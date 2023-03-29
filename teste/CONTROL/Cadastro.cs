using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL
{
    internal class Cadastro : Conexao
    {


        public int Cadastrar(string[] campos, string[] valores, string SQLinsert)
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
