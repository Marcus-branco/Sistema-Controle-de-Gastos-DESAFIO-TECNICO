namespace Sistema_Controle_de_Gastos_DESAFIO_TECNICO.Forms
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            FormPessoa FormPessoa = new FormPessoa();
            FormPessoa.Dock = DockStyle.Fill;
            FormPessoa.TopLevel = false;
            FormMain.MainPanel.Controls.Clear();
            FormMain.MainPanel.Controls.Add(FormPessoa);
            FormPessoa.Show();
        }

        private void buttonCadastroPessoa_Click_1(object sender, EventArgs e)
        {
            FormPessoa FormPessoa = new FormPessoa();
            FormPessoa.Dock = DockStyle.Fill;
            FormPessoa.TopLevel = false;
            FormMain.MainPanel.Controls.Clear();
            FormMain.MainPanel.Controls.Add(FormPessoa);
            FormPessoa.Show();
        }

        private void buttonCadastroTransacao_Click(object sender, EventArgs e)
        {
            FormTransacao cadastroTransacao = new FormTransacao();
            cadastroTransacao.Dock = DockStyle.Fill;
            cadastroTransacao.TopLevel = false;
            FormMain.MainPanel.Controls.Clear();
            FormMain.MainPanel.Controls.Add(cadastroTransacao);
            cadastroTransacao.Show();
        }
    }
}
