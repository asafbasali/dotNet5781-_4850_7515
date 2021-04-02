using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DalApi
{
    public enum Options { Object, Xml }
    public static class DALFactory
    {
        public static IDAL GetDal(Options type)
        {
            switch (type)
            {
                case Options.Object:
                    return DALObject.Instance;
                case Options.Xml:
                    return DALXml.Instance;
                default:
                    return null;
            }
        }
    }
}
