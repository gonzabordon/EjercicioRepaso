namespace WindowsFormsApp1
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
            this.BregistrarAlumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BregistrarAlumno
            // 
            this.BregistrarAlumno.Location = new System.Drawing.Point(251, 112);
            this.BregistrarAlumno.Name = "BregistrarAlumno";
            this.BregistrarAlumno.Size = new System.Drawing.Size(79, 45);
            this.BregistrarAlumno.TabIndex = 0;
            this.BregistrarAlumno.Text = "Registar Alumno";
            this.BregistrarAlumno.UseVisualStyleBackColor = true;
            this.BregistrarAlumno.Click += new System.EventHandler(this.BregistrarAlumno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 286);
            this.Controls.Add(this.BregistrarAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BregistrarAlumno;
    }
}

