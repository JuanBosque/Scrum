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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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

        private int div(int x, int y)
        {
            if (y > x)
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
