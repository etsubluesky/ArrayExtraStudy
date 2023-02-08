using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtraStudy
{
    public class ParkRules
    {
        public string NameOfRide { get; set; }
        public int Feet { get; set; }
        public int Inches { get; set; }
        public bool ChildrenUnder10CanRide { get; set; }


        public override string ToString()
        {
            return $"The ride is {NameOfRide} and the minimum height is {Feet}' {Inches}\"";

        }


    }
}
