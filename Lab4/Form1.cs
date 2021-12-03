using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gl = pictureBox1.CreateGraphics();
        }

        private static Graphics gl;

        private void drawFractalButton_Click(object sender, EventArgs e)
        {
            gl.Clear(Form1.DefaultBackColor);
            var n = Parse(depthBox.Text);
            var pen = new Pen(Color.Black);

            var start = new PointF(pictureBox1.Size.Width / 8, pictureBox1.Size.Height / 2);
            var end = new PointF(pictureBox1.Size.Width - pictureBox1.Size.Width / 8, pictureBox1.Size.Height / 2);
            DrawCurve(start, end, n, pen);
        }

        private static int Parse(string field)
        {
            try { return int.Parse(field); }
            catch
            {
                MessageBox.Show($"Failed reading a param! Param should be an integer.", "Error reading param");
            }
            return 0;
        }

        private static float fact;

        private static void DrawCurve(PointF start, PointF end, int depth, Pen pen)
        {
            if (depth == 0)
            {
                gl.DrawLine(pen, start, end);
                return;
            }
            var x = new float[9];
            var y = new float[9];
            x[0] = start.X;
            y[0] = start.Y;
            x[8] = end.X;
            y[8] = end.Y;

            float d;

            if (start.Y == end.Y)
            {
                d = (end.X - start.X) / 4;
                x[1] = x[2] = x[0] + d;
                x[3] = x[4] = x[5] = x[2] + d;
                x[6] = x[7] = x[3] + d;
                y[1] = y[4] = y[7] = y[0];
                y[2] = y[3] = y[0] - d;
                y[5] = y[6] = y[0] + d;
            }
            else
            {
                d = (end.Y - start.Y) / 4;
                y[1] = y[2] = y[0] + d;
                y[3] = y[4] = y[5] = y[2] + d;
                y[6] = y[7] = y[3] + d;
                x[1] = x[4] = x[7] = x[0];
                x[2] = x[3] = x[0] - d;
                x[5] = x[6] = x[0] + d;
            }

            for (int i = 0; i < 8; i++)
                DrawCurve(new PointF(x[i], y[i]), new PointF(x[i + 1], y[i + 1]), depth - 1, pen);
        }
    }
}
