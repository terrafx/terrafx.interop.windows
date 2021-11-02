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
        public static int CONSOLE_APPLICATION_16BIT
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return 0x0001;
                }
                else
                {
                    return 0x0000;
                }
            }
        }

        public static int GUI_16BITTASK
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return 0x00000020;
                }
                else
                {
                    return 0x00000000;
                }
            }
        }

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
        public static WPARAM MAKEWPARAM(ushort l, ushort h) => (nuint)MAKELONG(l, h);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LPARAM MAKELPARAM(ushort l, ushort h) => MAKELONG(l, h);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LRESULT MAKELRESULT(ushort l, ushort h) => MAKELONG(l, h);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short GET_APPCOMMAND_LPARAM(LPARAM lParam) => unchecked((short)(HIWORD((uint)lParam) & ~FAPPCOMMAND_MASK));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_DEVICE_LPARAM(LPARAM lParam) => unchecked((ushort)(HIWORD((uint)lParam) & FAPPCOMMAND_MASK));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_MOUSEORKEY_LPARAM(LPARAM lParam) => GET_DEVICE_LPARAM(lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_FLAGS_LPARAM(LPARAM lParam) => LOWORD(unchecked((uint)lParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_KEYSTATE_LPARAM(LPARAM lParam) => GET_FLAGS_LPARAM(lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short GET_WHEEL_DELTA_WPARAM(WPARAM wParam) => unchecked((short)HIWORD((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_KEYSTATE_WPARAM(WPARAM wParam) => LOWORD(unchecked((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short GET_NCHITTEST_WPARAM(WPARAM wParam) => unchecked((short)LOWORD((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_XBUTTON_WPARAM(WPARAM wParam) => HIWORD(unchecked((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BOOL ExitWindows(uint dwReserved, int Code) => ExitWindowsEx(EWX_LOGOFF, 0xFFFFFFFF);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BOOL PostAppMessageA([NativeTypeName("DWORD")] uint idThread, uint wMsg, WPARAM wParam, LPARAM lParam) => PostThreadMessageA(idThread, wMsg, wParam, lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BOOL PostAppMessageW([NativeTypeName("DWORD")] uint idThread, uint wMsg, WPARAM wParam, LPARAM lParam) => PostThreadMessageW(idThread, wMsg, wParam, lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static HWND CreateWindowA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int x, int y, int nWidth, int nHeight, HWND hWndParent, HMENU hMenu, HINSTANCE hInstance, [NativeTypeName("LPVOID")] void* lpParam) => CreateWindowExA(0, lpClassName, lpWindowName, dwStyle, x, y,nWidth, nHeight, hWndParent, hMenu, hInstance, lpParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static HWND CreateWindowW([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int x, int y, int nWidth, int nHeight, HWND hWndParent, HMENU hMenu, HINSTANCE hInstance, [NativeTypeName("LPVOID")] void* lpParam) => CreateWindowExW(0, lpClassName, lpWindowName, dwStyle, x, y, nWidth, nHeight, hWndParent, hMenu, hInstance, lpParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static HWND CreateDialogA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpName, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc) => CreateDialogParamA(hInstance, lpName, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static HWND CreateDialogW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpName, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc) => CreateDialogParamW(hInstance, lpName, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static HWND CreateDialogIndirectA(HINSTANCE hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc) => CreateDialogIndirectParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static HWND CreateDialogIndirectW(HINSTANCE hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc) => CreateDialogIndirectParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("INT_PTR")]
        public static IntPtr DialogBoxA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc) => DialogBoxParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("INT_PTR")]
        public static IntPtr DialogBoxW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc) => DialogBoxParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("INT_PTR")]
        public static IntPtr DialogBoxIndirectA(HINSTANCE hInstance, [NativeTypeName("LPCDLGTEMPLATEA")] DLGTEMPLATE* lpTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc) => DialogBoxIndirectParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("INT_PTR")]
        public static IntPtr DialogBoxIndirectW(HINSTANCE hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc) => DialogBoxIndirectParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int TOUCH_COORD_TO_PIXEL(int l) => l / 100;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_POINTERID_WPARAM(WPARAM wParam) => LOWORD(unchecked((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_FLAG_SET_WPARAM(WPARAM wParam, uint flag) => (HIWORD(unchecked((uint)wParam)) & flag) == flag;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_NEW_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_NEW);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_INRANGE_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_INRANGE);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_INCONTACT_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_INCONTACT);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_FIRSTBUTTON_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_FIRSTBUTTON);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_SECONDBUTTON_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_SECONDBUTTON);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_THIRDBUTTON_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_THIRDBUTTON);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_FOURTHBUTTON_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_FOURTHBUTTON);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_FIFTHBUTTON_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_FIFTHBUTTON);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_PRIMARY_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_PRIMARY);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HAS_POINTER_CONFIDENCE_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_CONFIDENCE);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_CANCELED_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_CANCELED);

        [NativeTypeName("#define GetWindowLongPtr GetWindowLongPtrW")]
        public static delegate*<HWND, int, nint> GetWindowLongPtr => &GetWindowLongPtrW;

        [return: NativeTypeName("LONG_PTR")]
        public static nint GetWindowLongPtrA(HWND hWnd, int nIndex)
        {
            if (sizeof(nint) == 4)
            {
                return GetWindowLongA(hWnd, nIndex);
            }
            else
            {
                [DllImport("user32", EntryPoint = "GetWindowLongPtrA", ExactSpelling = true)]
                [return: NativeTypeName("LONG_PTR")]
                static extern nint _GetWindowLongPtrA(HWND hWnd, int nIndex);

                return _GetWindowLongPtrA(hWnd, nIndex);
            }
        }

        [return: NativeTypeName("LONG_PTR")]
        public static nint GetWindowLongPtrW(HWND hWnd, int nIndex)
        {
            if (sizeof(nint) == 4)
            {
                return GetWindowLongW(hWnd, nIndex);
            }
            else
            {
                [DllImport("user32", EntryPoint = "GetWindowLongPtrW", ExactSpelling = true)]
                [return: NativeTypeName("LONG_PTR")]
                static extern nint _GetWindowLongPtrW(HWND hWnd, int nIndex);

                return _GetWindowLongPtrW(hWnd, nIndex);
            }
        }

        [NativeTypeName("#define SetWindowLongPtr SetWindowLongPtrW")]
        public static delegate*<HWND, int, nint, nint> SetWindowLongPtr => &SetWindowLongPtrW;

        [return: NativeTypeName("LONG_PTR")]
        public static nint SetWindowLongPtrA(HWND hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong)
        {
            if (sizeof(nint) == 4)
            {
                return SetWindowLongA(hWnd, nIndex, (int)dwNewLong);
            }
            else
            {
                [DllImport("user32", EntryPoint = "SetWindowLongPtrA", ExactSpelling = true)]
                [return: NativeTypeName("LONG_PTR")]
                static extern nint _SetWindowLongPtrA(HWND hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

                return _SetWindowLongPtrA(hWnd, nIndex, dwNewLong);
            }
        }

        [return: NativeTypeName("LONG_PTR")]
        public static nint SetWindowLongPtrW(HWND hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong)
        {
            if (sizeof(nint) == 4)
            {
                return SetWindowLongW(hWnd, nIndex, (int)dwNewLong);
            }
            else
            {
                [DllImport("user32", EntryPoint = "SetWindowLongPtrW", ExactSpelling = true)]
                [return: NativeTypeName("LONG_PTR")]
                static extern nint _SetWindowLongPtrW(HWND hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

                return _SetWindowLongPtrW(hWnd, nIndex, dwNewLong);
            }
        }

        [NativeTypeName("#define GetClassLongPtr GetClassLongPtrW")]
        public static delegate*<HWND, int, nuint> GetClassLongPtr => &GetClassLongPtrW;

        [return: NativeTypeName("ULONG_PTR")]
        public static nuint GetClassLongPtrA(HWND hWnd, int nIndex)
        {
            if (sizeof(nuint) == 4)
            {
                return GetClassLongA(hWnd, nIndex);
            }
            else
            {
                [DllImport("user32", EntryPoint = "GetClassLongPtrA", ExactSpelling = true)]
                [return: NativeTypeName("ULONG_PTR")]
                static extern nuint _GetClassLongPtrA(HWND hWnd, int nIndex);

                return _GetClassLongPtrA(hWnd, nIndex);
            }
        }

        [return: NativeTypeName("ULONG_PTR")]
        public static nuint GetClassLongPtrW(HWND hWnd, int nIndex)
        {
            if (sizeof(nuint) == 4)
            {
                return GetClassLongW(hWnd, nIndex);
            }
            else
            {
                [DllImport("user32", EntryPoint = "GetClassLongPtrW", ExactSpelling = true)]
                [return: NativeTypeName("ULONG_PTR")]
                static extern nuint _GetClassLongPtrW(HWND hWnd, int nIndex);

                return _GetClassLongPtrW(hWnd, nIndex);
            }
        }

        [NativeTypeName("#define SetClassLongPtr SetClassLongPtrW")]
        public static delegate*<HWND, int, nint, nuint> SetClassLongPtr => &SetClassLongPtrW;

        [return: NativeTypeName("ULONG_PTR")]
        public static nuint SetClassLongPtrA(HWND hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong)
        {
            if (sizeof(nuint) == 4)
            {
                return SetClassLongA(hWnd, nIndex, (int)dwNewLong);
            }
            else
            {
                [DllImport("user32", EntryPoint = "SetClassLongPtrA", ExactSpelling = true)]
                [return: NativeTypeName("ULONG_PTR")]
                static extern nuint _SetClassLongPtrA(HWND hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

                return _SetClassLongPtrA(hWnd, nIndex, dwNewLong);
            }
        }

        [return: NativeTypeName("ULONG_PTR")]
        public static nuint SetClassLongPtrW(HWND hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong)
        {
            if (sizeof(nuint) == 4)
            {
                return SetClassLongW(hWnd, nIndex, (int)dwNewLong);
            }
            else
            {
                [DllImport("user32", EntryPoint = "SetClassLongPtrW", ExactSpelling = true)]
                [return: NativeTypeName("ULONG_PTR")]
                static extern nuint _SetClassLongPtrW(HWND hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

                return _SetClassLongPtrW(hWnd, nIndex, dwNewLong);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BOOL EnumTaskWindows(IntPtr hTask, [NativeTypeName("WNDENUMPROC")] delegate* unmanaged<HWND, LPARAM, BOOL> lpfn, LPARAM lParam) => EnumThreadWindows((uint)hTask, lpfn, lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static HWND GetNextWindow(HWND hWnd, ushort wCmd) => GetWindow(hWnd, wCmd);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static HWND GetSysModalWindow() => (HWND)(NULL);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static HWND SetSysModalWindow(HWND hWnd) => (HWND)(NULL);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static HANDLE GetWindowTask(HWND hWnd) => (HANDLE)GetWindowThreadProcessId(hWnd, null);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LRESULT DefHookProc(int nCode, WPARAM wParam, LPARAM lParam, HHOOK phhk) => CallNextHookEx(phhk, nCode, wParam, lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GET_SC_WPARAM(WPARAM wParam) => unchecked((int)(wParam & 0xFFF0));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint GET_RAWINPUT_CODE_WPARAM(WPARAM wParam) => wParam & (nuint)(0xFFu);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint RAWINPUT_ALIGN(nint x) => (x + sizeof(nint) - 1) & ~(sizeof(nint) - 1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RAWINPUT* NEXTRAWINPUTBLOCK(RAWINPUT* ptr) => (RAWINPUT*)(RAWINPUT_ALIGN((nint)ptr) + ptr->header.dwSize);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RIDEV_EXMODE(int mode) => mode & RIDEV_EXMODEMASK;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_DEVICE_CHANGE_WPARAM(WPARAM wParam) => LOWORD(unchecked((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_DEVICE_CHANGE_LPARAM(LPARAM lParam) => LOWORD(unchecked((uint)lParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GID_ROTATE_ANGLE_TO_ARGUMENT(ushort _arg_) => (ushort)((_arg_ + (2.0 * 3.14159265)) / (4.0 * 3.14159265) * 65535.0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double GID_ROTATE_ANGLE_FROM_ARGUMENT(double _arg_) => (_arg_ / 65535.0 * 4.0 * 3.14159265) - (2.0 * 3.14159265);

        [NativeTypeName("#define HWND_BROADCAST ((HWND)0xffff)")]
        public static HWND HWND_BROADCAST => ((HWND)(0xffff));

        [NativeTypeName("#define HWND_MESSAGE ((HWND)-3)")]
        public static HWND HWND_MESSAGE => ((HWND)(-3));

        [NativeTypeName("#define HWND_DESKTOP ((HWND)0)")]
        public static HWND HWND_DESKTOP => ((HWND)(0));

        [NativeTypeName("#define HWND_TOP ((HWND)0)")]
        public static HWND HWND_TOP => ((HWND)(0));

        [NativeTypeName("#define HWND_BOTTOM ((HWND)1)")]
        public static HWND HWND_BOTTOM => ((HWND)(1));

        [NativeTypeName("#define HWND_TOPMOST ((HWND)-1)")]
        public static HWND HWND_TOPMOST => ((HWND)(-1));

        [NativeTypeName("#define HWND_NOTOPMOST ((HWND)-2)")]
        public static HWND HWND_NOTOPMOST => ((HWND)(-2));

        [NativeTypeName("#define HBMMENU_CALLBACK ((HBITMAP) -1)")]
        public static HBITMAP HBMMENU_CALLBACK => ((HBITMAP)(-1));

        [NativeTypeName("#define HBMMENU_SYSTEM ((HBITMAP)  1)")]
        public static HBITMAP HBMMENU_SYSTEM => ((HBITMAP)(1));

        [NativeTypeName("#define HBMMENU_MBAR_RESTORE ((HBITMAP)  2)")]
        public static HBITMAP HBMMENU_MBAR_RESTORE => ((HBITMAP)(2));

        [NativeTypeName("#define HBMMENU_MBAR_MINIMIZE ((HBITMAP)  3)")]
        public static HBITMAP HBMMENU_MBAR_MINIMIZE => ((HBITMAP)(3));

        [NativeTypeName("#define HBMMENU_MBAR_CLOSE ((HBITMAP)  5)")]
        public static HBITMAP HBMMENU_MBAR_CLOSE => ((HBITMAP)(5));

        [NativeTypeName("#define HBMMENU_MBAR_CLOSE_D ((HBITMAP)  6)")]
        public static HBITMAP HBMMENU_MBAR_CLOSE_D => ((HBITMAP)(6));

        [NativeTypeName("#define HBMMENU_MBAR_MINIMIZE_D ((HBITMAP)  7)")]
        public static HBITMAP HBMMENU_MBAR_MINIMIZE_D => ((HBITMAP)(7));

        [NativeTypeName("#define HBMMENU_POPUP_CLOSE ((HBITMAP)  8)")]
        public static HBITMAP HBMMENU_POPUP_CLOSE => ((HBITMAP)(8));

        [NativeTypeName("#define HBMMENU_POPUP_RESTORE ((HBITMAP)  9)")]
        public static HBITMAP HBMMENU_POPUP_RESTORE => ((HBITMAP)(9));

        [NativeTypeName("#define HBMMENU_POPUP_MAXIMIZE ((HBITMAP) 10)")]
        public static HBITMAP HBMMENU_POPUP_MAXIMIZE => ((HBITMAP)(10));

        [NativeTypeName("#define HBMMENU_POPUP_MINIMIZE ((HBITMAP) 11)")]
        public static HBITMAP HBMMENU_POPUP_MINIMIZE => ((HBITMAP)(11));

        [NativeTypeName("#define GR_GLOBAL ((HANDLE)-2)")]
        public static HANDLE GR_GLOBAL => ((HANDLE)(-2));
    }
}
