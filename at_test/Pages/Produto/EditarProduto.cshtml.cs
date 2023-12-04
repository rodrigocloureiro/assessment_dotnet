using at_test.Data.Models;
using at_test.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace at_test.Pages.Produto
{
    public class EditarProdutoModel : PageModel
    {
        private EsportivaContext _context;
        [BindProperty]
        public ProdutoModel ProdutoEditado { get; set; }

        public EditarProdutoModel(EsportivaContext context)
        {
            _context = context;
        }
        public void OnGet(int id)
        {
            ProdutoEditado = _context.Produtos.FirstOrDefault(prod => prod.Id == id);
        }

        public IActionResult OnPost(int id)
        {
            ProdutoModel produtoAntigo = _context.Produtos.AsNoTracking().FirstOrDefault(prod => prod.Id == id);

            Console.WriteLine("\n\n");
            Console.WriteLine(id);
            Console.WriteLine(ProdutoEditado.Id);
            Console.WriteLine(ProdutoEditado.Nome);
            Console.WriteLine(ProdutoEditado.Descricao);
            Console.WriteLine(ProdutoEditado.Preco);
            Console.WriteLine(ProdutoEditado.Quantidade);
            Console.WriteLine(ProdutoEditado.Upload);
            Console.WriteLine(ProdutoEditado.NomeImagem);
            Console.WriteLine("\n\n");

            if (!ModelState.IsValid)
            {
                var propriedadesComErros = ModelState.Where(x => x.Value.Errors.Any())
                                            .Select(x => new { Propriedade = x.Key, Erros = x.Value.Errors })
                                            .ToList();

                // Fa�a o que for necess�rio com as propriedades com erros
                // Por exemplo, voc� pode logar ou retornar uma resposta com os detalhes dos erros
                foreach (var propriedadeComErro in propriedadesComErros)
                {
                    foreach (var erro in propriedadeComErro.Erros)
                    {
                        // Fa�a algo com o erro, como logar ou processar de alguma forma
                        Console.WriteLine($"Propriedade: {propriedadeComErro.Propriedade}, Erro: {erro.ErrorMessage}");
                    }
                    return Page();
                }
            }

            if (ProdutoEditado.Upload is null)
            {
                ProdutoEditado.NomeImagem = produtoAntigo.NomeImagem;
            }
            else
            {
                ProdutoEditado.NomeImagem = ProdutoEditado.Upload.FileName;
            }

            _context.Produtos.Update(ProdutoEditado);
            _context.SaveChanges();

            return RedirectToPage("ExibirProdutos");
        }
    }
}
