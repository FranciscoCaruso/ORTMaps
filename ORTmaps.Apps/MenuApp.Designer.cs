namespace ORTmaps.Apps
{
    partial class MenuApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuApp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMapaMenu = new System.Windows.Forms.Button();
            this.btnMapaOrtMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 478);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // btnMapaMenu
            // 
            this.btnMapaMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMapaMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMapaMenu.BackgroundImage")));
            this.btnMapaMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMapaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapaMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMapaMenu.Location = new System.Drawing.Point(17, 205);
            this.btnMapaMenu.Name = "btnMapaMenu";
            this.btnMapaMenu.Size = new System.Drawing.Size(198, 43);
            this.btnMapaMenu.TabIndex = 2;
            this.btnMapaMenu.UseVisualStyleBackColor = false;
            this.btnMapaMenu.Click += new System.EventHandler(this.BtnMapaMenu_Click);
            // 
            // btnMapaOrtMenu
            // 
            this.btnMapaOrtMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMapaOrtMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMapaOrtMenu.BackgroundImage")));
            this.btnMapaOrtMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMapaOrtMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapaOrtMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMapaOrtMenu.Location = new System.Drawing.Point(17, 127);
            this.btnMapaOrtMenu.Name = "btnMapaOrtMenu";
            this.btnMapaOrtMenu.Size = new System.Drawing.Size(198, 42);
            this.btnMapaOrtMenu.TabIndex = 3;
            this.btnMapaOrtMenu.UseVisualStyleBackColor = false;
            this.btnMapaOrtMenu.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MenuApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btnMapaOrtMenu);
            this.Controls.Add(this.btnMapaMenu);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "MenuApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMapaMenu;
        private System.Windows.Forms.Button btnMapaOrtMenu;
    }
}