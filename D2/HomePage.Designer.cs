namespace D2
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            selectpro_btn = new System.Windows.Forms.Button();
            createpjt_btm = new System.Windows.Forms.Button();
            record_btn = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label7);
            panel1.Location = new System.Drawing.Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(548, 299);
            panel1.TabIndex = 0;
            panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(selectpro_btn, 0, 0);
            tableLayoutPanel1.Controls.Add(createpjt_btm, 1, 0);
            tableLayoutPanel1.Controls.Add(record_btn, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 1, 1);
            tableLayoutPanel1.Location = new System.Drawing.Point(112, 34);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(325, 262);
            tableLayoutPanel1.TabIndex = 71;
            // 
            // selectpro_btn
            // 
            selectpro_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            selectpro_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectpro_btn.BackgroundImage")));
            selectpro_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            selectpro_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            selectpro_btn.Location = new System.Drawing.Point(26, 10);
            selectpro_btn.Name = "selectpro_btn";
            selectpro_btn.Size = new System.Drawing.Size(110, 110);
            selectpro_btn.TabIndex = 68;
            selectpro_btn.Text = "Select \r\nProfile";
            selectpro_btn.UseVisualStyleBackColor = true;
            // 
            // createpjt_btm
            // 
            createpjt_btm.Anchor = System.Windows.Forms.AnchorStyles.None;
            createpjt_btm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createpjt_btm.BackgroundImage")));
            createpjt_btm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            createpjt_btm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createpjt_btm.Location = new System.Drawing.Point(188, 10);
            createpjt_btm.Name = "createpjt_btm";
            createpjt_btm.Size = new System.Drawing.Size(110, 110);
            createpjt_btm.TabIndex = 70;
            createpjt_btm.Text = "Create\r\n Project";
            createpjt_btm.UseVisualStyleBackColor = true;
            createpjt_btm.Click += new System.EventHandler(createpjt_btm_Click);
            // 
            // record_btn
            // 
            record_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            record_btn.BackColor = System.Drawing.Color.White;
            record_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("record_btn.BackgroundImage")));
            record_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            record_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            record_btn.Location = new System.Drawing.Point(26, 141);
            record_btn.Name = "record_btn";
            record_btn.Size = new System.Drawing.Size(110, 110);
            record_btn.TabIndex = 69;
            record_btn.Text = "Record";
            record_btn.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.Yellow;
            label7.Location = new System.Drawing.Point(201, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(162, 31);
            label7.TabIndex = 67;
            label7.Text = "File Set UP";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Aqua;
            button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button1.Location = new System.Drawing.Point(165, 134);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(133, 117);
            button1.TabIndex = 71;
            button1.Text = "WaveForm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // HomePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            ClientSize = new System.Drawing.Size(551, 301);
            Controls.Add(panel1);
            MinimumSize = new System.Drawing.Size(567, 340);
            Name = "HomePage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "HomePage";
            TransparencyKey = System.Drawing.Color.Navy;
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(HomePage_FormClosing);
            Load += new System.EventHandler(HomePage_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button createpjt_btm;
        private System.Windows.Forms.Button record_btn;
        private System.Windows.Forms.Button selectpro_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}