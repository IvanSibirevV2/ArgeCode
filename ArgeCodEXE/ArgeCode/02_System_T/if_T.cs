using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class if_T
    {
        public static T ifNull<T>(this T _this, System.Action<T> a) {if (_this == null) a(_this);return _this;}
        public static T ifNotNull<T>(this T _this, System.Action<T> a){ if (_this != null) a(_this); return _this; }
        [System.Diagnostics.TestLastMethod(_year: 2024, _month: 04, _day: 04, _hour: 20, _minute: 09, _second: 0, _millisecond: 0)]
        public static bool Test_ifNull()
        {
            System.Object _obj = null;
            _obj = null; "_obj = null;".WriteLine();
            _obj.ifNull(a=> "_obj == null;".WriteLine()).ifNotNull(a => "_obj != null;".WriteLine());
            _obj = new System.Object(); "_obj = new System.Object();".WriteLine();
            _obj.ifNull(a => "_obj == null;".WriteLine()).ifNotNull(a => "_obj != null;".WriteLine());
            return true;
        }
        public static System.Boolean if0(this System.Boolean _this, System.Action<System.Boolean> _a)
        { if (!_this) _a(_this); return _this;}
        public static System.Boolean if1(this System.Boolean _this, System.Action<System.Boolean> _a)
        { if (_this) _a(_this); return _this; }
        [System.Diagnostics.TestLastMethod(_year: 2024, _month: 04, _day: 04, _hour: 20, _minute: 09, _second: 1, _millisecond: 0)]
        public static bool Test_ifBool()
        {
            System.Boolean _flg = true;
            _flg = true; "_flg = true;".WriteLine();
            _flg.if1(a => "_flg == true;".WriteLine()).if0(a => "_flg == false;".WriteLine());
            _flg = false; "_obj = false;".WriteLine();
            _flg.if1(a => "_flg == true;".WriteLine()).if0(a => "_flg == false;".WriteLine());
            return true;
        }
    }
}