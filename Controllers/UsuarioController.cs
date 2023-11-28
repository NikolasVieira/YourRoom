using System;
using System.Data;
using YourRoom.Models;
using YourRoom.Services;

namespace YourRoom.Controllers
{
    public class UsuarioController
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        #region Inserir
        public int Inserir(Usuario usuario)
        {
            dataBase.ClearParameter();

            string query =
            "INSERT INTO tb_usuarios (nome , login, senha, nivel_acesso) " +
            "VALUES (@Nome, @Login, @Senha, @NivelAcesso)";

            dataBase.AddParameter("@Nome", usuario.Nome);
            dataBase.AddParameter("@Login", usuario.Login);
            dataBase.AddParameter("@Senha", usuario.Senha);
            dataBase.AddParameter("@NivelAcesso", usuario.NivelAcesso);

        dataBase.ExecuteManipulation(CommandType.Text, query);

            return Convert.ToInt32(dataBase.ExecuteQueryScalar(CommandType.Text, "EXEC sp_get_last_usuario"));
        }
        #endregion

        #region Alterar
        public int Alterar(Usuario usuario)
        {
            string query =
                "UPDATE tb_usuarios SET " +
                "nome = @Nome, " +
                "login = @Login, " +
                "senha = @Senha, " +
                "nivel_acesso  = @NivelAcesso, " +
                "WHERE id = @IdUsuario";

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
                "DELETE FROM tb_usuarios " +
                "WHERE id = @IdUsuario";

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
                "SELECT * FROM tb_usuarios " +
                "WHERE nome LIKE '%' + @Nome + '%'";

            dataBase.ClearParameter();
            dataBase.AddParameter("@Nome", nome.Trim());

            DataTable dataTable = dataBase.ExecuteQuery(CommandType.Text, query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Usuario usuario = new Usuario();

                usuario.IdUsuario = Convert.ToInt32(dataRow["id"]);
                usuario.Nome = Convert.ToString(dataRow["nome"]);
                usuario.Login = Convert.ToString(dataRow["login"]);
                usuario.Senha = Convert.ToString(dataRow["senha"]);
                usuario.NivelAcesso = Convert.ToInt32(dataRow["nivel_acesso"]);

                usuarioCollection.Add(usuario);
            }
            return usuarioCollection;
        }
        #endregion

        #region ConsultarPorId
        public Usuario ConsultarPorId(int IdUsuario)
        {
            string query =
                "SELECT * FROM tb_usuarios " +
                "WHERE id = @IdUsuario";

            dataBase.ClearParameter();
            dataBase.AddParameter("@IdUsuario", IdUsuario);

            DataTable dataTable = dataBase.ExecuteQuery(
                CommandType.Text, query);

            if (dataTable.Rows.Count > 0)
            {
                Usuario usuario = new Usuario();

                usuario.IdUsuario = Convert.ToInt32(dataTable.Rows[0]["id"]);
                usuario.Nome = Convert.ToString(dataTable.Rows[0]["nome"]);
                usuario.Login = Convert.ToString(dataTable.Rows[0]["login"]);
                usuario.Senha = Convert.ToString(dataTable.Rows[0]["senha"]);
                usuario.NivelAcesso = Convert.ToInt32(dataTable.Rows[0]["nivel_acesso"]);

                return usuario;
            }
            else
                return null;
        }
        #endregion
    }
}
