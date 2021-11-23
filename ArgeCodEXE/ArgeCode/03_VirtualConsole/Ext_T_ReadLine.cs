using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.VConsole
{
    /// <summary>Класс контекстного расширения всея объектов функцией чтения их из консоли. </summary>
    public static class Ext_T_ReadLine
    {
        /// <summary>
        /// Расширение, позволяет считать с консоли объект рефлексивно.
        /// Требование. У объекта должен буть беспараметрический конструктор или интерфейс чтения с консоли IReadLineEable.
        /// </summary>
        public static T Get__ReadLine<T>(this T _this)
        {
            if (_this == null) { throw new System.Exception("Eror:№14.11.2021.12.19:T.ReadLine<T>(this T _this);  _this == null   !!!"); return _this; }
            if (_this is IReadLineEable _IReadLineEable) return (T)_IReadLineEable.Get_ReadLine();
            System.Type _Type = _this.GetType();
            {
                if (_this is System.Boolean _Boolean) return _Boolean.Get_ReadLine().Cast_AsObj().Cast_As<T>();
                if (_this is System.Byte _Byte) return _Byte.Get_ReadLine().Cast_AsObj().Cast_As<T>();
                if (_this is System.Char _Char) return _Char.Get_ReadLine().Cast_AsObj().Cast_As<T>();
                if (_this is System.Decimal _Decimal) return _Decimal.Get_ReadLine().Cast_AsObj().Cast_As<T>();
                if (_this is System.Double _Double) return _Double.Get_ReadLine().Cast_AsObj().Cast_As<T>();
                if (_this is System.Int16 _Int16) return _Int16.Get_ReadLine().Cast_AsObj().Cast_As<T>();
                if (_this is System.Int32 _Int32) return _Int32.Get_ReadLine().Cast_AsObj().Cast_As<T>();
                if (_this is System.Int64 _Int64) return _Int64.Get_ReadLine().Cast_AsObj().Cast_As<T>();
                if (_this is System.SByte _SByte) return _SByte.Get_ReadLine().Cast_AsObj().Cast_As<T>();
                if (_this is System.Single _Single) return _Single.Get_ReadLine().Cast_AsObj().Cast_As<T>();
                if (_this is System.String _String) return _String.Get_ReadLine().Cast_AsObj().Cast_As<T>();
                if (_this is System.UInt16 _UInt16) return _UInt16.Get_ReadLine().Cast_AsObj().Cast_As<T>();
                if (_this is System.UInt32 _UInt32) return _UInt32.Get_ReadLine().Cast_AsObj().Cast_As<T>();
                if (_this is System.UInt64 _UInt64) return _UInt64.Get_ReadLine().Cast_AsObj().Cast_As<T>();
                ///////////////////////////////////////////////////////////////////////////////////////////////////
            }
            throw new System.Exception("Eror:№14.11.2021.12.31: not provided case; update the library later; !!!");
            return _this;
        }
        /// <summary>System.VConsole.Ext_T_ReadLine.Test_ReadLine();</summary>
        public static void Test_ReadLine()
        {
            
            false.ToString().WriteLine();
            //false.ReadLine().ToString().WriteLine();
        }
    }
}
