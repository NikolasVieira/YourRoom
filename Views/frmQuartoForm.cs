using System;
using System.Windows.Forms;
using YourRoom.Models;
using YourRoom.Controllers;
using YourRoom.Services;

namespace YourRoom.Views
{
    public partial class frmQuartoForm : Form
    {
        enumFormType formTypeSelecionado;
        Quarto quartoSelecionado;
        public frmQuartoForm(enumFormType formType, Quarto quarto)
        {
            InitializeComponent();
            InitializeComboBox();
            this.formTypeSelecionado = formType;
            this.quartoSelecionado = quarto;

            if(formTypeSelecionado == enumFormType.Inserir)
            {
                this.Text = "Cadastrar Quarto";
            }
            else
            {
                CarregarDados();
                if(formType == enumFormType.Alterar)
                {
                    this.Text = "Alterar Quarto";
                }
                else
                {
                    this.Text = "Vizualizar Quarto";
                    DesabilitarCampos();
                }
            }
        }

        private void InitializeComboBox()
        {
            // Adiciona na combo box os valores do enumerador
            cbxCategoria.Items.AddRange(Enum.GetNames(typeof(enumCategoria)));
            cbxStatus.Items.AddRange(Enum.GetNames(typeof(enumStatus)));
        }

        private void CarregarDados()
        {
            txtId.Text = quartoSelecionado.IdQuarto.ToString();
            txtNumero.Text = quartoSelecionado.Numero.ToString();
            cbxCategoria.SelectedIndex = quartoSelecionado.Categoria;
            cbxStatus.SelectedIndex = quartoSelecionado.Status;
            txtDiaria.Text = quartoSelecionado.Diaria.ToString();
            txtCapacidade.Text = quartoSelecionado.Capacidade.ToString();
        }

        private void DesabilitarCampos()
        {
            txtNumero.ReadOnly = true;
            cbxCategoria.Enabled = false;
            cbxStatus.Enabled = false;
            txtDiaria.ReadOnly = true;
            txtCapacidade.Enabled = false;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;

        }

        private void Salvar()
        {
            if (!string.IsNullOrEmpty(txtNumero.Text))
            {
                Quarto quarto = new Quarto();
                quarto.Numero = int.Parse(txtNumero.Text);
                quarto.Categoria = cbxCategoria.SelectedIndex;
                quarto.Status = cbxStatus.SelectedIndex;
                quarto.Diaria = decimal.Parse(txtDiaria.Text);
                quarto.Capacidade = int.Parse(txtCapacidade.Text);

                QuartoController quartoController = new QuartoController();

                int idCadastro = 0;

                if(formTypeSelecionado == enumFormType.Inserir)
                {
                    idCadastro = quartoController.Inserir(quarto);
                }
                else
                {
                    quarto.IdQuarto = int.Parse(txtId.Text);
                    idCadastro = quartoController.Alterar(quarto);
                }

                if(idCadastro > 0)
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

        private void frmQuartoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(formTypeSelecionado == enumFormType.Visualizar)
            {
                if (MessageBox.Show("Deseja realmente sair?", "Confirmação...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

    }
}
