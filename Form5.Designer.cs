
namespace Scrum
{
    partial class Form5
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
            this.inText1 = new System.Windows.Forms.TextBox();
            this.inText2 = new System.Windows.Forms.TextBox();
            this.outText = new System.Windows.Forms.TextBox();
            this.btnMCD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inText1
            // 
            this.inText1.Location = new System.Drawing.Point(179, 64);
            this.inText1.Name = "inText1";
            this.inText1.Size = new System.Drawing.Size(111, 22);
            this.inText1.TabIndex = 0;
            // 
            // inText2
            // 
            this.inText2.Location = new System.Drawing.Point(179, 92);
            this.inText2.Name = "inText2";
            this.inText2.Size = new System.Drawing.Size(111, 22);
            this.inText2.TabIndex = 1;
            this.inText2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // outText
            // 
            this.outText.Location = new System.Drawing.Point(308, 64);
            this.outText.Name = "outText";
            this.outText.Size = new System.Drawing.Size(111, 22);
            this.outText.TabIndex = 2;
            // 
            // btnMCD
            // 
            this.btnMCD.Location = new System.Drawing.Point(54, 64);
            this.btnMCD.Name = "btnMCD";
            this.btnMCD.Size = new System.Drawing.Size(75, 23);
            this.btnMCD.TabIndex = 3;
            this.btnMCD.Text = "MCD";
            this.btnMCD.UseVisualStyleBackColor = true;
            this.btnMCD.Click += new System.EventHandler(this.btnMCD_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMCD);
            this.Controls.Add(this.outText);
            this.Controls.Add(this.inText2);
            this.Controls.Add(this.inText1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inText1;
        private System.Windows.Forms.TextBox inText2;
        private System.Windows.Forms.TextBox outText;
        private System.Windows.Forms.Button btnMCD;
    }
}