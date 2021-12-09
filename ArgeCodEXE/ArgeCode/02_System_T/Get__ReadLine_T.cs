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
            if (_this == null) _this = _this.Get__New();
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
            //Метод получения пунктов меню для редактирования полей Fields
            List<System.VConsole.GUIVC> Get_ListGUIVC_For_Fields()
            {
                return _Type.GetFields(System.Diagnostics.Reflection.Const.p_MyBindingFlags)
                    .Select(_field => new System.VConsole.GUIVC()
                        .Set(_UpDate: a =>
                            a.p_Title = System.Reflection.MemberTypes.Field.ToString() + " "
                            + (_field.IsPublic ? "Public " : "") + (_field.IsPrivate ? "Private " : "") + (_field.IsFamily ? "Family " : "")
                            + (_field.IsAssembly ? "Assembly " : "") + (_field.IsStatic ? "Static " : "") + (_field.IsInitOnly ? "InitOnly " : "")
                            + (_field.IsLiteral ? "Literal " : "") + (_field.IsNotSerialized ? "NotSerialized " : "")
                            + (_field.IsSpecialName ? "SpecialName " : "") + (_field.IsSpecialName ? "IsSpecialName " : "")
                            + _field.FieldType + " " + _Type.ToString() + "." + _field.Name + " "
                            + "".GetIf(_Bool: _this == null, _f1: b => ".this == null",
                                _f0: b => _field.GetValue(_this).GetIf(_fBool: c => c == null, _f1: c => ".=null", _f0: c => ".=" + c.ToString()))
                        )
                        .Set(_Act: a => _this.SetIf(_Bool: _this != null, _f1: b => _field.SetValue(_this, _field.GetValue(_this).Get__ReadLine())))
                    ).ToList();
            }
            List<System.VConsole.GUIVC> Get_ListGUIVC_For_Properties()
            {
                return _Type.GetProperties(System.Diagnostics.Reflection.Const.p_MyBindingFlags)
                    .Select(_prop => new System.VConsole.GUIVC()
                        .Set(_UpDate: a =>
                            a.p_Title = System.Reflection.MemberTypes.Property.ToString() + " " + _prop.PropertyType.ToString() + " " + _Type.ToString() + "." + _prop.Name + " "
                            + (_prop.CanRead ? "get " : "") + (_prop.CanWrite ? "set " : "")
                            + "".GetIf(_Bool: _this == null, _f1: b => ".this == null",
                                _f0: b => _prop.GetValue(_this).GetIf(_fBool: c => c == null, _f1: c => ".=null", _f0: c => ".=" + c.ToString()))
                        )
                        .Set(_Act: a =>_this.SetIf(_Bool: (_this != null) && _prop.CanWrite, _f1: b =>_prop.SetValue(_this, _prop.GetValue(_this).Get__ReadLine())))
                    ).ToList();
            }
            //Далее пока не рабочий код
            System.VConsole.GUIVC _GUIVC = new System.VConsole.GUIVC()
                .Set(_Title: "Вод полей объекта", _IsRepeater: true)
                .Set(_GUIVC_S:
                    (new List<GUIVC>())
                    .Set_Add(new System.VConsole.GUIVC().Set(_Title:"Выход",_Act:a=> a.p_Sender.p_IsRepeater=false))
                    .Set(a=> a.AddRange(Get_ListGUIVC_For_Fields())).Set(a => a.AddRange(Get_ListGUIVC_For_Properties()))
                )
                .Do()
            ;
            
            return _this;
        }
        private class classForTest 
        {
            public System.String p_Str = "";
            public System.Int32 p_Int32 = 32;
            public System.Int16 p_Int16 { get; set; }
        }

        /// <summary>System.VConsole.Ext_T_ReadLine.Test_ReadLine();</summary>
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 12, _day: 02, _hour: 14, _minute: 31, _second: 0, _millisecond: 0)]
        public static void Test_ReadLine()
        {
            false.ToString().WriteLine();
            (new classForTest()).Get__ReadLine(); 
            //false.ReadLine().ToString().WriteLine();
        }
    }
    ///////////////////////////////////////////   
}