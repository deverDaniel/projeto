using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL
{
    public class Consulta:Conexao
    {
        public DataTable consultar(string sql)
        {
            DataTable dt = new DataTable();
            conn = getConexao();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            //fazer a consulta da informação passada pela query
            MySqlDataAdapter dados = new MySqlDataAdapter(cmd);//
            dados.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
