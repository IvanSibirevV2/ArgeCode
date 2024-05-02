using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.CMD
{
    /// <summary>
    /// Дверь из CSharp в CMD
    /// Одна проблема. System.Diagnostics.Process и System.Diagnostics.ProcessStartInfo крайне плохо работают с перенаправлением потоков
    /// По этому... Используется классика CMD/DOS/*.BAT --Перенаправление потоков ввода и вывода--
    /// " 1>" + _CMDynamicOutPut_FileName - Этог перенаправлениие вывода в файл для всего скрипта
    /// По аналогии можно и перенаправлять и ввод скрипта.
    /// Только вот ProcessStartInfo подкачал нужно разбираться.
    /// .WaitForExit() обеспечивает последовательность всех операций записи/чтения/удалений.
    /// Такой способ работает как швейцарские часы и автомат калашникова вместе взятые.
    /// Только вот на диске создаются временные файлы самого скрипта и результата его исполнения.
    /// 
    /// Внемание Если у Вас ошибка в CMDoor_V0 (Наплодило 2 гигабайта файлов ввода и вывода, а результата так и не дождались), значит в ваших скриптах ошибка...
    /// 
    /// Если в нутри запускаете открытие файлов через блокнот, то дочерн
    /// </summary>
    public static class CMDoor_V0
    {
        public static System.String Execute_CMDoor_V0(this string _this){ return Get_Resalt(_this);}
        /// <summary>Дверь из CSharp в CMD</summary>
        /// <param name="_CMDInPutSkript">Текст скрипта программных кодов</param>
        /// <param name="_Encoding">Дверь для кодировкиЕсли возникнут проблемы.</param>
        /// <returns>Результат выполнения скрипта для парсинга ответа на команду</returns>
        public static System.String Get_Resalt(
            System.String _CMDInPutSkript =
@"
echo off
echo NoComands
echo Привет мир
::TIMEOUT /T 10
"
            , System.Text.Encoding _Encoding = null
        )
        {
            //Осталось сделать запуск с параметрами процесса и отключение повторного эхо
            System.String _TimeString = System.DateTime.Now.ToString("yyyyMMdd_hhmmss_ffff");
            System.String _CMDynamicInPut_FileName = "CMDoorDynamicInPut" + _TimeString + ".bat";
            System.String _CMDynamicOutPut_FileName = "CMDoorDynamicOutPut" + _TimeString + ".txt";
            _CMDynamicOutPut_FileName
                .SetIf(_fBool: a => System.IO.File.Exists(a), _f1: a => System.IO.File.Delete(a))
                .Get(a => System.IO.File.CreateText(a))
                .Close()
            ;
            _CMDynamicInPut_FileName
                .SetIf(_fBool: a => System.IO.File.Exists(a), _f1: a => System.IO.File.Delete(a))
                .Get(a => System.IO.File.CreateText(a))
                .Set(a => a.WriteLine(_CMDInPutSkript))
                .Close()
            ;
            (new System.Diagnostics.Process())
                .Set(b => b.StartInfo =
                    (new System.Diagnostics.ProcessStartInfo(_CMDynamicInPut_FileName, " 1>" + _CMDynamicOutPut_FileName))
                    .Set(a => a.UseShellExecute = false)
                    .Set(a => a.CreateNoWindow = true)
            ).Set(a => a.Start()).WaitForExit()
            ;
            //System.Diagnostics.Process.Start(_CMDynamicInPut_FileName," 1>"+ _CMDynamicOutPut_FileName).WaitForExit();
            System.String _Resalt = "";
            if (_Encoding == null) _Encoding = System.Text.Encoding.UTF8;
            (new System.IO.StreamReader(_CMDynamicOutPut_FileName, _Encoding)).Set(a => _Resalt = a.ReadToEnd()).Close();
            System.IO.File.Delete(_CMDynamicInPut_FileName);
            System.IO.File.Delete(_CMDynamicOutPut_FileName);
            return _Resalt;
        }
        //////////////////////////////////////////////////////
        [System.Diagnostics.TestLastMethod(_year: 2020, _month: 08, _day: 05, _hour: 0, _minute: 59, _second: 0, _millisecond: 0, _StrComment: "Тест №0 System.CMD.CMDoor_V0")]
        public static bool Test()
        {
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            ">>>:System.CMD.CMDoor_V0.Test():>>>".WriteLine();
            System.CMD.CMDoor_V0.Get_Resalt().WriteLine();
            "<<<:System.CMD.CMDoor_V0.Test():<<<".WriteLine();
            return true;
        }
        //////////////////////////////////////////////////////
        [System.Diagnostics.TestLastMethod(_year: 2020, _month: 10, _day: 26, _hour: 13, _minute: 35, _second: 0, _millisecond: 0, _StrComment: "Тест №2 System.CMD.CMDoor_V0")]
        public static bool Test_2()
        {
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            ">>>:System.CMD.CMDoor_V0.Test_2():>>>".WriteLine();
            System.CMD.CMDoor_V0.Get_Resalt(_CMDInPutSkript:
@"@echo off
echo HelloWorld>>Text.txt
echo Привет_мир>>Text.txt
echo Закройте без сохранения и программа будет работать дальше>>Text.txt
notepad Text.txt
DEL Text.txt
"
                ).WriteLine()
            ;
            "<<<:System.CMD.CMDoor_V0.Test_2():<<<".WriteLine();
            return true;
        }
    }
}