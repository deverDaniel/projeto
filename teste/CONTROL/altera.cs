using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL
{
    internal class altera:Conexao
    {
        public int alterar(string[] campos, string[] valores, string SQLinsert, string cod)
        {

            int registro = -1;
            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SQLinsert, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = SQLinsert;
                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }
                cmd.Parameters.AddWithValue("@cod", Convert.ToInt32(cod));
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
