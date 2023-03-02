using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class Ext_StrWriteLine
    {
        public static System.String Write(this System.String _String)
        { System.VConsole.Config.p_VirtualConsole.Write(_String); return _String; }
        public static System.String WriteLine(this System.String _String)
        { System.VConsole.Config.p_VirtualConsole.WriteLine(_String); return _String; }
        public static List<System.String> WriteLine(this List<System.String> _StringS)
        { _StringS.ForEach(a => a.WriteLine()); return _StringS; }
        public static System.String ReadLine(this System.String _String)
        { return System.VConsole.Config.p_VirtualConsole.ReadLine(); }
        public static System.String Add(this System.String _String, System.String _Str)
        { return _String+_Str; }

    }
}