using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CMD;
using System.CMD.NirCMD;

/// <summary>
/// Данный проект предназначен для запуска скриптов
/// Наиболее ценное будет лежать по другим локализациям
/// </summary>
namespace ArgeCodEXE
{
    class Program
    {
        public static void Main(string[] args)
        {
            
             
            
            if (false)
            {
                System.Console.WriteLine("Выведем на экран имеющийся список тестов");
                System.Diagnostics.TestLast.Get_TestS().ForEach(a => a.WriteThis());
            }
            if (false)
            {
                System.Console.WriteLine("Запуск всех тестов");
                System.Diagnostics.TestLast.Do_Oll();
            }
            if (false)
            {
                System.Console.WriteLine("Запуск всех тестов");
                System.Diagnostics.TestLast.Do_IfBoolean_Oll();
            }
            System.Console.WriteLine("Запустим последний из них");
            if (!false)
            {
                System.Diagnostics.TestLast.Do();
            }
            if (false)
            {
                System.Diagnostics.TestLast.Get_TestS().Where_BoolTest().Get_LastTestMetod()
                    .WriteThis().Get_Delegate_AS<System.Func<System.Boolean>>()()
                ;
            }
            "Привет мир".WriteLine();
            "".ReadLine();
        }
    }
}
