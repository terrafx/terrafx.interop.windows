// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e"]/*' />
public enum CV_HREG_e
{
    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALLREG_ERR"]/*' />
    CV_ALLREG_ERR = 30000,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALLREG_TEB"]/*' />
    CV_ALLREG_TEB = 30001,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALLREG_TIMER"]/*' />
    CV_ALLREG_TIMER = 30002,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALLREG_EFAD1"]/*' />
    CV_ALLREG_EFAD1 = 30003,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALLREG_EFAD2"]/*' />
    CV_ALLREG_EFAD2 = 30004,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALLREG_EFAD3"]/*' />
    CV_ALLREG_EFAD3 = 30005,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALLREG_VFRAME"]/*' />
    CV_ALLREG_VFRAME = 30006,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALLREG_HANDLE"]/*' />
    CV_ALLREG_HANDLE = 30007,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALLREG_PARAMS"]/*' />
    CV_ALLREG_PARAMS = 30008,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALLREG_LOCALS"]/*' />
    CV_ALLREG_LOCALS = 30009,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALLREG_TID"]/*' />
    CV_ALLREG_TID = 30010,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALLREG_ENV"]/*' />
    CV_ALLREG_ENV = 30011,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALLREG_CMDLN"]/*' />
    CV_ALLREG_CMDLN = 30012,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_NONE"]/*' />
    CV_REG_NONE = 0,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_AL"]/*' />
    CV_REG_AL = 1,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_CL"]/*' />
    CV_REG_CL = 2,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_DL"]/*' />
    CV_REG_DL = 3,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_BL"]/*' />
    CV_REG_BL = 4,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_AH"]/*' />
    CV_REG_AH = 5,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_CH"]/*' />
    CV_REG_CH = 6,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_DH"]/*' />
    CV_REG_DH = 7,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_BH"]/*' />
    CV_REG_BH = 8,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_AX"]/*' />
    CV_REG_AX = 9,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_CX"]/*' />
    CV_REG_CX = 10,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_DX"]/*' />
    CV_REG_DX = 11,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_BX"]/*' />
    CV_REG_BX = 12,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_SP"]/*' />
    CV_REG_SP = 13,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_BP"]/*' />
    CV_REG_BP = 14,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_SI"]/*' />
    CV_REG_SI = 15,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_DI"]/*' />
    CV_REG_DI = 16,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EAX"]/*' />
    CV_REG_EAX = 17,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ECX"]/*' />
    CV_REG_ECX = 18,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EDX"]/*' />
    CV_REG_EDX = 19,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EBX"]/*' />
    CV_REG_EBX = 20,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ESP"]/*' />
    CV_REG_ESP = 21,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EBP"]/*' />
    CV_REG_EBP = 22,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ESI"]/*' />
    CV_REG_ESI = 23,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EDI"]/*' />
    CV_REG_EDI = 24,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ES"]/*' />
    CV_REG_ES = 25,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_CS"]/*' />
    CV_REG_CS = 26,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_SS"]/*' />
    CV_REG_SS = 27,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_DS"]/*' />
    CV_REG_DS = 28,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_FS"]/*' />
    CV_REG_FS = 29,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_GS"]/*' />
    CV_REG_GS = 30,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_IP"]/*' />
    CV_REG_IP = 31,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_FLAGS"]/*' />
    CV_REG_FLAGS = 32,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EIP"]/*' />
    CV_REG_EIP = 33,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EFLAGS"]/*' />
    CV_REG_EFLAGS = 34,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_TEMP"]/*' />
    CV_REG_TEMP = 40,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_TEMPH"]/*' />
    CV_REG_TEMPH = 41,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_QUOTE"]/*' />
    CV_REG_QUOTE = 42,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_PCDR3"]/*' />
    CV_REG_PCDR3 = 43,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_PCDR4"]/*' />
    CV_REG_PCDR4 = 44,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_PCDR5"]/*' />
    CV_REG_PCDR5 = 45,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_PCDR6"]/*' />
    CV_REG_PCDR6 = 46,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_PCDR7"]/*' />
    CV_REG_PCDR7 = 47,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_CR0"]/*' />
    CV_REG_CR0 = 80,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_CR1"]/*' />
    CV_REG_CR1 = 81,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_CR2"]/*' />
    CV_REG_CR2 = 82,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_CR3"]/*' />
    CV_REG_CR3 = 83,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_CR4"]/*' />
    CV_REG_CR4 = 84,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_DR0"]/*' />
    CV_REG_DR0 = 90,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_DR1"]/*' />
    CV_REG_DR1 = 91,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_DR2"]/*' />
    CV_REG_DR2 = 92,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_DR3"]/*' />
    CV_REG_DR3 = 93,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_DR4"]/*' />
    CV_REG_DR4 = 94,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_DR5"]/*' />
    CV_REG_DR5 = 95,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_DR6"]/*' />
    CV_REG_DR6 = 96,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_DR7"]/*' />
    CV_REG_DR7 = 97,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_GDTR"]/*' />
    CV_REG_GDTR = 110,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_GDTL"]/*' />
    CV_REG_GDTL = 111,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_IDTR"]/*' />
    CV_REG_IDTR = 112,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_IDTL"]/*' />
    CV_REG_IDTL = 113,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_LDTR"]/*' />
    CV_REG_LDTR = 114,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_TR"]/*' />
    CV_REG_TR = 115,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_PSEUDO1"]/*' />
    CV_REG_PSEUDO1 = 116,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_PSEUDO2"]/*' />
    CV_REG_PSEUDO2 = 117,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_PSEUDO3"]/*' />
    CV_REG_PSEUDO3 = 118,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_PSEUDO4"]/*' />
    CV_REG_PSEUDO4 = 119,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_PSEUDO5"]/*' />
    CV_REG_PSEUDO5 = 120,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_PSEUDO6"]/*' />
    CV_REG_PSEUDO6 = 121,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_PSEUDO7"]/*' />
    CV_REG_PSEUDO7 = 122,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_PSEUDO8"]/*' />
    CV_REG_PSEUDO8 = 123,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_PSEUDO9"]/*' />
    CV_REG_PSEUDO9 = 124,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ST0"]/*' />
    CV_REG_ST0 = 128,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ST1"]/*' />
    CV_REG_ST1 = 129,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ST2"]/*' />
    CV_REG_ST2 = 130,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ST3"]/*' />
    CV_REG_ST3 = 131,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ST4"]/*' />
    CV_REG_ST4 = 132,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ST5"]/*' />
    CV_REG_ST5 = 133,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ST6"]/*' />
    CV_REG_ST6 = 134,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ST7"]/*' />
    CV_REG_ST7 = 135,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_CTRL"]/*' />
    CV_REG_CTRL = 136,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_STAT"]/*' />
    CV_REG_STAT = 137,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_TAG"]/*' />
    CV_REG_TAG = 138,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_FPIP"]/*' />
    CV_REG_FPIP = 139,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_FPCS"]/*' />
    CV_REG_FPCS = 140,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_FPDO"]/*' />
    CV_REG_FPDO = 141,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_FPDS"]/*' />
    CV_REG_FPDS = 142,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ISEM"]/*' />
    CV_REG_ISEM = 143,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_FPEIP"]/*' />
    CV_REG_FPEIP = 144,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_FPEDO"]/*' />
    CV_REG_FPEDO = 145,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM0"]/*' />
    CV_REG_MM0 = 146,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM1"]/*' />
    CV_REG_MM1 = 147,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM2"]/*' />
    CV_REG_MM2 = 148,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM3"]/*' />
    CV_REG_MM3 = 149,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM4"]/*' />
    CV_REG_MM4 = 150,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM5"]/*' />
    CV_REG_MM5 = 151,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM6"]/*' />
    CV_REG_MM6 = 152,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM7"]/*' />
    CV_REG_MM7 = 153,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM0"]/*' />
    CV_REG_XMM0 = 154,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM1"]/*' />
    CV_REG_XMM1 = 155,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM2"]/*' />
    CV_REG_XMM2 = 156,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM3"]/*' />
    CV_REG_XMM3 = 157,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM4"]/*' />
    CV_REG_XMM4 = 158,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM5"]/*' />
    CV_REG_XMM5 = 159,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM6"]/*' />
    CV_REG_XMM6 = 160,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM7"]/*' />
    CV_REG_XMM7 = 161,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM00"]/*' />
    CV_REG_XMM00 = 162,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM01"]/*' />
    CV_REG_XMM01 = 163,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM02"]/*' />
    CV_REG_XMM02 = 164,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM03"]/*' />
    CV_REG_XMM03 = 165,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM10"]/*' />
    CV_REG_XMM10 = 166,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM11"]/*' />
    CV_REG_XMM11 = 167,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM12"]/*' />
    CV_REG_XMM12 = 168,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM13"]/*' />
    CV_REG_XMM13 = 169,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM20"]/*' />
    CV_REG_XMM20 = 170,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM21"]/*' />
    CV_REG_XMM21 = 171,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM22"]/*' />
    CV_REG_XMM22 = 172,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM23"]/*' />
    CV_REG_XMM23 = 173,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM30"]/*' />
    CV_REG_XMM30 = 174,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM31"]/*' />
    CV_REG_XMM31 = 175,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM32"]/*' />
    CV_REG_XMM32 = 176,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM33"]/*' />
    CV_REG_XMM33 = 177,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM40"]/*' />
    CV_REG_XMM40 = 178,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM41"]/*' />
    CV_REG_XMM41 = 179,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM42"]/*' />
    CV_REG_XMM42 = 180,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM43"]/*' />
    CV_REG_XMM43 = 181,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM50"]/*' />
    CV_REG_XMM50 = 182,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM51"]/*' />
    CV_REG_XMM51 = 183,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM52"]/*' />
    CV_REG_XMM52 = 184,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM53"]/*' />
    CV_REG_XMM53 = 185,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM60"]/*' />
    CV_REG_XMM60 = 186,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM61"]/*' />
    CV_REG_XMM61 = 187,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM62"]/*' />
    CV_REG_XMM62 = 188,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM63"]/*' />
    CV_REG_XMM63 = 189,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM70"]/*' />
    CV_REG_XMM70 = 190,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM71"]/*' />
    CV_REG_XMM71 = 191,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM72"]/*' />
    CV_REG_XMM72 = 192,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM73"]/*' />
    CV_REG_XMM73 = 193,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM0L"]/*' />
    CV_REG_XMM0L = 194,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM1L"]/*' />
    CV_REG_XMM1L = 195,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM2L"]/*' />
    CV_REG_XMM2L = 196,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM3L"]/*' />
    CV_REG_XMM3L = 197,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM4L"]/*' />
    CV_REG_XMM4L = 198,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM5L"]/*' />
    CV_REG_XMM5L = 199,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM6L"]/*' />
    CV_REG_XMM6L = 200,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM7L"]/*' />
    CV_REG_XMM7L = 201,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM0H"]/*' />
    CV_REG_XMM0H = 202,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM1H"]/*' />
    CV_REG_XMM1H = 203,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM2H"]/*' />
    CV_REG_XMM2H = 204,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM3H"]/*' />
    CV_REG_XMM3H = 205,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM4H"]/*' />
    CV_REG_XMM4H = 206,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM5H"]/*' />
    CV_REG_XMM5H = 207,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM6H"]/*' />
    CV_REG_XMM6H = 208,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_XMM7H"]/*' />
    CV_REG_XMM7H = 209,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MXCSR"]/*' />
    CV_REG_MXCSR = 211,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EDXEAX"]/*' />
    CV_REG_EDXEAX = 212,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EMM0L"]/*' />
    CV_REG_EMM0L = 220,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EMM1L"]/*' />
    CV_REG_EMM1L = 221,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EMM2L"]/*' />
    CV_REG_EMM2L = 222,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EMM3L"]/*' />
    CV_REG_EMM3L = 223,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EMM4L"]/*' />
    CV_REG_EMM4L = 224,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EMM5L"]/*' />
    CV_REG_EMM5L = 225,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EMM6L"]/*' />
    CV_REG_EMM6L = 226,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EMM7L"]/*' />
    CV_REG_EMM7L = 227,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EMM0H"]/*' />
    CV_REG_EMM0H = 228,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EMM1H"]/*' />
    CV_REG_EMM1H = 229,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EMM2H"]/*' />
    CV_REG_EMM2H = 230,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EMM3H"]/*' />
    CV_REG_EMM3H = 231,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EMM4H"]/*' />
    CV_REG_EMM4H = 232,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EMM5H"]/*' />
    CV_REG_EMM5H = 233,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EMM6H"]/*' />
    CV_REG_EMM6H = 234,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_EMM7H"]/*' />
    CV_REG_EMM7H = 235,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM00"]/*' />
    CV_REG_MM00 = 236,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM01"]/*' />
    CV_REG_MM01 = 237,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM10"]/*' />
    CV_REG_MM10 = 238,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM11"]/*' />
    CV_REG_MM11 = 239,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM20"]/*' />
    CV_REG_MM20 = 240,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM21"]/*' />
    CV_REG_MM21 = 241,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM30"]/*' />
    CV_REG_MM30 = 242,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM31"]/*' />
    CV_REG_MM31 = 243,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM40"]/*' />
    CV_REG_MM40 = 244,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM41"]/*' />
    CV_REG_MM41 = 245,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM50"]/*' />
    CV_REG_MM50 = 246,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM51"]/*' />
    CV_REG_MM51 = 247,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM60"]/*' />
    CV_REG_MM60 = 248,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM61"]/*' />
    CV_REG_MM61 = 249,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM70"]/*' />
    CV_REG_MM70 = 250,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_MM71"]/*' />
    CV_REG_MM71 = 251,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0"]/*' />
    CV_REG_YMM0 = 252,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1"]/*' />
    CV_REG_YMM1 = 253,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2"]/*' />
    CV_REG_YMM2 = 254,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3"]/*' />
    CV_REG_YMM3 = 255,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4"]/*' />
    CV_REG_YMM4 = 256,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5"]/*' />
    CV_REG_YMM5 = 257,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6"]/*' />
    CV_REG_YMM6 = 258,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7"]/*' />
    CV_REG_YMM7 = 259,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0H"]/*' />
    CV_REG_YMM0H = 260,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1H"]/*' />
    CV_REG_YMM1H = 261,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2H"]/*' />
    CV_REG_YMM2H = 262,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3H"]/*' />
    CV_REG_YMM3H = 263,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4H"]/*' />
    CV_REG_YMM4H = 264,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5H"]/*' />
    CV_REG_YMM5H = 265,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6H"]/*' />
    CV_REG_YMM6H = 266,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7H"]/*' />
    CV_REG_YMM7H = 267,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0I0"]/*' />
    CV_REG_YMM0I0 = 268,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0I1"]/*' />
    CV_REG_YMM0I1 = 269,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0I2"]/*' />
    CV_REG_YMM0I2 = 270,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0I3"]/*' />
    CV_REG_YMM0I3 = 271,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1I0"]/*' />
    CV_REG_YMM1I0 = 272,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1I1"]/*' />
    CV_REG_YMM1I1 = 273,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1I2"]/*' />
    CV_REG_YMM1I2 = 274,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1I3"]/*' />
    CV_REG_YMM1I3 = 275,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2I0"]/*' />
    CV_REG_YMM2I0 = 276,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2I1"]/*' />
    CV_REG_YMM2I1 = 277,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2I2"]/*' />
    CV_REG_YMM2I2 = 278,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2I3"]/*' />
    CV_REG_YMM2I3 = 279,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3I0"]/*' />
    CV_REG_YMM3I0 = 280,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3I1"]/*' />
    CV_REG_YMM3I1 = 281,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3I2"]/*' />
    CV_REG_YMM3I2 = 282,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3I3"]/*' />
    CV_REG_YMM3I3 = 283,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4I0"]/*' />
    CV_REG_YMM4I0 = 284,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4I1"]/*' />
    CV_REG_YMM4I1 = 285,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4I2"]/*' />
    CV_REG_YMM4I2 = 286,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4I3"]/*' />
    CV_REG_YMM4I3 = 287,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5I0"]/*' />
    CV_REG_YMM5I0 = 288,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5I1"]/*' />
    CV_REG_YMM5I1 = 289,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5I2"]/*' />
    CV_REG_YMM5I2 = 290,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5I3"]/*' />
    CV_REG_YMM5I3 = 291,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6I0"]/*' />
    CV_REG_YMM6I0 = 292,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6I1"]/*' />
    CV_REG_YMM6I1 = 293,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6I2"]/*' />
    CV_REG_YMM6I2 = 294,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6I3"]/*' />
    CV_REG_YMM6I3 = 295,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7I0"]/*' />
    CV_REG_YMM7I0 = 296,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7I1"]/*' />
    CV_REG_YMM7I1 = 297,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7I2"]/*' />
    CV_REG_YMM7I2 = 298,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7I3"]/*' />
    CV_REG_YMM7I3 = 299,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0F0"]/*' />
    CV_REG_YMM0F0 = 300,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0F1"]/*' />
    CV_REG_YMM0F1 = 301,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0F2"]/*' />
    CV_REG_YMM0F2 = 302,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0F3"]/*' />
    CV_REG_YMM0F3 = 303,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0F4"]/*' />
    CV_REG_YMM0F4 = 304,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0F5"]/*' />
    CV_REG_YMM0F5 = 305,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0F6"]/*' />
    CV_REG_YMM0F6 = 306,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0F7"]/*' />
    CV_REG_YMM0F7 = 307,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1F0"]/*' />
    CV_REG_YMM1F0 = 308,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1F1"]/*' />
    CV_REG_YMM1F1 = 309,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1F2"]/*' />
    CV_REG_YMM1F2 = 310,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1F3"]/*' />
    CV_REG_YMM1F3 = 311,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1F4"]/*' />
    CV_REG_YMM1F4 = 312,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1F5"]/*' />
    CV_REG_YMM1F5 = 313,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1F6"]/*' />
    CV_REG_YMM1F6 = 314,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1F7"]/*' />
    CV_REG_YMM1F7 = 315,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2F0"]/*' />
    CV_REG_YMM2F0 = 316,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2F1"]/*' />
    CV_REG_YMM2F1 = 317,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2F2"]/*' />
    CV_REG_YMM2F2 = 318,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2F3"]/*' />
    CV_REG_YMM2F3 = 319,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2F4"]/*' />
    CV_REG_YMM2F4 = 320,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2F5"]/*' />
    CV_REG_YMM2F5 = 321,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2F6"]/*' />
    CV_REG_YMM2F6 = 322,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2F7"]/*' />
    CV_REG_YMM2F7 = 323,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3F0"]/*' />
    CV_REG_YMM3F0 = 324,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3F1"]/*' />
    CV_REG_YMM3F1 = 325,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3F2"]/*' />
    CV_REG_YMM3F2 = 326,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3F3"]/*' />
    CV_REG_YMM3F3 = 327,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3F4"]/*' />
    CV_REG_YMM3F4 = 328,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3F5"]/*' />
    CV_REG_YMM3F5 = 329,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3F6"]/*' />
    CV_REG_YMM3F6 = 330,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3F7"]/*' />
    CV_REG_YMM3F7 = 331,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4F0"]/*' />
    CV_REG_YMM4F0 = 332,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4F1"]/*' />
    CV_REG_YMM4F1 = 333,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4F2"]/*' />
    CV_REG_YMM4F2 = 334,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4F3"]/*' />
    CV_REG_YMM4F3 = 335,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4F4"]/*' />
    CV_REG_YMM4F4 = 336,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4F5"]/*' />
    CV_REG_YMM4F5 = 337,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4F6"]/*' />
    CV_REG_YMM4F6 = 338,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4F7"]/*' />
    CV_REG_YMM4F7 = 339,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5F0"]/*' />
    CV_REG_YMM5F0 = 340,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5F1"]/*' />
    CV_REG_YMM5F1 = 341,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5F2"]/*' />
    CV_REG_YMM5F2 = 342,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5F3"]/*' />
    CV_REG_YMM5F3 = 343,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5F4"]/*' />
    CV_REG_YMM5F4 = 344,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5F5"]/*' />
    CV_REG_YMM5F5 = 345,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5F6"]/*' />
    CV_REG_YMM5F6 = 346,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5F7"]/*' />
    CV_REG_YMM5F7 = 347,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6F0"]/*' />
    CV_REG_YMM6F0 = 348,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6F1"]/*' />
    CV_REG_YMM6F1 = 349,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6F2"]/*' />
    CV_REG_YMM6F2 = 350,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6F3"]/*' />
    CV_REG_YMM6F3 = 351,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6F4"]/*' />
    CV_REG_YMM6F4 = 352,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6F5"]/*' />
    CV_REG_YMM6F5 = 353,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6F6"]/*' />
    CV_REG_YMM6F6 = 354,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6F7"]/*' />
    CV_REG_YMM6F7 = 355,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7F0"]/*' />
    CV_REG_YMM7F0 = 356,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7F1"]/*' />
    CV_REG_YMM7F1 = 357,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7F2"]/*' />
    CV_REG_YMM7F2 = 358,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7F3"]/*' />
    CV_REG_YMM7F3 = 359,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7F4"]/*' />
    CV_REG_YMM7F4 = 360,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7F5"]/*' />
    CV_REG_YMM7F5 = 361,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7F6"]/*' />
    CV_REG_YMM7F6 = 362,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7F7"]/*' />
    CV_REG_YMM7F7 = 363,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0D0"]/*' />
    CV_REG_YMM0D0 = 364,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0D1"]/*' />
    CV_REG_YMM0D1 = 365,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0D2"]/*' />
    CV_REG_YMM0D2 = 366,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM0D3"]/*' />
    CV_REG_YMM0D3 = 367,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1D0"]/*' />
    CV_REG_YMM1D0 = 368,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1D1"]/*' />
    CV_REG_YMM1D1 = 369,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1D2"]/*' />
    CV_REG_YMM1D2 = 370,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM1D3"]/*' />
    CV_REG_YMM1D3 = 371,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2D0"]/*' />
    CV_REG_YMM2D0 = 372,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2D1"]/*' />
    CV_REG_YMM2D1 = 373,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2D2"]/*' />
    CV_REG_YMM2D2 = 374,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM2D3"]/*' />
    CV_REG_YMM2D3 = 375,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3D0"]/*' />
    CV_REG_YMM3D0 = 376,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3D1"]/*' />
    CV_REG_YMM3D1 = 377,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3D2"]/*' />
    CV_REG_YMM3D2 = 378,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM3D3"]/*' />
    CV_REG_YMM3D3 = 379,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4D0"]/*' />
    CV_REG_YMM4D0 = 380,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4D1"]/*' />
    CV_REG_YMM4D1 = 381,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4D2"]/*' />
    CV_REG_YMM4D2 = 382,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM4D3"]/*' />
    CV_REG_YMM4D3 = 383,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5D0"]/*' />
    CV_REG_YMM5D0 = 384,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5D1"]/*' />
    CV_REG_YMM5D1 = 385,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5D2"]/*' />
    CV_REG_YMM5D2 = 386,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM5D3"]/*' />
    CV_REG_YMM5D3 = 387,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6D0"]/*' />
    CV_REG_YMM6D0 = 388,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6D1"]/*' />
    CV_REG_YMM6D1 = 389,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6D2"]/*' />
    CV_REG_YMM6D2 = 390,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM6D3"]/*' />
    CV_REG_YMM6D3 = 391,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7D0"]/*' />
    CV_REG_YMM7D0 = 392,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7D1"]/*' />
    CV_REG_YMM7D1 = 393,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7D2"]/*' />
    CV_REG_YMM7D2 = 394,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_YMM7D3"]/*' />
    CV_REG_YMM7D3 = 395,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_BND0"]/*' />
    CV_REG_BND0 = 396,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_BND1"]/*' />
    CV_REG_BND1 = 397,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_BND2"]/*' />
    CV_REG_BND2 = 398,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_BND3"]/*' />
    CV_REG_BND3 = 399,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_BNDCFGU"]/*' />
    CV_REG_BNDCFGU = 400,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_BNDSTATUS"]/*' />
    CV_REG_BNDSTATUS = 401,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ZMM0"]/*' />
    CV_REG_ZMM0 = 402,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ZMM1"]/*' />
    CV_REG_ZMM1 = 403,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ZMM2"]/*' />
    CV_REG_ZMM2 = 404,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ZMM3"]/*' />
    CV_REG_ZMM3 = 405,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ZMM4"]/*' />
    CV_REG_ZMM4 = 406,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ZMM5"]/*' />
    CV_REG_ZMM5 = 407,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ZMM6"]/*' />
    CV_REG_ZMM6 = 408,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ZMM7"]/*' />
    CV_REG_ZMM7 = 409,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ZMM0H"]/*' />
    CV_REG_ZMM0H = 410,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ZMM1H"]/*' />
    CV_REG_ZMM1H = 411,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ZMM2H"]/*' />
    CV_REG_ZMM2H = 412,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ZMM3H"]/*' />
    CV_REG_ZMM3H = 413,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ZMM4H"]/*' />
    CV_REG_ZMM4H = 414,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ZMM5H"]/*' />
    CV_REG_ZMM5H = 415,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ZMM6H"]/*' />
    CV_REG_ZMM6H = 416,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_ZMM7H"]/*' />
    CV_REG_ZMM7H = 417,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_K0"]/*' />
    CV_REG_K0 = 418,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_K1"]/*' />
    CV_REG_K1 = 419,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_K2"]/*' />
    CV_REG_K2 = 420,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_K3"]/*' />
    CV_REG_K3 = 421,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_K4"]/*' />
    CV_REG_K4 = 422,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_K5"]/*' />
    CV_REG_K5 = 423,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_K6"]/*' />
    CV_REG_K6 = 424,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_K7"]/*' />
    CV_REG_K7 = 425,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_REG_SSP"]/*' />
    CV_REG_SSP = 426,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_D0"]/*' />
    CV_R68_D0 = 0,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_D1"]/*' />
    CV_R68_D1 = 1,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_D2"]/*' />
    CV_R68_D2 = 2,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_D3"]/*' />
    CV_R68_D3 = 3,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_D4"]/*' />
    CV_R68_D4 = 4,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_D5"]/*' />
    CV_R68_D5 = 5,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_D6"]/*' />
    CV_R68_D6 = 6,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_D7"]/*' />
    CV_R68_D7 = 7,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_A0"]/*' />
    CV_R68_A0 = 8,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_A1"]/*' />
    CV_R68_A1 = 9,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_A2"]/*' />
    CV_R68_A2 = 10,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_A3"]/*' />
    CV_R68_A3 = 11,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_A4"]/*' />
    CV_R68_A4 = 12,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_A5"]/*' />
    CV_R68_A5 = 13,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_A6"]/*' />
    CV_R68_A6 = 14,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_A7"]/*' />
    CV_R68_A7 = 15,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_CCR"]/*' />
    CV_R68_CCR = 16,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_SR"]/*' />
    CV_R68_SR = 17,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_USP"]/*' />
    CV_R68_USP = 18,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_MSP"]/*' />
    CV_R68_MSP = 19,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_SFC"]/*' />
    CV_R68_SFC = 20,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_DFC"]/*' />
    CV_R68_DFC = 21,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_CACR"]/*' />
    CV_R68_CACR = 22,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_VBR"]/*' />
    CV_R68_VBR = 23,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_CAAR"]/*' />
    CV_R68_CAAR = 24,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_ISP"]/*' />
    CV_R68_ISP = 25,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_PC"]/*' />
    CV_R68_PC = 26,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_FPCR"]/*' />
    CV_R68_FPCR = 28,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_FPSR"]/*' />
    CV_R68_FPSR = 29,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_FPIAR"]/*' />
    CV_R68_FPIAR = 30,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_FP0"]/*' />
    CV_R68_FP0 = 32,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_FP1"]/*' />
    CV_R68_FP1 = 33,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_FP2"]/*' />
    CV_R68_FP2 = 34,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_FP3"]/*' />
    CV_R68_FP3 = 35,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_FP4"]/*' />
    CV_R68_FP4 = 36,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_FP5"]/*' />
    CV_R68_FP5 = 37,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_FP6"]/*' />
    CV_R68_FP6 = 38,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_FP7"]/*' />
    CV_R68_FP7 = 39,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_MMUSR030"]/*' />
    CV_R68_MMUSR030 = 41,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_MMUSR"]/*' />
    CV_R68_MMUSR = 42,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_URP"]/*' />
    CV_R68_URP = 43,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_DTT0"]/*' />
    CV_R68_DTT0 = 44,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_DTT1"]/*' />
    CV_R68_DTT1 = 45,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_ITT0"]/*' />
    CV_R68_ITT0 = 46,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_ITT1"]/*' />
    CV_R68_ITT1 = 47,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_PSR"]/*' />
    CV_R68_PSR = 51,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_PCSR"]/*' />
    CV_R68_PCSR = 52,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_VAL"]/*' />
    CV_R68_VAL = 53,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_CRP"]/*' />
    CV_R68_CRP = 54,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_SRP"]/*' />
    CV_R68_SRP = 55,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_DRP"]/*' />
    CV_R68_DRP = 56,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_TC"]/*' />
    CV_R68_TC = 57,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_AC"]/*' />
    CV_R68_AC = 58,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_SCC"]/*' />
    CV_R68_SCC = 59,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_CAL"]/*' />
    CV_R68_CAL = 60,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_TT0"]/*' />
    CV_R68_TT0 = 61,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_TT1"]/*' />
    CV_R68_TT1 = 62,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_BAD0"]/*' />
    CV_R68_BAD0 = 64,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_BAD1"]/*' />
    CV_R68_BAD1 = 65,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_BAD2"]/*' />
    CV_R68_BAD2 = 66,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_BAD3"]/*' />
    CV_R68_BAD3 = 67,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_BAD4"]/*' />
    CV_R68_BAD4 = 68,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_BAD5"]/*' />
    CV_R68_BAD5 = 69,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_BAD6"]/*' />
    CV_R68_BAD6 = 70,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_BAD7"]/*' />
    CV_R68_BAD7 = 71,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_BAC0"]/*' />
    CV_R68_BAC0 = 72,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_BAC1"]/*' />
    CV_R68_BAC1 = 73,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_BAC2"]/*' />
    CV_R68_BAC2 = 74,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_BAC3"]/*' />
    CV_R68_BAC3 = 75,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_BAC4"]/*' />
    CV_R68_BAC4 = 76,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_BAC5"]/*' />
    CV_R68_BAC5 = 77,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_BAC6"]/*' />
    CV_R68_BAC6 = 78,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_R68_BAC7"]/*' />
    CV_R68_BAC7 = 79,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_NOREG"]/*' />
    CV_M4_NOREG = CV_REG_NONE,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntZERO"]/*' />
    CV_M4_IntZERO = 10,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntAT"]/*' />
    CV_M4_IntAT = 11,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntV0"]/*' />
    CV_M4_IntV0 = 12,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntV1"]/*' />
    CV_M4_IntV1 = 13,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntA0"]/*' />
    CV_M4_IntA0 = 14,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntA1"]/*' />
    CV_M4_IntA1 = 15,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntA2"]/*' />
    CV_M4_IntA2 = 16,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntA3"]/*' />
    CV_M4_IntA3 = 17,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntT0"]/*' />
    CV_M4_IntT0 = 18,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntT1"]/*' />
    CV_M4_IntT1 = 19,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntT2"]/*' />
    CV_M4_IntT2 = 20,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntT3"]/*' />
    CV_M4_IntT3 = 21,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntT4"]/*' />
    CV_M4_IntT4 = 22,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntT5"]/*' />
    CV_M4_IntT5 = 23,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntT6"]/*' />
    CV_M4_IntT6 = 24,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntT7"]/*' />
    CV_M4_IntT7 = 25,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntS0"]/*' />
    CV_M4_IntS0 = 26,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntS1"]/*' />
    CV_M4_IntS1 = 27,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntS2"]/*' />
    CV_M4_IntS2 = 28,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntS3"]/*' />
    CV_M4_IntS3 = 29,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntS4"]/*' />
    CV_M4_IntS4 = 30,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntS5"]/*' />
    CV_M4_IntS5 = 31,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntS6"]/*' />
    CV_M4_IntS6 = 32,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntS7"]/*' />
    CV_M4_IntS7 = 33,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntT8"]/*' />
    CV_M4_IntT8 = 34,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntT9"]/*' />
    CV_M4_IntT9 = 35,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntKT0"]/*' />
    CV_M4_IntKT0 = 36,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntKT1"]/*' />
    CV_M4_IntKT1 = 37,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntGP"]/*' />
    CV_M4_IntGP = 38,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntSP"]/*' />
    CV_M4_IntSP = 39,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntS8"]/*' />
    CV_M4_IntS8 = 40,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntRA"]/*' />
    CV_M4_IntRA = 41,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntLO"]/*' />
    CV_M4_IntLO = 42,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_IntHI"]/*' />
    CV_M4_IntHI = 43,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_Fir"]/*' />
    CV_M4_Fir = 50,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_Psr"]/*' />
    CV_M4_Psr = 51,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF0"]/*' />
    CV_M4_FltF0 = 60,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF1"]/*' />
    CV_M4_FltF1 = 61,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF2"]/*' />
    CV_M4_FltF2 = 62,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF3"]/*' />
    CV_M4_FltF3 = 63,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF4"]/*' />
    CV_M4_FltF4 = 64,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF5"]/*' />
    CV_M4_FltF5 = 65,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF6"]/*' />
    CV_M4_FltF6 = 66,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF7"]/*' />
    CV_M4_FltF7 = 67,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF8"]/*' />
    CV_M4_FltF8 = 68,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF9"]/*' />
    CV_M4_FltF9 = 69,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF10"]/*' />
    CV_M4_FltF10 = 70,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF11"]/*' />
    CV_M4_FltF11 = 71,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF12"]/*' />
    CV_M4_FltF12 = 72,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF13"]/*' />
    CV_M4_FltF13 = 73,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF14"]/*' />
    CV_M4_FltF14 = 74,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF15"]/*' />
    CV_M4_FltF15 = 75,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF16"]/*' />
    CV_M4_FltF16 = 76,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF17"]/*' />
    CV_M4_FltF17 = 77,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF18"]/*' />
    CV_M4_FltF18 = 78,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF19"]/*' />
    CV_M4_FltF19 = 79,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF20"]/*' />
    CV_M4_FltF20 = 80,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF21"]/*' />
    CV_M4_FltF21 = 81,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF22"]/*' />
    CV_M4_FltF22 = 82,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF23"]/*' />
    CV_M4_FltF23 = 83,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF24"]/*' />
    CV_M4_FltF24 = 84,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF25"]/*' />
    CV_M4_FltF25 = 85,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF26"]/*' />
    CV_M4_FltF26 = 86,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF27"]/*' />
    CV_M4_FltF27 = 87,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF28"]/*' />
    CV_M4_FltF28 = 88,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF29"]/*' />
    CV_M4_FltF29 = 89,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF30"]/*' />
    CV_M4_FltF30 = 90,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltF31"]/*' />
    CV_M4_FltF31 = 91,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M4_FltFsr"]/*' />
    CV_M4_FltFsr = 92,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_NOREG"]/*' />
    CV_ALPHA_NOREG = CV_REG_NONE,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF0"]/*' />
    CV_ALPHA_FltF0 = 10,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF1"]/*' />
    CV_ALPHA_FltF1 = 11,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF2"]/*' />
    CV_ALPHA_FltF2 = 12,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF3"]/*' />
    CV_ALPHA_FltF3 = 13,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF4"]/*' />
    CV_ALPHA_FltF4 = 14,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF5"]/*' />
    CV_ALPHA_FltF5 = 15,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF6"]/*' />
    CV_ALPHA_FltF6 = 16,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF7"]/*' />
    CV_ALPHA_FltF7 = 17,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF8"]/*' />
    CV_ALPHA_FltF8 = 18,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF9"]/*' />
    CV_ALPHA_FltF9 = 19,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF10"]/*' />
    CV_ALPHA_FltF10 = 20,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF11"]/*' />
    CV_ALPHA_FltF11 = 21,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF12"]/*' />
    CV_ALPHA_FltF12 = 22,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF13"]/*' />
    CV_ALPHA_FltF13 = 23,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF14"]/*' />
    CV_ALPHA_FltF14 = 24,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF15"]/*' />
    CV_ALPHA_FltF15 = 25,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF16"]/*' />
    CV_ALPHA_FltF16 = 26,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF17"]/*' />
    CV_ALPHA_FltF17 = 27,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF18"]/*' />
    CV_ALPHA_FltF18 = 28,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF19"]/*' />
    CV_ALPHA_FltF19 = 29,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF20"]/*' />
    CV_ALPHA_FltF20 = 30,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF21"]/*' />
    CV_ALPHA_FltF21 = 31,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF22"]/*' />
    CV_ALPHA_FltF22 = 32,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF23"]/*' />
    CV_ALPHA_FltF23 = 33,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF24"]/*' />
    CV_ALPHA_FltF24 = 34,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF25"]/*' />
    CV_ALPHA_FltF25 = 35,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF26"]/*' />
    CV_ALPHA_FltF26 = 36,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF27"]/*' />
    CV_ALPHA_FltF27 = 37,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF28"]/*' />
    CV_ALPHA_FltF28 = 38,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF29"]/*' />
    CV_ALPHA_FltF29 = 39,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF30"]/*' />
    CV_ALPHA_FltF30 = 40,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltF31"]/*' />
    CV_ALPHA_FltF31 = 41,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntV0"]/*' />
    CV_ALPHA_IntV0 = 42,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntT0"]/*' />
    CV_ALPHA_IntT0 = 43,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntT1"]/*' />
    CV_ALPHA_IntT1 = 44,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntT2"]/*' />
    CV_ALPHA_IntT2 = 45,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntT3"]/*' />
    CV_ALPHA_IntT3 = 46,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntT4"]/*' />
    CV_ALPHA_IntT4 = 47,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntT5"]/*' />
    CV_ALPHA_IntT5 = 48,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntT6"]/*' />
    CV_ALPHA_IntT6 = 49,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntT7"]/*' />
    CV_ALPHA_IntT7 = 50,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntS0"]/*' />
    CV_ALPHA_IntS0 = 51,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntS1"]/*' />
    CV_ALPHA_IntS1 = 52,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntS2"]/*' />
    CV_ALPHA_IntS2 = 53,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntS3"]/*' />
    CV_ALPHA_IntS3 = 54,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntS4"]/*' />
    CV_ALPHA_IntS4 = 55,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntS5"]/*' />
    CV_ALPHA_IntS5 = 56,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntFP"]/*' />
    CV_ALPHA_IntFP = 57,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntA0"]/*' />
    CV_ALPHA_IntA0 = 58,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntA1"]/*' />
    CV_ALPHA_IntA1 = 59,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntA2"]/*' />
    CV_ALPHA_IntA2 = 60,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntA3"]/*' />
    CV_ALPHA_IntA3 = 61,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntA4"]/*' />
    CV_ALPHA_IntA4 = 62,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntA5"]/*' />
    CV_ALPHA_IntA5 = 63,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntT8"]/*' />
    CV_ALPHA_IntT8 = 64,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntT9"]/*' />
    CV_ALPHA_IntT9 = 65,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntT10"]/*' />
    CV_ALPHA_IntT10 = 66,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntT11"]/*' />
    CV_ALPHA_IntT11 = 67,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntRA"]/*' />
    CV_ALPHA_IntRA = 68,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntT12"]/*' />
    CV_ALPHA_IntT12 = 69,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntAT"]/*' />
    CV_ALPHA_IntAT = 70,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntGP"]/*' />
    CV_ALPHA_IntGP = 71,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntSP"]/*' />
    CV_ALPHA_IntSP = 72,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_IntZERO"]/*' />
    CV_ALPHA_IntZERO = 73,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_Fpcr"]/*' />
    CV_ALPHA_Fpcr = 74,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_Fir"]/*' />
    CV_ALPHA_Fir = 75,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_Psr"]/*' />
    CV_ALPHA_Psr = 76,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_FltFsr"]/*' />
    CV_ALPHA_FltFsr = 77,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ALPHA_SoftFpcr"]/*' />
    CV_ALPHA_SoftFpcr = 78,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR0"]/*' />
    CV_PPC_GPR0 = 1,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR1"]/*' />
    CV_PPC_GPR1 = 2,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR2"]/*' />
    CV_PPC_GPR2 = 3,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR3"]/*' />
    CV_PPC_GPR3 = 4,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR4"]/*' />
    CV_PPC_GPR4 = 5,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR5"]/*' />
    CV_PPC_GPR5 = 6,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR6"]/*' />
    CV_PPC_GPR6 = 7,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR7"]/*' />
    CV_PPC_GPR7 = 8,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR8"]/*' />
    CV_PPC_GPR8 = 9,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR9"]/*' />
    CV_PPC_GPR9 = 10,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR10"]/*' />
    CV_PPC_GPR10 = 11,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR11"]/*' />
    CV_PPC_GPR11 = 12,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR12"]/*' />
    CV_PPC_GPR12 = 13,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR13"]/*' />
    CV_PPC_GPR13 = 14,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR14"]/*' />
    CV_PPC_GPR14 = 15,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR15"]/*' />
    CV_PPC_GPR15 = 16,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR16"]/*' />
    CV_PPC_GPR16 = 17,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR17"]/*' />
    CV_PPC_GPR17 = 18,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR18"]/*' />
    CV_PPC_GPR18 = 19,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR19"]/*' />
    CV_PPC_GPR19 = 20,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR20"]/*' />
    CV_PPC_GPR20 = 21,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR21"]/*' />
    CV_PPC_GPR21 = 22,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR22"]/*' />
    CV_PPC_GPR22 = 23,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR23"]/*' />
    CV_PPC_GPR23 = 24,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR24"]/*' />
    CV_PPC_GPR24 = 25,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR25"]/*' />
    CV_PPC_GPR25 = 26,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR26"]/*' />
    CV_PPC_GPR26 = 27,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR27"]/*' />
    CV_PPC_GPR27 = 28,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR28"]/*' />
    CV_PPC_GPR28 = 29,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR29"]/*' />
    CV_PPC_GPR29 = 30,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR30"]/*' />
    CV_PPC_GPR30 = 31,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_GPR31"]/*' />
    CV_PPC_GPR31 = 32,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_CR"]/*' />
    CV_PPC_CR = 33,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_CR0"]/*' />
    CV_PPC_CR0 = 34,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_CR1"]/*' />
    CV_PPC_CR1 = 35,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_CR2"]/*' />
    CV_PPC_CR2 = 36,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_CR3"]/*' />
    CV_PPC_CR3 = 37,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_CR4"]/*' />
    CV_PPC_CR4 = 38,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_CR5"]/*' />
    CV_PPC_CR5 = 39,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_CR6"]/*' />
    CV_PPC_CR6 = 40,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_CR7"]/*' />
    CV_PPC_CR7 = 41,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR0"]/*' />
    CV_PPC_FPR0 = 42,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR1"]/*' />
    CV_PPC_FPR1 = 43,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR2"]/*' />
    CV_PPC_FPR2 = 44,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR3"]/*' />
    CV_PPC_FPR3 = 45,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR4"]/*' />
    CV_PPC_FPR4 = 46,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR5"]/*' />
    CV_PPC_FPR5 = 47,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR6"]/*' />
    CV_PPC_FPR6 = 48,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR7"]/*' />
    CV_PPC_FPR7 = 49,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR8"]/*' />
    CV_PPC_FPR8 = 50,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR9"]/*' />
    CV_PPC_FPR9 = 51,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR10"]/*' />
    CV_PPC_FPR10 = 52,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR11"]/*' />
    CV_PPC_FPR11 = 53,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR12"]/*' />
    CV_PPC_FPR12 = 54,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR13"]/*' />
    CV_PPC_FPR13 = 55,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR14"]/*' />
    CV_PPC_FPR14 = 56,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR15"]/*' />
    CV_PPC_FPR15 = 57,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR16"]/*' />
    CV_PPC_FPR16 = 58,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR17"]/*' />
    CV_PPC_FPR17 = 59,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR18"]/*' />
    CV_PPC_FPR18 = 60,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR19"]/*' />
    CV_PPC_FPR19 = 61,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR20"]/*' />
    CV_PPC_FPR20 = 62,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR21"]/*' />
    CV_PPC_FPR21 = 63,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR22"]/*' />
    CV_PPC_FPR22 = 64,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR23"]/*' />
    CV_PPC_FPR23 = 65,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR24"]/*' />
    CV_PPC_FPR24 = 66,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR25"]/*' />
    CV_PPC_FPR25 = 67,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR26"]/*' />
    CV_PPC_FPR26 = 68,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR27"]/*' />
    CV_PPC_FPR27 = 69,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR28"]/*' />
    CV_PPC_FPR28 = 70,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR29"]/*' />
    CV_PPC_FPR29 = 71,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR30"]/*' />
    CV_PPC_FPR30 = 72,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPR31"]/*' />
    CV_PPC_FPR31 = 73,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_FPSCR"]/*' />
    CV_PPC_FPSCR = 74,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_MSR"]/*' />
    CV_PPC_MSR = 75,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SR0"]/*' />
    CV_PPC_SR0 = 76,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SR1"]/*' />
    CV_PPC_SR1 = 77,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SR2"]/*' />
    CV_PPC_SR2 = 78,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SR3"]/*' />
    CV_PPC_SR3 = 79,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SR4"]/*' />
    CV_PPC_SR4 = 80,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SR5"]/*' />
    CV_PPC_SR5 = 81,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SR6"]/*' />
    CV_PPC_SR6 = 82,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SR7"]/*' />
    CV_PPC_SR7 = 83,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SR8"]/*' />
    CV_PPC_SR8 = 84,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SR9"]/*' />
    CV_PPC_SR9 = 85,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SR10"]/*' />
    CV_PPC_SR10 = 86,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SR11"]/*' />
    CV_PPC_SR11 = 87,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SR12"]/*' />
    CV_PPC_SR12 = 88,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SR13"]/*' />
    CV_PPC_SR13 = 89,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SR14"]/*' />
    CV_PPC_SR14 = 90,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SR15"]/*' />
    CV_PPC_SR15 = 91,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PC"]/*' />
    CV_PPC_PC = 99,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_MQ"]/*' />
    CV_PPC_MQ = 100,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_XER"]/*' />
    CV_PPC_XER = 101,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_RTCU"]/*' />
    CV_PPC_RTCU = 104,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_RTCL"]/*' />
    CV_PPC_RTCL = 105,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_LR"]/*' />
    CV_PPC_LR = 108,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_CTR"]/*' />
    CV_PPC_CTR = 109,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_COMPARE"]/*' />
    CV_PPC_COMPARE = 110,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_COUNT"]/*' />
    CV_PPC_COUNT = 111,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_DSISR"]/*' />
    CV_PPC_DSISR = 118,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_DAR"]/*' />
    CV_PPC_DAR = 119,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_DEC"]/*' />
    CV_PPC_DEC = 122,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SDR1"]/*' />
    CV_PPC_SDR1 = 125,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SRR0"]/*' />
    CV_PPC_SRR0 = 126,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SRR1"]/*' />
    CV_PPC_SRR1 = 127,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SPRG0"]/*' />
    CV_PPC_SPRG0 = 372,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SPRG1"]/*' />
    CV_PPC_SPRG1 = 373,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SPRG2"]/*' />
    CV_PPC_SPRG2 = 374,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_SPRG3"]/*' />
    CV_PPC_SPRG3 = 375,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_ASR"]/*' />
    CV_PPC_ASR = 280,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_EAR"]/*' />
    CV_PPC_EAR = 382,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PVR"]/*' />
    CV_PPC_PVR = 287,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_BAT0U"]/*' />
    CV_PPC_BAT0U = 628,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_BAT0L"]/*' />
    CV_PPC_BAT0L = 629,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_BAT1U"]/*' />
    CV_PPC_BAT1U = 630,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_BAT1L"]/*' />
    CV_PPC_BAT1L = 631,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_BAT2U"]/*' />
    CV_PPC_BAT2U = 632,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_BAT2L"]/*' />
    CV_PPC_BAT2L = 633,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_BAT3U"]/*' />
    CV_PPC_BAT3U = 634,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_BAT3L"]/*' />
    CV_PPC_BAT3L = 635,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_DBAT0U"]/*' />
    CV_PPC_DBAT0U = 636,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_DBAT0L"]/*' />
    CV_PPC_DBAT0L = 637,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_DBAT1U"]/*' />
    CV_PPC_DBAT1U = 638,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_DBAT1L"]/*' />
    CV_PPC_DBAT1L = 639,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_DBAT2U"]/*' />
    CV_PPC_DBAT2U = 640,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_DBAT2L"]/*' />
    CV_PPC_DBAT2L = 641,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_DBAT3U"]/*' />
    CV_PPC_DBAT3U = 642,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_DBAT3L"]/*' />
    CV_PPC_DBAT3L = 643,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PMR0"]/*' />
    CV_PPC_PMR0 = 1044,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PMR1"]/*' />
    CV_PPC_PMR1 = 1045,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PMR2"]/*' />
    CV_PPC_PMR2 = 1046,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PMR3"]/*' />
    CV_PPC_PMR3 = 1047,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PMR4"]/*' />
    CV_PPC_PMR4 = 1048,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PMR5"]/*' />
    CV_PPC_PMR5 = 1049,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PMR6"]/*' />
    CV_PPC_PMR6 = 1050,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PMR7"]/*' />
    CV_PPC_PMR7 = 1051,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PMR8"]/*' />
    CV_PPC_PMR8 = 1052,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PMR9"]/*' />
    CV_PPC_PMR9 = 1053,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PMR10"]/*' />
    CV_PPC_PMR10 = 1054,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PMR11"]/*' />
    CV_PPC_PMR11 = 1055,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PMR12"]/*' />
    CV_PPC_PMR12 = 1056,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PMR13"]/*' />
    CV_PPC_PMR13 = 1057,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PMR14"]/*' />
    CV_PPC_PMR14 = 1058,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_PMR15"]/*' />
    CV_PPC_PMR15 = 1059,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_DMISS"]/*' />
    CV_PPC_DMISS = 1076,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_DCMP"]/*' />
    CV_PPC_DCMP = 1077,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HASH1"]/*' />
    CV_PPC_HASH1 = 1078,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HASH2"]/*' />
    CV_PPC_HASH2 = 1079,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_IMISS"]/*' />
    CV_PPC_IMISS = 1080,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_ICMP"]/*' />
    CV_PPC_ICMP = 1081,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_RPA"]/*' />
    CV_PPC_RPA = 1082,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HID0"]/*' />
    CV_PPC_HID0 = 1108,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HID1"]/*' />
    CV_PPC_HID1 = 1109,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HID2"]/*' />
    CV_PPC_HID2 = 1110,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HID3"]/*' />
    CV_PPC_HID3 = 1111,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HID4"]/*' />
    CV_PPC_HID4 = 1112,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HID5"]/*' />
    CV_PPC_HID5 = 1113,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HID6"]/*' />
    CV_PPC_HID6 = 1114,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HID7"]/*' />
    CV_PPC_HID7 = 1115,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HID8"]/*' />
    CV_PPC_HID8 = 1116,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HID9"]/*' />
    CV_PPC_HID9 = 1117,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HID10"]/*' />
    CV_PPC_HID10 = 1118,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HID11"]/*' />
    CV_PPC_HID11 = 1119,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HID12"]/*' />
    CV_PPC_HID12 = 1120,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HID13"]/*' />
    CV_PPC_HID13 = 1121,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HID14"]/*' />
    CV_PPC_HID14 = 1122,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_PPC_HID15"]/*' />
    CV_PPC_HID15 = 1123,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_JAVA_PC"]/*' />
    CV_JAVA_PC = 1,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_NOREG"]/*' />
    CV_SH3_NOREG = CV_REG_NONE,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_IntR0"]/*' />
    CV_SH3_IntR0 = 10,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_IntR1"]/*' />
    CV_SH3_IntR1 = 11,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_IntR2"]/*' />
    CV_SH3_IntR2 = 12,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_IntR3"]/*' />
    CV_SH3_IntR3 = 13,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_IntR4"]/*' />
    CV_SH3_IntR4 = 14,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_IntR5"]/*' />
    CV_SH3_IntR5 = 15,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_IntR6"]/*' />
    CV_SH3_IntR6 = 16,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_IntR7"]/*' />
    CV_SH3_IntR7 = 17,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_IntR8"]/*' />
    CV_SH3_IntR8 = 18,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_IntR9"]/*' />
    CV_SH3_IntR9 = 19,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_IntR10"]/*' />
    CV_SH3_IntR10 = 20,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_IntR11"]/*' />
    CV_SH3_IntR11 = 21,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_IntR12"]/*' />
    CV_SH3_IntR12 = 22,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_IntR13"]/*' />
    CV_SH3_IntR13 = 23,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_IntFp"]/*' />
    CV_SH3_IntFp = 24,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_IntSp"]/*' />
    CV_SH3_IntSp = 25,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_Gbr"]/*' />
    CV_SH3_Gbr = 38,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_Pr"]/*' />
    CV_SH3_Pr = 39,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_Mach"]/*' />
    CV_SH3_Mach = 40,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_Macl"]/*' />
    CV_SH3_Macl = 41,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_Pc"]/*' />
    CV_SH3_Pc = 50,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_Sr"]/*' />
    CV_SH3_Sr = 51,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_BarA"]/*' />
    CV_SH3_BarA = 60,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_BasrA"]/*' />
    CV_SH3_BasrA = 61,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_BamrA"]/*' />
    CV_SH3_BamrA = 62,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_BbrA"]/*' />
    CV_SH3_BbrA = 63,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_BarB"]/*' />
    CV_SH3_BarB = 64,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_BasrB"]/*' />
    CV_SH3_BasrB = 65,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_BamrB"]/*' />
    CV_SH3_BamrB = 66,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_BbrB"]/*' />
    CV_SH3_BbrB = 67,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_BdrB"]/*' />
    CV_SH3_BdrB = 68,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_BdmrB"]/*' />
    CV_SH3_BdmrB = 69,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH3_Brcr"]/*' />
    CV_SH3_Brcr = 70,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_Fpscr"]/*' />
    CV_SH_Fpscr = 75,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_Fpul"]/*' />
    CV_SH_Fpul = 76,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_FpR0"]/*' />
    CV_SH_FpR0 = 80,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_FpR1"]/*' />
    CV_SH_FpR1 = 81,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_FpR2"]/*' />
    CV_SH_FpR2 = 82,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_FpR3"]/*' />
    CV_SH_FpR3 = 83,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_FpR4"]/*' />
    CV_SH_FpR4 = 84,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_FpR5"]/*' />
    CV_SH_FpR5 = 85,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_FpR6"]/*' />
    CV_SH_FpR6 = 86,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_FpR7"]/*' />
    CV_SH_FpR7 = 87,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_FpR8"]/*' />
    CV_SH_FpR8 = 88,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_FpR9"]/*' />
    CV_SH_FpR9 = 89,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_FpR10"]/*' />
    CV_SH_FpR10 = 90,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_FpR11"]/*' />
    CV_SH_FpR11 = 91,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_FpR12"]/*' />
    CV_SH_FpR12 = 92,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_FpR13"]/*' />
    CV_SH_FpR13 = 93,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_FpR14"]/*' />
    CV_SH_FpR14 = 94,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_FpR15"]/*' />
    CV_SH_FpR15 = 95,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_XFpR0"]/*' />
    CV_SH_XFpR0 = 96,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_XFpR1"]/*' />
    CV_SH_XFpR1 = 97,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_XFpR2"]/*' />
    CV_SH_XFpR2 = 98,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_XFpR3"]/*' />
    CV_SH_XFpR3 = 99,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_XFpR4"]/*' />
    CV_SH_XFpR4 = 100,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_XFpR5"]/*' />
    CV_SH_XFpR5 = 101,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_XFpR6"]/*' />
    CV_SH_XFpR6 = 102,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_XFpR7"]/*' />
    CV_SH_XFpR7 = 103,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_XFpR8"]/*' />
    CV_SH_XFpR8 = 104,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_XFpR9"]/*' />
    CV_SH_XFpR9 = 105,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_XFpR10"]/*' />
    CV_SH_XFpR10 = 106,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_XFpR11"]/*' />
    CV_SH_XFpR11 = 107,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_XFpR12"]/*' />
    CV_SH_XFpR12 = 108,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_XFpR13"]/*' />
    CV_SH_XFpR13 = 109,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_XFpR14"]/*' />
    CV_SH_XFpR14 = 110,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SH_XFpR15"]/*' />
    CV_SH_XFpR15 = 111,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NOREG"]/*' />
    CV_ARM_NOREG = CV_REG_NONE,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_R0"]/*' />
    CV_ARM_R0 = 10,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_R1"]/*' />
    CV_ARM_R1 = 11,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_R2"]/*' />
    CV_ARM_R2 = 12,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_R3"]/*' />
    CV_ARM_R3 = 13,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_R4"]/*' />
    CV_ARM_R4 = 14,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_R5"]/*' />
    CV_ARM_R5 = 15,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_R6"]/*' />
    CV_ARM_R6 = 16,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_R7"]/*' />
    CV_ARM_R7 = 17,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_R8"]/*' />
    CV_ARM_R8 = 18,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_R9"]/*' />
    CV_ARM_R9 = 19,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_R10"]/*' />
    CV_ARM_R10 = 20,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_R11"]/*' />
    CV_ARM_R11 = 21,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_R12"]/*' />
    CV_ARM_R12 = 22,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_SP"]/*' />
    CV_ARM_SP = 23,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_LR"]/*' />
    CV_ARM_LR = 24,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_PC"]/*' />
    CV_ARM_PC = 25,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_CPSR"]/*' />
    CV_ARM_CPSR = 26,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ACC0"]/*' />
    CV_ARM_ACC0 = 27,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FPSCR"]/*' />
    CV_ARM_FPSCR = 40,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FPEXC"]/*' />
    CV_ARM_FPEXC = 41,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS0"]/*' />
    CV_ARM_FS0 = 50,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS1"]/*' />
    CV_ARM_FS1 = 51,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS2"]/*' />
    CV_ARM_FS2 = 52,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS3"]/*' />
    CV_ARM_FS3 = 53,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS4"]/*' />
    CV_ARM_FS4 = 54,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS5"]/*' />
    CV_ARM_FS5 = 55,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS6"]/*' />
    CV_ARM_FS6 = 56,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS7"]/*' />
    CV_ARM_FS7 = 57,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS8"]/*' />
    CV_ARM_FS8 = 58,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS9"]/*' />
    CV_ARM_FS9 = 59,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS10"]/*' />
    CV_ARM_FS10 = 60,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS11"]/*' />
    CV_ARM_FS11 = 61,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS12"]/*' />
    CV_ARM_FS12 = 62,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS13"]/*' />
    CV_ARM_FS13 = 63,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS14"]/*' />
    CV_ARM_FS14 = 64,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS15"]/*' />
    CV_ARM_FS15 = 65,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS16"]/*' />
    CV_ARM_FS16 = 66,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS17"]/*' />
    CV_ARM_FS17 = 67,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS18"]/*' />
    CV_ARM_FS18 = 68,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS19"]/*' />
    CV_ARM_FS19 = 69,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS20"]/*' />
    CV_ARM_FS20 = 70,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS21"]/*' />
    CV_ARM_FS21 = 71,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS22"]/*' />
    CV_ARM_FS22 = 72,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS23"]/*' />
    CV_ARM_FS23 = 73,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS24"]/*' />
    CV_ARM_FS24 = 74,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS25"]/*' />
    CV_ARM_FS25 = 75,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS26"]/*' />
    CV_ARM_FS26 = 76,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS27"]/*' />
    CV_ARM_FS27 = 77,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS28"]/*' />
    CV_ARM_FS28 = 78,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS29"]/*' />
    CV_ARM_FS29 = 79,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS30"]/*' />
    CV_ARM_FS30 = 80,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS31"]/*' />
    CV_ARM_FS31 = 81,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FPEXTRA0"]/*' />
    CV_ARM_FPEXTRA0 = 90,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FPEXTRA1"]/*' />
    CV_ARM_FPEXTRA1 = 91,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FPEXTRA2"]/*' />
    CV_ARM_FPEXTRA2 = 92,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FPEXTRA3"]/*' />
    CV_ARM_FPEXTRA3 = 93,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FPEXTRA4"]/*' />
    CV_ARM_FPEXTRA4 = 94,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FPEXTRA5"]/*' />
    CV_ARM_FPEXTRA5 = 95,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FPEXTRA6"]/*' />
    CV_ARM_FPEXTRA6 = 96,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FPEXTRA7"]/*' />
    CV_ARM_FPEXTRA7 = 97,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WR0"]/*' />
    CV_ARM_WR0 = 128,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WR1"]/*' />
    CV_ARM_WR1 = 129,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WR2"]/*' />
    CV_ARM_WR2 = 130,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WR3"]/*' />
    CV_ARM_WR3 = 131,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WR4"]/*' />
    CV_ARM_WR4 = 132,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WR5"]/*' />
    CV_ARM_WR5 = 133,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WR6"]/*' />
    CV_ARM_WR6 = 134,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WR7"]/*' />
    CV_ARM_WR7 = 135,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WR8"]/*' />
    CV_ARM_WR8 = 136,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WR9"]/*' />
    CV_ARM_WR9 = 137,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WR10"]/*' />
    CV_ARM_WR10 = 138,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WR11"]/*' />
    CV_ARM_WR11 = 139,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WR12"]/*' />
    CV_ARM_WR12 = 140,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WR13"]/*' />
    CV_ARM_WR13 = 141,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WR14"]/*' />
    CV_ARM_WR14 = 142,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WR15"]/*' />
    CV_ARM_WR15 = 143,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WCID"]/*' />
    CV_ARM_WCID = 144,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WCON"]/*' />
    CV_ARM_WCON = 145,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WCSSF"]/*' />
    CV_ARM_WCSSF = 146,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WCASF"]/*' />
    CV_ARM_WCASF = 147,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WC4"]/*' />
    CV_ARM_WC4 = 148,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WC5"]/*' />
    CV_ARM_WC5 = 149,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WC6"]/*' />
    CV_ARM_WC6 = 150,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WC7"]/*' />
    CV_ARM_WC7 = 151,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WCGR0"]/*' />
    CV_ARM_WCGR0 = 152,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WCGR1"]/*' />
    CV_ARM_WCGR1 = 153,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WCGR2"]/*' />
    CV_ARM_WCGR2 = 154,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WCGR3"]/*' />
    CV_ARM_WCGR3 = 155,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WC12"]/*' />
    CV_ARM_WC12 = 156,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WC13"]/*' />
    CV_ARM_WC13 = 157,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WC14"]/*' />
    CV_ARM_WC14 = 158,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_WC15"]/*' />
    CV_ARM_WC15 = 159,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS32"]/*' />
    CV_ARM_FS32 = 200,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS33"]/*' />
    CV_ARM_FS33 = 201,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS34"]/*' />
    CV_ARM_FS34 = 202,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS35"]/*' />
    CV_ARM_FS35 = 203,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS36"]/*' />
    CV_ARM_FS36 = 204,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS37"]/*' />
    CV_ARM_FS37 = 205,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS38"]/*' />
    CV_ARM_FS38 = 206,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS39"]/*' />
    CV_ARM_FS39 = 207,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS40"]/*' />
    CV_ARM_FS40 = 208,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS41"]/*' />
    CV_ARM_FS41 = 209,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS42"]/*' />
    CV_ARM_FS42 = 210,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS43"]/*' />
    CV_ARM_FS43 = 211,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS44"]/*' />
    CV_ARM_FS44 = 212,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS45"]/*' />
    CV_ARM_FS45 = 213,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS46"]/*' />
    CV_ARM_FS46 = 214,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS47"]/*' />
    CV_ARM_FS47 = 215,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS48"]/*' />
    CV_ARM_FS48 = 216,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS49"]/*' />
    CV_ARM_FS49 = 217,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS50"]/*' />
    CV_ARM_FS50 = 218,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS51"]/*' />
    CV_ARM_FS51 = 219,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS52"]/*' />
    CV_ARM_FS52 = 220,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS53"]/*' />
    CV_ARM_FS53 = 221,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS54"]/*' />
    CV_ARM_FS54 = 222,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS55"]/*' />
    CV_ARM_FS55 = 223,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS56"]/*' />
    CV_ARM_FS56 = 224,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS57"]/*' />
    CV_ARM_FS57 = 225,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS58"]/*' />
    CV_ARM_FS58 = 226,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS59"]/*' />
    CV_ARM_FS59 = 227,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS60"]/*' />
    CV_ARM_FS60 = 228,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS61"]/*' />
    CV_ARM_FS61 = 229,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS62"]/*' />
    CV_ARM_FS62 = 230,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_FS63"]/*' />
    CV_ARM_FS63 = 231,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND0"]/*' />
    CV_ARM_ND0 = 300,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND1"]/*' />
    CV_ARM_ND1 = 301,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND2"]/*' />
    CV_ARM_ND2 = 302,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND3"]/*' />
    CV_ARM_ND3 = 303,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND4"]/*' />
    CV_ARM_ND4 = 304,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND5"]/*' />
    CV_ARM_ND5 = 305,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND6"]/*' />
    CV_ARM_ND6 = 306,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND7"]/*' />
    CV_ARM_ND7 = 307,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND8"]/*' />
    CV_ARM_ND8 = 308,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND9"]/*' />
    CV_ARM_ND9 = 309,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND10"]/*' />
    CV_ARM_ND10 = 310,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND11"]/*' />
    CV_ARM_ND11 = 311,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND12"]/*' />
    CV_ARM_ND12 = 312,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND13"]/*' />
    CV_ARM_ND13 = 313,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND14"]/*' />
    CV_ARM_ND14 = 314,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND15"]/*' />
    CV_ARM_ND15 = 315,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND16"]/*' />
    CV_ARM_ND16 = 316,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND17"]/*' />
    CV_ARM_ND17 = 317,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND18"]/*' />
    CV_ARM_ND18 = 318,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND19"]/*' />
    CV_ARM_ND19 = 319,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND20"]/*' />
    CV_ARM_ND20 = 320,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND21"]/*' />
    CV_ARM_ND21 = 321,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND22"]/*' />
    CV_ARM_ND22 = 322,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND23"]/*' />
    CV_ARM_ND23 = 323,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND24"]/*' />
    CV_ARM_ND24 = 324,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND25"]/*' />
    CV_ARM_ND25 = 325,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND26"]/*' />
    CV_ARM_ND26 = 326,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND27"]/*' />
    CV_ARM_ND27 = 327,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND28"]/*' />
    CV_ARM_ND28 = 328,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND29"]/*' />
    CV_ARM_ND29 = 329,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND30"]/*' />
    CV_ARM_ND30 = 330,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_ND31"]/*' />
    CV_ARM_ND31 = 331,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NQ0"]/*' />
    CV_ARM_NQ0 = 400,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NQ1"]/*' />
    CV_ARM_NQ1 = 401,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NQ2"]/*' />
    CV_ARM_NQ2 = 402,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NQ3"]/*' />
    CV_ARM_NQ3 = 403,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NQ4"]/*' />
    CV_ARM_NQ4 = 404,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NQ5"]/*' />
    CV_ARM_NQ5 = 405,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NQ6"]/*' />
    CV_ARM_NQ6 = 406,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NQ7"]/*' />
    CV_ARM_NQ7 = 407,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NQ8"]/*' />
    CV_ARM_NQ8 = 408,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NQ9"]/*' />
    CV_ARM_NQ9 = 409,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NQ10"]/*' />
    CV_ARM_NQ10 = 410,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NQ11"]/*' />
    CV_ARM_NQ11 = 411,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NQ12"]/*' />
    CV_ARM_NQ12 = 412,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NQ13"]/*' />
    CV_ARM_NQ13 = 413,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NQ14"]/*' />
    CV_ARM_NQ14 = 414,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM_NQ15"]/*' />
    CV_ARM_NQ15 = 415,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_NOREG"]/*' />
    CV_ARM64_NOREG = CV_REG_NONE,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W0"]/*' />
    CV_ARM64_W0 = 10,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W1"]/*' />
    CV_ARM64_W1 = 11,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W2"]/*' />
    CV_ARM64_W2 = 12,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W3"]/*' />
    CV_ARM64_W3 = 13,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W4"]/*' />
    CV_ARM64_W4 = 14,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W5"]/*' />
    CV_ARM64_W5 = 15,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W6"]/*' />
    CV_ARM64_W6 = 16,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W7"]/*' />
    CV_ARM64_W7 = 17,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W8"]/*' />
    CV_ARM64_W8 = 18,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W9"]/*' />
    CV_ARM64_W9 = 19,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W10"]/*' />
    CV_ARM64_W10 = 20,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W11"]/*' />
    CV_ARM64_W11 = 21,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W12"]/*' />
    CV_ARM64_W12 = 22,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W13"]/*' />
    CV_ARM64_W13 = 23,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W14"]/*' />
    CV_ARM64_W14 = 24,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W15"]/*' />
    CV_ARM64_W15 = 25,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W16"]/*' />
    CV_ARM64_W16 = 26,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W17"]/*' />
    CV_ARM64_W17 = 27,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W18"]/*' />
    CV_ARM64_W18 = 28,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W19"]/*' />
    CV_ARM64_W19 = 29,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W20"]/*' />
    CV_ARM64_W20 = 30,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W21"]/*' />
    CV_ARM64_W21 = 31,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W22"]/*' />
    CV_ARM64_W22 = 32,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W23"]/*' />
    CV_ARM64_W23 = 33,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W24"]/*' />
    CV_ARM64_W24 = 34,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W25"]/*' />
    CV_ARM64_W25 = 35,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W26"]/*' />
    CV_ARM64_W26 = 36,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W27"]/*' />
    CV_ARM64_W27 = 37,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W28"]/*' />
    CV_ARM64_W28 = 38,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W29"]/*' />
    CV_ARM64_W29 = 39,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_W30"]/*' />
    CV_ARM64_W30 = 40,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_WZR"]/*' />
    CV_ARM64_WZR = 41,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X0"]/*' />
    CV_ARM64_X0 = 50,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X1"]/*' />
    CV_ARM64_X1 = 51,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X2"]/*' />
    CV_ARM64_X2 = 52,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X3"]/*' />
    CV_ARM64_X3 = 53,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X4"]/*' />
    CV_ARM64_X4 = 54,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X5"]/*' />
    CV_ARM64_X5 = 55,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X6"]/*' />
    CV_ARM64_X6 = 56,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X7"]/*' />
    CV_ARM64_X7 = 57,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X8"]/*' />
    CV_ARM64_X8 = 58,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X9"]/*' />
    CV_ARM64_X9 = 59,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X10"]/*' />
    CV_ARM64_X10 = 60,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X11"]/*' />
    CV_ARM64_X11 = 61,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X12"]/*' />
    CV_ARM64_X12 = 62,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X13"]/*' />
    CV_ARM64_X13 = 63,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X14"]/*' />
    CV_ARM64_X14 = 64,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X15"]/*' />
    CV_ARM64_X15 = 65,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_IP0"]/*' />
    CV_ARM64_IP0 = 66,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_IP1"]/*' />
    CV_ARM64_IP1 = 67,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X18"]/*' />
    CV_ARM64_X18 = 68,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X19"]/*' />
    CV_ARM64_X19 = 69,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X20"]/*' />
    CV_ARM64_X20 = 70,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X21"]/*' />
    CV_ARM64_X21 = 71,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X22"]/*' />
    CV_ARM64_X22 = 72,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X23"]/*' />
    CV_ARM64_X23 = 73,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X24"]/*' />
    CV_ARM64_X24 = 74,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X25"]/*' />
    CV_ARM64_X25 = 75,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X26"]/*' />
    CV_ARM64_X26 = 76,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X27"]/*' />
    CV_ARM64_X27 = 77,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_X28"]/*' />
    CV_ARM64_X28 = 78,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_FP"]/*' />
    CV_ARM64_FP = 79,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_LR"]/*' />
    CV_ARM64_LR = 80,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_SP"]/*' />
    CV_ARM64_SP = 81,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_ZR"]/*' />
    CV_ARM64_ZR = 82,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_PC"]/*' />
    CV_ARM64_PC = 83,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_NZCV"]/*' />
    CV_ARM64_NZCV = 90,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_CPSR"]/*' />
    CV_ARM64_CPSR = 91,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S0"]/*' />
    CV_ARM64_S0 = 100,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S1"]/*' />
    CV_ARM64_S1 = 101,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S2"]/*' />
    CV_ARM64_S2 = 102,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S3"]/*' />
    CV_ARM64_S3 = 103,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S4"]/*' />
    CV_ARM64_S4 = 104,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S5"]/*' />
    CV_ARM64_S5 = 105,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S6"]/*' />
    CV_ARM64_S6 = 106,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S7"]/*' />
    CV_ARM64_S7 = 107,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S8"]/*' />
    CV_ARM64_S8 = 108,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S9"]/*' />
    CV_ARM64_S9 = 109,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S10"]/*' />
    CV_ARM64_S10 = 110,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S11"]/*' />
    CV_ARM64_S11 = 111,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S12"]/*' />
    CV_ARM64_S12 = 112,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S13"]/*' />
    CV_ARM64_S13 = 113,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S14"]/*' />
    CV_ARM64_S14 = 114,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S15"]/*' />
    CV_ARM64_S15 = 115,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S16"]/*' />
    CV_ARM64_S16 = 116,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S17"]/*' />
    CV_ARM64_S17 = 117,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S18"]/*' />
    CV_ARM64_S18 = 118,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S19"]/*' />
    CV_ARM64_S19 = 119,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S20"]/*' />
    CV_ARM64_S20 = 120,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S21"]/*' />
    CV_ARM64_S21 = 121,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S22"]/*' />
    CV_ARM64_S22 = 122,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S23"]/*' />
    CV_ARM64_S23 = 123,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S24"]/*' />
    CV_ARM64_S24 = 124,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S25"]/*' />
    CV_ARM64_S25 = 125,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S26"]/*' />
    CV_ARM64_S26 = 126,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S27"]/*' />
    CV_ARM64_S27 = 127,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S28"]/*' />
    CV_ARM64_S28 = 128,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S29"]/*' />
    CV_ARM64_S29 = 129,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S30"]/*' />
    CV_ARM64_S30 = 130,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_S31"]/*' />
    CV_ARM64_S31 = 131,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D0"]/*' />
    CV_ARM64_D0 = 140,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D1"]/*' />
    CV_ARM64_D1 = 141,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D2"]/*' />
    CV_ARM64_D2 = 142,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D3"]/*' />
    CV_ARM64_D3 = 143,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D4"]/*' />
    CV_ARM64_D4 = 144,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D5"]/*' />
    CV_ARM64_D5 = 145,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D6"]/*' />
    CV_ARM64_D6 = 146,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D7"]/*' />
    CV_ARM64_D7 = 147,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D8"]/*' />
    CV_ARM64_D8 = 148,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D9"]/*' />
    CV_ARM64_D9 = 149,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D10"]/*' />
    CV_ARM64_D10 = 150,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D11"]/*' />
    CV_ARM64_D11 = 151,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D12"]/*' />
    CV_ARM64_D12 = 152,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D13"]/*' />
    CV_ARM64_D13 = 153,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D14"]/*' />
    CV_ARM64_D14 = 154,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D15"]/*' />
    CV_ARM64_D15 = 155,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D16"]/*' />
    CV_ARM64_D16 = 156,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D17"]/*' />
    CV_ARM64_D17 = 157,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D18"]/*' />
    CV_ARM64_D18 = 158,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D19"]/*' />
    CV_ARM64_D19 = 159,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D20"]/*' />
    CV_ARM64_D20 = 160,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D21"]/*' />
    CV_ARM64_D21 = 161,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D22"]/*' />
    CV_ARM64_D22 = 162,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D23"]/*' />
    CV_ARM64_D23 = 163,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D24"]/*' />
    CV_ARM64_D24 = 164,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D25"]/*' />
    CV_ARM64_D25 = 165,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D26"]/*' />
    CV_ARM64_D26 = 166,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D27"]/*' />
    CV_ARM64_D27 = 167,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D28"]/*' />
    CV_ARM64_D28 = 168,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D29"]/*' />
    CV_ARM64_D29 = 169,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D30"]/*' />
    CV_ARM64_D30 = 170,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_D31"]/*' />
    CV_ARM64_D31 = 171,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q0"]/*' />
    CV_ARM64_Q0 = 180,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q1"]/*' />
    CV_ARM64_Q1 = 181,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q2"]/*' />
    CV_ARM64_Q2 = 182,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q3"]/*' />
    CV_ARM64_Q3 = 183,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q4"]/*' />
    CV_ARM64_Q4 = 184,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q5"]/*' />
    CV_ARM64_Q5 = 185,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q6"]/*' />
    CV_ARM64_Q6 = 186,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q7"]/*' />
    CV_ARM64_Q7 = 187,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q8"]/*' />
    CV_ARM64_Q8 = 188,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q9"]/*' />
    CV_ARM64_Q9 = 189,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q10"]/*' />
    CV_ARM64_Q10 = 190,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q11"]/*' />
    CV_ARM64_Q11 = 191,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q12"]/*' />
    CV_ARM64_Q12 = 192,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q13"]/*' />
    CV_ARM64_Q13 = 193,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q14"]/*' />
    CV_ARM64_Q14 = 194,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q15"]/*' />
    CV_ARM64_Q15 = 195,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q16"]/*' />
    CV_ARM64_Q16 = 196,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q17"]/*' />
    CV_ARM64_Q17 = 197,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q18"]/*' />
    CV_ARM64_Q18 = 198,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q19"]/*' />
    CV_ARM64_Q19 = 199,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q20"]/*' />
    CV_ARM64_Q20 = 200,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q21"]/*' />
    CV_ARM64_Q21 = 201,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q22"]/*' />
    CV_ARM64_Q22 = 202,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q23"]/*' />
    CV_ARM64_Q23 = 203,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q24"]/*' />
    CV_ARM64_Q24 = 204,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q25"]/*' />
    CV_ARM64_Q25 = 205,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q26"]/*' />
    CV_ARM64_Q26 = 206,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q27"]/*' />
    CV_ARM64_Q27 = 207,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q28"]/*' />
    CV_ARM64_Q28 = 208,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q29"]/*' />
    CV_ARM64_Q29 = 209,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q30"]/*' />
    CV_ARM64_Q30 = 210,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q31"]/*' />
    CV_ARM64_Q31 = 211,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_FPSR"]/*' />
    CV_ARM64_FPSR = 220,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_FPCR"]/*' />
    CV_ARM64_FPCR = 221,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B0"]/*' />
    CV_ARM64_B0 = 230,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B1"]/*' />
    CV_ARM64_B1 = 231,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B2"]/*' />
    CV_ARM64_B2 = 232,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B3"]/*' />
    CV_ARM64_B3 = 233,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B4"]/*' />
    CV_ARM64_B4 = 234,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B5"]/*' />
    CV_ARM64_B5 = 235,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B6"]/*' />
    CV_ARM64_B6 = 236,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B7"]/*' />
    CV_ARM64_B7 = 237,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B8"]/*' />
    CV_ARM64_B8 = 238,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B9"]/*' />
    CV_ARM64_B9 = 239,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B10"]/*' />
    CV_ARM64_B10 = 240,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B11"]/*' />
    CV_ARM64_B11 = 241,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B12"]/*' />
    CV_ARM64_B12 = 242,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B13"]/*' />
    CV_ARM64_B13 = 243,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B14"]/*' />
    CV_ARM64_B14 = 244,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B15"]/*' />
    CV_ARM64_B15 = 245,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B16"]/*' />
    CV_ARM64_B16 = 246,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B17"]/*' />
    CV_ARM64_B17 = 247,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B18"]/*' />
    CV_ARM64_B18 = 248,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B19"]/*' />
    CV_ARM64_B19 = 249,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B20"]/*' />
    CV_ARM64_B20 = 250,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B21"]/*' />
    CV_ARM64_B21 = 251,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B22"]/*' />
    CV_ARM64_B22 = 252,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B23"]/*' />
    CV_ARM64_B23 = 253,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B24"]/*' />
    CV_ARM64_B24 = 254,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B25"]/*' />
    CV_ARM64_B25 = 255,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B26"]/*' />
    CV_ARM64_B26 = 256,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B27"]/*' />
    CV_ARM64_B27 = 257,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B28"]/*' />
    CV_ARM64_B28 = 258,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B29"]/*' />
    CV_ARM64_B29 = 259,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B30"]/*' />
    CV_ARM64_B30 = 260,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_B31"]/*' />
    CV_ARM64_B31 = 261,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H0"]/*' />
    CV_ARM64_H0 = 270,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H1"]/*' />
    CV_ARM64_H1 = 271,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H2"]/*' />
    CV_ARM64_H2 = 272,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H3"]/*' />
    CV_ARM64_H3 = 273,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H4"]/*' />
    CV_ARM64_H4 = 274,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H5"]/*' />
    CV_ARM64_H5 = 275,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H6"]/*' />
    CV_ARM64_H6 = 276,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H7"]/*' />
    CV_ARM64_H7 = 277,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H8"]/*' />
    CV_ARM64_H8 = 278,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H9"]/*' />
    CV_ARM64_H9 = 279,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H10"]/*' />
    CV_ARM64_H10 = 280,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H11"]/*' />
    CV_ARM64_H11 = 281,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H12"]/*' />
    CV_ARM64_H12 = 282,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H13"]/*' />
    CV_ARM64_H13 = 283,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H14"]/*' />
    CV_ARM64_H14 = 284,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H15"]/*' />
    CV_ARM64_H15 = 285,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H16"]/*' />
    CV_ARM64_H16 = 286,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H17"]/*' />
    CV_ARM64_H17 = 287,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H18"]/*' />
    CV_ARM64_H18 = 288,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H19"]/*' />
    CV_ARM64_H19 = 289,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H20"]/*' />
    CV_ARM64_H20 = 290,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H21"]/*' />
    CV_ARM64_H21 = 291,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H22"]/*' />
    CV_ARM64_H22 = 292,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H23"]/*' />
    CV_ARM64_H23 = 293,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H24"]/*' />
    CV_ARM64_H24 = 294,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H25"]/*' />
    CV_ARM64_H25 = 295,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H26"]/*' />
    CV_ARM64_H26 = 296,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H27"]/*' />
    CV_ARM64_H27 = 297,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H28"]/*' />
    CV_ARM64_H28 = 298,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H29"]/*' />
    CV_ARM64_H29 = 299,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H30"]/*' />
    CV_ARM64_H30 = 300,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_H31"]/*' />
    CV_ARM64_H31 = 301,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V0"]/*' />
    CV_ARM64_V0 = 310,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V1"]/*' />
    CV_ARM64_V1 = 311,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V2"]/*' />
    CV_ARM64_V2 = 312,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V3"]/*' />
    CV_ARM64_V3 = 313,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V4"]/*' />
    CV_ARM64_V4 = 314,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V5"]/*' />
    CV_ARM64_V5 = 315,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V6"]/*' />
    CV_ARM64_V6 = 316,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V7"]/*' />
    CV_ARM64_V7 = 317,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V8"]/*' />
    CV_ARM64_V8 = 318,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V9"]/*' />
    CV_ARM64_V9 = 319,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V10"]/*' />
    CV_ARM64_V10 = 320,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V11"]/*' />
    CV_ARM64_V11 = 321,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V12"]/*' />
    CV_ARM64_V12 = 322,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V13"]/*' />
    CV_ARM64_V13 = 323,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V14"]/*' />
    CV_ARM64_V14 = 324,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V15"]/*' />
    CV_ARM64_V15 = 325,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V16"]/*' />
    CV_ARM64_V16 = 326,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V17"]/*' />
    CV_ARM64_V17 = 327,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V18"]/*' />
    CV_ARM64_V18 = 328,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V19"]/*' />
    CV_ARM64_V19 = 329,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V20"]/*' />
    CV_ARM64_V20 = 330,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V21"]/*' />
    CV_ARM64_V21 = 331,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V22"]/*' />
    CV_ARM64_V22 = 332,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V23"]/*' />
    CV_ARM64_V23 = 333,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V24"]/*' />
    CV_ARM64_V24 = 334,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V25"]/*' />
    CV_ARM64_V25 = 335,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V26"]/*' />
    CV_ARM64_V26 = 336,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V27"]/*' />
    CV_ARM64_V27 = 337,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V28"]/*' />
    CV_ARM64_V28 = 338,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V29"]/*' />
    CV_ARM64_V29 = 339,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V30"]/*' />
    CV_ARM64_V30 = 340,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_V31"]/*' />
    CV_ARM64_V31 = 341,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q0H"]/*' />
    CV_ARM64_Q0H = 350,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q1H"]/*' />
    CV_ARM64_Q1H = 351,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q2H"]/*' />
    CV_ARM64_Q2H = 352,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q3H"]/*' />
    CV_ARM64_Q3H = 353,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q4H"]/*' />
    CV_ARM64_Q4H = 354,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q5H"]/*' />
    CV_ARM64_Q5H = 355,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q6H"]/*' />
    CV_ARM64_Q6H = 356,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q7H"]/*' />
    CV_ARM64_Q7H = 357,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q8H"]/*' />
    CV_ARM64_Q8H = 358,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q9H"]/*' />
    CV_ARM64_Q9H = 359,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q10H"]/*' />
    CV_ARM64_Q10H = 360,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q11H"]/*' />
    CV_ARM64_Q11H = 361,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q12H"]/*' />
    CV_ARM64_Q12H = 362,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q13H"]/*' />
    CV_ARM64_Q13H = 363,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q14H"]/*' />
    CV_ARM64_Q14H = 364,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q15H"]/*' />
    CV_ARM64_Q15H = 365,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q16H"]/*' />
    CV_ARM64_Q16H = 366,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q17H"]/*' />
    CV_ARM64_Q17H = 367,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q18H"]/*' />
    CV_ARM64_Q18H = 368,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q19H"]/*' />
    CV_ARM64_Q19H = 369,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q20H"]/*' />
    CV_ARM64_Q20H = 370,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q21H"]/*' />
    CV_ARM64_Q21H = 371,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q22H"]/*' />
    CV_ARM64_Q22H = 372,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q23H"]/*' />
    CV_ARM64_Q23H = 373,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q24H"]/*' />
    CV_ARM64_Q24H = 374,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q25H"]/*' />
    CV_ARM64_Q25H = 375,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q26H"]/*' />
    CV_ARM64_Q26H = 376,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q27H"]/*' />
    CV_ARM64_Q27H = 377,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q28H"]/*' />
    CV_ARM64_Q28H = 378,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q29H"]/*' />
    CV_ARM64_Q29H = 379,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q30H"]/*' />
    CV_ARM64_Q30H = 380,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Q31H"]/*' />
    CV_ARM64_Q31H = 381,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z0"]/*' />
    CV_ARM64_Z0 = 382,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z1"]/*' />
    CV_ARM64_Z1 = 383,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z2"]/*' />
    CV_ARM64_Z2 = 384,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z3"]/*' />
    CV_ARM64_Z3 = 385,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z4"]/*' />
    CV_ARM64_Z4 = 386,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z5"]/*' />
    CV_ARM64_Z5 = 387,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z6"]/*' />
    CV_ARM64_Z6 = 388,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z7"]/*' />
    CV_ARM64_Z7 = 389,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z8"]/*' />
    CV_ARM64_Z8 = 390,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z9"]/*' />
    CV_ARM64_Z9 = 391,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z10"]/*' />
    CV_ARM64_Z10 = 392,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z11"]/*' />
    CV_ARM64_Z11 = 393,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z12"]/*' />
    CV_ARM64_Z12 = 394,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z13"]/*' />
    CV_ARM64_Z13 = 395,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z14"]/*' />
    CV_ARM64_Z14 = 396,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z15"]/*' />
    CV_ARM64_Z15 = 397,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z16"]/*' />
    CV_ARM64_Z16 = 398,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z17"]/*' />
    CV_ARM64_Z17 = 399,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z18"]/*' />
    CV_ARM64_Z18 = 400,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z19"]/*' />
    CV_ARM64_Z19 = 401,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z20"]/*' />
    CV_ARM64_Z20 = 402,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z21"]/*' />
    CV_ARM64_Z21 = 403,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z22"]/*' />
    CV_ARM64_Z22 = 404,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z23"]/*' />
    CV_ARM64_Z23 = 405,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z24"]/*' />
    CV_ARM64_Z24 = 406,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z25"]/*' />
    CV_ARM64_Z25 = 407,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z26"]/*' />
    CV_ARM64_Z26 = 408,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z27"]/*' />
    CV_ARM64_Z27 = 409,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z28"]/*' />
    CV_ARM64_Z28 = 410,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z29"]/*' />
    CV_ARM64_Z29 = 411,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z30"]/*' />
    CV_ARM64_Z30 = 412,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_Z31"]/*' />
    CV_ARM64_Z31 = 413,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_P0"]/*' />
    CV_ARM64_P0 = 414,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_P1"]/*' />
    CV_ARM64_P1 = 415,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_P2"]/*' />
    CV_ARM64_P2 = 416,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_P3"]/*' />
    CV_ARM64_P3 = 417,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_P4"]/*' />
    CV_ARM64_P4 = 418,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_P5"]/*' />
    CV_ARM64_P5 = 419,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_P6"]/*' />
    CV_ARM64_P6 = 420,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_P7"]/*' />
    CV_ARM64_P7 = 421,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_P8"]/*' />
    CV_ARM64_P8 = 422,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_P9"]/*' />
    CV_ARM64_P9 = 423,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_P10"]/*' />
    CV_ARM64_P10 = 424,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_P11"]/*' />
    CV_ARM64_P11 = 425,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_P12"]/*' />
    CV_ARM64_P12 = 426,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_P13"]/*' />
    CV_ARM64_P13 = 427,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_P14"]/*' />
    CV_ARM64_P14 = 428,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_ARM64_P15"]/*' />
    CV_ARM64_P15 = 429,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_NOREG"]/*' />
    CV_IA64_NOREG = CV_REG_NONE,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Br0"]/*' />
    CV_IA64_Br0 = 512,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Br1"]/*' />
    CV_IA64_Br1 = 513,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Br2"]/*' />
    CV_IA64_Br2 = 514,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Br3"]/*' />
    CV_IA64_Br3 = 515,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Br4"]/*' />
    CV_IA64_Br4 = 516,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Br5"]/*' />
    CV_IA64_Br5 = 517,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Br6"]/*' />
    CV_IA64_Br6 = 518,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Br7"]/*' />
    CV_IA64_Br7 = 519,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P0"]/*' />
    CV_IA64_P0 = 704,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P1"]/*' />
    CV_IA64_P1 = 705,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P2"]/*' />
    CV_IA64_P2 = 706,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P3"]/*' />
    CV_IA64_P3 = 707,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P4"]/*' />
    CV_IA64_P4 = 708,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P5"]/*' />
    CV_IA64_P5 = 709,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P6"]/*' />
    CV_IA64_P6 = 710,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P7"]/*' />
    CV_IA64_P7 = 711,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P8"]/*' />
    CV_IA64_P8 = 712,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P9"]/*' />
    CV_IA64_P9 = 713,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P10"]/*' />
    CV_IA64_P10 = 714,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P11"]/*' />
    CV_IA64_P11 = 715,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P12"]/*' />
    CV_IA64_P12 = 716,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P13"]/*' />
    CV_IA64_P13 = 717,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P14"]/*' />
    CV_IA64_P14 = 718,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P15"]/*' />
    CV_IA64_P15 = 719,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P16"]/*' />
    CV_IA64_P16 = 720,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P17"]/*' />
    CV_IA64_P17 = 721,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P18"]/*' />
    CV_IA64_P18 = 722,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P19"]/*' />
    CV_IA64_P19 = 723,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P20"]/*' />
    CV_IA64_P20 = 724,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P21"]/*' />
    CV_IA64_P21 = 725,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P22"]/*' />
    CV_IA64_P22 = 726,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P23"]/*' />
    CV_IA64_P23 = 727,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P24"]/*' />
    CV_IA64_P24 = 728,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P25"]/*' />
    CV_IA64_P25 = 729,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P26"]/*' />
    CV_IA64_P26 = 730,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P27"]/*' />
    CV_IA64_P27 = 731,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P28"]/*' />
    CV_IA64_P28 = 732,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P29"]/*' />
    CV_IA64_P29 = 733,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P30"]/*' />
    CV_IA64_P30 = 734,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P31"]/*' />
    CV_IA64_P31 = 735,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P32"]/*' />
    CV_IA64_P32 = 736,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P33"]/*' />
    CV_IA64_P33 = 737,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P34"]/*' />
    CV_IA64_P34 = 738,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P35"]/*' />
    CV_IA64_P35 = 739,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P36"]/*' />
    CV_IA64_P36 = 740,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P37"]/*' />
    CV_IA64_P37 = 741,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P38"]/*' />
    CV_IA64_P38 = 742,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P39"]/*' />
    CV_IA64_P39 = 743,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P40"]/*' />
    CV_IA64_P40 = 744,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P41"]/*' />
    CV_IA64_P41 = 745,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P42"]/*' />
    CV_IA64_P42 = 746,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P43"]/*' />
    CV_IA64_P43 = 747,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P44"]/*' />
    CV_IA64_P44 = 748,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P45"]/*' />
    CV_IA64_P45 = 749,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P46"]/*' />
    CV_IA64_P46 = 750,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P47"]/*' />
    CV_IA64_P47 = 751,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P48"]/*' />
    CV_IA64_P48 = 752,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P49"]/*' />
    CV_IA64_P49 = 753,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P50"]/*' />
    CV_IA64_P50 = 754,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P51"]/*' />
    CV_IA64_P51 = 755,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P52"]/*' />
    CV_IA64_P52 = 756,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P53"]/*' />
    CV_IA64_P53 = 757,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P54"]/*' />
    CV_IA64_P54 = 758,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P55"]/*' />
    CV_IA64_P55 = 759,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P56"]/*' />
    CV_IA64_P56 = 760,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P57"]/*' />
    CV_IA64_P57 = 761,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P58"]/*' />
    CV_IA64_P58 = 762,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P59"]/*' />
    CV_IA64_P59 = 763,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P60"]/*' />
    CV_IA64_P60 = 764,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P61"]/*' />
    CV_IA64_P61 = 765,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P62"]/*' />
    CV_IA64_P62 = 766,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_P63"]/*' />
    CV_IA64_P63 = 767,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Preds"]/*' />
    CV_IA64_Preds = 768,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntH0"]/*' />
    CV_IA64_IntH0 = 832,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntH1"]/*' />
    CV_IA64_IntH1 = 833,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntH2"]/*' />
    CV_IA64_IntH2 = 834,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntH3"]/*' />
    CV_IA64_IntH3 = 835,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntH4"]/*' />
    CV_IA64_IntH4 = 836,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntH5"]/*' />
    CV_IA64_IntH5 = 837,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntH6"]/*' />
    CV_IA64_IntH6 = 838,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntH7"]/*' />
    CV_IA64_IntH7 = 839,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntH8"]/*' />
    CV_IA64_IntH8 = 840,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntH9"]/*' />
    CV_IA64_IntH9 = 841,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntH10"]/*' />
    CV_IA64_IntH10 = 842,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntH11"]/*' />
    CV_IA64_IntH11 = 843,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntH12"]/*' />
    CV_IA64_IntH12 = 844,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntH13"]/*' />
    CV_IA64_IntH13 = 845,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntH14"]/*' />
    CV_IA64_IntH14 = 846,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntH15"]/*' />
    CV_IA64_IntH15 = 847,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Ip"]/*' />
    CV_IA64_Ip = 1016,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Umask"]/*' />
    CV_IA64_Umask = 1017,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Cfm"]/*' />
    CV_IA64_Cfm = 1018,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Psr"]/*' />
    CV_IA64_Psr = 1019,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Nats"]/*' />
    CV_IA64_Nats = 1020,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Nats2"]/*' />
    CV_IA64_Nats2 = 1021,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Nats3"]/*' />
    CV_IA64_Nats3 = 1022,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR0"]/*' />
    CV_IA64_IntR0 = 1024,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR1"]/*' />
    CV_IA64_IntR1 = 1025,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR2"]/*' />
    CV_IA64_IntR2 = 1026,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR3"]/*' />
    CV_IA64_IntR3 = 1027,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR4"]/*' />
    CV_IA64_IntR4 = 1028,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR5"]/*' />
    CV_IA64_IntR5 = 1029,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR6"]/*' />
    CV_IA64_IntR6 = 1030,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR7"]/*' />
    CV_IA64_IntR7 = 1031,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR8"]/*' />
    CV_IA64_IntR8 = 1032,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR9"]/*' />
    CV_IA64_IntR9 = 1033,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR10"]/*' />
    CV_IA64_IntR10 = 1034,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR11"]/*' />
    CV_IA64_IntR11 = 1035,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR12"]/*' />
    CV_IA64_IntR12 = 1036,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR13"]/*' />
    CV_IA64_IntR13 = 1037,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR14"]/*' />
    CV_IA64_IntR14 = 1038,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR15"]/*' />
    CV_IA64_IntR15 = 1039,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR16"]/*' />
    CV_IA64_IntR16 = 1040,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR17"]/*' />
    CV_IA64_IntR17 = 1041,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR18"]/*' />
    CV_IA64_IntR18 = 1042,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR19"]/*' />
    CV_IA64_IntR19 = 1043,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR20"]/*' />
    CV_IA64_IntR20 = 1044,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR21"]/*' />
    CV_IA64_IntR21 = 1045,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR22"]/*' />
    CV_IA64_IntR22 = 1046,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR23"]/*' />
    CV_IA64_IntR23 = 1047,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR24"]/*' />
    CV_IA64_IntR24 = 1048,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR25"]/*' />
    CV_IA64_IntR25 = 1049,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR26"]/*' />
    CV_IA64_IntR26 = 1050,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR27"]/*' />
    CV_IA64_IntR27 = 1051,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR28"]/*' />
    CV_IA64_IntR28 = 1052,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR29"]/*' />
    CV_IA64_IntR29 = 1053,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR30"]/*' />
    CV_IA64_IntR30 = 1054,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR31"]/*' />
    CV_IA64_IntR31 = 1055,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR32"]/*' />
    CV_IA64_IntR32 = 1056,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR33"]/*' />
    CV_IA64_IntR33 = 1057,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR34"]/*' />
    CV_IA64_IntR34 = 1058,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR35"]/*' />
    CV_IA64_IntR35 = 1059,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR36"]/*' />
    CV_IA64_IntR36 = 1060,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR37"]/*' />
    CV_IA64_IntR37 = 1061,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR38"]/*' />
    CV_IA64_IntR38 = 1062,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR39"]/*' />
    CV_IA64_IntR39 = 1063,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR40"]/*' />
    CV_IA64_IntR40 = 1064,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR41"]/*' />
    CV_IA64_IntR41 = 1065,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR42"]/*' />
    CV_IA64_IntR42 = 1066,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR43"]/*' />
    CV_IA64_IntR43 = 1067,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR44"]/*' />
    CV_IA64_IntR44 = 1068,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR45"]/*' />
    CV_IA64_IntR45 = 1069,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR46"]/*' />
    CV_IA64_IntR46 = 1070,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR47"]/*' />
    CV_IA64_IntR47 = 1071,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR48"]/*' />
    CV_IA64_IntR48 = 1072,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR49"]/*' />
    CV_IA64_IntR49 = 1073,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR50"]/*' />
    CV_IA64_IntR50 = 1074,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR51"]/*' />
    CV_IA64_IntR51 = 1075,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR52"]/*' />
    CV_IA64_IntR52 = 1076,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR53"]/*' />
    CV_IA64_IntR53 = 1077,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR54"]/*' />
    CV_IA64_IntR54 = 1078,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR55"]/*' />
    CV_IA64_IntR55 = 1079,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR56"]/*' />
    CV_IA64_IntR56 = 1080,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR57"]/*' />
    CV_IA64_IntR57 = 1081,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR58"]/*' />
    CV_IA64_IntR58 = 1082,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR59"]/*' />
    CV_IA64_IntR59 = 1083,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR60"]/*' />
    CV_IA64_IntR60 = 1084,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR61"]/*' />
    CV_IA64_IntR61 = 1085,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR62"]/*' />
    CV_IA64_IntR62 = 1086,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR63"]/*' />
    CV_IA64_IntR63 = 1087,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR64"]/*' />
    CV_IA64_IntR64 = 1088,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR65"]/*' />
    CV_IA64_IntR65 = 1089,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR66"]/*' />
    CV_IA64_IntR66 = 1090,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR67"]/*' />
    CV_IA64_IntR67 = 1091,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR68"]/*' />
    CV_IA64_IntR68 = 1092,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR69"]/*' />
    CV_IA64_IntR69 = 1093,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR70"]/*' />
    CV_IA64_IntR70 = 1094,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR71"]/*' />
    CV_IA64_IntR71 = 1095,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR72"]/*' />
    CV_IA64_IntR72 = 1096,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR73"]/*' />
    CV_IA64_IntR73 = 1097,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR74"]/*' />
    CV_IA64_IntR74 = 1098,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR75"]/*' />
    CV_IA64_IntR75 = 1099,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR76"]/*' />
    CV_IA64_IntR76 = 1100,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR77"]/*' />
    CV_IA64_IntR77 = 1101,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR78"]/*' />
    CV_IA64_IntR78 = 1102,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR79"]/*' />
    CV_IA64_IntR79 = 1103,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR80"]/*' />
    CV_IA64_IntR80 = 1104,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR81"]/*' />
    CV_IA64_IntR81 = 1105,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR82"]/*' />
    CV_IA64_IntR82 = 1106,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR83"]/*' />
    CV_IA64_IntR83 = 1107,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR84"]/*' />
    CV_IA64_IntR84 = 1108,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR85"]/*' />
    CV_IA64_IntR85 = 1109,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR86"]/*' />
    CV_IA64_IntR86 = 1110,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR87"]/*' />
    CV_IA64_IntR87 = 1111,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR88"]/*' />
    CV_IA64_IntR88 = 1112,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR89"]/*' />
    CV_IA64_IntR89 = 1113,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR90"]/*' />
    CV_IA64_IntR90 = 1114,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR91"]/*' />
    CV_IA64_IntR91 = 1115,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR92"]/*' />
    CV_IA64_IntR92 = 1116,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR93"]/*' />
    CV_IA64_IntR93 = 1117,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR94"]/*' />
    CV_IA64_IntR94 = 1118,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR95"]/*' />
    CV_IA64_IntR95 = 1119,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR96"]/*' />
    CV_IA64_IntR96 = 1120,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR97"]/*' />
    CV_IA64_IntR97 = 1121,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR98"]/*' />
    CV_IA64_IntR98 = 1122,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR99"]/*' />
    CV_IA64_IntR99 = 1123,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR100"]/*' />
    CV_IA64_IntR100 = 1124,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR101"]/*' />
    CV_IA64_IntR101 = 1125,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR102"]/*' />
    CV_IA64_IntR102 = 1126,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR103"]/*' />
    CV_IA64_IntR103 = 1127,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR104"]/*' />
    CV_IA64_IntR104 = 1128,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR105"]/*' />
    CV_IA64_IntR105 = 1129,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR106"]/*' />
    CV_IA64_IntR106 = 1130,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR107"]/*' />
    CV_IA64_IntR107 = 1131,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR108"]/*' />
    CV_IA64_IntR108 = 1132,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR109"]/*' />
    CV_IA64_IntR109 = 1133,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR110"]/*' />
    CV_IA64_IntR110 = 1134,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR111"]/*' />
    CV_IA64_IntR111 = 1135,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR112"]/*' />
    CV_IA64_IntR112 = 1136,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR113"]/*' />
    CV_IA64_IntR113 = 1137,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR114"]/*' />
    CV_IA64_IntR114 = 1138,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR115"]/*' />
    CV_IA64_IntR115 = 1139,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR116"]/*' />
    CV_IA64_IntR116 = 1140,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR117"]/*' />
    CV_IA64_IntR117 = 1141,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR118"]/*' />
    CV_IA64_IntR118 = 1142,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR119"]/*' />
    CV_IA64_IntR119 = 1143,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR120"]/*' />
    CV_IA64_IntR120 = 1144,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR121"]/*' />
    CV_IA64_IntR121 = 1145,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR122"]/*' />
    CV_IA64_IntR122 = 1146,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR123"]/*' />
    CV_IA64_IntR123 = 1147,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR124"]/*' />
    CV_IA64_IntR124 = 1148,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR125"]/*' />
    CV_IA64_IntR125 = 1149,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR126"]/*' />
    CV_IA64_IntR126 = 1150,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_IntR127"]/*' />
    CV_IA64_IntR127 = 1151,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF0"]/*' />
    CV_IA64_FltF0 = 2048,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF1"]/*' />
    CV_IA64_FltF1 = 2049,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF2"]/*' />
    CV_IA64_FltF2 = 2050,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF3"]/*' />
    CV_IA64_FltF3 = 2051,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF4"]/*' />
    CV_IA64_FltF4 = 2052,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF5"]/*' />
    CV_IA64_FltF5 = 2053,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF6"]/*' />
    CV_IA64_FltF6 = 2054,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF7"]/*' />
    CV_IA64_FltF7 = 2055,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF8"]/*' />
    CV_IA64_FltF8 = 2056,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF9"]/*' />
    CV_IA64_FltF9 = 2057,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF10"]/*' />
    CV_IA64_FltF10 = 2058,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF11"]/*' />
    CV_IA64_FltF11 = 2059,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF12"]/*' />
    CV_IA64_FltF12 = 2060,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF13"]/*' />
    CV_IA64_FltF13 = 2061,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF14"]/*' />
    CV_IA64_FltF14 = 2062,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF15"]/*' />
    CV_IA64_FltF15 = 2063,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF16"]/*' />
    CV_IA64_FltF16 = 2064,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF17"]/*' />
    CV_IA64_FltF17 = 2065,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF18"]/*' />
    CV_IA64_FltF18 = 2066,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF19"]/*' />
    CV_IA64_FltF19 = 2067,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF20"]/*' />
    CV_IA64_FltF20 = 2068,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF21"]/*' />
    CV_IA64_FltF21 = 2069,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF22"]/*' />
    CV_IA64_FltF22 = 2070,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF23"]/*' />
    CV_IA64_FltF23 = 2071,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF24"]/*' />
    CV_IA64_FltF24 = 2072,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF25"]/*' />
    CV_IA64_FltF25 = 2073,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF26"]/*' />
    CV_IA64_FltF26 = 2074,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF27"]/*' />
    CV_IA64_FltF27 = 2075,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF28"]/*' />
    CV_IA64_FltF28 = 2076,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF29"]/*' />
    CV_IA64_FltF29 = 2077,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF30"]/*' />
    CV_IA64_FltF30 = 2078,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF31"]/*' />
    CV_IA64_FltF31 = 2079,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF32"]/*' />
    CV_IA64_FltF32 = 2080,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF33"]/*' />
    CV_IA64_FltF33 = 2081,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF34"]/*' />
    CV_IA64_FltF34 = 2082,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF35"]/*' />
    CV_IA64_FltF35 = 2083,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF36"]/*' />
    CV_IA64_FltF36 = 2084,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF37"]/*' />
    CV_IA64_FltF37 = 2085,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF38"]/*' />
    CV_IA64_FltF38 = 2086,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF39"]/*' />
    CV_IA64_FltF39 = 2087,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF40"]/*' />
    CV_IA64_FltF40 = 2088,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF41"]/*' />
    CV_IA64_FltF41 = 2089,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF42"]/*' />
    CV_IA64_FltF42 = 2090,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF43"]/*' />
    CV_IA64_FltF43 = 2091,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF44"]/*' />
    CV_IA64_FltF44 = 2092,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF45"]/*' />
    CV_IA64_FltF45 = 2093,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF46"]/*' />
    CV_IA64_FltF46 = 2094,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF47"]/*' />
    CV_IA64_FltF47 = 2095,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF48"]/*' />
    CV_IA64_FltF48 = 2096,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF49"]/*' />
    CV_IA64_FltF49 = 2097,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF50"]/*' />
    CV_IA64_FltF50 = 2098,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF51"]/*' />
    CV_IA64_FltF51 = 2099,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF52"]/*' />
    CV_IA64_FltF52 = 2100,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF53"]/*' />
    CV_IA64_FltF53 = 2101,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF54"]/*' />
    CV_IA64_FltF54 = 2102,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF55"]/*' />
    CV_IA64_FltF55 = 2103,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF56"]/*' />
    CV_IA64_FltF56 = 2104,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF57"]/*' />
    CV_IA64_FltF57 = 2105,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF58"]/*' />
    CV_IA64_FltF58 = 2106,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF59"]/*' />
    CV_IA64_FltF59 = 2107,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF60"]/*' />
    CV_IA64_FltF60 = 2108,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF61"]/*' />
    CV_IA64_FltF61 = 2109,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF62"]/*' />
    CV_IA64_FltF62 = 2110,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF63"]/*' />
    CV_IA64_FltF63 = 2111,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF64"]/*' />
    CV_IA64_FltF64 = 2112,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF65"]/*' />
    CV_IA64_FltF65 = 2113,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF66"]/*' />
    CV_IA64_FltF66 = 2114,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF67"]/*' />
    CV_IA64_FltF67 = 2115,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF68"]/*' />
    CV_IA64_FltF68 = 2116,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF69"]/*' />
    CV_IA64_FltF69 = 2117,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF70"]/*' />
    CV_IA64_FltF70 = 2118,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF71"]/*' />
    CV_IA64_FltF71 = 2119,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF72"]/*' />
    CV_IA64_FltF72 = 2120,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF73"]/*' />
    CV_IA64_FltF73 = 2121,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF74"]/*' />
    CV_IA64_FltF74 = 2122,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF75"]/*' />
    CV_IA64_FltF75 = 2123,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF76"]/*' />
    CV_IA64_FltF76 = 2124,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF77"]/*' />
    CV_IA64_FltF77 = 2125,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF78"]/*' />
    CV_IA64_FltF78 = 2126,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF79"]/*' />
    CV_IA64_FltF79 = 2127,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF80"]/*' />
    CV_IA64_FltF80 = 2128,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF81"]/*' />
    CV_IA64_FltF81 = 2129,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF82"]/*' />
    CV_IA64_FltF82 = 2130,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF83"]/*' />
    CV_IA64_FltF83 = 2131,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF84"]/*' />
    CV_IA64_FltF84 = 2132,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF85"]/*' />
    CV_IA64_FltF85 = 2133,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF86"]/*' />
    CV_IA64_FltF86 = 2134,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF87"]/*' />
    CV_IA64_FltF87 = 2135,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF88"]/*' />
    CV_IA64_FltF88 = 2136,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF89"]/*' />
    CV_IA64_FltF89 = 2137,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF90"]/*' />
    CV_IA64_FltF90 = 2138,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF91"]/*' />
    CV_IA64_FltF91 = 2139,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF92"]/*' />
    CV_IA64_FltF92 = 2140,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF93"]/*' />
    CV_IA64_FltF93 = 2141,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF94"]/*' />
    CV_IA64_FltF94 = 2142,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF95"]/*' />
    CV_IA64_FltF95 = 2143,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF96"]/*' />
    CV_IA64_FltF96 = 2144,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF97"]/*' />
    CV_IA64_FltF97 = 2145,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF98"]/*' />
    CV_IA64_FltF98 = 2146,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF99"]/*' />
    CV_IA64_FltF99 = 2147,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF100"]/*' />
    CV_IA64_FltF100 = 2148,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF101"]/*' />
    CV_IA64_FltF101 = 2149,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF102"]/*' />
    CV_IA64_FltF102 = 2150,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF103"]/*' />
    CV_IA64_FltF103 = 2151,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF104"]/*' />
    CV_IA64_FltF104 = 2152,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF105"]/*' />
    CV_IA64_FltF105 = 2153,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF106"]/*' />
    CV_IA64_FltF106 = 2154,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF107"]/*' />
    CV_IA64_FltF107 = 2155,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF108"]/*' />
    CV_IA64_FltF108 = 2156,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF109"]/*' />
    CV_IA64_FltF109 = 2157,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF110"]/*' />
    CV_IA64_FltF110 = 2158,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF111"]/*' />
    CV_IA64_FltF111 = 2159,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF112"]/*' />
    CV_IA64_FltF112 = 2160,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF113"]/*' />
    CV_IA64_FltF113 = 2161,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF114"]/*' />
    CV_IA64_FltF114 = 2162,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF115"]/*' />
    CV_IA64_FltF115 = 2163,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF116"]/*' />
    CV_IA64_FltF116 = 2164,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF117"]/*' />
    CV_IA64_FltF117 = 2165,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF118"]/*' />
    CV_IA64_FltF118 = 2166,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF119"]/*' />
    CV_IA64_FltF119 = 2167,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF120"]/*' />
    CV_IA64_FltF120 = 2168,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF121"]/*' />
    CV_IA64_FltF121 = 2169,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF122"]/*' />
    CV_IA64_FltF122 = 2170,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF123"]/*' />
    CV_IA64_FltF123 = 2171,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF124"]/*' />
    CV_IA64_FltF124 = 2172,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF125"]/*' />
    CV_IA64_FltF125 = 2173,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF126"]/*' />
    CV_IA64_FltF126 = 2174,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_FltF127"]/*' />
    CV_IA64_FltF127 = 2175,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApKR0"]/*' />
    CV_IA64_ApKR0 = 3072,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApKR1"]/*' />
    CV_IA64_ApKR1 = 3073,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApKR2"]/*' />
    CV_IA64_ApKR2 = 3074,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApKR3"]/*' />
    CV_IA64_ApKR3 = 3075,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApKR4"]/*' />
    CV_IA64_ApKR4 = 3076,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApKR5"]/*' />
    CV_IA64_ApKR5 = 3077,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApKR6"]/*' />
    CV_IA64_ApKR6 = 3078,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApKR7"]/*' />
    CV_IA64_ApKR7 = 3079,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR8"]/*' />
    CV_IA64_AR8 = 3080,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR9"]/*' />
    CV_IA64_AR9 = 3081,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR10"]/*' />
    CV_IA64_AR10 = 3082,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR11"]/*' />
    CV_IA64_AR11 = 3083,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR12"]/*' />
    CV_IA64_AR12 = 3084,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR13"]/*' />
    CV_IA64_AR13 = 3085,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR14"]/*' />
    CV_IA64_AR14 = 3086,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR15"]/*' />
    CV_IA64_AR15 = 3087,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_RsRSC"]/*' />
    CV_IA64_RsRSC = 3088,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_RsBSP"]/*' />
    CV_IA64_RsBSP = 3089,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_RsBSPSTORE"]/*' />
    CV_IA64_RsBSPSTORE = 3090,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_RsRNAT"]/*' />
    CV_IA64_RsRNAT = 3091,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR20"]/*' />
    CV_IA64_AR20 = 3092,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_StFCR"]/*' />
    CV_IA64_StFCR = 3093,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR22"]/*' />
    CV_IA64_AR22 = 3094,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR23"]/*' />
    CV_IA64_AR23 = 3095,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_EFLAG"]/*' />
    CV_IA64_EFLAG = 3096,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CSD"]/*' />
    CV_IA64_CSD = 3097,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_SSD"]/*' />
    CV_IA64_SSD = 3098,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CFLG"]/*' />
    CV_IA64_CFLG = 3099,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_StFSR"]/*' />
    CV_IA64_StFSR = 3100,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_StFIR"]/*' />
    CV_IA64_StFIR = 3101,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_StFDR"]/*' />
    CV_IA64_StFDR = 3102,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR31"]/*' />
    CV_IA64_AR31 = 3103,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApCCV"]/*' />
    CV_IA64_ApCCV = 3104,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR33"]/*' />
    CV_IA64_AR33 = 3105,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR34"]/*' />
    CV_IA64_AR34 = 3106,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR35"]/*' />
    CV_IA64_AR35 = 3107,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApUNAT"]/*' />
    CV_IA64_ApUNAT = 3108,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR37"]/*' />
    CV_IA64_AR37 = 3109,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR38"]/*' />
    CV_IA64_AR38 = 3110,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR39"]/*' />
    CV_IA64_AR39 = 3111,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_StFPSR"]/*' />
    CV_IA64_StFPSR = 3112,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR41"]/*' />
    CV_IA64_AR41 = 3113,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR42"]/*' />
    CV_IA64_AR42 = 3114,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR43"]/*' />
    CV_IA64_AR43 = 3115,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApITC"]/*' />
    CV_IA64_ApITC = 3116,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR45"]/*' />
    CV_IA64_AR45 = 3117,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR46"]/*' />
    CV_IA64_AR46 = 3118,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR47"]/*' />
    CV_IA64_AR47 = 3119,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR48"]/*' />
    CV_IA64_AR48 = 3120,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR49"]/*' />
    CV_IA64_AR49 = 3121,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR50"]/*' />
    CV_IA64_AR50 = 3122,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR51"]/*' />
    CV_IA64_AR51 = 3123,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR52"]/*' />
    CV_IA64_AR52 = 3124,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR53"]/*' />
    CV_IA64_AR53 = 3125,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR54"]/*' />
    CV_IA64_AR54 = 3126,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR55"]/*' />
    CV_IA64_AR55 = 3127,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR56"]/*' />
    CV_IA64_AR56 = 3128,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR57"]/*' />
    CV_IA64_AR57 = 3129,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR58"]/*' />
    CV_IA64_AR58 = 3130,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR59"]/*' />
    CV_IA64_AR59 = 3131,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR60"]/*' />
    CV_IA64_AR60 = 3132,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR61"]/*' />
    CV_IA64_AR61 = 3133,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR62"]/*' />
    CV_IA64_AR62 = 3134,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR63"]/*' />
    CV_IA64_AR63 = 3135,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_RsPFS"]/*' />
    CV_IA64_RsPFS = 3136,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApLC"]/*' />
    CV_IA64_ApLC = 3137,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApEC"]/*' />
    CV_IA64_ApEC = 3138,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR67"]/*' />
    CV_IA64_AR67 = 3139,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR68"]/*' />
    CV_IA64_AR68 = 3140,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR69"]/*' />
    CV_IA64_AR69 = 3141,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR70"]/*' />
    CV_IA64_AR70 = 3142,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR71"]/*' />
    CV_IA64_AR71 = 3143,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR72"]/*' />
    CV_IA64_AR72 = 3144,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR73"]/*' />
    CV_IA64_AR73 = 3145,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR74"]/*' />
    CV_IA64_AR74 = 3146,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR75"]/*' />
    CV_IA64_AR75 = 3147,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR76"]/*' />
    CV_IA64_AR76 = 3148,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR77"]/*' />
    CV_IA64_AR77 = 3149,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR78"]/*' />
    CV_IA64_AR78 = 3150,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR79"]/*' />
    CV_IA64_AR79 = 3151,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR80"]/*' />
    CV_IA64_AR80 = 3152,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR81"]/*' />
    CV_IA64_AR81 = 3153,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR82"]/*' />
    CV_IA64_AR82 = 3154,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR83"]/*' />
    CV_IA64_AR83 = 3155,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR84"]/*' />
    CV_IA64_AR84 = 3156,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR85"]/*' />
    CV_IA64_AR85 = 3157,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR86"]/*' />
    CV_IA64_AR86 = 3158,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR87"]/*' />
    CV_IA64_AR87 = 3159,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR88"]/*' />
    CV_IA64_AR88 = 3160,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR89"]/*' />
    CV_IA64_AR89 = 3161,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR90"]/*' />
    CV_IA64_AR90 = 3162,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR91"]/*' />
    CV_IA64_AR91 = 3163,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR92"]/*' />
    CV_IA64_AR92 = 3164,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR93"]/*' />
    CV_IA64_AR93 = 3165,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR94"]/*' />
    CV_IA64_AR94 = 3166,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR95"]/*' />
    CV_IA64_AR95 = 3167,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR96"]/*' />
    CV_IA64_AR96 = 3168,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR97"]/*' />
    CV_IA64_AR97 = 3169,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR98"]/*' />
    CV_IA64_AR98 = 3170,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR99"]/*' />
    CV_IA64_AR99 = 3171,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR100"]/*' />
    CV_IA64_AR100 = 3172,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR101"]/*' />
    CV_IA64_AR101 = 3173,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR102"]/*' />
    CV_IA64_AR102 = 3174,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR103"]/*' />
    CV_IA64_AR103 = 3175,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR104"]/*' />
    CV_IA64_AR104 = 3176,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR105"]/*' />
    CV_IA64_AR105 = 3177,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR106"]/*' />
    CV_IA64_AR106 = 3178,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR107"]/*' />
    CV_IA64_AR107 = 3179,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR108"]/*' />
    CV_IA64_AR108 = 3180,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR109"]/*' />
    CV_IA64_AR109 = 3181,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR110"]/*' />
    CV_IA64_AR110 = 3182,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR111"]/*' />
    CV_IA64_AR111 = 3183,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR112"]/*' />
    CV_IA64_AR112 = 3184,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR113"]/*' />
    CV_IA64_AR113 = 3185,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR114"]/*' />
    CV_IA64_AR114 = 3186,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR115"]/*' />
    CV_IA64_AR115 = 3187,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR116"]/*' />
    CV_IA64_AR116 = 3188,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR117"]/*' />
    CV_IA64_AR117 = 3189,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR118"]/*' />
    CV_IA64_AR118 = 3190,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR119"]/*' />
    CV_IA64_AR119 = 3191,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR120"]/*' />
    CV_IA64_AR120 = 3192,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR121"]/*' />
    CV_IA64_AR121 = 3193,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR122"]/*' />
    CV_IA64_AR122 = 3194,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR123"]/*' />
    CV_IA64_AR123 = 3195,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR124"]/*' />
    CV_IA64_AR124 = 3196,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR125"]/*' />
    CV_IA64_AR125 = 3197,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR126"]/*' />
    CV_IA64_AR126 = 3198,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_AR127"]/*' />
    CV_IA64_AR127 = 3199,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CPUID0"]/*' />
    CV_IA64_CPUID0 = 3328,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CPUID1"]/*' />
    CV_IA64_CPUID1 = 3329,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CPUID2"]/*' />
    CV_IA64_CPUID2 = 3330,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CPUID3"]/*' />
    CV_IA64_CPUID3 = 3331,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CPUID4"]/*' />
    CV_IA64_CPUID4 = 3332,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApDCR"]/*' />
    CV_IA64_ApDCR = 4096,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApITM"]/*' />
    CV_IA64_ApITM = 4097,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApIVA"]/*' />
    CV_IA64_ApIVA = 4098,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR3"]/*' />
    CV_IA64_CR3 = 4099,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR4"]/*' />
    CV_IA64_CR4 = 4100,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR5"]/*' />
    CV_IA64_CR5 = 4101,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR6"]/*' />
    CV_IA64_CR6 = 4102,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR7"]/*' />
    CV_IA64_CR7 = 4103,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApPTA"]/*' />
    CV_IA64_ApPTA = 4104,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_ApGPTA"]/*' />
    CV_IA64_ApGPTA = 4105,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR10"]/*' />
    CV_IA64_CR10 = 4106,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR11"]/*' />
    CV_IA64_CR11 = 4107,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR12"]/*' />
    CV_IA64_CR12 = 4108,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR13"]/*' />
    CV_IA64_CR13 = 4109,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR14"]/*' />
    CV_IA64_CR14 = 4110,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR15"]/*' />
    CV_IA64_CR15 = 4111,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_StIPSR"]/*' />
    CV_IA64_StIPSR = 4112,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_StISR"]/*' />
    CV_IA64_StISR = 4113,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR18"]/*' />
    CV_IA64_CR18 = 4114,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_StIIP"]/*' />
    CV_IA64_StIIP = 4115,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_StIFA"]/*' />
    CV_IA64_StIFA = 4116,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_StITIR"]/*' />
    CV_IA64_StITIR = 4117,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_StIIPA"]/*' />
    CV_IA64_StIIPA = 4118,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_StIFS"]/*' />
    CV_IA64_StIFS = 4119,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_StIIM"]/*' />
    CV_IA64_StIIM = 4120,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_StIHA"]/*' />
    CV_IA64_StIHA = 4121,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR26"]/*' />
    CV_IA64_CR26 = 4122,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR27"]/*' />
    CV_IA64_CR27 = 4123,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR28"]/*' />
    CV_IA64_CR28 = 4124,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR29"]/*' />
    CV_IA64_CR29 = 4125,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR30"]/*' />
    CV_IA64_CR30 = 4126,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR31"]/*' />
    CV_IA64_CR31 = 4127,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR32"]/*' />
    CV_IA64_CR32 = 4128,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR33"]/*' />
    CV_IA64_CR33 = 4129,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR34"]/*' />
    CV_IA64_CR34 = 4130,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR35"]/*' />
    CV_IA64_CR35 = 4131,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR36"]/*' />
    CV_IA64_CR36 = 4132,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR37"]/*' />
    CV_IA64_CR37 = 4133,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR38"]/*' />
    CV_IA64_CR38 = 4134,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR39"]/*' />
    CV_IA64_CR39 = 4135,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR40"]/*' />
    CV_IA64_CR40 = 4136,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR41"]/*' />
    CV_IA64_CR41 = 4137,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR42"]/*' />
    CV_IA64_CR42 = 4138,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR43"]/*' />
    CV_IA64_CR43 = 4139,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR44"]/*' />
    CV_IA64_CR44 = 4140,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR45"]/*' />
    CV_IA64_CR45 = 4141,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR46"]/*' />
    CV_IA64_CR46 = 4142,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR47"]/*' />
    CV_IA64_CR47 = 4143,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR48"]/*' />
    CV_IA64_CR48 = 4144,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR49"]/*' />
    CV_IA64_CR49 = 4145,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR50"]/*' />
    CV_IA64_CR50 = 4146,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR51"]/*' />
    CV_IA64_CR51 = 4147,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR52"]/*' />
    CV_IA64_CR52 = 4148,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR53"]/*' />
    CV_IA64_CR53 = 4149,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR54"]/*' />
    CV_IA64_CR54 = 4150,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR55"]/*' />
    CV_IA64_CR55 = 4151,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR56"]/*' />
    CV_IA64_CR56 = 4152,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR57"]/*' />
    CV_IA64_CR57 = 4153,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR58"]/*' />
    CV_IA64_CR58 = 4154,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR59"]/*' />
    CV_IA64_CR59 = 4155,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR60"]/*' />
    CV_IA64_CR60 = 4156,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR61"]/*' />
    CV_IA64_CR61 = 4157,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR62"]/*' />
    CV_IA64_CR62 = 4158,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR63"]/*' />
    CV_IA64_CR63 = 4159,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_SaLID"]/*' />
    CV_IA64_SaLID = 4160,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_SaIVR"]/*' />
    CV_IA64_SaIVR = 4161,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_SaTPR"]/*' />
    CV_IA64_SaTPR = 4162,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_SaEOI"]/*' />
    CV_IA64_SaEOI = 4163,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_SaIRR0"]/*' />
    CV_IA64_SaIRR0 = 4164,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_SaIRR1"]/*' />
    CV_IA64_SaIRR1 = 4165,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_SaIRR2"]/*' />
    CV_IA64_SaIRR2 = 4166,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_SaIRR3"]/*' />
    CV_IA64_SaIRR3 = 4167,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_SaITV"]/*' />
    CV_IA64_SaITV = 4168,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_SaPMV"]/*' />
    CV_IA64_SaPMV = 4169,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_SaCMCV"]/*' />
    CV_IA64_SaCMCV = 4170,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR75"]/*' />
    CV_IA64_CR75 = 4171,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR76"]/*' />
    CV_IA64_CR76 = 4172,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR77"]/*' />
    CV_IA64_CR77 = 4173,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR78"]/*' />
    CV_IA64_CR78 = 4174,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR79"]/*' />
    CV_IA64_CR79 = 4175,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_SaLRR0"]/*' />
    CV_IA64_SaLRR0 = 4176,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_SaLRR1"]/*' />
    CV_IA64_SaLRR1 = 4177,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR82"]/*' />
    CV_IA64_CR82 = 4178,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR83"]/*' />
    CV_IA64_CR83 = 4179,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR84"]/*' />
    CV_IA64_CR84 = 4180,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR85"]/*' />
    CV_IA64_CR85 = 4181,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR86"]/*' />
    CV_IA64_CR86 = 4182,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR87"]/*' />
    CV_IA64_CR87 = 4183,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR88"]/*' />
    CV_IA64_CR88 = 4184,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR89"]/*' />
    CV_IA64_CR89 = 4185,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR90"]/*' />
    CV_IA64_CR90 = 4186,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR91"]/*' />
    CV_IA64_CR91 = 4187,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR92"]/*' />
    CV_IA64_CR92 = 4188,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR93"]/*' />
    CV_IA64_CR93 = 4189,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR94"]/*' />
    CV_IA64_CR94 = 4190,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR95"]/*' />
    CV_IA64_CR95 = 4191,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR96"]/*' />
    CV_IA64_CR96 = 4192,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR97"]/*' />
    CV_IA64_CR97 = 4193,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR98"]/*' />
    CV_IA64_CR98 = 4194,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR99"]/*' />
    CV_IA64_CR99 = 4195,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR100"]/*' />
    CV_IA64_CR100 = 4196,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR101"]/*' />
    CV_IA64_CR101 = 4197,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR102"]/*' />
    CV_IA64_CR102 = 4198,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR103"]/*' />
    CV_IA64_CR103 = 4199,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR104"]/*' />
    CV_IA64_CR104 = 4200,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR105"]/*' />
    CV_IA64_CR105 = 4201,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR106"]/*' />
    CV_IA64_CR106 = 4202,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR107"]/*' />
    CV_IA64_CR107 = 4203,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR108"]/*' />
    CV_IA64_CR108 = 4204,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR109"]/*' />
    CV_IA64_CR109 = 4205,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR110"]/*' />
    CV_IA64_CR110 = 4206,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR111"]/*' />
    CV_IA64_CR111 = 4207,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR112"]/*' />
    CV_IA64_CR112 = 4208,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR113"]/*' />
    CV_IA64_CR113 = 4209,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR114"]/*' />
    CV_IA64_CR114 = 4210,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR115"]/*' />
    CV_IA64_CR115 = 4211,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR116"]/*' />
    CV_IA64_CR116 = 4212,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR117"]/*' />
    CV_IA64_CR117 = 4213,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR118"]/*' />
    CV_IA64_CR118 = 4214,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR119"]/*' />
    CV_IA64_CR119 = 4215,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR120"]/*' />
    CV_IA64_CR120 = 4216,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR121"]/*' />
    CV_IA64_CR121 = 4217,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR122"]/*' />
    CV_IA64_CR122 = 4218,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR123"]/*' />
    CV_IA64_CR123 = 4219,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR124"]/*' />
    CV_IA64_CR124 = 4220,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR125"]/*' />
    CV_IA64_CR125 = 4221,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR126"]/*' />
    CV_IA64_CR126 = 4222,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_CR127"]/*' />
    CV_IA64_CR127 = 4223,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Pkr0"]/*' />
    CV_IA64_Pkr0 = 5120,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Pkr1"]/*' />
    CV_IA64_Pkr1 = 5121,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Pkr2"]/*' />
    CV_IA64_Pkr2 = 5122,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Pkr3"]/*' />
    CV_IA64_Pkr3 = 5123,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Pkr4"]/*' />
    CV_IA64_Pkr4 = 5124,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Pkr5"]/*' />
    CV_IA64_Pkr5 = 5125,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Pkr6"]/*' />
    CV_IA64_Pkr6 = 5126,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Pkr7"]/*' />
    CV_IA64_Pkr7 = 5127,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Pkr8"]/*' />
    CV_IA64_Pkr8 = 5128,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Pkr9"]/*' />
    CV_IA64_Pkr9 = 5129,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Pkr10"]/*' />
    CV_IA64_Pkr10 = 5130,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Pkr11"]/*' />
    CV_IA64_Pkr11 = 5131,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Pkr12"]/*' />
    CV_IA64_Pkr12 = 5132,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Pkr13"]/*' />
    CV_IA64_Pkr13 = 5133,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Pkr14"]/*' />
    CV_IA64_Pkr14 = 5134,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Pkr15"]/*' />
    CV_IA64_Pkr15 = 5135,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Rr0"]/*' />
    CV_IA64_Rr0 = 6144,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Rr1"]/*' />
    CV_IA64_Rr1 = 6145,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Rr2"]/*' />
    CV_IA64_Rr2 = 6146,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Rr3"]/*' />
    CV_IA64_Rr3 = 6147,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Rr4"]/*' />
    CV_IA64_Rr4 = 6148,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Rr5"]/*' />
    CV_IA64_Rr5 = 6149,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Rr6"]/*' />
    CV_IA64_Rr6 = 6150,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_Rr7"]/*' />
    CV_IA64_Rr7 = 6151,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD0"]/*' />
    CV_IA64_PFD0 = 7168,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD1"]/*' />
    CV_IA64_PFD1 = 7169,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD2"]/*' />
    CV_IA64_PFD2 = 7170,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD3"]/*' />
    CV_IA64_PFD3 = 7171,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD4"]/*' />
    CV_IA64_PFD4 = 7172,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD5"]/*' />
    CV_IA64_PFD5 = 7173,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD6"]/*' />
    CV_IA64_PFD6 = 7174,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD7"]/*' />
    CV_IA64_PFD7 = 7175,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD8"]/*' />
    CV_IA64_PFD8 = 7176,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD9"]/*' />
    CV_IA64_PFD9 = 7177,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD10"]/*' />
    CV_IA64_PFD10 = 7178,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD11"]/*' />
    CV_IA64_PFD11 = 7179,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD12"]/*' />
    CV_IA64_PFD12 = 7180,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD13"]/*' />
    CV_IA64_PFD13 = 7181,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD14"]/*' />
    CV_IA64_PFD14 = 7182,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD15"]/*' />
    CV_IA64_PFD15 = 7183,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD16"]/*' />
    CV_IA64_PFD16 = 7184,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFD17"]/*' />
    CV_IA64_PFD17 = 7185,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFC0"]/*' />
    CV_IA64_PFC0 = 7424,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFC1"]/*' />
    CV_IA64_PFC1 = 7425,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFC2"]/*' />
    CV_IA64_PFC2 = 7426,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFC3"]/*' />
    CV_IA64_PFC3 = 7427,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFC4"]/*' />
    CV_IA64_PFC4 = 7428,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFC5"]/*' />
    CV_IA64_PFC5 = 7429,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFC6"]/*' />
    CV_IA64_PFC6 = 7430,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFC7"]/*' />
    CV_IA64_PFC7 = 7431,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFC8"]/*' />
    CV_IA64_PFC8 = 7432,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFC9"]/*' />
    CV_IA64_PFC9 = 7433,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFC10"]/*' />
    CV_IA64_PFC10 = 7434,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFC11"]/*' />
    CV_IA64_PFC11 = 7435,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFC12"]/*' />
    CV_IA64_PFC12 = 7436,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFC13"]/*' />
    CV_IA64_PFC13 = 7437,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFC14"]/*' />
    CV_IA64_PFC14 = 7438,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_PFC15"]/*' />
    CV_IA64_PFC15 = 7439,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_TrI0"]/*' />
    CV_IA64_TrI0 = 8192,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_TrI1"]/*' />
    CV_IA64_TrI1 = 8193,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_TrI2"]/*' />
    CV_IA64_TrI2 = 8194,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_TrI3"]/*' />
    CV_IA64_TrI3 = 8195,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_TrI4"]/*' />
    CV_IA64_TrI4 = 8196,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_TrI5"]/*' />
    CV_IA64_TrI5 = 8197,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_TrI6"]/*' />
    CV_IA64_TrI6 = 8198,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_TrI7"]/*' />
    CV_IA64_TrI7 = 8199,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_TrD0"]/*' />
    CV_IA64_TrD0 = 8320,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_TrD1"]/*' />
    CV_IA64_TrD1 = 8321,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_TrD2"]/*' />
    CV_IA64_TrD2 = 8322,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_TrD3"]/*' />
    CV_IA64_TrD3 = 8323,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_TrD4"]/*' />
    CV_IA64_TrD4 = 8324,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_TrD5"]/*' />
    CV_IA64_TrD5 = 8325,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_TrD6"]/*' />
    CV_IA64_TrD6 = 8326,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_TrD7"]/*' />
    CV_IA64_TrD7 = 8327,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_DbI0"]/*' />
    CV_IA64_DbI0 = 8448,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_DbI1"]/*' />
    CV_IA64_DbI1 = 8449,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_DbI2"]/*' />
    CV_IA64_DbI2 = 8450,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_DbI3"]/*' />
    CV_IA64_DbI3 = 8451,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_DbI4"]/*' />
    CV_IA64_DbI4 = 8452,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_DbI5"]/*' />
    CV_IA64_DbI5 = 8453,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_DbI6"]/*' />
    CV_IA64_DbI6 = 8454,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_DbI7"]/*' />
    CV_IA64_DbI7 = 8455,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_DbD0"]/*' />
    CV_IA64_DbD0 = 8576,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_DbD1"]/*' />
    CV_IA64_DbD1 = 8577,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_DbD2"]/*' />
    CV_IA64_DbD2 = 8578,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_DbD3"]/*' />
    CV_IA64_DbD3 = 8579,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_DbD4"]/*' />
    CV_IA64_DbD4 = 8580,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_DbD5"]/*' />
    CV_IA64_DbD5 = 8581,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_DbD6"]/*' />
    CV_IA64_DbD6 = 8582,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_IA64_DbD7"]/*' />
    CV_IA64_DbD7 = 8583,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_NOREG"]/*' />
    CV_TRI_NOREG = CV_REG_NONE,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_D0"]/*' />
    CV_TRI_D0 = 10,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_D1"]/*' />
    CV_TRI_D1 = 11,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_D2"]/*' />
    CV_TRI_D2 = 12,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_D3"]/*' />
    CV_TRI_D3 = 13,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_D4"]/*' />
    CV_TRI_D4 = 14,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_D5"]/*' />
    CV_TRI_D5 = 15,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_D6"]/*' />
    CV_TRI_D6 = 16,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_D7"]/*' />
    CV_TRI_D7 = 17,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_D8"]/*' />
    CV_TRI_D8 = 18,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_D9"]/*' />
    CV_TRI_D9 = 19,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_D10"]/*' />
    CV_TRI_D10 = 20,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_D11"]/*' />
    CV_TRI_D11 = 21,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_D12"]/*' />
    CV_TRI_D12 = 22,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_D13"]/*' />
    CV_TRI_D13 = 23,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_D14"]/*' />
    CV_TRI_D14 = 24,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_D15"]/*' />
    CV_TRI_D15 = 25,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_A0"]/*' />
    CV_TRI_A0 = 26,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_A1"]/*' />
    CV_TRI_A1 = 27,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_A2"]/*' />
    CV_TRI_A2 = 28,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_A3"]/*' />
    CV_TRI_A3 = 29,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_A4"]/*' />
    CV_TRI_A4 = 30,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_A5"]/*' />
    CV_TRI_A5 = 31,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_A6"]/*' />
    CV_TRI_A6 = 32,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_A7"]/*' />
    CV_TRI_A7 = 33,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_A8"]/*' />
    CV_TRI_A8 = 34,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_A9"]/*' />
    CV_TRI_A9 = 35,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_A10"]/*' />
    CV_TRI_A10 = 36,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_A11"]/*' />
    CV_TRI_A11 = 37,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_A12"]/*' />
    CV_TRI_A12 = 38,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_A13"]/*' />
    CV_TRI_A13 = 39,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_A14"]/*' />
    CV_TRI_A14 = 40,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_A15"]/*' />
    CV_TRI_A15 = 41,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_E0"]/*' />
    CV_TRI_E0 = 42,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_E2"]/*' />
    CV_TRI_E2 = 43,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_E4"]/*' />
    CV_TRI_E4 = 44,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_E6"]/*' />
    CV_TRI_E6 = 45,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_E8"]/*' />
    CV_TRI_E8 = 46,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_E10"]/*' />
    CV_TRI_E10 = 47,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_E12"]/*' />
    CV_TRI_E12 = 48,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_E14"]/*' />
    CV_TRI_E14 = 49,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_EA0"]/*' />
    CV_TRI_EA0 = 50,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_EA2"]/*' />
    CV_TRI_EA2 = 51,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_EA4"]/*' />
    CV_TRI_EA4 = 52,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_EA6"]/*' />
    CV_TRI_EA6 = 53,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_EA8"]/*' />
    CV_TRI_EA8 = 54,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_EA10"]/*' />
    CV_TRI_EA10 = 55,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_EA12"]/*' />
    CV_TRI_EA12 = 56,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_EA14"]/*' />
    CV_TRI_EA14 = 57,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_PSW"]/*' />
    CV_TRI_PSW = 58,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_PCXI"]/*' />
    CV_TRI_PCXI = 59,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_PC"]/*' />
    CV_TRI_PC = 60,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_FCX"]/*' />
    CV_TRI_FCX = 61,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_LCX"]/*' />
    CV_TRI_LCX = 62,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_ISP"]/*' />
    CV_TRI_ISP = 63,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_ICR"]/*' />
    CV_TRI_ICR = 64,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_BIV"]/*' />
    CV_TRI_BIV = 65,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_BTV"]/*' />
    CV_TRI_BTV = 66,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_SYSCON"]/*' />
    CV_TRI_SYSCON = 67,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_DPRx_0"]/*' />
    CV_TRI_DPRx_0 = 68,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_DPRx_1"]/*' />
    CV_TRI_DPRx_1 = 69,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_DPRx_2"]/*' />
    CV_TRI_DPRx_2 = 70,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_DPRx_3"]/*' />
    CV_TRI_DPRx_3 = 71,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_CPRx_0"]/*' />
    CV_TRI_CPRx_0 = 68,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_CPRx_1"]/*' />
    CV_TRI_CPRx_1 = 69,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_CPRx_2"]/*' />
    CV_TRI_CPRx_2 = 70,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_CPRx_3"]/*' />
    CV_TRI_CPRx_3 = 71,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_DPMx_0"]/*' />
    CV_TRI_DPMx_0 = 68,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_DPMx_1"]/*' />
    CV_TRI_DPMx_1 = 69,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_DPMx_2"]/*' />
    CV_TRI_DPMx_2 = 70,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_DPMx_3"]/*' />
    CV_TRI_DPMx_3 = 71,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_CPMx_0"]/*' />
    CV_TRI_CPMx_0 = 68,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_CPMx_1"]/*' />
    CV_TRI_CPMx_1 = 69,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_CPMx_2"]/*' />
    CV_TRI_CPMx_2 = 70,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_CPMx_3"]/*' />
    CV_TRI_CPMx_3 = 71,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_DBGSSR"]/*' />
    CV_TRI_DBGSSR = 72,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_EXEVT"]/*' />
    CV_TRI_EXEVT = 73,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_SWEVT"]/*' />
    CV_TRI_SWEVT = 74,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_CREVT"]/*' />
    CV_TRI_CREVT = 75,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_TRnEVT"]/*' />
    CV_TRI_TRnEVT = 76,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_MMUCON"]/*' />
    CV_TRI_MMUCON = 77,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_ASI"]/*' />
    CV_TRI_ASI = 78,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_TVA"]/*' />
    CV_TRI_TVA = 79,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_TPA"]/*' />
    CV_TRI_TPA = 80,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_TPX"]/*' />
    CV_TRI_TPX = 81,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_TRI_TFA"]/*' />
    CV_TRI_TFA = 82,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_NOREG"]/*' />
    CV_AM33_NOREG = CV_REG_NONE,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_E0"]/*' />
    CV_AM33_E0 = 10,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_E1"]/*' />
    CV_AM33_E1 = 11,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_E2"]/*' />
    CV_AM33_E2 = 12,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_E3"]/*' />
    CV_AM33_E3 = 13,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_E4"]/*' />
    CV_AM33_E4 = 14,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_E5"]/*' />
    CV_AM33_E5 = 15,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_E6"]/*' />
    CV_AM33_E6 = 16,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_E7"]/*' />
    CV_AM33_E7 = 17,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_A0"]/*' />
    CV_AM33_A0 = 20,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_A1"]/*' />
    CV_AM33_A1 = 21,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_A2"]/*' />
    CV_AM33_A2 = 22,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_A3"]/*' />
    CV_AM33_A3 = 23,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_D0"]/*' />
    CV_AM33_D0 = 30,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_D1"]/*' />
    CV_AM33_D1 = 31,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_D2"]/*' />
    CV_AM33_D2 = 32,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_D3"]/*' />
    CV_AM33_D3 = 33,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS0"]/*' />
    CV_AM33_FS0 = 40,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS1"]/*' />
    CV_AM33_FS1 = 41,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS2"]/*' />
    CV_AM33_FS2 = 42,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS3"]/*' />
    CV_AM33_FS3 = 43,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS4"]/*' />
    CV_AM33_FS4 = 44,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS5"]/*' />
    CV_AM33_FS5 = 45,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS6"]/*' />
    CV_AM33_FS6 = 46,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS7"]/*' />
    CV_AM33_FS7 = 47,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS8"]/*' />
    CV_AM33_FS8 = 48,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS9"]/*' />
    CV_AM33_FS9 = 49,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS10"]/*' />
    CV_AM33_FS10 = 50,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS11"]/*' />
    CV_AM33_FS11 = 51,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS12"]/*' />
    CV_AM33_FS12 = 52,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS13"]/*' />
    CV_AM33_FS13 = 53,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS14"]/*' />
    CV_AM33_FS14 = 54,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS15"]/*' />
    CV_AM33_FS15 = 55,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS16"]/*' />
    CV_AM33_FS16 = 56,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS17"]/*' />
    CV_AM33_FS17 = 57,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS18"]/*' />
    CV_AM33_FS18 = 58,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS19"]/*' />
    CV_AM33_FS19 = 59,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS20"]/*' />
    CV_AM33_FS20 = 60,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS21"]/*' />
    CV_AM33_FS21 = 61,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS22"]/*' />
    CV_AM33_FS22 = 62,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS23"]/*' />
    CV_AM33_FS23 = 63,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS24"]/*' />
    CV_AM33_FS24 = 64,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS25"]/*' />
    CV_AM33_FS25 = 65,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS26"]/*' />
    CV_AM33_FS26 = 66,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS27"]/*' />
    CV_AM33_FS27 = 67,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS28"]/*' />
    CV_AM33_FS28 = 68,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS29"]/*' />
    CV_AM33_FS29 = 69,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS30"]/*' />
    CV_AM33_FS30 = 70,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FS31"]/*' />
    CV_AM33_FS31 = 71,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_SP"]/*' />
    CV_AM33_SP = 80,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_PC"]/*' />
    CV_AM33_PC = 81,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_MDR"]/*' />
    CV_AM33_MDR = 82,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_MDRQ"]/*' />
    CV_AM33_MDRQ = 83,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_MCRH"]/*' />
    CV_AM33_MCRH = 84,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_MCRL"]/*' />
    CV_AM33_MCRL = 85,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_MCVF"]/*' />
    CV_AM33_MCVF = 86,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_EPSW"]/*' />
    CV_AM33_EPSW = 87,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_FPCR"]/*' />
    CV_AM33_FPCR = 88,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_LIR"]/*' />
    CV_AM33_LIR = 89,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AM33_LAR"]/*' />
    CV_AM33_LAR = 90,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_NOREG"]/*' />
    CV_M32R_NOREG = CV_REG_NONE,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_R0"]/*' />
    CV_M32R_R0 = 10,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_R1"]/*' />
    CV_M32R_R1 = 11,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_R2"]/*' />
    CV_M32R_R2 = 12,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_R3"]/*' />
    CV_M32R_R3 = 13,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_R4"]/*' />
    CV_M32R_R4 = 14,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_R5"]/*' />
    CV_M32R_R5 = 15,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_R6"]/*' />
    CV_M32R_R6 = 16,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_R7"]/*' />
    CV_M32R_R7 = 17,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_R8"]/*' />
    CV_M32R_R8 = 18,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_R9"]/*' />
    CV_M32R_R9 = 19,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_R10"]/*' />
    CV_M32R_R10 = 20,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_R11"]/*' />
    CV_M32R_R11 = 21,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_R12"]/*' />
    CV_M32R_R12 = 22,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_R13"]/*' />
    CV_M32R_R13 = 23,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_R14"]/*' />
    CV_M32R_R14 = 24,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_R15"]/*' />
    CV_M32R_R15 = 25,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_PSW"]/*' />
    CV_M32R_PSW = 26,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_CBR"]/*' />
    CV_M32R_CBR = 27,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_SPI"]/*' />
    CV_M32R_SPI = 28,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_SPU"]/*' />
    CV_M32R_SPU = 29,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_SPO"]/*' />
    CV_M32R_SPO = 30,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_BPC"]/*' />
    CV_M32R_BPC = 31,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_ACHI"]/*' />
    CV_M32R_ACHI = 32,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_ACLO"]/*' />
    CV_M32R_ACLO = 33,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_M32R_PC"]/*' />
    CV_M32R_PC = 34,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_NOREG"]/*' />
    CV_SHMEDIA_NOREG = CV_REG_NONE,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R0"]/*' />
    CV_SHMEDIA_R0 = 10,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R1"]/*' />
    CV_SHMEDIA_R1 = 11,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R2"]/*' />
    CV_SHMEDIA_R2 = 12,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R3"]/*' />
    CV_SHMEDIA_R3 = 13,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R4"]/*' />
    CV_SHMEDIA_R4 = 14,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R5"]/*' />
    CV_SHMEDIA_R5 = 15,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R6"]/*' />
    CV_SHMEDIA_R6 = 16,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R7"]/*' />
    CV_SHMEDIA_R7 = 17,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R8"]/*' />
    CV_SHMEDIA_R8 = 18,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R9"]/*' />
    CV_SHMEDIA_R9 = 19,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R10"]/*' />
    CV_SHMEDIA_R10 = 20,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R11"]/*' />
    CV_SHMEDIA_R11 = 21,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R12"]/*' />
    CV_SHMEDIA_R12 = 22,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R13"]/*' />
    CV_SHMEDIA_R13 = 23,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R14"]/*' />
    CV_SHMEDIA_R14 = 24,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R15"]/*' />
    CV_SHMEDIA_R15 = 25,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R16"]/*' />
    CV_SHMEDIA_R16 = 26,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R17"]/*' />
    CV_SHMEDIA_R17 = 27,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R18"]/*' />
    CV_SHMEDIA_R18 = 28,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R19"]/*' />
    CV_SHMEDIA_R19 = 29,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R20"]/*' />
    CV_SHMEDIA_R20 = 30,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R21"]/*' />
    CV_SHMEDIA_R21 = 31,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R22"]/*' />
    CV_SHMEDIA_R22 = 32,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R23"]/*' />
    CV_SHMEDIA_R23 = 33,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R24"]/*' />
    CV_SHMEDIA_R24 = 34,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R25"]/*' />
    CV_SHMEDIA_R25 = 35,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R26"]/*' />
    CV_SHMEDIA_R26 = 36,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R27"]/*' />
    CV_SHMEDIA_R27 = 37,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R28"]/*' />
    CV_SHMEDIA_R28 = 38,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R29"]/*' />
    CV_SHMEDIA_R29 = 39,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R30"]/*' />
    CV_SHMEDIA_R30 = 40,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R31"]/*' />
    CV_SHMEDIA_R31 = 41,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R32"]/*' />
    CV_SHMEDIA_R32 = 42,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R33"]/*' />
    CV_SHMEDIA_R33 = 43,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R34"]/*' />
    CV_SHMEDIA_R34 = 44,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R35"]/*' />
    CV_SHMEDIA_R35 = 45,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R36"]/*' />
    CV_SHMEDIA_R36 = 46,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R37"]/*' />
    CV_SHMEDIA_R37 = 47,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R38"]/*' />
    CV_SHMEDIA_R38 = 48,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R39"]/*' />
    CV_SHMEDIA_R39 = 49,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R40"]/*' />
    CV_SHMEDIA_R40 = 50,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R41"]/*' />
    CV_SHMEDIA_R41 = 51,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R42"]/*' />
    CV_SHMEDIA_R42 = 52,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R43"]/*' />
    CV_SHMEDIA_R43 = 53,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R44"]/*' />
    CV_SHMEDIA_R44 = 54,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R45"]/*' />
    CV_SHMEDIA_R45 = 55,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R46"]/*' />
    CV_SHMEDIA_R46 = 56,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R47"]/*' />
    CV_SHMEDIA_R47 = 57,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R48"]/*' />
    CV_SHMEDIA_R48 = 58,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R49"]/*' />
    CV_SHMEDIA_R49 = 59,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R50"]/*' />
    CV_SHMEDIA_R50 = 60,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R51"]/*' />
    CV_SHMEDIA_R51 = 61,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R52"]/*' />
    CV_SHMEDIA_R52 = 62,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R53"]/*' />
    CV_SHMEDIA_R53 = 63,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R54"]/*' />
    CV_SHMEDIA_R54 = 64,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R55"]/*' />
    CV_SHMEDIA_R55 = 65,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R56"]/*' />
    CV_SHMEDIA_R56 = 66,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R57"]/*' />
    CV_SHMEDIA_R57 = 67,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R58"]/*' />
    CV_SHMEDIA_R58 = 68,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R59"]/*' />
    CV_SHMEDIA_R59 = 69,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R60"]/*' />
    CV_SHMEDIA_R60 = 70,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R61"]/*' />
    CV_SHMEDIA_R61 = 71,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R62"]/*' />
    CV_SHMEDIA_R62 = 72,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_R63"]/*' />
    CV_SHMEDIA_R63 = 73,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_TR0"]/*' />
    CV_SHMEDIA_TR0 = 74,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_TR1"]/*' />
    CV_SHMEDIA_TR1 = 75,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_TR2"]/*' />
    CV_SHMEDIA_TR2 = 76,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_TR3"]/*' />
    CV_SHMEDIA_TR3 = 77,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_TR4"]/*' />
    CV_SHMEDIA_TR4 = 78,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_TR5"]/*' />
    CV_SHMEDIA_TR5 = 79,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_TR6"]/*' />
    CV_SHMEDIA_TR6 = 80,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_TR7"]/*' />
    CV_SHMEDIA_TR7 = 81,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_TR8"]/*' />
    CV_SHMEDIA_TR8 = 82,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_TR9"]/*' />
    CV_SHMEDIA_TR9 = 83,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_TR10"]/*' />
    CV_SHMEDIA_TR10 = 84,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_TR11"]/*' />
    CV_SHMEDIA_TR11 = 85,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_TR12"]/*' />
    CV_SHMEDIA_TR12 = 86,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_TR13"]/*' />
    CV_SHMEDIA_TR13 = 87,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_TR14"]/*' />
    CV_SHMEDIA_TR14 = 88,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_TR15"]/*' />
    CV_SHMEDIA_TR15 = 89,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR0"]/*' />
    CV_SHMEDIA_FR0 = 128,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR1"]/*' />
    CV_SHMEDIA_FR1 = 129,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR2"]/*' />
    CV_SHMEDIA_FR2 = 130,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR3"]/*' />
    CV_SHMEDIA_FR3 = 131,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR4"]/*' />
    CV_SHMEDIA_FR4 = 132,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR5"]/*' />
    CV_SHMEDIA_FR5 = 133,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR6"]/*' />
    CV_SHMEDIA_FR6 = 134,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR7"]/*' />
    CV_SHMEDIA_FR7 = 135,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR8"]/*' />
    CV_SHMEDIA_FR8 = 136,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR9"]/*' />
    CV_SHMEDIA_FR9 = 137,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR10"]/*' />
    CV_SHMEDIA_FR10 = 138,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR11"]/*' />
    CV_SHMEDIA_FR11 = 139,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR12"]/*' />
    CV_SHMEDIA_FR12 = 140,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR13"]/*' />
    CV_SHMEDIA_FR13 = 141,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR14"]/*' />
    CV_SHMEDIA_FR14 = 142,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR15"]/*' />
    CV_SHMEDIA_FR15 = 143,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR16"]/*' />
    CV_SHMEDIA_FR16 = 144,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR17"]/*' />
    CV_SHMEDIA_FR17 = 145,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR18"]/*' />
    CV_SHMEDIA_FR18 = 146,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR19"]/*' />
    CV_SHMEDIA_FR19 = 147,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR20"]/*' />
    CV_SHMEDIA_FR20 = 148,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR21"]/*' />
    CV_SHMEDIA_FR21 = 149,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR22"]/*' />
    CV_SHMEDIA_FR22 = 150,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR23"]/*' />
    CV_SHMEDIA_FR23 = 151,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR24"]/*' />
    CV_SHMEDIA_FR24 = 152,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR25"]/*' />
    CV_SHMEDIA_FR25 = 153,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR26"]/*' />
    CV_SHMEDIA_FR26 = 154,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR27"]/*' />
    CV_SHMEDIA_FR27 = 155,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR28"]/*' />
    CV_SHMEDIA_FR28 = 156,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR29"]/*' />
    CV_SHMEDIA_FR29 = 157,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR30"]/*' />
    CV_SHMEDIA_FR30 = 158,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR31"]/*' />
    CV_SHMEDIA_FR31 = 159,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR32"]/*' />
    CV_SHMEDIA_FR32 = 160,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR33"]/*' />
    CV_SHMEDIA_FR33 = 161,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR34"]/*' />
    CV_SHMEDIA_FR34 = 162,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR35"]/*' />
    CV_SHMEDIA_FR35 = 163,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR36"]/*' />
    CV_SHMEDIA_FR36 = 164,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR37"]/*' />
    CV_SHMEDIA_FR37 = 165,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR38"]/*' />
    CV_SHMEDIA_FR38 = 166,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR39"]/*' />
    CV_SHMEDIA_FR39 = 167,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR40"]/*' />
    CV_SHMEDIA_FR40 = 168,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR41"]/*' />
    CV_SHMEDIA_FR41 = 169,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR42"]/*' />
    CV_SHMEDIA_FR42 = 170,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR43"]/*' />
    CV_SHMEDIA_FR43 = 171,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR44"]/*' />
    CV_SHMEDIA_FR44 = 172,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR45"]/*' />
    CV_SHMEDIA_FR45 = 173,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR46"]/*' />
    CV_SHMEDIA_FR46 = 174,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR47"]/*' />
    CV_SHMEDIA_FR47 = 175,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR48"]/*' />
    CV_SHMEDIA_FR48 = 176,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR49"]/*' />
    CV_SHMEDIA_FR49 = 177,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR50"]/*' />
    CV_SHMEDIA_FR50 = 178,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR51"]/*' />
    CV_SHMEDIA_FR51 = 179,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR52"]/*' />
    CV_SHMEDIA_FR52 = 180,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR53"]/*' />
    CV_SHMEDIA_FR53 = 181,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR54"]/*' />
    CV_SHMEDIA_FR54 = 182,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR55"]/*' />
    CV_SHMEDIA_FR55 = 183,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR56"]/*' />
    CV_SHMEDIA_FR56 = 184,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR57"]/*' />
    CV_SHMEDIA_FR57 = 185,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR58"]/*' />
    CV_SHMEDIA_FR58 = 186,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR59"]/*' />
    CV_SHMEDIA_FR59 = 187,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR60"]/*' />
    CV_SHMEDIA_FR60 = 188,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR61"]/*' />
    CV_SHMEDIA_FR61 = 189,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR62"]/*' />
    CV_SHMEDIA_FR62 = 190,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FR63"]/*' />
    CV_SHMEDIA_FR63 = 191,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR0"]/*' />
    CV_SHMEDIA_DR0 = 256,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR2"]/*' />
    CV_SHMEDIA_DR2 = 258,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR4"]/*' />
    CV_SHMEDIA_DR4 = 260,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR6"]/*' />
    CV_SHMEDIA_DR6 = 262,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR8"]/*' />
    CV_SHMEDIA_DR8 = 264,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR10"]/*' />
    CV_SHMEDIA_DR10 = 266,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR12"]/*' />
    CV_SHMEDIA_DR12 = 268,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR14"]/*' />
    CV_SHMEDIA_DR14 = 270,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR16"]/*' />
    CV_SHMEDIA_DR16 = 272,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR18"]/*' />
    CV_SHMEDIA_DR18 = 274,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR20"]/*' />
    CV_SHMEDIA_DR20 = 276,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR22"]/*' />
    CV_SHMEDIA_DR22 = 278,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR24"]/*' />
    CV_SHMEDIA_DR24 = 280,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR26"]/*' />
    CV_SHMEDIA_DR26 = 282,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR28"]/*' />
    CV_SHMEDIA_DR28 = 284,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR30"]/*' />
    CV_SHMEDIA_DR30 = 286,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR32"]/*' />
    CV_SHMEDIA_DR32 = 288,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR34"]/*' />
    CV_SHMEDIA_DR34 = 290,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR36"]/*' />
    CV_SHMEDIA_DR36 = 292,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR38"]/*' />
    CV_SHMEDIA_DR38 = 294,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR40"]/*' />
    CV_SHMEDIA_DR40 = 296,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR42"]/*' />
    CV_SHMEDIA_DR42 = 298,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR44"]/*' />
    CV_SHMEDIA_DR44 = 300,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR46"]/*' />
    CV_SHMEDIA_DR46 = 302,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR48"]/*' />
    CV_SHMEDIA_DR48 = 304,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR50"]/*' />
    CV_SHMEDIA_DR50 = 306,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR52"]/*' />
    CV_SHMEDIA_DR52 = 308,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR54"]/*' />
    CV_SHMEDIA_DR54 = 310,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR56"]/*' />
    CV_SHMEDIA_DR56 = 312,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR58"]/*' />
    CV_SHMEDIA_DR58 = 314,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR60"]/*' />
    CV_SHMEDIA_DR60 = 316,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_DR62"]/*' />
    CV_SHMEDIA_DR62 = 318,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FV0"]/*' />
    CV_SHMEDIA_FV0 = 512,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FV4"]/*' />
    CV_SHMEDIA_FV4 = 516,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FV8"]/*' />
    CV_SHMEDIA_FV8 = 520,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FV12"]/*' />
    CV_SHMEDIA_FV12 = 524,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FV16"]/*' />
    CV_SHMEDIA_FV16 = 528,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FV20"]/*' />
    CV_SHMEDIA_FV20 = 532,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FV24"]/*' />
    CV_SHMEDIA_FV24 = 536,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FV28"]/*' />
    CV_SHMEDIA_FV28 = 540,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FV32"]/*' />
    CV_SHMEDIA_FV32 = 544,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FV36"]/*' />
    CV_SHMEDIA_FV36 = 548,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FV40"]/*' />
    CV_SHMEDIA_FV40 = 552,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FV44"]/*' />
    CV_SHMEDIA_FV44 = 556,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FV48"]/*' />
    CV_SHMEDIA_FV48 = 560,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FV52"]/*' />
    CV_SHMEDIA_FV52 = 564,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FV56"]/*' />
    CV_SHMEDIA_FV56 = 568,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FV60"]/*' />
    CV_SHMEDIA_FV60 = 572,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_MTRX0"]/*' />
    CV_SHMEDIA_MTRX0 = 1024,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_MTRX16"]/*' />
    CV_SHMEDIA_MTRX16 = 1040,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_MTRX32"]/*' />
    CV_SHMEDIA_MTRX32 = 1056,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_MTRX48"]/*' />
    CV_SHMEDIA_MTRX48 = 1072,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR0"]/*' />
    CV_SHMEDIA_CR0 = 2000,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR1"]/*' />
    CV_SHMEDIA_CR1 = 2001,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR2"]/*' />
    CV_SHMEDIA_CR2 = 2002,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR3"]/*' />
    CV_SHMEDIA_CR3 = 2003,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR4"]/*' />
    CV_SHMEDIA_CR4 = 2004,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR5"]/*' />
    CV_SHMEDIA_CR5 = 2005,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR6"]/*' />
    CV_SHMEDIA_CR6 = 2006,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR7"]/*' />
    CV_SHMEDIA_CR7 = 2007,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR8"]/*' />
    CV_SHMEDIA_CR8 = 2008,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR9"]/*' />
    CV_SHMEDIA_CR9 = 2009,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR10"]/*' />
    CV_SHMEDIA_CR10 = 2010,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR11"]/*' />
    CV_SHMEDIA_CR11 = 2011,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR12"]/*' />
    CV_SHMEDIA_CR12 = 2012,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR13"]/*' />
    CV_SHMEDIA_CR13 = 2013,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR14"]/*' />
    CV_SHMEDIA_CR14 = 2014,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR15"]/*' />
    CV_SHMEDIA_CR15 = 2015,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR16"]/*' />
    CV_SHMEDIA_CR16 = 2016,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR17"]/*' />
    CV_SHMEDIA_CR17 = 2017,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR18"]/*' />
    CV_SHMEDIA_CR18 = 2018,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR19"]/*' />
    CV_SHMEDIA_CR19 = 2019,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR20"]/*' />
    CV_SHMEDIA_CR20 = 2020,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR21"]/*' />
    CV_SHMEDIA_CR21 = 2021,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR22"]/*' />
    CV_SHMEDIA_CR22 = 2022,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR23"]/*' />
    CV_SHMEDIA_CR23 = 2023,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR24"]/*' />
    CV_SHMEDIA_CR24 = 2024,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR25"]/*' />
    CV_SHMEDIA_CR25 = 2025,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR26"]/*' />
    CV_SHMEDIA_CR26 = 2026,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR27"]/*' />
    CV_SHMEDIA_CR27 = 2027,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR28"]/*' />
    CV_SHMEDIA_CR28 = 2028,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR29"]/*' />
    CV_SHMEDIA_CR29 = 2029,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR30"]/*' />
    CV_SHMEDIA_CR30 = 2030,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR31"]/*' />
    CV_SHMEDIA_CR31 = 2031,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR32"]/*' />
    CV_SHMEDIA_CR32 = 2032,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR33"]/*' />
    CV_SHMEDIA_CR33 = 2033,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR34"]/*' />
    CV_SHMEDIA_CR34 = 2034,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR35"]/*' />
    CV_SHMEDIA_CR35 = 2035,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR36"]/*' />
    CV_SHMEDIA_CR36 = 2036,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR37"]/*' />
    CV_SHMEDIA_CR37 = 2037,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR38"]/*' />
    CV_SHMEDIA_CR38 = 2038,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR39"]/*' />
    CV_SHMEDIA_CR39 = 2039,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR40"]/*' />
    CV_SHMEDIA_CR40 = 2040,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR41"]/*' />
    CV_SHMEDIA_CR41 = 2041,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR42"]/*' />
    CV_SHMEDIA_CR42 = 2042,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR43"]/*' />
    CV_SHMEDIA_CR43 = 2043,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR44"]/*' />
    CV_SHMEDIA_CR44 = 2044,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR45"]/*' />
    CV_SHMEDIA_CR45 = 2045,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR46"]/*' />
    CV_SHMEDIA_CR46 = 2046,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR47"]/*' />
    CV_SHMEDIA_CR47 = 2047,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR48"]/*' />
    CV_SHMEDIA_CR48 = 2048,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR49"]/*' />
    CV_SHMEDIA_CR49 = 2049,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR50"]/*' />
    CV_SHMEDIA_CR50 = 2050,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR51"]/*' />
    CV_SHMEDIA_CR51 = 2051,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR52"]/*' />
    CV_SHMEDIA_CR52 = 2052,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR53"]/*' />
    CV_SHMEDIA_CR53 = 2053,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR54"]/*' />
    CV_SHMEDIA_CR54 = 2054,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR55"]/*' />
    CV_SHMEDIA_CR55 = 2055,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR56"]/*' />
    CV_SHMEDIA_CR56 = 2056,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR57"]/*' />
    CV_SHMEDIA_CR57 = 2057,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR58"]/*' />
    CV_SHMEDIA_CR58 = 2058,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR59"]/*' />
    CV_SHMEDIA_CR59 = 2059,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR60"]/*' />
    CV_SHMEDIA_CR60 = 2060,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR61"]/*' />
    CV_SHMEDIA_CR61 = 2061,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR62"]/*' />
    CV_SHMEDIA_CR62 = 2062,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_CR63"]/*' />
    CV_SHMEDIA_CR63 = 2063,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FPSCR"]/*' />
    CV_SHMEDIA_FPSCR = 2064,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_GBR"]/*' />
    CV_SHMEDIA_GBR = CV_SHMEDIA_R16,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_MACL"]/*' />
    CV_SHMEDIA_MACL = 90,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_MACH"]/*' />
    CV_SHMEDIA_MACH = 91,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_PR"]/*' />
    CV_SHMEDIA_PR = CV_SHMEDIA_R18,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_T"]/*' />
    CV_SHMEDIA_T = 92,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_FPUL"]/*' />
    CV_SHMEDIA_FPUL = CV_SHMEDIA_FR32,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_PC"]/*' />
    CV_SHMEDIA_PC = 93,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_SHMEDIA_SR"]/*' />
    CV_SHMEDIA_SR = CV_SHMEDIA_CR0,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_AL"]/*' />
    CV_AMD64_AL = 1,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_CL"]/*' />
    CV_AMD64_CL = 2,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DL"]/*' />
    CV_AMD64_DL = 3,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_BL"]/*' />
    CV_AMD64_BL = 4,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_AH"]/*' />
    CV_AMD64_AH = 5,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_CH"]/*' />
    CV_AMD64_CH = 6,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DH"]/*' />
    CV_AMD64_DH = 7,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_BH"]/*' />
    CV_AMD64_BH = 8,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_AX"]/*' />
    CV_AMD64_AX = 9,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_CX"]/*' />
    CV_AMD64_CX = 10,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DX"]/*' />
    CV_AMD64_DX = 11,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_BX"]/*' />
    CV_AMD64_BX = 12,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_SP"]/*' />
    CV_AMD64_SP = 13,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_BP"]/*' />
    CV_AMD64_BP = 14,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_SI"]/*' />
    CV_AMD64_SI = 15,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DI"]/*' />
    CV_AMD64_DI = 16,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EAX"]/*' />
    CV_AMD64_EAX = 17,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ECX"]/*' />
    CV_AMD64_ECX = 18,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EDX"]/*' />
    CV_AMD64_EDX = 19,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EBX"]/*' />
    CV_AMD64_EBX = 20,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ESP"]/*' />
    CV_AMD64_ESP = 21,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EBP"]/*' />
    CV_AMD64_EBP = 22,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ESI"]/*' />
    CV_AMD64_ESI = 23,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EDI"]/*' />
    CV_AMD64_EDI = 24,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ES"]/*' />
    CV_AMD64_ES = 25,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_CS"]/*' />
    CV_AMD64_CS = 26,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_SS"]/*' />
    CV_AMD64_SS = 27,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DS"]/*' />
    CV_AMD64_DS = 28,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_FS"]/*' />
    CV_AMD64_FS = 29,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_GS"]/*' />
    CV_AMD64_GS = 30,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_FLAGS"]/*' />
    CV_AMD64_FLAGS = 32,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_RIP"]/*' />
    CV_AMD64_RIP = 33,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EFLAGS"]/*' />
    CV_AMD64_EFLAGS = 34,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_CR0"]/*' />
    CV_AMD64_CR0 = 80,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_CR1"]/*' />
    CV_AMD64_CR1 = 81,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_CR2"]/*' />
    CV_AMD64_CR2 = 82,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_CR3"]/*' />
    CV_AMD64_CR3 = 83,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_CR4"]/*' />
    CV_AMD64_CR4 = 84,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_CR8"]/*' />
    CV_AMD64_CR8 = 88,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DR0"]/*' />
    CV_AMD64_DR0 = 90,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DR1"]/*' />
    CV_AMD64_DR1 = 91,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DR2"]/*' />
    CV_AMD64_DR2 = 92,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DR3"]/*' />
    CV_AMD64_DR3 = 93,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DR4"]/*' />
    CV_AMD64_DR4 = 94,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DR5"]/*' />
    CV_AMD64_DR5 = 95,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DR6"]/*' />
    CV_AMD64_DR6 = 96,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DR7"]/*' />
    CV_AMD64_DR7 = 97,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DR8"]/*' />
    CV_AMD64_DR8 = 98,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DR9"]/*' />
    CV_AMD64_DR9 = 99,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DR10"]/*' />
    CV_AMD64_DR10 = 100,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DR11"]/*' />
    CV_AMD64_DR11 = 101,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DR12"]/*' />
    CV_AMD64_DR12 = 102,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DR13"]/*' />
    CV_AMD64_DR13 = 103,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DR14"]/*' />
    CV_AMD64_DR14 = 104,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DR15"]/*' />
    CV_AMD64_DR15 = 105,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_GDTR"]/*' />
    CV_AMD64_GDTR = 110,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_GDTL"]/*' />
    CV_AMD64_GDTL = 111,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_IDTR"]/*' />
    CV_AMD64_IDTR = 112,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_IDTL"]/*' />
    CV_AMD64_IDTL = 113,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_LDTR"]/*' />
    CV_AMD64_LDTR = 114,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_TR"]/*' />
    CV_AMD64_TR = 115,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ST0"]/*' />
    CV_AMD64_ST0 = 128,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ST1"]/*' />
    CV_AMD64_ST1 = 129,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ST2"]/*' />
    CV_AMD64_ST2 = 130,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ST3"]/*' />
    CV_AMD64_ST3 = 131,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ST4"]/*' />
    CV_AMD64_ST4 = 132,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ST5"]/*' />
    CV_AMD64_ST5 = 133,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ST6"]/*' />
    CV_AMD64_ST6 = 134,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ST7"]/*' />
    CV_AMD64_ST7 = 135,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_CTRL"]/*' />
    CV_AMD64_CTRL = 136,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_STAT"]/*' />
    CV_AMD64_STAT = 137,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_TAG"]/*' />
    CV_AMD64_TAG = 138,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_FPIP"]/*' />
    CV_AMD64_FPIP = 139,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_FPCS"]/*' />
    CV_AMD64_FPCS = 140,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_FPDO"]/*' />
    CV_AMD64_FPDO = 141,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_FPDS"]/*' />
    CV_AMD64_FPDS = 142,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ISEM"]/*' />
    CV_AMD64_ISEM = 143,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_FPEIP"]/*' />
    CV_AMD64_FPEIP = 144,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_FPEDO"]/*' />
    CV_AMD64_FPEDO = 145,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM0"]/*' />
    CV_AMD64_MM0 = 146,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM1"]/*' />
    CV_AMD64_MM1 = 147,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM2"]/*' />
    CV_AMD64_MM2 = 148,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM3"]/*' />
    CV_AMD64_MM3 = 149,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM4"]/*' />
    CV_AMD64_MM4 = 150,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM5"]/*' />
    CV_AMD64_MM5 = 151,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM6"]/*' />
    CV_AMD64_MM6 = 152,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM7"]/*' />
    CV_AMD64_MM7 = 153,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM0"]/*' />
    CV_AMD64_XMM0 = 154,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM1"]/*' />
    CV_AMD64_XMM1 = 155,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM2"]/*' />
    CV_AMD64_XMM2 = 156,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM3"]/*' />
    CV_AMD64_XMM3 = 157,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM4"]/*' />
    CV_AMD64_XMM4 = 158,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM5"]/*' />
    CV_AMD64_XMM5 = 159,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM6"]/*' />
    CV_AMD64_XMM6 = 160,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM7"]/*' />
    CV_AMD64_XMM7 = 161,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM0_0"]/*' />
    CV_AMD64_XMM0_0 = 162,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM0_1"]/*' />
    CV_AMD64_XMM0_1 = 163,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM0_2"]/*' />
    CV_AMD64_XMM0_2 = 164,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM0_3"]/*' />
    CV_AMD64_XMM0_3 = 165,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM1_0"]/*' />
    CV_AMD64_XMM1_0 = 166,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM1_1"]/*' />
    CV_AMD64_XMM1_1 = 167,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM1_2"]/*' />
    CV_AMD64_XMM1_2 = 168,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM1_3"]/*' />
    CV_AMD64_XMM1_3 = 169,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM2_0"]/*' />
    CV_AMD64_XMM2_0 = 170,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM2_1"]/*' />
    CV_AMD64_XMM2_1 = 171,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM2_2"]/*' />
    CV_AMD64_XMM2_2 = 172,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM2_3"]/*' />
    CV_AMD64_XMM2_3 = 173,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM3_0"]/*' />
    CV_AMD64_XMM3_0 = 174,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM3_1"]/*' />
    CV_AMD64_XMM3_1 = 175,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM3_2"]/*' />
    CV_AMD64_XMM3_2 = 176,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM3_3"]/*' />
    CV_AMD64_XMM3_3 = 177,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM4_0"]/*' />
    CV_AMD64_XMM4_0 = 178,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM4_1"]/*' />
    CV_AMD64_XMM4_1 = 179,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM4_2"]/*' />
    CV_AMD64_XMM4_2 = 180,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM4_3"]/*' />
    CV_AMD64_XMM4_3 = 181,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM5_0"]/*' />
    CV_AMD64_XMM5_0 = 182,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM5_1"]/*' />
    CV_AMD64_XMM5_1 = 183,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM5_2"]/*' />
    CV_AMD64_XMM5_2 = 184,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM5_3"]/*' />
    CV_AMD64_XMM5_3 = 185,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM6_0"]/*' />
    CV_AMD64_XMM6_0 = 186,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM6_1"]/*' />
    CV_AMD64_XMM6_1 = 187,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM6_2"]/*' />
    CV_AMD64_XMM6_2 = 188,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM6_3"]/*' />
    CV_AMD64_XMM6_3 = 189,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM7_0"]/*' />
    CV_AMD64_XMM7_0 = 190,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM7_1"]/*' />
    CV_AMD64_XMM7_1 = 191,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM7_2"]/*' />
    CV_AMD64_XMM7_2 = 192,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM7_3"]/*' />
    CV_AMD64_XMM7_3 = 193,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM0L"]/*' />
    CV_AMD64_XMM0L = 194,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM1L"]/*' />
    CV_AMD64_XMM1L = 195,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM2L"]/*' />
    CV_AMD64_XMM2L = 196,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM3L"]/*' />
    CV_AMD64_XMM3L = 197,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM4L"]/*' />
    CV_AMD64_XMM4L = 198,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM5L"]/*' />
    CV_AMD64_XMM5L = 199,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM6L"]/*' />
    CV_AMD64_XMM6L = 200,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM7L"]/*' />
    CV_AMD64_XMM7L = 201,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM0H"]/*' />
    CV_AMD64_XMM0H = 202,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM1H"]/*' />
    CV_AMD64_XMM1H = 203,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM2H"]/*' />
    CV_AMD64_XMM2H = 204,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM3H"]/*' />
    CV_AMD64_XMM3H = 205,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM4H"]/*' />
    CV_AMD64_XMM4H = 206,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM5H"]/*' />
    CV_AMD64_XMM5H = 207,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM6H"]/*' />
    CV_AMD64_XMM6H = 208,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM7H"]/*' />
    CV_AMD64_XMM7H = 209,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MXCSR"]/*' />
    CV_AMD64_MXCSR = 211,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM0L"]/*' />
    CV_AMD64_EMM0L = 220,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM1L"]/*' />
    CV_AMD64_EMM1L = 221,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM2L"]/*' />
    CV_AMD64_EMM2L = 222,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM3L"]/*' />
    CV_AMD64_EMM3L = 223,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM4L"]/*' />
    CV_AMD64_EMM4L = 224,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM5L"]/*' />
    CV_AMD64_EMM5L = 225,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM6L"]/*' />
    CV_AMD64_EMM6L = 226,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM7L"]/*' />
    CV_AMD64_EMM7L = 227,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM0H"]/*' />
    CV_AMD64_EMM0H = 228,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM1H"]/*' />
    CV_AMD64_EMM1H = 229,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM2H"]/*' />
    CV_AMD64_EMM2H = 230,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM3H"]/*' />
    CV_AMD64_EMM3H = 231,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM4H"]/*' />
    CV_AMD64_EMM4H = 232,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM5H"]/*' />
    CV_AMD64_EMM5H = 233,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM6H"]/*' />
    CV_AMD64_EMM6H = 234,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM7H"]/*' />
    CV_AMD64_EMM7H = 235,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM00"]/*' />
    CV_AMD64_MM00 = 236,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM01"]/*' />
    CV_AMD64_MM01 = 237,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM10"]/*' />
    CV_AMD64_MM10 = 238,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM11"]/*' />
    CV_AMD64_MM11 = 239,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM20"]/*' />
    CV_AMD64_MM20 = 240,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM21"]/*' />
    CV_AMD64_MM21 = 241,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM30"]/*' />
    CV_AMD64_MM30 = 242,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM31"]/*' />
    CV_AMD64_MM31 = 243,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM40"]/*' />
    CV_AMD64_MM40 = 244,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM41"]/*' />
    CV_AMD64_MM41 = 245,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM50"]/*' />
    CV_AMD64_MM50 = 246,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM51"]/*' />
    CV_AMD64_MM51 = 247,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM60"]/*' />
    CV_AMD64_MM60 = 248,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM61"]/*' />
    CV_AMD64_MM61 = 249,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM70"]/*' />
    CV_AMD64_MM70 = 250,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_MM71"]/*' />
    CV_AMD64_MM71 = 251,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM8"]/*' />
    CV_AMD64_XMM8 = 252,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM9"]/*' />
    CV_AMD64_XMM9 = 253,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM10"]/*' />
    CV_AMD64_XMM10 = 254,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM11"]/*' />
    CV_AMD64_XMM11 = 255,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM12"]/*' />
    CV_AMD64_XMM12 = 256,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM13"]/*' />
    CV_AMD64_XMM13 = 257,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM14"]/*' />
    CV_AMD64_XMM14 = 258,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM15"]/*' />
    CV_AMD64_XMM15 = 259,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM8_0"]/*' />
    CV_AMD64_XMM8_0 = 260,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM8_1"]/*' />
    CV_AMD64_XMM8_1 = 261,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM8_2"]/*' />
    CV_AMD64_XMM8_2 = 262,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM8_3"]/*' />
    CV_AMD64_XMM8_3 = 263,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM9_0"]/*' />
    CV_AMD64_XMM9_0 = 264,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM9_1"]/*' />
    CV_AMD64_XMM9_1 = 265,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM9_2"]/*' />
    CV_AMD64_XMM9_2 = 266,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM9_3"]/*' />
    CV_AMD64_XMM9_3 = 267,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM10_0"]/*' />
    CV_AMD64_XMM10_0 = 268,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM10_1"]/*' />
    CV_AMD64_XMM10_1 = 269,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM10_2"]/*' />
    CV_AMD64_XMM10_2 = 270,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM10_3"]/*' />
    CV_AMD64_XMM10_3 = 271,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM11_0"]/*' />
    CV_AMD64_XMM11_0 = 272,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM11_1"]/*' />
    CV_AMD64_XMM11_1 = 273,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM11_2"]/*' />
    CV_AMD64_XMM11_2 = 274,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM11_3"]/*' />
    CV_AMD64_XMM11_3 = 275,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM12_0"]/*' />
    CV_AMD64_XMM12_0 = 276,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM12_1"]/*' />
    CV_AMD64_XMM12_1 = 277,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM12_2"]/*' />
    CV_AMD64_XMM12_2 = 278,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM12_3"]/*' />
    CV_AMD64_XMM12_3 = 279,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM13_0"]/*' />
    CV_AMD64_XMM13_0 = 280,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM13_1"]/*' />
    CV_AMD64_XMM13_1 = 281,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM13_2"]/*' />
    CV_AMD64_XMM13_2 = 282,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM13_3"]/*' />
    CV_AMD64_XMM13_3 = 283,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM14_0"]/*' />
    CV_AMD64_XMM14_0 = 284,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM14_1"]/*' />
    CV_AMD64_XMM14_1 = 285,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM14_2"]/*' />
    CV_AMD64_XMM14_2 = 286,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM14_3"]/*' />
    CV_AMD64_XMM14_3 = 287,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM15_0"]/*' />
    CV_AMD64_XMM15_0 = 288,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM15_1"]/*' />
    CV_AMD64_XMM15_1 = 289,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM15_2"]/*' />
    CV_AMD64_XMM15_2 = 290,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM15_3"]/*' />
    CV_AMD64_XMM15_3 = 291,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM8L"]/*' />
    CV_AMD64_XMM8L = 292,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM9L"]/*' />
    CV_AMD64_XMM9L = 293,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM10L"]/*' />
    CV_AMD64_XMM10L = 294,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM11L"]/*' />
    CV_AMD64_XMM11L = 295,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM12L"]/*' />
    CV_AMD64_XMM12L = 296,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM13L"]/*' />
    CV_AMD64_XMM13L = 297,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM14L"]/*' />
    CV_AMD64_XMM14L = 298,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM15L"]/*' />
    CV_AMD64_XMM15L = 299,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM8H"]/*' />
    CV_AMD64_XMM8H = 300,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM9H"]/*' />
    CV_AMD64_XMM9H = 301,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM10H"]/*' />
    CV_AMD64_XMM10H = 302,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM11H"]/*' />
    CV_AMD64_XMM11H = 303,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM12H"]/*' />
    CV_AMD64_XMM12H = 304,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM13H"]/*' />
    CV_AMD64_XMM13H = 305,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM14H"]/*' />
    CV_AMD64_XMM14H = 306,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM15H"]/*' />
    CV_AMD64_XMM15H = 307,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM8L"]/*' />
    CV_AMD64_EMM8L = 308,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM9L"]/*' />
    CV_AMD64_EMM9L = 309,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM10L"]/*' />
    CV_AMD64_EMM10L = 310,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM11L"]/*' />
    CV_AMD64_EMM11L = 311,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM12L"]/*' />
    CV_AMD64_EMM12L = 312,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM13L"]/*' />
    CV_AMD64_EMM13L = 313,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM14L"]/*' />
    CV_AMD64_EMM14L = 314,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM15L"]/*' />
    CV_AMD64_EMM15L = 315,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM8H"]/*' />
    CV_AMD64_EMM8H = 316,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM9H"]/*' />
    CV_AMD64_EMM9H = 317,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM10H"]/*' />
    CV_AMD64_EMM10H = 318,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM11H"]/*' />
    CV_AMD64_EMM11H = 319,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM12H"]/*' />
    CV_AMD64_EMM12H = 320,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM13H"]/*' />
    CV_AMD64_EMM13H = 321,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM14H"]/*' />
    CV_AMD64_EMM14H = 322,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM15H"]/*' />
    CV_AMD64_EMM15H = 323,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_SIL"]/*' />
    CV_AMD64_SIL = 324,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_DIL"]/*' />
    CV_AMD64_DIL = 325,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_BPL"]/*' />
    CV_AMD64_BPL = 326,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_SPL"]/*' />
    CV_AMD64_SPL = 327,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_RAX"]/*' />
    CV_AMD64_RAX = 328,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_RBX"]/*' />
    CV_AMD64_RBX = 329,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_RCX"]/*' />
    CV_AMD64_RCX = 330,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_RDX"]/*' />
    CV_AMD64_RDX = 331,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_RSI"]/*' />
    CV_AMD64_RSI = 332,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_RDI"]/*' />
    CV_AMD64_RDI = 333,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_RBP"]/*' />
    CV_AMD64_RBP = 334,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_RSP"]/*' />
    CV_AMD64_RSP = 335,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R8"]/*' />
    CV_AMD64_R8 = 336,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R9"]/*' />
    CV_AMD64_R9 = 337,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R10"]/*' />
    CV_AMD64_R10 = 338,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R11"]/*' />
    CV_AMD64_R11 = 339,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R12"]/*' />
    CV_AMD64_R12 = 340,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R13"]/*' />
    CV_AMD64_R13 = 341,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R14"]/*' />
    CV_AMD64_R14 = 342,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R15"]/*' />
    CV_AMD64_R15 = 343,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R8B"]/*' />
    CV_AMD64_R8B = 344,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R9B"]/*' />
    CV_AMD64_R9B = 345,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R10B"]/*' />
    CV_AMD64_R10B = 346,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R11B"]/*' />
    CV_AMD64_R11B = 347,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R12B"]/*' />
    CV_AMD64_R12B = 348,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R13B"]/*' />
    CV_AMD64_R13B = 349,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R14B"]/*' />
    CV_AMD64_R14B = 350,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R15B"]/*' />
    CV_AMD64_R15B = 351,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R8W"]/*' />
    CV_AMD64_R8W = 352,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R9W"]/*' />
    CV_AMD64_R9W = 353,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R10W"]/*' />
    CV_AMD64_R10W = 354,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R11W"]/*' />
    CV_AMD64_R11W = 355,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R12W"]/*' />
    CV_AMD64_R12W = 356,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R13W"]/*' />
    CV_AMD64_R13W = 357,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R14W"]/*' />
    CV_AMD64_R14W = 358,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R15W"]/*' />
    CV_AMD64_R15W = 359,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R8D"]/*' />
    CV_AMD64_R8D = 360,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R9D"]/*' />
    CV_AMD64_R9D = 361,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R10D"]/*' />
    CV_AMD64_R10D = 362,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R11D"]/*' />
    CV_AMD64_R11D = 363,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R12D"]/*' />
    CV_AMD64_R12D = 364,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R13D"]/*' />
    CV_AMD64_R13D = 365,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R14D"]/*' />
    CV_AMD64_R14D = 366,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_R15D"]/*' />
    CV_AMD64_R15D = 367,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0"]/*' />
    CV_AMD64_YMM0 = 368,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1"]/*' />
    CV_AMD64_YMM1 = 369,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2"]/*' />
    CV_AMD64_YMM2 = 370,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3"]/*' />
    CV_AMD64_YMM3 = 371,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4"]/*' />
    CV_AMD64_YMM4 = 372,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5"]/*' />
    CV_AMD64_YMM5 = 373,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6"]/*' />
    CV_AMD64_YMM6 = 374,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7"]/*' />
    CV_AMD64_YMM7 = 375,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8"]/*' />
    CV_AMD64_YMM8 = 376,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9"]/*' />
    CV_AMD64_YMM9 = 377,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10"]/*' />
    CV_AMD64_YMM10 = 378,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11"]/*' />
    CV_AMD64_YMM11 = 379,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12"]/*' />
    CV_AMD64_YMM12 = 380,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13"]/*' />
    CV_AMD64_YMM13 = 381,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14"]/*' />
    CV_AMD64_YMM14 = 382,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15"]/*' />
    CV_AMD64_YMM15 = 383,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0H"]/*' />
    CV_AMD64_YMM0H = 384,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1H"]/*' />
    CV_AMD64_YMM1H = 385,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2H"]/*' />
    CV_AMD64_YMM2H = 386,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3H"]/*' />
    CV_AMD64_YMM3H = 387,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4H"]/*' />
    CV_AMD64_YMM4H = 388,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5H"]/*' />
    CV_AMD64_YMM5H = 389,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6H"]/*' />
    CV_AMD64_YMM6H = 390,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7H"]/*' />
    CV_AMD64_YMM7H = 391,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8H"]/*' />
    CV_AMD64_YMM8H = 392,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9H"]/*' />
    CV_AMD64_YMM9H = 393,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10H"]/*' />
    CV_AMD64_YMM10H = 394,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11H"]/*' />
    CV_AMD64_YMM11H = 395,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12H"]/*' />
    CV_AMD64_YMM12H = 396,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13H"]/*' />
    CV_AMD64_YMM13H = 397,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14H"]/*' />
    CV_AMD64_YMM14H = 398,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15H"]/*' />
    CV_AMD64_YMM15H = 399,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM0IL"]/*' />
    CV_AMD64_XMM0IL = 400,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM1IL"]/*' />
    CV_AMD64_XMM1IL = 401,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM2IL"]/*' />
    CV_AMD64_XMM2IL = 402,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM3IL"]/*' />
    CV_AMD64_XMM3IL = 403,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM4IL"]/*' />
    CV_AMD64_XMM4IL = 404,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM5IL"]/*' />
    CV_AMD64_XMM5IL = 405,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM6IL"]/*' />
    CV_AMD64_XMM6IL = 406,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM7IL"]/*' />
    CV_AMD64_XMM7IL = 407,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM8IL"]/*' />
    CV_AMD64_XMM8IL = 408,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM9IL"]/*' />
    CV_AMD64_XMM9IL = 409,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM10IL"]/*' />
    CV_AMD64_XMM10IL = 410,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM11IL"]/*' />
    CV_AMD64_XMM11IL = 411,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM12IL"]/*' />
    CV_AMD64_XMM12IL = 412,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM13IL"]/*' />
    CV_AMD64_XMM13IL = 413,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM14IL"]/*' />
    CV_AMD64_XMM14IL = 414,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM15IL"]/*' />
    CV_AMD64_XMM15IL = 415,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM0IH"]/*' />
    CV_AMD64_XMM0IH = 416,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM1IH"]/*' />
    CV_AMD64_XMM1IH = 417,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM2IH"]/*' />
    CV_AMD64_XMM2IH = 418,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM3IH"]/*' />
    CV_AMD64_XMM3IH = 419,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM4IH"]/*' />
    CV_AMD64_XMM4IH = 420,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM5IH"]/*' />
    CV_AMD64_XMM5IH = 421,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM6IH"]/*' />
    CV_AMD64_XMM6IH = 422,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM7IH"]/*' />
    CV_AMD64_XMM7IH = 423,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM8IH"]/*' />
    CV_AMD64_XMM8IH = 424,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM9IH"]/*' />
    CV_AMD64_XMM9IH = 425,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM10IH"]/*' />
    CV_AMD64_XMM10IH = 426,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM11IH"]/*' />
    CV_AMD64_XMM11IH = 427,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM12IH"]/*' />
    CV_AMD64_XMM12IH = 428,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM13IH"]/*' />
    CV_AMD64_XMM13IH = 429,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM14IH"]/*' />
    CV_AMD64_XMM14IH = 430,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM15IH"]/*' />
    CV_AMD64_XMM15IH = 431,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0I0"]/*' />
    CV_AMD64_YMM0I0 = 432,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0I1"]/*' />
    CV_AMD64_YMM0I1 = 433,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0I2"]/*' />
    CV_AMD64_YMM0I2 = 434,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0I3"]/*' />
    CV_AMD64_YMM0I3 = 435,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1I0"]/*' />
    CV_AMD64_YMM1I0 = 436,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1I1"]/*' />
    CV_AMD64_YMM1I1 = 437,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1I2"]/*' />
    CV_AMD64_YMM1I2 = 438,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1I3"]/*' />
    CV_AMD64_YMM1I3 = 439,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2I0"]/*' />
    CV_AMD64_YMM2I0 = 440,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2I1"]/*' />
    CV_AMD64_YMM2I1 = 441,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2I2"]/*' />
    CV_AMD64_YMM2I2 = 442,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2I3"]/*' />
    CV_AMD64_YMM2I3 = 443,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3I0"]/*' />
    CV_AMD64_YMM3I0 = 444,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3I1"]/*' />
    CV_AMD64_YMM3I1 = 445,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3I2"]/*' />
    CV_AMD64_YMM3I2 = 446,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3I3"]/*' />
    CV_AMD64_YMM3I3 = 447,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4I0"]/*' />
    CV_AMD64_YMM4I0 = 448,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4I1"]/*' />
    CV_AMD64_YMM4I1 = 449,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4I2"]/*' />
    CV_AMD64_YMM4I2 = 450,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4I3"]/*' />
    CV_AMD64_YMM4I3 = 451,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5I0"]/*' />
    CV_AMD64_YMM5I0 = 452,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5I1"]/*' />
    CV_AMD64_YMM5I1 = 453,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5I2"]/*' />
    CV_AMD64_YMM5I2 = 454,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5I3"]/*' />
    CV_AMD64_YMM5I3 = 455,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6I0"]/*' />
    CV_AMD64_YMM6I0 = 456,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6I1"]/*' />
    CV_AMD64_YMM6I1 = 457,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6I2"]/*' />
    CV_AMD64_YMM6I2 = 458,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6I3"]/*' />
    CV_AMD64_YMM6I3 = 459,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7I0"]/*' />
    CV_AMD64_YMM7I0 = 460,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7I1"]/*' />
    CV_AMD64_YMM7I1 = 461,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7I2"]/*' />
    CV_AMD64_YMM7I2 = 462,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7I3"]/*' />
    CV_AMD64_YMM7I3 = 463,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8I0"]/*' />
    CV_AMD64_YMM8I0 = 464,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8I1"]/*' />
    CV_AMD64_YMM8I1 = 465,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8I2"]/*' />
    CV_AMD64_YMM8I2 = 466,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8I3"]/*' />
    CV_AMD64_YMM8I3 = 467,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9I0"]/*' />
    CV_AMD64_YMM9I0 = 468,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9I1"]/*' />
    CV_AMD64_YMM9I1 = 469,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9I2"]/*' />
    CV_AMD64_YMM9I2 = 470,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9I3"]/*' />
    CV_AMD64_YMM9I3 = 471,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10I0"]/*' />
    CV_AMD64_YMM10I0 = 472,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10I1"]/*' />
    CV_AMD64_YMM10I1 = 473,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10I2"]/*' />
    CV_AMD64_YMM10I2 = 474,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10I3"]/*' />
    CV_AMD64_YMM10I3 = 475,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11I0"]/*' />
    CV_AMD64_YMM11I0 = 476,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11I1"]/*' />
    CV_AMD64_YMM11I1 = 477,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11I2"]/*' />
    CV_AMD64_YMM11I2 = 478,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11I3"]/*' />
    CV_AMD64_YMM11I3 = 479,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12I0"]/*' />
    CV_AMD64_YMM12I0 = 480,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12I1"]/*' />
    CV_AMD64_YMM12I1 = 481,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12I2"]/*' />
    CV_AMD64_YMM12I2 = 482,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12I3"]/*' />
    CV_AMD64_YMM12I3 = 483,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13I0"]/*' />
    CV_AMD64_YMM13I0 = 484,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13I1"]/*' />
    CV_AMD64_YMM13I1 = 485,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13I2"]/*' />
    CV_AMD64_YMM13I2 = 486,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13I3"]/*' />
    CV_AMD64_YMM13I3 = 487,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14I0"]/*' />
    CV_AMD64_YMM14I0 = 488,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14I1"]/*' />
    CV_AMD64_YMM14I1 = 489,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14I2"]/*' />
    CV_AMD64_YMM14I2 = 490,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14I3"]/*' />
    CV_AMD64_YMM14I3 = 491,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15I0"]/*' />
    CV_AMD64_YMM15I0 = 492,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15I1"]/*' />
    CV_AMD64_YMM15I1 = 493,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15I2"]/*' />
    CV_AMD64_YMM15I2 = 494,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15I3"]/*' />
    CV_AMD64_YMM15I3 = 495,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0F0"]/*' />
    CV_AMD64_YMM0F0 = 496,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0F1"]/*' />
    CV_AMD64_YMM0F1 = 497,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0F2"]/*' />
    CV_AMD64_YMM0F2 = 498,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0F3"]/*' />
    CV_AMD64_YMM0F3 = 499,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0F4"]/*' />
    CV_AMD64_YMM0F4 = 500,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0F5"]/*' />
    CV_AMD64_YMM0F5 = 501,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0F6"]/*' />
    CV_AMD64_YMM0F6 = 502,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0F7"]/*' />
    CV_AMD64_YMM0F7 = 503,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1F0"]/*' />
    CV_AMD64_YMM1F0 = 504,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1F1"]/*' />
    CV_AMD64_YMM1F1 = 505,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1F2"]/*' />
    CV_AMD64_YMM1F2 = 506,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1F3"]/*' />
    CV_AMD64_YMM1F3 = 507,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1F4"]/*' />
    CV_AMD64_YMM1F4 = 508,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1F5"]/*' />
    CV_AMD64_YMM1F5 = 509,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1F6"]/*' />
    CV_AMD64_YMM1F6 = 510,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1F7"]/*' />
    CV_AMD64_YMM1F7 = 511,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2F0"]/*' />
    CV_AMD64_YMM2F0 = 512,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2F1"]/*' />
    CV_AMD64_YMM2F1 = 513,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2F2"]/*' />
    CV_AMD64_YMM2F2 = 514,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2F3"]/*' />
    CV_AMD64_YMM2F3 = 515,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2F4"]/*' />
    CV_AMD64_YMM2F4 = 516,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2F5"]/*' />
    CV_AMD64_YMM2F5 = 517,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2F6"]/*' />
    CV_AMD64_YMM2F6 = 518,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2F7"]/*' />
    CV_AMD64_YMM2F7 = 519,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3F0"]/*' />
    CV_AMD64_YMM3F0 = 520,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3F1"]/*' />
    CV_AMD64_YMM3F1 = 521,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3F2"]/*' />
    CV_AMD64_YMM3F2 = 522,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3F3"]/*' />
    CV_AMD64_YMM3F3 = 523,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3F4"]/*' />
    CV_AMD64_YMM3F4 = 524,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3F5"]/*' />
    CV_AMD64_YMM3F5 = 525,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3F6"]/*' />
    CV_AMD64_YMM3F6 = 526,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3F7"]/*' />
    CV_AMD64_YMM3F7 = 527,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4F0"]/*' />
    CV_AMD64_YMM4F0 = 528,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4F1"]/*' />
    CV_AMD64_YMM4F1 = 529,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4F2"]/*' />
    CV_AMD64_YMM4F2 = 530,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4F3"]/*' />
    CV_AMD64_YMM4F3 = 531,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4F4"]/*' />
    CV_AMD64_YMM4F4 = 532,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4F5"]/*' />
    CV_AMD64_YMM4F5 = 533,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4F6"]/*' />
    CV_AMD64_YMM4F6 = 534,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4F7"]/*' />
    CV_AMD64_YMM4F7 = 535,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5F0"]/*' />
    CV_AMD64_YMM5F0 = 536,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5F1"]/*' />
    CV_AMD64_YMM5F1 = 537,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5F2"]/*' />
    CV_AMD64_YMM5F2 = 538,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5F3"]/*' />
    CV_AMD64_YMM5F3 = 539,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5F4"]/*' />
    CV_AMD64_YMM5F4 = 540,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5F5"]/*' />
    CV_AMD64_YMM5F5 = 541,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5F6"]/*' />
    CV_AMD64_YMM5F6 = 542,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5F7"]/*' />
    CV_AMD64_YMM5F7 = 543,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6F0"]/*' />
    CV_AMD64_YMM6F0 = 544,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6F1"]/*' />
    CV_AMD64_YMM6F1 = 545,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6F2"]/*' />
    CV_AMD64_YMM6F2 = 546,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6F3"]/*' />
    CV_AMD64_YMM6F3 = 547,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6F4"]/*' />
    CV_AMD64_YMM6F4 = 548,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6F5"]/*' />
    CV_AMD64_YMM6F5 = 549,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6F6"]/*' />
    CV_AMD64_YMM6F6 = 550,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6F7"]/*' />
    CV_AMD64_YMM6F7 = 551,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7F0"]/*' />
    CV_AMD64_YMM7F0 = 552,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7F1"]/*' />
    CV_AMD64_YMM7F1 = 553,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7F2"]/*' />
    CV_AMD64_YMM7F2 = 554,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7F3"]/*' />
    CV_AMD64_YMM7F3 = 555,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7F4"]/*' />
    CV_AMD64_YMM7F4 = 556,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7F5"]/*' />
    CV_AMD64_YMM7F5 = 557,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7F6"]/*' />
    CV_AMD64_YMM7F6 = 558,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7F7"]/*' />
    CV_AMD64_YMM7F7 = 559,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8F0"]/*' />
    CV_AMD64_YMM8F0 = 560,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8F1"]/*' />
    CV_AMD64_YMM8F1 = 561,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8F2"]/*' />
    CV_AMD64_YMM8F2 = 562,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8F3"]/*' />
    CV_AMD64_YMM8F3 = 563,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8F4"]/*' />
    CV_AMD64_YMM8F4 = 564,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8F5"]/*' />
    CV_AMD64_YMM8F5 = 565,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8F6"]/*' />
    CV_AMD64_YMM8F6 = 566,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8F7"]/*' />
    CV_AMD64_YMM8F7 = 567,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9F0"]/*' />
    CV_AMD64_YMM9F0 = 568,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9F1"]/*' />
    CV_AMD64_YMM9F1 = 569,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9F2"]/*' />
    CV_AMD64_YMM9F2 = 570,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9F3"]/*' />
    CV_AMD64_YMM9F3 = 571,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9F4"]/*' />
    CV_AMD64_YMM9F4 = 572,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9F5"]/*' />
    CV_AMD64_YMM9F5 = 573,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9F6"]/*' />
    CV_AMD64_YMM9F6 = 574,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9F7"]/*' />
    CV_AMD64_YMM9F7 = 575,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10F0"]/*' />
    CV_AMD64_YMM10F0 = 576,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10F1"]/*' />
    CV_AMD64_YMM10F1 = 577,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10F2"]/*' />
    CV_AMD64_YMM10F2 = 578,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10F3"]/*' />
    CV_AMD64_YMM10F3 = 579,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10F4"]/*' />
    CV_AMD64_YMM10F4 = 580,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10F5"]/*' />
    CV_AMD64_YMM10F5 = 581,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10F6"]/*' />
    CV_AMD64_YMM10F6 = 582,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10F7"]/*' />
    CV_AMD64_YMM10F7 = 583,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11F0"]/*' />
    CV_AMD64_YMM11F0 = 584,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11F1"]/*' />
    CV_AMD64_YMM11F1 = 585,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11F2"]/*' />
    CV_AMD64_YMM11F2 = 586,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11F3"]/*' />
    CV_AMD64_YMM11F3 = 587,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11F4"]/*' />
    CV_AMD64_YMM11F4 = 588,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11F5"]/*' />
    CV_AMD64_YMM11F5 = 589,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11F6"]/*' />
    CV_AMD64_YMM11F6 = 590,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11F7"]/*' />
    CV_AMD64_YMM11F7 = 591,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12F0"]/*' />
    CV_AMD64_YMM12F0 = 592,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12F1"]/*' />
    CV_AMD64_YMM12F1 = 593,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12F2"]/*' />
    CV_AMD64_YMM12F2 = 594,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12F3"]/*' />
    CV_AMD64_YMM12F3 = 595,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12F4"]/*' />
    CV_AMD64_YMM12F4 = 596,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12F5"]/*' />
    CV_AMD64_YMM12F5 = 597,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12F6"]/*' />
    CV_AMD64_YMM12F6 = 598,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12F7"]/*' />
    CV_AMD64_YMM12F7 = 599,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13F0"]/*' />
    CV_AMD64_YMM13F0 = 600,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13F1"]/*' />
    CV_AMD64_YMM13F1 = 601,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13F2"]/*' />
    CV_AMD64_YMM13F2 = 602,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13F3"]/*' />
    CV_AMD64_YMM13F3 = 603,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13F4"]/*' />
    CV_AMD64_YMM13F4 = 604,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13F5"]/*' />
    CV_AMD64_YMM13F5 = 605,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13F6"]/*' />
    CV_AMD64_YMM13F6 = 606,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13F7"]/*' />
    CV_AMD64_YMM13F7 = 607,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14F0"]/*' />
    CV_AMD64_YMM14F0 = 608,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14F1"]/*' />
    CV_AMD64_YMM14F1 = 609,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14F2"]/*' />
    CV_AMD64_YMM14F2 = 610,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14F3"]/*' />
    CV_AMD64_YMM14F3 = 611,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14F4"]/*' />
    CV_AMD64_YMM14F4 = 612,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14F5"]/*' />
    CV_AMD64_YMM14F5 = 613,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14F6"]/*' />
    CV_AMD64_YMM14F6 = 614,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14F7"]/*' />
    CV_AMD64_YMM14F7 = 615,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15F0"]/*' />
    CV_AMD64_YMM15F0 = 616,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15F1"]/*' />
    CV_AMD64_YMM15F1 = 617,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15F2"]/*' />
    CV_AMD64_YMM15F2 = 618,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15F3"]/*' />
    CV_AMD64_YMM15F3 = 619,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15F4"]/*' />
    CV_AMD64_YMM15F4 = 620,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15F5"]/*' />
    CV_AMD64_YMM15F5 = 621,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15F6"]/*' />
    CV_AMD64_YMM15F6 = 622,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15F7"]/*' />
    CV_AMD64_YMM15F7 = 623,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0D0"]/*' />
    CV_AMD64_YMM0D0 = 624,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0D1"]/*' />
    CV_AMD64_YMM0D1 = 625,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0D2"]/*' />
    CV_AMD64_YMM0D2 = 626,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM0D3"]/*' />
    CV_AMD64_YMM0D3 = 627,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1D0"]/*' />
    CV_AMD64_YMM1D0 = 628,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1D1"]/*' />
    CV_AMD64_YMM1D1 = 629,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1D2"]/*' />
    CV_AMD64_YMM1D2 = 630,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM1D3"]/*' />
    CV_AMD64_YMM1D3 = 631,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2D0"]/*' />
    CV_AMD64_YMM2D0 = 632,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2D1"]/*' />
    CV_AMD64_YMM2D1 = 633,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2D2"]/*' />
    CV_AMD64_YMM2D2 = 634,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM2D3"]/*' />
    CV_AMD64_YMM2D3 = 635,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3D0"]/*' />
    CV_AMD64_YMM3D0 = 636,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3D1"]/*' />
    CV_AMD64_YMM3D1 = 637,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3D2"]/*' />
    CV_AMD64_YMM3D2 = 638,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM3D3"]/*' />
    CV_AMD64_YMM3D3 = 639,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4D0"]/*' />
    CV_AMD64_YMM4D0 = 640,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4D1"]/*' />
    CV_AMD64_YMM4D1 = 641,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4D2"]/*' />
    CV_AMD64_YMM4D2 = 642,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM4D3"]/*' />
    CV_AMD64_YMM4D3 = 643,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5D0"]/*' />
    CV_AMD64_YMM5D0 = 644,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5D1"]/*' />
    CV_AMD64_YMM5D1 = 645,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5D2"]/*' />
    CV_AMD64_YMM5D2 = 646,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM5D3"]/*' />
    CV_AMD64_YMM5D3 = 647,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6D0"]/*' />
    CV_AMD64_YMM6D0 = 648,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6D1"]/*' />
    CV_AMD64_YMM6D1 = 649,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6D2"]/*' />
    CV_AMD64_YMM6D2 = 650,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM6D3"]/*' />
    CV_AMD64_YMM6D3 = 651,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7D0"]/*' />
    CV_AMD64_YMM7D0 = 652,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7D1"]/*' />
    CV_AMD64_YMM7D1 = 653,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7D2"]/*' />
    CV_AMD64_YMM7D2 = 654,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM7D3"]/*' />
    CV_AMD64_YMM7D3 = 655,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8D0"]/*' />
    CV_AMD64_YMM8D0 = 656,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8D1"]/*' />
    CV_AMD64_YMM8D1 = 657,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8D2"]/*' />
    CV_AMD64_YMM8D2 = 658,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM8D3"]/*' />
    CV_AMD64_YMM8D3 = 659,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9D0"]/*' />
    CV_AMD64_YMM9D0 = 660,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9D1"]/*' />
    CV_AMD64_YMM9D1 = 661,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9D2"]/*' />
    CV_AMD64_YMM9D2 = 662,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM9D3"]/*' />
    CV_AMD64_YMM9D3 = 663,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10D0"]/*' />
    CV_AMD64_YMM10D0 = 664,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10D1"]/*' />
    CV_AMD64_YMM10D1 = 665,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10D2"]/*' />
    CV_AMD64_YMM10D2 = 666,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM10D3"]/*' />
    CV_AMD64_YMM10D3 = 667,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11D0"]/*' />
    CV_AMD64_YMM11D0 = 668,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11D1"]/*' />
    CV_AMD64_YMM11D1 = 669,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11D2"]/*' />
    CV_AMD64_YMM11D2 = 670,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM11D3"]/*' />
    CV_AMD64_YMM11D3 = 671,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12D0"]/*' />
    CV_AMD64_YMM12D0 = 672,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12D1"]/*' />
    CV_AMD64_YMM12D1 = 673,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12D2"]/*' />
    CV_AMD64_YMM12D2 = 674,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM12D3"]/*' />
    CV_AMD64_YMM12D3 = 675,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13D0"]/*' />
    CV_AMD64_YMM13D0 = 676,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13D1"]/*' />
    CV_AMD64_YMM13D1 = 677,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13D2"]/*' />
    CV_AMD64_YMM13D2 = 678,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM13D3"]/*' />
    CV_AMD64_YMM13D3 = 679,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14D0"]/*' />
    CV_AMD64_YMM14D0 = 680,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14D1"]/*' />
    CV_AMD64_YMM14D1 = 681,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14D2"]/*' />
    CV_AMD64_YMM14D2 = 682,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM14D3"]/*' />
    CV_AMD64_YMM14D3 = 683,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15D0"]/*' />
    CV_AMD64_YMM15D0 = 684,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15D1"]/*' />
    CV_AMD64_YMM15D1 = 685,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15D2"]/*' />
    CV_AMD64_YMM15D2 = 686,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM15D3"]/*' />
    CV_AMD64_YMM15D3 = 687,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_BND0"]/*' />
    CV_AMD64_BND0 = 688,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_BND1"]/*' />
    CV_AMD64_BND1 = 689,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_BND2"]/*' />
    CV_AMD64_BND2 = 690,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_BND3"]/*' />
    CV_AMD64_BND3 = 691,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_BNDCFGU"]/*' />
    CV_AMD64_BNDCFGU = 692,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_BNDSTATUS"]/*' />
    CV_AMD64_BNDSTATUS = 693,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM16"]/*' />
    CV_AMD64_XMM16 = 694,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM17"]/*' />
    CV_AMD64_XMM17 = 695,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM18"]/*' />
    CV_AMD64_XMM18 = 696,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM19"]/*' />
    CV_AMD64_XMM19 = 697,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM20"]/*' />
    CV_AMD64_XMM20 = 698,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM21"]/*' />
    CV_AMD64_XMM21 = 699,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM22"]/*' />
    CV_AMD64_XMM22 = 700,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM23"]/*' />
    CV_AMD64_XMM23 = 701,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM24"]/*' />
    CV_AMD64_XMM24 = 702,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM25"]/*' />
    CV_AMD64_XMM25 = 703,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM26"]/*' />
    CV_AMD64_XMM26 = 704,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM27"]/*' />
    CV_AMD64_XMM27 = 705,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM28"]/*' />
    CV_AMD64_XMM28 = 706,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM29"]/*' />
    CV_AMD64_XMM29 = 707,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM30"]/*' />
    CV_AMD64_XMM30 = 708,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM31"]/*' />
    CV_AMD64_XMM31 = 709,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM16"]/*' />
    CV_AMD64_YMM16 = 710,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM17"]/*' />
    CV_AMD64_YMM17 = 711,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM18"]/*' />
    CV_AMD64_YMM18 = 712,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM19"]/*' />
    CV_AMD64_YMM19 = 713,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM20"]/*' />
    CV_AMD64_YMM20 = 714,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM21"]/*' />
    CV_AMD64_YMM21 = 715,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM22"]/*' />
    CV_AMD64_YMM22 = 716,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM23"]/*' />
    CV_AMD64_YMM23 = 717,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM24"]/*' />
    CV_AMD64_YMM24 = 718,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM25"]/*' />
    CV_AMD64_YMM25 = 719,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM26"]/*' />
    CV_AMD64_YMM26 = 720,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM27"]/*' />
    CV_AMD64_YMM27 = 721,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM28"]/*' />
    CV_AMD64_YMM28 = 722,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM29"]/*' />
    CV_AMD64_YMM29 = 723,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM30"]/*' />
    CV_AMD64_YMM30 = 724,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_YMM31"]/*' />
    CV_AMD64_YMM31 = 725,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM0"]/*' />
    CV_AMD64_ZMM0 = 726,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM1"]/*' />
    CV_AMD64_ZMM1 = 727,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM2"]/*' />
    CV_AMD64_ZMM2 = 728,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM3"]/*' />
    CV_AMD64_ZMM3 = 729,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM4"]/*' />
    CV_AMD64_ZMM4 = 730,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM5"]/*' />
    CV_AMD64_ZMM5 = 731,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM6"]/*' />
    CV_AMD64_ZMM6 = 732,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM7"]/*' />
    CV_AMD64_ZMM7 = 733,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM8"]/*' />
    CV_AMD64_ZMM8 = 734,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM9"]/*' />
    CV_AMD64_ZMM9 = 735,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM10"]/*' />
    CV_AMD64_ZMM10 = 736,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM11"]/*' />
    CV_AMD64_ZMM11 = 737,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM12"]/*' />
    CV_AMD64_ZMM12 = 738,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM13"]/*' />
    CV_AMD64_ZMM13 = 739,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM14"]/*' />
    CV_AMD64_ZMM14 = 740,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM15"]/*' />
    CV_AMD64_ZMM15 = 741,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM16"]/*' />
    CV_AMD64_ZMM16 = 742,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM17"]/*' />
    CV_AMD64_ZMM17 = 743,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM18"]/*' />
    CV_AMD64_ZMM18 = 744,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM19"]/*' />
    CV_AMD64_ZMM19 = 745,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM20"]/*' />
    CV_AMD64_ZMM20 = 746,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM21"]/*' />
    CV_AMD64_ZMM21 = 747,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM22"]/*' />
    CV_AMD64_ZMM22 = 748,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM23"]/*' />
    CV_AMD64_ZMM23 = 749,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM24"]/*' />
    CV_AMD64_ZMM24 = 750,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM25"]/*' />
    CV_AMD64_ZMM25 = 751,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM26"]/*' />
    CV_AMD64_ZMM26 = 752,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM27"]/*' />
    CV_AMD64_ZMM27 = 753,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM28"]/*' />
    CV_AMD64_ZMM28 = 754,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM29"]/*' />
    CV_AMD64_ZMM29 = 755,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM30"]/*' />
    CV_AMD64_ZMM30 = 756,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM31"]/*' />
    CV_AMD64_ZMM31 = 757,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_K0"]/*' />
    CV_AMD64_K0 = 758,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_K1"]/*' />
    CV_AMD64_K1 = 759,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_K2"]/*' />
    CV_AMD64_K2 = 760,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_K3"]/*' />
    CV_AMD64_K3 = 761,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_K4"]/*' />
    CV_AMD64_K4 = 762,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_K5"]/*' />
    CV_AMD64_K5 = 763,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_K6"]/*' />
    CV_AMD64_K6 = 764,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_K7"]/*' />
    CV_AMD64_K7 = 765,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM0H"]/*' />
    CV_AMD64_ZMM0H = 766,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM1H"]/*' />
    CV_AMD64_ZMM1H = 767,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM2H"]/*' />
    CV_AMD64_ZMM2H = 768,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM3H"]/*' />
    CV_AMD64_ZMM3H = 769,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM4H"]/*' />
    CV_AMD64_ZMM4H = 770,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM5H"]/*' />
    CV_AMD64_ZMM5H = 771,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM6H"]/*' />
    CV_AMD64_ZMM6H = 772,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM7H"]/*' />
    CV_AMD64_ZMM7H = 773,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM8H"]/*' />
    CV_AMD64_ZMM8H = 774,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM9H"]/*' />
    CV_AMD64_ZMM9H = 775,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM10H"]/*' />
    CV_AMD64_ZMM10H = 776,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM11H"]/*' />
    CV_AMD64_ZMM11H = 777,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM12H"]/*' />
    CV_AMD64_ZMM12H = 778,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM13H"]/*' />
    CV_AMD64_ZMM13H = 779,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM14H"]/*' />
    CV_AMD64_ZMM14H = 780,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_ZMM15H"]/*' />
    CV_AMD64_ZMM15H = 781,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM16L"]/*' />
    CV_AMD64_XMM16L = 782,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM17L"]/*' />
    CV_AMD64_XMM17L = 783,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM18L"]/*' />
    CV_AMD64_XMM18L = 784,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM19L"]/*' />
    CV_AMD64_XMM19L = 785,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM20L"]/*' />
    CV_AMD64_XMM20L = 786,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM21L"]/*' />
    CV_AMD64_XMM21L = 787,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM22L"]/*' />
    CV_AMD64_XMM22L = 788,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM23L"]/*' />
    CV_AMD64_XMM23L = 789,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM24L"]/*' />
    CV_AMD64_XMM24L = 790,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM25L"]/*' />
    CV_AMD64_XMM25L = 791,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM26L"]/*' />
    CV_AMD64_XMM26L = 792,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM27L"]/*' />
    CV_AMD64_XMM27L = 793,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM28L"]/*' />
    CV_AMD64_XMM28L = 794,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM29L"]/*' />
    CV_AMD64_XMM29L = 795,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM30L"]/*' />
    CV_AMD64_XMM30L = 796,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM31L"]/*' />
    CV_AMD64_XMM31L = 797,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM16_0"]/*' />
    CV_AMD64_XMM16_0 = 798,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM17_0"]/*' />
    CV_AMD64_XMM17_0 = 799,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM18_0"]/*' />
    CV_AMD64_XMM18_0 = 800,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM19_0"]/*' />
    CV_AMD64_XMM19_0 = 801,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM20_0"]/*' />
    CV_AMD64_XMM20_0 = 802,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM21_0"]/*' />
    CV_AMD64_XMM21_0 = 803,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM22_0"]/*' />
    CV_AMD64_XMM22_0 = 804,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM23_0"]/*' />
    CV_AMD64_XMM23_0 = 805,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM24_0"]/*' />
    CV_AMD64_XMM24_0 = 806,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM25_0"]/*' />
    CV_AMD64_XMM25_0 = 807,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM26_0"]/*' />
    CV_AMD64_XMM26_0 = 808,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM27_0"]/*' />
    CV_AMD64_XMM27_0 = 809,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM28_0"]/*' />
    CV_AMD64_XMM28_0 = 810,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM29_0"]/*' />
    CV_AMD64_XMM29_0 = 811,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM30_0"]/*' />
    CV_AMD64_XMM30_0 = 812,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM31_0"]/*' />
    CV_AMD64_XMM31_0 = 813,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM16H"]/*' />
    CV_AMD64_XMM16H = 814,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM17H"]/*' />
    CV_AMD64_XMM17H = 815,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM18H"]/*' />
    CV_AMD64_XMM18H = 816,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM19H"]/*' />
    CV_AMD64_XMM19H = 817,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM20H"]/*' />
    CV_AMD64_XMM20H = 818,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM21H"]/*' />
    CV_AMD64_XMM21H = 819,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM22H"]/*' />
    CV_AMD64_XMM22H = 820,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM23H"]/*' />
    CV_AMD64_XMM23H = 821,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM24H"]/*' />
    CV_AMD64_XMM24H = 822,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM25H"]/*' />
    CV_AMD64_XMM25H = 823,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM26H"]/*' />
    CV_AMD64_XMM26H = 824,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM27H"]/*' />
    CV_AMD64_XMM27H = 825,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM28H"]/*' />
    CV_AMD64_XMM28H = 826,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM29H"]/*' />
    CV_AMD64_XMM29H = 827,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM30H"]/*' />
    CV_AMD64_XMM30H = 828,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_XMM31H"]/*' />
    CV_AMD64_XMM31H = 829,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM16H"]/*' />
    CV_AMD64_EMM16H = 830,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM17H"]/*' />
    CV_AMD64_EMM17H = 831,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM18H"]/*' />
    CV_AMD64_EMM18H = 832,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM19H"]/*' />
    CV_AMD64_EMM19H = 833,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM20H"]/*' />
    CV_AMD64_EMM20H = 834,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM21H"]/*' />
    CV_AMD64_EMM21H = 835,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM22H"]/*' />
    CV_AMD64_EMM22H = 836,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM23H"]/*' />
    CV_AMD64_EMM23H = 837,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM24H"]/*' />
    CV_AMD64_EMM24H = 838,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM25H"]/*' />
    CV_AMD64_EMM25H = 839,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM26H"]/*' />
    CV_AMD64_EMM26H = 840,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM27H"]/*' />
    CV_AMD64_EMM27H = 841,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM28H"]/*' />
    CV_AMD64_EMM28H = 842,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM29H"]/*' />
    CV_AMD64_EMM29H = 843,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM30H"]/*' />
    CV_AMD64_EMM30H = 844,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_EMM31H"]/*' />
    CV_AMD64_EMM31H = 845,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_SSP"]/*' />
    CV_AMD64_SSP = 846,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_TMM0"]/*' />
    CV_AMD64_TMM0 = 847,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_TMM1"]/*' />
    CV_AMD64_TMM1 = 848,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_TMM2"]/*' />
    CV_AMD64_TMM2 = 849,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_TMM3"]/*' />
    CV_AMD64_TMM3 = 850,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_TMM4"]/*' />
    CV_AMD64_TMM4 = 851,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_TMM5"]/*' />
    CV_AMD64_TMM5 = 852,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_TMM6"]/*' />
    CV_AMD64_TMM6 = 853,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_TMM7"]/*' />
    CV_AMD64_TMM7 = 854,

    /// <include file='CV_HREG_e.xml' path='doc/member[@name="CV_HREG_e.CV_AMD64_TILECFG"]/*' />
    CV_AMD64_TILECFG = 855,
}
