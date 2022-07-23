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
            this.descriptBox = new System.Windows.Forms.RichTextBox();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.attrBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // attrBox
            // 
            this.attrBox.Controls.Add(this.descriptBox);
            this.attrBox.Controls.Add(this.categoryBox);
            this.attrBox.Controls.Add(this.categoryLabel);
            this.attrBox.Location = new System.Drawing.Point(406, 12);
            this.attrBox.Name = "attrBox";
            this.attrBox.Size = new System.Drawing.Size(382, 310);
            this.attrBox.TabIndex = 1;
            this.attrBox.TabStop = false;
            this.attrBox.Text = "Attributes";
            // 
            // descriptBox
            // 
            this.descriptBox.Location = new System.Drawing.Point(9, 20);
            this.descriptBox.Name = "descriptBox";
            this.descriptBox.ReadOnly = true;
            this.descriptBox.Size = new System.Drawing.Size(367, 242);
            this.descriptBox.TabIndex = 2;
            this.descriptBox.Text = "";
            // 
            // categoryBox
            // 
            this.categoryBox.Location = new System.Drawing.Point(69, 268);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.ReadOnly = true;
            this.categoryBox.Size = new System.Drawing.Size(100, 20);
            this.categoryBox.TabIndex = 1;
            this.categoryBox.Text = "Category XX";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(6, 271);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(57, 13);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Category";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.attrBox);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.Text = "IdView - An IdSave Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.attrBox.ResumeLayout(false);
            this.attrBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox attrBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.RichTextBox descriptBox;
        private System.Windows.Forms.TextBox categoryBox;
    }
}

