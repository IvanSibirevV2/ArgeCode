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
    public static class Ext__Set_FieldInfo_Writer
    {
        public static System.Type Set_FieldInfo_Writer(this System.Type _Type, System.Object _Object = null)
        => _Type.Set(a => a.GetFields(System.Diagnostics.Reflection.Const.p_MyBindingFlags).ToList().ForEach((FieldInfo _field) => _field
                .Set(c => _field.Set_Att_Writer())
                .Set(c => (System.Reflection.MemberTypes.Field.ToString() + " ").Write())
                .SetIf(_field.IsPublic, c => "Public ".Write())
                .SetIf(_field.IsPrivate, c => "Private ".Write())
                .SetIf(_field.IsFamily, c => "Family ".Write())
                .SetIf(_field.IsAssembly, c => "Assembly ".Write())
                .SetIf(_field.IsStatic, c => "Static ".Write())
                .SetIf(_field.IsInitOnly, c => "InitOnly ".Write())
                .SetIf(_field.IsLiteral,_f1: c => "Literal ".Write())
                .SetIf(_field.IsNotSerialized, c => "NotSerialized ".Write())
                .SetIf(_field.IsSpecialName, c => "SpecialName ".Write())
                .SetIf(_field.IsSpecialName, _c => "IsSpecialName ".Write())
                .Set(c => (_field.FieldType + " " + _Type.ToString() + "." + _field.Name + " ").Write())
                .SetIf(_Object != null, c =>
                {
                    System.Object _GetValue = _field.GetValue(_Object);
                    if (_GetValue == null) { ".=null".Write(); } else { (".=" + _GetValue.ToString()).Write(); }
                }
                )
                .Set(c => ";".WriteLine())
            ))
        ;
        /// <summary>Component.Reflection.Ext__Set_FieldInfo_Writer.Test();</summary>
        public static void Test()
        {
            "###".WriteLine().WriteLine();
            "Что выдает Тестируемая функция".WriteLine();
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            (new Component.Reflection.ClassForTest_Field())
                .GetType()
                .Set_FieldInfo_Writer()
            ;
            "###".WriteLine().WriteLine();
            "Что выдает Рефлексионер".WriteLine();
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            (new Component.Reflection.ClassForTest_Field())
                .GetType()
                .Set_Writer()
            ;
        }
    }
    public class ClassForTest_Field
    {
        public System.String p_StringField = "StringField";
    }
}
