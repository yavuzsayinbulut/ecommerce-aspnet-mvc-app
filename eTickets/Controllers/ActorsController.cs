using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorService _service; // ilk olarak db contexti import ediyoruz


        public ActorsController(IActorService service) //ctor yazarak constructor oluşturuyoruz
        {
           _service = service;
        }
    
        public async Task<IActionResult>  Index()
        {

            var data = await _service.GetAll();



            return View(data);
        }

        //get: actors/create
        public async Task<IActionResult> Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("fullName,profilePictureURL,biography")]Actor actor)
        {

            if(!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.Add(actor);
            return RedirectToAction(nameof(Index));
        }

        // get actors/details/1

        public async Task <IActionResult> Details(int id)
        {
            var actorDetails = _service.Get(id);
            if (actorDetails == null) return View("Empty");
            
            else return View(actorDetails);
        }

    }
}
