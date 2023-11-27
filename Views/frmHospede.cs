using System;
using System.Windows.Forms;
using YourRoom.Controllers;
using YourRoom.Models;
using YourRoom.Services;

namespace YourRoom.Views
{
    public partial class frmHospede : Form
    {
        public Hospede hospedeSelecionado;

        public frmHospede(bool ExibirBotaoSelecionar = false)
        {
            InitializeComponent();
            dgvRegistros.AutoGenerateColumns = false; //Permite customização nas colunas do Data Grid
            btnSelecionar.Visible = ExibirBotaoSelecionar; //Define visibilidade do botão de seleção
        }

        private void Pesquisar()
        {
            int id = 0; // Define ID inicial para 0
            HospedeController hospedeController = new HospedeController(); // Instancia o Controller para executar as consultas
            HospedeCollection hospedeCollection = new HospedeCollection(); // Instancia o Collection para armazenar os registros

            // Prepara DataGrid para receber os registros
            dgvRegistros.DataSource = null;
            
            // Verifica se o que foi digitado na pesquisa é um ID verificando se só ha números inteiros no cammpo
            if (int.TryParse(txtPesquisa.Text, out id))
            {
                // Armazena o registro retornado pela consulta por ID num objeto
                Hospede hospede = hospedeController.ConsultarPorId(id); 

                // Verifica se o objeto não esta vazio
                if(hospede != null)
                {
                    hospedeCollection.Add(hospede); // Adiciona o objeto na Collection
                }
            } 
            else 
            {
                // Armazena os registros retornados pela consulta por Nome na Collection
                hospedeCollection = hospedeController.ConsultarPorNome(txtPesquisa.Text);  
            }

            // Preenche o Data Grid com os valores da Collection
            dgvRegistros.DataSource= hospedeCollection;
            dgvRegistros.Update(); // Atualiza com os novos valores
            dgvRegistros.Refresh(); // Reexibe o Datagrid atualizado
        }

        // Método para Excluir o Registro Selecionado
        private void Excluir()
        {
            // Recupera o valor selecionado e armazena em um objeto
            Hospede hospedeSelecionado = Recuperar();
            
            // Se o valor selecionado não for nulo, executa
            if (hospedeSelecionado != null)
            {
                // Exibe uma Mensagem de confirmação e verifica se recebeu a resposta Yes
                if (MessageBox.Show("Deseja realmente excluir o hospede?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Instancia um controller
                    HospedeController clienteController = new HospedeController();

                    // Realiza a operação de DELETE e verifica se foi um sucesso
                    if (clienteController.Apagar(hospedeSelecionado.IdHospede) > 0)
                    {
                        // Exibe uma Mensagem de Sucesso
                        MessageBox.Show("Hospede excluído com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Exibe os registros que estão na tabela atualmente
                        Pesquisar();
                    }
                    else
                    {
                        // Exibe uma Mensagem de Erro
                        MessageBox.Show("Não foi possível excluir o hospede.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        // Método para obter as informações do registro selecionado
        private Hospede Recuperar()
        {
            // Verifica se tem algum registro selecionado
            if (dgvRegistros.SelectedRows.Count == 0)
            {
                // Exibe uma Mensagem de Aviso
                MessageBox.Show("Nenhum hospede selecionado.",
                    "Informação", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                // Não retorna nada
                return null;
            }
            else
            {
                // Retorna o valor do registro selecionado na forma de um objeto
                return dgvRegistros.SelectedRows[0].DataBoundItem as Hospede;
            }
        }

        // Método para abrir a pagina de formulario, espera de parametros o tipo de formulario e o objeto que vai ser utilizado
        private void Formulario(FormType formType, Hospede hospede)
        {
            // Instancia o objeto do formulario com os parametros do mmétodo
            frmHospedeForm frm = new frmHospedeForm(formType, hospede);
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
            hospedeSelecionado = Recuperar();

            // Se tiver dados
            if (hospedeSelecionado != null)
            {
                // Mostra uma tela de confirmação
                this.DialogResult = DialogResult.OK;                
            }
        }

        // Quando a página é carregada executa
        private void frmHospede_Load(object sender, EventArgs e)
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
