using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.CMD.NirCMD
{
    public static class Ext_NirCMDoor
    {
        public static string NircmdSendkeypress(this string _this,string _str) => _this.Add("nircmd sendkeypress ").Add(_str).NR();
        public static string MousBtnLeft(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x01").Add((_str != null) ? _str : "").NR();
        public static string MousBtnRight(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x02").Add((_str != null) ? _str : "").NR();
        public static string MousBtnMiddle(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x04").Add((_str != null) ? _str : "").NR();
        public static string Backspace(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x08").Add((_str != null) ? _str : "").NR();
        public static string Tab(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x09").Add((_str != null) ? _str : "").NR();
        public static string Enter(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x0D").Add((_str != null) ? _str : "").NR();
        public static string Shift(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x10").Add((_str != null) ? _str : "").NR();
        public static string Ctrl(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x11").Add((_str != null) ? _str : "").NR();
        public static string Alt(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x12").Add((_str != null) ? _str : "").NR();
        public static string Pause(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x13").Add((_str != null) ? _str : "").NR();
        public static string CapsLock(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x14").Add((_str != null) ? _str : "").NR();
        public static string Escape(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x1B").Add((_str != null) ? _str : "").NR();
        public static string Space(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x20").Add((_str != null) ? _str : "").NR();
        public static string PageUp(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x21").Add((_str != null) ? _str : "").NR();
        public static string PageDown(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x22").Add((_str != null) ? _str : "").NR();
        public static string End(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x23").Add((_str != null) ? _str : "").NR();
        public static string Home(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x24").Add((_str != null) ? _str : "").NR();
        public static string Insert(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x2D").Add((_str != null) ? _str : "").NR();
        public static string Delete(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x2E").Add((_str != null) ? _str : "").NR();
        public static string Win(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x5B").Add((_str != null) ? _str : "").NR();
        public static string WinRight(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x5C").Add((_str != null) ? _str : "").NR();
        public static string KeyApplication(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x5D").Add((_str != null) ? _str : "").NR();
        public static string ScrollLock(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x91").Add((_str != null) ? _str : "").NR();
        public static string PrintScreen(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x9A").Add((_str != null) ? _str : "").NR();
        public static string СommaPoint(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0xBA").Add((_str != null) ? _str : "").NR();
        public static string EQUally(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0xBB").Add((_str != null) ? _str : "").NR();
        public static string Сomma(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0xBC").Add((_str != null) ? _str : "").NR();
        public static string Minus(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0xBD").Add((_str != null) ? _str : "").NR();
        public static string Dot(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0xBE").Add((_str != null) ? _str : "").NR();
        public static string Slash(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0xBF").Add((_str != null) ? _str : "").NR();
        public static string Tilda(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0xC0").Add((_str != null) ? _str : "").NR();
        public static string SqueaBraketBegin(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0xDB").Add((_str != null) ? _str : "").NR();
        public static string UnSlash(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0xDC").Add((_str != null) ? _str : "").NR();
        public static string SqueaBraketEnd(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0xDD").Add((_str != null) ? _str : "").NR();
        public static string MarkUno(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0xDE").Add((_str != null) ? _str : "").NR();
        public static string ArrowLeft(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x25").Add((_str != null) ? _str : "").NR();
        public static string ArrowUp(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x26").Add((_str != null) ? _str : "").NR();
        public static string ArrowRight(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x27").Add((_str != null) ? _str : "").NR();
        public static string ArrowDown(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x28").Add((_str != null) ? _str : "").NR();
        public static string _0(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0").Add((_str != null) ? _str : "").NR();
        public static string _1(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 1").Add((_str != null) ? _str : "").NR();
        public static string _2(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 2").Add((_str != null) ? _str : "").NR();
        public static string _3(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 3").Add((_str != null) ? _str : "").NR();
        public static string _4(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 4").Add((_str != null) ? _str : "").NR();
        public static string _5(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 5").Add((_str != null) ? _str : "").NR();
        public static string _6(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 6").Add((_str != null) ? _str : "").NR();
        public static string _7(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 7").Add((_str != null) ? _str : "").NR();
        public static string _8(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 8").Add((_str != null) ? _str : "").NR();
        public static string _9(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 9").Add((_str != null) ? _str : "").NR();
        public static string A(this string _this,string _str=null) => _this.Add("nircmd sendkeypress a").Add((_str != null) ? _str : "").NR();
        public static string B(this string _this,string _str=null) => _this.Add("nircmd sendkeypress b").Add((_str != null) ? _str : "").NR();
        public static string C(this string _this,string _str=null) => _this.Add("nircmd sendkeypress c").Add((_str != null) ? _str : "").NR();
        public static string D(this string _this,string _str=null) => _this.Add("nircmd sendkeypress d").Add((_str != null) ? _str : "").NR();
        public static string E(this string _this,string _str=null) => _this.Add("nircmd sendkeypress e").Add((_str != null) ? _str : "").NR();
        public static string F(this string _this,string _str=null) => _this.Add("nircmd sendkeypress f").Add((_str != null) ? _str : "").NR();
        public static string G(this string _this,string _str=null) => _this.Add("nircmd sendkeypress g").Add((_str != null) ? _str : "").NR();
        public static string H(this string _this,string _str=null) => _this.Add("nircmd sendkeypress h").Add((_str != null) ? _str : "").NR();
        public static string I(this string _this,string _str=null) => _this.Add("nircmd sendkeypress i").Add((_str != null) ? _str : "").NR();
        public static string J(this string _this,string _str=null) => _this.Add("nircmd sendkeypress j").Add((_str != null) ? _str : "").NR();
        public static string K(this string _this,string _str=null) => _this.Add("nircmd sendkeypress k").Add((_str != null) ? _str : "").NR();
        public static string L(this string _this,string _str=null) => _this.Add("nircmd sendkeypress l").Add((_str != null) ? _str : "").NR();
        public static string M(this string _this,string _str=null) => _this.Add("nircmd sendkeypress m").Add((_str != null) ? _str : "").NR();
        public static string N(this string _this,string _str=null) => _this.Add("nircmd sendkeypress n").Add((_str != null) ? _str : "").NR();
        public static string O(this string _this,string _str=null) => _this.Add("nircmd sendkeypress o").Add((_str != null) ? _str : "").NR();
        public static string P(this string _this,string _str=null) => _this.Add("nircmd sendkeypress p").Add((_str != null) ? _str : "").NR();
        public static string Q(this string _this,string _str=null) => _this.Add("nircmd sendkeypress q").Add((_str != null) ? _str : "").NR();
        public static string R(this string _this,string _str=null) => _this.Add("nircmd sendkeypress r").Add((_str != null) ? _str : "").NR();
        public static string S(this string _this,string _str=null) => _this.Add("nircmd sendkeypress s").Add((_str != null) ? _str : "").NR();
        public static string T(this string _this,string _str=null) => _this.Add("nircmd sendkeypress t").Add((_str != null) ? _str : "").NR();
        public static string U(this string _this,string _str=null) => _this.Add("nircmd sendkeypress u").Add((_str != null) ? _str : "").NR();
        public static string V(this string _this,string _str=null) => _this.Add("nircmd sendkeypress v").Add((_str != null) ? _str : "").NR();
        public static string W(this string _this,string _str=null) => _this.Add("nircmd sendkeypress w").Add((_str != null) ? _str : "").NR();
        public static string X(this string _this,string _str=null) => _this.Add("nircmd sendkeypress x").Add((_str != null) ? _str : "").NR();
        public static string Y(this string _this,string _str=null) => _this.Add("nircmd sendkeypress y").Add((_str != null) ? _str : "").NR();
        public static string Z(this string _this,string _str=null) => _this.Add("nircmd sendkeypress z").Add((_str != null) ? _str : "").NR();
        public static string NumPad0(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x60").Add((_str != null) ? _str : "").NR();
        public static string NumPad1(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x61").Add((_str != null) ? _str : "").NR();
        public static string NumPad2(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x62").Add((_str != null) ? _str : "").NR();
        public static string NumPad3(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x63").Add((_str != null) ? _str : "").NR();
        public static string NumPad4(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x64").Add((_str != null) ? _str : "").NR();
        public static string NumPad5(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x65").Add((_str != null) ? _str : "").NR();
        public static string NumPad6(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x66").Add((_str != null) ? _str : "").NR();
        public static string NumPad7(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x67").Add((_str != null) ? _str : "").NR();
        public static string NumPad8(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x68").Add((_str != null) ? _str : "").NR();
        public static string NumPad9(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x69").Add((_str != null) ? _str : "").NR();
        public static string NumPadStar(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x6A").Add((_str != null) ? _str : "").NR();
        public static string NumPadPlas(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x6B").Add((_str != null) ? _str : "").NR();
        public static string NumPadMinus(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x6D").Add((_str != null) ? _str : "").NR();
        public static string NumPadDot(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x6E").Add((_str != null) ? _str : "").NR();
        public static string NumPadSlash(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x6F").Add((_str != null) ? _str : "").NR();
        public static string NumLock(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x90").Add((_str != null) ? _str : "").NR();
        public static string F1(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x70").Add((_str != null) ? _str : "").NR();
        public static string F2(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x71").Add((_str != null) ? _str : "").NR();
        public static string F3(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x72").Add((_str != null) ? _str : "").NR();
        public static string F4(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x73").Add((_str != null) ? _str : "").NR();
        public static string F5(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x74").Add((_str != null) ? _str : "").NR();
        public static string F6(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x75").Add((_str != null) ? _str : "").NR();
        public static string F7(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x76").Add((_str != null) ? _str : "").NR();
        public static string F8(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x77").Add((_str != null) ? _str : "").NR();
        public static string F9(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x78").Add((_str != null) ? _str : "").NR();
        public static string F10(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x79").Add((_str != null) ? _str : "").NR();
        public static string F11(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x7A").Add((_str != null) ? _str : "").NR();
        public static string F12(this string _this,string _str=null) => _this.Add("nircmd sendkeypress 0x7A").Add((_str != null) ? _str : "").NR();
        public static string Setcursor(this string _this,int x,int y) => _this.Add("nircmd setcursor ".Add(x.ToString()).Add(" ").Add(y.ToString())).NR();
        public static string Movecursor(this string _this, int x, int y) => _this.Add("nircmd movecursor ".Add(x.ToString()).Add(" ").Add(y.ToString())).NR();
        public static string Wait(this string _this, int x=25) => _this.Add("nircmd wait ".Add(x.ToString())).NR();
        public static string NirCMDoor_Run(this string _this, int x = 25) 
        {
            if (!System.IO.File.Exists("nircmd.exe")) ""
                .Set(a => "Требуемый Компонент не найден. Начинаю дозагрузку...".WriteLine())
                .Set(a => "Источник https://github.com/IvanSibirevV2/HowTo_NirCmd.git".WriteLine())
                .Set(a => "Буду скачивать nircmd.exe".WriteLine())
                .Add("ECHO %cd%").NR()
                .Add(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe -NoExit -command ""git clone --depth 1 https://github.com/IvanSibirevV2/HowTo_NirCmd.git;exit"" ").NR()
                .CMDoor_Run().WriteLine().Get(a => "")
                .Add("del nircmd.exe").NR()
                .Add(@"copy HowTo_NirCmd\NirCmd\nircmd.exe nircmd.exe").NR()
                .Add("rmdir HowTo_NirCmd /s /q").NR()
                .CMDoor_Run().WriteLine()
            ;
            return _this.CMDoor_Run();
        }
        [System.Diagnostics.TestLastMethod(_year: 2026, _month: 05, _day: 04, _hour: 15, _minute: 0, _second: 0, _millisecond: 0, _StrComment: "Тест №0 System.CMD.CMDoor_V0")]
        public static bool Test()
        {
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            //Скрипт открытия браузера или перемещения фокуса на него
            ""/*Создаем строку*/
                .Win("+b")/*Прожимаем горячее сочетание клавишь для переключение на понель виндовс в низу*/
                .Wait()/*Ждем, по умолчанию 25 милисекунд (по факту больше, зависит от скорости пакетного запуска, на игровых машинах почти моментально, на офисных +100500 милисекунд),*/
                .Tab().Tab().Tab().Tab()/*Табулируем перемещаясь на группу вкладок приложений*/
                .ArrowRight().ArrowRight().ArrowRight().ArrowRight()/*Сдвигаем фокус на браузер, если он пятый в списке*/
                .Enter()/*Повторяем легендарную речь Гагарина Ю.А. :"П О Е Х А Л И !!!"*/
                .Wait(5000)/*Шайтан машин ротор ган*/
                .Ctrl("+0x73")
                .Wait(50).Win("+0x20").Wait(50)
                .U().F().U().F().H().B().Y()
                .Space().Dot()
                .Wait(50).Win("+0x20").Wait(50).Dot()
                .Wait(50).Win("+0x20").Wait(50).F()
                .Wait(50).Win("+0x20").Wait(50).Dot()
                .Wait(50)
                .Enter()
                .NirCMDoor_Run() /*Крестимся и молимся о некоколебимости духа машины*/
            ;
            return true;
        }
    }
}