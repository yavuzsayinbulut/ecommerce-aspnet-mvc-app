using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly dbContextFile _context;

        public ProducerController(dbContextFile context)
        {
            _context = context;
        }
    
        public IActionResult Index()
        {
            var allProducers = _context.Producers.ToList();
            return View(allProducers);
        }
    }
}
