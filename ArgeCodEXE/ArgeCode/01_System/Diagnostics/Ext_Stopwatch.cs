using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Diagnostics
{
    public static class Ext_Stopwatch
    {
        public static System.Diagnostics.Stopwatch Set_(this System.Diagnostics.Stopwatch _this,System.Action<System.Diagnostics.Stopwatch> a)
        {
            _this.Reset_().Start_();
            a(_this);
            _this.Stop_();
            return _this;
        }
        public static System.Diagnostics.Stopwatch Reset_(this System.Diagnostics.Stopwatch _this){_this.Reset();return _this;}
        public static System.Diagnostics.Stopwatch Start_(this System.Diagnostics.Stopwatch _this){ _this.Start(); return _this; }
        public static System.Diagnostics.Stopwatch Stop_(this System.Diagnostics.Stopwatch _this) { _this.Stop(); return _this; }
        
        [System.Diagnostics.Att_TestLast(_year: 2020, _month: 07, _day: 27, _hour: 18, _minute: 04, _second: 0, _millisecond: 0)]
        public static void Test_Ext_Stopwatch_20200727_18_03()
        {
            System.Console.WriteLine(System.Diagnostics.StackTracer.Get_STS());
            (new System.Diagnostics.Stopwatch())
                .Set_(a =>
                    {
                        System.Threading.Thread.Sleep(5432); 
                    }
                )
                .Set(a=>
                    a.Elapsed.ToString().WriteLine()
                )
            ;
        }
    }
}