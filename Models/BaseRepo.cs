using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeadphonesStore.Models
{
    public abstract class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        protected AppDbContext ContextRepo { get; set; }

        public BaseRepo(AppDbContext contextRepo)
        {
            this.ContextRepo = contextRepo;
        }
        public IEnumerable<T> GetAll()
        {
            return this.ContextRepo.Set<T>();
        }
    }
}
