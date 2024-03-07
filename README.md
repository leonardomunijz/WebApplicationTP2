# WebApplicationTP2

<<<<<<< HEAD
# Teste de Performance 2 - P�ginas Razor
=======
# Teste de Performance 2 - Páginas Razor
>>>>>>> 5f7145b5c915c449483e7e465b73b2a2de6ffc58

Este � um projeto de teste de performance (TP) para praticar os conhecimentos adquiridos sobre o framework .NET e a cria��o de p�ginas Razor.

## Sobre o projeto

O projeto consiste em uma aplica��o web simples que utiliza o ASP.NET Core e as p�ginas Razor para exibir informa��es sobre pessoas. O projeto foi desenvolvido no Visual Studio e segue a estrutura padr�o de uma aplica��o web com ASP.NET Core.

## Perguntas e respostas

Neste documento, vou responder �s seguintes perguntas relacionadas � cria��o de p�ginas Razor:

- O que s�o as p�ginas Razor do ASP.NET Core e como funciona a sua estrutura?
- Crie uma aplica��o Web no Visual Studio utilizando o ASP .NET Core. 
- Execute e capture a tela inicial da sua aplica��o.
- Altere a p�gina Index para apresentar no t�tulo da aba do browser �P�gina do ALUNO�. Nesta p�gina, apresente uma mensagem motivacional. Criar uma classe �Pessoa" com os atributos encapsulados chamado nome, idade, CPF. Criar propriedades para acessar estes dados. Criar uma nova p�gina Razor na pasta Pages e faz�-la a p�gina default a ser apresentada quando a aplica��o for executada. Al�m disso, apresente na tela elementos da classe Pessoa que est�o em uma lista.

### O que s�o as p�ginas Razor do ASP.NET Core e como funciona a sua estrutura?

As p�ginas Razor do ASP.NET Core s�o uma forma de criar p�ginas web din�micas que combinam c�digo C# e HTML. As p�ginas Razor t�m a extens�o .cshtml e podem conter tags HTML, express�es C#, diretivas Razor, componentes, entre outros elementos. As p�ginas Razor s�o processadas no servidor e geram o HTML que � enviado para o navegador.

A estrutura de uma p�gina Razor � composta por duas partes principais: o modelo de p�gina e a p�gina Razor. O modelo de p�gina � uma classe C# que herda de PageModel e cont�m a l�gica e os dados da p�gina. A p�gina Razor � um arquivo .cshtml que cont�m o c�digo HTML e C# que define a apar�ncia da p�gina. A p�gina Razor usa a diretiva @model para referenciar o modelo de p�gina correspondente.

Um exemplo de modelo de p�gina e p�gina Razor � o seguinte:

```csharp
// Modelo de p�gina IndexModel.cs
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
<!-- Página Razor Index.cshtml -->
@page
@model IndexModel
<h1>Página Inicial</h1>
<p>@Model.Message</p>
```
>>>>>>> 5f7145b5c915c449483e7e465b73b2a2de6ffc58
