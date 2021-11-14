// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("imm32", ExactSpelling = true)]
        public static extern BOOL ImmGetHotKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPUINT")] uint* lpuModifiers, [NativeTypeName("LPUINT")] uint* lpuVKey, [NativeTypeName("LPHKL")] HKL* phKL);

        [DllImport("imm32", ExactSpelling = true)]
        public static extern BOOL ImmSetHotKey([NativeTypeName("DWORD")] uint param0, uint param1, uint param2, HKL param3);

        [DllImport("imm32", ExactSpelling = true)]
        public static extern BOOL ImmGenerateMessage(HIMC param0);

        [DllImport("imm32", ExactSpelling = true)]
        public static extern LRESULT ImmRequestMessageA(HIMC param0, WPARAM param1, LPARAM param2);

        [DllImport("imm32", ExactSpelling = true)]
        public static extern LRESULT ImmRequestMessageW(HIMC param0, WPARAM param1, LPARAM param2);

        [DllImport("imm32", ExactSpelling = true)]
        public static extern HWND ImmCreateSoftKeyboard(uint param0, HWND param1, int param2, int param3);

        [DllImport("imm32", ExactSpelling = true)]
        public static extern BOOL ImmDestroySoftKeyboard(HWND param0);

        [DllImport("imm32", ExactSpelling = true)]
        public static extern BOOL ImmShowSoftKeyboard(HWND param0, int param1);

        [DllImport("imm32", ExactSpelling = true)]
        [return: NativeTypeName("LPINPUTCONTEXT")]
        public static extern INPUTCONTEXT* ImmLockIMC(HIMC param0);

        [DllImport("imm32", ExactSpelling = true)]
        public static extern BOOL ImmUnlockIMC(HIMC param0);

        [DllImport("imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetIMCLockCount(HIMC param0);

        [DllImport("imm32", ExactSpelling = true)]
        public static extern HIMCC ImmCreateIMCC([NativeTypeName("DWORD")] uint param0);

        [DllImport("imm32", ExactSpelling = true)]
        public static extern HIMCC ImmDestroyIMCC(HIMCC param0);

        [DllImport("imm32", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* ImmLockIMCC(HIMCC param0);

        [DllImport("imm32", ExactSpelling = true)]
        public static extern BOOL ImmUnlockIMCC(HIMCC param0);

        [DllImport("imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetIMCCLockCount(HIMCC param0);

        [DllImport("imm32", ExactSpelling = true)]
        public static extern HIMCC ImmReSizeIMCC(HIMCC param0, [NativeTypeName("DWORD")] uint param1);

        [DllImport("imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetIMCCSize(HIMCC param0);

        [NativeTypeName("#define ImmRequestMessage ImmRequestMessageW")]
        public static delegate*<HIMC, WPARAM, LPARAM, LRESULT> ImmRequestMessage => &ImmRequestMessageW;

        [NativeTypeName("#define IMMGWL_IMC 0")]
        public const int IMMGWL_IMC = 0;

        [NativeTypeName("#define IMMGWL_PRIVATE (sizeof(LONG))")]
        public const uint IMMGWL_PRIVATE = (4);

        [NativeTypeName("#define IMMGWLP_IMC 0")]
        public const int IMMGWLP_IMC = 0;

        [NativeTypeName("#define IMMGWLP_PRIVATE (sizeof(LONG_PTR))")]
        public static uint IMMGWLP_PRIVATE => unchecked((uint)(sizeof(nint)));

        [NativeTypeName("#define IMC_SETCONVERSIONMODE 0x0002")]
        public const int IMC_SETCONVERSIONMODE = 0x0002;

        [NativeTypeName("#define IMC_SETSENTENCEMODE 0x0004")]
        public const int IMC_SETSENTENCEMODE = 0x0004;

        [NativeTypeName("#define IMC_SETOPENSTATUS 0x0006")]
        public const int IMC_SETOPENSTATUS = 0x0006;

        [NativeTypeName("#define IMC_GETSOFTKBDFONT 0x0011")]
        public const int IMC_GETSOFTKBDFONT = 0x0011;

        [NativeTypeName("#define IMC_SETSOFTKBDFONT 0x0012")]
        public const int IMC_SETSOFTKBDFONT = 0x0012;

        [NativeTypeName("#define IMC_GETSOFTKBDPOS 0x0013")]
        public const int IMC_GETSOFTKBDPOS = 0x0013;

        [NativeTypeName("#define IMC_SETSOFTKBDPOS 0x0014")]
        public const int IMC_SETSOFTKBDPOS = 0x0014;

        [NativeTypeName("#define IMC_GETSOFTKBDSUBTYPE 0x0015")]
        public const int IMC_GETSOFTKBDSUBTYPE = 0x0015;

        [NativeTypeName("#define IMC_SETSOFTKBDSUBTYPE 0x0016")]
        public const int IMC_SETSOFTKBDSUBTYPE = 0x0016;

        [NativeTypeName("#define IMC_SETSOFTKBDDATA 0x0018")]
        public const int IMC_SETSOFTKBDDATA = 0x0018;

        [NativeTypeName("#define NI_CONTEXTUPDATED 0x0003")]
        public const int NI_CONTEXTUPDATED = 0x0003;

        [NativeTypeName("#define GCS_COMP (GCS_COMPSTR|GCS_COMPATTR|GCS_COMPCLAUSE)")]
        public const int GCS_COMP = (0x0008 | 0x0010 | 0x0020);

        [NativeTypeName("#define GCS_COMPREAD (GCS_COMPREADSTR|GCS_COMPREADATTR |GCS_COMPREADCLAUSE)")]
        public const int GCS_COMPREAD = (0x0001 | 0x0002 | 0x0004);

        [NativeTypeName("#define GCS_RESULT (GCS_RESULTSTR|GCS_RESULTCLAUSE)")]
        public const int GCS_RESULT = (0x0800 | 0x1000);

        [NativeTypeName("#define GCS_RESULTREAD (GCS_RESULTREADSTR|GCS_RESULTREADCLAUSE)")]
        public const int GCS_RESULTREAD = (0x0200 | 0x0400);

        [NativeTypeName("#define INIT_STATUSWNDPOS 0x00000001")]
        public const int INIT_STATUSWNDPOS = 0x00000001;

        [NativeTypeName("#define INIT_CONVERSION 0x00000002")]
        public const int INIT_CONVERSION = 0x00000002;

        [NativeTypeName("#define INIT_SENTENCE 0x00000004")]
        public const int INIT_SENTENCE = 0x00000004;

        [NativeTypeName("#define INIT_LOGFONT 0x00000008")]
        public const int INIT_LOGFONT = 0x00000008;

        [NativeTypeName("#define INIT_COMPFORM 0x00000010")]
        public const int INIT_COMPFORM = 0x00000010;

        [NativeTypeName("#define INIT_SOFTKBDPOS 0x00000020")]
        public const int INIT_SOFTKBDPOS = 0x00000020;

        [NativeTypeName("#define UI_CAP_SOFTKBD 0x00010000")]
        public const int UI_CAP_SOFTKBD = 0x00010000;

        [NativeTypeName("#define IMN_SOFTKBDDESTROYED 0x0011")]
        public const int IMN_SOFTKBDDESTROYED = 0x0011;
    }
}
