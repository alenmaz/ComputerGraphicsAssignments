using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lab7.Entities.Objects;

namespace Lab7.Repositories
{
    public class Scene
    {
        public List<Object3D> Objects { get; }
        public string Name { get; set; }

        public Scene(string name)
        {
            Name = name;
            Objects = new List<Object3D>();
        }
    }
}
