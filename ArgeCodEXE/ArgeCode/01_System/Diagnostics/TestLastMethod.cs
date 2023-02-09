using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
///////////////////////////////////////////////////////////
namespace System.Diagnostics
{
    //Component.Att_TestLast//Component.TestLast.Do()//
    /// <summary>
    /// Отметьте этим атрибутом статический тестовый метод, укажите самую последнюю дату. И запускайте.
    /// Метод System.Diagnostics.TestLast.Do(); выберет самый последний тест и запустит его.
    /// Это удобно при отладке. Удобнее чем переименование в Main и модульные тесты.
    /// Аттрибут не повторяющийся.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class TestLastMethod : System.Attribute
    {
        private System.DateTime p__DateTime = new DateTime(); public System.DateTime p_DateTime { get => this.p__DateTime; }
        private System.String p__StrComment = "DefaultTest"; public System.String p_StrComment { get => this.p__StrComment; }
        /// <summary> Данные анализируемого метода </summary>
        public MethodInfo p__Target_MethodInfo = null;
        /// <summary> Класс источник метода </summary>
        public System.Type p__Target_Type = null;
        /////////////////////////////////////////////////////////////////////////////////////////////
        #region Заплатка или новая Фича ??? время покажет
        public static System.UInt64 p___Generation_Id = System.UInt64.MinValue;
        public System.UInt64 p__GenId = System.UInt64.MinValue;
        /// <summary>Id порядка генерации класса атрибута, Будет использоваться для альтерантивного однозначного вызрова тестовой функции</summary>
        public System.UInt64 p_GenId { get => p__GenId; }
        public TestLastMethod() { this.p__GenId = p___Generation_Id++; }
        #endregion
        /////////////////////////////////////////////////////////////////////////////////////////////
        //public Att_TestLast(){}
        /////////////////////////////////////////////////////////////////////////////////////////////
        public TestLastMethod(int _year = 0, int _month = 0, int _day = 0, int _hour = 0, int _minute = 0, int _second = 0, int _millisecond = 0, System.String _StrComment = null)
        {
            this.p__DateTime = new DateTime(_year, _month, _day, _hour, _minute, _second, _millisecond);
            this.p__StrComment = _StrComment;
        }
        public override string ToString()
        { return this.GetType().FullName.ToString() + "[" + this.p_DateTime.ToString("hh:mm:ss") + "::" + this.p_DateTime.ToString("dd.MM.yyyy") + "]"; }
        public TestLastMethod WriteThis()
        {
            if (this.p_StrComment != null) ("//" + this.p_StrComment).WriteLine();
            this.ToString().WriteLine();
            if (this.p__Target_Type != null) if (this.p__Target_MethodInfo != null)
                    (this.p__Target_Type.FullName + "." + this.p__Target_MethodInfo.Name + "()").WriteLine();
            return this;
        }
    }
}