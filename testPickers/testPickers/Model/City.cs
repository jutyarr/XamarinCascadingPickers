using System;
using System.Collections.Generic;
using System.Text;
using MvvmHelpers;

namespace testPickers.Model
{
    public class City : ObservableObject
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }
    }
}
