using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using aprender_cs.Data;
using aprender_cs.Models;

namespace aprender_cs.Controllers
{
    public class TesteController : Controller
    {
        private ApplicationDbContext _context;

        public TesteController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Heroi> Heroi = _context.Heroi
            .Include(cr => cr.ArmaId)
            .ToList();

            return View(Heroi);
        }

        public IActionResult Cad(){
            var listHeroi = _context.Heroi
            .OrderByDescending(mc=> mc.Nome)
            .ToList();

             ViewBag.ListaHeroi = listHeroi.Select(mc => new SelectListItem(mc.Nome, mc.Id.ToString()));

            return View();
        }

        [HttpPost]
        public IActionResult Cad(Heroi Heroi){
            if(ModelState.IsValid){
                _context.Heroi.Add(Heroi);
                _context.SaveChanges();
                TempData["CadSucess"] = true;
                return RedirectToAction(nameof(Index));
            }
            return View(Heroi);
          
        }

        public IActionResult IndexArma()
        {
            List<Arma> Arma = _context.Arma
            .ToList();

            return View(Arma);
        }

        public IActionResult CadArma(){
            var listArma = _context.Arma
            .OrderByDescending(mc=> mc.Nome)
            .ToList();

             ViewBag.ListaArma = listArma.Select(mc => new SelectListItem(mc.Nome, mc.Id.ToString()));

            return View();
        }

        [HttpPost]
        public IActionResult CadArma(Arma Arma){
            if(ModelState.IsValid){
                _context.Arma.Add(Arma);
                _context.SaveChanges();
                TempData["CadSucess"] = true;
                return RedirectToAction(nameof(IndexArma));
            }
            return View(Arma);
          
        }

        public IActionResult ListArma(){
            var list = _context.Arma
            .Include(mc => mc.Heroi)
            .ToList();
            return View(list);
        }

        public IActionResult Update(){
            return View();
        }

        /*public IActionResult ListMarca(){
            var list = _context.HeroiBatalhass
            .Include(mc => mc.Herois)
            .ToList();
            return View(list);
        }*/

        /*public IActionResult CadHeroiBatalhas(){
            return View();
        }*/

        //[HttpPost]
        /*public IActionResult CadHeroiBatalhas(HeroiBatalhas Heroi){
            if(ModelState.IsValid){
                _context.Heroi.Add(Heroi);
                _context.SaveChanges();
                 TempData["CadSucess"] = true;
                 return RedirectToAction(nameof(ListHeroi));
            }

            return View(Heroi);
        }*/
    }
}