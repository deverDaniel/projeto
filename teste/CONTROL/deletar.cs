using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL
{
    class deletar: Conexao
    {
        public int Cadastrar(string[] campos, string[] valores, string sqldelet)
        {

            int registro = -1;
            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqldelet, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sqldelet;
                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], Convert.ToInt32(valores[i]));
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
