using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeadphonesStore.Models
{
    public interface IHeadphonesRepo : IBaseRepo<Audio>
    {
        IEnumerable<Audio> PopularHeadphones { get; }
        Audio GetHeadphonesById(int headphonesId);
    }
}
