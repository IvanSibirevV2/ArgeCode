namespace Component.Reflection.BasicExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    //////////////////////////////////////////////////////////////////////////////
    using System.Reflection;
    //////////////////////////////////////////////////////////////////////////////
    //дело вот в чем Это серьёзный инструмент для взлома, и потому он не завязан на архитектуре приложения
    //!!!Этот код Нужно оставить как примен который не трогать не изменять не шатать!!!
    public static class Ext_ReflectiOneR
    {
        /// <summary> Отображает рефлексивную информацию объектов в консоль </summary>
        /// <param name="_Object">Изучаемый объект</param>
        /// <param name="_ObjectDescription"> Отображать только истиные флаги</param>
        /// <param name="_ObjectFullDescription"> Отобразить вообще все флаги </param>
        public static void Set_Writer(
            this Object _Object
            , Component.ConsoleR.IConsoleR _IConsoleR = null
            , System.Boolean _IsNeedMemberInfo = true
            , System.Boolean _IsNeedMethodInfo = true
            , System.Boolean _IsNeedConstructorInfo = true
            , System.Boolean _IsNeedFieldInfo = true
            , System.Boolean _IsNeedPropertyInfo = true
            , System.Boolean _IsNeedTypeInterfaces = true
        )
        {
            if (_IConsoleR == null) _IConsoleR = new Component.ConsoleR.ConsoleR_Base();
            if (_Object == null) { _IConsoleR.WriteLine(" _Obj== null"); }
            else
            {
                _Object.GetType().Set_Writer(_Object: _Object
                    , _IConsoleR: _IConsoleR
                    , _IsMemberInf: _IsNeedMemberInfo
                    , _IsMethodInf: _IsNeedMethodInfo
                    , _IsCtorInf: _IsNeedConstructorInfo
                    , _IsFieldInf: _IsNeedFieldInfo
                    , _IsPropInf: _IsNeedPropertyInfo
                    , _IsInterfacesInf: _IsNeedTypeInterfaces
                );
            }
        }
        public static System.Type Set_Writer(this System.Type _Type
            , System.Object _Object = null
            , Component.ConsoleR.IConsoleR _IConsoleR = null
            , System.Boolean _IsMemberInf = true
            , System.Boolean _IsMethodInf = true
            , System.Boolean _IsCtorInf = true
            , System.Boolean _IsFieldInf = true
            , System.Boolean _IsPropInf = true
            , System.Boolean _IsInterfacesInf = true
        )
        {
            if (_IConsoleR == null) _IConsoleR = new Component.ConsoleR.ConsoleR_Base();
            _IConsoleR.WriteLine(_Type.ToString());
            System.Action<System.Boolean, System.String> _TryReadCast = (System.Boolean _Boolean, System.String _String) =>{if (_Boolean) _IConsoleR.Write(_String);};
            { 
                _TryReadCast(_Type.IsAbstract, ".IsAbstract");
                _TryReadCast(_Type.IsAnsiClass, ".IsAnsiClass");
                _TryReadCast(_Type.IsArray, ".IsArray");
                _TryReadCast(_Type.IsAutoClass, ".IsAutoClass");
                _TryReadCast(_Type.IsAutoLayout, ".IsAutoLayout");
                _TryReadCast(_Type.IsByRef, ".IsByRef");
                _TryReadCast(_Type.IsClass, ".IsClass");
                _TryReadCast(_Type.IsCOMObject, ".IsCOMObject");
                _TryReadCast(_Type.IsConstructedGenericType, ".IsConstructedGenericType");
                _TryReadCast(_Type.IsContextful , ".IsContextful");
                //_TryReadCast(_Type.IsDefined, ".");
                _TryReadCast(_Type.IsEnum, ".IsEnum");
                _TryReadCast(_Type.IsExplicitLayout, ".IsExplicitLayout");
                _TryReadCast(_Type.IsGenericParameter , ".IsGenericParameter");
                _TryReadCast(_Type.IsGenericType, ".IsGenericType");
                _TryReadCast(_Type.IsGenericTypeDefinition, ".IsGenericTypeDefinition");
                _TryReadCast(_Type.IsImport, ".IsImport");
                _TryReadCast(_Type.IsInterface, ".IsInterface");
                _TryReadCast(_Type.IsLayoutSequential , ".IsLayoutSequential");
                _TryReadCast(_Type.IsMarshalByRef, ".IsMarshalByRef");
                _TryReadCast(_Type.IsNested, ".IsNested");
                _TryReadCast(_Type.IsNestedAssembly, ".IsNestedAssembly");
                _TryReadCast(_Type.IsNestedFamANDAssem, ".IsNestedFamANDAssem");
                _TryReadCast(_Type.IsNestedFamily, ".IsNestedFamily");
                _TryReadCast(_Type.IsNestedFamORAssem, ".IsNestedFamORAssem");
                _TryReadCast(_Type.IsNestedPrivate, ".IsNestedPrivate");
                _TryReadCast(_Type.IsNestedPublic, ".IsNestedPublic");
                _TryReadCast(_Type.IsNotPublic, ".IsNotPublic");
                _TryReadCast(_Type.IsPointer, ".IsPointer");
                _TryReadCast(_Type.IsPrimitive, ".IsPrimitive");
                _TryReadCast(_Type.IsPublic, ".IsPublic");
                _TryReadCast(_Type.IsSealed, ".IsSealed");
                _TryReadCast(_Type.IsSecurityCritical, ".IsSecurityCritical");
                _TryReadCast(_Type.IsSecuritySafeCritical, ".IsSecuritySafeCritical");
                _TryReadCast(_Type.IsSecurityTransparent, ".IsSecurityTransparent");
                _TryReadCast(_Type.IsSerializable, ".IsSerializable");
                _TryReadCast(_Type.IsSpecialName, ".IsSpecialName");
                _TryReadCast(_Type.IsUnicodeClass , ".IsUnicodeClass");
                _TryReadCast(_Type.IsValueType, ".IsValueType");
                _TryReadCast(_Type.IsVisible, ".IsVisible");
            }
            _IConsoleR.WriteLine("");
            return _Type
                .Set_MemberInfo_Writer(_IsMemberInf: _IsMemberInf, _IConsoleR: _IConsoleR)
                .Set_ConstructorInfo_Writer(_IsCtorInf: _IsCtorInf, _IConsoleR: _IConsoleR)
                .Set_TypeInterfaces_Writer(_IsInterfacesInf: _IsInterfacesInf, _IConsoleR: _IConsoleR)
                .Set_MethodInfo_Writer(_IsMethodInf: _IsMethodInf, _IConsoleR: _IConsoleR)
                .Set_FieldInfo_Writer(_Object: _Object,_IsFieldInf: _IsFieldInf, _IConsoleR: _IConsoleR)
                .Set_PropertyInfo_Writer(_Object: _Object, _IsPropertyInf: _IsPropInf, _IConsoleR: _IConsoleR)
                .Set(a => _IConsoleR.WriteLine("").WriteLine(""))                
            ;
        }
        /// <summary>  Выводит в консоль поверхностную информацию о членах класса </summary><returns>Возвращение с продолжением</returns>
        public static System.Type Set_MemberInfo_Writer(this System.Type _Type
            , Component.ConsoleR.IConsoleR _IConsoleR = null
            , System.Boolean _IsMemberInf = true 
        )
        {
            if (_IsMemberInf)
            {
                if (_IConsoleR == null) _IConsoleR = new Component.ConsoleR.ConsoleR_Base();
                foreach (MemberInfo mi in _Type.GetMembers(
                    BindingFlags.Default | BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy | BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty | BindingFlags.ExactBinding | BindingFlags.SuppressChangeType | BindingFlags.OptionalParamBinding | BindingFlags.IgnoreReturn
                ))
                    _IConsoleR.Write(mi.MemberType.ToString() + " ").WriteLine(_Type.ToString() + "."+ mi.Name );
                _IConsoleR.WriteLine("...");
            }
            return _Type;
        }
        public static System.Type Set_MethodInfo_Writer(this System.Type _Type
            , Component.ConsoleR.IConsoleR _IConsoleR = null
            , System.Boolean _IsMethodInf = true
            )
        {
            if (_IsMethodInf)
            {
                if (_IConsoleR == null) _IConsoleR = new Component.ConsoleR.ConsoleR_Base();
                //Component.Consoller.Settings.Test(() => { "Методы:".WriteLine(); });
                foreach (MethodInfo method in _Type.GetMethods(
                    BindingFlags.Default | BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy | BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty | BindingFlags.ExactBinding | BindingFlags.SuppressChangeType | BindingFlags.OptionalParamBinding | BindingFlags.IgnoreReturn
                ))
                {
                    _IConsoleR.Write(System.Reflection.MemberTypes.Method.ToString() + " ");
                    ((MethodBase) method).Set_AccessModifier_Writer();
                    _IConsoleR.Write(method.ReturnType.ToString() + " "+ _Type.ToString() + "." + method.Name + " (");
                    ParameterInfo[] parameters = method.GetParameters();//получаем все параметры
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        _IConsoleR.Write(parameters[i].ParameterType.ToString() + " " + parameters[i].Name);
                        if (i + 1 < parameters.Length) _IConsoleR.Write(", ");
                    }
                    _IConsoleR.Write(")").WriteLine(";");
                }
            }
            return _Type;
        }
        /// <summary>Возвращает в скриптовую консоль доступные модификаторы доступа</summary><returns>Возвращение с продолжением</returns>
        public static System.Reflection.MethodBase Set_AccessModifier_Writer(this System.Reflection.MethodBase _this_MethodBase
            , Component.ConsoleR.IConsoleR _IConsoleR = null
            )
        {
            if (_IConsoleR == null) _IConsoleR = new Component.ConsoleR.ConsoleR_Base();
            if (_this_MethodBase.IsPublic) _IConsoleR.Write("Public ");
            if (_this_MethodBase.IsPrivate) _IConsoleR.Write("Private ");
            if (_this_MethodBase.IsFamily) _IConsoleR.Write("Family ");
            if (_this_MethodBase.IsAssembly) _IConsoleR.Write("Assembly ");
            if (_this_MethodBase.IsStatic) _IConsoleR.Write("Static ");
            if (_this_MethodBase.IsFinal) _IConsoleR.Write("Final ");
            if (_this_MethodBase.IsVirtual) _IConsoleR.Write("Virtual ");
            if (_this_MethodBase.IsHideBySig) _IConsoleR.Write("HideBySig ");
            if (_this_MethodBase.IsAbstract) _IConsoleR.Write("Abstract ");
            return _this_MethodBase;
        }
        public static System.Type Set_ConstructorInfo_Writer(this System.Type _Type
            , Component.ConsoleR.IConsoleR _IConsoleR = null
            , System.Boolean _IsCtorInf = true
            )
        {
            if (_IsCtorInf)
            {
                if (_IConsoleR == null) _IConsoleR = new Component.ConsoleR.ConsoleR_Base();
                foreach (ConstructorInfo ctor in _Type.GetConstructors(
                    BindingFlags.Default | BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy | BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty | BindingFlags.ExactBinding | BindingFlags.SuppressChangeType | BindingFlags.OptionalParamBinding | BindingFlags.IgnoreReturn
                ))
                {
                    _IConsoleR.Write(System.Reflection.MemberTypes.Constructor.ToString() + " ");
                    ((MethodBase)ctor).Set_AccessModifier_Writer();
                    _IConsoleR.Write(_Type.Name + " (");
                    ParameterInfo[] parameters = ctor.GetParameters();
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        _IConsoleR.Write(parameters[i].ParameterType.ToString() + " " + parameters[i].Name);
                        if (i + 1 < parameters.Length)
                            _IConsoleR.Write(", ");
                    }
                    _IConsoleR.Write(")").WriteLine(";");
                }
            }
            return _Type;
        }
        public static System.Type Set_FieldInfo_Writer(this System.Type _Type
            , System.Object _Object = null
            , Component.ConsoleR.IConsoleR _IConsoleR = null
            , System.Boolean _IsFieldInf = true
            )
        {
            if (_IsFieldInf)
            {
                if (_IConsoleR == null) _IConsoleR = new Component.ConsoleR.ConsoleR_Base();
                //Component.Consoller.Settings.Test(() => { "Поля:".WriteLine(); });
                foreach (FieldInfo _field in _Type.GetFields(  
                    BindingFlags.Default | BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy | BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty | BindingFlags.ExactBinding | BindingFlags.SuppressChangeType | BindingFlags.OptionalParamBinding | BindingFlags.IgnoreReturn
                ))
                {
                    _IConsoleR.Write(System.Reflection.MemberTypes.Field.ToString() + " ");
                    if (_field.IsPublic) _IConsoleR.Write("Public ");
                    if (_field.IsPrivate) _IConsoleR.Write("Private ");
                    if (_field.IsFamily) _IConsoleR.Write("Family ");
                    if (_field.IsAssembly) _IConsoleR.Write("Assembly ");
                    if (_field.IsStatic) _IConsoleR.Write("Static ");
                    if (_field.IsInitOnly) _IConsoleR.Write("InitOnly ");
                    if (_field.IsLiteral) _IConsoleR.Write("Literal ");
                    if (_field.IsNotSerialized) _IConsoleR.Write("NotSerialized ");
                    if (_field.IsSpecialName) _IConsoleR.Write("SpecialName ");
                    if (_field.IsSpecialName) _IConsoleR.Write("IsSpecialName ");
                    _IConsoleR.Write(_field.FieldType + " ");
                    _IConsoleR.Write(_Type.ToString() + ".");
                    _IConsoleR.Write(_field.Name + " ");
                    if (_Object != null)
                    {
                        System.Object _GetValue = _field.GetValue(_Object);
                        if (_GetValue == null) { _IConsoleR.Write(".=null"); } else { _IConsoleR.Write(".=" + _GetValue.ToString()); }
                    }
                    _IConsoleR.WriteLine(";");
                }
            }
            return _Type;
        }
        public static System.Type Set_PropertyInfo_Writer(this System.Type _Type
            ,System.Object _Object = null
            , Component.ConsoleR.IConsoleR _IConsoleR = null
            , System.Boolean _IsPropertyInf = true
            )
        {
            if (_IsPropertyInf)
            {
                if (_IConsoleR == null) _IConsoleR = new Component.ConsoleR.ConsoleR_Base();
                //Component.Consoller.Settings.Test(() => { "Свойства:".WriteLine(); });

                foreach (PropertyInfo _prop in _Type.GetProperties(
                    BindingFlags.Default| BindingFlags.IgnoreCase| BindingFlags.DeclaredOnly| BindingFlags.Instance| BindingFlags.Static| BindingFlags.Public| BindingFlags.NonPublic| BindingFlags.FlattenHierarchy| BindingFlags.InvokeMethod| BindingFlags.CreateInstance| BindingFlags.GetField| BindingFlags.SetField| BindingFlags.GetProperty| BindingFlags.SetProperty| BindingFlags.PutDispProperty| BindingFlags.PutRefDispProperty| BindingFlags.ExactBinding| BindingFlags.SuppressChangeType| BindingFlags.OptionalParamBinding| BindingFlags.IgnoreReturn
                    ))
                {
                    //С пропертями все туго, анализ модификаторов доступа не предусмотрен
                    _IConsoleR.Write(System.Reflection.MemberTypes.Property.ToString() + " ")
                        .Write(_prop.PropertyType.ToString() + " ")
                        .Write(_Type.ToString() + ".")
                        .Write(_prop.Name + " ");
                    if(_prop.CanRead) _IConsoleR.Write("get ");
                    if (_prop.CanWrite) _IConsoleR.Write("set ");
                    if (_prop.CanRead)
                    {
                        if (_Object != null)
                        {
                            System.Object _GetValue = _prop.GetValue(_Object);
                            if (_GetValue == null) { _IConsoleR.Write(".=null"); } else { _IConsoleR.Write(".=" + _GetValue.ToString()); }
                        }
                    }
                    _IConsoleR.WriteLine(";");
                }
            }
            return _Type;
        }
        public static System.Type Set_TypeInterfaces_Writer(this System.Type _Type
            , Component.ConsoleR.IConsoleR _IConsoleR = null
            , System.Boolean _IsInterfacesInf = true
            )
        {
            if (_IsInterfacesInf)
            {
                if (_IConsoleR == null) _IConsoleR = new Component.ConsoleR.ConsoleR_Base();
                foreach (System.Type i in _Type.GetInterfaces())//Только так ... и это МакросоФаг =) 
                    
                    _IConsoleR.WriteLine("Interface "+_Type.ToString() + ":"+i.ToString() + ";");
            }
            return _Type;
        }
        /// <summary>Component.Reflection.Ext_ReflectiOneR.Test();</summary>
        public static void Test()
        {
            Component.StaticC.CheckStackTracer();
            (new Component.Reflection.ClassForTest()).Set_Writer();
        }
    }
}