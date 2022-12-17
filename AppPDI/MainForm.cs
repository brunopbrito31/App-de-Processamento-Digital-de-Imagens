using AppPDI.Models;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace AppPDI
{
    public partial class MainForm : Form
    {
        private ImageSelectModal modalImagem;

        private PictureToEdit pictureEdit;

        public MainForm(PictureToEdit pictureToEdit)
        {
            InitializeComponent();
            this.pictureEdit = pictureToEdit;

            radioButton1.Checked = true;
            InitializeChartHistograma();

            this.modalImagem = new ImageSelectModal(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void originImagePictureBox_Click(object sender, EventArgs e)
        {
            var imagemOrigem = originImagePictureBox.Image;
            Bitmap origem = new Bitmap(imagemOrigem);

            this.modalImagem.LoadImageInPitureBox(origem);
            this.modalImagem.ShowDialog();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = $"Red ({trackBar1.Value.ToString()})";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label4.Text = $"Green ({trackBar2.Value.ToString()})";
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label5.Text = $"Blue ({trackBar3.Value.ToString()})";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var imagemOrigem = radioButton1.Checked ? originImagePictureBox.Image : destinoPictureBox.Image;
            Bitmap origem = new Bitmap(imagemOrigem);
            Bitmap destino = new Bitmap(origem.Width, origem.Height); 

            Color pixel;
            
            for (int x = 0; x < origem.Width; x++)
            {
                for(int y = 0; y < origem.Height; y++)
                {
                    pixel = origem.GetPixel(x, y);
                    if (checkBox1.Checked)
                    {
                        destino.SetPixel(x, y, Color.FromArgb(trackBar1.Value, pixel.G, pixel.B));
                    }

                    if (checkBox2.Checked)
                    {
                        destino.SetPixel(x, y, Color.FromArgb(pixel.R, trackBar2.Value, pixel.B));
                    }

                    if (checkBox3.Checked)
                    {
                        destino.SetPixel(x, y, Color.FromArgb(pixel.R, pixel.G, trackBar3.Value));
                    }

                }
            }

            destinoPictureBox.Image = destino;
        }

        private void btApplyRed_Click(object sender, EventArgs e)
        {
            var imagemOrigem = radioButton1.Checked ? originImagePictureBox.Image : destinoPictureBox.Image;
            Bitmap origem = new Bitmap(imagemOrigem);
            Bitmap destino = new Bitmap(origem.Width, origem.Height);

            Color pixel;

            for (int x = 0; x < origem.Width; x++)
            {
                for (int y = 0; y < origem.Height; y++)
                {
                    pixel = origem.GetPixel(x, y);
                    destino.SetPixel(x, y, Color.FromArgb(trackBar1.Value, pixel.G, pixel.B));
                }
            }

            destinoPictureBox.Image = destino;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var imagemOrigem = radioButton1.Checked ? originImagePictureBox.Image : destinoPictureBox.Image;
            Bitmap origem = new Bitmap(imagemOrigem);
            Bitmap destino = new Bitmap(origem.Width, origem.Height);

            Color pixel;

            for (int x = 0; x < origem.Width; x++)
            {
                for (int y = 0; y < origem.Height; y++)
                {
                    pixel = origem.GetPixel(x, y);
                    destino.SetPixel(x, y, Color.FromArgb(pixel.R, trackBar2.Value, pixel.B));
                }
            }

            destinoPictureBox.Image = destino;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var imagemOrigem = radioButton1.Checked ? originImagePictureBox.Image : destinoPictureBox.Image;
            Bitmap origem = new Bitmap(imagemOrigem);
            Bitmap destino = new Bitmap(origem.Width, origem.Height);

            Color pixel;

            for (int x = 0; x < origem.Width; x++)
            {
                for (int y = 0; y < origem.Height; y++)
                {
                    pixel = origem.GetPixel(x, y);
                    destino.SetPixel(x, y, Color.FromArgb(pixel.R, pixel.G, trackBar3.Value));
                }
            }

            destinoPictureBox.Image = destino;
        }
     
        private void lightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap origem = GetOriginImage();
                Bitmap destino = pictureEdit.ApplyLightnessFilter(origem);
                SetPictureAndUpdateDestinoPictureBox(destino);
            }catch(Exception ex)
            {
                // Implementar o tratamento de erro
            }
        }


        private void SetPictureAndUpdateDestinoPictureBox (Bitmap image)
        {
            destinoPictureBox.Image = image;
        }

        private Bitmap GetOriginImage ()
        {
            var imagemOrigem = radioButton1.Checked ? originImagePictureBox.Image : destinoPictureBox.Image;
            Bitmap origem = new Bitmap(imagemOrigem);
            return origem;
        }


        private void avgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap origem = GetOriginImage();
                Bitmap destino = pictureEdit.ApplyAVGFilter(origem);
                SetPictureAndUpdateDestinoPictureBox(destino);
            }catch(Exception ex)
            {
                // Implementar o tratamento de erro
            }
        }

        private void luminosityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap origem = GetOriginImage();
                Bitmap destino = pictureEdit.ApplyLuminosityFilter(origem);
                SetPictureAndUpdateDestinoPictureBox(destino);
            }
            catch (Exception ex)
            {
                // Implementar o tratamento de erro
            }
        }

      
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var imagemOrigem = radioButton1.Checked ? originImagePictureBox.Image : destinoPictureBox.Image;
            Bitmap origem = new Bitmap(imagemOrigem);
            Bitmap destino = new Bitmap(origem.Width, origem.Height);

            Color pixelOrigem;

            for (int x = 0; x < origem.Width; x++)
            {
                for (int y = 0; y < origem.Height; y++)
                {
                    pixelOrigem = origem.GetPixel(x, y);

                    destino.SetPixel( (origem.Width - 1) - x, y, Color.FromArgb(pixelOrigem.R, pixelOrigem.G, pixelOrigem.B));
                }
            }

            destinoPictureBox.Image = destino;
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var imagemOrigem = radioButton1.Checked ? originImagePictureBox.Image : destinoPictureBox.Image;
            Bitmap origem = new Bitmap(imagemOrigem);
            Bitmap destino = new Bitmap(origem.Width, origem.Height);

            Color pixelOrigem;

            for (int x = 0; x < origem.Width; x++)
            {
                for (int y = 0; y < origem.Height; y++)
                {
                    pixelOrigem = origem.GetPixel(x, y);

                    destino.SetPixel(x, (origem.Height - 1) - y, Color.FromArgb(pixelOrigem.R, pixelOrigem.G, pixelOrigem.B));
                }
            }

            destinoPictureBox.Image = destino;
        }

        private void calcularNivelDeCinzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap origem = GetOriginImage();
                Bitmap destino = pictureEdit.ApplyNegativeOfImage(origem);
                SetPictureAndUpdateDestinoPictureBox(destino);
            }
            catch (Exception ex)
            {
                // Implementar tratativa de erros
            }
        }

        private DataTable CalcularHistograma()
        {
            var imagemOrigem = radioButton1.Checked ? originImagePictureBox.Image : destinoPictureBox.Image;
            Bitmap origem = new Bitmap(imagemOrigem);

            return pictureEdit.CalcularHistograma(origem);   
        }

        private void thresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap origem = GetOriginImage();
            Bitmap destino = pictureEdit.ApplyThresholdInImagem(origem);
            SetPictureAndUpdateDestinoPictureBox(destino);
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap origem = GetOriginImage();
            Bitmap destino = pictureEdit.ApplyLogTransformation(origem);
            SetPictureAndUpdateDestinoPictureBox(destino);
        }

        public void RefresOriginImage(Bitmap newImagem)
        {
            originImagePictureBox.Image = newImagem;
        }

        public void InitializeChartHistograma()
        {
            var histograma = CalcularHistograma();

            chart1.DataSource = histograma;
            // chart1.Series[0].XValueMember = "Ocorrencias";
            // chart1.Series[0].YValueMembers = "Intensidade";

            chart1.Series[0].YValueMembers = "Ocorrencias";
            chart1.Series[0].XValueMember = "Intensidade";

            if(this.chart1.Titles.Count == 0) { 
                this.chart1.Titles.Add("Histograma da imagem");
            }
            chart1.DataBind();
        }

        public void RefresHistogramaOriginImagem()
        {
            InitializeChartHistograma();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var SD = new System.Windows.Forms.SaveFileDialog();
            SD.DefaultExt = "png";
            SD.Filter = "Image Files (*.png)|*.png";

            // var FD = new System.Windows.Forms.FolderBrowserDialog();
            if (SD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fileStream = new FileStream(SD.FileName, FileMode.Create);

                var imagemAlvo = destinoPictureBox.Image;

                Bitmap image = new Bitmap(imagemAlvo);

                image.Save(fileStream, ImageFormat.Png);

                NotificarUsuarioViaEmail(SD.FileName);

                fileStream.Close();
            }
        }


        public void NotificarUsuarioViaEmail(string nameFile)
        {
            var url = $"http://localhost:8075/save?nameFile={nameFile}";
            HttpClient client = new HttpClient();
            client.GetAsync(url);
        }

        private void expToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap origem = GetOriginImage();
            Bitmap destino = pictureEdit.ApplyExpTransformation(origem);
            SetPictureAndUpdateDestinoPictureBox(destino);
        }

        private void sqrtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap origem = GetOriginImage();
            Bitmap destino = pictureEdit.ApplySqrtTransformation(origem);
            SetPictureAndUpdateDestinoPictureBox(destino);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }

}
