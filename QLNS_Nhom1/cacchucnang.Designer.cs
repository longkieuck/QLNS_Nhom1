namespace QLNS_Nhom1
{
    partial class cacchucnang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cacchucnang));
            this.btnpre = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnpre
            // 
            this.btnpre.Location = new System.Drawing.Point(41, 331);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(75, 23);
            this.btnpre.TabIndex = 0;
            this.btnpre.Text = "preview";
            this.btnpre.UseVisualStyleBackColor = true;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(490, 331);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 1;
            this.btnnext.Text = "next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "anh1.PNG");
            this.imageList1.Images.SetKeyName(1, "anh2.PNG");
            this.imageList1.Images.SetKeyName(2, "anh3.PNG");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 295);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cacchucnang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnpre);
            this.Name = "cacchucnang";
            this.Text = "cacchucnang";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}