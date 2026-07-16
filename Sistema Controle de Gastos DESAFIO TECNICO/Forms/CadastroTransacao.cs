using MySql.Data.MySqlClient;

namespace Sistema_Controle_de_Gastos_DESAFIO_TECNICO.Forms
{
    public partial class FormTransacao : Form
    {
        public FormTransacao()
        {
            InitializeComponent();
            listViewTransaçõesXPessoas.View = View.Details;
            listViewTransaçõesXPessoas.LabelEdit = true;
            listViewTransaçõesXPessoas.AllowColumnReorder = true;
            listViewTransaçõesXPessoas.FullRowSelect = true;
            listViewTransaçõesXPessoas.GridLines = true;
            listViewTransaçõesXPessoas.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listViewTransaçõesXPessoas.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listViewTransaçõesXPessoas.Columns.Add("Idade", 60, HorizontalAlignment.Left);
            listViewTransaçõesXPessoas.Columns.Add("Nro Transação", 100, HorizontalAlignment.Left);
            listViewTransaçõesXPessoas.Columns.Add("Descrição", 150, HorizontalAlignment.Left);
            listViewTransaçõesXPessoas.Columns.Add("Tipo", 100, HorizontalAlignment.Left);
            listViewTransaçõesXPessoas.Columns.Add("Valor", 60, HorizontalAlignment.Left);

            carregar_TransacaoxPessoa();
            popularListaPessoa();
        }

        string data_source = Conexoes.dbConexao();
        MySqlConnection Conexao;

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu FormMenu = new FormMenu();
            FormMenu.Dock = DockStyle.Fill;
            FormMenu.TopLevel = false;
            FormMain.MainPanel.Controls.Clear();
            FormMain.MainPanel.Controls.Add(FormMenu);
            FormMenu.Show();
        }

        private void buttonSalvarTransacao_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                if (comboxPessoa.SelectedItem == null)
                {
                    MessageBox.Show("Por favor selecione uma pessoa para salvar a transação!");
                    return;
                }
                if (txtValorTransacao.Text == null)
                {
                    MessageBox.Show("Por favor informe o valor da transação");
                    return;
                }
                if (listTipoTransacao.Text == null)
                {
                    MessageBox.Show("Por favor selecione o tipo de transação!");
                    return;
                }
                if (txtDescricaoTransacao.Text == null)
                {
                    MessageBox.Show("Por favor informe uma descrição para a transação!");
                    return;
                }


                cmd.CommandText = "SELECT id_pessoa, idade FROM pessoa " +
                                    "WHERE nome = @q;";
                cmd.Parameters.AddWithValue("@q", comboxPessoa.SelectedItem.ToString());
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();



