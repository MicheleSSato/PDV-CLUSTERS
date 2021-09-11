//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Windows.Forms;


//namespace PDV_CLUSTERS
//{
//    class Conexao
//    {
//        SqlConnection cnn;
//        SqlCommand cmd;
//        SqlDataReader dr;
//        public Conexao()
//        {
//            try
//            {
//                cnn = new SqlConnection(" ");
//                cnn.Open();
//                MessageBox.Show("Conectado");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Erro na conexao" + ex.ToString());
//            }
//        }

//        public void autoCompletar(TextBox textBoxBuscaFornecedor)
//        {
//            try
//            {
//                cmd = new SqlCommand("SELECT NOME FROM TB_CADASTRO_FORNECEDOR", cnn);
//                dr = cmd.ExecuteReader();
//                while (dr.Read())
//                {
//                    textBoxBuscaFornecedor.AutoCompleteCustomSource.Add(dr["NOME"].ToString());
//                }
//                dr.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Busca Inexistente");
//            }
//        }

//    }
//}
