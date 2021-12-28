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
            scene.Objects.Add(new Sphere(new Vector3(0, -1, -20), 3, new Vector3(1, 0.32f, 0.36f), Vector3.Zero, 1f, 0.36f));
            //behind ball
            scene.Objects.Add(new Sphere(new Vector3(2, 0, -35), 4, new Vector3(1f, 1f, 1f), Vector3.Zero, 0, 0f));
            //green metall ball
            scene.Objects.Add(new Sphere(new Vector3(6, -2, -20), 2, new Vector3(0f, 0.7f, 0.5f), Vector3.Zero, 0, 0.5f));
            //blue diffuse ball
            scene.Objects.Add(new Sphere(new Vector3(-4, -2, -15), 2, new Vector3(1f, 0f, 1f), Vector3.Zero, 0, 0f));
            //blue diffuse ball
            scene.Objects.Add(new Sphere(new Vector3(0, -3, -15), 1, new Vector3(0f, 0f, 1f), Vector3.Zero, 0, 0f));
            //blue diffuse ball
            scene.Objects.Add(new Sphere(new Vector3(2, -3, -15), 1, new Vector3(0f, 0f, 1f), Vector3.Zero, 0, 0f));
            //light
            scene.Objects.Add(new Sphere(new Vector3(2, 4, 0), 2, new Vector3(1f, 1, 1f), new Vector3(1, 1, 1), 1, 0f));
            pictureBox1.Image = Render(scene, this.Size, 0);
        }

        private Bitmap Smooth(Bitmap image)
        {
            for(int i= 1; i < image.Width - 1; i++)
            {
                for(int j = 1; j < image.Height - 1; j++)
                {
                    var R = image.GetPixel(i - 1, j).R + 
                        image.GetPixel(i + 1, j).R + 
                        image.GetPixel(i, j - 1).R + 
                        image.GetPixel(i, j + 1).R +
                        image.GetPixel(i - 1, j - 1).R +
                        image.GetPixel(i - 1, j + 1).R +
                        image.GetPixel(i + 1, j - 1).R +
                        image.GetPixel(i - 1, j + 1).R;
                    var G = image.GetPixel(i - 1, j).G + 
                        image.GetPixel(i + 1, j).G +
                        image.GetPixel(i, j - 1).G +
                        image.GetPixel(i, j + 1).G +
                        image.GetPixel(i - 1, j - 1).G +
                        image.GetPixel(i - 1, j + 1).G +
                        image.GetPixel(i + 1, j - 1).G +
                        image.GetPixel(i - 1, j + 1).G;
                    var B = image.GetPixel(i - 1, j).B + 
                        image.GetPixel(i + 1, j).B + 
                        image.GetPixel(i, j - 1).B + 
                        image.GetPixel(i, j + 1).B +
                        image.GetPixel(i - 1, j - 1).B +
                        image.GetPixel(i - 1, j + 1).B +
                        image.GetPixel(i + 1, j - 1).B +
                        image.GetPixel(i - 1, j + 1).B;
                    image.SetPixel(i, j, Color.FromArgb(R/9, G/9, B/9));
                }
            }
            return image;
        }

        public Bitmap Render(Scene scene, Size size, int depth)
        {
            var random = new Random(1);
            var bmp = new Bitmap(size.Width, size.Height);
            Vector3[,] image = new Vector3[size.Width, size.Height];
            float invWidth = 1 / (float)size.Width, invHeight = 1 / (float)size.Height;
            float fov = 40, aspectratio = size.Width / (float)size.Height;
            float angle = (float)Math.Tan(Math.PI * 0.5 * fov / 180.0f);
            // Trace rays
            for (int y = 0; y < size.Height; ++y)
            {
                for (int x = 0; x < size.Width; ++x)
                {
                    float xx = (float)(2 * ((x + 0.5) * invWidth) - 1) * angle * aspectratio;
                    float yy = (float)(1 - 2 * ((y + 0.5) * invHeight)) * angle;
                    var ray = new Ray(Vector3.Zero, Vector3.Normalize(new Vector3(xx, yy, -1)));
                    image[x, y] = ray.Trace(scene, depth);
                    bmp.SetPixel(x, y, image[x, y].ToColor());
                }
            }

            //var bmp = new Bitmap(size.Width, size.Height);
            //for (int y = 0; y < size.Height; ++y)
            //    for (int x = 0; x < size.Width; ++x)
            //        bmp.SetPixel(x, y, GammaCorrection(image[x, y].ToColor(), 2.0f));
            return Smooth(bmp);
        }
    }
}
