using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.CMD
{
    /// <summary>
    /// Дело вот в чем. Майкрасофт предоставляет классы System.Diagnostics.Process и System.Diagnostics.ProcessStartInfo.
    /// Пареметры ...ProcessStartInfo   .RedirectStandardOutput и .RedirectStandardInput
    /// позволяют перенаправить потоки ввода и вывода дочерней консоли, по идее. Но напрактике
    /// В интернете полно форумов с безуспешным обсуждением этого вопроса....
    /// .RedirectStandardInput = true не раболтает вообще.
    /// И так """Microsoft RedirectStandardInput: Fail"""
    /// Лучшее что сдесь можно сделать - это не использовать файл на жестком диске для перенаправления скрипта...
    /// Есть по нынешним временам как пишут антипатерн "Золотой молоток".
    /// Скажу Вам что этот антипатерн в неумелых руках является действительно таковым.
    /// Если "Золотой молоток" применять к месту и с чувством прекрасного,
    /// то тогда программный код упрощается для понимания, за счет повторяющихся подходов и патернов.
    /// Использование двух разных костылей (тоже антипатерн) приводит к бесполезной уникальности блоков программных кодов.
    /// Что только замедлит вхождение новых людей в проект.
    /// </summary>
    public static class CMDoor_MicrosoftFail
    {
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
            //System.Diagnostics.Process.StandardInput

            System.IO.StreamWriter _StreamWriter = null;
            //Осталось сделать запуск с параметрами процесса и отключение повторного эхо
            System.String _TimeString = System.DateTime.Now.ToString("yyyyMMdd_hhmmss_ffff");
            System.String _CMDynamicInPut_FileName = "CMDoorDynamicInPut" + _TimeString + ".bat";
            System.String _CMDynamicOutPut_FileName = "CMDoorDynamicOutPut" + _TimeString + ".txt";
            _CMDynamicInPut_FileName
                .SetIf(_fBool: a => System.IO.File.Exists(a), _f1: a => System.IO.File.Delete(a))
                .Get(a => System.IO.File.CreateText(a))
                .Set(a => a.WriteLine(_CMDInPutSkript))
                .Close()
            ;
            if (_Encoding == null) _Encoding = System.Text.Encoding.UTF8;
            System.String _Resalt = "";
            (new System.Diagnostics.Process())
                .Set(b => b.StartInfo =
                    (new System.Diagnostics.ProcessStartInfo(_CMDynamicInPut_FileName))
                    .Set(a => a.RedirectStandardOutput = true)
                    .Set(a => a.RedirectStandardInput = true)
                    .Set(a => a.RedirectStandardError = true)
                    .Set(a => a.StandardOutputEncoding = _Encoding)
                    .Set(a => a.UseShellExecute = false)
                    
                    .Set(a => a.CreateNoWindow = true)
            )
            .Set(a => a.Start())
            .Set(a => a.WaitForExit())
            .Set(a =>_Resalt = a.StandardOutput.ReadToEnd())
            ;
            System.IO.File.Delete(_CMDynamicInPut_FileName);
            return _Resalt;
        }
        //////////////////////////////////////////////////////
        [System.Diagnostics.Att_TestLast(_year: 2020, _month: 08, _day: 06, _hour: 19, _minute: 50, _second: 0, _millisecond: 0)]
        public static void Test()
        {
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            ">>>:System.CMD.CMDoor_V1:>>>".WriteLine();
            System.CMD.CMDoor_MicrosoftFail.Get_Resalt().WriteLine();
            "<<<:System.CMD.CMDoor_V1:<<<".WriteLine();
        }
    }
}