namespace WebApplicationTP2.Models
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private string cpf;
        
        public Pessoa()
        {

        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public Pessoa(string nome, int idade, string cpf)
        {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
        }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Cpf { get => cpf; set => cpf = value; }
    }
}
