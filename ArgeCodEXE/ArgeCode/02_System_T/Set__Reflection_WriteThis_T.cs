using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace System
{
    public static class Set__Reflection_WriteThis_T
    {
        #region private static System.Reflection.BindingFlags p__MyBindingFlags ;
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
        #endregion

        public static T Set__Reflection_WriteThis<T>(this T _this)
        {
            System.Type _Type = _this.GetType();
            _Type.ToString().WriteLine();
            #region GetCustomAttributes
            _Type.GetCustomAttributes(true).Select(a => "[" + a.GetType().ToString() + "]").ToList().WriteLine();
            "//".WriteLine();
            #endregion
            #region If(_Type.Is)
            if (_Type.IsAbstract) ".IsAbstract".Write();
            if (_Type.IsAnsiClass) ".IsAnsiClass".Write();
            if (_Type.IsArray) ".IsArray".Write();
            if (_Type.IsAutoClass) ".IsAutoClass".Write();
            if (_Type.IsAutoLayout) ".IsAutoLayout".Write();
            if (_Type.IsByRef) ".IsByRef".Write();
            if (_Type.IsClass) ".IsClass".Write();
            if (_Type.IsCOMObject) ".IsCOMObject".Write();
            if (_Type.IsConstructedGenericType) ".IsConstructedGenericType".Write();
            if(_Type.IsContextful) ".IsContextful".Write();
            //.SetIf(_Type.IsDefined, a=>".".Write();
            if(_Type.IsEnum)".IsEnum".Write();
            if (_Type.IsExplicitLayout) ".IsExplicitLayout".Write();
            if (_Type.IsGenericParameter) ".IsGenericParameter".Write();
            if(_Type.IsGenericType) ".IsGenericType".Write();
            if(_Type.IsGenericTypeDefinition) ".IsGenericTypeDefinition".Write();
            if(_Type.IsImport) ".IsImport".Write();
            if(_Type.IsInterface) ".IsInterface".Write();
            if(_Type.IsLayoutSequential) ".IsLayoutSequential".Write();
            if(_Type.IsMarshalByRef) ".IsMarshalByRef".Write();
            if(_Type.IsNested) ".IsNested".Write();
            if(_Type.IsNestedAssembly) ".IsNestedAssembly".Write();
            if(_Type.IsNestedFamANDAssem) ".IsNestedFamANDAssem".Write();
            if(_Type.IsNestedFamily) ".IsNestedFamily".Write();
            if(_Type.IsNestedFamORAssem) ".IsNestedFamORAssem".Write();
            if(_Type.IsNestedPrivate) ".IsNestedPrivate".Write();
            if(_Type.IsNestedPublic) ".IsNestedPublic".Write();
            if(_Type.IsNotPublic) ".IsNotPublic".Write();
            if(_Type.IsPointer) ".IsPointer".Write();
            if(_Type.IsPrimitive) ".IsPrimitive".Write();
            if(_Type.IsPublic) ".IsPublic".Write();
            if(_Type.IsSealed) ".IsSealed".Write();
            if(_Type.IsSecurityCritical) ".IsSecurityCritical".Write();
            if(_Type.IsSecuritySafeCritical) ".IsSecuritySafeCritical".Write();
            if(_Type.IsSecurityTransparent) ".IsSecurityTransparent".Write();
            if(_Type.IsSerializable) ".IsSerializable".Write();
            if(_Type.IsSpecialName) ".IsSpecialName".Write();
            if(_Type.IsUnicodeClass) ".IsUnicodeClass".Write();
            if(_Type.IsValueType) ".IsValueType".Write();
            if(_Type.IsVisible) ".IsVisible".Write();
            "".WriteLine();
            "//".WriteLine();
            #endregion
            #region Assembly
            _Type.Assembly.FullName.WriteLine();
            "//".WriteLine();
            #endregion
            #region GetMembers
            _Type.GetMembers(p__MyBindingFlags).Select(a=> a.MemberType.ToString() + " " + _Type.ToString() + "." + a.Name).ToList().WriteLine();
            "//".WriteLine();
            #endregion
            #region GetConstructors
            foreach (ConstructorInfo _ctor in _Type.GetConstructors(p__MyBindingFlags))
            {
                _ctor.GetCustomAttributes().Select(a => "[" + a.GetType().ToString() + "] ").ToList().WriteLine();
                (System.Reflection.MemberTypes.Constructor.ToString() + " ").Write();
                _ctor.Cast_As<MethodBase>().Set(a => {
                    if (a.IsPublic) "Public ".Write();
                    if (a.IsPrivate) "Private ".Write();
                    if (a.IsFamily) "Family ".Write();
                    if (a.IsAssembly) "Assembly ".Write();
                    if (a.IsStatic) "Static ".Write();
                    if (a.IsFinal) "Final ".Write();
                    if (a.IsVirtual) "Virtual ".Write();
                    if (a.IsHideBySig) "HideBySig ".Write();
                    if (a.IsAbstract) "Abstract ".Write();
                });
                (_Type.Name + "(").Write();
                System.String.Join(", ", _ctor.GetParameters().Select(a => (a.ParameterType.ToString() + " " + a.Name))).Write();
                ");".WriteLine();
            };
            "//".WriteLine();
            #endregion
            #region GetInterfaces
            _Type.GetInterfaces().Select(a => "Interface " + _Type.ToString() + ":" + a.ToString() + ";").ToList().WriteLine();
            #endregion
            #region GetMethods
            foreach (MethodInfo _method in _Type.GetMethods(p__MyBindingFlags))
            {
                _method.GetCustomAttributes().Select(a => "[" + a.GetType().ToString() + "] ").ToList().WriteLine();
                (System.Reflection.MemberTypes.Method.ToString() + " ").Write();
                _method.Cast_As<MethodBase>().Set(a => {
                    if (a.IsPublic) "Public ".Write();
                    if (a.IsPrivate) "Private ".Write();
                    if (a.IsFamily) "Family ".Write();
                    if (a.IsAssembly) "Assembly ".Write();
                    if (a.IsStatic) "Static ".Write();
                    if (a.IsFinal) "Final ".Write();
                    if (a.IsVirtual) "Virtual ".Write();
                    if (a.IsHideBySig) "HideBySig ".Write();
                    if (a.IsAbstract) "Abstract ".Write();
                });
                (_method.ReturnType.ToString() + " " + _Type.ToString() + "." + _method.Name + " (").Write();
                System.String.Join(", ", _method.GetParameters().Select(a => (a.ParameterType.ToString() + " " + a.Name))).Write();
                ");".WriteLine();
            }
            "//".WriteLine();
            #endregion
            #region GetFields
            foreach (FieldInfo _field in _Type.GetFields(p__MyBindingFlags))
            {
                _field.GetCustomAttributes().Select(a => "[" + a.GetType().ToString() + "] ").ToList().WriteLine();
                (System.Reflection.MemberTypes.Field.ToString() + " ").Write();
                if (_field.IsPublic) "Public ".Write();
                if (_field.IsPrivate) "Private ".Write();
                if (_field.IsFamily) "Family ".Write();
                if (_field.IsAssembly) "Assembly ".Write();
                if (_field.IsStatic) "Static ".Write();
                if (_field.IsInitOnly) "InitOnly ".Write();
                if (_field.IsLiteral) "Literal ".Write();
                if (_field.IsNotSerialized) "NotSerialized ".Write();
                if (_field.IsSpecialName) "SpecialName ".Write();
                if (_field.IsSpecialName) "IsSpecialName ".Write();
                (_field.FieldType + " " + _Type.ToString() + "." + _field.Name + " ").Write();
                if(_this != null)
                {
                    System.Object _GetValue = _field.GetValue(_this);
                    if (_GetValue == null) { ".=null".Write(); } else { (".=" + _GetValue.ToString()).Write(); }
                }
                ";".WriteLine();
            }
            "//".WriteLine();
            #endregion

            foreach (PropertyInfo _prop in _Type.GetProperties(p__MyBindingFlags))
            {
                _prop.GetCustomAttributes().Select(a => "[" + a.GetType().ToString() + "] ").ToList().WriteLine();
                (System.Reflection.MemberTypes.Property.ToString() + " " + _prop.PropertyType.ToString()
                    + " " + _Type.ToString() + "." + _prop.Name + " "
                ).Write();
                if (_prop.CanRead) "get ".Write();
                if (_prop.CanWrite) "set ".Write();
                if (_prop.CanRead && (_this != null))
                {
                    System.Object _GetValue = _prop.GetValue(_this);
                    if (_GetValue == null) { ".=null".Write(); } else { (".=" + _GetValue.ToString()).Write(); }
                }
            }
            return _this;
        }
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 28, _hour: 12, _minute: 47, _second: 0, _millisecond: 0)]
        public static void Test() 
        {
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            (new System.Set__Reflection_WriteThis_T.ClassForTest()).Set__Reflection_WriteThis();
        }
        /////////////////////////////////////////////////////////////////////////////////
        private class TestAtt : System.Attribute
        {
            private System.String p__String = "";
            public System.String p_String { get => this.p__String; set => this.p__String = value; }
            public TestAtt() { }
            public TestAtt(System.String _String = null) => this.Set(
                _String: _String
                )
            ;
            public TestAtt Set(
                TestAtt _this = null
                , System.String _String = null
            ) => this
                .SetIf(_this != null, a => this.Set(
                    _String: _String
                    )
                )
                .SetIf(_String != null, a => this.p_String = _String)
            ;
        }
        private interface IClassForTest
        {

            IClassForTest Set(Action<IClassForTest> x);
            void Foo(int i, int j, string str);
        }
        private class ClassForTest : IClassForTest
        {
            public IClassForTest Init()
            {
                return this;
            }
            public ClassForTest() { this.Init(); }
            //public ClassForTest(int i = 0, System.Boolean _flagan = false) { this.Init(); }
            public IClassForTest Set(Action<IClassForTest> x) { x(this); return this; }

            [TestAtt(_String: "Просто текст")]
            public void Foo(int i, int j, string str) { }
            #region ВООБЩЕ ВСЕ ПАРАМЕТРЫ И ПОЛЯ
            public System.String p__StringPublic { get { return p_StringPublic; } set { p_StringPublic = value; } }
            public System.String p_StringPublic = "Привет мир";
            private System.String p_StringPrivate = "Привет мир";

            public static System.String p_StringPublicStatic = "Привет мир";
            [TestAtt(_String: "Просто текст")]
            private static System.String p_StringPrivateStatic = "Привет мир";

            public IList<string> p_IListString = (new string[] { "Ghbdt vbh", "Ghbdtn vbh2" }).ToList<string>();
            public System.String[] p_ArrString = new string[] { "Arr Ghbdt vbh", "ArrGhbdtn vbh2" };

            public System.Boolean p_SystemBoolean = true;
            public System.Byte p_SystemByte = 0;
            public System.Char p_SystemChar = 'c';
            public System.Decimal p_SystemDecimal = 0;
            public System.Double p_SystemDouble = 0;
            public System.Int16 p_SystemInt16 = 0;
            [TestAtt(_String: "Просто текст")]
            public System.Int32 p_SystemInt32 = 0;
            public System.Int64 p_SystemInt64 = 0;
            public System.SByte p_SystemSByte = 0;
            public System.Single p_SystemSingle = 0;
            public System.String p_SystemString = "Привет мир";
            public System.UInt16 p_SystemUInt16 = 0;
            public System.UInt32 p_SystemUInt32 = 0;
            public System.UInt64 p_SystemUInt64 = 0;
            #endregion
        }
    }
}
