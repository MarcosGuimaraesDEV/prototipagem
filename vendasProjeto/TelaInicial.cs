using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace vendasProjeto
{
    public partial class TelaInicial : Form
    {
        Thread? t1;
        public TelaInicial()
        {
            InitializeComponent();
            //Pegaria os dados do banco de dados
            nomeEmpresa.Text = "Organizações Tabajara";
            nomeUsuario.Text = "Marcos Guimarães";
            numeroSuporte.Text = "(63) 999175735";
        }

        private void btnPdv_Click(object sender, EventArgs e)
        {
            t1 = new Thread(abrirTelaVendas);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirTelaVendas()
        {
            Application.Run(new TelaVenda());
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não foi implementado");
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não foi implementado");
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não foi implementado");
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não foi implementado");
        }

        private void listaEstoque_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não foi implementado");
        }
    }
}
