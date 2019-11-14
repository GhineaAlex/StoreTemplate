using HeadphonesStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeadphonesStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Headphones> PopularHeadphones { get; set; }
    }
}
