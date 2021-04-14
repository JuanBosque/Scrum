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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var num = "";
            int numero;
            int resultado = 0;
            string[] vector = txtEnviar.Text.Split(',');
            for (int i = 0; i < vector.Length; i++)
            {
                num = vector[i];
                numero = int.Parse(num);
                resultado = resultado + numero;
            }

            txtResultado.Text = resultado.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