                int pessoaID = reader.GetInt32("id_pessoa");
                int idadePessoa = reader.GetInt32("idade");
                if (idadePessoa < 18 && !string.Equals(listTipoTransacao.Text?.Trim(), "Despesa", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Pessoas menores de 18 anos só podem registrar transações do tipo Despesa!");
                    return;
                }

                reader.Close(); //Fecha a sessão do reader
                cmd.Parameters.Clear(); //Limpa os parâmetros


                // Insert no banco de dados
                cmd.CommandText = "INSERT INTO despesa(id_pessoa, descricao_despesa, valor_transacao, tipo_transacao) " +
                                    "VALUES (@id_pessoa, @descricao_despesa, @valor_transacao, @tipo_transacao);";
                cmd.Parameters.AddWithValue("@id_pessoa", pessoaID);
                cmd.Parameters.AddWithValue("@descricao_despesa", txtDescricaoTransacao.Text);
                cmd.Parameters.AddWithValue("@valor_transacao", txtValorTransacao.Text);
                cmd.Parameters.AddWithValue("@tipo_transacao", listTipoTransacao.Text);
                cmd.Prepare();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Transação cadastrada com sucesso!");

                carregar_TransacaoxPessoa(); // Carregar a lista de pessoas

                //  Apagar campos de cadastro

                listTipoTransacao.Text = "";
                txtValorTransacao.Text = "";
                txtDescricaoTransacao.Text = "";

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

        private void buttonPesquisarTransacao_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                // Select no banco de dados
                cmd.CommandText = "SELECT a.id_pessoa, a.nome, a.idade, b.id_despesa, " +
                                    "b.descricao_despesa, b.tipo_transacao, b.valor_transacao " +
                                    "FROM pessoa a LEFT OUTER JOIN despesa b ON a.id_pessoa = b.id_pessoa " +
                                    "WHERE a.id_pessoa LIKE @q " +
                                    "OR a.nome LIKE @q;";
                cmd.Parameters.AddWithValue("@q", $"%{txtConsulta.Text}%");

                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();   // Executar reader com o valor de retorno do comando

                listViewTransaçõesXPessoas.Items.Clear();   //Limpa a consulta pré-existente

                while (reader.Read())   // Enquanto existir linhas para ler, executa o bloco abaixo 
                {
                    // Criar colunas da lista
                    ListViewItem item = new ListViewItem(reader["id_pessoa"].ToString()); // 1ª linha

                    // Criar colunas subsequentes                    
                    item.SubItems.Add(reader["nome"].ToString());
                    item.SubItems.Add(reader["idade"].ToString());
                    item.SubItems.Add(reader["id_despesa"].ToString());
                    item.SubItems.Add(reader["descricao_despesa"].ToString());
                    item.SubItems.Add(reader["tipo_transacao"].ToString());
                    item.SubItems.Add(reader["valor_transacao"].ToString());

                    listViewTransaçõesXPessoas.Items.Add(item);    //Cria linha para a Lista de consulta  
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
        private void carregar_TransacaoxPessoa()
        {
            Conexao = new MySqlConnection(data_source);
            Conexao.Open();

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = Conexao;

            // Select no banco de dados
            cmd.CommandText = "SELECT a.id_pessoa, a.nome, a.idade, b.id_despesa, " +
                                "b.descricao_despesa, b.tipo_transacao, b.valor_transacao " +
                                "FROM pessoa a LEFT OUTER JOIN despesa b ON a.id_pessoa = b.id_pessoa " +
                                "order by a.id_pessoa;";

            cmd.Prepare();

            MySqlDataReader reader = cmd.ExecuteReader();   // Executar reader com o valor de retorno do comando

            listViewTransaçõesXPessoas.Items.Clear();   //Limpa a consulta pré-existente

            while (reader.Read())   // Enquanto existir linhas para ler, executa o bloco abaixo 
            {
                // Criar colunas da lista
                ListViewItem item = new ListViewItem(reader["id_pessoa"].ToString()); // 1ª linha

                // Criar colunas subsequentes                    
                item.SubItems.Add(reader["nome"].ToString());
                item.SubItems.Add(reader["idade"].ToString());
                item.SubItems.Add(reader["id_despesa"].ToString());
                item.SubItems.Add(reader["descricao_despesa"].ToString());
                item.SubItems.Add(reader["tipo_transacao"].ToString());
                item.SubItems.Add(reader["valor_transacao"].ToString());

                listViewTransaçõesXPessoas.Items.Add(item);    //Cria linha para a Lista de consulta  
            }
        }
        public void popularListaPessoa()
        {
            Conexao = new MySqlConnection(data_source);
            Conexao.Open();

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = Conexao;

            // Select no banco de dados
            cmd.CommandText = "SELECT nome FROM pessoa order by nome;";

            cmd.Prepare();

            MySqlDataReader reader = cmd.ExecuteReader();   // Executar reader com o valor de retorno do comando

            while (reader.Read())   // Enquanto existir linhas para ler, executa o bloco abaixo 
            {
                // Criar colunas da lista
                comboxPessoa.Items.Add(reader["nome"].ToString());
            }
        }
    }
}
