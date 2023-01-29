using Microsoft.AspNetCore.Mvc;
using MVCClininca.Data;
using System.Linq;
using MVCClininca.Models;
using Microsoft.EntityFrameworkCore;

namespace MVCClininca.Controllers
{
    public class MedicoController : Controller
    {
        private readonly DBClinicaContext context;
        public MedicoController(DBClinicaContext context)
        {
            this.context = context;
        }

        //Index
        [HttpGet]
        public IActionResult Index()
        {
            var medicos = context.Medicos.ToList();
            return View(medicos);
        } 

        //Create
        [HttpGet]
        public ActionResult Create() 
        {
            Medico medico = new Medico();
            return View(medico);

        }
        [HttpPost]
        public ActionResult Create(Medico medico) 
        {
            if (ModelState.IsValid) 
            {
                context.Medicos.Add(medico);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medico);
        }

        //Delete
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var medico = context.Medicos.Find(id);

            if (medico == null) { return NotFound(); }
            else { return View(medico); }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id) 
        {
            var medico = context.Medicos.Find(id);
            if (medico == null) return NotFound();
            else 
            {
                context.Medicos.Remove(medico);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        //Detail
        [HttpGet]
        public ActionResult Detail(int id) 
        {
            var medico = context.Medicos.Find(id);
            if (medico == null) return NotFound();
            else return View(medico);
        }

        //Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var medico = context.Medicos.Find(id);

            if (medico == null) { return NotFound(); }
            else { return View(medico); }
        }

        [HttpPost]
        public ActionResult Edit(int id, Medico medico) 
        {
            if (id != medico.Id) return BadRequest();
            if (ModelState.IsValid)
            {
                context.Entry(medico).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Detail", medico);

            }
            else return View(medico);
        }



    }
}
