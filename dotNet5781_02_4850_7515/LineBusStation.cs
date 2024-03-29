﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace dotNet5781_02_4850_7515
{
    class LineBusStation : IEnumerable
    {
        internal List<BusLine> lines = new List<BusLine>(); 
        internal int disfromprestation;//מרחק מתחנה קודמת 
        internal int timefromprestation;//זמן מתחנה קודמת

        internal LineBusStation(int _disfromprestation = 0, int _timefromprestation = 0) 
        {
            if (_disfromprestation>0){ disfromprestation = _disfromprestation;}
            if (_timefromprestation > 0) {  timefromprestation = _disfromprestation;}
        }
        int time_between_stations(LineBusStation newstation)
        {
            return Math.Abs(this.timefromprestation - newstation.timefromprestation);
        }
        int dis_between_stations(LineBusStation newstation)
        {
            return Math.Abs(this.disfromprestation - newstation.disfromprestation);
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)lines).GetEnumerator();
        }

        public BusLine this[int i]
        {
            get { return lines[i]; }
            set { lines[i] = value; }
        }
    }
}
