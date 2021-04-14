using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Int32.Parse(inText1.Text);
                outText.Text = fact(num).ToString();
            }
            catch
            {
                MessageBox.Show("Error en datos de entrada.");
            }

        }
        private void btnPow_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Int32.Parse(inText1.Text);
                int y = Int32.Parse(inText2.Text);
                outText.Text = pow(x, y).ToString();
            }
            catch
            {
                MessageBox.Show("Error en datos de entrada.");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Int32.Parse(inText1.Text);
                int y = Int32.Parse(inText2.Text);
                outText.Text = div(x, y).ToString();
            }
            catch
            {
                MessageBox.Show("Error en datos de entrada.");
            }
        }
        private int fact(int n)
        {

            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n*fact(n-1);
            }
        }

        private int pow(int x, int y)
        {
            if(y == 0)
            {
                return 1;
            }
            else
            {
                return x * pow(x, y - 1);
            }
            
        }

        private int div(int x, int y)
        {
            if(y > x)
            {
                return 0;
            }
            else
            {
                return 1 + div(x - y, y);
            }
        }

        
    }
}
