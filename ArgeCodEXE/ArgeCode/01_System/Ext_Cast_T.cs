namespace System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    ///////////////////////////////////////////////////////////
    /// <summary>
    /// Генетическое контекстно ориентированное расширение,
    /// добавляет к любому экземпляру объекта следующие функции.
    /// </summary>
    public static class Ext_Cast_T
    {
        /// <summary>Возвращает обертку экземпляра объекта в конкретный тип</summary>
        public static T Cast_As<T>(this System.Object _this) => (T)_this;
        /// <summary>Возвращает обертку обертку конкретного типа как объект</summary>
        public static System.Object Cast_AsObj<T>(this T _this) => (System.Object)_this;
        /// <summary>Пример использования</summary>
        public static void Test() 
        {
            "Привет мир".Cast_As<System.Object>();
            //Равносильно
            var Obj = ((System.Object)"Привет мир");
            "Привет мир".Cast_AsObj().Cast_As<System.String>();            
            //Равносильно
            System.String Str = ((System.String)(System.Object)"Привет мир");
            //Актуальность:
            //При небольших функциональных программных кодах классические обертки в духе
            // ((System.String)(System.Object)"Привет мир")
            //вполне уместны. Но как только речь заходит о чем-то более объемном Cast_As и Cast_AsObj экономит время 
            //при написании и повторном чтении/понимании программных кодов.
            //И дея позаимствована из LinQ_To_Object (только списки)
            // и распространена на все остальные случаи.
            // Расширяем граници применимости...
        }
    }
}
