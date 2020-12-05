using System;
using System.Collections.Generic;
using System.Text;

namespace dotNet5781_02_4850_7515
{
    class LineBusStation
    {
        int disfromprestation;//מרחק מתחנה קודמת 
        int timefromprestation;//זמן מתחנה קודמת

        LineBusStation(int _disfromprestation = 0, int _timefromprestation = 0) 
        {
            if (_disfromprestation>0){ disfromprestation = _disfromprestation;}
            else{   }
            if (_timefromprestation > 0) {  timefromprestation = _disfromprestation;}
            else{   }
        }
    }
}
