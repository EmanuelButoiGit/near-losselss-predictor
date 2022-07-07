namespace Image_Prediction
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadGrayscaleBtn = new System.Windows.Forms.Button();
            this.predictBtn = new System.Windows.Forms.Button();
            this.storeBtn = new System.Windows.Forms.Button();
            this.showErrorMatrixBtn = new System.Windows.Forms.Button();
            this.loadEncodedBtn = new System.Windows.Forms.Button();
            this.decodeBtn = new System.Windows.Forms.Button();
            this.saveDecodedBtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.predictieComboBox = new System.Windows.Forms.ComboBox();
            this.showHistogramBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.contrastTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.saveComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.compErrorBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.errorComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownScale = new System.Windows.Forms.NumericUpDown();
            this.chartHistograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistograma)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 350);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loadGrayscaleBtn
            // 
            this.loadGrayscaleBtn.Location = new System.Drawing.Point(132, 368);
            this.loadGrayscaleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadGrayscaleBtn.Name = "loadGrayscaleBtn";
            this.loadGrayscaleBtn.Size = new System.Drawing.Size(152, 30);
            this.loadGrayscaleBtn.TabIndex = 3;
            this.loadGrayscaleBtn.Text = "load image grayscale";
            this.loadGrayscaleBtn.UseVisualStyleBackColor = true;
            this.loadGrayscaleBtn.Click += new System.EventHandler(this.LoadGrayscaleBtn_Click);
            // 
            // predictBtn
            // 
            this.predictBtn.Location = new System.Drawing.Point(144, 404);
            this.predictBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.predictBtn.Name = "predictBtn";
            this.predictBtn.Size = new System.Drawing.Size(136, 23);
            this.predictBtn.TabIndex = 4;
            this.predictBtn.Text = "predict (encode)";
            this.predictBtn.UseVisualStyleBackColor = true;
            this.predictBtn.Click += new System.EventHandler(this.PredictBtn_Click);
            // 
            // storeBtn
            // 
            this.storeBtn.Location = new System.Drawing.Point(171, 432);
            this.storeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.storeBtn.Name = "storeBtn";
            this.storeBtn.Size = new System.Drawing.Size(75, 23);
            this.storeBtn.TabIndex = 5;
            this.storeBtn.Text = "save";
            this.storeBtn.UseVisualStyleBackColor = true;
            this.storeBtn.Click += new System.EventHandler(this.StoreBtn_Click);
            // 
            // showErrorMatrixBtn
            // 
            this.showErrorMatrixBtn.Location = new System.Drawing.Point(544, 427);
            this.showErrorMatrixBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showErrorMatrixBtn.Name = "showErrorMatrixBtn";
            this.showErrorMatrixBtn.Size = new System.Drawing.Size(127, 23);
            this.showErrorMatrixBtn.TabIndex = 7;
            this.showErrorMatrixBtn.Text = "show error matrix";
            this.showErrorMatrixBtn.UseVisualStyleBackColor = true;
            this.showErrorMatrixBtn.Click += new System.EventHandler(this.ShowErrorMatrixBtn_Click);
            // 
            // loadEncodedBtn
            // 
            this.loadEncodedBtn.Location = new System.Drawing.Point(945, 368);
            this.loadEncodedBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadEncodedBtn.Name = "loadEncodedBtn";
            this.loadEncodedBtn.Size = new System.Drawing.Size(111, 23);
            this.loadEncodedBtn.TabIndex = 8;
            this.loadEncodedBtn.Text = "load encoded";
            this.loadEncodedBtn.UseVisualStyleBackColor = true;
            this.loadEncodedBtn.Click += new System.EventHandler(this.LoadEncodedBtn_Click);
            // 
            // decodeBtn
            // 
            this.decodeBtn.Location = new System.Drawing.Point(964, 398);
            this.decodeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decodeBtn.Name = "decodeBtn";
            this.decodeBtn.Size = new System.Drawing.Size(71, 26);
            this.decodeBtn.TabIndex = 9;
            this.decodeBtn.Text = "decode";
            this.decodeBtn.UseVisualStyleBackColor = true;
            this.decodeBtn.Click += new System.EventHandler(this.DecodeBtn_Click);
            // 
            // saveDecodedBtn
            // 
            this.saveDecodedBtn.Location = new System.Drawing.Point(933, 428);
            this.saveDecodedBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveDecodedBtn.Name = "saveDecodedBtn";
            this.saveDecodedBtn.Size = new System.Drawing.Size(132, 23);
            this.saveDecodedBtn.TabIndex = 10;
            this.saveDecodedBtn.Text = "save and show";
            this.saveDecodedBtn.UseVisualStyleBackColor = true;
            this.saveDecodedBtn.Click += new System.EventHandler(this.SaveDecodedBtn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Original",
            "Error",
            "Coder Q Prediction Error",
            "Decoded",
            "Decoder Prediction Error",
            "Decoder Q Prediction Error",
            "Decoder Decoded"});
            this.comboBox2.Location = new System.Drawing.Point(855, 640);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 24);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Text = "Original";
            // 
            // predictieComboBox
            // 
            this.predictieComboBox.FormattingEnabled = true;
            this.predictieComboBox.Items.AddRange(new object[] {
            "128",
            "A",
            "B",
            "C",
            "A+B-C",
            "A+(B-C)/2",
            "B+(A-C)/2",
            "(A+B)/2",
            "jpegLS"});
            this.predictieComboBox.Location = new System.Drawing.Point(160, 465);
            this.predictieComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.predictieComboBox.Name = "predictieComboBox";
            this.predictieComboBox.Size = new System.Drawing.Size(100, 24);
            this.predictieComboBox.TabIndex = 13;
            this.predictieComboBox.Text = "128";
            // 
            // showHistogramBtn
            // 
            this.showHistogramBtn.Location = new System.Drawing.Point(868, 715);
            this.showHistogramBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showHistogramBtn.Name = "showHistogramBtn";
            this.showHistogramBtn.Size = new System.Drawing.Size(125, 23);
            this.showHistogramBtn.TabIndex = 14;
            this.showHistogramBtn.Text = "show histogram";
            this.showHistogramBtn.UseVisualStyleBackColor = true;
            this.showHistogramBtn.Click += new System.EventHandler(this.showHistogramBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(416, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(387, 350);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(809, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(387, 350);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // contrastTextBox
            // 
            this.contrastTextBox.Location = new System.Drawing.Point(557, 398);
            this.contrastTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contrastTextBox.Name = "contrastTextBox";
            this.contrastTextBox.Size = new System.Drawing.Size(100, 22);
            this.contrastTextBox.TabIndex = 17;
            this.contrastTextBox.Text = "13";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Predictor type: ";
            // 
            // kNumericUpDown
            // 
            this.kNumericUpDown.Location = new System.Drawing.Point(160, 535);
            this.kNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kNumericUpDown.Name = "kNumericUpDown";
            this.kNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.kNumericUpDown.TabIndex = 19;
            this.kNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Save mode:";
            // 
            // saveComboBox
            // 
            this.saveComboBox.FormattingEnabled = true;
            this.saveComboBox.Items.AddRange(new object[] {
            "fix",
            "table"});
            this.saveComboBox.Location = new System.Drawing.Point(160, 501);
            this.saveComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveComboBox.Name = "saveComboBox";
            this.saveComboBox.Size = new System.Drawing.Size(100, 24);
            this.saveComboBox.TabIndex = 20;
            this.saveComboBox.Text = "fix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "K value:";
            // 
            // compErrorBtn
            // 
            this.compErrorBtn.Location = new System.Drawing.Point(544, 494);
            this.compErrorBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.compErrorBtn.Name = "compErrorBtn";
            this.compErrorBtn.Size = new System.Drawing.Size(127, 23);
            this.compErrorBtn.TabIndex = 23;
            this.compErrorBtn.Text = "compute error";
            this.compErrorBtn.UseVisualStyleBackColor = true;
            this.compErrorBtn.Click += new System.EventHandler(this.CompErrorBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Max value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Min value:";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(619, 535);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(15, 16);
            this.maxLabel.TabIndex = 26;
            this.maxLabel.Text = "?";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(619, 562);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(15, 16);
            this.minLabel.TabIndex = 27;
            this.minLabel.Text = "?";
            // 
            // errorComboBox
            // 
            this.errorComboBox.FormattingEnabled = true;
            this.errorComboBox.Items.AddRange(new object[] {
            "prediction error",
            "q prediction error"});
            this.errorComboBox.Location = new System.Drawing.Point(544, 462);
            this.errorComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.errorComboBox.Name = "errorComboBox";
            this.errorComboBox.Size = new System.Drawing.Size(127, 24);
            this.errorComboBox.TabIndex = 28;
            this.errorComboBox.Text = "prediction error";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "contrast:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(869, 682);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Scale:";
            // 
            // numericUpDownScale
            // 
            this.numericUpDownScale.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDownScale.Location = new System.Drawing.Point(923, 679);
            this.numericUpDownScale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownScale.Name = "numericUpDownScale";
            this.numericUpDownScale.Size = new System.Drawing.Size(71, 22);
            this.numericUpDownScale.TabIndex = 31;
            this.numericUpDownScale.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // chartHistograma
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHistograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHistograma.Legends.Add(legend1);
            this.chartHistograma.Location = new System.Drawing.Point(12, 604);
            this.chartHistograma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartHistograma.Name = "chartHistograma";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Frecventa Pixelilor";
            this.chartHistograma.Series.Add(series1);
            this.chartHistograma.Size = new System.Drawing.Size(727, 374);
            this.chartHistograma.TabIndex = 34;
            this.chartHistograma.Text = "chartHistograma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 1039);
            this.Controls.Add(this.chartHistograma);
            this.Controls.Add(this.numericUpDownScale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.errorComboBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.compErrorBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveComboBox);
            this.Controls.Add(this.kNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contrastTextBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.showHistogramBtn);
            this.Controls.Add(this.predictieComboBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.saveDecodedBtn);
            this.Controls.Add(this.decodeBtn);
            this.Controls.Add(this.loadEncodedBtn);
            this.Controls.Add(this.showErrorMatrixBtn);
            this.Controls.Add(this.storeBtn);
            this.Controls.Add(this.predictBtn);
            this.Controls.Add(this.loadGrayscaleBtn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Near Losseless";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistograma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadGrayscaleBtn;
        private System.Windows.Forms.Button predictBtn;
        private System.Windows.Forms.Button storeBtn;
        private System.Windows.Forms.Button showErrorMatrixBtn;
        private System.Windows.Forms.Button loadEncodedBtn;
        private System.Windows.Forms.Button decodeBtn;
        private System.Windows.Forms.Button saveDecodedBtn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox predictieComboBox;
        private System.Windows.Forms.Button showHistogramBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox contrastTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown kNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox saveComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button compErrorBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.ComboBox errorComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownScale;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistograma;
    }
}

