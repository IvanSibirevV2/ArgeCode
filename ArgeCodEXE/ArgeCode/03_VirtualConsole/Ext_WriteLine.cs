namespace System.VConsole
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    /////////////////////////////////////////////////////////
    public static class Ext_WriteLine
    {
        public static System.String Write(this System.String _String)
        {System.VConsole.Config.p_VirtualConsole.Write(_String);return _String;}
        public static System.String WriteLine(this System.String _String)
        {System.VConsole.Config.p_VirtualConsole.WriteLine(_String);return _String;}

    }
}