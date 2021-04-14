
namespace Scrum
{
    partial class Form2
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
            this.btnPow = new System.Windows.Forms.Button();
            this.inText1 = new System.Windows.Forms.TextBox();
            this.inText2 = new System.Windows.Forms.TextBox();
            this.outText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(44, 64);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(75, 23);
            this.btnPow.TabIndex = 0;
            this.btnPow.Text = "Pow";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // inText1
            // 
            this.inText1.Location = new System.Drawing.Point(150, 64);
            this.inText1.Name = "inText1";
            this.inText1.Size = new System.Drawing.Size(100, 22);
            this.inText1.TabIndex = 1;
            // 
            // inText2
            // 
            this.inText2.Location = new System.Drawing.Point(150, 93);
            this.inText2.Name = "inText2";
            this.inText2.Size = new System.Drawing.Size(100, 22);
            this.inText2.TabIndex = 2;
            // 
            // outText
            // 
            this.outText.Location = new System.Drawing.Point(266, 65);
            this.outText.Name = "outText";
            this.outText.Size = new System.Drawing.Size(107, 22);
            this.outText.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outText);
            this.Controls.Add(this.inText2);
            this.Controls.Add(this.inText1);
            this.Controls.Add(this.btnPow);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.TextBox inText1;
        private System.Windows.Forms.TextBox inText2;
        private System.Windows.Forms.TextBox outText;
    }
}