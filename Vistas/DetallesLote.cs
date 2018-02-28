using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class DetallesLote : Form
    {
     
        Entidades.Lote lote;

        public DetallesLote(Entidades.Lote lote)
        {
           
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

        private void EditLote_Load(object sender, EventArgs e)
        {

        }
    }
}
