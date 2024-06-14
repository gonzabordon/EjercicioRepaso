namespace WindowsFormsApp1
{
    partial class FormRegistrar
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
            this.Bok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBnombres = new System.Windows.Forms.TextBox();
            this.TBdni = new System.Windows.Forms.TextBox();
            this.TBNotas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Bok
            // 
            this.Bok.Location = new System.Drawing.Point(191, 243);
            this.Bok.Name = "Bok";
            this.Bok.Size = new System.Drawing.Size(75, 23);
            this.Bok.TabIndex = 0;
            this.Bok.Text = "OK";
            this.Bok.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
          
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Notas";
            // 
            // TBnombres
            // 
            this.TBnombres.Location = new System.Drawing.Point(247, 102);
            this.TBnombres.Name = "TBnombres";
            this.TBnombres.Size = new System.Drawing.Size(100, 20);
            this.TBnombres.TabIndex = 4;
            // 
            // TBdni
            // 
            this.TBdni.Location = new System.Drawing.Point(247, 140);
            this.TBdni.Name = "TBdni";
            this.TBdni.Size = new System.Drawing.Size(100, 20);
            this.TBdni.TabIndex = 5;
            // 
            // TBNotas
            // 
            this.TBNotas.Location = new System.Drawing.Point(247, 177);
            this.TBNotas.Name = "TBNotas";
            this.TBNotas.Size = new System.Drawing.Size(100, 20);
            this.TBNotas.TabIndex = 6;
            // 
            // FormRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 379);
            this.Controls.Add(this.TBNotas);
            this.Controls.Add(this.TBdni);
            this.Controls.Add(this.TBnombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bok);
            this.Name = "FormRegistrar";
            this.Text = "FormRegistrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBnombres;
        private System.Windows.Forms.TextBox TBdni;
        private System.Windows.Forms.TextBox TBNotas;
    }
}