using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeadphonesStore.Models
{
    public class HeadphonesRepo : BaseRepo<Audio>, IHeadphonesRepo
    {
        public HeadphonesRepo(AppDbContext contextRepo) : base(contextRepo)
        {
        }
        public IEnumerable<Audio> AllHeadphones
        {
            get
            {
                return ContextRepo.Headphones.Include(c => c.Category);
            }
        }

        public IEnumerable<Audio> PopularHeadphones
        {
            get
            {
                return ContextRepo.Headphones.Include(c => c.Category).Where(p => p.PopularHeadphones);
            }
        }

        public Audio GetHeadphonesById(int headphonesId)
        {
            return ContextRepo.Headphones.FirstOrDefault(p => p.HeadphonesId == headphonesId);
        }
    }
}
