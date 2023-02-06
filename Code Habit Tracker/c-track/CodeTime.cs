using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace code_tracker
{
    public class CodeTime
            {
                public int Id {get; set;}
                public DateTime Date {get; set;}
                public DateTime StartTime {get; set;}
                public DateTime EndTime {get; set;}
                public TimeSpan Duration {get; set;}
            }
}