using Micro_OndasAPI.Models;
using Micro_OndasAPI.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Micro_OndasAPI.Persistencia
{
    public class UsuarioPersistencia
    {

        public RetornoPadraoModel CriarUsuario(UsuarioModel usuModel) {
            SQLiteCommand cmd = new SQLiteCommand();
            SQLiteDataReader dr;

            DataTable dt = new DataTable();

            string sql = "";
            string retornoMensagem = "";
            bool retornoStatus = false;
            try
            {

                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(usuModel.senha);
                    byte[] hash = sha256.ComputeHash(bytes);

                    StringBuilder builder = new StringBuilder();
                    foreach (var b in hash)
                        builder.Append(b.ToString("x2"));

                    usuModel.senha = builder.ToString();
                }

                var conexao = Global.CriarConexao();

                conexao.Open();

                cmd = conexao.CreateCommand();

                sql = "insert into usuario (nome,login,senha) values (@nome,@login,@senha)";

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@nome", usuModel.nome);
                cmd.Parameters.AddWithValue("@login", usuModel.login);
                cmd.Parameters.AddWithValue("@senha", usuModel.senha);


                dr = cmd.ExecuteReader();

                retornoMensagem = "teste concluido";
                retornoStatus = true;
            }
            catch (Exception ex)
            {
                retornoMensagem = "Falha: "+ex.Message;
            }

            Global.FecharConexao();

            RetornoPadraoModel retorno = new RetornoPadraoModel();
            retorno.Data = usuModel;
            retorno.Mensagem = retornoMensagem;
            retorno.Status = retornoStatus;
            return retorno;

        }

    }
}