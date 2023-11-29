using System;
using System.Reflection;
using System.Windows.Forms;
using YourRoom.Controllers;
using YourRoom.Models;

namespace YourRoom.Views
{
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
            dgvRegistros.AutoGenerateColumns = false;
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

        }

        private void Pesquisar()
        {
            int id = 0;

            ReservaController reservaController = new ReservaController();
            ReservaCollection reservaCollection = new ReservaCollection();

            dgvRegistros.DataSource = null;

            // Verifica se o que foi digitado na pesquisa é um ID verificando se só ha números inteiros no cammpo
            if (int.TryParse(txtPesquisa.Text, out id))
            {
                // Armazena o registro retornado pela consulta por ID num objeto
                Reserva reserva = reservaController.ConsultarPorId(id);

                // Verifica se o objeto não esta vazio
                if (reserva != null)
                {
                    reservaCollection.Add(reserva); // Adiciona o objeto na Collection
                }
            }
            else
            {
                // Armazena os registros retornados pela consulta por Nome na Collection
                reservaCollection = reservaController.ConsultarReservas();
            }

            dgvRegistros.DataSource = reservaCollection;
            dgvRegistros.Update();
            dgvRegistros.Refresh();
        }
    }
}
