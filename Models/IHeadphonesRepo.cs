using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeadphonesStore.Models
{
    public interface IHeadphonesRepo
    {
        IEnumerable<Headphones> AllHeadphones { get; }
        IEnumerable<Headphones> PopularHeadphones { get; }
        Headphones GetHeadphonesById(int headphonesId);
    }
}
