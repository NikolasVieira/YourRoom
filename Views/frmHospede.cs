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

        public frmHospede()
        {
            InitializeComponent();
        }

        private void Pesquisar()
        {
            int id = 0;
            HospedeController hospedeController = new HospedeController();
        }

        private void Excluir()
        {
            //Hospede selectedHospede = Recuperar();
        }

        /*
        private Hospede Recuperar()
        {

        }
        */

        private void Formulario()
        {

        }

        private void Selecionar()
        {

        }
    }
}
