using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;

namespace grafica
{
    public class Fractal : Figure3D
    {
        public Fractal(Vector3 start, int n)
        {
            this.Surfaces = new List<Surface>();
            List<Vector3> points = new List<Vector3>();
            points.Add(start);

            for (int i = 0; i < n; i++)
            {
                var last = points.Last();
                //var theta = Math.Asin(start.Z / r);
                //var phi = Math.Atan(start.Y, start.X);
                //var point = last * new Vector3((float)(Math.Cos(theta) * Math.Cos(phi)), (float)(Math.Cos(theta) * Math.Sin(phi)), (float)Math.Sin(theta));

                //points.Add(point);
            }
            Surfaces.Add(new Surface(points));
        }

        private Vector3 Pow(Vector3 vector, int pow)
        {
            return new Vector3((float)Math.Pow(vector.X, pow), (float)Math.Pow(vector.Y, pow), (float)Math.Pow(vector.Z, pow));
        }
    }
}
