using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public class SelectedList<T>
    {
        public List<T> p_ListT= new List<T>();
        private int p__SelectedIndex = -1;
        public int p_SelectedIndex
        {
            get {return this.ValidatSelectedIndex().p__SelectedIndex;}
            set {this.p__SelectedIndex = value;this.ValidatSelectedIndex();}
        }
        public SelectedList<T> ValidatSelectedIndex()
        {
            if (this.p__SelectedIndex > this.p_ListT.Count()) this.p__SelectedIndex = this.p_ListT.Count() - 1;
            if (this.p__SelectedIndex < -1) this.p__SelectedIndex = -1;
            return this;
        }
        public T p_SelectedItem { 
            get{ return this.p_ListT[this.p_SelectedIndex];}
            set { this.p_ListT[this.p_SelectedIndex] = value; }
        }
    }
}