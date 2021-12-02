using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.VConsole
{
    public static class Ext_List_GUIVC
    {
        public static List<GUIVC> Get_Copy(this List<GUIVC> _this) => new List<GUIVC>().Set(a=>_this.ForEach(b=>a.Add(new GUIVC().Set(_this: b))));
    }
    public class GUIVC
    {
        /// <summary> Заголовок Меню </summary>
        public System.String p_Title = "";
        public List<GUIVC> p_GUIVC_S = new List<GUIVC>();
        public System.Action<GUIVC> p_Act = x => { };
        public System.Action<GUIVC> p_UpDate = x => { };
        /// <summary> Сбласываемый в собитии p_Act параметр. Когда установлен в false происходит либо однократное исполнение меню, либо разрыв многократного исполнения.</summary>
        public System.Boolean p_IsRepeater = false;
        public dynamic ResValue = null;
        private System.Byte p_ByteId = 0;
        ////////////////////////////////////////////////////////////////
        public GUIVC() { }
        public GUIVC Set(GUIVC _this=null, System.String _Title = null, List<GUIVC> _GUIVC_S = null, System.Action<GUIVC> _Act =null, System.Action<GUIVC> _UpDate = null, System.Nullable<System.Boolean> _IsRepeater = null)
        {
            if (_this != null) this.Set(_this: null, _GUIVC_S: _this.p_GUIVC_S.Get_Copy(), _Act: null, _UpDate: null);
            if (_Title != null) this.p_Title = _Title;
            if (_GUIVC_S != null) this.p_GUIVC_S = _GUIVC_S;
            if (_Act != null) this.p_Act = _Act;
            if (_UpDate != null) this.p_UpDate = _UpDate;
            if (_IsRepeater != null) this.p_IsRepeater = _IsRepeater.Value;
            return this;
        }
        /// <summary>Временный параметр, устанавливается во время исполнения.</summary>
        public GUIVC p_Sender = null;
        public GUIVC Do() 
        {
            do
            {
                this.p_GUIVC_S.ForEach(a => a.p_Sender = this);
                this.p_UpDate(this);
                this.p_GUIVC_S.ForEach(a => a.p_UpDate(a));
                this.p_Title.WriteLine();
                int i = 0;
                this.p_GUIVC_S.ForEach(a => ("-" + i++.ToString() + "-" + a.p_Title).WriteLine());                
                System.Boolean _Flag = true;
                System.Byte _Byte = 0;
                while (_Flag)
                {
                    _Byte = new System.Byte().Get_ReadLine();
                    if ((_Byte >= 0) && (_Byte < this.p_GUIVC_S.Count)) _Flag = false;
                }
                this.p_GUIVC_S[_Byte].Set(a => a.p_Act(a));
            } while (this.p_IsRepeater);
            return this;
        }
        /// <summary>System.VConsole.Ext_T_ReadLine.Test_ReadLine();</summary>
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 30, _hour: 18, _minute: 10, _second: 2, _millisecond: 0)]
        public static void Test2()
        {
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            new GUIVC()
                .Set(_Title: "Титульник Меню",_IsRepeater:true
                    , _GUIVC_S: new List<GUIVC>() {
                        new GUIVC().Set(_Title:"Выход",_Act:a=>a.p_Sender.p_IsRepeater=false)
                        , new GUIVC().Set(_Title:"Выбор 1")
                        , new GUIVC().Set(_Title:"Выбор 2")
                    }
                )
                .Do()
           ;
        }
        /// <summary>System.VConsole.Ext_T_ReadLine.Test_ReadLine();</summary>
        [System.Diagnostics.Att_TestLast(_year: 2021, _month: 11, _day: 30, _hour: 18, _minute: 10, _second: 0, _millisecond: 0)]
        public static void Test() 
        {
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            new GUIVC()
                .Set(_Title: "Титульник Меню"
                    , _GUIVC_S: new List<GUIVC>() {
                        new GUIVC().Set(_Title:"ДА",_Act:a=>a.p_Title.WriteLine())
                        , new GUIVC().Set(_Title:"НЕТ",_Act:a=>a.p_Title.WriteLine())
                        , new GUIVC().Set(_Title:"Сомневаюсь")
                    }
                )
                .Do()
           ;
        }
    }
}
