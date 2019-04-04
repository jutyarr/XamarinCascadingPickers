using System;
using System.Collections.Generic;
using System.Text;
using MvvmHelpers;

namespace testPickers.Model
{
    public class Town : ObservableObject
    {
        public int TownId { get; set; }
        public string TownName { get; set; }
        public int CityId { get; set; }
    }
}
