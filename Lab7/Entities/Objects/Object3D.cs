using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Drawing.Imaging;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;

using Lab7.Entities.Base;

namespace Lab7.Entities.Objects
{
    public class Object3D
    {
        private readonly List<Polygon> polygons;
        public string Name { get; set; }
        public Vector3 Start { get; set; }

        public Material Material { get; set; }
        public int TextureID { get; set; }

        public Object3D()
        {
            Start = new Vector3(0, 0, 0);
            polygons = new List<Polygon>();
            Material = Material.Default;
        }

        public Object3D(List<Polygon> polygons)
        {
            Start = new Vector3(0, 0, 0);
            this.polygons = polygons;
            Material = Material.Default;
        }

        public void Draw(Material material, Light light, Vector3 viewPos)
        {
            if (material is null) material = Material;
            Vector4 color;
            GL.BindTexture(TextureTarget.Texture2D, TextureID);
            foreach (var p in polygons)
            {
                if (p.Normals.Count == 0) FillNormals(p);
                if (p.TextureCoordinates.Count == 0) FillTextureCoordinates(p);
                GL.Begin(BeginMode.Polygon);
                for (int i = 0; i < p.Vertexes.Count; i++)
                {
                    color = material.GetColor(p.Normals.ElementAtOrDefault(i), light, viewPos, p.Vertexes[i]);
                    GL.Color4(color);
                    GL.TexCoord2(p.TextureCoordinates.ElementAtOrDefault(i));
                    GL.Vertex3(Vector3.Add(Start, p.Vertexes[i]));
                }
                GL.End();
            }
        }

        private void FillNormals(Polygon polygon)
        {
            for (int i = 0; i < polygon.Vertexes.Count; i++)
                polygon.Normals.Add(new Vector3(1, 1, 1));
        }

        private void FillTextureCoordinates(Polygon polygon)
        {
            polygon.TextureCoordinates.Add(new Vector2(0, 0));
            polygon.TextureCoordinates.Add(new Vector2(0, 1));
            polygon.TextureCoordinates.Add(new Vector2(1, 1));
            polygon.TextureCoordinates.Add(new Vector2(1, 0));
        }

        public void AddPolygon(Polygon polygon)
        {
            polygons.Add(polygon);
        }
    }
}
