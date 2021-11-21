using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ACoder : ICOder
    {
        public string Encoder (string _in)
        {
            return _in;
        }
        public string Decoder (string _in)
        {
            return _in;
        }
    }
}
