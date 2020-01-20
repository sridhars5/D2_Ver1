namespace D2
{
    partial class ReceiverInputPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiverInputPage));
            panel1 = new System.Windows.Forms.Panel();
            Filter_Box = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            Gain_Box = new System.Windows.Forms.GroupBox();
            trackBar3 = new System.Windows.Forms.TrackBar();
            Signal_Box = new System.Windows.Forms.GroupBox();
            zero_btn = new System.Windows.Forms.Button();
            range_btn = new System.Windows.Forms.Button();
            velocity_btn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Save_btn = new System.Windows.Forms.Button();
            Rceivercancel_btn = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            Filter_Box.SuspendLayout();
            Gain_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(trackBar3)).BeginInit();
            Signal_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(chart1)).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            panel1.Controls.Add(Rceivercancel_btn);
            panel1.Controls.Add(Save_btn);
            panel1.Controls.Add(Filter_Box);
            panel1.Controls.Add(Gain_Box);
            panel1.Controls.Add(Signal_Box);
            panel1.Controls.Add(zero_btn);
            panel1.Controls.Add(range_btn);
            panel1.Controls.Add(velocity_btn);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(779, 609);
            panel1.TabIndex = 2;
            // 
            // Filter_Box
            // 
            Filter_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            Filter_Box.BackColor = System.Drawing.Color.White;
            Filter_Box.Controls.Add(comboBox2);
            Filter_Box.Controls.Add(comboBox1);
            Filter_Box.Controls.Add(label3);
            Filter_Box.Controls.Add(label2);
            Filter_Box.Enabled = false;
            Filter_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Filter_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            Filter_Box.Location = new System.Drawing.Point(490, 220);
            Filter_Box.Name = "Filter_Box";
            Filter_Box.Size = new System.Drawing.Size(281, 109);
            Filter_Box.TabIndex = 14;
            Filter_Box.TabStop = false;
            Filter_Box.Text = "Filter";
            Filter_Box.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            label3.Location = new System.Drawing.Point(160, 30);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(113, 16);
            label3.TabIndex = 4;
            label3.Text = "Low Pass Filter";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            label2.Location = new System.Drawing.Point(27, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 16);
            label2.TabIndex = 3;
            label2.Text = "High Pass Filter";
            // 
            // Gain_Box
            // 
            Gain_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            Gain_Box.BackColor = System.Drawing.Color.White;
            Gain_Box.Controls.Add(trackBar3);
            Gain_Box.Enabled = false;
            Gain_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Gain_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            Gain_Box.Location = new System.Drawing.Point(493, 106);
            Gain_Box.Name = "Gain_Box";
            Gain_Box.Size = new System.Drawing.Size(286, 78);
            Gain_Box.TabIndex = 14;
            Gain_Box.TabStop = false;
            Gain_Box.Text = "Gain";
            Gain_Box.Visible = false;
            // 
            // trackBar3
            // 
            trackBar3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            trackBar3.BackColor = System.Drawing.Color.White;
            trackBar3.Location = new System.Drawing.Point(27, 28);
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new System.Drawing.Size(251, 45);
            trackBar3.TabIndex = 12;
            // 
            // Signal_Box
            // 
            Signal_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            Signal_Box.BackColor = System.Drawing.Color.White;
            Signal_Box.Controls.Add(chart1);
            Signal_Box.Enabled = false;
            Signal_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Signal_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            Signal_Box.Location = new System.Drawing.Point(493, 343);
            Signal_Box.Name = "Signal_Box";
            Signal_Box.Size = new System.Drawing.Size(283, 132);
            Signal_Box.TabIndex = 13;
            Signal_Box.TabStop = false;
            Signal_Box.Text = "Signal";
            Signal_Box.Visible = false;
            // 
            // zero_btn
            // 
            zero_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            zero_btn.BackColor = System.Drawing.Color.Transparent;
            zero_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zero_btn.BackgroundImage")));
            zero_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            zero_btn.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zero_btn.ForeColor = System.Drawing.Color.Black;
            zero_btn.Location = new System.Drawing.Point(3, 343);
            zero_btn.Name = "zero_btn";
            zero_btn.Size = new System.Drawing.Size(200, 80);
            zero_btn.TabIndex = 10;
            zero_btn.Text = "RF Display";
            zero_btn.UseVisualStyleBackColor = false;
            zero_btn.Click += new System.EventHandler(zero_btn_Click);
            // 
            // range_btn
            // 
            range_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            range_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("range_btn.BackgroundImage")));
            range_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            range_btn.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            range_btn.ForeColor = System.Drawing.Color.Black;
            range_btn.Location = new System.Drawing.Point(3, 220);
            range_btn.Name = "range_btn";
            range_btn.Size = new System.Drawing.Size(200, 80);
            range_btn.TabIndex = 7;
            range_btn.Text = "Filter";
            range_btn.UseVisualStyleBackColor = true;
            range_btn.Click += new System.EventHandler(range_btn_Click);
            // 
            // velocity_btn
            // 
            velocity_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            velocity_btn.BackColor = System.Drawing.Color.White;
            velocity_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("velocity_btn.BackgroundImage")));
            velocity_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            velocity_btn.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            velocity_btn.ForeColor = System.Drawing.Color.Black;
            velocity_btn.Location = new System.Drawing.Point(0, 106);
            velocity_btn.Name = "velocity_btn";
            velocity_btn.Size = new System.Drawing.Size(200, 80);
            velocity_btn.TabIndex = 1;
            velocity_btn.Text = "Gain";
            velocity_btn.UseVisualStyleBackColor = false;
            velocity_btn.Click += new System.EventHandler(velocity_btn_Click);
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Navy;
            label1.Location = new System.Drawing.Point(269, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(250, 37);
            label1.TabIndex = 0;
            label1.Text = "Receiver Inputs";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] {
            "40K",
            "80K",
            "160K",
            "320K",
            "640K",
            "1.25M",
            "2.5M",
            "5M"});
            comboBox1.Location = new System.Drawing.Point(30, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(77, 32);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] {
            "200K",
            "400K",
            "800K",
            "1.6M",
            "3.2M",
            "6.4M",
            "12.5M",
            "25M"});
            comboBox2.Location = new System.Drawing.Point(163, 54);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(83, 32);
            comboBox2.TabIndex = 6;
            // 
            // chart1
            // 
            chart1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            chartArea3.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart1.Legends.Add(legend3);
            chart1.Location = new System.Drawing.Point(37, 28);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart1.Series.Add(series3);
            chart1.Size = new System.Drawing.Size(231, 92);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // Save_btn
            // 
            Save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            Save_btn.BackColor = System.Drawing.Color.White;
            Save_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save_btn.BackgroundImage")));
            Save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Save_btn.ForeColor = System.Drawing.Color.Black;
            Save_btn.Location = new System.Drawing.Point(571, 506);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new System.Drawing.Size(200, 100);
            Save_btn.TabIndex = 68;
            Save_btn.Text = "SAVE";
            Save_btn.UseVisualStyleBackColor = false;
            // 
            // Rceivercancel_btn
            // 
            Rceivercancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            Rceivercancel_btn.BackColor = System.Drawing.Color.Black;
            Rceivercancel_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rceivercancel_btn.BackgroundImage")));
            Rceivercancel_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Rceivercancel_btn.Location = new System.Drawing.Point(3, 509);
            Rceivercancel_btn.Name = "Rceivercancel_btn";
            Rceivercancel_btn.Size = new System.Drawing.Size(200, 100);
            Rceivercancel_btn.TabIndex = 69;
            Rceivercancel_btn.UseVisualStyleBackColor = false;
            Rceivercancel_btn.Click += new System.EventHandler(Rceivercancel_btn_Click);
            // 
            // ReceiverInputPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(784, 611);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(650, 650);
            Name = "ReceiverInputPage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ReceiverInputPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Filter_Box.ResumeLayout(false);
            Filter_Box.PerformLayout();
            Gain_Box.ResumeLayout(false);
            Gain_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(trackBar3)).EndInit();
            Signal_Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(chart1)).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Filter_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Gain_Box;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.GroupBox Signal_Box;
        private System.Windows.Forms.Button zero_btn;
        private System.Windows.Forms.Button range_btn;
        private System.Windows.Forms.Button velocity_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Rceivercancel_btn;
    }
}