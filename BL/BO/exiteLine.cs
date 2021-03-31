using System;
using System.Collections.Generic;
using System.Text;

namespace BO
{
    public class exitLine
    {
        public int IDLinebus { get; set; }
        public int ExitLine { get; set; }
        public int finishtime { get; set; }
        public DateTime Time = DateTime.Now;
        public exitLine(int ID, int busnum, int _finishtime)
        {
            IDLinebus = ID;
            ExitLine = busnum;
            finishtime = _finishtime;
            Time = Time.AddMinutes(_finishtime);
        }
    }  //internal int frequency;
}
