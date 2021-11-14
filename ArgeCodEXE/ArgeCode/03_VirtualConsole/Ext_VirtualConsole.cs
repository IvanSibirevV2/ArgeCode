using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.VConsole
{
    public static class Ext_VirtualConsole
    {
        /// <summary>
        /// Лямбда контекст консоли по окончании которого цвет сбрасывается на стандартный
        /// Печать дико цветного текста в консоли  - операция не чатая, по этому
        /// вызываем консоль (например из System.VConsole.Config...), затем в её контексте передаем печатаем текст.
        /// </summary>
        public static VirtualConsole Set_(this VirtualConsole _this, System.Action<VirtualConsole> x) { x(_this); return _this.Set_Default(); }
        public static  VirtualConsole Set_Color(this VirtualConsole _this, ConsoleColor _ForegroundColor, ConsoleColor _BackgroundColor)
        {_this.p_BackgroundColor = _BackgroundColor;_this.p_ForegroundColor = _ForegroundColor;return _this;}
        public static VirtualConsole Set_Default(this VirtualConsole _this) => _this.Set_Color(ConsoleColor.Gray, ConsoleColor.Black);
        public static VirtualConsole Set_Test(this VirtualConsole _this) => _this.Set_Color(ConsoleColor.Cyan, ConsoleColor.DarkRed);
        public static VirtualConsole Set_Exception(this VirtualConsole _this) => _this.Set_Color(ConsoleColor.Red, ConsoleColor.Black);
        public static VirtualConsole Set_DarkMagenta(this VirtualConsole _this) => _this.Set_Color(ConsoleColor.Green, ConsoleColor.DarkMagenta);
    }
}
