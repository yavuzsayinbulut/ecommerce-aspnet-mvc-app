using eTickets.Data.Base;
using eTickets.Models;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IProducerService : IEntityBaseRepository<Producer>

    {
        Task ToListAsync();
    }
}


// İlk Servis Interafacei açtık
// Daha sonra EntityBaseRepository Interface import Ettik
//producer definion a gitti import sağlandı
//producers servis isimli class açıldı
//PRODUCERESERVİS GEÇ