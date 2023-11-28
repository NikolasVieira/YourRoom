using System;
using System.Windows.Forms;
using YourRoom.Models;
using YourRoom.Controllers;
using YourRoom.Services;

namespace YourRoom.Views
{
    public partial class frmHospedeForm : Form
    {
        FormType formTypeSelecionado;
        Hospede hospedeSelecionado;

        public frmHospedeForm(FormType formType, Hospede hospede)
        {
            InitializeComponent();
            this.formTypeSelecionado = formType;
            this.hospedeSelecionado = hospede;

            if (formTypeSelecionado == FormType.Inserir)
            {
                this.Text = "Cadastrar Hospede";
            }
            else
            {
                CarregarDados();

                if (formType == FormType.Alterar)
                {
                    this.Text = "Alterar Hospede";
                }
                else
                {
                    this.Text = "Visualizar Hospede";
                    DesabilitarCampos();
                }
            }
        }

        private void CarregarDados()
        {
            txtId.Text = hospedeSelecionado.IdHospede.ToString();
            txtNome.Text = hospedeSelecionado.Nome;
            mskCPF.Text = hospedeSelecionado.CPF;
            dtpDtNascimento.Value = hospedeSelecionado.DtNascimento;
            txtTelefone.Text = hospedeSelecionado.Telefone;
        }

        private void DesabilitarCampos()
        {
            txtNome.ReadOnly = true;
            mskCPF.ReadOnly = true;
            dtpDtNascimento.Enabled = false;
            txtTelefone.ReadOnly = true;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void Salvar()
        {
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                Hospede hospede = new Hospede();

                hospede.Nome = txtNome.Text;

                hospede.CPF = mskCPF.Text.Replace(".", "");
                hospede.CPF = hospede.CPF.Replace(",", "");
                hospede.CPF = hospede.CPF.Replace("-", "");

                hospede.DtNascimento = dtpDtNascimento.Value;
                hospede.Telefone = txtTelefone.Text;

                HospedeController hospedeController = new HospedeController();

                int idCadastro = 0;

                if (formTypeSelecionado == FormType.Inserir)
                {
                    idCadastro = hospedeController.Inserir(hospede);
                }
                else
                {
                    hospede.IdHospede = int.Parse(txtId.Text);
                    idCadastro = hospedeController.Alterar(hospede);
                }

                if (idCadastro > 0)
                {
                    if (string.IsNullOrEmpty(txtId.Text))
                    {
                        txtId.Text = idCadastro.ToString();
                    }
                        
                    MessageBox.Show("Registro salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao salvar registro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHospedeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formTypeSelecionado != FormType.Visualizar)
            {
                if (MessageBox.Show("Deseja realmente sair?", "Confirmação...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
