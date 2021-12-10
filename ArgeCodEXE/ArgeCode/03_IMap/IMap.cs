using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////////////////////////////////////////////////////////////
using System.Reflection;
////////////////////////////////////////////////////////////

namespace System.Diagnostics.Map
{
    /// <summary> Пользовательский интерфейс для отображения и редактирования объектов.
    /// Использовать совместно с Att_MapLast.
    /// Привязка к типу редактируемого класса осуществляется через Generic.
    /// Это аналог дата контрактов, но под GUI, ожидается что он будет более изящьным в применении 
    /// </summary>
    public interface IMap<T>
    {
        IMap<T> Set_Obj(T _Obj);
        IMap<T> Do();
        T GetResalt();
    }
    public static class Ext_IMapS
    {
        /// <summary> Возвращает самую позднюю версию интерфейса под класс</summary>
        public static IMap<T> Get_LastImap_T<T>()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(_Assemblie => _Assemblie.GetTypes()
                    .Where(a => a.IsClass & a.GetInterfaces().Contains(typeof(System.Diagnostics.Map.IMap<T>)))
                ).Get(a =>{
                    System.DateTime _DateTime = a.Select(b => b.GetCustomAttributes(true).OfType<Att_MapLast>().First().p_DateTime).Max();
                    return a.Where(b => b.GetCustomAttributes(true).OfType<Att_MapLast>().First().p_DateTime == _DateTime);
                }).First()
                .Get(a => (T)Activator.CreateInstance(a))
                .Cast_As<IMap<T>>()
            ;
        }
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 12, _day: 09, _hour: 11, _minute: 59, _second: 0, _millisecond: 0)]
        public static void Test() 
        {            
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
        }
    }
}