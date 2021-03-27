using System;
using System.Collections.Generic;
using System.Text;

namespace Outline.Models
{
    public class PointOfInterest
    {
        public string uniqueId { get; set; }
        public double Latitude{get; set;}
        public double Longitude { get; set; }
        public int Score { get; set; }
        public bool Disponibility { get; set; }

    }
}
