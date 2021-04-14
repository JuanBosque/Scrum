
namespace Scrum
{
    partial class Form3
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
            this.btnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inText1
            // 
            this.inText1.Location = new System.Drawing.Point(157, 59);
            this.inText1.Name = "inText1";
            this.inText1.Size = new System.Drawing.Size(110, 22);
            this.inText1.TabIndex = 0;
            // 
            // inText2
            // 
            this.inText2.Location = new System.Drawing.Point(157, 87);
            this.inText2.Name = "inText2";
            this.inText2.Size = new System.Drawing.Size(110, 22);
            this.inText2.TabIndex = 1;
            // 
            // outText
            // 
            this.outText.Location = new System.Drawing.Point(295, 59);
            this.outText.Name = "outText";
            this.outText.Size = new System.Drawing.Size(110, 22);
            this.outText.TabIndex = 2;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(50, 59);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "Div";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.outText);
            this.Controls.Add(this.inText2);
            this.Controls.Add(this.inText1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inText1;
        private System.Windows.Forms.TextBox inText2;
        private System.Windows.Forms.TextBox outText;
        private System.Windows.Forms.Button btnDiv;
    }
}