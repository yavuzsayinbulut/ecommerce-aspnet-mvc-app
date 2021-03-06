using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
       private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetAllAsync();

            return View(allMovies);
        }

        //GET Detail

        public async Task<IActionResult> Detail(int id)
        {
            var allCinemas = await _service.GetByIdAsync(id);
            if (allCinemas == null) return View("NotFound");
            else
                return View(allCinemas);
        }

      
    }
}
