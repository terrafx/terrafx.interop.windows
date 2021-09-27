// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmGetHotKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPUINT")] uint* lpuModifiers, [NativeTypeName("LPUINT")] uint* lpuVKey, [NativeTypeName("LPHKL")] IntPtr* phKL);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmSetHotKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("UINT")] uint param1, [NativeTypeName("UINT")] uint param2, [NativeTypeName("HKL")] IntPtr param3);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmGenerateMessage([NativeTypeName("HIMC")] IntPtr param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint ImmRequestMessageA([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("WPARAM")] nuint param1, [NativeTypeName("LPARAM")] nint param2);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint ImmRequestMessageW([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("WPARAM")] nuint param1, [NativeTypeName("LPARAM")] nint param2);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr ImmCreateSoftKeyboard([NativeTypeName("UINT")] uint param0, [NativeTypeName("HWND")] IntPtr param1, int param2, int param3);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmDestroySoftKeyboard([NativeTypeName("HWND")] IntPtr param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmShowSoftKeyboard([NativeTypeName("HWND")] IntPtr param0, int param1);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("LPINPUTCONTEXT")]
        public static extern INPUTCONTEXT* ImmLockIMC([NativeTypeName("HIMC")] IntPtr param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmUnlockIMC([NativeTypeName("HIMC")] IntPtr param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetIMCLockCount([NativeTypeName("HIMC")] IntPtr param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("HIMCC")]
        public static extern IntPtr ImmCreateIMCC([NativeTypeName("DWORD")] uint param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("HIMCC")]
        public static extern IntPtr ImmDestroyIMCC([NativeTypeName("HIMCC")] IntPtr param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* ImmLockIMCC([NativeTypeName("HIMCC")] IntPtr param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmUnlockIMCC([NativeTypeName("HIMCC")] IntPtr param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetIMCCLockCount([NativeTypeName("HIMCC")] IntPtr param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("HIMCC")]
        public static extern IntPtr ImmReSizeIMCC([NativeTypeName("HIMCC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetIMCCSize([NativeTypeName("HIMCC")] IntPtr param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImeInquire([NativeTypeName("LPIMEINFO")] IMEINFO* lpIMEInfo, [NativeTypeName("LPTSTR")] ushort* lpszUIClass, [NativeTypeName("DWORD")] uint dwSystemInfoFlags);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImeConfigure([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("HWND")] IntPtr param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPVOID")] void* param3);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImeConversionList([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("LPCTSTR")] ushort* lpSource, [NativeTypeName("LPCANDIDATELIST")] CANDIDATELIST* lpDest, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("UINT")] uint uFlag);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImeDestroy([NativeTypeName("UINT")] uint param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint ImeEscape([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("UINT")] uint param1, [NativeTypeName("LPVOID")] void* param2);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImeProcessKey([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("UINT")] uint param1, [NativeTypeName("LPARAM")] nint param2, [NativeTypeName("const LPBYTE")] byte* lpbKeyState);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImeSelect([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("BOOL")] int param1);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImeSetActiveContext([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("BOOL")] int param1);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint ImeToAsciiEx([NativeTypeName("UINT")] uint uVirtKey, [NativeTypeName("UINT")] uint uScaCode, [NativeTypeName("const LPBYTE")] byte* lpbKeyState, [NativeTypeName("LPTRANSMSGLIST")] TRANSMSGLIST* lpTransBuf, [NativeTypeName("UINT")] uint fuState, [NativeTypeName("HIMC")] IntPtr param5);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int NotifyIME([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImeRegisterWord([NativeTypeName("LPCTSTR")] ushort* lpszReading, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPCTSTR")] ushort* lpszString);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImeUnregisterWord([NativeTypeName("LPCTSTR")] ushort* lpszReading, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPCTSTR")] ushort* lpszString);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint ImeGetRegisterWordStyle([NativeTypeName("UINT")] uint nItem, [NativeTypeName("LPSTYLEBUF")] STYLEBUFW* lpStyleBuf);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint ImeEnumRegisterWord([NativeTypeName("REGISTERWORDENUMPROCW")] delegate* unmanaged<ushort*, uint, ushort*, void*, int> param0, [NativeTypeName("LPCTSTR")] ushort* lpszReading, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPCTSTR")] ushort* lpszString, [NativeTypeName("LPVOID")] void* param4);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImeSetCompositionString([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPVOID")] void* lpComp, [NativeTypeName("DWORD")] uint dwCompLen, [NativeTypeName("LPVOID")] void* lpRead, [NativeTypeName("DWORD")] uint dwReadLen);

        [NativeTypeName("#define ImmRequestMessage ImmRequestMessageW")]
        public static delegate*<IntPtr, nuint, nint, nint> ImmRequestMessage => &ImmRequestMessageW;

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

        [NativeTypeName("#define IME_SYSINFO_WINLOGON 0x0001")]
        public const int IME_SYSINFO_WINLOGON = 0x0001;

        [NativeTypeName("#define IME_SYSINFO_WOW16 0x0002")]
        public const int IME_SYSINFO_WOW16 = 0x0002;

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

        [NativeTypeName("#define IME_PROP_END_UNLOAD 0x00000001")]
        public const int IME_PROP_END_UNLOAD = 0x00000001;

        [NativeTypeName("#define IME_PROP_KBD_CHAR_FIRST 0x00000002")]
        public const int IME_PROP_KBD_CHAR_FIRST = 0x00000002;

        [NativeTypeName("#define IME_PROP_IGNORE_UPKEYS 0x00000004")]
        public const int IME_PROP_IGNORE_UPKEYS = 0x00000004;

        [NativeTypeName("#define IME_PROP_NEED_ALTKEY 0x00000008")]
        public const int IME_PROP_NEED_ALTKEY = 0x00000008;

        [NativeTypeName("#define IME_PROP_NO_KEYS_ON_CLOSE 0x00000010")]
        public const int IME_PROP_NO_KEYS_ON_CLOSE = 0x00000010;

        [NativeTypeName("#define IME_PROP_ACCEPT_WIDE_VKEY 0x00000020")]
        public const int IME_PROP_ACCEPT_WIDE_VKEY = 0x00000020;

        [NativeTypeName("#define UI_CAP_SOFTKBD 0x00010000")]
        public const int UI_CAP_SOFTKBD = 0x00010000;

        [NativeTypeName("#define IMN_SOFTKBDDESTROYED 0x0011")]
        public const int IMN_SOFTKBDDESTROYED = 0x0011;

        [NativeTypeName("#define IME_UI_CLASS_NAME_SIZE 16")]
        public const int IME_UI_CLASS_NAME_SIZE = 16;

        [NativeTypeName("#define IME_ESC_STRING_BUFFER_SIZE 80")]
        public const int IME_ESC_STRING_BUFFER_SIZE = 80;
    }
}
