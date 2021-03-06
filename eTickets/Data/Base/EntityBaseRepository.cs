using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        /* Servisleri kaldırıp Base Açtık
         * Interface Entity Base Repostory bölümünde genel fonksiyonlar tanımlandı. Gelen entitye göre T değer alıp fonksiyonları burada döndürecek
         * IentityBase ise hangi attributelerle işlem yapılması gerektiğini belirtiyor
         **/


        private readonly dbContextFile _context;


        public EntityBaseRepository(dbContextFile context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await _context.Set<T>().ToListAsync();
            return result;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }





        public async Task  AddAsync(T entity) //Actor actor etc
        {
           await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

   

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
             entityEntry.State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
