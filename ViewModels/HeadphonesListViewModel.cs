using HeadphonesStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeadphonesStore.ViewModels
{
    public class HeadphonesListViewModel
    {
        public IEnumerable<Headphones> headphones { get; set; }
        public string CurrentCategory { get; set; }
    }
}
