
namespace PDV_CLUSTERS
{
    partial class telaCadastroFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btVoltar = new System.Windows.Forms.Button();
            this.btAdicionarNovo = new System.Windows.Forms.Button();
            this.textBoxBuscaFornecedor = new System.Windows.Forms.TextBox();
            this.gdListaFornecedor = new System.Windows.Forms.DataGridView();
            this.btVisualizar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdListaFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btVoltar.Location = new System.Drawing.Point(12, 634);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(108, 54);
            this.btVoltar.TabIndex = 1;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAdicionarNovo
            // 
            this.btAdicionarNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btAdicionarNovo.FlatAppearance.BorderSize = 0;
            this.btAdicionarNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionarNovo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionarNovo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btAdicionarNovo.Location = new System.Drawing.Point(534, 636);
            this.btAdicionarNovo.Name = "btAdicionarNovo";
            this.btAdicionarNovo.Size = new System.Drawing.Size(108, 54);
            this.btAdicionarNovo.TabIndex = 7;
            this.btAdicionarNovo.Text = "Adicionar Novo";
            this.btAdicionarNovo.UseCompatibleTextRendering = true;
            this.btAdicionarNovo.UseVisualStyleBackColor = false;
            this.btAdicionarNovo.Click += new System.EventHandler(this.btAdicionarNovo_Click);
            // 
            // textBoxBuscaFornecedor
            // 
            this.textBoxBuscaFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxBuscaFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxBuscaFornecedor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscaFornecedor.HideSelection = false;
            this.textBoxBuscaFornecedor.Location = new System.Drawing.Point(12, 15);
            this.textBoxBuscaFornecedor.Multiline = true;
            this.textBoxBuscaFornecedor.Name = "textBoxBuscaFornecedor";
            this.textBoxBuscaFornecedor.Size = new System.Drawing.Size(745, 54);
            this.textBoxBuscaFornecedor.TabIndex = 10;
            this.textBoxBuscaFornecedor.TextChanged += new System.EventHandler(this.textBoxBuscaFornecedor_TextChanged);
            // 
            // gdListaFornecedor
            // 
            this.gdListaFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdListaFornecedor.Location = new System.Drawing.Point(12, 81);
            this.gdListaFornecedor.Name = "gdListaFornecedor";
            this.gdListaFornecedor.RowHeadersWidth = 51;
            this.gdListaFornecedor.Size = new System.Drawing.Size(858, 530);
            this.gdListaFornecedor.TabIndex = 12;
            this.gdListaFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdListaFornecedor_CellContentClick);
            // 
            // btVisualizar
            // 
            this.btVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btVisualizar.FlatAppearance.BorderSize = 0;
            this.btVisualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btVisualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVisualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVisualizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btVisualizar.Location = new System.Drawing.Point(420, 636);
            this.btVisualizar.Name = "btVisualizar";
            this.btVisualizar.Size = new System.Drawing.Size(108, 54);
            this.btVisualizar.TabIndex = 13;
            this.btVisualizar.Text = "Visualizar";
            this.btVisualizar.UseVisualStyleBackColor = false;
            this.btVisualizar.Click += new System.EventHandler(this.btVisualizar_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btEditar.FlatAppearance.BorderSize = 0;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btEditar.Location = new System.Drawing.Point(648, 636);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(108, 54);
            this.btEditar.TabIndex = 14;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btExcluir.Location = new System.Drawing.Point(762, 636);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(108, 54);
            this.btExcluir.TabIndex = 15;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btPesquisar.FlatAppearance.BorderSize = 0;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btPesquisar.Location = new System.Drawing.Point(762, 15);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(108, 54);
            this.btPesquisar.TabIndex = 16;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            // 
            // telaCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(903, 703);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btVisualizar);
            this.Controls.Add(this.gdListaFornecedor);
            this.Controls.Add(this.textBoxBuscaFornecedor);
            this.Controls.Add(this.btAdicionarNovo);
            this.Controls.Add(this.btVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaCadastroFornecedor";
            this.Text = "telaCadastroFornecedor";
            this.Load += new System.EventHandler(this.telaCadastroFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdListaFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btAdicionarNovo;
        private System.Windows.Forms.TextBox textBoxBuscaFornecedor;
        private System.Windows.Forms.DataGridView gdListaFornecedor;
        private System.Windows.Forms.Button btVisualizar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btPesquisar;
    }
}