using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorService : IActorService
    {
        private readonly dbContextFile _context;

        public ActorService(dbContextFile context)
        {
            _context = context;
        }

        public object Actors => throw new System.NotImplementedException();

        public void Add(Actor actor)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Actor Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public  async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await  _context.Actors.ToListAsync();
            return result;
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new System.NotImplementedException();
        }
    }
}
