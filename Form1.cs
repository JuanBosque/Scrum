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
            int num = Int32.Parse(inText1.Text);
            outText.Text = fact(num).ToString();
        }
        private void btnPow_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(inText1.Text);
            int y = Int32.Parse(inText2.Text);
            outText.Text = pow(x, y).ToString();
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

        
    }
}
