using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lab7.Entities.Base;
using Lab7.Entities.Objects;

namespace Lab7
{
    public class Storage
    {
        const int max_obj_size = 10;
        const int max_material_size = 15;
        const int max_texture_size = 5;
        protected List<Object3D> objects { get; }
        protected List<Material> materials { get; }
        protected List<Texture> textures { get; }
        protected List<Light> lights { get; }

        public Storage()
        {
            objects = new List<Object3D>();
            materials = new List<Material>();
            textures = new List<Texture>();
            lights = new List<Light>();
        }

        public void AddObject(Object3D obj)
        {
            if (objects.Count < max_obj_size) objects.Add(obj);
        }

        public void AddMaterial(Material material)
        {
            if (materials.Count < max_material_size) materials.Add(material);
        }

        public void AddTexture(Texture texture)
        {
            if (textures.Count < max_texture_size) textures.Add(texture);
        }

        public void AddLight(Light light)
        {
            lights.Add(light);
        }

        public List<Object3D> GetObjects() => objects;
        public List<Material> GetMaterials() => materials;
        public List<Texture> GetTextures() => textures;
        public List<Light> GetLights() => lights;
    }
}
