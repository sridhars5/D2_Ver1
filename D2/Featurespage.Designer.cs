namespace D2
{
    partial class Featurespage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Featurespage));
            panel1 = new System.Windows.Forms.Panel();
            range_Box = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            velocity_Box = new System.Windows.Forms.GroupBox();
            trackBar3 = new System.Windows.Forms.TrackBar();
            Delay_Box = new System.Windows.Forms.GroupBox();
            trackBar1 = new System.Windows.Forms.TrackBar();
            zero_Box = new System.Windows.Forms.GroupBox();
            trackBar2 = new System.Windows.Forms.TrackBar();
            zero_btn = new System.Windows.Forms.Button();
            delay_btn = new System.Windows.Forms.Button();
            range_btn = new System.Windows.Forms.Button();
            velocity_btn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            Save_btn = new System.Windows.Forms.Button();
            BasicCancel_btn = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            range_Box.SuspendLayout();
            velocity_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(trackBar3)).BeginInit();
            Delay_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(trackBar1)).BeginInit();
            zero_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(trackBar2)).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel1.Controls.Add(BasicCancel_btn);
            panel1.Controls.Add(Save_btn);
            panel1.Controls.Add(range_Box);
            panel1.Controls.Add(velocity_Box);
            panel1.Controls.Add(Delay_Box);
            panel1.Controls.Add(zero_Box);
            panel1.Controls.Add(zero_btn);
            panel1.Controls.Add(delay_btn);
            panel1.Controls.Add(range_btn);
            panel1.Controls.Add(velocity_btn);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(760, 587);
            panel1.TabIndex = 1;
            // 
            // range_Box
            // 
            range_Box.Controls.Add(label4);
            range_Box.Controls.Add(label3);
            range_Box.Controls.Add(label2);
            range_Box.Controls.Add(textBox3);
            range_Box.Controls.Add(textBox2);
            range_Box.Controls.Add(textBox1);
            range_Box.Enabled = false;
            range_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            range_Box.ForeColor = System.Drawing.Color.Navy;
            range_Box.Location = new System.Drawing.Point(361, 152);
            range_Box.Name = "range_Box";
            range_Box.Size = new System.Drawing.Size(380, 100);
            range_Box.TabIndex = 14;
            range_Box.TabStop = false;
            range_Box.Text = "Range";
            range_Box.Visible = false;
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
            textBox3.Size = new System.Drawing.Size(100, 36);
            textBox3.TabIndex = 2;
            textBox3.Text = "  ";
            textBox3.TextChanged += new System.EventHandler(textBox3_TextChanged);
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(146, 58);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 36);
            textBox2.TabIndex = 1;
            textBox2.Text = "Inch";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(27, 58);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 36);
            textBox1.TabIndex = 0;
            textBox1.Text = "mm";
            // 
            // velocity_Box
            // 
            velocity_Box.Controls.Add(trackBar3);
            velocity_Box.Enabled = false;
            velocity_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            velocity_Box.ForeColor = System.Drawing.Color.Navy;
            velocity_Box.Location = new System.Drawing.Point(361, 53);
            velocity_Box.Name = "velocity_Box";
            velocity_Box.Size = new System.Drawing.Size(380, 73);
            velocity_Box.TabIndex = 14;
            velocity_Box.TabStop = false;
            velocity_Box.Text = "Velocity";
            velocity_Box.Visible = false;
            // 
            // trackBar3
            // 
            trackBar3.Location = new System.Drawing.Point(27, 28);
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new System.Drawing.Size(319, 45);
            trackBar3.TabIndex = 12;
            // 
            // Delay_Box
            // 
            Delay_Box.Controls.Add(trackBar1);
            Delay_Box.Enabled = false;
            Delay_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Delay_Box.ForeColor = System.Drawing.Color.Navy;
            Delay_Box.Location = new System.Drawing.Point(361, 392);
            Delay_Box.Name = "Delay_Box";
            Delay_Box.Size = new System.Drawing.Size(380, 81);
            Delay_Box.TabIndex = 14;
            Delay_Box.TabStop = false;
            Delay_Box.Text = "Delay";
            Delay_Box.Visible = false;
            // 
            // trackBar1
            // 
            trackBar1.Location = new System.Drawing.Point(27, 28);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(319, 45);
            trackBar1.TabIndex = 12;
            // 
            // zero_Box
            // 
            zero_Box.Controls.Add(trackBar2);
            zero_Box.Enabled = false;
            zero_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zero_Box.ForeColor = System.Drawing.Color.Navy;
            zero_Box.Location = new System.Drawing.Point(361, 274);
            zero_Box.Name = "zero_Box";
            zero_Box.Size = new System.Drawing.Size(380, 77);
            zero_Box.TabIndex = 13;
            zero_Box.TabStop = false;
            zero_Box.Text = "Zero";
            zero_Box.Visible = false;
            // 
            // trackBar2
            // 
            trackBar2.Location = new System.Drawing.Point(27, 28);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new System.Drawing.Size(319, 45);
            trackBar2.TabIndex = 12;
            // 
            // zero_btn
            // 
            zero_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            zero_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zero_btn.BackgroundImage")));
            zero_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            zero_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zero_btn.Location = new System.Drawing.Point(23, 274);
            zero_btn.Name = "zero_btn";
            zero_btn.Size = new System.Drawing.Size(200, 80);
            zero_btn.TabIndex = 10;
            zero_btn.Text = "Zero";
            zero_btn.UseVisualStyleBackColor = true;
            zero_btn.Click += new System.EventHandler(zero_btn_Click);
            // 
            // delay_btn
            // 
            delay_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            delay_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delay_btn.BackgroundImage")));
            delay_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            delay_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            delay_btn.Location = new System.Drawing.Point(23, 392);
            delay_btn.Name = "delay_btn";
            delay_btn.Size = new System.Drawing.Size(200, 80);
            delay_btn.TabIndex = 9;
            delay_btn.Text = "Delay";
            delay_btn.UseVisualStyleBackColor = true;
            delay_btn.Click += new System.EventHandler(delay_btn_Click);
            // 
            // range_btn
            // 
            range_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            range_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("range_btn.BackgroundImage")));
            range_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            range_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            range_btn.Location = new System.Drawing.Point(23, 166);
            range_btn.Name = "range_btn";
            range_btn.Size = new System.Drawing.Size(200, 80);
            range_btn.TabIndex = 7;
            range_btn.Text = "Range";
            range_btn.UseVisualStyleBackColor = true;
            range_btn.Click += new System.EventHandler(range_btn_Click);
            // 
            // velocity_btn
            // 
            velocity_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            velocity_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("velocity_btn.BackgroundImage")));
            velocity_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            velocity_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            velocity_btn.Location = new System.Drawing.Point(23, 53);
            velocity_btn.Name = "velocity_btn";
            velocity_btn.Size = new System.Drawing.Size(200, 80);
            velocity_btn.TabIndex = 1;
            velocity_btn.Text = "Velocity";
            velocity_btn.UseVisualStyleBackColor = true;
            velocity_btn.Click += new System.EventHandler(velocity_btn_Click);
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.MidnightBlue;
            label1.Location = new System.Drawing.Point(292, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(187, 29);
            label1.TabIndex = 0;
            label1.Text = "Basic Features";
            // 
            // Save_btn
            // 
            Save_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            Save_btn.BackColor = System.Drawing.Color.White;
            Save_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save_btn.BackgroundImage")));
            Save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Save_btn.Location = new System.Drawing.Point(556, 484);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new System.Drawing.Size(204, 100);
            Save_btn.TabIndex = 68;
            Save_btn.Text = "SAVE";
            Save_btn.UseVisualStyleBackColor = false;
            Save_btn.Click += new System.EventHandler(Save_btn_Click);
            // 
            // BasicCancel_btn
            // 
            BasicCancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            BasicCancel_btn.BackColor = System.Drawing.Color.Black;
            BasicCancel_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BasicCancel_btn.BackgroundImage")));
            BasicCancel_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            BasicCancel_btn.Location = new System.Drawing.Point(0, 484);
            BasicCancel_btn.Name = "BasicCancel_btn";
            BasicCancel_btn.Size = new System.Drawing.Size(200, 100);
            BasicCancel_btn.TabIndex = 71;
            BasicCancel_btn.UseVisualStyleBackColor = false;
            BasicCancel_btn.Click += new System.EventHandler(BasicCancel_btn_Click);
            // 
            // Featurespage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(784, 611);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Featurespage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Featurespage";
            Load += new System.EventHandler(Featurespage_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            range_Box.ResumeLayout(false);
            range_Box.PerformLayout();
            velocity_Box.ResumeLayout(false);
            velocity_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(trackBar3)).EndInit();
            Delay_Box.ResumeLayout(false);
            Delay_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(trackBar1)).EndInit();
            zero_Box.ResumeLayout(false);
            zero_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(trackBar2)).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button zero_btn;
        private System.Windows.Forms.Button delay_btn;
        private System.Windows.Forms.Button range_btn;
        private System.Windows.Forms.Button velocity_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.GroupBox zero_Box;
        private System.Windows.Forms.GroupBox range_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox velocity_Box;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.GroupBox Delay_Box;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button BasicCancel_btn;
    }
}