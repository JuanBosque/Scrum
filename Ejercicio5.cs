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
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            char[] caracteres;
            int num = 0;
            var numero = txtEntrada.Text;
            for (int i = 0; i < numero.Length; i++)
            {
                num = num + numero[i];
            }
            txtResultado.Text = num.ToString();
        }

        private int recuSumArray(char [] numArray, int i)
        {

            return 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
