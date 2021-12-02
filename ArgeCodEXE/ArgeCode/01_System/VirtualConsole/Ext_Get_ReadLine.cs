using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.VConsole
{
    /// <summary>Контекстно ориентированное расширение читателей с консоли базовых типов </summary>
    public static class Ext_Get_ReadLine
    {
        #region System.Boolean
        public static System.Boolean Get_ReadLine(this System.Boolean _this)
        {
            switch (System.VConsole.Config.p_VirtualConsole.ReadLine())
            {
                case "0": return false; break;
                case "False": return false; break;
                case "false": return false; break;
                case "1": return true; break;
                case "True": return true; break;
                case "true": return true; break;
                default: return false; break;
            }
            return _this;
        }
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 23, _hour: 8, _minute: 05, _second: 0, _millisecond: 0)]
        public static void Test_Get_ReadLine_System_Boolean() { System.Diagnostics.StackTracer.Get_STS().WriteLine(); (new System.Boolean()).Get_ReadLine().ToString().WriteLine(); }
        #endregion
        #region System.Byte
        public static System.Byte Get_ReadLine(this System.Byte _this)
        {
            System.Byte rez = 0;
            while (System.Byte.TryParse(System.VConsole.Config.p_VirtualConsole.ReadLine(), out rez)
                .SetIf(_fBool: a => a = true, _f0: a => ("Сan't convert to " + _this.GetType().ToString() + "; Try again !!").WriteLine()).Get(a => !a)
            ) ;
            return rez;
        }
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 23, _hour: 8, _minute: 07, _second: 0, _millisecond: 0)]
        public static void Test_Get_ReadLine_System_Byte() { System.Diagnostics.StackTracer.Get_STS().WriteLine(); (new System.Byte()).Get_ReadLine().ToString().WriteLine(); }
        #endregion
        #region System.Char
        public static System.Char Get_ReadLine(this System.Char _this)
        {
            System.Char rez = ' ';
            while (System.Char.TryParse(System.VConsole.Config.p_VirtualConsole.ReadLine(), out rez)
                .SetIf(_fBool: a => a = true, _f0: a => ("Сan't convert to " + _this.GetType().ToString() + "; Try again !!").WriteLine()).Get(a => !a)
            ) ;
            return rez;
        }
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 23, _hour: 8, _minute: 08, _second: 0, _millisecond: 0)]
        public static void Test_Get_ReadLine_System_Char() { System.Diagnostics.StackTracer.Get_STS().WriteLine(); (new System.Char()).Get_ReadLine().ToString().WriteLine(); }
        #endregion
        #region System.Decimal
        public static System.Decimal Get_ReadLine(this System.Decimal _this)
        {
            System.Decimal rez = 0;
            while (System.Decimal.TryParse(System.VConsole.Config.p_VirtualConsole.ReadLine(), out rez)
                .SetIf(_fBool: a => a = true, _f0: a => ("Сan't convert to " + _this.GetType().ToString() + "; Try again !!").WriteLine()).Get(a => !a)
            ) ;
            return rez;
        }
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 23, _hour: 8, _minute: 09, _second: 0, _millisecond: 0)]
        public static void Test_Get_ReadLine_System_Decimal() { System.Diagnostics.StackTracer.Get_STS().WriteLine(); (new System.Decimal()).Get_ReadLine().ToString().WriteLine(); }
        #endregion
        #region System.Double
        public static System.Double Get_ReadLine(this System.Double _this)
        {
            System.Double rez = 0;
            while (System.Double.TryParse(System.VConsole.Config.p_VirtualConsole.ReadLine(), out rez)
                .SetIf(_fBool: a => a = true, _f0: a => ("Сan't convert to " + _this.GetType().ToString() + "; Try again !!").WriteLine()).Get(a => !a)
            ) ;
            return rez;
        }
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 23, _hour: 8, _minute: 10, _second: 0, _millisecond: 0)]
        public static void Test_Get_ReadLine_System_Double() { System.Diagnostics.StackTracer.Get_STS().WriteLine(); (new System.Double()).Get_ReadLine().ToString().WriteLine(); }
        #endregion
        #region System.Int16
        public static System.Int16 Get_ReadLine(this System.Int16 _this)
        {
            System.Int16 rez = 0;
            while (System.Int16.TryParse(System.VConsole.Config.p_VirtualConsole.ReadLine(), out rez)
                .SetIf(_fBool: a => a = true, _f0: a => ("Сan't convert to " + _this.GetType().ToString() + "; Try again !!").WriteLine()).Get(a => !a)
            ) ;
            return rez;
        }

        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 23, _hour: 8, _minute: 11, _second: 0, _millisecond: 0)]
        public static void Test_Get_ReadLine_System_Int16() { System.Diagnostics.StackTracer.Get_STS().WriteLine(); (new System.Int16()).Get_ReadLine().ToString().WriteLine(); }
        #endregion
        #region System.Int32
        public static System.Int32 Get_ReadLine(this System.Int32 _this)
        {
            System.Int32 rez = 0;
            while (System.Int32.TryParse(System.VConsole.Config.p_VirtualConsole.ReadLine(), out rez)
                .SetIf(_fBool: a => a = true, _f0: a => ("Сan't convert to " + _this.GetType().ToString() + "; Try again !!").WriteLine()).Get(a => !a)
            ) ;
            return rez;
        }
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 23, _hour: 8, _minute: 12, _second: 0, _millisecond: 0)]
        public static void Test_Get_ReadLine_System_Int32() { System.Diagnostics.StackTracer.Get_STS().WriteLine(); (new System.Int32()).Get_ReadLine().ToString().WriteLine(); }
        #endregion
        #region System.Int64
        public static System.Int64 Get_ReadLine(this System.Int64 _this)
        {
            System.Int64 rez = 0;
            while (System.Int64.TryParse(System.VConsole.Config.p_VirtualConsole.ReadLine(), out rez)
                .SetIf(_fBool: a => a = true, _f0: a => ("Сan't convert to " + _this.GetType().ToString() + "; Try again !!").WriteLine()).Get(a => !a)
            ) ;
            return rez;
        }
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 23, _hour: 8, _minute: 13, _second: 0, _millisecond: 0)]
        public static void Test_Get_ReadLine_System_Int64() { System.Diagnostics.StackTracer.Get_STS().WriteLine(); (new System.Int64()).Get_ReadLine().ToString().WriteLine(); }
        #endregion
        #region System.SByte
        public static System.SByte Get_ReadLine(this System.SByte _this)
        {
            System.SByte rez = 0;
            while (System.SByte.TryParse(System.VConsole.Config.p_VirtualConsole.ReadLine(), out rez)
                .SetIf(_fBool: a => a = true, _f0: a => ("Сan't convert to " + _this.GetType().ToString() + "; Try again !!").WriteLine()).Get(a => !a)
            ) ;
            return rez;
        }
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 23, _hour: 8, _minute: 14, _second: 0, _millisecond: 0)]
        public static void Test_Get_ReadLine_System_SByte() { System.Diagnostics.StackTracer.Get_STS().WriteLine(); (new System.SByte()).Get_ReadLine().ToString().WriteLine(); }
        #endregion
        #region System.Single
        public static System.Single Get_ReadLine(this System.Single _this)
        {
            System.Single rez = 0;
            while (System.Single.TryParse(System.VConsole.Config.p_VirtualConsole.ReadLine(), out rez)
                .SetIf(_fBool: a => a = true, _f0: a => ("Сan't convert to " + _this.GetType().ToString() + "; Try again !!").WriteLine()).Get(a => !a)
            ) ;
            return rez;
        }
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 23, _hour: 8, _minute: 15, _second: 0, _millisecond: 0)]
        public static void Test_Get_ReadLine_System_Single() { System.Diagnostics.StackTracer.Get_STS().WriteLine(); (new System.Single()).Get_ReadLine().ToString().WriteLine(); }
        #endregion
        #region System.String
        public static System.String Get_ReadLine(this System.String _this) { return System.VConsole.Config.p_VirtualConsole.ReadLine(); }
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 23, _hour: 8, _minute: 16, _second: 0, _millisecond: 0)]
        public static void Test_Get_ReadLine_System_String() { System.Diagnostics.StackTracer.Get_STS().WriteLine(); "".Get_ReadLine().ToString().WriteLine(); }
        #endregion
        #region System.UInt16
        public static System.UInt16 Get_ReadLine(this System.UInt16 _this)
        {
            System.UInt16 rez = 0;
            while (System.UInt16.TryParse(System.VConsole.Config.p_VirtualConsole.ReadLine(), out rez)
                .SetIf(_fBool: a => a = true, _f0: a => ("Сan't convert to " + _this.GetType().ToString() + "; Try again !!").WriteLine()).Get(a => !a)
            ) ;
            return rez;
        }
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 23, _hour: 8, _minute: 16, _second: 0, _millisecond: 0)]
        public static void Test_Get_ReadLine_System_UInt16() { System.Diagnostics.StackTracer.Get_STS().WriteLine(); (new System.UInt16()).Get_ReadLine().ToString().WriteLine(); }
        #endregion
        #region System.UInt32 
        public static System.UInt32 Get_ReadLine(this System.UInt32 _this)
        {
            System.UInt32 rez = 0;
            while (System.UInt32.TryParse(System.VConsole.Config.p_VirtualConsole.ReadLine(), out rez)
                .SetIf(_fBool: a => a = true, _f0: a => ("Сan't convert to " + _this.GetType().ToString() + "; Try again !!").WriteLine()).Get(a => !a)
            ) ;
            return rez;
        }
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 23, _hour: 8, _minute: 17, _second: 0, _millisecond: 0)]
        public static void Test_Get_ReadLine_System_UInt32() { System.Diagnostics.StackTracer.Get_STS().WriteLine(); (new System.UInt32()).Get_ReadLine().ToString().WriteLine(); }
        #endregion
        #region System.UInt64
        public static System.UInt64 Get_ReadLine(this System.UInt64 _this)
        {
            System.UInt64 rez = 0;
            while (System.UInt64.TryParse(System.VConsole.Config.p_VirtualConsole.ReadLine(), out rez)
                .SetIf(_fBool: a => a = true, _f0: a => ("Сan't convert to " + _this.GetType().ToString() + "; Try again !!").WriteLine()).Get(a => !a)
            ) ;
            return rez;
        }
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 23, _hour: 8, _minute: 18, _second: 0, _millisecond: 0)]
        public static void Test_Get_ReadLine_System_UInt64() { System.Diagnostics.StackTracer.Get_STS().WriteLine(); (new System.UInt64()).Get_ReadLine().ToString().WriteLine(); }
        #endregion
    }




}
