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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            try
            {
                char[] charArray = inText.Text.ToCharArray();
                string s = reverseText(charArray, 0);
                outText.Text = s;
            }
            catch
            {
                MessageBox.Show("Error en datos de entrada.");
            }
        }

        private string reverseText(char [] charArray, int i)
        {
            if (charArray.Length == 0)
            {
                return "";
            }
            else if(i == charArray.Length-1)
            {
                return "" + charArray[i];
            }
            else
            {
                return reverseText(charArray, i + 1) + charArray[i];
            }
            return "xd";
        }
    }
}
