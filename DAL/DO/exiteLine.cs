﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DO
{
    public class exiteLine
    {
        public int IDLinebus { get; set; }
        public int exitLine { get; set; }
        public int finishtime { get; set; }
        public exiteLine() { }
        public exiteLine(int _finishtime, int ID,int busnum)
        {
            IDLinebus = ID;
            exitLine = busnum;
            finishtime = _finishtime;
        }
    }  //internal int frequency;
}
