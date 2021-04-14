
namespace Scrum
{
    partial class Form7
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
            this.btnMultilicar = new System.Windows.Forms.Button();
            this.listaVectores = new System.Windows.Forms.ListBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMultilicar
            // 
            this.btnMultilicar.Location = new System.Drawing.Point(39, 282);
            this.btnMultilicar.Name = "btnMultilicar";
            this.btnMultilicar.Size = new System.Drawing.Size(254, 33);
            this.btnMultilicar.TabIndex = 0;
            this.btnMultilicar.Text = "multiplicar vector";
            this.btnMultilicar.UseVisualStyleBackColor = true;
            this.btnMultilicar.Click += new System.EventHandler(this.btnMultilicar_Click);
            // 
            // listaVectores
            // 
            this.listaVectores.FormattingEnabled = true;
            this.listaVectores.ItemHeight = 16;
            this.listaVectores.Location = new System.Drawing.Point(39, 31);
            this.listaVectores.Name = "listaVectores";
            this.listaVectores.Size = new System.Drawing.Size(173, 196);
            this.listaVectores.TabIndex = 1;
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(415, 41);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(149, 22);
            this.txtSalida.TabIndex = 2;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.listaVectores);
            this.Controls.Add(this.btnMultilicar);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMultilicar;
        private System.Windows.Forms.ListBox listaVectores;
        private System.Windows.Forms.TextBox txtSalida;
    }
}