﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class Ext_String
    {
        public static System.String GetStringtAs(this System.String _Str, uint i = 3)
        {
            while (_Str.Length != i)
            {
                ;
                if (_Str.Length < i) _Str = _Str.Add(" ");
                if (_Str.Length > i) { _Str = _Str.Remove(_Str.Length - 2).Add("_"); }
            }
            return _Str;
        }
    }
}