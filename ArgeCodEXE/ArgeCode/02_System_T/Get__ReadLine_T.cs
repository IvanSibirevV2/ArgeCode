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
