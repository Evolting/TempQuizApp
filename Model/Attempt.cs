using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Model
{
    public class Attempt
    {
        public int ID { get; set; }
        public string username { get; set; }
        public double score { get; set; }
        public DateTime takenAt { get; set; }
    }
}
