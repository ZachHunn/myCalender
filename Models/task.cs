using System;


namespace myCalender.Models
{
    public class Task
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public string Notes {get; set;}
        public bool Important { get; set; }
        public DateTime? Date { get; set; }
        public string User { get; set; }
    }
}