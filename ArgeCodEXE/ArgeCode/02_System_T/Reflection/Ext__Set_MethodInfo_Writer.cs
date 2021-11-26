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
    public static class Ext__Set_MethodInfo_Writer
    {
        public static System.Type Set_MethodInfo_Writer(this System.Type _Type) =>
            _Type.Set(
                a => a.GetMethods(System.Diagnostics.Reflection.Const.p_MyBindingFlags).ToList().ForEach(_method =>
                {
                    _method.Set_Att_Writer();
                    (System.Reflection.MemberTypes.Method.ToString() + " ").Write();
                    ((MethodBase)_method).Set_MetodAccessModifier_Writer()
                    /*
                                .SetIf(method.IsPublic, b => "Public ".Write())
                                .SetIf(method.IsPrivate, b => "Private ".Write())
                                .SetIf(method.IsFamily, b => "Family ".Write())
                                .SetIf(method.IsAssembly, b => "Assembly ".Write())
                                .SetIf(method.IsStatic, b => "Static ".Write())
                                .SetIf(method.IsFinal, b => "Final ".Write())
                                .SetIf(method.IsVirtual, b => "Virtual ".Write())
                                .SetIf(method.IsHideBySig, b => "HideBySig ".Write())
                                .SetIf(method.IsAbstract, b => "Abstract ".Write())
                                */
                            ;
                    (_method.ReturnType.ToString() + " " + _Type.ToString() + "." + _method.Name + " (").Write();
                    ParameterInfo[] parameters = _method.GetParameters();//получаем все параметры
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

        /// <summary>Component.Reflection.Ext__Set_MethodInfo_Writer.Test();</summary>
        public static void Test()
        {
            "###".WriteLine().WriteLine();
            "Что выдает Тестируемая функция".WriteLine();
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            (new Component.Reflection.ClassForTest_Method())
                .GetType()
                .Set_MethodInfo_Writer()
            ;
            "###".WriteLine().WriteLine();
            "Что выдает Рефлексионер".WriteLine();
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            (new Component.Reflection.ClassForTest_Method())
                .GetType()
                .Set_Writer()
            ;
        }
    }
    public class ClassForTest_Method
    {
        public void Foo_0() { }
        public void Foo_1(int i) { }
        public void Foo_2(int i, int j) { } 
    }
}
