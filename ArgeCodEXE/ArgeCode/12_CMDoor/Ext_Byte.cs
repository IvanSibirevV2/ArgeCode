﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.CMD.NirCMD
{
    public static class Hex
    {
public static byte MousBtnLeft_byte(this int _this) =>0x01;
public static string MousBtnLeft_str(this int _this) =>"0x01";
public static byte MousBtnRight_byte(this int _this) =>0x02;
public static string MousBtnRight_str(this int _this) =>"0x02";
public static byte MousBtnMiddle_byte(this int _this) =>0x04;
public static string MousBtnMiddle_str(this int _this) =>"0x04";
public static byte Backspace_byte(this int _this) =>0x08;
public static string Backspace_str(this int _this) =>"0x08";
public static byte Tab_byte(this int _this) =>0x09;
public static string Tab_str(this int _this) =>"0x09";
public static byte Enter_byte(this int _this) =>0x0D;
public static string Enter_str(this int _this) =>"0x0D";
public static byte Shift_byte(this int _this) =>0x10;
public static string Shift_str(this int _this) =>"0x10";
public static byte Ctrl_byte(this int _this) =>0x11;
public static string Ctrl_str(this int _this) =>"0x11";
public static byte Alt_byte(this int _this) =>0x12;
public static string Alt_str(this int _this) =>"0x12";
public static byte Pause_byte(this int _this) =>0x13;
public static string Pause_str(this int _this) =>"0x13";
public static byte CapsLock_byte(this int _this) =>0x14;
public static string CapsLock_str(this int _this) =>"0x14";
public static byte Escape_byte(this int _this) =>0x1B;
public static string Escape_str(this int _this) =>"0x1B";
public static byte Space_byte(this int _this) =>0x20;
public static string Space_str(this int _this) =>"0x20";
public static byte PageUp_byte(this int _this) =>0x21;
public static string PageUp_str(this int _this) =>"0x21";
public static byte PageDown_byte(this int _this) =>0x22;
public static string PageDown_str(this int _this) =>"0x22";
public static byte End_byte(this int _this) =>0x23;
public static string End_str(this int _this) =>"0x23";
public static byte Home_byte(this int _this) =>0x24;
public static string Home_str(this int _this) =>"0x24";
public static byte Insert_byte(this int _this) =>0x2D;
public static string Insert_str(this int _this) =>"0x2D";
public static byte Delete_byte(this int _this) =>0x2E;
public static string Delete_str(this int _this) =>"0x2E";
public static byte Win_byte(this int _this) =>0x5B;
public static string Win_str(this int _this) =>"0x5B";
public static byte WinRight_byte(this int _this) =>0x5C;
public static string WinRight_str(this int _this) =>"0x5C";
public static byte KeyApplication_byte(this int _this) =>0x5D;
public static string KeyApplication_str(this int _this) =>"0x5D";
public static byte ScrollLock_byte(this int _this) =>0x91;
public static string ScrollLock_str(this int _this) =>"0x91";
public static byte PrintScreen_byte(this int _this) =>0x9A;
public static string PrintScreen_str(this int _this) =>"0x9A";
public static byte СommaPoint_byte(this int _this) =>0xBA;
public static string СommaPoint_str(this int _this) =>"0xBA";
public static byte EQUally_byte(this int _this) =>0xBB;
public static string EQUally_str(this int _this) =>"0xBB";
public static byte Сomma_byte(this int _this) =>0xBC;
public static string Сomma_str(this int _this) =>"0xBC";
public static byte Minus_byte(this int _this) =>0xBD;
public static string Minus_str(this int _this) =>"0xBD";
public static byte Dot_byte(this int _this) =>0xBE;
public static string Dot_str(this int _this) =>"0xBE";
public static byte Slash_byte(this int _this) =>0xBF;
public static string Slash_str(this int _this) =>"0xBF";
public static byte Tilda_byte(this int _this) =>0xC0;
public static string Tilda_str(this int _this) =>"0xC0";
public static byte SqueaBraketBegin_byte(this int _this) =>0xDB;
public static string SqueaBraketBegin_str(this int _this) =>"0xDB";
public static byte UnSlash_byte(this int _this) =>0xDC;
public static string UnSlash_str(this int _this) =>"0xDC";
public static byte SqueaBraketEnd_byte(this int _this) =>0xDD;
public static string SqueaBraketEnd_str(this int _this) =>"0xDD";
public static byte MarkUno_byte(this int _this) =>0xDE;
public static string MarkUno_str(this int _this) =>"0xDE";
public static byte ArrowLeft_byte(this int _this) =>0x25;
public static string ArrowLeft_str(this int _this) =>"0x25";
public static byte ArrowUp_byte(this int _this) =>0x26;
public static string ArrowUp_str(this int _this) =>"0x26";
public static byte ArrowRight_byte(this int _this) =>0x27;
public static string ArrowRight_str(this int _this) =>"0x27";
public static byte ArrowDown_byte(this int _this) =>0x28;
public static string ArrowDown_str(this int _this) =>"0x28";
public static byte _0_byte(this int _this) =>0x30;
public static string _0_str(this int _this) =>"0x30";
public static byte _1_byte(this int _this) =>0x31;
public static string _1_str(this int _this) =>"0x31";
public static byte _2_byte(this int _this) =>0x32;
public static string _2_str(this int _this) =>"0x32";
public static byte _3_byte(this int _this) =>0x33;
public static string _3_str(this int _this) =>"0x33";
public static byte _4_byte(this int _this) =>0x34;
public static string _4_str(this int _this) =>"0x34";
public static byte _5_byte(this int _this) =>0x35;
public static string _5_str(this int _this) =>"0x35";
public static byte _6_byte(this int _this) =>0x36;
public static string _6_str(this int _this) =>"0x36";
public static byte _7_byte(this int _this) =>0x37;
public static string _7_str(this int _this) =>"0x37";
public static byte _8_byte(this int _this) =>0x38;
public static string _8_str(this int _this) =>"0x38";
public static byte _9_byte(this int _this) =>0x39;
public static string _9_str(this int _this) =>"0x39";
public static byte A_byte(this int _this) =>0x41;
public static string A_str(this int _this) =>"0x41";
public static byte B_byte(this int _this) =>0x42;
public static string B_str(this int _this) =>"0x42";
public static byte C_byte(this int _this) =>0x43;
public static string C_str(this int _this) =>"0x43";
public static byte D_byte(this int _this) =>0x44;
public static string D_str(this int _this) =>"0x44";
public static byte E_byte(this int _this) =>0x45;
public static string E_str(this int _this) =>"0x45";
public static byte F_byte(this int _this) =>0x46;
public static string F_str(this int _this) =>"0x46";
public static byte G_byte(this int _this) =>0x47;
public static string G_str(this int _this) =>"0x47";
public static byte H_byte(this int _this) =>0x48;
public static string H_str(this int _this) =>"0x48";
public static byte I_byte(this int _this) =>0x49;
public static string I_str(this int _this) =>"0x49";
public static byte J_byte(this int _this) =>0x4A;
public static string J_str(this int _this) =>"0x4A";
public static byte K_byte(this int _this) =>0x4B;
public static string K_str(this int _this) =>"0x4B";
public static byte L_byte(this int _this) =>0x4C;
public static string L_str(this int _this) =>"0x4C";
public static byte M_byte(this int _this) =>0x4D;
public static string M_str(this int _this) =>"0x4D";
public static byte N_byte(this int _this) =>0x4E;
public static string N_str(this int _this) =>"0x4E";
public static byte O_byte(this int _this) =>0x4F;
public static string O_str(this int _this) =>"0x4F";
public static byte P_byte(this int _this) =>0x50;
public static string P_str(this int _this) =>"0x50";
public static byte Q_byte(this int _this) =>0x51;
public static string Q_str(this int _this) =>"0x51";
public static byte R_byte(this int _this) =>0x52;
public static string R_str(this int _this) =>"0x52";
public static byte S_byte(this int _this) =>0x53;
public static string S_str(this int _this) =>"0x53";
public static byte T_byte(this int _this) =>0x54;
public static string T_str(this int _this) =>"0x54";
public static byte U_byte(this int _this) =>0x55;
public static string U_str(this int _this) =>"0x55";
public static byte V_byte(this int _this) =>0x56;
public static string V_str(this int _this) =>"0x56";
public static byte W_byte(this int _this) =>0x57;
public static string W_str(this int _this) =>"0x57";
public static byte X_byte(this int _this) =>0x58;
public static string X_str(this int _this) =>"0x58";
public static byte Y_byte(this int _this) =>0x59;
public static string Y_str(this int _this) =>"0x59";
public static byte Z_byte(this int _this) =>0x5A;
public static string Z_str(this int _this) =>"0x5A";
public static byte NumPad0_byte(this int _this) =>0x60;
public static string NumPad0_str(this int _this) =>"0x60";
public static byte NumPad1_byte(this int _this) =>0x61;
public static string NumPad1_str(this int _this) =>"0x61";
public static byte NumPad2_byte(this int _this) =>0x62;
public static string NumPad2_str(this int _this) =>"0x62";
public static byte NumPad3_byte(this int _this) =>0x63;
public static string NumPad3_str(this int _this) =>"0x63";
public static byte NumPad4_byte(this int _this) =>0x64;
public static string NumPad4_str(this int _this) =>"0x64";
public static byte NumPad5_byte(this int _this) =>0x65;
public static string NumPad5_str(this int _this) =>"0x65";
public static byte NumPad6_byte(this int _this) =>0x66;
public static string NumPad6_str(this int _this) =>"0x66";
public static byte NumPad7_byte(this int _this) =>0x67;
public static string NumPad7_str(this int _this) =>"0x67";
public static byte NumPad8_byte(this int _this) =>0x68;
public static string NumPad8_str(this int _this) =>"0x68";
public static byte NumPad9_byte(this int _this) =>0x69;
public static string NumPad9_str(this int _this) =>"0x69";
public static byte NumPadStar_byte(this int _this) =>0x6A;
public static string NumPadStar_str(this int _this) =>"0x6A";
public static byte NumPadPlas_byte(this int _this) =>0x6B;
public static string NumPadPlas_str(this int _this) =>"0x6B";
public static byte NumPadMinus_byte(this int _this) =>0x6D;
public static string NumPadMinus_str(this int _this) =>"0x6D";
public static byte NumPadDot_byte(this int _this) =>0x6E;
public static string NumPadDot_str(this int _this) =>"0x6E";
public static byte NumPadSlash_byte(this int _this) =>0x6F;
public static string NumPadSlash_str(this int _this) =>"0x6F";
public static byte NumLock_byte(this int _this) =>0x90;
public static string NumLock_str(this int _this) =>"0x90";
public static byte F1_byte(this int _this) =>0x70;
public static string F1_str(this int _this) =>"0x70";
public static byte F2_byte(this int _this) =>0x71;
public static string F2_str(this int _this) =>"0x71";
public static byte F3_byte(this int _this) =>0x72;
public static string F3_str(this int _this) =>"0x72";
public static byte F4_byte(this int _this) =>0x73;
public static string F4_str(this int _this) =>"0x73";
public static byte F5_byte(this int _this) =>0x74;
public static string F5_str(this int _this) =>"0x74";
public static byte F6_byte(this int _this) =>0x75;
public static string F6_str(this int _this) =>"0x75";
public static byte F7_byte(this int _this) =>0x76;
public static string F7_str(this int _this) =>"0x76";
public static byte F8_byte(this int _this) =>0x77;
public static string F8_str(this int _this) =>"0x77";
public static byte F9_byte(this int _this) =>0x78;
public static string F9_str(this int _this) =>"0x78";
public static byte F10_byte(this int _this) =>0x79;
public static string F10_str(this int _this) =>"0x79";
public static byte F11_byte(this int _this) =>0x7A;
public static string F11_str(this int _this) =>"0x7A";
public static byte F12_byte(this int _this) =>0x7A;
public static string F12_str(this int _this) =>"0x7A";
    }
}
