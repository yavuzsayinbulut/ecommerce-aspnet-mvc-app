using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ICinemasService _service;

        public CinemaController(ICinemasService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAllAsync();
            return View(allCinemas);
        }


        //GET Detail

        public async Task<IActionResult> Details(int id)
        {
            var allCinemas = await _service.GetByIdAsync(id);
            if (allCinemas == null) return View("NotFound");
            else
                return View(allCinemas);
        }
  

        // Create Get
        public IActionResult Create()
        {
            return View();
        }
        //Create Post
        [HttpPost]
        public async Task<IActionResult> Create([Bind("cinemaLogo,name,description")] Cinema cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            else
                await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }


        //Delete
        public async Task<IActionResult> Delete(int id)
        {
            var cinemaDetail = await _service.GetByIdAsync(id);
            if (cinemaDetail == null) return View("NotFound");
            return View(cinemaDetail);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfimed(int id)
        {
            var cinemaDetail = await _service.GetByIdAsync(id);
            if (cinemaDetail == null) return View("NotFound");
            await _service.DeleteAsync(cinemaDetail.Id);
            return RedirectToAction(nameof(Index));
        }

        //Update
        public async Task<IActionResult> Edit(int id)
        {
            var cinemaDetail = await _service.GetByIdAsync(id);
            if (cinemaDetail == null) return View("NotFound");
            return View(cinemaDetail);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,cinemaLogo,name,description")] Cinema cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            if (id == cinema.Id)
            {
                await _service.UpdateAsync(id, cinema);
                return RedirectToAction(nameof(Index));
            }
            return View(cinema);
        }



    }
}
