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
        public IEnumerable<Headphones> AllHeadphones
        {
            get
            {
                return _appDbContext.headphones.Include(c => c.Category);
            }
        }

        public IEnumerable<Headphones> PopularHeadphones
        {
            get
            {
                return _appDbContext.headphones.Include(c => c.Category).Where(prop => prop.PopularHeadphones);
            }
        }

        public Headphones GetHeadphonesById(int headphonesId)
        {
            return _appDbContext.headphones.FirstOrDefault(p => p.HeadphonesId == headphonesId);
        }
    }
}
