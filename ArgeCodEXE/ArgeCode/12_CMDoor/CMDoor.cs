using System;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace System.CMD
{
    /// <summary>
    /// Дверь из CSharp в CMD
    /// </summary>
    public static class CMDoor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_this"></param>
        /// <param name="_InPutString"></param>
        /// <returns>Возвращает результат конслоли для дальнейшего парсинга</returns>
        public static System.String CMDoor_Run(this string _this,System.String _InPutString=null)
        {
            System.String _result = "";
            System.Diagnostics.Process _Process = new System.Diagnostics.Process();
            _Process.StartInfo = new System.Diagnostics.ProcessStartInfo();
            _Process.StartInfo.FileName = "".Add("CMDoorDynamic").Add(System.DateTime.Now.ToString("yyyyMMdd_hhmmss_ffff")).Add(".bat");
            _Process.StartInfo.UseShellExecute = false;
            _Process.StartInfo.CreateNoWindow = true;
            _Process.StartInfo.RedirectStandardOutput = true;
            _Process.StartInfo.RedirectStandardError = true;
            _Process.StartInfo.RedirectStandardInput = true;
            _Process.OutputDataReceived += (object sender, DataReceivedEventArgs e) 
                =>e.Data.ifNotNull(a =>_result += Encoding.UTF8.GetString(Encoding.GetEncoding("CP866").GetBytes(a)).WriteLine().NR());
            _Process.ErrorDataReceived += (object sender, DataReceivedEventArgs e)
                => e.Data.ifNotNull(a => _result += Encoding.UTF8.GetString(Encoding.GetEncoding("CP866").GetBytes(a)).WriteLine().NR());

            _Process.StartInfo.FileName
                .SetIf(_fBool: a => System.IO.File.Exists(a), _f1: a => System.IO.File.Delete(a))
                .Get(a => System.IO.File.CreateText(a))
                .Set(a => a.WriteLine(_this))
                .Close()
            ;                
            _Process.Start();

            _Process.BeginOutputReadLine();
            _Process.BeginErrorReadLine();
            _InPutString.ifNotNull(a => _InPutString.Split('\n').ToList().ForEach(b => _Process.StandardInput.WriteLine(b)));                        

            _Process.WaitForExit();
            System.IO.File.Delete(_Process.StartInfo.FileName);
            return _result;
        }
        public static string echo_off(this string _this) => _this.Add("@echo off").NR();
        public static string echo(this string _this, string _str) => _this.Add("echo ").Add(_str).NR();
        /// <summary>echo.</summary>
        public static string echo_(this string _this) => _this.Add("echo.").NR();
        public static string notepad(this string _this, string _str) => _this.Add("notepad ").Add(_str).NR();
        public static string del(this string _this, string _str) => _this.Add("del ").Add(_str).NR();
        //////////////////////////////////////////////////////
        [System.Diagnostics.TestLastMethod(_year: 2024, _month: 05, _day: 03, _hour: 09, _minute: 09, _second: 0, _millisecond: 0, _StrComment: "Тест №0 System.CMD.CMDoor_V0")]
        public static bool Test()
        {
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            ""
                .echo_off()
                .echo("NoComands")
                .echo("echo Привет мир!!!")
                .echo_()
            .CMDoor_Run();
            ""//Как видите, таймер не рааботает
                .echo_off()
                .echo("Ждем 2 секунды")
                .Add("TIMEOUT /T 3").NR()
                .echo("Все ок")
            .CMDoor_Run();
            ""//Как видите, пауза  стопорит, если не послать текст
                .echo_off()
                .echo("пауза")
                .Add("pause").NR()
                .Add("pause").NR()
                .echo("Все ок")
            .CMDoor_Run("");
            ""//Как видите, пауза  стопорит, если не послать текст
                .echo_off()
                .echo("HelloWorld>>Text.txt")
                .echo("Привет_мир>>Text.txt")
                .echo("Закройте без сохранения и программа будет работать дальше>>Text.txt")
                .notepad("Text.txt")
                .del("Text.txt")
                .echo("Привет мир")
                .CMDoor_Run();
            return true;
        }
    }
}