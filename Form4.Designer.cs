
namespace Scrum
{
    partial class Form4
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
            this.btnReverse = new System.Windows.Forms.Button();
            this.inText = new System.Windows.Forms.TextBox();
            this.outText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(49, 61);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 0;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // inText
            // 
            this.inText.Location = new System.Drawing.Point(148, 61);
            this.inText.Name = "inText";
            this.inText.Size = new System.Drawing.Size(100, 22);
            this.inText.TabIndex = 1;
            // 
            // outText
            // 
            this.outText.Location = new System.Drawing.Point(281, 61);
            this.outText.Name = "outText";
            this.outText.Size = new System.Drawing.Size(100, 22);
            this.outText.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outText);
            this.Controls.Add(this.inText);
            this.Controls.Add(this.btnReverse);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.TextBox inText;
        private System.Windows.Forms.TextBox outText;
    }
}