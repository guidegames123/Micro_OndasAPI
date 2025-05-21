using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace Micro_OndasAPI.Persistencia
{
    public class Global
    {

        private static SQLiteConnection conexao;

        public static SQLiteConnection CriarConexao()
        {
            if (conexao == null)
            {
                string caminho = "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "Micro_OndasBD.db;Version=3;";
                conexao = new SQLiteConnection(caminho);
            }
            return conexao;
        }

        public static void FecharConexao()
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
                conexao.Close();
        }

    }
}