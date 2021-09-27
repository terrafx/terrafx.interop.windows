// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("HKL")]
        public static extern IntPtr ImmInstallIMEA([NativeTypeName("LPCSTR")] sbyte* lpszIMEFileName, [NativeTypeName("LPCSTR")] sbyte* lpszLayoutText);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("HKL")]
        public static extern IntPtr ImmInstallIMEW([NativeTypeName("LPCWSTR")] ushort* lpszIMEFileName, [NativeTypeName("LPCWSTR")] ushort* lpszLayoutText);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr ImmGetDefaultIMEWnd([NativeTypeName("HWND")] IntPtr param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint ImmGetDescriptionA([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("LPSTR")] sbyte* lpszDescription, [NativeTypeName("UINT")] uint uBufLen);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint ImmGetDescriptionW([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("LPWSTR")] ushort* lpszDescription, [NativeTypeName("UINT")] uint uBufLen);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint ImmGetIMEFileNameA([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("LPSTR")] sbyte* lpszFileName, [NativeTypeName("UINT")] uint uBufLen);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint ImmGetIMEFileNameW([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("LPWSTR")] ushort* lpszFileName, [NativeTypeName("UINT")] uint uBufLen);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetProperty([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("DWORD")] uint param1);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmIsIME([NativeTypeName("HKL")] IntPtr param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmSimulateHotKey([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("DWORD")] uint param1);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("HIMC")]
        public static extern IntPtr ImmCreateContext();

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmDestroyContext([NativeTypeName("HIMC")] IntPtr param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("HIMC")]
        public static extern IntPtr ImmGetContext([NativeTypeName("HWND")] IntPtr param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmReleaseContext([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("HIMC")] IntPtr param1);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("HIMC")]
        public static extern IntPtr ImmAssociateContext([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("HIMC")] IntPtr param1);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmAssociateContextEx([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("HIMC")] IntPtr param1, [NativeTypeName("DWORD")] uint param2);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ImmGetCompositionStringA([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPVOID")] void* lpBuf, [NativeTypeName("DWORD")] uint dwBufLen);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ImmGetCompositionStringW([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPVOID")] void* lpBuf, [NativeTypeName("DWORD")] uint dwBufLen);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmSetCompositionStringA([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPVOID")] void* lpComp, [NativeTypeName("DWORD")] uint dwCompLen, [NativeTypeName("LPVOID")] void* lpRead, [NativeTypeName("DWORD")] uint dwReadLen);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmSetCompositionStringW([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPVOID")] void* lpComp, [NativeTypeName("DWORD")] uint dwCompLen, [NativeTypeName("LPVOID")] void* lpRead, [NativeTypeName("DWORD")] uint dwReadLen);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetCandidateListCountA([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("LPDWORD")] uint* lpdwListCount);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetCandidateListCountW([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("LPDWORD")] uint* lpdwListCount);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetCandidateListA([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("DWORD")] uint deIndex, [NativeTypeName("LPCANDIDATELIST")] CANDIDATELIST* lpCandList, [NativeTypeName("DWORD")] uint dwBufLen);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetCandidateListW([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("DWORD")] uint deIndex, [NativeTypeName("LPCANDIDATELIST")] CANDIDATELIST* lpCandList, [NativeTypeName("DWORD")] uint dwBufLen);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetGuideLineA([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPSTR")] sbyte* lpBuf, [NativeTypeName("DWORD")] uint dwBufLen);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetGuideLineW([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* lpBuf, [NativeTypeName("DWORD")] uint dwBufLen);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmGetConversionStatus([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("LPDWORD")] uint* lpfdwConversion, [NativeTypeName("LPDWORD")] uint* lpfdwSentence);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmSetConversionStatus([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmGetOpenStatus([NativeTypeName("HIMC")] IntPtr param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmSetOpenStatus([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("BOOL")] int param1);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmGetCompositionFontA([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("LPLOGFONTA")] LOGFONTA* lplf);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmGetCompositionFontW([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("LPLOGFONTW")] LOGFONTW* lplf);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmSetCompositionFontA([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("LPLOGFONTA")] LOGFONTA* lplf);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmSetCompositionFontW([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("LPLOGFONTW")] LOGFONTW* lplf);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmConfigureIMEA([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("HWND")] IntPtr param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPVOID")] void* param3);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmConfigureIMEW([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("HWND")] IntPtr param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPVOID")] void* param3);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint ImmEscapeA([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("HIMC")] IntPtr param1, [NativeTypeName("UINT")] uint param2, [NativeTypeName("LPVOID")] void* param3);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint ImmEscapeW([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("HIMC")] IntPtr param1, [NativeTypeName("UINT")] uint param2, [NativeTypeName("LPVOID")] void* param3);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetConversionListA([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("HIMC")] IntPtr param1, [NativeTypeName("LPCSTR")] sbyte* lpSrc, [NativeTypeName("LPCANDIDATELIST")] CANDIDATELIST* lpDst, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("UINT")] uint uFlag);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetConversionListW([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("HIMC")] IntPtr param1, [NativeTypeName("LPCWSTR")] ushort* lpSrc, [NativeTypeName("LPCANDIDATELIST")] CANDIDATELIST* lpDst, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("UINT")] uint uFlag);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmNotifyIME([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwValue);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmGetStatusWindowPos([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("LPPOINT")] POINT* lpptPos);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmSetStatusWindowPos([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("LPPOINT")] POINT* lpptPos);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmGetCompositionWindow([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("LPCOMPOSITIONFORM")] COMPOSITIONFORM* lpCompForm);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmSetCompositionWindow([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("LPCOMPOSITIONFORM")] COMPOSITIONFORM* lpCompForm);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmGetCandidateWindow([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPCANDIDATEFORM")] CANDIDATEFORM* lpCandidate);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmSetCandidateWindow([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("LPCANDIDATEFORM")] CANDIDATEFORM* lpCandidate);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmIsUIMessageA([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("UINT")] uint param1, [NativeTypeName("WPARAM")] nuint param2, [NativeTypeName("LPARAM")] nint param3);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmIsUIMessageW([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("UINT")] uint param1, [NativeTypeName("WPARAM")] nuint param2, [NativeTypeName("LPARAM")] nint param3);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint ImmGetVirtualKey([NativeTypeName("HWND")] IntPtr param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmRegisterWordA([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("LPCSTR")] sbyte* lpszReading, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPCSTR")] sbyte* lpszRegister);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmRegisterWordW([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("LPCWSTR")] ushort* lpszReading, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPCWSTR")] ushort* lpszRegister);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmUnregisterWordA([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("LPCSTR")] sbyte* lpszReading, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPCSTR")] sbyte* lpszUnregister);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmUnregisterWordW([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("LPCWSTR")] ushort* lpszReading, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPCWSTR")] ushort* lpszUnregister);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint ImmGetRegisterWordStyleA([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("UINT")] uint nItem, [NativeTypeName("LPSTYLEBUFA")] STYLEBUFA* lpStyleBuf);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint ImmGetRegisterWordStyleW([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("UINT")] uint nItem, [NativeTypeName("LPSTYLEBUFW")] STYLEBUFW* lpStyleBuf);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint ImmEnumRegisterWordA([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("REGISTERWORDENUMPROCA")] delegate* unmanaged<sbyte*, uint, sbyte*, void*, int> param1, [NativeTypeName("LPCSTR")] sbyte* lpszReading, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPCSTR")] sbyte* lpszRegister, [NativeTypeName("LPVOID")] void* param5);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint ImmEnumRegisterWordW([NativeTypeName("HKL")] IntPtr param0, [NativeTypeName("REGISTERWORDENUMPROCW")] delegate* unmanaged<ushort*, uint, ushort*, void*, int> param1, [NativeTypeName("LPCWSTR")] ushort* lpszReading, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPCWSTR")] ushort* lpszRegister, [NativeTypeName("LPVOID")] void* param5);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmDisableIME([NativeTypeName("DWORD")] uint param0);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmEnumInputContext([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("IMCENUMPROC")] delegate* unmanaged<IntPtr, nint, int> lpfn, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetImeMenuItemsA([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPIMEMENUITEMINFOA")] IMEMENUITEMINFOA* lpImeParentMenu, [NativeTypeName("LPIMEMENUITEMINFOA")] IMEMENUITEMINFOA* lpImeMenu, [NativeTypeName("DWORD")] uint dwSize);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ImmGetImeMenuItemsW([NativeTypeName("HIMC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPIMEMENUITEMINFOW")] IMEMENUITEMINFOW* lpImeParentMenu, [NativeTypeName("LPIMEMENUITEMINFOW")] IMEMENUITEMINFOW* lpImeMenu, [NativeTypeName("DWORD")] uint dwSize);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmDisableTextFrameService([NativeTypeName("DWORD")] uint idThread);

        [DllImport("Imm32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ImmDisableLegacyIME();

        [NativeTypeName("#define STYLE_DESCRIPTION_SIZE 32")]
        public const int STYLE_DESCRIPTION_SIZE = 32;

        [NativeTypeName("#define IMEMENUITEM_STRING_SIZE 80")]
        public const int IMEMENUITEM_STRING_SIZE = 80;

        [NativeTypeName("#define ImmInstallIME ImmInstallIMEW")]
        public static delegate*<ushort*, ushort*, IntPtr> ImmInstallIME => &ImmInstallIMEW;

        [NativeTypeName("#define ImmGetDescription ImmGetDescriptionW")]
        public static delegate*<IntPtr, ushort*, uint, uint> ImmGetDescription => &ImmGetDescriptionW;

        [NativeTypeName("#define ImmGetIMEFileName ImmGetIMEFileNameW")]
        public static delegate*<IntPtr, ushort*, uint, uint> ImmGetIMEFileName => &ImmGetIMEFileNameW;

        [NativeTypeName("#define ImmGetCompositionString ImmGetCompositionStringW")]
        public static delegate*<IntPtr, uint, void*, uint, int> ImmGetCompositionString => &ImmGetCompositionStringW;

        [NativeTypeName("#define ImmSetCompositionString ImmSetCompositionStringW")]
        public static delegate*<IntPtr, uint, void*, uint, void*, uint, int> ImmSetCompositionString => &ImmSetCompositionStringW;

        [NativeTypeName("#define ImmGetCandidateListCount ImmGetCandidateListCountW")]
        public static delegate*<IntPtr, uint*, uint> ImmGetCandidateListCount => &ImmGetCandidateListCountW;

        [NativeTypeName("#define ImmGetCandidateList ImmGetCandidateListW")]
        public static delegate*<IntPtr, uint, CANDIDATELIST*, uint, uint> ImmGetCandidateList => &ImmGetCandidateListW;

        [NativeTypeName("#define ImmGetGuideLine ImmGetGuideLineW")]
        public static delegate*<IntPtr, uint, ushort*, uint, uint> ImmGetGuideLine => &ImmGetGuideLineW;

        [NativeTypeName("#define ImmGetCompositionFont ImmGetCompositionFontW")]
        public static delegate*<IntPtr, LOGFONTW*, int> ImmGetCompositionFont => &ImmGetCompositionFontW;

        [NativeTypeName("#define ImmSetCompositionFont ImmSetCompositionFontW")]
        public static delegate*<IntPtr, LOGFONTW*, int> ImmSetCompositionFont => &ImmSetCompositionFontW;

        [NativeTypeName("#define ImmConfigureIME ImmConfigureIMEW")]
        public static delegate*<IntPtr, IntPtr, uint, void*, int> ImmConfigureIME => &ImmConfigureIMEW;

        [NativeTypeName("#define ImmEscape ImmEscapeW")]
        public static delegate*<IntPtr, IntPtr, uint, void*, nint> ImmEscape => &ImmEscapeW;

        [NativeTypeName("#define ImmGetConversionList ImmGetConversionListW")]
        public static delegate*<IntPtr, IntPtr, ushort*, CANDIDATELIST*, uint, uint, uint> ImmGetConversionList => &ImmGetConversionListW;

        [NativeTypeName("#define ImmIsUIMessage ImmIsUIMessageW")]
        public static delegate*<IntPtr, uint, nuint, nint, int> ImmIsUIMessage => &ImmIsUIMessageW;

        [NativeTypeName("#define ImmRegisterWord ImmRegisterWordW")]
        public static delegate*<IntPtr, ushort*, uint, ushort*, int> ImmRegisterWord => &ImmRegisterWordW;

        [NativeTypeName("#define ImmUnregisterWord ImmUnregisterWordW")]
        public static delegate*<IntPtr, ushort*, uint, ushort*, int> ImmUnregisterWord => &ImmUnregisterWordW;

        [NativeTypeName("#define ImmGetRegisterWordStyle ImmGetRegisterWordStyleW")]
        public static delegate*<IntPtr, uint, STYLEBUFW*, uint> ImmGetRegisterWordStyle => &ImmGetRegisterWordStyleW;

        [NativeTypeName("#define ImmEnumRegisterWord ImmEnumRegisterWordW")]
        public static delegate*<IntPtr, delegate* unmanaged<ushort*, uint, ushort*, void*, int>, ushort*, uint, ushort*, void*, uint> ImmEnumRegisterWord => &ImmEnumRegisterWordW;

        [NativeTypeName("#define ImmGetImeMenuItems ImmGetImeMenuItemsW")]
        public static delegate*<IntPtr, uint, uint, IMEMENUITEMINFOW*, IMEMENUITEMINFOW*, uint, uint> ImmGetImeMenuItems => &ImmGetImeMenuItemsW;

        [NativeTypeName("#define IMC_GETCANDIDATEPOS 0x0007")]
        public const int IMC_GETCANDIDATEPOS = 0x0007;

        [NativeTypeName("#define IMC_SETCANDIDATEPOS 0x0008")]
        public const int IMC_SETCANDIDATEPOS = 0x0008;

        [NativeTypeName("#define IMC_GETCOMPOSITIONFONT 0x0009")]
        public const int IMC_GETCOMPOSITIONFONT = 0x0009;

        [NativeTypeName("#define IMC_SETCOMPOSITIONFONT 0x000A")]
        public const int IMC_SETCOMPOSITIONFONT = 0x000A;

        [NativeTypeName("#define IMC_GETCOMPOSITIONWINDOW 0x000B")]
        public const int IMC_GETCOMPOSITIONWINDOW = 0x000B;

        [NativeTypeName("#define IMC_SETCOMPOSITIONWINDOW 0x000C")]
        public const int IMC_SETCOMPOSITIONWINDOW = 0x000C;

        [NativeTypeName("#define IMC_GETSTATUSWINDOWPOS 0x000F")]
        public const int IMC_GETSTATUSWINDOWPOS = 0x000F;

        [NativeTypeName("#define IMC_SETSTATUSWINDOWPOS 0x0010")]
        public const int IMC_SETSTATUSWINDOWPOS = 0x0010;

        [NativeTypeName("#define IMC_CLOSESTATUSWINDOW 0x0021")]
        public const int IMC_CLOSESTATUSWINDOW = 0x0021;

        [NativeTypeName("#define IMC_OPENSTATUSWINDOW 0x0022")]
        public const int IMC_OPENSTATUSWINDOW = 0x0022;

        [NativeTypeName("#define NI_OPENCANDIDATE 0x0010")]
        public const int NI_OPENCANDIDATE = 0x0010;

        [NativeTypeName("#define NI_CLOSECANDIDATE 0x0011")]
        public const int NI_CLOSECANDIDATE = 0x0011;

        [NativeTypeName("#define NI_SELECTCANDIDATESTR 0x0012")]
        public const int NI_SELECTCANDIDATESTR = 0x0012;

        [NativeTypeName("#define NI_CHANGECANDIDATELIST 0x0013")]
        public const int NI_CHANGECANDIDATELIST = 0x0013;

        [NativeTypeName("#define NI_FINALIZECONVERSIONRESULT 0x0014")]
        public const int NI_FINALIZECONVERSIONRESULT = 0x0014;

        [NativeTypeName("#define NI_COMPOSITIONSTR 0x0015")]
        public const int NI_COMPOSITIONSTR = 0x0015;

        [NativeTypeName("#define NI_SETCANDIDATE_PAGESTART 0x0016")]
        public const int NI_SETCANDIDATE_PAGESTART = 0x0016;

        [NativeTypeName("#define NI_SETCANDIDATE_PAGESIZE 0x0017")]
        public const int NI_SETCANDIDATE_PAGESIZE = 0x0017;

        [NativeTypeName("#define NI_IMEMENUSELECTED 0x0018")]
        public const int NI_IMEMENUSELECTED = 0x0018;

        [NativeTypeName("#define ISC_SHOWUICANDIDATEWINDOW 0x00000001")]
        public const int ISC_SHOWUICANDIDATEWINDOW = 0x00000001;

        [NativeTypeName("#define ISC_SHOWUICOMPOSITIONWINDOW 0x80000000")]
        public const uint ISC_SHOWUICOMPOSITIONWINDOW = 0x80000000;

        [NativeTypeName("#define ISC_SHOWUIGUIDELINE 0x40000000")]
        public const int ISC_SHOWUIGUIDELINE = 0x40000000;

        [NativeTypeName("#define ISC_SHOWUIALLCANDIDATEWINDOW 0x0000000F")]
        public const int ISC_SHOWUIALLCANDIDATEWINDOW = 0x0000000F;

        [NativeTypeName("#define ISC_SHOWUIALL 0xC000000F")]
        public const uint ISC_SHOWUIALL = 0xC000000F;

        [NativeTypeName("#define CPS_COMPLETE 0x0001")]
        public const int CPS_COMPLETE = 0x0001;

        [NativeTypeName("#define CPS_CONVERT 0x0002")]
        public const int CPS_CONVERT = 0x0002;

        [NativeTypeName("#define CPS_REVERT 0x0003")]
        public const int CPS_REVERT = 0x0003;

        [NativeTypeName("#define CPS_CANCEL 0x0004")]
        public const int CPS_CANCEL = 0x0004;

        [NativeTypeName("#define MOD_LEFT 0x8000")]
        public const int MOD_LEFT = 0x8000;

        [NativeTypeName("#define MOD_RIGHT 0x4000")]
        public const int MOD_RIGHT = 0x4000;

        [NativeTypeName("#define MOD_ON_KEYUP 0x0800")]
        public const int MOD_ON_KEYUP = 0x0800;

        [NativeTypeName("#define MOD_IGNORE_ALL_MODIFIER 0x0400")]
        public const int MOD_IGNORE_ALL_MODIFIER = 0x0400;

        [NativeTypeName("#define IME_CHOTKEY_IME_NONIME_TOGGLE 0x10")]
        public const int IME_CHOTKEY_IME_NONIME_TOGGLE = 0x10;

        [NativeTypeName("#define IME_CHOTKEY_SHAPE_TOGGLE 0x11")]
        public const int IME_CHOTKEY_SHAPE_TOGGLE = 0x11;

        [NativeTypeName("#define IME_CHOTKEY_SYMBOL_TOGGLE 0x12")]
        public const int IME_CHOTKEY_SYMBOL_TOGGLE = 0x12;

        [NativeTypeName("#define IME_JHOTKEY_CLOSE_OPEN 0x30")]
        public const int IME_JHOTKEY_CLOSE_OPEN = 0x30;

        [NativeTypeName("#define IME_KHOTKEY_SHAPE_TOGGLE 0x50")]
        public const int IME_KHOTKEY_SHAPE_TOGGLE = 0x50;

        [NativeTypeName("#define IME_KHOTKEY_HANJACONVERT 0x51")]
        public const int IME_KHOTKEY_HANJACONVERT = 0x51;

        [NativeTypeName("#define IME_KHOTKEY_ENGLISH 0x52")]
        public const int IME_KHOTKEY_ENGLISH = 0x52;

        [NativeTypeName("#define IME_THOTKEY_IME_NONIME_TOGGLE 0x70")]
        public const int IME_THOTKEY_IME_NONIME_TOGGLE = 0x70;

        [NativeTypeName("#define IME_THOTKEY_SHAPE_TOGGLE 0x71")]
        public const int IME_THOTKEY_SHAPE_TOGGLE = 0x71;

        [NativeTypeName("#define IME_THOTKEY_SYMBOL_TOGGLE 0x72")]
        public const int IME_THOTKEY_SYMBOL_TOGGLE = 0x72;

        [NativeTypeName("#define IME_HOTKEY_DSWITCH_FIRST 0x100")]
        public const int IME_HOTKEY_DSWITCH_FIRST = 0x100;

        [NativeTypeName("#define IME_HOTKEY_DSWITCH_LAST 0x11F")]
        public const int IME_HOTKEY_DSWITCH_LAST = 0x11F;

        [NativeTypeName("#define IME_HOTKEY_PRIVATE_FIRST 0x200")]
        public const int IME_HOTKEY_PRIVATE_FIRST = 0x200;

        [NativeTypeName("#define IME_ITHOTKEY_RESEND_RESULTSTR 0x200")]
        public const int IME_ITHOTKEY_RESEND_RESULTSTR = 0x200;

        [NativeTypeName("#define IME_ITHOTKEY_PREVIOUS_COMPOSITION 0x201")]
        public const int IME_ITHOTKEY_PREVIOUS_COMPOSITION = 0x201;

        [NativeTypeName("#define IME_ITHOTKEY_UISTYLE_TOGGLE 0x202")]
        public const int IME_ITHOTKEY_UISTYLE_TOGGLE = 0x202;

        [NativeTypeName("#define IME_ITHOTKEY_RECONVERTSTRING 0x203")]
        public const int IME_ITHOTKEY_RECONVERTSTRING = 0x203;

        [NativeTypeName("#define IME_HOTKEY_PRIVATE_LAST 0x21F")]
        public const int IME_HOTKEY_PRIVATE_LAST = 0x21F;

        [NativeTypeName("#define GCS_COMPREADSTR 0x0001")]
        public const int GCS_COMPREADSTR = 0x0001;

        [NativeTypeName("#define GCS_COMPREADATTR 0x0002")]
        public const int GCS_COMPREADATTR = 0x0002;

        [NativeTypeName("#define GCS_COMPREADCLAUSE 0x0004")]
        public const int GCS_COMPREADCLAUSE = 0x0004;

        [NativeTypeName("#define GCS_COMPSTR 0x0008")]
        public const int GCS_COMPSTR = 0x0008;

        [NativeTypeName("#define GCS_COMPATTR 0x0010")]
        public const int GCS_COMPATTR = 0x0010;

        [NativeTypeName("#define GCS_COMPCLAUSE 0x0020")]
        public const int GCS_COMPCLAUSE = 0x0020;

        [NativeTypeName("#define GCS_CURSORPOS 0x0080")]
        public const int GCS_CURSORPOS = 0x0080;

        [NativeTypeName("#define GCS_DELTASTART 0x0100")]
        public const int GCS_DELTASTART = 0x0100;

        [NativeTypeName("#define GCS_RESULTREADSTR 0x0200")]
        public const int GCS_RESULTREADSTR = 0x0200;

        [NativeTypeName("#define GCS_RESULTREADCLAUSE 0x0400")]
        public const int GCS_RESULTREADCLAUSE = 0x0400;

        [NativeTypeName("#define GCS_RESULTSTR 0x0800")]
        public const int GCS_RESULTSTR = 0x0800;

        [NativeTypeName("#define GCS_RESULTCLAUSE 0x1000")]
        public const int GCS_RESULTCLAUSE = 0x1000;

        [NativeTypeName("#define CS_INSERTCHAR 0x2000")]
        public const int CS_INSERTCHAR = 0x2000;

        [NativeTypeName("#define CS_NOMOVECARET 0x4000")]
        public const int CS_NOMOVECARET = 0x4000;

        [NativeTypeName("#define IMEVER_0310 0x0003000A")]
        public const int IMEVER_0310 = 0x0003000A;

        [NativeTypeName("#define IMEVER_0400 0x00040000")]
        public const int IMEVER_0400 = 0x00040000;

        [NativeTypeName("#define IME_PROP_AT_CARET 0x00010000")]
        public const int IME_PROP_AT_CARET = 0x00010000;

        [NativeTypeName("#define IME_PROP_SPECIAL_UI 0x00020000")]
        public const int IME_PROP_SPECIAL_UI = 0x00020000;

        [NativeTypeName("#define IME_PROP_CANDLIST_START_FROM_1 0x00040000")]
        public const int IME_PROP_CANDLIST_START_FROM_1 = 0x00040000;

        [NativeTypeName("#define IME_PROP_UNICODE 0x00080000")]
        public const int IME_PROP_UNICODE = 0x00080000;

        [NativeTypeName("#define IME_PROP_COMPLETE_ON_UNSELECT 0x00100000")]
        public const int IME_PROP_COMPLETE_ON_UNSELECT = 0x00100000;

        [NativeTypeName("#define UI_CAP_2700 0x00000001")]
        public const int UI_CAP_2700 = 0x00000001;

        [NativeTypeName("#define UI_CAP_ROT90 0x00000002")]
        public const int UI_CAP_ROT90 = 0x00000002;

        [NativeTypeName("#define UI_CAP_ROTANY 0x00000004")]
        public const int UI_CAP_ROTANY = 0x00000004;

        [NativeTypeName("#define SCS_CAP_COMPSTR 0x00000001")]
        public const int SCS_CAP_COMPSTR = 0x00000001;

        [NativeTypeName("#define SCS_CAP_MAKEREAD 0x00000002")]
        public const int SCS_CAP_MAKEREAD = 0x00000002;

        [NativeTypeName("#define SCS_CAP_SETRECONVERTSTRING 0x00000004")]
        public const int SCS_CAP_SETRECONVERTSTRING = 0x00000004;

        [NativeTypeName("#define SELECT_CAP_CONVERSION 0x00000001")]
        public const int SELECT_CAP_CONVERSION = 0x00000001;

        [NativeTypeName("#define SELECT_CAP_SENTENCE 0x00000002")]
        public const int SELECT_CAP_SENTENCE = 0x00000002;

        [NativeTypeName("#define GGL_LEVEL 0x00000001")]
        public const int GGL_LEVEL = 0x00000001;

        [NativeTypeName("#define GGL_INDEX 0x00000002")]
        public const int GGL_INDEX = 0x00000002;

        [NativeTypeName("#define GGL_STRING 0x00000003")]
        public const int GGL_STRING = 0x00000003;

        [NativeTypeName("#define GGL_PRIVATE 0x00000004")]
        public const int GGL_PRIVATE = 0x00000004;

        [NativeTypeName("#define GL_LEVEL_NOGUIDELINE 0x00000000")]
        public const int GL_LEVEL_NOGUIDELINE = 0x00000000;

        [NativeTypeName("#define GL_LEVEL_FATAL 0x00000001")]
        public const int GL_LEVEL_FATAL = 0x00000001;

        [NativeTypeName("#define GL_LEVEL_ERROR 0x00000002")]
        public const int GL_LEVEL_ERROR = 0x00000002;

        [NativeTypeName("#define GL_LEVEL_WARNING 0x00000003")]
        public const int GL_LEVEL_WARNING = 0x00000003;

        [NativeTypeName("#define GL_LEVEL_INFORMATION 0x00000004")]
        public const int GL_LEVEL_INFORMATION = 0x00000004;

        [NativeTypeName("#define GL_ID_UNKNOWN 0x00000000")]
        public const int GL_ID_UNKNOWN = 0x00000000;

        [NativeTypeName("#define GL_ID_NOMODULE 0x00000001")]
        public const int GL_ID_NOMODULE = 0x00000001;

        [NativeTypeName("#define GL_ID_NODICTIONARY 0x00000010")]
        public const int GL_ID_NODICTIONARY = 0x00000010;

        [NativeTypeName("#define GL_ID_CANNOTSAVE 0x00000011")]
        public const int GL_ID_CANNOTSAVE = 0x00000011;

        [NativeTypeName("#define GL_ID_NOCONVERT 0x00000020")]
        public const int GL_ID_NOCONVERT = 0x00000020;

        [NativeTypeName("#define GL_ID_TYPINGERROR 0x00000021")]
        public const int GL_ID_TYPINGERROR = 0x00000021;

        [NativeTypeName("#define GL_ID_TOOMANYSTROKE 0x00000022")]
        public const int GL_ID_TOOMANYSTROKE = 0x00000022;

        [NativeTypeName("#define GL_ID_READINGCONFLICT 0x00000023")]
        public const int GL_ID_READINGCONFLICT = 0x00000023;

        [NativeTypeName("#define GL_ID_INPUTREADING 0x00000024")]
        public const int GL_ID_INPUTREADING = 0x00000024;

        [NativeTypeName("#define GL_ID_INPUTRADICAL 0x00000025")]
        public const int GL_ID_INPUTRADICAL = 0x00000025;

        [NativeTypeName("#define GL_ID_INPUTCODE 0x00000026")]
        public const int GL_ID_INPUTCODE = 0x00000026;

        [NativeTypeName("#define GL_ID_INPUTSYMBOL 0x00000027")]
        public const int GL_ID_INPUTSYMBOL = 0x00000027;

        [NativeTypeName("#define GL_ID_CHOOSECANDIDATE 0x00000028")]
        public const int GL_ID_CHOOSECANDIDATE = 0x00000028;

        [NativeTypeName("#define GL_ID_REVERSECONVERSION 0x00000029")]
        public const int GL_ID_REVERSECONVERSION = 0x00000029;

        [NativeTypeName("#define GL_ID_PRIVATE_FIRST 0x00008000")]
        public const int GL_ID_PRIVATE_FIRST = 0x00008000;

        [NativeTypeName("#define GL_ID_PRIVATE_LAST 0x0000FFFF")]
        public const int GL_ID_PRIVATE_LAST = 0x0000FFFF;

        [NativeTypeName("#define IGP_GETIMEVERSION (DWORD)(-4)")]
        public const uint IGP_GETIMEVERSION = unchecked((uint)(-4));

        [NativeTypeName("#define IGP_PROPERTY 0x00000004")]
        public const int IGP_PROPERTY = 0x00000004;

        [NativeTypeName("#define IGP_CONVERSION 0x00000008")]
        public const int IGP_CONVERSION = 0x00000008;

        [NativeTypeName("#define IGP_SENTENCE 0x0000000c")]
        public const int IGP_SENTENCE = 0x0000000c;

        [NativeTypeName("#define IGP_UI 0x00000010")]
        public const int IGP_UI = 0x00000010;

        [NativeTypeName("#define IGP_SETCOMPSTR 0x00000014")]
        public const int IGP_SETCOMPSTR = 0x00000014;

        [NativeTypeName("#define IGP_SELECT 0x00000018")]
        public const int IGP_SELECT = 0x00000018;

        [NativeTypeName("#define SCS_SETSTR (GCS_COMPREADSTR|GCS_COMPSTR)")]
        public const int SCS_SETSTR = (0x0001 | 0x0008);

        [NativeTypeName("#define SCS_CHANGEATTR (GCS_COMPREADATTR|GCS_COMPATTR)")]
        public const int SCS_CHANGEATTR = (0x0002 | 0x0010);

        [NativeTypeName("#define SCS_CHANGECLAUSE (GCS_COMPREADCLAUSE|GCS_COMPCLAUSE)")]
        public const int SCS_CHANGECLAUSE = (0x0004 | 0x0020);

        [NativeTypeName("#define SCS_SETRECONVERTSTRING 0x00010000")]
        public const int SCS_SETRECONVERTSTRING = 0x00010000;

        [NativeTypeName("#define SCS_QUERYRECONVERTSTRING 0x00020000")]
        public const int SCS_QUERYRECONVERTSTRING = 0x00020000;

        [NativeTypeName("#define ATTR_INPUT 0x00")]
        public const int ATTR_INPUT = 0x00;

        [NativeTypeName("#define ATTR_TARGET_CONVERTED 0x01")]
        public const int ATTR_TARGET_CONVERTED = 0x01;

        [NativeTypeName("#define ATTR_CONVERTED 0x02")]
        public const int ATTR_CONVERTED = 0x02;

        [NativeTypeName("#define ATTR_TARGET_NOTCONVERTED 0x03")]
        public const int ATTR_TARGET_NOTCONVERTED = 0x03;

        [NativeTypeName("#define ATTR_INPUT_ERROR 0x04")]
        public const int ATTR_INPUT_ERROR = 0x04;

        [NativeTypeName("#define ATTR_FIXEDCONVERTED 0x05")]
        public const int ATTR_FIXEDCONVERTED = 0x05;

        [NativeTypeName("#define CFS_DEFAULT 0x0000")]
        public const int CFS_DEFAULT = 0x0000;

        [NativeTypeName("#define CFS_RECT 0x0001")]
        public const int CFS_RECT = 0x0001;

        [NativeTypeName("#define CFS_POINT 0x0002")]
        public const int CFS_POINT = 0x0002;

        [NativeTypeName("#define CFS_FORCE_POSITION 0x0020")]
        public const int CFS_FORCE_POSITION = 0x0020;

        [NativeTypeName("#define CFS_CANDIDATEPOS 0x0040")]
        public const int CFS_CANDIDATEPOS = 0x0040;

        [NativeTypeName("#define CFS_EXCLUDE 0x0080")]
        public const int CFS_EXCLUDE = 0x0080;

        [NativeTypeName("#define GCL_CONVERSION 0x0001")]
        public const int GCL_CONVERSION = 0x0001;

        [NativeTypeName("#define GCL_REVERSECONVERSION 0x0002")]
        public const int GCL_REVERSECONVERSION = 0x0002;

        [NativeTypeName("#define GCL_REVERSE_LENGTH 0x0003")]
        public const int GCL_REVERSE_LENGTH = 0x0003;

        [NativeTypeName("#define IME_CMODE_HANGEUL IME_CMODE_NATIVE")]
        public const int IME_CMODE_HANGEUL = 0x0001;

        [NativeTypeName("#define IME_CMODE_SOFTKBD 0x0080")]
        public const int IME_CMODE_SOFTKBD = 0x0080;

        [NativeTypeName("#define IME_CMODE_NOCONVERSION 0x0100")]
        public const int IME_CMODE_NOCONVERSION = 0x0100;

        [NativeTypeName("#define IME_CMODE_EUDC 0x0200")]
        public const int IME_CMODE_EUDC = 0x0200;

        [NativeTypeName("#define IME_CMODE_SYMBOL 0x0400")]
        public const int IME_CMODE_SYMBOL = 0x0400;

        [NativeTypeName("#define IME_CMODE_FIXED 0x0800")]
        public const int IME_CMODE_FIXED = 0x0800;

        [NativeTypeName("#define IME_CMODE_RESERVED 0xF0000000")]
        public const uint IME_CMODE_RESERVED = 0xF0000000;

        [NativeTypeName("#define IME_SMODE_NONE 0x0000")]
        public const int IME_SMODE_NONE = 0x0000;

        [NativeTypeName("#define IME_SMODE_PLAURALCLAUSE 0x0001")]
        public const int IME_SMODE_PLAURALCLAUSE = 0x0001;

        [NativeTypeName("#define IME_SMODE_SINGLECONVERT 0x0002")]
        public const int IME_SMODE_SINGLECONVERT = 0x0002;

        [NativeTypeName("#define IME_SMODE_AUTOMATIC 0x0004")]
        public const int IME_SMODE_AUTOMATIC = 0x0004;

        [NativeTypeName("#define IME_SMODE_PHRASEPREDICT 0x0008")]
        public const int IME_SMODE_PHRASEPREDICT = 0x0008;

        [NativeTypeName("#define IME_SMODE_CONVERSATION 0x0010")]
        public const int IME_SMODE_CONVERSATION = 0x0010;

        [NativeTypeName("#define IME_SMODE_RESERVED 0x0000F000")]
        public const int IME_SMODE_RESERVED = 0x0000F000;

        [NativeTypeName("#define IME_CAND_UNKNOWN 0x0000")]
        public const int IME_CAND_UNKNOWN = 0x0000;

        [NativeTypeName("#define IME_CAND_READ 0x0001")]
        public const int IME_CAND_READ = 0x0001;

        [NativeTypeName("#define IME_CAND_CODE 0x0002")]
        public const int IME_CAND_CODE = 0x0002;

        [NativeTypeName("#define IME_CAND_MEANING 0x0003")]
        public const int IME_CAND_MEANING = 0x0003;

        [NativeTypeName("#define IME_CAND_RADICAL 0x0004")]
        public const int IME_CAND_RADICAL = 0x0004;

        [NativeTypeName("#define IME_CAND_STROKE 0x0005")]
        public const int IME_CAND_STROKE = 0x0005;

        [NativeTypeName("#define IMN_CLOSESTATUSWINDOW 0x0001")]
        public const int IMN_CLOSESTATUSWINDOW = 0x0001;

        [NativeTypeName("#define IMN_OPENSTATUSWINDOW 0x0002")]
        public const int IMN_OPENSTATUSWINDOW = 0x0002;

        [NativeTypeName("#define IMN_CHANGECANDIDATE 0x0003")]
        public const int IMN_CHANGECANDIDATE = 0x0003;

        [NativeTypeName("#define IMN_CLOSECANDIDATE 0x0004")]
        public const int IMN_CLOSECANDIDATE = 0x0004;

        [NativeTypeName("#define IMN_OPENCANDIDATE 0x0005")]
        public const int IMN_OPENCANDIDATE = 0x0005;

        [NativeTypeName("#define IMN_SETCONVERSIONMODE 0x0006")]
        public const int IMN_SETCONVERSIONMODE = 0x0006;

        [NativeTypeName("#define IMN_SETSENTENCEMODE 0x0007")]
        public const int IMN_SETSENTENCEMODE = 0x0007;

        [NativeTypeName("#define IMN_SETOPENSTATUS 0x0008")]
        public const int IMN_SETOPENSTATUS = 0x0008;

        [NativeTypeName("#define IMN_SETCANDIDATEPOS 0x0009")]
        public const int IMN_SETCANDIDATEPOS = 0x0009;

        [NativeTypeName("#define IMN_SETCOMPOSITIONFONT 0x000A")]
        public const int IMN_SETCOMPOSITIONFONT = 0x000A;

        [NativeTypeName("#define IMN_SETCOMPOSITIONWINDOW 0x000B")]
        public const int IMN_SETCOMPOSITIONWINDOW = 0x000B;

        [NativeTypeName("#define IMN_SETSTATUSWINDOWPOS 0x000C")]
        public const int IMN_SETSTATUSWINDOWPOS = 0x000C;

        [NativeTypeName("#define IMN_GUIDELINE 0x000D")]
        public const int IMN_GUIDELINE = 0x000D;

        [NativeTypeName("#define IMN_PRIVATE 0x000E")]
        public const int IMN_PRIVATE = 0x000E;

        [NativeTypeName("#define IMR_COMPOSITIONWINDOW 0x0001")]
        public const int IMR_COMPOSITIONWINDOW = 0x0001;

        [NativeTypeName("#define IMR_CANDIDATEWINDOW 0x0002")]
        public const int IMR_CANDIDATEWINDOW = 0x0002;

        [NativeTypeName("#define IMR_COMPOSITIONFONT 0x0003")]
        public const int IMR_COMPOSITIONFONT = 0x0003;

        [NativeTypeName("#define IMR_RECONVERTSTRING 0x0004")]
        public const int IMR_RECONVERTSTRING = 0x0004;

        [NativeTypeName("#define IMR_CONFIRMRECONVERTSTRING 0x0005")]
        public const int IMR_CONFIRMRECONVERTSTRING = 0x0005;

        [NativeTypeName("#define IMR_QUERYCHARPOSITION 0x0006")]
        public const int IMR_QUERYCHARPOSITION = 0x0006;

        [NativeTypeName("#define IMR_DOCUMENTFEED 0x0007")]
        public const int IMR_DOCUMENTFEED = 0x0007;

        [NativeTypeName("#define IMM_ERROR_NODATA (-1)")]
        public const int IMM_ERROR_NODATA = (-1);

        [NativeTypeName("#define IMM_ERROR_GENERAL (-2)")]
        public const int IMM_ERROR_GENERAL = (-2);

        [NativeTypeName("#define IME_CONFIG_GENERAL 1")]
        public const int IME_CONFIG_GENERAL = 1;

        [NativeTypeName("#define IME_CONFIG_REGISTERWORD 2")]
        public const int IME_CONFIG_REGISTERWORD = 2;

        [NativeTypeName("#define IME_CONFIG_SELECTDICTIONARY 3")]
        public const int IME_CONFIG_SELECTDICTIONARY = 3;

        [NativeTypeName("#define IME_ESC_QUERY_SUPPORT 0x0003")]
        public const int IME_ESC_QUERY_SUPPORT = 0x0003;

        [NativeTypeName("#define IME_ESC_RESERVED_FIRST 0x0004")]
        public const int IME_ESC_RESERVED_FIRST = 0x0004;

        [NativeTypeName("#define IME_ESC_RESERVED_LAST 0x07FF")]
        public const int IME_ESC_RESERVED_LAST = 0x07FF;

        [NativeTypeName("#define IME_ESC_PRIVATE_FIRST 0x0800")]
        public const int IME_ESC_PRIVATE_FIRST = 0x0800;

        [NativeTypeName("#define IME_ESC_PRIVATE_LAST 0x0FFF")]
        public const int IME_ESC_PRIVATE_LAST = 0x0FFF;

        [NativeTypeName("#define IME_ESC_SEQUENCE_TO_INTERNAL 0x1001")]
        public const int IME_ESC_SEQUENCE_TO_INTERNAL = 0x1001;

        [NativeTypeName("#define IME_ESC_GET_EUDC_DICTIONARY 0x1003")]
        public const int IME_ESC_GET_EUDC_DICTIONARY = 0x1003;

        [NativeTypeName("#define IME_ESC_SET_EUDC_DICTIONARY 0x1004")]
        public const int IME_ESC_SET_EUDC_DICTIONARY = 0x1004;

        [NativeTypeName("#define IME_ESC_MAX_KEY 0x1005")]
        public const int IME_ESC_MAX_KEY = 0x1005;

        [NativeTypeName("#define IME_ESC_IME_NAME 0x1006")]
        public const int IME_ESC_IME_NAME = 0x1006;

        [NativeTypeName("#define IME_ESC_SYNC_HOTKEY 0x1007")]
        public const int IME_ESC_SYNC_HOTKEY = 0x1007;

        [NativeTypeName("#define IME_ESC_HANJA_MODE 0x1008")]
        public const int IME_ESC_HANJA_MODE = 0x1008;

        [NativeTypeName("#define IME_ESC_AUTOMATA 0x1009")]
        public const int IME_ESC_AUTOMATA = 0x1009;

        [NativeTypeName("#define IME_ESC_PRIVATE_HOTKEY 0x100a")]
        public const int IME_ESC_PRIVATE_HOTKEY = 0x100a;

        [NativeTypeName("#define IME_ESC_GETHELPFILENAME 0x100b")]
        public const int IME_ESC_GETHELPFILENAME = 0x100b;

        [NativeTypeName("#define IME_REGWORD_STYLE_EUDC 0x00000001")]
        public const int IME_REGWORD_STYLE_EUDC = 0x00000001;

        [NativeTypeName("#define IME_REGWORD_STYLE_USER_FIRST 0x80000000")]
        public const uint IME_REGWORD_STYLE_USER_FIRST = 0x80000000;

        [NativeTypeName("#define IME_REGWORD_STYLE_USER_LAST 0xFFFFFFFF")]
        public const uint IME_REGWORD_STYLE_USER_LAST = 0xFFFFFFFF;

        [NativeTypeName("#define IACE_CHILDREN 0x0001")]
        public const int IACE_CHILDREN = 0x0001;

        [NativeTypeName("#define IACE_DEFAULT 0x0010")]
        public const int IACE_DEFAULT = 0x0010;

        [NativeTypeName("#define IACE_IGNORENOCONTEXT 0x0020")]
        public const int IACE_IGNORENOCONTEXT = 0x0020;

        [NativeTypeName("#define IGIMIF_RIGHTMENU 0x0001")]
        public const int IGIMIF_RIGHTMENU = 0x0001;

        [NativeTypeName("#define IGIMII_CMODE 0x0001")]
        public const int IGIMII_CMODE = 0x0001;

        [NativeTypeName("#define IGIMII_SMODE 0x0002")]
        public const int IGIMII_SMODE = 0x0002;

        [NativeTypeName("#define IGIMII_CONFIGURE 0x0004")]
        public const int IGIMII_CONFIGURE = 0x0004;

        [NativeTypeName("#define IGIMII_TOOLS 0x0008")]
        public const int IGIMII_TOOLS = 0x0008;

        [NativeTypeName("#define IGIMII_HELP 0x0010")]
        public const int IGIMII_HELP = 0x0010;

        [NativeTypeName("#define IGIMII_OTHER 0x0020")]
        public const int IGIMII_OTHER = 0x0020;

        [NativeTypeName("#define IGIMII_INPUTTOOLS 0x0040")]
        public const int IGIMII_INPUTTOOLS = 0x0040;

        [NativeTypeName("#define IMFT_RADIOCHECK 0x00001")]
        public const int IMFT_RADIOCHECK = 0x00001;

        [NativeTypeName("#define IMFT_SEPARATOR 0x00002")]
        public const int IMFT_SEPARATOR = 0x00002;

        [NativeTypeName("#define IMFT_SUBMENU 0x00004")]
        public const int IMFT_SUBMENU = 0x00004;

        [NativeTypeName("#define IMFS_GRAYED MFS_GRAYED")]
        public const int IMFS_GRAYED = 0x00000003;

        [NativeTypeName("#define IMFS_DISABLED MFS_DISABLED")]
        public const int IMFS_DISABLED = 0x00000003;

        [NativeTypeName("#define IMFS_CHECKED MFS_CHECKED")]
        public const int IMFS_CHECKED = 0x00000008;

        [NativeTypeName("#define IMFS_HILITE MFS_HILITE")]
        public const int IMFS_HILITE = 0x00000080;

        [NativeTypeName("#define IMFS_ENABLED MFS_ENABLED")]
        public const int IMFS_ENABLED = 0x00000000;

        [NativeTypeName("#define IMFS_UNCHECKED MFS_UNCHECKED")]
        public const int IMFS_UNCHECKED = 0x00000000;

        [NativeTypeName("#define IMFS_UNHILITE MFS_UNHILITE")]
        public const int IMFS_UNHILITE = 0x00000000;

        [NativeTypeName("#define IMFS_DEFAULT MFS_DEFAULT")]
        public const int IMFS_DEFAULT = 0x00001000;

        [NativeTypeName("#define SOFTKEYBOARD_TYPE_T1 0x0001")]
        public const int SOFTKEYBOARD_TYPE_T1 = 0x0001;

        [NativeTypeName("#define SOFTKEYBOARD_TYPE_C1 0x0002")]
        public const int SOFTKEYBOARD_TYPE_C1 = 0x0002;
    }
}
