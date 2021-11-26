namespace Component.Reflection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    //////////////////////////////////////////////////////////////////////////////
    using System.Reflection;
    ////////////////////////////////////////////////////////////////////////
    public static class Ext__Set_TypeInterfaces_Writer
    {
        public static System.Type Set_TypeInterfaces_Writer(this System.Type _Type) => _Type.Set(a =>a.GetInterfaces().ToList().ForEach(i => ("Interface " + _Type.ToString() + ":" + i.ToString() + ";").WriteLine()));

        /// <summary>Component.Reflection.Ext__Set_TypeInterfaces_Writer.Test();</summary>
        public static void Test()
        {
            "###".WriteLine().WriteLine();
            "Что выдает Тестируемая функция".WriteLine();
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            (new Component.Reflection.ClassForTest_Interfaces())
                .GetType()
                .Set_TypeInterfaces_Writer()
            ;
            "###".WriteLine().WriteLine();
            "Что выдает Рефлексионер".WriteLine();
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            (new Component.Reflection.ClassForTest_Interfaces())
                .GetType()
                .Set_Writer()
            ;
        }
    }
    public interface IClassForTest_Interfaces :ICloneable, INewEable
    {
        IClassForTest_Interfaces New();
        IClassForTest_Interfaces Clone();
    }
    /// <summary>Этот пример прямо показывает как ведут себя интерфейсы и классы</summary>
    public class ClassForTest_Interfaces: IClassForTest_Interfaces
    {
        System.Object INewEable.New() => this.New();
        public IClassForTest_Interfaces New() => new ClassForTest_Interfaces();
        System.Object ICloneable.Clone() => this.Clone();
        public IClassForTest_Interfaces Clone() => this.New();
    }
}