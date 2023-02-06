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
    /// Аттрибут не повторяющийся.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class TestLastMethod : System.Attribute
    {
        private System.DateTime p__DateTime = new DateTime(); public System.DateTime p_DateTime { get => this.p__DateTime; }
        private System.String p__StrComment = "DefaultTest"; public System.String p_StrComment { get => this.p__StrComment; }
        /// <summary> Данные анализируемого метода </summary>
        public MethodInfo p__Target_MethodInfo = null;
        /// <summary> Класс источник метода </summary>
        public System.Type p__Target_Type = null;
        /////////////////////////////////////////////////////////////////////////////////////////////
        #region Заплатка или новая Фича ??? время покажет
        public static System.UInt64 p___Generation_Id = System.UInt64.MinValue;
        public System.UInt64 p__GenId = System.UInt64.MinValue;
        /// <summary>Id порядка генерации класса атрибута, Будет использоваться для альтерантивного однозначного вызрова тестовой функции</summary>
        public System.UInt64 p_GenId { get => p__GenId; }
        public TestLastMethod() { this.p__GenId = p___Generation_Id++; }
        #endregion
        /////////////////////////////////////////////////////////////////////////////////////////////
        //public Att_TestLast(){}
        /////////////////////////////////////////////////////////////////////////////////////////////
        public TestLastMethod(int _year = 0, int _month = 0, int _day = 0, int _hour = 0, int _minute = 0, int _second = 0, int _millisecond = 0, System.String _StrComment = null)
        {
            this.p__DateTime = new DateTime(_year, _month, _day, _hour, _minute, _second, _millisecond);
            this.p__StrComment = _StrComment;
        }
        public override string ToString()
        { return this.GetType().FullName.ToString() + "[" + this.p_DateTime.ToString("hh:mm:ss") + "::" + this.p_DateTime.ToString("dd.MM.yyyy") + "]"; }
        public TestLastMethod WriteThis()
        {
            if (this.p_StrComment != null) ("//" + this.p_StrComment).WriteLine();
            this.ToString().WriteLine();
            if (this.p__Target_Type != null) if (this.p__Target_MethodInfo != null)
                    (this.p__Target_Type.FullName + "." + this.p__Target_MethodInfo.Name + "()").WriteLine();
            return this;
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
        public static List<TestLastMethod> Get_TestS()
        {
            List<TestLastMethod> TestS =
                AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(_Assemblie => _Assemblie.GetTypes().ToArray())
                .SelectMany(_Type => _Type.GetMethods().Where((MethodInfo a) => a.IsStatic).Where(a => a.GetCustomAttributes(true).OfType<TestLastMethod>().Count() == 1)
                    .Select(a => a.GetCustomAttributes(true).OfType<TestLastMethod>().First().Set(b => { b.p__Target_MethodInfo = a; b.p__Target_Type = _Type; }))
                ).ToList();
            TestS.Sort((a, b) => {
                if (a.p_DateTime > b.p_DateTime) return 1;
                if (a.p_DateTime < b.p_DateTime) return -1;
                return 0;
            })
            ;
            if (TestS.Count() == 0) throw new System.Exception("Eror:232710012023:Список тестов пуст, пометье хотябы одну статическую функцию тестовым атрибутом [TestLastMethod]");
            return TestS;
            //return null;
        }
        public static TestLastMethod Get_LastTestMetod(this List<TestLastMethod> _TestLastMethodS)
        { return _TestLastMethodS.Get(a => a.Select(b => b.p_DateTime).Max().Get(_Max => a.Where(b => b.p_DateTime == _Max))).First(); }

        public static T Get_Delegate_AS<T>(this TestLastMethod _TestLastMethod) where T : System.Delegate
        { return _TestLastMethod.p__Target_MethodInfo.CreateDelegate(typeof(T)).Cast_As<T>(); }
        /// <summary> Запуск последнего тестового метода, возвращающего System.Boolean </summary>
        public static System.Boolean Do_IfBoolean()
        {
            return System.Diagnostics.TestLast.Get_TestS()
                .Where(a => a.p__Target_MethodInfo.ReturnParameter.ParameterType == typeof(System.Boolean)).ToList()
                .Get_LastTestMetod().WriteThis().Get_Delegate_AS<System.Func<System.Boolean>>()()
            ;
        }
        /// <summary> Запуск вообще всех тестов bool. Предупреждение тест bool не может использовать пользовательский ввод и вывод</summary>
        public static System.Boolean Do_IfBoolean_Oll()
        {
            return System.Diagnostics.TestLast.Get_TestS()
                .Where(a => a.p__Target_MethodInfo.ReturnParameter.ParameterType == typeof(System.Boolean)).ToList()
                .Select(a => a.Get_Delegate_AS<System.Func<System.Boolean>>()()).Aggregate((a,b)=>a&b)
            ;
        }
        /// <summary> Запуск последнего тестового метода, возвращающего System.Boolean </summary>
        public static void Do()
        {
            System.Diagnostics.TestLast.Get_TestS()
                .Where(a => a.p__Target_MethodInfo.ReturnParameter.ParameterType == typeof(void)).ToList()
                .Get_LastTestMetod().WriteThis().Get_Delegate_AS<System.Action>()()
            ;
        }
        /// <summary> Запуск вообще всех тестов void. Предупреждение тест void может использовать пользовательский ввод и вывод</summary>
        public static void Do_Oll()
        {
            System.Diagnostics.TestLast.Get_TestS()
                .Where(a => a.p__Target_MethodInfo.ReturnParameter.ParameterType == typeof(void)).ToList()
                .ForEach(a => a.Get_Delegate_AS<System.Action>()())
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
        [System.Diagnostics.TestLastMethod(_year: 2023, _month: 2, _day: 2, _hour: 18, _minute: 23, _second: 0, _millisecond: 0, _StrComment: "Тест №0. Мапинг тестовых функций ")]
        public static void Test_0()
        {
            System.Console.WriteLine(System.Diagnostics.StackTracer.Get_STS());
        }
        [System.Diagnostics.TestLastMethod(_year: 2023, _month: 2, _day: 2, _hour: 18, _minute: 23, _second: 1, _millisecond: 0, _StrComment: "Тест №0. Мапинг тестовых функций ")]
        public static System.Boolean Test_0XT78587GF874444G()
        {
            System.Console.WriteLine(System.Diagnostics.StackTracer.Get_STS());
            return (System.Boolean)true;
        }
        [System.Diagnostics.TestLastMethod(_year: 2021, _month: 11, _day: 17, _hour: 15, _minute: 06, _second: 0, _millisecond: 0, _StrComment: "Тест №2. Мапинг тестовых функций ")]
        public static void Test_1()
        {
            System.Console.WriteLine(System.Diagnostics.StackTracer.Get_STS());
        }
    }
}