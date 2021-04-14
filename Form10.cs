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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btnVector_Click(object sender, EventArgs e)
        {
            int numMax;
            var rand = new Random();
            int[] miArray = new int[10];

            for(int i=0; i <= miArray.Length; i++)
            {
              miArray[i] = rand.Next(0, 11);
                listaVectores.Items.Add(miArray[i]);
            }
            numMax = miArray[0];
            for (int i = 0; i <= miArray.Length; i++)
            {
                if(numMax <= miArray[i])
                {
                    numMax = miArray[i];
                } 
            }
            txtSalida.Text = numMax.ToString();

        }
    }
}
