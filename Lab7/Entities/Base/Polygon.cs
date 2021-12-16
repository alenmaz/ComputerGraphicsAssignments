using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;

namespace Lab7.Entities.Base
{
    public class Polygon
    {
        private readonly List<Vector3> vertexes;
        private readonly List<Vector2> textureCoordinates;
        private Vector3 color = new Vector3(0.0f, 0.0f, 0.0f);

        public List<Vector3> Vertexes { get => vertexes; }
        public List<Vector2> TextureCoordinates { get => textureCoordinates; }

        public Polygon()
        {
            vertexes = new List<Vector3>();
            textureCoordinates = new List<Vector2>();
        }

        public Polygon(IEnumerable<Vector3> vertexes)
        {
            this.vertexes = vertexes.ToList();
        }
    }
}
