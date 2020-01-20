namespace D2.Properties
{
    partial class Resultgraph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultgraph));
            menu_btn = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            back_btn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            SuspendLayout();
            // 
            // menu_btn
            // 
            menu_btn.BackColor = System.Drawing.Color.White;
            menu_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_btn.BackgroundImage")));
            menu_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            menu_btn.Location = new System.Drawing.Point(470, 226);
            menu_btn.Name = "menu_btn";
            menu_btn.Size = new System.Drawing.Size(80, 70);
            menu_btn.TabIndex = 66;
            menu_btn.UseVisualStyleBackColor = false;
            menu_btn.Click += new System.EventHandler(menu_btn_Click);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(236, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(311, 190);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // back_btn
            // 
            back_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            back_btn.BackColor = System.Drawing.Color.White;
            back_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_btn.BackgroundImage")));
            back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            back_btn.Location = new System.Drawing.Point(0, 227);
            back_btn.Name = "back_btn";
            back_btn.Size = new System.Drawing.Size(80, 70);
            back_btn.TabIndex = 64;
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += new System.EventHandler(back_btn_Click);
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.MidnightBlue;
            label1.Location = new System.Drawing.Point(232, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 24);
            label1.TabIndex = 2;
            label1.Text = "File Set UP";
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(menu_btn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(back_btn);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(550, 296);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Location = new System.Drawing.Point(3, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(218, 190);
            pictureBox2.TabIndex = 67;
            pictureBox2.TabStop = false;
            // 
            // Resultgraph
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(551, 301);
            Controls.Add(panel1);
            MaximumSize = new System.Drawing.Size(567, 340);
            MinimumSize = new System.Drawing.Size(567, 340);
            Name = "Resultgraph";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Resultgraph";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menu_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}