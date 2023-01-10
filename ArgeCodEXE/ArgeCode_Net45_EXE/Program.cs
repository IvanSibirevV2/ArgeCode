using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgeCode_Net45_EXE
{
    public class Program
    {
        public static System.Type Get_qwe<T>() where T: System.Delegate
        {
            System.Type _Type = "s".GetType();
            _Type = typeof(T);
            
            return _Type;
        }
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Привет мир");
            System.Console.WriteLine("Выведем на экран имеющийся список тестов");
            System.Diagnostics.TestLast.Get_TestS().ForEach(a => a.WriteThis());
            System.Console.WriteLine("");
            System.Console.WriteLine("Запустим последний из них");
            System.Diagnostics.TestLast.Do();
            System.Console.ReadLine();
        }
    }
}
