using Component.ConsoleR.ReadER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Component.ConsoleR;
///////////////////////////////////////////////////////////
namespace Component.Diagnostics
{
    //Component.Att_TestLast//Component.TestLast.Do()//
    [AttributeUsage(AttributeTargets.Method)]
    public class Att_TestLast : System.Attribute
    {
        public System.DateTime p_DateTime = new DateTime();
        public Att_TestLast() { }
        public Att_TestLast(int _year=0, int _month=0, int _day=0, int _hour=0, int _minute=0, int _second=0, int _millisecond=0)
        {
            this.p_DateTime = new DateTime(_year, _month, _day, _hour, _minute, _second, _millisecond);
        }
        public override string ToString()
        {
            return this.GetType().FullName.ToString()+"[" + this.p_DateTime.ToString()+"]";
        }
    }
    /// <summary>
    /// Продвинутый инструмент запуска тестовых функций.
    /// Как пользоваться. Создаете статическую тестовую вункцию.
    /// Помечаете ее атрибутом тестовых функций:
    /// [Component.Att_TestMode(_year: 2020, _month: 07, _day: 27, _hour: 15, _minute: 43, _second: 0, _millisecond: 0)]
    /// Выставляете параметры глядя на карманные часы)))
    /// В самом коде втыкаете Component.TestMode.On();
    /// ///////////////////////////////////////////////////////////
    /// Как это работает: рефлексивный LinQ-шный поиск по типам классов с поиском самого позднего System.DateTime , сидящего в атрибуте
    /// </summary>
    public static class TestLast
    {
        public static void Do()
        {
            AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(_Assemblie => _Assemblie.GetTypes().ToArray())
                .SelectMany(_Type => _Type.GetMethods().Where(a => a.IsStatic).Select(a => new { p_Method =a, p_Type = _Type}))
                .Where(a => a.p_Method.GetCustomAttributes(true).OfType<Att_TestLast>().Count() == 1)
                .SetIf(_fBool: a => a.Count() == 0, _f1: a => throw new System.Exception("Eror:20200727_1004:Ошибка запуска тест сценария. Нет тестовых функций помеченных атрибутом <" + typeof(Att_TestLast).ToString() + ">"))
                .Get(a=> {
                    System.DateTime _DateTime =
                        a.Select(b => b.p_Method.GetCustomAttributes(true).OfType<Att_TestLast>().First().p_DateTime).Max();
                    ;
                    return a.Where(b => b.p_Method.GetCustomAttributes(true).OfType<Att_TestLast>().First().p_DateTime == _DateTime);
                })
                .First()
                .Set(a => Component.StaticC.p_IConsoleR
                    .WriteLine(a.p_Method.GetCustomAttributes(true).OfType<Att_TestLast>().First().ToString())
                    .Set_(b =>b.Set_Test().WriteLine(a.p_Type.FullName + "." + a.p_Method.Name + "()"))
                ).p_Method
                .CreateDelegate(typeof(System.Action))
                .Cast_As<System.Action>()()
            ;
        }
        //private struct Q
        //Пример того, как тестовые функции запускались ранее
        /// <summary>Component.TestMode.Test();</summary>
        public static void Test()
        {
            Component.StaticC.CheckStackTracer();
            Component.Diagnostics.TestLast.Do();
        }
        //Пример того, как тестовые функции можно мапить сейчас
        [Component.Diagnostics.Att_TestLast(_year:2020,_month:07,_day:27,_hour:15,_minute:40,_second:0,_millisecond:0)]
        public static void Test_0()
        {
            Component.StaticC.CheckStackTracer();
        }
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 07, _day: 27, _hour: 15, _minute: 43, _second: 0, _millisecond: 0)]
        public static void Test_1()
        {
            Component.StaticC.CheckStackTracer();
        }
    }
}