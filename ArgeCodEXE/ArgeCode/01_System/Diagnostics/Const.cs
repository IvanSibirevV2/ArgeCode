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
    public static class Const
    {
        public static System.Reflection.BindingFlags p_MyBindingFlags { get => p__MyBindingFlags; }
        /// <summary>Внутри шарповые рефлексивные флаги выборок членов класса </summary>
        private static System.Reflection.BindingFlags p__MyBindingFlags =
            BindingFlags.Default
            | BindingFlags.IgnoreCase
            | BindingFlags.DeclaredOnly
            | BindingFlags.Instance
            | BindingFlags.Static
            | BindingFlags.Public
            | BindingFlags.NonPublic
            | BindingFlags.FlattenHierarchy
            | BindingFlags.InvokeMethod
            | BindingFlags.CreateInstance
            | BindingFlags.GetField
            | BindingFlags.SetField
            | BindingFlags.GetProperty
            | BindingFlags.SetProperty
            | BindingFlags.PutDispProperty
            | BindingFlags.PutRefDispProperty
            | BindingFlags.ExactBinding
            | BindingFlags.SuppressChangeType
            | BindingFlags.OptionalParamBinding
            | BindingFlags.IgnoreReturn
        ;
    }
}