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
            dgvRegistros.AutoGenerateColumns = false;
            btnSelecionar.Visible = ExibirBotaoSelecionar;
        }

        private void Pesquisar()
        {
            int id = 0;
            HospedeController hospedeController = new HospedeController();
            HospedeCollection hospedeCollection = new HospedeCollection();

            dgvRegistros.DataSource = null;

            if (int.TryParse(txtPesquisa.Text, out id))
            {
                Hospede hospede = hospedeController.ConsultarPorId(id); 
                if(hospede != null)
                {
                    hospedeCollection.Add(hospede);
                }
            } 
            else
            {
                hospedeCollection = hospedeController.ConsultarPorNome(txtPesquisa.Text); 
            }

            dgvRegistros.DataSource= hospedeCollection;
            dgvRegistros.Update();
            dgvRegistros.Refresh();
        }

        private void Excluir()
        {
            Hospede selectedHospede = Recuperar();

            if (hospedeSelecionado != null)
            {
                if (MessageBox.Show("Deseja realmente excluir o hospede?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    HospedeController clienteController = new HospedeController();

                    if (clienteController.Apagar(hospedeSelecionado.IdHospede) > 0)
                    {
                        MessageBox.Show("Hospede excluído com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Pesquisar();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o hospede.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }


        private Hospede Recuperar()
        {
            if (dgvRegistros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum hospede selecionado.",
                    "Informação", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return null;
            }
            else
            {
                return dgvRegistros.SelectedRows[0].DataBoundItem
                as Hospede;
            }
        }


        private void Formulario(FormType formType, Hospede hospede)
        {
            frmHospedeForm frm = new frmHospedeForm(formType, hospede);
            frm.ShowDialog();

            if (formType != FormType.Visualizar)
            {
                Pesquisar();
            }
        }

        private void Selecionar()
        {
            hospedeSelecionado = Recuperar();
            if (hospedeSelecionado != null)
            {
                this.DialogResult = DialogResult.OK;                
            }
        }

        private void frmHospede_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

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


    }
}
