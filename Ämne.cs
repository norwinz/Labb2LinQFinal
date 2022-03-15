using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2LinQFinal
{
    public class Ämne
    {
        public int ÄmneId { get; set; }
        public string ÄmneNamn { get; set; }
        public virtual Lärare Lärare { get; set; }
        public int LärareId { get; set; }
        
    }
}
