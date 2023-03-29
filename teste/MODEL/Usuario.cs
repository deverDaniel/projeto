namespace MODEL
{
    public class Usuario
    {
        string nome;
        string email;
        string fone;
        string cod;
        public Usuario()
        {
            nome = "";
            email = "";
            fone = "";

        }
        public string test(string valor)
        {
            return nome = valor;
        }
        public string GetNome()
        {
            return this.nome;
        }
        public string Getemail()
        {
            return this.email;
        }
        public string Getfone()
        {
            return this.fone;
        } public void setnome(string nome)
        {
            this.nome = nome;

        } public void setemail(string email)
        {
            this.email = email;
        }public void setfone (string fone)
        {
            this.fone = fone;
        }
        public string Getcod()
        {
            return this.cod;
        }
        public void setcod(string cod)
        {
            this.cod = cod;
        }
    }
}