namespace System.Diagnostics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    ////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Анализатор стека вызова функций
    /// Итак, стек вызова функций. Два варианта реализации.
    /// Environment.StackTrace - получает строку.
    /// System.Diagnostics.StackTrace/System.Diagnostics.StackFrame - честно читайте, пережовывайте этот кал, там лажа полная.
    /// Со статичесикми функциями не работат. Багует, шлет всех на*** тоесть на Microsoft.com...
    /// 
    /// По этому пишим компонент для изымания имени текущей строки функции.
    /// </summary>
    public class StackTracer
    {
        public int p_StepBackShift = -1;
        public int p_BaseShift = 4;
        public IList<string> p_ILS = new List<string>();
        public string p_str_StackTrace = "";
        public StackTracer()
        {
            this.p_str_StackTrace = Environment.StackTrace;
            this.p_ILS = this.p_str_StackTrace.Split('\n').ToList<string>();
        }
        public StackTracer Set(System.Nullable<int> _StepBackShift = null, System.Nullable<int> _BaseShift = null)
        {
            if (_StepBackShift != null) this.p_StepBackShift = _StepBackShift.Value;
            if (_BaseShift != null) this.p_BaseShift = _BaseShift.Value;
            return this;
        }
        public static string Get_STS() => (new StackTracer() { p_StepBackShift = 0 }).Get_STSS();
        /// <summary> Возвращает строку функции в которой был вызван метод </summary>
        public string Get_STSS()
        {
            int _Shift = this.p_BaseShift + this.p_StepBackShift;
            if (this.p_ILS.Count > _Shift) return this.p_ILS[_Shift].Split('в')[1];
            throw new System.Exception("Component.StackTracer.Get_STSS() /n Eror");
        }
        /// <summary> Возвращает строку функции в которой был вызван метод </summary>
        
        public static implicit operator System.String(StackTracer _StackTracer) { return _StackTracer.Get_STSS(); }
        public StackTracer writeThis() { this.p_ILS.ToList().ForEach(a => System.Console.WriteLine(a)); return this; }
        /// <summary>
        /// Консольный тест.
        /// Консольные тесты пишутся так что при запуске модульных тестов можно перенаправить вывод в лог файлы
        /// System.Diagnostics.StackTracer.Test();
        /// </summary>
        public static void Test()
        {
            System.Console.WriteLine("Component.StackTracer Class");
            System.Console.WriteLine("Вот весь стек");
            (new StackTracer()).writeThis();
            System.Console.WriteLine("");
            System.Console.WriteLine((new StackTracer()).Get_STSS());
            System.Console.WriteLine("");
            System.Console.WriteLine(System.Diagnostics.StackTracer.Get_STS());
        }
    }
}