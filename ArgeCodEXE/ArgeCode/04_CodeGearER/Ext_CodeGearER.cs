using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////////////////////////////////////////////////
using System.Globalization;
////////////////////////////////////////////////
namespace System.CodeGearER
{
    public static class Ext_CodeGearER
    {
        public static System.Reflection.Assembly Get_Assembly(this string sources) 
        {
            
            Microsoft.CSharp.CSharpCodeProvider _CSharpCodeProvider = new Microsoft.CSharp.CSharpCodeProvider();
            System.CodeDom.Compiler.CompilerParameters _CompilerParameters = new System.CodeDom.Compiler.CompilerParameters();
            ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;
            _CompilerParameters.ReferencedAssemblies.AddRange(AppDomain.CurrentDomain.GetAssemblies().Select(p => p.Location).ToArray());
            System.CodeDom.Compiler.CompilerResults _CompilerResults = _CSharpCodeProvider
                .CompileAssemblyFromSource(_CompilerParameters
                    , sources
                )
            ;
            if (_CompilerResults.Errors.Count > 0)
            {
                for (int i = 0; i < _CompilerResults.Errors.Count; i++) _CompilerResults.Errors[i].ErrorText.WriteLine();
                throw new System.Exception("ErrorS:2021.21.09_21.18:Ошибки компиляции из текста");
            }
            return _CompilerResults.CompiledAssembly;
        }
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 12, _day: 10, _hour: 22, _minute: 26, _second: 0, _millisecond: 0)]
        public static void Test()
        {
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            System.String _NameSpace = "Space_" + System.DateTime.Now.ToString("yyyyMMdd_ssmmhh_ffffff");
            System.String _NameClass = "Class_" + System.DateTime.Now.ToString("yyyyMMdd_ssmmhh_ffffff");
            System.String _NameMetod = "Metod_" + System.DateTime.Now.ToString("yyyyMMdd_ssmmhh_ffffff");
            
            (@"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////////////////////////////////////////////////
using System.Globalization;
namespace " + _NameSpace + @"
{
    public static class " + _NameClass + @"
    {
        public static void "+_NameMetod+ @"()
        {
            "+"\""+"Привет Котишка.Как твои дела ? Хорошо ли ты кушаешь ? " + "\"" + @".WriteLine();
        }
    }
}
            ")
                .Get_Assembly()
                .GetType(_NameSpace + "." + _NameClass)
                .GetMethod(_NameMetod)
                .CreateDelegate(typeof(System.Action))
                .Cast_As<System.Action>()
            ()    
            ;
        }
    }
}
