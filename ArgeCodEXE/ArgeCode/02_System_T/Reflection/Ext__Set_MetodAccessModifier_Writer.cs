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
    public static class Ext__Set_MetodAccessModifier_Writer
    {
        /// <summary>Возвращает в скриптовую консоль доступные модификаторы доступа</summary><returns>Возвращение с продолжением</returns>
        public static System.Reflection.MethodBase Set_MetodAccessModifier_Writer(this System.Reflection.MethodBase a) => a
            .SetIf(a.IsPublic, b => "Public ".Write())
            .SetIf(a.IsPrivate, b => "Private ".Write())
            .SetIf(a.IsFamily, b => "Family ".Write())
            .SetIf(a.IsAssembly, b => "Assembly ".Write())
            .SetIf(a.IsStatic, b => "Static ".Write())
            .SetIf(a.IsFinal, b => "Final ".Write())
            .SetIf(a.IsVirtual, b => "Virtual ".Write())
            .SetIf(a.IsHideBySig, b => "HideBySig ".Write())
            .SetIf(a.IsAbstract, b => "Abstract ".Write())
        ;
    }
}
