namespace prjSofoTaakKlassesEnObjecten {
    partial class frmEditOrNew {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.picProfilePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // picProfilePicture
            // 
            this.picProfilePicture.Image = global::prjSofoTaakKlassesEnObjecten.Properties.Resources.DefaultProfilePic;
            this.picProfilePicture.Location = new System.Drawing.Point(13, 13);
            this.picProfilePicture.Name = "picProfilePicture";
            this.picProfilePicture.Size = new System.Drawing.Size(150, 150);
            this.picProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfilePicture.TabIndex = 0;
            this.picProfilePicture.TabStop = false;
            // 
            // frmEditOrNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 558);
            this.Controls.Add(this.picProfilePicture);
            this.Name = "frmEditOrNew";
            this.Text = "EDITING CONTACTNAAM - CREATING NEW CONTACT";
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picProfilePicture;
    }
}