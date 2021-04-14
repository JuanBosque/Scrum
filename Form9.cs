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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void vector_Click(object sender, EventArgs e)
        {
            {
                listavectores.Items.Clear();
                int numMin;
                var rand = new Random();
                int[] miArray = new int[10];

                for (int i = 0; i < miArray.Length; i++)
                {
                    miArray[i] = rand.Next(0, 11);
                    listavectores.Items.Add(miArray[i]);
                }
                numMin = miArray[0];
                for (int i = 0; i < miArray.Length; i++)
                {
                    if (numMin >= miArray[i])
                    {
                        numMin = miArray[i];
                    }
                }
                textosalida.Text = numMin.ToString();

            }
        }
    }
}
