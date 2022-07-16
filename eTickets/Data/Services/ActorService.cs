using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorService :EntityBaseRepository<Actor>, IActorService
    {
      

        public ActorService(dbContextFile context):base(context)
        {
           
        }
    }
}



/*  private readonly dbContextFile _context;

       public ActorService(dbContextFile context)
       {
           _context = context;
       }

       public object Actors => throw new System.NotImplementedException();

       public async Task AddAsync(Actor actor)
       {
           await _context.Actors.AddAsync(actor);
         await  _context.SaveChangesAsync();
       }

       public async Task DeleteAsync(int id)
       {
                                            var result = await _context.Actors.FirstOrDefaultAsync(n => n.actorID == id);
            _context.Actors.Remove(result);
           await _context.SaveChangesAsync();
       }





       public async Task< Actor> UpdateAsync(int id, Actor newActor)
       {
           _context.Update(newActor);
           await _context.SaveChangesAsync();
           return newActor;
       }*/