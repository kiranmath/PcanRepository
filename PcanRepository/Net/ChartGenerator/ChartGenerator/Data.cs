using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChartGenerator
{
    class Data
    {
        private object[] p;

        public Data(object[] p)
        {
            // TODO: Complete member initialization
            this.Label = Label;
            this.Val = Val;
        }
        public string Label { get; set; }
        public double Val { get; set; }

    }
}
