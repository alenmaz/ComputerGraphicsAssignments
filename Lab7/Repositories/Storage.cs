using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lab7.Entities.Base;
using Lab7.Entities.Objects;

namespace Lab7.Repositories
{
    public class Storage
    {
        const int max_obj_size = 50;
        const int max_material_size = 10;
        const int max_texture_size = 5;
        const int max_light_size = 5;
        protected List<Scene> scenes { get; }
        protected List<Material> materials { get; }
        protected List<Texture> textures { get; }
        protected List<Light> lights { get; }

        public Storage()
        {
            scenes = new List<Scene>();
            materials = new List<Material>();
            textures = new List<Texture>();
            lights = new List<Light>();
        }

        public void AddScene(Scene scene) => scenes.Add(scene);

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
            if(lights.Count < max_light_size) lights.Add(light);
        }

        public List<Scene> GetScenes() => scenes;
        public List<Material> GetMaterials() => materials;
        public List<Texture> GetTextures() => textures;
        public List<Light> GetLights() => lights;
    }
}
