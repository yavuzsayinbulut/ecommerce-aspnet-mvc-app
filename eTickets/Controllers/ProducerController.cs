using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly IProducerService _service;

        public ProducerController(IProducerService service)
        {
            _service  =service;
        }
    
        public async Task<IActionResult> Index()
        {
            var allProducers =await _service.GetAllAsync();
            return View(allProducers);
        }


        //Get Request
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails==null) return View("NotFound");
            else
                return View(producerDetails);
        }

        // Create Get
        public IActionResult Create()
        {
            return View();
        }
        //Create Post
        [HttpPost]
        public async Task<IActionResult> Create([Bind("profilePictureURL,fullName,biography")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);
            else
                await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        //Update get
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,profilePictureURL,fullName,biography")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);
            if (id==producer.Id)
            {
                await _service.UpdateAsync(id,producer);
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
        }


        //Delete Get
        

        public async Task<IActionResult> Delete(int id)
        {
            var consumerDetails = await _service.GetByIdAsync(id);
            if (consumerDetails == null) return View("NotFound");
            return View(consumerDetails);


        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            await  _service.DeleteAsync(producerDetails.Id);
            return RedirectToAction(nameof(Index));
        }

    }
}
