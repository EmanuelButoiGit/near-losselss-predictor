using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Image_Prediction
{
    public partial class Form1 : Form
    {
        private BitReader bitReader;
        private string input;
        private string inputOriginal;
        private string tipPredictor;
        private string tipSave;
        private string comboPredictor;
        private int imgSize;
        private int pathPredictor;
        private byte[] antet;
        private int[,] mCodorEroarePredictie;
        private byte[,] mCodorOriginala;
        private byte[,] mCodorPredictie;
        private byte[,] mCodorPredictie2;
        private byte[,] mEroareDisplay;
        private int[,] mCodorEroareQ;
        private int[,] mCodorEroareDq;
        private byte[,] mCodorDecodare;
        private int[,] mCodorEroare;
        private int[,] mDecodorEroareQ;
        private int[,] mDecodorEroareDq;
        private byte[,] mDecodorPredictie;
        private byte[,] mDecodorDecodare;
        private int[,] mDecodorEroarePredictie;
        private int decoderK;
        private int predictor;
        private int saveMode;

        public Form1()
        {
            InitializeComponent();
            input = null;
            inputOriginal = null;
            tipPredictor = null;
            tipSave = null;
            comboPredictor = null;
            imgSize = 256;
            pathPredictor = 0;
            antet = new byte[1078];
            mCodorOriginala = new byte[imgSize, imgSize];
            mCodorEroarePredictie = new int[imgSize, imgSize];
            mCodorPredictie = new byte[imgSize, imgSize];
            mCodorPredictie2 = new byte[imgSize, imgSize];
            mEroareDisplay = new byte[imgSize, imgSize];
            mCodorEroareQ = new int[imgSize, imgSize];
            mCodorEroareDq = new int[imgSize, imgSize];
            mCodorDecodare = new byte[imgSize, imgSize];
            mCodorEroare = new int[imgSize, imgSize];
            mDecodorEroareQ = new int[imgSize, imgSize];
            mDecodorEroareDq = new int[imgSize, imgSize];
            mDecodorPredictie = new byte[imgSize, imgSize];
            mDecodorDecodare = new byte[imgSize, imgSize];
            mDecodorEroarePredictie = new int[imgSize, imgSize];
            decoderK = 0;
            predictor = 0;
            saveMode = 0;
            chartHistograma.ChartAreas[0].AxisX.Minimum = -256;
            chartHistograma.ChartAreas[0].AxisX.Maximum = 256;
            chartHistograma.ChartAreas[0].AxisY.Maximum = 511;
            kNumericUpDown.Maximum = 10;

        }

        private byte[,] CitireImagine(byte[,] mImagine)
        {
            bitReader = new BitReader(input);

            for (int i = 0; i < 1078; i++)
            {
                antet[i] = (byte)bitReader.ReadNBits(8);
            }

            for (int i = 0; i < imgSize; i++)
            {
                for (int j = 0; j < imgSize; j++)
                {
                    int pixel = bitReader.ReadNBits(8);
                    mImagine[i, j] = (byte)pixel;
                }
            }

            return mImagine;
        } 

        private void LoadGrayscaleBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                input = openFileDialog1.FileName;
                inputOriginal = input;
            }

            FileStream fs = new System.IO.FileStream(input, FileMode.Open, FileAccess.Read);
            pictureBox1.Image = Image.FromStream(fs);
            fs.Close();

            CitireImagine(mCodorOriginala);
            showHistogramBtn_Click(sender, e);
        }

        private void StoreEncodarePredictor(BitWriter bitWriter)
        {
            switch (comboPredictor)
            {
                case "128":
                    bitWriter.WriteNBits(0, 4);
                    break;
                case "A":
                    bitWriter.WriteNBits(1, 4);
                    break;
                case "B":
                    bitWriter.WriteNBits(2, 4);
                    break;
                case "C":
                    bitWriter.WriteNBits(3, 4);
                    break;
                case "A+B-C":
                    bitWriter.WriteNBits(4, 4);
                    break;
                case "A+(B-C)/2":
                    bitWriter.WriteNBits(5, 4);
                    break;
                case "B+(A-C)/2":
                    bitWriter.WriteNBits(6, 4);
                    break;
                case "(A+B)/2":
                    bitWriter.WriteNBits(7, 4);
                    break;
                case "jpegLS":
                    bitWriter.WriteNBits(8, 4);
                    break;
            }
        }

        int FindLine(int line, int pixel)
        {
            if (pixel == 0)
            {
                return 0;
            }

            for (int x = 1; x <= 8; x++)
            {
                if (Math.Abs(pixel) < Math.Pow(2, x) && Math.Abs(pixel) >= Math.Pow(2, x - 1))
                {
                    line = x;
                }
            }

            return line;
        }

        private void StoreFisier()
        {
            BitWriter bitWriter = new BitWriter(input);

            for (int i = 0; i < 1078; i++)
            {
                bitWriter.WriteNBits(antet[i], 8);
            }

            bitWriter.WriteNBits((int) kNumericUpDown.Value, 4);
            StoreEncodarePredictor(bitWriter); //4 biti
            
            if (tipSave == "F")
            {
                bitWriter.WriteNBits(0, 2);

                for (int i = 0; i < imgSize; i++)
                {
                    for (int j = 0; j < imgSize; j++)
                    {
                        bitWriter.WriteNBits(mCodorEroareQ[i, j], 32);
                    }
                }
            }

            if (tipSave == "T")
            {
                bitWriter.WriteNBits(1, 2);

                for (int i = 0; i < imgSize; i++)
                {
                    for (int j = 0; j < imgSize; j++)
                    {
                        if (mCodorEroareQ[i, j] == 0)
                        {
                            bitWriter.WriteNBits(0, 1);
                        }
                        else
                        {
                            int line = 0;
                            line = FindLine(line, mCodorEroareQ[i, j]);
                            int indexLine = line;

                            while (indexLine > 0)
                            {
                                bitWriter.WriteNBits(1, 1);
                                indexLine--;
                            }
                            bitWriter.WriteNBits(0, 1);

                            if (mCodorEroareQ[i, j] >= 0)
                            {
                                bitWriter.WriteNBits(mCodorEroareQ[i, j], line);
                            }

                            else
                            {
                                bitWriter.WriteNBits((mCodorEroareQ[i, j] + Convert.ToInt32(Math.Pow(2, line) - 1)), line);
                            }
                        }
                    }
                }
            }

            bitWriter.WriteNBits(0, 7);
            bitWriter.Dispose();
        }

        int SeePredictor()
        {
            comboPredictor = predictieComboBox.SelectedItem.ToString();

            switch (comboPredictor)
            {
                case "128":
                    return 1;
                case "A":
                    return 2;
                case "B":
                    return 3;
                case "C":
                    return 4;
                case "A+B-C":
                    return 5;
                case "A+(B-C)/2":
                    return 6;
                case "B+(A-C)/2":
                    return 7;
                case "(A+B)/2":
                    return 8;
                case "jpegLS":
                    return 9;
                default:
                    return 0;
            }
        }

        private void StoreBtn_Click(object sender, EventArgs e)
        {
            tipSave = saveComboBox.Text.ToString();

            if(tipSave == "fix")
            {
                tipSave = "F";
            }
            else if(tipSave == "table")
            {
                tipSave = "T";
            }

            pathPredictor = SeePredictor();

            input = input + ".p" + pathPredictor + "k" + kNumericUpDown.Value.ToString() + tipSave + ".prd";
            var myFile = File.Create(input);
            myFile.Close();

            StoreFisier();
            
        }

        private void SaveDecodedBtn_Click(object sender, EventArgs e)
        {
            input += ".bmp";
            var myFile = File.Create(input);
            myFile.Close();

            BitWriter bitWriter = new BitWriter(input);
            Bitmap bmp2 = new Bitmap(imgSize, imgSize);

            input = "";

            for (int i = 0; i < 1078; i++)
            {
                bitWriter.WriteNBits(antet[i], 8);
            }

            for (int i = 0; i < imgSize; i++)
            {
                for (int j = 0; j < imgSize; j++)
                {
                    bitWriter.WriteNBits(mDecodorDecodare[i, j], 8);
                    var color = Color.FromArgb(mDecodorDecodare[i, j], mDecodorDecodare[i, j], mDecodorDecodare[i, j]);
                    bmp2.SetPixel(i, j, color);
                }
            }

            bmp2.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox3.Image = bmp2;
            bitWriter.Dispose();
            input = inputOriginal;
        }

        public void CheckPredictor(int pred)
        {
            switch (pred)
            {
                case 0:
                    tipPredictor = "128";
                    break;
                case 1:
                    tipPredictor = "A";
                    break;
                case 2:
                    tipPredictor = "B";
                    break;
                case 3:
                    tipPredictor = "C";
                    break;
                case 4:
                    tipPredictor = "A+B-C";
                    break;
                case 5:
                    tipPredictor = "A+(B-C)/2";
                    break;
                case 6:
                    tipPredictor = "B+(A-C)/2";
                    break;
                case 7:
                    tipPredictor = "(A+B)/2";
                    break;
                case 8:
                    tipPredictor = "jpegLS";
                    break;
            }
        }

        private void LoadEncodedBtn_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "prd files (*.prd)|*.prd|All files (*.*)|*.*";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                input = openFileDialog2.FileName;
            }

            bitReader = new BitReader(input);

            for (int i = 0; i < 1078; i++)
            {
                antet[i] = (byte)bitReader.ReadNBits(8);
            }

            decoderK = bitReader.ReadNBits(4);
            predictor = bitReader.ReadNBits(4);
            CheckPredictor(predictor);
            saveMode = bitReader.ReadNBits(2);

            if (saveMode == 0)
            {
                tipSave = "fixed";
                for (int i = 0; i < imgSize; i++)
                {
                    for (int j = 0; j < imgSize; j++)
                    {
                        mDecodorEroareQ[i, j] = bitReader.ReadNBits(32);
                    }
                }

            }

            else if(saveMode == 1)
            {
                tipSave = "table";
                for (int i = 0; i < imgSize; i++)
                {
                    for (int j = 0; j < imgSize; j++)
                    {
                        int counter = 0;
                        int bit = (int)bitReader.ReadBit();

                        while(bit != 0)
                        {
                            bit = (int)bitReader.ReadBit();
                            counter++;
                        }

                        int line = bitReader.ReadNBits(counter);

                        if (line >= Convert.ToInt32(Math.Pow(2, line - 1)))
                        {
                            mDecodorEroareQ[i, j] = Convert.ToInt32(line);
                        }
                        else
                        {
                            mDecodorEroareQ[i, j] = Convert.ToInt32(line - (Convert.ToInt32(Math.Pow(2, counter)) - 1));
                        }

                    }
                }
            }

            bitReader.Dispose();

        }


        private byte Predictionare(byte[,] mPredictionata, int i, int j)
        {
            int regula = 0;

            if (i == 0 && j == 0)
            {
                mPredictionata[i, j] = 128;
                return mPredictionata[i,j];
            }

            else if (i == 0 && j != 0)
            {
                mPredictionata[i, j] = mPredictionata[i, j - 1];
                return mPredictionata[i, j];
            }

            else if (i != 0 && j == 0)
            {
                mPredictionata[i, j] = mPredictionata[i - 1, j];
                return mPredictionata[i, j];
            }

            else if (i != 0 && j != 0)
            {
                var A = mPredictionata[i, j - 1];
                var B = mPredictionata[i - 1, j];
                var C = mPredictionata[i - 1, j - 1];


                switch (tipPredictor)
                {
                    case "128":
                        regula = 128;
                        break;
                    case "A":
                        regula = A;
                        break;
                    case "B":
                        regula = B;
                        break;
                    case "C":
                        regula = C;
                        break;
                    case "A+B-C":
                        regula = (int)(A + B - C);
                        break;
                    case "A+(B-C)/2":
                        regula = (int)(A + (B - C) / 2);
                        break;
                    case "B+(A-C)/2":
                        regula = (int)(B + (A - C) / 2);
                        break;
                    case "(A+B)/2":
                        regula = (int)((A + B) / 2);
                        break;
                    case "jpegLS":
                        byte max = Math.Max(A, B);
                        byte min = Math.Min(A, B);

                        if (C >= max)
                        {
                            regula = min;
                        }

                        else if (C <= min)
                        {
                            regula = max;
                        }

                        else
                        {
                            regula = (int)(A + B - C);
                        }
                        break;
                }

                mPredictionata[i, j] = (byte) (Normalizare(regula));
                return mPredictionata[i, j];
            }

            return mPredictionata[i, j];
        }

        private int Normalizare(int pixel)
        {

            if (pixel < 0)
            {
                return 0;
            }

            else if (pixel > imgSize)
            {
                return 255;
            }

            else
            {
                return pixel;
            }
        }

        private void PredictBtn_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            pictureBox3.Image = null;

            tipPredictor = predictieComboBox.SelectedItem.ToString();
            int k = (int)kNumericUpDown.Value;
            for (int i = 0; i < imgSize; i++)
            {
                for (int j = 0; j < imgSize; j++)
                {
                    mCodorPredictie[i, j] = Predictionare(mCodorDecodare, i, j);
                    mCodorEroarePredictie[i, j] = (int) (mCodorOriginala[i, j] - mCodorPredictie[i, j]);
                    mCodorEroareQ[i, j] = (int) Math.Floor((mCodorEroarePredictie[i, j] + k) / (2.0 * k + 1));
                    mCodorEroareDq[i, j] = mCodorEroareQ[i, j] * (2 * k + 1);
                    mCodorPredictie2[i, j] = Predictionare(mCodorDecodare, i, j);
                    mCodorDecodare[i, j] = (byte) (Normalizare(mCodorEroareDq[i, j] + mCodorPredictie2[i, j]));
                    mCodorEroare[i, j] = mCodorOriginala[i, j] - mCodorDecodare[i, j];
                }

            }

        }

        private void ShowErrorMatrixBtn_Click(object sender, EventArgs e)
        {
            double contrast = double.Parse(contrastTextBox.Text);
            Bitmap bmp = new Bitmap(imgSize, imgSize);
            string errorSelect = errorComboBox.Text;

            if (errorSelect == "prediction error")
            {
                for (int i = 0; i < imgSize; i++)
                {
                    for (int j = 0; j < imgSize; j++)
                    {
                        mEroareDisplay[i, j] = (byte)(128 + mCodorEroarePredictie[i, j] * contrast);
                        var color = Color.FromArgb(mEroareDisplay[i, j], mEroareDisplay[i, j], mEroareDisplay[i, j]);
                        bmp.SetPixel(i, j, color);
                    }
                }
            }

            else if(errorSelect == "q prediction error")
            {
                for (int i = 0; i < imgSize; i++)
                {
                    for (int j = 0; j < imgSize; j++)
                    {
                        mEroareDisplay[i, j] = (byte)(128 + mCodorEroareQ[i, j] * contrast);
                        var color = Color.FromArgb(mEroareDisplay[i, j], mEroareDisplay[i, j], mEroareDisplay[i, j]);
                        bmp.SetPixel(i, j, color);
                    }
                }
            }

            bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox2.Image = bmp;
        }

        private void DecodeBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < imgSize; i++)
            {
                for (int j = 0; j < imgSize; j++)
                {
                    mDecodorEroareDq[i, j] = mDecodorEroareQ[i, j] * (2 * decoderK + 1);
                    mDecodorPredictie[i, j] = Predictionare(mDecodorDecodare, i, j);
                    mDecodorDecodare[i, j] = (byte) Normalizare(mDecodorEroareDq[i, j] + ((int) mDecodorPredictie[i, j]));
                    mDecodorEroarePredictie[i, j] = mCodorOriginala[i, j] - mDecodorDecodare[i, j];
                }
            }

        }

        private int[] CalcHistograma(int[,] matrix)
        {
            int[] freq = new int[imgSize];

            for (int i = 0; i < imgSize; i++)
            {
                freq[i] = 0;
            }

            for (int i = 0; i < imgSize; i++)
            {
                for (int j = 0; j < imgSize; j++)
                {
                    int pixel = matrix[i, j];

                    if (pixel < 0)
                    {
                        pixel = 0;
                    }
                    else if (pixel > 255)
                    {
                        pixel = 255;
                    }

                    if (pixel != 0)
                    {
                        freq[pixel]++;
                    }
                }
            }

            return freq;
        }

        private int[] CalcHistograma(byte[,] matrix)
        {
            int[] freq = new int[imgSize];

            for (int i = 0; i < imgSize; i++)
            {
                freq[i] = 0;
            }

            for (int i = 0; i < imgSize; i++)
            {
                for (int j = 0; j < imgSize; j++)
                {
                    int pixel = matrix[i, j];
                    freq[pixel]++;
                }
            }

            return freq;
        }

        private int[] PopValoriAxa()
        {
            int[] values = new int[imgSize];

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = i;
            }

            return values;
        }

        private void showHistogramBtn_Click(object sender, EventArgs e)
        {
            /*
            Original
            Error
            Coder Q Prediction Error
            Decoded
            Decoder Prediction Error
            Decoder Q Prediction Error
            Decoder Decoded
             */

            int[] frecventa = null;
            int[] pixeli = null;

            string comboShowSelectat = comboBox2.SelectedItem.ToString();
            double scale = (double)numericUpDownScale.Value;

            switch (comboShowSelectat)
            {
                case "Original":
                frecventa = CalcHistograma(mCodorOriginala);
                    break;
                case "Error":
                    frecventa = CalcHistograma(mCodorEroarePredictie);
                    break;
                case "Coder Q Prediction Error":
                    frecventa = CalcHistograma(mCodorEroareQ);
                    break;
                case "Decoded":
                    frecventa = CalcHistograma(mCodorDecodare);
                    break;
                case "Decoder Prediction Error":
                    frecventa = CalcHistograma(mDecodorEroarePredictie);
                    break;
                case "Decoder Q Prediction Error":
                    frecventa = CalcHistograma(mDecodorEroareQ);
                    break;
                case "Decoder Decoded":
                    frecventa = CalcHistograma(mDecodorDecodare);
                    break;
            }

            pixeli = PopValoriAxa();
            chartHistograma.Series[0].Points.DataBindXY(pixeli, ScallingValues(frecventa));

        }

        public int[] ScallingValues(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Convert.ToInt32(values[i] * Convert.ToDouble(numericUpDownScale.Value));
            }

            return values;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CompErrorBtn_Click(object sender, EventArgs e)
        {
            double min, max;
            min = double.MaxValue;
            max = double.MinValue;

            for (int i = 0; i < imgSize; i++)
            {
                for (int j = 0; j < imgSize; j++)
                {

                    if (mDecodorEroarePredictie[i, j] < min)
                    {
                        min = mDecodorEroarePredictie[i, j]; 
                    }

                    else if (mDecodorEroarePredictie[i, j] > max)
                    {
                        max = mDecodorEroarePredictie[i, j];
                    }
                }
            }

            minLabel.Text = min.ToString();
            maxLabel.Text = max.ToString();
        }

    }
}
