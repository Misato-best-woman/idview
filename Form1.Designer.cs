namespace IdView
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.attrBox = new System.Windows.Forms.GroupBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ideaImage = new System.Windows.Forms.PictureBox();
            this.categoryName = new System.Windows.Forms.Label();
            this.descriptBox = new System.Windows.Forms.Label();
            this.attrBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ideaImage)).BeginInit();
            this.SuspendLayout();
            // 
            // attrBox
            // 
            this.attrBox.Controls.Add(this.descriptBox);
            this.attrBox.Controls.Add(this.categoryName);
            this.attrBox.Controls.Add(this.categoryLabel);
            this.attrBox.Location = new System.Drawing.Point(406, 12);
            this.attrBox.Name = "attrBox";
            this.attrBox.Size = new System.Drawing.Size(382, 310);
            this.attrBox.TabIndex = 1;
            this.attrBox.TabStop = false;
            this.attrBox.Text = "Attributes";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(6, 271);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(61, 13);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Category:";
            this.categoryLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "< Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 73);
            this.button2.TabIndex = 3;
            this.button2.Text = "Next >";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ideaImage
            // 
            this.ideaImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ideaImage.Image = ((System.Drawing.Image)(resources.GetObject("ideaImage.Image")));
            this.ideaImage.Location = new System.Drawing.Point(12, 32);
            this.ideaImage.Name = "ideaImage";
            this.ideaImage.Size = new System.Drawing.Size(388, 392);
            this.ideaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ideaImage.TabIndex = 4;
            this.ideaImage.TabStop = false;
            this.ideaImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // categoryName
            // 
            this.categoryName.AutoSize = true;
            this.categoryName.Location = new System.Drawing.Point(70, 271);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(35, 13);
            this.categoryName.TabIndex = 3;
            this.categoryName.Text = "label1";
            this.categoryName.Click += new System.EventHandler(this.categoryName_Click);
            // 
            // descriptBox
            // 
            this.descriptBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.descriptBox.Location = new System.Drawing.Point(9, 20);
            this.descriptBox.Name = "descriptBox";
            this.descriptBox.Size = new System.Drawing.Size(365, 240);
            this.descriptBox.TabIndex = 4;
            this.descriptBox.Text = "label1";
            this.descriptBox.Click += new System.EventHandler(this.descriptBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ideaImage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.attrBox);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.Text = "IdView - An IdSave Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.attrBox.ResumeLayout(false);
            this.attrBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ideaImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox attrBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox ideaImage;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label categoryName;
        private System.Windows.Forms.Label descriptBox;
    }
}

