﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;

using Lab7.Entities.Base;
using Lab7.Entities.Objects;
using Lab7.Parsesrs;

namespace Lab7
{
    public partial class ModelViewer : Form
    {
        public ModelViewer()
        {
            InitializeComponent();
        }

        public Storage Storage;
        private int zoom = 10;
        private int frequencyOfUpdate = 20;
        private Vector4 backgroundColor = new Vector4(0.5f, 0.5f, 0.5f, 0.0f);

        private void SetupViewport(GLControl glControl)
        {
            float aspectRatio = (float)glControl.Width / (float)glControl.Height;
            GL.Viewport(0, 0, glControl.Width, glControl.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4,
                                                                       aspectRatio,
                                                                       1f,
                                                                       5000000000);
            GL.MultMatrix(ref perspective);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
        }

        bool loaded = false;

        private void ModelViewer_Load(object sender, EventArgs e)
        {
            Storage = new Storage();
            loaded = true;
            SetupViewport(glControl1);
            Timer timer = new Timer();
            timer.Interval = (frequencyOfUpdate);
            timer.Tick += new EventHandler(Update);
            timer.Start();

            Storage.GetLights().Add(new Light("base", new Vector3(1.0f, 1.0f, 1.0f), new Vector3(5.0f, 0.0f, 0.0f)));

            objComboBox.Items.Add("None");
            objComboBox.SelectedIndex = 0;

            Storage.AddMaterial(Material.Default);
            mComboBox.Items.Add(Material.Default.Name);
            mComboBox.SelectedIndex = 0;

            textureComboBox.Items.Add("None");
            textureComboBox.SelectedIndex = 0;

            lightComboBox.Items.Add("None");
            lightComboBox.Items.Add("base");
            lightComboBox.SelectedIndex = 0;
        }

        private void Update(object sender, EventArgs e)
        {
            glControl1.Invalidate();
            foreach (var l in Storage.GetLights())
                if(!lightComboBox.Items.Contains(l.Name)) lightComboBox.Items.Add(l.Name);
            var obj2 = Storage.GetObjects().Find(o => o.Name == objComboBox.SelectedItem.ToString());
            if (obj2 != null)
            {
                var mat2 = Storage.GetMaterials().Find(m => m.Name == mComboBox.SelectedItem.ToString());
                if (mat2 != null) obj2.Material = mat2;
                var tex2 = Storage.GetTextures().Find(t => t.Name == textureComboBox.SelectedItem.ToString());
                if (tex2 != null) obj2.Texture = tex2;
            }
        }

        private void glControl1_Zoom(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {

            if (!loaded)
                return;

            GL.ClearColor(backgroundColor.X, backgroundColor.Y, backgroundColor.Z, backgroundColor.W);//цвет фона 
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.Texture2D);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            var viewPos = new Vector3(zoom, zoom, zoom);
            Matrix4 modelview = Matrix4.LookAt
              (viewPos, new Vector3(0, 0, 0), new Vector3(0, 0, 1));

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);

            if ((Control.MouseButtons & MouseButtons.Left) != 0)
            {
                var cursor = Control.MousePosition;
                GL.Rotate(cursor.X % 360, 1, 0, 0);
                GL.Rotate(cursor.Y % 360, 0, 0, 1);
            }
            GL.ShadeModel(ShadingModel.Smooth);

            DrawAxis(new Vector3(1.0f, 1.0f, 0.0f), new Vector3(1.0f, 0.0f, 0.0f), new Vector3(0.2f, 0.9f, 1.0f));
            if (drawAllCheckBox.Checked) DrawAll(viewPos);
            else DrawObject(viewPos);

            glControl1.SwapBuffers();
        }

        private void DrawObject(Vector3 viewPos)
        {
            var normal = new Vector3(1, 1, 1);

            var selected = objComboBox.SelectedItem.ToString();
            if (!selected.Equals("None"))
            {
                var obj2 = Storage.GetObjects().Find(o => o.Name == objComboBox.SelectedItem.ToString());
                var mat2 = Storage.GetMaterials().Find(m => m.Name == mComboBox.SelectedItem.ToString());
                var tex2 = Storage.GetTextures().Find(t => t.Name == textureComboBox.SelectedItem.ToString());
                var light = Storage.GetLights().Find(l => l.Name == lightComboBox.SelectedItem.ToString());

                if (obj2 != null) 
                    obj2.Draw(mat2 is null ? obj2.Material : mat2, 
                        tex2 is null ? obj2.Texture : tex2, 
                        light is null ? Storage.GetLights().Find(l => l.Name == "base") : light, 
                        viewPos);
            }
        }

