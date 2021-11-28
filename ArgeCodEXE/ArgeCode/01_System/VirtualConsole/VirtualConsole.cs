using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.VConsole
{
    /// <summary>
    /// Прослойка виртуальной консоли.
    /// По умоляанию оно завязано через Паттрн шаблонный метод через лямбда выражения на обычной консоли.
    /// При желании можно создать версию, другой класс наследник, или этот класс с другими лямбдами
    /// Чтобы например сделать консоль для работы с батниками, с файлом или с удаленным сервером.
    /// Данная реализация классифицируется как топорная, простая в стиле комбинирруй предметы (носок + ручка = равно вертолет).
    /// Данная реализация классифицируется как достаточно гибкая, что бы не мучаться над её переписыванием боле.
    /// ///
    /// Данны й класс максимально разгружен.
    /// Все вспомогательные функции не зависят о реализации лямбда выражений и находятся в контекстно ориентированном окружении.
    /// Да, выглядит весьма грамоздко и медленно работающе, но в консоли скорость не нужна.
    /// Вывод на экран всегда занимал много больше времени.
    /// </summary>
    public class VirtualConsole
    {
        #region public ConsoleColor p_ForegroundColor {get;set;}
        public System.Func<ConsoleColor> ActGet_p_ForegroundColor = () => { return System.Console.ForegroundColor; };
        public System.Action<ConsoleColor> ActSet_p_ForegroundColor = _ConsoleColor => { System.Console.ForegroundColor = _ConsoleColor; };
        public ConsoleColor p_ForegroundColor { get => this.ActGet_p_ForegroundColor(); set => this.ActSet_p_ForegroundColor(value); }
        #endregion
        #region public ConsoleColor p_BackgroundColor {get;set;}
        public System.Func<ConsoleColor> ActGet_p_BackgroundColor = () => { return System.Console.BackgroundColor; };
        public System.Action<ConsoleColor> ActSet_p_BackgroundColor = _ConsoleColor => { System.Console.BackgroundColor = _ConsoleColor; };
        public ConsoleColor p_BackgroundColor { get => this.ActGet_p_BackgroundColor(); set => this.ActSet_p_BackgroundColor(value); }
        #endregion
        public VirtualConsole() { }
        #region public Write/WriteLine/ReadLine
        public Action<System.String> Act_WriteLine = _str =>{System.Console.WriteLine(_str);};
        public VirtualConsole WriteLine(System.String _str){ this.Act_WriteLine(_str); return this;}
        public Action<System.String> Act_Write = _str => { System.Console.Write(_str); };
        public VirtualConsole Write(System.String _str) { this.Act_Write(_str); return this; }
        public Func<System.String> Act_ReadLine = () => { return System.Console.ReadLine().Set(a => System.Threading.Tasks.Task.Delay(2000)); };
        public System.String ReadLine() {return this.Act_ReadLine(); }
        #endregion
    }
    public static class Ext_VirtualConsole
    {
        /// <summary>
        /// Лямбда контекст консоли по окончании которого цвет сбрасывается на стандартный
        /// Печать дико цветного текста в консоли  - операция не чатая, по этому
        /// вызываем консоль (например из System.VConsole.Config...), затем в её контексте передаем печатаем текст.
        /// </summary>
        public static VirtualConsole Set_(this VirtualConsole _this, System.Action<VirtualConsole> x) { x(_this); return _this.Set_Default(); }
        public static VirtualConsole Set_Color(this VirtualConsole _this, ConsoleColor _ForegroundColor, ConsoleColor _BackgroundColor)
        { _this.p_BackgroundColor = _BackgroundColor; _this.p_ForegroundColor = _ForegroundColor; return _this; }
        public static VirtualConsole Set_Default(this VirtualConsole _this) => _this.Set_Color(ConsoleColor.Gray, ConsoleColor.Black);
        public static VirtualConsole Set_Test(this VirtualConsole _this) => _this.Set_Color(ConsoleColor.Cyan, ConsoleColor.DarkRed);
        public static VirtualConsole Set_Exception(this VirtualConsole _this) => _this.Set_Color(ConsoleColor.Red, ConsoleColor.Black);
        public static VirtualConsole Set_DarkMagenta(this VirtualConsole _this) => _this.Set_Color(ConsoleColor.Green, ConsoleColor.DarkMagenta);
    }
    public static class Config
    {
        /// <summary>
        /// Синглтон виртуальной консоли
        /// System.VConsole.Config.p_VirtualConsole
        /// </summary>
        public static VirtualConsole p_VirtualConsole = new VirtualConsole();
    }
  
}
namespace System
{
    public static class Ext_WriteLine
    {
        public static System.String Write(this System.String _String)
        { System.VConsole.Config.p_VirtualConsole.Write(_String); return _String; }
        public static System.String WriteLine(this System.String _String)
        { System.VConsole.Config.p_VirtualConsole.WriteLine(_String); return _String; }
        public static List<System.String> WriteLine(this List<System.String> _StringS)
        { _StringS.ForEach(a => a.WriteLine());  return _StringS; }
        public static System.String ReadLine(this System.String _String)
        { return System.VConsole.Config.p_VirtualConsole.ReadLine(); }
    }
}