using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vendasProjeto
{
    public partial class TelaVenda : Form
    {
        public TelaVenda()
        {
            InitializeComponent();
            //Pegaria os dados do banco de dados
            nomeEmpresa.Text = "Organizações Tabajara";
            nomeUsuario.Text = "Marcos Guimarães";
            numeroSuporte.Text = "(63) 999175735";
        }

        private void TelaVenda_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


    }
}
