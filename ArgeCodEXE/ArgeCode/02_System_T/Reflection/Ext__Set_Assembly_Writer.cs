namespace Component.Reflection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    ////////////////////////////////////////////////////
    using Component;
    using System.Reflection;
    ////////////////////////////////////////////////////
    public static class Ext__Set_Assembly_Writer
    {
        public static System.Reflection.Assembly Set_Assembly_Writer(this System.Reflection.Assembly _Assembly) => _Assembly
            .Set(a => (".FullName=" + a.FullName).WriteLine())
            .Set(a => a.GetName()
                .Set(b => ("..Name=" + b.Name).WriteLine())
                .Set(c => c.Version
                    .Set(d => ("..Version=" + d.Major + "." + d.Minor).WriteLine())
                )
            )
            .Set(a => (".CodeBase=" + a.CodeBase).WriteLine())
            .Set(a => "".WriteLine().WriteLine())
        ;
        /// <summary>Component.Reflection.Ext__Set_Assembly_Writer.Test();</summary>
        public static void Test()
        {
            //AppDomain.CurrentDomain.GetAssemblies()
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            "Привет мир".GetType().Assembly.Set_Assembly_Writer();
        }
    }
}