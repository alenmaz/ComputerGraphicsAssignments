using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;

namespace grafica
{
    class Surface
    {
        public List<Vector3> points = new List<Vector3>();

        public Surface() { }
        public Surface(List<Vector3> points)
        {
            this.points = points;
        }
    }

    public abstract class Figure3D
    {
        private List<Surface> surfaces;

        internal List<Surface> Surfaces { get => surfaces; set => surfaces = value; }

        public virtual void Draw(BeginMode beginMode)
        {
            var colors = new List<Color>(new[] { Color.Pink, Color.Yellow, Color.Blue, Color.Red, Color.Green, Color.DarkBlue });
            var coll = typeof(Color).GetProperties(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.DeclaredOnly).Select(i => i.GetValue(null)).Cast<Color>();
            var en = coll.GetEnumerator();
            en.MoveNext();
            foreach (var surface in Surfaces)
            {
                GL.Begin(beginMode);
                var currentColor = en.Current;
                foreach (var point in surface.points)
                {
                    GL.Color3(currentColor);
                    GL.Vertex3(point);
                }
                en.MoveNext();
                GL.End();
            }
        }
    }

    class Cuboid : Figure3D
    {
        public Cuboid(Vector3 start, float sizeX, float sizeY, float sizeZ)
        {
            Surfaces = new List<Surface>();
            Surfaces.Add(new Surface(new List<Vector3>(new[] { 
                start, 
                new Vector3(start.X + sizeX, start.Y, start.Z),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z),
                new Vector3(start.X, start.Y + sizeY, start.Z)
            })));

            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                start,
                new Vector3(start.X + sizeX, start.Y, start.Z),
                new Vector3(start.X + sizeX, start.Y, start.Z + sizeZ),
                new Vector3(start.X, start.Y, start.Z + sizeZ)
            })));

            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                start,
                new Vector3(start.X, start.Y, start.Z + sizeZ),
                new Vector3(start.X, start.Y + sizeY, start.Z + sizeZ),
                new Vector3(start.X, start.Y + sizeY, start.Z)
            })));

            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                new Vector3(start.X, start.Y + sizeY, start.Z),
                new Vector3(start.X, start.Y + sizeY, start.Z + sizeZ),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z + sizeZ),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z)
            })));

            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                new Vector3(start.X + sizeX, start.Y, start.Z),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z + sizeZ),
                new Vector3(start.X + sizeX, start.Y, start.Z + sizeZ)
            })));

            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                new Vector3(start.X, start.Y, start.Z + sizeZ),
                new Vector3(start.X + sizeX, start.Y, start.Z + sizeZ),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z + sizeZ),
                new Vector3(start.X, start.Y + sizeY, start.Z + sizeZ)
            })));
        }
    }

    class Pyramid : Figure3D
    {
        public Pyramid(Vector3 start, float sizeX, float sizeY, float height)
        {
            Surfaces = new List<Surface>();
            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                start,
                new Vector3(start.X + sizeX, start.Y, start.Z),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z),
            })));

            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z),
                new Vector3(start.X, start.Y + sizeY, start.Z),
                start
            })));

            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                start,
                new Vector3(start.X, start.Y + sizeY, start.Z),
                new Vector3(start.X + sizeX / 2, start.Y + sizeY / 2, start.Z + height)
            })));

            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                start,
                new Vector3(start.X + sizeX, start.Y, start.Z),
                new Vector3(start.X + sizeX / 2, start.Y + sizeY / 2, start.Z + height)
            })));

            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                new Vector3(start.X + sizeX, start.Y, start.Z),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z),
                new Vector3(start.X + sizeX / 2, start.Y + sizeY / 2, start.Z + height)
            })));

            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z),
                new Vector3(start.X, start.Y + sizeY, start.Z),
                new Vector3(start.X + sizeX / 2, start.Y + sizeY / 2, start.Z + height)
            })));
        }
    }

    class Trapezoid : Figure3D
    {
        public Trapezoid(Vector3 start, float sizeX, float sizeY, float sizeZ, float delta)
        {
            Surfaces = new List<Surface>();
            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                start,
                new Vector3(start.X + sizeX, start.Y, start.Z),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z),
                new Vector3(start.X, start.Y + sizeY, start.Z)
            })));

            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                new Vector3(start.X + delta, start.Y + delta, start.Z + sizeZ),
                new Vector3(start.X + delta, start.Y + sizeY - delta, start.Z + sizeZ),
                new Vector3(start.X + sizeX - delta, start.Y + sizeY - delta, start.Z + sizeZ),
                new Vector3(start.X + sizeX - delta, start.Y + delta, start.Z + sizeZ)
            })));

            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                start,
                new Vector3(start.X + sizeX, start.Y, start.Z),
                new Vector3(start.X + sizeX - delta, start.Y + delta, start.Z + sizeZ),
                new Vector3(start.X + delta, start.Y + delta, start.Z + sizeZ)
            })));

            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                start,
                new Vector3(start.X, start.Y + sizeY, start.Z),
                new Vector3(start.X + delta, start.Y + sizeY - delta, start.Z + sizeZ),
                new Vector3(start.X + delta, start.Y + delta, start.Z + sizeZ)
            })));

            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                new Vector3(start.X + sizeX, start.Y, start.Z),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z),
                new Vector3(start.X + sizeX - delta, start.Y + sizeY - delta, start.Z + sizeZ),
                new Vector3(start.X + sizeX - delta, start.Y + delta, start.Z + sizeZ)
            })));

            Surfaces.Add(new Surface(new List<Vector3>(new[] {
                new Vector3(start.X, start.Y + sizeY, start.Z),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z),
                new Vector3(start.X + sizeX - delta, start.Y + sizeY - delta, start.Z + sizeZ),
                new Vector3(start.X + delta, start.Y + sizeY - delta, start.Z + sizeZ)
            })));
        }
    }

    class Octathedron : Figure3D
    {
        public Octathedron(Vector3 center, float radiusUp, float radiusSide)
        {
            Surfaces = new List<Surface>();
            Surfaces.Add(new Surface(new List<Vector3> { new Vector3(center.X + radiusSide, center.Y - radiusSide, center.Z),
                                                         new Vector3(center.X + radiusSide, center.Y + radiusSide, center.Z),
                                                         new Vector3(center.X, center.Y, center.Z + radiusUp)}));
            Surfaces.Add(new Surface(new List<Vector3> { new Vector3(center.X + radiusSide, center.Y + radiusSide, center.Z),
                                                         new Vector3(center.X - radiusSide, center.Y + radiusSide, center.Z),
                                                         new Vector3(center.X, center.Y, center.Z + radiusUp)}));
            Surfaces.Add(new Surface(new List<Vector3> { new Vector3(center.X - radiusSide, center.Y + radiusSide, center.Z),
                                                         new Vector3(center.X - radiusSide, center.Y - radiusSide, center.Z),
                                                         new Vector3(center.X, center.Y, center.Z + radiusUp)}));
            Surfaces.Add(new Surface(new List<Vector3> { new Vector3(center.X - radiusSide, center.Y - radiusSide, center.Z),
                                                         new Vector3(center.X + radiusSide, center.Y - radiusSide, center.Z),
                                                         new Vector3(center.X, center.Y, center.Z + radiusUp)}));

            Surfaces.Add(new Surface(new List<Vector3> { new Vector3(center.X + radiusSide, center.Y - radiusSide, center.Z),
                                                         new Vector3(center.X + radiusSide, center.Y + radiusSide, center.Z),
                                                         new Vector3(center.X, center.Y, center.Z - radiusUp)}));
            Surfaces.Add(new Surface(new List<Vector3> { new Vector3(center.X + radiusSide, center.Y + radiusSide, center.Z),
                                                         new Vector3(center.X - radiusSide, center.Y + radiusSide, center.Z),
                                                         new Vector3(center.X, center.Y, center.Z - radiusUp)}));
            Surfaces.Add(new Surface(new List<Vector3> { new Vector3(center.X - radiusSide, center.Y + radiusSide, center.Z),
                                                         new Vector3(center.X - radiusSide, center.Y - radiusSide, center.Z),
                                                         new Vector3(center.X, center.Y, center.Z - radiusUp)}));
            Surfaces.Add(new Surface(new List<Vector3> { new Vector3(center.X - radiusSide, center.Y - radiusSide, center.Z),
                                                         new Vector3(center.X + radiusSide, center.Y - radiusSide, center.Z),
                                                         new Vector3(center.X, center.Y, center.Z - radiusUp)}));
        }
    }

    class Conus : Figure3D
    {
        public Conus(Vector3 start, int n, float radius, float height)
        {
            Surfaces = new List<Surface>();
            var angle = (float)Math.PI * 2 / n;
            //creating bottom surface of conus
            var bottomSurface = new Surface(Enumerable.Range(0, n)
                .Select(i => GetVector(start, i, radius, angle))
                .ToList());
            bottomSurface.points.Add(bottomSurface.points.First());
            Surfaces.Add(bottomSurface);

            //creating side surfaces of conus
            var tip = new Vector3(start.X, start.Y, start.Z + height);
            for(int i = 0; i < bottomSurface.points.Count - 1; i++)
                Surfaces.Add(new Surface(new List<Vector3>{ bottomSurface.points[i], bottomSurface.points[i + 1], tip }));
            Surfaces.Add(new Surface(new List<Vector3> { bottomSurface.points[bottomSurface.points.Count - 1], bottomSurface.points[0], tip}));
        }

        private static Vector3 GetVector(Vector3 center, int i, float r, float angle)
        {
            var vec = new Vector3(center.X, center.Y, center.Z);
            var inc = new Vector3((float)Math.Sin(i * angle) * r, (float)Math.Cos(i * angle) * r, 0);
            return Vector3.Add(vec, inc);
        }
    }

    class Cylinder : Figure3D
    {
        public Cylinder(Vector3 start, float radius, float height)
        {
            var num = 50;
            Surfaces = new List<Surface>();
            var angle = Math.PI * 2 / num;
            var upperpoints = Enumerable.Range(0, num).Select(i =>
                    Vector3.Add(start, new Vector3((float)Math.Sin(i * angle) * radius, (float)Math.Cos(i * angle) * radius, start.Z)))
                    .ToList();
            var lowerPoints = Enumerable.Range(0, num).Select(i =>
                    Vector3.Add(start, new Vector3((float)Math.Sin(i * angle) * radius, (float)Math.Cos(i * angle) * radius, start.Z + height)))
                    .ToList();
            Surfaces.Add(new Surface(upperpoints));
            for (int i = 0; i < num - 1; i++)
                Surfaces.Add(new Surface(new List<Vector3> {
                    upperpoints[i],
                    upperpoints[i + 1],
                    lowerPoints[i + 1],
                    lowerPoints[i]
                }));
            Surfaces.Add(new Surface(new List<Vector3> {
                upperpoints[num - 1],
                upperpoints[0],
                lowerPoints[0],
                lowerPoints[num - 1]
            }));

            Surfaces.Add(new Surface(lowerPoints));
        }
    }

    class Torus : Figure3D
    {
        public Torus(Vector3 start, float r, float iR)
        {
            Surfaces = new List<Surface>();
            var points = new List<Vector3>();
            if (iR < r) iR = 1.1f * r;
            int n = 30;

            double x, y, z, w = 0.0f;
            while(w < 2 * Math.PI + (2 * Math.PI / n))
            {
                var surface = new Surface();
                double v = 0.0f;
                while(v < 2 * Math.PI + (2 * Math.PI / n))
                {
                    z =  r * Math.Sin(v);
                    x = (iR + r * Math.Cos(v)) * Math.Cos(w);
                    y = (iR + r * Math.Cos(v)) * Math.Sin(w);

                    surface.points.Add(new Vector3((float)x, (float)y, (float)z));

                    z = r * Math.Sin(v + 2 * Math.PI / n);
                    x = (iR + r * Math.Cos(v + 2 * Math.PI / n)) * Math.Cos(w + 2 * Math.PI / n);
                    y = (iR + r * Math.Cos(v + 2 * Math.PI / n)) * Math.Sin(w + 2 * Math.PI / n);

                    surface.points.Add(new Vector3((float)x, (float)y, (float)z));
                    v += 2 * Math.PI / n;
                }
                w += 2 * Math.PI / n;
                Surfaces.Add(surface);
            }
        }
    }

    class Sphere : Figure3D
    {
        public Sphere(Vector3 start, float r)
        {
            Surfaces = new List<Surface>();
            var n = 30;

            double x, y, z;

            for (var i = 0; i < n; i++)
            {
                var surface = new Surface();
                for (var j = 0; j <= n; j++)
                {
                    for (var k = 0; k <= 1; k++)
                    {
                        x = r * Math.Sin(i * Math.PI / n) * Math.Cos(2 * j * Math.PI / n);
                        y = r * Math.Sin(i * Math.PI / n) * Math.Sin(2 * j * Math.PI / n);
                        z = r * Math.Cos(i * Math.PI / n);

                        surface.points.Add(new Vector3((float)x, (float)y, (float)z));

                        x = r * Math.Sin((i + 1) * Math.PI / n) * Math.Cos(2 * j * Math.PI / n);
                        y = r * Math.Sin((i + 1) * Math.PI / n) * Math.Sin(2 * j * Math.PI / n);
                        z = r * Math.Cos((i + 1) * Math.PI / n);

                        surface.points.Add(new Vector3((float)x, (float)y, (float)z));
                    }
                }
                Surfaces.Add(surface);
            }
        }
    }

    class Spiral : Figure3D
    {
        public Spiral(Vector3 start, float radius, float lengthOfSpiral, int numOfCircles, int smoothness)
        {
            Surfaces = new List<Surface>();
            var points = new List<Vector3>();
            for(int j = 0; j < numOfCircles; j++)
                for(int i = 0; i < smoothness; i++)
                {
                    points.Add(new Vector3(start.X + radius * (float)Math.Cos((i * Math.PI * 2) / smoothness), start.Y + radius * (float)Math.Sin((i * Math.PI * 2) / smoothness), start.Z + lengthOfSpiral));
                    lengthOfSpiral -= 1f;
                    points.Add(new Vector3(start.X + radius * (float)Math.Cos(((i + 1) * Math.PI * 2) / smoothness), start.Y + radius * (float)Math.Sin(((i + 1) * Math.PI * 2) / smoothness), start.Z + lengthOfSpiral));
                }
            Surfaces.Add(new Surface(points));
        }
    }
}
