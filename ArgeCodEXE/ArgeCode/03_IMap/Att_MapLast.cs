using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Diagnostics.Map
{
    /// <summary>Аттрибут для мапинга пользовательских интерфейсов для указания более поздней версии по дате</summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class Att_MapLast : System.Attribute
    {
        
        private System.DateTime p__DateTime = new DateTime(); public System.DateTime p_DateTime { get => this.p__DateTime; }
        private int p__year = 0; public int p_year { get => this.p__year; }
        private int p__month = 0; public int p_month { get => this.p__month; }
        private int p__day = 0; public int p_day { get => this.p__day; }
        private int p__hour = 0; public int p_hour { get => this.p__hour; }
        private int p__minute = 0; public int p_minute { get => this.p__minute; }
        private int p__second = 0; public int p_second { get => this.p__second; }
        private int p__millisecond = 0; public int p_millisecond { get => this.p__millisecond; }
        public Att_MapLast() { }
        public Att_MapLast(int _year = 0, int _month = 0, int _day = 0, int _hour = 0, int _minute = 0, int _second = 0, int _millisecond = 0)
        {
            this.p__DateTime = new DateTime(_year, _month, _day, _hour, _minute, _second, _millisecond);
            p__year = _year; p__month = _month; p__day = _day; p__hour = _hour;
            p__minute = _minute; p__second = _second; p__millisecond = _millisecond;
        }
        public override string ToString()
        { return this.GetType().FullName.ToString() + "[" + this.p_DateTime.ToString() + "]"; }
    }
}
