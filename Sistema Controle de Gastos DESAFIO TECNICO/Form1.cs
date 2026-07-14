using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
using System.Data;
using System.Data.Common;

namespace Sistema_Controle_de_Gastos_DESAFIO_TECNICO
{
    public partial class Form1 : Form
    {
        public Form1()
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
            listConsulta.Columns.Add("Idade", 50, HorizontalAlignment.Left);
            listConsulta.Columns.Add("Nro despesa", 100, HorizontalAlignment.Left);
            listConsulta.Columns.Add("Descrição despesa", 150, HorizontalAlignment.Left);
            listConsulta.Columns.Add("Tipo despesa", 150, HorizontalAlignment.Left);
            listConsulta.Columns.Add("Valor", 150, HorizontalAlignment.Left);

            carregar_despesas();    //Carrega consulta de despesas ao abrir o sistema
        }

        string data_source = Conexoes.dbConexao();
        MySqlConnection Conexao;

        private void btnSalvarDespesa_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                // Insert no banco de dados
                cmd.CommandText =   "INSERT INTO pessoa(nome, idade) VALUES (@nome, @idade)";
                cmd.Parameters.AddWithValue("@nome", txtNomePessoa.Text);
                cmd.Parameters.AddWithValue("@idade", txtIdadePessoa.Text);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                carregar_despesas();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                
            }
            catch(Exception ex)
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

        private void btnConsultarDespesa_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                // Select no banco de dados
                cmd.CommandText =   "SELECT a.id_pessoa, a.nome, a.idade, b.id_despesa, " +
                                    "b.descricao_despesa, b.tipo_transacao, b.valor_transacao " +
                                    "FROM pessoa a LEFT OUTER JOIN despesa b ON a.id_pessoa = b.id_pessoa " +
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
                    item.SubItems.Add(reader["id_despesa"].ToString());
                    item.SubItems.Add(reader["descricao_despesa"].ToString());
                    item.SubItems.Add(reader["tipo_transacao"].ToString());
                    item.SubItems.Add(reader["valor_transacao"].ToString());

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
        private void carregar_despesas()
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

            listConsulta.Items.Clear();   //Limpa a consulta pré-existente

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

                listConsulta.Items.Add(item);    //Cria linha para a Lista de consulta  
            }
        }
    }
}
