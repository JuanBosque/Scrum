
namespace Scrum
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnFact = new System.Windows.Forms.Button();
            this.inText1 = new System.Windows.Forms.TextBox();
            this.outText = new System.Windows.Forms.TextBox();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnFact
            // 
            this.btnFact.Location = new System.Drawing.Point(48, 92);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(75, 23);
            this.btnFact.TabIndex = 1;
            this.btnFact.Text = "Fact";
            this.btnFact.UseVisualStyleBackColor = true;
            this.btnFact.Click += new System.EventHandler(this.button1_Click);
            // 
            // inText1
            // 
            this.inText1.Location = new System.Drawing.Point(143, 92);
            this.inText1.Name = "inText1";
            this.inText1.Size = new System.Drawing.Size(100, 22);
            this.inText1.TabIndex = 2;
            // 
            // outText
            // 
            this.outText.Location = new System.Drawing.Point(266, 92);
            this.outText.Name = "outText";
            this.outText.Size = new System.Drawing.Size(100, 22);
            this.outText.TabIndex = 3;
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(0, 0);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(75, 23);
            this.btnPow.TabIndex = 1;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(0, 0);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.outText);
            this.Controls.Add(this.inText1);
            this.Controls.Add(this.btnFact);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnFact;
        private System.Windows.Forms.TextBox inText1;
        private System.Windows.Forms.TextBox outText;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnDiv;
    }
}

