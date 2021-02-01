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
    }
}
