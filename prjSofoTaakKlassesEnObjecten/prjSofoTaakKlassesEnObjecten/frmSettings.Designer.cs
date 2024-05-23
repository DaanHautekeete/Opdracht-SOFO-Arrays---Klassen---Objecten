namespace prjSofoTaakKlassesEnObjecten
{
    partial class frmSettings
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
            this.btnExit = new System.Windows.Forms.Button();
            this.BtnVerwijder = new System.Windows.Forms.Button();
            this.lsbCustomProperties = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(113, 120);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // BtnVerwijder
            // 
            this.BtnVerwijder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerwijder.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerwijder.Location = new System.Drawing.Point(12, 120);
            this.BtnVerwijder.Name = "BtnVerwijder";
            this.BtnVerwijder.Size = new System.Drawing.Size(95, 40);
            this.BtnVerwijder.TabIndex = 3;
            this.BtnVerwijder.Text = "REMOVE";
            this.BtnVerwijder.UseVisualStyleBackColor = true;
            // 
            // lsbCustomProperties
            // 
            this.lsbCustomProperties.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbCustomProperties.FormattingEnabled = true;
            this.lsbCustomProperties.ItemHeight = 16;
            this.lsbCustomProperties.Location = new System.Drawing.Point(12, 12);
            this.lsbCustomProperties.Name = "lsbCustomProperties";
            this.lsbCustomProperties.Size = new System.Drawing.Size(202, 100);
            this.lsbCustomProperties.TabIndex = 2;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 170);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnVerwijder);
            this.Controls.Add(this.lsbCustomProperties);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button BtnVerwijder;
        private System.Windows.Forms.ListBox lsbCustomProperties;
    }
}