namespace Component.Reflection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Reflection;
    /////////////////////////////////////////////////////////////
    public interface IClassForTest
    {
        IClassForTest Set(Action<IClassForTest> x);
        void Foo(int i, int j, string str);
    }
    public class ClassForTest : IClassForTest
    {
        public IClassForTest Init()
        {
            return this;
        }
        public ClassForTest() { this.Init(); }
        //public ClassForTest(int i = 0, System.Boolean _flagan = false) { this.Init(); }
        public IClassForTest Set(Action<IClassForTest> x) { x(this); return this; }

        [TestAtt(_String: "Просто текст")]
        public void Foo(int i, int j, string str) { }
        #region ВООБЩЕ ВСЕ ПАРАМЕТРЫ И ПОЛЯ
        public System.String p__StringPublic { get { return p_StringPublic; } set { p_StringPublic = value; } }
        public System.String p_StringPublic = "Привет мир";
        private System.String p_StringPrivate = "Привет мир";

        public static System.String p_StringPublicStatic = "Привет мир";
        [TestAtt(_String: "Просто текст")]
        private static System.String p_StringPrivateStatic = "Привет мир";

        public IList<string> p_IListString = (new string[] { "Ghbdt vbh", "Ghbdtn vbh2" }).ToList<string>();
        public System.String[] p_ArrString = new string[] { "Arr Ghbdt vbh", "ArrGhbdtn vbh2" };

        public System.Boolean p_SystemBoolean = true;
        public System.Byte p_SystemByte = 0;
        public System.Char p_SystemChar = 'c';
        public System.Decimal p_SystemDecimal = 0;
        public System.Double p_SystemDouble = 0;
        public System.Int16 p_SystemInt16 = 0;
        [TestAtt(_String: "Просто текст")]
        public System.Int32 p_SystemInt32 = 0;
        public System.Int64 p_SystemInt64 = 0;
        public System.SByte p_SystemSByte = 0;
        public System.Single p_SystemSingle = 0;
        public System.String p_SystemString = "Привет мир";
        public System.UInt16 p_SystemUInt16 = 0;
        public System.UInt32 p_SystemUInt32 = 0;
        public System.UInt64 p_SystemUInt64 = 0;
        #endregion

    }
}
