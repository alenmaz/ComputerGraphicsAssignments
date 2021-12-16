using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;

using Lab7.Entities.Base;
using Lab7.Entities.Objects;

namespace Lab7.Parsesrs
{
    static class ObjFormatParser
    {
        public static List<Object3D> Parse(string filename)
        {
            var list = new List<Object3D>();
            Object3D model = null;
            List<Vector3> vertexes = new List<Vector3>();
            List<Vector2> textureCoordinates = new List<Vector2>();
            List<Vector3> normals = new List<Vector3>();

            using (var reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line.StartsWith("#") || line.StartsWith("mtllib") || line.StartsWith("usemtl")) continue;
                    if (line.StartsWith("mtllib")) continue;
                    if (Regex.IsMatch(line, @"^o [a-zA-Z0-9._]+$"))
                    {
                        if(model != null) list.Add(model);
                        model = new Object3D();
                        model.Name = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1];
                    }
                    if (Regex.IsMatch(line, @"^v (-?\d+\.\d+ ?){3}$"))
                    {
                        var coordinates = ParseLine(line);
                        vertexes.Add(new Vector3(coordinates[0], coordinates[1], coordinates[2]));
                    }
                    if (Regex.IsMatch(line, @"^vt (\d+\.\d+ ?){2}$"))
                    {
                        var coordinates = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                            .Skip(1).Select(i => float.Parse(i, NumberStyles.Any, CultureInfo.InvariantCulture))
                            .ToArray();
                        textureCoordinates.Add(new Vector2(coordinates[0], coordinates[1]));
                    }
                    if (Regex.IsMatch(line, @"^vn (-?\d+\.\d+ ?){3}$"))
                    {
                        var coordinates = ParseLine(line);
                        normals.Add(new Vector3(coordinates[0], coordinates[1], coordinates[2]));
                    }
                    if (Regex.IsMatch(line, @"^f (\d+/\d+/\d+ ?)+$"))
                    {
                        var polygon = new Polygon();
                        ParsePolygon(vertexes, textureCoordinates, line, polygon);
                        model.AddPolygon(polygon);
                    }
                }
            }
            list.Add(model);
            return list;
        }

        private static void ParsePolygon(List<Vector3> vertexes, List<Vector2> textureCoordinates, string line, Polygon polygon)
        {
            var facesParams = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Skip(1);
            foreach (var param in facesParams)
            {
                var vertexesParams = param.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                polygon.Vertexes.Add(vertexes[int.Parse(vertexesParams[0]) - 1]);
                polygon.TextureCoordinates.Add(textureCoordinates[int.Parse(vertexesParams[1]) - 1]);
            }
        }

        private static float[] ParseLine(string line)
        {
            var str = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Skip(1).Select(i => float.Parse(i, NumberStyles.Any, CultureInfo.InvariantCulture)).ToArray();
            return new float[] { str[0], str[1], str[2] };
        }
    }
}
