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
                Name = name;
                var n = 30;

                double x, y, z;

                for (var i = 0; i < n; i++)
                {
                    var surface = new Polygon();
                    for (var j = 0; j <= n; j++)
                    {
                        for (var k = 0; k <= 1; k++)
                        {
                            x = r * Math.Sin(i * Math.PI / n) * Math.Cos(2 * j * Math.PI / n);
                            y = r * Math.Sin(i * Math.PI / n) * Math.Sin(2 * j * Math.PI / n);
                            z = r * Math.Cos(i * Math.PI / n);

                            surface.Vertexes.Add(new Vector3((float)x, (float)y, (float)z));

                            x = r * Math.Sin((i + 1) * Math.PI / n) * Math.Cos(2 * j * Math.PI / n);
                            y = r * Math.Sin((i + 1) * Math.PI / n) * Math.Sin(2 * j * Math.PI / n);
                            z = r * Math.Cos((i + 1) * Math.PI / n);

                            surface.Vertexes.Add(new Vector3((float)x, (float)y, (float)z));
                        }
                    }
                    AddPolygon(surface);
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
                    Name = name;
                    if (R < r) R = 1.1f * r;
                    int n = 30;

                    double x, y, z, w = 0.0f;
                    while (w < 2 * Math.PI + (2 * Math.PI / n))
                    {
                        var surface = new Polygon();
                        double v = 0.0f;
                        while (v < 2 * Math.PI + (2 * Math.PI / n))
                        {
                            z = r * Math.Sin(v);
                            x = (R + r * Math.Cos(v)) * Math.Cos(w);
                            y = (R + r * Math.Cos(v)) * Math.Sin(w);

                            surface.Vertexes.Add(new Vector3((float)x, (float)y, (float)z));

                            z = r * Math.Sin(v + 2 * Math.PI / n);
                            x = (R + r * Math.Cos(v + 2 * Math.PI / n)) * Math.Cos(w + 2 * Math.PI / n);
                            y = (R + r * Math.Cos(v + 2 * Math.PI / n)) * Math.Sin(w + 2 * Math.PI / n);

                            surface.Vertexes.Add(new Vector3((float)x, (float)y, (float)z));
                            v += 2 * Math.PI / n;
                        }
                        w += 2 * Math.PI / n;
                        AddPolygon(surface);
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
