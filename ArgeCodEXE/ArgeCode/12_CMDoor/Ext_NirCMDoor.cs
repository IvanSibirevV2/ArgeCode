using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.CMD.NirCMD
{
    public static class Ext_NirCMDoor
    {
        public static string NircmdSendkeypress(this string _this) => _this.Add("nircmd sendkeypress ");
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
        [System.Diagnostics.TestLastMethod(_year: 2024, _month: 05, _day: 6, _hour: 12, _minute: 0, _second: 0, _millisecond: 0, _StrComment: "Тест №0 System.CMD.CMDoor_V0")]
        public static bool Test()
        {
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            //Скрипт открытия браузера или перемещения фокуса на него
            ""/*Создаем строку*/
                .Combo(0.Win_str(), 0.B_str())/*Прожимаем горячее сочетание клавишь для переключение на понель виндовс в низу*/
                .Wait()/*Ждем, по умолчанию 25 милисекунд (по факту больше, зависит от скорости пакетного запуска, на игровых машинах почти моментально, на офисных +100500 милисекунд),*/
                .Tab().Tab().Tab().Tab()/*Табулируем перемещаясь на группу вкладок приложений*/
                .ArrowRight().ArrowRight().ArrowRight().ArrowRight()/*Сдвигаем фокус на браузер, если он пятый в списке*/
                .Enter()/*Повторяем легендарную речь Гагарина Ю.А. :"П О Е Х А Л И !!!"*/
                .Wait(5000)/*Шайтан машин ротор ган*/
                  .Combo(0.Ctrl_str(), 0.F4_str())
                .Wait(50).Combo(0.Win_str(),0.Space_str()).Wait(50)
                .U().F().U().F().H().B().Y()
                .Space().Dot()
                .Wait(50).Combo(0.Win_str(), 0.Space_str()).Wait(50).Dot()
                .Wait(50).Combo(0.Win_str(), 0.Space_str()).Wait(50).F()
                .Wait(50).Combo(0.Win_str(), 0.Space_str()).Wait(50).Dot()
                .Wait(50)
                .Enter()
                .NirCMDoor_Run() /*Крестимся и молимся о некоколебимости духа машины*/
            ;
            return true;
        }
        public static System.String Combo(this string _this, params string[] args) => _this.Add("nircmd sendkeypress ").Add(System.String.Join("+", args)).NR();
        [System.Diagnostics.TestLastMethod(_year: 2024, _month: 05, _day: 04, _hour: 5, _minute: 0, _second: 0, _millisecond: 0, _StrComment: "Тест №0 System.CMD.CMDoor_V0")]
        public static bool Test_2() 
        {
            "".Combo("", "", "");
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            string _str1 = " ".Combo("".Win(), "".B()) ;
            string _str2 = "\r";
            ;
            return true;
        }
    }
}