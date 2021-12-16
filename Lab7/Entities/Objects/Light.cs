using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;

namespace Lab7.Entities.Objects
{
    public class Light
    {
        public Vector3 lightColor { get; set; }
        public Vector3 lightPos { get; set; }
        public string Name { get; set; }

        public Light(string name, Vector3 lightColor, Vector3 lightPos)
        {
            this.lightColor = lightColor;
            this.lightPos = lightPos;
            this.Name = name;
        }
    }
}
