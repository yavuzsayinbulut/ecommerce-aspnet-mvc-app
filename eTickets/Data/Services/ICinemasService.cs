using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface ICinemasService:IEntityBaseRepository<Cinema>
    {
    }
}



/*
 * 1-> InterfaceEntityBaseRep  import edildi 
 * 2-> Model import edildi
 * 3-> Cinema Definition
 * 4-> Cinema EntityBase import edildi (error giidiyor)
 * 5-> CinemaService classında  EntityBaseRepository import edilip model dahil edildi ve Icinemaservice ile bağlantı kuruldu
 * 6-> CTOR açıldı dcContext tanımlandı ve base açıldı
 * 7-> Startup scoped eklendi
 * 8-> Controllera gidilip dbcontext silindi servis eklendi 
 * 9-> GetAllAsync kullanıldı
 */