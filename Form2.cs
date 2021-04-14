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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
        private int pow(int x, int y)
        {
            if (y == 0)
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
