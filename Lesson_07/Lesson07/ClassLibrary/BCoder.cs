﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BCoder : ICOder
    {
        static Dictionary<char,char> dictChar = new Dictionary<char, char> //словарь для шифровки дешифровки.
                                                                           //Более элегантного способа реализации не придумал.
                                                                           //Но зато можно оперативно менять словари)))
        {
            {'А','Я'},{'Б','Ю'},{'В','Э'},{'Г','Ь'},{'Д','Ы'},{'Е','Ъ'},{'Ё','Щ'},
            {'Ж','Ш'},{'З','Ч'},{'И','Ц'},{'Й','Х'},{'К','Ф'},{'Л','У'},{'М','Т'},
            {'Н','С'},{'О','Р'},{'П','П'},{'Р','О'},{'С','Н'},{'Т','М'},{'У','Л'},
            {'Ф','К'},{'Х','Й'},{'Ц','И'},{'Ч','З'},{'Ш','Ж'},{'Щ','Ё'},{'Ъ','Е'},
            {'Ы','Д'},{'Ь','Г'},{'Э','В'},{'Ю','Б'},{'Я','А'},{' ',' '},{'а','я'},
            {'б','ю'},{'в','э'},{'г','ь'},{'д','ы'},{'е','ъ'},{'ё','щ'},{'ж','ш'},
            {'з','ч'},{'и','ц'},{'й','х'},{'к','ф'},{'л','у'},{'м','т'},{'н','с'},
            {'о','р'},{'п','п'},{'р','о'},{'с','н'},{'т','м'},{'у','л'},{'ф','к'},
            {'х','й'},{'ц','и'},{'ч','з'},{'ш','ж'},{'щ','ё'},{'ъ','е'},{'ы','д'},
            {'ь','г'},{'э','в'},{'ю','б'},{'я','а'}
        };
        public static string Encoder(string _in)   //Метод шифрования строки - сдвиг на один символ
        {
            string _out = "";

            for (int i = 0; i < _in.Length; i++)
            {
                _out = _out + dictChar[_in[i]];
            }

            return _out;
        }
        public static string Decoder(string _in)   //Метод дешифрования строки
        {
            string _out = "";


            for (int i = 0; i < _in.Length; i++)
            {
                _out = _out + dictChar[_in[i]];
            }

            return _out;
        }
    }
}
