using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
///////////////////////////////////////////////////////////
namespace System.Diagnostics
{
    //Component.Att_TestLast//Component.TestLast.Do()//
    /// <summary>
    /// Отметьте этим атрибутом статический тестовый метод, укажите самую последнюю дату. И запускайте.
    /// Метод System.Diagnostics.TestLast.Do(); выберет самый последний тест и запустит его.
    /// Это удобно при отладке. Удобнее чем переименование в Main и модульные тесты.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class Att_TestLast : System.Attribute
    {
        private int p__year = 0; public int p_year { get => this.p__year; }
        private int p__month = 0; public int p_month { get => this.p__month; }
        private int p__day = 0; public int p_day { get => this.p__day; }
        private int p__hour = 0; public int p_hour { get => this.p__hour; }
        private int p__minute = 0; public int p_minute { get => this.p__minute; }
        private int p__second = 0; public int p_second { get => this.p__second; }
        private int p__millisecond = 0; public int p_millisecond { get => this.p__millisecond; }
        private System.String p__StrComment = "DefaultTest"; public System.String p_StrComment { get => this.p__StrComment; }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>Перестыковкой возвращет дату и время</summary>
        public System.DateTime p_DateTime { get => new DateTime(this.p__year, this.p__month, this.p__day, this.p__hour, this.p__minute, this.p__second, this.p__millisecond); }
        /////////////////////////////////////////////////////////////////////////////////////////////
        #region Заплатка или новая Фича ??? время покажет
        public static System.UInt64 p___Generation_Id = System.UInt64.MinValue;
        public System.UInt64 p__GenId = System.UInt64.MinValue;
        /// <summary>Id порядка генерации класса атрибута, Будет использоваться для альтерантивного однозначного вызрова тестовой функции</summary>
        public System.UInt64 p_GenId { get => p__GenId; }
        public Att_TestLast() {this.p__GenId=p___Generation_Id++;}
        #endregion
        /////////////////////////////////////////////////////////////////////////////////////////////
        //public Att_TestLast(){}
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>Иньектор зависимостей, используется как универсальный конструктов.Да, через него можно поменять значение приватного параметра. Смотрите на это как на досадное упущение.</summary>
        public Att_TestLast Set(
             Att_TestLast _this = null
            , System.Nullable<int> _year = null
            , System.Nullable<int> _month = null
            , System.Nullable<int> _day = null
            , System.Nullable<int> _hour = null
            , System.Nullable<int> _minute = null
            , System.Nullable<int> _second = null
            , System.Nullable<int> _millisecond = null
            , System.String _StrComment = null
            ) 
        {
            if (_this != null) this.Set(
                _this:null
                , _year:_this.p__year
                , _month:_this.p__month
                , _day: _this.p__day
                , _hour: _this.p__hour
                , _minute: _this.p__minute
                , _second: _this.p__second
                , _millisecond: _this.p__millisecond
                , _StrComment: _this.p__StrComment+""
                );
            if (_year != null) this.p__year = _year.Value;
            if (_month != null) this.p__month = _month.Value;
            if (_day != null) this.p__day = _day.Value;
            if (_hour != null) this.p__hour = _hour.Value;
            if (_minute != null) this.p__minute = _minute.Value;
            if (_second != null) this.p__second = _second.Value;
            if (_millisecond != null) this.p__millisecond = _millisecond.Value;
            if (_StrComment != null) this.p__StrComment = _StrComment;
            return this;
        }
        public Att_TestLast(int _year = 0, int _month = 0, int _day = 0, int _hour = 0, int _minute = 0, int _second = 0, int _millisecond = 0)
        { this.Set(_year: _year, _month: _month, _day: _day, _hour: _hour, _minute: _minute, _second: _second, _millisecond: _millisecond, _StrComment: "DefaultTest"); }
        public Att_TestLast(int _year = 0, int _month = 0, int _day = 0, int _hour = 0, int _minute = 0, int _second = 0, int _millisecond = 0, System.String _StrComment = "DefaultTest")
        { this.Set(_year: _year, _month: _month, _day: _day, _hour: _hour, _minute: _minute, _second: _second, _millisecond: _millisecond, _StrComment: _StrComment); }
        public override string ToString()
        { return this.GetType().FullName.ToString() + "[" + this.p_DateTime.ToString() + "]"; }
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
                .SelectMany(_Type => _Type.GetMethods().Where(a => a.IsStatic).Select(a => new { p_Method = a, p_Type = _Type }))
                .Where(a => a.p_Method.GetCustomAttributes(true).OfType<Att_TestLast>().Count() == 1)
                .SetIf(_fBool: a => a.Count() == 0, _f1: a => throw new System.Exception("Eror:20200727_1004:Ошибка запуска тест сценария. Нет тестовых функций помеченных атрибутом <" + typeof(Att_TestLast).ToString() + ">"))
                .Get(a => {
                    System.DateTime _DateTime =
                        a.Select(b => b.p_Method.GetCustomAttributes(true).OfType<Att_TestLast>().First().p_DateTime).Max();
                    ;
                    return a.Where(b => b.p_Method.GetCustomAttributes(true).OfType<Att_TestLast>().First().p_DateTime == _DateTime);
                })
                .First()
                .Set(a => {
                    System.Console.WriteLine(a.p_Method.GetCustomAttributes(true).OfType<Att_TestLast>().First().ToString());
                    System.Console.WriteLine(a.p_Type.FullName + "." + a.p_Method.Name + "()");
                }).p_Method
                /*
                .Set(a => Component.StaticC.p_IConsoleR
                    .WriteLine(a.p_Method.GetCustomAttributes(true).OfType<Att_TestLast>().First().ToString())
                    .Set_(b =>b.Set_Test().WriteLine(a.p_Type.FullName + "." + a.p_Method.Name + "()"))
                ).p_Method*/
                .CreateDelegate(typeof(System.Action))
                .Cast_As<System.Action>()()
            ;
        }
        //Пример того, как тестовые функции запускались ранее
        /// <summary>System.Diagnostics.TestMode.Test();</summary>
        public static void Test()
        {
            System.Console.WriteLine(System.Diagnostics.StackTracer.Get_STS());
            System.Diagnostics.TestLast.Do();
        }
        //Пример того, как тестовые функции можно мапить сейчас
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 17, _hour: 15, _minute: 05, _second: 0, _millisecond: 0)]
        public static void Test_0()
        {
            System.Console.WriteLine(System.Diagnostics.StackTracer.Get_STS());
        }

        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 17, _hour: 15, _minute: 06, _second: 0, _millisecond: 0)]
        public static void Test_1()
        {
            System.Console.WriteLine(System.Diagnostics.StackTracer.Get_STS());
        }
    }
}