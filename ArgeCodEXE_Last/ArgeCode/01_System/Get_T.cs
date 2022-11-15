namespace System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    //////////////////////////////////////////////////////////
    /// <summary>
    /// Генетическое контекстно ориентированное расширение,
    /// добавляет к любому экземпляру объекта следующие функции.
    /// </summary>
    public static class Get_T
    {
        /// <summary>Возвращает результат исполнения лямбда контекста для любого экземпляра или конкретного типа</summary>
        public static T1 Get<T, T1>(this T _this, System.Func<T, T1> x) { return x(_this); }
        /// <summary>
        /// Пример использования:
        /// System.Get_T.Test();
        /// </summary>
        public static void Test() 
        {
            System.Console.WriteLine(
                (6).Cast_AsObj().Cast_As<System.Int32>()
                    .Get(a => "System.Int32=<" + a.ToString()+">")
            )
            ;
            //Актуальность:
            //Используется для конвертирования и преобразования результата исполнения одной функций или цепочки функций
            //Если короче, то позволяет вернуть именно то что нужно Вам.
        }
    }
}