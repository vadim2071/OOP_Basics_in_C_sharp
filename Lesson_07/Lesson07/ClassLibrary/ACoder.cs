using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ACoder : ICOder
    {
        public static string Encoder (string _in)   //Метод шифрования строки - сдвиг на один символ
        {
            string _out = "";
            for (int i = 0; i < _in.Length; i++)
            {
                _out = _out + (char)((int)_in[i] + 1);
            } 

            return _out;
        }
        public static string Decoder (string _in)   //Метод дешифрования строки
        {
            string _out = "";
            for (int i = 0; i < _in.Length; i++)
            {
                _out = _out + (char)((int)_in[i] - 1);
            }

            return _out;
        }
    }
}
