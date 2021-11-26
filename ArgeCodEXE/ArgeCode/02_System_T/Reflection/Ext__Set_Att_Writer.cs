namespace Component.Reflection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    //////////////////////////////////////////////////////////////////////////////
    using System.Reflection;
    //////////////////////////////////////////////////////////////////////////////
    public static class Ext__Set_Att_Writer
    {
        public static void Set_Att_Writer(this System.Reflection.MemberInfo _CtorInf)
            => _CtorInf.GetCustomAttributes().ToList()
                .Set(a => { if (a.Count() > 0) { a.ForEach(b => ('[' + b.GetType().ToString() + "] ").Write()); "".WriteLine(); } })
        ;
    }
    /// <summary> Тестовый атрибут/// Component.Reflection.TestAtt /// </summary>
    public class TestAtt : System.Attribute
    {        
        private System.String p__String = "";
        public System.String p_String { get => this.p__String; set => this.p__String = value; }
        public TestAtt() { }
        public TestAtt(System.String _String = null) => this.Set(
            _String: _String
            )
        ;
        public TestAtt Set(
            TestAtt _this = null
            ,System.String _String = null
        ) => this
            .SetIf(_this != null, a => this.Set(
                _String:_String
                )
            )
            .SetIf(_String!=null,a=>this.p_String=_String)
        ;
    }
}