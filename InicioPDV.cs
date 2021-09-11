using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
namespace PDV_CLUSTERS
{
    public partial class InicioPDV : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source =(localdb)\MSSQLLocalDB; Initial Catalog=PDV; User Id=admin;Password=admin");
        SqlCommand comando;
        string strSQL;

        public InicioPDV()
        {
            InitializeComponent();
            customizarDesing();
        }
        private void customizarDesing()
        {
            panelSubmenuCadastro.Visible = false;
            panelSubmenuCaixa.Visible = false;
            panelSubmenuRelatorio.Visible = false;

        }
        private void hideSubmenu()
        {
            if (panelSubmenuCadastro.Visible == true)
                panelSubmenuCadastro.Visible = false;
            if (panelSubmenuCaixa.Visible == true)
                panelSubmenuCaixa.Visible = false;
            if (panelSubmenuRelatorio.Visible == true)
                panelSubmenuRelatorio.Visible = false;
        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btCaixa_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuCaixa);

        }

        private void btVenda_Click(object sender, EventArgs e)
        {
            openChildForm(new telaCaixaVenda());
            //mostrar algum formulario
            //o codigo vai aqui para o botao 
            //aqui vai a tela de venda em si.
            hideSubmenu();
        }

        private void btSangria_Click(object sender, EventArgs e)
        {
            openChildForm(new telaCaixaSangria());
            //mostrar algum formulario
            //o codigo vai aqui para o botao 
            //aqui vai a tela de venda em si.
            hideSubmenu();
        }


        private void btFechamento_Click(object sender, EventArgs e)
        {
            openChildForm(new telaCaixaFechamento());
            //mostrar algum formulario
            //o codigo vai aqui para o botao 
            //aqui vai a tela de venda em si.
            hideSubmenu();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuCadastro);
        }

        private void btProduto_Click(object sender, EventArgs e)
        {
            openChildForm(new telaCadastroProduto());
            //mostrar algum formulario
            //o codigo vai aqui para o botao 
            //aqui vai a tela de venda em si.
            hideSubmenu();
        }

        private void btFuncionario_Click(object sender, EventArgs e)
        {
            openChildForm(new telaCadastroFuncionario());
            //mostrar algum formulario
            //o codigo vai aqui para o botao 
            //aqui vai a tela de venda em si.
            hideSubmenu();
        }

        private void btFornecedor_Click(object sender, EventArgs e)
        {
            openChildForm(new telaCadastroFornecedor());
            //mostrar algum formulario
            //o codigo vai aqui para o botao 
            //aqui vai a tela de venda em si.
            hideSubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuRelatorio);
        }

        private void btRelVendas_Click(object sender, EventArgs e)
        {
            openChildForm(new telaRelatorioVendas());
            //mostrar algum formulario
            //o codigo vai aqui para o botao 
            //aqui vai a tela de venda em si.
            hideSubmenu();
        }

        private void btRelFuncionario_Click(object sender, EventArgs e)
        {
            openChildForm(new telaRelatorioFuncionario());
            //mostrar algum formulario
            //o codigo vai aqui para o botao 
            //aqui vai a tela de venda em si.
            hideSubmenu();
        }

        private void btRelProdutos_Click(object sender, EventArgs e)
        {
            openChildForm(new telaRelatorioProdutos());
            //mostrar algum formulario
            //o codigo vai aqui para o botao 
            //aqui vai a tela de venda em si.
            hideSubmenu();
        }
        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InicioPDV_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }

}
