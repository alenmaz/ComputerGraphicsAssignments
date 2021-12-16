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
            Texture = new Texture("default", DrawFilledRectangle(254, 254));
        }

        public Object3D(List<Polygon> polygons)
        {
            Start = new Vector3(0, 0, 0);
            this.polygons = polygons;
            Material = Material.Default;
            Texture = new Texture("default", DrawFilledRectangle(254, 254));
        }

        public void Draw(Material material, Texture texture, Vector3 normal, Light light, Vector3 viewPos)
        {
            var textureID = LoadTexture(texture);
            Vector4 color;
            GL.BindTexture(TextureTarget.Texture2D, textureID);
            foreach (var p in polygons)
            {
                GL.Begin(BeginMode.Polygon);
                for (int i = 0; i < p.Vertexes.Count; i++)
                {
                    color = material.GetColor(normal, light, viewPos, p.Vertexes[i]);
                    GL.Color4(color);
                    GL.TexCoord2(p.TextureCoordinates[i]);
                    GL.Vertex3(Vector3.Add(Start, p.Vertexes[i]));
                }
                GL.End();
            }
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

        private Bitmap DrawFilledRectangle(int x, int y)
        {
            Bitmap bmp = new Bitmap(x, y);
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle ImageSize = new Rectangle(0, 0, x, y);
                graph.FillRectangle(Brushes.White, ImageSize);
            }
            return bmp;
        }
    }
}