        private void DrawAll(Vector3 viewPos)
        {
            var light = Storage.GetLights().Find(l => l.Name == lightComboBox.SelectedItem.ToString());
            foreach (var obj in Storage.GetObjects())
                obj.Draw(obj.Material,obj.Texture, light is null ? Storage.GetLights().Find(l => l.Name == "base") : light, viewPos);
        }

        private static void DrawAxis(Vector3 clr1, Vector3 clr2, Vector3 clr3)
        {
            GL.Begin(BeginMode.Lines);
            GL.Color3(clr1);
            GL.Vertex3(-300.0f, 0.0f, 0.0f);
            GL.Vertex3(300.0f, 0.0f, 0.0f);
            GL.End();

            GL.Begin(BeginMode.Lines);
            GL.Color3(clr2);
            GL.Vertex3(0.0f, -300.0f, 0.0f);
            GL.Vertex3(0.0f, 300.0f, 0.0f);
            GL.End();

            GL.Begin(BeginMode.Lines);
            GL.Color3(clr3);
            GL.Vertex3(0.0f, 0.0f, -300f);
            GL.Vertex3(0.0f, 0.0f, 300.0f);
            GL.End();
        }

        private void ZoomIn()
        {
            if (zoom + 1 < 100) zoom += 1;
        }

