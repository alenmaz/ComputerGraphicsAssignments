using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;


using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;

using Lab7.Entities.Base;
using Lab7.Entities.Objects;

namespace Lab7.Parsesrs
{
    class MtlFormatParser
    {
        public static List<Material> Parse(string filename)
        {
            var list = new List<Material>();
            Material material = null;

            using (var reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line.StartsWith("#") || line.StartsWith("Ni") || line.StartsWith("illum")) continue;
                    if (Regex.IsMatch(line, @"^newmtl [a-zA-Z0-9._]+$"))
                    {
                        if (material != null) list.Add(material);
                        material = new Material("");
                        material.Name = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1];
                    }
                    if (Regex.IsMatch(line, @"^Ns (-?\d+\.\d+)$"))
                    {
                        material.shininess = float.Parse(line.Split(' ').Skip(1).FirstOrDefault(), NumberStyles.Any, CultureInfo.InvariantCulture);
                    }
                    if (Regex.IsMatch(line, @"^Ka (-?\d+\.\d+ ?){3}$"))
                    {
                        material.ambient = ParseLine(line);
                    }
                    if (Regex.IsMatch(line, @"^Kd (-?\d+\.\d+ ?){3}$"))
                    {
                        material.DiffuseColor = ParseLine(line);
                    }
                    if (Regex.IsMatch(line, @"^Ks (-?\d+\.\d+ ?){3}$"))
                    {
                        material.specular = ParseLine(line);
                    }
                    if (Regex.IsMatch(line, @"^Ke (-?\d+\.\d+ ?){3}$"))
                    {
                        material.emissive = ParseLine(line);
                    }
                    if (Regex.IsMatch(line, @"^d (-?\d+\.\d+)$"))
                    {
                        material.dissolve = float.Parse(line.Split(' ').Skip(1).FirstOrDefault(), NumberStyles.Any, CultureInfo.InvariantCulture);
                    }
                }
            }
            list.Add(material);
            return list;
        }

        private static Vector3 ParseLine(string line)
        {
            var str = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Skip(1).Select(i => float.Parse(i, NumberStyles.Any, CultureInfo.InvariantCulture)).ToArray();
            return new Vector3(str[0], str[1], str[2]);
        }
    }
}
