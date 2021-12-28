using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace Lab8_3
{
    public class Ray
    {
        const int MAX_RAY_DEPTH = 5;
        public Vector3 Origin { get; private set; }
        public Vector3 Direction { get; private set; }

        public Ray(Vector3 origin, Vector3 direction)
        {
            Origin = origin;
            Direction = direction;
        }

        public Vector3 Trace(Scene scene, int depth)
        {
            float tnear = float.MaxValue;
            IObj hitObj = null;

            for (int i = 0; i < scene.Objects.Count; ++i)
            {
                float t0 = float.MaxValue, t1 = float.MaxValue;
                if (scene.Objects[i].doesIntersect(this, out t0, out t1))
                {
                    if (t0 < 0) t0 = t1;
                    if (t0 < tnear)
                    {
                        tnear = t0;
                        hitObj = scene.Objects[i];
                    }
                }
            }
            if (hitObj is null) return scene.BackgroundColor;
            Vector3 surfaceColor = Vector3.Zero;
            Vector3 phit = Origin + Direction * tnear;
            Vector3 nhit = phit - hitObj.Position;
            nhit = Vector3.Normalize(nhit);

            float bias = 1e-4f;
            bool inside = false;
            if (Direction.Dot(nhit) > 0) nhit = -nhit;
            inside = true;
            if ((hitObj.Transparency > 0 || hitObj.Reflection > 0) && depth < MAX_RAY_DEPTH)
            {
                float facingratio = -Direction.Dot(nhit);
                float fresneleffect = mix((float)Math.Pow(1 - facingratio, 3), 1, 0.1f);
                Vector3 refldir = refldir = Direction - nhit * 2 * Direction.Dot(nhit);
                refldir = Vector3.Normalize(refldir);
                Vector3 reflection = new Ray(phit + nhit * bias, refldir).Trace(scene, depth + 1);
                Vector3 refraction = Vector3.Zero;
                if (hitObj.Transparency > 0)
                {
                    float ior = 1.1f, eta = (inside) ? ior : 1 / ior;
                    float cosi = -nhit.Dot(Direction);
                    float k = 1 - eta * eta * (1 - cosi * cosi);
                    Vector3 refrdir = Direction * eta + nhit * (eta * cosi - (float)Math.Sqrt(k));
                    refldir = Vector3.Normalize(refrdir);
                    refraction = new Ray(phit - nhit * bias, refrdir).Trace(scene, depth + 1);
                }
                surfaceColor = (
                    reflection * fresneleffect +
                    refraction * (1 - fresneleffect) * hitObj.Transparency) * hitObj.SurfaceColor;
            }
            else
            {
                for (int i = 0; i < scene.Objects.Count; ++i)
                {
                    if (scene.Objects[i].EmissionColor.X > 0)
                    {
                        Vector3 transmission = Vector3.One;
                        Vector3 lightDirection = scene.Objects[i].Position - phit;
                        lightDirection = Vector3.Normalize(lightDirection);
                        for (int j = 0; j < scene.Objects.Count; ++j)
                        {
                            if (i != j)
                            {
                                float t0, t1;
                                if (scene.Objects[j].doesIntersect(new Ray(phit + nhit * bias, lightDirection), out t0, out t1))
                                {
                                    transmission = Vector3.Zero;
                                    break;
                                }
                            }
                        }
                        surfaceColor += hitObj.SurfaceColor * transmission *
                            Math.Max(0.0f, nhit.Dot(lightDirection)) * scene.Objects[i].EmissionColor;
                    }
                }
            }

            return surfaceColor + hitObj.EmissionColor;
        }

        float mix(float a, float b, float mix) => b * mix + a * (1 - mix);
    }
}
