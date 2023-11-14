using System.Threading;
namespace vendasProjeto
{
  
    public partial class telaLogin : Form
    {
        Thread? t1;
        public telaLogin()
        {
            InitializeComponent();
        }
        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            if (usuario.Text.ToUpper() =="marcos" && senha.Text == "1234" ) { 
                this.Close();
                t1 = new Thread(abrirTelaInicial);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos");
            }
        }
        private void abrirTelaInicial()
        {
            Application.Run(new TelaInicial());
        }
    }
}