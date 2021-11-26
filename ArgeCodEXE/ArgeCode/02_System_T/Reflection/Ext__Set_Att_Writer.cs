namespace System.Diagnostics.Reflection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    //////////////////////////////////////////////////////////////////////////////
    using System.Reflection;
    //////////////////////////////////////////////////////////////////////////////
    public static class Ext__Set_Att_Writer
    {
        public static void Set_Att_Writer(this System.Reflection.MemberInfo _CtorInf)
            => _CtorInf.GetCustomAttributes().ToList()
                .Set(a => { if (a.Count() > 0) { a.ForEach(b => ('[' + b.GetType().ToString() + "] ").Write()); "".WriteLine(); } })
        ;
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 26, _hour: 9, _minute: 40, _second: 0, _millisecond: 0)]
        public static void Test()
        {
            System.Diagnostics.StackTracer.Get_STS().WriteLine();

        }

        [System.Diagnostics.Reflection.TestAtt(_String: "Интерфейс")]
        private interface interfaceForTest{}
        [System.Diagnostics.Reflection.TestAtt(_String: "   кЛАСС")]
        private class classForTest: interfaceForTest
        {
            [System.Diagnostics.Reflection.TestAtt(_String: "пАРАМЕТР ")]
            public System.Int16 p_e = 0;
            public System.Int16 p__e { get; set; }
            [System.Diagnostics.Reflection.TestAtt(_String: "пАРАМЕТР")]
            private System.Int32 p_r = 0;
            private System.Int32 p__r{get; set;}
            [System.Diagnostics.Reflection.TestAtt(_String: "мЕТОД")]
            public static void Foo_qwe(int q, int w) { }
            [System.Diagnostics.Reflection.TestAtt(_String: "мЕТОД")]
            public System.Double Foo_qwee(int q, int w) { return 0; }
        }
    }
}
    /// <summary> Тестовый атрибут/// Component.Reflection.TestAtt /// </summary>
    
