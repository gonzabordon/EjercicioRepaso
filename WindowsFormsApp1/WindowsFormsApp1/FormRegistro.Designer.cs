namespace WindowsFormsApp1
{
    partial class FormRegistro
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
            this.Lnombre = new System.Windows.Forms.Label();
            this.Ldni = new System.Windows.Forms.Label();
            this.Lnota = new System.Windows.Forms.Label();
            this.TBnotas = new System.Windows.Forms.TextBox();
            this.TBdni = new System.Windows.Forms.TextBox();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.Bok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lnombre
            // 
            this.Lnombre.AutoSize = true;
            this.Lnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnombre.Location = new System.Drawing.Point(140, 67);
            this.Lnombre.Name = "Lnombre";
            this.Lnombre.Size = new System.Drawing.Size(58, 17);
            this.Lnombre.TabIndex = 0;
            this.Lnombre.Text = "Nombre";
            // 
            // Ldni
            // 
            this.Ldni.AutoSize = true;
            this.Ldni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ldni.Location = new System.Drawing.Point(140, 108);
            this.Ldni.Name = "Ldni";
            this.Ldni.Size = new System.Drawing.Size(31, 17);
            this.Ldni.TabIndex = 1;
            this.Ldni.Text = "DNI";
            // 
            // Lnota
            // 
            this.Lnota.AutoSize = true;
            this.Lnota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnota.Location = new System.Drawing.Point(140, 155);
            this.Lnota.Name = "Lnota";
            this.Lnota.Size = new System.Drawing.Size(38, 17);
            this.Lnota.TabIndex = 2;
            this.Lnota.Text = "Nota";
            // 
            // TBnotas
            // 
            this.TBnotas.Location = new System.Drawing.Point(277, 155);
            this.TBnotas.Name = "TBnotas";
            this.TBnotas.Size = new System.Drawing.Size(100, 20);
            this.TBnotas.TabIndex = 3;
            // 
            // TBdni
            // 
            this.TBdni.Location = new System.Drawing.Point(277, 108);
            this.TBdni.Name = "TBdni";
            this.TBdni.Size = new System.Drawing.Size(100, 20);
            this.TBdni.TabIndex = 4;
            // 
            // TBnombre
            // 
            this.TBnombre.Location = new System.Drawing.Point(277, 66);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(100, 20);
            this.TBnombre.TabIndex = 5;
            // 
            // Bok
            // 
            this.Bok.Location = new System.Drawing.Point(194, 213);
            this.Bok.Name = "Bok";
            this.Bok.Size = new System.Drawing.Size(97, 35);
            this.Bok.TabIndex = 6;
            this.Bok.Text = "Ok";
            this.Bok.UseVisualStyleBackColor = true;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 292);
            this.Controls.Add(this.Bok);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.TBdni);
            this.Controls.Add(this.TBnotas);
            this.Controls.Add(this.Lnota);
            this.Controls.Add(this.Ldni);
            this.Controls.Add(this.Lnombre);
            this.Name = "FormRegistro";
            this.Text = "FormRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lnombre;
        private System.Windows.Forms.Label Ldni;
        private System.Windows.Forms.Label Lnota;
        private System.Windows.Forms.TextBox TBnotas;
        private System.Windows.Forms.TextBox TBdni;
        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.Button Bok;
    }
}