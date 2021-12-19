using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;

using Lab7.Entities.Base;

namespace Lab7.Entities.Objects
{
    public static class Primitives
    {
        public class Cube : Object3D
        {
            public Cube(string name, Vector3 start, float sizeX, float sizeY, float sizeZ) : base()
            {
                Name = name;
                AddPolygon(new Polygon(new List<Vector3>(new[] {
                start,
                new Vector3(start.X + sizeX, start.Y, start.Z),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z),
                new Vector3(start.X, start.Y + sizeY, start.Z)
                })));

                AddPolygon(new Polygon(new List<Vector3>(new[] {
                start,
                new Vector3(start.X + sizeX, start.Y, start.Z),
                new Vector3(start.X + sizeX, start.Y, start.Z + sizeZ),
                new Vector3(start.X, start.Y, start.Z + sizeZ)
                })));

                AddPolygon(new Polygon(new List<Vector3>(new[] {
                start,
                new Vector3(start.X, start.Y, start.Z + sizeZ),
                new Vector3(start.X, start.Y + sizeY, start.Z + sizeZ),
                new Vector3(start.X, start.Y + sizeY, start.Z)
                })));

                AddPolygon(new Polygon(new List<Vector3>(new[] {
                new Vector3(start.X, start.Y + sizeY, start.Z),
                new Vector3(start.X, start.Y + sizeY, start.Z + sizeZ),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z + sizeZ),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z)
                })));

