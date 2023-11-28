using System;
using System.Windows.Forms;
using YourRoom.Controllers;
using YourRoom.Models;
using YourRoom.Services;

namespace YourRoom.Views
{
    public partial class frmUsuario : Form
    {
        public Usuario usuarioSelecionado;

        public frmUsuario(bool ExibirBotaoSelecionar = false)
        {
            InitializeComponent();
            dgvRegistros.AutoGenerateColumns = false; //Permite customização nas colunas do Data Grid
            btnSelecionar.Visible = ExibirBotaoSelecionar; //Define visibilidade do botão de seleção
        }

        private void Pesquisar()
        {
            int id = 0; // Define ID inicial para 0
            UsuarioController usuarioController = new UsuarioController(); // Instancia o Controller para executar as consultas
            UsuarioCollection usuarioCollection = new UsuarioCollection(); // Instancia o Collection para armazenar os registros

            // Prepara DataGrid para receber os registros
            dgvRegistros.DataSource = null;

            // Verifica se o que foi digitado na pesquisa é um ID verificando se só ha números inteiros no cammpo
            if (int.TryParse(txtPesquisa.Text, out id))
            {
                // Armazena o registro retornado pela consulta por ID num objeto
                Usuario usuario = usuarioController.ConsultarPorId(id);

                // Verifica se o objeto não esta vazio
                if (usuario != null)
                {
                    usuarioCollection.Add(usuario); // Adiciona o objeto na Collection
                }
            }
            else
            {
                // Armazena os registros retornados pela consulta por Nome na Collection
                usuarioCollection = usuarioController.ConsultarPorNome(txtPesquisa.Text);
            }

            // Preenche o Data Grid com os valores da Collection
            dgvRegistros.DataSource = usuarioCollection;
            dgvRegistros.Update(); // Atualiza com os novos valores
            dgvRegistros.Refresh(); // Reexibe o Datagrid atualizado
        }

        // Método para obter as informações do registro selecionado
        private Usuario Recuperar()
        {
            // Verifica se tem algum registro selecionado
            if (dgvRegistros.SelectedRows.Count == 0)
            {
                // Exibe uma Mensagem de Aviso
                MessageBox.Show("Nenhum usuario selecionado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Não retorna nada
                return null;
            }
            else
            {
                // Retorna o valor do registro selecionado na forma de um objeto
                return dgvRegistros.SelectedRows[0].DataBoundItem as Usuario;
            }
        }

        private void Excluir()
        {
            // Recupera o valor selecionado e armazena em um objeto
            Usuario usuarioSelecionado = Recuperar();

            // Se o valor selecionado não for nulo, executa
            if (usuarioSelecionado != null)
            {
                // Exibe uma Mensagem de confirmação e verifica se recebeu a resposta Yes
                if (MessageBox.Show("Deseja realmente excluir o usuario?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Instancia um controller
                    UsuarioController usuarioController = new UsuarioController();

                    // Realiza a operação de DELETE e verifica se foi um sucesso
                    if (usuarioController.Apagar(usuarioSelecionado.IdUsuario) > 0)
                    {
                        // Exibe uma Mensagem de Sucesso
                        MessageBox.Show("Usuario excluído com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Exibe os registros que estão na tabela atualmente
                        Pesquisar();
                    }
                    else
                    {
                        // Exibe uma Mensagem de Erro
                        MessageBox.Show("Não foi possível excluir o usuario.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        // Método para abrir a pagina de formulario, espera de parametros o tipo de formulario e o objeto que vai ser utilizado
        private void Formulario(FormType formType, Usuario usuario)
        {
            // Instancia o objeto do formulario com os parametros do mmétodo
            frmUsuarioForm frm = new frmUsuarioForm(formType, usuario);
            // Mostra uma nova janela
            frm.ShowDialog();

            // Se o tipo de formulario for visualizar, atualiza os dados
            if (formType != FormType.Visualizar)
            {
                Pesquisar();
            }
        }

        // Médoto para Selecionar um registro
        private void Selecionar()
        {
            // Instancia o registro selecionado em um objeto
            usuarioSelecionado = Recuperar();

            // Se tiver dados
            if (usuarioSelecionado != null)
            {
                // Mostra uma tela de confirmação
                this.DialogResult = DialogResult.OK;
            }
        }

        // Quando os botões são clicados
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

        // Quando os botões são clicados
        #region Botões
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Formulario(FormType.Inserir, null);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Formulario(FormType.Alterar, Recuperar());
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Formulario(FormType.Visualizar, Recuperar());
        }
        #endregion
    }
}
