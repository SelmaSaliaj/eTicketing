using eTicketing.Data.Base;
using eTicketing.Models;

namespace eTicketing.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
