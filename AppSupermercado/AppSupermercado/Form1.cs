using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSupermercado
{
    public partial class Form1 : Form
    {
        double ValorTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            double ValorUnt = double.Parse(txtValorUnt.Text); 
            int Quantidade = int.Parse(txtQuantidade.Text);
            string Produto = txtProduto.Text;

            ValorTotal = Valor + ValorTotal;



            lstProdutos.Items.Add($"{Produto} / {Quantidade} / R${ValorUnt * Quantidade}");

            lblValorTotal.Text = ValorTotal.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtProduto.Clear();
            txtQuantidade.Clear();
            txtValorUnt.Clear();
            lstProdutos.Items.Clear();
            ValorTotal = 0;
        }
    }
}
