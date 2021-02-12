// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("user32", ExactSpelling = true)]
        public static extern int wvsprintfA([NativeTypeName("LPSTR")] sbyte* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("va_list")] sbyte* arglist);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int wvsprintfW([NativeTypeName("LPWSTR")] ushort* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("va_list")] sbyte* arglist);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int wsprintfA([NativeTypeName("LPSTR")] sbyte* param0, [NativeTypeName("LPCSTR")] sbyte* param1);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int wsprintfW([NativeTypeName("LPWSTR")] ushort* param0, [NativeTypeName("LPCWSTR")] ushort* param1);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HKL")]
        public static extern IntPtr LoadKeyboardLayoutA([NativeTypeName("LPCSTR")] sbyte* pwszKLID, [NativeTypeName("UINT")] uint Flags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HKL")]
        public static extern IntPtr LoadKeyboardLayoutW([NativeTypeName("LPCWSTR")] ushort* pwszKLID, [NativeTypeName("UINT")] uint Flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HKL")]
        public static extern IntPtr ActivateKeyboardLayout([NativeTypeName("HKL")] IntPtr hkl, [NativeTypeName("UINT")] uint Flags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int ToUnicodeEx([NativeTypeName("UINT")] uint wVirtKey, [NativeTypeName("UINT")] uint wScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWSTR")] ushort* pwszBuff, int cchBuff, [NativeTypeName("UINT")] uint wFlags, [NativeTypeName("HKL")] IntPtr dwhkl);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnloadKeyboardLayout([NativeTypeName("HKL")] IntPtr hkl);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetKeyboardLayoutNameA([NativeTypeName("LPSTR")] sbyte* pwszKLID);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetKeyboardLayoutNameW([NativeTypeName("LPWSTR")] ushort* pwszKLID);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetKeyboardLayoutList(int nBuff, [NativeTypeName("HKL *")] IntPtr* lpList);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HKL")]
        public static extern IntPtr GetKeyboardLayout([NativeTypeName("DWORD")] uint idThread);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetMouseMovePointsEx([NativeTypeName("UINT")] uint cbSize, [NativeTypeName("LPMOUSEMOVEPOINT")] MOUSEMOVEPOINT* lppt, [NativeTypeName("LPMOUSEMOVEPOINT")] MOUSEMOVEPOINT* lpptBuf, int nBufPoints, [NativeTypeName("DWORD")] uint resolution);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr CreateDesktopA([NativeTypeName("LPCSTR")] sbyte* lpszDesktop, [NativeTypeName("LPCSTR")] sbyte* lpszDevice, [NativeTypeName("DEVMODEA *")] DEVMODEA* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr CreateDesktopW([NativeTypeName("LPCWSTR")] ushort* lpszDesktop, [NativeTypeName("LPCWSTR")] ushort* lpszDevice, [NativeTypeName("DEVMODEW *")] DEVMODEW* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr CreateDesktopExA([NativeTypeName("LPCSTR")] sbyte* lpszDesktop, [NativeTypeName("LPCSTR")] sbyte* lpszDevice, [NativeTypeName("DEVMODEA *")] DEVMODEA* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa, [NativeTypeName("ULONG")] uint ulHeapSize, [NativeTypeName("PVOID")] void* pvoid);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr CreateDesktopExW([NativeTypeName("LPCWSTR")] ushort* lpszDesktop, [NativeTypeName("LPCWSTR")] ushort* lpszDevice, [NativeTypeName("DEVMODEW *")] DEVMODEW* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa, [NativeTypeName("ULONG")] uint ulHeapSize, [NativeTypeName("PVOID")] void* pvoid);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr OpenDesktopA([NativeTypeName("LPCSTR")] sbyte* lpszDesktop, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr OpenDesktopW([NativeTypeName("LPCWSTR")] ushort* lpszDesktop, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr OpenInputDesktop([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDesktopsA([NativeTypeName("HWINSTA")] IntPtr hwinsta, [NativeTypeName("DESKTOPENUMPROCA")] delegate* unmanaged<sbyte*, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDesktopsW([NativeTypeName("HWINSTA")] IntPtr hwinsta, [NativeTypeName("DESKTOPENUMPROCW")] delegate* unmanaged<ushort*, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDesktopWindows([NativeTypeName("HDESK")] IntPtr hDesktop, [NativeTypeName("WNDENUMPROC")] delegate* unmanaged<IntPtr, nint, int> lpfn, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SwitchDesktop([NativeTypeName("HDESK")] IntPtr hDesktop);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadDesktop([NativeTypeName("HDESK")] IntPtr hDesktop);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseDesktop([NativeTypeName("HDESK")] IntPtr hDesktop);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr GetThreadDesktop([NativeTypeName("DWORD")] uint dwThreadId);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern IntPtr CreateWindowStationA([NativeTypeName("LPCSTR")] sbyte* lpwinsta, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern IntPtr CreateWindowStationW([NativeTypeName("LPCWSTR")] ushort* lpwinsta, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern IntPtr OpenWindowStationA([NativeTypeName("LPCSTR")] sbyte* lpszWinSta, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern IntPtr OpenWindowStationW([NativeTypeName("LPCWSTR")] ushort* lpszWinSta, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumWindowStationsA([NativeTypeName("WINSTAENUMPROCA")] delegate* unmanaged<sbyte*, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumWindowStationsW([NativeTypeName("WINSTAENUMPROCW")] delegate* unmanaged<ushort*, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseWindowStation([NativeTypeName("HWINSTA")] IntPtr hWinSta);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessWindowStation([NativeTypeName("HWINSTA")] IntPtr hWinSta);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern IntPtr GetProcessWindowStation();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetUserObjectSecurity([NativeTypeName("HANDLE")] IntPtr hObj, [NativeTypeName("PSECURITY_INFORMATION")] uint* pSIRequested, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSID);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserObjectSecurity([NativeTypeName("HANDLE")] IntPtr hObj, [NativeTypeName("PSECURITY_INFORMATION")] uint* pSIRequested, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSID, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserObjectInformationA([NativeTypeName("HANDLE")] IntPtr hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserObjectInformationW([NativeTypeName("HANDLE")] IntPtr hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetUserObjectInformationA([NativeTypeName("HANDLE")] IntPtr hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetUserObjectInformationW([NativeTypeName("HANDLE")] IntPtr hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsHungAppWindow([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern void DisableProcessWindowsGhosting();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RegisterWindowMessageA([NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RegisterWindowMessageW([NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TrackMouseEvent([NativeTypeName("LPTRACKMOUSEEVENT")] TRACKMOUSEEVENT* lpEventTrack);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawEdge([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPRECT")] RECT* qrc, [NativeTypeName("UINT")] uint edge, [NativeTypeName("UINT")] uint grfFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawFrameControl([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("LPRECT")] RECT* param1, [NativeTypeName("UINT")] uint param2, [NativeTypeName("UINT")] uint param3);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawCaption([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const RECT *")] RECT* lprect, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawAnimatedRects([NativeTypeName("HWND")] IntPtr hwnd, int idAni, [NativeTypeName("const RECT *")] RECT* lprcFrom, [NativeTypeName("const RECT *")] RECT* lprcTo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMessageA([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint wMsgFilterMin, [NativeTypeName("UINT")] uint wMsgFilterMax);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMessageW([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint wMsgFilterMin, [NativeTypeName("UINT")] uint wMsgFilterMax);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TranslateMessage([NativeTypeName("const MSG *")] MSG* lpMsg);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DispatchMessageA([NativeTypeName("const MSG *")] MSG* lpMsg);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DispatchMessageW([NativeTypeName("const MSG *")] MSG* lpMsg);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMessageQueue(int cMessagesMax);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PeekMessageA([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint wMsgFilterMin, [NativeTypeName("UINT")] uint wMsgFilterMax, [NativeTypeName("UINT")] uint wRemoveMsg);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PeekMessageW([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint wMsgFilterMin, [NativeTypeName("UINT")] uint wMsgFilterMax, [NativeTypeName("UINT")] uint wRemoveMsg);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterHotKey([NativeTypeName("HWND")] IntPtr hWnd, int id, [NativeTypeName("UINT")] uint fsModifiers, [NativeTypeName("UINT")] uint vk);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterHotKey([NativeTypeName("HWND")] IntPtr hWnd, int id);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExitWindowsEx([NativeTypeName("UINT")] uint uFlags, [NativeTypeName("DWORD")] uint dwReason);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SwapMouseButton([NativeTypeName("BOOL")] int fSwap);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetMessagePos();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetMessageTime();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LPARAM")]
        public static extern nint GetMessageExtraInfo();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetUnpredictedMessagePos();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWow64Message();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LPARAM")]
        public static extern nint SetMessageExtraInfo([NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendMessageA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendMessageW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendMessageTimeoutA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("UINT")] uint fuFlags, [NativeTypeName("UINT")] uint uTimeout, [NativeTypeName("PDWORD_PTR")] nuint* lpdwResult);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendMessageTimeoutW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("UINT")] uint fuFlags, [NativeTypeName("UINT")] uint uTimeout, [NativeTypeName("PDWORD_PTR")] nuint* lpdwResult);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SendNotifyMessageA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SendNotifyMessageW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SendMessageCallbackA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("SENDASYNCPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, void> lpResultCallBack, [NativeTypeName("ULONG_PTR")] nuint dwData);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SendMessageCallbackW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("SENDASYNCPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, void> lpResultCallBack, [NativeTypeName("ULONG_PTR")] nuint dwData);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageExA([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("PBSMINFO")] BSMINFO* pbsmInfo);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageExW([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("PBSMINFO")] BSMINFO* pbsmInfo);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageA([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageW([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HDEVNOTIFY")]
        public static extern void* RegisterDeviceNotificationA([NativeTypeName("HANDLE")] IntPtr hRecipient, [NativeTypeName("LPVOID")] void* NotificationFilter, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HDEVNOTIFY")]
        public static extern void* RegisterDeviceNotificationW([NativeTypeName("HANDLE")] IntPtr hRecipient, [NativeTypeName("LPVOID")] void* NotificationFilter, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterDeviceNotification([NativeTypeName("HDEVNOTIFY")] void* Handle);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HPOWERNOTIFY")]
        public static extern void* RegisterPowerSettingNotification([NativeTypeName("HANDLE")] IntPtr hRecipient, [NativeTypeName("LPCGUID")] Guid* PowerSettingGuid, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterPowerSettingNotification([NativeTypeName("HPOWERNOTIFY")] void* Handle);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HPOWERNOTIFY")]
        public static extern void* RegisterSuspendResumeNotification([NativeTypeName("HANDLE")] IntPtr hRecipient, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterSuspendResumeNotification([NativeTypeName("HPOWERNOTIFY")] void* Handle);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PostMessageA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PostMessageW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PostThreadMessageA([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PostThreadMessageW([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AttachThreadInput([NativeTypeName("DWORD")] uint idAttach, [NativeTypeName("DWORD")] uint idAttachTo, [NativeTypeName("BOOL")] int fAttach);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReplyMessage([NativeTypeName("LRESULT")] nint lResult);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WaitMessage();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WaitForInputIdle([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefWindowProcA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefWindowProcW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern void PostQuitMessage(int nExitCode);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint CallWindowProcA([NativeTypeName("WNDPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpPrevWndFunc, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint CallWindowProcW([NativeTypeName("WNDPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpPrevWndFunc, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InSendMessage();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint InSendMessageEx([NativeTypeName("LPVOID")] void* lpReserved);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDoubleClickTime();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDoubleClickTime([NativeTypeName("UINT")] uint param0);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassA([NativeTypeName("const WNDCLASSA *")] WNDCLASSA* lpWndClass);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassW([NativeTypeName("const WNDCLASSW *")] WNDCLASSW* lpWndClass);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterClassA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("HINSTANCE")] IntPtr hInstance);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterClassW([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("HINSTANCE")] IntPtr hInstance);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClassInfoA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPWNDCLASSA")] WNDCLASSA* lpWndClass);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClassInfoW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPWNDCLASSW")] WNDCLASSW* lpWndClass);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassExA([NativeTypeName("const WNDCLASSEXA *")] WNDCLASSEXA* param0);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassExW([NativeTypeName("const WNDCLASSEXW *")] WNDCLASSEXW* param0);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClassInfoExA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpszClass, [NativeTypeName("LPWNDCLASSEXA")] WNDCLASSEXA* lpwcx);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClassInfoExW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpszClass, [NativeTypeName("LPWNDCLASSEXW")] WNDCLASSEXW* lpwcx);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateWindowExA([NativeTypeName("DWORD")] uint dwExStyle, [NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPVOID")] void* lpParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateWindowExW([NativeTypeName("DWORD")] uint dwExStyle, [NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPVOID")] void* lpParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsMenu([NativeTypeName("HMENU")] IntPtr hMenu);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsChild([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowWindow([NativeTypeName("HWND")] IntPtr hWnd, int nCmdShow);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AnimateWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("DWORD")] uint dwTime, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateLayeredWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HDC")] IntPtr hdcDst, [NativeTypeName("POINT *")] POINT* pptDst, [NativeTypeName("SIZE *")] SIZE* psize, [NativeTypeName("HDC")] IntPtr hdcSrc, [NativeTypeName("POINT *")] POINT* pptSrc, [NativeTypeName("COLORREF")] uint crKey, [NativeTypeName("BLENDFUNCTION *")] BLENDFUNCTION* pblend, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateLayeredWindowIndirect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const UPDATELAYEREDWINDOWINFO *")] UPDATELAYEREDWINDOWINFO* pULWInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLayeredWindowAttributes([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("COLORREF *")] uint* pcrKey, [NativeTypeName("BYTE *")] byte* pbAlpha, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PrintWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HDC")] IntPtr hdcBlt, [NativeTypeName("UINT")] uint nFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetLayeredWindowAttributes([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("COLORREF")] uint crKey, [NativeTypeName("BYTE")] byte bAlpha, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowWindowAsync([NativeTypeName("HWND")] IntPtr hWnd, int nCmdShow);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlashWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("BOOL")] int bInvert);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlashWindowEx([NativeTypeName("PFLASHWINFO")] FLASHWINFO* pfwi);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowOwnedPopups([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("BOOL")] int fShow);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenIcon([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveWindow([NativeTypeName("HWND")] IntPtr hWnd, int X, int Y, int nWidth, int nHeight, [NativeTypeName("BOOL")] int bRepaint);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowPos([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HWND")] IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowPlacement([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("WINDOWPLACEMENT *")] WINDOWPLACEMENT* lpwndpl);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowPlacement([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const WINDOWPLACEMENT *")] WINDOWPLACEMENT* lpwndpl);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowDisplayAffinity([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("DWORD *")] uint* pdwAffinity);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowDisplayAffinity([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("DWORD")] uint dwAffinity);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HDWP")]
        public static extern IntPtr BeginDeferWindowPos(int nNumWindows);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HDWP")]
        public static extern IntPtr DeferWindowPos([NativeTypeName("HDWP")] IntPtr hWinPosInfo, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HWND")] IntPtr hWndInsertAfter, int x, int y, int cx, int cy, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndDeferWindowPos([NativeTypeName("HDWP")] IntPtr hWinPosInfo);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindowVisible([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsIconic([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AnyPopup();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BringWindowToTop([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsZoomed([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateDialogParamA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTemplateName, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateDialogParamW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTemplateName, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateDialogIndirectParamA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEA")] DLGTEMPLATE* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateDialogIndirectParamW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint DialogBoxParamA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTemplateName, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint DialogBoxParamW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTemplateName, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint DialogBoxIndirectParamA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEA")] DLGTEMPLATE* hDialogTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint DialogBoxIndirectParamW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* hDialogTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndDialog([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("INT_PTR")] nint nResult);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetDlgItem([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDlgItemInt([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("UINT")] uint uValue, [NativeTypeName("BOOL")] int bSigned);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDlgItemInt([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("BOOL *")] int* lpTranslated, [NativeTypeName("BOOL")] int bSigned);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDlgItemTextA([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDlgItemTextW([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDlgItemTextA([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("LPSTR")] sbyte* lpString, int cchMax);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDlgItemTextW([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("LPWSTR")] ushort* lpString, int cchMax);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckDlgButton([NativeTypeName("HWND")] IntPtr hDlg, int nIDButton, [NativeTypeName("UINT")] uint uCheck);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckRadioButton([NativeTypeName("HWND")] IntPtr hDlg, int nIDFirstButton, int nIDLastButton, int nIDCheckButton);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint IsDlgButtonChecked([NativeTypeName("HWND")] IntPtr hDlg, int nIDButton);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendDlgItemMessageA([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendDlgItemMessageW([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetNextDlgGroupItem([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("HWND")] IntPtr hCtl, [NativeTypeName("BOOL")] int bPrevious);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetNextDlgTabItem([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("HWND")] IntPtr hCtl, [NativeTypeName("BOOL")] int bPrevious);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetDlgCtrlID([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int GetDialogBaseUnits();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefDlgProcA([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefDlgProcW([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDialogControlDpiChangeBehavior([NativeTypeName("HWND")] IntPtr hWnd, DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS mask, DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS values);

        [DllImport("user32", ExactSpelling = true)]
        public static extern DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS GetDialogControlDpiChangeBehavior([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDialogDpiChangeBehavior([NativeTypeName("HWND")] IntPtr hDlg, DIALOG_DPI_CHANGE_BEHAVIORS mask, DIALOG_DPI_CHANGE_BEHAVIORS values);

        [DllImport("user32", ExactSpelling = true)]
        public static extern DIALOG_DPI_CHANGE_BEHAVIORS GetDialogDpiChangeBehavior([NativeTypeName("HWND")] IntPtr hDlg);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CallMsgFilterA([NativeTypeName("LPMSG")] MSG* lpMsg, int nCode);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CallMsgFilterW([NativeTypeName("LPMSG")] MSG* lpMsg, int nCode);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenClipboard([NativeTypeName("HWND")] IntPtr hWndNewOwner);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseClipboard();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetClipboardSequenceNumber();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetClipboardOwner();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr SetClipboardViewer([NativeTypeName("HWND")] IntPtr hWndNewViewer);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetClipboardViewer();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeClipboardChain([NativeTypeName("HWND")] IntPtr hWndRemove, [NativeTypeName("HWND")] IntPtr hWndNewNext);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr SetClipboardData([NativeTypeName("UINT")] uint uFormat, [NativeTypeName("HANDLE")] IntPtr hMem);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr GetClipboardData([NativeTypeName("UINT")] uint uFormat);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RegisterClipboardFormatA([NativeTypeName("LPCSTR")] sbyte* lpszFormat);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RegisterClipboardFormatW([NativeTypeName("LPCWSTR")] ushort* lpszFormat);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int CountClipboardFormats();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint EnumClipboardFormats([NativeTypeName("UINT")] uint format);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetClipboardFormatNameA([NativeTypeName("UINT")] uint format, [NativeTypeName("LPSTR")] sbyte* lpszFormatName, int cchMaxCount);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetClipboardFormatNameW([NativeTypeName("UINT")] uint format, [NativeTypeName("LPWSTR")] ushort* lpszFormatName, int cchMaxCount);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EmptyClipboard();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsClipboardFormatAvailable([NativeTypeName("UINT")] uint format);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetPriorityClipboardFormat([NativeTypeName("UINT *")] uint* paFormatPriorityList, int cFormats);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetOpenClipboardWindow();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddClipboardFormatListener([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveClipboardFormatListener([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUpdatedClipboardFormats([NativeTypeName("PUINT")] uint* lpuiFormats, [NativeTypeName("UINT")] uint cFormats, [NativeTypeName("PUINT")] uint* pcFormatsOut);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CharToOemA([NativeTypeName("LPCSTR")] sbyte* pSrc, [NativeTypeName("LPSTR")] sbyte* pDst);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CharToOemW([NativeTypeName("LPCWSTR")] ushort* pSrc, [NativeTypeName("LPSTR")] sbyte* pDst);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OemToCharA([NativeTypeName("LPCSTR")] sbyte* pSrc, [NativeTypeName("LPSTR")] sbyte* pDst);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OemToCharW([NativeTypeName("LPCSTR")] sbyte* pSrc, [NativeTypeName("LPWSTR")] ushort* pDst);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CharToOemBuffA([NativeTypeName("LPCSTR")] sbyte* lpszSrc, [NativeTypeName("LPSTR")] sbyte* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CharToOemBuffW([NativeTypeName("LPCWSTR")] ushort* lpszSrc, [NativeTypeName("LPSTR")] sbyte* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OemToCharBuffA([NativeTypeName("LPCSTR")] sbyte* lpszSrc, [NativeTypeName("LPSTR")] sbyte* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OemToCharBuffW([NativeTypeName("LPCSTR")] sbyte* lpszSrc, [NativeTypeName("LPWSTR")] ushort* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharUpperA([NativeTypeName("LPSTR")] sbyte* lpsz);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* CharUpperW([NativeTypeName("LPWSTR")] ushort* lpsz);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CharUpperBuffA([NativeTypeName("LPSTR")] sbyte* lpsz, [NativeTypeName("DWORD")] uint cchLength);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CharUpperBuffW([NativeTypeName("LPWSTR")] ushort* lpsz, [NativeTypeName("DWORD")] uint cchLength);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharLowerA([NativeTypeName("LPSTR")] sbyte* lpsz);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* CharLowerW([NativeTypeName("LPWSTR")] ushort* lpsz);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CharLowerBuffA([NativeTypeName("LPSTR")] sbyte* lpsz, [NativeTypeName("DWORD")] uint cchLength);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CharLowerBuffW([NativeTypeName("LPWSTR")] ushort* lpsz, [NativeTypeName("DWORD")] uint cchLength);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharNextA([NativeTypeName("LPCSTR")] sbyte* lpsz);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* CharNextW([NativeTypeName("LPCWSTR")] ushort* lpsz);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharPrevA([NativeTypeName("LPCSTR")] sbyte* lpszStart, [NativeTypeName("LPCSTR")] sbyte* lpszCurrent);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* CharPrevW([NativeTypeName("LPCWSTR")] ushort* lpszStart, [NativeTypeName("LPCWSTR")] ushort* lpszCurrent);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharNextExA([NativeTypeName("WORD")] ushort CodePage, [NativeTypeName("LPCSTR")] sbyte* lpCurrentChar, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharPrevExA([NativeTypeName("WORD")] ushort CodePage, [NativeTypeName("LPCSTR")] sbyte* lpStart, [NativeTypeName("LPCSTR")] sbyte* lpCurrentChar, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharAlphaA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharAlphaW([NativeTypeName("WCHAR")] ushort ch);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharAlphaNumericA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharAlphaNumericW([NativeTypeName("WCHAR")] ushort ch);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharUpperA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharUpperW([NativeTypeName("WCHAR")] ushort ch);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharLowerA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharLowerW([NativeTypeName("WCHAR")] ushort ch);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr SetFocus([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetActiveWindow();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetFocus();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetKBCodePage();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("SHORT")]
        public static extern short GetKeyState(int nVirtKey);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("SHORT")]
        public static extern short GetAsyncKeyState(int vKey);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetKeyboardState([NativeTypeName("PBYTE")] byte* lpKeyState);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetKeyboardState([NativeTypeName("LPBYTE")] byte* lpKeyState);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetKeyNameTextA([NativeTypeName("LONG")] int lParam, [NativeTypeName("LPSTR")] sbyte* lpString, int cchSize);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetKeyNameTextW([NativeTypeName("LONG")] int lParam, [NativeTypeName("LPWSTR")] ushort* lpString, int cchSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetKeyboardType(int nTypeFlag);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int ToAscii([NativeTypeName("UINT")] uint uVirtKey, [NativeTypeName("UINT")] uint uScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWORD")] ushort* lpChar, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int ToAsciiEx([NativeTypeName("UINT")] uint uVirtKey, [NativeTypeName("UINT")] uint uScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWORD")] ushort* lpChar, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("HKL")] IntPtr dwhkl);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int ToUnicode([NativeTypeName("UINT")] uint wVirtKey, [NativeTypeName("UINT")] uint wScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWSTR")] ushort* pwszBuff, int cchBuff, [NativeTypeName("UINT")] uint wFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint OemKeyScan([NativeTypeName("WORD")] ushort wOemChar);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("SHORT")]
        public static extern short VkKeyScanA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("SHORT")]
        public static extern short VkKeyScanW([NativeTypeName("WCHAR")] ushort ch);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("SHORT")]
        public static extern short VkKeyScanExA([NativeTypeName("CHAR")] sbyte ch, [NativeTypeName("HKL")] IntPtr dwhkl);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("SHORT")]
        public static extern short VkKeyScanExW([NativeTypeName("WCHAR")] ushort ch, [NativeTypeName("HKL")] IntPtr dwhkl);

        [DllImport("user32", ExactSpelling = true)]
        public static extern void keybd_event([NativeTypeName("BYTE")] byte bVk, [NativeTypeName("BYTE")] byte bScan, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG_PTR")] nuint dwExtraInfo);

        [DllImport("user32", ExactSpelling = true)]
        public static extern void mouse_event([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dx, [NativeTypeName("DWORD")] uint dy, [NativeTypeName("DWORD")] uint dwData, [NativeTypeName("ULONG_PTR")] nuint dwExtraInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SendInput([NativeTypeName("UINT")] uint cInputs, [NativeTypeName("LPINPUT")] INPUT* pInputs, int cbSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTouchInputInfo([NativeTypeName("HTOUCHINPUT")] IntPtr hTouchInput, [NativeTypeName("UINT")] uint cInputs, [NativeTypeName("PTOUCHINPUT")] TOUCHINPUT* pInputs, int cbSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseTouchInputHandle([NativeTypeName("HTOUCHINPUT")] IntPtr hTouchInput);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterTouchWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("ULONG")] uint ulFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterTouchWindow([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsTouchWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("PULONG")] uint* pulFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeTouchInjection([NativeTypeName("UINT32")] uint maxCount, [NativeTypeName("DWORD")] uint dwMode);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InjectTouchInput([NativeTypeName("UINT32")] uint count, [NativeTypeName("const POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* contacts);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerType([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_INPUT_TYPE *")] uint* pointerType);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerCursorId([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* cursorId);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_INFO *")] POINTER_INFO* pointerInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("POINTER_INFO *")] POINTER_INFO* pointerInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFrameInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_INFO *")] POINTER_INFO* pointerInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFrameInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_INFO *")] POINTER_INFO* pointerInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerTouchInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* touchInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerTouchInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* touchInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFrameTouchInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* touchInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFrameTouchInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* touchInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerPenInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_PEN_INFO *")] POINTER_PEN_INFO* penInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerPenInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("POINTER_PEN_INFO *")] POINTER_PEN_INFO* penInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFramePenInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_PEN_INFO *")] POINTER_PEN_INFO* penInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFramePenInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_PEN_INFO *")] POINTER_PEN_INFO* penInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SkipPointerFrameMessages([NativeTypeName("UINT32")] uint pointerId);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterPointerInputTarget([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterPointerInputTarget([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterPointerInputTargetEx([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType, [NativeTypeName("BOOL")] int fObserve);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterPointerInputTargetEx([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HSYNTHETICPOINTERDEVICE")]
        public static extern IntPtr CreateSyntheticPointerDevice([NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType, [NativeTypeName("ULONG")] uint maxCount, POINTER_FEEDBACK_MODE mode);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InjectSyntheticPointerInput([NativeTypeName("HSYNTHETICPOINTERDEVICE")] IntPtr device, [NativeTypeName("const POINTER_TYPE_INFO *")] POINTER_TYPE_INFO* pointerInfo, [NativeTypeName("UINT32")] uint count);

        [DllImport("user32", ExactSpelling = true)]
        public static extern void DestroySyntheticPointerDevice([NativeTypeName("HSYNTHETICPOINTERDEVICE")] IntPtr device);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableMouseInPointer([NativeTypeName("BOOL")] int fEnable);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsMouseInPointerEnabled();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableMouseInPointerForThread();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterTouchHitTestingWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("ULONG")] uint value);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EvaluateProximityToRect([NativeTypeName("const RECT *")] RECT* controlBoundingBox, [NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] TOUCH_HIT_TESTING_INPUT* pHitTestingInput, [NativeTypeName("TOUCH_HIT_TESTING_PROXIMITY_EVALUATION *")] TOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EvaluateProximityToPolygon([NativeTypeName("UINT32")] uint numVertices, [NativeTypeName("const POINT *")] POINT* controlPolygon, [NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] TOUCH_HIT_TESTING_INPUT* pHitTestingInput, [NativeTypeName("TOUCH_HIT_TESTING_PROXIMITY_EVALUATION *")] TOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint PackTouchHitTestingProximityEvaluation([NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] TOUCH_HIT_TESTING_INPUT* pHitTestingInput, [NativeTypeName("const TOUCH_HIT_TESTING_PROXIMITY_EVALUATION *")] TOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowFeedbackSetting([NativeTypeName("HWND")] IntPtr hwnd, FEEDBACK_TYPE feedback, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("UINT32 *")] uint* pSize, [NativeTypeName("void *")] void* config);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowFeedbackSetting([NativeTypeName("HWND")] IntPtr hwnd, FEEDBACK_TYPE feedback, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("UINT32")] uint size, [NativeTypeName("const void *")] void* configuration);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerInputTransform([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint historyCount, [NativeTypeName("INPUT_TRANSFORM *")] INPUT_TRANSFORM* inputTransform);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLastInputInfo([NativeTypeName("PLASTINPUTINFO")] LASTINPUTINFO* plii);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MapVirtualKeyA([NativeTypeName("UINT")] uint uCode, [NativeTypeName("UINT")] uint uMapType);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MapVirtualKeyW([NativeTypeName("UINT")] uint uCode, [NativeTypeName("UINT")] uint uMapType);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MapVirtualKeyExA([NativeTypeName("UINT")] uint uCode, [NativeTypeName("UINT")] uint uMapType, [NativeTypeName("HKL")] IntPtr dwhkl);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MapVirtualKeyExW([NativeTypeName("UINT")] uint uCode, [NativeTypeName("UINT")] uint uMapType, [NativeTypeName("HKL")] IntPtr dwhkl);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetInputState();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetQueueStatus([NativeTypeName("UINT")] uint flags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetCapture();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr SetCapture([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReleaseCapture();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MsgWaitForMultipleObjects([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] IntPtr* pHandles, [NativeTypeName("BOOL")] int fWaitAll, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("DWORD")] uint dwWakeMask);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MsgWaitForMultipleObjectsEx([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] IntPtr* pHandles, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("DWORD")] uint dwWakeMask, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT_PTR")]
        public static extern nuint SetTimer([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT_PTR")] nuint nIDEvent, [NativeTypeName("UINT")] uint uElapse, [NativeTypeName("TIMERPROC")] delegate* unmanaged<IntPtr, uint, nuint, uint, void> lpTimerFunc);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT_PTR")]
        public static extern nuint SetCoalescableTimer([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT_PTR")] nuint nIDEvent, [NativeTypeName("UINT")] uint uElapse, [NativeTypeName("TIMERPROC")] delegate* unmanaged<IntPtr, uint, nuint, uint, void> lpTimerFunc, [NativeTypeName("ULONG")] uint uToleranceDelay);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int KillTimer([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT_PTR")] nuint uIDEvent);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindowUnicode([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("BOOL")] int bEnable);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindowEnabled([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HACCEL")]
        public static extern IntPtr LoadAcceleratorsA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTableName);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HACCEL")]
        public static extern IntPtr LoadAcceleratorsW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTableName);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HACCEL")]
        public static extern IntPtr CreateAcceleratorTableA([NativeTypeName("LPACCEL")] ACCEL* paccel, int cAccel);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HACCEL")]
        public static extern IntPtr CreateAcceleratorTableW([NativeTypeName("LPACCEL")] ACCEL* paccel, int cAccel);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyAcceleratorTable([NativeTypeName("HACCEL")] IntPtr hAccel);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int CopyAcceleratorTableA([NativeTypeName("HACCEL")] IntPtr hAccelSrc, [NativeTypeName("LPACCEL")] ACCEL* lpAccelDst, int cAccelEntries);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int CopyAcceleratorTableW([NativeTypeName("HACCEL")] IntPtr hAccelSrc, [NativeTypeName("LPACCEL")] ACCEL* lpAccelDst, int cAccelEntries);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int TranslateAcceleratorA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HACCEL")] IntPtr hAccTable, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int TranslateAcceleratorW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HACCEL")] IntPtr hAccTable, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetSystemMetrics(int nIndex);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetSystemMetricsForDpi(int nIndex, [NativeTypeName("UINT")] uint dpi);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr LoadMenuA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpMenuName);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr LoadMenuW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpMenuName);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr LoadMenuIndirectA([NativeTypeName("const MENUTEMPLATEA *")] void* lpMenuTemplate);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr LoadMenuIndirectW([NativeTypeName("const MENUTEMPLATEW *")] void* lpMenuTemplate);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr GetMenu([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenu([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HMENU")] IntPtr hMenu);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeMenuA([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint cmd, [NativeTypeName("LPCSTR")] sbyte* lpszNewItem, [NativeTypeName("UINT")] uint cmdInsert, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeMenuW([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint cmd, [NativeTypeName("LPCWSTR")] ushort* lpszNewItem, [NativeTypeName("UINT")] uint cmdInsert, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HiliteMenuItem([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uIDHiliteItem, [NativeTypeName("UINT")] uint uHilite);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetMenuStringA([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uIDItem, [NativeTypeName("LPSTR")] sbyte* lpString, int cchMax, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetMenuStringW([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uIDItem, [NativeTypeName("LPWSTR")] ushort* lpString, int cchMax, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetMenuState([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uId, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawMenuBar([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr GetSystemMenu([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("BOOL")] int bRevert);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr CreateMenu();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr CreatePopupMenu();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyMenu([NativeTypeName("HMENU")] IntPtr hMenu);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CheckMenuItem([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uIDCheckItem, [NativeTypeName("UINT")] uint uCheck);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableMenuItem([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uIDEnableItem, [NativeTypeName("UINT")] uint uEnable);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr GetSubMenu([NativeTypeName("HMENU")] IntPtr hMenu, int nPos);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetMenuItemID([NativeTypeName("HMENU")] IntPtr hMenu, int nPos);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetMenuItemCount([NativeTypeName("HMENU")] IntPtr hMenu);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InsertMenuA([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCSTR")] sbyte* lpNewItem);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InsertMenuW([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCWSTR")] ushort* lpNewItem);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AppendMenuA([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCSTR")] sbyte* lpNewItem);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AppendMenuW([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCWSTR")] ushort* lpNewItem);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ModifyMenuA([NativeTypeName("HMENU")] IntPtr hMnu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCSTR")] sbyte* lpNewItem);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ModifyMenuW([NativeTypeName("HMENU")] IntPtr hMnu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCWSTR")] ushort* lpNewItem);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveMenu([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteMenu([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuItemBitmaps([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("HBITMAP")] IntPtr hBitmapUnchecked, [NativeTypeName("HBITMAP")] IntPtr hBitmapChecked);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetMenuCheckMarkDimensions();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TrackPopupMenu([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uFlags, int x, int y, int nReserved, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const RECT *")] RECT* prcRect);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TrackPopupMenuEx([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uFlags, int x, int y, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPTPMPARAMS")] TPMPARAMS* lptpm);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CalculatePopupWindowPosition([NativeTypeName("const POINT *")] POINT* anchorPoint, [NativeTypeName("const SIZE *")] SIZE* windowSize, [NativeTypeName("UINT")] uint flags, [NativeTypeName("RECT *")] RECT* excludeRect, [NativeTypeName("RECT *")] RECT* popupWindowPosition);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuInfo([NativeTypeName("HMENU")] IntPtr param0, [NativeTypeName("LPMENUINFO")] MENUINFO* param1);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuInfo([NativeTypeName("HMENU")] IntPtr param0, [NativeTypeName("LPCMENUINFO")] MENUINFO* param1);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndMenu();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InsertMenuItemA([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint item, [NativeTypeName("BOOL")] int fByPosition, [NativeTypeName("LPCMENUITEMINFOA")] MENUITEMINFOA* lpmi);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InsertMenuItemW([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint item, [NativeTypeName("BOOL")] int fByPosition, [NativeTypeName("LPCMENUITEMINFOW")] MENUITEMINFOW* lpmi);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuItemInfoA([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint item, [NativeTypeName("BOOL")] int fByPosition, [NativeTypeName("LPMENUITEMINFOA")] MENUITEMINFOA* lpmii);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuItemInfoW([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint item, [NativeTypeName("BOOL")] int fByPosition, [NativeTypeName("LPMENUITEMINFOW")] MENUITEMINFOW* lpmii);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuItemInfoA([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint item, [NativeTypeName("BOOL")] int fByPositon, [NativeTypeName("LPCMENUITEMINFOA")] MENUITEMINFOA* lpmii);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuItemInfoW([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint item, [NativeTypeName("BOOL")] int fByPositon, [NativeTypeName("LPCMENUITEMINFOW")] MENUITEMINFOW* lpmii);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetMenuDefaultItem([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint fByPos, [NativeTypeName("UINT")] uint gmdiFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuDefaultItem([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uItem, [NativeTypeName("UINT")] uint fByPos);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuItemRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uItem, [NativeTypeName("LPRECT")] RECT* lprcItem);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int MenuItemFromPoint([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HMENU")] IntPtr hMenu, POINT ptScreen);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DragObject([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("HWND")] IntPtr hwndFrom, [NativeTypeName("UINT")] uint fmt, [NativeTypeName("ULONG_PTR")] nuint data, [NativeTypeName("HCURSOR")] IntPtr hcur);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DragDetect([NativeTypeName("HWND")] IntPtr hwnd, POINT pt);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawIcon([NativeTypeName("HDC")] IntPtr hDC, int X, int Y, [NativeTypeName("HICON")] IntPtr hIcon);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int DrawTextA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, [NativeTypeName("UINT")] uint format);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int DrawTextW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, [NativeTypeName("UINT")] uint format);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int DrawTextExA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPSTR")] sbyte* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, [NativeTypeName("UINT")] uint format, [NativeTypeName("LPDRAWTEXTPARAMS")] DRAWTEXTPARAMS* lpdtp);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int DrawTextExW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPWSTR")] ushort* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, [NativeTypeName("UINT")] uint format, [NativeTypeName("LPDRAWTEXTPARAMS")] DRAWTEXTPARAMS* lpdtp);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GrayStringA([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("HBRUSH")] IntPtr hBrush, [NativeTypeName("GRAYSTRINGPROC")] delegate* unmanaged<IntPtr, nint, int, int> lpOutputFunc, [NativeTypeName("LPARAM")] nint lpData, int nCount, int X, int Y, int nWidth, int nHeight);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GrayStringW([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("HBRUSH")] IntPtr hBrush, [NativeTypeName("GRAYSTRINGPROC")] delegate* unmanaged<IntPtr, nint, int, int> lpOutputFunc, [NativeTypeName("LPARAM")] nint lpData, int nCount, int X, int Y, int nWidth, int nHeight);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawStateA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HBRUSH")] IntPtr hbrFore, [NativeTypeName("DRAWSTATEPROC")] delegate* unmanaged<IntPtr, nint, nuint, int, int, int> qfnCallBack, [NativeTypeName("LPARAM")] nint lData, [NativeTypeName("WPARAM")] nuint wData, int x, int y, int cx, int cy, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawStateW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HBRUSH")] IntPtr hbrFore, [NativeTypeName("DRAWSTATEPROC")] delegate* unmanaged<IntPtr, nint, nuint, int, int, int> qfnCallBack, [NativeTypeName("LPARAM")] nint lData, [NativeTypeName("WPARAM")] nuint wData, int x, int y, int cx, int cy, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int TabbedTextOutA([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPCSTR")] sbyte* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions, int nTabOrigin);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int TabbedTextOutW([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPCWSTR")] ushort* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions, int nTabOrigin);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTabbedTextExtentA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTabbedTextExtentW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr SetActiveWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PaintDesktop([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("user32", ExactSpelling = true)]
        public static extern void SwitchToThisWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("BOOL")] int fUnknown);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetForegroundWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AllowSetForegroundWindow([NativeTypeName("DWORD")] uint dwProcessId);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockSetForegroundWindow([NativeTypeName("UINT")] uint uLockCode);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr WindowFromDC([NativeTypeName("HDC")] IntPtr hDC);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr GetDC([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr GetDCEx([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hrgnClip, [NativeTypeName("DWORD")] uint flags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr GetWindowDC([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int ReleaseDC([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HDC")] IntPtr hDC);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr BeginPaint([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPAINTSTRUCT")] PAINTSTRUCT* lpPaint);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndPaint([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const PAINTSTRUCT *")] PAINTSTRUCT* lpPaint);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUpdateRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("BOOL")] int bErase);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetUpdateRgn([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hRgn, [NativeTypeName("BOOL")] int bErase);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int SetWindowRgn([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hRgn, [NativeTypeName("BOOL")] int bRedraw);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetWindowRgn([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hRgn);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetWindowRgnBox([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPRECT")] RECT* lprc);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int ExcludeUpdateRgn([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InvalidateRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const RECT *")] RECT* lpRect, [NativeTypeName("BOOL")] int bErase);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ValidateRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const RECT *")] RECT* lpRect);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InvalidateRgn([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hRgn, [NativeTypeName("BOOL")] int bErase);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ValidateRgn([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hRgn);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RedrawWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const RECT *")] RECT* lprcUpdate, [NativeTypeName("HRGN")] IntPtr hrgnUpdate, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockWindowUpdate([NativeTypeName("HWND")] IntPtr hWndLock);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScrollWindow([NativeTypeName("HWND")] IntPtr hWnd, int XAmount, int YAmount, [NativeTypeName("const RECT *")] RECT* lpRect, [NativeTypeName("const RECT *")] RECT* lpClipRect);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScrollDC([NativeTypeName("HDC")] IntPtr hDC, int dx, int dy, [NativeTypeName("const RECT *")] RECT* lprcScroll, [NativeTypeName("const RECT *")] RECT* lprcClip, [NativeTypeName("HRGN")] IntPtr hrgnUpdate, [NativeTypeName("LPRECT")] RECT* lprcUpdate);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int ScrollWindowEx([NativeTypeName("HWND")] IntPtr hWnd, int dx, int dy, [NativeTypeName("const RECT *")] RECT* prcScroll, [NativeTypeName("const RECT *")] RECT* prcClip, [NativeTypeName("HRGN")] IntPtr hrgnUpdate, [NativeTypeName("LPRECT")] RECT* prcUpdate, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int SetScrollPos([NativeTypeName("HWND")] IntPtr hWnd, int nBar, int nPos, [NativeTypeName("BOOL")] int bRedraw);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetScrollPos([NativeTypeName("HWND")] IntPtr hWnd, int nBar);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetScrollRange([NativeTypeName("HWND")] IntPtr hWnd, int nBar, int nMinPos, int nMaxPos, [NativeTypeName("BOOL")] int bRedraw);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetScrollRange([NativeTypeName("HWND")] IntPtr hWnd, int nBar, [NativeTypeName("LPINT")] int* lpMinPos, [NativeTypeName("LPINT")] int* lpMaxPos);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowScrollBar([NativeTypeName("HWND")] IntPtr hWnd, int wBar, [NativeTypeName("BOOL")] int bShow);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableScrollBar([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint wSBflags, [NativeTypeName("UINT")] uint wArrows);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPropA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("HANDLE")] IntPtr hData);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPropW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("HANDLE")] IntPtr hData);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr GetPropA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr GetPropW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr RemovePropA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr RemovePropW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int EnumPropsExA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("PROPENUMPROCEXA")] delegate* unmanaged<IntPtr, sbyte*, IntPtr, nuint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int EnumPropsExW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("PROPENUMPROCEXW")] delegate* unmanaged<IntPtr, ushort*, IntPtr, nuint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int EnumPropsA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("PROPENUMPROCA")] delegate* unmanaged<IntPtr, sbyte*, IntPtr, int> lpEnumFunc);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int EnumPropsW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("PROPENUMPROCW")] delegate* unmanaged<IntPtr, ushort*, IntPtr, int> lpEnumFunc);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowTextA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowTextW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetWindowTextA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPSTR")] sbyte* lpString, int nMaxCount);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetWindowTextW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPWSTR")] ushort* lpString, int nMaxCount);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetWindowTextLengthA([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetWindowTextLengthW([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClientRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AdjustWindowRect([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("BOOL")] int bMenu);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AdjustWindowRectEx([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("BOOL")] int bMenu, [NativeTypeName("DWORD")] uint dwExStyle);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AdjustWindowRectExForDpi([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("BOOL")] int bMenu, [NativeTypeName("DWORD")] uint dwExStyle, [NativeTypeName("UINT")] uint dpi);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowContextHelpId([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("DWORD")] uint param1);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetWindowContextHelpId([NativeTypeName("HWND")] IntPtr param0);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuContextHelpId([NativeTypeName("HMENU")] IntPtr param0, [NativeTypeName("DWORD")] uint param1);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetMenuContextHelpId([NativeTypeName("HMENU")] IntPtr param0);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int MessageBoxA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCSTR")] sbyte* lpText, [NativeTypeName("LPCSTR")] sbyte* lpCaption, [NativeTypeName("UINT")] uint uType);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int MessageBoxW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpText, [NativeTypeName("LPCWSTR")] ushort* lpCaption, [NativeTypeName("UINT")] uint uType);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int MessageBoxExA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCSTR")] sbyte* lpText, [NativeTypeName("LPCSTR")] sbyte* lpCaption, [NativeTypeName("UINT")] uint uType, [NativeTypeName("WORD")] ushort wLanguageId);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int MessageBoxExW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpText, [NativeTypeName("LPCWSTR")] ushort* lpCaption, [NativeTypeName("UINT")] uint uType, [NativeTypeName("WORD")] ushort wLanguageId);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int MessageBoxIndirectA([NativeTypeName("const MSGBOXPARAMSA *")] MSGBOXPARAMSA* lpmbp);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int MessageBoxIndirectW([NativeTypeName("const MSGBOXPARAMSW *")] MSGBOXPARAMSW* lpmbp);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MessageBeep([NativeTypeName("UINT")] uint uType);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int ShowCursor([NativeTypeName("BOOL")] int bShow);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCursorPos(int X, int Y);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPhysicalCursorPos(int X, int Y);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr SetCursor([NativeTypeName("HCURSOR")] IntPtr hCursor);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCursorPos([NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPhysicalCursorPos([NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClipCursor([NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr GetCursor();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateCaret([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HBITMAP")] IntPtr hBitmap, int nWidth, int nHeight);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetCaretBlinkTime();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCaretBlinkTime([NativeTypeName("UINT")] uint uMSeconds);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyCaret();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HideCaret([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowCaret([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCaretPos(int X, int Y);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCaretPos([NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClientToScreen([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScreenToClient([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogicalToPhysicalPoint([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PhysicalToLogicalPoint([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogicalToPhysicalPointForPerMonitorDPI([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PhysicalToLogicalPointForPerMonitorDPI([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int MapWindowPoints([NativeTypeName("HWND")] IntPtr hWndFrom, [NativeTypeName("HWND")] IntPtr hWndTo, [NativeTypeName("LPPOINT")] POINT* lpPoints, [NativeTypeName("UINT")] uint cPoints);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr WindowFromPoint(POINT Point);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr WindowFromPhysicalPoint(POINT Point);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr ChildWindowFromPoint([NativeTypeName("HWND")] IntPtr hWndParent, POINT Point);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClipCursor([NativeTypeName("const RECT *")] RECT* lpRect);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr ChildWindowFromPointEx([NativeTypeName("HWND")] IntPtr hwnd, POINT pt, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetSysColor(int nIndex);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr GetSysColorBrush(int nIndex);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSysColors(int cElements, [NativeTypeName("const INT *")] int* lpaElements, [NativeTypeName("const COLORREF *")] uint* lpaRgbValues);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawFocusRect([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("const RECT *")] RECT* lprc);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int FillRect([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("HBRUSH")] IntPtr hbr);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int FrameRect([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("HBRUSH")] IntPtr hbr);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InvertRect([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("const RECT *")] RECT* lprc);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetRect([NativeTypeName("LPRECT")] RECT* lprc, int xLeft, int yTop, int xRight, int yBottom);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetRectEmpty([NativeTypeName("LPRECT")] RECT* lprc);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InflateRect([NativeTypeName("LPRECT")] RECT* lprc, int dx, int dy);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IntersectRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnionRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SubtractRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OffsetRect([NativeTypeName("LPRECT")] RECT* lprc, int dx, int dy);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsRectEmpty([NativeTypeName("const RECT *")] RECT* lprc);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EqualRect([NativeTypeName("const RECT *")] RECT* lprc1, [NativeTypeName("const RECT *")] RECT* lprc2);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PtInRect([NativeTypeName("const RECT *")] RECT* lprc, POINT pt);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort GetWindowWord([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort SetWindowWord([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("WORD")] ushort wNewWord);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetWindowLongA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetWindowLongW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetWindowLongA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetWindowLongW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort GetClassWord([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort SetClassWord([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("WORD")] ushort wNewWord);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetClassLongA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetClassLongW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetClassLongA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetClassLongW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessDefaultLayout([NativeTypeName("DWORD *")] uint* pdwDefaultLayout);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDefaultLayout([NativeTypeName("DWORD")] uint dwDefaultLayout);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetParent([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr SetParent([NativeTypeName("HWND")] IntPtr hWndChild, [NativeTypeName("HWND")] IntPtr hWndNewParent);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumChildWindows([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("WNDENUMPROC")] delegate* unmanaged<IntPtr, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr FindWindowA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr FindWindowW([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr FindWindowExA([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HWND")] IntPtr hWndChildAfter, [NativeTypeName("LPCSTR")] sbyte* lpszClass, [NativeTypeName("LPCSTR")] sbyte* lpszWindow);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr FindWindowExW([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HWND")] IntPtr hWndChildAfter, [NativeTypeName("LPCWSTR")] ushort* lpszClass, [NativeTypeName("LPCWSTR")] ushort* lpszWindow);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetShellWindow();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterShellHookWindow([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeregisterShellHookWindow([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumWindows([NativeTypeName("WNDENUMPROC")] delegate* unmanaged<IntPtr, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumThreadWindows([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("WNDENUMPROC")] delegate* unmanaged<IntPtr, nint, int> lpfn, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetClassNameA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPSTR")] sbyte* lpClassName, int nMaxCount);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetClassNameW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPWSTR")] ushort* lpClassName, int nMaxCount);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetTopWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetWindowThreadProcessId([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPDWORD")] uint* lpdwProcessId);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsGUIThread([NativeTypeName("BOOL")] int bConvert);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetLastActivePopup([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint uCmd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HHOOK")]
        public static extern IntPtr SetWindowsHookA(int nFilterType, [NativeTypeName("HOOKPROC")] delegate* unmanaged<int, nuint, nint, nint> pfnFilterProc);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HHOOK")]
        public static extern IntPtr SetWindowsHookW(int nFilterType, [NativeTypeName("HOOKPROC")] delegate* unmanaged<int, nuint, nint, nint> pfnFilterProc);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnhookWindowsHook(int nCode, [NativeTypeName("HOOKPROC")] delegate* unmanaged<int, nuint, nint, nint> pfnFilterProc);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HHOOK")]
        public static extern IntPtr SetWindowsHookExA(int idHook, [NativeTypeName("HOOKPROC")] delegate* unmanaged<int, nuint, nint, nint> lpfn, [NativeTypeName("HINSTANCE")] IntPtr hmod, [NativeTypeName("DWORD")] uint dwThreadId);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HHOOK")]
        public static extern IntPtr SetWindowsHookExW(int idHook, [NativeTypeName("HOOKPROC")] delegate* unmanaged<int, nuint, nint, nint> lpfn, [NativeTypeName("HINSTANCE")] IntPtr hmod, [NativeTypeName("DWORD")] uint dwThreadId);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnhookWindowsHookEx([NativeTypeName("HHOOK")] IntPtr hhk);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint CallNextHookEx([NativeTypeName("HHOOK")] IntPtr hhk, int nCode, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckMenuRadioItem([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint first, [NativeTypeName("UINT")] uint last, [NativeTypeName("UINT")] uint check, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr LoadBitmapA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpBitmapName);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr LoadBitmapW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpBitmapName);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr LoadCursorA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpCursorName);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr LoadCursorW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpCursorName);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr LoadCursorFromFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr LoadCursorFromFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr CreateCursor([NativeTypeName("HINSTANCE")] IntPtr hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, [NativeTypeName("const void *")] void* pvANDPlane, [NativeTypeName("const void *")] void* pvXORPlane);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyCursor([NativeTypeName("HCURSOR")] IntPtr hCursor);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSystemCursor([NativeTypeName("HCURSOR")] IntPtr hcur, [NativeTypeName("DWORD")] uint id);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr LoadIconA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpIconName);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr LoadIconW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpIconName);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint PrivateExtractIconsA([NativeTypeName("LPCSTR")] sbyte* szFileName, int nIconIndex, int cxIcon, int cyIcon, [NativeTypeName("HICON *")] IntPtr* phicon, [NativeTypeName("UINT *")] uint* piconid, [NativeTypeName("UINT")] uint nIcons, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint PrivateExtractIconsW([NativeTypeName("LPCWSTR")] ushort* szFileName, int nIconIndex, int cxIcon, int cyIcon, [NativeTypeName("HICON *")] IntPtr* phicon, [NativeTypeName("UINT *")] uint* piconid, [NativeTypeName("UINT")] uint nIcons, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr CreateIcon([NativeTypeName("HINSTANCE")] IntPtr hInstance, int nWidth, int nHeight, [NativeTypeName("BYTE")] byte cPlanes, [NativeTypeName("BYTE")] byte cBitsPixel, [NativeTypeName("const BYTE *")] byte* lpbANDbits, [NativeTypeName("const BYTE *")] byte* lpbXORbits);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyIcon([NativeTypeName("HICON")] IntPtr hIcon);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int LookupIconIdFromDirectory([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("BOOL")] int fIcon);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int LookupIconIdFromDirectoryEx([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("BOOL")] int fIcon, int cxDesired, int cyDesired, [NativeTypeName("UINT")] uint Flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr CreateIconFromResource([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("DWORD")] uint dwResSize, [NativeTypeName("BOOL")] int fIcon, [NativeTypeName("DWORD")] uint dwVer);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr CreateIconFromResourceEx([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("DWORD")] uint dwResSize, [NativeTypeName("BOOL")] int fIcon, [NativeTypeName("DWORD")] uint dwVer, int cxDesired, int cyDesired, [NativeTypeName("UINT")] uint Flags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr LoadImageA([NativeTypeName("HINSTANCE")] IntPtr hInst, [NativeTypeName("LPCSTR")] sbyte* name, [NativeTypeName("UINT")] uint type, int cx, int cy, [NativeTypeName("UINT")] uint fuLoad);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr LoadImageW([NativeTypeName("HINSTANCE")] IntPtr hInst, [NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("UINT")] uint type, int cx, int cy, [NativeTypeName("UINT")] uint fuLoad);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CopyImage([NativeTypeName("HANDLE")] IntPtr h, [NativeTypeName("UINT")] uint type, int cx, int cy, [NativeTypeName("UINT")] uint flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawIconEx([NativeTypeName("HDC")] IntPtr hdc, int xLeft, int yTop, [NativeTypeName("HICON")] IntPtr hIcon, int cxWidth, int cyWidth, [NativeTypeName("UINT")] uint istepIfAniCur, [NativeTypeName("HBRUSH")] IntPtr hbrFlickerFreeDraw, [NativeTypeName("UINT")] uint diFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr CreateIconIndirect([NativeTypeName("PICONINFO")] ICONINFO* piconinfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr CopyIcon([NativeTypeName("HICON")] IntPtr hIcon);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetIconInfo([NativeTypeName("HICON")] IntPtr hIcon, [NativeTypeName("PICONINFO")] ICONINFO* piconinfo);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetIconInfoExA([NativeTypeName("HICON")] IntPtr hicon, [NativeTypeName("PICONINFOEXA")] ICONINFOEXA* piconinfo);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetIconInfoExW([NativeTypeName("HICON")] IntPtr hicon, [NativeTypeName("PICONINFOEXW")] ICONINFOEXW* piconinfo);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsDialogMessageA([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsDialogMessageW([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MapDialogRect([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int DlgDirListA([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPSTR")] sbyte* lpPathSpec, int nIDListBox, int nIDStaticPath, [NativeTypeName("UINT")] uint uFileType);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int DlgDirListW([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPWSTR")] ushort* lpPathSpec, int nIDListBox, int nIDStaticPath, [NativeTypeName("UINT")] uint uFileType);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DlgDirSelectExA([NativeTypeName("HWND")] IntPtr hwndDlg, [NativeTypeName("LPSTR")] sbyte* lpString, int chCount, int idListBox);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DlgDirSelectExW([NativeTypeName("HWND")] IntPtr hwndDlg, [NativeTypeName("LPWSTR")] ushort* lpString, int chCount, int idListBox);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int DlgDirListComboBoxA([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPSTR")] sbyte* lpPathSpec, int nIDComboBox, int nIDStaticPath, [NativeTypeName("UINT")] uint uFiletype);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int DlgDirListComboBoxW([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPWSTR")] ushort* lpPathSpec, int nIDComboBox, int nIDStaticPath, [NativeTypeName("UINT")] uint uFiletype);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DlgDirSelectComboBoxExA([NativeTypeName("HWND")] IntPtr hwndDlg, [NativeTypeName("LPSTR")] sbyte* lpString, int cchOut, int idComboBox);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DlgDirSelectComboBoxExW([NativeTypeName("HWND")] IntPtr hwndDlg, [NativeTypeName("LPWSTR")] ushort* lpString, int cchOut, int idComboBox);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int SetScrollInfo([NativeTypeName("HWND")] IntPtr hwnd, int nBar, [NativeTypeName("LPCSCROLLINFO")] SCROLLINFO* lpsi, [NativeTypeName("BOOL")] int redraw);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetScrollInfo([NativeTypeName("HWND")] IntPtr hwnd, int nBar, [NativeTypeName("LPSCROLLINFO")] SCROLLINFO* lpsi);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefFrameProcA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HWND")] IntPtr hWndMDIClient, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefFrameProcW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HWND")] IntPtr hWndMDIClient, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefMDIChildProcA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefMDIChildProcW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TranslateMDISysAccel([NativeTypeName("HWND")] IntPtr hWndClient, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint ArrangeIconicWindows([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateMDIWindowA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateMDIWindowW([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort TileWindows([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("UINT")] uint wHow, [NativeTypeName("const RECT *")] RECT* lpRect, [NativeTypeName("UINT")] uint cKids, [NativeTypeName("const HWND *")] IntPtr* lpKids);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort CascadeWindows([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("UINT")] uint wHow, [NativeTypeName("const RECT *")] RECT* lpRect, [NativeTypeName("UINT")] uint cKids, [NativeTypeName("const HWND *")] IntPtr* lpKids);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinHelpA([NativeTypeName("HWND")] IntPtr hWndMain, [NativeTypeName("LPCSTR")] sbyte* lpszHelp, [NativeTypeName("UINT")] uint uCommand, [NativeTypeName("ULONG_PTR")] nuint dwData);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinHelpW([NativeTypeName("HWND")] IntPtr hWndMain, [NativeTypeName("LPCWSTR")] ushort* lpszHelp, [NativeTypeName("UINT")] uint uCommand, [NativeTypeName("ULONG_PTR")] nuint dwData);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGuiResources([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("DWORD")] uint uiFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SoundSentry();

        [DllImport("user32", ExactSpelling = true)]
        public static extern void SetDebugErrorLevel([NativeTypeName("DWORD")] uint dwLevel);

        [DllImport("user32", ExactSpelling = true)]
        public static extern void SetLastErrorEx([NativeTypeName("DWORD")] uint dwErrCode, [NativeTypeName("DWORD")] uint dwType);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int InternalGetWindowText([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPWSTR")] ushort* pString, int cchMaxCount);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelShutdown();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HMONITOR")]
        public static extern IntPtr MonitorFromPoint(POINT pt, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HMONITOR")]
        public static extern IntPtr MonitorFromRect([NativeTypeName("LPCRECT")] RECT* lprc, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HMONITOR")]
        public static extern IntPtr MonitorFromWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMonitorInfoA([NativeTypeName("HMONITOR")] IntPtr hMonitor, [NativeTypeName("LPMONITORINFO")] MONITORINFO* lpmi);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMonitorInfoW([NativeTypeName("HMONITOR")] IntPtr hMonitor, [NativeTypeName("LPMONITORINFO")] MONITORINFO* lpmi);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplayMonitors([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCRECT")] RECT* lprcClip, [NativeTypeName("MONITORENUMPROC")] delegate* unmanaged<IntPtr, IntPtr, RECT*, nint, int> lpfnEnum, [NativeTypeName("LPARAM")] nint dwData);

        [DllImport("user32", ExactSpelling = true)]
        public static extern void NotifyWinEvent([NativeTypeName("DWORD")] uint @event, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("LONG")] int idChild);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWINEVENTHOOK")]
        public static extern IntPtr SetWinEventHook([NativeTypeName("DWORD")] uint eventMin, [NativeTypeName("DWORD")] uint eventMax, [NativeTypeName("HMODULE")] IntPtr hmodWinEventProc, [NativeTypeName("WINEVENTPROC")] delegate* unmanaged<IntPtr, uint, IntPtr, int, int, uint, uint, void> pfnWinEventProc, [NativeTypeName("DWORD")] uint idProcess, [NativeTypeName("DWORD")] uint idThread, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWinEventHookInstalled([NativeTypeName("DWORD")] uint @event);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnhookWinEvent([NativeTypeName("HWINEVENTHOOK")] IntPtr hWinEventHook);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGUIThreadInfo([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("PGUITHREADINFO")] GUITHREADINFO* pgui);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BlockInput([NativeTypeName("BOOL")] int fBlockIt);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDPIAware();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsProcessDPIAware();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DPI_AWARENESS_CONTEXT")]
        public static extern IntPtr SetThreadDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr dpiContext);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DPI_AWARENESS_CONTEXT")]
        public static extern IntPtr GetThreadDpiAwarenessContext();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DPI_AWARENESS_CONTEXT")]
        public static extern IntPtr GetWindowDpiAwarenessContext([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern DPI_AWARENESS GetAwarenessFromDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr value);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDpiFromDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr value);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AreDpiAwarenessContextsEqual([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr dpiContextA, [NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr dpiContextB);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsValidDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr value);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDpiForWindow([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDpiForSystem();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemDpiForProcess([NativeTypeName("HANDLE")] IntPtr hProcess);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableNonClientDpiScaling([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InheritWindowMonitor([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HWND")] IntPtr hwndInherit);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr value);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DPI_AWARENESS_CONTEXT")]
        public static extern IntPtr GetDpiAwarenessContextForProcess([NativeTypeName("HANDLE")] IntPtr hProcess);

        [DllImport("user32", ExactSpelling = true)]
        public static extern DPI_HOSTING_BEHAVIOR SetThreadDpiHostingBehavior(DPI_HOSTING_BEHAVIOR value);

        [DllImport("user32", ExactSpelling = true)]
        public static extern DPI_HOSTING_BEHAVIOR GetThreadDpiHostingBehavior();

        [DllImport("user32", ExactSpelling = true)]
        public static extern DPI_HOSTING_BEHAVIOR GetWindowDpiHostingBehavior([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetWindowModuleFileNameA([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPSTR")] sbyte* pszFileName, [NativeTypeName("UINT")] uint cchFileNameMax);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetWindowModuleFileNameW([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPWSTR")] ushort* pszFileName, [NativeTypeName("UINT")] uint cchFileNameMax);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCursorInfo([NativeTypeName("PCURSORINFO")] CURSORINFO* pci);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowInfo([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("PWINDOWINFO")] WINDOWINFO* pwi);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTitleBarInfo([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("PTITLEBARINFO")] TITLEBARINFO* pti);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuBarInfo([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("LONG")] int idItem, [NativeTypeName("PMENUBARINFO")] MENUBARINFO* pmbi);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetScrollBarInfo([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("PSCROLLBARINFO")] SCROLLBARINFO* psbi);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetComboBoxInfo([NativeTypeName("HWND")] IntPtr hwndCombo, [NativeTypeName("PCOMBOBOXINFO")] COMBOBOXINFO* pcbi);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetAncestor([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint gaFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr RealChildWindowFromPoint([NativeTypeName("HWND")] IntPtr hwndParent, POINT ptParentClientCoords);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RealGetWindowClassA([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPSTR")] sbyte* ptszClassName, [NativeTypeName("UINT")] uint cchClassNameMax);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RealGetWindowClassW([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPWSTR")] ushort* ptszClassName, [NativeTypeName("UINT")] uint cchClassNameMax);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAltTabInfoA([NativeTypeName("HWND")] IntPtr hwnd, int iItem, [NativeTypeName("PALTTABINFO")] ALTTABINFO* pati, [NativeTypeName("LPSTR")] sbyte* pszItemText, [NativeTypeName("UINT")] uint cchItemText);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAltTabInfoW([NativeTypeName("HWND")] IntPtr hwnd, int iItem, [NativeTypeName("PALTTABINFO")] ALTTABINFO* pati, [NativeTypeName("LPWSTR")] ushort* pszItemText, [NativeTypeName("UINT")] uint cchItemText);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetListBoxInfo([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockWorkStation();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UserHandleGrantAccess([NativeTypeName("HANDLE")] IntPtr hUserHandle, [NativeTypeName("HANDLE")] IntPtr hJob, [NativeTypeName("BOOL")] int bGrant);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRawInputData([NativeTypeName("HRAWINPUT")] IntPtr hRawInput, [NativeTypeName("UINT")] uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize, [NativeTypeName("UINT")] uint cbSizeHeader);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRawInputDeviceInfoA([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("UINT")] uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRawInputDeviceInfoW([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("UINT")] uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRawInputBuffer([NativeTypeName("PRAWINPUT")] RAWINPUT* pData, [NativeTypeName("PUINT")] uint* pcbSize, [NativeTypeName("UINT")] uint cbSizeHeader);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterRawInputDevices([NativeTypeName("PCRAWINPUTDEVICE")] RAWINPUTDEVICE* pRawInputDevices, [NativeTypeName("UINT")] uint uiNumDevices, [NativeTypeName("UINT")] uint cbSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRegisteredRawInputDevices([NativeTypeName("PRAWINPUTDEVICE")] RAWINPUTDEVICE* pRawInputDevices, [NativeTypeName("PUINT")] uint* puiNumDevices, [NativeTypeName("UINT")] uint cbSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRawInputDeviceList([NativeTypeName("PRAWINPUTDEVICELIST")] RAWINPUTDEVICELIST* pRawInputDeviceList, [NativeTypeName("PUINT")] uint* puiNumDevices, [NativeTypeName("UINT")] uint cbSize);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefRawInputProc([NativeTypeName("PRAWINPUT *")] RAWINPUT** paRawInput, [NativeTypeName("INT")] int nInput, [NativeTypeName("UINT")] uint cbSizeHeader);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDevices([NativeTypeName("UINT32 *")] uint* deviceCount, [NativeTypeName("POINTER_DEVICE_INFO *")] POINTER_DEVICE_INFO* pointerDevices);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDevice([NativeTypeName("HANDLE")] IntPtr device, [NativeTypeName("POINTER_DEVICE_INFO *")] POINTER_DEVICE_INFO* pointerDevice);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDeviceProperties([NativeTypeName("HANDLE")] IntPtr device, [NativeTypeName("UINT32 *")] uint* propertyCount, [NativeTypeName("POINTER_DEVICE_PROPERTY *")] POINTER_DEVICE_PROPERTY* pointerProperties);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterPointerDeviceNotifications([NativeTypeName("HWND")] IntPtr window, [NativeTypeName("BOOL")] int notifyRange);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDeviceRects([NativeTypeName("HANDLE")] IntPtr device, [NativeTypeName("RECT *")] RECT* pointerDeviceRect, [NativeTypeName("RECT *")] RECT* displayRect);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDeviceCursors([NativeTypeName("HANDLE")] IntPtr device, [NativeTypeName("UINT32 *")] uint* cursorCount, [NativeTypeName("POINTER_DEVICE_CURSOR_INFO *")] POINTER_DEVICE_CURSOR_INFO* deviceCursors);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetRawPointerDeviceData([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint historyCount, [NativeTypeName("UINT32")] uint propertiesCount, [NativeTypeName("POINTER_DEVICE_PROPERTY *")] POINTER_DEVICE_PROPERTY* pProperties, [NativeTypeName("LONG *")] int* pValues);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeWindowMessageFilter([NativeTypeName("UINT")] uint message, [NativeTypeName("DWORD")] uint dwFlag);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeWindowMessageFilterEx([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint message, [NativeTypeName("DWORD")] uint action, [NativeTypeName("PCHANGEFILTERSTRUCT")] CHANGEFILTERSTRUCT* pChangeFilterStruct);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGestureInfo([NativeTypeName("HGESTUREINFO")] IntPtr hGestureInfo, [NativeTypeName("PGESTUREINFO")] GESTUREINFO* pGestureInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGestureExtraArgs([NativeTypeName("HGESTUREINFO")] IntPtr hGestureInfo, [NativeTypeName("UINT")] uint cbExtraArgs, [NativeTypeName("PBYTE")] byte* pExtraArgs);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseGestureInfoHandle([NativeTypeName("HGESTUREINFO")] IntPtr hGestureInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetGestureConfig([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("UINT")] uint cIDs, [NativeTypeName("PGESTURECONFIG")] GESTURECONFIG* pGestureConfig, [NativeTypeName("UINT")] uint cbSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGestureConfig([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PUINT")] uint* pcIDs, [NativeTypeName("PGESTURECONFIG")] GESTURECONFIG* pGestureConfig, [NativeTypeName("UINT")] uint cbSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShutdownBlockReasonCreate([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* pwszReason);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShutdownBlockReasonQuery([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPWSTR")] ushort* pwszBuff, [NativeTypeName("DWORD *")] uint* pcchBuff);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShutdownBlockReasonDestroy([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentInputMessageSource([NativeTypeName("INPUT_MESSAGE_SOURCE *")] INPUT_MESSAGE_SOURCE* inputMessageSource);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCIMSSM([NativeTypeName("INPUT_MESSAGE_SOURCE *")] INPUT_MESSAGE_SOURCE* inputMessageSource);

        [DllImport("kernel", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAutoRotationState([NativeTypeName("PAR_STATE")] AR_STATE* pState);

        [DllImport("kernel", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDisplayAutoRotationPreferences([NativeTypeName("ORIENTATION_PREFERENCE *")] ORIENTATION_PREFERENCE* pOrientation);

        [DllImport("kernel", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDisplayAutoRotationPreferencesByProcessId([NativeTypeName("DWORD")] uint dwProcessId, [NativeTypeName("ORIENTATION_PREFERENCE *")] ORIENTATION_PREFERENCE* pOrientation, [NativeTypeName("BOOL *")] int* fRotateScreen);

        [DllImport("kernel", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDisplayAutoRotationPreferences(ORIENTATION_PREFERENCE orientation);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsImmersiveProcess([NativeTypeName("HANDLE")] IntPtr hProcess);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessRestrictionExemption([NativeTypeName("BOOL")] int fEnableExemption);

        [NativeTypeName("#define RT_CURSOR MAKEINTRESOURCE(1)")]
        public static readonly ushort* RT_CURSOR = ((ushort*)((nuint)((ushort)(1))));

        [NativeTypeName("#define RT_BITMAP MAKEINTRESOURCE(2)")]
        public static readonly ushort* RT_BITMAP = ((ushort*)((nuint)((ushort)(2))));

        [NativeTypeName("#define RT_ICON MAKEINTRESOURCE(3)")]
        public static readonly ushort* RT_ICON = ((ushort*)((nuint)((ushort)(3))));

        [NativeTypeName("#define RT_MENU MAKEINTRESOURCE(4)")]
        public static readonly ushort* RT_MENU = ((ushort*)((nuint)((ushort)(4))));

        [NativeTypeName("#define RT_DIALOG MAKEINTRESOURCE(5)")]
        public static readonly ushort* RT_DIALOG = ((ushort*)((nuint)((ushort)(5))));

        [NativeTypeName("#define RT_STRING MAKEINTRESOURCE(6)")]
        public static readonly ushort* RT_STRING = ((ushort*)((nuint)((ushort)(6))));

        [NativeTypeName("#define RT_FONTDIR MAKEINTRESOURCE(7)")]
        public static readonly ushort* RT_FONTDIR = ((ushort*)((nuint)((ushort)(7))));

        [NativeTypeName("#define RT_FONT MAKEINTRESOURCE(8)")]
        public static readonly ushort* RT_FONT = ((ushort*)((nuint)((ushort)(8))));

        [NativeTypeName("#define RT_ACCELERATOR MAKEINTRESOURCE(9)")]
        public static readonly ushort* RT_ACCELERATOR = ((ushort*)((nuint)((ushort)(9))));

        [NativeTypeName("#define RT_RCDATA MAKEINTRESOURCE(10)")]
        public static readonly ushort* RT_RCDATA = ((ushort*)((nuint)((ushort)(10))));

        [NativeTypeName("#define RT_MESSAGETABLE MAKEINTRESOURCE(11)")]
        public static readonly ushort* RT_MESSAGETABLE = ((ushort*)((nuint)((ushort)(11))));

        [NativeTypeName("#define DIFFERENCE 11")]
        public const int DIFFERENCE = 11;

        [NativeTypeName("#define RT_GROUP_CURSOR MAKEINTRESOURCE((ULONG_PTR)(RT_CURSOR) + DIFFERENCE)")]
        public static readonly ushort* RT_GROUP_CURSOR = ((ushort*)((nuint)((ushort)((nuint)(((ushort*)((nuint)((ushort)(1))))) + 11))));

        [NativeTypeName("#define RT_GROUP_ICON MAKEINTRESOURCE((ULONG_PTR)(RT_ICON) + DIFFERENCE)")]
        public static readonly ushort* RT_GROUP_ICON = ((ushort*)((nuint)((ushort)((nuint)(((ushort*)((nuint)((ushort)(3))))) + 11))));

        [NativeTypeName("#define RT_VERSION MAKEINTRESOURCE(16)")]
        public static readonly ushort* RT_VERSION = ((ushort*)((nuint)((ushort)(16))));

        [NativeTypeName("#define RT_DLGINCLUDE MAKEINTRESOURCE(17)")]
        public static readonly ushort* RT_DLGINCLUDE = ((ushort*)((nuint)((ushort)(17))));

        [NativeTypeName("#define RT_PLUGPLAY MAKEINTRESOURCE(19)")]
        public static readonly ushort* RT_PLUGPLAY = ((ushort*)((nuint)((ushort)(19))));

        [NativeTypeName("#define RT_VXD MAKEINTRESOURCE(20)")]
        public static readonly ushort* RT_VXD = ((ushort*)((nuint)((ushort)(20))));

        [NativeTypeName("#define RT_ANICURSOR MAKEINTRESOURCE(21)")]
        public static readonly ushort* RT_ANICURSOR = ((ushort*)((nuint)((ushort)(21))));

        [NativeTypeName("#define RT_ANIICON MAKEINTRESOURCE(22)")]
        public static readonly ushort* RT_ANIICON = ((ushort*)((nuint)((ushort)(22))));

        [NativeTypeName("#define RT_HTML MAKEINTRESOURCE(23)")]
        public static readonly ushort* RT_HTML = ((ushort*)((nuint)((ushort)(23))));

        [NativeTypeName("#define RT_MANIFEST MAKEINTRESOURCE(24)")]
        public static readonly ushort* RT_MANIFEST = ((ushort*)((nuint)((ushort)(24))));

        [NativeTypeName("#define CREATEPROCESS_MANIFEST_RESOURCE_ID MAKEINTRESOURCE( 1)")]
        public static readonly ushort* CREATEPROCESS_MANIFEST_RESOURCE_ID = ((ushort*)((nuint)((ushort)(1))));

        [NativeTypeName("#define ISOLATIONAWARE_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(2)")]
        public static readonly ushort* ISOLATIONAWARE_MANIFEST_RESOURCE_ID = ((ushort*)((nuint)((ushort)(2))));

        [NativeTypeName("#define ISOLATIONAWARE_NOSTATICIMPORT_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(3)")]
        public static readonly ushort* ISOLATIONAWARE_NOSTATICIMPORT_MANIFEST_RESOURCE_ID = ((ushort*)((nuint)((ushort)(3))));

        [NativeTypeName("#define ISOLATIONPOLICY_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(4)")]
        public static readonly ushort* ISOLATIONPOLICY_MANIFEST_RESOURCE_ID = ((ushort*)((nuint)((ushort)(4))));

        [NativeTypeName("#define ISOLATIONPOLICY_BROWSER_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(5)")]
        public static readonly ushort* ISOLATIONPOLICY_BROWSER_MANIFEST_RESOURCE_ID = ((ushort*)((nuint)((ushort)(5))));

        [NativeTypeName("#define MINIMUM_RESERVED_MANIFEST_RESOURCE_ID MAKEINTRESOURCE( 1 /*inclusive*/)")]
        public static readonly ushort* MINIMUM_RESERVED_MANIFEST_RESOURCE_ID = ((ushort*)((nuint)((ushort)(1))));

        [NativeTypeName("#define MAXIMUM_RESERVED_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(16 /*inclusive*/)")]
        public static readonly ushort* MAXIMUM_RESERVED_MANIFEST_RESOURCE_ID = ((ushort*)((nuint)((ushort)(16))));

        [NativeTypeName("#define wvsprintf wvsprintfW")]
        public static readonly delegate*<ushort*, ushort*, sbyte*, int> wvsprintf = &wvsprintfW;

        [NativeTypeName("#define wsprintf wsprintfW")]
        public static readonly delegate*<ushort*, ushort*, int> wsprintf = &wsprintfW;

        [NativeTypeName("#define SETWALLPAPER_DEFAULT ((LPWSTR)-1)")]
        public static readonly ushort* SETWALLPAPER_DEFAULT = unchecked((ushort*)(-1));

        [NativeTypeName("#define SB_HORZ 0")]
        public const int SB_HORZ = 0;

        [NativeTypeName("#define SB_VERT 1")]
        public const int SB_VERT = 1;

        [NativeTypeName("#define SB_CTL 2")]
        public const int SB_CTL = 2;

        [NativeTypeName("#define SB_BOTH 3")]
        public const int SB_BOTH = 3;

        [NativeTypeName("#define SB_LINEUP 0")]
        public const int SB_LINEUP = 0;

        [NativeTypeName("#define SB_LINELEFT 0")]
        public const int SB_LINELEFT = 0;

        [NativeTypeName("#define SB_LINEDOWN 1")]
        public const int SB_LINEDOWN = 1;

        [NativeTypeName("#define SB_LINERIGHT 1")]
        public const int SB_LINERIGHT = 1;

        [NativeTypeName("#define SB_PAGEUP 2")]
        public const int SB_PAGEUP = 2;

        [NativeTypeName("#define SB_PAGELEFT 2")]
        public const int SB_PAGELEFT = 2;

        [NativeTypeName("#define SB_PAGEDOWN 3")]
        public const int SB_PAGEDOWN = 3;

        [NativeTypeName("#define SB_PAGERIGHT 3")]
        public const int SB_PAGERIGHT = 3;

        [NativeTypeName("#define SB_THUMBPOSITION 4")]
        public const int SB_THUMBPOSITION = 4;

        [NativeTypeName("#define SB_THUMBTRACK 5")]
        public const int SB_THUMBTRACK = 5;

        [NativeTypeName("#define SB_TOP 6")]
        public const int SB_TOP = 6;

        [NativeTypeName("#define SB_LEFT 6")]
        public const int SB_LEFT = 6;

        [NativeTypeName("#define SB_BOTTOM 7")]
        public const int SB_BOTTOM = 7;

        [NativeTypeName("#define SB_RIGHT 7")]
        public const int SB_RIGHT = 7;

        [NativeTypeName("#define SB_ENDSCROLL 8")]
        public const int SB_ENDSCROLL = 8;

        [NativeTypeName("#define SW_HIDE 0")]
        public const int SW_HIDE = 0;

        [NativeTypeName("#define SW_SHOWNORMAL 1")]
        public const int SW_SHOWNORMAL = 1;

        [NativeTypeName("#define SW_NORMAL 1")]
        public const int SW_NORMAL = 1;

        [NativeTypeName("#define SW_SHOWMINIMIZED 2")]
        public const int SW_SHOWMINIMIZED = 2;

        [NativeTypeName("#define SW_SHOWMAXIMIZED 3")]
        public const int SW_SHOWMAXIMIZED = 3;

        [NativeTypeName("#define SW_MAXIMIZE 3")]
        public const int SW_MAXIMIZE = 3;

        [NativeTypeName("#define SW_SHOWNOACTIVATE 4")]
        public const int SW_SHOWNOACTIVATE = 4;

        [NativeTypeName("#define SW_SHOW 5")]
        public const int SW_SHOW = 5;

        [NativeTypeName("#define SW_MINIMIZE 6")]
        public const int SW_MINIMIZE = 6;

        [NativeTypeName("#define SW_SHOWMINNOACTIVE 7")]
        public const int SW_SHOWMINNOACTIVE = 7;

        [NativeTypeName("#define SW_SHOWNA 8")]
        public const int SW_SHOWNA = 8;

        [NativeTypeName("#define SW_RESTORE 9")]
        public const int SW_RESTORE = 9;

        [NativeTypeName("#define SW_SHOWDEFAULT 10")]
        public const int SW_SHOWDEFAULT = 10;

        [NativeTypeName("#define SW_FORCEMINIMIZE 11")]
        public const int SW_FORCEMINIMIZE = 11;

        [NativeTypeName("#define SW_MAX 11")]
        public const int SW_MAX = 11;

        [NativeTypeName("#define HIDE_WINDOW 0")]
        public const int HIDE_WINDOW = 0;

        [NativeTypeName("#define SHOW_OPENWINDOW 1")]
        public const int SHOW_OPENWINDOW = 1;

        [NativeTypeName("#define SHOW_ICONWINDOW 2")]
        public const int SHOW_ICONWINDOW = 2;

        [NativeTypeName("#define SHOW_FULLSCREEN 3")]
        public const int SHOW_FULLSCREEN = 3;

        [NativeTypeName("#define SHOW_OPENNOACTIVATE 4")]
        public const int SHOW_OPENNOACTIVATE = 4;

        [NativeTypeName("#define SW_PARENTCLOSING 1")]
        public const int SW_PARENTCLOSING = 1;

        [NativeTypeName("#define SW_OTHERZOOM 2")]
        public const int SW_OTHERZOOM = 2;

        [NativeTypeName("#define SW_PARENTOPENING 3")]
        public const int SW_PARENTOPENING = 3;

        [NativeTypeName("#define SW_OTHERUNZOOM 4")]
        public const int SW_OTHERUNZOOM = 4;

        [NativeTypeName("#define AW_HOR_POSITIVE 0x00000001")]
        public const int AW_HOR_POSITIVE = 0x00000001;

        [NativeTypeName("#define AW_HOR_NEGATIVE 0x00000002")]
        public const int AW_HOR_NEGATIVE = 0x00000002;

        [NativeTypeName("#define AW_VER_POSITIVE 0x00000004")]
        public const int AW_VER_POSITIVE = 0x00000004;

        [NativeTypeName("#define AW_VER_NEGATIVE 0x00000008")]
        public const int AW_VER_NEGATIVE = 0x00000008;

        [NativeTypeName("#define AW_CENTER 0x00000010")]
        public const int AW_CENTER = 0x00000010;

        [NativeTypeName("#define AW_HIDE 0x00010000")]
        public const int AW_HIDE = 0x00010000;

        [NativeTypeName("#define AW_ACTIVATE 0x00020000")]
        public const int AW_ACTIVATE = 0x00020000;

        [NativeTypeName("#define AW_SLIDE 0x00040000")]
        public const int AW_SLIDE = 0x00040000;

        [NativeTypeName("#define AW_BLEND 0x00080000")]
        public const int AW_BLEND = 0x00080000;

        [NativeTypeName("#define KF_EXTENDED 0x0100")]
        public const int KF_EXTENDED = 0x0100;

        [NativeTypeName("#define KF_DLGMODE 0x0800")]
        public const int KF_DLGMODE = 0x0800;

        [NativeTypeName("#define KF_MENUMODE 0x1000")]
        public const int KF_MENUMODE = 0x1000;

        [NativeTypeName("#define KF_ALTDOWN 0x2000")]
        public const int KF_ALTDOWN = 0x2000;

        [NativeTypeName("#define KF_REPEAT 0x4000")]
        public const int KF_REPEAT = 0x4000;

        [NativeTypeName("#define KF_UP 0x8000")]
        public const int KF_UP = 0x8000;

        [NativeTypeName("#define VK_LBUTTON 0x01")]
        public const int VK_LBUTTON = 0x01;

        [NativeTypeName("#define VK_RBUTTON 0x02")]
        public const int VK_RBUTTON = 0x02;

        [NativeTypeName("#define VK_CANCEL 0x03")]
        public const int VK_CANCEL = 0x03;

        [NativeTypeName("#define VK_MBUTTON 0x04")]
        public const int VK_MBUTTON = 0x04;

        [NativeTypeName("#define VK_XBUTTON1 0x05")]
        public const int VK_XBUTTON1 = 0x05;

        [NativeTypeName("#define VK_XBUTTON2 0x06")]
        public const int VK_XBUTTON2 = 0x06;

        [NativeTypeName("#define VK_BACK 0x08")]
        public const int VK_BACK = 0x08;

        [NativeTypeName("#define VK_TAB 0x09")]
        public const int VK_TAB = 0x09;

        [NativeTypeName("#define VK_CLEAR 0x0C")]
        public const int VK_CLEAR = 0x0C;

        [NativeTypeName("#define VK_RETURN 0x0D")]
        public const int VK_RETURN = 0x0D;

        [NativeTypeName("#define VK_SHIFT 0x10")]
        public const int VK_SHIFT = 0x10;

        [NativeTypeName("#define VK_CONTROL 0x11")]
        public const int VK_CONTROL = 0x11;

        [NativeTypeName("#define VK_MENU 0x12")]
        public const int VK_MENU = 0x12;

        [NativeTypeName("#define VK_PAUSE 0x13")]
        public const int VK_PAUSE = 0x13;

        [NativeTypeName("#define VK_CAPITAL 0x14")]
        public const int VK_CAPITAL = 0x14;

        [NativeTypeName("#define VK_KANA 0x15")]
        public const int VK_KANA = 0x15;

        [NativeTypeName("#define VK_HANGEUL 0x15")]
        public const int VK_HANGEUL = 0x15;

        [NativeTypeName("#define VK_HANGUL 0x15")]
        public const int VK_HANGUL = 0x15;

        [NativeTypeName("#define VK_JUNJA 0x17")]
        public const int VK_JUNJA = 0x17;

        [NativeTypeName("#define VK_FINAL 0x18")]
        public const int VK_FINAL = 0x18;

        [NativeTypeName("#define VK_HANJA 0x19")]
        public const int VK_HANJA = 0x19;

        [NativeTypeName("#define VK_KANJI 0x19")]
        public const int VK_KANJI = 0x19;

        [NativeTypeName("#define VK_ESCAPE 0x1B")]
        public const int VK_ESCAPE = 0x1B;

        [NativeTypeName("#define VK_CONVERT 0x1C")]
        public const int VK_CONVERT = 0x1C;

        [NativeTypeName("#define VK_NONCONVERT 0x1D")]
        public const int VK_NONCONVERT = 0x1D;

        [NativeTypeName("#define VK_ACCEPT 0x1E")]
        public const int VK_ACCEPT = 0x1E;

        [NativeTypeName("#define VK_MODECHANGE 0x1F")]
        public const int VK_MODECHANGE = 0x1F;

        [NativeTypeName("#define VK_SPACE 0x20")]
        public const int VK_SPACE = 0x20;

        [NativeTypeName("#define VK_PRIOR 0x21")]
        public const int VK_PRIOR = 0x21;

        [NativeTypeName("#define VK_NEXT 0x22")]
        public const int VK_NEXT = 0x22;

        [NativeTypeName("#define VK_END 0x23")]
        public const int VK_END = 0x23;

        [NativeTypeName("#define VK_HOME 0x24")]
        public const int VK_HOME = 0x24;

        [NativeTypeName("#define VK_LEFT 0x25")]
        public const int VK_LEFT = 0x25;

        [NativeTypeName("#define VK_UP 0x26")]
        public const int VK_UP = 0x26;

        [NativeTypeName("#define VK_RIGHT 0x27")]
        public const int VK_RIGHT = 0x27;

        [NativeTypeName("#define VK_DOWN 0x28")]
        public const int VK_DOWN = 0x28;

        [NativeTypeName("#define VK_SELECT 0x29")]
        public const int VK_SELECT = 0x29;

        [NativeTypeName("#define VK_PRINT 0x2A")]
        public const int VK_PRINT = 0x2A;

        [NativeTypeName("#define VK_EXECUTE 0x2B")]
        public const int VK_EXECUTE = 0x2B;

        [NativeTypeName("#define VK_SNAPSHOT 0x2C")]
        public const int VK_SNAPSHOT = 0x2C;

        [NativeTypeName("#define VK_INSERT 0x2D")]
        public const int VK_INSERT = 0x2D;

        [NativeTypeName("#define VK_DELETE 0x2E")]
        public const int VK_DELETE = 0x2E;

        [NativeTypeName("#define VK_HELP 0x2F")]
        public const int VK_HELP = 0x2F;

        [NativeTypeName("#define VK_LWIN 0x5B")]
        public const int VK_LWIN = 0x5B;

        [NativeTypeName("#define VK_RWIN 0x5C")]
        public const int VK_RWIN = 0x5C;

        [NativeTypeName("#define VK_APPS 0x5D")]
        public const int VK_APPS = 0x5D;

        [NativeTypeName("#define VK_SLEEP 0x5F")]
        public const int VK_SLEEP = 0x5F;

        [NativeTypeName("#define VK_NUMPAD0 0x60")]
        public const int VK_NUMPAD0 = 0x60;

        [NativeTypeName("#define VK_NUMPAD1 0x61")]
        public const int VK_NUMPAD1 = 0x61;

        [NativeTypeName("#define VK_NUMPAD2 0x62")]
        public const int VK_NUMPAD2 = 0x62;

        [NativeTypeName("#define VK_NUMPAD3 0x63")]
        public const int VK_NUMPAD3 = 0x63;

        [NativeTypeName("#define VK_NUMPAD4 0x64")]
        public const int VK_NUMPAD4 = 0x64;

        [NativeTypeName("#define VK_NUMPAD5 0x65")]
        public const int VK_NUMPAD5 = 0x65;

        [NativeTypeName("#define VK_NUMPAD6 0x66")]
        public const int VK_NUMPAD6 = 0x66;

        [NativeTypeName("#define VK_NUMPAD7 0x67")]
        public const int VK_NUMPAD7 = 0x67;

        [NativeTypeName("#define VK_NUMPAD8 0x68")]
        public const int VK_NUMPAD8 = 0x68;

        [NativeTypeName("#define VK_NUMPAD9 0x69")]
        public const int VK_NUMPAD9 = 0x69;

        [NativeTypeName("#define VK_MULTIPLY 0x6A")]
        public const int VK_MULTIPLY = 0x6A;

        [NativeTypeName("#define VK_ADD 0x6B")]
        public const int VK_ADD = 0x6B;

        [NativeTypeName("#define VK_SEPARATOR 0x6C")]
        public const int VK_SEPARATOR = 0x6C;

        [NativeTypeName("#define VK_SUBTRACT 0x6D")]
        public const int VK_SUBTRACT = 0x6D;

        [NativeTypeName("#define VK_DECIMAL 0x6E")]
        public const int VK_DECIMAL = 0x6E;

        [NativeTypeName("#define VK_DIVIDE 0x6F")]
        public const int VK_DIVIDE = 0x6F;

        [NativeTypeName("#define VK_F1 0x70")]
        public const int VK_F1 = 0x70;

        [NativeTypeName("#define VK_F2 0x71")]
        public const int VK_F2 = 0x71;

        [NativeTypeName("#define VK_F3 0x72")]
        public const int VK_F3 = 0x72;

        [NativeTypeName("#define VK_F4 0x73")]
        public const int VK_F4 = 0x73;

        [NativeTypeName("#define VK_F5 0x74")]
        public const int VK_F5 = 0x74;

        [NativeTypeName("#define VK_F6 0x75")]
        public const int VK_F6 = 0x75;

        [NativeTypeName("#define VK_F7 0x76")]
        public const int VK_F7 = 0x76;

        [NativeTypeName("#define VK_F8 0x77")]
        public const int VK_F8 = 0x77;

        [NativeTypeName("#define VK_F9 0x78")]
        public const int VK_F9 = 0x78;

        [NativeTypeName("#define VK_F10 0x79")]
        public const int VK_F10 = 0x79;

        [NativeTypeName("#define VK_F11 0x7A")]
        public const int VK_F11 = 0x7A;

        [NativeTypeName("#define VK_F12 0x7B")]
        public const int VK_F12 = 0x7B;

        [NativeTypeName("#define VK_F13 0x7C")]
        public const int VK_F13 = 0x7C;

        [NativeTypeName("#define VK_F14 0x7D")]
        public const int VK_F14 = 0x7D;

        [NativeTypeName("#define VK_F15 0x7E")]
        public const int VK_F15 = 0x7E;

        [NativeTypeName("#define VK_F16 0x7F")]
        public const int VK_F16 = 0x7F;

        [NativeTypeName("#define VK_F17 0x80")]
        public const int VK_F17 = 0x80;

        [NativeTypeName("#define VK_F18 0x81")]
        public const int VK_F18 = 0x81;

        [NativeTypeName("#define VK_F19 0x82")]
        public const int VK_F19 = 0x82;

        [NativeTypeName("#define VK_F20 0x83")]
        public const int VK_F20 = 0x83;

        [NativeTypeName("#define VK_F21 0x84")]
        public const int VK_F21 = 0x84;

        [NativeTypeName("#define VK_F22 0x85")]
        public const int VK_F22 = 0x85;

        [NativeTypeName("#define VK_F23 0x86")]
        public const int VK_F23 = 0x86;

        [NativeTypeName("#define VK_F24 0x87")]
        public const int VK_F24 = 0x87;

        [NativeTypeName("#define VK_NAVIGATION_VIEW 0x88")]
        public const int VK_NAVIGATION_VIEW = 0x88;

        [NativeTypeName("#define VK_NAVIGATION_MENU 0x89")]
        public const int VK_NAVIGATION_MENU = 0x89;

        [NativeTypeName("#define VK_NAVIGATION_UP 0x8A")]
        public const int VK_NAVIGATION_UP = 0x8A;

        [NativeTypeName("#define VK_NAVIGATION_DOWN 0x8B")]
        public const int VK_NAVIGATION_DOWN = 0x8B;

        [NativeTypeName("#define VK_NAVIGATION_LEFT 0x8C")]
        public const int VK_NAVIGATION_LEFT = 0x8C;

        [NativeTypeName("#define VK_NAVIGATION_RIGHT 0x8D")]
        public const int VK_NAVIGATION_RIGHT = 0x8D;

        [NativeTypeName("#define VK_NAVIGATION_ACCEPT 0x8E")]
        public const int VK_NAVIGATION_ACCEPT = 0x8E;

        [NativeTypeName("#define VK_NAVIGATION_CANCEL 0x8F")]
        public const int VK_NAVIGATION_CANCEL = 0x8F;

        [NativeTypeName("#define VK_NUMLOCK 0x90")]
        public const int VK_NUMLOCK = 0x90;

        [NativeTypeName("#define VK_SCROLL 0x91")]
        public const int VK_SCROLL = 0x91;

        [NativeTypeName("#define VK_OEM_NEC_EQUAL 0x92")]
        public const int VK_OEM_NEC_EQUAL = 0x92;

        [NativeTypeName("#define VK_OEM_FJ_JISHO 0x92")]
        public const int VK_OEM_FJ_JISHO = 0x92;

        [NativeTypeName("#define VK_OEM_FJ_MASSHOU 0x93")]
        public const int VK_OEM_FJ_MASSHOU = 0x93;

        [NativeTypeName("#define VK_OEM_FJ_TOUROKU 0x94")]
        public const int VK_OEM_FJ_TOUROKU = 0x94;

        [NativeTypeName("#define VK_OEM_FJ_LOYA 0x95")]
        public const int VK_OEM_FJ_LOYA = 0x95;

        [NativeTypeName("#define VK_OEM_FJ_ROYA 0x96")]
        public const int VK_OEM_FJ_ROYA = 0x96;

        [NativeTypeName("#define VK_LSHIFT 0xA0")]
        public const int VK_LSHIFT = 0xA0;

        [NativeTypeName("#define VK_RSHIFT 0xA1")]
        public const int VK_RSHIFT = 0xA1;

        [NativeTypeName("#define VK_LCONTROL 0xA2")]
        public const int VK_LCONTROL = 0xA2;

        [NativeTypeName("#define VK_RCONTROL 0xA3")]
        public const int VK_RCONTROL = 0xA3;

        [NativeTypeName("#define VK_LMENU 0xA4")]
        public const int VK_LMENU = 0xA4;

        [NativeTypeName("#define VK_RMENU 0xA5")]
        public const int VK_RMENU = 0xA5;

        [NativeTypeName("#define VK_BROWSER_BACK 0xA6")]
        public const int VK_BROWSER_BACK = 0xA6;

        [NativeTypeName("#define VK_BROWSER_FORWARD 0xA7")]
        public const int VK_BROWSER_FORWARD = 0xA7;

        [NativeTypeName("#define VK_BROWSER_REFRESH 0xA8")]
        public const int VK_BROWSER_REFRESH = 0xA8;

        [NativeTypeName("#define VK_BROWSER_STOP 0xA9")]
        public const int VK_BROWSER_STOP = 0xA9;

        [NativeTypeName("#define VK_BROWSER_SEARCH 0xAA")]
        public const int VK_BROWSER_SEARCH = 0xAA;

        [NativeTypeName("#define VK_BROWSER_FAVORITES 0xAB")]
        public const int VK_BROWSER_FAVORITES = 0xAB;

        [NativeTypeName("#define VK_BROWSER_HOME 0xAC")]
        public const int VK_BROWSER_HOME = 0xAC;

        [NativeTypeName("#define VK_VOLUME_MUTE 0xAD")]
        public const int VK_VOLUME_MUTE = 0xAD;

        [NativeTypeName("#define VK_VOLUME_DOWN 0xAE")]
        public const int VK_VOLUME_DOWN = 0xAE;

        [NativeTypeName("#define VK_VOLUME_UP 0xAF")]
        public const int VK_VOLUME_UP = 0xAF;

        [NativeTypeName("#define VK_MEDIA_NEXT_TRACK 0xB0")]
        public const int VK_MEDIA_NEXT_TRACK = 0xB0;

        [NativeTypeName("#define VK_MEDIA_PREV_TRACK 0xB1")]
        public const int VK_MEDIA_PREV_TRACK = 0xB1;

        [NativeTypeName("#define VK_MEDIA_STOP 0xB2")]
        public const int VK_MEDIA_STOP = 0xB2;

        [NativeTypeName("#define VK_MEDIA_PLAY_PAUSE 0xB3")]
        public const int VK_MEDIA_PLAY_PAUSE = 0xB3;

        [NativeTypeName("#define VK_LAUNCH_MAIL 0xB4")]
        public const int VK_LAUNCH_MAIL = 0xB4;

        [NativeTypeName("#define VK_LAUNCH_MEDIA_SELECT 0xB5")]
        public const int VK_LAUNCH_MEDIA_SELECT = 0xB5;

        [NativeTypeName("#define VK_LAUNCH_APP1 0xB6")]
        public const int VK_LAUNCH_APP1 = 0xB6;

        [NativeTypeName("#define VK_LAUNCH_APP2 0xB7")]
        public const int VK_LAUNCH_APP2 = 0xB7;

        [NativeTypeName("#define VK_OEM_1 0xBA")]
        public const int VK_OEM_1 = 0xBA;

        [NativeTypeName("#define VK_OEM_PLUS 0xBB")]
        public const int VK_OEM_PLUS = 0xBB;

        [NativeTypeName("#define VK_OEM_COMMA 0xBC")]
        public const int VK_OEM_COMMA = 0xBC;

        [NativeTypeName("#define VK_OEM_MINUS 0xBD")]
        public const int VK_OEM_MINUS = 0xBD;

        [NativeTypeName("#define VK_OEM_PERIOD 0xBE")]
        public const int VK_OEM_PERIOD = 0xBE;

        [NativeTypeName("#define VK_OEM_2 0xBF")]
        public const int VK_OEM_2 = 0xBF;

        [NativeTypeName("#define VK_OEM_3 0xC0")]
        public const int VK_OEM_3 = 0xC0;

        [NativeTypeName("#define VK_GAMEPAD_A 0xC3")]
        public const int VK_GAMEPAD_A = 0xC3;

        [NativeTypeName("#define VK_GAMEPAD_B 0xC4")]
        public const int VK_GAMEPAD_B = 0xC4;

        [NativeTypeName("#define VK_GAMEPAD_X 0xC5")]
        public const int VK_GAMEPAD_X = 0xC5;

        [NativeTypeName("#define VK_GAMEPAD_Y 0xC6")]
        public const int VK_GAMEPAD_Y = 0xC6;

        [NativeTypeName("#define VK_GAMEPAD_RIGHT_SHOULDER 0xC7")]
        public const int VK_GAMEPAD_RIGHT_SHOULDER = 0xC7;

        [NativeTypeName("#define VK_GAMEPAD_LEFT_SHOULDER 0xC8")]
        public const int VK_GAMEPAD_LEFT_SHOULDER = 0xC8;

        [NativeTypeName("#define VK_GAMEPAD_LEFT_TRIGGER 0xC9")]
        public const int VK_GAMEPAD_LEFT_TRIGGER = 0xC9;

        [NativeTypeName("#define VK_GAMEPAD_RIGHT_TRIGGER 0xCA")]
        public const int VK_GAMEPAD_RIGHT_TRIGGER = 0xCA;

        [NativeTypeName("#define VK_GAMEPAD_DPAD_UP 0xCB")]
        public const int VK_GAMEPAD_DPAD_UP = 0xCB;

        [NativeTypeName("#define VK_GAMEPAD_DPAD_DOWN 0xCC")]
        public const int VK_GAMEPAD_DPAD_DOWN = 0xCC;

        [NativeTypeName("#define VK_GAMEPAD_DPAD_LEFT 0xCD")]
        public const int VK_GAMEPAD_DPAD_LEFT = 0xCD;

        [NativeTypeName("#define VK_GAMEPAD_DPAD_RIGHT 0xCE")]
        public const int VK_GAMEPAD_DPAD_RIGHT = 0xCE;

        [NativeTypeName("#define VK_GAMEPAD_MENU 0xCF")]
        public const int VK_GAMEPAD_MENU = 0xCF;

        [NativeTypeName("#define VK_GAMEPAD_VIEW 0xD0")]
        public const int VK_GAMEPAD_VIEW = 0xD0;

        [NativeTypeName("#define VK_GAMEPAD_LEFT_THUMBSTICK_BUTTON 0xD1")]
        public const int VK_GAMEPAD_LEFT_THUMBSTICK_BUTTON = 0xD1;

        [NativeTypeName("#define VK_GAMEPAD_RIGHT_THUMBSTICK_BUTTON 0xD2")]
        public const int VK_GAMEPAD_RIGHT_THUMBSTICK_BUTTON = 0xD2;

        [NativeTypeName("#define VK_GAMEPAD_LEFT_THUMBSTICK_UP 0xD3")]
        public const int VK_GAMEPAD_LEFT_THUMBSTICK_UP = 0xD3;

        [NativeTypeName("#define VK_GAMEPAD_LEFT_THUMBSTICK_DOWN 0xD4")]
        public const int VK_GAMEPAD_LEFT_THUMBSTICK_DOWN = 0xD4;

        [NativeTypeName("#define VK_GAMEPAD_LEFT_THUMBSTICK_RIGHT 0xD5")]
        public const int VK_GAMEPAD_LEFT_THUMBSTICK_RIGHT = 0xD5;

        [NativeTypeName("#define VK_GAMEPAD_LEFT_THUMBSTICK_LEFT 0xD6")]
        public const int VK_GAMEPAD_LEFT_THUMBSTICK_LEFT = 0xD6;

        [NativeTypeName("#define VK_GAMEPAD_RIGHT_THUMBSTICK_UP 0xD7")]
        public const int VK_GAMEPAD_RIGHT_THUMBSTICK_UP = 0xD7;

        [NativeTypeName("#define VK_GAMEPAD_RIGHT_THUMBSTICK_DOWN 0xD8")]
        public const int VK_GAMEPAD_RIGHT_THUMBSTICK_DOWN = 0xD8;

        [NativeTypeName("#define VK_GAMEPAD_RIGHT_THUMBSTICK_RIGHT 0xD9")]
        public const int VK_GAMEPAD_RIGHT_THUMBSTICK_RIGHT = 0xD9;

        [NativeTypeName("#define VK_GAMEPAD_RIGHT_THUMBSTICK_LEFT 0xDA")]
        public const int VK_GAMEPAD_RIGHT_THUMBSTICK_LEFT = 0xDA;

        [NativeTypeName("#define VK_OEM_4 0xDB")]
        public const int VK_OEM_4 = 0xDB;

        [NativeTypeName("#define VK_OEM_5 0xDC")]
        public const int VK_OEM_5 = 0xDC;

        [NativeTypeName("#define VK_OEM_6 0xDD")]
        public const int VK_OEM_6 = 0xDD;

        [NativeTypeName("#define VK_OEM_7 0xDE")]
        public const int VK_OEM_7 = 0xDE;

        [NativeTypeName("#define VK_OEM_8 0xDF")]
        public const int VK_OEM_8 = 0xDF;

        [NativeTypeName("#define VK_OEM_AX 0xE1")]
        public const int VK_OEM_AX = 0xE1;

        [NativeTypeName("#define VK_OEM_102 0xE2")]
        public const int VK_OEM_102 = 0xE2;

        [NativeTypeName("#define VK_ICO_HELP 0xE3")]
        public const int VK_ICO_HELP = 0xE3;

        [NativeTypeName("#define VK_ICO_00 0xE4")]
        public const int VK_ICO_00 = 0xE4;

        [NativeTypeName("#define VK_PROCESSKEY 0xE5")]
        public const int VK_PROCESSKEY = 0xE5;

        [NativeTypeName("#define VK_ICO_CLEAR 0xE6")]
        public const int VK_ICO_CLEAR = 0xE6;

        [NativeTypeName("#define VK_PACKET 0xE7")]
        public const int VK_PACKET = 0xE7;

        [NativeTypeName("#define VK_OEM_RESET 0xE9")]
        public const int VK_OEM_RESET = 0xE9;

        [NativeTypeName("#define VK_OEM_JUMP 0xEA")]
        public const int VK_OEM_JUMP = 0xEA;

        [NativeTypeName("#define VK_OEM_PA1 0xEB")]
        public const int VK_OEM_PA1 = 0xEB;

        [NativeTypeName("#define VK_OEM_PA2 0xEC")]
        public const int VK_OEM_PA2 = 0xEC;

        [NativeTypeName("#define VK_OEM_PA3 0xED")]
        public const int VK_OEM_PA3 = 0xED;

        [NativeTypeName("#define VK_OEM_WSCTRL 0xEE")]
        public const int VK_OEM_WSCTRL = 0xEE;

        [NativeTypeName("#define VK_OEM_CUSEL 0xEF")]
        public const int VK_OEM_CUSEL = 0xEF;

        [NativeTypeName("#define VK_OEM_ATTN 0xF0")]
        public const int VK_OEM_ATTN = 0xF0;

        [NativeTypeName("#define VK_OEM_FINISH 0xF1")]
        public const int VK_OEM_FINISH = 0xF1;

        [NativeTypeName("#define VK_OEM_COPY 0xF2")]
        public const int VK_OEM_COPY = 0xF2;

        [NativeTypeName("#define VK_OEM_AUTO 0xF3")]
        public const int VK_OEM_AUTO = 0xF3;

        [NativeTypeName("#define VK_OEM_ENLW 0xF4")]
        public const int VK_OEM_ENLW = 0xF4;

        [NativeTypeName("#define VK_OEM_BACKTAB 0xF5")]
        public const int VK_OEM_BACKTAB = 0xF5;

        [NativeTypeName("#define VK_ATTN 0xF6")]
        public const int VK_ATTN = 0xF6;

        [NativeTypeName("#define VK_CRSEL 0xF7")]
        public const int VK_CRSEL = 0xF7;

        [NativeTypeName("#define VK_EXSEL 0xF8")]
        public const int VK_EXSEL = 0xF8;

        [NativeTypeName("#define VK_EREOF 0xF9")]
        public const int VK_EREOF = 0xF9;

        [NativeTypeName("#define VK_PLAY 0xFA")]
        public const int VK_PLAY = 0xFA;

        [NativeTypeName("#define VK_ZOOM 0xFB")]
        public const int VK_ZOOM = 0xFB;

        [NativeTypeName("#define VK_NONAME 0xFC")]
        public const int VK_NONAME = 0xFC;

        [NativeTypeName("#define VK_PA1 0xFD")]
        public const int VK_PA1 = 0xFD;

        [NativeTypeName("#define VK_OEM_CLEAR 0xFE")]
        public const int VK_OEM_CLEAR = 0xFE;

        [NativeTypeName("#define WH_MIN (-1)")]
        public const int WH_MIN = (-1);

        [NativeTypeName("#define WH_MSGFILTER (-1)")]
        public const int WH_MSGFILTER = (-1);

        [NativeTypeName("#define WH_JOURNALRECORD 0")]
        public const int WH_JOURNALRECORD = 0;

        [NativeTypeName("#define WH_JOURNALPLAYBACK 1")]
        public const int WH_JOURNALPLAYBACK = 1;

        [NativeTypeName("#define WH_KEYBOARD 2")]
        public const int WH_KEYBOARD = 2;

        [NativeTypeName("#define WH_GETMESSAGE 3")]
        public const int WH_GETMESSAGE = 3;

        [NativeTypeName("#define WH_CALLWNDPROC 4")]
        public const int WH_CALLWNDPROC = 4;

        [NativeTypeName("#define WH_CBT 5")]
        public const int WH_CBT = 5;

        [NativeTypeName("#define WH_SYSMSGFILTER 6")]
        public const int WH_SYSMSGFILTER = 6;

        [NativeTypeName("#define WH_MOUSE 7")]
        public const int WH_MOUSE = 7;

        [NativeTypeName("#define WH_DEBUG 9")]
        public const int WH_DEBUG = 9;

        [NativeTypeName("#define WH_SHELL 10")]
        public const int WH_SHELL = 10;

        [NativeTypeName("#define WH_FOREGROUNDIDLE 11")]
        public const int WH_FOREGROUNDIDLE = 11;

        [NativeTypeName("#define WH_CALLWNDPROCRET 12")]
        public const int WH_CALLWNDPROCRET = 12;

        [NativeTypeName("#define WH_KEYBOARD_LL 13")]
        public const int WH_KEYBOARD_LL = 13;

        [NativeTypeName("#define WH_MOUSE_LL 14")]
        public const int WH_MOUSE_LL = 14;

        [NativeTypeName("#define WH_MAX 14")]
        public const int WH_MAX = 14;

        [NativeTypeName("#define WH_MINHOOK WH_MIN")]
        public const int WH_MINHOOK = (-1);

        [NativeTypeName("#define WH_MAXHOOK WH_MAX")]
        public const int WH_MAXHOOK = 14;

        [NativeTypeName("#define HC_ACTION 0")]
        public const int HC_ACTION = 0;

        [NativeTypeName("#define HC_GETNEXT 1")]
        public const int HC_GETNEXT = 1;

        [NativeTypeName("#define HC_SKIP 2")]
        public const int HC_SKIP = 2;

        [NativeTypeName("#define HC_NOREMOVE 3")]
        public const int HC_NOREMOVE = 3;

        [NativeTypeName("#define HC_NOREM HC_NOREMOVE")]
        public const int HC_NOREM = 3;

        [NativeTypeName("#define HC_SYSMODALON 4")]
        public const int HC_SYSMODALON = 4;

        [NativeTypeName("#define HC_SYSMODALOFF 5")]
        public const int HC_SYSMODALOFF = 5;

        [NativeTypeName("#define HCBT_MOVESIZE 0")]
        public const int HCBT_MOVESIZE = 0;

        [NativeTypeName("#define HCBT_MINMAX 1")]
        public const int HCBT_MINMAX = 1;

        [NativeTypeName("#define HCBT_QS 2")]
        public const int HCBT_QS = 2;

        [NativeTypeName("#define HCBT_CREATEWND 3")]
        public const int HCBT_CREATEWND = 3;

        [NativeTypeName("#define HCBT_DESTROYWND 4")]
        public const int HCBT_DESTROYWND = 4;

        [NativeTypeName("#define HCBT_ACTIVATE 5")]
        public const int HCBT_ACTIVATE = 5;

        [NativeTypeName("#define HCBT_CLICKSKIPPED 6")]
        public const int HCBT_CLICKSKIPPED = 6;

        [NativeTypeName("#define HCBT_KEYSKIPPED 7")]
        public const int HCBT_KEYSKIPPED = 7;

        [NativeTypeName("#define HCBT_SYSCOMMAND 8")]
        public const int HCBT_SYSCOMMAND = 8;

        [NativeTypeName("#define HCBT_SETFOCUS 9")]
        public const int HCBT_SETFOCUS = 9;

        [NativeTypeName("#define WTS_CONSOLE_CONNECT 0x1")]
        public const int WTS_CONSOLE_CONNECT = 0x1;

        [NativeTypeName("#define WTS_CONSOLE_DISCONNECT 0x2")]
        public const int WTS_CONSOLE_DISCONNECT = 0x2;

        [NativeTypeName("#define WTS_REMOTE_CONNECT 0x3")]
        public const int WTS_REMOTE_CONNECT = 0x3;

        [NativeTypeName("#define WTS_REMOTE_DISCONNECT 0x4")]
        public const int WTS_REMOTE_DISCONNECT = 0x4;

        [NativeTypeName("#define WTS_SESSION_LOGON 0x5")]
        public const int WTS_SESSION_LOGON = 0x5;

        [NativeTypeName("#define WTS_SESSION_LOGOFF 0x6")]
        public const int WTS_SESSION_LOGOFF = 0x6;

        [NativeTypeName("#define WTS_SESSION_LOCK 0x7")]
        public const int WTS_SESSION_LOCK = 0x7;

        [NativeTypeName("#define WTS_SESSION_UNLOCK 0x8")]
        public const int WTS_SESSION_UNLOCK = 0x8;

        [NativeTypeName("#define WTS_SESSION_REMOTE_CONTROL 0x9")]
        public const int WTS_SESSION_REMOTE_CONTROL = 0x9;

        [NativeTypeName("#define WTS_SESSION_CREATE 0xa")]
        public const int WTS_SESSION_CREATE = 0xa;

        [NativeTypeName("#define WTS_SESSION_TERMINATE 0xb")]
        public const int WTS_SESSION_TERMINATE = 0xb;

        [NativeTypeName("#define MSGF_DIALOGBOX 0")]
        public const int MSGF_DIALOGBOX = 0;

        [NativeTypeName("#define MSGF_MESSAGEBOX 1")]
        public const int MSGF_MESSAGEBOX = 1;

        [NativeTypeName("#define MSGF_MENU 2")]
        public const int MSGF_MENU = 2;

        [NativeTypeName("#define MSGF_SCROLLBAR 5")]
        public const int MSGF_SCROLLBAR = 5;

        [NativeTypeName("#define MSGF_NEXTWINDOW 6")]
        public const int MSGF_NEXTWINDOW = 6;

        [NativeTypeName("#define MSGF_MAX 8")]
        public const int MSGF_MAX = 8;

        [NativeTypeName("#define MSGF_USER 4096")]
        public const int MSGF_USER = 4096;

        [NativeTypeName("#define HSHELL_WINDOWCREATED 1")]
        public const int HSHELL_WINDOWCREATED = 1;

        [NativeTypeName("#define HSHELL_WINDOWDESTROYED 2")]
        public const int HSHELL_WINDOWDESTROYED = 2;

        [NativeTypeName("#define HSHELL_ACTIVATESHELLWINDOW 3")]
        public const int HSHELL_ACTIVATESHELLWINDOW = 3;

        [NativeTypeName("#define HSHELL_WINDOWACTIVATED 4")]
        public const int HSHELL_WINDOWACTIVATED = 4;

        [NativeTypeName("#define HSHELL_GETMINRECT 5")]
        public const int HSHELL_GETMINRECT = 5;

        [NativeTypeName("#define HSHELL_REDRAW 6")]
        public const int HSHELL_REDRAW = 6;

        [NativeTypeName("#define HSHELL_TASKMAN 7")]
        public const int HSHELL_TASKMAN = 7;

        [NativeTypeName("#define HSHELL_LANGUAGE 8")]
        public const int HSHELL_LANGUAGE = 8;

        [NativeTypeName("#define HSHELL_SYSMENU 9")]
        public const int HSHELL_SYSMENU = 9;

        [NativeTypeName("#define HSHELL_ENDTASK 10")]
        public const int HSHELL_ENDTASK = 10;

        [NativeTypeName("#define HSHELL_ACCESSIBILITYSTATE 11")]
        public const int HSHELL_ACCESSIBILITYSTATE = 11;

        [NativeTypeName("#define HSHELL_APPCOMMAND 12")]
        public const int HSHELL_APPCOMMAND = 12;

        [NativeTypeName("#define HSHELL_WINDOWREPLACED 13")]
        public const int HSHELL_WINDOWREPLACED = 13;

        [NativeTypeName("#define HSHELL_WINDOWREPLACING 14")]
        public const int HSHELL_WINDOWREPLACING = 14;

        [NativeTypeName("#define HSHELL_MONITORCHANGED 16")]
        public const int HSHELL_MONITORCHANGED = 16;

        [NativeTypeName("#define HSHELL_HIGHBIT 0x8000")]
        public const int HSHELL_HIGHBIT = 0x8000;

        [NativeTypeName("#define HSHELL_FLASH (HSHELL_REDRAW|HSHELL_HIGHBIT)")]
        public const int HSHELL_FLASH = (6 | 0x8000);

        [NativeTypeName("#define HSHELL_RUDEAPPACTIVATED (HSHELL_WINDOWACTIVATED|HSHELL_HIGHBIT)")]
        public const int HSHELL_RUDEAPPACTIVATED = (4 | 0x8000);

        [NativeTypeName("#define APPCOMMAND_BROWSER_BACKWARD 1")]
        public const int APPCOMMAND_BROWSER_BACKWARD = 1;

        [NativeTypeName("#define APPCOMMAND_BROWSER_FORWARD 2")]
        public const int APPCOMMAND_BROWSER_FORWARD = 2;

        [NativeTypeName("#define APPCOMMAND_BROWSER_REFRESH 3")]
        public const int APPCOMMAND_BROWSER_REFRESH = 3;

        [NativeTypeName("#define APPCOMMAND_BROWSER_STOP 4")]
        public const int APPCOMMAND_BROWSER_STOP = 4;

        [NativeTypeName("#define APPCOMMAND_BROWSER_SEARCH 5")]
        public const int APPCOMMAND_BROWSER_SEARCH = 5;

        [NativeTypeName("#define APPCOMMAND_BROWSER_FAVORITES 6")]
        public const int APPCOMMAND_BROWSER_FAVORITES = 6;

        [NativeTypeName("#define APPCOMMAND_BROWSER_HOME 7")]
        public const int APPCOMMAND_BROWSER_HOME = 7;

        [NativeTypeName("#define APPCOMMAND_VOLUME_MUTE 8")]
        public const int APPCOMMAND_VOLUME_MUTE = 8;

        [NativeTypeName("#define APPCOMMAND_VOLUME_DOWN 9")]
        public const int APPCOMMAND_VOLUME_DOWN = 9;

        [NativeTypeName("#define APPCOMMAND_VOLUME_UP 10")]
        public const int APPCOMMAND_VOLUME_UP = 10;

        [NativeTypeName("#define APPCOMMAND_MEDIA_NEXTTRACK 11")]
        public const int APPCOMMAND_MEDIA_NEXTTRACK = 11;

        [NativeTypeName("#define APPCOMMAND_MEDIA_PREVIOUSTRACK 12")]
        public const int APPCOMMAND_MEDIA_PREVIOUSTRACK = 12;

        [NativeTypeName("#define APPCOMMAND_MEDIA_STOP 13")]
        public const int APPCOMMAND_MEDIA_STOP = 13;

        [NativeTypeName("#define APPCOMMAND_MEDIA_PLAY_PAUSE 14")]
        public const int APPCOMMAND_MEDIA_PLAY_PAUSE = 14;

        [NativeTypeName("#define APPCOMMAND_LAUNCH_MAIL 15")]
        public const int APPCOMMAND_LAUNCH_MAIL = 15;

        [NativeTypeName("#define APPCOMMAND_LAUNCH_MEDIA_SELECT 16")]
        public const int APPCOMMAND_LAUNCH_MEDIA_SELECT = 16;

        [NativeTypeName("#define APPCOMMAND_LAUNCH_APP1 17")]
        public const int APPCOMMAND_LAUNCH_APP1 = 17;

        [NativeTypeName("#define APPCOMMAND_LAUNCH_APP2 18")]
        public const int APPCOMMAND_LAUNCH_APP2 = 18;

        [NativeTypeName("#define APPCOMMAND_BASS_DOWN 19")]
        public const int APPCOMMAND_BASS_DOWN = 19;

        [NativeTypeName("#define APPCOMMAND_BASS_BOOST 20")]
        public const int APPCOMMAND_BASS_BOOST = 20;

        [NativeTypeName("#define APPCOMMAND_BASS_UP 21")]
        public const int APPCOMMAND_BASS_UP = 21;

        [NativeTypeName("#define APPCOMMAND_TREBLE_DOWN 22")]
        public const int APPCOMMAND_TREBLE_DOWN = 22;

        [NativeTypeName("#define APPCOMMAND_TREBLE_UP 23")]
        public const int APPCOMMAND_TREBLE_UP = 23;

        [NativeTypeName("#define APPCOMMAND_MICROPHONE_VOLUME_MUTE 24")]
        public const int APPCOMMAND_MICROPHONE_VOLUME_MUTE = 24;

        [NativeTypeName("#define APPCOMMAND_MICROPHONE_VOLUME_DOWN 25")]
        public const int APPCOMMAND_MICROPHONE_VOLUME_DOWN = 25;

        [NativeTypeName("#define APPCOMMAND_MICROPHONE_VOLUME_UP 26")]
        public const int APPCOMMAND_MICROPHONE_VOLUME_UP = 26;

        [NativeTypeName("#define APPCOMMAND_HELP 27")]
        public const int APPCOMMAND_HELP = 27;

        [NativeTypeName("#define APPCOMMAND_FIND 28")]
        public const int APPCOMMAND_FIND = 28;

        [NativeTypeName("#define APPCOMMAND_NEW 29")]
        public const int APPCOMMAND_NEW = 29;

        [NativeTypeName("#define APPCOMMAND_OPEN 30")]
        public const int APPCOMMAND_OPEN = 30;

        [NativeTypeName("#define APPCOMMAND_CLOSE 31")]
        public const int APPCOMMAND_CLOSE = 31;

        [NativeTypeName("#define APPCOMMAND_SAVE 32")]
        public const int APPCOMMAND_SAVE = 32;

        [NativeTypeName("#define APPCOMMAND_PRINT 33")]
        public const int APPCOMMAND_PRINT = 33;

        [NativeTypeName("#define APPCOMMAND_UNDO 34")]
        public const int APPCOMMAND_UNDO = 34;

        [NativeTypeName("#define APPCOMMAND_REDO 35")]
        public const int APPCOMMAND_REDO = 35;

        [NativeTypeName("#define APPCOMMAND_COPY 36")]
        public const int APPCOMMAND_COPY = 36;

        [NativeTypeName("#define APPCOMMAND_CUT 37")]
        public const int APPCOMMAND_CUT = 37;

        [NativeTypeName("#define APPCOMMAND_PASTE 38")]
        public const int APPCOMMAND_PASTE = 38;

        [NativeTypeName("#define APPCOMMAND_REPLY_TO_MAIL 39")]
        public const int APPCOMMAND_REPLY_TO_MAIL = 39;

        [NativeTypeName("#define APPCOMMAND_FORWARD_MAIL 40")]
        public const int APPCOMMAND_FORWARD_MAIL = 40;

        [NativeTypeName("#define APPCOMMAND_SEND_MAIL 41")]
        public const int APPCOMMAND_SEND_MAIL = 41;

        [NativeTypeName("#define APPCOMMAND_SPELL_CHECK 42")]
        public const int APPCOMMAND_SPELL_CHECK = 42;

        [NativeTypeName("#define APPCOMMAND_DICTATE_OR_COMMAND_CONTROL_TOGGLE 43")]
        public const int APPCOMMAND_DICTATE_OR_COMMAND_CONTROL_TOGGLE = 43;

        [NativeTypeName("#define APPCOMMAND_MIC_ON_OFF_TOGGLE 44")]
        public const int APPCOMMAND_MIC_ON_OFF_TOGGLE = 44;

        [NativeTypeName("#define APPCOMMAND_CORRECTION_LIST 45")]
        public const int APPCOMMAND_CORRECTION_LIST = 45;

        [NativeTypeName("#define APPCOMMAND_MEDIA_PLAY 46")]
        public const int APPCOMMAND_MEDIA_PLAY = 46;

        [NativeTypeName("#define APPCOMMAND_MEDIA_PAUSE 47")]
        public const int APPCOMMAND_MEDIA_PAUSE = 47;

        [NativeTypeName("#define APPCOMMAND_MEDIA_RECORD 48")]
        public const int APPCOMMAND_MEDIA_RECORD = 48;

        [NativeTypeName("#define APPCOMMAND_MEDIA_FAST_FORWARD 49")]
        public const int APPCOMMAND_MEDIA_FAST_FORWARD = 49;

        [NativeTypeName("#define APPCOMMAND_MEDIA_REWIND 50")]
        public const int APPCOMMAND_MEDIA_REWIND = 50;

        [NativeTypeName("#define APPCOMMAND_MEDIA_CHANNEL_UP 51")]
        public const int APPCOMMAND_MEDIA_CHANNEL_UP = 51;

        [NativeTypeName("#define APPCOMMAND_MEDIA_CHANNEL_DOWN 52")]
        public const int APPCOMMAND_MEDIA_CHANNEL_DOWN = 52;

        [NativeTypeName("#define APPCOMMAND_DELETE 53")]
        public const int APPCOMMAND_DELETE = 53;

        [NativeTypeName("#define APPCOMMAND_DWM_FLIP3D 54")]
        public const int APPCOMMAND_DWM_FLIP3D = 54;

        [NativeTypeName("#define FAPPCOMMAND_MOUSE 0x8000")]
        public const int FAPPCOMMAND_MOUSE = 0x8000;

        [NativeTypeName("#define FAPPCOMMAND_KEY 0")]
        public const int FAPPCOMMAND_KEY = 0;

        [NativeTypeName("#define FAPPCOMMAND_OEM 0x1000")]
        public const int FAPPCOMMAND_OEM = 0x1000;

        [NativeTypeName("#define FAPPCOMMAND_MASK 0xF000")]
        public const int FAPPCOMMAND_MASK = 0xF000;

        [NativeTypeName("#define LLKHF_EXTENDED (KF_EXTENDED >> 8)")]
        public const int LLKHF_EXTENDED = (0x0100 >> 8);

        [NativeTypeName("#define LLKHF_INJECTED 0x00000010")]
        public const int LLKHF_INJECTED = 0x00000010;

        [NativeTypeName("#define LLKHF_ALTDOWN (KF_ALTDOWN >> 8)")]
        public const int LLKHF_ALTDOWN = (0x2000 >> 8);

        [NativeTypeName("#define LLKHF_UP (KF_UP >> 8)")]
        public const int LLKHF_UP = (0x8000 >> 8);

        [NativeTypeName("#define LLKHF_LOWER_IL_INJECTED 0x00000002")]
        public const int LLKHF_LOWER_IL_INJECTED = 0x00000002;

        [NativeTypeName("#define LLMHF_INJECTED 0x00000001")]
        public const int LLMHF_INJECTED = 0x00000001;

        [NativeTypeName("#define LLMHF_LOWER_IL_INJECTED 0x00000002")]
        public const int LLMHF_LOWER_IL_INJECTED = 0x00000002;

        [NativeTypeName("#define HKL_PREV 0")]
        public const int HKL_PREV = 0;

        [NativeTypeName("#define HKL_NEXT 1")]
        public const int HKL_NEXT = 1;

        [NativeTypeName("#define KLF_ACTIVATE 0x00000001")]
        public const int KLF_ACTIVATE = 0x00000001;

        [NativeTypeName("#define KLF_SUBSTITUTE_OK 0x00000002")]
        public const int KLF_SUBSTITUTE_OK = 0x00000002;

        [NativeTypeName("#define KLF_REORDER 0x00000008")]
        public const int KLF_REORDER = 0x00000008;

        [NativeTypeName("#define KLF_REPLACELANG 0x00000010")]
        public const int KLF_REPLACELANG = 0x00000010;

        [NativeTypeName("#define KLF_NOTELLSHELL 0x00000080")]
        public const int KLF_NOTELLSHELL = 0x00000080;

        [NativeTypeName("#define KLF_SETFORPROCESS 0x00000100")]
        public const int KLF_SETFORPROCESS = 0x00000100;

        [NativeTypeName("#define KLF_SHIFTLOCK 0x00010000")]
        public const int KLF_SHIFTLOCK = 0x00010000;

        [NativeTypeName("#define KLF_RESET 0x40000000")]
        public const int KLF_RESET = 0x40000000;

        [NativeTypeName("#define INPUTLANGCHANGE_SYSCHARSET 0x0001")]
        public const int INPUTLANGCHANGE_SYSCHARSET = 0x0001;

        [NativeTypeName("#define INPUTLANGCHANGE_FORWARD 0x0002")]
        public const int INPUTLANGCHANGE_FORWARD = 0x0002;

        [NativeTypeName("#define INPUTLANGCHANGE_BACKWARD 0x0004")]
        public const int INPUTLANGCHANGE_BACKWARD = 0x0004;

        [NativeTypeName("#define KL_NAMELENGTH 9")]
        public const int KL_NAMELENGTH = 9;

        [NativeTypeName("#define LoadKeyboardLayout LoadKeyboardLayoutW")]
        public static readonly delegate*<ushort*, uint, IntPtr> LoadKeyboardLayout = &LoadKeyboardLayoutW;

        [NativeTypeName("#define GetKeyboardLayoutName GetKeyboardLayoutNameW")]
        public static readonly delegate*<ushort*, int> GetKeyboardLayoutName = &GetKeyboardLayoutNameW;

        [NativeTypeName("#define GMMP_USE_DISPLAY_POINTS 1")]
        public const int GMMP_USE_DISPLAY_POINTS = 1;

        [NativeTypeName("#define GMMP_USE_HIGH_RESOLUTION_POINTS 2")]
        public const int GMMP_USE_HIGH_RESOLUTION_POINTS = 2;

        [NativeTypeName("#define DESKTOP_READOBJECTS 0x0001L")]
        public const int DESKTOP_READOBJECTS = 0x0001;

        [NativeTypeName("#define DESKTOP_CREATEWINDOW 0x0002L")]
        public const int DESKTOP_CREATEWINDOW = 0x0002;

        [NativeTypeName("#define DESKTOP_CREATEMENU 0x0004L")]
        public const int DESKTOP_CREATEMENU = 0x0004;

        [NativeTypeName("#define DESKTOP_HOOKCONTROL 0x0008L")]
        public const int DESKTOP_HOOKCONTROL = 0x0008;

        [NativeTypeName("#define DESKTOP_JOURNALRECORD 0x0010L")]
        public const int DESKTOP_JOURNALRECORD = 0x0010;

        [NativeTypeName("#define DESKTOP_JOURNALPLAYBACK 0x0020L")]
        public const int DESKTOP_JOURNALPLAYBACK = 0x0020;

        [NativeTypeName("#define DESKTOP_ENUMERATE 0x0040L")]
        public const int DESKTOP_ENUMERATE = 0x0040;

        [NativeTypeName("#define DESKTOP_WRITEOBJECTS 0x0080L")]
        public const int DESKTOP_WRITEOBJECTS = 0x0080;

        [NativeTypeName("#define DESKTOP_SWITCHDESKTOP 0x0100L")]
        public const int DESKTOP_SWITCHDESKTOP = 0x0100;

        [NativeTypeName("#define DF_ALLOWOTHERACCOUNTHOOK 0x0001L")]
        public const int DF_ALLOWOTHERACCOUNTHOOK = 0x0001;

        [NativeTypeName("#define CreateDesktop CreateDesktopW")]
        public static readonly delegate*<ushort*, ushort*, DEVMODEW*, uint, uint, SECURITY_ATTRIBUTES*, IntPtr> CreateDesktop = &CreateDesktopW;

        [NativeTypeName("#define CreateDesktopEx CreateDesktopExW")]
        public static readonly delegate*<ushort*, ushort*, DEVMODEW*, uint, uint, SECURITY_ATTRIBUTES*, uint, void*, IntPtr> CreateDesktopEx = &CreateDesktopExW;

        [NativeTypeName("#define OpenDesktop OpenDesktopW")]
        public static readonly delegate*<ushort*, uint, int, uint, IntPtr> OpenDesktop = &OpenDesktopW;

        [NativeTypeName("#define EnumDesktops EnumDesktopsW")]
        public static readonly delegate*<IntPtr, delegate* unmanaged<ushort*, nint, int>, nint, int> EnumDesktops = &EnumDesktopsW;

        [NativeTypeName("#define WINSTA_ENUMDESKTOPS 0x0001L")]
        public const int WINSTA_ENUMDESKTOPS = 0x0001;

        [NativeTypeName("#define WINSTA_READATTRIBUTES 0x0002L")]
        public const int WINSTA_READATTRIBUTES = 0x0002;

        [NativeTypeName("#define WINSTA_ACCESSCLIPBOARD 0x0004L")]
        public const int WINSTA_ACCESSCLIPBOARD = 0x0004;

        [NativeTypeName("#define WINSTA_CREATEDESKTOP 0x0008L")]
        public const int WINSTA_CREATEDESKTOP = 0x0008;

        [NativeTypeName("#define WINSTA_WRITEATTRIBUTES 0x0010L")]
        public const int WINSTA_WRITEATTRIBUTES = 0x0010;

        [NativeTypeName("#define WINSTA_ACCESSGLOBALATOMS 0x0020L")]
        public const int WINSTA_ACCESSGLOBALATOMS = 0x0020;

        [NativeTypeName("#define WINSTA_EXITWINDOWS 0x0040L")]
        public const int WINSTA_EXITWINDOWS = 0x0040;

        [NativeTypeName("#define WINSTA_ENUMERATE 0x0100L")]
        public const int WINSTA_ENUMERATE = 0x0100;

        [NativeTypeName("#define WINSTA_READSCREEN 0x0200L")]
        public const int WINSTA_READSCREEN = 0x0200;

        [NativeTypeName("#define WINSTA_ALL_ACCESS (WINSTA_ENUMDESKTOPS  | WINSTA_READATTRIBUTES  | WINSTA_ACCESSCLIPBOARD | \\\r\n                                     WINSTA_CREATEDESKTOP | WINSTA_WRITEATTRIBUTES | WINSTA_ACCESSGLOBALATOMS | \\\r\n                                     WINSTA_EXITWINDOWS   | WINSTA_ENUMERATE       | WINSTA_READSCREEN)")]
        public const int WINSTA_ALL_ACCESS = (0x0001 | 0x0002 | 0x0004 | 0x0008 | 0x0010 | 0x0020 | 0x0040 | 0x0100 | 0x0200);

        [NativeTypeName("#define CWF_CREATE_ONLY 0x00000001")]
        public const int CWF_CREATE_ONLY = 0x00000001;

        [NativeTypeName("#define WSF_VISIBLE 0x0001L")]
        public const int WSF_VISIBLE = 0x0001;

        [NativeTypeName("#define CreateWindowStation CreateWindowStationW")]
        public static readonly delegate*<ushort*, uint, uint, SECURITY_ATTRIBUTES*, IntPtr> CreateWindowStation = &CreateWindowStationW;

        [NativeTypeName("#define OpenWindowStation OpenWindowStationW")]
        public static readonly delegate*<ushort*, int, uint, IntPtr> OpenWindowStation = &OpenWindowStationW;

        [NativeTypeName("#define EnumWindowStations EnumWindowStationsW")]
        public static readonly delegate*<delegate* unmanaged<ushort*, nint, int>, nint, int> EnumWindowStations = &EnumWindowStationsW;

        [NativeTypeName("#define UOI_FLAGS 1")]
        public const int UOI_FLAGS = 1;

        [NativeTypeName("#define UOI_NAME 2")]
        public const int UOI_NAME = 2;

        [NativeTypeName("#define UOI_TYPE 3")]
        public const int UOI_TYPE = 3;

        [NativeTypeName("#define UOI_USER_SID 4")]
        public const int UOI_USER_SID = 4;

        [NativeTypeName("#define UOI_HEAPSIZE 5")]
        public const int UOI_HEAPSIZE = 5;

        [NativeTypeName("#define UOI_IO 6")]
        public const int UOI_IO = 6;

        [NativeTypeName("#define UOI_TIMERPROC_EXCEPTION_SUPPRESSION 7")]
        public const int UOI_TIMERPROC_EXCEPTION_SUPPRESSION = 7;

        [NativeTypeName("#define GetUserObjectInformation GetUserObjectInformationW")]
        public static readonly delegate*<IntPtr, int, void*, uint, uint*, int> GetUserObjectInformation = &GetUserObjectInformationW;

        [NativeTypeName("#define SetUserObjectInformation SetUserObjectInformationW")]
        public static readonly delegate*<IntPtr, int, void*, uint, int> SetUserObjectInformation = &SetUserObjectInformationW;

        [NativeTypeName("#define GWL_WNDPROC (-4)")]
        public const int GWL_WNDPROC = (-4);

        [NativeTypeName("#define GWL_HINSTANCE (-6)")]
        public const int GWL_HINSTANCE = (-6);

        [NativeTypeName("#define GWL_HWNDPARENT (-8)")]
        public const int GWL_HWNDPARENT = (-8);

        [NativeTypeName("#define GWL_STYLE (-16)")]
        public const int GWL_STYLE = (-16);

        [NativeTypeName("#define GWL_EXSTYLE (-20)")]
        public const int GWL_EXSTYLE = (-20);

        [NativeTypeName("#define GWL_USERDATA (-21)")]
        public const int GWL_USERDATA = (-21);

        [NativeTypeName("#define GWL_ID (-12)")]
        public const int GWL_ID = (-12);

        [NativeTypeName("#define GWLP_WNDPROC (-4)")]
        public const int GWLP_WNDPROC = (-4);

        [NativeTypeName("#define GWLP_HINSTANCE (-6)")]
        public const int GWLP_HINSTANCE = (-6);

        [NativeTypeName("#define GWLP_HWNDPARENT (-8)")]
        public const int GWLP_HWNDPARENT = (-8);

        [NativeTypeName("#define GWLP_USERDATA (-21)")]
        public const int GWLP_USERDATA = (-21);

        [NativeTypeName("#define GWLP_ID (-12)")]
        public const int GWLP_ID = (-12);

        [NativeTypeName("#define GCL_MENUNAME (-8)")]
        public const int GCL_MENUNAME = (-8);

        [NativeTypeName("#define GCL_HBRBACKGROUND (-10)")]
        public const int GCL_HBRBACKGROUND = (-10);

        [NativeTypeName("#define GCL_HCURSOR (-12)")]
        public const int GCL_HCURSOR = (-12);

        [NativeTypeName("#define GCL_HICON (-14)")]
        public const int GCL_HICON = (-14);

        [NativeTypeName("#define GCL_HMODULE (-16)")]
        public const int GCL_HMODULE = (-16);

        [NativeTypeName("#define GCL_CBWNDEXTRA (-18)")]
        public const int GCL_CBWNDEXTRA = (-18);

        [NativeTypeName("#define GCL_CBCLSEXTRA (-20)")]
        public const int GCL_CBCLSEXTRA = (-20);

        [NativeTypeName("#define GCL_WNDPROC (-24)")]
        public const int GCL_WNDPROC = (-24);

        [NativeTypeName("#define GCL_STYLE (-26)")]
        public const int GCL_STYLE = (-26);

        [NativeTypeName("#define GCW_ATOM (-32)")]
        public const int GCW_ATOM = (-32);

        [NativeTypeName("#define GCL_HICONSM (-34)")]
        public const int GCL_HICONSM = (-34);

        [NativeTypeName("#define GCLP_MENUNAME (-8)")]
        public const int GCLP_MENUNAME = (-8);

        [NativeTypeName("#define GCLP_HBRBACKGROUND (-10)")]
        public const int GCLP_HBRBACKGROUND = (-10);

        [NativeTypeName("#define GCLP_HCURSOR (-12)")]
        public const int GCLP_HCURSOR = (-12);

        [NativeTypeName("#define GCLP_HICON (-14)")]
        public const int GCLP_HICON = (-14);

        [NativeTypeName("#define GCLP_HMODULE (-16)")]
        public const int GCLP_HMODULE = (-16);

        [NativeTypeName("#define GCLP_WNDPROC (-24)")]
        public const int GCLP_WNDPROC = (-24);

        [NativeTypeName("#define GCLP_HICONSM (-34)")]
        public const int GCLP_HICONSM = (-34);

        [NativeTypeName("#define WM_NULL 0x0000")]
        public const int WM_NULL = 0x0000;

        [NativeTypeName("#define WM_CREATE 0x0001")]
        public const int WM_CREATE = 0x0001;

        [NativeTypeName("#define WM_DESTROY 0x0002")]
        public const int WM_DESTROY = 0x0002;

        [NativeTypeName("#define WM_MOVE 0x0003")]
        public const int WM_MOVE = 0x0003;

        [NativeTypeName("#define WM_SIZE 0x0005")]
        public const int WM_SIZE = 0x0005;

        [NativeTypeName("#define WM_ACTIVATE 0x0006")]
        public const int WM_ACTIVATE = 0x0006;

        [NativeTypeName("#define WA_INACTIVE 0")]
        public const int WA_INACTIVE = 0;

        [NativeTypeName("#define WA_ACTIVE 1")]
        public const int WA_ACTIVE = 1;

        [NativeTypeName("#define WA_CLICKACTIVE 2")]
        public const int WA_CLICKACTIVE = 2;

        [NativeTypeName("#define WM_SETFOCUS 0x0007")]
        public const int WM_SETFOCUS = 0x0007;

        [NativeTypeName("#define WM_KILLFOCUS 0x0008")]
        public const int WM_KILLFOCUS = 0x0008;

        [NativeTypeName("#define WM_ENABLE 0x000A")]
        public const int WM_ENABLE = 0x000A;

        [NativeTypeName("#define WM_SETREDRAW 0x000B")]
        public const int WM_SETREDRAW = 0x000B;

        [NativeTypeName("#define WM_SETTEXT 0x000C")]
        public const int WM_SETTEXT = 0x000C;

        [NativeTypeName("#define WM_GETTEXT 0x000D")]
        public const int WM_GETTEXT = 0x000D;

        [NativeTypeName("#define WM_GETTEXTLENGTH 0x000E")]
        public const int WM_GETTEXTLENGTH = 0x000E;

        [NativeTypeName("#define WM_PAINT 0x000F")]
        public const int WM_PAINT = 0x000F;

        [NativeTypeName("#define WM_CLOSE 0x0010")]
        public const int WM_CLOSE = 0x0010;

        [NativeTypeName("#define WM_QUERYENDSESSION 0x0011")]
        public const int WM_QUERYENDSESSION = 0x0011;

        [NativeTypeName("#define WM_QUERYOPEN 0x0013")]
        public const int WM_QUERYOPEN = 0x0013;

        [NativeTypeName("#define WM_ENDSESSION 0x0016")]
        public const int WM_ENDSESSION = 0x0016;

        [NativeTypeName("#define WM_QUIT 0x0012")]
        public const int WM_QUIT = 0x0012;

        [NativeTypeName("#define WM_ERASEBKGND 0x0014")]
        public const int WM_ERASEBKGND = 0x0014;

        [NativeTypeName("#define WM_SYSCOLORCHANGE 0x0015")]
        public const int WM_SYSCOLORCHANGE = 0x0015;

        [NativeTypeName("#define WM_SHOWWINDOW 0x0018")]
        public const int WM_SHOWWINDOW = 0x0018;

        [NativeTypeName("#define WM_WININICHANGE 0x001A")]
        public const int WM_WININICHANGE = 0x001A;

        [NativeTypeName("#define WM_SETTINGCHANGE WM_WININICHANGE")]
        public const int WM_SETTINGCHANGE = 0x001A;

        [NativeTypeName("#define WM_DEVMODECHANGE 0x001B")]
        public const int WM_DEVMODECHANGE = 0x001B;

        [NativeTypeName("#define WM_ACTIVATEAPP 0x001C")]
        public const int WM_ACTIVATEAPP = 0x001C;

        [NativeTypeName("#define WM_FONTCHANGE 0x001D")]
        public const int WM_FONTCHANGE = 0x001D;

        [NativeTypeName("#define WM_TIMECHANGE 0x001E")]
        public const int WM_TIMECHANGE = 0x001E;

        [NativeTypeName("#define WM_CANCELMODE 0x001F")]
        public const int WM_CANCELMODE = 0x001F;

        [NativeTypeName("#define WM_SETCURSOR 0x0020")]
        public const int WM_SETCURSOR = 0x0020;

        [NativeTypeName("#define WM_MOUSEACTIVATE 0x0021")]
        public const int WM_MOUSEACTIVATE = 0x0021;

        [NativeTypeName("#define WM_CHILDACTIVATE 0x0022")]
        public const int WM_CHILDACTIVATE = 0x0022;

        [NativeTypeName("#define WM_QUEUESYNC 0x0023")]
        public const int WM_QUEUESYNC = 0x0023;

        [NativeTypeName("#define WM_GETMINMAXINFO 0x0024")]
        public const int WM_GETMINMAXINFO = 0x0024;

        [NativeTypeName("#define WM_PAINTICON 0x0026")]
        public const int WM_PAINTICON = 0x0026;

        [NativeTypeName("#define WM_ICONERASEBKGND 0x0027")]
        public const int WM_ICONERASEBKGND = 0x0027;

        [NativeTypeName("#define WM_NEXTDLGCTL 0x0028")]
        public const int WM_NEXTDLGCTL = 0x0028;

        [NativeTypeName("#define WM_SPOOLERSTATUS 0x002A")]
        public const int WM_SPOOLERSTATUS = 0x002A;

        [NativeTypeName("#define WM_DRAWITEM 0x002B")]
        public const int WM_DRAWITEM = 0x002B;

        [NativeTypeName("#define WM_MEASUREITEM 0x002C")]
        public const int WM_MEASUREITEM = 0x002C;

        [NativeTypeName("#define WM_DELETEITEM 0x002D")]
        public const int WM_DELETEITEM = 0x002D;

        [NativeTypeName("#define WM_VKEYTOITEM 0x002E")]
        public const int WM_VKEYTOITEM = 0x002E;

        [NativeTypeName("#define WM_CHARTOITEM 0x002F")]
        public const int WM_CHARTOITEM = 0x002F;

        [NativeTypeName("#define WM_SETFONT 0x0030")]
        public const int WM_SETFONT = 0x0030;

        [NativeTypeName("#define WM_GETFONT 0x0031")]
        public const int WM_GETFONT = 0x0031;

        [NativeTypeName("#define WM_SETHOTKEY 0x0032")]
        public const int WM_SETHOTKEY = 0x0032;

        [NativeTypeName("#define WM_GETHOTKEY 0x0033")]
        public const int WM_GETHOTKEY = 0x0033;

        [NativeTypeName("#define WM_QUERYDRAGICON 0x0037")]
        public const int WM_QUERYDRAGICON = 0x0037;

        [NativeTypeName("#define WM_COMPAREITEM 0x0039")]
        public const int WM_COMPAREITEM = 0x0039;

        [NativeTypeName("#define WM_GETOBJECT 0x003D")]
        public const int WM_GETOBJECT = 0x003D;

        [NativeTypeName("#define WM_COMPACTING 0x0041")]
        public const int WM_COMPACTING = 0x0041;

        [NativeTypeName("#define WM_COMMNOTIFY 0x0044")]
        public const int WM_COMMNOTIFY = 0x0044;

        [NativeTypeName("#define WM_WINDOWPOSCHANGING 0x0046")]
        public const int WM_WINDOWPOSCHANGING = 0x0046;

        [NativeTypeName("#define WM_WINDOWPOSCHANGED 0x0047")]
        public const int WM_WINDOWPOSCHANGED = 0x0047;

        [NativeTypeName("#define WM_POWER 0x0048")]
        public const int WM_POWER = 0x0048;

        [NativeTypeName("#define PWR_OK 1")]
        public const int PWR_OK = 1;

        [NativeTypeName("#define PWR_FAIL (-1)")]
        public const int PWR_FAIL = (-1);

        [NativeTypeName("#define PWR_SUSPENDREQUEST 1")]
        public const int PWR_SUSPENDREQUEST = 1;

        [NativeTypeName("#define PWR_SUSPENDRESUME 2")]
        public const int PWR_SUSPENDRESUME = 2;

        [NativeTypeName("#define PWR_CRITICALRESUME 3")]
        public const int PWR_CRITICALRESUME = 3;

        [NativeTypeName("#define WM_COPYDATA 0x004A")]
        public const int WM_COPYDATA = 0x004A;

        [NativeTypeName("#define WM_CANCELJOURNAL 0x004B")]
        public const int WM_CANCELJOURNAL = 0x004B;

        [NativeTypeName("#define WM_NOTIFY 0x004E")]
        public const int WM_NOTIFY = 0x004E;

        [NativeTypeName("#define WM_INPUTLANGCHANGEREQUEST 0x0050")]
        public const int WM_INPUTLANGCHANGEREQUEST = 0x0050;

        [NativeTypeName("#define WM_INPUTLANGCHANGE 0x0051")]
        public const int WM_INPUTLANGCHANGE = 0x0051;

        [NativeTypeName("#define WM_TCARD 0x0052")]
        public const int WM_TCARD = 0x0052;

        [NativeTypeName("#define WM_HELP 0x0053")]
        public const int WM_HELP = 0x0053;

        [NativeTypeName("#define WM_USERCHANGED 0x0054")]
        public const int WM_USERCHANGED = 0x0054;

        [NativeTypeName("#define WM_NOTIFYFORMAT 0x0055")]
        public const int WM_NOTIFYFORMAT = 0x0055;

        [NativeTypeName("#define NFR_ANSI 1")]
        public const int NFR_ANSI = 1;

        [NativeTypeName("#define NFR_UNICODE 2")]
        public const int NFR_UNICODE = 2;

        [NativeTypeName("#define NF_QUERY 3")]
        public const int NF_QUERY = 3;

        [NativeTypeName("#define NF_REQUERY 4")]
        public const int NF_REQUERY = 4;

        [NativeTypeName("#define WM_CONTEXTMENU 0x007B")]
        public const int WM_CONTEXTMENU = 0x007B;

        [NativeTypeName("#define WM_STYLECHANGING 0x007C")]
        public const int WM_STYLECHANGING = 0x007C;

        [NativeTypeName("#define WM_STYLECHANGED 0x007D")]
        public const int WM_STYLECHANGED = 0x007D;

        [NativeTypeName("#define WM_DISPLAYCHANGE 0x007E")]
        public const int WM_DISPLAYCHANGE = 0x007E;

        [NativeTypeName("#define WM_GETICON 0x007F")]
        public const int WM_GETICON = 0x007F;

        [NativeTypeName("#define WM_SETICON 0x0080")]
        public const int WM_SETICON = 0x0080;

        [NativeTypeName("#define WM_NCCREATE 0x0081")]
        public const int WM_NCCREATE = 0x0081;

        [NativeTypeName("#define WM_NCDESTROY 0x0082")]
        public const int WM_NCDESTROY = 0x0082;

        [NativeTypeName("#define WM_NCCALCSIZE 0x0083")]
        public const int WM_NCCALCSIZE = 0x0083;

        [NativeTypeName("#define WM_NCHITTEST 0x0084")]
        public const int WM_NCHITTEST = 0x0084;

        [NativeTypeName("#define WM_NCPAINT 0x0085")]
        public const int WM_NCPAINT = 0x0085;

        [NativeTypeName("#define WM_NCACTIVATE 0x0086")]
        public const int WM_NCACTIVATE = 0x0086;

        [NativeTypeName("#define WM_GETDLGCODE 0x0087")]
        public const int WM_GETDLGCODE = 0x0087;

        [NativeTypeName("#define WM_SYNCPAINT 0x0088")]
        public const int WM_SYNCPAINT = 0x0088;

        [NativeTypeName("#define WM_NCMOUSEMOVE 0x00A0")]
        public const int WM_NCMOUSEMOVE = 0x00A0;

        [NativeTypeName("#define WM_NCLBUTTONDOWN 0x00A1")]
        public const int WM_NCLBUTTONDOWN = 0x00A1;

        [NativeTypeName("#define WM_NCLBUTTONUP 0x00A2")]
        public const int WM_NCLBUTTONUP = 0x00A2;

        [NativeTypeName("#define WM_NCLBUTTONDBLCLK 0x00A3")]
        public const int WM_NCLBUTTONDBLCLK = 0x00A3;

        [NativeTypeName("#define WM_NCRBUTTONDOWN 0x00A4")]
        public const int WM_NCRBUTTONDOWN = 0x00A4;

        [NativeTypeName("#define WM_NCRBUTTONUP 0x00A5")]
        public const int WM_NCRBUTTONUP = 0x00A5;

        [NativeTypeName("#define WM_NCRBUTTONDBLCLK 0x00A6")]
        public const int WM_NCRBUTTONDBLCLK = 0x00A6;

        [NativeTypeName("#define WM_NCMBUTTONDOWN 0x00A7")]
        public const int WM_NCMBUTTONDOWN = 0x00A7;

        [NativeTypeName("#define WM_NCMBUTTONUP 0x00A8")]
        public const int WM_NCMBUTTONUP = 0x00A8;

        [NativeTypeName("#define WM_NCMBUTTONDBLCLK 0x00A9")]
        public const int WM_NCMBUTTONDBLCLK = 0x00A9;

        [NativeTypeName("#define WM_NCXBUTTONDOWN 0x00AB")]
        public const int WM_NCXBUTTONDOWN = 0x00AB;

        [NativeTypeName("#define WM_NCXBUTTONUP 0x00AC")]
        public const int WM_NCXBUTTONUP = 0x00AC;

        [NativeTypeName("#define WM_NCXBUTTONDBLCLK 0x00AD")]
        public const int WM_NCXBUTTONDBLCLK = 0x00AD;

        [NativeTypeName("#define WM_INPUT_DEVICE_CHANGE 0x00FE")]
        public const int WM_INPUT_DEVICE_CHANGE = 0x00FE;

        [NativeTypeName("#define WM_INPUT 0x00FF")]
        public const int WM_INPUT = 0x00FF;

        [NativeTypeName("#define WM_KEYFIRST 0x0100")]
        public const int WM_KEYFIRST = 0x0100;

        [NativeTypeName("#define WM_KEYDOWN 0x0100")]
        public const int WM_KEYDOWN = 0x0100;

        [NativeTypeName("#define WM_KEYUP 0x0101")]
        public const int WM_KEYUP = 0x0101;

        [NativeTypeName("#define WM_CHAR 0x0102")]
        public const int WM_CHAR = 0x0102;

        [NativeTypeName("#define WM_DEADCHAR 0x0103")]
        public const int WM_DEADCHAR = 0x0103;

        [NativeTypeName("#define WM_SYSKEYDOWN 0x0104")]
        public const int WM_SYSKEYDOWN = 0x0104;

        [NativeTypeName("#define WM_SYSKEYUP 0x0105")]
        public const int WM_SYSKEYUP = 0x0105;

        [NativeTypeName("#define WM_SYSCHAR 0x0106")]
        public const int WM_SYSCHAR = 0x0106;

        [NativeTypeName("#define WM_SYSDEADCHAR 0x0107")]
        public const int WM_SYSDEADCHAR = 0x0107;

        [NativeTypeName("#define WM_UNICHAR 0x0109")]
        public const int WM_UNICHAR = 0x0109;

        [NativeTypeName("#define WM_KEYLAST 0x0109")]
        public const int WM_KEYLAST = 0x0109;

        [NativeTypeName("#define UNICODE_NOCHAR 0xFFFF")]
        public const int UNICODE_NOCHAR = 0xFFFF;

        [NativeTypeName("#define WM_IME_STARTCOMPOSITION 0x010D")]
        public const int WM_IME_STARTCOMPOSITION = 0x010D;

        [NativeTypeName("#define WM_IME_ENDCOMPOSITION 0x010E")]
        public const int WM_IME_ENDCOMPOSITION = 0x010E;

        [NativeTypeName("#define WM_IME_COMPOSITION 0x010F")]
        public const int WM_IME_COMPOSITION = 0x010F;

        [NativeTypeName("#define WM_IME_KEYLAST 0x010F")]
        public const int WM_IME_KEYLAST = 0x010F;

        [NativeTypeName("#define WM_INITDIALOG 0x0110")]
        public const int WM_INITDIALOG = 0x0110;

        [NativeTypeName("#define WM_COMMAND 0x0111")]
        public const int WM_COMMAND = 0x0111;

        [NativeTypeName("#define WM_SYSCOMMAND 0x0112")]
        public const int WM_SYSCOMMAND = 0x0112;

        [NativeTypeName("#define WM_TIMER 0x0113")]
        public const int WM_TIMER = 0x0113;

        [NativeTypeName("#define WM_HSCROLL 0x0114")]
        public const int WM_HSCROLL = 0x0114;

        [NativeTypeName("#define WM_VSCROLL 0x0115")]
        public const int WM_VSCROLL = 0x0115;

        [NativeTypeName("#define WM_INITMENU 0x0116")]
        public const int WM_INITMENU = 0x0116;

        [NativeTypeName("#define WM_INITMENUPOPUP 0x0117")]
        public const int WM_INITMENUPOPUP = 0x0117;

        [NativeTypeName("#define WM_GESTURE 0x0119")]
        public const int WM_GESTURE = 0x0119;

        [NativeTypeName("#define WM_GESTURENOTIFY 0x011A")]
        public const int WM_GESTURENOTIFY = 0x011A;

        [NativeTypeName("#define WM_MENUSELECT 0x011F")]
        public const int WM_MENUSELECT = 0x011F;

        [NativeTypeName("#define WM_MENUCHAR 0x0120")]
        public const int WM_MENUCHAR = 0x0120;

        [NativeTypeName("#define WM_ENTERIDLE 0x0121")]
        public const int WM_ENTERIDLE = 0x0121;

        [NativeTypeName("#define WM_MENURBUTTONUP 0x0122")]
        public const int WM_MENURBUTTONUP = 0x0122;

        [NativeTypeName("#define WM_MENUDRAG 0x0123")]
        public const int WM_MENUDRAG = 0x0123;

        [NativeTypeName("#define WM_MENUGETOBJECT 0x0124")]
        public const int WM_MENUGETOBJECT = 0x0124;

        [NativeTypeName("#define WM_UNINITMENUPOPUP 0x0125")]
        public const int WM_UNINITMENUPOPUP = 0x0125;

        [NativeTypeName("#define WM_MENUCOMMAND 0x0126")]
        public const int WM_MENUCOMMAND = 0x0126;

        [NativeTypeName("#define WM_CHANGEUISTATE 0x0127")]
        public const int WM_CHANGEUISTATE = 0x0127;

        [NativeTypeName("#define WM_UPDATEUISTATE 0x0128")]
        public const int WM_UPDATEUISTATE = 0x0128;

        [NativeTypeName("#define WM_QUERYUISTATE 0x0129")]
        public const int WM_QUERYUISTATE = 0x0129;

        [NativeTypeName("#define UIS_SET 1")]
        public const int UIS_SET = 1;

        [NativeTypeName("#define UIS_CLEAR 2")]
        public const int UIS_CLEAR = 2;

        [NativeTypeName("#define UIS_INITIALIZE 3")]
        public const int UIS_INITIALIZE = 3;

        [NativeTypeName("#define UISF_HIDEFOCUS 0x1")]
        public const int UISF_HIDEFOCUS = 0x1;

        [NativeTypeName("#define UISF_HIDEACCEL 0x2")]
        public const int UISF_HIDEACCEL = 0x2;

        [NativeTypeName("#define UISF_ACTIVE 0x4")]
        public const int UISF_ACTIVE = 0x4;

        [NativeTypeName("#define WM_CTLCOLORMSGBOX 0x0132")]
        public const int WM_CTLCOLORMSGBOX = 0x0132;

        [NativeTypeName("#define WM_CTLCOLOREDIT 0x0133")]
        public const int WM_CTLCOLOREDIT = 0x0133;

        [NativeTypeName("#define WM_CTLCOLORLISTBOX 0x0134")]
        public const int WM_CTLCOLORLISTBOX = 0x0134;

        [NativeTypeName("#define WM_CTLCOLORBTN 0x0135")]
        public const int WM_CTLCOLORBTN = 0x0135;

        [NativeTypeName("#define WM_CTLCOLORDLG 0x0136")]
        public const int WM_CTLCOLORDLG = 0x0136;

        [NativeTypeName("#define WM_CTLCOLORSCROLLBAR 0x0137")]
        public const int WM_CTLCOLORSCROLLBAR = 0x0137;

        [NativeTypeName("#define WM_CTLCOLORSTATIC 0x0138")]
        public const int WM_CTLCOLORSTATIC = 0x0138;

        [NativeTypeName("#define MN_GETHMENU 0x01E1")]
        public const int MN_GETHMENU = 0x01E1;

        [NativeTypeName("#define WM_MOUSEFIRST 0x0200")]
        public const int WM_MOUSEFIRST = 0x0200;

        [NativeTypeName("#define WM_MOUSEMOVE 0x0200")]
        public const int WM_MOUSEMOVE = 0x0200;

        [NativeTypeName("#define WM_LBUTTONDOWN 0x0201")]
        public const int WM_LBUTTONDOWN = 0x0201;

        [NativeTypeName("#define WM_LBUTTONUP 0x0202")]
        public const int WM_LBUTTONUP = 0x0202;

        [NativeTypeName("#define WM_LBUTTONDBLCLK 0x0203")]
        public const int WM_LBUTTONDBLCLK = 0x0203;

        [NativeTypeName("#define WM_RBUTTONDOWN 0x0204")]
        public const int WM_RBUTTONDOWN = 0x0204;

        [NativeTypeName("#define WM_RBUTTONUP 0x0205")]
        public const int WM_RBUTTONUP = 0x0205;

        [NativeTypeName("#define WM_RBUTTONDBLCLK 0x0206")]
        public const int WM_RBUTTONDBLCLK = 0x0206;

        [NativeTypeName("#define WM_MBUTTONDOWN 0x0207")]
        public const int WM_MBUTTONDOWN = 0x0207;

        [NativeTypeName("#define WM_MBUTTONUP 0x0208")]
        public const int WM_MBUTTONUP = 0x0208;

        [NativeTypeName("#define WM_MBUTTONDBLCLK 0x0209")]
        public const int WM_MBUTTONDBLCLK = 0x0209;

        [NativeTypeName("#define WM_MOUSEWHEEL 0x020A")]
        public const int WM_MOUSEWHEEL = 0x020A;

        [NativeTypeName("#define WM_XBUTTONDOWN 0x020B")]
        public const int WM_XBUTTONDOWN = 0x020B;

        [NativeTypeName("#define WM_XBUTTONUP 0x020C")]
        public const int WM_XBUTTONUP = 0x020C;

        [NativeTypeName("#define WM_XBUTTONDBLCLK 0x020D")]
        public const int WM_XBUTTONDBLCLK = 0x020D;

        [NativeTypeName("#define WM_MOUSEHWHEEL 0x020E")]
        public const int WM_MOUSEHWHEEL = 0x020E;

        [NativeTypeName("#define WM_MOUSELAST 0x020E")]
        public const int WM_MOUSELAST = 0x020E;

        [NativeTypeName("#define WHEEL_DELTA 120")]
        public const int WHEEL_DELTA = 120;

        [NativeTypeName("#define WHEEL_PAGESCROLL (UINT_MAX)")]
        public const uint WHEEL_PAGESCROLL = (0xffffffff);

        [NativeTypeName("#define XBUTTON1 0x0001")]
        public const int XBUTTON1 = 0x0001;

        [NativeTypeName("#define XBUTTON2 0x0002")]
        public const int XBUTTON2 = 0x0002;

        [NativeTypeName("#define WM_PARENTNOTIFY 0x0210")]
        public const int WM_PARENTNOTIFY = 0x0210;

        [NativeTypeName("#define WM_ENTERMENULOOP 0x0211")]
        public const int WM_ENTERMENULOOP = 0x0211;

        [NativeTypeName("#define WM_EXITMENULOOP 0x0212")]
        public const int WM_EXITMENULOOP = 0x0212;

        [NativeTypeName("#define WM_NEXTMENU 0x0213")]
        public const int WM_NEXTMENU = 0x0213;

        [NativeTypeName("#define WM_SIZING 0x0214")]
        public const int WM_SIZING = 0x0214;

        [NativeTypeName("#define WM_CAPTURECHANGED 0x0215")]
        public const int WM_CAPTURECHANGED = 0x0215;

        [NativeTypeName("#define WM_MOVING 0x0216")]
        public const int WM_MOVING = 0x0216;

        [NativeTypeName("#define WM_POWERBROADCAST 0x0218")]
        public const int WM_POWERBROADCAST = 0x0218;

        [NativeTypeName("#define PBT_APMQUERYSUSPEND 0x0000")]
        public const int PBT_APMQUERYSUSPEND = 0x0000;

        [NativeTypeName("#define PBT_APMQUERYSTANDBY 0x0001")]
        public const int PBT_APMQUERYSTANDBY = 0x0001;

        [NativeTypeName("#define PBT_APMQUERYSUSPENDFAILED 0x0002")]
        public const int PBT_APMQUERYSUSPENDFAILED = 0x0002;

        [NativeTypeName("#define PBT_APMQUERYSTANDBYFAILED 0x0003")]
        public const int PBT_APMQUERYSTANDBYFAILED = 0x0003;

        [NativeTypeName("#define PBT_APMSUSPEND 0x0004")]
        public const int PBT_APMSUSPEND = 0x0004;

        [NativeTypeName("#define PBT_APMSTANDBY 0x0005")]
        public const int PBT_APMSTANDBY = 0x0005;

        [NativeTypeName("#define PBT_APMRESUMECRITICAL 0x0006")]
        public const int PBT_APMRESUMECRITICAL = 0x0006;

        [NativeTypeName("#define PBT_APMRESUMESUSPEND 0x0007")]
        public const int PBT_APMRESUMESUSPEND = 0x0007;

        [NativeTypeName("#define PBT_APMRESUMESTANDBY 0x0008")]
        public const int PBT_APMRESUMESTANDBY = 0x0008;

        [NativeTypeName("#define PBTF_APMRESUMEFROMFAILURE 0x00000001")]
        public const int PBTF_APMRESUMEFROMFAILURE = 0x00000001;

        [NativeTypeName("#define PBT_APMBATTERYLOW 0x0009")]
        public const int PBT_APMBATTERYLOW = 0x0009;

        [NativeTypeName("#define PBT_APMPOWERSTATUSCHANGE 0x000A")]
        public const int PBT_APMPOWERSTATUSCHANGE = 0x000A;

        [NativeTypeName("#define PBT_APMOEMEVENT 0x000B")]
        public const int PBT_APMOEMEVENT = 0x000B;

        [NativeTypeName("#define PBT_APMRESUMEAUTOMATIC 0x0012")]
        public const int PBT_APMRESUMEAUTOMATIC = 0x0012;

        [NativeTypeName("#define PBT_POWERSETTINGCHANGE 0x8013")]
        public const int PBT_POWERSETTINGCHANGE = 0x8013;

        [NativeTypeName("#define WM_DEVICECHANGE 0x0219")]
        public const int WM_DEVICECHANGE = 0x0219;

        [NativeTypeName("#define WM_MDICREATE 0x0220")]
        public const int WM_MDICREATE = 0x0220;

        [NativeTypeName("#define WM_MDIDESTROY 0x0221")]
        public const int WM_MDIDESTROY = 0x0221;

        [NativeTypeName("#define WM_MDIACTIVATE 0x0222")]
        public const int WM_MDIACTIVATE = 0x0222;

        [NativeTypeName("#define WM_MDIRESTORE 0x0223")]
        public const int WM_MDIRESTORE = 0x0223;

        [NativeTypeName("#define WM_MDINEXT 0x0224")]
        public const int WM_MDINEXT = 0x0224;

        [NativeTypeName("#define WM_MDIMAXIMIZE 0x0225")]
        public const int WM_MDIMAXIMIZE = 0x0225;

        [NativeTypeName("#define WM_MDITILE 0x0226")]
        public const int WM_MDITILE = 0x0226;

        [NativeTypeName("#define WM_MDICASCADE 0x0227")]
        public const int WM_MDICASCADE = 0x0227;

        [NativeTypeName("#define WM_MDIICONARRANGE 0x0228")]
        public const int WM_MDIICONARRANGE = 0x0228;

        [NativeTypeName("#define WM_MDIGETACTIVE 0x0229")]
        public const int WM_MDIGETACTIVE = 0x0229;

        [NativeTypeName("#define WM_MDISETMENU 0x0230")]
        public const int WM_MDISETMENU = 0x0230;

        [NativeTypeName("#define WM_ENTERSIZEMOVE 0x0231")]
        public const int WM_ENTERSIZEMOVE = 0x0231;

        [NativeTypeName("#define WM_EXITSIZEMOVE 0x0232")]
        public const int WM_EXITSIZEMOVE = 0x0232;

        [NativeTypeName("#define WM_DROPFILES 0x0233")]
        public const int WM_DROPFILES = 0x0233;

        [NativeTypeName("#define WM_MDIREFRESHMENU 0x0234")]
        public const int WM_MDIREFRESHMENU = 0x0234;

        [NativeTypeName("#define WM_POINTERDEVICECHANGE 0x238")]
        public const int WM_POINTERDEVICECHANGE = 0x238;

        [NativeTypeName("#define WM_POINTERDEVICEINRANGE 0x239")]
        public const int WM_POINTERDEVICEINRANGE = 0x239;

        [NativeTypeName("#define WM_POINTERDEVICEOUTOFRANGE 0x23A")]
        public const int WM_POINTERDEVICEOUTOFRANGE = 0x23A;

        [NativeTypeName("#define WM_TOUCH 0x0240")]
        public const int WM_TOUCH = 0x0240;

        [NativeTypeName("#define WM_NCPOINTERUPDATE 0x0241")]
        public const int WM_NCPOINTERUPDATE = 0x0241;

        [NativeTypeName("#define WM_NCPOINTERDOWN 0x0242")]
        public const int WM_NCPOINTERDOWN = 0x0242;

        [NativeTypeName("#define WM_NCPOINTERUP 0x0243")]
        public const int WM_NCPOINTERUP = 0x0243;

        [NativeTypeName("#define WM_POINTERUPDATE 0x0245")]
        public const int WM_POINTERUPDATE = 0x0245;

        [NativeTypeName("#define WM_POINTERDOWN 0x0246")]
        public const int WM_POINTERDOWN = 0x0246;

        [NativeTypeName("#define WM_POINTERUP 0x0247")]
        public const int WM_POINTERUP = 0x0247;

        [NativeTypeName("#define WM_POINTERENTER 0x0249")]
        public const int WM_POINTERENTER = 0x0249;

        [NativeTypeName("#define WM_POINTERLEAVE 0x024A")]
        public const int WM_POINTERLEAVE = 0x024A;

        [NativeTypeName("#define WM_POINTERACTIVATE 0x024B")]
        public const int WM_POINTERACTIVATE = 0x024B;

        [NativeTypeName("#define WM_POINTERCAPTURECHANGED 0x024C")]
        public const int WM_POINTERCAPTURECHANGED = 0x024C;

        [NativeTypeName("#define WM_TOUCHHITTESTING 0x024D")]
        public const int WM_TOUCHHITTESTING = 0x024D;

        [NativeTypeName("#define WM_POINTERWHEEL 0x024E")]
        public const int WM_POINTERWHEEL = 0x024E;

        [NativeTypeName("#define WM_POINTERHWHEEL 0x024F")]
        public const int WM_POINTERHWHEEL = 0x024F;

        [NativeTypeName("#define DM_POINTERHITTEST 0x0250")]
        public const int DM_POINTERHITTEST = 0x0250;

        [NativeTypeName("#define WM_POINTERROUTEDTO 0x0251")]
        public const int WM_POINTERROUTEDTO = 0x0251;

        [NativeTypeName("#define WM_POINTERROUTEDAWAY 0x0252")]
        public const int WM_POINTERROUTEDAWAY = 0x0252;

        [NativeTypeName("#define WM_POINTERROUTEDRELEASED 0x0253")]
        public const int WM_POINTERROUTEDRELEASED = 0x0253;

        [NativeTypeName("#define WM_IME_SETCONTEXT 0x0281")]
        public const int WM_IME_SETCONTEXT = 0x0281;

        [NativeTypeName("#define WM_IME_NOTIFY 0x0282")]
        public const int WM_IME_NOTIFY = 0x0282;

        [NativeTypeName("#define WM_IME_CONTROL 0x0283")]
        public const int WM_IME_CONTROL = 0x0283;

        [NativeTypeName("#define WM_IME_COMPOSITIONFULL 0x0284")]
        public const int WM_IME_COMPOSITIONFULL = 0x0284;

        [NativeTypeName("#define WM_IME_SELECT 0x0285")]
        public const int WM_IME_SELECT = 0x0285;

        [NativeTypeName("#define WM_IME_CHAR 0x0286")]
        public const int WM_IME_CHAR = 0x0286;

        [NativeTypeName("#define WM_IME_REQUEST 0x0288")]
        public const int WM_IME_REQUEST = 0x0288;

        [NativeTypeName("#define WM_IME_KEYDOWN 0x0290")]
        public const int WM_IME_KEYDOWN = 0x0290;

        [NativeTypeName("#define WM_IME_KEYUP 0x0291")]
        public const int WM_IME_KEYUP = 0x0291;

        [NativeTypeName("#define WM_MOUSEHOVER 0x02A1")]
        public const int WM_MOUSEHOVER = 0x02A1;

        [NativeTypeName("#define WM_MOUSELEAVE 0x02A3")]
        public const int WM_MOUSELEAVE = 0x02A3;

        [NativeTypeName("#define WM_NCMOUSEHOVER 0x02A0")]
        public const int WM_NCMOUSEHOVER = 0x02A0;

        [NativeTypeName("#define WM_NCMOUSELEAVE 0x02A2")]
        public const int WM_NCMOUSELEAVE = 0x02A2;

        [NativeTypeName("#define WM_WTSSESSION_CHANGE 0x02B1")]
        public const int WM_WTSSESSION_CHANGE = 0x02B1;

        [NativeTypeName("#define WM_TABLET_FIRST 0x02c0")]
        public const int WM_TABLET_FIRST = 0x02c0;

        [NativeTypeName("#define WM_TABLET_LAST 0x02df")]
        public const int WM_TABLET_LAST = 0x02df;

        [NativeTypeName("#define WM_DPICHANGED 0x02E0")]
        public const int WM_DPICHANGED = 0x02E0;

        [NativeTypeName("#define WM_DPICHANGED_BEFOREPARENT 0x02E2")]
        public const int WM_DPICHANGED_BEFOREPARENT = 0x02E2;

        [NativeTypeName("#define WM_DPICHANGED_AFTERPARENT 0x02E3")]
        public const int WM_DPICHANGED_AFTERPARENT = 0x02E3;

        [NativeTypeName("#define WM_GETDPISCALEDSIZE 0x02E4")]
        public const int WM_GETDPISCALEDSIZE = 0x02E4;

        [NativeTypeName("#define WM_CUT 0x0300")]
        public const int WM_CUT = 0x0300;

        [NativeTypeName("#define WM_COPY 0x0301")]
        public const int WM_COPY = 0x0301;

        [NativeTypeName("#define WM_PASTE 0x0302")]
        public const int WM_PASTE = 0x0302;

        [NativeTypeName("#define WM_CLEAR 0x0303")]
        public const int WM_CLEAR = 0x0303;

        [NativeTypeName("#define WM_UNDO 0x0304")]
        public const int WM_UNDO = 0x0304;

        [NativeTypeName("#define WM_RENDERFORMAT 0x0305")]
        public const int WM_RENDERFORMAT = 0x0305;

        [NativeTypeName("#define WM_RENDERALLFORMATS 0x0306")]
        public const int WM_RENDERALLFORMATS = 0x0306;

        [NativeTypeName("#define WM_DESTROYCLIPBOARD 0x0307")]
        public const int WM_DESTROYCLIPBOARD = 0x0307;

        [NativeTypeName("#define WM_DRAWCLIPBOARD 0x0308")]
        public const int WM_DRAWCLIPBOARD = 0x0308;

        [NativeTypeName("#define WM_PAINTCLIPBOARD 0x0309")]
        public const int WM_PAINTCLIPBOARD = 0x0309;

        [NativeTypeName("#define WM_VSCROLLCLIPBOARD 0x030A")]
        public const int WM_VSCROLLCLIPBOARD = 0x030A;

        [NativeTypeName("#define WM_SIZECLIPBOARD 0x030B")]
        public const int WM_SIZECLIPBOARD = 0x030B;

        [NativeTypeName("#define WM_ASKCBFORMATNAME 0x030C")]
        public const int WM_ASKCBFORMATNAME = 0x030C;

        [NativeTypeName("#define WM_CHANGECBCHAIN 0x030D")]
        public const int WM_CHANGECBCHAIN = 0x030D;

        [NativeTypeName("#define WM_HSCROLLCLIPBOARD 0x030E")]
        public const int WM_HSCROLLCLIPBOARD = 0x030E;

        [NativeTypeName("#define WM_QUERYNEWPALETTE 0x030F")]
        public const int WM_QUERYNEWPALETTE = 0x030F;

        [NativeTypeName("#define WM_PALETTEISCHANGING 0x0310")]
        public const int WM_PALETTEISCHANGING = 0x0310;

        [NativeTypeName("#define WM_PALETTECHANGED 0x0311")]
        public const int WM_PALETTECHANGED = 0x0311;

        [NativeTypeName("#define WM_HOTKEY 0x0312")]
        public const int WM_HOTKEY = 0x0312;

        [NativeTypeName("#define WM_PRINT 0x0317")]
        public const int WM_PRINT = 0x0317;

        [NativeTypeName("#define WM_PRINTCLIENT 0x0318")]
        public const int WM_PRINTCLIENT = 0x0318;

        [NativeTypeName("#define WM_APPCOMMAND 0x0319")]
        public const int WM_APPCOMMAND = 0x0319;

        [NativeTypeName("#define WM_THEMECHANGED 0x031A")]
        public const int WM_THEMECHANGED = 0x031A;

        [NativeTypeName("#define WM_CLIPBOARDUPDATE 0x031D")]
        public const int WM_CLIPBOARDUPDATE = 0x031D;

        [NativeTypeName("#define WM_DWMCOMPOSITIONCHANGED 0x031E")]
        public const int WM_DWMCOMPOSITIONCHANGED = 0x031E;

        [NativeTypeName("#define WM_DWMNCRENDERINGCHANGED 0x031F")]
        public const int WM_DWMNCRENDERINGCHANGED = 0x031F;

        [NativeTypeName("#define WM_DWMCOLORIZATIONCOLORCHANGED 0x0320")]
        public const int WM_DWMCOLORIZATIONCOLORCHANGED = 0x0320;

        [NativeTypeName("#define WM_DWMWINDOWMAXIMIZEDCHANGE 0x0321")]
        public const int WM_DWMWINDOWMAXIMIZEDCHANGE = 0x0321;

        [NativeTypeName("#define WM_DWMSENDICONICTHUMBNAIL 0x0323")]
        public const int WM_DWMSENDICONICTHUMBNAIL = 0x0323;

        [NativeTypeName("#define WM_DWMSENDICONICLIVEPREVIEWBITMAP 0x0326")]
        public const int WM_DWMSENDICONICLIVEPREVIEWBITMAP = 0x0326;

        [NativeTypeName("#define WM_GETTITLEBARINFOEX 0x033F")]
        public const int WM_GETTITLEBARINFOEX = 0x033F;

        [NativeTypeName("#define WM_HANDHELDFIRST 0x0358")]
        public const int WM_HANDHELDFIRST = 0x0358;

        [NativeTypeName("#define WM_HANDHELDLAST 0x035F")]
        public const int WM_HANDHELDLAST = 0x035F;

        [NativeTypeName("#define WM_AFXFIRST 0x0360")]
        public const int WM_AFXFIRST = 0x0360;

        [NativeTypeName("#define WM_AFXLAST 0x037F")]
        public const int WM_AFXLAST = 0x037F;

        [NativeTypeName("#define WM_PENWINFIRST 0x0380")]
        public const int WM_PENWINFIRST = 0x0380;

        [NativeTypeName("#define WM_PENWINLAST 0x038F")]
        public const int WM_PENWINLAST = 0x038F;

        [NativeTypeName("#define WM_APP 0x8000")]
        public const int WM_APP = 0x8000;

        [NativeTypeName("#define WM_USER 0x0400")]
        public const int WM_USER = 0x0400;

        [NativeTypeName("#define WMSZ_LEFT 1")]
        public const int WMSZ_LEFT = 1;

        [NativeTypeName("#define WMSZ_RIGHT 2")]
        public const int WMSZ_RIGHT = 2;

        [NativeTypeName("#define WMSZ_TOP 3")]
        public const int WMSZ_TOP = 3;

        [NativeTypeName("#define WMSZ_TOPLEFT 4")]
        public const int WMSZ_TOPLEFT = 4;

        [NativeTypeName("#define WMSZ_TOPRIGHT 5")]
        public const int WMSZ_TOPRIGHT = 5;

        [NativeTypeName("#define WMSZ_BOTTOM 6")]
        public const int WMSZ_BOTTOM = 6;

        [NativeTypeName("#define WMSZ_BOTTOMLEFT 7")]
        public const int WMSZ_BOTTOMLEFT = 7;

        [NativeTypeName("#define WMSZ_BOTTOMRIGHT 8")]
        public const int WMSZ_BOTTOMRIGHT = 8;

        [NativeTypeName("#define HTERROR (-2)")]
        public const int HTERROR = (-2);

        [NativeTypeName("#define HTTRANSPARENT (-1)")]
        public const int HTTRANSPARENT = (-1);

        [NativeTypeName("#define HTNOWHERE 0")]
        public const int HTNOWHERE = 0;

        [NativeTypeName("#define HTCLIENT 1")]
        public const int HTCLIENT = 1;

        [NativeTypeName("#define HTCAPTION 2")]
        public const int HTCAPTION = 2;

        [NativeTypeName("#define HTSYSMENU 3")]
        public const int HTSYSMENU = 3;

        [NativeTypeName("#define HTGROWBOX 4")]
        public const int HTGROWBOX = 4;

        [NativeTypeName("#define HTSIZE HTGROWBOX")]
        public const int HTSIZE = 4;

        [NativeTypeName("#define HTMENU 5")]
        public const int HTMENU = 5;

        [NativeTypeName("#define HTHSCROLL 6")]
        public const int HTHSCROLL = 6;

        [NativeTypeName("#define HTVSCROLL 7")]
        public const int HTVSCROLL = 7;

        [NativeTypeName("#define HTMINBUTTON 8")]
        public const int HTMINBUTTON = 8;

        [NativeTypeName("#define HTMAXBUTTON 9")]
        public const int HTMAXBUTTON = 9;

        [NativeTypeName("#define HTLEFT 10")]
        public const int HTLEFT = 10;

        [NativeTypeName("#define HTRIGHT 11")]
        public const int HTRIGHT = 11;

        [NativeTypeName("#define HTTOP 12")]
        public const int HTTOP = 12;

        [NativeTypeName("#define HTTOPLEFT 13")]
        public const int HTTOPLEFT = 13;

        [NativeTypeName("#define HTTOPRIGHT 14")]
        public const int HTTOPRIGHT = 14;

        [NativeTypeName("#define HTBOTTOM 15")]
        public const int HTBOTTOM = 15;

        [NativeTypeName("#define HTBOTTOMLEFT 16")]
        public const int HTBOTTOMLEFT = 16;

        [NativeTypeName("#define HTBOTTOMRIGHT 17")]
        public const int HTBOTTOMRIGHT = 17;

        [NativeTypeName("#define HTBORDER 18")]
        public const int HTBORDER = 18;

        [NativeTypeName("#define HTREDUCE HTMINBUTTON")]
        public const int HTREDUCE = 8;

        [NativeTypeName("#define HTZOOM HTMAXBUTTON")]
        public const int HTZOOM = 9;

        [NativeTypeName("#define HTSIZEFIRST HTLEFT")]
        public const int HTSIZEFIRST = 10;

        [NativeTypeName("#define HTSIZELAST HTBOTTOMRIGHT")]
        public const int HTSIZELAST = 17;

        [NativeTypeName("#define HTOBJECT 19")]
        public const int HTOBJECT = 19;

        [NativeTypeName("#define HTCLOSE 20")]
        public const int HTCLOSE = 20;

        [NativeTypeName("#define HTHELP 21")]
        public const int HTHELP = 21;

        [NativeTypeName("#define SMTO_NORMAL 0x0000")]
        public const int SMTO_NORMAL = 0x0000;

        [NativeTypeName("#define SMTO_BLOCK 0x0001")]
        public const int SMTO_BLOCK = 0x0001;

        [NativeTypeName("#define SMTO_ABORTIFHUNG 0x0002")]
        public const int SMTO_ABORTIFHUNG = 0x0002;

        [NativeTypeName("#define SMTO_NOTIMEOUTIFNOTHUNG 0x0008")]
        public const int SMTO_NOTIMEOUTIFNOTHUNG = 0x0008;

        [NativeTypeName("#define SMTO_ERRORONEXIT 0x0020")]
        public const int SMTO_ERRORONEXIT = 0x0020;

        [NativeTypeName("#define MA_ACTIVATE 1")]
        public const int MA_ACTIVATE = 1;

        [NativeTypeName("#define MA_ACTIVATEANDEAT 2")]
        public const int MA_ACTIVATEANDEAT = 2;

        [NativeTypeName("#define MA_NOACTIVATE 3")]
        public const int MA_NOACTIVATE = 3;

        [NativeTypeName("#define MA_NOACTIVATEANDEAT 4")]
        public const int MA_NOACTIVATEANDEAT = 4;

        [NativeTypeName("#define ICON_SMALL 0")]
        public const int ICON_SMALL = 0;

        [NativeTypeName("#define ICON_BIG 1")]
        public const int ICON_BIG = 1;

        [NativeTypeName("#define ICON_SMALL2 2")]
        public const int ICON_SMALL2 = 2;

        [NativeTypeName("#define RegisterWindowMessage RegisterWindowMessageW")]
        public static readonly delegate*<ushort*, uint> RegisterWindowMessage = &RegisterWindowMessageW;

        [NativeTypeName("#define SIZE_RESTORED 0")]
        public const int SIZE_RESTORED = 0;

        [NativeTypeName("#define SIZE_MINIMIZED 1")]
        public const int SIZE_MINIMIZED = 1;

        [NativeTypeName("#define SIZE_MAXIMIZED 2")]
        public const int SIZE_MAXIMIZED = 2;

        [NativeTypeName("#define SIZE_MAXSHOW 3")]
        public const int SIZE_MAXSHOW = 3;

        [NativeTypeName("#define SIZE_MAXHIDE 4")]
        public const int SIZE_MAXHIDE = 4;

        [NativeTypeName("#define SIZENORMAL SIZE_RESTORED")]
        public const int SIZENORMAL = 0;

        [NativeTypeName("#define SIZEICONIC SIZE_MINIMIZED")]
        public const int SIZEICONIC = 1;

        [NativeTypeName("#define SIZEFULLSCREEN SIZE_MAXIMIZED")]
        public const int SIZEFULLSCREEN = 2;

        [NativeTypeName("#define SIZEZOOMSHOW SIZE_MAXSHOW")]
        public const int SIZEZOOMSHOW = 3;

        [NativeTypeName("#define SIZEZOOMHIDE SIZE_MAXHIDE")]
        public const int SIZEZOOMHIDE = 4;

        [NativeTypeName("#define WVR_ALIGNTOP 0x0010")]
        public const int WVR_ALIGNTOP = 0x0010;

        [NativeTypeName("#define WVR_ALIGNLEFT 0x0020")]
        public const int WVR_ALIGNLEFT = 0x0020;

        [NativeTypeName("#define WVR_ALIGNBOTTOM 0x0040")]
        public const int WVR_ALIGNBOTTOM = 0x0040;

        [NativeTypeName("#define WVR_ALIGNRIGHT 0x0080")]
        public const int WVR_ALIGNRIGHT = 0x0080;

        [NativeTypeName("#define WVR_HREDRAW 0x0100")]
        public const int WVR_HREDRAW = 0x0100;

        [NativeTypeName("#define WVR_VREDRAW 0x0200")]
        public const int WVR_VREDRAW = 0x0200;

        [NativeTypeName("#define WVR_REDRAW (WVR_HREDRAW | \\\r\n                            WVR_VREDRAW)")]
        public const int WVR_REDRAW = (0x0100 | 0x0200);

        [NativeTypeName("#define WVR_VALIDRECTS 0x0400")]
        public const int WVR_VALIDRECTS = 0x0400;

        [NativeTypeName("#define MK_LBUTTON 0x0001")]
        public const int MK_LBUTTON = 0x0001;

        [NativeTypeName("#define MK_RBUTTON 0x0002")]
        public const int MK_RBUTTON = 0x0002;

        [NativeTypeName("#define MK_SHIFT 0x0004")]
        public const int MK_SHIFT = 0x0004;

        [NativeTypeName("#define MK_CONTROL 0x0008")]
        public const int MK_CONTROL = 0x0008;

        [NativeTypeName("#define MK_MBUTTON 0x0010")]
        public const int MK_MBUTTON = 0x0010;

        [NativeTypeName("#define MK_XBUTTON1 0x0020")]
        public const int MK_XBUTTON1 = 0x0020;

        [NativeTypeName("#define MK_XBUTTON2 0x0040")]
        public const int MK_XBUTTON2 = 0x0040;

        [NativeTypeName("#define TME_HOVER 0x00000001")]
        public const int TME_HOVER = 0x00000001;

        [NativeTypeName("#define TME_LEAVE 0x00000002")]
        public const int TME_LEAVE = 0x00000002;

        [NativeTypeName("#define TME_NONCLIENT 0x00000010")]
        public const int TME_NONCLIENT = 0x00000010;

        [NativeTypeName("#define TME_QUERY 0x40000000")]
        public const int TME_QUERY = 0x40000000;

        [NativeTypeName("#define TME_CANCEL 0x80000000")]
        public const uint TME_CANCEL = 0x80000000;

        [NativeTypeName("#define HOVER_DEFAULT 0xFFFFFFFF")]
        public const uint HOVER_DEFAULT = 0xFFFFFFFF;

        [NativeTypeName("#define WS_OVERLAPPED 0x00000000L")]
        public const int WS_OVERLAPPED = 0x00000000;

        [NativeTypeName("#define WS_POPUP 0x80000000L")]
        public const uint WS_POPUP = 0x80000000;

        [NativeTypeName("#define WS_CHILD 0x40000000L")]
        public const int WS_CHILD = 0x40000000;

        [NativeTypeName("#define WS_MINIMIZE 0x20000000L")]
        public const int WS_MINIMIZE = 0x20000000;

        [NativeTypeName("#define WS_VISIBLE 0x10000000L")]
        public const int WS_VISIBLE = 0x10000000;

        [NativeTypeName("#define WS_DISABLED 0x08000000L")]
        public const int WS_DISABLED = 0x08000000;

        [NativeTypeName("#define WS_CLIPSIBLINGS 0x04000000L")]
        public const int WS_CLIPSIBLINGS = 0x04000000;

        [NativeTypeName("#define WS_CLIPCHILDREN 0x02000000L")]
        public const int WS_CLIPCHILDREN = 0x02000000;

        [NativeTypeName("#define WS_MAXIMIZE 0x01000000L")]
        public const int WS_MAXIMIZE = 0x01000000;

        [NativeTypeName("#define WS_CAPTION 0x00C00000L")]
        public const int WS_CAPTION = 0x00C00000;

        [NativeTypeName("#define WS_BORDER 0x00800000L")]
        public const int WS_BORDER = 0x00800000;

        [NativeTypeName("#define WS_DLGFRAME 0x00400000L")]
        public const int WS_DLGFRAME = 0x00400000;

        [NativeTypeName("#define WS_VSCROLL 0x00200000L")]
        public const int WS_VSCROLL = 0x00200000;

        [NativeTypeName("#define WS_HSCROLL 0x00100000L")]
        public const int WS_HSCROLL = 0x00100000;

        [NativeTypeName("#define WS_SYSMENU 0x00080000L")]
        public const int WS_SYSMENU = 0x00080000;

        [NativeTypeName("#define WS_THICKFRAME 0x00040000L")]
        public const int WS_THICKFRAME = 0x00040000;

        [NativeTypeName("#define WS_GROUP 0x00020000L")]
        public const int WS_GROUP = 0x00020000;

        [NativeTypeName("#define WS_TABSTOP 0x00010000L")]
        public const int WS_TABSTOP = 0x00010000;

        [NativeTypeName("#define WS_MINIMIZEBOX 0x00020000L")]
        public const int WS_MINIMIZEBOX = 0x00020000;

        [NativeTypeName("#define WS_MAXIMIZEBOX 0x00010000L")]
        public const int WS_MAXIMIZEBOX = 0x00010000;

        [NativeTypeName("#define WS_TILED WS_OVERLAPPED")]
        public const int WS_TILED = 0x00000000;

        [NativeTypeName("#define WS_ICONIC WS_MINIMIZE")]
        public const int WS_ICONIC = 0x20000000;

        [NativeTypeName("#define WS_SIZEBOX WS_THICKFRAME")]
        public const int WS_SIZEBOX = 0x00040000;

        [NativeTypeName("#define WS_TILEDWINDOW WS_OVERLAPPEDWINDOW")]
        public const int WS_TILEDWINDOW = (0x00000000 | 0x00C00000 | 0x00080000 | 0x00040000 | 0x00020000 | 0x00010000);

        [NativeTypeName("#define WS_OVERLAPPEDWINDOW (WS_OVERLAPPED     | \\\r\n                             WS_CAPTION        | \\\r\n                             WS_SYSMENU        | \\\r\n                             WS_THICKFRAME     | \\\r\n                             WS_MINIMIZEBOX    | \\\r\n                             WS_MAXIMIZEBOX)")]
        public const int WS_OVERLAPPEDWINDOW = (0x00000000 | 0x00C00000 | 0x00080000 | 0x00040000 | 0x00020000 | 0x00010000);

        [NativeTypeName("#define WS_POPUPWINDOW (WS_POPUP          | \\\r\n                             WS_BORDER         | \\\r\n                             WS_SYSMENU)")]
        public const uint WS_POPUPWINDOW = (0x80000000 | 0x00800000 | 0x00080000);

        [NativeTypeName("#define WS_CHILDWINDOW (WS_CHILD)")]
        public const int WS_CHILDWINDOW = (0x40000000);

        [NativeTypeName("#define WS_EX_DLGMODALFRAME 0x00000001L")]
        public const int WS_EX_DLGMODALFRAME = 0x00000001;

        [NativeTypeName("#define WS_EX_NOPARENTNOTIFY 0x00000004L")]
        public const int WS_EX_NOPARENTNOTIFY = 0x00000004;

        [NativeTypeName("#define WS_EX_TOPMOST 0x00000008L")]
        public const int WS_EX_TOPMOST = 0x00000008;

        [NativeTypeName("#define WS_EX_ACCEPTFILES 0x00000010L")]
        public const int WS_EX_ACCEPTFILES = 0x00000010;

        [NativeTypeName("#define WS_EX_TRANSPARENT 0x00000020L")]
        public const int WS_EX_TRANSPARENT = 0x00000020;

        [NativeTypeName("#define WS_EX_MDICHILD 0x00000040L")]
        public const int WS_EX_MDICHILD = 0x00000040;

        [NativeTypeName("#define WS_EX_TOOLWINDOW 0x00000080L")]
        public const int WS_EX_TOOLWINDOW = 0x00000080;

        [NativeTypeName("#define WS_EX_WINDOWEDGE 0x00000100L")]
        public const int WS_EX_WINDOWEDGE = 0x00000100;

        [NativeTypeName("#define WS_EX_CLIENTEDGE 0x00000200L")]
        public const int WS_EX_CLIENTEDGE = 0x00000200;

        [NativeTypeName("#define WS_EX_CONTEXTHELP 0x00000400L")]
        public const int WS_EX_CONTEXTHELP = 0x00000400;

        [NativeTypeName("#define WS_EX_RIGHT 0x00001000L")]
        public const int WS_EX_RIGHT = 0x00001000;

        [NativeTypeName("#define WS_EX_LEFT 0x00000000L")]
        public const int WS_EX_LEFT = 0x00000000;

        [NativeTypeName("#define WS_EX_RTLREADING 0x00002000L")]
        public const int WS_EX_RTLREADING = 0x00002000;

        [NativeTypeName("#define WS_EX_LTRREADING 0x00000000L")]
        public const int WS_EX_LTRREADING = 0x00000000;

        [NativeTypeName("#define WS_EX_LEFTSCROLLBAR 0x00004000L")]
        public const int WS_EX_LEFTSCROLLBAR = 0x00004000;

        [NativeTypeName("#define WS_EX_RIGHTSCROLLBAR 0x00000000L")]
        public const int WS_EX_RIGHTSCROLLBAR = 0x00000000;

        [NativeTypeName("#define WS_EX_CONTROLPARENT 0x00010000L")]
        public const int WS_EX_CONTROLPARENT = 0x00010000;

        [NativeTypeName("#define WS_EX_STATICEDGE 0x00020000L")]
        public const int WS_EX_STATICEDGE = 0x00020000;

        [NativeTypeName("#define WS_EX_APPWINDOW 0x00040000L")]
        public const int WS_EX_APPWINDOW = 0x00040000;

        [NativeTypeName("#define WS_EX_OVERLAPPEDWINDOW (WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE)")]
        public const int WS_EX_OVERLAPPEDWINDOW = (0x00000100 | 0x00000200);

        [NativeTypeName("#define WS_EX_PALETTEWINDOW (WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST)")]
        public const int WS_EX_PALETTEWINDOW = (0x00000100 | 0x00000080 | 0x00000008);

        [NativeTypeName("#define WS_EX_LAYERED 0x00080000")]
        public const int WS_EX_LAYERED = 0x00080000;

        [NativeTypeName("#define WS_EX_NOINHERITLAYOUT 0x00100000L")]
        public const int WS_EX_NOINHERITLAYOUT = 0x00100000;

        [NativeTypeName("#define WS_EX_NOREDIRECTIONBITMAP 0x00200000L")]
        public const int WS_EX_NOREDIRECTIONBITMAP = 0x00200000;

        [NativeTypeName("#define WS_EX_LAYOUTRTL 0x00400000L")]
        public const int WS_EX_LAYOUTRTL = 0x00400000;

        [NativeTypeName("#define WS_EX_COMPOSITED 0x02000000L")]
        public const int WS_EX_COMPOSITED = 0x02000000;

        [NativeTypeName("#define WS_EX_NOACTIVATE 0x08000000L")]
        public const int WS_EX_NOACTIVATE = 0x08000000;

        [NativeTypeName("#define CS_VREDRAW 0x0001")]
        public const int CS_VREDRAW = 0x0001;

        [NativeTypeName("#define CS_HREDRAW 0x0002")]
        public const int CS_HREDRAW = 0x0002;

        [NativeTypeName("#define CS_DBLCLKS 0x0008")]
        public const int CS_DBLCLKS = 0x0008;

        [NativeTypeName("#define CS_OWNDC 0x0020")]
        public const int CS_OWNDC = 0x0020;

        [NativeTypeName("#define CS_CLASSDC 0x0040")]
        public const int CS_CLASSDC = 0x0040;

        [NativeTypeName("#define CS_PARENTDC 0x0080")]
        public const int CS_PARENTDC = 0x0080;

        [NativeTypeName("#define CS_NOCLOSE 0x0200")]
        public const int CS_NOCLOSE = 0x0200;

        [NativeTypeName("#define CS_SAVEBITS 0x0800")]
        public const int CS_SAVEBITS = 0x0800;

        [NativeTypeName("#define CS_BYTEALIGNCLIENT 0x1000")]
        public const int CS_BYTEALIGNCLIENT = 0x1000;

        [NativeTypeName("#define CS_BYTEALIGNWINDOW 0x2000")]
        public const int CS_BYTEALIGNWINDOW = 0x2000;

        [NativeTypeName("#define CS_GLOBALCLASS 0x4000")]
        public const int CS_GLOBALCLASS = 0x4000;

        [NativeTypeName("#define CS_IME 0x00010000")]
        public const int CS_IME = 0x00010000;

        [NativeTypeName("#define CS_DROPSHADOW 0x00020000")]
        public const int CS_DROPSHADOW = 0x00020000;

        [NativeTypeName("#define PRF_CHECKVISIBLE 0x00000001L")]
        public const int PRF_CHECKVISIBLE = 0x00000001;

        [NativeTypeName("#define PRF_NONCLIENT 0x00000002L")]
        public const int PRF_NONCLIENT = 0x00000002;

        [NativeTypeName("#define PRF_CLIENT 0x00000004L")]
        public const int PRF_CLIENT = 0x00000004;

        [NativeTypeName("#define PRF_ERASEBKGND 0x00000008L")]
        public const int PRF_ERASEBKGND = 0x00000008;

        [NativeTypeName("#define PRF_CHILDREN 0x00000010L")]
        public const int PRF_CHILDREN = 0x00000010;

        [NativeTypeName("#define PRF_OWNED 0x00000020L")]
        public const int PRF_OWNED = 0x00000020;

        [NativeTypeName("#define BDR_RAISEDOUTER 0x0001")]
        public const int BDR_RAISEDOUTER = 0x0001;

        [NativeTypeName("#define BDR_SUNKENOUTER 0x0002")]
        public const int BDR_SUNKENOUTER = 0x0002;

        [NativeTypeName("#define BDR_RAISEDINNER 0x0004")]
        public const int BDR_RAISEDINNER = 0x0004;

        [NativeTypeName("#define BDR_SUNKENINNER 0x0008")]
        public const int BDR_SUNKENINNER = 0x0008;

        [NativeTypeName("#define BDR_OUTER (BDR_RAISEDOUTER | BDR_SUNKENOUTER)")]
        public const int BDR_OUTER = (0x0001 | 0x0002);

        [NativeTypeName("#define BDR_INNER (BDR_RAISEDINNER | BDR_SUNKENINNER)")]
        public const int BDR_INNER = (0x0004 | 0x0008);

        [NativeTypeName("#define BDR_RAISED (BDR_RAISEDOUTER | BDR_RAISEDINNER)")]
        public const int BDR_RAISED = (0x0001 | 0x0004);

        [NativeTypeName("#define BDR_SUNKEN (BDR_SUNKENOUTER | BDR_SUNKENINNER)")]
        public const int BDR_SUNKEN = (0x0002 | 0x0008);

        [NativeTypeName("#define EDGE_RAISED (BDR_RAISEDOUTER | BDR_RAISEDINNER)")]
        public const int EDGE_RAISED = (0x0001 | 0x0004);

        [NativeTypeName("#define EDGE_SUNKEN (BDR_SUNKENOUTER | BDR_SUNKENINNER)")]
        public const int EDGE_SUNKEN = (0x0002 | 0x0008);

        [NativeTypeName("#define EDGE_ETCHED (BDR_SUNKENOUTER | BDR_RAISEDINNER)")]
        public const int EDGE_ETCHED = (0x0002 | 0x0004);

        [NativeTypeName("#define EDGE_BUMP (BDR_RAISEDOUTER | BDR_SUNKENINNER)")]
        public const int EDGE_BUMP = (0x0001 | 0x0008);

        [NativeTypeName("#define BF_LEFT 0x0001")]
        public const int BF_LEFT = 0x0001;

        [NativeTypeName("#define BF_TOP 0x0002")]
        public const int BF_TOP = 0x0002;

        [NativeTypeName("#define BF_RIGHT 0x0004")]
        public const int BF_RIGHT = 0x0004;

        [NativeTypeName("#define BF_BOTTOM 0x0008")]
        public const int BF_BOTTOM = 0x0008;

        [NativeTypeName("#define BF_TOPLEFT (BF_TOP | BF_LEFT)")]
        public const int BF_TOPLEFT = (0x0002 | 0x0001);

        [NativeTypeName("#define BF_TOPRIGHT (BF_TOP | BF_RIGHT)")]
        public const int BF_TOPRIGHT = (0x0002 | 0x0004);

        [NativeTypeName("#define BF_BOTTOMLEFT (BF_BOTTOM | BF_LEFT)")]
        public const int BF_BOTTOMLEFT = (0x0008 | 0x0001);

        [NativeTypeName("#define BF_BOTTOMRIGHT (BF_BOTTOM | BF_RIGHT)")]
        public const int BF_BOTTOMRIGHT = (0x0008 | 0x0004);

        [NativeTypeName("#define BF_RECT (BF_LEFT | BF_TOP | BF_RIGHT | BF_BOTTOM)")]
        public const int BF_RECT = (0x0001 | 0x0002 | 0x0004 | 0x0008);

        [NativeTypeName("#define BF_DIAGONAL 0x0010")]
        public const int BF_DIAGONAL = 0x0010;

        [NativeTypeName("#define BF_DIAGONAL_ENDTOPRIGHT (BF_DIAGONAL | BF_TOP | BF_RIGHT)")]
        public const int BF_DIAGONAL_ENDTOPRIGHT = (0x0010 | 0x0002 | 0x0004);

        [NativeTypeName("#define BF_DIAGONAL_ENDTOPLEFT (BF_DIAGONAL | BF_TOP | BF_LEFT)")]
        public const int BF_DIAGONAL_ENDTOPLEFT = (0x0010 | 0x0002 | 0x0001);

        [NativeTypeName("#define BF_DIAGONAL_ENDBOTTOMLEFT (BF_DIAGONAL | BF_BOTTOM | BF_LEFT)")]
        public const int BF_DIAGONAL_ENDBOTTOMLEFT = (0x0010 | 0x0008 | 0x0001);

        [NativeTypeName("#define BF_DIAGONAL_ENDBOTTOMRIGHT (BF_DIAGONAL | BF_BOTTOM | BF_RIGHT)")]
        public const int BF_DIAGONAL_ENDBOTTOMRIGHT = (0x0010 | 0x0008 | 0x0004);

        [NativeTypeName("#define BF_MIDDLE 0x0800")]
        public const int BF_MIDDLE = 0x0800;

        [NativeTypeName("#define BF_SOFT 0x1000")]
        public const int BF_SOFT = 0x1000;

        [NativeTypeName("#define BF_ADJUST 0x2000")]
        public const int BF_ADJUST = 0x2000;

        [NativeTypeName("#define BF_FLAT 0x4000")]
        public const int BF_FLAT = 0x4000;

        [NativeTypeName("#define BF_MONO 0x8000")]
        public const int BF_MONO = 0x8000;

        [NativeTypeName("#define DFC_CAPTION 1")]
        public const int DFC_CAPTION = 1;

        [NativeTypeName("#define DFC_MENU 2")]
        public const int DFC_MENU = 2;

        [NativeTypeName("#define DFC_SCROLL 3")]
        public const int DFC_SCROLL = 3;

        [NativeTypeName("#define DFC_BUTTON 4")]
        public const int DFC_BUTTON = 4;

        [NativeTypeName("#define DFC_POPUPMENU 5")]
        public const int DFC_POPUPMENU = 5;

        [NativeTypeName("#define DFCS_CAPTIONCLOSE 0x0000")]
        public const int DFCS_CAPTIONCLOSE = 0x0000;

        [NativeTypeName("#define DFCS_CAPTIONMIN 0x0001")]
        public const int DFCS_CAPTIONMIN = 0x0001;

        [NativeTypeName("#define DFCS_CAPTIONMAX 0x0002")]
        public const int DFCS_CAPTIONMAX = 0x0002;

        [NativeTypeName("#define DFCS_CAPTIONRESTORE 0x0003")]
        public const int DFCS_CAPTIONRESTORE = 0x0003;

        [NativeTypeName("#define DFCS_CAPTIONHELP 0x0004")]
        public const int DFCS_CAPTIONHELP = 0x0004;

        [NativeTypeName("#define DFCS_MENUARROW 0x0000")]
        public const int DFCS_MENUARROW = 0x0000;

        [NativeTypeName("#define DFCS_MENUCHECK 0x0001")]
        public const int DFCS_MENUCHECK = 0x0001;

        [NativeTypeName("#define DFCS_MENUBULLET 0x0002")]
        public const int DFCS_MENUBULLET = 0x0002;

        [NativeTypeName("#define DFCS_MENUARROWRIGHT 0x0004")]
        public const int DFCS_MENUARROWRIGHT = 0x0004;

        [NativeTypeName("#define DFCS_SCROLLUP 0x0000")]
        public const int DFCS_SCROLLUP = 0x0000;

        [NativeTypeName("#define DFCS_SCROLLDOWN 0x0001")]
        public const int DFCS_SCROLLDOWN = 0x0001;

        [NativeTypeName("#define DFCS_SCROLLLEFT 0x0002")]
        public const int DFCS_SCROLLLEFT = 0x0002;

        [NativeTypeName("#define DFCS_SCROLLRIGHT 0x0003")]
        public const int DFCS_SCROLLRIGHT = 0x0003;

        [NativeTypeName("#define DFCS_SCROLLCOMBOBOX 0x0005")]
        public const int DFCS_SCROLLCOMBOBOX = 0x0005;

        [NativeTypeName("#define DFCS_SCROLLSIZEGRIP 0x0008")]
        public const int DFCS_SCROLLSIZEGRIP = 0x0008;

        [NativeTypeName("#define DFCS_SCROLLSIZEGRIPRIGHT 0x0010")]
        public const int DFCS_SCROLLSIZEGRIPRIGHT = 0x0010;

        [NativeTypeName("#define DFCS_BUTTONCHECK 0x0000")]
        public const int DFCS_BUTTONCHECK = 0x0000;

        [NativeTypeName("#define DFCS_BUTTONRADIOIMAGE 0x0001")]
        public const int DFCS_BUTTONRADIOIMAGE = 0x0001;

        [NativeTypeName("#define DFCS_BUTTONRADIOMASK 0x0002")]
        public const int DFCS_BUTTONRADIOMASK = 0x0002;

        [NativeTypeName("#define DFCS_BUTTONRADIO 0x0004")]
        public const int DFCS_BUTTONRADIO = 0x0004;

        [NativeTypeName("#define DFCS_BUTTON3STATE 0x0008")]
        public const int DFCS_BUTTON3STATE = 0x0008;

        [NativeTypeName("#define DFCS_BUTTONPUSH 0x0010")]
        public const int DFCS_BUTTONPUSH = 0x0010;

        [NativeTypeName("#define DFCS_INACTIVE 0x0100")]
        public const int DFCS_INACTIVE = 0x0100;

        [NativeTypeName("#define DFCS_PUSHED 0x0200")]
        public const int DFCS_PUSHED = 0x0200;

        [NativeTypeName("#define DFCS_CHECKED 0x0400")]
        public const int DFCS_CHECKED = 0x0400;

        [NativeTypeName("#define DFCS_TRANSPARENT 0x0800")]
        public const int DFCS_TRANSPARENT = 0x0800;

        [NativeTypeName("#define DFCS_HOT 0x1000")]
        public const int DFCS_HOT = 0x1000;

        [NativeTypeName("#define DFCS_ADJUSTRECT 0x2000")]
        public const int DFCS_ADJUSTRECT = 0x2000;

        [NativeTypeName("#define DFCS_FLAT 0x4000")]
        public const int DFCS_FLAT = 0x4000;

        [NativeTypeName("#define DFCS_MONO 0x8000")]
        public const int DFCS_MONO = 0x8000;

        [NativeTypeName("#define DC_ACTIVE 0x0001")]
        public const int DC_ACTIVE = 0x0001;

        [NativeTypeName("#define DC_SMALLCAP 0x0002")]
        public const int DC_SMALLCAP = 0x0002;

        [NativeTypeName("#define DC_ICON 0x0004")]
        public const int DC_ICON = 0x0004;

        [NativeTypeName("#define DC_TEXT 0x0008")]
        public const int DC_TEXT = 0x0008;

        [NativeTypeName("#define DC_INBUTTON 0x0010")]
        public const int DC_INBUTTON = 0x0010;

        [NativeTypeName("#define DC_GRADIENT 0x0020")]
        public const int DC_GRADIENT = 0x0020;

        [NativeTypeName("#define DC_BUTTONS 0x1000")]
        public const int DC_BUTTONS = 0x1000;

        [NativeTypeName("#define IDANI_OPEN 1")]
        public const int IDANI_OPEN = 1;

        [NativeTypeName("#define IDANI_CAPTION 3")]
        public const int IDANI_CAPTION = 3;

        [NativeTypeName("#define CF_TEXT 1")]
        public const int CF_TEXT = 1;

        [NativeTypeName("#define CF_BITMAP 2")]
        public const int CF_BITMAP = 2;

        [NativeTypeName("#define CF_METAFILEPICT 3")]
        public const int CF_METAFILEPICT = 3;

        [NativeTypeName("#define CF_SYLK 4")]
        public const int CF_SYLK = 4;

        [NativeTypeName("#define CF_DIF 5")]
        public const int CF_DIF = 5;

        [NativeTypeName("#define CF_TIFF 6")]
        public const int CF_TIFF = 6;

        [NativeTypeName("#define CF_OEMTEXT 7")]
        public const int CF_OEMTEXT = 7;

        [NativeTypeName("#define CF_DIB 8")]
        public const int CF_DIB = 8;

        [NativeTypeName("#define CF_PALETTE 9")]
        public const int CF_PALETTE = 9;

        [NativeTypeName("#define CF_PENDATA 10")]
        public const int CF_PENDATA = 10;

        [NativeTypeName("#define CF_RIFF 11")]
        public const int CF_RIFF = 11;

        [NativeTypeName("#define CF_WAVE 12")]
        public const int CF_WAVE = 12;

        [NativeTypeName("#define CF_UNICODETEXT 13")]
        public const int CF_UNICODETEXT = 13;

        [NativeTypeName("#define CF_ENHMETAFILE 14")]
        public const int CF_ENHMETAFILE = 14;

        [NativeTypeName("#define CF_HDROP 15")]
        public const int CF_HDROP = 15;

        [NativeTypeName("#define CF_LOCALE 16")]
        public const int CF_LOCALE = 16;

        [NativeTypeName("#define CF_DIBV5 17")]
        public const int CF_DIBV5 = 17;

        [NativeTypeName("#define CF_MAX 18")]
        public const int CF_MAX = 18;

        [NativeTypeName("#define CF_OWNERDISPLAY 0x0080")]
        public const int CF_OWNERDISPLAY = 0x0080;

        [NativeTypeName("#define CF_DSPTEXT 0x0081")]
        public const int CF_DSPTEXT = 0x0081;

        [NativeTypeName("#define CF_DSPBITMAP 0x0082")]
        public const int CF_DSPBITMAP = 0x0082;

        [NativeTypeName("#define CF_DSPMETAFILEPICT 0x0083")]
        public const int CF_DSPMETAFILEPICT = 0x0083;

        [NativeTypeName("#define CF_DSPENHMETAFILE 0x008E")]
        public const int CF_DSPENHMETAFILE = 0x008E;

        [NativeTypeName("#define CF_PRIVATEFIRST 0x0200")]
        public const int CF_PRIVATEFIRST = 0x0200;

        [NativeTypeName("#define CF_PRIVATELAST 0x02FF")]
        public const int CF_PRIVATELAST = 0x02FF;

        [NativeTypeName("#define CF_GDIOBJFIRST 0x0300")]
        public const int CF_GDIOBJFIRST = 0x0300;

        [NativeTypeName("#define CF_GDIOBJLAST 0x03FF")]
        public const int CF_GDIOBJLAST = 0x03FF;

        [NativeTypeName("#define FVIRTKEY TRUE")]
        public const int FVIRTKEY = 1;

        [NativeTypeName("#define FNOINVERT 0x02")]
        public const int FNOINVERT = 0x02;

        [NativeTypeName("#define FSHIFT 0x04")]
        public const int FSHIFT = 0x04;

        [NativeTypeName("#define FCONTROL 0x08")]
        public const int FCONTROL = 0x08;

        [NativeTypeName("#define FALT 0x10")]
        public const int FALT = 0x10;

        [NativeTypeName("#define WPF_SETMINPOSITION 0x0001")]
        public const int WPF_SETMINPOSITION = 0x0001;

        [NativeTypeName("#define WPF_RESTORETOMAXIMIZED 0x0002")]
        public const int WPF_RESTORETOMAXIMIZED = 0x0002;

        [NativeTypeName("#define WPF_ASYNCWINDOWPLACEMENT 0x0004")]
        public const int WPF_ASYNCWINDOWPLACEMENT = 0x0004;

        [NativeTypeName("#define ODT_MENU 1")]
        public const int ODT_MENU = 1;

        [NativeTypeName("#define ODT_LISTBOX 2")]
        public const int ODT_LISTBOX = 2;

        [NativeTypeName("#define ODT_COMBOBOX 3")]
        public const int ODT_COMBOBOX = 3;

        [NativeTypeName("#define ODT_BUTTON 4")]
        public const int ODT_BUTTON = 4;

        [NativeTypeName("#define ODT_STATIC 5")]
        public const int ODT_STATIC = 5;

        [NativeTypeName("#define ODA_DRAWENTIRE 0x0001")]
        public const int ODA_DRAWENTIRE = 0x0001;

        [NativeTypeName("#define ODA_SELECT 0x0002")]
        public const int ODA_SELECT = 0x0002;

        [NativeTypeName("#define ODA_FOCUS 0x0004")]
        public const int ODA_FOCUS = 0x0004;

        [NativeTypeName("#define ODS_SELECTED 0x0001")]
        public const int ODS_SELECTED = 0x0001;

        [NativeTypeName("#define ODS_GRAYED 0x0002")]
        public const int ODS_GRAYED = 0x0002;

        [NativeTypeName("#define ODS_DISABLED 0x0004")]
        public const int ODS_DISABLED = 0x0004;

        [NativeTypeName("#define ODS_CHECKED 0x0008")]
        public const int ODS_CHECKED = 0x0008;

        [NativeTypeName("#define ODS_FOCUS 0x0010")]
        public const int ODS_FOCUS = 0x0010;

        [NativeTypeName("#define ODS_DEFAULT 0x0020")]
        public const int ODS_DEFAULT = 0x0020;

        [NativeTypeName("#define ODS_COMBOBOXEDIT 0x1000")]
        public const int ODS_COMBOBOXEDIT = 0x1000;

        [NativeTypeName("#define ODS_HOTLIGHT 0x0040")]
        public const int ODS_HOTLIGHT = 0x0040;

        [NativeTypeName("#define ODS_INACTIVE 0x0080")]
        public const int ODS_INACTIVE = 0x0080;

        [NativeTypeName("#define ODS_NOACCEL 0x0100")]
        public const int ODS_NOACCEL = 0x0100;

        [NativeTypeName("#define ODS_NOFOCUSRECT 0x0200")]
        public const int ODS_NOFOCUSRECT = 0x0200;

        [NativeTypeName("#define GetMessage GetMessageW")]
        public static readonly delegate*<MSG*, IntPtr, uint, uint, int> GetMessage = &GetMessageW;

        [NativeTypeName("#define DispatchMessage DispatchMessageW")]
        public static readonly delegate*<MSG*, nint> DispatchMessage = &DispatchMessageW;

        [NativeTypeName("#define PeekMessage PeekMessageW")]
        public static readonly delegate*<MSG*, IntPtr, uint, uint, uint, int> PeekMessage = &PeekMessageW;

        [NativeTypeName("#define PM_NOREMOVE 0x0000")]
        public const int PM_NOREMOVE = 0x0000;

        [NativeTypeName("#define PM_REMOVE 0x0001")]
        public const int PM_REMOVE = 0x0001;

        [NativeTypeName("#define PM_NOYIELD 0x0002")]
        public const int PM_NOYIELD = 0x0002;

        [NativeTypeName("#define PM_QS_INPUT (QS_INPUT << 16)")]
        public const int PM_QS_INPUT = (((0x0002 | 0x0004) | 0x0001 | 0x0400 | 0x0800 | 0x1000) << 16);

        [NativeTypeName("#define PM_QS_POSTMESSAGE ((QS_POSTMESSAGE | QS_HOTKEY | QS_TIMER) << 16)")]
        public const int PM_QS_POSTMESSAGE = ((0x0008 | 0x0080 | 0x0010) << 16);

        [NativeTypeName("#define PM_QS_PAINT (QS_PAINT << 16)")]
        public const int PM_QS_PAINT = (0x0020 << 16);

        [NativeTypeName("#define PM_QS_SENDMESSAGE (QS_SENDMESSAGE << 16)")]
        public const int PM_QS_SENDMESSAGE = (0x0040 << 16);

        [NativeTypeName("#define MOD_ALT 0x0001")]
        public const int MOD_ALT = 0x0001;

        [NativeTypeName("#define MOD_CONTROL 0x0002")]
        public const int MOD_CONTROL = 0x0002;

        [NativeTypeName("#define MOD_SHIFT 0x0004")]
        public const int MOD_SHIFT = 0x0004;

        [NativeTypeName("#define MOD_WIN 0x0008")]
        public const int MOD_WIN = 0x0008;

        [NativeTypeName("#define MOD_NOREPEAT 0x4000")]
        public const int MOD_NOREPEAT = 0x4000;

        [NativeTypeName("#define IDHOT_SNAPWINDOW (-1)")]
        public const int IDHOT_SNAPWINDOW = (-1);

        [NativeTypeName("#define IDHOT_SNAPDESKTOP (-2)")]
        public const int IDHOT_SNAPDESKTOP = (-2);

        [NativeTypeName("#define ENDSESSION_CLOSEAPP 0x00000001")]
        public const int ENDSESSION_CLOSEAPP = 0x00000001;

        [NativeTypeName("#define ENDSESSION_CRITICAL 0x40000000")]
        public const int ENDSESSION_CRITICAL = 0x40000000;

        [NativeTypeName("#define ENDSESSION_LOGOFF 0x80000000")]
        public const uint ENDSESSION_LOGOFF = 0x80000000;

        [NativeTypeName("#define EWX_LOGOFF 0x00000000")]
        public const int EWX_LOGOFF = 0x00000000;

        [NativeTypeName("#define EWX_SHUTDOWN 0x00000001")]
        public const int EWX_SHUTDOWN = 0x00000001;

        [NativeTypeName("#define EWX_REBOOT 0x00000002")]
        public const int EWX_REBOOT = 0x00000002;

        [NativeTypeName("#define EWX_FORCE 0x00000004")]
        public const int EWX_FORCE = 0x00000004;

        [NativeTypeName("#define EWX_POWEROFF 0x00000008")]
        public const int EWX_POWEROFF = 0x00000008;

        [NativeTypeName("#define EWX_FORCEIFHUNG 0x00000010")]
        public const int EWX_FORCEIFHUNG = 0x00000010;

        [NativeTypeName("#define EWX_QUICKRESOLVE 0x00000020")]
        public const int EWX_QUICKRESOLVE = 0x00000020;

        [NativeTypeName("#define EWX_RESTARTAPPS 0x00000040")]
        public const int EWX_RESTARTAPPS = 0x00000040;

        [NativeTypeName("#define EWX_HYBRID_SHUTDOWN 0x00400000")]
        public const int EWX_HYBRID_SHUTDOWN = 0x00400000;

        [NativeTypeName("#define EWX_BOOTOPTIONS 0x01000000")]
        public const int EWX_BOOTOPTIONS = 0x01000000;

        [NativeTypeName("#define EWX_ARSO 0x04000000")]
        public const int EWX_ARSO = 0x04000000;

        [NativeTypeName("#define SendMessage SendMessageW")]
        public static readonly delegate*<IntPtr, uint, nuint, nint, nint> SendMessage = &SendMessageW;

        [NativeTypeName("#define SendMessageTimeout SendMessageTimeoutW")]
        public static readonly delegate*<IntPtr, uint, nuint, nint, uint, uint, nuint*, nint> SendMessageTimeout = &SendMessageTimeoutW;

        [NativeTypeName("#define SendNotifyMessage SendNotifyMessageW")]
        public static readonly delegate*<IntPtr, uint, nuint, nint, int> SendNotifyMessage = &SendNotifyMessageW;

        [NativeTypeName("#define SendMessageCallback SendMessageCallbackW")]
        public static readonly delegate*<IntPtr, uint, nuint, nint, delegate* unmanaged<IntPtr, uint, nuint, nint, void>, nuint, int> SendMessageCallback = &SendMessageCallbackW;

        [NativeTypeName("#define BroadcastSystemMessageEx BroadcastSystemMessageExW")]
        public static readonly delegate*<uint, uint*, uint, nuint, nint, BSMINFO*, int> BroadcastSystemMessageEx = &BroadcastSystemMessageExW;

        [NativeTypeName("#define BroadcastSystemMessage BroadcastSystemMessageW")]
        public static readonly delegate*<uint, uint*, uint, nuint, nint, int> BroadcastSystemMessage = &BroadcastSystemMessageW;

        [NativeTypeName("#define BSM_ALLCOMPONENTS 0x00000000")]
        public const int BSM_ALLCOMPONENTS = 0x00000000;

        [NativeTypeName("#define BSM_VXDS 0x00000001")]
        public const int BSM_VXDS = 0x00000001;

        [NativeTypeName("#define BSM_NETDRIVER 0x00000002")]
        public const int BSM_NETDRIVER = 0x00000002;

        [NativeTypeName("#define BSM_INSTALLABLEDRIVERS 0x00000004")]
        public const int BSM_INSTALLABLEDRIVERS = 0x00000004;

        [NativeTypeName("#define BSM_APPLICATIONS 0x00000008")]
        public const int BSM_APPLICATIONS = 0x00000008;

        [NativeTypeName("#define BSM_ALLDESKTOPS 0x00000010")]
        public const int BSM_ALLDESKTOPS = 0x00000010;

        [NativeTypeName("#define BSF_QUERY 0x00000001")]
        public const int BSF_QUERY = 0x00000001;

        [NativeTypeName("#define BSF_IGNORECURRENTTASK 0x00000002")]
        public const int BSF_IGNORECURRENTTASK = 0x00000002;

        [NativeTypeName("#define BSF_FLUSHDISK 0x00000004")]
        public const int BSF_FLUSHDISK = 0x00000004;

        [NativeTypeName("#define BSF_NOHANG 0x00000008")]
        public const int BSF_NOHANG = 0x00000008;

        [NativeTypeName("#define BSF_POSTMESSAGE 0x00000010")]
        public const int BSF_POSTMESSAGE = 0x00000010;

        [NativeTypeName("#define BSF_FORCEIFHUNG 0x00000020")]
        public const int BSF_FORCEIFHUNG = 0x00000020;

        [NativeTypeName("#define BSF_NOTIMEOUTIFNOTHUNG 0x00000040")]
        public const int BSF_NOTIMEOUTIFNOTHUNG = 0x00000040;

        [NativeTypeName("#define BSF_ALLOWSFW 0x00000080")]
        public const int BSF_ALLOWSFW = 0x00000080;

        [NativeTypeName("#define BSF_SENDNOTIFYMESSAGE 0x00000100")]
        public const int BSF_SENDNOTIFYMESSAGE = 0x00000100;

        [NativeTypeName("#define BSF_RETURNHDESK 0x00000200")]
        public const int BSF_RETURNHDESK = 0x00000200;

        [NativeTypeName("#define BSF_LUID 0x00000400")]
        public const int BSF_LUID = 0x00000400;

        [NativeTypeName("#define BROADCAST_QUERY_DENY 0x424D5144")]
        public const int BROADCAST_QUERY_DENY = 0x424D5144;

        [NativeTypeName("#define DEVICE_NOTIFY_WINDOW_HANDLE 0x00000000")]
        public const int DEVICE_NOTIFY_WINDOW_HANDLE = 0x00000000;

        [NativeTypeName("#define DEVICE_NOTIFY_SERVICE_HANDLE 0x00000001")]
        public const int DEVICE_NOTIFY_SERVICE_HANDLE = 0x00000001;

        [NativeTypeName("#define DEVICE_NOTIFY_ALL_INTERFACE_CLASSES 0x00000004")]
        public const int DEVICE_NOTIFY_ALL_INTERFACE_CLASSES = 0x00000004;

        [NativeTypeName("#define RegisterDeviceNotification RegisterDeviceNotificationW")]
        public static readonly delegate*<IntPtr, void*, uint, void*> RegisterDeviceNotification = &RegisterDeviceNotificationW;

        [NativeTypeName("#define PostMessage PostMessageW")]
        public static readonly delegate*<IntPtr, uint, nuint, nint, int> PostMessage = &PostMessageW;

        [NativeTypeName("#define PostThreadMessage PostThreadMessageW")]
        public static readonly delegate*<uint, uint, nuint, nint, int> PostThreadMessage = &PostThreadMessageW;

        [NativeTypeName("#define HWND_BROADCAST ((HWND)0xffff)")]
        public static readonly IntPtr HWND_BROADCAST = ((IntPtr)(0xffff));

        [NativeTypeName("#define HWND_MESSAGE ((HWND)-3)")]
        public static readonly IntPtr HWND_MESSAGE = ((IntPtr)(-3));

        [NativeTypeName("#define DefWindowProc DefWindowProcW")]
        public static readonly delegate*<IntPtr, uint, nuint, nint, nint> DefWindowProc = &DefWindowProcW;

        [NativeTypeName("#define CallWindowProc CallWindowProcW")]
        public static readonly delegate*<delegate* unmanaged<IntPtr, uint, nuint, nint, nint>, IntPtr, uint, nuint, nint, nint> CallWindowProc = &CallWindowProcW;

        [NativeTypeName("#define ISMEX_NOSEND 0x00000000")]
        public const int ISMEX_NOSEND = 0x00000000;

        [NativeTypeName("#define ISMEX_SEND 0x00000001")]
        public const int ISMEX_SEND = 0x00000001;

        [NativeTypeName("#define ISMEX_NOTIFY 0x00000002")]
        public const int ISMEX_NOTIFY = 0x00000002;

        [NativeTypeName("#define ISMEX_CALLBACK 0x00000004")]
        public const int ISMEX_CALLBACK = 0x00000004;

        [NativeTypeName("#define ISMEX_REPLIED 0x00000008")]
        public const int ISMEX_REPLIED = 0x00000008;

        [NativeTypeName("#define RegisterClass RegisterClassW")]
        public static readonly delegate*<WNDCLASSW*, ushort> RegisterClass = &RegisterClassW;

        [NativeTypeName("#define UnregisterClass UnregisterClassW")]
        public static readonly delegate*<ushort*, IntPtr, int> UnregisterClass = &UnregisterClassW;

        [NativeTypeName("#define GetClassInfo GetClassInfoW")]
        public static readonly delegate*<IntPtr, ushort*, WNDCLASSW*, int> GetClassInfo = &GetClassInfoW;

        [NativeTypeName("#define RegisterClassEx RegisterClassExW")]
        public static readonly delegate*<WNDCLASSEXW*, ushort> RegisterClassEx = &RegisterClassExW;

        [NativeTypeName("#define GetClassInfoEx GetClassInfoExW")]
        public static readonly delegate*<IntPtr, ushort*, WNDCLASSEXW*, int> GetClassInfoEx = &GetClassInfoExW;

        [NativeTypeName("#define CW_USEDEFAULT ((int)0x80000000)")]
        public const int CW_USEDEFAULT = unchecked((int)(0x80000000));

        [NativeTypeName("#define HWND_DESKTOP ((HWND)0)")]
        public static readonly IntPtr HWND_DESKTOP = ((IntPtr)(0));

        [NativeTypeName("#define CreateWindowEx CreateWindowExW")]
        public static readonly delegate*<uint, ushort*, ushort*, uint, int, int, int, int, IntPtr, IntPtr, IntPtr, void*, IntPtr> CreateWindowEx = &CreateWindowExW;

        [NativeTypeName("#define PW_CLIENTONLY 0x00000001")]
        public const int PW_CLIENTONLY = 0x00000001;

        [NativeTypeName("#define PW_RENDERFULLCONTENT 0x00000002")]
        public const int PW_RENDERFULLCONTENT = 0x00000002;

        [NativeTypeName("#define LWA_COLORKEY 0x00000001")]
        public const int LWA_COLORKEY = 0x00000001;

        [NativeTypeName("#define LWA_ALPHA 0x00000002")]
        public const int LWA_ALPHA = 0x00000002;

        [NativeTypeName("#define ULW_COLORKEY 0x00000001")]
        public const int ULW_COLORKEY = 0x00000001;

        [NativeTypeName("#define ULW_ALPHA 0x00000002")]
        public const int ULW_ALPHA = 0x00000002;

        [NativeTypeName("#define ULW_OPAQUE 0x00000004")]
        public const int ULW_OPAQUE = 0x00000004;

        [NativeTypeName("#define ULW_EX_NORESIZE 0x00000008")]
        public const int ULW_EX_NORESIZE = 0x00000008;

        [NativeTypeName("#define FLASHW_STOP 0")]
        public const int FLASHW_STOP = 0;

        [NativeTypeName("#define FLASHW_CAPTION 0x00000001")]
        public const int FLASHW_CAPTION = 0x00000001;

        [NativeTypeName("#define FLASHW_TRAY 0x00000002")]
        public const int FLASHW_TRAY = 0x00000002;

        [NativeTypeName("#define FLASHW_ALL (FLASHW_CAPTION | FLASHW_TRAY)")]
        public const int FLASHW_ALL = (0x00000001 | 0x00000002);

        [NativeTypeName("#define FLASHW_TIMER 0x00000004")]
        public const int FLASHW_TIMER = 0x00000004;

        [NativeTypeName("#define FLASHW_TIMERNOFG 0x0000000C")]
        public const int FLASHW_TIMERNOFG = 0x0000000C;

        [NativeTypeName("#define WDA_NONE 0x00000000")]
        public const int WDA_NONE = 0x00000000;

        [NativeTypeName("#define WDA_MONITOR 0x00000001")]
        public const int WDA_MONITOR = 0x00000001;

        [NativeTypeName("#define WDA_EXCLUDEFROMCAPTURE 0x00000011")]
        public const int WDA_EXCLUDEFROMCAPTURE = 0x00000011;

        [NativeTypeName("#define SWP_NOSIZE 0x0001")]
        public const int SWP_NOSIZE = 0x0001;

        [NativeTypeName("#define SWP_NOMOVE 0x0002")]
        public const int SWP_NOMOVE = 0x0002;

        [NativeTypeName("#define SWP_NOZORDER 0x0004")]
        public const int SWP_NOZORDER = 0x0004;

        [NativeTypeName("#define SWP_NOREDRAW 0x0008")]
        public const int SWP_NOREDRAW = 0x0008;

        [NativeTypeName("#define SWP_NOACTIVATE 0x0010")]
        public const int SWP_NOACTIVATE = 0x0010;

        [NativeTypeName("#define SWP_FRAMECHANGED 0x0020")]
        public const int SWP_FRAMECHANGED = 0x0020;

        [NativeTypeName("#define SWP_SHOWWINDOW 0x0040")]
        public const int SWP_SHOWWINDOW = 0x0040;

        [NativeTypeName("#define SWP_HIDEWINDOW 0x0080")]
        public const int SWP_HIDEWINDOW = 0x0080;

        [NativeTypeName("#define SWP_NOCOPYBITS 0x0100")]
        public const int SWP_NOCOPYBITS = 0x0100;

        [NativeTypeName("#define SWP_NOOWNERZORDER 0x0200")]
        public const int SWP_NOOWNERZORDER = 0x0200;

        [NativeTypeName("#define SWP_NOSENDCHANGING 0x0400")]
        public const int SWP_NOSENDCHANGING = 0x0400;

        [NativeTypeName("#define SWP_DRAWFRAME SWP_FRAMECHANGED")]
        public const int SWP_DRAWFRAME = 0x0020;

        [NativeTypeName("#define SWP_NOREPOSITION SWP_NOOWNERZORDER")]
        public const int SWP_NOREPOSITION = 0x0200;

        [NativeTypeName("#define SWP_DEFERERASE 0x2000")]
        public const int SWP_DEFERERASE = 0x2000;

        [NativeTypeName("#define SWP_ASYNCWINDOWPOS 0x4000")]
        public const int SWP_ASYNCWINDOWPOS = 0x4000;

        [NativeTypeName("#define HWND_TOP ((HWND)0)")]
        public static readonly IntPtr HWND_TOP = ((IntPtr)(0));

        [NativeTypeName("#define HWND_BOTTOM ((HWND)1)")]
        public static readonly IntPtr HWND_BOTTOM = ((IntPtr)(1));

        [NativeTypeName("#define HWND_TOPMOST ((HWND)-1)")]
        public static readonly IntPtr HWND_TOPMOST = ((IntPtr)(-1));

        [NativeTypeName("#define HWND_NOTOPMOST ((HWND)-2)")]
        public static readonly IntPtr HWND_NOTOPMOST = ((IntPtr)(-2));

        [NativeTypeName("#define CreateDialogParam CreateDialogParamW")]
        public static readonly delegate*<IntPtr, ushort*, IntPtr, delegate* unmanaged<IntPtr, uint, nuint, nint, nint>, nint, IntPtr> CreateDialogParam = &CreateDialogParamW;

        [NativeTypeName("#define CreateDialogIndirectParam CreateDialogIndirectParamW")]
        public static readonly delegate*<IntPtr, DLGTEMPLATE*, IntPtr, delegate* unmanaged<IntPtr, uint, nuint, nint, nint>, nint, IntPtr> CreateDialogIndirectParam = &CreateDialogIndirectParamW;

        [NativeTypeName("#define DialogBoxParam DialogBoxParamW")]
        public static readonly delegate*<IntPtr, ushort*, IntPtr, delegate* unmanaged<IntPtr, uint, nuint, nint, nint>, nint, nint> DialogBoxParam = &DialogBoxParamW;

        [NativeTypeName("#define DialogBoxIndirectParam DialogBoxIndirectParamW")]
        public static readonly delegate*<IntPtr, DLGTEMPLATE*, IntPtr, delegate* unmanaged<IntPtr, uint, nuint, nint, nint>, nint, nint> DialogBoxIndirectParam = &DialogBoxIndirectParamW;

        [NativeTypeName("#define SetDlgItemText SetDlgItemTextW")]
        public static readonly delegate*<IntPtr, int, ushort*, int> SetDlgItemText = &SetDlgItemTextW;

        [NativeTypeName("#define GetDlgItemText GetDlgItemTextW")]
        public static readonly delegate*<IntPtr, int, ushort*, int, uint> GetDlgItemText = &GetDlgItemTextW;

        [NativeTypeName("#define SendDlgItemMessage SendDlgItemMessageW")]
        public static readonly delegate*<IntPtr, int, uint, nuint, nint, nint> SendDlgItemMessage = &SendDlgItemMessageW;

        [NativeTypeName("#define DefDlgProc DefDlgProcW")]
        public static readonly delegate*<IntPtr, uint, nuint, nint, nint> DefDlgProc = &DefDlgProcW;

        [NativeTypeName("#define DLGWINDOWEXTRA 30")]
        public const int DLGWINDOWEXTRA = 30;

        [NativeTypeName("#define CallMsgFilter CallMsgFilterW")]
        public static readonly delegate*<MSG*, int, int> CallMsgFilter = &CallMsgFilterW;

        [NativeTypeName("#define RegisterClipboardFormat RegisterClipboardFormatW")]
        public static readonly delegate*<ushort*, uint> RegisterClipboardFormat = &RegisterClipboardFormatW;

        [NativeTypeName("#define GetClipboardFormatName GetClipboardFormatNameW")]
        public static readonly delegate*<uint, ushort*, int, int> GetClipboardFormatName = &GetClipboardFormatNameW;

        [NativeTypeName("#define CharToOem CharToOemW")]
        public static readonly delegate*<ushort*, sbyte*, int> CharToOem = &CharToOemW;

        [NativeTypeName("#define OemToChar OemToCharW")]
        public static readonly delegate*<sbyte*, ushort*, int> OemToChar = &OemToCharW;

        [NativeTypeName("#define CharToOemBuff CharToOemBuffW")]
        public static readonly delegate*<ushort*, sbyte*, uint, int> CharToOemBuff = &CharToOemBuffW;

        [NativeTypeName("#define OemToCharBuff OemToCharBuffW")]
        public static readonly delegate*<sbyte*, ushort*, uint, int> OemToCharBuff = &OemToCharBuffW;

        [NativeTypeName("#define CharUpper CharUpperW")]
        public static readonly delegate*<ushort*, ushort*> CharUpper = &CharUpperW;

        [NativeTypeName("#define CharUpperBuff CharUpperBuffW")]
        public static readonly delegate*<ushort*, uint, uint> CharUpperBuff = &CharUpperBuffW;

        [NativeTypeName("#define CharLower CharLowerW")]
        public static readonly delegate*<ushort*, ushort*> CharLower = &CharLowerW;

        [NativeTypeName("#define CharLowerBuff CharLowerBuffW")]
        public static readonly delegate*<ushort*, uint, uint> CharLowerBuff = &CharLowerBuffW;

        [NativeTypeName("#define CharNext CharNextW")]
        public static readonly delegate*<ushort*, ushort*> CharNext = &CharNextW;

        [NativeTypeName("#define CharPrev CharPrevW")]
        public static readonly delegate*<ushort*, ushort*, ushort*> CharPrev = &CharPrevW;

        [NativeTypeName("#define AnsiToOem CharToOemA")]
        public static readonly delegate*<sbyte*, sbyte*, int> AnsiToOem = &CharToOemA;

        [NativeTypeName("#define OemToAnsi OemToCharA")]
        public static readonly delegate*<sbyte*, sbyte*, int> OemToAnsi = &OemToCharA;

        [NativeTypeName("#define AnsiToOemBuff CharToOemBuffA")]
        public static readonly delegate*<sbyte*, sbyte*, uint, int> AnsiToOemBuff = &CharToOemBuffA;

        [NativeTypeName("#define OemToAnsiBuff OemToCharBuffA")]
        public static readonly delegate*<sbyte*, sbyte*, uint, int> OemToAnsiBuff = &OemToCharBuffA;

        [NativeTypeName("#define AnsiUpper CharUpperA")]
        public static readonly delegate*<sbyte*, sbyte*> AnsiUpper = &CharUpperA;

        [NativeTypeName("#define AnsiUpperBuff CharUpperBuffA")]
        public static readonly delegate*<sbyte*, uint, uint> AnsiUpperBuff = &CharUpperBuffA;

        [NativeTypeName("#define AnsiLower CharLowerA")]
        public static readonly delegate*<sbyte*, sbyte*> AnsiLower = &CharLowerA;

        [NativeTypeName("#define AnsiLowerBuff CharLowerBuffA")]
        public static readonly delegate*<sbyte*, uint, uint> AnsiLowerBuff = &CharLowerBuffA;

        [NativeTypeName("#define AnsiNext CharNextA")]
        public static readonly delegate*<sbyte*, sbyte*> AnsiNext = &CharNextA;

        [NativeTypeName("#define AnsiPrev CharPrevA")]
        public static readonly delegate*<sbyte*, sbyte*, sbyte*> AnsiPrev = &CharPrevA;

        [NativeTypeName("#define IsCharAlpha IsCharAlphaW")]
        public static readonly delegate*<ushort, int> IsCharAlpha = &IsCharAlphaW;

        [NativeTypeName("#define IsCharAlphaNumeric IsCharAlphaNumericW")]
        public static readonly delegate*<ushort, int> IsCharAlphaNumeric = &IsCharAlphaNumericW;

        [NativeTypeName("#define IsCharUpper IsCharUpperW")]
        public static readonly delegate*<ushort, int> IsCharUpper = &IsCharUpperW;

        [NativeTypeName("#define IsCharLower IsCharLowerW")]
        public static readonly delegate*<ushort, int> IsCharLower = &IsCharLowerW;

        [NativeTypeName("#define GetKeyNameText GetKeyNameTextW")]
        public static readonly delegate*<int, ushort*, int, int> GetKeyNameText = &GetKeyNameTextW;

        [NativeTypeName("#define VkKeyScan VkKeyScanW")]
        public static readonly delegate*<ushort, short> VkKeyScan = &VkKeyScanW;

        [NativeTypeName("#define VkKeyScanEx VkKeyScanExW")]
        public static readonly delegate*<ushort, IntPtr, short> VkKeyScanEx = &VkKeyScanExW;

        [NativeTypeName("#define KEYEVENTF_EXTENDEDKEY 0x0001")]
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001;

        [NativeTypeName("#define KEYEVENTF_KEYUP 0x0002")]
        public const int KEYEVENTF_KEYUP = 0x0002;

        [NativeTypeName("#define KEYEVENTF_UNICODE 0x0004")]
        public const int KEYEVENTF_UNICODE = 0x0004;

        [NativeTypeName("#define KEYEVENTF_SCANCODE 0x0008")]
        public const int KEYEVENTF_SCANCODE = 0x0008;

        [NativeTypeName("#define MOUSEEVENTF_MOVE 0x0001")]
        public const int MOUSEEVENTF_MOVE = 0x0001;

        [NativeTypeName("#define MOUSEEVENTF_LEFTDOWN 0x0002")]
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;

        [NativeTypeName("#define MOUSEEVENTF_LEFTUP 0x0004")]
        public const int MOUSEEVENTF_LEFTUP = 0x0004;

        [NativeTypeName("#define MOUSEEVENTF_RIGHTDOWN 0x0008")]
        public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;

        [NativeTypeName("#define MOUSEEVENTF_RIGHTUP 0x0010")]
        public const int MOUSEEVENTF_RIGHTUP = 0x0010;

        [NativeTypeName("#define MOUSEEVENTF_MIDDLEDOWN 0x0020")]
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;

        [NativeTypeName("#define MOUSEEVENTF_MIDDLEUP 0x0040")]
        public const int MOUSEEVENTF_MIDDLEUP = 0x0040;

        [NativeTypeName("#define MOUSEEVENTF_XDOWN 0x0080")]
        public const int MOUSEEVENTF_XDOWN = 0x0080;

        [NativeTypeName("#define MOUSEEVENTF_XUP 0x0100")]
        public const int MOUSEEVENTF_XUP = 0x0100;

        [NativeTypeName("#define MOUSEEVENTF_WHEEL 0x0800")]
        public const int MOUSEEVENTF_WHEEL = 0x0800;

        [NativeTypeName("#define MOUSEEVENTF_HWHEEL 0x01000")]
        public const int MOUSEEVENTF_HWHEEL = 0x01000;

        [NativeTypeName("#define MOUSEEVENTF_MOVE_NOCOALESCE 0x2000")]
        public const int MOUSEEVENTF_MOVE_NOCOALESCE = 0x2000;

        [NativeTypeName("#define MOUSEEVENTF_VIRTUALDESK 0x4000")]
        public const int MOUSEEVENTF_VIRTUALDESK = 0x4000;

        [NativeTypeName("#define MOUSEEVENTF_ABSOLUTE 0x8000")]
        public const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        [NativeTypeName("#define INPUT_MOUSE 0")]
        public const int INPUT_MOUSE = 0;

        [NativeTypeName("#define INPUT_KEYBOARD 1")]
        public const int INPUT_KEYBOARD = 1;

        [NativeTypeName("#define INPUT_HARDWARE 2")]
        public const int INPUT_HARDWARE = 2;

        [NativeTypeName("#define TOUCHEVENTF_MOVE 0x0001")]
        public const int TOUCHEVENTF_MOVE = 0x0001;

        [NativeTypeName("#define TOUCHEVENTF_DOWN 0x0002")]
        public const int TOUCHEVENTF_DOWN = 0x0002;

        [NativeTypeName("#define TOUCHEVENTF_UP 0x0004")]
        public const int TOUCHEVENTF_UP = 0x0004;

        [NativeTypeName("#define TOUCHEVENTF_INRANGE 0x0008")]
        public const int TOUCHEVENTF_INRANGE = 0x0008;

        [NativeTypeName("#define TOUCHEVENTF_PRIMARY 0x0010")]
        public const int TOUCHEVENTF_PRIMARY = 0x0010;

        [NativeTypeName("#define TOUCHEVENTF_NOCOALESCE 0x0020")]
        public const int TOUCHEVENTF_NOCOALESCE = 0x0020;

        [NativeTypeName("#define TOUCHEVENTF_PEN 0x0040")]
        public const int TOUCHEVENTF_PEN = 0x0040;

        [NativeTypeName("#define TOUCHEVENTF_PALM 0x0080")]
        public const int TOUCHEVENTF_PALM = 0x0080;

        [NativeTypeName("#define TOUCHINPUTMASKF_TIMEFROMSYSTEM 0x0001")]
        public const int TOUCHINPUTMASKF_TIMEFROMSYSTEM = 0x0001;

        [NativeTypeName("#define TOUCHINPUTMASKF_EXTRAINFO 0x0002")]
        public const int TOUCHINPUTMASKF_EXTRAINFO = 0x0002;

        [NativeTypeName("#define TOUCHINPUTMASKF_CONTACTAREA 0x0004")]
        public const int TOUCHINPUTMASKF_CONTACTAREA = 0x0004;

        [NativeTypeName("#define TWF_FINETOUCH (0x00000001)")]
        public const int TWF_FINETOUCH = (0x00000001);

        [NativeTypeName("#define TWF_WANTPALM (0x00000002)")]
        public const int TWF_WANTPALM = (0x00000002);

        [NativeTypeName("#define POINTER_FLAG_NONE 0x00000000")]
        public const int POINTER_FLAG_NONE = 0x00000000;

        [NativeTypeName("#define POINTER_FLAG_NEW 0x00000001")]
        public const int POINTER_FLAG_NEW = 0x00000001;

        [NativeTypeName("#define POINTER_FLAG_INRANGE 0x00000002")]
        public const int POINTER_FLAG_INRANGE = 0x00000002;

        [NativeTypeName("#define POINTER_FLAG_INCONTACT 0x00000004")]
        public const int POINTER_FLAG_INCONTACT = 0x00000004;

        [NativeTypeName("#define POINTER_FLAG_FIRSTBUTTON 0x00000010")]
        public const int POINTER_FLAG_FIRSTBUTTON = 0x00000010;

        [NativeTypeName("#define POINTER_FLAG_SECONDBUTTON 0x00000020")]
        public const int POINTER_FLAG_SECONDBUTTON = 0x00000020;

        [NativeTypeName("#define POINTER_FLAG_THIRDBUTTON 0x00000040")]
        public const int POINTER_FLAG_THIRDBUTTON = 0x00000040;

        [NativeTypeName("#define POINTER_FLAG_FOURTHBUTTON 0x00000080")]
        public const int POINTER_FLAG_FOURTHBUTTON = 0x00000080;

        [NativeTypeName("#define POINTER_FLAG_FIFTHBUTTON 0x00000100")]
        public const int POINTER_FLAG_FIFTHBUTTON = 0x00000100;

        [NativeTypeName("#define POINTER_FLAG_PRIMARY 0x00002000")]
        public const int POINTER_FLAG_PRIMARY = 0x00002000;

        [NativeTypeName("#define POINTER_FLAG_CONFIDENCE 0x00004000")]
        public const int POINTER_FLAG_CONFIDENCE = 0x00004000;

        [NativeTypeName("#define POINTER_FLAG_CANCELED 0x00008000")]
        public const int POINTER_FLAG_CANCELED = 0x00008000;

        [NativeTypeName("#define POINTER_FLAG_DOWN 0x00010000")]
        public const int POINTER_FLAG_DOWN = 0x00010000;

        [NativeTypeName("#define POINTER_FLAG_UPDATE 0x00020000")]
        public const int POINTER_FLAG_UPDATE = 0x00020000;

        [NativeTypeName("#define POINTER_FLAG_UP 0x00040000")]
        public const int POINTER_FLAG_UP = 0x00040000;

        [NativeTypeName("#define POINTER_FLAG_WHEEL 0x00080000")]
        public const int POINTER_FLAG_WHEEL = 0x00080000;

        [NativeTypeName("#define POINTER_FLAG_HWHEEL 0x00100000")]
        public const int POINTER_FLAG_HWHEEL = 0x00100000;

        [NativeTypeName("#define POINTER_FLAG_CAPTURECHANGED 0x00200000")]
        public const int POINTER_FLAG_CAPTURECHANGED = 0x00200000;

        [NativeTypeName("#define POINTER_FLAG_HASTRANSFORM 0x00400000")]
        public const int POINTER_FLAG_HASTRANSFORM = 0x00400000;

        [NativeTypeName("#define POINTER_MOD_SHIFT (0x0004)")]
        public const int POINTER_MOD_SHIFT = (0x0004);

        [NativeTypeName("#define POINTER_MOD_CTRL (0x0008)")]
        public const int POINTER_MOD_CTRL = (0x0008);

        [NativeTypeName("#define TOUCH_FLAG_NONE 0x00000000")]
        public const int TOUCH_FLAG_NONE = 0x00000000;

        [NativeTypeName("#define TOUCH_MASK_NONE 0x00000000")]
        public const int TOUCH_MASK_NONE = 0x00000000;

        [NativeTypeName("#define TOUCH_MASK_CONTACTAREA 0x00000001")]
        public const int TOUCH_MASK_CONTACTAREA = 0x00000001;

        [NativeTypeName("#define TOUCH_MASK_ORIENTATION 0x00000002")]
        public const int TOUCH_MASK_ORIENTATION = 0x00000002;

        [NativeTypeName("#define TOUCH_MASK_PRESSURE 0x00000004")]
        public const int TOUCH_MASK_PRESSURE = 0x00000004;

        [NativeTypeName("#define PEN_FLAG_NONE 0x00000000")]
        public const int PEN_FLAG_NONE = 0x00000000;

        [NativeTypeName("#define PEN_FLAG_BARREL 0x00000001")]
        public const int PEN_FLAG_BARREL = 0x00000001;

        [NativeTypeName("#define PEN_FLAG_INVERTED 0x00000002")]
        public const int PEN_FLAG_INVERTED = 0x00000002;

        [NativeTypeName("#define PEN_FLAG_ERASER 0x00000004")]
        public const int PEN_FLAG_ERASER = 0x00000004;

        [NativeTypeName("#define PEN_MASK_NONE 0x00000000")]
        public const int PEN_MASK_NONE = 0x00000000;

        [NativeTypeName("#define PEN_MASK_PRESSURE 0x00000001")]
        public const int PEN_MASK_PRESSURE = 0x00000001;

        [NativeTypeName("#define PEN_MASK_ROTATION 0x00000002")]
        public const int PEN_MASK_ROTATION = 0x00000002;

        [NativeTypeName("#define PEN_MASK_TILT_X 0x00000004")]
        public const int PEN_MASK_TILT_X = 0x00000004;

        [NativeTypeName("#define PEN_MASK_TILT_Y 0x00000008")]
        public const int PEN_MASK_TILT_Y = 0x00000008;

        [NativeTypeName("#define POINTER_MESSAGE_FLAG_NEW 0x00000001")]
        public const int POINTER_MESSAGE_FLAG_NEW = 0x00000001;

        [NativeTypeName("#define POINTER_MESSAGE_FLAG_INRANGE 0x00000002")]
        public const int POINTER_MESSAGE_FLAG_INRANGE = 0x00000002;

        [NativeTypeName("#define POINTER_MESSAGE_FLAG_INCONTACT 0x00000004")]
        public const int POINTER_MESSAGE_FLAG_INCONTACT = 0x00000004;

        [NativeTypeName("#define POINTER_MESSAGE_FLAG_FIRSTBUTTON 0x00000010")]
        public const int POINTER_MESSAGE_FLAG_FIRSTBUTTON = 0x00000010;

        [NativeTypeName("#define POINTER_MESSAGE_FLAG_SECONDBUTTON 0x00000020")]
        public const int POINTER_MESSAGE_FLAG_SECONDBUTTON = 0x00000020;

        [NativeTypeName("#define POINTER_MESSAGE_FLAG_THIRDBUTTON 0x00000040")]
        public const int POINTER_MESSAGE_FLAG_THIRDBUTTON = 0x00000040;

        [NativeTypeName("#define POINTER_MESSAGE_FLAG_FOURTHBUTTON 0x00000080")]
        public const int POINTER_MESSAGE_FLAG_FOURTHBUTTON = 0x00000080;

        [NativeTypeName("#define POINTER_MESSAGE_FLAG_FIFTHBUTTON 0x00000100")]
        public const int POINTER_MESSAGE_FLAG_FIFTHBUTTON = 0x00000100;

        [NativeTypeName("#define POINTER_MESSAGE_FLAG_PRIMARY 0x00002000")]
        public const int POINTER_MESSAGE_FLAG_PRIMARY = 0x00002000;

        [NativeTypeName("#define POINTER_MESSAGE_FLAG_CONFIDENCE 0x00004000")]
        public const int POINTER_MESSAGE_FLAG_CONFIDENCE = 0x00004000;

        [NativeTypeName("#define POINTER_MESSAGE_FLAG_CANCELED 0x00008000")]
        public const int POINTER_MESSAGE_FLAG_CANCELED = 0x00008000;

        [NativeTypeName("#define PA_ACTIVATE MA_ACTIVATE")]
        public const int PA_ACTIVATE = 1;

        [NativeTypeName("#define PA_NOACTIVATE MA_NOACTIVATE")]
        public const int PA_NOACTIVATE = 3;

        [NativeTypeName("#define MAX_TOUCH_COUNT 256")]
        public const int MAX_TOUCH_COUNT = 256;

        [NativeTypeName("#define TOUCH_FEEDBACK_DEFAULT 0x1")]
        public const int TOUCH_FEEDBACK_DEFAULT = 0x1;

        [NativeTypeName("#define TOUCH_FEEDBACK_INDIRECT 0x2")]
        public const int TOUCH_FEEDBACK_INDIRECT = 0x2;

        [NativeTypeName("#define TOUCH_FEEDBACK_NONE 0x3")]
        public const int TOUCH_FEEDBACK_NONE = 0x3;

        [NativeTypeName("#define TOUCH_HIT_TESTING_DEFAULT 0x0")]
        public const int TOUCH_HIT_TESTING_DEFAULT = 0x0;

        [NativeTypeName("#define TOUCH_HIT_TESTING_CLIENT 0x1")]
        public const int TOUCH_HIT_TESTING_CLIENT = 0x1;

        [NativeTypeName("#define TOUCH_HIT_TESTING_NONE 0x2")]
        public const int TOUCH_HIT_TESTING_NONE = 0x2;

        [NativeTypeName("#define TOUCH_HIT_TESTING_PROXIMITY_CLOSEST 0x0")]
        public const int TOUCH_HIT_TESTING_PROXIMITY_CLOSEST = 0x0;

        [NativeTypeName("#define TOUCH_HIT_TESTING_PROXIMITY_FARTHEST 0xFFF")]
        public const int TOUCH_HIT_TESTING_PROXIMITY_FARTHEST = 0xFFF;

        [NativeTypeName("#define GWFS_INCLUDE_ANCESTORS 0x00000001")]
        public const int GWFS_INCLUDE_ANCESTORS = 0x00000001;

        [NativeTypeName("#define MapVirtualKey MapVirtualKeyW")]
        public static readonly delegate*<uint, uint, uint> MapVirtualKey = &MapVirtualKeyW;

        [NativeTypeName("#define MapVirtualKeyEx MapVirtualKeyExW")]
        public static readonly delegate*<uint, uint, IntPtr, uint> MapVirtualKeyEx = &MapVirtualKeyExW;

        [NativeTypeName("#define MAPVK_VK_TO_VSC (0)")]
        public const int MAPVK_VK_TO_VSC = (0);

        [NativeTypeName("#define MAPVK_VSC_TO_VK (1)")]
        public const int MAPVK_VSC_TO_VK = (1);

        [NativeTypeName("#define MAPVK_VK_TO_CHAR (2)")]
        public const int MAPVK_VK_TO_CHAR = (2);

        [NativeTypeName("#define MAPVK_VSC_TO_VK_EX (3)")]
        public const int MAPVK_VSC_TO_VK_EX = (3);

        [NativeTypeName("#define MAPVK_VK_TO_VSC_EX (4)")]
        public const int MAPVK_VK_TO_VSC_EX = (4);

        [NativeTypeName("#define MWMO_WAITALL 0x0001")]
        public const int MWMO_WAITALL = 0x0001;

        [NativeTypeName("#define MWMO_ALERTABLE 0x0002")]
        public const int MWMO_ALERTABLE = 0x0002;

        [NativeTypeName("#define MWMO_INPUTAVAILABLE 0x0004")]
        public const int MWMO_INPUTAVAILABLE = 0x0004;

        [NativeTypeName("#define QS_KEY 0x0001")]
        public const int QS_KEY = 0x0001;

        [NativeTypeName("#define QS_MOUSEMOVE 0x0002")]
        public const int QS_MOUSEMOVE = 0x0002;

        [NativeTypeName("#define QS_MOUSEBUTTON 0x0004")]
        public const int QS_MOUSEBUTTON = 0x0004;

        [NativeTypeName("#define QS_POSTMESSAGE 0x0008")]
        public const int QS_POSTMESSAGE = 0x0008;

        [NativeTypeName("#define QS_TIMER 0x0010")]
        public const int QS_TIMER = 0x0010;

        [NativeTypeName("#define QS_PAINT 0x0020")]
        public const int QS_PAINT = 0x0020;

        [NativeTypeName("#define QS_SENDMESSAGE 0x0040")]
        public const int QS_SENDMESSAGE = 0x0040;

        [NativeTypeName("#define QS_HOTKEY 0x0080")]
        public const int QS_HOTKEY = 0x0080;

        [NativeTypeName("#define QS_ALLPOSTMESSAGE 0x0100")]
        public const int QS_ALLPOSTMESSAGE = 0x0100;

        [NativeTypeName("#define QS_RAWINPUT 0x0400")]
        public const int QS_RAWINPUT = 0x0400;

        [NativeTypeName("#define QS_TOUCH 0x0800")]
        public const int QS_TOUCH = 0x0800;

        [NativeTypeName("#define QS_POINTER 0x1000")]
        public const int QS_POINTER = 0x1000;

        [NativeTypeName("#define QS_MOUSE (QS_MOUSEMOVE     | \\\r\n                            QS_MOUSEBUTTON)")]
        public const int QS_MOUSE = (0x0002 | 0x0004);

        [NativeTypeName("#define QS_INPUT (QS_MOUSE         | \\\r\n                            QS_KEY           | \\\r\n                            QS_RAWINPUT      | \\\r\n                            QS_TOUCH         | \\\r\n                            QS_POINTER)")]
        public const int QS_INPUT = ((0x0002 | 0x0004) | 0x0001 | 0x0400 | 0x0800 | 0x1000);

        [NativeTypeName("#define QS_ALLEVENTS (QS_INPUT         | \\\r\n                            QS_POSTMESSAGE   | \\\r\n                            QS_TIMER         | \\\r\n                            QS_PAINT         | \\\r\n                            QS_HOTKEY)")]
        public const int QS_ALLEVENTS = (((0x0002 | 0x0004) | 0x0001 | 0x0400 | 0x0800 | 0x1000) | 0x0008 | 0x0010 | 0x0020 | 0x0080);

        [NativeTypeName("#define QS_ALLINPUT (QS_INPUT         | \\\r\n                            QS_POSTMESSAGE   | \\\r\n                            QS_TIMER         | \\\r\n                            QS_PAINT         | \\\r\n                            QS_HOTKEY        | \\\r\n                            QS_SENDMESSAGE)")]
        public const int QS_ALLINPUT = (((0x0002 | 0x0004) | 0x0001 | 0x0400 | 0x0800 | 0x1000) | 0x0008 | 0x0010 | 0x0020 | 0x0080 | 0x0040);

        [NativeTypeName("#define USER_TIMER_MAXIMUM 0x7FFFFFFF")]
        public const int USER_TIMER_MAXIMUM = 0x7FFFFFFF;

        [NativeTypeName("#define USER_TIMER_MINIMUM 0x0000000A")]
        public const int USER_TIMER_MINIMUM = 0x0000000A;

        [NativeTypeName("#define TIMERV_DEFAULT_COALESCING (0)")]
        public const int TIMERV_DEFAULT_COALESCING = (0);

        [NativeTypeName("#define TIMERV_NO_COALESCING (0xFFFFFFFF)")]
        public const uint TIMERV_NO_COALESCING = (0xFFFFFFFF);

        [NativeTypeName("#define TIMERV_COALESCING_MIN (1)")]
        public const int TIMERV_COALESCING_MIN = (1);

        [NativeTypeName("#define TIMERV_COALESCING_MAX (0x7FFFFFF5)")]
        public const int TIMERV_COALESCING_MAX = (0x7FFFFFF5);

        [NativeTypeName("#define LoadAccelerators LoadAcceleratorsW")]
        public static readonly delegate*<IntPtr, ushort*, IntPtr> LoadAccelerators = &LoadAcceleratorsW;

        [NativeTypeName("#define CreateAcceleratorTable CreateAcceleratorTableW")]
        public static readonly delegate*<ACCEL*, int, IntPtr> CreateAcceleratorTable = &CreateAcceleratorTableW;

        [NativeTypeName("#define CopyAcceleratorTable CopyAcceleratorTableW")]
        public static readonly delegate*<IntPtr, ACCEL*, int, int> CopyAcceleratorTable = &CopyAcceleratorTableW;

        [NativeTypeName("#define TranslateAccelerator TranslateAcceleratorW")]
        public static readonly delegate*<IntPtr, IntPtr, MSG*, int> TranslateAccelerator = &TranslateAcceleratorW;

        [NativeTypeName("#define SM_CXSCREEN 0")]
        public const int SM_CXSCREEN = 0;

        [NativeTypeName("#define SM_CYSCREEN 1")]
        public const int SM_CYSCREEN = 1;

        [NativeTypeName("#define SM_CXVSCROLL 2")]
        public const int SM_CXVSCROLL = 2;

        [NativeTypeName("#define SM_CYHSCROLL 3")]
        public const int SM_CYHSCROLL = 3;

        [NativeTypeName("#define SM_CYCAPTION 4")]
        public const int SM_CYCAPTION = 4;

        [NativeTypeName("#define SM_CXBORDER 5")]
        public const int SM_CXBORDER = 5;

        [NativeTypeName("#define SM_CYBORDER 6")]
        public const int SM_CYBORDER = 6;

        [NativeTypeName("#define SM_CXDLGFRAME 7")]
        public const int SM_CXDLGFRAME = 7;

        [NativeTypeName("#define SM_CYDLGFRAME 8")]
        public const int SM_CYDLGFRAME = 8;

        [NativeTypeName("#define SM_CYVTHUMB 9")]
        public const int SM_CYVTHUMB = 9;

        [NativeTypeName("#define SM_CXHTHUMB 10")]
        public const int SM_CXHTHUMB = 10;

        [NativeTypeName("#define SM_CXICON 11")]
        public const int SM_CXICON = 11;

        [NativeTypeName("#define SM_CYICON 12")]
        public const int SM_CYICON = 12;

        [NativeTypeName("#define SM_CXCURSOR 13")]
        public const int SM_CXCURSOR = 13;

        [NativeTypeName("#define SM_CYCURSOR 14")]
        public const int SM_CYCURSOR = 14;

        [NativeTypeName("#define SM_CYMENU 15")]
        public const int SM_CYMENU = 15;

        [NativeTypeName("#define SM_CXFULLSCREEN 16")]
        public const int SM_CXFULLSCREEN = 16;

        [NativeTypeName("#define SM_CYFULLSCREEN 17")]
        public const int SM_CYFULLSCREEN = 17;

        [NativeTypeName("#define SM_CYKANJIWINDOW 18")]
        public const int SM_CYKANJIWINDOW = 18;

        [NativeTypeName("#define SM_MOUSEPRESENT 19")]
        public const int SM_MOUSEPRESENT = 19;

        [NativeTypeName("#define SM_CYVSCROLL 20")]
        public const int SM_CYVSCROLL = 20;

        [NativeTypeName("#define SM_CXHSCROLL 21")]
        public const int SM_CXHSCROLL = 21;

        [NativeTypeName("#define SM_DEBUG 22")]
        public const int SM_DEBUG = 22;

        [NativeTypeName("#define SM_SWAPBUTTON 23")]
        public const int SM_SWAPBUTTON = 23;

        [NativeTypeName("#define SM_RESERVED1 24")]
        public const int SM_RESERVED1 = 24;

        [NativeTypeName("#define SM_RESERVED2 25")]
        public const int SM_RESERVED2 = 25;

        [NativeTypeName("#define SM_RESERVED3 26")]
        public const int SM_RESERVED3 = 26;

        [NativeTypeName("#define SM_RESERVED4 27")]
        public const int SM_RESERVED4 = 27;

        [NativeTypeName("#define SM_CXMIN 28")]
        public const int SM_CXMIN = 28;

        [NativeTypeName("#define SM_CYMIN 29")]
        public const int SM_CYMIN = 29;

        [NativeTypeName("#define SM_CXSIZE 30")]
        public const int SM_CXSIZE = 30;

        [NativeTypeName("#define SM_CYSIZE 31")]
        public const int SM_CYSIZE = 31;

        [NativeTypeName("#define SM_CXFRAME 32")]
        public const int SM_CXFRAME = 32;

        [NativeTypeName("#define SM_CYFRAME 33")]
        public const int SM_CYFRAME = 33;

        [NativeTypeName("#define SM_CXMINTRACK 34")]
        public const int SM_CXMINTRACK = 34;

        [NativeTypeName("#define SM_CYMINTRACK 35")]
        public const int SM_CYMINTRACK = 35;

        [NativeTypeName("#define SM_CXDOUBLECLK 36")]
        public const int SM_CXDOUBLECLK = 36;

        [NativeTypeName("#define SM_CYDOUBLECLK 37")]
        public const int SM_CYDOUBLECLK = 37;

        [NativeTypeName("#define SM_CXICONSPACING 38")]
        public const int SM_CXICONSPACING = 38;

        [NativeTypeName("#define SM_CYICONSPACING 39")]
        public const int SM_CYICONSPACING = 39;

        [NativeTypeName("#define SM_MENUDROPALIGNMENT 40")]
        public const int SM_MENUDROPALIGNMENT = 40;

        [NativeTypeName("#define SM_PENWINDOWS 41")]
        public const int SM_PENWINDOWS = 41;

        [NativeTypeName("#define SM_DBCSENABLED 42")]
        public const int SM_DBCSENABLED = 42;

        [NativeTypeName("#define SM_CMOUSEBUTTONS 43")]
        public const int SM_CMOUSEBUTTONS = 43;

        [NativeTypeName("#define SM_CXFIXEDFRAME SM_CXDLGFRAME")]
        public const int SM_CXFIXEDFRAME = 7;

        [NativeTypeName("#define SM_CYFIXEDFRAME SM_CYDLGFRAME")]
        public const int SM_CYFIXEDFRAME = 8;

        [NativeTypeName("#define SM_CXSIZEFRAME SM_CXFRAME")]
        public const int SM_CXSIZEFRAME = 32;

        [NativeTypeName("#define SM_CYSIZEFRAME SM_CYFRAME")]
        public const int SM_CYSIZEFRAME = 33;

        [NativeTypeName("#define SM_SECURE 44")]
        public const int SM_SECURE = 44;

        [NativeTypeName("#define SM_CXEDGE 45")]
        public const int SM_CXEDGE = 45;

        [NativeTypeName("#define SM_CYEDGE 46")]
        public const int SM_CYEDGE = 46;

        [NativeTypeName("#define SM_CXMINSPACING 47")]
        public const int SM_CXMINSPACING = 47;

        [NativeTypeName("#define SM_CYMINSPACING 48")]
        public const int SM_CYMINSPACING = 48;

        [NativeTypeName("#define SM_CXSMICON 49")]
        public const int SM_CXSMICON = 49;

        [NativeTypeName("#define SM_CYSMICON 50")]
        public const int SM_CYSMICON = 50;

        [NativeTypeName("#define SM_CYSMCAPTION 51")]
        public const int SM_CYSMCAPTION = 51;

        [NativeTypeName("#define SM_CXSMSIZE 52")]
        public const int SM_CXSMSIZE = 52;

        [NativeTypeName("#define SM_CYSMSIZE 53")]
        public const int SM_CYSMSIZE = 53;

        [NativeTypeName("#define SM_CXMENUSIZE 54")]
        public const int SM_CXMENUSIZE = 54;

        [NativeTypeName("#define SM_CYMENUSIZE 55")]
        public const int SM_CYMENUSIZE = 55;

        [NativeTypeName("#define SM_ARRANGE 56")]
        public const int SM_ARRANGE = 56;

        [NativeTypeName("#define SM_CXMINIMIZED 57")]
        public const int SM_CXMINIMIZED = 57;

        [NativeTypeName("#define SM_CYMINIMIZED 58")]
        public const int SM_CYMINIMIZED = 58;

        [NativeTypeName("#define SM_CXMAXTRACK 59")]
        public const int SM_CXMAXTRACK = 59;

        [NativeTypeName("#define SM_CYMAXTRACK 60")]
        public const int SM_CYMAXTRACK = 60;

        [NativeTypeName("#define SM_CXMAXIMIZED 61")]
        public const int SM_CXMAXIMIZED = 61;

        [NativeTypeName("#define SM_CYMAXIMIZED 62")]
        public const int SM_CYMAXIMIZED = 62;

        [NativeTypeName("#define SM_NETWORK 63")]
        public const int SM_NETWORK = 63;

        [NativeTypeName("#define SM_CLEANBOOT 67")]
        public const int SM_CLEANBOOT = 67;

        [NativeTypeName("#define SM_CXDRAG 68")]
        public const int SM_CXDRAG = 68;

        [NativeTypeName("#define SM_CYDRAG 69")]
        public const int SM_CYDRAG = 69;

        [NativeTypeName("#define SM_SHOWSOUNDS 70")]
        public const int SM_SHOWSOUNDS = 70;

        [NativeTypeName("#define SM_CXMENUCHECK 71")]
        public const int SM_CXMENUCHECK = 71;

        [NativeTypeName("#define SM_CYMENUCHECK 72")]
        public const int SM_CYMENUCHECK = 72;

        [NativeTypeName("#define SM_SLOWMACHINE 73")]
        public const int SM_SLOWMACHINE = 73;

        [NativeTypeName("#define SM_MIDEASTENABLED 74")]
        public const int SM_MIDEASTENABLED = 74;

        [NativeTypeName("#define SM_MOUSEWHEELPRESENT 75")]
        public const int SM_MOUSEWHEELPRESENT = 75;

        [NativeTypeName("#define SM_XVIRTUALSCREEN 76")]
        public const int SM_XVIRTUALSCREEN = 76;

        [NativeTypeName("#define SM_YVIRTUALSCREEN 77")]
        public const int SM_YVIRTUALSCREEN = 77;

        [NativeTypeName("#define SM_CXVIRTUALSCREEN 78")]
        public const int SM_CXVIRTUALSCREEN = 78;

        [NativeTypeName("#define SM_CYVIRTUALSCREEN 79")]
        public const int SM_CYVIRTUALSCREEN = 79;

        [NativeTypeName("#define SM_CMONITORS 80")]
        public const int SM_CMONITORS = 80;

        [NativeTypeName("#define SM_SAMEDISPLAYFORMAT 81")]
        public const int SM_SAMEDISPLAYFORMAT = 81;

        [NativeTypeName("#define SM_IMMENABLED 82")]
        public const int SM_IMMENABLED = 82;

        [NativeTypeName("#define SM_CXFOCUSBORDER 83")]
        public const int SM_CXFOCUSBORDER = 83;

        [NativeTypeName("#define SM_CYFOCUSBORDER 84")]
        public const int SM_CYFOCUSBORDER = 84;

        [NativeTypeName("#define SM_TABLETPC 86")]
        public const int SM_TABLETPC = 86;

        [NativeTypeName("#define SM_MEDIACENTER 87")]
        public const int SM_MEDIACENTER = 87;

        [NativeTypeName("#define SM_STARTER 88")]
        public const int SM_STARTER = 88;

        [NativeTypeName("#define SM_SERVERR2 89")]
        public const int SM_SERVERR2 = 89;

        [NativeTypeName("#define SM_MOUSEHORIZONTALWHEELPRESENT 91")]
        public const int SM_MOUSEHORIZONTALWHEELPRESENT = 91;

        [NativeTypeName("#define SM_CXPADDEDBORDER 92")]
        public const int SM_CXPADDEDBORDER = 92;

        [NativeTypeName("#define SM_DIGITIZER 94")]
        public const int SM_DIGITIZER = 94;

        [NativeTypeName("#define SM_MAXIMUMTOUCHES 95")]
        public const int SM_MAXIMUMTOUCHES = 95;

        [NativeTypeName("#define SM_CMETRICS 97")]
        public const int SM_CMETRICS = 97;

        [NativeTypeName("#define SM_REMOTESESSION 0x1000")]
        public const int SM_REMOTESESSION = 0x1000;

        [NativeTypeName("#define SM_SHUTTINGDOWN 0x2000")]
        public const int SM_SHUTTINGDOWN = 0x2000;

        [NativeTypeName("#define SM_REMOTECONTROL 0x2001")]
        public const int SM_REMOTECONTROL = 0x2001;

        [NativeTypeName("#define SM_CARETBLINKINGENABLED 0x2002")]
        public const int SM_CARETBLINKINGENABLED = 0x2002;

        [NativeTypeName("#define SM_CONVERTIBLESLATEMODE 0x2003")]
        public const int SM_CONVERTIBLESLATEMODE = 0x2003;

        [NativeTypeName("#define SM_SYSTEMDOCKED 0x2004")]
        public const int SM_SYSTEMDOCKED = 0x2004;

        [NativeTypeName("#define LoadMenu LoadMenuW")]
        public static readonly delegate*<IntPtr, ushort*, IntPtr> LoadMenu = &LoadMenuW;

        [NativeTypeName("#define LoadMenuIndirect LoadMenuIndirectW")]
        public static readonly delegate*<void*, IntPtr> LoadMenuIndirect = &LoadMenuIndirectW;

        [NativeTypeName("#define ChangeMenu ChangeMenuW")]
        public static readonly delegate*<IntPtr, uint, ushort*, uint, uint, int> ChangeMenu = &ChangeMenuW;

        [NativeTypeName("#define GetMenuString GetMenuStringW")]
        public static readonly delegate*<IntPtr, uint, ushort*, int, uint, int> GetMenuString = &GetMenuStringW;

        [NativeTypeName("#define PMB_ACTIVE 0x00000001")]
        public const int PMB_ACTIVE = 0x00000001;

        [NativeTypeName("#define InsertMenu InsertMenuW")]
        public static readonly delegate*<IntPtr, uint, uint, nuint, ushort*, int> InsertMenu = &InsertMenuW;

        [NativeTypeName("#define AppendMenu AppendMenuW")]
        public static readonly delegate*<IntPtr, uint, nuint, ushort*, int> AppendMenu = &AppendMenuW;

        [NativeTypeName("#define ModifyMenu ModifyMenuW")]
        public static readonly delegate*<IntPtr, uint, uint, nuint, ushort*, int> ModifyMenu = &ModifyMenuW;

        [NativeTypeName("#define MNC_IGNORE 0")]
        public const int MNC_IGNORE = 0;

        [NativeTypeName("#define MNC_CLOSE 1")]
        public const int MNC_CLOSE = 1;

        [NativeTypeName("#define MNC_EXECUTE 2")]
        public const int MNC_EXECUTE = 2;

        [NativeTypeName("#define MNC_SELECT 3")]
        public const int MNC_SELECT = 3;

        [NativeTypeName("#define MNS_NOCHECK 0x80000000")]
        public const uint MNS_NOCHECK = 0x80000000;

        [NativeTypeName("#define MNS_MODELESS 0x40000000")]
        public const int MNS_MODELESS = 0x40000000;

        [NativeTypeName("#define MNS_DRAGDROP 0x20000000")]
        public const int MNS_DRAGDROP = 0x20000000;

        [NativeTypeName("#define MNS_AUTODISMISS 0x10000000")]
        public const int MNS_AUTODISMISS = 0x10000000;

        [NativeTypeName("#define MNS_NOTIFYBYPOS 0x08000000")]
        public const int MNS_NOTIFYBYPOS = 0x08000000;

        [NativeTypeName("#define MNS_CHECKORBMP 0x04000000")]
        public const int MNS_CHECKORBMP = 0x04000000;

        [NativeTypeName("#define MIM_MAXHEIGHT 0x00000001")]
        public const int MIM_MAXHEIGHT = 0x00000001;

        [NativeTypeName("#define MIM_BACKGROUND 0x00000002")]
        public const int MIM_BACKGROUND = 0x00000002;

        [NativeTypeName("#define MIM_HELPID 0x00000004")]
        public const int MIM_HELPID = 0x00000004;

        [NativeTypeName("#define MIM_MENUDATA 0x00000008")]
        public const int MIM_MENUDATA = 0x00000008;

        [NativeTypeName("#define MIM_STYLE 0x00000010")]
        public const int MIM_STYLE = 0x00000010;

        [NativeTypeName("#define MIM_APPLYTOSUBMENUS 0x80000000")]
        public const uint MIM_APPLYTOSUBMENUS = 0x80000000;

        [NativeTypeName("#define MND_CONTINUE 0")]
        public const int MND_CONTINUE = 0;

        [NativeTypeName("#define MND_ENDMENU 1")]
        public const int MND_ENDMENU = 1;

        [NativeTypeName("#define MNGOF_TOPGAP 0x00000001")]
        public const int MNGOF_TOPGAP = 0x00000001;

        [NativeTypeName("#define MNGOF_BOTTOMGAP 0x00000002")]
        public const int MNGOF_BOTTOMGAP = 0x00000002;

        [NativeTypeName("#define MNGO_NOINTERFACE 0x00000000")]
        public const int MNGO_NOINTERFACE = 0x00000000;

        [NativeTypeName("#define MNGO_NOERROR 0x00000001")]
        public const int MNGO_NOERROR = 0x00000001;

        [NativeTypeName("#define MIIM_STATE 0x00000001")]
        public const int MIIM_STATE = 0x00000001;

        [NativeTypeName("#define MIIM_ID 0x00000002")]
        public const int MIIM_ID = 0x00000002;

        [NativeTypeName("#define MIIM_SUBMENU 0x00000004")]
        public const int MIIM_SUBMENU = 0x00000004;

        [NativeTypeName("#define MIIM_CHECKMARKS 0x00000008")]
        public const int MIIM_CHECKMARKS = 0x00000008;

        [NativeTypeName("#define MIIM_TYPE 0x00000010")]
        public const int MIIM_TYPE = 0x00000010;

        [NativeTypeName("#define MIIM_DATA 0x00000020")]
        public const int MIIM_DATA = 0x00000020;

        [NativeTypeName("#define MIIM_STRING 0x00000040")]
        public const int MIIM_STRING = 0x00000040;

        [NativeTypeName("#define MIIM_BITMAP 0x00000080")]
        public const int MIIM_BITMAP = 0x00000080;

        [NativeTypeName("#define MIIM_FTYPE 0x00000100")]
        public const int MIIM_FTYPE = 0x00000100;

        [NativeTypeName("#define HBMMENU_CALLBACK ((HBITMAP) -1)")]
        public static readonly IntPtr HBMMENU_CALLBACK = ((IntPtr)(-1));

        [NativeTypeName("#define HBMMENU_SYSTEM ((HBITMAP)  1)")]
        public static readonly IntPtr HBMMENU_SYSTEM = ((IntPtr)(1));

        [NativeTypeName("#define HBMMENU_MBAR_RESTORE ((HBITMAP)  2)")]
        public static readonly IntPtr HBMMENU_MBAR_RESTORE = ((IntPtr)(2));

        [NativeTypeName("#define HBMMENU_MBAR_MINIMIZE ((HBITMAP)  3)")]
        public static readonly IntPtr HBMMENU_MBAR_MINIMIZE = ((IntPtr)(3));

        [NativeTypeName("#define HBMMENU_MBAR_CLOSE ((HBITMAP)  5)")]
        public static readonly IntPtr HBMMENU_MBAR_CLOSE = ((IntPtr)(5));

        [NativeTypeName("#define HBMMENU_MBAR_CLOSE_D ((HBITMAP)  6)")]
        public static readonly IntPtr HBMMENU_MBAR_CLOSE_D = ((IntPtr)(6));

        [NativeTypeName("#define HBMMENU_MBAR_MINIMIZE_D ((HBITMAP)  7)")]
        public static readonly IntPtr HBMMENU_MBAR_MINIMIZE_D = ((IntPtr)(7));

        [NativeTypeName("#define HBMMENU_POPUP_CLOSE ((HBITMAP)  8)")]
        public static readonly IntPtr HBMMENU_POPUP_CLOSE = ((IntPtr)(8));

        [NativeTypeName("#define HBMMENU_POPUP_RESTORE ((HBITMAP)  9)")]
        public static readonly IntPtr HBMMENU_POPUP_RESTORE = ((IntPtr)(9));

        [NativeTypeName("#define HBMMENU_POPUP_MAXIMIZE ((HBITMAP) 10)")]
        public static readonly IntPtr HBMMENU_POPUP_MAXIMIZE = ((IntPtr)(10));

        [NativeTypeName("#define HBMMENU_POPUP_MINIMIZE ((HBITMAP) 11)")]
        public static readonly IntPtr HBMMENU_POPUP_MINIMIZE = ((IntPtr)(11));

        [NativeTypeName("#define InsertMenuItem InsertMenuItemW")]
        public static readonly delegate*<IntPtr, uint, int, MENUITEMINFOW*, int> InsertMenuItem = &InsertMenuItemW;

        [NativeTypeName("#define GetMenuItemInfo GetMenuItemInfoW")]
        public static readonly delegate*<IntPtr, uint, int, MENUITEMINFOW*, int> GetMenuItemInfo = &GetMenuItemInfoW;

        [NativeTypeName("#define SetMenuItemInfo SetMenuItemInfoW")]
        public static readonly delegate*<IntPtr, uint, int, MENUITEMINFOW*, int> SetMenuItemInfo = &SetMenuItemInfoW;

        [NativeTypeName("#define GMDI_USEDISABLED 0x0001L")]
        public const int GMDI_USEDISABLED = 0x0001;

        [NativeTypeName("#define GMDI_GOINTOPOPUPS 0x0002L")]
        public const int GMDI_GOINTOPOPUPS = 0x0002;

        [NativeTypeName("#define TPM_LEFTBUTTON 0x0000L")]
        public const int TPM_LEFTBUTTON = 0x0000;

        [NativeTypeName("#define TPM_RIGHTBUTTON 0x0002L")]
        public const int TPM_RIGHTBUTTON = 0x0002;

        [NativeTypeName("#define TPM_LEFTALIGN 0x0000L")]
        public const int TPM_LEFTALIGN = 0x0000;

        [NativeTypeName("#define TPM_CENTERALIGN 0x0004L")]
        public const int TPM_CENTERALIGN = 0x0004;

        [NativeTypeName("#define TPM_RIGHTALIGN 0x0008L")]
        public const int TPM_RIGHTALIGN = 0x0008;

        [NativeTypeName("#define TPM_TOPALIGN 0x0000L")]
        public const int TPM_TOPALIGN = 0x0000;

        [NativeTypeName("#define TPM_VCENTERALIGN 0x0010L")]
        public const int TPM_VCENTERALIGN = 0x0010;

        [NativeTypeName("#define TPM_BOTTOMALIGN 0x0020L")]
        public const int TPM_BOTTOMALIGN = 0x0020;

        [NativeTypeName("#define TPM_HORIZONTAL 0x0000L")]
        public const int TPM_HORIZONTAL = 0x0000;

        [NativeTypeName("#define TPM_VERTICAL 0x0040L")]
        public const int TPM_VERTICAL = 0x0040;

        [NativeTypeName("#define TPM_NONOTIFY 0x0080L")]
        public const int TPM_NONOTIFY = 0x0080;

        [NativeTypeName("#define TPM_RETURNCMD 0x0100L")]
        public const int TPM_RETURNCMD = 0x0100;

        [NativeTypeName("#define TPM_RECURSE 0x0001L")]
        public const int TPM_RECURSE = 0x0001;

        [NativeTypeName("#define TPM_HORPOSANIMATION 0x0400L")]
        public const int TPM_HORPOSANIMATION = 0x0400;

        [NativeTypeName("#define TPM_HORNEGANIMATION 0x0800L")]
        public const int TPM_HORNEGANIMATION = 0x0800;

        [NativeTypeName("#define TPM_VERPOSANIMATION 0x1000L")]
        public const int TPM_VERPOSANIMATION = 0x1000;

        [NativeTypeName("#define TPM_VERNEGANIMATION 0x2000L")]
        public const int TPM_VERNEGANIMATION = 0x2000;

        [NativeTypeName("#define TPM_NOANIMATION 0x4000L")]
        public const int TPM_NOANIMATION = 0x4000;

        [NativeTypeName("#define TPM_LAYOUTRTL 0x8000L")]
        public const int TPM_LAYOUTRTL = 0x8000;

        [NativeTypeName("#define TPM_WORKAREA 0x10000L")]
        public const int TPM_WORKAREA = 0x10000;

        [NativeTypeName("#define DOF_EXECUTABLE 0x8001")]
        public const int DOF_EXECUTABLE = 0x8001;

        [NativeTypeName("#define DOF_DOCUMENT 0x8002")]
        public const int DOF_DOCUMENT = 0x8002;

        [NativeTypeName("#define DOF_DIRECTORY 0x8003")]
        public const int DOF_DIRECTORY = 0x8003;

        [NativeTypeName("#define DOF_MULTIPLE 0x8004")]
        public const int DOF_MULTIPLE = 0x8004;

        [NativeTypeName("#define DOF_PROGMAN 0x0001")]
        public const int DOF_PROGMAN = 0x0001;

        [NativeTypeName("#define DOF_SHELLDATA 0x0002")]
        public const int DOF_SHELLDATA = 0x0002;

        [NativeTypeName("#define DO_DROPFILE 0x454C4946L")]
        public const int DO_DROPFILE = 0x454C4946;

        [NativeTypeName("#define DO_PRINTFILE 0x544E5250L")]
        public const int DO_PRINTFILE = 0x544E5250;

        [NativeTypeName("#define DT_TOP 0x00000000")]
        public const int DT_TOP = 0x00000000;

        [NativeTypeName("#define DT_LEFT 0x00000000")]
        public const int DT_LEFT = 0x00000000;

        [NativeTypeName("#define DT_CENTER 0x00000001")]
        public const int DT_CENTER = 0x00000001;

        [NativeTypeName("#define DT_RIGHT 0x00000002")]
        public const int DT_RIGHT = 0x00000002;

        [NativeTypeName("#define DT_VCENTER 0x00000004")]
        public const int DT_VCENTER = 0x00000004;

        [NativeTypeName("#define DT_BOTTOM 0x00000008")]
        public const int DT_BOTTOM = 0x00000008;

        [NativeTypeName("#define DT_WORDBREAK 0x00000010")]
        public const int DT_WORDBREAK = 0x00000010;

        [NativeTypeName("#define DT_SINGLELINE 0x00000020")]
        public const int DT_SINGLELINE = 0x00000020;

        [NativeTypeName("#define DT_EXPANDTABS 0x00000040")]
        public const int DT_EXPANDTABS = 0x00000040;

        [NativeTypeName("#define DT_TABSTOP 0x00000080")]
        public const int DT_TABSTOP = 0x00000080;

        [NativeTypeName("#define DT_NOCLIP 0x00000100")]
        public const int DT_NOCLIP = 0x00000100;

        [NativeTypeName("#define DT_EXTERNALLEADING 0x00000200")]
        public const int DT_EXTERNALLEADING = 0x00000200;

        [NativeTypeName("#define DT_CALCRECT 0x00000400")]
        public const int DT_CALCRECT = 0x00000400;

        [NativeTypeName("#define DT_NOPREFIX 0x00000800")]
        public const int DT_NOPREFIX = 0x00000800;

        [NativeTypeName("#define DT_INTERNAL 0x00001000")]
        public const int DT_INTERNAL = 0x00001000;

        [NativeTypeName("#define DT_EDITCONTROL 0x00002000")]
        public const int DT_EDITCONTROL = 0x00002000;

        [NativeTypeName("#define DT_PATH_ELLIPSIS 0x00004000")]
        public const int DT_PATH_ELLIPSIS = 0x00004000;

        [NativeTypeName("#define DT_END_ELLIPSIS 0x00008000")]
        public const int DT_END_ELLIPSIS = 0x00008000;

        [NativeTypeName("#define DT_MODIFYSTRING 0x00010000")]
        public const int DT_MODIFYSTRING = 0x00010000;

        [NativeTypeName("#define DT_RTLREADING 0x00020000")]
        public const int DT_RTLREADING = 0x00020000;

        [NativeTypeName("#define DT_WORD_ELLIPSIS 0x00040000")]
        public const int DT_WORD_ELLIPSIS = 0x00040000;

        [NativeTypeName("#define DT_NOFULLWIDTHCHARBREAK 0x00080000")]
        public const int DT_NOFULLWIDTHCHARBREAK = 0x00080000;

        [NativeTypeName("#define DT_HIDEPREFIX 0x00100000")]
        public const int DT_HIDEPREFIX = 0x00100000;

        [NativeTypeName("#define DT_PREFIXONLY 0x00200000")]
        public const int DT_PREFIXONLY = 0x00200000;

        [NativeTypeName("#define DrawText DrawTextW")]
        public static readonly delegate*<IntPtr, ushort*, int, RECT*, uint, int> DrawText = &DrawTextW;

        [NativeTypeName("#define DrawTextEx DrawTextExW")]
        public static readonly delegate*<IntPtr, ushort*, int, RECT*, uint, DRAWTEXTPARAMS*, int> DrawTextEx = &DrawTextExW;

        [NativeTypeName("#define GrayString GrayStringW")]
        public static readonly delegate*<IntPtr, IntPtr, delegate* unmanaged<IntPtr, nint, int, int>, nint, int, int, int, int, int, int> GrayString = &GrayStringW;

        [NativeTypeName("#define DST_COMPLEX 0x0000")]
        public const int DST_COMPLEX = 0x0000;

        [NativeTypeName("#define DST_TEXT 0x0001")]
        public const int DST_TEXT = 0x0001;

        [NativeTypeName("#define DST_PREFIXTEXT 0x0002")]
        public const int DST_PREFIXTEXT = 0x0002;

        [NativeTypeName("#define DST_ICON 0x0003")]
        public const int DST_ICON = 0x0003;

        [NativeTypeName("#define DST_BITMAP 0x0004")]
        public const int DST_BITMAP = 0x0004;

        [NativeTypeName("#define DSS_NORMAL 0x0000")]
        public const int DSS_NORMAL = 0x0000;

        [NativeTypeName("#define DSS_UNION 0x0010")]
        public const int DSS_UNION = 0x0010;

        [NativeTypeName("#define DSS_DISABLED 0x0020")]
        public const int DSS_DISABLED = 0x0020;

        [NativeTypeName("#define DSS_MONO 0x0080")]
        public const int DSS_MONO = 0x0080;

        [NativeTypeName("#define DSS_HIDEPREFIX 0x0200")]
        public const int DSS_HIDEPREFIX = 0x0200;

        [NativeTypeName("#define DSS_PREFIXONLY 0x0400")]
        public const int DSS_PREFIXONLY = 0x0400;

        [NativeTypeName("#define DSS_RIGHT 0x8000")]
        public const int DSS_RIGHT = 0x8000;

        [NativeTypeName("#define DrawState DrawStateW")]
        public static readonly delegate*<IntPtr, IntPtr, delegate* unmanaged<IntPtr, nint, nuint, int, int, int>, nint, nuint, int, int, int, int, uint, int> DrawState = &DrawStateW;

        [NativeTypeName("#define TabbedTextOut TabbedTextOutW")]
        public static readonly delegate*<IntPtr, int, int, ushort*, int, int, int*, int, int> TabbedTextOut = &TabbedTextOutW;

        [NativeTypeName("#define GetTabbedTextExtent GetTabbedTextExtentW")]
        public static readonly delegate*<IntPtr, ushort*, int, int, int*, uint> GetTabbedTextExtent = &GetTabbedTextExtentW;

        [NativeTypeName("#define ASFW_ANY ((DWORD)-1)")]
        public const uint ASFW_ANY = unchecked((uint)(-1));

        [NativeTypeName("#define LSFW_LOCK 1")]
        public const int LSFW_LOCK = 1;

        [NativeTypeName("#define LSFW_UNLOCK 2")]
        public const int LSFW_UNLOCK = 2;

        [NativeTypeName("#define DCX_WINDOW 0x00000001L")]
        public const int DCX_WINDOW = 0x00000001;

        [NativeTypeName("#define DCX_CACHE 0x00000002L")]
        public const int DCX_CACHE = 0x00000002;

        [NativeTypeName("#define DCX_NORESETATTRS 0x00000004L")]
        public const int DCX_NORESETATTRS = 0x00000004;

        [NativeTypeName("#define DCX_CLIPCHILDREN 0x00000008L")]
        public const int DCX_CLIPCHILDREN = 0x00000008;

        [NativeTypeName("#define DCX_CLIPSIBLINGS 0x00000010L")]
        public const int DCX_CLIPSIBLINGS = 0x00000010;

        [NativeTypeName("#define DCX_PARENTCLIP 0x00000020L")]
        public const int DCX_PARENTCLIP = 0x00000020;

        [NativeTypeName("#define DCX_EXCLUDERGN 0x00000040L")]
        public const int DCX_EXCLUDERGN = 0x00000040;

        [NativeTypeName("#define DCX_INTERSECTRGN 0x00000080L")]
        public const int DCX_INTERSECTRGN = 0x00000080;

        [NativeTypeName("#define DCX_EXCLUDEUPDATE 0x00000100L")]
        public const int DCX_EXCLUDEUPDATE = 0x00000100;

        [NativeTypeName("#define DCX_INTERSECTUPDATE 0x00000200L")]
        public const int DCX_INTERSECTUPDATE = 0x00000200;

        [NativeTypeName("#define DCX_LOCKWINDOWUPDATE 0x00000400L")]
        public const int DCX_LOCKWINDOWUPDATE = 0x00000400;

        [NativeTypeName("#define DCX_VALIDATE 0x00200000L")]
        public const int DCX_VALIDATE = 0x00200000;

        [NativeTypeName("#define RDW_INVALIDATE 0x0001")]
        public const int RDW_INVALIDATE = 0x0001;

        [NativeTypeName("#define RDW_INTERNALPAINT 0x0002")]
        public const int RDW_INTERNALPAINT = 0x0002;

        [NativeTypeName("#define RDW_ERASE 0x0004")]
        public const int RDW_ERASE = 0x0004;

        [NativeTypeName("#define RDW_VALIDATE 0x0008")]
        public const int RDW_VALIDATE = 0x0008;

        [NativeTypeName("#define RDW_NOINTERNALPAINT 0x0010")]
        public const int RDW_NOINTERNALPAINT = 0x0010;

        [NativeTypeName("#define RDW_NOERASE 0x0020")]
        public const int RDW_NOERASE = 0x0020;

        [NativeTypeName("#define RDW_NOCHILDREN 0x0040")]
        public const int RDW_NOCHILDREN = 0x0040;

        [NativeTypeName("#define RDW_ALLCHILDREN 0x0080")]
        public const int RDW_ALLCHILDREN = 0x0080;

        [NativeTypeName("#define RDW_UPDATENOW 0x0100")]
        public const int RDW_UPDATENOW = 0x0100;

        [NativeTypeName("#define RDW_ERASENOW 0x0200")]
        public const int RDW_ERASENOW = 0x0200;

        [NativeTypeName("#define RDW_FRAME 0x0400")]
        public const int RDW_FRAME = 0x0400;

        [NativeTypeName("#define RDW_NOFRAME 0x0800")]
        public const int RDW_NOFRAME = 0x0800;

        [NativeTypeName("#define SW_SCROLLCHILDREN 0x0001")]
        public const int SW_SCROLLCHILDREN = 0x0001;

        [NativeTypeName("#define SW_INVALIDATE 0x0002")]
        public const int SW_INVALIDATE = 0x0002;

        [NativeTypeName("#define SW_ERASE 0x0004")]
        public const int SW_ERASE = 0x0004;

        [NativeTypeName("#define SW_SMOOTHSCROLL 0x0010")]
        public const int SW_SMOOTHSCROLL = 0x0010;

        [NativeTypeName("#define ESB_ENABLE_BOTH 0x0000")]
        public const int ESB_ENABLE_BOTH = 0x0000;

        [NativeTypeName("#define ESB_DISABLE_BOTH 0x0003")]
        public const int ESB_DISABLE_BOTH = 0x0003;

        [NativeTypeName("#define ESB_DISABLE_LEFT 0x0001")]
        public const int ESB_DISABLE_LEFT = 0x0001;

        [NativeTypeName("#define ESB_DISABLE_RIGHT 0x0002")]
        public const int ESB_DISABLE_RIGHT = 0x0002;

        [NativeTypeName("#define ESB_DISABLE_UP 0x0001")]
        public const int ESB_DISABLE_UP = 0x0001;

        [NativeTypeName("#define ESB_DISABLE_DOWN 0x0002")]
        public const int ESB_DISABLE_DOWN = 0x0002;

        [NativeTypeName("#define ESB_DISABLE_LTUP ESB_DISABLE_LEFT")]
        public const int ESB_DISABLE_LTUP = 0x0001;

        [NativeTypeName("#define ESB_DISABLE_RTDN ESB_DISABLE_RIGHT")]
        public const int ESB_DISABLE_RTDN = 0x0002;

        [NativeTypeName("#define SetProp SetPropW")]
        public static readonly delegate*<IntPtr, ushort*, IntPtr, int> SetProp = &SetPropW;

        [NativeTypeName("#define GetProp GetPropW")]
        public static readonly delegate*<IntPtr, ushort*, IntPtr> GetProp = &GetPropW;

        [NativeTypeName("#define RemoveProp RemovePropW")]
        public static readonly delegate*<IntPtr, ushort*, IntPtr> RemoveProp = &RemovePropW;

        [NativeTypeName("#define EnumPropsEx EnumPropsExW")]
        public static readonly delegate*<IntPtr, delegate* unmanaged<IntPtr, ushort*, IntPtr, nuint, int>, nint, int> EnumPropsEx = &EnumPropsExW;

        [NativeTypeName("#define EnumProps EnumPropsW")]
        public static readonly delegate*<IntPtr, delegate* unmanaged<IntPtr, ushort*, IntPtr, int>, int> EnumProps = &EnumPropsW;

        [NativeTypeName("#define SetWindowText SetWindowTextW")]
        public static readonly delegate*<IntPtr, ushort*, int> SetWindowText = &SetWindowTextW;

        [NativeTypeName("#define GetWindowText GetWindowTextW")]
        public static readonly delegate*<IntPtr, ushort*, int, int> GetWindowText = &GetWindowTextW;

        [NativeTypeName("#define GetWindowTextLength GetWindowTextLengthW")]
        public static readonly delegate*<IntPtr, int> GetWindowTextLength = &GetWindowTextLengthW;

        [NativeTypeName("#define HELPINFO_WINDOW 0x0001")]
        public const int HELPINFO_WINDOW = 0x0001;

        [NativeTypeName("#define HELPINFO_MENUITEM 0x0002")]
        public const int HELPINFO_MENUITEM = 0x0002;

        [NativeTypeName("#define MB_OK 0x00000000L")]
        public const int MB_OK = 0x00000000;

        [NativeTypeName("#define MB_OKCANCEL 0x00000001L")]
        public const int MB_OKCANCEL = 0x00000001;

        [NativeTypeName("#define MB_ABORTRETRYIGNORE 0x00000002L")]
        public const int MB_ABORTRETRYIGNORE = 0x00000002;

        [NativeTypeName("#define MB_YESNOCANCEL 0x00000003L")]
        public const int MB_YESNOCANCEL = 0x00000003;

        [NativeTypeName("#define MB_YESNO 0x00000004L")]
        public const int MB_YESNO = 0x00000004;

        [NativeTypeName("#define MB_RETRYCANCEL 0x00000005L")]
        public const int MB_RETRYCANCEL = 0x00000005;

        [NativeTypeName("#define MB_CANCELTRYCONTINUE 0x00000006L")]
        public const int MB_CANCELTRYCONTINUE = 0x00000006;

        [NativeTypeName("#define MB_ICONHAND 0x00000010L")]
        public const int MB_ICONHAND = 0x00000010;

        [NativeTypeName("#define MB_ICONQUESTION 0x00000020L")]
        public const int MB_ICONQUESTION = 0x00000020;

        [NativeTypeName("#define MB_ICONEXCLAMATION 0x00000030L")]
        public const int MB_ICONEXCLAMATION = 0x00000030;

        [NativeTypeName("#define MB_ICONASTERISK 0x00000040L")]
        public const int MB_ICONASTERISK = 0x00000040;

        [NativeTypeName("#define MB_USERICON 0x00000080L")]
        public const int MB_USERICON = 0x00000080;

        [NativeTypeName("#define MB_ICONWARNING MB_ICONEXCLAMATION")]
        public const int MB_ICONWARNING = 0x00000030;

        [NativeTypeName("#define MB_ICONERROR MB_ICONHAND")]
        public const int MB_ICONERROR = 0x00000010;

        [NativeTypeName("#define MB_ICONINFORMATION MB_ICONASTERISK")]
        public const int MB_ICONINFORMATION = 0x00000040;

        [NativeTypeName("#define MB_ICONSTOP MB_ICONHAND")]
        public const int MB_ICONSTOP = 0x00000010;

        [NativeTypeName("#define MB_DEFBUTTON1 0x00000000L")]
        public const int MB_DEFBUTTON1 = 0x00000000;

        [NativeTypeName("#define MB_DEFBUTTON2 0x00000100L")]
        public const int MB_DEFBUTTON2 = 0x00000100;

        [NativeTypeName("#define MB_DEFBUTTON3 0x00000200L")]
        public const int MB_DEFBUTTON3 = 0x00000200;

        [NativeTypeName("#define MB_DEFBUTTON4 0x00000300L")]
        public const int MB_DEFBUTTON4 = 0x00000300;

        [NativeTypeName("#define MB_APPLMODAL 0x00000000L")]
        public const int MB_APPLMODAL = 0x00000000;

        [NativeTypeName("#define MB_SYSTEMMODAL 0x00001000L")]
        public const int MB_SYSTEMMODAL = 0x00001000;

        [NativeTypeName("#define MB_TASKMODAL 0x00002000L")]
        public const int MB_TASKMODAL = 0x00002000;

        [NativeTypeName("#define MB_HELP 0x00004000L")]
        public const int MB_HELP = 0x00004000;

        [NativeTypeName("#define MB_NOFOCUS 0x00008000L")]
        public const int MB_NOFOCUS = 0x00008000;

        [NativeTypeName("#define MB_SETFOREGROUND 0x00010000L")]
        public const int MB_SETFOREGROUND = 0x00010000;

        [NativeTypeName("#define MB_DEFAULT_DESKTOP_ONLY 0x00020000L")]
        public const int MB_DEFAULT_DESKTOP_ONLY = 0x00020000;

        [NativeTypeName("#define MB_TOPMOST 0x00040000L")]
        public const int MB_TOPMOST = 0x00040000;

        [NativeTypeName("#define MB_RIGHT 0x00080000L")]
        public const int MB_RIGHT = 0x00080000;

        [NativeTypeName("#define MB_RTLREADING 0x00100000L")]
        public const int MB_RTLREADING = 0x00100000;

        [NativeTypeName("#define MB_SERVICE_NOTIFICATION 0x00200000L")]
        public const int MB_SERVICE_NOTIFICATION = 0x00200000;

        [NativeTypeName("#define MB_SERVICE_NOTIFICATION_NT3X 0x00040000L")]
        public const int MB_SERVICE_NOTIFICATION_NT3X = 0x00040000;

        [NativeTypeName("#define MB_TYPEMASK 0x0000000FL")]
        public const int MB_TYPEMASK = 0x0000000F;

        [NativeTypeName("#define MB_ICONMASK 0x000000F0L")]
        public const int MB_ICONMASK = 0x000000F0;

        [NativeTypeName("#define MB_DEFMASK 0x00000F00L")]
        public const int MB_DEFMASK = 0x00000F00;

        [NativeTypeName("#define MB_MODEMASK 0x00003000L")]
        public const int MB_MODEMASK = 0x00003000;

        [NativeTypeName("#define MB_MISCMASK 0x0000C000L")]
        public const int MB_MISCMASK = 0x0000C000;

        [NativeTypeName("#define MessageBox MessageBoxW")]
        public static readonly delegate*<IntPtr, ushort*, ushort*, uint, int> MessageBox = &MessageBoxW;

        [NativeTypeName("#define MessageBoxEx MessageBoxExW")]
        public static readonly delegate*<IntPtr, ushort*, ushort*, uint, ushort, int> MessageBoxEx = &MessageBoxExW;

        [NativeTypeName("#define MessageBoxIndirect MessageBoxIndirectW")]
        public static readonly delegate*<MSGBOXPARAMSW*, int> MessageBoxIndirect = &MessageBoxIndirectW;

        [NativeTypeName("#define CWP_ALL 0x0000")]
        public const int CWP_ALL = 0x0000;

        [NativeTypeName("#define CWP_SKIPINVISIBLE 0x0001")]
        public const int CWP_SKIPINVISIBLE = 0x0001;

        [NativeTypeName("#define CWP_SKIPDISABLED 0x0002")]
        public const int CWP_SKIPDISABLED = 0x0002;

        [NativeTypeName("#define CWP_SKIPTRANSPARENT 0x0004")]
        public const int CWP_SKIPTRANSPARENT = 0x0004;

        [NativeTypeName("#define CTLCOLOR_MSGBOX 0")]
        public const int CTLCOLOR_MSGBOX = 0;

        [NativeTypeName("#define CTLCOLOR_EDIT 1")]
        public const int CTLCOLOR_EDIT = 1;

        [NativeTypeName("#define CTLCOLOR_LISTBOX 2")]
        public const int CTLCOLOR_LISTBOX = 2;

        [NativeTypeName("#define CTLCOLOR_BTN 3")]
        public const int CTLCOLOR_BTN = 3;

        [NativeTypeName("#define CTLCOLOR_DLG 4")]
        public const int CTLCOLOR_DLG = 4;

        [NativeTypeName("#define CTLCOLOR_SCROLLBAR 5")]
        public const int CTLCOLOR_SCROLLBAR = 5;

        [NativeTypeName("#define CTLCOLOR_STATIC 6")]
        public const int CTLCOLOR_STATIC = 6;

        [NativeTypeName("#define CTLCOLOR_MAX 7")]
        public const int CTLCOLOR_MAX = 7;

        [NativeTypeName("#define COLOR_SCROLLBAR 0")]
        public const int COLOR_SCROLLBAR = 0;

        [NativeTypeName("#define COLOR_BACKGROUND 1")]
        public const int COLOR_BACKGROUND = 1;

        [NativeTypeName("#define COLOR_ACTIVECAPTION 2")]
        public const int COLOR_ACTIVECAPTION = 2;

        [NativeTypeName("#define COLOR_INACTIVECAPTION 3")]
        public const int COLOR_INACTIVECAPTION = 3;

        [NativeTypeName("#define COLOR_MENU 4")]
        public const int COLOR_MENU = 4;

        [NativeTypeName("#define COLOR_WINDOW 5")]
        public const int COLOR_WINDOW = 5;

        [NativeTypeName("#define COLOR_WINDOWFRAME 6")]
        public const int COLOR_WINDOWFRAME = 6;

        [NativeTypeName("#define COLOR_MENUTEXT 7")]
        public const int COLOR_MENUTEXT = 7;

        [NativeTypeName("#define COLOR_WINDOWTEXT 8")]
        public const int COLOR_WINDOWTEXT = 8;

        [NativeTypeName("#define COLOR_CAPTIONTEXT 9")]
        public const int COLOR_CAPTIONTEXT = 9;

        [NativeTypeName("#define COLOR_ACTIVEBORDER 10")]
        public const int COLOR_ACTIVEBORDER = 10;

        [NativeTypeName("#define COLOR_INACTIVEBORDER 11")]
        public const int COLOR_INACTIVEBORDER = 11;

        [NativeTypeName("#define COLOR_APPWORKSPACE 12")]
        public const int COLOR_APPWORKSPACE = 12;

        [NativeTypeName("#define COLOR_HIGHLIGHT 13")]
        public const int COLOR_HIGHLIGHT = 13;

        [NativeTypeName("#define COLOR_HIGHLIGHTTEXT 14")]
        public const int COLOR_HIGHLIGHTTEXT = 14;

        [NativeTypeName("#define COLOR_BTNFACE 15")]
        public const int COLOR_BTNFACE = 15;

        [NativeTypeName("#define COLOR_BTNSHADOW 16")]
        public const int COLOR_BTNSHADOW = 16;

        [NativeTypeName("#define COLOR_GRAYTEXT 17")]
        public const int COLOR_GRAYTEXT = 17;

        [NativeTypeName("#define COLOR_BTNTEXT 18")]
        public const int COLOR_BTNTEXT = 18;

        [NativeTypeName("#define COLOR_INACTIVECAPTIONTEXT 19")]
        public const int COLOR_INACTIVECAPTIONTEXT = 19;

        [NativeTypeName("#define COLOR_BTNHIGHLIGHT 20")]
        public const int COLOR_BTNHIGHLIGHT = 20;

        [NativeTypeName("#define COLOR_3DDKSHADOW 21")]
        public const int COLOR_3DDKSHADOW = 21;

        [NativeTypeName("#define COLOR_3DLIGHT 22")]
        public const int COLOR_3DLIGHT = 22;

        [NativeTypeName("#define COLOR_INFOTEXT 23")]
        public const int COLOR_INFOTEXT = 23;

        [NativeTypeName("#define COLOR_INFOBK 24")]
        public const int COLOR_INFOBK = 24;

        [NativeTypeName("#define COLOR_HOTLIGHT 26")]
        public const int COLOR_HOTLIGHT = 26;

        [NativeTypeName("#define COLOR_GRADIENTACTIVECAPTION 27")]
        public const int COLOR_GRADIENTACTIVECAPTION = 27;

        [NativeTypeName("#define COLOR_GRADIENTINACTIVECAPTION 28")]
        public const int COLOR_GRADIENTINACTIVECAPTION = 28;

        [NativeTypeName("#define COLOR_MENUHILIGHT 29")]
        public const int COLOR_MENUHILIGHT = 29;

        [NativeTypeName("#define COLOR_MENUBAR 30")]
        public const int COLOR_MENUBAR = 30;

        [NativeTypeName("#define COLOR_DESKTOP COLOR_BACKGROUND")]
        public const int COLOR_DESKTOP = 1;

        [NativeTypeName("#define COLOR_3DFACE COLOR_BTNFACE")]
        public const int COLOR_3DFACE = 15;

        [NativeTypeName("#define COLOR_3DSHADOW COLOR_BTNSHADOW")]
        public const int COLOR_3DSHADOW = 16;

        [NativeTypeName("#define COLOR_3DHIGHLIGHT COLOR_BTNHIGHLIGHT")]
        public const int COLOR_3DHIGHLIGHT = 20;

        [NativeTypeName("#define COLOR_3DHILIGHT COLOR_BTNHIGHLIGHT")]
        public const int COLOR_3DHILIGHT = 20;

        [NativeTypeName("#define COLOR_BTNHILIGHT COLOR_BTNHIGHLIGHT")]
        public const int COLOR_BTNHILIGHT = 20;

        [NativeTypeName("#define GetWindowLong GetWindowLongW")]
        public static readonly delegate*<IntPtr, int, int> GetWindowLong = &GetWindowLongW;

        [NativeTypeName("#define SetWindowLong SetWindowLongW")]
        public static readonly delegate*<IntPtr, int, int, int> SetWindowLong = &SetWindowLongW;

        [NativeTypeName("#define GetClassLong GetClassLongW")]
        public static readonly delegate*<IntPtr, int, uint> GetClassLong = &GetClassLongW;

        [NativeTypeName("#define SetClassLong SetClassLongW")]
        public static readonly delegate*<IntPtr, int, int, uint> SetClassLong = &SetClassLongW;

        [NativeTypeName("#define FindWindow FindWindowW")]
        public static readonly delegate*<ushort*, ushort*, IntPtr> FindWindow = &FindWindowW;

        [NativeTypeName("#define FindWindowEx FindWindowExW")]
        public static readonly delegate*<IntPtr, IntPtr, ushort*, ushort*, IntPtr> FindWindowEx = &FindWindowExW;

        [NativeTypeName("#define GetClassName GetClassNameW")]
        public static readonly delegate*<IntPtr, ushort*, int, int> GetClassName = &GetClassNameW;

        [NativeTypeName("#define GW_HWNDFIRST 0")]
        public const int GW_HWNDFIRST = 0;

        [NativeTypeName("#define GW_HWNDLAST 1")]
        public const int GW_HWNDLAST = 1;

        [NativeTypeName("#define GW_HWNDNEXT 2")]
        public const int GW_HWNDNEXT = 2;

        [NativeTypeName("#define GW_HWNDPREV 3")]
        public const int GW_HWNDPREV = 3;

        [NativeTypeName("#define GW_OWNER 4")]
        public const int GW_OWNER = 4;

        [NativeTypeName("#define GW_CHILD 5")]
        public const int GW_CHILD = 5;

        [NativeTypeName("#define GW_ENABLEDPOPUP 6")]
        public const int GW_ENABLEDPOPUP = 6;

        [NativeTypeName("#define GW_MAX 6")]
        public const int GW_MAX = 6;

        [NativeTypeName("#define SetWindowsHook SetWindowsHookW")]
        public static readonly delegate*<int, delegate* unmanaged<int, nuint, nint, nint>, IntPtr> SetWindowsHook = &SetWindowsHookW;

        [NativeTypeName("#define SetWindowsHookEx SetWindowsHookExW")]
        public static readonly delegate*<int, delegate* unmanaged<int, nuint, nint, nint>, IntPtr, uint, IntPtr> SetWindowsHookEx = &SetWindowsHookExW;

        [NativeTypeName("#define MF_INSERT 0x00000000L")]
        public const int MF_INSERT = 0x00000000;

        [NativeTypeName("#define MF_CHANGE 0x00000080L")]
        public const int MF_CHANGE = 0x00000080;

        [NativeTypeName("#define MF_APPEND 0x00000100L")]
        public const int MF_APPEND = 0x00000100;

        [NativeTypeName("#define MF_DELETE 0x00000200L")]
        public const int MF_DELETE = 0x00000200;

        [NativeTypeName("#define MF_REMOVE 0x00001000L")]
        public const int MF_REMOVE = 0x00001000;

        [NativeTypeName("#define MF_BYCOMMAND 0x00000000L")]
        public const int MF_BYCOMMAND = 0x00000000;

        [NativeTypeName("#define MF_BYPOSITION 0x00000400L")]
        public const int MF_BYPOSITION = 0x00000400;

        [NativeTypeName("#define MF_SEPARATOR 0x00000800L")]
        public const int MF_SEPARATOR = 0x00000800;

        [NativeTypeName("#define MF_ENABLED 0x00000000L")]
        public const int MF_ENABLED = 0x00000000;

        [NativeTypeName("#define MF_GRAYED 0x00000001L")]
        public const int MF_GRAYED = 0x00000001;

        [NativeTypeName("#define MF_DISABLED 0x00000002L")]
        public const int MF_DISABLED = 0x00000002;

        [NativeTypeName("#define MF_UNCHECKED 0x00000000L")]
        public const int MF_UNCHECKED = 0x00000000;

        [NativeTypeName("#define MF_CHECKED 0x00000008L")]
        public const int MF_CHECKED = 0x00000008;

        [NativeTypeName("#define MF_USECHECKBITMAPS 0x00000200L")]
        public const int MF_USECHECKBITMAPS = 0x00000200;

        [NativeTypeName("#define MF_STRING 0x00000000L")]
        public const int MF_STRING = 0x00000000;

        [NativeTypeName("#define MF_BITMAP 0x00000004L")]
        public const int MF_BITMAP = 0x00000004;

        [NativeTypeName("#define MF_OWNERDRAW 0x00000100L")]
        public const int MF_OWNERDRAW = 0x00000100;

        [NativeTypeName("#define MF_POPUP 0x00000010L")]
        public const int MF_POPUP = 0x00000010;

        [NativeTypeName("#define MF_MENUBARBREAK 0x00000020L")]
        public const int MF_MENUBARBREAK = 0x00000020;

        [NativeTypeName("#define MF_MENUBREAK 0x00000040L")]
        public const int MF_MENUBREAK = 0x00000040;

        [NativeTypeName("#define MF_UNHILITE 0x00000000L")]
        public const int MF_UNHILITE = 0x00000000;

        [NativeTypeName("#define MF_HILITE 0x00000080L")]
        public const int MF_HILITE = 0x00000080;

        [NativeTypeName("#define MF_DEFAULT 0x00001000L")]
        public const int MF_DEFAULT = 0x00001000;

        [NativeTypeName("#define MF_SYSMENU 0x00002000L")]
        public const int MF_SYSMENU = 0x00002000;

        [NativeTypeName("#define MF_HELP 0x00004000L")]
        public const int MF_HELP = 0x00004000;

        [NativeTypeName("#define MF_RIGHTJUSTIFY 0x00004000L")]
        public const int MF_RIGHTJUSTIFY = 0x00004000;

        [NativeTypeName("#define MF_MOUSESELECT 0x00008000L")]
        public const int MF_MOUSESELECT = 0x00008000;

        [NativeTypeName("#define MF_END 0x00000080L")]
        public const int MF_END = 0x00000080;

        [NativeTypeName("#define MFT_STRING MF_STRING")]
        public const int MFT_STRING = 0x00000000;

        [NativeTypeName("#define MFT_BITMAP MF_BITMAP")]
        public const int MFT_BITMAP = 0x00000004;

        [NativeTypeName("#define MFT_MENUBARBREAK MF_MENUBARBREAK")]
        public const int MFT_MENUBARBREAK = 0x00000020;

        [NativeTypeName("#define MFT_MENUBREAK MF_MENUBREAK")]
        public const int MFT_MENUBREAK = 0x00000040;

        [NativeTypeName("#define MFT_OWNERDRAW MF_OWNERDRAW")]
        public const int MFT_OWNERDRAW = 0x00000100;

        [NativeTypeName("#define MFT_RADIOCHECK 0x00000200L")]
        public const int MFT_RADIOCHECK = 0x00000200;

        [NativeTypeName("#define MFT_SEPARATOR MF_SEPARATOR")]
        public const int MFT_SEPARATOR = 0x00000800;

        [NativeTypeName("#define MFT_RIGHTORDER 0x00002000L")]
        public const int MFT_RIGHTORDER = 0x00002000;

        [NativeTypeName("#define MFT_RIGHTJUSTIFY MF_RIGHTJUSTIFY")]
        public const int MFT_RIGHTJUSTIFY = 0x00004000;

        [NativeTypeName("#define MFS_GRAYED 0x00000003L")]
        public const int MFS_GRAYED = 0x00000003;

        [NativeTypeName("#define MFS_DISABLED MFS_GRAYED")]
        public const int MFS_DISABLED = 0x00000003;

        [NativeTypeName("#define MFS_CHECKED MF_CHECKED")]
        public const int MFS_CHECKED = 0x00000008;

        [NativeTypeName("#define MFS_HILITE MF_HILITE")]
        public const int MFS_HILITE = 0x00000080;

        [NativeTypeName("#define MFS_ENABLED MF_ENABLED")]
        public const int MFS_ENABLED = 0x00000000;

        [NativeTypeName("#define MFS_UNCHECKED MF_UNCHECKED")]
        public const int MFS_UNCHECKED = 0x00000000;

        [NativeTypeName("#define MFS_UNHILITE MF_UNHILITE")]
        public const int MFS_UNHILITE = 0x00000000;

        [NativeTypeName("#define MFS_DEFAULT MF_DEFAULT")]
        public const int MFS_DEFAULT = 0x00001000;

        [NativeTypeName("#define SC_SIZE 0xF000")]
        public const int SC_SIZE = 0xF000;

        [NativeTypeName("#define SC_MOVE 0xF010")]
        public const int SC_MOVE = 0xF010;

        [NativeTypeName("#define SC_MINIMIZE 0xF020")]
        public const int SC_MINIMIZE = 0xF020;

        [NativeTypeName("#define SC_MAXIMIZE 0xF030")]
        public const int SC_MAXIMIZE = 0xF030;

        [NativeTypeName("#define SC_NEXTWINDOW 0xF040")]
        public const int SC_NEXTWINDOW = 0xF040;

        [NativeTypeName("#define SC_PREVWINDOW 0xF050")]
        public const int SC_PREVWINDOW = 0xF050;

        [NativeTypeName("#define SC_CLOSE 0xF060")]
        public const int SC_CLOSE = 0xF060;

        [NativeTypeName("#define SC_VSCROLL 0xF070")]
        public const int SC_VSCROLL = 0xF070;

        [NativeTypeName("#define SC_HSCROLL 0xF080")]
        public const int SC_HSCROLL = 0xF080;

        [NativeTypeName("#define SC_MOUSEMENU 0xF090")]
        public const int SC_MOUSEMENU = 0xF090;

        [NativeTypeName("#define SC_KEYMENU 0xF100")]
        public const int SC_KEYMENU = 0xF100;

        [NativeTypeName("#define SC_ARRANGE 0xF110")]
        public const int SC_ARRANGE = 0xF110;

        [NativeTypeName("#define SC_RESTORE 0xF120")]
        public const int SC_RESTORE = 0xF120;

        [NativeTypeName("#define SC_TASKLIST 0xF130")]
        public const int SC_TASKLIST = 0xF130;

        [NativeTypeName("#define SC_SCREENSAVE 0xF140")]
        public const int SC_SCREENSAVE = 0xF140;

        [NativeTypeName("#define SC_HOTKEY 0xF150")]
        public const int SC_HOTKEY = 0xF150;

        [NativeTypeName("#define SC_DEFAULT 0xF160")]
        public const int SC_DEFAULT = 0xF160;

        [NativeTypeName("#define SC_MONITORPOWER 0xF170")]
        public const int SC_MONITORPOWER = 0xF170;

        [NativeTypeName("#define SC_CONTEXTHELP 0xF180")]
        public const int SC_CONTEXTHELP = 0xF180;

        [NativeTypeName("#define SC_SEPARATOR 0xF00F")]
        public const int SC_SEPARATOR = 0xF00F;

        [NativeTypeName("#define SCF_ISSECURE 0x00000001")]
        public const int SCF_ISSECURE = 0x00000001;

        [NativeTypeName("#define SC_ICON SC_MINIMIZE")]
        public const int SC_ICON = 0xF020;

        [NativeTypeName("#define SC_ZOOM SC_MAXIMIZE")]
        public const int SC_ZOOM = 0xF030;

        [NativeTypeName("#define LoadBitmap LoadBitmapW")]
        public static readonly delegate*<IntPtr, ushort*, IntPtr> LoadBitmap = &LoadBitmapW;

        [NativeTypeName("#define LoadCursor LoadCursorW")]
        public static readonly delegate*<IntPtr, ushort*, IntPtr> LoadCursor = &LoadCursorW;

        [NativeTypeName("#define LoadCursorFromFile LoadCursorFromFileW")]
        public static readonly delegate*<ushort*, IntPtr> LoadCursorFromFile = &LoadCursorFromFileW;

        [NativeTypeName("#define IDC_ARROW MAKEINTRESOURCE(32512)")]
        public static readonly ushort* IDC_ARROW = ((ushort*)((nuint)((ushort)(32512))));

        [NativeTypeName("#define IDC_IBEAM MAKEINTRESOURCE(32513)")]
        public static readonly ushort* IDC_IBEAM = ((ushort*)((nuint)((ushort)(32513))));

        [NativeTypeName("#define IDC_WAIT MAKEINTRESOURCE(32514)")]
        public static readonly ushort* IDC_WAIT = ((ushort*)((nuint)((ushort)(32514))));

        [NativeTypeName("#define IDC_CROSS MAKEINTRESOURCE(32515)")]
        public static readonly ushort* IDC_CROSS = ((ushort*)((nuint)((ushort)(32515))));

        [NativeTypeName("#define IDC_UPARROW MAKEINTRESOURCE(32516)")]
        public static readonly ushort* IDC_UPARROW = ((ushort*)((nuint)((ushort)(32516))));

        [NativeTypeName("#define IDC_SIZE MAKEINTRESOURCE(32640)")]
        public static readonly ushort* IDC_SIZE = ((ushort*)((nuint)((ushort)(32640))));

        [NativeTypeName("#define IDC_ICON MAKEINTRESOURCE(32641)")]
        public static readonly ushort* IDC_ICON = ((ushort*)((nuint)((ushort)(32641))));

        [NativeTypeName("#define IDC_SIZENWSE MAKEINTRESOURCE(32642)")]
        public static readonly ushort* IDC_SIZENWSE = ((ushort*)((nuint)((ushort)(32642))));

        [NativeTypeName("#define IDC_SIZENESW MAKEINTRESOURCE(32643)")]
        public static readonly ushort* IDC_SIZENESW = ((ushort*)((nuint)((ushort)(32643))));

        [NativeTypeName("#define IDC_SIZEWE MAKEINTRESOURCE(32644)")]
        public static readonly ushort* IDC_SIZEWE = ((ushort*)((nuint)((ushort)(32644))));

        [NativeTypeName("#define IDC_SIZENS MAKEINTRESOURCE(32645)")]
        public static readonly ushort* IDC_SIZENS = ((ushort*)((nuint)((ushort)(32645))));

        [NativeTypeName("#define IDC_SIZEALL MAKEINTRESOURCE(32646)")]
        public static readonly ushort* IDC_SIZEALL = ((ushort*)((nuint)((ushort)(32646))));

        [NativeTypeName("#define IDC_NO MAKEINTRESOURCE(32648)")]
        public static readonly ushort* IDC_NO = ((ushort*)((nuint)((ushort)(32648))));

        [NativeTypeName("#define IDC_HAND MAKEINTRESOURCE(32649)")]
        public static readonly ushort* IDC_HAND = ((ushort*)((nuint)((ushort)(32649))));

        [NativeTypeName("#define IDC_APPSTARTING MAKEINTRESOURCE(32650)")]
        public static readonly ushort* IDC_APPSTARTING = ((ushort*)((nuint)((ushort)(32650))));

        [NativeTypeName("#define IDC_HELP MAKEINTRESOURCE(32651)")]
        public static readonly ushort* IDC_HELP = ((ushort*)((nuint)((ushort)(32651))));

        [NativeTypeName("#define IDC_PIN MAKEINTRESOURCE(32671)")]
        public static readonly ushort* IDC_PIN = ((ushort*)((nuint)((ushort)(32671))));

        [NativeTypeName("#define IDC_PERSON MAKEINTRESOURCE(32672)")]
        public static readonly ushort* IDC_PERSON = ((ushort*)((nuint)((ushort)(32672))));

        [NativeTypeName("#define LoadIcon LoadIconW")]
        public static readonly delegate*<IntPtr, ushort*, IntPtr> LoadIcon = &LoadIconW;

        [NativeTypeName("#define PrivateExtractIcons PrivateExtractIconsW")]
        public static readonly delegate*<ushort*, int, int, int, IntPtr*, uint*, uint, uint, uint> PrivateExtractIcons = &PrivateExtractIconsW;

        [NativeTypeName("#define IMAGE_BITMAP 0")]
        public const int IMAGE_BITMAP = 0;

        [NativeTypeName("#define IMAGE_ICON 1")]
        public const int IMAGE_ICON = 1;

        [NativeTypeName("#define IMAGE_CURSOR 2")]
        public const int IMAGE_CURSOR = 2;

        [NativeTypeName("#define IMAGE_ENHMETAFILE 3")]
        public const int IMAGE_ENHMETAFILE = 3;

        [NativeTypeName("#define LR_DEFAULTCOLOR 0x00000000")]
        public const int LR_DEFAULTCOLOR = 0x00000000;

        [NativeTypeName("#define LR_MONOCHROME 0x00000001")]
        public const int LR_MONOCHROME = 0x00000001;

        [NativeTypeName("#define LR_COLOR 0x00000002")]
        public const int LR_COLOR = 0x00000002;

        [NativeTypeName("#define LR_COPYRETURNORG 0x00000004")]
        public const int LR_COPYRETURNORG = 0x00000004;

        [NativeTypeName("#define LR_COPYDELETEORG 0x00000008")]
        public const int LR_COPYDELETEORG = 0x00000008;

        [NativeTypeName("#define LR_LOADFROMFILE 0x00000010")]
        public const int LR_LOADFROMFILE = 0x00000010;

        [NativeTypeName("#define LR_LOADTRANSPARENT 0x00000020")]
        public const int LR_LOADTRANSPARENT = 0x00000020;

        [NativeTypeName("#define LR_DEFAULTSIZE 0x00000040")]
        public const int LR_DEFAULTSIZE = 0x00000040;

        [NativeTypeName("#define LR_VGACOLOR 0x00000080")]
        public const int LR_VGACOLOR = 0x00000080;

        [NativeTypeName("#define LR_LOADMAP3DCOLORS 0x00001000")]
        public const int LR_LOADMAP3DCOLORS = 0x00001000;

        [NativeTypeName("#define LR_CREATEDIBSECTION 0x00002000")]
        public const int LR_CREATEDIBSECTION = 0x00002000;

        [NativeTypeName("#define LR_COPYFROMRESOURCE 0x00004000")]
        public const int LR_COPYFROMRESOURCE = 0x00004000;

        [NativeTypeName("#define LR_SHARED 0x00008000")]
        public const int LR_SHARED = 0x00008000;

        [NativeTypeName("#define LoadImage LoadImageW")]
        public static readonly delegate*<IntPtr, ushort*, uint, int, int, uint, IntPtr> LoadImage = &LoadImageW;

        [NativeTypeName("#define DI_MASK 0x0001")]
        public const int DI_MASK = 0x0001;

        [NativeTypeName("#define DI_IMAGE 0x0002")]
        public const int DI_IMAGE = 0x0002;

        [NativeTypeName("#define DI_NORMAL 0x0003")]
        public const int DI_NORMAL = 0x0003;

        [NativeTypeName("#define DI_COMPAT 0x0004")]
        public const int DI_COMPAT = 0x0004;

        [NativeTypeName("#define DI_DEFAULTSIZE 0x0008")]
        public const int DI_DEFAULTSIZE = 0x0008;

        [NativeTypeName("#define DI_NOMIRROR 0x0010")]
        public const int DI_NOMIRROR = 0x0010;

        [NativeTypeName("#define GetIconInfoEx GetIconInfoExW")]
        public static readonly delegate*<IntPtr, ICONINFOEXW*, int> GetIconInfoEx = &GetIconInfoExW;

        [NativeTypeName("#define RES_ICON 1")]
        public const int RES_ICON = 1;

        [NativeTypeName("#define RES_CURSOR 2")]
        public const int RES_CURSOR = 2;

        [NativeTypeName("#define ORD_LANGDRIVER 1")]
        public const int ORD_LANGDRIVER = 1;

        [NativeTypeName("#define IDI_APPLICATION MAKEINTRESOURCE(32512)")]
        public static readonly ushort* IDI_APPLICATION = ((ushort*)((nuint)((ushort)(32512))));

        [NativeTypeName("#define IDI_HAND MAKEINTRESOURCE(32513)")]
        public static readonly ushort* IDI_HAND = ((ushort*)((nuint)((ushort)(32513))));

        [NativeTypeName("#define IDI_QUESTION MAKEINTRESOURCE(32514)")]
        public static readonly ushort* IDI_QUESTION = ((ushort*)((nuint)((ushort)(32514))));

        [NativeTypeName("#define IDI_EXCLAMATION MAKEINTRESOURCE(32515)")]
        public static readonly ushort* IDI_EXCLAMATION = ((ushort*)((nuint)((ushort)(32515))));

        [NativeTypeName("#define IDI_ASTERISK MAKEINTRESOURCE(32516)")]
        public static readonly ushort* IDI_ASTERISK = ((ushort*)((nuint)((ushort)(32516))));

        [NativeTypeName("#define IDI_WINLOGO MAKEINTRESOURCE(32517)")]
        public static readonly ushort* IDI_WINLOGO = ((ushort*)((nuint)((ushort)(32517))));

        [NativeTypeName("#define IDI_SHIELD MAKEINTRESOURCE(32518)")]
        public static readonly ushort* IDI_SHIELD = ((ushort*)((nuint)((ushort)(32518))));

        [NativeTypeName("#define IDI_WARNING IDI_EXCLAMATION")]
        public static readonly ushort* IDI_WARNING = ((ushort*)((nuint)((ushort)(32515))));

        [NativeTypeName("#define IDI_ERROR IDI_HAND")]
        public static readonly ushort* IDI_ERROR = ((ushort*)((nuint)((ushort)(32513))));

        [NativeTypeName("#define IDI_INFORMATION IDI_ASTERISK")]
        public static readonly ushort* IDI_INFORMATION = ((ushort*)((nuint)((ushort)(32516))));

        [NativeTypeName("#define IDOK 1")]
        public const int IDOK = 1;

        [NativeTypeName("#define IDCANCEL 2")]
        public const int IDCANCEL = 2;

        [NativeTypeName("#define IDABORT 3")]
        public const int IDABORT = 3;

        [NativeTypeName("#define IDRETRY 4")]
        public const int IDRETRY = 4;

        [NativeTypeName("#define IDIGNORE 5")]
        public const int IDIGNORE = 5;

        [NativeTypeName("#define IDYES 6")]
        public const int IDYES = 6;

        [NativeTypeName("#define IDNO 7")]
        public const int IDNO = 7;

        [NativeTypeName("#define IDCLOSE 8")]
        public const int IDCLOSE = 8;

        [NativeTypeName("#define IDHELP 9")]
        public const int IDHELP = 9;

        [NativeTypeName("#define IDTRYAGAIN 10")]
        public const int IDTRYAGAIN = 10;

        [NativeTypeName("#define IDCONTINUE 11")]
        public const int IDCONTINUE = 11;

        [NativeTypeName("#define IDTIMEOUT 32000")]
        public const int IDTIMEOUT = 32000;

        [NativeTypeName("#define ES_LEFT 0x0000L")]
        public const int ES_LEFT = 0x0000;

        [NativeTypeName("#define ES_CENTER 0x0001L")]
        public const int ES_CENTER = 0x0001;

        [NativeTypeName("#define ES_RIGHT 0x0002L")]
        public const int ES_RIGHT = 0x0002;

        [NativeTypeName("#define ES_MULTILINE 0x0004L")]
        public const int ES_MULTILINE = 0x0004;

        [NativeTypeName("#define ES_UPPERCASE 0x0008L")]
        public const int ES_UPPERCASE = 0x0008;

        [NativeTypeName("#define ES_LOWERCASE 0x0010L")]
        public const int ES_LOWERCASE = 0x0010;

        [NativeTypeName("#define ES_PASSWORD 0x0020L")]
        public const int ES_PASSWORD = 0x0020;

        [NativeTypeName("#define ES_AUTOVSCROLL 0x0040L")]
        public const int ES_AUTOVSCROLL = 0x0040;

        [NativeTypeName("#define ES_AUTOHSCROLL 0x0080L")]
        public const int ES_AUTOHSCROLL = 0x0080;

        [NativeTypeName("#define ES_NOHIDESEL 0x0100L")]
        public const int ES_NOHIDESEL = 0x0100;

        [NativeTypeName("#define ES_OEMCONVERT 0x0400L")]
        public const int ES_OEMCONVERT = 0x0400;

        [NativeTypeName("#define ES_READONLY 0x0800L")]
        public const int ES_READONLY = 0x0800;

        [NativeTypeName("#define ES_WANTRETURN 0x1000L")]
        public const int ES_WANTRETURN = 0x1000;

        [NativeTypeName("#define ES_NUMBER 0x2000L")]
        public const int ES_NUMBER = 0x2000;

        [NativeTypeName("#define EN_SETFOCUS 0x0100")]
        public const int EN_SETFOCUS = 0x0100;

        [NativeTypeName("#define EN_KILLFOCUS 0x0200")]
        public const int EN_KILLFOCUS = 0x0200;

        [NativeTypeName("#define EN_CHANGE 0x0300")]
        public const int EN_CHANGE = 0x0300;

        [NativeTypeName("#define EN_UPDATE 0x0400")]
        public const int EN_UPDATE = 0x0400;

        [NativeTypeName("#define EN_ERRSPACE 0x0500")]
        public const int EN_ERRSPACE = 0x0500;

        [NativeTypeName("#define EN_MAXTEXT 0x0501")]
        public const int EN_MAXTEXT = 0x0501;

        [NativeTypeName("#define EN_HSCROLL 0x0601")]
        public const int EN_HSCROLL = 0x0601;

        [NativeTypeName("#define EN_VSCROLL 0x0602")]
        public const int EN_VSCROLL = 0x0602;

        [NativeTypeName("#define EN_ALIGN_LTR_EC 0x0700")]
        public const int EN_ALIGN_LTR_EC = 0x0700;

        [NativeTypeName("#define EN_ALIGN_RTL_EC 0x0701")]
        public const int EN_ALIGN_RTL_EC = 0x0701;

        [NativeTypeName("#define EN_BEFORE_PASTE 0x0800")]
        public const int EN_BEFORE_PASTE = 0x0800;

        [NativeTypeName("#define EN_AFTER_PASTE 0x0801")]
        public const int EN_AFTER_PASTE = 0x0801;

        [NativeTypeName("#define EC_LEFTMARGIN 0x0001")]
        public const int EC_LEFTMARGIN = 0x0001;

        [NativeTypeName("#define EC_RIGHTMARGIN 0x0002")]
        public const int EC_RIGHTMARGIN = 0x0002;

        [NativeTypeName("#define EC_USEFONTINFO 0xffff")]
        public const int EC_USEFONTINFO = 0xffff;

        [NativeTypeName("#define EMSIS_COMPOSITIONSTRING 0x0001")]
        public const int EMSIS_COMPOSITIONSTRING = 0x0001;

        [NativeTypeName("#define EIMES_GETCOMPSTRATONCE 0x0001")]
        public const int EIMES_GETCOMPSTRATONCE = 0x0001;

        [NativeTypeName("#define EIMES_CANCELCOMPSTRINFOCUS 0x0002")]
        public const int EIMES_CANCELCOMPSTRINFOCUS = 0x0002;

        [NativeTypeName("#define EIMES_COMPLETECOMPSTRKILLFOCUS 0x0004")]
        public const int EIMES_COMPLETECOMPSTRKILLFOCUS = 0x0004;

        [NativeTypeName("#define EM_GETSEL 0x00B0")]
        public const int EM_GETSEL = 0x00B0;

        [NativeTypeName("#define EM_SETSEL 0x00B1")]
        public const int EM_SETSEL = 0x00B1;

        [NativeTypeName("#define EM_GETRECT 0x00B2")]
        public const int EM_GETRECT = 0x00B2;

        [NativeTypeName("#define EM_SETRECT 0x00B3")]
        public const int EM_SETRECT = 0x00B3;

        [NativeTypeName("#define EM_SETRECTNP 0x00B4")]
        public const int EM_SETRECTNP = 0x00B4;

        [NativeTypeName("#define EM_SCROLL 0x00B5")]
        public const int EM_SCROLL = 0x00B5;

        [NativeTypeName("#define EM_LINESCROLL 0x00B6")]
        public const int EM_LINESCROLL = 0x00B6;

        [NativeTypeName("#define EM_SCROLLCARET 0x00B7")]
        public const int EM_SCROLLCARET = 0x00B7;

        [NativeTypeName("#define EM_GETMODIFY 0x00B8")]
        public const int EM_GETMODIFY = 0x00B8;

        [NativeTypeName("#define EM_SETMODIFY 0x00B9")]
        public const int EM_SETMODIFY = 0x00B9;

        [NativeTypeName("#define EM_GETLINECOUNT 0x00BA")]
        public const int EM_GETLINECOUNT = 0x00BA;

        [NativeTypeName("#define EM_LINEINDEX 0x00BB")]
        public const int EM_LINEINDEX = 0x00BB;

        [NativeTypeName("#define EM_SETHANDLE 0x00BC")]
        public const int EM_SETHANDLE = 0x00BC;

        [NativeTypeName("#define EM_GETHANDLE 0x00BD")]
        public const int EM_GETHANDLE = 0x00BD;

        [NativeTypeName("#define EM_GETTHUMB 0x00BE")]
        public const int EM_GETTHUMB = 0x00BE;

        [NativeTypeName("#define EM_LINELENGTH 0x00C1")]
        public const int EM_LINELENGTH = 0x00C1;

        [NativeTypeName("#define EM_REPLACESEL 0x00C2")]
        public const int EM_REPLACESEL = 0x00C2;

        [NativeTypeName("#define EM_GETLINE 0x00C4")]
        public const int EM_GETLINE = 0x00C4;

        [NativeTypeName("#define EM_LIMITTEXT 0x00C5")]
        public const int EM_LIMITTEXT = 0x00C5;

        [NativeTypeName("#define EM_CANUNDO 0x00C6")]
        public const int EM_CANUNDO = 0x00C6;

        [NativeTypeName("#define EM_UNDO 0x00C7")]
        public const int EM_UNDO = 0x00C7;

        [NativeTypeName("#define EM_FMTLINES 0x00C8")]
        public const int EM_FMTLINES = 0x00C8;

        [NativeTypeName("#define EM_LINEFROMCHAR 0x00C9")]
        public const int EM_LINEFROMCHAR = 0x00C9;

        [NativeTypeName("#define EM_SETTABSTOPS 0x00CB")]
        public const int EM_SETTABSTOPS = 0x00CB;

        [NativeTypeName("#define EM_SETPASSWORDCHAR 0x00CC")]
        public const int EM_SETPASSWORDCHAR = 0x00CC;

        [NativeTypeName("#define EM_EMPTYUNDOBUFFER 0x00CD")]
        public const int EM_EMPTYUNDOBUFFER = 0x00CD;

        [NativeTypeName("#define EM_GETFIRSTVISIBLELINE 0x00CE")]
        public const int EM_GETFIRSTVISIBLELINE = 0x00CE;

        [NativeTypeName("#define EM_SETREADONLY 0x00CF")]
        public const int EM_SETREADONLY = 0x00CF;

        [NativeTypeName("#define EM_SETWORDBREAKPROC 0x00D0")]
        public const int EM_SETWORDBREAKPROC = 0x00D0;

        [NativeTypeName("#define EM_GETWORDBREAKPROC 0x00D1")]
        public const int EM_GETWORDBREAKPROC = 0x00D1;

        [NativeTypeName("#define EM_GETPASSWORDCHAR 0x00D2")]
        public const int EM_GETPASSWORDCHAR = 0x00D2;

        [NativeTypeName("#define EM_SETMARGINS 0x00D3")]
        public const int EM_SETMARGINS = 0x00D3;

        [NativeTypeName("#define EM_GETMARGINS 0x00D4")]
        public const int EM_GETMARGINS = 0x00D4;

        [NativeTypeName("#define EM_SETLIMITTEXT EM_LIMITTEXT")]
        public const int EM_SETLIMITTEXT = 0x00C5;

        [NativeTypeName("#define EM_GETLIMITTEXT 0x00D5")]
        public const int EM_GETLIMITTEXT = 0x00D5;

        [NativeTypeName("#define EM_POSFROMCHAR 0x00D6")]
        public const int EM_POSFROMCHAR = 0x00D6;

        [NativeTypeName("#define EM_CHARFROMPOS 0x00D7")]
        public const int EM_CHARFROMPOS = 0x00D7;

        [NativeTypeName("#define EM_SETIMESTATUS 0x00D8")]
        public const int EM_SETIMESTATUS = 0x00D8;

        [NativeTypeName("#define EM_GETIMESTATUS 0x00D9")]
        public const int EM_GETIMESTATUS = 0x00D9;

        [NativeTypeName("#define EM_ENABLEFEATURE 0x00DA")]
        public const int EM_ENABLEFEATURE = 0x00DA;

        [NativeTypeName("#define WB_LEFT 0")]
        public const int WB_LEFT = 0;

        [NativeTypeName("#define WB_RIGHT 1")]
        public const int WB_RIGHT = 1;

        [NativeTypeName("#define WB_ISDELIMITER 2")]
        public const int WB_ISDELIMITER = 2;

        [NativeTypeName("#define BS_PUSHBUTTON 0x00000000L")]
        public const int BS_PUSHBUTTON = 0x00000000;

        [NativeTypeName("#define BS_DEFPUSHBUTTON 0x00000001L")]
        public const int BS_DEFPUSHBUTTON = 0x00000001;

        [NativeTypeName("#define BS_CHECKBOX 0x00000002L")]
        public const int BS_CHECKBOX = 0x00000002;

        [NativeTypeName("#define BS_AUTOCHECKBOX 0x00000003L")]
        public const int BS_AUTOCHECKBOX = 0x00000003;

        [NativeTypeName("#define BS_RADIOBUTTON 0x00000004L")]
        public const int BS_RADIOBUTTON = 0x00000004;

        [NativeTypeName("#define BS_3STATE 0x00000005L")]
        public const int BS_3STATE = 0x00000005;

        [NativeTypeName("#define BS_AUTO3STATE 0x00000006L")]
        public const int BS_AUTO3STATE = 0x00000006;

        [NativeTypeName("#define BS_GROUPBOX 0x00000007L")]
        public const int BS_GROUPBOX = 0x00000007;

        [NativeTypeName("#define BS_USERBUTTON 0x00000008L")]
        public const int BS_USERBUTTON = 0x00000008;

        [NativeTypeName("#define BS_AUTORADIOBUTTON 0x00000009L")]
        public const int BS_AUTORADIOBUTTON = 0x00000009;

        [NativeTypeName("#define BS_PUSHBOX 0x0000000AL")]
        public const int BS_PUSHBOX = 0x0000000A;

        [NativeTypeName("#define BS_OWNERDRAW 0x0000000BL")]
        public const int BS_OWNERDRAW = 0x0000000B;

        [NativeTypeName("#define BS_TYPEMASK 0x0000000FL")]
        public const int BS_TYPEMASK = 0x0000000F;

        [NativeTypeName("#define BS_LEFTTEXT 0x00000020L")]
        public const int BS_LEFTTEXT = 0x00000020;

        [NativeTypeName("#define BS_TEXT 0x00000000L")]
        public const int BS_TEXT = 0x00000000;

        [NativeTypeName("#define BS_ICON 0x00000040L")]
        public const int BS_ICON = 0x00000040;

        [NativeTypeName("#define BS_BITMAP 0x00000080L")]
        public const int BS_BITMAP = 0x00000080;

        [NativeTypeName("#define BS_LEFT 0x00000100L")]
        public const int BS_LEFT = 0x00000100;

        [NativeTypeName("#define BS_RIGHT 0x00000200L")]
        public const int BS_RIGHT = 0x00000200;

        [NativeTypeName("#define BS_CENTER 0x00000300L")]
        public const int BS_CENTER = 0x00000300;

        [NativeTypeName("#define BS_TOP 0x00000400L")]
        public const int BS_TOP = 0x00000400;

        [NativeTypeName("#define BS_BOTTOM 0x00000800L")]
        public const int BS_BOTTOM = 0x00000800;

        [NativeTypeName("#define BS_VCENTER 0x00000C00L")]
        public const int BS_VCENTER = 0x00000C00;

        [NativeTypeName("#define BS_PUSHLIKE 0x00001000L")]
        public const int BS_PUSHLIKE = 0x00001000;

        [NativeTypeName("#define BS_MULTILINE 0x00002000L")]
        public const int BS_MULTILINE = 0x00002000;

        [NativeTypeName("#define BS_NOTIFY 0x00004000L")]
        public const int BS_NOTIFY = 0x00004000;

        [NativeTypeName("#define BS_FLAT 0x00008000L")]
        public const int BS_FLAT = 0x00008000;

        [NativeTypeName("#define BS_RIGHTBUTTON BS_LEFTTEXT")]
        public const int BS_RIGHTBUTTON = 0x00000020;

        [NativeTypeName("#define BN_CLICKED 0")]
        public const int BN_CLICKED = 0;

        [NativeTypeName("#define BN_PAINT 1")]
        public const int BN_PAINT = 1;

        [NativeTypeName("#define BN_HILITE 2")]
        public const int BN_HILITE = 2;

        [NativeTypeName("#define BN_UNHILITE 3")]
        public const int BN_UNHILITE = 3;

        [NativeTypeName("#define BN_DISABLE 4")]
        public const int BN_DISABLE = 4;

        [NativeTypeName("#define BN_DOUBLECLICKED 5")]
        public const int BN_DOUBLECLICKED = 5;

        [NativeTypeName("#define BN_PUSHED BN_HILITE")]
        public const int BN_PUSHED = 2;

        [NativeTypeName("#define BN_UNPUSHED BN_UNHILITE")]
        public const int BN_UNPUSHED = 3;

        [NativeTypeName("#define BN_DBLCLK BN_DOUBLECLICKED")]
        public const int BN_DBLCLK = 5;

        [NativeTypeName("#define BN_SETFOCUS 6")]
        public const int BN_SETFOCUS = 6;

        [NativeTypeName("#define BN_KILLFOCUS 7")]
        public const int BN_KILLFOCUS = 7;

        [NativeTypeName("#define BM_GETCHECK 0x00F0")]
        public const int BM_GETCHECK = 0x00F0;

        [NativeTypeName("#define BM_SETCHECK 0x00F1")]
        public const int BM_SETCHECK = 0x00F1;

        [NativeTypeName("#define BM_GETSTATE 0x00F2")]
        public const int BM_GETSTATE = 0x00F2;

        [NativeTypeName("#define BM_SETSTATE 0x00F3")]
        public const int BM_SETSTATE = 0x00F3;

        [NativeTypeName("#define BM_SETSTYLE 0x00F4")]
        public const int BM_SETSTYLE = 0x00F4;

        [NativeTypeName("#define BM_CLICK 0x00F5")]
        public const int BM_CLICK = 0x00F5;

        [NativeTypeName("#define BM_GETIMAGE 0x00F6")]
        public const int BM_GETIMAGE = 0x00F6;

        [NativeTypeName("#define BM_SETIMAGE 0x00F7")]
        public const int BM_SETIMAGE = 0x00F7;

        [NativeTypeName("#define BM_SETDONTCLICK 0x00F8")]
        public const int BM_SETDONTCLICK = 0x00F8;

        [NativeTypeName("#define BST_UNCHECKED 0x0000")]
        public const int BST_UNCHECKED = 0x0000;

        [NativeTypeName("#define BST_CHECKED 0x0001")]
        public const int BST_CHECKED = 0x0001;

        [NativeTypeName("#define BST_INDETERMINATE 0x0002")]
        public const int BST_INDETERMINATE = 0x0002;

        [NativeTypeName("#define BST_PUSHED 0x0004")]
        public const int BST_PUSHED = 0x0004;

        [NativeTypeName("#define BST_FOCUS 0x0008")]
        public const int BST_FOCUS = 0x0008;

        [NativeTypeName("#define SS_LEFT 0x00000000L")]
        public const int SS_LEFT = 0x00000000;

        [NativeTypeName("#define SS_CENTER 0x00000001L")]
        public const int SS_CENTER = 0x00000001;

        [NativeTypeName("#define SS_RIGHT 0x00000002L")]
        public const int SS_RIGHT = 0x00000002;

        [NativeTypeName("#define SS_ICON 0x00000003L")]
        public const int SS_ICON = 0x00000003;

        [NativeTypeName("#define SS_BLACKRECT 0x00000004L")]
        public const int SS_BLACKRECT = 0x00000004;

        [NativeTypeName("#define SS_GRAYRECT 0x00000005L")]
        public const int SS_GRAYRECT = 0x00000005;

        [NativeTypeName("#define SS_WHITERECT 0x00000006L")]
        public const int SS_WHITERECT = 0x00000006;

        [NativeTypeName("#define SS_BLACKFRAME 0x00000007L")]
        public const int SS_BLACKFRAME = 0x00000007;

        [NativeTypeName("#define SS_GRAYFRAME 0x00000008L")]
        public const int SS_GRAYFRAME = 0x00000008;

        [NativeTypeName("#define SS_WHITEFRAME 0x00000009L")]
        public const int SS_WHITEFRAME = 0x00000009;

        [NativeTypeName("#define SS_USERITEM 0x0000000AL")]
        public const int SS_USERITEM = 0x0000000A;

        [NativeTypeName("#define SS_SIMPLE 0x0000000BL")]
        public const int SS_SIMPLE = 0x0000000B;

        [NativeTypeName("#define SS_LEFTNOWORDWRAP 0x0000000CL")]
        public const int SS_LEFTNOWORDWRAP = 0x0000000C;

        [NativeTypeName("#define SS_OWNERDRAW 0x0000000DL")]
        public const int SS_OWNERDRAW = 0x0000000D;

        [NativeTypeName("#define SS_BITMAP 0x0000000EL")]
        public const int SS_BITMAP = 0x0000000E;

        [NativeTypeName("#define SS_ENHMETAFILE 0x0000000FL")]
        public const int SS_ENHMETAFILE = 0x0000000F;

        [NativeTypeName("#define SS_ETCHEDHORZ 0x00000010L")]
        public const int SS_ETCHEDHORZ = 0x00000010;

        [NativeTypeName("#define SS_ETCHEDVERT 0x00000011L")]
        public const int SS_ETCHEDVERT = 0x00000011;

        [NativeTypeName("#define SS_ETCHEDFRAME 0x00000012L")]
        public const int SS_ETCHEDFRAME = 0x00000012;

        [NativeTypeName("#define SS_TYPEMASK 0x0000001FL")]
        public const int SS_TYPEMASK = 0x0000001F;

        [NativeTypeName("#define SS_REALSIZECONTROL 0x00000040L")]
        public const int SS_REALSIZECONTROL = 0x00000040;

        [NativeTypeName("#define SS_NOPREFIX 0x00000080L")]
        public const int SS_NOPREFIX = 0x00000080;

        [NativeTypeName("#define SS_NOTIFY 0x00000100L")]
        public const int SS_NOTIFY = 0x00000100;

        [NativeTypeName("#define SS_CENTERIMAGE 0x00000200L")]
        public const int SS_CENTERIMAGE = 0x00000200;

        [NativeTypeName("#define SS_RIGHTJUST 0x00000400L")]
        public const int SS_RIGHTJUST = 0x00000400;

        [NativeTypeName("#define SS_REALSIZEIMAGE 0x00000800L")]
        public const int SS_REALSIZEIMAGE = 0x00000800;

        [NativeTypeName("#define SS_SUNKEN 0x00001000L")]
        public const int SS_SUNKEN = 0x00001000;

        [NativeTypeName("#define SS_EDITCONTROL 0x00002000L")]
        public const int SS_EDITCONTROL = 0x00002000;

        [NativeTypeName("#define SS_ENDELLIPSIS 0x00004000L")]
        public const int SS_ENDELLIPSIS = 0x00004000;

        [NativeTypeName("#define SS_PATHELLIPSIS 0x00008000L")]
        public const int SS_PATHELLIPSIS = 0x00008000;

        [NativeTypeName("#define SS_WORDELLIPSIS 0x0000C000L")]
        public const int SS_WORDELLIPSIS = 0x0000C000;

        [NativeTypeName("#define SS_ELLIPSISMASK 0x0000C000L")]
        public const int SS_ELLIPSISMASK = 0x0000C000;

        [NativeTypeName("#define STM_SETICON 0x0170")]
        public const int STM_SETICON = 0x0170;

        [NativeTypeName("#define STM_GETICON 0x0171")]
        public const int STM_GETICON = 0x0171;

        [NativeTypeName("#define STM_SETIMAGE 0x0172")]
        public const int STM_SETIMAGE = 0x0172;

        [NativeTypeName("#define STM_GETIMAGE 0x0173")]
        public const int STM_GETIMAGE = 0x0173;

        [NativeTypeName("#define STN_CLICKED 0")]
        public const int STN_CLICKED = 0;

        [NativeTypeName("#define STN_DBLCLK 1")]
        public const int STN_DBLCLK = 1;

        [NativeTypeName("#define STN_ENABLE 2")]
        public const int STN_ENABLE = 2;

        [NativeTypeName("#define STN_DISABLE 3")]
        public const int STN_DISABLE = 3;

        [NativeTypeName("#define STM_MSGMAX 0x0174")]
        public const int STM_MSGMAX = 0x0174;

        [NativeTypeName("#define WC_DIALOG (MAKEINTATOM(0x8002))")]
        public static readonly ushort* WC_DIALOG = ((ushort*)((nuint)((ushort)(0x8002))));

        [NativeTypeName("#define DWL_MSGRESULT 0")]
        public const int DWL_MSGRESULT = 0;

        [NativeTypeName("#define DWL_DLGPROC 4")]
        public const int DWL_DLGPROC = 4;

        [NativeTypeName("#define DWL_USER 8")]
        public const int DWL_USER = 8;

        [NativeTypeName("#define DWLP_MSGRESULT 0")]
        public const int DWLP_MSGRESULT = 0;

        [NativeTypeName("#define DWLP_DLGPROC DWLP_MSGRESULT + sizeof(LRESULT)")]
        public static readonly uint DWLP_DLGPROC = unchecked(0 + (uint)(sizeof(nint)));

        [NativeTypeName("#define DWLP_USER DWLP_DLGPROC + sizeof(DLGPROC)")]
        public static readonly uint DWLP_USER = unchecked(0 + (uint)(sizeof(nint)) + (uint)(sizeof(delegate* unmanaged<IntPtr, uint, nuint, nint, nint>)));

        [NativeTypeName("#define IsDialogMessage IsDialogMessageW")]
        public static readonly delegate*<IntPtr, MSG*, int> IsDialogMessage = &IsDialogMessageW;

        [NativeTypeName("#define DlgDirList DlgDirListW")]
        public static readonly delegate*<IntPtr, ushort*, int, int, uint, int> DlgDirList = &DlgDirListW;

        [NativeTypeName("#define DDL_READWRITE 0x0000")]
        public const int DDL_READWRITE = 0x0000;

        [NativeTypeName("#define DDL_READONLY 0x0001")]
        public const int DDL_READONLY = 0x0001;

        [NativeTypeName("#define DDL_HIDDEN 0x0002")]
        public const int DDL_HIDDEN = 0x0002;

        [NativeTypeName("#define DDL_SYSTEM 0x0004")]
        public const int DDL_SYSTEM = 0x0004;

        [NativeTypeName("#define DDL_DIRECTORY 0x0010")]
        public const int DDL_DIRECTORY = 0x0010;

        [NativeTypeName("#define DDL_ARCHIVE 0x0020")]
        public const int DDL_ARCHIVE = 0x0020;

        [NativeTypeName("#define DDL_POSTMSGS 0x2000")]
        public const int DDL_POSTMSGS = 0x2000;

        [NativeTypeName("#define DDL_DRIVES 0x4000")]
        public const int DDL_DRIVES = 0x4000;

        [NativeTypeName("#define DDL_EXCLUSIVE 0x8000")]
        public const int DDL_EXCLUSIVE = 0x8000;

        [NativeTypeName("#define DlgDirSelectEx DlgDirSelectExW")]
        public static readonly delegate*<IntPtr, ushort*, int, int, int> DlgDirSelectEx = &DlgDirSelectExW;

        [NativeTypeName("#define DlgDirListComboBox DlgDirListComboBoxW")]
        public static readonly delegate*<IntPtr, ushort*, int, int, uint, int> DlgDirListComboBox = &DlgDirListComboBoxW;

        [NativeTypeName("#define DlgDirSelectComboBoxEx DlgDirSelectComboBoxExW")]
        public static readonly delegate*<IntPtr, ushort*, int, int, int> DlgDirSelectComboBoxEx = &DlgDirSelectComboBoxExW;

        [NativeTypeName("#define DS_ABSALIGN 0x01L")]
        public const int DS_ABSALIGN = 0x01;

        [NativeTypeName("#define DS_SYSMODAL 0x02L")]
        public const int DS_SYSMODAL = 0x02;

        [NativeTypeName("#define DS_LOCALEDIT 0x20L")]
        public const int DS_LOCALEDIT = 0x20;

        [NativeTypeName("#define DS_SETFONT 0x40L")]
        public const int DS_SETFONT = 0x40;

        [NativeTypeName("#define DS_MODALFRAME 0x80L")]
        public const int DS_MODALFRAME = 0x80;

        [NativeTypeName("#define DS_NOIDLEMSG 0x100L")]
        public const int DS_NOIDLEMSG = 0x100;

        [NativeTypeName("#define DS_SETFOREGROUND 0x200L")]
        public const int DS_SETFOREGROUND = 0x200;

        [NativeTypeName("#define DS_3DLOOK 0x0004L")]
        public const int DS_3DLOOK = 0x0004;

        [NativeTypeName("#define DS_FIXEDSYS 0x0008L")]
        public const int DS_FIXEDSYS = 0x0008;

        [NativeTypeName("#define DS_NOFAILCREATE 0x0010L")]
        public const int DS_NOFAILCREATE = 0x0010;

        [NativeTypeName("#define DS_CONTROL 0x0400L")]
        public const int DS_CONTROL = 0x0400;

        [NativeTypeName("#define DS_CENTER 0x0800L")]
        public const int DS_CENTER = 0x0800;

        [NativeTypeName("#define DS_CENTERMOUSE 0x1000L")]
        public const int DS_CENTERMOUSE = 0x1000;

        [NativeTypeName("#define DS_CONTEXTHELP 0x2000L")]
        public const int DS_CONTEXTHELP = 0x2000;

        [NativeTypeName("#define DS_SHELLFONT (DS_SETFONT | DS_FIXEDSYS)")]
        public const int DS_SHELLFONT = (0x40 | 0x0008);

        [NativeTypeName("#define DM_GETDEFID (WM_USER+0)")]
        public const int DM_GETDEFID = (0x0400 + 0);

        [NativeTypeName("#define DM_SETDEFID (WM_USER+1)")]
        public const int DM_SETDEFID = (0x0400 + 1);

        [NativeTypeName("#define DM_REPOSITION (WM_USER+2)")]
        public const int DM_REPOSITION = (0x0400 + 2);

        [NativeTypeName("#define DC_HASDEFID 0x534B")]
        public const int DC_HASDEFID = 0x534B;

        [NativeTypeName("#define DLGC_WANTARROWS 0x0001")]
        public const int DLGC_WANTARROWS = 0x0001;

        [NativeTypeName("#define DLGC_WANTTAB 0x0002")]
        public const int DLGC_WANTTAB = 0x0002;

        [NativeTypeName("#define DLGC_WANTALLKEYS 0x0004")]
        public const int DLGC_WANTALLKEYS = 0x0004;

        [NativeTypeName("#define DLGC_WANTMESSAGE 0x0004")]
        public const int DLGC_WANTMESSAGE = 0x0004;

        [NativeTypeName("#define DLGC_HASSETSEL 0x0008")]
        public const int DLGC_HASSETSEL = 0x0008;

        [NativeTypeName("#define DLGC_DEFPUSHBUTTON 0x0010")]
        public const int DLGC_DEFPUSHBUTTON = 0x0010;

        [NativeTypeName("#define DLGC_UNDEFPUSHBUTTON 0x0020")]
        public const int DLGC_UNDEFPUSHBUTTON = 0x0020;

        [NativeTypeName("#define DLGC_RADIOBUTTON 0x0040")]
        public const int DLGC_RADIOBUTTON = 0x0040;

        [NativeTypeName("#define DLGC_WANTCHARS 0x0080")]
        public const int DLGC_WANTCHARS = 0x0080;

        [NativeTypeName("#define DLGC_STATIC 0x0100")]
        public const int DLGC_STATIC = 0x0100;

        [NativeTypeName("#define DLGC_BUTTON 0x2000")]
        public const int DLGC_BUTTON = 0x2000;

        [NativeTypeName("#define LB_CTLCODE 0L")]
        public const int LB_CTLCODE = 0;

        [NativeTypeName("#define LB_OKAY 0")]
        public const int LB_OKAY = 0;

        [NativeTypeName("#define LB_ERR (-1)")]
        public const int LB_ERR = (-1);

        [NativeTypeName("#define LB_ERRSPACE (-2)")]
        public const int LB_ERRSPACE = (-2);

        [NativeTypeName("#define LBN_ERRSPACE (-2)")]
        public const int LBN_ERRSPACE = (-2);

        [NativeTypeName("#define LBN_SELCHANGE 1")]
        public const int LBN_SELCHANGE = 1;

        [NativeTypeName("#define LBN_DBLCLK 2")]
        public const int LBN_DBLCLK = 2;

        [NativeTypeName("#define LBN_SELCANCEL 3")]
        public const int LBN_SELCANCEL = 3;

        [NativeTypeName("#define LBN_SETFOCUS 4")]
        public const int LBN_SETFOCUS = 4;

        [NativeTypeName("#define LBN_KILLFOCUS 5")]
        public const int LBN_KILLFOCUS = 5;

        [NativeTypeName("#define LB_ADDSTRING 0x0180")]
        public const int LB_ADDSTRING = 0x0180;

        [NativeTypeName("#define LB_INSERTSTRING 0x0181")]
        public const int LB_INSERTSTRING = 0x0181;

        [NativeTypeName("#define LB_DELETESTRING 0x0182")]
        public const int LB_DELETESTRING = 0x0182;

        [NativeTypeName("#define LB_SELITEMRANGEEX 0x0183")]
        public const int LB_SELITEMRANGEEX = 0x0183;

        [NativeTypeName("#define LB_RESETCONTENT 0x0184")]
        public const int LB_RESETCONTENT = 0x0184;

        [NativeTypeName("#define LB_SETSEL 0x0185")]
        public const int LB_SETSEL = 0x0185;

        [NativeTypeName("#define LB_SETCURSEL 0x0186")]
        public const int LB_SETCURSEL = 0x0186;

        [NativeTypeName("#define LB_GETSEL 0x0187")]
        public const int LB_GETSEL = 0x0187;

        [NativeTypeName("#define LB_GETCURSEL 0x0188")]
        public const int LB_GETCURSEL = 0x0188;

        [NativeTypeName("#define LB_GETTEXT 0x0189")]
        public const int LB_GETTEXT = 0x0189;

        [NativeTypeName("#define LB_GETTEXTLEN 0x018A")]
        public const int LB_GETTEXTLEN = 0x018A;

        [NativeTypeName("#define LB_GETCOUNT 0x018B")]
        public const int LB_GETCOUNT = 0x018B;

        [NativeTypeName("#define LB_SELECTSTRING 0x018C")]
        public const int LB_SELECTSTRING = 0x018C;

        [NativeTypeName("#define LB_DIR 0x018D")]
        public const int LB_DIR = 0x018D;

        [NativeTypeName("#define LB_GETTOPINDEX 0x018E")]
        public const int LB_GETTOPINDEX = 0x018E;

        [NativeTypeName("#define LB_FINDSTRING 0x018F")]
        public const int LB_FINDSTRING = 0x018F;

        [NativeTypeName("#define LB_GETSELCOUNT 0x0190")]
        public const int LB_GETSELCOUNT = 0x0190;

        [NativeTypeName("#define LB_GETSELITEMS 0x0191")]
        public const int LB_GETSELITEMS = 0x0191;

        [NativeTypeName("#define LB_SETTABSTOPS 0x0192")]
        public const int LB_SETTABSTOPS = 0x0192;

        [NativeTypeName("#define LB_GETHORIZONTALEXTENT 0x0193")]
        public const int LB_GETHORIZONTALEXTENT = 0x0193;

        [NativeTypeName("#define LB_SETHORIZONTALEXTENT 0x0194")]
        public const int LB_SETHORIZONTALEXTENT = 0x0194;

        [NativeTypeName("#define LB_SETCOLUMNWIDTH 0x0195")]
        public const int LB_SETCOLUMNWIDTH = 0x0195;

        [NativeTypeName("#define LB_ADDFILE 0x0196")]
        public const int LB_ADDFILE = 0x0196;

        [NativeTypeName("#define LB_SETTOPINDEX 0x0197")]
        public const int LB_SETTOPINDEX = 0x0197;

        [NativeTypeName("#define LB_GETITEMRECT 0x0198")]
        public const int LB_GETITEMRECT = 0x0198;

        [NativeTypeName("#define LB_GETITEMDATA 0x0199")]
        public const int LB_GETITEMDATA = 0x0199;

        [NativeTypeName("#define LB_SETITEMDATA 0x019A")]
        public const int LB_SETITEMDATA = 0x019A;

        [NativeTypeName("#define LB_SELITEMRANGE 0x019B")]
        public const int LB_SELITEMRANGE = 0x019B;

        [NativeTypeName("#define LB_SETANCHORINDEX 0x019C")]
        public const int LB_SETANCHORINDEX = 0x019C;

        [NativeTypeName("#define LB_GETANCHORINDEX 0x019D")]
        public const int LB_GETANCHORINDEX = 0x019D;

        [NativeTypeName("#define LB_SETCARETINDEX 0x019E")]
        public const int LB_SETCARETINDEX = 0x019E;

        [NativeTypeName("#define LB_GETCARETINDEX 0x019F")]
        public const int LB_GETCARETINDEX = 0x019F;

        [NativeTypeName("#define LB_SETITEMHEIGHT 0x01A0")]
        public const int LB_SETITEMHEIGHT = 0x01A0;

        [NativeTypeName("#define LB_GETITEMHEIGHT 0x01A1")]
        public const int LB_GETITEMHEIGHT = 0x01A1;

        [NativeTypeName("#define LB_FINDSTRINGEXACT 0x01A2")]
        public const int LB_FINDSTRINGEXACT = 0x01A2;

        [NativeTypeName("#define LB_SETLOCALE 0x01A5")]
        public const int LB_SETLOCALE = 0x01A5;

        [NativeTypeName("#define LB_GETLOCALE 0x01A6")]
        public const int LB_GETLOCALE = 0x01A6;

        [NativeTypeName("#define LB_SETCOUNT 0x01A7")]
        public const int LB_SETCOUNT = 0x01A7;

        [NativeTypeName("#define LB_INITSTORAGE 0x01A8")]
        public const int LB_INITSTORAGE = 0x01A8;

        [NativeTypeName("#define LB_ITEMFROMPOINT 0x01A9")]
        public const int LB_ITEMFROMPOINT = 0x01A9;

        [NativeTypeName("#define LB_GETLISTBOXINFO 0x01B2")]
        public const int LB_GETLISTBOXINFO = 0x01B2;

        [NativeTypeName("#define LB_MSGMAX 0x01B3")]
        public const int LB_MSGMAX = 0x01B3;

        [NativeTypeName("#define LBS_NOTIFY 0x0001L")]
        public const int LBS_NOTIFY = 0x0001;

        [NativeTypeName("#define LBS_SORT 0x0002L")]
        public const int LBS_SORT = 0x0002;

        [NativeTypeName("#define LBS_NOREDRAW 0x0004L")]
        public const int LBS_NOREDRAW = 0x0004;

        [NativeTypeName("#define LBS_MULTIPLESEL 0x0008L")]
        public const int LBS_MULTIPLESEL = 0x0008;

        [NativeTypeName("#define LBS_OWNERDRAWFIXED 0x0010L")]
        public const int LBS_OWNERDRAWFIXED = 0x0010;

        [NativeTypeName("#define LBS_OWNERDRAWVARIABLE 0x0020L")]
        public const int LBS_OWNERDRAWVARIABLE = 0x0020;

        [NativeTypeName("#define LBS_HASSTRINGS 0x0040L")]
        public const int LBS_HASSTRINGS = 0x0040;

        [NativeTypeName("#define LBS_USETABSTOPS 0x0080L")]
        public const int LBS_USETABSTOPS = 0x0080;

        [NativeTypeName("#define LBS_NOINTEGRALHEIGHT 0x0100L")]
        public const int LBS_NOINTEGRALHEIGHT = 0x0100;

        [NativeTypeName("#define LBS_MULTICOLUMN 0x0200L")]
        public const int LBS_MULTICOLUMN = 0x0200;

        [NativeTypeName("#define LBS_WANTKEYBOARDINPUT 0x0400L")]
        public const int LBS_WANTKEYBOARDINPUT = 0x0400;

        [NativeTypeName("#define LBS_EXTENDEDSEL 0x0800L")]
        public const int LBS_EXTENDEDSEL = 0x0800;

        [NativeTypeName("#define LBS_DISABLENOSCROLL 0x1000L")]
        public const int LBS_DISABLENOSCROLL = 0x1000;

        [NativeTypeName("#define LBS_NODATA 0x2000L")]
        public const int LBS_NODATA = 0x2000;

        [NativeTypeName("#define LBS_NOSEL 0x4000L")]
        public const int LBS_NOSEL = 0x4000;

        [NativeTypeName("#define LBS_COMBOBOX 0x8000L")]
        public const int LBS_COMBOBOX = 0x8000;

        [NativeTypeName("#define LBS_STANDARD (LBS_NOTIFY | LBS_SORT | WS_VSCROLL | WS_BORDER)")]
        public const int LBS_STANDARD = (0x0001 | 0x0002 | 0x00200000 | 0x00800000);

        [NativeTypeName("#define CB_OKAY 0")]
        public const int CB_OKAY = 0;

        [NativeTypeName("#define CB_ERR (-1)")]
        public const int CB_ERR = (-1);

        [NativeTypeName("#define CB_ERRSPACE (-2)")]
        public const int CB_ERRSPACE = (-2);

        [NativeTypeName("#define CBN_ERRSPACE (-1)")]
        public const int CBN_ERRSPACE = (-1);

        [NativeTypeName("#define CBN_SELCHANGE 1")]
        public const int CBN_SELCHANGE = 1;

        [NativeTypeName("#define CBN_DBLCLK 2")]
        public const int CBN_DBLCLK = 2;

        [NativeTypeName("#define CBN_SETFOCUS 3")]
        public const int CBN_SETFOCUS = 3;

        [NativeTypeName("#define CBN_KILLFOCUS 4")]
        public const int CBN_KILLFOCUS = 4;

        [NativeTypeName("#define CBN_EDITCHANGE 5")]
        public const int CBN_EDITCHANGE = 5;

        [NativeTypeName("#define CBN_EDITUPDATE 6")]
        public const int CBN_EDITUPDATE = 6;

        [NativeTypeName("#define CBN_DROPDOWN 7")]
        public const int CBN_DROPDOWN = 7;

        [NativeTypeName("#define CBN_CLOSEUP 8")]
        public const int CBN_CLOSEUP = 8;

        [NativeTypeName("#define CBN_SELENDOK 9")]
        public const int CBN_SELENDOK = 9;

        [NativeTypeName("#define CBN_SELENDCANCEL 10")]
        public const int CBN_SELENDCANCEL = 10;

        [NativeTypeName("#define CBS_SIMPLE 0x0001L")]
        public const int CBS_SIMPLE = 0x0001;

        [NativeTypeName("#define CBS_DROPDOWN 0x0002L")]
        public const int CBS_DROPDOWN = 0x0002;

        [NativeTypeName("#define CBS_DROPDOWNLIST 0x0003L")]
        public const int CBS_DROPDOWNLIST = 0x0003;

        [NativeTypeName("#define CBS_OWNERDRAWFIXED 0x0010L")]
        public const int CBS_OWNERDRAWFIXED = 0x0010;

        [NativeTypeName("#define CBS_OWNERDRAWVARIABLE 0x0020L")]
        public const int CBS_OWNERDRAWVARIABLE = 0x0020;

        [NativeTypeName("#define CBS_AUTOHSCROLL 0x0040L")]
        public const int CBS_AUTOHSCROLL = 0x0040;

        [NativeTypeName("#define CBS_OEMCONVERT 0x0080L")]
        public const int CBS_OEMCONVERT = 0x0080;

        [NativeTypeName("#define CBS_SORT 0x0100L")]
        public const int CBS_SORT = 0x0100;

        [NativeTypeName("#define CBS_HASSTRINGS 0x0200L")]
        public const int CBS_HASSTRINGS = 0x0200;

        [NativeTypeName("#define CBS_NOINTEGRALHEIGHT 0x0400L")]
        public const int CBS_NOINTEGRALHEIGHT = 0x0400;

        [NativeTypeName("#define CBS_DISABLENOSCROLL 0x0800L")]
        public const int CBS_DISABLENOSCROLL = 0x0800;

        [NativeTypeName("#define CBS_UPPERCASE 0x2000L")]
        public const int CBS_UPPERCASE = 0x2000;

        [NativeTypeName("#define CBS_LOWERCASE 0x4000L")]
        public const int CBS_LOWERCASE = 0x4000;

        [NativeTypeName("#define CB_GETEDITSEL 0x0140")]
        public const int CB_GETEDITSEL = 0x0140;

        [NativeTypeName("#define CB_LIMITTEXT 0x0141")]
        public const int CB_LIMITTEXT = 0x0141;

        [NativeTypeName("#define CB_SETEDITSEL 0x0142")]
        public const int CB_SETEDITSEL = 0x0142;

        [NativeTypeName("#define CB_ADDSTRING 0x0143")]
        public const int CB_ADDSTRING = 0x0143;

        [NativeTypeName("#define CB_DELETESTRING 0x0144")]
        public const int CB_DELETESTRING = 0x0144;

        [NativeTypeName("#define CB_DIR 0x0145")]
        public const int CB_DIR = 0x0145;

        [NativeTypeName("#define CB_GETCOUNT 0x0146")]
        public const int CB_GETCOUNT = 0x0146;

        [NativeTypeName("#define CB_GETCURSEL 0x0147")]
        public const int CB_GETCURSEL = 0x0147;

        [NativeTypeName("#define CB_GETLBTEXT 0x0148")]
        public const int CB_GETLBTEXT = 0x0148;

        [NativeTypeName("#define CB_GETLBTEXTLEN 0x0149")]
        public const int CB_GETLBTEXTLEN = 0x0149;

        [NativeTypeName("#define CB_INSERTSTRING 0x014A")]
        public const int CB_INSERTSTRING = 0x014A;

        [NativeTypeName("#define CB_RESETCONTENT 0x014B")]
        public const int CB_RESETCONTENT = 0x014B;

        [NativeTypeName("#define CB_FINDSTRING 0x014C")]
        public const int CB_FINDSTRING = 0x014C;

        [NativeTypeName("#define CB_SELECTSTRING 0x014D")]
        public const int CB_SELECTSTRING = 0x014D;

        [NativeTypeName("#define CB_SETCURSEL 0x014E")]
        public const int CB_SETCURSEL = 0x014E;

        [NativeTypeName("#define CB_SHOWDROPDOWN 0x014F")]
        public const int CB_SHOWDROPDOWN = 0x014F;

        [NativeTypeName("#define CB_GETITEMDATA 0x0150")]
        public const int CB_GETITEMDATA = 0x0150;

        [NativeTypeName("#define CB_SETITEMDATA 0x0151")]
        public const int CB_SETITEMDATA = 0x0151;

        [NativeTypeName("#define CB_GETDROPPEDCONTROLRECT 0x0152")]
        public const int CB_GETDROPPEDCONTROLRECT = 0x0152;

        [NativeTypeName("#define CB_SETITEMHEIGHT 0x0153")]
        public const int CB_SETITEMHEIGHT = 0x0153;

        [NativeTypeName("#define CB_GETITEMHEIGHT 0x0154")]
        public const int CB_GETITEMHEIGHT = 0x0154;

        [NativeTypeName("#define CB_SETEXTENDEDUI 0x0155")]
        public const int CB_SETEXTENDEDUI = 0x0155;

        [NativeTypeName("#define CB_GETEXTENDEDUI 0x0156")]
        public const int CB_GETEXTENDEDUI = 0x0156;

        [NativeTypeName("#define CB_GETDROPPEDSTATE 0x0157")]
        public const int CB_GETDROPPEDSTATE = 0x0157;

        [NativeTypeName("#define CB_FINDSTRINGEXACT 0x0158")]
        public const int CB_FINDSTRINGEXACT = 0x0158;

        [NativeTypeName("#define CB_SETLOCALE 0x0159")]
        public const int CB_SETLOCALE = 0x0159;

        [NativeTypeName("#define CB_GETLOCALE 0x015A")]
        public const int CB_GETLOCALE = 0x015A;

        [NativeTypeName("#define CB_GETTOPINDEX 0x015b")]
        public const int CB_GETTOPINDEX = 0x015b;

        [NativeTypeName("#define CB_SETTOPINDEX 0x015c")]
        public const int CB_SETTOPINDEX = 0x015c;

        [NativeTypeName("#define CB_GETHORIZONTALEXTENT 0x015d")]
        public const int CB_GETHORIZONTALEXTENT = 0x015d;

        [NativeTypeName("#define CB_SETHORIZONTALEXTENT 0x015e")]
        public const int CB_SETHORIZONTALEXTENT = 0x015e;

        [NativeTypeName("#define CB_GETDROPPEDWIDTH 0x015f")]
        public const int CB_GETDROPPEDWIDTH = 0x015f;

        [NativeTypeName("#define CB_SETDROPPEDWIDTH 0x0160")]
        public const int CB_SETDROPPEDWIDTH = 0x0160;

        [NativeTypeName("#define CB_INITSTORAGE 0x0161")]
        public const int CB_INITSTORAGE = 0x0161;

        [NativeTypeName("#define CB_GETCOMBOBOXINFO 0x0164")]
        public const int CB_GETCOMBOBOXINFO = 0x0164;

        [NativeTypeName("#define CB_MSGMAX 0x0165")]
        public const int CB_MSGMAX = 0x0165;

        [NativeTypeName("#define SBS_HORZ 0x0000L")]
        public const int SBS_HORZ = 0x0000;

        [NativeTypeName("#define SBS_VERT 0x0001L")]
        public const int SBS_VERT = 0x0001;

        [NativeTypeName("#define SBS_TOPALIGN 0x0002L")]
        public const int SBS_TOPALIGN = 0x0002;

        [NativeTypeName("#define SBS_LEFTALIGN 0x0002L")]
        public const int SBS_LEFTALIGN = 0x0002;

        [NativeTypeName("#define SBS_BOTTOMALIGN 0x0004L")]
        public const int SBS_BOTTOMALIGN = 0x0004;

        [NativeTypeName("#define SBS_RIGHTALIGN 0x0004L")]
        public const int SBS_RIGHTALIGN = 0x0004;

        [NativeTypeName("#define SBS_SIZEBOXTOPLEFTALIGN 0x0002L")]
        public const int SBS_SIZEBOXTOPLEFTALIGN = 0x0002;

        [NativeTypeName("#define SBS_SIZEBOXBOTTOMRIGHTALIGN 0x0004L")]
        public const int SBS_SIZEBOXBOTTOMRIGHTALIGN = 0x0004;

        [NativeTypeName("#define SBS_SIZEBOX 0x0008L")]
        public const int SBS_SIZEBOX = 0x0008;

        [NativeTypeName("#define SBS_SIZEGRIP 0x0010L")]
        public const int SBS_SIZEGRIP = 0x0010;

        [NativeTypeName("#define SBM_SETPOS 0x00E0")]
        public const int SBM_SETPOS = 0x00E0;

        [NativeTypeName("#define SBM_GETPOS 0x00E1")]
        public const int SBM_GETPOS = 0x00E1;

        [NativeTypeName("#define SBM_SETRANGE 0x00E2")]
        public const int SBM_SETRANGE = 0x00E2;

        [NativeTypeName("#define SBM_SETRANGEREDRAW 0x00E6")]
        public const int SBM_SETRANGEREDRAW = 0x00E6;

        [NativeTypeName("#define SBM_GETRANGE 0x00E3")]
        public const int SBM_GETRANGE = 0x00E3;

        [NativeTypeName("#define SBM_ENABLE_ARROWS 0x00E4")]
        public const int SBM_ENABLE_ARROWS = 0x00E4;

        [NativeTypeName("#define SBM_SETSCROLLINFO 0x00E9")]
        public const int SBM_SETSCROLLINFO = 0x00E9;

        [NativeTypeName("#define SBM_GETSCROLLINFO 0x00EA")]
        public const int SBM_GETSCROLLINFO = 0x00EA;

        [NativeTypeName("#define SBM_GETSCROLLBARINFO 0x00EB")]
        public const int SBM_GETSCROLLBARINFO = 0x00EB;

        [NativeTypeName("#define SIF_RANGE 0x0001")]
        public const int SIF_RANGE = 0x0001;

        [NativeTypeName("#define SIF_PAGE 0x0002")]
        public const int SIF_PAGE = 0x0002;

        [NativeTypeName("#define SIF_POS 0x0004")]
        public const int SIF_POS = 0x0004;

        [NativeTypeName("#define SIF_DISABLENOSCROLL 0x0008")]
        public const int SIF_DISABLENOSCROLL = 0x0008;

        [NativeTypeName("#define SIF_TRACKPOS 0x0010")]
        public const int SIF_TRACKPOS = 0x0010;

        [NativeTypeName("#define SIF_ALL (SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS)")]
        public const int SIF_ALL = (0x0001 | 0x0002 | 0x0004 | 0x0010);

        [NativeTypeName("#define MDIS_ALLCHILDSTYLES 0x0001")]
        public const int MDIS_ALLCHILDSTYLES = 0x0001;

        [NativeTypeName("#define MDITILE_VERTICAL 0x0000")]
        public const int MDITILE_VERTICAL = 0x0000;

        [NativeTypeName("#define MDITILE_HORIZONTAL 0x0001")]
        public const int MDITILE_HORIZONTAL = 0x0001;

        [NativeTypeName("#define MDITILE_SKIPDISABLED 0x0002")]
        public const int MDITILE_SKIPDISABLED = 0x0002;

        [NativeTypeName("#define MDITILE_ZORDER 0x0004")]
        public const int MDITILE_ZORDER = 0x0004;

        [NativeTypeName("#define DefFrameProc DefFrameProcW")]
        public static readonly delegate*<IntPtr, IntPtr, uint, nuint, nint, nint> DefFrameProc = &DefFrameProcW;

        [NativeTypeName("#define DefMDIChildProc DefMDIChildProcW")]
        public static readonly delegate*<IntPtr, uint, nuint, nint, nint> DefMDIChildProc = &DefMDIChildProcW;

        [NativeTypeName("#define CreateMDIWindow CreateMDIWindowW")]
        public static readonly delegate*<ushort*, ushort*, uint, int, int, int, int, IntPtr, IntPtr, nint, IntPtr> CreateMDIWindow = &CreateMDIWindowW;

        [NativeTypeName("#define HELP_CONTEXT 0x0001L")]
        public const int HELP_CONTEXT = 0x0001;

        [NativeTypeName("#define HELP_QUIT 0x0002L")]
        public const int HELP_QUIT = 0x0002;

        [NativeTypeName("#define HELP_INDEX 0x0003L")]
        public const int HELP_INDEX = 0x0003;

        [NativeTypeName("#define HELP_CONTENTS 0x0003L")]
        public const int HELP_CONTENTS = 0x0003;

        [NativeTypeName("#define HELP_HELPONHELP 0x0004L")]
        public const int HELP_HELPONHELP = 0x0004;

        [NativeTypeName("#define HELP_SETINDEX 0x0005L")]
        public const int HELP_SETINDEX = 0x0005;

        [NativeTypeName("#define HELP_SETCONTENTS 0x0005L")]
        public const int HELP_SETCONTENTS = 0x0005;

        [NativeTypeName("#define HELP_CONTEXTPOPUP 0x0008L")]
        public const int HELP_CONTEXTPOPUP = 0x0008;

        [NativeTypeName("#define HELP_FORCEFILE 0x0009L")]
        public const int HELP_FORCEFILE = 0x0009;

        [NativeTypeName("#define HELP_KEY 0x0101L")]
        public const int HELP_KEY = 0x0101;

        [NativeTypeName("#define HELP_COMMAND 0x0102L")]
        public const int HELP_COMMAND = 0x0102;

        [NativeTypeName("#define HELP_PARTIALKEY 0x0105L")]
        public const int HELP_PARTIALKEY = 0x0105;

        [NativeTypeName("#define HELP_MULTIKEY 0x0201L")]
        public const int HELP_MULTIKEY = 0x0201;

        [NativeTypeName("#define HELP_SETWINPOS 0x0203L")]
        public const int HELP_SETWINPOS = 0x0203;

        [NativeTypeName("#define HELP_CONTEXTMENU 0x000a")]
        public const int HELP_CONTEXTMENU = 0x000a;

        [NativeTypeName("#define HELP_FINDER 0x000b")]
        public const int HELP_FINDER = 0x000b;

        [NativeTypeName("#define HELP_WM_HELP 0x000c")]
        public const int HELP_WM_HELP = 0x000c;

        [NativeTypeName("#define HELP_SETPOPUP_POS 0x000d")]
        public const int HELP_SETPOPUP_POS = 0x000d;

        [NativeTypeName("#define HELP_TCARD 0x8000")]
        public const int HELP_TCARD = 0x8000;

        [NativeTypeName("#define HELP_TCARD_DATA 0x0010")]
        public const int HELP_TCARD_DATA = 0x0010;

        [NativeTypeName("#define HELP_TCARD_OTHER_CALLER 0x0011")]
        public const int HELP_TCARD_OTHER_CALLER = 0x0011;

        [NativeTypeName("#define IDH_NO_HELP 28440")]
        public const int IDH_NO_HELP = 28440;

        [NativeTypeName("#define IDH_MISSING_CONTEXT 28441")]
        public const int IDH_MISSING_CONTEXT = 28441;

        [NativeTypeName("#define IDH_GENERIC_HELP_BUTTON 28442")]
        public const int IDH_GENERIC_HELP_BUTTON = 28442;

        [NativeTypeName("#define IDH_OK 28443")]
        public const int IDH_OK = 28443;

        [NativeTypeName("#define IDH_CANCEL 28444")]
        public const int IDH_CANCEL = 28444;

        [NativeTypeName("#define IDH_HELP 28445")]
        public const int IDH_HELP = 28445;

        [NativeTypeName("#define WinHelp WinHelpW")]
        public static readonly delegate*<IntPtr, ushort*, uint, nuint, int> WinHelp = &WinHelpW;

        [NativeTypeName("#define GR_GDIOBJECTS 0")]
        public const int GR_GDIOBJECTS = 0;

        [NativeTypeName("#define GR_USEROBJECTS 1")]
        public const int GR_USEROBJECTS = 1;

        [NativeTypeName("#define GR_GDIOBJECTS_PEAK 2")]
        public const int GR_GDIOBJECTS_PEAK = 2;

        [NativeTypeName("#define GR_USEROBJECTS_PEAK 4")]
        public const int GR_USEROBJECTS_PEAK = 4;

        [NativeTypeName("#define GR_GLOBAL ((HANDLE)-2)")]
        public static readonly IntPtr GR_GLOBAL = ((IntPtr)(-2));

        [NativeTypeName("#define FKF_FILTERKEYSON 0x00000001")]
        public const int FKF_FILTERKEYSON = 0x00000001;

        [NativeTypeName("#define FKF_AVAILABLE 0x00000002")]
        public const int FKF_AVAILABLE = 0x00000002;

        [NativeTypeName("#define FKF_HOTKEYACTIVE 0x00000004")]
        public const int FKF_HOTKEYACTIVE = 0x00000004;

        [NativeTypeName("#define FKF_CONFIRMHOTKEY 0x00000008")]
        public const int FKF_CONFIRMHOTKEY = 0x00000008;

        [NativeTypeName("#define FKF_HOTKEYSOUND 0x00000010")]
        public const int FKF_HOTKEYSOUND = 0x00000010;

        [NativeTypeName("#define FKF_INDICATOR 0x00000020")]
        public const int FKF_INDICATOR = 0x00000020;

        [NativeTypeName("#define FKF_CLICKON 0x00000040")]
        public const int FKF_CLICKON = 0x00000040;

        [NativeTypeName("#define SKF_STICKYKEYSON 0x00000001")]
        public const int SKF_STICKYKEYSON = 0x00000001;

        [NativeTypeName("#define SKF_AVAILABLE 0x00000002")]
        public const int SKF_AVAILABLE = 0x00000002;

        [NativeTypeName("#define SKF_HOTKEYACTIVE 0x00000004")]
        public const int SKF_HOTKEYACTIVE = 0x00000004;

        [NativeTypeName("#define SKF_CONFIRMHOTKEY 0x00000008")]
        public const int SKF_CONFIRMHOTKEY = 0x00000008;

        [NativeTypeName("#define SKF_HOTKEYSOUND 0x00000010")]
        public const int SKF_HOTKEYSOUND = 0x00000010;

        [NativeTypeName("#define SKF_INDICATOR 0x00000020")]
        public const int SKF_INDICATOR = 0x00000020;

        [NativeTypeName("#define SKF_AUDIBLEFEEDBACK 0x00000040")]
        public const int SKF_AUDIBLEFEEDBACK = 0x00000040;

        [NativeTypeName("#define SKF_TRISTATE 0x00000080")]
        public const int SKF_TRISTATE = 0x00000080;

        [NativeTypeName("#define SKF_TWOKEYSOFF 0x00000100")]
        public const int SKF_TWOKEYSOFF = 0x00000100;

        [NativeTypeName("#define SKF_LALTLATCHED 0x10000000")]
        public const int SKF_LALTLATCHED = 0x10000000;

        [NativeTypeName("#define SKF_LCTLLATCHED 0x04000000")]
        public const int SKF_LCTLLATCHED = 0x04000000;

        [NativeTypeName("#define SKF_LSHIFTLATCHED 0x01000000")]
        public const int SKF_LSHIFTLATCHED = 0x01000000;

        [NativeTypeName("#define SKF_RALTLATCHED 0x20000000")]
        public const int SKF_RALTLATCHED = 0x20000000;

        [NativeTypeName("#define SKF_RCTLLATCHED 0x08000000")]
        public const int SKF_RCTLLATCHED = 0x08000000;

        [NativeTypeName("#define SKF_RSHIFTLATCHED 0x02000000")]
        public const int SKF_RSHIFTLATCHED = 0x02000000;

        [NativeTypeName("#define SKF_LWINLATCHED 0x40000000")]
        public const int SKF_LWINLATCHED = 0x40000000;

        [NativeTypeName("#define SKF_RWINLATCHED 0x80000000")]
        public const uint SKF_RWINLATCHED = 0x80000000;

        [NativeTypeName("#define SKF_LALTLOCKED 0x00100000")]
        public const int SKF_LALTLOCKED = 0x00100000;

        [NativeTypeName("#define SKF_LCTLLOCKED 0x00040000")]
        public const int SKF_LCTLLOCKED = 0x00040000;

        [NativeTypeName("#define SKF_LSHIFTLOCKED 0x00010000")]
        public const int SKF_LSHIFTLOCKED = 0x00010000;

        [NativeTypeName("#define SKF_RALTLOCKED 0x00200000")]
        public const int SKF_RALTLOCKED = 0x00200000;

        [NativeTypeName("#define SKF_RCTLLOCKED 0x00080000")]
        public const int SKF_RCTLLOCKED = 0x00080000;

        [NativeTypeName("#define SKF_RSHIFTLOCKED 0x00020000")]
        public const int SKF_RSHIFTLOCKED = 0x00020000;

        [NativeTypeName("#define SKF_LWINLOCKED 0x00400000")]
        public const int SKF_LWINLOCKED = 0x00400000;

        [NativeTypeName("#define SKF_RWINLOCKED 0x00800000")]
        public const int SKF_RWINLOCKED = 0x00800000;

        [NativeTypeName("#define MKF_MOUSEKEYSON 0x00000001")]
        public const int MKF_MOUSEKEYSON = 0x00000001;

        [NativeTypeName("#define MKF_AVAILABLE 0x00000002")]
        public const int MKF_AVAILABLE = 0x00000002;

        [NativeTypeName("#define MKF_HOTKEYACTIVE 0x00000004")]
        public const int MKF_HOTKEYACTIVE = 0x00000004;

        [NativeTypeName("#define MKF_CONFIRMHOTKEY 0x00000008")]
        public const int MKF_CONFIRMHOTKEY = 0x00000008;

        [NativeTypeName("#define MKF_HOTKEYSOUND 0x00000010")]
        public const int MKF_HOTKEYSOUND = 0x00000010;

        [NativeTypeName("#define MKF_INDICATOR 0x00000020")]
        public const int MKF_INDICATOR = 0x00000020;

        [NativeTypeName("#define MKF_MODIFIERS 0x00000040")]
        public const int MKF_MODIFIERS = 0x00000040;

        [NativeTypeName("#define MKF_REPLACENUMBERS 0x00000080")]
        public const int MKF_REPLACENUMBERS = 0x00000080;

        [NativeTypeName("#define MKF_LEFTBUTTONSEL 0x10000000")]
        public const int MKF_LEFTBUTTONSEL = 0x10000000;

        [NativeTypeName("#define MKF_RIGHTBUTTONSEL 0x20000000")]
        public const int MKF_RIGHTBUTTONSEL = 0x20000000;

        [NativeTypeName("#define MKF_LEFTBUTTONDOWN 0x01000000")]
        public const int MKF_LEFTBUTTONDOWN = 0x01000000;

        [NativeTypeName("#define MKF_RIGHTBUTTONDOWN 0x02000000")]
        public const int MKF_RIGHTBUTTONDOWN = 0x02000000;

        [NativeTypeName("#define MKF_MOUSEMODE 0x80000000")]
        public const uint MKF_MOUSEMODE = 0x80000000;

        [NativeTypeName("#define ATF_TIMEOUTON 0x00000001")]
        public const int ATF_TIMEOUTON = 0x00000001;

        [NativeTypeName("#define ATF_ONOFFFEEDBACK 0x00000002")]
        public const int ATF_ONOFFFEEDBACK = 0x00000002;

        [NativeTypeName("#define SSGF_NONE 0")]
        public const int SSGF_NONE = 0;

        [NativeTypeName("#define SSGF_DISPLAY 3")]
        public const int SSGF_DISPLAY = 3;

        [NativeTypeName("#define SSTF_NONE 0")]
        public const int SSTF_NONE = 0;

        [NativeTypeName("#define SSTF_CHARS 1")]
        public const int SSTF_CHARS = 1;

        [NativeTypeName("#define SSTF_BORDER 2")]
        public const int SSTF_BORDER = 2;

        [NativeTypeName("#define SSTF_DISPLAY 3")]
        public const int SSTF_DISPLAY = 3;

        [NativeTypeName("#define SSWF_NONE 0")]
        public const int SSWF_NONE = 0;

        [NativeTypeName("#define SSWF_TITLE 1")]
        public const int SSWF_TITLE = 1;

        [NativeTypeName("#define SSWF_WINDOW 2")]
        public const int SSWF_WINDOW = 2;

        [NativeTypeName("#define SSWF_DISPLAY 3")]
        public const int SSWF_DISPLAY = 3;

        [NativeTypeName("#define SSWF_CUSTOM 4")]
        public const int SSWF_CUSTOM = 4;

        [NativeTypeName("#define SSF_SOUNDSENTRYON 0x00000001")]
        public const int SSF_SOUNDSENTRYON = 0x00000001;

        [NativeTypeName("#define SSF_AVAILABLE 0x00000002")]
        public const int SSF_AVAILABLE = 0x00000002;

        [NativeTypeName("#define SSF_INDICATOR 0x00000004")]
        public const int SSF_INDICATOR = 0x00000004;

        [NativeTypeName("#define TKF_TOGGLEKEYSON 0x00000001")]
        public const int TKF_TOGGLEKEYSON = 0x00000001;

        [NativeTypeName("#define TKF_AVAILABLE 0x00000002")]
        public const int TKF_AVAILABLE = 0x00000002;

        [NativeTypeName("#define TKF_HOTKEYACTIVE 0x00000004")]
        public const int TKF_HOTKEYACTIVE = 0x00000004;

        [NativeTypeName("#define TKF_CONFIRMHOTKEY 0x00000008")]
        public const int TKF_CONFIRMHOTKEY = 0x00000008;

        [NativeTypeName("#define TKF_HOTKEYSOUND 0x00000010")]
        public const int TKF_HOTKEYSOUND = 0x00000010;

        [NativeTypeName("#define TKF_INDICATOR 0x00000020")]
        public const int TKF_INDICATOR = 0x00000020;

        [NativeTypeName("#define SLE_ERROR 0x00000001")]
        public const int SLE_ERROR = 0x00000001;

        [NativeTypeName("#define SLE_MINORERROR 0x00000002")]
        public const int SLE_MINORERROR = 0x00000002;

        [NativeTypeName("#define SLE_WARNING 0x00000003")]
        public const int SLE_WARNING = 0x00000003;

        [NativeTypeName("#define MONITOR_DEFAULTTONULL 0x00000000")]
        public const int MONITOR_DEFAULTTONULL = 0x00000000;

        [NativeTypeName("#define MONITOR_DEFAULTTOPRIMARY 0x00000001")]
        public const int MONITOR_DEFAULTTOPRIMARY = 0x00000001;

        [NativeTypeName("#define MONITOR_DEFAULTTONEAREST 0x00000002")]
        public const int MONITOR_DEFAULTTONEAREST = 0x00000002;

        [NativeTypeName("#define MONITORINFOF_PRIMARY 0x00000001")]
        public const int MONITORINFOF_PRIMARY = 0x00000001;

        [NativeTypeName("#define GetMonitorInfo GetMonitorInfoW")]
        public static readonly delegate*<IntPtr, MONITORINFO*, int> GetMonitorInfo = &GetMonitorInfoW;

        [NativeTypeName("#define WINEVENT_OUTOFCONTEXT 0x0000")]
        public const int WINEVENT_OUTOFCONTEXT = 0x0000;

        [NativeTypeName("#define WINEVENT_SKIPOWNTHREAD 0x0001")]
        public const int WINEVENT_SKIPOWNTHREAD = 0x0001;

        [NativeTypeName("#define WINEVENT_SKIPOWNPROCESS 0x0002")]
        public const int WINEVENT_SKIPOWNPROCESS = 0x0002;

        [NativeTypeName("#define WINEVENT_INCONTEXT 0x0004")]
        public const int WINEVENT_INCONTEXT = 0x0004;

        [NativeTypeName("#define CHILDID_SELF 0")]
        public const int CHILDID_SELF = 0;

        [NativeTypeName("#define INDEXID_OBJECT 0")]
        public const int INDEXID_OBJECT = 0;

        [NativeTypeName("#define INDEXID_CONTAINER 0")]
        public const int INDEXID_CONTAINER = 0;

        [NativeTypeName("#define OBJID_WINDOW ((LONG)0x00000000)")]
        public const int OBJID_WINDOW = ((int)(0x00000000));

        [NativeTypeName("#define OBJID_SYSMENU ((LONG)0xFFFFFFFF)")]
        public const int OBJID_SYSMENU = unchecked((int)(0xFFFFFFFF));

        [NativeTypeName("#define OBJID_TITLEBAR ((LONG)0xFFFFFFFE)")]
        public const int OBJID_TITLEBAR = unchecked((int)(0xFFFFFFFE));

        [NativeTypeName("#define OBJID_MENU ((LONG)0xFFFFFFFD)")]
        public const int OBJID_MENU = unchecked((int)(0xFFFFFFFD));

        [NativeTypeName("#define OBJID_CLIENT ((LONG)0xFFFFFFFC)")]
        public const int OBJID_CLIENT = unchecked((int)(0xFFFFFFFC));

        [NativeTypeName("#define OBJID_VSCROLL ((LONG)0xFFFFFFFB)")]
        public const int OBJID_VSCROLL = unchecked((int)(0xFFFFFFFB));

        [NativeTypeName("#define OBJID_HSCROLL ((LONG)0xFFFFFFFA)")]
        public const int OBJID_HSCROLL = unchecked((int)(0xFFFFFFFA));

        [NativeTypeName("#define OBJID_SIZEGRIP ((LONG)0xFFFFFFF9)")]
        public const int OBJID_SIZEGRIP = unchecked((int)(0xFFFFFFF9));

        [NativeTypeName("#define OBJID_CARET ((LONG)0xFFFFFFF8)")]
        public const int OBJID_CARET = unchecked((int)(0xFFFFFFF8));

        [NativeTypeName("#define OBJID_CURSOR ((LONG)0xFFFFFFF7)")]
        public const int OBJID_CURSOR = unchecked((int)(0xFFFFFFF7));

        [NativeTypeName("#define OBJID_ALERT ((LONG)0xFFFFFFF6)")]
        public const int OBJID_ALERT = unchecked((int)(0xFFFFFFF6));

        [NativeTypeName("#define OBJID_SOUND ((LONG)0xFFFFFFF5)")]
        public const int OBJID_SOUND = unchecked((int)(0xFFFFFFF5));

        [NativeTypeName("#define OBJID_QUERYCLASSNAMEIDX ((LONG)0xFFFFFFF4)")]
        public const int OBJID_QUERYCLASSNAMEIDX = unchecked((int)(0xFFFFFFF4));

        [NativeTypeName("#define OBJID_NATIVEOM ((LONG)0xFFFFFFF0)")]
        public const int OBJID_NATIVEOM = unchecked((int)(0xFFFFFFF0));

        [NativeTypeName("#define EVENT_MIN 0x00000001")]
        public const int EVENT_MIN = 0x00000001;

        [NativeTypeName("#define EVENT_MAX 0x7FFFFFFF")]
        public const int EVENT_MAX = 0x7FFFFFFF;

        [NativeTypeName("#define EVENT_SYSTEM_SOUND 0x0001")]
        public const int EVENT_SYSTEM_SOUND = 0x0001;

        [NativeTypeName("#define EVENT_SYSTEM_ALERT 0x0002")]
        public const int EVENT_SYSTEM_ALERT = 0x0002;

        [NativeTypeName("#define EVENT_SYSTEM_FOREGROUND 0x0003")]
        public const int EVENT_SYSTEM_FOREGROUND = 0x0003;

        [NativeTypeName("#define EVENT_SYSTEM_MENUSTART 0x0004")]
        public const int EVENT_SYSTEM_MENUSTART = 0x0004;

        [NativeTypeName("#define EVENT_SYSTEM_MENUEND 0x0005")]
        public const int EVENT_SYSTEM_MENUEND = 0x0005;

        [NativeTypeName("#define EVENT_SYSTEM_MENUPOPUPSTART 0x0006")]
        public const int EVENT_SYSTEM_MENUPOPUPSTART = 0x0006;

        [NativeTypeName("#define EVENT_SYSTEM_MENUPOPUPEND 0x0007")]
        public const int EVENT_SYSTEM_MENUPOPUPEND = 0x0007;

        [NativeTypeName("#define EVENT_SYSTEM_CAPTURESTART 0x0008")]
        public const int EVENT_SYSTEM_CAPTURESTART = 0x0008;

        [NativeTypeName("#define EVENT_SYSTEM_CAPTUREEND 0x0009")]
        public const int EVENT_SYSTEM_CAPTUREEND = 0x0009;

        [NativeTypeName("#define EVENT_SYSTEM_MOVESIZESTART 0x000A")]
        public const int EVENT_SYSTEM_MOVESIZESTART = 0x000A;

        [NativeTypeName("#define EVENT_SYSTEM_MOVESIZEEND 0x000B")]
        public const int EVENT_SYSTEM_MOVESIZEEND = 0x000B;

        [NativeTypeName("#define EVENT_SYSTEM_CONTEXTHELPSTART 0x000C")]
        public const int EVENT_SYSTEM_CONTEXTHELPSTART = 0x000C;

        [NativeTypeName("#define EVENT_SYSTEM_CONTEXTHELPEND 0x000D")]
        public const int EVENT_SYSTEM_CONTEXTHELPEND = 0x000D;

        [NativeTypeName("#define EVENT_SYSTEM_DRAGDROPSTART 0x000E")]
        public const int EVENT_SYSTEM_DRAGDROPSTART = 0x000E;

        [NativeTypeName("#define EVENT_SYSTEM_DRAGDROPEND 0x000F")]
        public const int EVENT_SYSTEM_DRAGDROPEND = 0x000F;

        [NativeTypeName("#define EVENT_SYSTEM_DIALOGSTART 0x0010")]
        public const int EVENT_SYSTEM_DIALOGSTART = 0x0010;

        [NativeTypeName("#define EVENT_SYSTEM_DIALOGEND 0x0011")]
        public const int EVENT_SYSTEM_DIALOGEND = 0x0011;

        [NativeTypeName("#define EVENT_SYSTEM_SCROLLINGSTART 0x0012")]
        public const int EVENT_SYSTEM_SCROLLINGSTART = 0x0012;

        [NativeTypeName("#define EVENT_SYSTEM_SCROLLINGEND 0x0013")]
        public const int EVENT_SYSTEM_SCROLLINGEND = 0x0013;

        [NativeTypeName("#define EVENT_SYSTEM_SWITCHSTART 0x0014")]
        public const int EVENT_SYSTEM_SWITCHSTART = 0x0014;

        [NativeTypeName("#define EVENT_SYSTEM_SWITCHEND 0x0015")]
        public const int EVENT_SYSTEM_SWITCHEND = 0x0015;

        [NativeTypeName("#define EVENT_SYSTEM_MINIMIZESTART 0x0016")]
        public const int EVENT_SYSTEM_MINIMIZESTART = 0x0016;

        [NativeTypeName("#define EVENT_SYSTEM_MINIMIZEEND 0x0017")]
        public const int EVENT_SYSTEM_MINIMIZEEND = 0x0017;

        [NativeTypeName("#define EVENT_SYSTEM_DESKTOPSWITCH 0x0020")]
        public const int EVENT_SYSTEM_DESKTOPSWITCH = 0x0020;

        [NativeTypeName("#define EVENT_SYSTEM_SWITCHER_APPGRABBED 0x0024")]
        public const int EVENT_SYSTEM_SWITCHER_APPGRABBED = 0x0024;

        [NativeTypeName("#define EVENT_SYSTEM_SWITCHER_APPOVERTARGET 0x0025")]
        public const int EVENT_SYSTEM_SWITCHER_APPOVERTARGET = 0x0025;

        [NativeTypeName("#define EVENT_SYSTEM_SWITCHER_APPDROPPED 0x0026")]
        public const int EVENT_SYSTEM_SWITCHER_APPDROPPED = 0x0026;

        [NativeTypeName("#define EVENT_SYSTEM_SWITCHER_CANCELLED 0x0027")]
        public const int EVENT_SYSTEM_SWITCHER_CANCELLED = 0x0027;

        [NativeTypeName("#define EVENT_SYSTEM_IME_KEY_NOTIFICATION 0x0029")]
        public const int EVENT_SYSTEM_IME_KEY_NOTIFICATION = 0x0029;

        [NativeTypeName("#define EVENT_SYSTEM_END 0x00FF")]
        public const int EVENT_SYSTEM_END = 0x00FF;

        [NativeTypeName("#define EVENT_OEM_DEFINED_START 0x0101")]
        public const int EVENT_OEM_DEFINED_START = 0x0101;

        [NativeTypeName("#define EVENT_OEM_DEFINED_END 0x01FF")]
        public const int EVENT_OEM_DEFINED_END = 0x01FF;

        [NativeTypeName("#define EVENT_UIA_EVENTID_START 0x4E00")]
        public const int EVENT_UIA_EVENTID_START = 0x4E00;

        [NativeTypeName("#define EVENT_UIA_EVENTID_END 0x4EFF")]
        public const int EVENT_UIA_EVENTID_END = 0x4EFF;

        [NativeTypeName("#define EVENT_UIA_PROPID_START 0x7500")]
        public const int EVENT_UIA_PROPID_START = 0x7500;

        [NativeTypeName("#define EVENT_UIA_PROPID_END 0x75FF")]
        public const int EVENT_UIA_PROPID_END = 0x75FF;

        [NativeTypeName("#define EVENT_CONSOLE_CARET 0x4001")]
        public const int EVENT_CONSOLE_CARET = 0x4001;

        [NativeTypeName("#define EVENT_CONSOLE_UPDATE_REGION 0x4002")]
        public const int EVENT_CONSOLE_UPDATE_REGION = 0x4002;

        [NativeTypeName("#define EVENT_CONSOLE_UPDATE_SIMPLE 0x4003")]
        public const int EVENT_CONSOLE_UPDATE_SIMPLE = 0x4003;

        [NativeTypeName("#define EVENT_CONSOLE_UPDATE_SCROLL 0x4004")]
        public const int EVENT_CONSOLE_UPDATE_SCROLL = 0x4004;

        [NativeTypeName("#define EVENT_CONSOLE_LAYOUT 0x4005")]
        public const int EVENT_CONSOLE_LAYOUT = 0x4005;

        [NativeTypeName("#define EVENT_CONSOLE_START_APPLICATION 0x4006")]
        public const int EVENT_CONSOLE_START_APPLICATION = 0x4006;

        [NativeTypeName("#define EVENT_CONSOLE_END_APPLICATION 0x4007")]
        public const int EVENT_CONSOLE_END_APPLICATION = 0x4007;

        [NativeTypeName("#define CONSOLE_APPLICATION_16BIT 0x0001")]
        public const int CONSOLE_APPLICATION_16BIT = 0x0001;

        [NativeTypeName("#define CONSOLE_CARET_SELECTION 0x0001")]
        public const int CONSOLE_CARET_SELECTION = 0x0001;

        [NativeTypeName("#define CONSOLE_CARET_VISIBLE 0x0002")]
        public const int CONSOLE_CARET_VISIBLE = 0x0002;

        [NativeTypeName("#define EVENT_CONSOLE_END 0x40FF")]
        public const int EVENT_CONSOLE_END = 0x40FF;

        [NativeTypeName("#define EVENT_OBJECT_CREATE 0x8000")]
        public const int EVENT_OBJECT_CREATE = 0x8000;

        [NativeTypeName("#define EVENT_OBJECT_DESTROY 0x8001")]
        public const int EVENT_OBJECT_DESTROY = 0x8001;

        [NativeTypeName("#define EVENT_OBJECT_SHOW 0x8002")]
        public const int EVENT_OBJECT_SHOW = 0x8002;

        [NativeTypeName("#define EVENT_OBJECT_HIDE 0x8003")]
        public const int EVENT_OBJECT_HIDE = 0x8003;

        [NativeTypeName("#define EVENT_OBJECT_REORDER 0x8004")]
        public const int EVENT_OBJECT_REORDER = 0x8004;

        [NativeTypeName("#define EVENT_OBJECT_FOCUS 0x8005")]
        public const int EVENT_OBJECT_FOCUS = 0x8005;

        [NativeTypeName("#define EVENT_OBJECT_SELECTION 0x8006")]
        public const int EVENT_OBJECT_SELECTION = 0x8006;

        [NativeTypeName("#define EVENT_OBJECT_SELECTIONADD 0x8007")]
        public const int EVENT_OBJECT_SELECTIONADD = 0x8007;

        [NativeTypeName("#define EVENT_OBJECT_SELECTIONREMOVE 0x8008")]
        public const int EVENT_OBJECT_SELECTIONREMOVE = 0x8008;

        [NativeTypeName("#define EVENT_OBJECT_SELECTIONWITHIN 0x8009")]
        public const int EVENT_OBJECT_SELECTIONWITHIN = 0x8009;

        [NativeTypeName("#define EVENT_OBJECT_STATECHANGE 0x800A")]
        public const int EVENT_OBJECT_STATECHANGE = 0x800A;

        [NativeTypeName("#define EVENT_OBJECT_LOCATIONCHANGE 0x800B")]
        public const int EVENT_OBJECT_LOCATIONCHANGE = 0x800B;

        [NativeTypeName("#define EVENT_OBJECT_NAMECHANGE 0x800C")]
        public const int EVENT_OBJECT_NAMECHANGE = 0x800C;

        [NativeTypeName("#define EVENT_OBJECT_DESCRIPTIONCHANGE 0x800D")]
        public const int EVENT_OBJECT_DESCRIPTIONCHANGE = 0x800D;

        [NativeTypeName("#define EVENT_OBJECT_VALUECHANGE 0x800E")]
        public const int EVENT_OBJECT_VALUECHANGE = 0x800E;

        [NativeTypeName("#define EVENT_OBJECT_PARENTCHANGE 0x800F")]
        public const int EVENT_OBJECT_PARENTCHANGE = 0x800F;

        [NativeTypeName("#define EVENT_OBJECT_HELPCHANGE 0x8010")]
        public const int EVENT_OBJECT_HELPCHANGE = 0x8010;

        [NativeTypeName("#define EVENT_OBJECT_DEFACTIONCHANGE 0x8011")]
        public const int EVENT_OBJECT_DEFACTIONCHANGE = 0x8011;

        [NativeTypeName("#define EVENT_OBJECT_ACCELERATORCHANGE 0x8012")]
        public const int EVENT_OBJECT_ACCELERATORCHANGE = 0x8012;

        [NativeTypeName("#define EVENT_OBJECT_INVOKED 0x8013")]
        public const int EVENT_OBJECT_INVOKED = 0x8013;

        [NativeTypeName("#define EVENT_OBJECT_TEXTSELECTIONCHANGED 0x8014")]
        public const int EVENT_OBJECT_TEXTSELECTIONCHANGED = 0x8014;

        [NativeTypeName("#define EVENT_OBJECT_CONTENTSCROLLED 0x8015")]
        public const int EVENT_OBJECT_CONTENTSCROLLED = 0x8015;

        [NativeTypeName("#define EVENT_SYSTEM_ARRANGMENTPREVIEW 0x8016")]
        public const int EVENT_SYSTEM_ARRANGMENTPREVIEW = 0x8016;

        [NativeTypeName("#define EVENT_OBJECT_CLOAKED 0x8017")]
        public const int EVENT_OBJECT_CLOAKED = 0x8017;

        [NativeTypeName("#define EVENT_OBJECT_UNCLOAKED 0x8018")]
        public const int EVENT_OBJECT_UNCLOAKED = 0x8018;

        [NativeTypeName("#define EVENT_OBJECT_LIVEREGIONCHANGED 0x8019")]
        public const int EVENT_OBJECT_LIVEREGIONCHANGED = 0x8019;

        [NativeTypeName("#define EVENT_OBJECT_HOSTEDOBJECTSINVALIDATED 0x8020")]
        public const int EVENT_OBJECT_HOSTEDOBJECTSINVALIDATED = 0x8020;

        [NativeTypeName("#define EVENT_OBJECT_DRAGSTART 0x8021")]
        public const int EVENT_OBJECT_DRAGSTART = 0x8021;

        [NativeTypeName("#define EVENT_OBJECT_DRAGCANCEL 0x8022")]
        public const int EVENT_OBJECT_DRAGCANCEL = 0x8022;

        [NativeTypeName("#define EVENT_OBJECT_DRAGCOMPLETE 0x8023")]
        public const int EVENT_OBJECT_DRAGCOMPLETE = 0x8023;

        [NativeTypeName("#define EVENT_OBJECT_DRAGENTER 0x8024")]
        public const int EVENT_OBJECT_DRAGENTER = 0x8024;

        [NativeTypeName("#define EVENT_OBJECT_DRAGLEAVE 0x8025")]
        public const int EVENT_OBJECT_DRAGLEAVE = 0x8025;

        [NativeTypeName("#define EVENT_OBJECT_DRAGDROPPED 0x8026")]
        public const int EVENT_OBJECT_DRAGDROPPED = 0x8026;

        [NativeTypeName("#define EVENT_OBJECT_IME_SHOW 0x8027")]
        public const int EVENT_OBJECT_IME_SHOW = 0x8027;

        [NativeTypeName("#define EVENT_OBJECT_IME_HIDE 0x8028")]
        public const int EVENT_OBJECT_IME_HIDE = 0x8028;

        [NativeTypeName("#define EVENT_OBJECT_IME_CHANGE 0x8029")]
        public const int EVENT_OBJECT_IME_CHANGE = 0x8029;

        [NativeTypeName("#define EVENT_OBJECT_TEXTEDIT_CONVERSIONTARGETCHANGED 0x8030")]
        public const int EVENT_OBJECT_TEXTEDIT_CONVERSIONTARGETCHANGED = 0x8030;

        [NativeTypeName("#define EVENT_OBJECT_END 0x80FF")]
        public const int EVENT_OBJECT_END = 0x80FF;

        [NativeTypeName("#define EVENT_AIA_START 0xA000")]
        public const int EVENT_AIA_START = 0xA000;

        [NativeTypeName("#define EVENT_AIA_END 0xAFFF")]
        public const int EVENT_AIA_END = 0xAFFF;

        [NativeTypeName("#define SOUND_SYSTEM_STARTUP 1")]
        public const int SOUND_SYSTEM_STARTUP = 1;

        [NativeTypeName("#define SOUND_SYSTEM_SHUTDOWN 2")]
        public const int SOUND_SYSTEM_SHUTDOWN = 2;

        [NativeTypeName("#define SOUND_SYSTEM_BEEP 3")]
        public const int SOUND_SYSTEM_BEEP = 3;

        [NativeTypeName("#define SOUND_SYSTEM_ERROR 4")]
        public const int SOUND_SYSTEM_ERROR = 4;

        [NativeTypeName("#define SOUND_SYSTEM_QUESTION 5")]
        public const int SOUND_SYSTEM_QUESTION = 5;

        [NativeTypeName("#define SOUND_SYSTEM_WARNING 6")]
        public const int SOUND_SYSTEM_WARNING = 6;

        [NativeTypeName("#define SOUND_SYSTEM_INFORMATION 7")]
        public const int SOUND_SYSTEM_INFORMATION = 7;

        [NativeTypeName("#define SOUND_SYSTEM_MAXIMIZE 8")]
        public const int SOUND_SYSTEM_MAXIMIZE = 8;

        [NativeTypeName("#define SOUND_SYSTEM_MINIMIZE 9")]
        public const int SOUND_SYSTEM_MINIMIZE = 9;

        [NativeTypeName("#define SOUND_SYSTEM_RESTOREUP 10")]
        public const int SOUND_SYSTEM_RESTOREUP = 10;

        [NativeTypeName("#define SOUND_SYSTEM_RESTOREDOWN 11")]
        public const int SOUND_SYSTEM_RESTOREDOWN = 11;

        [NativeTypeName("#define SOUND_SYSTEM_APPSTART 12")]
        public const int SOUND_SYSTEM_APPSTART = 12;

        [NativeTypeName("#define SOUND_SYSTEM_FAULT 13")]
        public const int SOUND_SYSTEM_FAULT = 13;

        [NativeTypeName("#define SOUND_SYSTEM_APPEND 14")]
        public const int SOUND_SYSTEM_APPEND = 14;

        [NativeTypeName("#define SOUND_SYSTEM_MENUCOMMAND 15")]
        public const int SOUND_SYSTEM_MENUCOMMAND = 15;

        [NativeTypeName("#define SOUND_SYSTEM_MENUPOPUP 16")]
        public const int SOUND_SYSTEM_MENUPOPUP = 16;

        [NativeTypeName("#define CSOUND_SYSTEM 16")]
        public const int CSOUND_SYSTEM = 16;

        [NativeTypeName("#define ALERT_SYSTEM_INFORMATIONAL 1")]
        public const int ALERT_SYSTEM_INFORMATIONAL = 1;

        [NativeTypeName("#define ALERT_SYSTEM_WARNING 2")]
        public const int ALERT_SYSTEM_WARNING = 2;

        [NativeTypeName("#define ALERT_SYSTEM_ERROR 3")]
        public const int ALERT_SYSTEM_ERROR = 3;

        [NativeTypeName("#define ALERT_SYSTEM_QUERY 4")]
        public const int ALERT_SYSTEM_QUERY = 4;

        [NativeTypeName("#define ALERT_SYSTEM_CRITICAL 5")]
        public const int ALERT_SYSTEM_CRITICAL = 5;

        [NativeTypeName("#define CALERT_SYSTEM 6")]
        public const int CALERT_SYSTEM = 6;

        [NativeTypeName("#define GUI_CARETBLINKING 0x00000001")]
        public const int GUI_CARETBLINKING = 0x00000001;

        [NativeTypeName("#define GUI_INMOVESIZE 0x00000002")]
        public const int GUI_INMOVESIZE = 0x00000002;

        [NativeTypeName("#define GUI_INMENUMODE 0x00000004")]
        public const int GUI_INMENUMODE = 0x00000004;

        [NativeTypeName("#define GUI_SYSTEMMENUMODE 0x00000008")]
        public const int GUI_SYSTEMMENUMODE = 0x00000008;

        [NativeTypeName("#define GUI_POPUPMENUMODE 0x00000010")]
        public const int GUI_POPUPMENUMODE = 0x00000010;

        [NativeTypeName("#define GUI_16BITTASK 0x00000020")]
        public const int GUI_16BITTASK = 0x00000020;

        [NativeTypeName("#define USER_DEFAULT_SCREEN_DPI 96")]
        public const int USER_DEFAULT_SCREEN_DPI = 96;

        [NativeTypeName("#define GetWindowModuleFileName GetWindowModuleFileNameW")]
        public static readonly delegate*<IntPtr, ushort*, uint, uint> GetWindowModuleFileName = &GetWindowModuleFileNameW;

        [NativeTypeName("#define STATE_SYSTEM_UNAVAILABLE 0x00000001")]
        public const int STATE_SYSTEM_UNAVAILABLE = 0x00000001;

        [NativeTypeName("#define STATE_SYSTEM_SELECTED 0x00000002")]
        public const int STATE_SYSTEM_SELECTED = 0x00000002;

        [NativeTypeName("#define STATE_SYSTEM_FOCUSED 0x00000004")]
        public const int STATE_SYSTEM_FOCUSED = 0x00000004;

        [NativeTypeName("#define STATE_SYSTEM_PRESSED 0x00000008")]
        public const int STATE_SYSTEM_PRESSED = 0x00000008;

        [NativeTypeName("#define STATE_SYSTEM_CHECKED 0x00000010")]
        public const int STATE_SYSTEM_CHECKED = 0x00000010;

        [NativeTypeName("#define STATE_SYSTEM_MIXED 0x00000020")]
        public const int STATE_SYSTEM_MIXED = 0x00000020;

        [NativeTypeName("#define STATE_SYSTEM_INDETERMINATE STATE_SYSTEM_MIXED")]
        public const int STATE_SYSTEM_INDETERMINATE = 0x00000020;

        [NativeTypeName("#define STATE_SYSTEM_READONLY 0x00000040")]
        public const int STATE_SYSTEM_READONLY = 0x00000040;

        [NativeTypeName("#define STATE_SYSTEM_HOTTRACKED 0x00000080")]
        public const int STATE_SYSTEM_HOTTRACKED = 0x00000080;

        [NativeTypeName("#define STATE_SYSTEM_DEFAULT 0x00000100")]
        public const int STATE_SYSTEM_DEFAULT = 0x00000100;

        [NativeTypeName("#define STATE_SYSTEM_EXPANDED 0x00000200")]
        public const int STATE_SYSTEM_EXPANDED = 0x00000200;

        [NativeTypeName("#define STATE_SYSTEM_COLLAPSED 0x00000400")]
        public const int STATE_SYSTEM_COLLAPSED = 0x00000400;

        [NativeTypeName("#define STATE_SYSTEM_BUSY 0x00000800")]
        public const int STATE_SYSTEM_BUSY = 0x00000800;

        [NativeTypeName("#define STATE_SYSTEM_FLOATING 0x00001000")]
        public const int STATE_SYSTEM_FLOATING = 0x00001000;

        [NativeTypeName("#define STATE_SYSTEM_MARQUEED 0x00002000")]
        public const int STATE_SYSTEM_MARQUEED = 0x00002000;

        [NativeTypeName("#define STATE_SYSTEM_ANIMATED 0x00004000")]
        public const int STATE_SYSTEM_ANIMATED = 0x00004000;

        [NativeTypeName("#define STATE_SYSTEM_INVISIBLE 0x00008000")]
        public const int STATE_SYSTEM_INVISIBLE = 0x00008000;

        [NativeTypeName("#define STATE_SYSTEM_OFFSCREEN 0x00010000")]
        public const int STATE_SYSTEM_OFFSCREEN = 0x00010000;

        [NativeTypeName("#define STATE_SYSTEM_SIZEABLE 0x00020000")]
        public const int STATE_SYSTEM_SIZEABLE = 0x00020000;

        [NativeTypeName("#define STATE_SYSTEM_MOVEABLE 0x00040000")]
        public const int STATE_SYSTEM_MOVEABLE = 0x00040000;

        [NativeTypeName("#define STATE_SYSTEM_SELFVOICING 0x00080000")]
        public const int STATE_SYSTEM_SELFVOICING = 0x00080000;

        [NativeTypeName("#define STATE_SYSTEM_FOCUSABLE 0x00100000")]
        public const int STATE_SYSTEM_FOCUSABLE = 0x00100000;

        [NativeTypeName("#define STATE_SYSTEM_SELECTABLE 0x00200000")]
        public const int STATE_SYSTEM_SELECTABLE = 0x00200000;

        [NativeTypeName("#define STATE_SYSTEM_LINKED 0x00400000")]
        public const int STATE_SYSTEM_LINKED = 0x00400000;

        [NativeTypeName("#define STATE_SYSTEM_TRAVERSED 0x00800000")]
        public const int STATE_SYSTEM_TRAVERSED = 0x00800000;

        [NativeTypeName("#define STATE_SYSTEM_MULTISELECTABLE 0x01000000")]
        public const int STATE_SYSTEM_MULTISELECTABLE = 0x01000000;

        [NativeTypeName("#define STATE_SYSTEM_EXTSELECTABLE 0x02000000")]
        public const int STATE_SYSTEM_EXTSELECTABLE = 0x02000000;

        [NativeTypeName("#define STATE_SYSTEM_ALERT_LOW 0x04000000")]
        public const int STATE_SYSTEM_ALERT_LOW = 0x04000000;

        [NativeTypeName("#define STATE_SYSTEM_ALERT_MEDIUM 0x08000000")]
        public const int STATE_SYSTEM_ALERT_MEDIUM = 0x08000000;

        [NativeTypeName("#define STATE_SYSTEM_ALERT_HIGH 0x10000000")]
        public const int STATE_SYSTEM_ALERT_HIGH = 0x10000000;

        [NativeTypeName("#define STATE_SYSTEM_PROTECTED 0x20000000")]
        public const int STATE_SYSTEM_PROTECTED = 0x20000000;

        [NativeTypeName("#define STATE_SYSTEM_VALID 0x3FFFFFFF")]
        public const int STATE_SYSTEM_VALID = 0x3FFFFFFF;

        [NativeTypeName("#define CCHILDREN_TITLEBAR 5")]
        public const int CCHILDREN_TITLEBAR = 5;

        [NativeTypeName("#define CCHILDREN_SCROLLBAR 5")]
        public const int CCHILDREN_SCROLLBAR = 5;

        [NativeTypeName("#define CURSOR_SHOWING 0x00000001")]
        public const int CURSOR_SHOWING = 0x00000001;

        [NativeTypeName("#define CURSOR_SUPPRESSED 0x00000002")]
        public const int CURSOR_SUPPRESSED = 0x00000002;

        [NativeTypeName("#define WS_ACTIVECAPTION 0x0001")]
        public const int WS_ACTIVECAPTION = 0x0001;

        [NativeTypeName("#define GA_PARENT 1")]
        public const int GA_PARENT = 1;

        [NativeTypeName("#define GA_ROOT 2")]
        public const int GA_ROOT = 2;

        [NativeTypeName("#define GA_ROOTOWNER 3")]
        public const int GA_ROOTOWNER = 3;

        [NativeTypeName("#define RealGetWindowClass RealGetWindowClassW")]
        public static readonly delegate*<IntPtr, ushort*, uint, uint> RealGetWindowClass = &RealGetWindowClassW;

        [NativeTypeName("#define GetAltTabInfo GetAltTabInfoW")]
        public static readonly delegate*<IntPtr, int, ALTTABINFO*, ushort*, uint, int> GetAltTabInfo = &GetAltTabInfoW;

        [NativeTypeName("#define RIM_INPUT 0")]
        public const int RIM_INPUT = 0;

        [NativeTypeName("#define RIM_INPUTSINK 1")]
        public const int RIM_INPUTSINK = 1;

        [NativeTypeName("#define RIM_TYPEMOUSE 0")]
        public const int RIM_TYPEMOUSE = 0;

        [NativeTypeName("#define RIM_TYPEKEYBOARD 1")]
        public const int RIM_TYPEKEYBOARD = 1;

        [NativeTypeName("#define RIM_TYPEHID 2")]
        public const int RIM_TYPEHID = 2;

        [NativeTypeName("#define RIM_TYPEMAX 2")]
        public const int RIM_TYPEMAX = 2;

        [NativeTypeName("#define RI_MOUSE_LEFT_BUTTON_DOWN 0x0001")]
        public const int RI_MOUSE_LEFT_BUTTON_DOWN = 0x0001;

        [NativeTypeName("#define RI_MOUSE_LEFT_BUTTON_UP 0x0002")]
        public const int RI_MOUSE_LEFT_BUTTON_UP = 0x0002;

        [NativeTypeName("#define RI_MOUSE_RIGHT_BUTTON_DOWN 0x0004")]
        public const int RI_MOUSE_RIGHT_BUTTON_DOWN = 0x0004;

        [NativeTypeName("#define RI_MOUSE_RIGHT_BUTTON_UP 0x0008")]
        public const int RI_MOUSE_RIGHT_BUTTON_UP = 0x0008;

        [NativeTypeName("#define RI_MOUSE_MIDDLE_BUTTON_DOWN 0x0010")]
        public const int RI_MOUSE_MIDDLE_BUTTON_DOWN = 0x0010;

        [NativeTypeName("#define RI_MOUSE_MIDDLE_BUTTON_UP 0x0020")]
        public const int RI_MOUSE_MIDDLE_BUTTON_UP = 0x0020;

        [NativeTypeName("#define RI_MOUSE_BUTTON_1_DOWN RI_MOUSE_LEFT_BUTTON_DOWN")]
        public const int RI_MOUSE_BUTTON_1_DOWN = 0x0001;

        [NativeTypeName("#define RI_MOUSE_BUTTON_1_UP RI_MOUSE_LEFT_BUTTON_UP")]
        public const int RI_MOUSE_BUTTON_1_UP = 0x0002;

        [NativeTypeName("#define RI_MOUSE_BUTTON_2_DOWN RI_MOUSE_RIGHT_BUTTON_DOWN")]
        public const int RI_MOUSE_BUTTON_2_DOWN = 0x0004;

        [NativeTypeName("#define RI_MOUSE_BUTTON_2_UP RI_MOUSE_RIGHT_BUTTON_UP")]
        public const int RI_MOUSE_BUTTON_2_UP = 0x0008;

        [NativeTypeName("#define RI_MOUSE_BUTTON_3_DOWN RI_MOUSE_MIDDLE_BUTTON_DOWN")]
        public const int RI_MOUSE_BUTTON_3_DOWN = 0x0010;

        [NativeTypeName("#define RI_MOUSE_BUTTON_3_UP RI_MOUSE_MIDDLE_BUTTON_UP")]
        public const int RI_MOUSE_BUTTON_3_UP = 0x0020;

        [NativeTypeName("#define RI_MOUSE_BUTTON_4_DOWN 0x0040")]
        public const int RI_MOUSE_BUTTON_4_DOWN = 0x0040;

        [NativeTypeName("#define RI_MOUSE_BUTTON_4_UP 0x0080")]
        public const int RI_MOUSE_BUTTON_4_UP = 0x0080;

        [NativeTypeName("#define RI_MOUSE_BUTTON_5_DOWN 0x0100")]
        public const int RI_MOUSE_BUTTON_5_DOWN = 0x0100;

        [NativeTypeName("#define RI_MOUSE_BUTTON_5_UP 0x0200")]
        public const int RI_MOUSE_BUTTON_5_UP = 0x0200;

        [NativeTypeName("#define RI_MOUSE_WHEEL 0x0400")]
        public const int RI_MOUSE_WHEEL = 0x0400;

        [NativeTypeName("#define RI_MOUSE_HWHEEL 0x0800")]
        public const int RI_MOUSE_HWHEEL = 0x0800;

        [NativeTypeName("#define MOUSE_MOVE_RELATIVE 0")]
        public const int MOUSE_MOVE_RELATIVE = 0;

        [NativeTypeName("#define MOUSE_MOVE_ABSOLUTE 1")]
        public const int MOUSE_MOVE_ABSOLUTE = 1;

        [NativeTypeName("#define MOUSE_VIRTUAL_DESKTOP 0x02")]
        public const int MOUSE_VIRTUAL_DESKTOP = 0x02;

        [NativeTypeName("#define MOUSE_ATTRIBUTES_CHANGED 0x04")]
        public const int MOUSE_ATTRIBUTES_CHANGED = 0x04;

        [NativeTypeName("#define MOUSE_MOVE_NOCOALESCE 0x08")]
        public const int MOUSE_MOVE_NOCOALESCE = 0x08;

        [NativeTypeName("#define KEYBOARD_OVERRUN_MAKE_CODE 0xFF")]
        public const int KEYBOARD_OVERRUN_MAKE_CODE = 0xFF;

        [NativeTypeName("#define RI_KEY_MAKE 0")]
        public const int RI_KEY_MAKE = 0;

        [NativeTypeName("#define RI_KEY_BREAK 1")]
        public const int RI_KEY_BREAK = 1;

        [NativeTypeName("#define RI_KEY_E0 2")]
        public const int RI_KEY_E0 = 2;

        [NativeTypeName("#define RI_KEY_E1 4")]
        public const int RI_KEY_E1 = 4;

        [NativeTypeName("#define RI_KEY_TERMSRV_SET_LED 8")]
        public const int RI_KEY_TERMSRV_SET_LED = 8;

        [NativeTypeName("#define RI_KEY_TERMSRV_SHADOW 0x10")]
        public const int RI_KEY_TERMSRV_SHADOW = 0x10;

        [NativeTypeName("#define RID_INPUT 0x10000003")]
        public const int RID_INPUT = 0x10000003;

        [NativeTypeName("#define RID_HEADER 0x10000005")]
        public const int RID_HEADER = 0x10000005;

        [NativeTypeName("#define RIDI_PREPARSEDDATA 0x20000005")]
        public const int RIDI_PREPARSEDDATA = 0x20000005;

        [NativeTypeName("#define RIDI_DEVICENAME 0x20000007")]
        public const int RIDI_DEVICENAME = 0x20000007;

        [NativeTypeName("#define RIDI_DEVICEINFO 0x2000000b")]
        public const int RIDI_DEVICEINFO = 0x2000000b;

        [NativeTypeName("#define GetRawInputDeviceInfo GetRawInputDeviceInfoW")]
        public static readonly delegate*<IntPtr, uint, void*, uint*, uint> GetRawInputDeviceInfo = &GetRawInputDeviceInfoW;

        [NativeTypeName("#define RIDEV_REMOVE 0x00000001")]
        public const int RIDEV_REMOVE = 0x00000001;

        [NativeTypeName("#define RIDEV_EXCLUDE 0x00000010")]
        public const int RIDEV_EXCLUDE = 0x00000010;

        [NativeTypeName("#define RIDEV_PAGEONLY 0x00000020")]
        public const int RIDEV_PAGEONLY = 0x00000020;

        [NativeTypeName("#define RIDEV_NOLEGACY 0x00000030")]
        public const int RIDEV_NOLEGACY = 0x00000030;

        [NativeTypeName("#define RIDEV_INPUTSINK 0x00000100")]
        public const int RIDEV_INPUTSINK = 0x00000100;

        [NativeTypeName("#define RIDEV_CAPTUREMOUSE 0x00000200")]
        public const int RIDEV_CAPTUREMOUSE = 0x00000200;

        [NativeTypeName("#define RIDEV_NOHOTKEYS 0x00000200")]
        public const int RIDEV_NOHOTKEYS = 0x00000200;

        [NativeTypeName("#define RIDEV_APPKEYS 0x00000400")]
        public const int RIDEV_APPKEYS = 0x00000400;

        [NativeTypeName("#define RIDEV_EXINPUTSINK 0x00001000")]
        public const int RIDEV_EXINPUTSINK = 0x00001000;

        [NativeTypeName("#define RIDEV_DEVNOTIFY 0x00002000")]
        public const int RIDEV_DEVNOTIFY = 0x00002000;

        [NativeTypeName("#define RIDEV_EXMODEMASK 0x000000F0")]
        public const int RIDEV_EXMODEMASK = 0x000000F0;

        [NativeTypeName("#define GIDC_ARRIVAL 1")]
        public const int GIDC_ARRIVAL = 1;

        [NativeTypeName("#define GIDC_REMOVAL 2")]
        public const int GIDC_REMOVAL = 2;

        [NativeTypeName("#define POINTER_DEVICE_PRODUCT_STRING_MAX 520")]
        public const int POINTER_DEVICE_PRODUCT_STRING_MAX = 520;

        [NativeTypeName("#define PDC_ARRIVAL 0x001")]
        public const int PDC_ARRIVAL = 0x001;

        [NativeTypeName("#define PDC_REMOVAL 0x002")]
        public const int PDC_REMOVAL = 0x002;

        [NativeTypeName("#define PDC_ORIENTATION_0 0x004")]
        public const int PDC_ORIENTATION_0 = 0x004;

        [NativeTypeName("#define PDC_ORIENTATION_90 0x008")]
        public const int PDC_ORIENTATION_90 = 0x008;

        [NativeTypeName("#define PDC_ORIENTATION_180 0x010")]
        public const int PDC_ORIENTATION_180 = 0x010;

        [NativeTypeName("#define PDC_ORIENTATION_270 0x020")]
        public const int PDC_ORIENTATION_270 = 0x020;

        [NativeTypeName("#define PDC_MODE_DEFAULT 0x040")]
        public const int PDC_MODE_DEFAULT = 0x040;

        [NativeTypeName("#define PDC_MODE_CENTERED 0x080")]
        public const int PDC_MODE_CENTERED = 0x080;

        [NativeTypeName("#define PDC_MAPPING_CHANGE 0x100")]
        public const int PDC_MAPPING_CHANGE = 0x100;

        [NativeTypeName("#define PDC_RESOLUTION 0x200")]
        public const int PDC_RESOLUTION = 0x200;

        [NativeTypeName("#define PDC_ORIGIN 0x400")]
        public const int PDC_ORIGIN = 0x400;

        [NativeTypeName("#define PDC_MODE_ASPECTRATIOPRESERVED 0x800")]
        public const int PDC_MODE_ASPECTRATIOPRESERVED = 0x800;

        [NativeTypeName("#define MSGFLT_ADD 1")]
        public const int MSGFLT_ADD = 1;

        [NativeTypeName("#define MSGFLT_REMOVE 2")]
        public const int MSGFLT_REMOVE = 2;

        [NativeTypeName("#define MSGFLTINFO_NONE (0)")]
        public const int MSGFLTINFO_NONE = (0);

        [NativeTypeName("#define MSGFLTINFO_ALREADYALLOWED_FORWND (1)")]
        public const int MSGFLTINFO_ALREADYALLOWED_FORWND = (1);

        [NativeTypeName("#define MSGFLTINFO_ALREADYDISALLOWED_FORWND (2)")]
        public const int MSGFLTINFO_ALREADYDISALLOWED_FORWND = (2);

        [NativeTypeName("#define MSGFLTINFO_ALLOWED_HIGHER (3)")]
        public const int MSGFLTINFO_ALLOWED_HIGHER = (3);

        [NativeTypeName("#define MSGFLT_RESET (0)")]
        public const int MSGFLT_RESET = (0);

        [NativeTypeName("#define MSGFLT_ALLOW (1)")]
        public const int MSGFLT_ALLOW = (1);

        [NativeTypeName("#define MSGFLT_DISALLOW (2)")]
        public const int MSGFLT_DISALLOW = (2);

        [NativeTypeName("#define GF_BEGIN 0x00000001")]
        public const int GF_BEGIN = 0x00000001;

        [NativeTypeName("#define GF_INERTIA 0x00000002")]
        public const int GF_INERTIA = 0x00000002;

        [NativeTypeName("#define GF_END 0x00000004")]
        public const int GF_END = 0x00000004;

        [NativeTypeName("#define GID_BEGIN 1")]
        public const int GID_BEGIN = 1;

        [NativeTypeName("#define GID_END 2")]
        public const int GID_END = 2;

        [NativeTypeName("#define GID_ZOOM 3")]
        public const int GID_ZOOM = 3;

        [NativeTypeName("#define GID_PAN 4")]
        public const int GID_PAN = 4;

        [NativeTypeName("#define GID_ROTATE 5")]
        public const int GID_ROTATE = 5;

        [NativeTypeName("#define GID_TWOFINGERTAP 6")]
        public const int GID_TWOFINGERTAP = 6;

        [NativeTypeName("#define GID_PRESSANDTAP 7")]
        public const int GID_PRESSANDTAP = 7;

        [NativeTypeName("#define GID_ROLLOVER GID_PRESSANDTAP")]
        public const int GID_ROLLOVER = 7;

        [NativeTypeName("#define GC_ALLGESTURES 0x00000001")]
        public const int GC_ALLGESTURES = 0x00000001;

        [NativeTypeName("#define GC_ZOOM 0x00000001")]
        public const int GC_ZOOM = 0x00000001;

        [NativeTypeName("#define GC_PAN 0x00000001")]
        public const int GC_PAN = 0x00000001;

        [NativeTypeName("#define GC_PAN_WITH_SINGLE_FINGER_VERTICALLY 0x00000002")]
        public const int GC_PAN_WITH_SINGLE_FINGER_VERTICALLY = 0x00000002;

        [NativeTypeName("#define GC_PAN_WITH_SINGLE_FINGER_HORIZONTALLY 0x00000004")]
        public const int GC_PAN_WITH_SINGLE_FINGER_HORIZONTALLY = 0x00000004;

        [NativeTypeName("#define GC_PAN_WITH_GUTTER 0x00000008")]
        public const int GC_PAN_WITH_GUTTER = 0x00000008;

        [NativeTypeName("#define GC_PAN_WITH_INERTIA 0x00000010")]
        public const int GC_PAN_WITH_INERTIA = 0x00000010;

        [NativeTypeName("#define GC_ROTATE 0x00000001")]
        public const int GC_ROTATE = 0x00000001;

        [NativeTypeName("#define GC_TWOFINGERTAP 0x00000001")]
        public const int GC_TWOFINGERTAP = 0x00000001;

        [NativeTypeName("#define GC_PRESSANDTAP 0x00000001")]
        public const int GC_PRESSANDTAP = 0x00000001;

        [NativeTypeName("#define GC_ROLLOVER GC_PRESSANDTAP")]
        public const int GC_ROLLOVER = 0x00000001;

        [NativeTypeName("#define GESTURECONFIGMAXCOUNT 256")]
        public const int GESTURECONFIGMAXCOUNT = 256;

        [NativeTypeName("#define GCF_INCLUDE_ANCESTORS 0x00000001")]
        public const int GCF_INCLUDE_ANCESTORS = 0x00000001;

        [NativeTypeName("#define NID_INTEGRATED_TOUCH 0x00000001")]
        public const int NID_INTEGRATED_TOUCH = 0x00000001;

        [NativeTypeName("#define NID_EXTERNAL_TOUCH 0x00000002")]
        public const int NID_EXTERNAL_TOUCH = 0x00000002;

        [NativeTypeName("#define NID_INTEGRATED_PEN 0x00000004")]
        public const int NID_INTEGRATED_PEN = 0x00000004;

        [NativeTypeName("#define NID_EXTERNAL_PEN 0x00000008")]
        public const int NID_EXTERNAL_PEN = 0x00000008;

        [NativeTypeName("#define NID_MULTI_INPUT 0x00000040")]
        public const int NID_MULTI_INPUT = 0x00000040;

        [NativeTypeName("#define NID_READY 0x00000080")]
        public const int NID_READY = 0x00000080;

        [NativeTypeName("#define MAX_STR_BLOCKREASON 256")]
        public const int MAX_STR_BLOCKREASON = 256;
    }
}
