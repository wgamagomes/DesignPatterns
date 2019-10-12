using System;
using System.Collections.Generic;
using System.Text;

namespace SustainableFleet.Data
{
    public class AlertHistory
    {
        public string Plate { get; set; }
        public string Prefix { get; set; }
        public string DriverName { get; set; }
        public string CPF { get; set; }
        public string BusinessUnit { get; set; }
        public string Event { get; set; }
        public string Level { get; set; }
        public string Threshold { get; set; }
        public string Overspeed { get; set; }
        public string Duration { get; set; }
        public string ReferencePoint { get; set; }
        public string Category { get; set; }
        public string Highway { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public DateTime? DateTime { get; set; }
        public string Status { get; set; }
        public string Assigned { get; set; }
    }
}
