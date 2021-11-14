using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.VConsole
{
    /// <summary>
    /// Интерфейс для объектов, которые способны быть введены с консоли нативным способом.
    /// Можно реализовать на System.Console
    /// Рекомендуется реализовать на System.VConsole.Config.p_VirtualConsole
    /// Запрет на реализацию через"".Get__ReadLine<T>() - вероятно будет зацикливание
    /// </summary>
    public interface IReadLineEable
    {
        System.Object Get_ReadLine();
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
                if (_Type == typeof(System.Boolean))
                {
                    switch (System.VConsole.Config.p_VirtualConsole.ReadLine())
                    {
                        case "0": return (T)(System.Object)false; break;
                        case "False": return (T)(System.Object)false; break;
                        case "false": return (T)(System.Object)false; break;
                        case "1": return (T)(System.Object)true; break;
                        case "True": return (T)(System.Object)true; break;
                        case "true": return (T)(System.Object)true; break;
                        default: return (T)(System.Object)false; break;
                    }
                }
                if (_Type == typeof(System.Byte))return (T)(System.Object)System.Byte.Parse(System.VConsole.Config.p_VirtualConsole.ReadLine());
                if (_Type == typeof(System.Char)) return (T)(System.Object)System.Char.Parse(System.VConsole.Config.p_VirtualConsole.ReadLine());
                if (_Type == typeof(System.Decimal)) return (T)(System.Object)System.Decimal.Parse(System.VConsole.Config.p_VirtualConsole.ReadLine());
                if (_Type == typeof(System.Double)) return (T)(System.Object)System.Double.Parse(System.VConsole.Config.p_VirtualConsole.ReadLine());
                if (_Type == typeof(System.Int16)) return (T)(System.Object)System.Int16.Parse(System.VConsole.Config.p_VirtualConsole.ReadLine());
                if (_Type == typeof(System.Int32)) return (T)(System.Object)System.Int32.Parse(System.VConsole.Config.p_VirtualConsole.ReadLine());
                if (_Type == typeof(System.Int64)) return (T)(System.Object)System.Int64.Parse(System.VConsole.Config.p_VirtualConsole.ReadLine());
                if (_Type == typeof(System.SByte)) return (T)(System.Object)System.SByte.Parse(System.VConsole.Config.p_VirtualConsole.ReadLine());
                if (_Type == typeof(System.Single)) return (T)(System.Object)System.Single.Parse(System.VConsole.Config.p_VirtualConsole.ReadLine());
                if (_Type == typeof(System.String)) return (T)(System.Object)System.VConsole.Config.p_VirtualConsole.ReadLine();
                if (_Type == typeof(System.UInt16)) return (T)(System.Object)System.UInt16.Parse(System.VConsole.Config.p_VirtualConsole.ReadLine());
                if (_Type == typeof(System.UInt32)) return (T)(System.Object)System.UInt32.Parse(System.VConsole.Config.p_VirtualConsole.ReadLine());
                if (_Type == typeof(System.UInt64)) return (T)(System.Object)System.UInt64.Parse(System.VConsole.Config.p_VirtualConsole.ReadLine());
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
