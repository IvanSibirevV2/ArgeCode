using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CMD;


namespace T_Or
{
    public static class Ext_ListByte
    {
        public static List<byte> _(this List<byte> _this, byte _bvk)
            => _this.Set_Add(_bvk);
        public static List<byte> _(this List<byte> _this, byte _bvk1, byte _bvk2, byte _bvk3, byte _bvk4)
            => _this.Set_Add(_bvk1).Set_Add(_bvk2).Set_Add(_bvk3).Set_Add(_bvk4);
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public static List<byte> MousBtnLeft(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x01);
        public static List<byte> MousBtnRight(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x02);
        public static List<byte> MousBtnMiddle(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x04);
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public static List<byte> Backspace(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x08);
        public static List<byte> Tab(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x09);
        public static List<byte> Enter(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x0D);
        public static List<byte> Shift(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x10);
        public static List<byte> Ctrl(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x11);
        public static List<byte> Alt(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x12);
        public static List<byte> Pause(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x13);
        public static List<byte> CapsLock(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x14);
        public static List<byte> Escape(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x1B);
        public static List<byte> Space(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x20);
        public static List<byte> PageUp(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x21);
        public static List<byte> PageDown(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x22);
        public static List<byte> End(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x23);
        public static List<byte> Home(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x24);
        public static List<byte> Insert(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x2D);
        public static List<byte> Delete(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x2E);
        public static List<byte> Win(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x5B);
        public static List<byte> WinLeft(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x5B);
        public static List<byte> WinRight(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x5C);
        public static List<byte> KeyApplication(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x5D);
        public static List<byte> ScrollLock(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x91);
        public static List<byte> PrintScreen(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x9A);
        public static List<byte> СommaPoint(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0xBA);
        public static List<byte> EQUally(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0xBB);
        public static List<byte> Сomma(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0xBC);
        public static List<byte> Minus(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0xBD);
        public static List<byte> Dot(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0xBE);
        public static List<byte> Slash(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0xBF);
        public static List<byte> Tilda(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0xC0);
        public static List<byte> SqueaBraketBegin(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0xDB);
        public static List<byte> UnSlash(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0xDC);
        public static List<byte> SqueaBraketEnd(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0xDD);
        public static List<byte> MarkUno(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0xDE);
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        public static List<byte> ArrowLeft(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x25);
        public static List<byte> ArrowUp(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x26);
        public static List<byte> ArrowRight(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x27);
        public static List<byte> ArrowDown(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x28);
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        public static List<byte> _0(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x30);
        public static List<byte> _1(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x31);
        public static List<byte> _2(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x32);
        public static List<byte> _3(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x33);
        public static List<byte> _4(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x34);
        public static List<byte> _5(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x35);
        public static List<byte> _6(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x36);
        public static List<byte> _7(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x37);
        public static List<byte> _8(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x38);
        public static List<byte> _9(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x39);
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public static List<byte> A(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x41);
        public static List<byte> B(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x42);
        public static List<byte> C(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x43);
        public static List<byte> D(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x44);
        public static List<byte> E(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x45);
        public static List<byte> F(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x46);
        public static List<byte> G(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x47);
        public static List<byte> H(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x48);
        public static List<byte> I(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x49);
        public static List<byte> J(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x4A);
        public static List<byte> K(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x4B);
        public static List<byte> L(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x4C);
        public static List<byte> M(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x4D);
        public static List<byte> N(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x4E);
        public static List<byte> O(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x4F);
        public static List<byte> P(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x50);
        public static List<byte> Q(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x51);
        public static List<byte> R(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x52);
        public static List<byte> S(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x53);
        public static List<byte> T(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x54);
        public static List<byte> U(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x55);
        public static List<byte> V(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x56);
        public static List<byte> W(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x57);
        public static List<byte> X(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x58);
        public static List<byte> Y(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x59);
        public static List<byte> Z(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x5A);
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static List<byte> NumPad0(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x60);
        public static List<byte> NumPad1(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x61);
        public static List<byte> NumPad2(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x62);
        public static List<byte> NumPad3(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x63);
        public static List<byte> NumPad4(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x64);
        public static List<byte> NumPad5(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x65);
        public static List<byte> NumPad6(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x66);
        public static List<byte> NumPad7(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x67);
        public static List<byte> NumPad8(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x68);
        public static List<byte> NumPad9(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x69);
        public static List<byte> NumPadStar(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x6A);
        public static List<byte> NumPadPlas(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x6B);
        public static List<byte> NumPadMinus(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x6D);
        public static List<byte> NumPadDot(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x6E);
        public static List<byte> NumPadSlash(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x6F);
        public static List<byte> NumLock(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x90);
        //////////////////////////////////////////////////////////////////////////////////
        public static List<byte> F1(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x70);
        public static List<byte> F2(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x71);
        public static List<byte> F3(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x72);
        public static List<byte> F4(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x73);
        public static List<byte> F5(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x74);
        public static List<byte> F6(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x75);
        public static List<byte> F7(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x76);
        public static List<byte> F8(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x77);
        public static List<byte> F9(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x78);
        public static List<byte> F10(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x79);
        public static List<byte> F11(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x7A);
        public static List<byte> F12(this List<byte> _this) => _this._(0x00, 0x00, 0x00, 0x7B);
        //////////////////////////////////////////////////////////////////////////////////
        // Перечень 16 битных комианд.
        public static List<byte> MouseX0(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x01);
        public static List<byte> MouseX1(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x02);
        public static List<byte> MouseX5(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x03);
        public static List<byte> MouseX10(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x04);
        public static List<byte> MouseX50(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x05);
        public static List<byte> MouseX100(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x06);
        public static List<byte> MouseX500(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x07);
        public static List<byte> MouseX1000(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x08);

