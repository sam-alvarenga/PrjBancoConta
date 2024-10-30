using PrjBancoConta.Forms;

namespace PrjBancoConta
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void criarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciando objeto para guardar na memoria
            frmCriarConta formCriarConta = new frmCriarConta();
            //Pegando variável "formCriarConta" e usando a propriedade (MdiParent) para definir quem é o pai, que no caso this(proprio arquivo) faz referencia a class frmPrincipal 
            formCriarConta.MdiParent = this;
            //Abrir a janela
            formCriarConta.Show();

        }
    }
}