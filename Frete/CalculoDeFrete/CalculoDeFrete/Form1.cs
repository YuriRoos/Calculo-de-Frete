using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeFrete
{
    public partial class Form1 : Form
    {
        void Calcular()
        {
            string nome = txtnome.Text;
            decimal valor = decimal.Parse(txtvalor.Text);
            string estado = this.cboestado.SelectedItem.ToString();
            decimal frete = 0;


            if (valor > 1000)
            {
                valor += 0;
            }

            if (valor < 1000)
            {
                if (estado == "São Paulo (SP)")
                {
                    frete = 5;
                }
                if (estado == "Rio de Janeiro (RJ)")
                {
                    frete = 10;
                }
                if (estado == "Amazonas (AM)")
                {
                    frete = 20;
                }
                if (estado != "São Paulo (SP)" && estado != "Rio de Janeiro (RJ)" && estado != "Amazonas (AM)")
                {
                    frete = 15;
                }
            }
            var valorTotal = valor + frete;
            lblvalorcompra.Text = valor.ToString("C");
            lblfrete.Text = frete.ToString("C");
            lbltotal.Text = valorTotal.ToString("C");
        }
        void Limpar()
        {
            txtnome.Text = "";
            txtvalor.Text = "";
            cboestado.Text = "";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularFrete_Click(object sender, EventArgs e)
        {
            Calcular();
        }
        private void LimparCampos_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
