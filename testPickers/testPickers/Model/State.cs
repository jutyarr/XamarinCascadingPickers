using System;
using System.Collections.Generic;
using System.Text;
using MvvmHelpers;

namespace testPickers.Model
{
    public class State : ObservableObject
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
}
