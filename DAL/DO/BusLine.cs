using System;
using System.Collections.Generic;
using System.Text;

namespace DO
{
    public class BusLine
    {
        public List<Station> Stations = new List<Station>();
        public int Id { get; set; }
        public int busnumber { get; set; }
        public int Idfirststation { get; set; }
        public int Idlaststation { get; set; }
        public BusLine(int _Id,int _busnumber,int _Idfirststation = 0, int _Idlaststation = 0)
        {
            this.busnumber = _busnumber;
            this.Id = _Id;
            this.Idfirststation = _Idfirststation;
            this.Idlaststation = _Idlaststation;
        }
        public BusLine()
        {

        }
    }
}
