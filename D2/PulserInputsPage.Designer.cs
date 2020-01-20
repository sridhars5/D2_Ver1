namespace D2
{
    partial class PulserInputsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PulserInputsPage));
            panel1 = new System.Windows.Forms.Panel();
            Save_btn = new System.Windows.Forms.Button();
            Damping_Box = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            voltage_Box = new System.Windows.Forms.GroupBox();
            trackBar3 = new System.Windows.Forms.TrackBar();
            Frequency_Box = new System.Windows.Forms.GroupBox();
            Damping_btn = new System.Windows.Forms.Button();
            Frequency_btn = new System.Windows.Forms.Button();
            votage_btn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            Rceivercancel_btn = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            Damping_Box.SuspendLayout();
            voltage_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(trackBar3)).BeginInit();
            Frequency_Box.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel1.Controls.Add(Rceivercancel_btn);
            panel1.Controls.Add(Save_btn);
            panel1.Controls.Add(Damping_Box);
            panel1.Controls.Add(voltage_Box);
            panel1.Controls.Add(Frequency_Box);
            panel1.Controls.Add(Damping_btn);
            panel1.Controls.Add(Frequency_btn);
            panel1.Controls.Add(votage_btn);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(4, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(776, 610);
            panel1.TabIndex = 2;
            // 
            // Save_btn
            // 
            Save_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            Save_btn.BackColor = System.Drawing.Color.White;
            Save_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save_btn.BackgroundImage")));
            Save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Save_btn.Location = new System.Drawing.Point(576, 507);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new System.Drawing.Size(200, 100);
            Save_btn.TabIndex = 67;
            Save_btn.Text = "SAVE";
            Save_btn.UseVisualStyleBackColor = false;
            Save_btn.Click += new System.EventHandler(menu_btn_Click);
            // 
            // Damping_Box
            // 
            Damping_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            Damping_Box.Controls.Add(label4);
            Damping_Box.Controls.Add(label3);
            Damping_Box.Controls.Add(label2);
            Damping_Box.Controls.Add(textBox3);
            Damping_Box.Controls.Add(textBox2);
            Damping_Box.Controls.Add(textBox1);
            Damping_Box.Enabled = false;
            Damping_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Damping_Box.ForeColor = System.Drawing.Color.Navy;
            Damping_Box.Location = new System.Drawing.Point(377, 316);
            Damping_Box.Name = "Damping_Box";
            Damping_Box.Size = new System.Drawing.Size(379, 124);
            Damping_Box.TabIndex = 14;
            Damping_Box.TabStop = false;
            Damping_Box.Text = "Damping";
            Damping_Box.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label4.Location = new System.Drawing.Point(260, 31);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 16);
            label4.TabIndex = 5;
            label4.Text = "Press 3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label3.Location = new System.Drawing.Point(142, 29);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 16);
            label3.TabIndex = 4;
            label3.Text = "Press 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label2.Location = new System.Drawing.Point(27, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 16);
            label2.TabIndex = 3;
            label2.Text = "Press 1";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(264, 58);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(108, 36);
            textBox3.TabIndex = 2;
            textBox3.Text = "  Not Needed";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(146, 58);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(81, 36);
            textBox2.TabIndex = 1;
            textBox2.Text = "Variable";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(27, 58);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(75, 36);
            textBox1.TabIndex = 0;
            textBox1.Text = "Fixed";
            textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
            // 
            // voltage_Box
            // 
            voltage_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            voltage_Box.Controls.Add(trackBar3);
            voltage_Box.Enabled = false;
            voltage_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            voltage_Box.ForeColor = System.Drawing.Color.Navy;
            voltage_Box.Location = new System.Drawing.Point(377, 75);
            voltage_Box.Name = "voltage_Box";
            voltage_Box.Size = new System.Drawing.Size(358, 88);
            voltage_Box.TabIndex = 14;
            voltage_Box.TabStop = false;
            voltage_Box.Text = "Voltage";
            voltage_Box.Visible = false;
            // 
            // trackBar3
            // 
            trackBar3.Anchor = System.Windows.Forms.AnchorStyles.None;
            trackBar3.BackColor = System.Drawing.Color.White;
            trackBar3.Location = new System.Drawing.Point(29, 39);
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new System.Drawing.Size(231, 45);
            trackBar3.TabIndex = 12;
            // 
            // Frequency_Box
            // 
            Frequency_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            Frequency_Box.Controls.Add(label5);
            Frequency_Box.Controls.Add(comboBox1);
            Frequency_Box.Enabled = false;
            Frequency_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Frequency_Box.ForeColor = System.Drawing.Color.Navy;
            Frequency_Box.Location = new System.Drawing.Point(377, 190);
            Frequency_Box.Name = "Frequency_Box";
            Frequency_Box.Size = new System.Drawing.Size(358, 111);
            Frequency_Box.TabIndex = 13;
            Frequency_Box.TabStop = false;
            Frequency_Box.Text = "Frequency";
            Frequency_Box.Visible = false;
            // 
            // Damping_btn
            // 
            Damping_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            Damping_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Damping_btn.BackgroundImage")));
            Damping_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Damping_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Damping_btn.Location = new System.Drawing.Point(3, 313);
            Damping_btn.Name = "Damping_btn";
            Damping_btn.Size = new System.Drawing.Size(200, 80);
            Damping_btn.TabIndex = 10;
            Damping_btn.Text = "Damping";
            Damping_btn.UseVisualStyleBackColor = true;
            Damping_btn.Click += new System.EventHandler(Damping_btn_Click);
            // 
            // Frequency_btn
            // 
            Frequency_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            Frequency_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Frequency_btn.BackgroundImage")));
            Frequency_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Frequency_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Frequency_btn.Location = new System.Drawing.Point(0, 190);
            Frequency_btn.Name = "Frequency_btn";
            Frequency_btn.Size = new System.Drawing.Size(200, 80);
            Frequency_btn.TabIndex = 7;
            Frequency_btn.Text = "Frequency";
            Frequency_btn.UseVisualStyleBackColor = true;
            Frequency_btn.Click += new System.EventHandler(Frequency_btn_Click);
            // 
            // votage_btn
            // 
            votage_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            votage_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("votage_btn.BackgroundImage")));
            votage_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            votage_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            votage_btn.Location = new System.Drawing.Point(4, 75);
            votage_btn.Name = "votage_btn";
            votage_btn.Size = new System.Drawing.Size(200, 80);
            votage_btn.TabIndex = 1;
            votage_btn.Text = "Voltage";
            votage_btn.UseVisualStyleBackColor = true;
            votage_btn.Click += new System.EventHandler(votage_btn_Click);
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.MidnightBlue;
            label1.Location = new System.Drawing.Point(299, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(216, 37);
            label1.TabIndex = 0;
            label1.Text = "Pulser Inputs";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] {
            "10MHz",
            "15MHz",
            "20MHz",
            "25MHz",
            "30MHz",
            "35MHz",
            "40MHz",
            "45MHz",
            "50MHz",
            "55MHz",
            "60MHz",
            "65MHz",
            "70MHz",
            "75MHz"});
            comboBox1.Location = new System.Drawing.Point(27, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(182, 32);
            comboBox1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(23, 26);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(111, 24);
            label5.TabIndex = 1;
            label5.Text = "Frequency";
            // 
            // Rceivercancel_btn
            // 
            Rceivercancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            Rceivercancel_btn.BackColor = System.Drawing.Color.Black;
            Rceivercancel_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rceivercancel_btn.BackgroundImage")));
            Rceivercancel_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Rceivercancel_btn.Location = new System.Drawing.Point(3, 507);
            Rceivercancel_btn.Name = "Rceivercancel_btn";
            Rceivercancel_btn.Size = new System.Drawing.Size(200, 100);
            Rceivercancel_btn.TabIndex = 70;
            Rceivercancel_btn.UseVisualStyleBackColor = false;
            // 
            // PulserInputsPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(784, 611);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PulserInputsPage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PulserInputsPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Damping_Box.ResumeLayout(false);
            Damping_Box.PerformLayout();
            voltage_Box.ResumeLayout(false);
            voltage_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(trackBar3)).EndInit();
            Frequency_Box.ResumeLayout(false);
            Frequency_Box.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.GroupBox Damping_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox voltage_Box;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.GroupBox Frequency_Box;
        private System.Windows.Forms.Button Damping_btn;
        private System.Windows.Forms.Button Frequency_btn;
        private System.Windows.Forms.Button votage_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Rceivercancel_btn;
    }
}