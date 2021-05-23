using BlogPessoal.Web.Data.Contexto;
using BlogPessoal.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BlogPessoal.Web.Controllers
{
    public class CategoriasdeArtigoController : Controller
    {
        //Referenciando o Contexto
        private BlogPessoalContexto _ctx = new BlogPessoalContexto();

        //Listar
        // GET: CategoriasdeArtigo
        public ActionResult Index()
        {
            var categorias = _ctx.CategoriasdeArtigo
                .OrderBy(t => t.Nome)
                .ToList();
            return View(categorias);
        }

        //Criar
        //View de Apresentação do Formulário
        public ActionResult Create()
        {            
            return View();
        }

        //View para Persistir os dados - Criar
        [HttpPost]
        public ActionResult Create(CategoriadeArtigo categoria)
        {
            if (ModelState.IsValid) //checa se o todo modelo está valido
            {
                _ctx.CategoriasdeArtigo.Add(categoria);
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoria); //retorna os dados que ele preencheu
        }

        //Alterar
        //View de Apresentação do Formulário
        public ActionResult Edit(int? id) //nullable ?
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var categoria = _ctx.CategoriasdeArtigo.Find(id);  //else

            if (categoria == null)
                return HttpNotFound();
            return View(categoria); //else - view de edit passando a categoria
        }

        //View para Persistir os dados - Alterar
        [HttpPost]
        public ActionResult Edit(CategoriadeArtigo categoria)
        {
            if (ModelState.IsValid) //checa se o todo modelo está valido. trabalha com dataAnotation
            {
                _ctx.Entry(categoria).State = EntityState.Modified; //modificando os dados
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoria); //retorna os dados que ele preencheu
        }

        //Deletar
        public ActionResult Delete(int? id) //passa o id que deve deletar
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var categoria = _ctx.CategoriasdeArtigo.Find(id); //else

            if (categoria == null)
                return HttpNotFound();
            return View(categoria); //else - retorna as categorias atuais
        }

        //View para Persistir os dados - Deletar
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var categoria = _ctx.CategoriasdeArtigo.Find(id);
            _ctx.CategoriasdeArtigo.Remove(categoria);
            _ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}