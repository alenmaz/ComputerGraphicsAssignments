using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace Lab8_3
{
    public class Scene
    {
        public string Name { get; private set; }
        public List<IObj> Objects { get; private set; }
        public Vector3 BackgroundColor { get; private set; }

        public Vector3 BackColorRay(Ray ray) => RayColor(ray);

        private Vector3 RayColor(Ray ray) 
        {
            var t = 0.5 * (ray.Direction.Y + 1.0);
            return (new Vector3(1, 1, 1)).Multiply(1.0f - (float)t) + (new Vector3(0.5f, 0.7f, 1)).Multiply((float)t);
        }


        public Scene(string name, Vector3 backColor)
        {
            Name = name;
            Objects = new List<IObj>();
            BackgroundColor = backColor;
        }
    }
}