        private void ZoomOut()
        {
            if (zoom - 1 > 0) zoom -= 1;
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importobjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    foreach (var obj in ObjFormatParser.Parse(open.FileName)) Storage.AddObject(obj);
                    objComboBox.Items.AddRange(Storage.GetObjects().Select(i => i.Name).ToArray());
                }
            }
            catch
            {
                MessageBox.Show("Failed reading file from filepath!", "Error reading file.");
                return;
            }
        }

        private void importmtlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    foreach (var m in MtlFormatParser.Parse(open.FileName)) Storage.AddMaterial(m);
                    foreach(var a in Storage.GetMaterials().Select(i => i.Name).ToArray()) mComboBox.Items.Add(a);
                }
            }
            catch
            {
                MessageBox.Show("Failed reading file from filepath!", "Error reading file.");
                return;
            }
        }

        private void importImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    var texture = new Bitmap(open.FileName);
                    var fileName = Path.GetFileName(open.FileName);
                    Storage.AddTexture(new Texture(fileName, texture));
                    textureComboBox.Items.Add(fileName);
                }
            }
            catch
            {
                MessageBox.Show("Failed reading file from filepath!", "Error reading file.");
                return;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Storage = new Storage();
            objComboBox.Items.Clear();
            objComboBox.Items.Add("None");

            textureComboBox.Items.Clear();
            textureComboBox.Items.Add("None");

            mComboBox.Items.Clear();
            mComboBox.Items.Add("None");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse wheel - zoom in\\out, hold left click and drag - rotate object", "Help");
        }

        private void makeLightSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LightCreate(this).ShowDialog();
        }

        private void deleteLightSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lights = Storage.GetLights();
            if (lights.Count > 1)
            {
                var l = lights.Last();
                lights.Remove(l);
                lightComboBox.Items.Remove(l.Name);
                lightComboBox.SelectedIndex = 0;
            }
        }

        private Vector3 ParseStart()
        {
            var x = 0.0f;
            var y = 0.0f;
            var z = 0.0f;

            if(xTextBox.Text != null) 
                x = float.Parse(xTextBox.Text);
            if (yTextBox.Text != null)
                y = float.Parse(yTextBox.Text);
            if (zTextBox.Text != null)
                z = float.Parse(zTextBox.Text);

            return new Vector3(x,y,z);
        }

        private void cubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var start = ParseStart();
            var rcolor = 0.0f;
            var gcolor = 0.0f;
            var bcolor = 0.0f;
            if (RGBBox1.Text != null) rcolor = float.Parse(RGBBox1.Text);
            if (RGBBox2.Text != null) gcolor = float.Parse(RGBBox2.Text);
            if (RGBBox3.Text != null) bcolor = float.Parse(RGBBox3.Text);
            var color = new Vector3(rcolor, gcolor, bcolor);
            var sizeX = 1.0f;
            var sizeY = 1.0f;
            var sizeZ = 1.0f;
            if(sizeXBox != null) sizeX = float.Parse(sizeXBox.Text);
            if (sizeYBox != null) sizeY = float.Parse(sizeYBox.Text);
            if (sizeZBox != null) sizeZ = float.Parse(sizeZBox.Text);

            var cube = new Primitives.Cube("cube" + Storage.GetObjects().Count, start, sizeX, sizeY, sizeZ);
            cube.Material.DiffuseColor = color;
            Storage.AddObject(cube);
            objComboBox.Items.Add(cube.Name);
        }

        private void sphereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var start = ParseStart();
            var rcolor = 0.0f;
            var gcolor = 0.0f;
            var bcolor = 0.0f;
            if (RGBBox1.Text != null) rcolor = float.Parse(RGBBox1.Text);
            if (RGBBox2.Text != null) gcolor = float.Parse(RGBBox2.Text);
            if (RGBBox3.Text != null) bcolor = float.Parse(RGBBox3.Text);
            var color = new Vector3(rcolor, gcolor, bcolor);
            var r = 1.0f;
            if (rBox != null) r = float.Parse(rBox.Text);
            var sphere = new Primitives.Sphere("sphere" + Storage.GetObjects().Count, start, r);
            sphere.Material.DiffuseColor = color;
            Storage.AddObject(sphere);
            objComboBox.Items.Add(sphere);
        }

        private void pyramidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var start = ParseStart();
            var rcolor = 0.0f;
            var gcolor = 0.0f;
            var bcolor = 0.0f;
            if (RGBBox1.Text != null) rcolor = float.Parse(RGBBox1.Text);
            if (RGBBox2.Text != null) gcolor = float.Parse(RGBBox2.Text);
            if (RGBBox3.Text != null) bcolor = float.Parse(RGBBox3.Text);
            var color = new Vector3(rcolor, gcolor, bcolor);
            var sizeX = 1.0f;
            var sizeY = 1.0f;
            var sizeZ = 1.0f;
            if (sizeXBox != null) sizeX = float.Parse(sizeXBox.Text);
            if (sizeYBox != null) sizeY = float.Parse(sizeYBox.Text);
            if (sizeZBox != null) sizeZ = float.Parse(sizeZBox.Text);
            var pyramid = new Primitives.Pyramid("pyramid" + Storage.GetObjects().Count, start, sizeX, sizeY, sizeZ);
            pyramid.Material.DiffuseColor = color;
            Storage.AddObject(pyramid);
            objComboBox.Items.Add(pyramid.Name);
        }

        private void torusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var start = ParseStart();
            var rcolor = 0.0f;
            var gcolor = 0.0f;
            var bcolor = 0.0f;
            if (RGBBox1.Text != null) rcolor = float.Parse(RGBBox1.Text);
            if (RGBBox2.Text != null) gcolor = float.Parse(RGBBox2.Text);
            if (RGBBox3.Text != null) bcolor = float.Parse(RGBBox3.Text);
            var color = new Vector3(rcolor, gcolor, bcolor);
            var r = 1.0f;
            var R = 2.0f;
            if (rBox != null) r = float.Parse(rBox.Text);
            if (BigRBox != null) R = float.Parse(BigRBox.Text);
            var torus = new Primitives.Torus("torus" + Storage.GetObjects().Count, start, r, R);
            torus.Material.DiffuseColor = color;
            Storage.AddObject(torus);
            objComboBox.Items.Add(torus.Name);
        }

        private void conusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var start = ParseStart();
            var rcolor = 0.0f;
            var gcolor = 0.0f;
            var bcolor = 0.0f;
            if (RGBBox1.Text != null) rcolor = float.Parse(RGBBox1.Text);
            if (RGBBox2.Text != null) gcolor = float.Parse(RGBBox2.Text);
            if (RGBBox3.Text != null) bcolor = float.Parse(RGBBox3.Text);
            var color = new Vector3(rcolor, gcolor, bcolor);

            var r = 1.0f;
            if (rBox != null) r = float.Parse(rBox.Text);
            var sizeZ = 1.0f;
            if (sizeZBox != null) sizeZ = float.Parse(sizeZBox.Text);
            var conus = new Primitives.Conus("conus" + Storage.GetObjects().Count, start, 30, r, sizeZ);
            conus.Material.DiffuseColor = color;
            Storage.AddObject(conus);
            objComboBox.Items.Add(conus.Name);
        }

        private void cylinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var start = ParseStart();
            var rcolor = 0.0f;
            var gcolor = 0.0f;
            var bcolor = 0.0f;
            if (RGBBox1.Text != null) rcolor = float.Parse(RGBBox1.Text);
            if (RGBBox2.Text != null) gcolor = float.Parse(RGBBox2.Text);
            if (RGBBox3.Text != null) bcolor = float.Parse(RGBBox3.Text);
            var color = new Vector3(rcolor, gcolor, bcolor);

            var r = 1.0f;
            if (rBox != null) r = float.Parse(rBox.Text);
            var sizeZ = 1.0f;
            if (sizeZBox != null) sizeZ = float.Parse(sizeZBox.Text);
            var cylinder = new Primitives.Cylinder("cylinder" + Storage.GetObjects().Count, start, r, sizeZ);
            cylinder.Material.DiffuseColor = color;
            Storage.AddObject(cylinder);
            objComboBox.Items.Add(cylinder.Name);
        }
    }
}
