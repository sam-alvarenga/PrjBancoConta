using PrjBancoConta.Forms;
using SamAlvarenga.Ativ_ContaBancaria.Models;

namespace PrjBancoConta
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        
        public List<Conta> contas = new List<Conta>();

        private void criarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciando objeto para guardar na memoria
            frmCriarConta formCriarConta = new frmCriarConta();
            //Pegando variável "formCriarConta" e usando a propriedade (MdiParent) para definir quem é o pai, que no caso this(proprio arquivo) faz referencia a class frmPrincipal 
            formCriarConta.MdiParent = this;
            //Abrir a janela
            formCriarConta.Show();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}