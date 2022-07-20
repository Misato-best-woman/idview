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
            this.imageBox = new System.Windows.Forms.GroupBox();
            this.descriptBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(12, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(382, 310);
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            this.imageBox.Text = "Image";
            this.imageBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // descriptBox
            // 
            this.descriptBox.Location = new System.Drawing.Point(406, 12);
            this.descriptBox.Name = "descriptBox";
            this.descriptBox.Size = new System.Drawing.Size(382, 310);
            this.descriptBox.TabIndex = 1;
            this.descriptBox.TabStop = false;
            this.descriptBox.Text = "Attributes";
            this.descriptBox.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 0);
            this.Controls.Add(this.descriptBox);
            this.Controls.Add(this.imageBox);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.Text = "IdView - An IdSave Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox imageBox;
        private System.Windows.Forms.GroupBox descriptBox;
    }
}

