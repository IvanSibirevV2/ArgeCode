using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Or;

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
            for (int j = 0; j < 130; j++)
            {
            new List<byte>().WinB().Tab().Tab().Tab().Tab().ArrowRight().Enter().Do();
            new List<byte>().Home().Home().Do();
            for (int i = 0;i<35;i++)new List<byte>().Delete().Do();

            new List<byte>().P().U().B().L().I().C().Space().S().T().A().T().I().C().Space()
                .S().T().R().I().N().G().Space().Do();

            new List<byte>().Home().Home().ArrowDown().Do();
            new List<byte>().Sleep1000().WinB().Tab().Tab().Tab().Tab().ArrowRight().ArrowRight().ArrowRight().ArrowRight().ArrowRight().ArrowRight().Enter().Do();


             
            }
            //
            "Привет мир".WriteLine();
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
            if (false)
            {
                System.Diagnostics.TestLast.Do();
            }
            if (false)
            {
                System.Diagnostics.TestLast.Get_TestS().Where_BoolTest().Get_LastTestMetod()
                    .WriteThis().Get_Delegate_AS<System.Func<System.Boolean>>()()
                ;
            }
            //System.Console.ReadLine();
            //"".ReadLine();
        }
    }
}
