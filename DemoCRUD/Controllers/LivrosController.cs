using DemoCRUD.AcessoDados;
using DemoCRUD.Infra;
using DemoCRUD.Models;
using DemoCRUD.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;
using System.Web.Mvc;

namespace DemoCRUD.Controllers
{
    public class LivrosController : Controller
    {
        private LivrosContexto db = new LivrosContexto();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarPorGenero(int id)
        {

            LivrosPorGeneroViewModel livrosPorGeneroVM = new LivrosPorGeneroViewModel();

            List<Livro> livros = null;

            if (id != 0)
            {
                Genero genero = db.Generos.FirstOrDefault(g => g.Id == id);

                livrosPorGeneroVM.Genero = genero.Nome;
                livros = db.Livros.Where(l => l.GeneroId == id).ToList();
            }
            else
            {
                livros = db.Livros.ToList();
            }

            livrosPorGeneroVM.Livros = livros;

            return PartialView(livrosPorGeneroVM);
        }


        public JsonResult Listar(ParametrosPaginacao paginacao)
        {
            var livros = db.Livros.AsQueryable();

            int totalLivros = livros.Count();

            if (!String.IsNullOrWhiteSpace(paginacao.SearchPhrase))
            {
                // tentar converter em número para pesquisa
                int ano = 0;
                int.TryParse(paginacao.SearchPhrase, out ano);

                // tentar converter em décima para pesquisa
                decimal valor = 0.0m;
                decimal.TryParse(paginacao.SearchPhrase, out valor);

                // utiliza Dynamic LINQ para fazer o filtro
                livros = livros.Where("Titulo.Contains(@0) OR Autor.Contains(@0) OR AnoEdicao == @1 OR Valor == @2", paginacao.SearchPhrase, ano, valor);
            }

            // utiliza Dynamic LINQ para fazer o ordenamento por um campo
            var livrosFiltrados = livros.OrderBy(paginacao.CampoOrdenado).Skip((paginacao.Current - 1) * paginacao.RowCount).Take(paginacao.RowCount).ToList();

            int totalFiltrado = livrosFiltrados.Count();

            return Json(new DadosFiltrados() {
                        current = paginacao.Current,
                        rowCount = paginacao.RowCount,
                        rows = livrosFiltrados,
                        total = totalLivros
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Livro livro = db.Livros.Include(l => l.Genero).FirstOrDefault(l => l.Id == id.Value);

            if (livro == null)
            {
                return HttpNotFound();
            }

            return PartialView(livro);
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Nome");

            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Create(Livro livro)
        {
            if (ModelState.IsValid)
            {
                db.Livros.Add(livro);
                db.SaveChanges();
                return Json(new { resultado = true, message = "Livro cadastrado com sucesso" });
            }
            else
            {
                IEnumerable<ModelError> erros = ModelState.Values.SelectMany(item => item.Errors);

                return Json(new { resultado = false, message = erros });
            }

        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Livro livro = db.Livros.Find(id);

            if (livro == null)
            {
                return HttpNotFound();
            }

            ViewBag.GeneroId = new SelectList(db.Generos, "Id", "Nome", livro.GeneroId);

            return PartialView(livro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Edit(Livro livro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(livro).State = EntityState.Modified;
                db.SaveChanges();

                return Json(new { resultado = true, message = "Livro editado com sucesso" });
            }
            else
            {
                IEnumerable<ModelError> erros = ModelState.Values.SelectMany(item => item.Errors);

                return Json(new { resultado = false, message = erros });
            }
        }
        
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Livro livro = db.Livros.Include(l => l.Genero).FirstOrDefault(l => l.Id == id);

            if (livro == null)
            {
                return HttpNotFound();
            }

            return PartialView(livro);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public JsonResult DeleteConfirmed(int id)
        {
            try
            {
                Livro livro = db.Livros.Find(id);

                db.Livros.Remove(livro);

                db.SaveChanges();

                return Json(new { resultado = true, message = "Livro excluído com sucesso" });
            }
            catch (Exception e)
            {
                return Json(new { resultado = false, message = e.Message });
            }

            
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
