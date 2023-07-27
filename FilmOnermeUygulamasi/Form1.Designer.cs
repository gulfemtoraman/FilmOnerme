namespace FilmOnermeUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_yerli = new System.Windows.Forms.Button();
            this.btn_yabanci = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_yerli
            // 
            this.btn_yerli.Location = new System.Drawing.Point(122, 278);
            this.btn_yerli.Name = "btn_yerli";
            this.btn_yerli.Size = new System.Drawing.Size(180, 91);
            this.btn_yerli.TabIndex = 0;
            this.btn_yerli.Text = "Yerli";
            this.btn_yerli.UseVisualStyleBackColor = true;
            this.btn_yerli.Click += new System.EventHandler(this.btn_yerli_Click);
            // 
            // btn_yabanci
            // 
            this.btn_yabanci.Location = new System.Drawing.Point(474, 278);
            this.btn_yabanci.Name = "btn_yabanci";
            this.btn_yabanci.Size = new System.Drawing.Size(180, 91);
            this.btn_yabanci.TabIndex = 1;
            this.btn_yabanci.Text = "Yabancı";
            this.btn_yabanci.UseVisualStyleBackColor = true;
            this.btn_yabanci.Click += new System.EventHandler(this.btn_yabanci_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FilmOnermeUygulamasi.Properties.Resources.yabanciFilm;
            this.pictureBox2.Location = new System.Drawing.Point(474, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lütfen seçiniz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(766, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_yabanci);
            this.Controls.Add(this.btn_yerli);
            this.Name = "Form1";
            this.Text = "Film Önerme Uygulaması";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_yerli;
        private Button btn_yabanci;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}