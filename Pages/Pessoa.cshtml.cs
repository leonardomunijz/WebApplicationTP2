using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationTP2.Models;

namespace WebApplicationTP2.Pages
{
    public class PessoaModel : PageModel
    {
        public List<Pessoa> PessoaList { get; set; }

        public void OnGet()
        {
            PessoaList = new List<Pessoa>();

            PessoaList.Add(new Pessoa { Nome = "Leonardo Muniz", Idade = 25, Cpf = "123.456.789-09" });
            PessoaList.Add(new Pessoa { Nome = "Calebe Machado", Idade = 20, Cpf = "987.654.321-01" });
            PessoaList.Add(new Pessoa { Nome = "André Becker", Idade = 39, Cpf = "234.567.890-12" });
            PessoaList.Add(new Pessoa { Nome = "Ricardo Frohlich", Idade = 39, Cpf = "456.789.012-23" });
            PessoaList.Add(new Pessoa { Nome = "Elberth Moraes", Idade = 40, Cpf = "567.890.123-34" });
            PessoaList.Add(new Pessoa { Nome = "Luiz Paulo Maia", Idade = 44, Cpf = "111.222.333-44" });
        }   
    }
}
