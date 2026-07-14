using MySql.Data.MySqlClient;
using Sistema_Controle_de_Gastos_DESAFIO_TECNICO.Forms;

namespace Sistema_Controle_de_Gastos_DESAFIO_TECNICO
{
    public partial class FormPessoa : Form
    {
        public FormPessoa()
        {
            InitializeComponent();

            //  Configurar Lista da Consulta de despesas
            listConsulta.View = View.Details;
            listConsulta.LabelEdit = true;
            listConsulta.AllowColumnReorder = true;
            listConsulta.FullRowSelect = true;
            listConsulta.GridLines = true;
            listConsulta.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listConsulta.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listConsulta.Columns.Add("Idade", 40, HorizontalAlignment.Left);

            carregar_pessoas();    //Carrega consulta de despesas ao abrir o sistema
        }

        string data_source = Conexoes.dbConexao();
        MySqlConnection Conexao;

        private void BtnSalvarPessoa_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                // Insert no banco de dados
                cmd.CommandText = "INSERT INTO pessoa(nome, idade) VALUES (@nome, @idade)";
                cmd.Parameters.AddWithValue("@nome", txtNomePessoa.Text);
                cmd.Parameters.AddWithValue("@idade", txtIdadePessoa.Text);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Pessoa cadastrada com sucesso!");

                carregar_pessoas(); // Carregar a lista de pessoas

                //  Apagar campos de cadastro
                txtNomePessoa.Text = "";
                txtIdadePessoa.Text = "";

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um Erro  " + ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btnConsultarPessoa_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                // Select no banco de dados
                cmd.CommandText = "SELECT a.id_pessoa, a.nome, a.idade " +
                                    "FROM pessoa a " +
                                    "WHERE a.id_pessoa LIKE @q " +
                                    "OR a.nome LIKE @q;";
                cmd.Parameters.AddWithValue("@q", $"%{txtBuscar.Text}%");

                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();   // Executar reader com o valor de retorno do comando

                listConsulta.Items.Clear();   //Limpa a consulta pré-existente

                while (reader.Read())   // Enquanto existir linhas para ler, executa o bloco abaixo 
                {
                    // Criar colunas da lista
                    ListViewItem item = new ListViewItem(reader["id_pessoa"].ToString()); // 1ª linha

                    // Criar colunas subsequentes                    
                    item.SubItems.Add(reader["nome"].ToString());
                    item.SubItems.Add(reader["idade"].ToString());

                    listConsulta.Items.Add(item);    //Cria linha para a Lista de consulta  
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
        private void carregar_pessoas()
        {
            Conexao = new MySqlConnection(data_source);
            Conexao.Open();

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = Conexao;

            // Select no banco de dados
            cmd.CommandText = "SELECT a.id_pessoa, a.nome, a.idade " +
                                "FROM pessoa a " +
                                "order by a.id_pessoa;";

            cmd.Prepare();

            MySqlDataReader reader = cmd.ExecuteReader();   // Executar reader com o valor de retorno do comando

            listConsulta.Items.Clear();   //Limpa a consulta pré-existente

            while (reader.Read())   // Enquanto existir linhas para ler, executa o bloco abaixo 
            {
                // Criar colunas da lista
                ListViewItem item = new ListViewItem(reader["id_pessoa"].ToString()); // 1ª linha

                // Criar colunas subsequentes                    
                item.SubItems.Add(reader["nome"].ToString());
                item.SubItems.Add(reader["idade"].ToString());

                listConsulta.Items.Add(item);    //Cria linha para a Lista de consulta  
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu FormMenu = new FormMenu();
            FormMenu.Dock = DockStyle.Fill;
            FormMenu.TopLevel = false;
            FormMain.MainPanel.Controls.Clear();
            FormMain.MainPanel.Controls.Add(FormMenu);
            FormMenu.Show();
        }
    }
}
