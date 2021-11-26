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
    public static class Ext__Set_MemberInfo_Writer
    {
        /// <summary>  Выводит в консоль поверхностную информацию о членах класса </summary><returns>Возвращение с продолжением</returns>
        public static System.Type Set_MemberInfo_Writer(this System.Type _Type) =>
            _Type.Set(a => a.Get(b => _Type.GetMembers(System.Diagnostics.Reflection.Const.p_MyBindingFlags))
                .ToList().ForEach(mi => (mi.MemberType.ToString() + " " + _Type.ToString() + "." + mi.Name).WriteLine())
            ).Set(a => "...".WriteLine())
        ;

        /// <summary>Component.Reflection.Ext__Set_MemberInfo_Writer.Test();</summary>
        public static void Test()
        {
            "###".WriteLine().WriteLine();
            "Что выдает Тестируемая функция".WriteLine();
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            (new Component.Reflection.ClassForTest())
                .GetType()
                .Set_MemberInfo_Writer()
            ;
            "###".WriteLine().WriteLine();
            "Что выдает Рефлексионер".WriteLine();
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            (new Component.Reflection.ClassForTest())
                .GetType()
                .Set_Writer()
            ;
        }
    }
}
