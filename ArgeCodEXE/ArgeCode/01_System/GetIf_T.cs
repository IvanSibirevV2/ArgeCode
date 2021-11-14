namespace System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    ////////////////////////////////////////////////////////////////
    /// <summary>
    /// Генетическое контекстно ориентированное расширение,
    /// добавляет к любому экземпляру объекта следующие функции.
    /// </summary>
    public static class GetIf_T
    {
        /// <summary>Ветвление лямбда контекста, с возвратом значения</summary>
        public static T1 GetIf<T, T1>(
            this T _this
            , System.Nullable<System.Boolean> _Bool = null
            , System.Func<T,T1> _f1 = null
            , System.Func<T, T1> _f0 = null
            , System.Func<T, System.Boolean> _fBool = null
        )
        {
            System.Boolean _Boolean = false;
            if (_Bool != null) _Boolean = _Bool.Value;
            if (_fBool != null) _Boolean = _fBool(_this);
            if (_Boolean)
            {
                if (_f1 != null) return _f1(_this);
            }
            else
            {
                if (_f0 != null) return _f0(_this);
            }
            System.Func<T, T1> _fail = null;
            return _fail(_this);
        }
        /// <summary>Пример с использованием</summary>
        public static void Test() 
        {
            { 
                System.Boolean _Boolean = true;
                System.Console.WriteLine(_Boolean.GetIf(_Boolean, a => "<true>", a => "<false>"));
                //Равносилен
                System.Console.WriteLine(_Boolean.GetIf(_Bool: _Boolean, _f1: a => "<true>", _f0: a => "<false>"));
                //Равносилен
                System.Console.WriteLine(_Boolean.GetIf(_Bool: null, _f1: a => "<true>", _f0: a => "<false>",_fBool:a=>a));
            }
            System.Console.WriteLine(true.GetIf(_fBool:a=>a,_f1: a => "<true>", _f0: a => "<false>"));
            //Актуальность:
            //Данная функция - гибрид .Get(a =>...) и .SetIf<T>(_Bool:...,_f1:...,_f0:...,_fBool:...)
            //и аргонично заполняет бреш в функциональных программных кодах.
        }
    }
}