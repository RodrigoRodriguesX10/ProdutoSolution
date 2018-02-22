using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdutoProjeto.Models;

namespace ProdutoProjeto.Controllers
{
    public class UsuarioController : Controller
    {
        public static List<Usuario> Usuarios = new List<Usuario>
        {
            new Usuario { Id = 1, Nome = "Usuario 1",Cpf = "11122233344854", Email="user1@mail.com" },
            new Usuario { Id = 2, Nome="Usuario 2",Cpf = "11122233344854", Email="user2@mail.com" },
            new Usuario { Id = 3, Nome="Usuario 3",Cpf = "11122233344854", Email="user3@mail.com" },
            new Usuario { Id = 4, Nome="Usuario 4",Cpf = "11122233344854", Email="user4@mail.com" },
            new Usuario { Id = 5, Nome="Usuario 5",Cpf = "11122233344854", Email="user5@mail.com" }
        };
        // GET: Usuario
        public ActionResult Index()
        {
            return View(Usuarios);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
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