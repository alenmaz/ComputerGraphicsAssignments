using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab7.Entities.Base
{
    public class Texture
    {
        public Bitmap TextureImage { get; }
        public string Name { get; }

        public Texture(string name, Bitmap image)
        {
            Name = name;
            TextureImage = image;
        }
    }
}
