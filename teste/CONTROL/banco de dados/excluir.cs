using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL
{
    class excluir:Conexao
    {
        public int deletar(string campo, string valor, string sqldelete)
        {

            int registro = -1;
            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqldelete, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sqldelete;
                cmd.Parameters.AddWithValue(campo, Convert.ToInt32(valor));
                registro = cmd.ExecuteNonQuery();
                conn.Close();
                return registro;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
    }
}
