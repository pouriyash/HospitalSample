using CsvHelper.Configuration.Attributes;
using System;

namespace BlazoriseDemo.API.Models
{
    public class ConvertModel
    {
        public double MHR { get; set; }
        public double FHR1 { get; set; }
        public double FHR2 { get; set; }
        public string RR { get; set; }
        public string SPO2 { get; set; }
        public string TEMP { get; set; }
        public DateTime timestamp { get; set; }
    }
    public class CSVModel
    {
        //[Index(0)]
        //public string id { get; set; }
        //[Index(1)]
        //public string time_offset { get; set; }
        [Index(2)]
        public double MHR { get; set; }
        [Index(3)]
        public double FHR1 { get; set; }
        [Index(4)]
        public double FHR2 { get; set; }
        //[Index(5)]
        //public string FHR3 { get; set; }
        //[Index(5)]
        //public string modes { get; set; }
        //[Index(6)]
        //public string TOCO { get; set; }
        //[Index(7)]
        //public string QUALITY1 { get; set; }
        //[Index(8)]
        //public string QUALITY2 { get; set; }
        //[Index(9)]
        //public string QUALITY3 { get; set; }
        //[Index(10)]
        //public string MQUALITY { get; set; }
        [Index(12)]
        public double timestamp { get; set; }
        //[Index(12)]
        //public string MOVEMENT { get; set; }
        //[Index(13)]
        //public string NOTE { get; set; }
        //[Index(14)]
        //public string MARKER { get; set; }
        //[Index(15)]
        //public string ALARMACK { get; set; }
        //[Index(16)]
        //public string SPEED { get; set; }

    }
}
