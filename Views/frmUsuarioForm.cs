using System;
using System.Windows.Forms;
using YourRoom.Models;
using YourRoom.Controllers;
using YourRoom.Services;

namespace YourRoom.Views
{
    public partial class frmUsuarioForm : Form
    {
        FormType formTypeSelecionado;
        Usuario usuarioSelecionado;

        public frmUsuarioForm(FormType formType, Usuario usuario)
        {
            InitializeComponent();
            InitializeComboBox();
            this.formTypeSelecionado = formType;
            this.usuarioSelecionado = usuario;

            if (formTypeSelecionado == FormType.Inserir)
            {
                this.Text = "Cadastrar Usuario";
            }
            else
            {
                CarregarDados();

                if (formType == FormType.Alterar)
                {
                    this.Text = "Alterar Usuario";
                }
                else
                {
                    this.Text = "Visualizar Usuario";
                    DesabilitarCampos();
                }
            }
        }

        private void InitializeComboBox()
        {
            // Adiciona na combo box os valores do enumerador
            cbxNivelAcesso.Items.AddRange(Enum.GetNames(typeof(NivelAcesso)));
        }

        private void CarregarDados()
        {
            txtId.Text = usuarioSelecionado.IdUsuario.ToString();
            txtNome.Text = usuarioSelecionado.Nome;
            txtLogin.Text = usuarioSelecionado.Login;
            txtSenha.Text = usuarioSelecionado.Senha;
            cbxNivelAcesso.SelectedIndex = usuarioSelecionado.NivelAcesso;
        }

        private void DesabilitarCampos()
        {
            txtNome.ReadOnly = true;
            txtLogin.ReadOnly = true;
            txtSenha.ReadOnly = true;
            cbxNivelAcesso.Enabled = false;

            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void Salvar()
        {
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                Usuario usuario = new Usuario();

                usuario.Nome = txtNome.Text;
                usuario.Login = txtLogin.Text;
                usuario.Senha = txtSenha.Text;
                usuario.NivelAcesso = cbxNivelAcesso.SelectedIndex;

                UsuarioController usuarioController = new UsuarioController();

                int idCadastro = 0;

                if (formTypeSelecionado == FormType.Inserir) 
                {
                    idCadastro = usuarioController.Inserir(usuario);
                }
                else
                {
                    usuario.IdUsuario = int.Parse(txtId.Text);
                    idCadastro = usuarioController.Alterar(usuario);
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

        private void frmUsuarioForm_FormClosing(object sender, FormClosingEventArgs e)
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
