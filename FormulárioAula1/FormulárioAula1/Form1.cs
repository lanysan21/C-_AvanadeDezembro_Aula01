namespace FormulárioAula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBoasVindas_Click(object sender, EventArgs e)

        { 
            string nomeUsuario;

            nomeUsuario = txtNome.Text;


            MessageBox.Show($"Bem vindo ao C# {nomeUsuario}", "Olá!", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            lblMensagem.Text = $"Bem vindo ao C# {nomeUsuario}";
        }
    }
}