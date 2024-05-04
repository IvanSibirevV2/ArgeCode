﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.CMD.NirCMD
{
    public static class NirCMDoor
    {   public static string MousBtnLeft(this string _this) => _this.Add("sendkeypress 0x01").NR();
        public static string MousBtnRight(this string _this) => _this.Add("sendkeypress 0x02").NR();
        public static string MousBtnMiddle(this string _this) => _this.Add("sendkeypress 0x04").NR();
        public static string Backspace(this string _this) => _this.Add("sendkeypress 0x08").NR();
        public static string Tab(this string _this) => _this.Add("sendkeypress 0x09").NR();
        public static string Enter(this string _this) => _this.Add("sendkeypress 0x0D").NR();
        public static string Shift(this string _this) => _this.Add("sendkeypress 0x10").NR();
        public static string Ctrl(this string _this) => _this.Add("sendkeypress 0x11").NR();
        public static string Alt(this string _this) => _this.Add("sendkeypress 0x12").NR();
        public static string Pause(this string _this) => _this.Add("sendkeypress 0x13").NR();
        public static string CapsLock(this string _this) => _this.Add("sendkeypress 0x14").NR();
        public static string Escape(this string _this) => _this.Add("sendkeypress 0x1B").NR();
        public static string Space(this string _this) => _this.Add("sendkeypress 0x20").NR();
        public static string PageUp(this string _this) => _this.Add("sendkeypress 0x21").NR();
        public static string PageDown(this string _this) => _this.Add("sendkeypress 0x22").NR();
        public static string End(this string _this) => _this.Add("sendkeypress 0x23").NR();
        public static string Home(this string _this) => _this.Add("sendkeypress 0x24").NR();
        public static string Insert(this string _this) => _this.Add("sendkeypress 0x2D").NR();
        public static string Delete(this string _this) => _this.Add("sendkeypress 0x2E").NR();
        public static string Win(this string _this) => _this.Add("sendkeypress 0x5B").NR();
        public static string WinRight(this string _this) => _this.Add("sendkeypress 0x5C").NR();
        public static string KeyApplication(this string _this) => _this.Add("sendkeypress 0x5D").NR();
        public static string ScrollLock(this string _this) => _this.Add("sendkeypress 0x91").NR();
        public static string PrintScreen(this string _this) => _this.Add("sendkeypress 0x9A").NR();
        public static string СommaPoint(this string _this) => _this.Add("sendkeypress 0xBA").NR();
        public static string EQUally(this string _this) => _this.Add("sendkeypress 0xBB").NR();
        public static string Сomma(this string _this) => _this.Add("sendkeypress 0xBC").NR();
        public static string Minus(this string _this) => _this.Add("sendkeypress 0xBD").NR();
        public static string Dot(this string _this) => _this.Add("sendkeypress 0xBE").NR();
        public static string Slash(this string _this) => _this.Add("sendkeypress 0xBF").NR();
        public static string Tilda(this string _this) => _this.Add("sendkeypress 0xC0").NR();
        public static string SqueaBraketBegin(this string _this) => _this.Add("sendkeypress 0xDB").NR();
        public static string UnSlash(this string _this) => _this.Add("sendkeypress 0xDC").NR();
        public static string SqueaBraketEnd(this string _this) => _this.Add("sendkeypress 0xDD").NR();
        public static string MarkUno(this string _this) => _this.Add("sendkeypress 0xDE").NR();
        public static string ArrowLeft(this string _this) => _this.Add("sendkeypress 0x25").NR();
        public static string ArrowUp(this string _this) => _this.Add("sendkeypress 0x26").NR();
        public static string ArrowRight(this string _this) => _this.Add("sendkeypress 0x27").NR();
        public static string ArrowDown(this string _this) => _this.Add("sendkeypress 0x28").NR();
        public static string _0(this string _this) => _this.Add("sendkeypress 0").NR();
        public static string _1(this string _this) => _this.Add("sendkeypress 1").NR();
        public static string _2(this string _this) => _this.Add("sendkeypress 2").NR();
        public static string _3(this string _this) => _this.Add("sendkeypress 3").NR();
        public static string _4(this string _this) => _this.Add("sendkeypress 4").NR();
        public static string _5(this string _this) => _this.Add("sendkeypress 5").NR();
        public static string _6(this string _this) => _this.Add("sendkeypress 6").NR();
        public static string _7(this string _this) => _this.Add("sendkeypress 7").NR();
        public static string _8(this string _this) => _this.Add("sendkeypress 8").NR();
        public static string _9(this string _this) => _this.Add("sendkeypress 9").NR();
        public static string A(this string _this) => _this.Add("sendkeypress a").NR();
        public static string B(this string _this) => _this.Add("sendkeypress b").NR();
        public static string C(this string _this) => _this.Add("sendkeypress c").NR();
        public static string D(this string _this) => _this.Add("sendkeypress d").NR();
        public static string E(this string _this) => _this.Add("sendkeypress e").NR();
        public static string F(this string _this) => _this.Add("sendkeypress f").NR();
        public static string G(this string _this) => _this.Add("sendkeypress g").NR();
        public static string H(this string _this) => _this.Add("sendkeypress h").NR();
        public static string I(this string _this) => _this.Add("sendkeypress i").NR();
        public static string J(this string _this) => _this.Add("sendkeypress j").NR();
        public static string K(this string _this) => _this.Add("sendkeypress k").NR();
        public static string L(this string _this) => _this.Add("sendkeypress l").NR();
        public static string M(this string _this) => _this.Add("sendkeypress m").NR();
        public static string N(this string _this) => _this.Add("sendkeypress n").NR();
        public static string O(this string _this) => _this.Add("sendkeypress o").NR();
        public static string P(this string _this) => _this.Add("sendkeypress p").NR();
        public static string Q(this string _this) => _this.Add("sendkeypress q").NR();
        public static string R(this string _this) => _this.Add("sendkeypress r").NR();
        public static string S(this string _this) => _this.Add("sendkeypress s").NR();
        public static string T(this string _this) => _this.Add("sendkeypress t").NR();
        public static string U(this string _this) => _this.Add("sendkeypress u").NR();
        public static string V(this string _this) => _this.Add("sendkeypress v").NR();
        public static string W(this string _this) => _this.Add("sendkeypress w").NR();
        public static string X(this string _this) => _this.Add("sendkeypress x").NR();
        public static string Y(this string _this) => _this.Add("sendkeypress y").NR();
        public static string Z(this string _this) => _this.Add("sendkeypress z").NR();
        public static string NumPad0(this string _this) => _this.Add("sendkeypress 0x60").NR();
        public static string NumPad1(this string _this) => _this.Add("sendkeypress 0x61").NR();
        public static string NumPad2(this string _this) => _this.Add("sendkeypress 0x62").NR();
        public static string NumPad3(this string _this) => _this.Add("sendkeypress 0x63").NR();
        public static string NumPad4(this string _this) => _this.Add("sendkeypress 0x64").NR();
        public static string NumPad5(this string _this) => _this.Add("sendkeypress 0x65").NR();
        public static string NumPad6(this string _this) => _this.Add("sendkeypress 0x66").NR();
        public static string NumPad7(this string _this) => _this.Add("sendkeypress 0x67").NR();
        public static string NumPad8(this string _this) => _this.Add("sendkeypress 0x68").NR();
        public static string NumPad9(this string _this) => _this.Add("sendkeypress 0x69").NR();
        public static string NumPadStar(this string _this) => _this.Add("sendkeypress 0x6A").NR();
        public static string NumPadPlas(this string _this) => _this.Add("sendkeypress 0x6B").NR();
        public static string NumPadMinus(this string _this) => _this.Add("sendkeypress 0x6D").NR();
        public static string NumPadDot(this string _this) => _this.Add("sendkeypress 0x6E").NR();
        public static string NumPadSlash(this string _this) => _this.Add("sendkeypress 0x6F").NR();
        public static string NumLock(this string _this) => _this.Add("sendkeypress 0x90").NR();
        public static string F1(this string _this) => _this.Add("sendkeypress 0x70").NR();
        public static string F2(this string _this) => _this.Add("sendkeypress 0x71").NR();
        public static string F3(this string _this) => _this.Add("sendkeypress 0x72").NR();
        public static string F4(this string _this) => _this.Add("sendkeypress 0x73").NR();
        public static string F5(this string _this) => _this.Add("sendkeypress 0x74").NR();
        public static string F6(this string _this) => _this.Add("sendkeypress 0x75").NR();
        public static string F7(this string _this) => _this.Add("sendkeypress 0x76").NR();
        public static string F8(this string _this) => _this.Add("sendkeypress 0x77").NR();
        public static string F9(this string _this) => _this.Add("sendkeypress 0x78").NR();
        public static string F10(this string _this) => _this.Add("sendkeypress 0x79").NR();
        public static string F11(this string _this) => _this.Add("sendkeypress 0x7A").NR();
        public static string F12(this string _this) => _this.Add("sendkeypress 0x7A").NR();
        public static string MouseX0(this string _this) => _this.Add("setcursor 0 0").NR();
        public static string MouseX1(this string _this) => _this.Add("movecursor 1 0").NR();
        public static string MouseX5(this string _this) => _this.Add("movecursor 5 0").NR();
        public static string MouseX10(this string _this) => _this.Add("movecursor 10 0").NR();
        public static string MouseX50(this string _this) => _this.Add("movecursor 50 0").NR();
        public static string MouseX100(this string _this) => _this.Add("movecursor 100 0").NR();
        public static string MouseX500(this string _this) => _this.Add("movecursor 500 0").NR();
        public static string MouseX1000(this string _this) => _this.Add("movecursor 1000 0").NR();
        public static string MouseY0(this string _this) => _this.Add("setcursor 0 0").NR();
        public static string MouseY1(this string _this) => _this.Add("movecursor 0 1").NR();
        public static string MouseY5(this string _this) => _this.Add("movecursor 0 5").NR();
        public static string MouseY10(this string _this) => _this.Add("movecursor 0 10").NR();
        public static string MouseY50(this string _this) => _this.Add("movecursor 0 50").NR();
        public static string MouseY100(this string _this) => _this.Add("movecursor 0 100").NR();
        public static string MouseY500(this string _this) => _this.Add("movecursor 0 500").NR();
        public static string MouseY1000(this string _this) => _this.Add("movecursor 0 1000").NR();
    }
}