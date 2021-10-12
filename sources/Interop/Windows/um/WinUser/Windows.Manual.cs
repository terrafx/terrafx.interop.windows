// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int WH_HARDWARE = 8;

        public const int OBM_CLOSE = 32754;

        public const int OBM_UPARROW = 32753;

        public const int OBM_DNARROW = 32752;

        public const int OBM_RGARROW = 32751;

        public const int OBM_LFARROW = 32750;

        public const int OBM_REDUCE = 32749;

        public const int OBM_ZOOM = 32748;

        public const int OBM_RESTORE = 32747;

        public const int OBM_REDUCED = 32746;

        public const int OBM_ZOOMD = 32745;

        public const int OBM_RESTORED = 32744;

        public const int OBM_UPARROWD = 32743;

        public const int OBM_DNARROWD = 32742;

        public const int OBM_RGARROWD = 32741;

        public const int OBM_LFARROWD = 32740;

        public const int OBM_MNARROW = 32739;

        public const int OBM_COMBO = 32738;

        public const int OBM_UPARROWI = 32737;

        public const int OBM_DNARROWI = 32736;

        public const int OBM_RGARROWI = 32735;

        public const int OBM_LFARROWI = 32734;

        public const int OBM_OLD_CLOSE = 32767;

        public const int OBM_SIZE = 32766;

        public const int OBM_OLD_UPARROW = 32765;

        public const int OBM_OLD_DNARROW = 32764;

        public const int OBM_OLD_RGARROW = 32763;

        public const int OBM_OLD_LFARROW = 32762;

        public const int OBM_BTSIZE = 32761;

        public const int OBM_CHECK = 32760;

        public const int OBM_CHECKBOXES = 32759;

        public const int OBM_BTNCORNERS = 32758;

        public const int OBM_OLD_REDUCE = 32757;

        public const int OBM_OLD_ZOOM = 32756;

        public const int OBM_OLD_RESTORE = 32755;

        public const int OCR_NORMAL = 32512;

        public const int OCR_IBEAM = 32513;

        public const int OCR_WAIT = 32514;

        public const int OCR_CROSS = 32515;

        public const int OCR_UP = 32516;

        [Obsolete("use OCR_SIZEALL")]
        public const int OCR_SIZE = 32640;

        [Obsolete("use OCR_NORMAL")]
        public const int OCR_ICON = 32641;

        public const int OCR_SIZENWSE = 32642;

        public const int OCR_SIZENESW = 32643;

        public const int OCR_SIZEWE = 32644;

        public const int OCR_SIZENS = 32645;

        public const int OCR_SIZEALL = 32646;

        [Obsolete("use OIC_WINLOGO")]
        public const int OCR_ICOCUR = 32647;

        public const int OCR_NO = 32648;

        public const int OCR_HAND = 32649;

        public const int OCR_APPSTARTING = 32650;

        public const int OIC_SAMPLE = 32512;

        public const int OIC_HAND = 32513;

        public const int OIC_QUES = 32514;

        public const int OIC_BANG = 32515;

        public const int OIC_NOTE = 32516;

        public const int OIC_WINLOGO = 32517;

        public const int OIC_WARNING = OIC_BANG;

        public const int OIC_ERROR = OIC_HAND;

        public const int OIC_INFORMATION = OIC_NOTE;

        public const int OIC_SHIELD = 32518;

        public const int DS_USEPIXELS = 0x8000;

        public const int LB_MULTIPLEADDSTRING = 0x01B1;

        public const int CB_MULTIPLEADDSTRING = 0x0163;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_INTRESOURCE([NativeTypeName("ULONG_PTR")] nuint _r)
        {
            return (_r >> 16) == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LPWSTR")]
        public static ushort* MAKEINTRESOURCE(ushort i) => (ushort*)(nuint)i;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static POINT POINTSTOPOINT(POINTS pts)
        {
            return new POINT {
                x = (short)LOWORD(*(uint*)&pts),
                y = (short)HIWORD(*(uint*)&pts),
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int POINTTOPOINTS(POINTS pt) => MAKELONG((ushort)pt.x, (ushort)pt.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("WPARAM")]
        public static nuint MAKEWPARAM(ushort l, ushort h) => (nuint)MAKELONG(l, h);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LPARAM")]
        public static nint MAKELPARAM(ushort l, ushort h) => MAKELONG(l, h);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LRESULT")]
        public static nint MAKELRESULT(ushort l, ushort h) => MAKELONG(l, h);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short GET_APPCOMMAND_LPARAM([NativeTypeName("LPARAM")] nint lParam) => unchecked((short)(HIWORD((uint)lParam) & ~FAPPCOMMAND_MASK));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_DEVICE_LPARAM([NativeTypeName("LPARAM")] nint lParam) => unchecked((ushort)(HIWORD((uint)lParam) & FAPPCOMMAND_MASK));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_MOUSEORKEY_LPARAM([NativeTypeName("LPARAM")] nint lParam) => GET_DEVICE_LPARAM(lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_FLAGS_LPARAM([NativeTypeName("LPARAM")] nint lParam) => LOWORD(unchecked((uint)lParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_KEYSTATE_LPARAM([NativeTypeName("LPARAM")] nint lParam) => GET_FLAGS_LPARAM(lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short GET_WHEEL_DELTA_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => unchecked((short)HIWORD((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_KEYSTATE_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => LOWORD(unchecked((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short GET_NCHITTEST_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => unchecked((short)LOWORD((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_XBUTTON_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => HIWORD(unchecked((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public static int ExitWindows(uint dwReserved, int Code) => ExitWindowsEx(EWX_LOGOFF, 0xFFFFFFFF);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public static int PostAppMessageA([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam) => PostThreadMessageA(idThread, wMsg, wParam, lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public static int PostAppMessageW([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam) => PostThreadMessageW(idThread, wMsg, wParam, lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr CreateWindowA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int x, int y, int nWidth, int nHeight, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPVOID")] void* lpParam) => CreateWindowExA(0, lpClassName, lpWindowName, dwStyle, x, y,nWidth, nHeight, hWndParent, hMenu, hInstance, lpParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr CreateWindowW([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int x, int y, int nWidth, int nHeight, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPVOID")] void* lpParam) => CreateWindowExW(0, lpClassName, lpWindowName, dwStyle, x, y, nWidth, nHeight, hWndParent, hMenu, hInstance, lpParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr CreateDialogA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc) => CreateDialogParamA(hInstance, lpName, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr CreateDialogW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc) => CreateDialogParamW(hInstance, lpName, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr CreateDialogIndirectA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc) => CreateDialogIndirectParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr CreateDialogIndirectW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc) => CreateDialogIndirectParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("INT_PTR")]
        public static IntPtr DialogBoxA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc) => DialogBoxParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("INT_PTR")]
        public static IntPtr DialogBoxW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc) => DialogBoxParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("INT_PTR")]
        public static IntPtr DialogBoxIndirectA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEA")] DLGTEMPLATE* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc) => DialogBoxIndirectParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("INT_PTR")]
        public static IntPtr DialogBoxIndirectW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc) => DialogBoxIndirectParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int TOUCH_COORD_TO_PIXEL(int l) => l / 100;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_POINTERID_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => LOWORD(unchecked((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_FLAG_SET_WPARAM([NativeTypeName("WPARAM")] nuint wParam, uint flag) => (HIWORD(unchecked((uint)wParam)) & flag) == flag;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_NEW_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_NEW);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_INRANGE_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_INRANGE);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_INCONTACT_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_INCONTACT);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_FIRSTBUTTON_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_FIRSTBUTTON);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_SECONDBUTTON_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_SECONDBUTTON);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_THIRDBUTTON_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_THIRDBUTTON);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_FOURTHBUTTON_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_FOURTHBUTTON);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_FIFTHBUTTON_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_FIFTHBUTTON);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_PRIMARY_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_PRIMARY);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HAS_POINTER_CONFIDENCE_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_CONFIDENCE);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_CANCELED_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_CANCELED);

        [NativeTypeName("#define GetWindowLongPtr GetWindowLongPtrW")]
        public static delegate*<IntPtr, int, nint> GetWindowLongPtr => &GetWindowLongPtrW;

        [return: NativeTypeName("LONG_PTR")]
        public static nint GetWindowLongPtrA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex)
        {
            if (sizeof(nint) == 4)
            {
                return GetWindowLongA(hWnd, nIndex);
            }
            else
            {
                [DllImport("user32", EntryPoint = "GetWindowLongPtrA", ExactSpelling = true)]
                [return: NativeTypeName("LONG_PTR")]
                static extern nint _GetWindowLongPtrA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

                return _GetWindowLongPtrA(hWnd, nIndex);
            }
        }

        [return: NativeTypeName("LONG_PTR")]
        public static nint GetWindowLongPtrW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex)
        {
            if (sizeof(nint) == 4)
            {
                return GetWindowLongW(hWnd, nIndex);
            }
            else
            {
                [DllImport("user32", EntryPoint = "GetWindowLongPtrW", ExactSpelling = true)]
                [return: NativeTypeName("LONG_PTR")]
                static extern nint _GetWindowLongPtrW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

                return _GetWindowLongPtrW(hWnd, nIndex);
            }
        }

        [NativeTypeName("#define SetWindowLongPtr SetWindowLongPtrW")]
        public static delegate*<IntPtr, int, nint, nint> SetWindowLongPtr => &SetWindowLongPtrW;

        [return: NativeTypeName("LONG_PTR")]
        public static nint SetWindowLongPtrA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong)
        {
            if (sizeof(nint) == 4)
            {
                return SetWindowLongA(hWnd, nIndex, (int)dwNewLong);
            }
            else
            {
                [DllImport("user32", EntryPoint = "SetWindowLongPtrA", ExactSpelling = true)]
                [return: NativeTypeName("LONG_PTR")]
                static extern nint _SetWindowLongPtrA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

                return _SetWindowLongPtrA(hWnd, nIndex, dwNewLong);
            }
        }

        [return: NativeTypeName("LONG_PTR")]
        public static nint SetWindowLongPtrW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong)
        {
            if (sizeof(nint) == 4)
            {
                return SetWindowLongW(hWnd, nIndex, (int)dwNewLong);
            }
            else
            {
                [DllImport("user32", EntryPoint = "SetWindowLongPtrW", ExactSpelling = true)]
                [return: NativeTypeName("LONG_PTR")]
                static extern nint _SetWindowLongPtrW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

                return _SetWindowLongPtrW(hWnd, nIndex, dwNewLong);
            }
        }

        [NativeTypeName("#define GetClassLongPtr GetClassLongPtrW")]
        public static delegate*<IntPtr, int, nuint> GetClassLongPtr => &GetClassLongPtrW;

        [return: NativeTypeName("ULONG_PTR")]
        public static nuint GetClassLongPtrA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex)
        {
            if (sizeof(nuint) == 4)
            {
                return GetClassLongA(hWnd, nIndex);
            }
            else
            {
                [DllImport("user32", EntryPoint = "GetClassLongPtrA", ExactSpelling = true)]
                [return: NativeTypeName("ULONG_PTR")]
                static extern nuint _GetClassLongPtrA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

                return _GetClassLongPtrA(hWnd, nIndex);
            }
        }

        [return: NativeTypeName("ULONG_PTR")]
        public static nuint GetClassLongPtrW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex)
        {
            if (sizeof(nuint) == 4)
            {
                return GetClassLongW(hWnd, nIndex);
            }
            else
            {
                [DllImport("user32", EntryPoint = "GetClassLongPtrW", ExactSpelling = true)]
                [return: NativeTypeName("ULONG_PTR")]
                static extern nuint _GetClassLongPtrW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

                return _GetClassLongPtrW(hWnd, nIndex);
            }
        }

        [NativeTypeName("#define SetClassLongPtr SetClassLongPtrW")]
        public static delegate*<IntPtr, int, nint, nuint> SetClassLongPtr => &SetClassLongPtrW;

        [return: NativeTypeName("ULONG_PTR")]
        public static nuint SetClassLongPtrA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong)
        {
            if (sizeof(nuint) == 4)
            {
                return SetClassLongA(hWnd, nIndex, (int)dwNewLong);
            }
            else
            {
                [DllImport("user32", EntryPoint = "SetClassLongPtrA", ExactSpelling = true)]
                [return: NativeTypeName("ULONG_PTR")]
                static extern nuint _SetClassLongPtrA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

                return _SetClassLongPtrA(hWnd, nIndex, dwNewLong);
            }
        }

        [return: NativeTypeName("ULONG_PTR")]
        public static nuint SetClassLongPtrW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong)
        {
            if (sizeof(nuint) == 4)
            {
                return SetClassLongW(hWnd, nIndex, (int)dwNewLong);
            }
            else
            {
                [DllImport("user32", EntryPoint = "SetClassLongPtrW", ExactSpelling = true)]
                [return: NativeTypeName("ULONG_PTR")]
                static extern nuint _SetClassLongPtrW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

                return _SetClassLongPtrW(hWnd, nIndex, dwNewLong);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public static int EnumTaskWindows(IntPtr hTask, [NativeTypeName("WNDENUMPROC")] delegate* unmanaged<IntPtr, nint, int> lpfn, [NativeTypeName("LPARAM")] nint lParam) => EnumThreadWindows((uint)hTask, lpfn, lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr GetNextWindow([NativeTypeName("HWND")] IntPtr hWnd, ushort wCmd) => GetWindow(hWnd, wCmd);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr GetSysModalWindow() => IntPtr.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr SetSysModalWindow([NativeTypeName("HWND")] IntPtr hWnd) => IntPtr.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HANDLE")]
        public static void* GetWindowTask([NativeTypeName("HWND")] IntPtr hWnd) => (void*)(nuint)GetWindowThreadProcessId(hWnd, null);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LRESULT")]
        public static IntPtr DefHookProc(int nCode, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("HHOOK")] IntPtr* phhk) => CallNextHookEx(*phhk, nCode, wParam, lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GET_SC_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => unchecked((int)(wParam & 0xFFF0));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint GET_RAWINPUT_CODE_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => wParam & 0xFF;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint RAWINPUT_ALIGN(nint x) => (x + sizeof(nint) - 1) & ~(sizeof(nint) - 1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RAWINPUT* NEXTRAWINPUTBLOCK(RAWINPUT* ptr) => (RAWINPUT*)(RAWINPUT_ALIGN((nint)ptr) + ptr->header.dwSize);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RIDEV_EXMODE(int mode) => mode & RIDEV_EXMODEMASK;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_DEVICE_CHANGE_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => LOWORD(unchecked((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_DEVICE_CHANGE_LPARAM([NativeTypeName("LPARAM")] nint lParam) => LOWORD(unchecked((uint)lParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GID_ROTATE_ANGLE_TO_ARGUMENT(ushort _arg_) => (ushort)((_arg_ + (2.0 * 3.14159265)) / (4.0 * 3.14159265) * 65535.0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double GID_ROTATE_ANGLE_FROM_ARGUMENT(double  _arg_) => (_arg_ / 65535.0 * 4.0 * 3.14159265) - (2.0 * 3.14159265);
    }
}
