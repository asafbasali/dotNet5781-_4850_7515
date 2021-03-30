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
        public exitLine(int ID, int busnum, int _finishtime)
        {
            IDLinebus = ID;
            ExitLine = busnum;
            finishtime = _finishtime;
        }
    }  //internal int frequency;
}
