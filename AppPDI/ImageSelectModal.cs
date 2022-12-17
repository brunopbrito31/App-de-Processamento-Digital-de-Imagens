using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppPDI
{
    public partial class ImageSelectModal : Form
    {
        private MainForm father;

        public ImageSelectModal(MainForm father)
        {
            this.father = father;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                
        }

        public void LoadImageInPitureBox(Bitmap image)
        {
            this.button2.Enabled = false;
            this.pictureBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;


                System.IO.StreamReader reader = new System.IO.StreamReader(fileToOpen);

                Bitmap newImage = new Bitmap(fileToOpen);

                this.pictureBox1.Image = newImage;
                this.button2.Enabled = true;
                //etc
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.father.RefresOriginImage(new Bitmap(this.pictureBox1.Image));
            this.father.RefresHistogramaOriginImagem();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
