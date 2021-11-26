namespace Component.Reflection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    //////////////////////////////////////////////////////////////////////////////
    using System.Reflection;
    //////////////////////////////////////////////////////////////////////////////
    /// <summary>Ext__Set_ConstructorInfo_Writer</summary>v
    public static class Ext__Set_CtorInfo_Writer
    {
        public static System.Type Set_ConstructorInfo_Writer(this System.Type _Type) =>
            _Type.Set(a => a.GetConstructors(System.Diagnostics.Reflection.Const.p_MyBindingFlags).ToList().ForEach((ConstructorInfo _ctor) =>
            {
                _ctor.Set_Att_Writer();
                (System.Reflection.MemberTypes.Constructor.ToString() + " ").Write();
                ((MethodBase)_ctor).Set_MetodAccessModifier_Writer();
                (_Type.Name + " (").Write();
                ParameterInfo[] parameters = _ctor.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    (parameters[i].ParameterType.ToString() + " " + parameters[i].Name).Write();
                    if (i + 1 < parameters.Length) ", ".Write();
                }
                ");".WriteLine();
            }
                )
            )
        ;
        /// <summary>Component.Reflection.Ext__Set_CtorInfo_Writer.Test();</summary>
        public static void Test()
        {
            "###".WriteLine().WriteLine();
            "Что выдает Тестируемая функция".WriteLine();
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            (new Component.Reflection.ClassForTest_Ctor())
                .GetType()                
                .Set_ConstructorInfo_Writer()
            ;
            "###".WriteLine().WriteLine();
            "Что выдает Рефлексионер".WriteLine();
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            (new Component.Reflection.ClassForTest_Ctor())
                .GetType()                
                .Set_Writer()
            ;
        }
    }
    /// <summary>Класс для отладки рефлексии/Конструктор</summary>
    public class ClassForTest_Ctor
    {
        [TestAtt(_String: "dasda")]
        public ClassForTest_Ctor() { }
        public ClassForTest_Ctor(int a) { }
        private ClassForTest_Ctor(int a,int b) { }
    }
}
