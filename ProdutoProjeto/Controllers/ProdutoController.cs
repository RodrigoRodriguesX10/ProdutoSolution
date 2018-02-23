using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdutoProjeto.Models;

namespace ProdutoProjeto.Controllers
{
    public class ProdutoController : Controller
    {
        public static List<Produto> Produtos = new List<Produto>
        {
            new Produto { Id = 1, Categoria = "Alimento", Nome = "Feijão", Preco = 10 },
            new Produto { Id = 2, Categoria = "Higiene", Nome = "Sabonete", Preco = .80m },
            new Produto { Id = 3, Categoria = "Bebida", Nome = "Refrigerante", Preco = 10 },
            new Produto { Id = 4, Categoria = "Alimento", Nome = "Arroz", Preco = 10 },
            new Produto { Id = 5, Categoria = "Higiene", Nome = "Shampoo", Preco = 6.66M }
        };
        // GET: Produto
        public ActionResult Index()
        {
            return View(Produtos);
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id) 
        {
            var produto = Produtos.First(p => p.Id == id);
            return View(produto);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produto model)
        {
            try
            {
                Produtos.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            var produto = Produtos.First(p => p.Id == id);
            return View(produto);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Produto produto)
        {
            try
            {
                var model = Produtos.First(p => p.Id == produto.Id);
                var index = Produtos.IndexOf(model);
                Produtos[index] = produto;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}