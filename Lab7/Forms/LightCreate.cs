using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using OpenTK;

using Lab7.Entities.Objects;

namespace Lab7
{
    public partial class LightCreate : Form
    {
        ModelViewer form;
        public LightCreate(ModelViewer modelViewer)
        {
            InitializeComponent();
            form = modelViewer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = float.Parse(xBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
            var y = float.Parse(yBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
            var z = float.Parse(zBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture);

            var r = float.Parse(rBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
            var g = float.Parse(gBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
            var b = float.Parse(bBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture);

            form.Storage.AddLight(new Light("light" + form.Storage.GetLights().Count, new Vector3(r, g, b), new Vector3(x, y, z)));
            this.Close();
        }
    }
}
