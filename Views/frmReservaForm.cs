using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourRoom.Models;
using YourRoom.Services;

namespace YourRoom.Views
{
    public partial class frmReservaForm : Form
    {
        enumFormType formTypeSelecionado;
        Reserva reservaSelecionado;

        public frmReservaForm(enumFormType formType, Reserva reserva)
        {
            InitializeComponent();
            this.formTypeSelecionado = formType;
            this.reservaSelecionado = reserva;

            if (formTypeSelecionado == enumFormType.Inserir)
            {
                this.Text = "Cadastrar Reserva";
            }
            else
            {
                CarregarDados();

                if (formType == enumFormType.Alterar)
                {
                    this.Text = "Alterar Reserva";
                }
                else
                {
                    this.Text = "Visualizar Reserva";
                    DesabilitarCampos();
                }
            }
        }


        private void CarregarDados()
        {
            txtCategoria.Text = reservaSelecionado.Quarto.Categoria.ToString();
            txtIdHospede.Text = reservaSelecionado.Hospede.IdHospede.ToString();
            txtIdQuarto.Text = reservaSelecionado.Quarto.IdQuarto.ToString();
            txtIdReserva.Text = reservaSelecionado.IdReserva.ToString();
            txtNomeHospede.Text = reservaSelecionado.Hospede.Nome.ToString();
            txtQuantidadeHospede.Text = reservaSelecionado.QtdHospedes.ToString();
            dtpDtReserva.Value = reservaSelecionado.DtReserva;
            dtpDtCheckIn.Value = reservaSelecionado.DtCheckIn;
            dtpDtCheckOut.Value = reservaSelecionado.DtCheckOut;
        }

        private void btnPesquisarHospede_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarQuarto_Click(object sender, EventArgs e)
        {

        }


    }
}
