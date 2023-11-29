using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourRoom.Controllers;
using YourRoom.Models;
using YourRoom.Services;

namespace YourRoom.Views
{
    public partial class frmQuarto : Form
    {

        public Quarto quartoSelecionado;

        public frmQuarto(bool ExibirBotaoSelecionar = false)
        {
            InitializeComponent();
            dgvRegistros.AutoGenerateColumns = false; //Permite customização nas colunas do Data Grid
            btnSelecionar.Visible = ExibirBotaoSelecionar; //Define visibilidade do botão de seleção
        }

        private void Pesquisar()
        {
            int id = 0;
            QuartoController quartoController = new QuartoController();
            QuartoCollection quartoCollection = new QuartoCollection();

            dgvRegistros.DataSource = null;

            if (int.TryParse(txtPesquisa.Text, out id))
            {
                Quarto quarto = quartoController.ConsultarPorId(id);

                if (quarto != null)
                {
                    quartoCollection.Add(quarto);
                }
            }
            else
            {
                quartoCollection = quartoController.ConsultarPorNumero(int.Parse(txtPesquisa.Text));
            }

            dgvRegistros.DataSource = quartoCollection;
            dgvRegistros.Update(); // Atualiza com os novos valores
            dgvRegistros.Refresh(); // Reexibe o Datagrid atualizado
        }

        private Quarto Recuperar()
        {
            // Verifica se tem algum registro selecionado
            if (dgvRegistros.SelectedRows.Count == 0)
            {
                // Exibe uma Mensagem de Aviso
                MessageBox.Show("Nenhum quarto selecionado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Não retorna nada
                return null;
            }
            else
            {
                // Retorna o valor do registro selecionado na forma de um objeto
                return dgvRegistros.SelectedRows[0].DataBoundItem as Quarto;
            }
        }

        private void Excluir()
        {
            Quarto quartoSelecionado = Recuperar();

            if (quartoSelecionado != null)
            {
                if (MessageBox.Show("Deseja realmente excluir o quarto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Instancia um controller
                    QuartoController reservaController = new QuartoController();

                    if (reservaController.Apagar(quartoSelecionado.IdQuarto) > 0)
                    {
                        MessageBox.Show("Quarto excluído com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Pesquisar();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o quarto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }


        private void Formulario(FormType formType, Quarto quarto)
        {
            frmQuartoForm frm = new frmQuartoForm(formType,quarto);
            frm.ShowDialog();

            if(formType != FormType.Visualizar)
            {
                Pesquisar();
            }
        }

        private void Selecionar()
        {
            quartoSelecionado = Recuperar();
            if(quartoSelecionado != null)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        

        private void frmQuarto_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

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
