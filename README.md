# WebApplicationTP2

<<<<<<< HEAD
# Teste de Performance 2 - Páginas Razor
=======
# Teste de Performance 2 - PÃ¡ginas Razor
>>>>>>> 5f7145b5c915c449483e7e465b73b2a2de6ffc58

Este é um projeto de teste de performance (TP) para praticar os conhecimentos adquiridos sobre o framework .NET e a criação de páginas Razor.

## Sobre o projeto

O projeto consiste em uma aplicação web simples que utiliza o ASP.NET Core e as páginas Razor para exibir informações sobre pessoas. O projeto foi desenvolvido no Visual Studio e segue a estrutura padrão de uma aplicação web com ASP.NET Core.

## Perguntas e respostas

Neste documento, vou responder às seguintes perguntas relacionadas à criação de páginas Razor:

- O que são as páginas Razor do ASP.NET Core e como funciona a sua estrutura?
- Crie uma aplicação Web no Visual Studio utilizando o ASP .NET Core. 
- Execute e capture a tela inicial da sua aplicação.
- Altere a página Index para apresentar no título da aba do browser “Página do ALUNO”. Nesta página, apresente uma mensagem motivacional. Criar uma classe “Pessoa" com os atributos encapsulados chamado nome, idade, CPF. Criar propriedades para acessar estes dados. Criar uma nova página Razor na pasta Pages e fazê-la a página default a ser apresentada quando a aplicação for executada. Além disso, apresente na tela elementos da classe Pessoa que estão em uma lista.

### O que são as páginas Razor do ASP.NET Core e como funciona a sua estrutura?

As páginas Razor do ASP.NET Core são uma forma de criar páginas web dinâmicas que combinam código C# e HTML. As páginas Razor têm a extensão .cshtml e podem conter tags HTML, expressões C#, diretivas Razor, componentes, entre outros elementos. As páginas Razor são processadas no servidor e geram o HTML que é enviado para o navegador.

A estrutura de uma página Razor é composta por duas partes principais: o modelo de página e a página Razor. O modelo de página é uma classe C# que herda de PageModel e contém a lógica e os dados da página. A página Razor é um arquivo .cshtml que contém o código HTML e C# que define a aparência da página. A página Razor usa a diretiva @model para referenciar o modelo de página correspondente.

Um exemplo de modelo de página e página Razor é o seguinte:

```csharp
// Modelo de página IndexModel.cs
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Hello, world!";
        }
    }
<<<<<<< HEAD
}
=======
}
```
```html
<!-- PÃ¡gina Razor Index.cshtml -->
@page
@model IndexModel
<h1>PÃ¡gina Inicial</h1>
<p>@Model.Message</p>
```
>>>>>>> 5f7145b5c915c449483e7e465b73b2a2de6ffc58
