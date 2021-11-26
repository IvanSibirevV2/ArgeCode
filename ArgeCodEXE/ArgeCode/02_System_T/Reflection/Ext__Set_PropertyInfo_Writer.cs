namespace System.Diagnostics.Reflection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    //////////////////////////////////////////////////////////////////////////////
    using System.Reflection;
    ////////////////////////////////////////////////////////////////
    public static class Ext__Set_PropertyInfo_Writer
    {

        public static System.Type Set_PropertyInfo_Writer(this System.Type _Type, System.Object _Object = null)
            => _Type.Set(a =>
                 a.GetProperties(System.Diagnostics.Reflection.Const.p_MyBindingFlags).ToList().ForEach((PropertyInfo _prop) => _prop
                    .Set(b=> _prop.Set_Att_Writer())
                    .Set(b => (System.Reflection.MemberTypes.Property.ToString() + " " + _prop.PropertyType.ToString() + " " + _Type.ToString() + "." + _prop.Name + " ").Write())
                     //С пропертями все туго, анализ модификаторов доступа не предусмотрен
                     .SetIf(_prop.CanRead, b => "get ".Write())
                     .SetIf(_prop.CanWrite, b => "set ".Write())
                     .SetIf(_prop.CanRead && (_Object != null), b => {
                         System.Object _GetValue = _prop.GetValue(_Object);
                         if (_GetValue == null) { ".=null".Write(); } else { (".=" + _GetValue.ToString()).Write(); }
                     })
                 )
            )
        ;

        /// <summary>Component.Reflection.Ext__Set_PropertyInfo_Writer.Test();</summary>
        public static void Test()
        {
            "###".WriteLine().WriteLine();
            "Что выдает Тестируемая функция".WriteLine();
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            (new System.Diagnostics.Reflection.ClassForTest_Property())
                .GetType()
                .Set_MethodInfo_Writer()
            ;
            "###".WriteLine().WriteLine();
            "Что выдает Рефлексионер".WriteLine();
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            (new System.Diagnostics.Reflection.ClassForTest_Property())
                .GetType()
                .Set_Writer()
            ;
        }

    }
    public class ClassForTest_Property
    {
        private System.String p__StringField = "StringField";
        public System.String p_StringField { get => this.p__StringField; set => this.p__StringField = value; }
    }
}