                AddPolygon(new Polygon(new List<Vector3>(new[] {
                new Vector3(start.X + sizeX, start.Y, start.Z),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z + sizeZ),
                new Vector3(start.X + sizeX, start.Y, start.Z + sizeZ)
                })));

                AddPolygon(new Polygon(new List<Vector3>(new[] {
                new Vector3(start.X, start.Y, start.Z + sizeZ),
                new Vector3(start.X + sizeX, start.Y, start.Z + sizeZ),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z + sizeZ),
                new Vector3(start.X, start.Y + sizeY, start.Z + sizeZ)
                })));
            }
        }

        public class Cylinder : Object3D
        {
            public Cylinder(string name, Vector3 start, float radius, float height)
            {
                Name = name;
                var num = 50;
                var angle = Math.PI * 2 / num;
                var upperpoints = Enumerable.Range(0, num).Select(i =>
                        Vector3.Add(start, new Vector3((float)Math.Sin(i * angle) * radius, (float)Math.Cos(i * angle) * radius, start.Z + height)))
                        .ToList();
                var lowerPoints = Enumerable.Range(0, num).Select(i =>
                        Vector3.Add(start, new Vector3((float)Math.Sin(i * angle) * radius, (float)Math.Cos(i * angle) * radius, start.Z)))
                        .ToList();
                AddPolygon(new Polygon(upperpoints));
                for (int i = 0; i < num - 1; i++)
                    AddPolygon(new Polygon(new List<Vector3> {
                    upperpoints[i],
                    upperpoints[i + 1],
                    lowerPoints[i + 1],
                    lowerPoints[i]
                }));
                AddPolygon(new Polygon(new List<Vector3> {
                upperpoints[num - 1],
                upperpoints[0],
                lowerPoints[0],
                lowerPoints[num - 1]
                }));

                AddPolygon(new Polygon(lowerPoints));
            }
        }

        public class Sphere : Object3D
        {
            public Sphere(string name, Vector3 start, float r)
            {
                var n = 30;
                float x, y, z;
                var polygon = new Polygon();
                for (var i = 0; i < n; ++i)
                {
                    for (var j = 0; j <= n; ++j)
                    {
                        x = (float)(r * Math.Sin(i * Math.PI / n) * Math.Cos(2 * j * Math.PI / n));
                        y = (float)(r * Math.Sin(i * Math.PI / n) * Math.Sin(2 * j * Math.PI / n));
                        z = (float)(r * Math.Cos(i * Math.PI / n));
                        polygon.Vertexes.Add(new Vector3(x, y, z));

                        x = (float)(r * Math.Sin((i + 1) * Math.PI / n) * Math.Cos(2 * j * Math.PI / n));
                        y = (float)(r * Math.Sin((i + 1) * Math.PI / n) * Math.Sin(2 * j * Math.PI / n));
                        z = (float)(r * Math.Cos((i + 1) * Math.PI / n));
                        polygon.Vertexes.Add(new Vector3(x, y, z));
                    }
                    AddPolygon(polygon);
                    polygon = new Polygon();
                }
            }
        }

        public class Pyramid : Object3D
        {
            public Pyramid(string name, Vector3 start, float sizeX, float sizeY, float height)
            {
                Name = name;
                AddPolygon(new Polygon(new List<Vector3>(new[] {
                start,
                new Vector3(start.X + sizeX, start.Y, start.Z),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z),
                })));

                AddPolygon(new Polygon(new List<Vector3>(new[] {
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z),
                new Vector3(start.X, start.Y + sizeY, start.Z),
                start
                })));

                AddPolygon(new Polygon(new List<Vector3>(new[] {
                start,
                new Vector3(start.X, start.Y + sizeY, start.Z),
                new Vector3(start.X + sizeX / 2, start.Y + sizeY / 2, start.Z + height)
                })));

                AddPolygon(new Polygon(new List<Vector3>(new[] {
                start,
                new Vector3(start.X + sizeX, start.Y, start.Z),
                new Vector3(start.X + sizeX / 2, start.Y + sizeY / 2, start.Z + height)
                })));

                AddPolygon(new Polygon(new List<Vector3>(new[] {
                new Vector3(start.X + sizeX, start.Y, start.Z),
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z),
                new Vector3(start.X + sizeX / 2, start.Y + sizeY / 2, start.Z + height)
                })));

                AddPolygon(new Polygon(new List<Vector3>(new[] {
                new Vector3(start.X + sizeX, start.Y + sizeY, start.Z),
                new Vector3(start.X, start.Y + sizeY, start.Z),
                new Vector3(start.X + sizeX / 2, start.Y + sizeY / 2, start.Z + height)
                })));
            }
        }

        public class Torus : Object3D
        {
            public Torus(string name, Vector3 start, float r, float R)
            {
                int N = 30;
                int n = 30;
                double w = 0.0f;
                Name = name;
                float x, y, z;
                var polygon = new Polygon();

                while (w < 2 * Math.PI + (2 * Math.PI / N))
                {
                    double v = 0.0f;
                    while (v < 2 * Math.PI + (2 * Math.PI / n))
                    {
                        y = (float)((R + r * Math.Cos(v)) * Math.Cos(w));
                        z = (float)((R + r * Math.Cos(v)) * Math.Sin(w));
                        x = (float)(r * Math.Sin(v));
                        polygon.Vertexes.Add(new Vector3(x, y, z));

                        y = (float)((R + r * Math.Cos(v + 2 * Math.PI / n)) * Math.Cos(w + 2 * Math.PI / N));
                        z = (float)((R + r * Math.Cos(v + 2 * Math.PI / n)) * Math.Sin(w + 2 * Math.PI / N));
                        x = (float)(r * Math.Sin(v + 2 * Math.PI / n));
                        polygon.Vertexes.Add(new Vector3(x, y, z));

                        v += 2 * Math.PI / n;
                    }
                    AddPolygon(polygon);
                    polygon = new Polygon();
                    w += 2 * Math.PI / N;
                }
            }
        }

        public class Conus : Object3D
        {
            public Conus(string name, Vector3 start, int n, float radius, float height)
            {
                Name = name;
                var angle = (float)Math.PI * 2 / n;
                var bottomSurface = new Polygon(Enumerable.Range(0, n)
                    .Select(i => GetVector(start, i, radius, angle))
                    .ToList());
                bottomSurface.Vertexes.Add(bottomSurface.Vertexes.First());
                AddPolygon(bottomSurface);

                var tip = new Vector3(start.X, start.Y, start.Z + height);
                for (int i = 0; i < bottomSurface.Vertexes.Count - 1; i++)
                    AddPolygon(new Polygon(new List<Vector3> { bottomSurface.Vertexes[i], bottomSurface.Vertexes[i + 1], tip }));
                AddPolygon(new Polygon(new List<Vector3> { bottomSurface.Vertexes[bottomSurface.Vertexes.Count - 1], bottomSurface.Vertexes[0], tip }));
            }

            private static Vector3 GetVector(Vector3 center, int i, float r, float angle)
            {
                var vec = new Vector3(center.X, center.Y, center.Z);
                var inc = new Vector3((float)Math.Sin(i * angle) * r, (float)Math.Cos(i * angle) * r, 0);
                return Vector3.Add(vec, inc);
            }
        }
    }
}
