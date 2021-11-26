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
    //дело вот в чем Это серьёзный инструмент для взлома, и потому он не завязан на архитектуре приложения
    //!!!Этот код Нужно оставить как примен который не трогать не изменять не шатать!!!
    //А теперь мне плевать на всё это дело, и я дописываю к рефлексионеру пару ласковых комментариев
    //Если в будующем потребуется херачить опять одной страницей для Rasor, то опят сформируем один файл
    public static class Ext__Set_Writer
    {
        /// <summary> Отображает рефлексивную информацию объектов в консоль </summary>
        /// <param name="_Object">Изучаемый объект</param>
        /// <param name="_ObjectDescription"> Отображать только истиные флаги</param>
        /// <param name="_ObjectFullDescription"> Отобразить вообще все флаги </param>
        public static void Set_Writer(
            this Object _Object
            , System.Boolean _IsMemberInf = true
            , System.Boolean _IsMethodInf = true
            , System.Boolean _IsCtorInf = true
            , System.Boolean _IsFieldInf = true
            , System.Boolean _IsPropInf = true
            , System.Boolean _IsInterfacesInf = true
        ) => _Object.SetIf(_Object == null
                , a => " _Obj== null".WriteLine()
                , a => _Object.GetType().Set_Writer(_Object: _Object
                     , _IsMemberInf: _IsMemberInf
                     , _IsMethodInf: _IsMethodInf
                     , _IsCtorInf: _IsCtorInf
                     , _IsFieldInf: _IsFieldInf
                     , _IsPropInf: _IsPropInf
                     , _IsInterfacesInf: _IsInterfacesInf
                 )
            )
        ;
        public static System.Type Set_Writer(this System.Type _Type
            , System.Object _Object = null
            , System.Boolean _IsMemberInf = true
            , System.Boolean _IsMethodInf = true
            , System.Boolean _IsCtorInf = true
            , System.Boolean _IsFieldInf = true
            , System.Boolean _IsFieldAtt = true
            , System.Boolean _IsPropInf = true
            , System.Boolean _IsInterfacesInf = true
        ) => _Type.Set(a => a.ToString().WriteLine())
            .Set(a =>
                a.GetCustomAttributes(true).ToList()
                .Set(b => b.ForEach(c => ("[" + c.GetType().ToString() + "]").Write()))
                .SetIf(_fBool: b => b.Count > 0, _f1: b => "".WriteLine())
            )
            .SetIf(_Type.IsAbstract, a => ".IsAbstract".Write())
            .SetIf(_Type.IsAnsiClass, a => ".IsAnsiClass".Write())
            .SetIf(_Type.IsArray, a => ".IsArray".Write())
            .SetIf(_Type.IsAutoClass, a => ".IsAutoClass".Write())
            .SetIf(_Type.IsAutoLayout, a => ".IsAutoLayout".Write())
            .SetIf(_Type.IsByRef, a => ".IsByRef".Write())
            .SetIf(_Type.IsClass, a => ".IsClass".Write())
            .SetIf(_Type.IsCOMObject, a => ".IsCOMObject".Write())
            .SetIf(_Type.IsConstructedGenericType, a => ".IsConstructedGenericType".Write())
            .SetIf(_Type.IsContextful, a => ".IsContextful".Write())
            //.SetIf(_Type.IsDefined, a=>".".Write())
            .SetIf(_Type.IsEnum, a => ".IsEnum".Write())
            .SetIf(_Type.IsExplicitLayout, a => ".IsExplicitLayout".Write())
            .SetIf(_Type.IsGenericParameter, a => ".IsGenericParameter".Write())
            .SetIf(_Type.IsGenericType, a => ".IsGenericType".Write())
            .SetIf(_Type.IsGenericTypeDefinition, a => ".IsGenericTypeDefinition".Write())
            .SetIf(_Type.IsImport, a => ".IsImport".Write())
            .SetIf(_Type.IsInterface, a => ".IsInterface".Write())
            .SetIf(_Type.IsLayoutSequential, a => ".IsLayoutSequential".Write())
            .SetIf(_Type.IsMarshalByRef, a => ".IsMarshalByRef".Write())
            .SetIf(_Type.IsNested, a => ".IsNested".Write())
            .SetIf(_Type.IsNestedAssembly, a => ".IsNestedAssembly".Write())
            .SetIf(_Type.IsNestedFamANDAssem, a => ".IsNestedFamANDAssem".Write())
            .SetIf(_Type.IsNestedFamily, a => ".IsNestedFamily".Write())
            .SetIf(_Type.IsNestedFamORAssem, a => ".IsNestedFamORAssem".Write())
            .SetIf(_Type.IsNestedPrivate, a => ".IsNestedPrivate".Write())
            .SetIf(_Type.IsNestedPublic, a => ".IsNestedPublic".Write())
            .SetIf(_Type.IsNotPublic, a => ".IsNotPublic".Write())
            .SetIf(_Type.IsPointer, a => ".IsPointer".Write())
            .SetIf(_Type.IsPrimitive, a => ".IsPrimitive".Write())
            .SetIf(_Type.IsPublic, a => ".IsPublic".Write())
            .SetIf(_Type.IsSealed, a => ".IsSealed".Write())
            .SetIf(_Type.IsSecurityCritical, a => ".IsSecurityCritical".Write())
            .SetIf(_Type.IsSecuritySafeCritical, a => ".IsSecuritySafeCritical".Write())
            .SetIf(_Type.IsSecurityTransparent, a => ".IsSecurityTransparent".Write())
            .SetIf(_Type.IsSerializable, a => ".IsSerializable".Write())
            .SetIf(_Type.IsSpecialName, a => ".IsSpecialName".Write())
            .SetIf(_Type.IsUnicodeClass, a => ".IsUnicodeClass".Write())
            .SetIf(_Type.IsValueType, a => ".IsValueType".Write())
            .SetIf(_Type.IsVisible, a => ".IsVisible".Write())
            .Set(a => "".WriteLine())
            //////////////////////////////////////////////////////////////////////////            
            .Set(a=>a.Assembly.FullName.WriteLine())
            .SetIf(_IsMemberInf, a => a.Set_MemberInfo_Writer())
            .SetIf(_IsCtorInf, a => a.Set_ConstructorInfo_Writer())
            .SetIf(_IsInterfacesInf, a => a.Set_TypeInterfaces_Writer())
            .SetIf(_IsMethodInf, a => a.Set_MethodInfo_Writer())
            .SetIf(_IsFieldInf, a => a.Set_FieldInfo_Writer(_Object: _Object))
            .SetIf(_IsPropInf, a => a.Set_PropertyInfo_Writer(_Object: _Object))
            .Set(a => "".WriteLine().WriteLine())
        ;
        
        /// <summary>Component.Reflection.Ext_ReflectiOneR.Test();</summary>
        public static void Test()
        {
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            (new System.Diagnostics.Reflection.ClassForTest()).Set_Writer();
        }
    }
}