using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace System.Diagnostics
{
    public static class Ext_TestLastMethod
    {
        public static T Get_Delegate_AS<T>(this TestLastMethod _TestLastMethod) where T : System.Delegate
        { return _TestLastMethod.p__Target_MethodInfo.CreateDelegate(typeof(T)).Cast_As<T>(); }
    }

    public static class Ext_ListTestLastMethod
    {
        public static TestLastMethod Get_LastTestMetod(this List<TestLastMethod> _TestLastMethodS)
        { return _TestLastMethodS.Select(b => b.p_DateTime).Max().Get(_Max => _TestLastMethodS.Where(b => b.p_DateTime == _Max)).First(); }
        public static List<TestLastMethod> Where_BoolTest(this List<TestLastMethod> _List_TestLastMethod)
        { return _List_TestLastMethod.Where(a => a.p__Target_MethodInfo.ReturnParameter.ParameterType == typeof(System.Boolean)).ToList(); }
        public static List<TestLastMethod> Where_VoidTest(this List<TestLastMethod> _List_TestLastMethod)
        { return _List_TestLastMethod.Where(a => a.p__Target_MethodInfo.ReturnParameter.ParameterType == typeof(void)).ToList(); }
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

        /// <summary> Запуск последнего тестового метода, возвращающего System.Boolean </summary>
        public static System.Boolean Do_IfBoolean()
        { return System.Diagnostics.TestLast.Get_TestS().Where_BoolTest().Get_LastTestMetod().WriteThis().Get_Delegate_AS<System.Func<System.Boolean>>()(); }
        /// <summary> Запуск вообще всех тестов bool. Предупреждение тест bool не может использовать пользовательский ввод и вывод</summary>
        public static System.Boolean Do_IfBoolean_Oll()
        { return System.Diagnostics.TestLast.Get_TestS().Where_BoolTest().Select(a => a.Get_Delegate_AS<System.Func<System.Boolean>>()()).Aggregate((a, b) => a & b); }
        /// <summary> Запуск последнего тестового метода, возвращающего System.Boolean </summary>
        public static void Do_IfVoid() { System.Diagnostics.TestLast.Get_TestS().Where_VoidTest().Get_LastTestMetod().WriteThis().Get_Delegate_AS<System.Action>()(); }
        /// <summary> Запуск вообще всех тестов void. Предупреждение тест void может использовать пользовательский ввод и вывод</summary>
        public static void Do_IfVoid_Oll()
        { System.Diagnostics.TestLast.Get_TestS().Where_VoidTest().ForEach(a => a.Get_Delegate_AS<System.Action>()()); }
        /// <summary> Запуск последнего тестового метода, возвращающего System.Boolean </summary>
        public static System.Boolean Do()
        { return System.Diagnostics.TestLast.Get_TestS().Where_BoolTest().Get_LastTestMetod().WriteThis().Get_Delegate_AS<System.Func<System.Boolean>>()(); }
        /// <summary> Запуск вообще всех тестов bool. Предупреждение тест bool не может использовать пользовательский ввод и вывод</summary>
        public static System.Boolean Do_Oll()
        { return System.Diagnostics.TestLast.Get_TestS().Where_BoolTest().Select(a => a.Get_Delegate_AS<System.Func<System.Boolean>>()()).Aggregate((a, b) => a & b); }

        //Пример того, как тестовые функции запускались ранее
        /// <summary>System.Diagnostics.TestMode.Test();</summary>
        public static void Test()
        {
            System.Console.WriteLine(System.Diagnostics.StackTracer.Get_STS());
            System.Diagnostics.TestLast.Do();
        }
        //Пример того, как тестовые функции можно мапить сейчас
        [System.Diagnostics.TestLastMethod(_year: 2023, _month: 2, _day: 2, _hour: 18, _minute: 23, _second: 0, _millisecond: 0, _StrComment: "Тест №0. Мапинг тестовых функций ")]
        public static bool Test_0()
        { System.Console.WriteLine(System.Diagnostics.StackTracer.Get_STS()); return true; }
        [System.Diagnostics.TestLastMethod(_year: 2023, _month: 2, _day: 2, _hour: 18, _minute: 23, _second: 1, _millisecond: 0, _StrComment: "Тест №0. Мапинг тестовых функций ")]
        public static System.Boolean Test_0XT78587GF874444G()
        { System.Console.WriteLine(System.Diagnostics.StackTracer.Get_STS()); return true; }
        [System.Diagnostics.TestLastMethod(_year: 2021, _month: 11, _day: 17, _hour: 15, _minute: 06, _second: 0, _millisecond: 0, _StrComment: "Тест №2. Мапинг тестовых функций ")]
        public static bool Test_1()
        { System.Console.WriteLine(System.Diagnostics.StackTracer.Get_STS()); return true; }
    }
}