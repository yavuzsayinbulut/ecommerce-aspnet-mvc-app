using eTickets.Data.Base;
using eTickets.Models;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ProducerService:EntityBaseRepository<Producer>,IProducerService
    {
        public ProducerService(dbContextFile contex):base(contex)
        {

        }

        public Task ToListAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}


//cTOR AÇILDI
//STARTUP A GİDİLDİ
