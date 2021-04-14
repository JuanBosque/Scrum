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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnMultilicar_Click(object sender, EventArgs e)
        {
            int numMulti = 0;
            var rand = new Random();
            int[] miArray = new int[10];

            for (int i = 0; i < miArray.Length; i++)
            {
                miArray[i] = rand.Next(0, 11);
                listaVectores.Items.Add(miArray[i]);
            }
            numMulti = miArray[0];
            for (int i = 1; i < miArray.Length; i++)
            {
                numMulti = numMulti * miArray[i];
                listaVectores.Items.Add(miArray[i]);
            }
            txtSalida.Text = numMulti.ToString();
        }
    }
}
