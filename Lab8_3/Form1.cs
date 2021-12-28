using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_OnLoad(object sender, EventArgs e)
        {
            var scene = new Scene("base", new Vector3(2));
            scene.Objects.Add(new Sphere(new Vector3(0, -10004, -20), 10000, new Vector3(0.2f, 0.2f, 0.2f), Vector3.Zero, 0, 0));
            //red ball
            scene.Objects.Add(new Sphere(new Vector3(0, 0, -20), 4, new Vector3(1, 0.32f, 0.36f), Vector3.Zero, 1, 0.36f));
            //green metall ball
            scene.Objects.Add(new Sphere(new Vector3(6, -2, -20), 2, new Vector3(0.5f, 0.5f, 0.36f), new Vector3(0.2f, 0.2f, 0.2f), 0, 0.5f));
            //blue diffuse ball
            scene.Objects.Add(new Sphere(new Vector3(-4, -2, -15), 2, new Vector3(0.5f, 0.5f, 1f), new Vector3(0.2f, 0.2f, 0.2f), 0, 0f));
            //blue diffuse ball
            scene.Objects.Add(new Sphere(new Vector3(0, -4, -15), 1, new Vector3(0f, 0f, 1f), new Vector3(0.2f, 0.2f, 0.2f), 0, 0f));
            //blue diffuse ball
            scene.Objects.Add(new Sphere(new Vector3(2, -4, -15), 1, new Vector3(0f, 0f, 1f), new Vector3(0.2f, 0.2f, 0.2f), 0, 0f));
            //light
            scene.Objects.Add(new Sphere(new Vector3(5, 5, -10), 2, new Vector3(0.5f, 1, 0.5f), new Vector3(1, 1, 1), 1, 0.3f));
            pictureBox1.Image = Render(scene, pictureBox1.Size, 0);
        }

        public Bitmap Render(Scene scene, Size size, int depth)
        {
            var random = new Random(1);
            var bmp = new Bitmap(size.Width, size.Height);
            Vector3[,] image = new Vector3[size.Width, size.Height];
            float invWidth = 1 / (float)size.Width, invHeight = 1 / (float)size.Height;
            float fov = 30, aspectratio = size.Width / (float)size.Height;
            float angle = (float)Math.Tan(Math.PI * 0.5 * fov / 180.0f);
            // Trace rays
            for (int y = 0; y < size.Height; ++y)
            {
                for (int x = 0; x < size.Width; ++x)
                {
                    float xx = (float)(2 * ((x + random.NextDouble()) * invWidth) - 1) * angle * aspectratio;
                    float yy = (float)(1 - 2 * ((y + random.NextDouble()) * invHeight)) * angle;
                    var ray = new Ray(Vector3.Zero, Vector3.Normalize(new Vector3(xx, yy, -1)));
                    image[x, y] = ray.Trace(scene, depth);
                    bmp.SetPixel(x, y, image[x, y].ToColor());
                }
            }

            //var bmp = new Bitmap(size.Width, size.Height);
            //for (int y = 0; y < size.Height; ++y)
            //    for (int x = 0; x < size.Width; ++x)
            //        bmp.SetPixel(x, y, GammaCorrection(image[x, y].ToColor(), 2.0f));
            return bmp;
        }
    }
}
