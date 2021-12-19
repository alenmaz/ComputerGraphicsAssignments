using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;

using Lab7.Entities.Objects;

namespace Lab7.Entities.Base
{   
    public class Material
    {
        public float shininess;
        public Vector3 ambient;
        public Vector3 specular;
        public Vector3 emissive;
        public float dissolve;

        public Vector3 DiffuseColor { get; set; }
        public string Name { get; set; }

        public Material(string name)
        {
            Name = name;
            shininess = 0.0f;
            DiffuseColor = new Vector3(0.0f, 0.0f, 0.0f);
            ambient = new Vector3(0.0f, 0.0f, 0.0f);
            specular = new Vector3(0.0f, 0.0f, 0.0f);
            emissive = new Vector3(0.0f, 0.0f, 0.0f);
            dissolve = 1.0f;
        }
        public Material(string name, Vector3 diffuseColor)
        {
            Name = name;
            DiffuseColor = diffuseColor;
            shininess = 0.0f;
            ambient = new Vector3(0.0f, 0.0f, 0.0f);
            specular = new Vector3(0.0f, 0.0f, 0.0f);
            emissive = new Vector3(0.0f, 0.0f, 0.0f);
            dissolve = 1.0f;
        }

        public Material(float shiness, Vector3 ambientColor, Vector3 specularColor, Vector3 emissiveColor, float dissolve, Vector3 diffuseColor)
        {
            DiffuseColor = diffuseColor;
            this.shininess = shiness;
            this.ambient = ambientColor;
            this.specular = specularColor;
            this.emissive = emissiveColor;
            this.dissolve = dissolve;
        }

        public static Material Default { get => new Material("default", new Vector3(1.0f, 1.0f, 1.0f)); }

        public Vector4 GetColor(Vector3 Normal, Light light, Vector3 viewPos, Vector3 FragPos)
        {
            Vector3 ambient = light.lightColor * this.ambient;

            Vector3 norm = Vector3.Normalize(Normal);
            Vector3 lightDir = Vector3.Normalize(light.lightPos - FragPos);

            float diff = (float)Math.Max(Vector3.Dot(norm, lightDir), 0.0);
            Vector3 diffuse = light.lightColor * diff;

            float specularStrength = 0.5f;
            Vector3 viewDir = Vector3.Normalize(viewPos - FragPos);
            Vector3 reflectDir = Reflect(-lightDir, norm);
            float spec = (float)Math.Pow(Math.Max(Vector3.Dot(viewDir, reflectDir), 0.0), 32);
            Vector3 specular = specularStrength * spec * light.lightColor;

            Vector3 result = (ambient + diffuse + specular) * DiffuseColor;
            return new Vector4(result, 1.0f);
        }

        public static Vector3 Reflect(Vector3 first, Vector3 second)
        {
            return Vector3.Subtract(first, Vector3.Multiply(second, Vector3.Dot(first, second) * 2));
        }
    }
}
