using eTicketing.Data.Base;
using eTicketing.Models;

namespace eTicketing.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context) { }
    }
}
