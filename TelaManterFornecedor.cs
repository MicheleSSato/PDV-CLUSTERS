using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace PDV_CLUSTERS
{
    public partial class TelaManterFornecedor : Form
    {
        
        
        public TelaManterFornecedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = null;
            
            try
            {
                conexao = new SqlConnection(@"Data Source =(localdb)\MSSQLLocalDB; Initial Catalog=PDV; User Id=admin;Password=admin");
                string strSQL = "INSERT INTO TB_CADASTRO_FORNECEDOR (NOME, ENDERECO, TELEFONE, CNPJ) " +
                    "VALUES(@NOME, @ENDERECO, @TELEFONE, @CNPJ)";
                conexao.Open();
                SqlCommand comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@CNPJ", txtCnpj.Text);
                
                comando.ExecuteNonQuery();
                MessageBox.Show("Completou");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            this.Close();
        }
    }
}
