using System;
using System.Data;
using YourRoom.Models;
using YourRoom.Services;

namespace YourRoom.Controllers
{
    public class UsuarioController
    {
        #region Variaveis Locais
        // Importa os métodos que realizam interação com o banco de dados
        DataBaseSqlServer dataBase = new DataBaseSqlServer();
        #endregion

        #region Inserir
        // Insere na tabela de reserva
        public int Inserir(Usuario usuario)
        {
            // Limpa os parametros que podem estar na Query
            dataBase.ClearParameter();

            // Query que vai ser executada
            string query =
            "INSERT INTO Usuario (Nome, Login, Senha, NivelAcesso) " +
            "VALUES (@Nome, @Login, @Senha, @NivelAcesso)";

            //Adiona os valores de cada parametro que esta sendo utilizado
            dataBase.AddParameter("@Nome", usuario.Nome);
            dataBase.AddParameter("@Login", usuario.Login);
            dataBase.AddParameter("@Senha", usuario.Senha);
            dataBase.AddParameter("@NivelAcesso", usuario.NivelAcesso);

        //Solicita a camada de banco de dados a execução da query
        dataBase.ExecuteManipulation(CommandType.Text, query);
            //Nesse momento o meu comando é executado no banco de dados

            //Executar um comando no banco de dados, para recupear o ID criado
            //pelo Identity
            //SELECT @@IDENTITY
            return Convert.ToInt32(dataBase.ExecuteQueryScalar(
                CommandType.Text, "SELECT @@IDENTITY"));
        }
        #endregion

        #region Alterar
        // Atualiza na tabela de reserva
        public int Alterar(Usuario usuario)
        {
            string query =
                "UPDATE Usuario SET " +
                "Nome = @Nome, " +
                "Login = @Login, " +
                "Senha = @Senha, " +
                "NivelAcesso = @NivelAcesso, " +
                "WHERE IdUsuario = @IdUsuario";

            dataBase.ClearParameter();
            dataBase.AddParameter("@Nome", usuario.Nome);
            dataBase.AddParameter("@Login", usuario.Login);
            dataBase.AddParameter("@Senha", usuario.Senha);
            dataBase.AddParameter("@NivelAcesso", usuario.NivelAcesso);
            dataBase.AddParameter("@IdUsuario", usuario.IdUsuario);

            return dataBase.ExecuteManipulation(CommandType.Text, query);
        }
        #endregion

        #region Apagar
        public int Apagar(int IdUsuario)
        {
            string query =
                "DELETE FROM Usuario " +
                "WHERE IdUsuario = @IdUsuario";

            dataBase.ClearParameter();
            dataBase.AddParameter("@IdUsuario", IdUsuario);

            return dataBase.ExecuteManipulation(CommandType.Text, query);
        }
        #endregion

        #region ConsultarPorNome
        public UsuarioCollection ConsultarPorNome(string nome)
        {
            UsuarioCollection usuarioCollection = new UsuarioCollection();
            string query =
                "SELECT * FROM Usuario " +
                "WHERE Nome LIKE '%' + @Nome + '%'";

            dataBase.ClearParameter();
            dataBase.AddParameter("@Nome", nome.Trim());

            DataTable dataTable = dataBase.ExecuteQuery(CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Usuario usuario = new Usuario();

                usuario.IdUsuario = Convert.ToInt32(dataRow["IdUsuario"]);
                usuario.Nome = Convert.ToString(dataRow["Nome"]);
                usuario.Login = Convert.ToString(dataRow["Login"]);
                usuario.Senha = Convert.ToString(dataRow["Senha"]);
                usuario.NivelAcesso = Convert.ToInt32(dataRow["NivelAcesso"]);

                usuarioCollection.Add(usuario);
            }
            return usuarioCollection;
        }
        #endregion

        #region ConsultarPorId
        public Usuario ConsultarPorId(int IdUsuario)
        {
            string query =
                "SELECT * FROM Hospede " +
                "WHERE IdHospede = @IdHospede";

            dataBase.ClearParameter();
            dataBase.AddParameter("@IdUsuario", IdUsuario);

            DataTable dataTable = dataBase.ExecuteQuery(
                CommandType.Text, query);

            if (dataTable.Rows.Count > 0)
            {
                Usuario usuario = new Usuario();

                usuario.IdUsuario = Convert.ToInt32(dataTable.Rows[0]["IdUsuario"]);
                usuario.Nome = Convert.ToString(dataTable.Rows[0]["Nome"]);
                usuario.Login = Convert.ToString(dataTable.Rows[0]["Login"]);
                usuario.Senha = Convert.ToString(dataTable.Rows[0]["Senha"]);
                usuario.NivelAcesso = Convert.ToInt32(dataTable.Rows[0]["NivelAcesso"]);

                return usuario;
            }
            else
                return null;
        }
        #endregion
    }
}
