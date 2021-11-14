namespace System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    ///////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////
    /// <summary>
    /// Генетическое контекстно ориентированное расширение,
    /// добавляет к любому экземпляру объекта следующие функции.
    /// </summary>
    public static class SetIf_T
    {
        /// <summary>Ветвление лямбда контекста</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_Bool">Если ветвление не через лямбда, а через System.Boolean то сюда</param>
        /// <param name="_f1">Лямбда на случай если истино</param>
        /// <param name="_f0">Лямбда на случай если ложно</param>
        /// <param name="_fBool">Если хотите ветвление по результату лямбда выражения</param>
        public static T SetIf<T>(
            this T _this
            , System.Nullable<System.Boolean> _Bool = null
            , System.Action<T> _f1 = null
            , System.Action<T> _f0 = null
            , System.Func<T,System.Boolean> _fBool = null
            )
        {
            System.Boolean _Boolean = false;
            if (_Bool != null) _Boolean = _Bool.Value;
            if (_fBool!=null) _Boolean = _fBool(_this);
            if (_Boolean)
            {
                if (_f1 != null) _f1(_this);
            }
            else
            {
                if (_f0 != null) _f0(_this);
            }
            return _this;
        }
        /// <summary>
        /// Пример использования:
        /// </summary>
        public static void Test() 
        {
            {
                System.Boolean _Boolean = true;
                _Boolean.SetIf(_Boolean, a => System.Console.WriteLine("<true>"), a => System.Console.WriteLine("<false>"));
                //Равносилен
                _Boolean.SetIf(_Bool:_Boolean, _f1: a => System.Console.WriteLine("<true>"), _f0: a => System.Console.WriteLine("<false>"));
                //Равносилен
                _Boolean.SetIf(_Bool: null, _f1: a => System.Console.WriteLine("<true>"), _f0: a => System.Console.WriteLine("<false>"), _fBool: a => a);
            }
            true.SetIf(_fBool: a => a, _f1: a => System.Console.WriteLine("<true>"), _f0: a => System.Console.WriteLine("<false>"));
            //Актуальность:
            //***Скептики могут усомниться "Изобретаем If заново".
            //Не скрою, да это так.
            //Мы шли от практической необходимости...
            //Статистика использования такова что .Set/.SetIf/.Get/.GetIf как 25/5/1/1 в долях на вскидку.
            //Хорошо что дело не дошло до изобретения цикла. Его изобрели до нас. Пример LinQToObject:
            (new string[] { "1", "2", "3" })
                .Set(b => b.ToList().ForEach(a => System.Console.WriteLine(a)))
                .Select(a => System.Int32.Parse(a))
                .OfType<System.Double>()
                .SetIf(_fBool:a=>a.Count()==0,_f0:a=>throw new System.Exception("Eror:20200806_2150:неудалось преобразовать к System.Double[]"))
                //Равностильно, только обработчик ошибо наш...
                .Cast<System.Double>()
                //...
            ;
            //Как видете, без детального изучения трудно отличить наши расширения языка
            //от стандартной библиотеки обработки списков LinQToObject.
            //
            //Следует заметить что .ForEach(a =>{}) обладает большей производительностью чем
            for (int i = 0; i < 100; i++) ; 
            foreach (var qwe in (new string[] { "1", "2", "3" })) ;
            //
        }
    }
}