        public static List<byte> MouseY0(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x09);
        public static List<byte> MouseY1(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x0A);
        public static List<byte> MouseY5(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x0B);
        public static List<byte> MouseY10(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x0C);
        public static List<byte> MouseY50(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x0D);
        public static List<byte> MouseY100(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x0E);
        public static List<byte> MouseY500(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x0F);
        public static List<byte> MouseY1000(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x10);
        //
        public static List<byte> Sleep25(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x11);
        public static List<byte> Sleep50(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x12);
        public static List<byte> Sleep100(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x13);
        public static List<byte> Sleep500(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x14);
        public static List<byte> Sleep1000(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x15);
        public static List<byte> Sleep5000(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x16);
        //////////////////////////////////////////////////
        public static List<byte> WinB(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x17);
        public static List<byte> CtrlN(this List<byte> _this) => _this._(0x00, 0x00, 0x01, 0x18);

        ///////////////////////////////////////////////////////////////////////////////////////
        public static System.String Add(this System.String _this, System.String _str)
            => _this + _str;
        public static System.String NR(this System.String _this)
            => _this.Add("\r\n");

        public static List<byte> Do(this List<byte> _this)
        {

            if (!System.IO.File.Exists("nircmd.exe")) ""
                .Set(a => "Требуемый Компонент не найден. Начинаю дозагрузку...".WriteLine())
                .Set(a => "Источник https://github.com/IvanSibirevV2/HowTo_NirCmd.git".WriteLine())
                .Set(a => "Буду скачивать nircmd.exe".WriteLine())
                .Add("ECHO %cd%").NR()
                .Add(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe -NoExit -command ""git clone --depth 1 https://github.com/IvanSibirevV2/HowTo_NirCmd.git;exit"" ").NR()
                .CMDoor_Run().WriteLine().Get(a => "")
                .Add("del nircmd.exe").NR()
                .Add(@"copy HowTo_NirCmd\NirCmd\nircmd.exe nircmd.exe").NR()
                .Add("rmdir HowTo_NirCmd /s /q").NR()
                .CMDoor_Run().WriteLine()
            ;
            int Counter = 0;
            while (Counter < _this.Count())
            {
                System.Byte _Byte1 = _this[Counter]; Counter++;
                System.Byte _Byte2 = _this[Counter]; Counter++;
                System.Byte _Byte3 = _this[Counter]; Counter++;
                System.Byte _Byte4 = _this[Counter]; Counter++;

                //И кому же нужно жиденькое ГоВнИцО. Досыпем побольше желатина.
                switch (_Byte1)
                {
                    case 0x00:
                        switch (_Byte2)
                        {
                            case 0x00:
                                switch (_Byte3)
                                {
                                    case 0x00:
                                        switch (_Byte4)
                                        {
                                            case 0x00: break;
                                            case 0x01: new Process().Set_NirCmd("sendkeypress 0x01"); break; new List<byte>().MousBtnLeft();
                                            case 0x02: new Process().Set_NirCmd("sendkeypress 0x02"); break; new List<byte>().MousBtnRight();
                                            case 0x04: new Process().Set_NirCmd("sendkeypress 0x04"); break; new List<byte>().MousBtnMiddle();
                                            case 0x08: new Process().Set_NirCmd("sendkeypress 0x08"); break; new List<byte>().Backspace();
                                            case 0x09: new Process().Set_NirCmd("sendkeypress 0x09"); break; new List<byte>().Tab();
                                            case 0x0D: new Process().Set_NirCmd("sendkeypress 0x0D"); break; new List<byte>().Enter();
                                            case 0x10: new Process().Set_NirCmd("sendkeypress 0x10"); break; new List<byte>().Shift();
                                            case 0x11: new Process().Set_NirCmd("sendkeypress 0x11"); break; new List<byte>().Ctrl();
                                            case 0x12: new Process().Set_NirCmd("sendkeypress 0x12"); break; new List<byte>().Alt();
                                            case 0x13: new Process().Set_NirCmd("sendkeypress 0x13"); break; new List<byte>().Pause();
                                            case 0x14: new Process().Set_NirCmd("sendkeypress 0x14"); break; new List<byte>().CapsLock();
                                            case 0x1B: new Process().Set_NirCmd("sendkeypress 0x1B"); break; new List<byte>().Escape();
                                            case 0x20: new Process().Set_NirCmd("sendkeypress 0x20"); break; new List<byte>().Space();
                                            case 0x21: new Process().Set_NirCmd("sendkeypress 0x21"); break; new List<byte>().PageUp();
                                            case 0x22: new Process().Set_NirCmd("sendkeypress 0x22"); break; new List<byte>().PageDown();
                                            case 0x23: new Process().Set_NirCmd("sendkeypress 0x23"); break; new List<byte>().End();
                                            case 0x24: new Process().Set_NirCmd("sendkeypress 0x24"); break; new List<byte>().Home();
                                            case 0x2D: new Process().Set_NirCmd("sendkeypress 0x2D"); break; new List<byte>().Insert();
                                            case 0x2E: new Process().Set_NirCmd("sendkeypress 0x2E"); break; new List<byte>().Delete();
                                            case 0x5B: new Process().Set_NirCmd("sendkeypress 0x5B"); break; new List<byte>().Win(); new List<byte>().WinLeft();
                                            case 0x5C: new Process().Set_NirCmd("sendkeypress 0x5C"); break; new List<byte>().WinRight();
                                            case 0x5D: new Process().Set_NirCmd("sendkeypress 0x5D"); break; new List<byte>().KeyApplication();
                                            case 0x91: new Process().Set_NirCmd("sendkeypress 0x91"); break; new List<byte>().ScrollLock();
                                            case 0x9A: new Process().Set_NirCmd("sendkeypress 0x9A"); break; new List<byte>().PrintScreen();
                                            case 0xBA: new Process().Set_NirCmd("sendkeypress 0xBA"); break; new List<byte>().СommaPoint();
                                            case 0xBB: new Process().Set_NirCmd("sendkeypress 0xBB"); break; new List<byte>().EQUally();
                                            case 0xBC: new Process().Set_NirCmd("sendkeypress 0xBC"); break; new List<byte>().Сomma();
                                            case 0xBD: new Process().Set_NirCmd("sendkeypress 0xBD"); break; new List<byte>().Minus();
                                            case 0xBE: new Process().Set_NirCmd("sendkeypress 0xBE"); break; new List<byte>().Dot();
                                            case 0xBF: new Process().Set_NirCmd("sendkeypress 0xBF"); break; new List<byte>().Slash();
                                            case 0xC0: new Process().Set_NirCmd("sendkeypress 0xC0"); break; new List<byte>().Tilda();
                                            case 0xDB: new Process().Set_NirCmd("sendkeypress 0xDB"); break; new List<byte>().SqueaBraketBegin();
                                            case 0xDC: new Process().Set_NirCmd("sendkeypress 0xDC"); break; new List<byte>().UnSlash();
                                            case 0xDD: new Process().Set_NirCmd("sendkeypress 0xDD"); break; new List<byte>().SqueaBraketEnd();
                                            case 0xDE: new Process().Set_NirCmd("sendkeypress 0xDE"); break; new List<byte>().MarkUno();
                                            ////////////////////////////////////
                                            case 0x25: new Process().Set_NirCmd("sendkeypress 0x25"); break; new List<byte>().ArrowLeft();
                                            case 0x26: new Process().Set_NirCmd("sendkeypress 0x26"); break; new List<byte>().ArrowUp();
                                            case 0x27: new Process().Set_NirCmd("sendkeypress 0x27"); break; new List<byte>().ArrowRight();
                                            case 0x28: new Process().Set_NirCmd("sendkeypress 0x28"); break; new List<byte>().ArrowDown();
                                            //////////////////////////////////////
                                            case 0x30: new Process().Set_NirCmd("sendkeypress 0"); break; new List<byte>()._0();
                                            case 0x31: new Process().Set_NirCmd("sendkeypress 1"); break; new List<byte>()._1();
                                            case 0x32: new Process().Set_NirCmd("sendkeypress 2"); break; new List<byte>()._2();
                                            case 0x33: new Process().Set_NirCmd("sendkeypress 3"); break; new List<byte>()._3();
                                            case 0x34: new Process().Set_NirCmd("sendkeypress 4"); break; new List<byte>()._4();
                                            case 0x35: new Process().Set_NirCmd("sendkeypress 5"); break; new List<byte>()._5();
                                            case 0x36: new Process().Set_NirCmd("sendkeypress 6"); break; new List<byte>()._6();
                                            case 0x37: new Process().Set_NirCmd("sendkeypress 7"); break; new List<byte>()._7();
                                            case 0x38: new Process().Set_NirCmd("sendkeypress 8"); break; new List<byte>()._8();
                                            case 0x39: new Process().Set_NirCmd("sendkeypress 9"); break; new List<byte>()._9();
                                            //////////////////////////////////
                                            case 0x41: new Process().Set_NirCmd("sendkeypress a"); break; new List<byte>().A();
                                            case 0x42: new Process().Set_NirCmd("sendkeypress b"); break; new List<byte>().B();
                                            case 0x43: new Process().Set_NirCmd("sendkeypress c"); break; new List<byte>().C();
                                            case 0x44: new Process().Set_NirCmd("sendkeypress d"); break; new List<byte>().D();
                                            case 0x45: new Process().Set_NirCmd("sendkeypress e"); break; new List<byte>().E();
                                            case 0x46: new Process().Set_NirCmd("sendkeypress f"); break; new List<byte>().F();
                                            case 0x47: new Process().Set_NirCmd("sendkeypress g"); break; new List<byte>().G();
                                            case 0x48: new Process().Set_NirCmd("sendkeypress h"); break; new List<byte>().H();
                                            case 0x49: new Process().Set_NirCmd("sendkeypress i"); break; new List<byte>().I();
                                            case 0x4A: new Process().Set_NirCmd("sendkeypress j"); break; new List<byte>().J();
                                            case 0x4B: new Process().Set_NirCmd("sendkeypress k"); break; new List<byte>().K();
                                            case 0x4C: new Process().Set_NirCmd("sendkeypress l"); break; new List<byte>().L();
                                            case 0x4D: new Process().Set_NirCmd("sendkeypress m"); break; new List<byte>().M();
                                            case 0x4E: new Process().Set_NirCmd("sendkeypress n"); break; new List<byte>().N();
                                            case 0x4F: new Process().Set_NirCmd("sendkeypress o"); break; new List<byte>().O();
                                            case 0x50: new Process().Set_NirCmd("sendkeypress p"); break; new List<byte>().P();
                                            case 0x51: new Process().Set_NirCmd("sendkeypress q"); break; new List<byte>().Q();
                                            case 0x52: new Process().Set_NirCmd("sendkeypress r"); break; new List<byte>().R();
                                            case 0x53: new Process().Set_NirCmd("sendkeypress s"); break; new List<byte>().S();
                                            case 0x54: new Process().Set_NirCmd("sendkeypress t"); break; new List<byte>().T();
                                            case 0x55: new Process().Set_NirCmd("sendkeypress u"); break; new List<byte>().U();
                                            case 0x56: new Process().Set_NirCmd("sendkeypress v"); break; new List<byte>().V();
                                            case 0x57: new Process().Set_NirCmd("sendkeypress w"); break; new List<byte>().W();
                                            case 0x58: new Process().Set_NirCmd("sendkeypress x"); break; new List<byte>().X();
                                            case 0x59: new Process().Set_NirCmd("sendkeypress y"); break; new List<byte>().Y();
                                            case 0x5A: new Process().Set_NirCmd("sendkeypress z"); break; new List<byte>().Z();
                                            ///////new //////////()./////////////////////);
                                            case 0x60: new Process().Set_NirCmd("sendkeypress 0x60"); break; new List<byte>().NumPad0();
                                            case 0x61: new Process().Set_NirCmd("sendkeypress 0x61"); break; new List<byte>().NumPad1();
                                            case 0x62: new Process().Set_NirCmd("sendkeypress 0x62"); break; new List<byte>().NumPad2();
                                            case 0x63: new Process().Set_NirCmd("sendkeypress 0x63"); break; new List<byte>().NumPad3();
                                            case 0x64: new Process().Set_NirCmd("sendkeypress 0x64"); break; new List<byte>().NumPad4();
                                            case 0x65: new Process().Set_NirCmd("sendkeypress 0x65"); break; new List<byte>().NumPad5();
                                            case 0x66: new Process().Set_NirCmd("sendkeypress 0x66"); break; new List<byte>().NumPad6();
                                            case 0x67: new Process().Set_NirCmd("sendkeypress 0x67"); break; new List<byte>().NumPad7();
                                            case 0x68: new Process().Set_NirCmd("sendkeypress 0x68"); break; new List<byte>().NumPad8();
                                            case 0x69: new Process().Set_NirCmd("sendkeypress 0x69"); break; new List<byte>().NumPad9();
                                            case 0x6A: new Process().Set_NirCmd("sendkeypress 0x6A"); break; new List<byte>().NumPadStar();
                                            case 0x6B: new Process().Set_NirCmd("sendkeypress 0x6B"); break; new List<byte>().NumPadPlas();
                                            case 0x6D: new Process().Set_NirCmd("sendkeypress 0x6D"); break; new List<byte>().NumPadMinus();
                                            case 0x6E: new Process().Set_NirCmd("sendkeypress 0x6E"); break; new List<byte>().NumPadDot();
                                            case 0x6F: new Process().Set_NirCmd("sendkeypress 0x6F"); break; new List<byte>().NumPadSlash();
                                            case 0x90: new Process().Set_NirCmd("sendkeypress 0x90"); break; new List<byte>().NumLock();
                                            /////////////////);nircmd sendkeypress
                                            case 0x70: new Process().Set_NirCmd("sendkeypress 0x70"); break; new List<byte>().F1();
                                            case 0x71: new Process().Set_NirCmd("sendkeypress 0x71"); break; new List<byte>().F2();
                                            case 0x72: new Process().Set_NirCmd("sendkeypress 0x72"); break; new List<byte>().F3();
                                            case 0x73: new Process().Set_NirCmd("sendkeypress 0x73"); break; new List<byte>().F4();
                                            case 0x74: new Process().Set_NirCmd("sendkeypress 0x74"); break; new List<byte>().F5();
                                            case 0x75: new Process().Set_NirCmd("sendkeypress 0x75"); break; new List<byte>().F6();
                                            case 0x76: new Process().Set_NirCmd("sendkeypress 0x76"); break; new List<byte>().F7();
                                            case 0x77: new Process().Set_NirCmd("sendkeypress 0x77"); break; new List<byte>().F8();
                                            case 0x78: new Process().Set_NirCmd("sendkeypress 0x78"); break; new List<byte>().F9();
                                            case 0x79: new Process().Set_NirCmd("sendkeypress 0x79"); break; new List<byte>().F10();
                                            case 0x7A: new Process().Set_NirCmd("sendkeypress 0x7A"); break; new List<byte>().F11();
                                            case 0x7B: new Process().Set_NirCmd("sendkeypress 0x7A"); break; new List<byte>().F12();
                                                ///////new //////////());
                                        }
                                        break;
                                    case 0x01:
                                        switch (_Byte4)
                                        {
                                            case 0x01: new Process().Set_NirCmd("setcursor 0 0"); break; new List<byte>().MouseX0();
                                            case 0x02: new Process().Set_NirCmd("movecursor 1 0"); break; new List<byte>().MouseX1();
                                            case 0x03: new Process().Set_NirCmd("movecursor 5 0"); break; new List<byte>().MouseX5();
                                            case 0x04: new Process().Set_NirCmd("movecursor 10 0"); break; new List<byte>().MouseX10();
                                            case 0x05: new Process().Set_NirCmd("movecursor 50 0"); break; new List<byte>().MouseX50();
                                            case 0x06: new Process().Set_NirCmd("movecursor 100 0"); break; new List<byte>().MouseX100();
                                            case 0x07: new Process().Set_NirCmd("movecursor 500 0"); break; new List<byte>().MouseX500();
                                            case 0x08: new Process().Set_NirCmd("movecursor 1000 0"); break; new List<byte>().MouseX1000();
                                            case 0x09: new Process().Set_NirCmd("setcursor 0 0"); break; new List<byte>().MouseY0();
                                            case 0x0A: new Process().Set_NirCmd("movecursor 0 1"); break; new List<byte>().MouseY1();
                                            case 0x0B: new Process().Set_NirCmd("movecursor 0 5"); break; new List<byte>().MouseY5();
                                            case 0x0C: new Process().Set_NirCmd("movecursor 0 10"); break; new List<byte>().MouseY10();
                                            case 0x0D: new Process().Set_NirCmd("movecursor 0 50"); break; new List<byte>().MouseY50();
                                            case 0x0E: new Process().Set_NirCmd("movecursor 0 100"); break; new List<byte>().MouseY100();
                                            case 0x0F: new Process().Set_NirCmd("movecursor 0 500"); break; new List<byte>().MouseY500();
                                            case 0x10: new Process().Set_NirCmd("movecursor 0 1000"); break; new List<byte>().MouseY1000();
                                            case 0x11: System.Threading.Thread.Sleep(25); break; new List<byte>().Sleep25();
                                            case 0x12: System.Threading.Thread.Sleep(50); break; new List<byte>().Sleep50();
                                            case 0x13: System.Threading.Thread.Sleep(100); break; new List<byte>().Sleep100();
                                            case 0x14: System.Threading.Thread.Sleep(500); break; new List<byte>().Sleep500();
                                            case 0x15: System.Threading.Thread.Sleep(1000); break; new List<byte>().Sleep1000();
                                            case 0x16: System.Threading.Thread.Sleep(5000); break; new List<byte>().Sleep5000();
                                            case 0x17: new Process().Set_NirCmd("sendkeypress 0x5B+b"); break; new List<byte>().WinB();
                                            case 0x18: new Process().Set_NirCmd("sendkeypress 0x11+n"); break; new List<byte>().Ctrl();
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                }
            }
            return _this;
        }
    }

}
