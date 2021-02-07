namespace QLNS_Nhom1
{
    partial class FormMT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMT));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnpre = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "anh1.png");
            this.imageList1.Images.SetKeyName(1, "anh2 .png");
            this.imageList1.Images.SetKeyName(2, "anh3.png");
            this.imageList1.Images.SetKeyName(3, "anh4.png");
            this.imageList1.Images.SetKeyName(4, "anh5.png");
            this.imageList1.Images.SetKeyName(5, "anh6.png");
            this.imageList1.Images.SetKeyName(6, "anh7.png");
            this.imageList1.Images.SetKeyName(7, "anh8.png");
            this.imageList1.Images.SetKeyName(8, "anh9.png");
            this.imageList1.Images.SetKeyName(9, "anh10 .png");
            this.imageList1.Images.SetKeyName(10, "anh11.png");
            this.imageList1.Images.SetKeyName(11, "anh12.png");
            this.imageList1.Images.SetKeyName(12, "anh13.png");
            this.imageList1.Images.SetKeyName(13, "anh14.png");
            this.imageList1.Images.SetKeyName(14, "anh15.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 247);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnpre
            // 
            this.btnpre.Location = new System.Drawing.Point(38, 283);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(75, 23);
            this.btnpre.TabIndex = 1;
            this.btnpre.Text = "preview";
            this.btnpre.UseVisualStyleBackColor = true;
            this.btnpre.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(241, 283);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 2;
            this.btnnext.Text = "next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // FormMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 326);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnpre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMT";
            this.Text = "FormMT";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Button btnnext;
    }
}