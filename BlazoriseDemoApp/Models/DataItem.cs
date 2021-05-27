using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoriseDemoApp.Models
{
    public class DataItem
    {
        public string Lable { get; set; }
        public double Value { get; set; }
    }

    public class ConvertModel
    {
        public double MHR { get; set; }
        public double FHR1 { get; set; }
        public double FHR2 { get; set; }

        public DateTime timestamp { get; set; }
    }
}
