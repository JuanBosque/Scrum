
namespace Scrum
{
    partial class Form9
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
            this.vector = new System.Windows.Forms.Button();
            this.listavectores = new System.Windows.Forms.ListBox();
            this.textosalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // vector
            // 
            this.vector.Location = new System.Drawing.Point(80, 281);
            this.vector.Name = "vector";
            this.vector.Size = new System.Drawing.Size(147, 44);
            this.vector.TabIndex = 0;
            this.vector.Text = "Crear vector";
            this.vector.UseVisualStyleBackColor = true;
            this.vector.Click += new System.EventHandler(this.vector_Click);
            // 
            // listavectores
            // 
            this.listavectores.FormattingEnabled = true;
            this.listavectores.ItemHeight = 16;
            this.listavectores.Location = new System.Drawing.Point(80, 37);
            this.listavectores.Name = "listavectores";
            this.listavectores.Size = new System.Drawing.Size(147, 212);
            this.listavectores.TabIndex = 1;
            // 
            // textosalida
            // 
            this.textosalida.Location = new System.Drawing.Point(323, 37);
            this.textosalida.Name = "textosalida";
            this.textosalida.Size = new System.Drawing.Size(100, 22);
            this.textosalida.TabIndex = 2;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textosalida);
            this.Controls.Add(this.listavectores);
            this.Controls.Add(this.vector);
            this.Name = "Form9";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vector;
        private System.Windows.Forms.ListBox listavectores;
        private System.Windows.Forms.TextBox textosalida;
    }
}