using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class Ext_List_T
    {
        public static List<T> Set_Add<T>(this List<T> _this, T item) {_this.Add(item);return _this;}
        public static List<T> Set_RemoveAt<T>(this List<T> _this, int index) { _this.RemoveAt(index); return _this; }
        public static List<T> Set_AddRange<T>(this List<T> _this, IEnumerable<T> collection) { _this.AddRange(collection); return _this; }
    }
}
