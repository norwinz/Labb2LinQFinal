using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2LinQFinal
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentNamn { get; set; }        
        public virtual Kurs Kurs { get; set; }
        public int KursId { get; set; }
        
        public virtual Lärare Lärare { get; set; }
        public int  LärareId { get; set; }
    }
}
