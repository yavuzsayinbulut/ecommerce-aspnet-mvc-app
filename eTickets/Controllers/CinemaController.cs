using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly dbContextFile _context;

        public CinemaController(dbContextFile context)
        {
            _context = context; 
        }

        public async Task<IActionResult> Index()
        {
           var  allCinemas= await _context.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
