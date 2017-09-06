using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Notebook.Model;

namespace NoteWeb.Controllers
{
    public class HomeController : Controller
    {
        private INoteRepository _noteRepository;

        public HomeController(INoteRepository repository, IConfiguration config)
        {
            _noteRepository = repository;
        }
        public IActionResult Index()
        {
            IEnumerable<Note> notes = (from n in _noteRepository.Notes
                select n).AsEnumerable();

            return View(notes);
        
        }

        [HttpPost]
        public IActionResult CreateNewNote(Note note)
        {
            note.Created = DateTime.Now;
            _noteRepository.SaveNote(note);
            return RedirectToAction("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
