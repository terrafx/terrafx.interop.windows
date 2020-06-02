// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("user32", EntryPoint = "wvsprintfA", ExactSpelling = true)]
        public static extern int wvsprintfA([NativeTypeName("LPSTR")] sbyte* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("va_list")] sbyte* arglist);

        [DllImport("user32", EntryPoint = "wvsprintfW", ExactSpelling = true)]
        public static extern int wvsprintfW([NativeTypeName("LPWSTR")] ushort* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("va_list")] sbyte* arglist);

        [DllImport("user32", EntryPoint = "wsprintfA", ExactSpelling = true)]
        public static extern int wsprintfA([NativeTypeName("LPSTR")] sbyte* param0, [NativeTypeName("LPCSTR")] sbyte* param1);

        [DllImport("user32", EntryPoint = "wsprintfW", ExactSpelling = true)]
        public static extern int wsprintfW([NativeTypeName("LPWSTR")] ushort* param0, [NativeTypeName("LPCWSTR")] ushort* param1);

        [DllImport("user32", EntryPoint = "LoadKeyboardLayoutA", ExactSpelling = true)]
        [return: NativeTypeName("HKL")]
        public static extern IntPtr LoadKeyboardLayoutA([NativeTypeName("LPCSTR")] sbyte* pwszKLID, [NativeTypeName("UINT")] uint Flags);

        [DllImport("user32", EntryPoint = "LoadKeyboardLayoutW", ExactSpelling = true)]
        [return: NativeTypeName("HKL")]
        public static extern IntPtr LoadKeyboardLayoutW([NativeTypeName("LPCWSTR")] ushort* pwszKLID, [NativeTypeName("UINT")] uint Flags);

        [DllImport("user32", EntryPoint = "ActivateKeyboardLayout", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HKL")]
        public static extern IntPtr ActivateKeyboardLayout([NativeTypeName("HKL")] IntPtr hkl, [NativeTypeName("UINT")] uint Flags);

        [DllImport("user32", EntryPoint = "ToUnicodeEx", ExactSpelling = true)]
        public static extern int ToUnicodeEx([NativeTypeName("UINT")] uint wVirtKey, [NativeTypeName("UINT")] uint wScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWSTR")] ushort* pwszBuff, int cchBuff, [NativeTypeName("UINT")] uint wFlags, [NativeTypeName("HKL")] IntPtr dwhkl);

        [DllImport("user32", EntryPoint = "UnloadKeyboardLayout", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnloadKeyboardLayout([NativeTypeName("HKL")] IntPtr hkl);

        [DllImport("user32", EntryPoint = "GetKeyboardLayoutNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetKeyboardLayoutNameA([NativeTypeName("LPSTR")] sbyte* pwszKLID);

        [DllImport("user32", EntryPoint = "GetKeyboardLayoutNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetKeyboardLayoutNameW([NativeTypeName("LPWSTR")] ushort* pwszKLID);

        [DllImport("user32", EntryPoint = "GetKeyboardLayoutList", ExactSpelling = true, SetLastError = true)]
        public static extern int GetKeyboardLayoutList(int nBuff, [NativeTypeName("HKL *")] IntPtr* lpList);

        [DllImport("user32", EntryPoint = "GetKeyboardLayout", ExactSpelling = true)]
        [return: NativeTypeName("HKL")]
        public static extern IntPtr GetKeyboardLayout([NativeTypeName("DWORD")] uint idThread);

        [DllImport("user32", EntryPoint = "GetMouseMovePointsEx", ExactSpelling = true, SetLastError = true)]
        public static extern int GetMouseMovePointsEx([NativeTypeName("UINT")] uint cbSize, [NativeTypeName("LPMOUSEMOVEPOINT")] MOUSEMOVEPOINT* lppt, [NativeTypeName("LPMOUSEMOVEPOINT")] MOUSEMOVEPOINT* lpptBuf, int nBufPoints, [NativeTypeName("DWORD")] uint resolution);

        [DllImport("user32", EntryPoint = "CreateDesktopA", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr CreateDesktopA([NativeTypeName("LPCSTR")] sbyte* lpszDesktop, [NativeTypeName("LPCSTR")] sbyte* lpszDevice, [NativeTypeName("DEVMODEA *")] DEVMODEA* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);

        [DllImport("user32", EntryPoint = "CreateDesktopW", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr CreateDesktopW([NativeTypeName("LPCWSTR")] ushort* lpszDesktop, [NativeTypeName("LPCWSTR")] ushort* lpszDevice, [NativeTypeName("DEVMODEW *")] DEVMODEW* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);

        [DllImport("user32", EntryPoint = "CreateDesktopExA", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr CreateDesktopExA([NativeTypeName("LPCSTR")] sbyte* lpszDesktop, [NativeTypeName("LPCSTR")] sbyte* lpszDevice, [NativeTypeName("DEVMODEA *")] DEVMODEA* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa, [NativeTypeName("ULONG")] uint ulHeapSize, [NativeTypeName("PVOID")] void* pvoid);

        [DllImport("user32", EntryPoint = "CreateDesktopExW", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr CreateDesktopExW([NativeTypeName("LPCWSTR")] ushort* lpszDesktop, [NativeTypeName("LPCWSTR")] ushort* lpszDevice, [NativeTypeName("DEVMODEW *")] DEVMODEW* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa, [NativeTypeName("ULONG")] uint ulHeapSize, [NativeTypeName("PVOID")] void* pvoid);

        [DllImport("user32", EntryPoint = "OpenDesktopA", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr OpenDesktopA([NativeTypeName("LPCSTR")] sbyte* lpszDesktop, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32", EntryPoint = "OpenDesktopW", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr OpenDesktopW([NativeTypeName("LPCWSTR")] ushort* lpszDesktop, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32", EntryPoint = "OpenInputDesktop", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr OpenInputDesktop([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32", EntryPoint = "EnumDesktopsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDesktopsA([NativeTypeName("HWINSTA")] IntPtr hwinsta, [NativeTypeName("DESKTOPENUMPROCA")] delegate* stdcall<sbyte*, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "EnumDesktopsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDesktopsW([NativeTypeName("HWINSTA")] IntPtr hwinsta, [NativeTypeName("DESKTOPENUMPROCW")] delegate* stdcall<ushort*, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "EnumDesktopWindows", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDesktopWindows([NativeTypeName("HDESK")] IntPtr hDesktop, [NativeTypeName("WNDENUMPROC")] delegate* stdcall<IntPtr, nint, int> lpfn, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "SwitchDesktop", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SwitchDesktop([NativeTypeName("HDESK")] IntPtr hDesktop);

        [DllImport("user32", EntryPoint = "SetThreadDesktop", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadDesktop([NativeTypeName("HDESK")] IntPtr hDesktop);

        [DllImport("user32", EntryPoint = "CloseDesktop", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseDesktop([NativeTypeName("HDESK")] IntPtr hDesktop);

        [DllImport("user32", EntryPoint = "GetThreadDesktop", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr GetThreadDesktop([NativeTypeName("DWORD")] uint dwThreadId);

        [DllImport("user32", EntryPoint = "CreateWindowStationA", ExactSpelling = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern IntPtr CreateWindowStationA([NativeTypeName("LPCSTR")] sbyte* lpwinsta, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);

        [DllImport("user32", EntryPoint = "CreateWindowStationW", ExactSpelling = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern IntPtr CreateWindowStationW([NativeTypeName("LPCWSTR")] ushort* lpwinsta, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);

        [DllImport("user32", EntryPoint = "OpenWindowStationA", ExactSpelling = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern IntPtr OpenWindowStationA([NativeTypeName("LPCSTR")] sbyte* lpszWinSta, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32", EntryPoint = "OpenWindowStationW", ExactSpelling = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern IntPtr OpenWindowStationW([NativeTypeName("LPCWSTR")] ushort* lpszWinSta, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32", EntryPoint = "EnumWindowStationsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumWindowStationsA([NativeTypeName("WINSTAENUMPROCA")] delegate* stdcall<sbyte*, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "EnumWindowStationsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumWindowStationsW([NativeTypeName("WINSTAENUMPROCW")] delegate* stdcall<ushort*, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "CloseWindowStation", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseWindowStation([NativeTypeName("HWINSTA")] IntPtr hWinSta);

        [DllImport("user32", EntryPoint = "SetProcessWindowStation", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessWindowStation([NativeTypeName("HWINSTA")] IntPtr hWinSta);

        [DllImport("user32", EntryPoint = "GetProcessWindowStation", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern IntPtr GetProcessWindowStation();

        [DllImport("user32", EntryPoint = "SetUserObjectSecurity", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetUserObjectSecurity([NativeTypeName("HANDLE")] IntPtr hObj, [NativeTypeName("PSECURITY_INFORMATION")] uint* pSIRequested, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSID);

        [DllImport("user32", EntryPoint = "GetUserObjectSecurity", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserObjectSecurity([NativeTypeName("HANDLE")] IntPtr hObj, [NativeTypeName("PSECURITY_INFORMATION")] uint* pSIRequested, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSID, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport("user32", EntryPoint = "GetUserObjectInformationA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserObjectInformationA([NativeTypeName("HANDLE")] IntPtr hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport("user32", EntryPoint = "GetUserObjectInformationW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserObjectInformationW([NativeTypeName("HANDLE")] IntPtr hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport("user32", EntryPoint = "SetUserObjectInformationA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetUserObjectInformationA([NativeTypeName("HANDLE")] IntPtr hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength);

        [DllImport("user32", EntryPoint = "SetUserObjectInformationW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetUserObjectInformationW([NativeTypeName("HANDLE")] IntPtr hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength);

        [DllImport("user32", EntryPoint = "IsHungAppWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsHungAppWindow([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", EntryPoint = "DisableProcessWindowsGhosting", ExactSpelling = true)]
        public static extern void DisableProcessWindowsGhosting();

        [DllImport("user32", EntryPoint = "RegisterWindowMessageA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RegisterWindowMessageA([NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32", EntryPoint = "RegisterWindowMessageW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RegisterWindowMessageW([NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("user32", EntryPoint = "TrackMouseEvent", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TrackMouseEvent([NativeTypeName("LPTRACKMOUSEEVENT")] TRACKMOUSEEVENT* lpEventTrack);

        [DllImport("user32", EntryPoint = "DrawEdge", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawEdge([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPRECT")] RECT* qrc, [NativeTypeName("UINT")] uint edge, [NativeTypeName("UINT")] uint grfFlags);

        [DllImport("user32", EntryPoint = "DrawFrameControl", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawFrameControl([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("LPRECT")] RECT* param1, [NativeTypeName("UINT")] uint param2, [NativeTypeName("UINT")] uint param3);

        [DllImport("user32", EntryPoint = "DrawCaption", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawCaption([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const RECT *")] RECT* lprect, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", EntryPoint = "DrawAnimatedRects", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawAnimatedRects([NativeTypeName("HWND")] IntPtr hwnd, int idAni, [NativeTypeName("const RECT *")] RECT* lprcFrom, [NativeTypeName("const RECT *")] RECT* lprcTo);

        [DllImport("user32", EntryPoint = "GetMessage", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMessage([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint wMsgFilterMin, [NativeTypeName("UINT")] uint wMsgFilterMax);

        [DllImport("user32", EntryPoint = "GetMessageW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMessageW([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint wMsgFilterMin, [NativeTypeName("UINT")] uint wMsgFilterMax);

        [DllImport("user32", EntryPoint = "TranslateMessage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TranslateMessage([NativeTypeName("const MSG *")] MSG* lpMsg);

        [DllImport("user32", EntryPoint = "DispatchMessageA", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DispatchMessageA([NativeTypeName("const MSG *")] MSG* lpMsg);

        [DllImport("user32", EntryPoint = "DispatchMessageW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DispatchMessageW([NativeTypeName("const MSG *")] MSG* lpMsg);

        [DllImport("user32", EntryPoint = "SetMessageQueue", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMessageQueue(int cMessagesMax);

        [DllImport("user32", EntryPoint = "PeekMessageA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PeekMessageA([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint wMsgFilterMin, [NativeTypeName("UINT")] uint wMsgFilterMax, [NativeTypeName("UINT")] uint wRemoveMsg);

        [DllImport("user32", EntryPoint = "PeekMessageW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PeekMessageW([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint wMsgFilterMin, [NativeTypeName("UINT")] uint wMsgFilterMax, [NativeTypeName("UINT")] uint wRemoveMsg);

        [DllImport("user32", EntryPoint = "RegisterHotKey", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterHotKey([NativeTypeName("HWND")] IntPtr hWnd, int id, [NativeTypeName("UINT")] uint fsModifiers, [NativeTypeName("UINT")] uint vk);

        [DllImport("user32", EntryPoint = "UnregisterHotKey", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterHotKey([NativeTypeName("HWND")] IntPtr hWnd, int id);

        [DllImport("user32", EntryPoint = "ExitWindowsEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExitWindowsEx([NativeTypeName("UINT")] uint uFlags, [NativeTypeName("DWORD")] uint dwReason);

        [DllImport("user32", EntryPoint = "SwapMouseButton", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SwapMouseButton([NativeTypeName("BOOL")] int fSwap);

        [DllImport("user32", EntryPoint = "GetMessagePos", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetMessagePos();

        [DllImport("user32", EntryPoint = "GetMessageTime", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetMessageTime();

        [DllImport("user32", EntryPoint = "GetMessageExtraInfo", ExactSpelling = true)]
        [return: NativeTypeName("LPARAM")]
        public static extern nint GetMessageExtraInfo();

        [DllImport("user32", EntryPoint = "GetUnpredictedMessagePos", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetUnpredictedMessagePos();

        [DllImport("user32", EntryPoint = "IsWow64Message", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWow64Message();

        [DllImport("user32", EntryPoint = "SetMessageExtraInfo", ExactSpelling = true)]
        [return: NativeTypeName("LPARAM")]
        public static extern nint SetMessageExtraInfo([NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "SendMessageA", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendMessageA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "SendMessageW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendMessageW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "SendMessageTimeoutA", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendMessageTimeoutA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("UINT")] uint fuFlags, [NativeTypeName("UINT")] uint uTimeout, [NativeTypeName("PDWORD_PTR")] nuint* lpdwResult);

        [DllImport("user32", EntryPoint = "SendMessageTimeoutW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendMessageTimeoutW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("UINT")] uint fuFlags, [NativeTypeName("UINT")] uint uTimeout, [NativeTypeName("PDWORD_PTR")] nuint* lpdwResult);

        [DllImport("user32", EntryPoint = "SendNotifyMessageA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SendNotifyMessageA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "SendNotifyMessageW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SendNotifyMessageW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "SendMessageCallbackA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SendMessageCallbackA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("SENDASYNCPROC")] delegate* stdcall<IntPtr, uint, nuint, nint, void> lpResultCallBack, [NativeTypeName("ULONG_PTR")] nuint dwData);

        [DllImport("user32", EntryPoint = "SendMessageCallbackW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SendMessageCallbackW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("SENDASYNCPROC")] delegate* stdcall<IntPtr, uint, nuint, nint, void> lpResultCallBack, [NativeTypeName("ULONG_PTR")] nuint dwData);

        [DllImport("user32", EntryPoint = "BroadcastSystemMessageExA", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageExA([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("PBSMINFO")] BSMINFO* pbsmInfo);

        [DllImport("user32", EntryPoint = "BroadcastSystemMessageExW", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageExW([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("PBSMINFO")] BSMINFO* pbsmInfo);

        [DllImport("user32", EntryPoint = "BroadcastSystemMessageA", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageA([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "BroadcastSystemMessageW", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageW([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "RegisterDeviceNotificationA", ExactSpelling = true)]
        [return: NativeTypeName("HDEVNOTIFY")]
        public static extern void* RegisterDeviceNotificationA([NativeTypeName("HANDLE")] IntPtr hRecipient, [NativeTypeName("LPVOID")] void* NotificationFilter, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("user32", EntryPoint = "RegisterDeviceNotificationW", ExactSpelling = true)]
        [return: NativeTypeName("HDEVNOTIFY")]
        public static extern void* RegisterDeviceNotificationW([NativeTypeName("HANDLE")] IntPtr hRecipient, [NativeTypeName("LPVOID")] void* NotificationFilter, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("user32", EntryPoint = "UnregisterDeviceNotification", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterDeviceNotification([NativeTypeName("HDEVNOTIFY")] void* Handle);

        [DllImport("user32", EntryPoint = "RegisterPowerSettingNotification", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HPOWERNOTIFY")]
        public static extern void* RegisterPowerSettingNotification([NativeTypeName("HANDLE")] IntPtr hRecipient, [NativeTypeName("LPCGUID")] Guid* PowerSettingGuid, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("user32", EntryPoint = "UnregisterPowerSettingNotification", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterPowerSettingNotification([NativeTypeName("HPOWERNOTIFY")] void* Handle);

        [DllImport("user32", EntryPoint = "RegisterSuspendResumeNotification", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HPOWERNOTIFY")]
        public static extern void* RegisterSuspendResumeNotification([NativeTypeName("HANDLE")] IntPtr hRecipient, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("user32", EntryPoint = "UnregisterSuspendResumeNotification", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterSuspendResumeNotification([NativeTypeName("HPOWERNOTIFY")] void* Handle);

        [DllImport("user32", EntryPoint = "PostMessageA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PostMessageA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "PostMessageW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PostMessageW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "PostThreadMessageA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PostThreadMessageA([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "PostThreadMessageW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PostThreadMessageW([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "AttachThreadInput", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AttachThreadInput([NativeTypeName("DWORD")] uint idAttach, [NativeTypeName("DWORD")] uint idAttachTo, [NativeTypeName("BOOL")] int fAttach);

        [DllImport("user32", EntryPoint = "ReplyMessage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReplyMessage([NativeTypeName("LRESULT")] nint lResult);

        [DllImport("user32", EntryPoint = "WaitMessage", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WaitMessage();

        [DllImport("user32", EntryPoint = "WaitForInputIdle", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WaitForInputIdle([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport("user32", EntryPoint = "DefWindowProcA", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefWindowProcA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "DefWindowProcW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefWindowProcW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "PostQuitMessage", ExactSpelling = true)]
        public static extern void PostQuitMessage(int nExitCode);

        [DllImport("user32", EntryPoint = "CallWindowProcA", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint CallWindowProcA([NativeTypeName("WNDPROC")] delegate* stdcall<IntPtr, uint, nuint, nint, nint> lpPrevWndFunc, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "CallWindowProcW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint CallWindowProcW([NativeTypeName("WNDPROC")] delegate* stdcall<IntPtr, uint, nuint, nint, nint> lpPrevWndFunc, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "InSendMessage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InSendMessage();

        [DllImport("user32", EntryPoint = "InSendMessageEx", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint InSendMessageEx([NativeTypeName("LPVOID")] void* lpReserved);

        [DllImport("user32", EntryPoint = "GetDoubleClickTime", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDoubleClickTime();

        [DllImport("user32", EntryPoint = "SetDoubleClickTime", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDoubleClickTime([NativeTypeName("UINT")] uint param0);

        [DllImport("user32", EntryPoint = "RegisterClassA", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassA([NativeTypeName("const WNDCLASSA *")] WNDCLASSA* lpWndClass);

        [DllImport("user32", EntryPoint = "RegisterClassW", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassW([NativeTypeName("const WNDCLASSW *")] WNDCLASSW* lpWndClass);

        [DllImport("user32", EntryPoint = "UnregisterClassA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterClassA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("HINSTANCE")] IntPtr hInstance);

        [DllImport("user32", EntryPoint = "UnregisterClassW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterClassW([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("HINSTANCE")] IntPtr hInstance);

        [DllImport("user32", EntryPoint = "GetClassInfoA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClassInfoA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPWNDCLASSA")] WNDCLASSA* lpWndClass);

        [DllImport("user32", EntryPoint = "GetClassInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClassInfoW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPWNDCLASSW")] WNDCLASSW* lpWndClass);

        [DllImport("user32", EntryPoint = "RegisterClassExA", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassExA([NativeTypeName("const WNDCLASSEXA *")] WNDCLASSEXA* param0);

        [DllImport("user32", EntryPoint = "RegisterClassExW", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassExW([NativeTypeName("const WNDCLASSEXW *")] WNDCLASSEXW* param0);

        [DllImport("user32", EntryPoint = "GetClassInfoExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClassInfoExA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpszClass, [NativeTypeName("LPWNDCLASSEXA")] WNDCLASSEXA* lpwcx);

        [DllImport("user32", EntryPoint = "GetClassInfoExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClassInfoExW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpszClass, [NativeTypeName("LPWNDCLASSEXW")] WNDCLASSEXW* lpwcx);

        [DllImport("user32", EntryPoint = "CreateWindowExA", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateWindowExA([NativeTypeName("DWORD")] uint dwExStyle, [NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPVOID")] void* lpParam);

        [DllImport("user32", EntryPoint = "CreateWindowExW", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateWindowExW([NativeTypeName("DWORD")] uint dwExStyle, [NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPVOID")] void* lpParam);

        [DllImport("user32", EntryPoint = "IsWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "IsMenu", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsMenu([NativeTypeName("HMENU")] IntPtr hMenu);

        [DllImport("user32", EntryPoint = "IsChild", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsChild([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "DestroyWindow", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "ShowWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowWindow([NativeTypeName("HWND")] IntPtr hWnd, int nCmdShow);

        [DllImport("user32", EntryPoint = "AnimateWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AnimateWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("DWORD")] uint dwTime, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", EntryPoint = "UpdateLayeredWindow", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateLayeredWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HDC")] IntPtr hdcDst, [NativeTypeName("POINT *")] POINT* pptDst, [NativeTypeName("SIZE *")] SIZE* psize, [NativeTypeName("HDC")] IntPtr hdcSrc, [NativeTypeName("POINT *")] POINT* pptSrc, [NativeTypeName("COLORREF")] uint crKey, [NativeTypeName("BLENDFUNCTION *")] BLENDFUNCTION* pblend, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", EntryPoint = "UpdateLayeredWindowIndirect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateLayeredWindowIndirect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const UPDATELAYEREDWINDOWINFO *")] UPDATELAYEREDWINDOWINFO* pULWInfo);

        [DllImport("user32", EntryPoint = "GetLayeredWindowAttributes", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLayeredWindowAttributes([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("COLORREF *")] uint* pcrKey, [NativeTypeName("BYTE *")] byte* pbAlpha, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport("user32", EntryPoint = "PrintWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PrintWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HDC")] IntPtr hdcBlt, [NativeTypeName("UINT")] uint nFlags);

        [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetLayeredWindowAttributes([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("COLORREF")] uint crKey, [NativeTypeName("BYTE")] byte bAlpha, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", EntryPoint = "ShowWindowAsync", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowWindowAsync([NativeTypeName("HWND")] IntPtr hWnd, int nCmdShow);

        [DllImport("user32", EntryPoint = "FlashWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlashWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("BOOL")] int bInvert);

        [DllImport("user32", EntryPoint = "FlashWindowEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlashWindowEx([NativeTypeName("PFLASHWINFO")] FLASHWINFO* pfwi);

        [DllImport("user32", EntryPoint = "ShowOwnedPopups", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowOwnedPopups([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("BOOL")] int fShow);

        [DllImport("user32", EntryPoint = "OpenIcon", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenIcon([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "CloseWindow", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "MoveWindow", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveWindow([NativeTypeName("HWND")] IntPtr hWnd, int X, int Y, int nWidth, int nHeight, [NativeTypeName("BOOL")] int bRepaint);

        [DllImport("user32", EntryPoint = "SetWindowPos", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowPos([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HWND")] IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("user32", EntryPoint = "GetWindowPlacement", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowPlacement([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("WINDOWPLACEMENT *")] WINDOWPLACEMENT* lpwndpl);

        [DllImport("user32", EntryPoint = "SetWindowPlacement", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowPlacement([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const WINDOWPLACEMENT *")] WINDOWPLACEMENT* lpwndpl);

        [DllImport("user32", EntryPoint = "GetWindowDisplayAffinity", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowDisplayAffinity([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("DWORD *")] uint* pdwAffinity);

        [DllImport("user32", EntryPoint = "SetWindowDisplayAffinity", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowDisplayAffinity([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("DWORD")] uint dwAffinity);

        [DllImport("user32", EntryPoint = "BeginDeferWindowPos", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HDWP")]
        public static extern IntPtr BeginDeferWindowPos(int nNumWindows);

        [DllImport("user32", EntryPoint = "DeferWindowPos", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HDWP")]
        public static extern IntPtr DeferWindowPos([NativeTypeName("HDWP")] IntPtr hWinPosInfo, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HWND")] IntPtr hWndInsertAfter, int x, int y, int cx, int cy, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("user32", EntryPoint = "EndDeferWindowPos", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndDeferWindowPos([NativeTypeName("HDWP")] IntPtr hWinPosInfo);

        [DllImport("user32", EntryPoint = "IsWindowVisible", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindowVisible([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "IsIconic", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsIconic([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "AnyPopup", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AnyPopup();

        [DllImport("user32", EntryPoint = "BringWindowToTop", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BringWindowToTop([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "IsZoomed", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsZoomed([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "CreateDialogParamA", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateDialogParamA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTemplateName, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* stdcall<IntPtr, uint, nuint, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32", EntryPoint = "CreateDialogParamW", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateDialogParamW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTemplateName, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* stdcall<IntPtr, uint, nuint, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32", EntryPoint = "CreateDialogIndirectParamA", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateDialogIndirectParamA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEA")] DLGTEMPLATE* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* stdcall<IntPtr, uint, nuint, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32", EntryPoint = "CreateDialogIndirectParamW", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateDialogIndirectParamW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* stdcall<IntPtr, uint, nuint, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32", EntryPoint = "DialogBoxParamA", ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint DialogBoxParamA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTemplateName, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* stdcall<IntPtr, uint, nuint, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32", EntryPoint = "DialogBoxParamW", ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint DialogBoxParamW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTemplateName, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* stdcall<IntPtr, uint, nuint, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32", EntryPoint = "DialogBoxIndirectParamA", ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint DialogBoxIndirectParamA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEA")] DLGTEMPLATE* hDialogTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* stdcall<IntPtr, uint, nuint, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32", EntryPoint = "DialogBoxIndirectParamW", ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint DialogBoxIndirectParamW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* hDialogTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* stdcall<IntPtr, uint, nuint, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32", EntryPoint = "EndDialog", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndDialog([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("INT_PTR")] nint nResult);

        [DllImport("user32", EntryPoint = "GetDlgItem", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetDlgItem([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem);

        [DllImport("user32", EntryPoint = "SetDlgItemInt", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDlgItemInt([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("UINT")] uint uValue, [NativeTypeName("BOOL")] int bSigned);

        [DllImport("user32", EntryPoint = "GetDlgItemInt", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDlgItemInt([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("BOOL *")] int* lpTranslated, [NativeTypeName("BOOL")] int bSigned);

        [DllImport("user32", EntryPoint = "SetDlgItemTextA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDlgItemTextA([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32", EntryPoint = "SetDlgItemTextW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDlgItemTextW([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("user32", EntryPoint = "GetDlgItemTextA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDlgItemTextA([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("LPSTR")] sbyte* lpString, int cchMax);

        [DllImport("user32", EntryPoint = "GetDlgItemTextW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDlgItemTextW([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("LPWSTR")] ushort* lpString, int cchMax);

        [DllImport("user32", EntryPoint = "CheckDlgButton", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckDlgButton([NativeTypeName("HWND")] IntPtr hDlg, int nIDButton, [NativeTypeName("UINT")] uint uCheck);

        [DllImport("user32", EntryPoint = "CheckRadioButton", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckRadioButton([NativeTypeName("HWND")] IntPtr hDlg, int nIDFirstButton, int nIDLastButton, int nIDCheckButton);

        [DllImport("user32", EntryPoint = "IsDlgButtonChecked", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint IsDlgButtonChecked([NativeTypeName("HWND")] IntPtr hDlg, int nIDButton);

        [DllImport("user32", EntryPoint = "SendDlgItemMessageA", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendDlgItemMessageA([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "SendDlgItemMessageW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendDlgItemMessageW([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "GetNextDlgGroupItem", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetNextDlgGroupItem([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("HWND")] IntPtr hCtl, [NativeTypeName("BOOL")] int bPrevious);

        [DllImport("user32", EntryPoint = "GetNextDlgTabItem", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetNextDlgTabItem([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("HWND")] IntPtr hCtl, [NativeTypeName("BOOL")] int bPrevious);

        [DllImport("user32", EntryPoint = "GetDlgCtrlID", ExactSpelling = true, SetLastError = true)]
        public static extern int GetDlgCtrlID([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "GetDialogBaseUnits", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int GetDialogBaseUnits();

        [DllImport("user32", EntryPoint = "DefDlgProcA", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefDlgProcA([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "DefDlgProcW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefDlgProcW([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "SetDialogControlDpiChangeBehavior", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDialogControlDpiChangeBehavior([NativeTypeName("HWND")] IntPtr hWnd, DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS mask, DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS values);

        [DllImport("user32", EntryPoint = "GetDialogControlDpiChangeBehavior", ExactSpelling = true)]
        public static extern DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS GetDialogControlDpiChangeBehavior([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "SetDialogDpiChangeBehavior", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDialogDpiChangeBehavior([NativeTypeName("HWND")] IntPtr hDlg, DIALOG_DPI_CHANGE_BEHAVIORS mask, DIALOG_DPI_CHANGE_BEHAVIORS values);

        [DllImport("user32", EntryPoint = "GetDialogDpiChangeBehavior", ExactSpelling = true)]
        public static extern DIALOG_DPI_CHANGE_BEHAVIORS GetDialogDpiChangeBehavior([NativeTypeName("HWND")] IntPtr hDlg);

        [DllImport("user32", EntryPoint = "CallMsgFilterA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CallMsgFilterA([NativeTypeName("LPMSG")] MSG* lpMsg, int nCode);

        [DllImport("user32", EntryPoint = "CallMsgFilterW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CallMsgFilterW([NativeTypeName("LPMSG")] MSG* lpMsg, int nCode);

        [DllImport("user32", EntryPoint = "OpenClipboard", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenClipboard([NativeTypeName("HWND")] IntPtr hWndNewOwner);

        [DllImport("user32", EntryPoint = "CloseClipboard", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseClipboard();

        [DllImport("user32", EntryPoint = "GetClipboardSequenceNumber", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetClipboardSequenceNumber();

        [DllImport("user32", EntryPoint = "GetClipboardOwner", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetClipboardOwner();

        [DllImport("user32", EntryPoint = "SetClipboardViewer", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr SetClipboardViewer([NativeTypeName("HWND")] IntPtr hWndNewViewer);

        [DllImport("user32", EntryPoint = "GetClipboardViewer", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetClipboardViewer();

        [DllImport("user32", EntryPoint = "ChangeClipboardChain", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeClipboardChain([NativeTypeName("HWND")] IntPtr hWndRemove, [NativeTypeName("HWND")] IntPtr hWndNewNext);

        [DllImport("user32", EntryPoint = "SetClipboardData", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr SetClipboardData([NativeTypeName("UINT")] uint uFormat, [NativeTypeName("HANDLE")] IntPtr hMem);

        [DllImport("user32", EntryPoint = "GetClipboardData", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr GetClipboardData([NativeTypeName("UINT")] uint uFormat);

        [DllImport("user32", EntryPoint = "RegisterClipboardFormatA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RegisterClipboardFormatA([NativeTypeName("LPCSTR")] sbyte* lpszFormat);

        [DllImport("user32", EntryPoint = "RegisterClipboardFormatW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RegisterClipboardFormatW([NativeTypeName("LPCWSTR")] ushort* lpszFormat);

        [DllImport("user32", EntryPoint = "CountClipboardFormats", ExactSpelling = true, SetLastError = true)]
        public static extern int CountClipboardFormats();

        [DllImport("user32", EntryPoint = "EnumClipboardFormats", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint EnumClipboardFormats([NativeTypeName("UINT")] uint format);

        [DllImport("user32", EntryPoint = "GetClipboardFormatNameA", ExactSpelling = true)]
        public static extern int GetClipboardFormatNameA([NativeTypeName("UINT")] uint format, [NativeTypeName("LPSTR")] sbyte* lpszFormatName, int cchMaxCount);

        [DllImport("user32", EntryPoint = "GetClipboardFormatNameW", ExactSpelling = true)]
        public static extern int GetClipboardFormatNameW([NativeTypeName("UINT")] uint format, [NativeTypeName("LPWSTR")] ushort* lpszFormatName, int cchMaxCount);

        [DllImport("user32", EntryPoint = "EmptyClipboard", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EmptyClipboard();

        [DllImport("user32", EntryPoint = "IsClipboardFormatAvailable", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsClipboardFormatAvailable([NativeTypeName("UINT")] uint format);

        [DllImport("user32", EntryPoint = "GetPriorityClipboardFormat", ExactSpelling = true, SetLastError = true)]
        public static extern int GetPriorityClipboardFormat([NativeTypeName("UINT *")] uint* paFormatPriorityList, int cFormats);

        [DllImport("user32", EntryPoint = "GetOpenClipboardWindow", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetOpenClipboardWindow();

        [DllImport("user32", EntryPoint = "AddClipboardFormatListener", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddClipboardFormatListener([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", EntryPoint = "RemoveClipboardFormatListener", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveClipboardFormatListener([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", EntryPoint = "GetUpdatedClipboardFormats", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUpdatedClipboardFormats([NativeTypeName("PUINT")] uint* lpuiFormats, [NativeTypeName("UINT")] uint cFormats, [NativeTypeName("PUINT")] uint* pcFormatsOut);

        [DllImport("user32", EntryPoint = "CharToOemA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CharToOemA([NativeTypeName("LPCSTR")] sbyte* pSrc, [NativeTypeName("LPSTR")] sbyte* pDst);

        [DllImport("user32", EntryPoint = "CharToOemW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CharToOemW([NativeTypeName("LPCWSTR")] ushort* pSrc, [NativeTypeName("LPSTR")] sbyte* pDst);

        [DllImport("user32", EntryPoint = "OemToCharA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OemToCharA([NativeTypeName("LPCSTR")] sbyte* pSrc, [NativeTypeName("LPSTR")] sbyte* pDst);

        [DllImport("user32", EntryPoint = "OemToCharW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OemToCharW([NativeTypeName("LPCSTR")] sbyte* pSrc, [NativeTypeName("LPWSTR")] ushort* pDst);

        [DllImport("user32", EntryPoint = "CharToOemBuffA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CharToOemBuffA([NativeTypeName("LPCSTR")] sbyte* lpszSrc, [NativeTypeName("LPSTR")] sbyte* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport("user32", EntryPoint = "CharToOemBuffW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CharToOemBuffW([NativeTypeName("LPCWSTR")] ushort* lpszSrc, [NativeTypeName("LPSTR")] sbyte* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport("user32", EntryPoint = "OemToCharBuffA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OemToCharBuffA([NativeTypeName("LPCSTR")] sbyte* lpszSrc, [NativeTypeName("LPSTR")] sbyte* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport("user32", EntryPoint = "OemToCharBuffW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OemToCharBuffW([NativeTypeName("LPCSTR")] sbyte* lpszSrc, [NativeTypeName("LPWSTR")] ushort* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport("user32", EntryPoint = "CharUpperA", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharUpperA([NativeTypeName("LPSTR")] sbyte* lpsz);

        [DllImport("user32", EntryPoint = "CharUpperW", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* CharUpperW([NativeTypeName("LPWSTR")] ushort* lpsz);

        [DllImport("user32", EntryPoint = "CharUpperBuffA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CharUpperBuffA([NativeTypeName("LPSTR")] sbyte* lpsz, [NativeTypeName("DWORD")] uint cchLength);

        [DllImport("user32", EntryPoint = "CharUpperBuffW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CharUpperBuffW([NativeTypeName("LPWSTR")] ushort* lpsz, [NativeTypeName("DWORD")] uint cchLength);

        [DllImport("user32", EntryPoint = "CharLowerA", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharLowerA([NativeTypeName("LPSTR")] sbyte* lpsz);

        [DllImport("user32", EntryPoint = "CharLowerW", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* CharLowerW([NativeTypeName("LPWSTR")] ushort* lpsz);

        [DllImport("user32", EntryPoint = "CharLowerBuffA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CharLowerBuffA([NativeTypeName("LPSTR")] sbyte* lpsz, [NativeTypeName("DWORD")] uint cchLength);

        [DllImport("user32", EntryPoint = "CharLowerBuffW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CharLowerBuffW([NativeTypeName("LPWSTR")] ushort* lpsz, [NativeTypeName("DWORD")] uint cchLength);

        [DllImport("user32", EntryPoint = "CharNextA", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharNextA([NativeTypeName("LPCSTR")] sbyte* lpsz);

        [DllImport("user32", EntryPoint = "CharNextW", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* CharNextW([NativeTypeName("LPCWSTR")] ushort* lpsz);

        [DllImport("user32", EntryPoint = "CharPrevA", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharPrevA([NativeTypeName("LPCSTR")] sbyte* lpszStart, [NativeTypeName("LPCSTR")] sbyte* lpszCurrent);

        [DllImport("user32", EntryPoint = "CharPrevW", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* CharPrevW([NativeTypeName("LPCWSTR")] ushort* lpszStart, [NativeTypeName("LPCWSTR")] ushort* lpszCurrent);

        [DllImport("user32", EntryPoint = "CharNextExA", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharNextExA([NativeTypeName("WORD")] ushort CodePage, [NativeTypeName("LPCSTR")] sbyte* lpCurrentChar, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", EntryPoint = "CharPrevExA", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharPrevExA([NativeTypeName("WORD")] ushort CodePage, [NativeTypeName("LPCSTR")] sbyte* lpStart, [NativeTypeName("LPCSTR")] sbyte* lpCurrentChar, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", EntryPoint = "IsCharAlphaA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharAlphaA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32", EntryPoint = "IsCharAlphaW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharAlphaW([NativeTypeName("WCHAR")] ushort ch);

        [DllImport("user32", EntryPoint = "IsCharAlphaNumericA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharAlphaNumericA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32", EntryPoint = "IsCharAlphaNumericW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharAlphaNumericW([NativeTypeName("WCHAR")] ushort ch);

        [DllImport("user32", EntryPoint = "IsCharUpperA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharUpperA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32", EntryPoint = "IsCharUpperW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharUpperW([NativeTypeName("WCHAR")] ushort ch);

        [DllImport("user32", EntryPoint = "IsCharLowerA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharLowerA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32", EntryPoint = "IsCharLowerW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharLowerW([NativeTypeName("WCHAR")] ushort ch);

        [DllImport("user32", EntryPoint = "SetFocus", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr SetFocus([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "GetActiveWindow", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetActiveWindow();

        [DllImport("user32", EntryPoint = "GetFocus", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetFocus();

        [DllImport("user32", EntryPoint = "GetKBCodePage", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetKBCodePage();

        [DllImport("user32", EntryPoint = "GetKeyState", ExactSpelling = true)]
        [return: NativeTypeName("SHORT")]
        public static extern short GetKeyState(int nVirtKey);

        [DllImport("user32", EntryPoint = "GetAsyncKeyState", ExactSpelling = true)]
        [return: NativeTypeName("SHORT")]
        public static extern short GetAsyncKeyState(int vKey);

        [DllImport("user32", EntryPoint = "GetKeyboardState", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetKeyboardState([NativeTypeName("PBYTE")] byte* lpKeyState);

        [DllImport("user32", EntryPoint = "SetKeyboardState", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetKeyboardState([NativeTypeName("LPBYTE")] byte* lpKeyState);

        [DllImport("user32", EntryPoint = "GetKeyNameTextA", ExactSpelling = true)]
        public static extern int GetKeyNameTextA([NativeTypeName("LONG")] int lParam, [NativeTypeName("LPSTR")] sbyte* lpString, int cchSize);

        [DllImport("user32", EntryPoint = "GetKeyNameTextW", ExactSpelling = true)]
        public static extern int GetKeyNameTextW([NativeTypeName("LONG")] int lParam, [NativeTypeName("LPWSTR")] ushort* lpString, int cchSize);

        [DllImport("user32", EntryPoint = "GetKeyboardType", ExactSpelling = true, SetLastError = true)]
        public static extern int GetKeyboardType(int nTypeFlag);

        [DllImport("user32", EntryPoint = "ToAscii", ExactSpelling = true)]
        public static extern int ToAscii([NativeTypeName("UINT")] uint uVirtKey, [NativeTypeName("UINT")] uint uScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWORD")] ushort* lpChar, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("user32", EntryPoint = "ToAsciiEx", ExactSpelling = true)]
        public static extern int ToAsciiEx([NativeTypeName("UINT")] uint uVirtKey, [NativeTypeName("UINT")] uint uScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWORD")] ushort* lpChar, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("HKL")] IntPtr dwhkl);

        [DllImport("user32", EntryPoint = "ToUnicode", ExactSpelling = true)]
        public static extern int ToUnicode([NativeTypeName("UINT")] uint wVirtKey, [NativeTypeName("UINT")] uint wScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWSTR")] ushort* pwszBuff, int cchBuff, [NativeTypeName("UINT")] uint wFlags);

        [DllImport("user32", EntryPoint = "OemKeyScan", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint OemKeyScan([NativeTypeName("WORD")] ushort wOemChar);

        [DllImport("user32", EntryPoint = "VkKeyScanA", ExactSpelling = true)]
        [return: NativeTypeName("SHORT")]
        public static extern short VkKeyScanA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32", EntryPoint = "VkKeyScanW", ExactSpelling = true)]
        [return: NativeTypeName("SHORT")]
        public static extern short VkKeyScanW([NativeTypeName("WCHAR")] ushort ch);

        [DllImport("user32", EntryPoint = "VkKeyScanExA", ExactSpelling = true)]
        [return: NativeTypeName("SHORT")]
        public static extern short VkKeyScanExA([NativeTypeName("CHAR")] sbyte ch, [NativeTypeName("HKL")] IntPtr dwhkl);

        [DllImport("user32", EntryPoint = "VkKeyScanExW", ExactSpelling = true)]
        [return: NativeTypeName("SHORT")]
        public static extern short VkKeyScanExW([NativeTypeName("WCHAR")] ushort ch, [NativeTypeName("HKL")] IntPtr dwhkl);

        [DllImport("user32", EntryPoint = "keybd_event", ExactSpelling = true)]
        public static extern void keybd_event([NativeTypeName("BYTE")] byte bVk, [NativeTypeName("BYTE")] byte bScan, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG_PTR")] nuint dwExtraInfo);

        [DllImport("user32", EntryPoint = "mouse_event", ExactSpelling = true)]
        public static extern void mouse_event([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dx, [NativeTypeName("DWORD")] uint dy, [NativeTypeName("DWORD")] uint dwData, [NativeTypeName("ULONG_PTR")] nuint dwExtraInfo);

        [DllImport("user32", EntryPoint = "SendInput", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SendInput([NativeTypeName("UINT")] uint cInputs, [NativeTypeName("LPINPUT")] INPUT* pInputs, int cbSize);

        [DllImport("user32", EntryPoint = "GetTouchInputInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTouchInputInfo([NativeTypeName("HTOUCHINPUT")] IntPtr hTouchInput, [NativeTypeName("UINT")] uint cInputs, [NativeTypeName("PTOUCHINPUT")] TOUCHINPUT* pInputs, int cbSize);

        [DllImport("user32", EntryPoint = "CloseTouchInputHandle", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseTouchInputHandle([NativeTypeName("HTOUCHINPUT")] IntPtr hTouchInput);

        [DllImport("user32", EntryPoint = "RegisterTouchWindow", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterTouchWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("ULONG")] uint ulFlags);

        [DllImport("user32", EntryPoint = "UnregisterTouchWindow", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterTouchWindow([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", EntryPoint = "IsTouchWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsTouchWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("PULONG")] uint* pulFlags);

        [DllImport("user32", EntryPoint = "InitializeTouchInjection", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeTouchInjection([NativeTypeName("UINT32")] uint maxCount, [NativeTypeName("DWORD")] uint dwMode);

        [DllImport("user32", EntryPoint = "InjectTouchInput", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InjectTouchInput([NativeTypeName("UINT32")] uint count, [NativeTypeName("const POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* contacts);

        [DllImport("user32", EntryPoint = "GetPointerType", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerType([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_INPUT_TYPE *")] uint* pointerType);

        [DllImport("user32", EntryPoint = "GetPointerCursorId", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerCursorId([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* cursorId);

        [DllImport("user32", EntryPoint = "GetPointerInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_INFO *")] POINTER_INFO* pointerInfo);

        [DllImport("user32", EntryPoint = "GetPointerInfoHistory", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("POINTER_INFO *")] POINTER_INFO* pointerInfo);

        [DllImport("user32", EntryPoint = "GetPointerFrameInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFrameInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_INFO *")] POINTER_INFO* pointerInfo);

        [DllImport("user32", EntryPoint = "GetPointerFrameInfoHistory", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFrameInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_INFO *")] POINTER_INFO* pointerInfo);

        [DllImport("user32", EntryPoint = "GetPointerTouchInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerTouchInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* touchInfo);

        [DllImport("user32", EntryPoint = "GetPointerTouchInfoHistory", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerTouchInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* touchInfo);

        [DllImport("user32", EntryPoint = "GetPointerFrameTouchInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFrameTouchInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* touchInfo);

        [DllImport("user32", EntryPoint = "GetPointerFrameTouchInfoHistory", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFrameTouchInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* touchInfo);

        [DllImport("user32", EntryPoint = "GetPointerPenInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerPenInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_PEN_INFO *")] POINTER_PEN_INFO* penInfo);

        [DllImport("user32", EntryPoint = "GetPointerPenInfoHistory", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerPenInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("POINTER_PEN_INFO *")] POINTER_PEN_INFO* penInfo);

        [DllImport("user32", EntryPoint = "GetPointerFramePenInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFramePenInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_PEN_INFO *")] POINTER_PEN_INFO* penInfo);

        [DllImport("user32", EntryPoint = "GetPointerFramePenInfoHistory", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFramePenInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_PEN_INFO *")] POINTER_PEN_INFO* penInfo);

        [DllImport("user32", EntryPoint = "SkipPointerFrameMessages", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SkipPointerFrameMessages([NativeTypeName("UINT32")] uint pointerId);

        [DllImport("user32", EntryPoint = "RegisterPointerInputTarget", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterPointerInputTarget([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);

        [DllImport("user32", EntryPoint = "UnregisterPointerInputTarget", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterPointerInputTarget([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);

        [DllImport("user32", EntryPoint = "RegisterPointerInputTargetEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterPointerInputTargetEx([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType, [NativeTypeName("BOOL")] int fObserve);

        [DllImport("user32", EntryPoint = "UnregisterPointerInputTargetEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterPointerInputTargetEx([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);

        [DllImport("user32", EntryPoint = "CreateSyntheticPointerDevice", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HSYNTHETICPOINTERDEVICE")]
        public static extern IntPtr CreateSyntheticPointerDevice([NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType, [NativeTypeName("ULONG")] uint maxCount, POINTER_FEEDBACK_MODE mode);

        [DllImport("user32", EntryPoint = "InjectSyntheticPointerInput", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InjectSyntheticPointerInput([NativeTypeName("HSYNTHETICPOINTERDEVICE")] IntPtr device, [NativeTypeName("const POINTER_TYPE_INFO *")] POINTER_TYPE_INFO* pointerInfo, [NativeTypeName("UINT32")] uint count);

        [DllImport("user32", EntryPoint = "DestroySyntheticPointerDevice", ExactSpelling = true)]
        public static extern void DestroySyntheticPointerDevice([NativeTypeName("HSYNTHETICPOINTERDEVICE")] IntPtr device);

        [DllImport("user32", EntryPoint = "EnableMouseInPointer", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableMouseInPointer([NativeTypeName("BOOL")] int fEnable);

        [DllImport("user32", EntryPoint = "IsMouseInPointerEnabled", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsMouseInPointerEnabled();

        [DllImport("user32", EntryPoint = "EnableMouseInPointerForThread", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableMouseInPointerForThread();

        [DllImport("user32", EntryPoint = "RegisterTouchHitTestingWindow", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterTouchHitTestingWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("ULONG")] uint value);

        [DllImport("user32", EntryPoint = "EvaluateProximityToRect", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EvaluateProximityToRect([NativeTypeName("const RECT *")] RECT* controlBoundingBox, [NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] TOUCH_HIT_TESTING_INPUT* pHitTestingInput, [NativeTypeName("TOUCH_HIT_TESTING_PROXIMITY_EVALUATION *")] TOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);

        [DllImport("user32", EntryPoint = "EvaluateProximityToPolygon", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EvaluateProximityToPolygon([NativeTypeName("UINT32")] uint numVertices, [NativeTypeName("const POINT *")] POINT* controlPolygon, [NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] TOUCH_HIT_TESTING_INPUT* pHitTestingInput, [NativeTypeName("TOUCH_HIT_TESTING_PROXIMITY_EVALUATION *")] TOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);

        [DllImport("user32", EntryPoint = "PackTouchHitTestingProximityEvaluation", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint PackTouchHitTestingProximityEvaluation([NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] TOUCH_HIT_TESTING_INPUT* pHitTestingInput, [NativeTypeName("const TOUCH_HIT_TESTING_PROXIMITY_EVALUATION *")] TOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);

        [DllImport("user32", EntryPoint = "GetWindowFeedbackSetting", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowFeedbackSetting([NativeTypeName("HWND")] IntPtr hwnd, FEEDBACK_TYPE feedback, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("UINT32 *")] uint* pSize, [NativeTypeName("void *")] void* config);

        [DllImport("user32", EntryPoint = "SetWindowFeedbackSetting", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowFeedbackSetting([NativeTypeName("HWND")] IntPtr hwnd, FEEDBACK_TYPE feedback, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("UINT32")] uint size, [NativeTypeName("const void *")] void* configuration);

        [DllImport("user32", EntryPoint = "GetPointerInputTransform", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerInputTransform([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint historyCount, [NativeTypeName("INPUT_TRANSFORM *")] INPUT_TRANSFORM* inputTransform);

        [DllImport("user32", EntryPoint = "GetLastInputInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLastInputInfo([NativeTypeName("PLASTINPUTINFO")] LASTINPUTINFO* plii);

        [DllImport("user32", EntryPoint = "MapVirtualKeyA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MapVirtualKeyA([NativeTypeName("UINT")] uint uCode, [NativeTypeName("UINT")] uint uMapType);

        [DllImport("user32", EntryPoint = "MapVirtualKeyW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MapVirtualKeyW([NativeTypeName("UINT")] uint uCode, [NativeTypeName("UINT")] uint uMapType);

        [DllImport("user32", EntryPoint = "MapVirtualKeyExA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MapVirtualKeyExA([NativeTypeName("UINT")] uint uCode, [NativeTypeName("UINT")] uint uMapType, [NativeTypeName("HKL")] IntPtr dwhkl);

        [DllImport("user32", EntryPoint = "MapVirtualKeyExW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MapVirtualKeyExW([NativeTypeName("UINT")] uint uCode, [NativeTypeName("UINT")] uint uMapType, [NativeTypeName("HKL")] IntPtr dwhkl);

        [DllImport("user32", EntryPoint = "GetInputState", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetInputState();

        [DllImport("user32", EntryPoint = "GetQueueStatus", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetQueueStatus([NativeTypeName("UINT")] uint flags);

        [DllImport("user32", EntryPoint = "GetCapture", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetCapture();

        [DllImport("user32", EntryPoint = "SetCapture", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr SetCapture([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "ReleaseCapture", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReleaseCapture();

        [DllImport("user32", EntryPoint = "MsgWaitForMultipleObjects", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MsgWaitForMultipleObjects([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] void** pHandles, [NativeTypeName("BOOL")] int fWaitAll, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("DWORD")] uint dwWakeMask);

        [DllImport("user32", EntryPoint = "MsgWaitForMultipleObjectsEx", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MsgWaitForMultipleObjectsEx([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] void** pHandles, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("DWORD")] uint dwWakeMask, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", EntryPoint = "SetTimer", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT_PTR")]
        public static extern nuint SetTimer([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT_PTR")] nuint nIDEvent, [NativeTypeName("UINT")] uint uElapse, [NativeTypeName("TIMERPROC")] delegate* stdcall<IntPtr, uint, nuint, uint, void> lpTimerFunc);

        [DllImport("user32", EntryPoint = "SetCoalescableTimer", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT_PTR")]
        public static extern nuint SetCoalescableTimer([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT_PTR")] nuint nIDEvent, [NativeTypeName("UINT")] uint uElapse, [NativeTypeName("TIMERPROC")] delegate* stdcall<IntPtr, uint, nuint, uint, void> lpTimerFunc, [NativeTypeName("ULONG")] uint uToleranceDelay);

        [DllImport("user32", EntryPoint = "KillTimer", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int KillTimer([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT_PTR")] nuint uIDEvent);

        [DllImport("user32", EntryPoint = "IsWindowUnicode", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindowUnicode([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "EnableWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("BOOL")] int bEnable);

        [DllImport("user32", EntryPoint = "IsWindowEnabled", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindowEnabled([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "LoadAcceleratorsA", ExactSpelling = true)]
        [return: NativeTypeName("HACCEL")]
        public static extern IntPtr LoadAcceleratorsA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTableName);

        [DllImport("user32", EntryPoint = "LoadAcceleratorsW", ExactSpelling = true)]
        [return: NativeTypeName("HACCEL")]
        public static extern IntPtr LoadAcceleratorsW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTableName);

        [DllImport("user32", EntryPoint = "CreateAcceleratorTableA", ExactSpelling = true)]
        [return: NativeTypeName("HACCEL")]
        public static extern IntPtr CreateAcceleratorTableA([NativeTypeName("LPACCEL")] ACCEL* paccel, int cAccel);

        [DllImport("user32", EntryPoint = "CreateAcceleratorTableW", ExactSpelling = true)]
        [return: NativeTypeName("HACCEL")]
        public static extern IntPtr CreateAcceleratorTableW([NativeTypeName("LPACCEL")] ACCEL* paccel, int cAccel);

        [DllImport("user32", EntryPoint = "DestroyAcceleratorTable", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyAcceleratorTable([NativeTypeName("HACCEL")] IntPtr hAccel);

        [DllImport("user32", EntryPoint = "CopyAcceleratorTableA", ExactSpelling = true)]
        public static extern int CopyAcceleratorTableA([NativeTypeName("HACCEL")] IntPtr hAccelSrc, [NativeTypeName("LPACCEL")] ACCEL* lpAccelDst, int cAccelEntries);

        [DllImport("user32", EntryPoint = "CopyAcceleratorTableW", ExactSpelling = true)]
        public static extern int CopyAcceleratorTableW([NativeTypeName("HACCEL")] IntPtr hAccelSrc, [NativeTypeName("LPACCEL")] ACCEL* lpAccelDst, int cAccelEntries);

        [DllImport("user32", EntryPoint = "TranslateAcceleratorA", ExactSpelling = true)]
        public static extern int TranslateAcceleratorA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HACCEL")] IntPtr hAccTable, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32", EntryPoint = "TranslateAcceleratorW", ExactSpelling = true)]
        public static extern int TranslateAcceleratorW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HACCEL")] IntPtr hAccTable, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32", EntryPoint = "GetSystemMetrics", ExactSpelling = true, SetLastError = true)]
        public static extern int GetSystemMetrics(int nIndex);

        [DllImport("user32", EntryPoint = "GetSystemMetricsForDpi", ExactSpelling = true, SetLastError = true)]
        public static extern int GetSystemMetricsForDpi(int nIndex, [NativeTypeName("UINT")] uint dpi);

        [DllImport("user32", EntryPoint = "LoadMenuA", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr LoadMenuA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpMenuName);

        [DllImport("user32", EntryPoint = "LoadMenuW", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr LoadMenuW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpMenuName);

        [DllImport("user32", EntryPoint = "LoadMenuIndirectA", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr LoadMenuIndirectA([NativeTypeName("const MENUTEMPLATEA *")] void* lpMenuTemplate);

        [DllImport("user32", EntryPoint = "LoadMenuIndirectW", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr LoadMenuIndirectW([NativeTypeName("const MENUTEMPLATEW *")] void* lpMenuTemplate);

        [DllImport("user32", EntryPoint = "GetMenu", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr GetMenu([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "SetMenu", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenu([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HMENU")] IntPtr hMenu);

        [DllImport("user32", EntryPoint = "ChangeMenuA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeMenuA([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint cmd, [NativeTypeName("LPCSTR")] sbyte* lpszNewItem, [NativeTypeName("UINT")] uint cmdInsert, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", EntryPoint = "ChangeMenuW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeMenuW([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint cmd, [NativeTypeName("LPCWSTR")] ushort* lpszNewItem, [NativeTypeName("UINT")] uint cmdInsert, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", EntryPoint = "HiliteMenuItem", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HiliteMenuItem([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uIDHiliteItem, [NativeTypeName("UINT")] uint uHilite);

        [DllImport("user32", EntryPoint = "GetMenuStringA", ExactSpelling = true)]
        public static extern int GetMenuStringA([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uIDItem, [NativeTypeName("LPSTR")] sbyte* lpString, int cchMax, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", EntryPoint = "GetMenuStringW", ExactSpelling = true)]
        public static extern int GetMenuStringW([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uIDItem, [NativeTypeName("LPWSTR")] ushort* lpString, int cchMax, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", EntryPoint = "GetMenuState", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetMenuState([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uId, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("user32", EntryPoint = "DrawMenuBar", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawMenuBar([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "GetSystemMenu", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr GetSystemMenu([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("BOOL")] int bRevert);

        [DllImport("user32", EntryPoint = "CreateMenu", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr CreateMenu();

        [DllImport("user32", EntryPoint = "CreatePopupMenu", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr CreatePopupMenu();

        [DllImport("user32", EntryPoint = "DestroyMenu", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyMenu([NativeTypeName("HMENU")] IntPtr hMenu);

        [DllImport("user32", EntryPoint = "CheckMenuItem", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CheckMenuItem([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uIDCheckItem, [NativeTypeName("UINT")] uint uCheck);

        [DllImport("user32", EntryPoint = "EnableMenuItem", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableMenuItem([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uIDEnableItem, [NativeTypeName("UINT")] uint uEnable);

        [DllImport("user32", EntryPoint = "GetSubMenu", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr GetSubMenu([NativeTypeName("HMENU")] IntPtr hMenu, int nPos);

        [DllImport("user32", EntryPoint = "GetMenuItemID", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetMenuItemID([NativeTypeName("HMENU")] IntPtr hMenu, int nPos);

        [DllImport("user32", EntryPoint = "GetMenuItemCount", ExactSpelling = true, SetLastError = true)]
        public static extern int GetMenuItemCount([NativeTypeName("HMENU")] IntPtr hMenu);

        [DllImport("user32", EntryPoint = "InsertMenuA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InsertMenuA([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCSTR")] sbyte* lpNewItem);

        [DllImport("user32", EntryPoint = "InsertMenuW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InsertMenuW([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCWSTR")] ushort* lpNewItem);

        [DllImport("user32", EntryPoint = "AppendMenuA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AppendMenuA([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCSTR")] sbyte* lpNewItem);

        [DllImport("user32", EntryPoint = "AppendMenuW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AppendMenuW([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCWSTR")] ushort* lpNewItem);

        [DllImport("user32", EntryPoint = "ModifyMenuA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ModifyMenuA([NativeTypeName("HMENU")] IntPtr hMnu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCSTR")] sbyte* lpNewItem);

        [DllImport("user32", EntryPoint = "ModifyMenuW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ModifyMenuW([NativeTypeName("HMENU")] IntPtr hMnu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCWSTR")] ushort* lpNewItem);

        [DllImport("user32", EntryPoint = "RemoveMenu", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveMenu([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("user32", EntryPoint = "DeleteMenu", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteMenu([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("user32", EntryPoint = "SetMenuItemBitmaps", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuItemBitmaps([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("HBITMAP")] IntPtr hBitmapUnchecked, [NativeTypeName("HBITMAP")] IntPtr hBitmapChecked);

        [DllImport("user32", EntryPoint = "GetMenuCheckMarkDimensions", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetMenuCheckMarkDimensions();

        [DllImport("user32", EntryPoint = "TrackPopupMenu", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TrackPopupMenu([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uFlags, int x, int y, int nReserved, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const RECT *")] RECT* prcRect);

        [DllImport("user32", EntryPoint = "TrackPopupMenuEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TrackPopupMenuEx([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uFlags, int x, int y, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPTPMPARAMS")] TPMPARAMS* lptpm);

        [DllImport("user32", EntryPoint = "CalculatePopupWindowPosition", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CalculatePopupWindowPosition([NativeTypeName("const POINT *")] POINT* anchorPoint, [NativeTypeName("const SIZE *")] SIZE* windowSize, [NativeTypeName("UINT")] uint flags, [NativeTypeName("RECT *")] RECT* excludeRect, [NativeTypeName("RECT *")] RECT* popupWindowPosition);

        [DllImport("user32", EntryPoint = "GetMenuInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuInfo([NativeTypeName("HMENU")] IntPtr param0, [NativeTypeName("LPMENUINFO")] MENUINFO* param1);

        [DllImport("user32", EntryPoint = "SetMenuInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuInfo([NativeTypeName("HMENU")] IntPtr param0, [NativeTypeName("LPCMENUINFO")] MENUINFO* param1);

        [DllImport("user32", EntryPoint = "EndMenu", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndMenu();

        [DllImport("user32", EntryPoint = "InsertMenuItemA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InsertMenuItemA([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint item, [NativeTypeName("BOOL")] int fByPosition, [NativeTypeName("LPCMENUITEMINFOA")] MENUITEMINFOA* lpmi);

        [DllImport("user32", EntryPoint = "InsertMenuItemW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InsertMenuItemW([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint item, [NativeTypeName("BOOL")] int fByPosition, [NativeTypeName("LPCMENUITEMINFOW")] MENUITEMINFOW* lpmi);

        [DllImport("user32", EntryPoint = "GetMenuItemInfoA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuItemInfoA([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint item, [NativeTypeName("BOOL")] int fByPosition, [NativeTypeName("LPMENUITEMINFOA")] MENUITEMINFOA* lpmii);

        [DllImport("user32", EntryPoint = "GetMenuItemInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuItemInfoW([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint item, [NativeTypeName("BOOL")] int fByPosition, [NativeTypeName("LPMENUITEMINFOW")] MENUITEMINFOW* lpmii);

        [DllImport("user32", EntryPoint = "SetMenuItemInfoA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuItemInfoA([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint item, [NativeTypeName("BOOL")] int fByPositon, [NativeTypeName("LPCMENUITEMINFOA")] MENUITEMINFOA* lpmii);

        [DllImport("user32", EntryPoint = "SetMenuItemInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuItemInfoW([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint item, [NativeTypeName("BOOL")] int fByPositon, [NativeTypeName("LPCMENUITEMINFOW")] MENUITEMINFOW* lpmii);

        [DllImport("user32", EntryPoint = "GetMenuDefaultItem", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetMenuDefaultItem([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint fByPos, [NativeTypeName("UINT")] uint gmdiFlags);

        [DllImport("user32", EntryPoint = "SetMenuDefaultItem", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuDefaultItem([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uItem, [NativeTypeName("UINT")] uint fByPos);

        [DllImport("user32", EntryPoint = "GetMenuItemRect", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuItemRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uItem, [NativeTypeName("LPRECT")] RECT* lprcItem);

        [DllImport("user32", EntryPoint = "MenuItemFromPoint", ExactSpelling = true)]
        public static extern int MenuItemFromPoint([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HMENU")] IntPtr hMenu, POINT ptScreen);

        [DllImport("user32", EntryPoint = "DragObject", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DragObject([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("HWND")] IntPtr hwndFrom, [NativeTypeName("UINT")] uint fmt, [NativeTypeName("ULONG_PTR")] nuint data, [NativeTypeName("HCURSOR")] IntPtr hcur);

        [DllImport("user32", EntryPoint = "DragDetect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DragDetect([NativeTypeName("HWND")] IntPtr hwnd, POINT pt);

        [DllImport("user32", EntryPoint = "DrawIcon", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawIcon([NativeTypeName("HDC")] IntPtr hDC, int X, int Y, [NativeTypeName("HICON")] IntPtr hIcon);

        [DllImport("user32", EntryPoint = "DrawText", ExactSpelling = true)]
        public static extern int DrawText([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, [NativeTypeName("UINT")] uint format);

        [DllImport("user32", EntryPoint = "DrawTextW", ExactSpelling = true)]
        public static extern int DrawTextW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, [NativeTypeName("UINT")] uint format);

        [DllImport("user32", EntryPoint = "DrawTextExA", ExactSpelling = true)]
        public static extern int DrawTextExA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPSTR")] sbyte* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, [NativeTypeName("UINT")] uint format, [NativeTypeName("LPDRAWTEXTPARAMS")] DRAWTEXTPARAMS* lpdtp);

        [DllImport("user32", EntryPoint = "DrawTextExW", ExactSpelling = true)]
        public static extern int DrawTextExW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPWSTR")] ushort* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, [NativeTypeName("UINT")] uint format, [NativeTypeName("LPDRAWTEXTPARAMS")] DRAWTEXTPARAMS* lpdtp);

        [DllImport("user32", EntryPoint = "GrayStringA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GrayStringA([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("HBRUSH")] IntPtr hBrush, [NativeTypeName("GRAYSTRINGPROC")] delegate* stdcall<IntPtr, nint, int, int> lpOutputFunc, [NativeTypeName("LPARAM")] nint lpData, int nCount, int X, int Y, int nWidth, int nHeight);

        [DllImport("user32", EntryPoint = "GrayStringW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GrayStringW([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("HBRUSH")] IntPtr hBrush, [NativeTypeName("GRAYSTRINGPROC")] delegate* stdcall<IntPtr, nint, int, int> lpOutputFunc, [NativeTypeName("LPARAM")] nint lpData, int nCount, int X, int Y, int nWidth, int nHeight);

        [DllImport("user32", EntryPoint = "DrawStateA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawStateA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HBRUSH")] IntPtr hbrFore, [NativeTypeName("DRAWSTATEPROC")] delegate* stdcall<IntPtr, nint, nuint, int, int, int> qfnCallBack, [NativeTypeName("LPARAM")] nint lData, [NativeTypeName("WPARAM")] nuint wData, int x, int y, int cx, int cy, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("user32", EntryPoint = "DrawStateW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawStateW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HBRUSH")] IntPtr hbrFore, [NativeTypeName("DRAWSTATEPROC")] delegate* stdcall<IntPtr, nint, nuint, int, int, int> qfnCallBack, [NativeTypeName("LPARAM")] nint lData, [NativeTypeName("WPARAM")] nuint wData, int x, int y, int cx, int cy, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("user32", EntryPoint = "TabbedTextOutA", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int TabbedTextOutA([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPCSTR")] sbyte* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions, int nTabOrigin);

        [DllImport("user32", EntryPoint = "TabbedTextOutW", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int TabbedTextOutW([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPCWSTR")] ushort* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions, int nTabOrigin);

        [DllImport("user32", EntryPoint = "GetTabbedTextExtentA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTabbedTextExtentA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions);

        [DllImport("user32", EntryPoint = "GetTabbedTextExtentW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTabbedTextExtentW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions);

        [DllImport("user32", EntryPoint = "UpdateWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "SetActiveWindow", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr SetActiveWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "GetForegroundWindow", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32", EntryPoint = "PaintDesktop", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PaintDesktop([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("user32", EntryPoint = "SwitchToThisWindow", ExactSpelling = true)]
        public static extern void SwitchToThisWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("BOOL")] int fUnknown);

        [DllImport("user32", EntryPoint = "SetForegroundWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetForegroundWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "AllowSetForegroundWindow", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AllowSetForegroundWindow([NativeTypeName("DWORD")] uint dwProcessId);

        [DllImport("user32", EntryPoint = "LockSetForegroundWindow", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockSetForegroundWindow([NativeTypeName("UINT")] uint uLockCode);

        [DllImport("user32", EntryPoint = "WindowFromDC", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr WindowFromDC([NativeTypeName("HDC")] IntPtr hDC);

        [DllImport("user32", EntryPoint = "GetDC", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr GetDC([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "GetDCEx", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr GetDCEx([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hrgnClip, [NativeTypeName("DWORD")] uint flags);

        [DllImport("user32", EntryPoint = "GetWindowDC", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr GetWindowDC([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "ReleaseDC", ExactSpelling = true)]
        public static extern int ReleaseDC([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HDC")] IntPtr hDC);

        [DllImport("user32", EntryPoint = "BeginPaint", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr BeginPaint([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPAINTSTRUCT")] PAINTSTRUCT* lpPaint);

        [DllImport("user32", EntryPoint = "EndPaint", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndPaint([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const PAINTSTRUCT *")] PAINTSTRUCT* lpPaint);

        [DllImport("user32", EntryPoint = "GetUpdateRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUpdateRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("BOOL")] int bErase);

        [DllImport("user32", EntryPoint = "GetUpdateRgn", ExactSpelling = true)]
        public static extern int GetUpdateRgn([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hRgn, [NativeTypeName("BOOL")] int bErase);

        [DllImport("user32", EntryPoint = "SetWindowRgn", ExactSpelling = true)]
        public static extern int SetWindowRgn([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hRgn, [NativeTypeName("BOOL")] int bRedraw);

        [DllImport("user32", EntryPoint = "GetWindowRgn", ExactSpelling = true)]
        public static extern int GetWindowRgn([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hRgn);

        [DllImport("user32", EntryPoint = "GetWindowRgnBox", ExactSpelling = true)]
        public static extern int GetWindowRgnBox([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPRECT")] RECT* lprc);

        [DllImport("user32", EntryPoint = "ExcludeUpdateRgn", ExactSpelling = true)]
        public static extern int ExcludeUpdateRgn([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "InvalidateRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InvalidateRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const RECT *")] RECT* lpRect, [NativeTypeName("BOOL")] int bErase);

        [DllImport("user32", EntryPoint = "ValidateRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ValidateRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const RECT *")] RECT* lpRect);

        [DllImport("user32", EntryPoint = "InvalidateRgn", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InvalidateRgn([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hRgn, [NativeTypeName("BOOL")] int bErase);

        [DllImport("user32", EntryPoint = "ValidateRgn", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ValidateRgn([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hRgn);

        [DllImport("user32", EntryPoint = "RedrawWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RedrawWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const RECT *")] RECT* lprcUpdate, [NativeTypeName("HRGN")] IntPtr hrgnUpdate, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", EntryPoint = "LockWindowUpdate", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockWindowUpdate([NativeTypeName("HWND")] IntPtr hWndLock);

        [DllImport("user32", EntryPoint = "ScrollWindow", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScrollWindow([NativeTypeName("HWND")] IntPtr hWnd, int XAmount, int YAmount, [NativeTypeName("const RECT *")] RECT* lpRect, [NativeTypeName("const RECT *")] RECT* lpClipRect);

        [DllImport("user32", EntryPoint = "ScrollDC", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScrollDC([NativeTypeName("HDC")] IntPtr hDC, int dx, int dy, [NativeTypeName("const RECT *")] RECT* lprcScroll, [NativeTypeName("const RECT *")] RECT* lprcClip, [NativeTypeName("HRGN")] IntPtr hrgnUpdate, [NativeTypeName("LPRECT")] RECT* lprcUpdate);

        [DllImport("user32", EntryPoint = "ScrollWindowEx", ExactSpelling = true, SetLastError = true)]
        public static extern int ScrollWindowEx([NativeTypeName("HWND")] IntPtr hWnd, int dx, int dy, [NativeTypeName("const RECT *")] RECT* prcScroll, [NativeTypeName("const RECT *")] RECT* prcClip, [NativeTypeName("HRGN")] IntPtr hrgnUpdate, [NativeTypeName("LPRECT")] RECT* prcUpdate, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", EntryPoint = "SetScrollPos", ExactSpelling = true, SetLastError = true)]
        public static extern int SetScrollPos([NativeTypeName("HWND")] IntPtr hWnd, int nBar, int nPos, [NativeTypeName("BOOL")] int bRedraw);

        [DllImport("user32", EntryPoint = "GetScrollPos", ExactSpelling = true, SetLastError = true)]
        public static extern int GetScrollPos([NativeTypeName("HWND")] IntPtr hWnd, int nBar);

        [DllImport("user32", EntryPoint = "SetScrollRange", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetScrollRange([NativeTypeName("HWND")] IntPtr hWnd, int nBar, int nMinPos, int nMaxPos, [NativeTypeName("BOOL")] int bRedraw);

        [DllImport("user32", EntryPoint = "GetScrollRange", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetScrollRange([NativeTypeName("HWND")] IntPtr hWnd, int nBar, [NativeTypeName("LPINT")] int* lpMinPos, [NativeTypeName("LPINT")] int* lpMaxPos);

        [DllImport("user32", EntryPoint = "ShowScrollBar", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowScrollBar([NativeTypeName("HWND")] IntPtr hWnd, int wBar, [NativeTypeName("BOOL")] int bShow);

        [DllImport("user32", EntryPoint = "EnableScrollBar", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableScrollBar([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint wSBflags, [NativeTypeName("UINT")] uint wArrows);

        [DllImport("user32", EntryPoint = "SetPropA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPropA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("HANDLE")] IntPtr hData);

        [DllImport("user32", EntryPoint = "SetPropW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPropW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("HANDLE")] IntPtr hData);

        [DllImport("user32", EntryPoint = "GetPropA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr GetPropA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32", EntryPoint = "GetPropW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr GetPropW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("user32", EntryPoint = "RemovePropA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr RemovePropA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32", EntryPoint = "RemovePropW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr RemovePropW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("user32", EntryPoint = "EnumPropsExA", ExactSpelling = true)]
        public static extern int EnumPropsExA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("PROPENUMPROCEXA")] delegate* stdcall<IntPtr, sbyte*, IntPtr, nuint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "EnumPropsExW", ExactSpelling = true)]
        public static extern int EnumPropsExW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("PROPENUMPROCEXW")] delegate* stdcall<IntPtr, ushort*, IntPtr, nuint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "EnumPropsA", ExactSpelling = true)]
        public static extern int EnumPropsA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("PROPENUMPROCA")] delegate* stdcall<IntPtr, sbyte*, IntPtr, int> lpEnumFunc);

        [DllImport("user32", EntryPoint = "EnumPropsW", ExactSpelling = true)]
        public static extern int EnumPropsW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("PROPENUMPROCW")] delegate* stdcall<IntPtr, ushort*, IntPtr, int> lpEnumFunc);

        [DllImport("user32", EntryPoint = "SetWindowTextA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowTextA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32", EntryPoint = "SetWindowTextW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowTextW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("user32", EntryPoint = "GetWindowTextA", ExactSpelling = true)]
        public static extern int GetWindowTextA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPSTR")] sbyte* lpString, int nMaxCount);

        [DllImport("user32", EntryPoint = "GetWindowTextW", ExactSpelling = true)]
        public static extern int GetWindowTextW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPWSTR")] ushort* lpString, int nMaxCount);

        [DllImport("user32", EntryPoint = "GetWindowTextLengthA", ExactSpelling = true)]
        public static extern int GetWindowTextLengthA([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "GetWindowTextLengthW", ExactSpelling = true)]
        public static extern int GetWindowTextLengthW([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "GetClientRect", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClientRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport("user32", EntryPoint = "GetWindowRect", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport("user32", EntryPoint = "AdjustWindowRect", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AdjustWindowRect([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("BOOL")] int bMenu);

        [DllImport("user32", EntryPoint = "AdjustWindowRectEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AdjustWindowRectEx([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("BOOL")] int bMenu, [NativeTypeName("DWORD")] uint dwExStyle);

        [DllImport("user32", EntryPoint = "AdjustWindowRectExForDpi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AdjustWindowRectExForDpi([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("BOOL")] int bMenu, [NativeTypeName("DWORD")] uint dwExStyle, [NativeTypeName("UINT")] uint dpi);

        [DllImport("user32", EntryPoint = "SetWindowContextHelpId", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowContextHelpId([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("DWORD")] uint param1);

        [DllImport("user32", EntryPoint = "GetWindowContextHelpId", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetWindowContextHelpId([NativeTypeName("HWND")] IntPtr param0);

        [DllImport("user32", EntryPoint = "SetMenuContextHelpId", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuContextHelpId([NativeTypeName("HMENU")] IntPtr param0, [NativeTypeName("DWORD")] uint param1);

        [DllImport("user32", EntryPoint = "GetMenuContextHelpId", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetMenuContextHelpId([NativeTypeName("HMENU")] IntPtr param0);

        [DllImport("user32", EntryPoint = "MessageBoxA", ExactSpelling = true)]
        public static extern int MessageBoxA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCSTR")] sbyte* lpText, [NativeTypeName("LPCSTR")] sbyte* lpCaption, [NativeTypeName("UINT")] uint uType);

        [DllImport("user32", EntryPoint = "MessageBoxW", ExactSpelling = true)]
        public static extern int MessageBoxW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpText, [NativeTypeName("LPCWSTR")] ushort* lpCaption, [NativeTypeName("UINT")] uint uType);

        [DllImport("user32", EntryPoint = "MessageBoxExA", ExactSpelling = true)]
        public static extern int MessageBoxExA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCSTR")] sbyte* lpText, [NativeTypeName("LPCSTR")] sbyte* lpCaption, [NativeTypeName("UINT")] uint uType, [NativeTypeName("WORD")] ushort wLanguageId);

        [DllImport("user32", EntryPoint = "MessageBoxExW", ExactSpelling = true)]
        public static extern int MessageBoxExW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpText, [NativeTypeName("LPCWSTR")] ushort* lpCaption, [NativeTypeName("UINT")] uint uType, [NativeTypeName("WORD")] ushort wLanguageId);

        [DllImport("user32", EntryPoint = "MessageBoxIndirectA", ExactSpelling = true)]
        public static extern int MessageBoxIndirectA([NativeTypeName("const MSGBOXPARAMSA *")] MSGBOXPARAMSA* lpmbp);

        [DllImport("user32", EntryPoint = "MessageBoxIndirectW", ExactSpelling = true)]
        public static extern int MessageBoxIndirectW([NativeTypeName("const MSGBOXPARAMSW *")] MSGBOXPARAMSW* lpmbp);

        [DllImport("user32", EntryPoint = "MessageBeep", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MessageBeep([NativeTypeName("UINT")] uint uType);

        [DllImport("user32", EntryPoint = "ShowCursor", ExactSpelling = true)]
        public static extern int ShowCursor([NativeTypeName("BOOL")] int bShow);

        [DllImport("user32", EntryPoint = "SetCursorPos", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCursorPos(int X, int Y);

        [DllImport("user32", EntryPoint = "SetPhysicalCursorPos", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPhysicalCursorPos(int X, int Y);

        [DllImport("user32", EntryPoint = "SetCursor", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr SetCursor([NativeTypeName("HCURSOR")] IntPtr hCursor);

        [DllImport("user32", EntryPoint = "GetCursorPos", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCursorPos([NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", EntryPoint = "GetPhysicalCursorPos", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPhysicalCursorPos([NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", EntryPoint = "GetClipCursor", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClipCursor([NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport("user32", EntryPoint = "GetCursor", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr GetCursor();

        [DllImport("user32", EntryPoint = "CreateCaret", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateCaret([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HBITMAP")] IntPtr hBitmap, int nWidth, int nHeight);

        [DllImport("user32", EntryPoint = "GetCaretBlinkTime", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetCaretBlinkTime();

        [DllImport("user32", EntryPoint = "SetCaretBlinkTime", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCaretBlinkTime([NativeTypeName("UINT")] uint uMSeconds);

        [DllImport("user32", EntryPoint = "DestroyCaret", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyCaret();

        [DllImport("user32", EntryPoint = "HideCaret", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HideCaret([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "ShowCaret", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowCaret([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "SetCaretPos", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCaretPos(int X, int Y);

        [DllImport("user32", EntryPoint = "GetCaretPos", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCaretPos([NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", EntryPoint = "ClientToScreen", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClientToScreen([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", EntryPoint = "ScreenToClient", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScreenToClient([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", EntryPoint = "LogicalToPhysicalPoint", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogicalToPhysicalPoint([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", EntryPoint = "PhysicalToLogicalPoint", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PhysicalToLogicalPoint([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", EntryPoint = "LogicalToPhysicalPointForPerMonitorDPI", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogicalToPhysicalPointForPerMonitorDPI([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", EntryPoint = "PhysicalToLogicalPointForPerMonitorDPI", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PhysicalToLogicalPointForPerMonitorDPI([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", EntryPoint = "MapWindowPoints", ExactSpelling = true)]
        public static extern int MapWindowPoints([NativeTypeName("HWND")] IntPtr hWndFrom, [NativeTypeName("HWND")] IntPtr hWndTo, [NativeTypeName("LPPOINT")] POINT* lpPoints, [NativeTypeName("UINT")] uint cPoints);

        [DllImport("user32", EntryPoint = "WindowFromPoint", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr WindowFromPoint(POINT Point);

        [DllImport("user32", EntryPoint = "WindowFromPhysicalPoint", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr WindowFromPhysicalPoint(POINT Point);

        [DllImport("user32", EntryPoint = "ChildWindowFromPoint", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr ChildWindowFromPoint([NativeTypeName("HWND")] IntPtr hWndParent, POINT Point);

        [DllImport("user32", EntryPoint = "ClipCursor", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClipCursor([NativeTypeName("const RECT *")] RECT* lpRect);

        [DllImport("user32", EntryPoint = "ChildWindowFromPointEx", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr ChildWindowFromPointEx([NativeTypeName("HWND")] IntPtr hwnd, POINT pt, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", EntryPoint = "GetSysColor", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetSysColor(int nIndex);

        [DllImport("user32", EntryPoint = "GetSysColorBrush", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr GetSysColorBrush(int nIndex);

        [DllImport("user32", EntryPoint = "SetSysColors", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSysColors(int cElements, [NativeTypeName("const INT *")] int* lpaElements, [NativeTypeName("const COLORREF *")] uint* lpaRgbValues);

        [DllImport("user32", EntryPoint = "DrawFocusRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawFocusRect([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("const RECT *")] RECT* lprc);

        [DllImport("user32", EntryPoint = "FillRect", ExactSpelling = true)]
        public static extern int FillRect([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("HBRUSH")] IntPtr hbr);

        [DllImport("user32", EntryPoint = "FrameRect", ExactSpelling = true)]
        public static extern int FrameRect([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("HBRUSH")] IntPtr hbr);

        [DllImport("user32", EntryPoint = "InvertRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InvertRect([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("const RECT *")] RECT* lprc);

        [DllImport("user32", EntryPoint = "SetRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetRect([NativeTypeName("LPRECT")] RECT* lprc, int xLeft, int yTop, int xRight, int yBottom);

        [DllImport("user32", EntryPoint = "SetRectEmpty", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetRectEmpty([NativeTypeName("LPRECT")] RECT* lprc);

        [DllImport("user32", EntryPoint = "CopyRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc);

        [DllImport("user32", EntryPoint = "InflateRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InflateRect([NativeTypeName("LPRECT")] RECT* lprc, int dx, int dy);

        [DllImport("user32", EntryPoint = "IntersectRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IntersectRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);

        [DllImport("user32", EntryPoint = "UnionRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnionRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);

        [DllImport("user32", EntryPoint = "SubtractRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SubtractRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);

        [DllImport("user32", EntryPoint = "OffsetRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OffsetRect([NativeTypeName("LPRECT")] RECT* lprc, int dx, int dy);

        [DllImport("user32", EntryPoint = "IsRectEmpty", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsRectEmpty([NativeTypeName("const RECT *")] RECT* lprc);

        [DllImport("user32", EntryPoint = "EqualRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EqualRect([NativeTypeName("const RECT *")] RECT* lprc1, [NativeTypeName("const RECT *")] RECT* lprc2);

        [DllImport("user32", EntryPoint = "PtInRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PtInRect([NativeTypeName("const RECT *")] RECT* lprc, POINT pt);

        [DllImport("user32", EntryPoint = "GetWindowWord", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort GetWindowWord([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport("user32", EntryPoint = "SetWindowWord", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort SetWindowWord([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("WORD")] ushort wNewWord);

        [DllImport("user32", EntryPoint = "GetWindowLongA", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetWindowLongA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport("user32", EntryPoint = "GetWindowLongW", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetWindowLongW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport("user32", EntryPoint = "SetWindowLongA", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetWindowLongA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport("user32", EntryPoint = "SetWindowLongW", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetWindowLongW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport("user32", EntryPoint = "GetClassWord", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort GetClassWord([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport("user32", EntryPoint = "SetClassWord", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort SetClassWord([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("WORD")] ushort wNewWord);

        [DllImport("user32", EntryPoint = "GetClassLongA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetClassLongA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport("user32", EntryPoint = "GetClassLongW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetClassLongW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport("user32", EntryPoint = "SetClassLongA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetClassLongA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport("user32", EntryPoint = "SetClassLongW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetClassLongW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport("user32", EntryPoint = "GetProcessDefaultLayout", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessDefaultLayout([NativeTypeName("DWORD *")] uint* pdwDefaultLayout);

        [DllImport("user32", EntryPoint = "SetProcessDefaultLayout", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDefaultLayout([NativeTypeName("DWORD")] uint dwDefaultLayout);

        [DllImport("user32", EntryPoint = "GetDesktopWindow", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32", EntryPoint = "GetParent", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetParent([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "SetParent", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr SetParent([NativeTypeName("HWND")] IntPtr hWndChild, [NativeTypeName("HWND")] IntPtr hWndNewParent);

        [DllImport("user32", EntryPoint = "EnumChildWindows", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumChildWindows([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("WNDENUMPROC")] delegate* stdcall<IntPtr, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "FindWindowA", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr FindWindowA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName);

        [DllImport("user32", EntryPoint = "FindWindowW", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr FindWindowW([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName);

        [DllImport("user32", EntryPoint = "FindWindowExA", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr FindWindowExA([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HWND")] IntPtr hWndChildAfter, [NativeTypeName("LPCSTR")] sbyte* lpszClass, [NativeTypeName("LPCSTR")] sbyte* lpszWindow);

        [DllImport("user32", EntryPoint = "FindWindowExW", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr FindWindowExW([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HWND")] IntPtr hWndChildAfter, [NativeTypeName("LPCWSTR")] ushort* lpszClass, [NativeTypeName("LPCWSTR")] ushort* lpszWindow);

        [DllImport("user32", EntryPoint = "GetShellWindow", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetShellWindow();

        [DllImport("user32", EntryPoint = "RegisterShellHookWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterShellHookWindow([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", EntryPoint = "DeregisterShellHookWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeregisterShellHookWindow([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", EntryPoint = "EnumWindows", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumWindows([NativeTypeName("WNDENUMPROC")] delegate* stdcall<IntPtr, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "EnumThreadWindows", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumThreadWindows([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("WNDENUMPROC")] delegate* stdcall<IntPtr, nint, int> lpfn, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "GetClassNameA", ExactSpelling = true)]
        public static extern int GetClassNameA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPSTR")] sbyte* lpClassName, int nMaxCount);

        [DllImport("user32", EntryPoint = "GetClassNameW", ExactSpelling = true)]
        public static extern int GetClassNameW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPWSTR")] ushort* lpClassName, int nMaxCount);

        [DllImport("user32", EntryPoint = "GetTopWindow", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetTopWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "GetWindowThreadProcessId", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetWindowThreadProcessId([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPDWORD")] uint* lpdwProcessId);

        [DllImport("user32", EntryPoint = "IsGUIThread", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsGUIThread([NativeTypeName("BOOL")] int bConvert);

        [DllImport("user32", EntryPoint = "GetLastActivePopup", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetLastActivePopup([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "GetWindow", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint uCmd);

        [DllImport("user32", EntryPoint = "SetWindowsHookA", ExactSpelling = true)]
        [return: NativeTypeName("HHOOK")]
        public static extern IntPtr SetWindowsHookA(int nFilterType, [NativeTypeName("HOOKPROC")] delegate* stdcall<int, nuint, nint, nint> pfnFilterProc);

        [DllImport("user32", EntryPoint = "SetWindowsHookW", ExactSpelling = true)]
        [return: NativeTypeName("HHOOK")]
        public static extern IntPtr SetWindowsHookW(int nFilterType, [NativeTypeName("HOOKPROC")] delegate* stdcall<int, nuint, nint, nint> pfnFilterProc);

        [DllImport("user32", EntryPoint = "UnhookWindowsHook", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnhookWindowsHook(int nCode, [NativeTypeName("HOOKPROC")] delegate* stdcall<int, nuint, nint, nint> pfnFilterProc);

        [DllImport("user32", EntryPoint = "SetWindowsHookExA", ExactSpelling = true)]
        [return: NativeTypeName("HHOOK")]
        public static extern IntPtr SetWindowsHookExA(int idHook, [NativeTypeName("HOOKPROC")] delegate* stdcall<int, nuint, nint, nint> lpfn, [NativeTypeName("HINSTANCE")] IntPtr hmod, [NativeTypeName("DWORD")] uint dwThreadId);

        [DllImport("user32", EntryPoint = "SetWindowsHookExW", ExactSpelling = true)]
        [return: NativeTypeName("HHOOK")]
        public static extern IntPtr SetWindowsHookExW(int idHook, [NativeTypeName("HOOKPROC")] delegate* stdcall<int, nuint, nint, nint> lpfn, [NativeTypeName("HINSTANCE")] IntPtr hmod, [NativeTypeName("DWORD")] uint dwThreadId);

        [DllImport("user32", EntryPoint = "UnhookWindowsHookEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnhookWindowsHookEx([NativeTypeName("HHOOK")] IntPtr hhk);

        [DllImport("user32", EntryPoint = "CallNextHookEx", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint CallNextHookEx([NativeTypeName("HHOOK")] IntPtr hhk, int nCode, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "CheckMenuRadioItem", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckMenuRadioItem([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint first, [NativeTypeName("UINT")] uint last, [NativeTypeName("UINT")] uint check, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", EntryPoint = "LoadBitmapA", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr LoadBitmapA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpBitmapName);

        [DllImport("user32", EntryPoint = "LoadBitmapW", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr LoadBitmapW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpBitmapName);

        [DllImport("user32", EntryPoint = "LoadCursorA", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr LoadCursorA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpCursorName);

        [DllImport("user32", EntryPoint = "LoadCursorW", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr LoadCursorW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpCursorName);

        [DllImport("user32", EntryPoint = "LoadCursorFromFileA", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr LoadCursorFromFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("user32", EntryPoint = "LoadCursorFromFileW", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr LoadCursorFromFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("user32", EntryPoint = "CreateCursor", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr CreateCursor([NativeTypeName("HINSTANCE")] IntPtr hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, [NativeTypeName("const void *")] void* pvANDPlane, [NativeTypeName("const void *")] void* pvXORPlane);

        [DllImport("user32", EntryPoint = "DestroyCursor", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyCursor([NativeTypeName("HCURSOR")] IntPtr hCursor);

        [DllImport("user32", EntryPoint = "SetSystemCursor", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSystemCursor([NativeTypeName("HCURSOR")] IntPtr hcur, [NativeTypeName("DWORD")] uint id);

        [DllImport("user32", EntryPoint = "LoadIconA", ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr LoadIconA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpIconName);

        [DllImport("user32", EntryPoint = "LoadIconW", ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr LoadIconW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpIconName);

        [DllImport("user32", EntryPoint = "PrivateExtractIconsA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint PrivateExtractIconsA([NativeTypeName("LPCSTR")] sbyte* szFileName, int nIconIndex, int cxIcon, int cyIcon, [NativeTypeName("HICON *")] IntPtr* phicon, [NativeTypeName("UINT *")] uint* piconid, [NativeTypeName("UINT")] uint nIcons, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", EntryPoint = "PrivateExtractIconsW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint PrivateExtractIconsW([NativeTypeName("LPCWSTR")] ushort* szFileName, int nIconIndex, int cxIcon, int cyIcon, [NativeTypeName("HICON *")] IntPtr* phicon, [NativeTypeName("UINT *")] uint* piconid, [NativeTypeName("UINT")] uint nIcons, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", EntryPoint = "CreateIcon", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr CreateIcon([NativeTypeName("HINSTANCE")] IntPtr hInstance, int nWidth, int nHeight, [NativeTypeName("BYTE")] byte cPlanes, [NativeTypeName("BYTE")] byte cBitsPixel, [NativeTypeName("const BYTE *")] byte* lpbANDbits, [NativeTypeName("const BYTE *")] byte* lpbXORbits);

        [DllImport("user32", EntryPoint = "DestroyIcon", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyIcon([NativeTypeName("HICON")] IntPtr hIcon);

        [DllImport("user32", EntryPoint = "LookupIconIdFromDirectory", ExactSpelling = true, SetLastError = true)]
        public static extern int LookupIconIdFromDirectory([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("BOOL")] int fIcon);

        [DllImport("user32", EntryPoint = "LookupIconIdFromDirectoryEx", ExactSpelling = true, SetLastError = true)]
        public static extern int LookupIconIdFromDirectoryEx([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("BOOL")] int fIcon, int cxDesired, int cyDesired, [NativeTypeName("UINT")] uint Flags);

        [DllImport("user32", EntryPoint = "CreateIconFromResource", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr CreateIconFromResource([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("DWORD")] uint dwResSize, [NativeTypeName("BOOL")] int fIcon, [NativeTypeName("DWORD")] uint dwVer);

        [DllImport("user32", EntryPoint = "CreateIconFromResourceEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr CreateIconFromResourceEx([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("DWORD")] uint dwResSize, [NativeTypeName("BOOL")] int fIcon, [NativeTypeName("DWORD")] uint dwVer, int cxDesired, int cyDesired, [NativeTypeName("UINT")] uint Flags);

        [DllImport("user32", EntryPoint = "LoadImageA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr LoadImageA([NativeTypeName("HINSTANCE")] IntPtr hInst, [NativeTypeName("LPCSTR")] sbyte* name, [NativeTypeName("UINT")] uint type, int cx, int cy, [NativeTypeName("UINT")] uint fuLoad);

        [DllImport("user32", EntryPoint = "LoadImageW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr LoadImageW([NativeTypeName("HINSTANCE")] IntPtr hInst, [NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("UINT")] uint type, int cx, int cy, [NativeTypeName("UINT")] uint fuLoad);

        [DllImport("user32", EntryPoint = "CopyImage", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CopyImage([NativeTypeName("HANDLE")] IntPtr h, [NativeTypeName("UINT")] uint type, int cx, int cy, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", EntryPoint = "DrawIconEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawIconEx([NativeTypeName("HDC")] IntPtr hdc, int xLeft, int yTop, [NativeTypeName("HICON")] IntPtr hIcon, int cxWidth, int cyWidth, [NativeTypeName("UINT")] uint istepIfAniCur, [NativeTypeName("HBRUSH")] IntPtr hbrFlickerFreeDraw, [NativeTypeName("UINT")] uint diFlags);

        [DllImport("user32", EntryPoint = "CreateIconIndirect", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr CreateIconIndirect([NativeTypeName("PICONINFO")] ICONINFO* piconinfo);

        [DllImport("user32", EntryPoint = "CopyIcon", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr CopyIcon([NativeTypeName("HICON")] IntPtr hIcon);

        [DllImport("user32", EntryPoint = "GetIconInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetIconInfo([NativeTypeName("HICON")] IntPtr hIcon, [NativeTypeName("PICONINFO")] ICONINFO* piconinfo);

        [DllImport("user32", EntryPoint = "GetIconInfoExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetIconInfoExA([NativeTypeName("HICON")] IntPtr hicon, [NativeTypeName("PICONINFOEXA")] ICONINFOEXA* piconinfo);

        [DllImport("user32", EntryPoint = "GetIconInfoExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetIconInfoExW([NativeTypeName("HICON")] IntPtr hicon, [NativeTypeName("PICONINFOEXW")] ICONINFOEXW* piconinfo);

        [DllImport("user32", EntryPoint = "IsDialogMessageA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsDialogMessageA([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32", EntryPoint = "IsDialogMessageW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsDialogMessageW([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32", EntryPoint = "MapDialogRect", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MapDialogRect([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport("user32", EntryPoint = "DlgDirListA", ExactSpelling = true)]
        public static extern int DlgDirListA([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPSTR")] sbyte* lpPathSpec, int nIDListBox, int nIDStaticPath, [NativeTypeName("UINT")] uint uFileType);

        [DllImport("user32", EntryPoint = "DlgDirListW", ExactSpelling = true)]
        public static extern int DlgDirListW([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPWSTR")] ushort* lpPathSpec, int nIDListBox, int nIDStaticPath, [NativeTypeName("UINT")] uint uFileType);

        [DllImport("user32", EntryPoint = "DlgDirSelectExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DlgDirSelectExA([NativeTypeName("HWND")] IntPtr hwndDlg, [NativeTypeName("LPSTR")] sbyte* lpString, int chCount, int idListBox);

        [DllImport("user32", EntryPoint = "DlgDirSelectExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DlgDirSelectExW([NativeTypeName("HWND")] IntPtr hwndDlg, [NativeTypeName("LPWSTR")] ushort* lpString, int chCount, int idListBox);

        [DllImport("user32", EntryPoint = "DlgDirListComboBoxA", ExactSpelling = true)]
        public static extern int DlgDirListComboBoxA([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPSTR")] sbyte* lpPathSpec, int nIDComboBox, int nIDStaticPath, [NativeTypeName("UINT")] uint uFiletype);

        [DllImport("user32", EntryPoint = "DlgDirListComboBoxW", ExactSpelling = true)]
        public static extern int DlgDirListComboBoxW([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPWSTR")] ushort* lpPathSpec, int nIDComboBox, int nIDStaticPath, [NativeTypeName("UINT")] uint uFiletype);

        [DllImport("user32", EntryPoint = "DlgDirSelectComboBoxExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DlgDirSelectComboBoxExA([NativeTypeName("HWND")] IntPtr hwndDlg, [NativeTypeName("LPSTR")] sbyte* lpString, int cchOut, int idComboBox);

        [DllImport("user32", EntryPoint = "DlgDirSelectComboBoxExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DlgDirSelectComboBoxExW([NativeTypeName("HWND")] IntPtr hwndDlg, [NativeTypeName("LPWSTR")] ushort* lpString, int cchOut, int idComboBox);

        [DllImport("user32", EntryPoint = "SetScrollInfo", ExactSpelling = true)]
        public static extern int SetScrollInfo([NativeTypeName("HWND")] IntPtr hwnd, int nBar, [NativeTypeName("LPCSCROLLINFO")] SCROLLINFO* lpsi, [NativeTypeName("BOOL")] int redraw);

        [DllImport("user32", EntryPoint = "GetScrollInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetScrollInfo([NativeTypeName("HWND")] IntPtr hwnd, int nBar, [NativeTypeName("LPSCROLLINFO")] SCROLLINFO* lpsi);

        [DllImport("user32", EntryPoint = "DefFrameProcA", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefFrameProcA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HWND")] IntPtr hWndMDIClient, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "DefFrameProcW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefFrameProcW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HWND")] IntPtr hWndMDIClient, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "DefMDIChildProcA", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefMDIChildProcA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "DefMDIChildProcW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefMDIChildProcW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "TranslateMDISysAccel", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TranslateMDISysAccel([NativeTypeName("HWND")] IntPtr hWndClient, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32", EntryPoint = "ArrangeIconicWindows", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint ArrangeIconicWindows([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "CreateMDIWindowA", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateMDIWindowA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "CreateMDIWindowW", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateMDIWindowW([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", EntryPoint = "TileWindows", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort TileWindows([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("UINT")] uint wHow, [NativeTypeName("const RECT *")] RECT* lpRect, [NativeTypeName("UINT")] uint cKids, [NativeTypeName("const HWND *")] IntPtr* lpKids);

        [DllImport("user32", EntryPoint = "CascadeWindows", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort CascadeWindows([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("UINT")] uint wHow, [NativeTypeName("const RECT *")] RECT* lpRect, [NativeTypeName("UINT")] uint cKids, [NativeTypeName("const HWND *")] IntPtr* lpKids);

        [DllImport("user32", EntryPoint = "WinHelpA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinHelpA([NativeTypeName("HWND")] IntPtr hWndMain, [NativeTypeName("LPCSTR")] sbyte* lpszHelp, [NativeTypeName("UINT")] uint uCommand, [NativeTypeName("ULONG_PTR")] nuint dwData);

        [DllImport("user32", EntryPoint = "WinHelpW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinHelpW([NativeTypeName("HWND")] IntPtr hWndMain, [NativeTypeName("LPCWSTR")] ushort* lpszHelp, [NativeTypeName("UINT")] uint uCommand, [NativeTypeName("ULONG_PTR")] nuint dwData);

        [DllImport("user32", EntryPoint = "GetGuiResources", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGuiResources([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("DWORD")] uint uiFlags);

        [DllImport("user32", EntryPoint = "ChangeDisplaySettingsA", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ChangeDisplaySettingsA([NativeTypeName("DEVMODEA *")] DEVMODEA* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", EntryPoint = "ChangeDisplaySettingsW", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ChangeDisplaySettingsW([NativeTypeName("DEVMODEW *")] DEVMODEW* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", EntryPoint = "ChangeDisplaySettingsExA", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ChangeDisplaySettingsExA([NativeTypeName("LPCSTR")] sbyte* lpszDeviceName, [NativeTypeName("DEVMODEA *")] DEVMODEA* lpDevMode, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwflags, [NativeTypeName("LPVOID")] void* lParam);

        [DllImport("user32", EntryPoint = "ChangeDisplaySettingsExW", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ChangeDisplaySettingsExW([NativeTypeName("LPCWSTR")] ushort* lpszDeviceName, [NativeTypeName("DEVMODEW *")] DEVMODEW* lpDevMode, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwflags, [NativeTypeName("LPVOID")] void* lParam);

        [DllImport("user32", EntryPoint = "EnumDisplaySettingsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplaySettingsA([NativeTypeName("LPCSTR")] sbyte* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, [NativeTypeName("DEVMODEA *")] DEVMODEA* lpDevMode);

        [DllImport("user32", EntryPoint = "EnumDisplaySettingsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplaySettingsW([NativeTypeName("LPCWSTR")] ushort* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, [NativeTypeName("DEVMODEW *")] DEVMODEW* lpDevMode);

        [DllImport("user32", EntryPoint = "EnumDisplaySettingsExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplaySettingsExA([NativeTypeName("LPCSTR")] sbyte* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, [NativeTypeName("DEVMODEA *")] DEVMODEA* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", EntryPoint = "EnumDisplaySettingsExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplaySettingsExW([NativeTypeName("LPCWSTR")] ushort* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, [NativeTypeName("DEVMODEW *")] DEVMODEW* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", EntryPoint = "EnumDisplayDevicesA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplayDevicesA([NativeTypeName("LPCSTR")] sbyte* lpDevice, [NativeTypeName("DWORD")] uint iDevNum, [NativeTypeName("PDISPLAY_DEVICEA")] DISPLAY_DEVICEA* lpDisplayDevice, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", EntryPoint = "EnumDisplayDevicesW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplayDevicesW([NativeTypeName("LPCWSTR")] ushort* lpDevice, [NativeTypeName("DWORD")] uint iDevNum, [NativeTypeName("PDISPLAY_DEVICEW")] DISPLAY_DEVICEW* lpDisplayDevice, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", EntryPoint = "GetDisplayConfigBufferSizes", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetDisplayConfigBufferSizes([NativeTypeName("UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* numPathArrayElements, [NativeTypeName("UINT32 *")] uint* numModeInfoArrayElements);

        [DllImport("user32", EntryPoint = "SetDisplayConfig", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetDisplayConfig([NativeTypeName("UINT32")] uint numPathArrayElements, [NativeTypeName("DISPLAYCONFIG_PATH_INFO *")] DISPLAYCONFIG_PATH_INFO* pathArray, [NativeTypeName("UINT32")] uint numModeInfoArrayElements, [NativeTypeName("DISPLAYCONFIG_MODE_INFO *")] DISPLAYCONFIG_MODE_INFO* modeInfoArray, [NativeTypeName("UINT32")] uint flags);

        [DllImport("user32", EntryPoint = "QueryDisplayConfig", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int QueryDisplayConfig([NativeTypeName("UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* numPathArrayElements, [NativeTypeName("DISPLAYCONFIG_PATH_INFO *")] DISPLAYCONFIG_PATH_INFO* pathArray, [NativeTypeName("UINT32 *")] uint* numModeInfoArrayElements, [NativeTypeName("DISPLAYCONFIG_MODE_INFO *")] DISPLAYCONFIG_MODE_INFO* modeInfoArray, [NativeTypeName("DISPLAYCONFIG_TOPOLOGY_ID *")] DISPLAYCONFIG_TOPOLOGY_ID* currentTopologyId);

        [DllImport("user32", EntryPoint = "DisplayConfigGetDeviceInfo", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int DisplayConfigGetDeviceInfo([NativeTypeName("DISPLAYCONFIG_DEVICE_INFO_HEADER *")] DISPLAYCONFIG_DEVICE_INFO_HEADER* requestPacket);

        [DllImport("user32", EntryPoint = "DisplayConfigSetDeviceInfo", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int DisplayConfigSetDeviceInfo([NativeTypeName("DISPLAYCONFIG_DEVICE_INFO_HEADER *")] DISPLAYCONFIG_DEVICE_INFO_HEADER* setPacket);

        [DllImport("user32", EntryPoint = "SystemParametersInfoA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SystemParametersInfoA([NativeTypeName("UINT")] uint uiAction, [NativeTypeName("UINT")] uint uiParam, [NativeTypeName("PVOID")] void* pvParam, [NativeTypeName("UINT")] uint fWinIni);

        [DllImport("user32", EntryPoint = "SystemParametersInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SystemParametersInfoW([NativeTypeName("UINT")] uint uiAction, [NativeTypeName("UINT")] uint uiParam, [NativeTypeName("PVOID")] void* pvParam, [NativeTypeName("UINT")] uint fWinIni);

        [DllImport("user32", EntryPoint = "SystemParametersInfoForDpi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SystemParametersInfoForDpi([NativeTypeName("UINT")] uint uiAction, [NativeTypeName("UINT")] uint uiParam, [NativeTypeName("PVOID")] void* pvParam, [NativeTypeName("UINT")] uint fWinIni, [NativeTypeName("UINT")] uint dpi);

        [DllImport("user32", EntryPoint = "SoundSentry", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SoundSentry();

        [DllImport("user32", EntryPoint = "SetDebugErrorLevel", ExactSpelling = true)]
        public static extern void SetDebugErrorLevel([NativeTypeName("DWORD")] uint dwLevel);

        [DllImport("user32", EntryPoint = "SetLastErrorEx", ExactSpelling = true)]
        public static extern void SetLastErrorEx([NativeTypeName("DWORD")] uint dwErrCode, [NativeTypeName("DWORD")] uint dwType);

        [DllImport("user32", EntryPoint = "InternalGetWindowText", ExactSpelling = true, SetLastError = true)]
        public static extern int InternalGetWindowText([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPWSTR")] ushort* pString, int cchMaxCount);

        [DllImport("user32", EntryPoint = "CancelShutdown", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelShutdown();

        [DllImport("user32", EntryPoint = "MonitorFromPoint", ExactSpelling = true)]
        [return: NativeTypeName("HMONITOR")]
        public static extern IntPtr MonitorFromPoint(POINT pt, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", EntryPoint = "MonitorFromRect", ExactSpelling = true)]
        [return: NativeTypeName("HMONITOR")]
        public static extern IntPtr MonitorFromRect([NativeTypeName("LPCRECT")] RECT* lprc, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", EntryPoint = "MonitorFromWindow", ExactSpelling = true)]
        [return: NativeTypeName("HMONITOR")]
        public static extern IntPtr MonitorFromWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", EntryPoint = "GetMonitorInfoA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMonitorInfoA([NativeTypeName("HMONITOR")] IntPtr hMonitor, [NativeTypeName("LPMONITORINFO")] MONITORINFO* lpmi);

        [DllImport("user32", EntryPoint = "GetMonitorInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMonitorInfoW([NativeTypeName("HMONITOR")] IntPtr hMonitor, [NativeTypeName("LPMONITORINFO")] MONITORINFO* lpmi);

        [DllImport("user32", EntryPoint = "EnumDisplayMonitors", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplayMonitors([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCRECT")] RECT* lprcClip, [NativeTypeName("MONITORENUMPROC")] delegate* stdcall<IntPtr, IntPtr, RECT*, nint, int> lpfnEnum, [NativeTypeName("LPARAM")] nint dwData);

        [DllImport("user32", EntryPoint = "NotifyWinEvent", ExactSpelling = true)]
        public static extern void NotifyWinEvent([NativeTypeName("DWORD")] uint @event, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("LONG")] int idChild);

        [DllImport("user32", EntryPoint = "SetWinEventHook", ExactSpelling = true)]
        [return: NativeTypeName("HWINEVENTHOOK")]
        public static extern IntPtr SetWinEventHook([NativeTypeName("DWORD")] uint eventMin, [NativeTypeName("DWORD")] uint eventMax, [NativeTypeName("HMODULE")] IntPtr hmodWinEventProc, [NativeTypeName("WINEVENTPROC")] delegate* stdcall<IntPtr, uint, IntPtr, int, int, uint, uint, void> pfnWinEventProc, [NativeTypeName("DWORD")] uint idProcess, [NativeTypeName("DWORD")] uint idThread, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", EntryPoint = "IsWinEventHookInstalled", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWinEventHookInstalled([NativeTypeName("DWORD")] uint @event);

        [DllImport("user32", EntryPoint = "UnhookWinEvent", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnhookWinEvent([NativeTypeName("HWINEVENTHOOK")] IntPtr hWinEventHook);

        [DllImport("user32", EntryPoint = "GetGUIThreadInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGUIThreadInfo([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("PGUITHREADINFO")] GUITHREADINFO* pgui);

        [DllImport("user32", EntryPoint = "BlockInput", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BlockInput([NativeTypeName("BOOL")] int fBlockIt);

        [DllImport("user32", EntryPoint = "SetProcessDPIAware", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDPIAware();

        [DllImport("user32", EntryPoint = "IsProcessDPIAware", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsProcessDPIAware();

        [DllImport("user32", EntryPoint = "SetThreadDpiAwarenessContext", ExactSpelling = true)]
        [return: NativeTypeName("DPI_AWARENESS_CONTEXT")]
        public static extern IntPtr SetThreadDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr dpiContext);

        [DllImport("user32", EntryPoint = "GetThreadDpiAwarenessContext", ExactSpelling = true)]
        [return: NativeTypeName("DPI_AWARENESS_CONTEXT")]
        public static extern IntPtr GetThreadDpiAwarenessContext();

        [DllImport("user32", EntryPoint = "GetWindowDpiAwarenessContext", ExactSpelling = true)]
        [return: NativeTypeName("DPI_AWARENESS_CONTEXT")]
        public static extern IntPtr GetWindowDpiAwarenessContext([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", EntryPoint = "GetAwarenessFromDpiAwarenessContext", ExactSpelling = true)]
        public static extern DPI_AWARENESS GetAwarenessFromDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr value);

        [DllImport("user32", EntryPoint = "GetDpiFromDpiAwarenessContext", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDpiFromDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr value);

        [DllImport("user32", EntryPoint = "AreDpiAwarenessContextsEqual", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AreDpiAwarenessContextsEqual([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr dpiContextA, [NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr dpiContextB);

        [DllImport("user32", EntryPoint = "IsValidDpiAwarenessContext", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsValidDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr value);

        [DllImport("user32", EntryPoint = "GetDpiForWindow", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDpiForWindow([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", EntryPoint = "GetDpiForSystem", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDpiForSystem();

        [DllImport("user32", EntryPoint = "GetSystemDpiForProcess", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemDpiForProcess([NativeTypeName("HANDLE")] IntPtr hProcess);

        [DllImport("user32", EntryPoint = "EnableNonClientDpiScaling", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableNonClientDpiScaling([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", EntryPoint = "InheritWindowMonitor", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InheritWindowMonitor([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HWND")] IntPtr hwndInherit);

        [DllImport("user32", EntryPoint = "SetProcessDpiAwarenessContext", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr value);

        [DllImport("user32", EntryPoint = "GetDpiAwarenessContextForProcess", ExactSpelling = true)]
        [return: NativeTypeName("DPI_AWARENESS_CONTEXT")]
        public static extern IntPtr GetDpiAwarenessContextForProcess([NativeTypeName("HANDLE")] IntPtr hProcess);

        [DllImport("user32", EntryPoint = "SetThreadDpiHostingBehavior", ExactSpelling = true)]
        public static extern DPI_HOSTING_BEHAVIOR SetThreadDpiHostingBehavior(DPI_HOSTING_BEHAVIOR value);

        [DllImport("user32", EntryPoint = "GetThreadDpiHostingBehavior", ExactSpelling = true)]
        public static extern DPI_HOSTING_BEHAVIOR GetThreadDpiHostingBehavior();

        [DllImport("user32", EntryPoint = "GetWindowDpiHostingBehavior", ExactSpelling = true)]
        public static extern DPI_HOSTING_BEHAVIOR GetWindowDpiHostingBehavior([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", EntryPoint = "GetWindowModuleFileNameA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetWindowModuleFileNameA([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPSTR")] sbyte* pszFileName, [NativeTypeName("UINT")] uint cchFileNameMax);

        [DllImport("user32", EntryPoint = "GetWindowModuleFileNameW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetWindowModuleFileNameW([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPWSTR")] ushort* pszFileName, [NativeTypeName("UINT")] uint cchFileNameMax);

        [DllImport("user32", EntryPoint = "GetCursorInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCursorInfo([NativeTypeName("PCURSORINFO")] CURSORINFO* pci);

        [DllImport("user32", EntryPoint = "GetWindowInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowInfo([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("PWINDOWINFO")] WINDOWINFO* pwi);

        [DllImport("user32", EntryPoint = "GetTitleBarInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTitleBarInfo([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("PTITLEBARINFO")] TITLEBARINFO* pti);

        [DllImport("user32", EntryPoint = "GetMenuBarInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuBarInfo([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("LONG")] int idItem, [NativeTypeName("PMENUBARINFO")] MENUBARINFO* pmbi);

        [DllImport("user32", EntryPoint = "GetScrollBarInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetScrollBarInfo([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("PSCROLLBARINFO")] SCROLLBARINFO* psbi);

        [DllImport("user32", EntryPoint = "GetComboBoxInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetComboBoxInfo([NativeTypeName("HWND")] IntPtr hwndCombo, [NativeTypeName("PCOMBOBOXINFO")] COMBOBOXINFO* pcbi);

        [DllImport("user32", EntryPoint = "GetAncestor", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetAncestor([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint gaFlags);

        [DllImport("user32", EntryPoint = "RealChildWindowFromPoint", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr RealChildWindowFromPoint([NativeTypeName("HWND")] IntPtr hwndParent, POINT ptParentClientCoords);

        [DllImport("user32", EntryPoint = "RealGetWindowClassA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RealGetWindowClassA([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPSTR")] sbyte* ptszClassName, [NativeTypeName("UINT")] uint cchClassNameMax);

        [DllImport("user32", EntryPoint = "RealGetWindowClassW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RealGetWindowClassW([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPWSTR")] ushort* ptszClassName, [NativeTypeName("UINT")] uint cchClassNameMax);

        [DllImport("user32", EntryPoint = "GetAltTabInfoA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAltTabInfoA([NativeTypeName("HWND")] IntPtr hwnd, int iItem, [NativeTypeName("PALTTABINFO")] ALTTABINFO* pati, [NativeTypeName("LPSTR")] sbyte* pszItemText, [NativeTypeName("UINT")] uint cchItemText);

        [DllImport("user32", EntryPoint = "GetAltTabInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAltTabInfoW([NativeTypeName("HWND")] IntPtr hwnd, int iItem, [NativeTypeName("PALTTABINFO")] ALTTABINFO* pati, [NativeTypeName("LPWSTR")] ushort* pszItemText, [NativeTypeName("UINT")] uint cchItemText);

        [DllImport("user32", EntryPoint = "GetListBoxInfo", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetListBoxInfo([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", EntryPoint = "LockWorkStation", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockWorkStation();

        [DllImport("user32", EntryPoint = "UserHandleGrantAccess", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UserHandleGrantAccess([NativeTypeName("HANDLE")] IntPtr hUserHandle, [NativeTypeName("HANDLE")] IntPtr hJob, [NativeTypeName("BOOL")] int bGrant);

        [DllImport("user32", EntryPoint = "GetRawInputData", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRawInputData([NativeTypeName("HRAWINPUT")] IntPtr hRawInput, [NativeTypeName("UINT")] uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize, [NativeTypeName("UINT")] uint cbSizeHeader);

        [DllImport("user32", EntryPoint = "GetRawInputDeviceInfoA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRawInputDeviceInfoA([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("UINT")] uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize);

        [DllImport("user32", EntryPoint = "GetRawInputDeviceInfoW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRawInputDeviceInfoW([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("UINT")] uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize);

        [DllImport("user32", EntryPoint = "GetRawInputBuffer", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRawInputBuffer([NativeTypeName("PRAWINPUT")] RAWINPUT* pData, [NativeTypeName("PUINT")] uint* pcbSize, [NativeTypeName("UINT")] uint cbSizeHeader);

        [DllImport("user32", EntryPoint = "RegisterRawInputDevices", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterRawInputDevices([NativeTypeName("PCRAWINPUTDEVICE")] RAWINPUTDEVICE* pRawInputDevices, [NativeTypeName("UINT")] uint uiNumDevices, [NativeTypeName("UINT")] uint cbSize);

        [DllImport("user32", EntryPoint = "GetRegisteredRawInputDevices", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRegisteredRawInputDevices([NativeTypeName("PRAWINPUTDEVICE")] RAWINPUTDEVICE* pRawInputDevices, [NativeTypeName("PUINT")] uint* puiNumDevices, [NativeTypeName("UINT")] uint cbSize);

        [DllImport("user32", EntryPoint = "GetRawInputDeviceList", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRawInputDeviceList([NativeTypeName("PRAWINPUTDEVICELIST")] RAWINPUTDEVICELIST* pRawInputDeviceList, [NativeTypeName("PUINT")] uint* puiNumDevices, [NativeTypeName("UINT")] uint cbSize);

        [DllImport("user32", EntryPoint = "DefRawInputProc", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefRawInputProc([NativeTypeName("PRAWINPUT *")] RAWINPUT** paRawInput, [NativeTypeName("INT")] int nInput, [NativeTypeName("UINT")] uint cbSizeHeader);

        [DllImport("user32", EntryPoint = "GetPointerDevices", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDevices([NativeTypeName("UINT32 *")] uint* deviceCount, [NativeTypeName("POINTER_DEVICE_INFO *")] POINTER_DEVICE_INFO* pointerDevices);

        [DllImport("user32", EntryPoint = "GetPointerDevice", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDevice([NativeTypeName("HANDLE")] IntPtr device, [NativeTypeName("POINTER_DEVICE_INFO *")] POINTER_DEVICE_INFO* pointerDevice);

        [DllImport("user32", EntryPoint = "GetPointerDeviceProperties", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDeviceProperties([NativeTypeName("HANDLE")] IntPtr device, [NativeTypeName("UINT32 *")] uint* propertyCount, [NativeTypeName("POINTER_DEVICE_PROPERTY *")] POINTER_DEVICE_PROPERTY* pointerProperties);

        [DllImport("user32", EntryPoint = "RegisterPointerDeviceNotifications", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterPointerDeviceNotifications([NativeTypeName("HWND")] IntPtr window, [NativeTypeName("BOOL")] int notifyRange);

        [DllImport("user32", EntryPoint = "GetPointerDeviceRects", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDeviceRects([NativeTypeName("HANDLE")] IntPtr device, [NativeTypeName("RECT *")] RECT* pointerDeviceRect, [NativeTypeName("RECT *")] RECT* displayRect);

        [DllImport("user32", EntryPoint = "GetPointerDeviceCursors", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDeviceCursors([NativeTypeName("HANDLE")] IntPtr device, [NativeTypeName("UINT32 *")] uint* cursorCount, [NativeTypeName("POINTER_DEVICE_CURSOR_INFO *")] POINTER_DEVICE_CURSOR_INFO* deviceCursors);

        [DllImport("user32", EntryPoint = "GetRawPointerDeviceData", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetRawPointerDeviceData([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint historyCount, [NativeTypeName("UINT32")] uint propertiesCount, [NativeTypeName("POINTER_DEVICE_PROPERTY *")] POINTER_DEVICE_PROPERTY* pProperties, [NativeTypeName("LONG *")] int* pValues);

        [DllImport("user32", EntryPoint = "ChangeWindowMessageFilter", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeWindowMessageFilter([NativeTypeName("UINT")] uint message, [NativeTypeName("DWORD")] uint dwFlag);

        [DllImport("user32", EntryPoint = "ChangeWindowMessageFilterEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeWindowMessageFilterEx([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint message, [NativeTypeName("DWORD")] uint action, [NativeTypeName("PCHANGEFILTERSTRUCT")] CHANGEFILTERSTRUCT* pChangeFilterStruct);

        [DllImport("user32", EntryPoint = "GetGestureInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGestureInfo([NativeTypeName("HGESTUREINFO")] IntPtr hGestureInfo, [NativeTypeName("PGESTUREINFO")] GESTUREINFO* pGestureInfo);

        [DllImport("user32", EntryPoint = "GetGestureExtraArgs", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGestureExtraArgs([NativeTypeName("HGESTUREINFO")] IntPtr hGestureInfo, [NativeTypeName("UINT")] uint cbExtraArgs, [NativeTypeName("PBYTE")] byte* pExtraArgs);

        [DllImport("user32", EntryPoint = "CloseGestureInfoHandle", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseGestureInfoHandle([NativeTypeName("HGESTUREINFO")] IntPtr hGestureInfo);

        [DllImport("user32", EntryPoint = "SetGestureConfig", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetGestureConfig([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("UINT")] uint cIDs, [NativeTypeName("PGESTURECONFIG")] GESTURECONFIG* pGestureConfig, [NativeTypeName("UINT")] uint cbSize);

        [DllImport("user32", EntryPoint = "GetGestureConfig", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGestureConfig([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PUINT")] uint* pcIDs, [NativeTypeName("PGESTURECONFIG")] GESTURECONFIG* pGestureConfig, [NativeTypeName("UINT")] uint cbSize);

        [DllImport("user32", EntryPoint = "ShutdownBlockReasonCreate", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShutdownBlockReasonCreate([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* pwszReason);

        [DllImport("user32", EntryPoint = "ShutdownBlockReasonQuery", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShutdownBlockReasonQuery([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPWSTR")] ushort* pwszBuff, [NativeTypeName("DWORD *")] uint* pcchBuff);

        [DllImport("user32", EntryPoint = "ShutdownBlockReasonDestroy", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShutdownBlockReasonDestroy([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", EntryPoint = "GetCurrentInputMessageSource", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentInputMessageSource([NativeTypeName("INPUT_MESSAGE_SOURCE *")] INPUT_MESSAGE_SOURCE* inputMessageSource);

        [DllImport("user32", EntryPoint = "GetCIMSSM", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCIMSSM([NativeTypeName("INPUT_MESSAGE_SOURCE *")] INPUT_MESSAGE_SOURCE* inputMessageSource);

        [DllImport("kernel", EntryPoint = "GetAutoRotationState", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAutoRotationState([NativeTypeName("PAR_STATE")] AR_STATE* pState);

        [DllImport("kernel", EntryPoint = "GetDisplayAutoRotationPreferences", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDisplayAutoRotationPreferences([NativeTypeName("ORIENTATION_PREFERENCE *")] ORIENTATION_PREFERENCE* pOrientation);

        [DllImport("kernel", EntryPoint = "GetDisplayAutoRotationPreferencesByProcessId", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDisplayAutoRotationPreferencesByProcessId([NativeTypeName("DWORD")] uint dwProcessId, [NativeTypeName("ORIENTATION_PREFERENCE *")] ORIENTATION_PREFERENCE* pOrientation, [NativeTypeName("BOOL *")] int* fRotateScreen);

        [DllImport("kernel", EntryPoint = "SetDisplayAutoRotationPreferences", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDisplayAutoRotationPreferences(ORIENTATION_PREFERENCE orientation);

        [DllImport("user32", EntryPoint = "IsImmersiveProcess", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsImmersiveProcess([NativeTypeName("HANDLE")] IntPtr hProcess);

        [DllImport("user32", EntryPoint = "SetProcessRestrictionExemption", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessRestrictionExemption([NativeTypeName("BOOL")] int fEnableExemption);
    }
}
