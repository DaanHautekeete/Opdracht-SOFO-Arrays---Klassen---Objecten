namespace prjSofoTaakKlassesEnObjecten
{
    partial class frmAddCustomProperties
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
            this.lsbCustomProperties = new System.Windows.Forms.ListBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbCustomProperties
            // 
            this.lsbCustomProperties.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbCustomProperties.FormattingEnabled = true;
            this.lsbCustomProperties.ItemHeight = 16;
            this.lsbCustomProperties.Location = new System.Drawing.Point(17, 12);
            this.lsbCustomProperties.Name = "lsbCustomProperties";
            this.lsbCustomProperties.Size = new System.Drawing.Size(202, 100);
            this.lsbCustomProperties.TabIndex = 0;
            // 
            // btnAssign
            // 
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(17, 120);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(95, 40);
            this.btnAssign.TabIndex = 1;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(118, 120);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 40);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // frmAddCustomProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 171);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lsbCustomProperties);
            this.Name = "frmAddCustomProperties";
            this.Text = "CUSTOM PROPERTIES";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbCustomProperties;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnNew;
    }
}