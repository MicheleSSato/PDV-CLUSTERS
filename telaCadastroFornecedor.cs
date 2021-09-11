using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PDV_CLUSTERS
{
    public partial class telaCadastroFornecedor : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source =(localdb)\MSSQLLocalDB; Initial Catalog=PDV; User Id=admin;Password=admin");
        SqlCommand comando;
        string strSQL;
        public telaCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ///criei sem querer esse evento
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdicionarNovo_Click(object sender, EventArgs e)
        {
            TelaManterFornecedor novoForm = new TelaManterFornecedor();
            novoForm.Show();
        }

        private void gdListaFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           ///
        }

        private void btVisualizar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * From TB_CADASTRO_FORNECEDOR", conexao);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            gdListaFornecedor.DataSource = tabela;
        }

        private void telaCadastroFornecedor_Load(object sender, EventArgs e)
        {
            //Conexao c = new Conexao();
            //c.autoCompletar(textBoxBuscaFornecedor);
        }

        private void textBoxBuscaFornecedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
