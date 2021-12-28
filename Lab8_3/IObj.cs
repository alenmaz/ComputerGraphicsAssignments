using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace Lab8_3
{
    public interface IObj
    {
        Vector3 Position { get; set; }
        float Radius { get; set; }

        Vector3 SurfaceColor { get; }
        Vector3 EmissionColor { get; }
        float Transparency { get; }
        float Reflection { get; }

        bool doesIntersect(Ray ray, out float t0, out float t1);
    }

    public class Sphere : IObj
    {
        public Vector3 Position { get; set; }
        public float Radius { get; set; }

        public Vector3 SurfaceColor { get; private set; }

        public Vector3 EmissionColor { get; private set; }

        public float Transparency { get; private set; }

        public float Reflection { get; private set; }

        public Sphere(Vector3 position, float radius, Vector3 surfaceColor, Vector3 emissionColor, float transparency, float reflection)
        {
            Position = position;
            Radius = radius;
            SurfaceColor = surfaceColor;
            EmissionColor = emissionColor;
            Transparency = transparency;
            Reflection = reflection;
        }

        public bool doesIntersect(Ray ray, out float t0, out float t1)
        {
            t0 = float.MaxValue; t1 = float.MaxValue;
            Vector3 l = Position - ray.Origin;
            float tca = l.Dot(ray.Direction);
            if (tca < 0) return false;
            float d2 = l.Dot(l) - tca * tca;
            if (d2 > Radius * Radius) return false;
            float thc = (float)Math.Sqrt(Radius * Radius - d2);
            t0 = tca - thc;
            t1 = tca + thc;

            return true;
        }
    }
}
