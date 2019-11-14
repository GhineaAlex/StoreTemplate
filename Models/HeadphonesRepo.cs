using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeadphonesStore.Models
{
    public class HeadphonesRepo : IHeadphonesRepo
    {
        private readonly AppDbContext _appDbContext;
        public HeadphonesRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Audio> AllHeadphones
        {
            get
            {
                return _appDbContext.Headphones.Include(c => c.Category);
            }
        }

        public IEnumerable<Audio> PopularHeadphones
        {
            get
            {
                return _appDbContext.Headphones.Include(c => c.Category).Where(p => p.PopularHeadphones);
            }
        }

        public Audio GetHeadphonesById(int headphonesId)
        {
            return _appDbContext.Headphones.FirstOrDefault(p => p.HeadphonesId == headphonesId);
        }
    }
}
