using System;
using MODEL;
using MySql.Data.MySqlClient;

namespace CONTROL
{
    public class Usuariocontroller: Usuario
    {
        //variavel boleana resultado falso
        bool resultado = false;
        //chamando instancia de conexao
        
        //criando metodo booleano "cadastrarUsuario", passando o modelo usuario
        public bool cadastraUsuario(Usuario US)
        {
            try
            {
                Cadastro con = new Cadastro();
                //montando a string de insert sql
                string sql = "INSERT INTO usuario (nome,email,fone) values (@nome,@email,@fone)";
                //
                string[] campos = { "@nome", "@email", "@fone" };
                string[] valores = { US.GetNome(), US.Getemail(), US.Getfone() };
                if (con.Cadastrar(campos, valores, sql) >= 1)
                {
                    resultado = true;

                }
                else
                {
                    resultado = false;
                  
                }
                return resultado;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);

            }

        }
        public bool deletar_usuario(Usuario US)
        {
            try
            {
                excluir exc = new excluir();
                //montando a string de delete sql
                string sql = "delete from usuario where cod_usuario = @cod";
                string campos =  "@cod" ;
                string valor = (US.Getcod());
                if (exc.deletar(campos, valor, sql) >= 1)
                {
                    resultado = true;

                }
                else
                {
                    resultado = false;

                }
                return resultado;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);

            }

        }
        public bool alterar_usuario(Usuario US)
        {
            try
            {
                altera alt = new altera();
                string sql = "update usuario set nome = @nome, email = @email, fone= @fone where cod_usuario = @cod";
                string[] campos = { "@nome", "@email", "@fone" };
                string[] valor = { US.GetNome(), US.Getemail(), US.Getfone()};
                if (alt.alterar(campos, valor, sql,US.Getcod()) >= 1)
                {
                    resultado = true;

                }
                else
                {
                    resultado = false;

                }
                return resultado;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);

            }

        }
    }
}

