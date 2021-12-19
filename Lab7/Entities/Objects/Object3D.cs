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
        public Texture Texture { get; set; }

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

        public void Draw(Material material, Texture texture, Light light, Vector3 viewPos)
        {
            var textureID = 0;
            if(texture != null) LoadTexture(texture);
            Vector4 color;
            GL.BindTexture(TextureTarget.Texture2D, textureID);
            foreach (var p in polygons)
            {
                GL.Begin(BeginMode.Polygon);
                for (int i = 0; i < p.Vertexes.Count; i++)
                {
                    if (p.Normals.Count == 0) FillNormals(p);
                    if (p.TextureCoordinates.Count == 0) FillTextureCoordinates(p);
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

        private int LoadTexture(Texture texture)
        {
            int textureID = 0;
            GL.GenTextures(1, out textureID);

            if (texture != null)
            {
                var bitmap = texture.TextureImage;

                GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest);

                GL.GenTextures(1, out textureID);
                GL.BindTexture(TextureTarget.Texture2D, textureID);
                BitmapData data = bitmap.LockBits(new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height),
                    ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, data.Width, data.Height, 0,
                    OpenTK.Graphics.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);
                bitmap.UnlockBits(data);

                GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
                GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
                GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
                GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);
            }
            return textureID;
        }

        public void AddPolygon(Polygon polygon)
        {
            polygons.Add(polygon);
        }
    }
}
