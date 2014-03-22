using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredictiveCoder
{
    public partial class Form1 : Form
    {
        Coder coder;
        Decoder decoder;
        int predMethod;
        int[] histVect;
        public Form1()
        {
            InitializeComponent();
            coder = new Coder();
            decoder = new Decoder();
            histVect = new int[Coder.imageHeight * 2 - 1];
            predMethod = 0;
        }

        private void loadImgButton_Click(object sender, EventArgs e)
        {
            Bitmap inputImage;
            openImgDialog.InitialDirectory = ".";
            openImgDialog.Filter = "Bitmap files (*.bmp) | *.bmp";
            openImgDialog.RestoreDirectory = true;
            if (openImgDialog.ShowDialog() == DialogResult.OK)
            {
                coder.readOrigImage(openImgDialog.FileName);
                inputImage = new Bitmap(openImgDialog.FileName);
                pictureBox1.Image = inputImage;
            }
        }

        private void codeButton_Click(object sender, EventArgs e)
        {
            foreach (var control in groupBox2.Controls)
            {
                RadioButton radio = control as RadioButton;
                if (radio != null && radio.Checked)
                {
                    predMethod = Convert.ToInt32(radio.Name[11] - '0');
                    break;
                }
            }
            coder.k = Convert.ToInt32(comboBox1.Text);
            coder.predMethod = predMethod;
            coder.code();
            showCodedImage();
        }

        private void showCodedImage()
        {
            Bitmap image = new Bitmap(Coder.imageHeight, Coder.imageWidth);
            double pixel;
            Color col;
            int i, j;
            double scale;
            int[,] mat = new int[Coder.imageHeight, Coder.imageWidth];
            scale = Convert.ToDouble(contrastBox.Text);
            if (predErrRadio.Checked)
                mat = coder.predErrMatrix;
            else if (predErrQRadio.Checked)
                mat = coder.predErrMatrixQ;
            for (i = 0; i < 256; i++)
                for (j = 0; j < 256; j++)
                {
                    pixel = mat[i, j] * scale + 128;
                    if (pixel < 0)
                        pixel = 0;
                    if (pixel > 255)
                        pixel = 255;
                    col = Color.FromArgb(255, (int)pixel, (int)pixel, (int)pixel);
                    image.SetPixel(i, j, col);
                }
            image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            codedBox.Image = image;
            codedBox.Refresh();
        }

        private void showDecodedImage()
        {
            Bitmap image = new Bitmap(Coder.imageHeight, Coder.imageWidth);
            double pixel;
            Color col;
            int i, j;
            for (i = 0; i < 256; i++)
                for (j = 0; j < 256; j++)
                {
                    pixel = decoder.decMatrix[i, j];
                    if (pixel < 0)
                        pixel = 0;
                    if (pixel > 255)
                        pixel = 255;
                    col = Color.FromArgb(255, (int)pixel, (int)pixel, (int)pixel);
                    image.SetPixel(i, j, col);
                }
            image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            decodedBox.Image = image;
            decodedBox.Refresh();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            showCodedImage();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string path;
            int saveMethod = 0;
            if (fixedRadio.Checked)
                saveMethod = 0;
            else if (tableRadio.Checked)
                saveMethod = 1;
            saveImgDialog.Filter = "|*.bmp";
            if (saveImgDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveImgDialog.FileName + ".p" + Convert.ToString(predMethod) + "k" + coder.k + Convert.ToString(saveMethod) + ".nl";
                coder.writeResultsFile(path, predMethod, saveMethod);
            }
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            decoder.decode();
            showDecodedImage();

        }

        private void loadNLButton_Click(object sender, EventArgs e)
        {
            openImgDialog.Filter = "Near-lossless files (*.nl) | *.nl";
            openImgDialog.RestoreDirectory = true;
            if (openImgDialog.ShowDialog() == DialogResult.OK)
                decoder.loadImage(openImgDialog.FileName);
        }

        private void saveNLButton_Click(object sender, EventArgs e)
        {
            saveImgDialog.Filter = "|*.bmp";
            if (saveImgDialog.ShowDialog() == DialogResult.OK)
            {
                decoder.saveImage(saveImgDialog.FileName);
            }
        }

        private void computeErrorButton_Click(object sender, EventArgs e)
        {
            int i, j, min, max, diff;
            min = 255;
            max = 0;
            for (i = 0; i < 256; i++)
                for (j = 0; j < 256; j++)
                {
                    diff = coder.origImage[i, j] - decoder.decMatrix[i, j];
                    if (diff > max) max = diff;
                    if (diff < min) min = diff;
                }
            minBox.Text = Convert.ToString(min);
            maxBox.Text = Convert.ToString(max);
        }

        private void histRefreshButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 511; i++)
            {
                histVect[i] = 0;
            }
            if (radioButton13.Checked)
                calcHistByte(coder.origImage);
            else if (radioButton14.Checked)
                calcHist(coder.predErrMatrix);
            else if (radioButton15.Checked)
                calcHist(coder.predErrMatrixQ);
            else if (radioButton16.Checked)
                calcHistByte(decoder.decMatrix);
            Graphics g = histPictureBox.CreateGraphics();
            Color color = Color.MediumBlue;

            g.Clear(Color.White);
            double scale = System.Convert.ToDouble(histScaleTextBox.Text);
            for (int i = 0; i < 511; i++)
            {

                g.DrawLine(new Pen(color), i, histPictureBox.Height - Convert.ToInt32(histVect[i] * scale), i, histPictureBox.Height);

            }

        }
        public void calcHist(int[,] mat)
        {
            int i,j;
                for (i = 0; i < 256; i++)
                    for (j = 0; j < 256; j++)
                        histVect[mat[i, j] + 256]++;
        }
        public void calcHistByte(byte[,] mat)
        {
            int i, j;
            for (i = 0; i < 256; i++)
                for (j = 0; j < 256; j++)
                    histVect[mat[i, j] + 256]++;
        }

    }
}
