using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace System.VConsole
{
    /// <summary>
    /// Интерфейс для объектов, которые способны быть введены с консоли нативным способом.
    /// Можно реализовать на System.Console
    /// Рекомендуется реализовать на System.VConsole.Config.p_VirtualConsole
    /// Запрет на реализацию через"".Get__ReadLine<T>() - вероятно будет зацикливание
    /// </summary>
    public interface IReadLineEable{System.Object Get_ReadLine();}
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
            ////Жёсткое создание нового экземпляра
            //Копируем и вставляем вообще все поля.
            if (false)
            _Type.Set(a => a.GetFields(System.Diagnostics.Reflection.Const.p_MyBindingFlags).ToList().ForEach((FieldInfo _field) => _field
                //.Set(c => _field.Set_Att_Writer())
                .Set(c => (System.Reflection.MemberTypes.Field.ToString() + " ").Write())
                .SetIf(_field.IsPublic, c => "Public ".Write())
                .SetIf(_field.IsPrivate, c => "Private ".Write())
                .SetIf(_field.IsFamily, c => "Family ".Write())
                .SetIf(_field.IsAssembly, c => "Assembly ".Write())
                .SetIf(_field.IsStatic, c => "Static ".Write())
                .SetIf(_field.IsInitOnly, c => "InitOnly ".Write())
                .SetIf(_field.IsLiteral, _f1: c => "Literal ".Write())
                .SetIf(_field.IsNotSerialized, c => "NotSerialized ".Write())
                .SetIf(_field.IsSpecialName, c => "SpecialName ".Write())
                .SetIf(_field.IsSpecialName, _c => "IsSpecialName ".Write())
                .Set(c => (_field.FieldType + " " + _Type.ToString() + "." + _field.Name + " ").Write())
                .SetIf(_this != null, c =>
                {
                    System.Object _GetValue = _field.GetValue(_this);
                    if (_GetValue == null) { ".=null".Write(); } else { (".=" + _GetValue.ToString()).Write(); }
                }
                )
                .Set(c => ";".WriteLine())
            ))
            ;
            if(false)
            _Type.Set(a =>
                 a.GetProperties(System.Diagnostics.Reflection.Const.p_MyBindingFlags).ToList().ForEach((PropertyInfo _prop) => _prop
                    //.Set(b => _prop.Set_Att_Writer())
                    .Set(b => (System.Reflection.MemberTypes.Property.ToString() + " " + _prop.PropertyType.ToString() + " " + _Type.ToString() + "." + _prop.Name + " ").Write())
                     //С пропертями все туго, анализ модификаторов доступа не предусмотрен
                     .SetIf(_prop.CanRead, b => "get ".Write())
                     .SetIf(_prop.CanWrite, b => "set ".Write())
                     .SetIf(_prop.CanRead && (_this != null), b => {
                         System.Object _GetValue = _prop.GetValue(_this);
                         if (_GetValue == null) { ".=null".Write(); } else { (".=" + _GetValue.ToString()).Write(); }
                     })
                 )
            )
           ;

            //.ForEach(a=>a.Name);
            //.ForEach(_field => _field.SetValue(_t, _field.GetValue(_this).Get__Copy()))
            ;
            //throw new System.Exception("Eror:№14.11.2021.12.31: not provided case; update the library later; !!!");
            return _this;
        }
        private class classForTest 
        {
            public System.String p_Str = "";
            public System.Int32 p_Int32 = 32;
        }

        /// <summary>System.VConsole.Ext_T_ReadLine.Test_ReadLine();</summary>
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 26, _hour: 9, _minute: 15, _second: 0, _millisecond: 0)]
        public static void Test_ReadLine()
        {
            false.ToString().WriteLine();
            (new classForTest()).Get__ReadLine(); 
            //false.ReadLine().ToString().WriteLine();
        }
    }
    ///////////////////////////////////////////
    
}
