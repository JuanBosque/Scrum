
namespace Scrum
{
    partial class Form10
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
            this.btnVector = new System.Windows.Forms.Button();
            this.listaVectores = new System.Windows.Forms.ListBox();
            this.salida = new System.Windows.Forms.Label();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVector
            // 
            this.btnVector.Location = new System.Drawing.Point(42, 207);
            this.btnVector.Name = "btnVector";
            this.btnVector.Size = new System.Drawing.Size(162, 23);
            this.btnVector.TabIndex = 0;
            this.btnVector.Text = "Crear Vector";
            this.btnVector.UseVisualStyleBackColor = true;
            this.btnVector.Click += new System.EventHandler(this.btnVector_Click);
            // 
            // listaVectores
            // 
            this.listaVectores.FormattingEnabled = true;
            this.listaVectores.ItemHeight = 16;
            this.listaVectores.Location = new System.Drawing.Point(24, 13);
            this.listaVectores.Name = "listaVectores";
            this.listaVectores.Size = new System.Drawing.Size(195, 164);
            this.listaVectores.TabIndex = 1;
            // 
            // salida
            // 
            this.salida.AutoSize = true;
            this.salida.Location = new System.Drawing.Point(393, 41);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(0, 17);
            this.salida.TabIndex = 2;
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(292, 16);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(148, 22);
            this.txtSalida.TabIndex = 3;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.listaVectores);
            this.Controls.Add(this.btnVector);
            this.Name = "Form10";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVector;
        private System.Windows.Forms.ListBox listaVectores;
        private System.Windows.Forms.Label salida;
        private System.Windows.Forms.TextBox txtSalida;
    }
}