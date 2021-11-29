using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageEditor
{
    public partial class ImageEditor : Form
    {
        public ImageEditor()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    sourceBox.Image = Image.FromFile(open.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Failed reading file from filepath!", "Error reading file.");
                return;
            }
        }

        private void showData_Click(object sender, EventArgs e)
        {
            ShowImageData(sourceBox.Image);
        }

        private void ShowImageData(Image image)
        {
            if (image != null)
            {
                var result = new StringBuilder();
                var imageBMP = (Bitmap)image;
                var pixel = Color.Black;
                for (int x = 0; x < imageBMP.Width; x++)
                    for (int y = 0; y < imageBMP.Height; y++)
                    {
                        pixel = imageBMP.GetPixel(x, y);
                        result.Append($"pixel {x},{y} : ({pixel.R},{pixel.G},{pixel.B}) {0.2126*pixel.R + 0.7152*pixel.G + 0.0722*pixel.B}\n");
                    }
                ImageData.AppendText(result.ToString());
            }
            else MessageBox.Show("Failed showing pixel data! There's no image.", "Image data error");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (sourceBox.Image is null) MessageBox.Show("There's no image already!", "Clear error");
            else
            {
                sourceBox.Image = null;
                resultBox.Image = null;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Color color = Color.Black;
            Color singlePixelColor = Color.Black;
            int brightness, setx, sety;

            singlePixelColor = ParseFieldForColor(ref SinglePixelColorBox, "pixel change color");
            color = ParseFieldForColor(ref colorBox, "color filter");
            try 
            {
                setx = int.Parse(XCoordinateBox.Text);
                sety = int.Parse(YCoordinateBox.Text);
            } 
            catch 
            {
                var result = MessageBox.Show("Wrong pixel coordinates!", "Edit params error");
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    XCoordinateBox.Text = "";
                    YCoordinateBox.Text = "";
                }
                return;
            };

            try { brightness = int.Parse(brightnessBox.Text); }
            catch { 
                var result = MessageBox.Show("Wrong brightness params!", "Edit params error"); 
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    colorBox.Text = "";
                    brightnessBox.Text = "";
                }
                return;
            };

            if (sourceBox.Image != null)
            {
                Bitmap result = new Bitmap(sourceBox.Image.Width, sourceBox.Image.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                var pixel = Color.Black;
                for (int x = 0; x < sourceBox.Image.Width; x++)
                    for (int y = 0; y < sourceBox.Image.Height; y++)
                    {
                        pixel = ((Bitmap)sourceBox.Image).GetPixel(x, y);
                        var cR = pixel.R - color.R + brightness;
                        var cG = pixel.G - color.G + brightness;
                        var cB = pixel.B - color.B + brightness;
                        result.SetPixel(x, y, Color.FromArgb(CheckColor(cR), CheckColor(cG), CheckColor(cB)));
                    }
                result.SetPixel(setx, sety, singlePixelColor);
                resultBox.Image = result;
            }
            else MessageBox.Show("Failed editing image! There's no image to edit.", "Edit error");
        }

        private static Color ParseFieldForColor(ref TextBox box, string paramName)
        {
            Color color = Color.Black;
            try
            {
                var colorParams = box.Text.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
                if (colorParams.Length > 0)
                    color = ConvertTextFieldsToColor(colorParams);

            }
            catch
            {
                var result = MessageBox.Show($"Wrong {paramName} params!", "Edit params error");
                if (result == System.Windows.Forms.DialogResult.Yes)
                    box.Text = "";
            }
            return color;
        }

        private static Color ConvertTextFieldsToColor(string[] colorParams)
        {
            return Color.FromArgb(int.Parse(colorParams[0]), int.Parse(colorParams[1]), int.Parse(colorParams[2]));
        }

        private static int CheckColor(int value)
        {
            if (value < 0) return 0;
            if(value > 255) return 255;
            return value;
        }

        private void editedImageData_Click(object sender, EventArgs e)
        {
            ShowImageData(resultBox.Image);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
