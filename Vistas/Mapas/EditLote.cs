using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Mapas
{
    public partial class EditLote : Form
    {
        Mapa padreForm;
        Entidades.Lote lote;

        public EditLote(Mapa padreForm, Entidades.Lote lote)
        {
            this.padreForm = padreForm;
            this.lote = lote;
            InitializeComponent();
            txtArea.Text = lote.Area.ToString();
            txtCodigo.Text = lote.IdLote;
            txtAreaUtilizada.Text = lote.AreaUtilizada.ToString();
            txtCantPlantas.Text = lote.CantPlantas.ToString();
            cargarCodecs();
        }
        void cargarCodecs()
        {
            var codecs = ImageCodecInfo.GetImageEncoders();
            var codecFilter = "Image Files|";
            foreach (var codec in codecs)
            {
                codecFilter += codec.FilenameExtension + ";";
            }
            openFileDialog1.Filter = codecFilter;

        }


        private void btnMapa_Click(object sender, EventArgs e)
        {
         try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;

                    txtImagen.Text = imagen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lote.Area = double.Parse(txtArea.Text);
            if (txtImagen.Text != "")
            {
                try
                {
                    lote.Imagen = image_compressor(txtImagen.Text);
                    if (lote.Imagen == null) { MessageBox.Show("ERROR: Tipo formato de imagen no valido"); return; }
                }
                catch (Exception ex) { MessageBox.Show("ERROR_1:" + ex.Message + ex.Source); return; }
                /*
                try
                {
                    lote.Imagen = setQuality(lote.Imagen);   
                }
                catch(Exception ex) { MessageBox.Show("ERROR_2:" + ex.Message); return; }*/
                padreForm.editarLote(lote);
                Dispose();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtArea.ReadOnly = false;
                btnGuardar.Enabled = true;
                btnMapa.Enabled = true;
            }
            else
            {
                txtArea.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnMapa.Enabled = false;
            }
        }
        private void validarNumeros(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (isNumber(tb.Text))
            {
                tb.BackColor = SystemColors.Window;
                btnGuardar.Enabled = true;
            }
            else
            {
                tb.BackColor = Color.Tomato;
                btnGuardar.Enabled = false;
            }
        }

        bool isNumber(string entrada)
        {
            double d;
            return double.TryParse(entrada, out d);
        }
        private Image CompressImage(Image sourceImage, long quality)
        {
            try
            {
                //Create an ImageCodecInfo-object for the codec information
                ImageCodecInfo jpegCodec = null;

                //Set quality factor for compression
                EncoderParameter imageQualitysParameter = new EncoderParameter(
                            System.Drawing.Imaging.Encoder.Quality, quality);

                //List all avaible codecs (system wide)
                ImageCodecInfo[] alleCodecs = ImageCodecInfo.GetImageEncoders();

                EncoderParameters codecParameter = new EncoderParameters(1);
                codecParameter.Param[0] = imageQualitysParameter;

                //Find and choose JPEG codec
                for (int i = 0; i < alleCodecs.Length; i++)
                {
                    if (alleCodecs[i].MimeType == "image/jpeg")
                    {
                        jpegCodec = alleCodecs[i];
                        break;
                    }
                }
                var ms = new System.IO.MemoryStream();
                //Save compressed image
                sourceImage.Save(ms, jpegCodec, codecParameter);
                return Image.FromStream(ms);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private Image setQuality(Image sourceImage)
        {
            var ms1 = new MemoryStream(2000000);
            sourceImage = CompressImage(sourceImage, 100L);
            sourceImage.Save(ms1, ImageFormat.Jpeg);
            while (ms1.Length >= 1000000)
            {
                sourceImage = CompressImage(sourceImage, 50L);
                ms1 = new MemoryStream(2000000);
                sourceImage.Save(ms1, ImageFormat.Jpeg);
                MessageBox.Show((ms1.Length / 1024 / 1024).ToString());
            }
            return sourceImage;
        }
        static public Image image_compressor(string image_path)
        {
            Image imagen = null;

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\PyScripts";
            File.Copy(image_path, path + "\\original.png", true);
            string py_path = "ImageCompressor.py";
            image_path = "original.png";
            string out_path = "compressed.JPEG";

            ProcessStartInfo startInfo;
            Process process;
            string directory = path;
            string script = string.Format("{0} {1} {2}", py_path, image_path, out_path);

            startInfo = new ProcessStartInfo("python");
            startInfo.WorkingDirectory = directory;
            startInfo.Arguments = script;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

            process = new Process();
            process.StartInfo = startInfo;
            process.Start();

            string s;
            while ((s = process.StandardOutput.ReadLine()) != null)
            {
                if (s == "true")
                {
                    imagen = Image.FromFile(path + "\\compressed.JPEG");
                }
            }
            File.Delete(path + "\\original.png");
            return imagen;
        }
    }
}
