using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Drawing;
using System.Threading.Tasks;

namespace Lab8_3
{
    static class Extensions
    {
        public static float Dot(this Vector3 first, Vector3 second) => first.X * second.X + first.Y * second.Y + first.Z * second.Z;

        public static Vector3 Multiply(this Vector3 vector, float f) => new Vector3(vector.X * f, vector.Y * f, vector.Z * f);

        public static Color ToColor(this Vector3 vector) => Color.FromArgb(CutColorValue((int)(vector.X * 255)), CutColorValue((int)(vector.Y * 255)), CutColorValue((int)(vector.Z * 255)));

        public static int CutColorValue(int value) => value > 255 ? 255 : value < 0 ? 0 : value;
    }
}
