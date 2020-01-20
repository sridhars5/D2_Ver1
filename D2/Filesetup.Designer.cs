namespace D2
{
    partial class Filesetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filesetup));
            panel1 = new System.Windows.Forms.Panel();
            button3 = new System.Windows.Forms.Button();
            sensor_call_btn = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            FileFormSave_btn = new System.Windows.Forms.Button();
            cancel_btn = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            stave_txt = new System.Windows.Forms.TextBox();
            thickness_txt = new System.Windows.Forms.TextBox();
            channel_txt = new System.Windows.Forms.TextBox();
            diameter_txt = new System.Windows.Forms.TextBox();
            gap_txt = new System.Windows.Forms.TextBox();
            width_txt = new System.Windows.Forms.TextBox();
            angle_txt = new System.Windows.Forms.TextBox();
            length_stave_txt = new System.Windows.Forms.TextBox();
            name_txt = new System.Windows.Forms.TextBox();
            button4 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel1.BackColor = System.Drawing.Color.SteelBlue;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(sensor_call_btn);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(FileFormSave_btn);
            panel1.Controls.Add(cancel_btn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(stave_txt);
            panel1.Controls.Add(thickness_txt);
            panel1.Controls.Add(channel_txt);
            panel1.Controls.Add(diameter_txt);
            panel1.Controls.Add(gap_txt);
            panel1.Controls.Add(width_txt);
            panel1.Controls.Add(angle_txt);
            panel1.Controls.Add(length_stave_txt);
            panel1.Controls.Add(name_txt);
            panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panel1.ForeColor = System.Drawing.Color.ForestGreen;
            panel1.Location = new System.Drawing.Point(-2, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(435, 298);
            panel1.TabIndex = 0;
            panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
            panel1.Leave += new System.EventHandler(name_txt_Leave);
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(346, 86);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(78, 63);
            button3.TabIndex = 76;
            button3.Text = "Opbox";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(button3_Click);
            // 
            // sensor_call_btn
            // 
            sensor_call_btn.Location = new System.Drawing.Point(13, 157);
            sensor_call_btn.Name = "sensor_call_btn";
            sensor_call_btn.Size = new System.Drawing.Size(75, 58);
            sensor_call_btn.TabIndex = 75;
            sensor_call_btn.Text = "button3";
            sensor_call_btn.UseVisualStyleBackColor = true;
            sensor_call_btn.Click += new System.EventHandler(sensor_call_btn_Click);
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(357, 175);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 40);
            button2.TabIndex = 74;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);
            // 
            // FileFormSave_btn
            // 
            FileFormSave_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            FileFormSave_btn.BackColor = System.Drawing.Color.White;
            FileFormSave_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FileFormSave_btn.BackgroundImage")));
            FileFormSave_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            FileFormSave_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            FileFormSave_btn.ForeColor = System.Drawing.Color.DimGray;
            FileFormSave_btn.Location = new System.Drawing.Point(346, 239);
            FileFormSave_btn.Name = "FileFormSave_btn";
            FileFormSave_btn.Size = new System.Drawing.Size(89, 59);
            FileFormSave_btn.TabIndex = 73;
            FileFormSave_btn.Text = "SAVE";
            FileFormSave_btn.UseVisualStyleBackColor = false;
            FileFormSave_btn.Click += new System.EventHandler(FileFormSave_btn_Click);
            // 
            // cancel_btn
            // 
            cancel_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel_btn.BackgroundImage")));
            cancel_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            cancel_btn.Location = new System.Drawing.Point(3, 239);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new System.Drawing.Size(85, 60);
            cancel_btn.TabIndex = 72;
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += new System.EventHandler(cancel_btn_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Black;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(159, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 20);
            label2.TabIndex = 71;
            label2.Text = "File Set UP";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(444, 654);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(114, 48);
            button1.TabIndex = 22;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // stave_txt
            // 
            stave_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            stave_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stave_txt.ForeColor = System.Drawing.Color.Blue;
            stave_txt.Location = new System.Drawing.Point(100, 53);
            stave_txt.Multiline = true;
            stave_txt.Name = "stave_txt";
            stave_txt.Size = new System.Drawing.Size(232, 25);
            stave_txt.TabIndex = 21;
            stave_txt.Text = "No. of Stave";
            stave_txt.Enter += new System.EventHandler(stave_txt_Enter);
            stave_txt.Leave += new System.EventHandler(stave_txt_Leave);
            // 
            // thickness_txt
            // 
            thickness_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            thickness_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            thickness_txt.ForeColor = System.Drawing.Color.Blue;
            thickness_txt.Location = new System.Drawing.Point(100, 270);
            thickness_txt.Multiline = true;
            thickness_txt.Name = "thickness_txt";
            thickness_txt.Size = new System.Drawing.Size(232, 25);
            thickness_txt.TabIndex = 19;
            thickness_txt.Text = "Thickness";
            thickness_txt.Enter += new System.EventHandler(thickness_txt_Enter);
            thickness_txt.Leave += new System.EventHandler(thickness_txt_Leave);
            // 
            // channel_txt
            // 
            channel_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            channel_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            channel_txt.ForeColor = System.Drawing.Color.Blue;
            channel_txt.Location = new System.Drawing.Point(100, 239);
            channel_txt.Multiline = true;
            channel_txt.Name = "channel_txt";
            channel_txt.Size = new System.Drawing.Size(232, 25);
            channel_txt.TabIndex = 17;
            channel_txt.Text = "Diameter of Channel";
            channel_txt.Enter += new System.EventHandler(channel_txt_Enter);
            channel_txt.Leave += new System.EventHandler(channel_txt_Leave);
            // 
            // diameter_txt
            // 
            diameter_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            diameter_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diameter_txt.ForeColor = System.Drawing.Color.Blue;
            diameter_txt.Location = new System.Drawing.Point(100, 208);
            diameter_txt.Multiline = true;
            diameter_txt.Name = "diameter_txt";
            diameter_txt.Size = new System.Drawing.Size(232, 25);
            diameter_txt.TabIndex = 15;
            diameter_txt.Text = "Diameter of Pipe";
            diameter_txt.Enter += new System.EventHandler(diameter_txt_Enter);
            diameter_txt.Leave += new System.EventHandler(diameter_txt_Leave);
            // 
            // gap_txt
            // 
            gap_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            gap_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gap_txt.ForeColor = System.Drawing.Color.Blue;
            gap_txt.Location = new System.Drawing.Point(100, 177);
            gap_txt.Multiline = true;
            gap_txt.Name = "gap_txt";
            gap_txt.Size = new System.Drawing.Size(232, 25);
            gap_txt.TabIndex = 13;
            gap_txt.Text = "Gap";
            gap_txt.TextChanged += new System.EventHandler(gap_txt_TextChanged);
            gap_txt.Enter += new System.EventHandler(gap_txt_Enter);
            gap_txt.Leave += new System.EventHandler(gap_txt_Leave);
            // 
            // width_txt
            // 
            width_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            width_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            width_txt.ForeColor = System.Drawing.Color.Blue;
            width_txt.Location = new System.Drawing.Point(100, 146);
            width_txt.Multiline = true;
            width_txt.Name = "width_txt";
            width_txt.Size = new System.Drawing.Size(232, 25);
            width_txt.TabIndex = 11;
            width_txt.Text = "Width";
            width_txt.Enter += new System.EventHandler(width_txt_Enter);
            width_txt.Leave += new System.EventHandler(width_txt_Leave);
            // 
            // angle_txt
            // 
            angle_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            angle_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            angle_txt.ForeColor = System.Drawing.Color.Blue;
            angle_txt.Location = new System.Drawing.Point(100, 115);
            angle_txt.Multiline = true;
            angle_txt.Name = "angle_txt";
            angle_txt.Size = new System.Drawing.Size(232, 25);
            angle_txt.TabIndex = 9;
            angle_txt.Text = "Angle of Bend";
            angle_txt.Enter += new System.EventHandler(angle_txt_Enter);
            angle_txt.Leave += new System.EventHandler(angle_txt_Leave);
            // 
            // length_stave_txt
            // 
            length_stave_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            length_stave_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            length_stave_txt.ForeColor = System.Drawing.Color.Blue;
            length_stave_txt.Location = new System.Drawing.Point(100, 84);
            length_stave_txt.Multiline = true;
            length_stave_txt.Name = "length_stave_txt";
            length_stave_txt.Size = new System.Drawing.Size(232, 25);
            length_stave_txt.TabIndex = 7;
            length_stave_txt.Text = "Length of Stave";
            length_stave_txt.Enter += new System.EventHandler(length_stave_txt_Enter);
            length_stave_txt.Leave += new System.EventHandler(length_stave_txt_Leave);
            // 
            // name_txt
            // 
            name_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            name_txt.ForeColor = System.Drawing.Color.Blue;
            name_txt.Location = new System.Drawing.Point(100, 22);
            name_txt.Multiline = true;
            name_txt.Name = "name_txt";
            name_txt.Size = new System.Drawing.Size(232, 25);
            name_txt.TabIndex = 20;
            name_txt.Text = "Enter Name";
            name_txt.TextChanged += new System.EventHandler(name_txt_TextChanged);
            name_txt.Enter += new System.EventHandler(name_txt_Enter);
            name_txt.Leave += new System.EventHandler(name_txt_Leave_1);
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(13, 51);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(75, 89);
            button4.TabIndex = 77;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(button4_Click);
            // 
            // Filesetup
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(434, 301);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Filesetup";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Filesetup";
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(Filesetup_FormClosing);
            Load += new System.EventHandler(Filesetup_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox thickness_txt;
        private System.Windows.Forms.TextBox channel_txt;
        private System.Windows.Forms.TextBox diameter_txt;
        private System.Windows.Forms.TextBox gap_txt;
        private System.Windows.Forms.TextBox width_txt;
        private System.Windows.Forms.TextBox angle_txt;
        private System.Windows.Forms.TextBox length_stave_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox stave_txt;
        private System.Windows.Forms.Button button1;
     //   private System.Windows.Forms.Button Savevalues_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button FileFormSave_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sensor_call_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}