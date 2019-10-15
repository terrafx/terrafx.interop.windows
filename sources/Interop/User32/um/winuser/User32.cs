// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class User32
    {
        private const string LibraryPath = "User32";

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wvsprintfW", ExactSpelling = true)]
        public static extern int wvsprintf([NativeTypeName("LPWSTR")] ushort* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("va_list")] sbyte* arglist);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wsprintfW", ExactSpelling = true)]
        public static extern int wsprintf([NativeTypeName("LPWSTR")] ushort* param0, [NativeTypeName("LPCWSTR")] ushort* param1);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadKeyboardLayoutW", ExactSpelling = true)]
        [return: NativeTypeName("HKL")]
        public static extern IntPtr LoadKeyboardLayout([NativeTypeName("LPCWSTR")] ushort* pwszKLID, [NativeTypeName("UINT")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ActivateKeyboardLayout", ExactSpelling = true)]
        [return: NativeTypeName("HKL")]
        public static extern IntPtr ActivateKeyboardLayout([NativeTypeName("HKL")] IntPtr hkl, [NativeTypeName("UINT")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ToUnicodeEx", ExactSpelling = true)]
        public static extern int ToUnicodeEx([NativeTypeName("UINT")] uint wVirtKey, [NativeTypeName("UINT")] uint wScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWSTR")] ushort* pwszBuff, int cchBuff, [NativeTypeName("UINT")] uint wFlags, [NativeTypeName("HKL")] IntPtr dwhkl);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnloadKeyboardLayout", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnloadKeyboardLayout([NativeTypeName("HKL")] IntPtr hkl);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetKeyboardLayoutNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetKeyboardLayoutName([NativeTypeName("LPWSTR")] ushort* pwszKLID);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetKeyboardLayoutList", ExactSpelling = true)]
        public static extern int GetKeyboardLayoutList(int nBuff, [NativeTypeName("HKL *")] IntPtr* lpList);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetKeyboardLayout", ExactSpelling = true)]
        [return: NativeTypeName("HKL")]
        public static extern IntPtr GetKeyboardLayout([NativeTypeName("DWORD")] uint idThread);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMouseMovePointsEx", ExactSpelling = true)]
        public static extern int GetMouseMovePointsEx([NativeTypeName("UINT")] uint cbSize, [NativeTypeName("LPMOUSEMOVEPOINT")] MOUSEMOVEPOINT* lppt, [NativeTypeName("LPMOUSEMOVEPOINT")] MOUSEMOVEPOINT* lpptBuf, int nBufPoints, [NativeTypeName("DWORD")] uint resolution);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateDesktopW", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr CreateDesktop([NativeTypeName("LPCWSTR")] ushort* lpszDesktop, [NativeTypeName("LPCWSTR")] ushort* lpszDevice, [NativeTypeName("DEVMODEW *")] DEVMODEW* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateDesktopExW", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr CreateDesktopEx([NativeTypeName("LPCWSTR")] ushort* lpszDesktop, [NativeTypeName("LPCWSTR")] ushort* lpszDevice, [NativeTypeName("DEVMODEW *")] DEVMODEW* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa, [NativeTypeName("ULONG")] uint ulHeapSize, [NativeTypeName("PVOID")] void* pvoid);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OpenDesktopW", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr OpenDesktop([NativeTypeName("LPCWSTR")] ushort* lpszDesktop, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OpenInputDesktop", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr OpenInputDesktop([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumDesktopsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDesktops([NativeTypeName("HWINSTA")] IntPtr hwinsta, [NativeTypeName("DESKTOPENUMPROCW")] IntPtr lpEnumFunc, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumDesktopWindows", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDesktopWindows([NativeTypeName("HDESK")] IntPtr hDesktop, [NativeTypeName("WNDENUMPROC")] IntPtr lpfn, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SwitchDesktop", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SwitchDesktop([NativeTypeName("HDESK")] IntPtr hDesktop);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetThreadDesktop", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadDesktop([NativeTypeName("HDESK")] IntPtr hDesktop);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CloseDesktop", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseDesktop([NativeTypeName("HDESK")] IntPtr hDesktop);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetThreadDesktop", ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern IntPtr GetThreadDesktop([NativeTypeName("DWORD")] uint dwThreadId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateWindowStationW", ExactSpelling = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern IntPtr CreateWindowStation([NativeTypeName("LPCWSTR")] ushort* lpwinsta, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OpenWindowStationW", ExactSpelling = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern IntPtr OpenWindowStation([NativeTypeName("LPCWSTR")] ushort* lpszWinSta, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumWindowStationsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumWindowStations([NativeTypeName("WINSTAENUMPROCW")] IntPtr lpEnumFunc, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CloseWindowStation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseWindowStation([NativeTypeName("HWINSTA")] IntPtr hWinSta);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetProcessWindowStation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessWindowStation([NativeTypeName("HWINSTA")] IntPtr hWinSta);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProcessWindowStation", ExactSpelling = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern IntPtr GetProcessWindowStation();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetUserObjectSecurity", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetUserObjectSecurity([NativeTypeName("HANDLE")] void* hObj, [NativeTypeName("PSECURITY_INFORMATION")] uint* pSIRequested, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSID);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetUserObjectSecurity", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserObjectSecurity([NativeTypeName("HANDLE")] void* hObj, [NativeTypeName("PSECURITY_INFORMATION")] uint* pSIRequested, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSID, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetUserObjectInformationW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserObjectInformation([NativeTypeName("HANDLE")] void* hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetUserObjectInformationW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetUserObjectInformation([NativeTypeName("HANDLE")] void* hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsHungAppWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsHungAppWindow([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DisableProcessWindowsGhosting", ExactSpelling = true)]
        public static extern void DisableProcessWindowsGhosting();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RegisterWindowMessageW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RegisterWindowMessage([NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TrackMouseEvent", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TrackMouseEvent([NativeTypeName("LPTRACKMOUSEEVENT")] TRACKMOUSEEVENT* lpEventTrack);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DrawEdge", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawEdge([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPRECT")] RECT* qrc, [NativeTypeName("UINT")] uint edge, [NativeTypeName("UINT")] uint grfFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DrawFrameControl", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawFrameControl([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("LPRECT")] RECT* param1, [NativeTypeName("UINT")] uint param2, [NativeTypeName("UINT")] uint param3);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DrawCaption", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawCaption([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const RECT *")] RECT* lprect, [NativeTypeName("UINT")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DrawAnimatedRects", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawAnimatedRects([NativeTypeName("HWND")] IntPtr hwnd, int idAni, [NativeTypeName("const RECT *")] RECT* lprcFrom, [NativeTypeName("const RECT *")] RECT* lprcTo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMessageW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMessage([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint wMsgFilterMin, [NativeTypeName("UINT")] uint wMsgFilterMax);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TranslateMessage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TranslateMessage([NativeTypeName("const MSG *")] MSG* lpMsg);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DispatchMessageW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern IntPtr DispatchMessage([NativeTypeName("const MSG *")] MSG* lpMsg);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetMessageQueue", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMessageQueue(int cMessagesMax);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PeekMessageW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PeekMessage([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint wMsgFilterMin, [NativeTypeName("UINT")] uint wMsgFilterMax, [NativeTypeName("UINT")] uint wRemoveMsg);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RegisterHotKey", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterHotKey([NativeTypeName("HWND")] IntPtr hWnd, int id, [NativeTypeName("UINT")] uint fsModifiers, [NativeTypeName("UINT")] uint vk);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnregisterHotKey", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterHotKey([NativeTypeName("HWND")] IntPtr hWnd, int id);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ExitWindowsEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExitWindowsEx([NativeTypeName("UINT")] uint uFlags, [NativeTypeName("DWORD")] uint dwReason);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SwapMouseButton", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SwapMouseButton([NativeTypeName("BOOL")] int fSwap);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMessagePos", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetMessagePos();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMessageTime", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetMessageTime();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMessageExtraInfo", ExactSpelling = true)]
        [return: NativeTypeName("LPARAM")]
        public static extern IntPtr GetMessageExtraInfo();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetUnpredictedMessagePos", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetUnpredictedMessagePos();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsWow64Message", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWow64Message();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetMessageExtraInfo", ExactSpelling = true)]
        [return: NativeTypeName("LPARAM")]
        public static extern IntPtr SetMessageExtraInfo([NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SendMessageW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern IntPtr SendMessage([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SendMessageTimeoutW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern IntPtr SendMessageTimeout([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam, [NativeTypeName("UINT")] uint fuFlags, [NativeTypeName("UINT")] uint uTimeout, [NativeTypeName("PDWORD_PTR")] UIntPtr* lpdwResult);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SendNotifyMessageW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SendNotifyMessage([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SendMessageCallbackW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SendMessageCallback([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam, [NativeTypeName("SENDASYNCPROC")] IntPtr lpResultCallBack, [NativeTypeName("ULONG_PTR")] UIntPtr dwData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "BroadcastSystemMessageExW", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageEx([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam, [NativeTypeName("PBSMINFO")] BSMINFO* pbsmInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "BroadcastSystemMessageW", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessage([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RegisterDeviceNotificationW", ExactSpelling = true)]
        [return: NativeTypeName("HDEVNOTIFY")]
        public static extern void* RegisterDeviceNotification([NativeTypeName("HANDLE")] void* hRecipient, [NativeTypeName("LPVOID")] void* NotificationFilter, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnregisterDeviceNotification", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterDeviceNotification([NativeTypeName("HDEVNOTIFY")] void* Handle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RegisterPowerSettingNotification", ExactSpelling = true)]
        [return: NativeTypeName("HPOWERNOTIFY")]
        public static extern void* RegisterPowerSettingNotification([NativeTypeName("HANDLE")] void* hRecipient, [NativeTypeName("LPCGUID")] Guid* PowerSettingGuid, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnregisterPowerSettingNotification", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterPowerSettingNotification([NativeTypeName("HPOWERNOTIFY")] void* Handle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RegisterSuspendResumeNotification", ExactSpelling = true)]
        [return: NativeTypeName("HPOWERNOTIFY")]
        public static extern void* RegisterSuspendResumeNotification([NativeTypeName("HANDLE")] void* hRecipient, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnregisterSuspendResumeNotification", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterSuspendResumeNotification([NativeTypeName("HPOWERNOTIFY")] void* Handle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PostMessageW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PostMessage([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PostThreadMessageW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PostThreadMessage([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AttachThreadInput", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AttachThreadInput([NativeTypeName("DWORD")] uint idAttach, [NativeTypeName("DWORD")] uint idAttachTo, [NativeTypeName("BOOL")] int fAttach);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ReplyMessage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReplyMessage([NativeTypeName("LRESULT")] IntPtr lResult);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WaitMessage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WaitMessage();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WaitForInputIdle", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WaitForInputIdle([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DefWindowProcW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern IntPtr DefWindowProc([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PostQuitMessage", ExactSpelling = true)]
        public static extern void PostQuitMessage(int nExitCode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CallWindowProcW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern IntPtr CallWindowProc([NativeTypeName("WNDPROC")] IntPtr lpPrevWndFunc, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InSendMessage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InSendMessage();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InSendMessageEx", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint InSendMessageEx([NativeTypeName("LPVOID")] void* lpReserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDoubleClickTime", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDoubleClickTime();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetDoubleClickTime", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDoubleClickTime([NativeTypeName("UINT")] uint param0);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RegisterClassW", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClass([NativeTypeName("const WNDCLASSW *")] WNDCLASS* lpWndClass);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnregisterClassW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterClass([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("HINSTANCE")] IntPtr hInstance);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClassInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClassInfo([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPWNDCLASSW")] WNDCLASS* lpWndClass);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RegisterClassExW", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassEx([NativeTypeName("const WNDCLASSEXW *")] WNDCLASSEX* param0);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClassInfoExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClassInfoEx([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpszClass, [NativeTypeName("LPWNDCLASSEXW")] WNDCLASSEX* lpwcx);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateWindowExW", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateWindowEx([NativeTypeName("DWORD")] uint dwExStyle, [NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPVOID")] void* lpParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsMenu", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsMenu([NativeTypeName("HMENU")] IntPtr hMenu);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsChild", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsChild([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DestroyWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ShowWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowWindow([NativeTypeName("HWND")] IntPtr hWnd, int nCmdShow);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AnimateWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AnimateWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("DWORD")] uint dwTime, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UpdateLayeredWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateLayeredWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HDC")] IntPtr hdcDst, [NativeTypeName("POINT *")] POINT* pptDst, [NativeTypeName("SIZE *")] SIZE* psize, [NativeTypeName("HDC")] IntPtr hdcSrc, [NativeTypeName("POINT *")] POINT* pptSrc, [NativeTypeName("COLORREF")] uint crKey, [NativeTypeName("BLENDFUNCTION *")] BLENDFUNCTION* pblend, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UpdateLayeredWindowIndirect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateLayeredWindowIndirect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const UPDATELAYEREDWINDOWINFO *")] UPDATELAYEREDWINDOWINFO* pULWInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetLayeredWindowAttributes", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLayeredWindowAttributes([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("COLORREF *")] uint* pcrKey, [NativeTypeName("BYTE *")] byte* pbAlpha, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PrintWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PrintWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HDC")] IntPtr hdcBlt, [NativeTypeName("UINT")] uint nFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetLayeredWindowAttributes", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetLayeredWindowAttributes([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("COLORREF")] uint crKey, [NativeTypeName("BYTE")] byte bAlpha, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ShowWindowAsync", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowWindowAsync([NativeTypeName("HWND")] IntPtr hWnd, int nCmdShow);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FlashWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlashWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("BOOL")] int bInvert);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FlashWindowEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlashWindowEx([NativeTypeName("PFLASHWINFO")] FLASHWINFO* pfwi);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ShowOwnedPopups", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowOwnedPopups([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("BOOL")] int fShow);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OpenIcon", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenIcon([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CloseWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MoveWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveWindow([NativeTypeName("HWND")] IntPtr hWnd, int X, int Y, int nWidth, int nHeight, [NativeTypeName("BOOL")] int bRepaint);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowPos", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowPos([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HWND")] IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, [NativeTypeName("UINT")] uint uFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowPlacement", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowPlacement([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("WINDOWPLACEMENT *")] WINDOWPLACEMENT* lpwndpl);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowPlacement", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowPlacement([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const WINDOWPLACEMENT *")] WINDOWPLACEMENT* lpwndpl);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowDisplayAffinity", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowDisplayAffinity([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("DWORD *")] uint* pdwAffinity);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowDisplayAffinity", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowDisplayAffinity([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("DWORD")] uint dwAffinity);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "BeginDeferWindowPos", ExactSpelling = true)]
        [return: NativeTypeName("HDWP")]
        public static extern void* BeginDeferWindowPos(int nNumWindows);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DeferWindowPos", ExactSpelling = true)]
        [return: NativeTypeName("HDWP")]
        public static extern void* DeferWindowPos([NativeTypeName("HDWP")] void* hWinPosInfo, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HWND")] IntPtr hWndInsertAfter, int x, int y, int cx, int cy, [NativeTypeName("UINT")] uint uFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EndDeferWindowPos", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndDeferWindowPos([NativeTypeName("HDWP")] void* hWinPosInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsWindowVisible", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindowVisible([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsIconic", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsIconic([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AnyPopup", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AnyPopup();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "BringWindowToTop", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BringWindowToTop([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsZoomed", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsZoomed([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateDialogParamW", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateDialogParam([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTemplateName, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] IntPtr lpDialogFunc, [NativeTypeName("LPARAM")] IntPtr dwInitParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateDialogIndirectParamW", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateDialogIndirectParam([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] IntPtr lpDialogFunc, [NativeTypeName("LPARAM")] IntPtr dwInitParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DialogBoxParamW", ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern IntPtr DialogBoxParam([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTemplateName, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] IntPtr lpDialogFunc, [NativeTypeName("LPARAM")] IntPtr dwInitParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DialogBoxIndirectParamW", ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern IntPtr DialogBoxIndirectParam([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* hDialogTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] IntPtr lpDialogFunc, [NativeTypeName("LPARAM")] IntPtr dwInitParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EndDialog", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndDialog([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("INT_PTR")] IntPtr nResult);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDlgItem", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetDlgItem([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetDlgItemInt", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDlgItemInt([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("UINT")] uint uValue, [NativeTypeName("BOOL")] int bSigned);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDlgItemInt", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDlgItemInt([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("BOOL *")] int* lpTranslated, [NativeTypeName("BOOL")] int bSigned);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetDlgItemTextW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDlgItemText([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDlgItemTextW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDlgItemText([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("LPWSTR")] ushort* lpString, int cchMax);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CheckDlgButton", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckDlgButton([NativeTypeName("HWND")] IntPtr hDlg, int nIDButton, [NativeTypeName("UINT")] uint uCheck);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CheckRadioButton", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckRadioButton([NativeTypeName("HWND")] IntPtr hDlg, int nIDFirstButton, int nIDLastButton, int nIDCheckButton);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsDlgButtonChecked", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint IsDlgButtonChecked([NativeTypeName("HWND")] IntPtr hDlg, int nIDButton);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SendDlgItemMessageW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern IntPtr SendDlgItemMessage([NativeTypeName("HWND")] IntPtr hDlg, int nIDDlgItem, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetNextDlgGroupItem", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetNextDlgGroupItem([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("HWND")] IntPtr hCtl, [NativeTypeName("BOOL")] int bPrevious);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetNextDlgTabItem", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetNextDlgTabItem([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("HWND")] IntPtr hCtl, [NativeTypeName("BOOL")] int bPrevious);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDlgCtrlID", ExactSpelling = true)]
        public static extern int GetDlgCtrlID([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDialogBaseUnits", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int GetDialogBaseUnits();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DefDlgProcW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern IntPtr DefDlgProc([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetDialogControlDpiChangeBehavior", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDialogControlDpiChangeBehavior([NativeTypeName("HWND")] IntPtr hWnd, DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS mask, DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS values);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDialogControlDpiChangeBehavior", ExactSpelling = true)]
        public static extern DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS GetDialogControlDpiChangeBehavior([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetDialogDpiChangeBehavior", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDialogDpiChangeBehavior([NativeTypeName("HWND")] IntPtr hDlg, DIALOG_DPI_CHANGE_BEHAVIORS mask, DIALOG_DPI_CHANGE_BEHAVIORS values);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDialogDpiChangeBehavior", ExactSpelling = true)]
        public static extern DIALOG_DPI_CHANGE_BEHAVIORS GetDialogDpiChangeBehavior([NativeTypeName("HWND")] IntPtr hDlg);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CallMsgFilterW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CallMsgFilter([NativeTypeName("LPMSG")] MSG* lpMsg, int nCode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OpenClipboard", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenClipboard([NativeTypeName("HWND")] IntPtr hWndNewOwner);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CloseClipboard", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseClipboard();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClipboardSequenceNumber", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetClipboardSequenceNumber();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClipboardOwner", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetClipboardOwner();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetClipboardViewer", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr SetClipboardViewer([NativeTypeName("HWND")] IntPtr hWndNewViewer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClipboardViewer", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetClipboardViewer();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ChangeClipboardChain", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeClipboardChain([NativeTypeName("HWND")] IntPtr hWndRemove, [NativeTypeName("HWND")] IntPtr hWndNewNext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetClipboardData", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* SetClipboardData([NativeTypeName("UINT")] uint uFormat, [NativeTypeName("HANDLE")] void* hMem);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClipboardData", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* GetClipboardData([NativeTypeName("UINT")] uint uFormat);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RegisterClipboardFormatW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RegisterClipboardFormat([NativeTypeName("LPCWSTR")] ushort* lpszFormat);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CountClipboardFormats", ExactSpelling = true)]
        public static extern int CountClipboardFormats();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumClipboardFormats", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint EnumClipboardFormats([NativeTypeName("UINT")] uint format);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClipboardFormatNameW", ExactSpelling = true)]
        public static extern int GetClipboardFormatName([NativeTypeName("UINT")] uint format, [NativeTypeName("LPWSTR")] ushort* lpszFormatName, int cchMaxCount);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EmptyClipboard", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EmptyClipboard();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsClipboardFormatAvailable", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsClipboardFormatAvailable([NativeTypeName("UINT")] uint format);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPriorityClipboardFormat", ExactSpelling = true)]
        public static extern int GetPriorityClipboardFormat([NativeTypeName("UINT *")] uint* paFormatPriorityList, int cFormats);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetOpenClipboardWindow", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetOpenClipboardWindow();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AddClipboardFormatListener", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddClipboardFormatListener([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RemoveClipboardFormatListener", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveClipboardFormatListener([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetUpdatedClipboardFormats", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUpdatedClipboardFormats([NativeTypeName("PUINT")] uint* lpuiFormats, [NativeTypeName("UINT")] uint cFormats, [NativeTypeName("PUINT")] uint* pcFormatsOut);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CharToOemW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CharToOem([NativeTypeName("LPCWSTR")] ushort* pSrc, [NativeTypeName("LPSTR")] sbyte* pDst);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OemToCharW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OemToChar([NativeTypeName("LPCSTR")] sbyte* pSrc, [NativeTypeName("LPWSTR")] ushort* pDst);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CharToOemBuffW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CharToOemBuff([NativeTypeName("LPCWSTR")] ushort* lpszSrc, [NativeTypeName("LPSTR")] sbyte* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OemToCharBuffW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OemToCharBuff([NativeTypeName("LPCSTR")] sbyte* lpszSrc, [NativeTypeName("LPWSTR")] ushort* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CharUpperW", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* CharUpper([NativeTypeName("LPWSTR")] ushort* lpsz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CharUpperBuffW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CharUpperBuff([NativeTypeName("LPWSTR")] ushort* lpsz, [NativeTypeName("DWORD")] uint cchLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CharLowerW", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* CharLower([NativeTypeName("LPWSTR")] ushort* lpsz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CharLowerBuffW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CharLowerBuff([NativeTypeName("LPWSTR")] ushort* lpsz, [NativeTypeName("DWORD")] uint cchLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CharNextW", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* CharNext([NativeTypeName("LPCWSTR")] ushort* lpsz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CharPrevW", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* CharPrev([NativeTypeName("LPCWSTR")] ushort* lpszStart, [NativeTypeName("LPCWSTR")] ushort* lpszCurrent);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsCharAlphaW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharAlpha([NativeTypeName("WCHAR")] ushort ch);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsCharAlphaNumericW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharAlphaNumeric([NativeTypeName("WCHAR")] ushort ch);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsCharUpperW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharUpper([NativeTypeName("WCHAR")] ushort ch);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsCharLowerW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharLower([NativeTypeName("WCHAR")] ushort ch);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetFocus", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr SetFocus([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetActiveWindow", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetActiveWindow();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFocus", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetFocus();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetKBCodePage", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetKBCodePage();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetKeyState", ExactSpelling = true)]
        [return: NativeTypeName("SHORT")]
        public static extern short GetKeyState(int nVirtKey);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetAsyncKeyState", ExactSpelling = true)]
        [return: NativeTypeName("SHORT")]
        public static extern short GetAsyncKeyState(int vKey);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetKeyboardState", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetKeyboardState([NativeTypeName("PBYTE")] byte* lpKeyState);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetKeyboardState", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetKeyboardState([NativeTypeName("LPBYTE")] byte* lpKeyState);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetKeyNameTextW", ExactSpelling = true)]
        public static extern int GetKeyNameText([NativeTypeName("LONG")] int lParam, [NativeTypeName("LPWSTR")] ushort* lpString, int cchSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetKeyboardType", ExactSpelling = true)]
        public static extern int GetKeyboardType(int nTypeFlag);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ToAscii", ExactSpelling = true)]
        public static extern int ToAscii([NativeTypeName("UINT")] uint uVirtKey, [NativeTypeName("UINT")] uint uScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWORD")] ushort* lpChar, [NativeTypeName("UINT")] uint uFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ToAsciiEx", ExactSpelling = true)]
        public static extern int ToAsciiEx([NativeTypeName("UINT")] uint uVirtKey, [NativeTypeName("UINT")] uint uScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWORD")] ushort* lpChar, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("HKL")] IntPtr dwhkl);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ToUnicode", ExactSpelling = true)]
        public static extern int ToUnicode([NativeTypeName("UINT")] uint wVirtKey, [NativeTypeName("UINT")] uint wScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWSTR")] ushort* pwszBuff, int cchBuff, [NativeTypeName("UINT")] uint wFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OemKeyScan", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint OemKeyScan([NativeTypeName("WORD")] ushort wOemChar);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "VkKeyScanW", ExactSpelling = true)]
        [return: NativeTypeName("SHORT")]
        public static extern short VkKeyScan([NativeTypeName("WCHAR")] ushort ch);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "VkKeyScanExW", ExactSpelling = true)]
        [return: NativeTypeName("SHORT")]
        public static extern short VkKeyScanEx([NativeTypeName("WCHAR")] ushort ch, [NativeTypeName("HKL")] IntPtr dwhkl);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "keybd_event", ExactSpelling = true)]
        public static extern void keybd_event([NativeTypeName("BYTE")] byte bVk, [NativeTypeName("BYTE")] byte bScan, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG_PTR")] UIntPtr dwExtraInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "mouse_event", ExactSpelling = true)]
        public static extern void mouse_event([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dx, [NativeTypeName("DWORD")] uint dy, [NativeTypeName("DWORD")] uint dwData, [NativeTypeName("ULONG_PTR")] UIntPtr dwExtraInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SendInput", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SendInput([NativeTypeName("UINT")] uint cInputs, [NativeTypeName("LPINPUT")] INPUT* pInputs, int cbSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTouchInputInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTouchInputInfo([NativeTypeName("HTOUCHINPUT")] IntPtr hTouchInput, [NativeTypeName("UINT")] uint cInputs, [NativeTypeName("PTOUCHINPUT")] TOUCHINPUT* pInputs, int cbSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CloseTouchInputHandle", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseTouchInputHandle([NativeTypeName("HTOUCHINPUT")] IntPtr hTouchInput);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RegisterTouchWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterTouchWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("ULONG")] uint ulFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnregisterTouchWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterTouchWindow([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsTouchWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsTouchWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("PULONG")] uint* pulFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InitializeTouchInjection", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeTouchInjection([NativeTypeName("UINT32")] uint maxCount, [NativeTypeName("DWORD")] uint dwMode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InjectTouchInput", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InjectTouchInput([NativeTypeName("UINT32")] uint count, [NativeTypeName("const POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* contacts);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerType", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerType([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_INPUT_TYPE *")] uint* pointerType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerCursorId", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerCursorId([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* cursorId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_INFO *")] POINTER_INFO* pointerInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerInfoHistory", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("POINTER_INFO *")] POINTER_INFO* pointerInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerFrameInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFrameInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_INFO *")] POINTER_INFO* pointerInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerFrameInfoHistory", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFrameInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_INFO *")] POINTER_INFO* pointerInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerTouchInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerTouchInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* touchInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerTouchInfoHistory", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerTouchInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* touchInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerFrameTouchInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFrameTouchInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* touchInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerFrameTouchInfoHistory", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFrameTouchInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* touchInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerPenInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerPenInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_PEN_INFO *")] POINTER_PEN_INFO* penInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerPenInfoHistory", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerPenInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("POINTER_PEN_INFO *")] POINTER_PEN_INFO* penInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerFramePenInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFramePenInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_PEN_INFO *")] POINTER_PEN_INFO* penInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerFramePenInfoHistory", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFramePenInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_PEN_INFO *")] POINTER_PEN_INFO* penInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SkipPointerFrameMessages", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SkipPointerFrameMessages([NativeTypeName("UINT32")] uint pointerId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RegisterPointerInputTarget", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterPointerInputTarget([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnregisterPointerInputTarget", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterPointerInputTarget([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RegisterPointerInputTargetEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterPointerInputTargetEx([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType, [NativeTypeName("BOOL")] int fObserve);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnregisterPointerInputTargetEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterPointerInputTargetEx([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnableMouseInPointer", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableMouseInPointer([NativeTypeName("BOOL")] int fEnable);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsMouseInPointerEnabled", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsMouseInPointerEnabled();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RegisterTouchHitTestingWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterTouchHitTestingWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("ULONG")] uint value);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EvaluateProximityToRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EvaluateProximityToRect([NativeTypeName("const RECT *")] RECT* controlBoundingBox, [NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] TOUCH_HIT_TESTING_INPUT* pHitTestingInput, [NativeTypeName("TOUCH_HIT_TESTING_PROXIMITY_EVALUATION *")] TOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EvaluateProximityToPolygon", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EvaluateProximityToPolygon([NativeTypeName("UINT32")] uint numVertices, [NativeTypeName("const POINT *")] POINT* controlPolygon, [NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] TOUCH_HIT_TESTING_INPUT* pHitTestingInput, [NativeTypeName("TOUCH_HIT_TESTING_PROXIMITY_EVALUATION *")] TOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PackTouchHitTestingProximityEvaluation", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern IntPtr PackTouchHitTestingProximityEvaluation([NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] TOUCH_HIT_TESTING_INPUT* pHitTestingInput, [NativeTypeName("const TOUCH_HIT_TESTING_PROXIMITY_EVALUATION *")] TOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowFeedbackSetting", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowFeedbackSetting([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("FEEDBACK_TYPE")] FEEDBACK_TYPE feedback, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("UINT32 *")] uint* pSize, [NativeTypeName("void *")] void* config);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowFeedbackSetting", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowFeedbackSetting([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("FEEDBACK_TYPE")] FEEDBACK_TYPE feedback, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("UINT32")] uint size, [NativeTypeName("const void *")] void* configuration);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerInputTransform", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerInputTransform([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint historyCount, [NativeTypeName("INPUT_TRANSFORM *")] INPUT_TRANSFORM* inputTransform);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetLastInputInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLastInputInfo([NativeTypeName("PLASTINPUTINFO")] LASTINPUTINFO* plii);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MapVirtualKeyW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MapVirtualKey([NativeTypeName("UINT")] uint uCode, [NativeTypeName("UINT")] uint uMapType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MapVirtualKeyExW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MapVirtualKeyEx([NativeTypeName("UINT")] uint uCode, [NativeTypeName("UINT")] uint uMapType, [NativeTypeName("HKL")] IntPtr dwhkl);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetInputState", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetInputState();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetQueueStatus", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetQueueStatus([NativeTypeName("UINT")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCapture", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetCapture();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetCapture", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr SetCapture([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ReleaseCapture", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReleaseCapture();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MsgWaitForMultipleObjects", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MsgWaitForMultipleObjects([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] void** pHandles, [NativeTypeName("BOOL")] int fWaitAll, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("DWORD")] uint dwWakeMask);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MsgWaitForMultipleObjectsEx", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MsgWaitForMultipleObjectsEx([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] void** pHandles, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("DWORD")] uint dwWakeMask, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetTimer", ExactSpelling = true)]
        [return: NativeTypeName("UINT_PTR")]
        public static extern UIntPtr SetTimer([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT_PTR")] UIntPtr nIDEvent, [NativeTypeName("UINT")] uint uElapse, [NativeTypeName("TIMERPROC")] IntPtr lpTimerFunc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetCoalescableTimer", ExactSpelling = true)]
        [return: NativeTypeName("UINT_PTR")]
        public static extern UIntPtr SetCoalescableTimer([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT_PTR")] UIntPtr nIDEvent, [NativeTypeName("UINT")] uint uElapse, [NativeTypeName("TIMERPROC")] IntPtr lpTimerFunc, [NativeTypeName("ULONG")] uint uToleranceDelay);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "KillTimer", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int KillTimer([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT_PTR")] UIntPtr uIDEvent);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsWindowUnicode", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindowUnicode([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnableWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("BOOL")] int bEnable);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsWindowEnabled", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindowEnabled([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadAcceleratorsW", ExactSpelling = true)]
        [return: NativeTypeName("HACCEL")]
        public static extern IntPtr LoadAccelerators([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTableName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateAcceleratorTableW", ExactSpelling = true)]
        [return: NativeTypeName("HACCEL")]
        public static extern IntPtr CreateAcceleratorTable([NativeTypeName("LPACCEL")] ACCEL* paccel, int cAccel);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DestroyAcceleratorTable", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyAcceleratorTable([NativeTypeName("HACCEL")] IntPtr hAccel);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CopyAcceleratorTableW", ExactSpelling = true)]
        public static extern int CopyAcceleratorTable([NativeTypeName("HACCEL")] IntPtr hAccelSrc, [NativeTypeName("LPACCEL")] ACCEL* lpAccelDst, int cAccelEntries);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TranslateAcceleratorW", ExactSpelling = true)]
        public static extern int TranslateAccelerator([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HACCEL")] IntPtr hAccTable, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemMetrics", ExactSpelling = true)]
        public static extern int GetSystemMetrics(int nIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemMetricsForDpi", ExactSpelling = true)]
        public static extern int GetSystemMetricsForDpi(int nIndex, [NativeTypeName("UINT")] uint dpi);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadMenuW", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr LoadMenu([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpMenuName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadMenuIndirectW", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr LoadMenuIndirect([NativeTypeName("const MENUTEMPLATEW *")] void* lpMenuTemplate);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMenu", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr GetMenu([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetMenu", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenu([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HMENU")] IntPtr hMenu);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ChangeMenuW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeMenu([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint cmd, [NativeTypeName("LPCWSTR")] ushort* lpszNewItem, [NativeTypeName("UINT")] uint cmdInsert, [NativeTypeName("UINT")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "HiliteMenuItem", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HiliteMenuItem([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uIDHiliteItem, [NativeTypeName("UINT")] uint uHilite);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMenuStringW", ExactSpelling = true)]
        public static extern int GetMenuString([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uIDItem, [NativeTypeName("LPWSTR")] ushort* lpString, int cchMax, [NativeTypeName("UINT")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMenuState", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetMenuState([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uId, [NativeTypeName("UINT")] uint uFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DrawMenuBar", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawMenuBar([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemMenu", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr GetSystemMenu([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("BOOL")] int bRevert);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateMenu", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr CreateMenu();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreatePopupMenu", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr CreatePopupMenu();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DestroyMenu", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyMenu([NativeTypeName("HMENU")] IntPtr hMenu);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CheckMenuItem", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CheckMenuItem([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uIDCheckItem, [NativeTypeName("UINT")] uint uCheck);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnableMenuItem", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableMenuItem([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uIDEnableItem, [NativeTypeName("UINT")] uint uEnable);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSubMenu", ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern IntPtr GetSubMenu([NativeTypeName("HMENU")] IntPtr hMenu, int nPos);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMenuItemID", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetMenuItemID([NativeTypeName("HMENU")] IntPtr hMenu, int nPos);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMenuItemCount", ExactSpelling = true)]
        public static extern int GetMenuItemCount([NativeTypeName("HMENU")] IntPtr hMenu);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InsertMenuW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InsertMenu([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("UINT_PTR")] UIntPtr uIDNewItem, [NativeTypeName("LPCWSTR")] ushort* lpNewItem);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AppendMenuW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AppendMenu([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("UINT_PTR")] UIntPtr uIDNewItem, [NativeTypeName("LPCWSTR")] ushort* lpNewItem);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ModifyMenuW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ModifyMenu([NativeTypeName("HMENU")] IntPtr hMnu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("UINT_PTR")] UIntPtr uIDNewItem, [NativeTypeName("LPCWSTR")] ushort* lpNewItem);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RemoveMenu", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveMenu([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DeleteMenu", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteMenu([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetMenuItemBitmaps", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuItemBitmaps([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uPosition, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("HBITMAP")] IntPtr hBitmapUnchecked, [NativeTypeName("HBITMAP")] IntPtr hBitmapChecked);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMenuCheckMarkDimensions", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetMenuCheckMarkDimensions();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TrackPopupMenu", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TrackPopupMenu([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uFlags, int x, int y, int nReserved, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const RECT *")] RECT* prcRect);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TrackPopupMenuEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TrackPopupMenuEx([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uFlags, int x, int y, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPTPMPARAMS")] TPMPARAMS* lptpm);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CalculatePopupWindowPosition", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CalculatePopupWindowPosition([NativeTypeName("const POINT *")] POINT* anchorPoint, [NativeTypeName("const SIZE *")] SIZE* windowSize, [NativeTypeName("UINT")] uint flags, [NativeTypeName("RECT *")] RECT* excludeRect, [NativeTypeName("RECT *")] RECT* popupWindowPosition);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMenuInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuInfo([NativeTypeName("HMENU")] IntPtr param0, [NativeTypeName("LPMENUINFO")] MENUINFO* param1);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetMenuInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuInfo([NativeTypeName("HMENU")] IntPtr param0, [NativeTypeName("LPCMENUINFO")] MENUINFO* param1);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EndMenu", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndMenu();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InsertMenuItemW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InsertMenuItem([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint item, [NativeTypeName("BOOL")] int fByPosition, [NativeTypeName("LPCMENUITEMINFOW")] MENUITEMINFO* lpmi);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMenuItemInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuItemInfo([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint item, [NativeTypeName("BOOL")] int fByPosition, [NativeTypeName("LPMENUITEMINFOW")] MENUITEMINFO* lpmii);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetMenuItemInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuItemInfo([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint item, [NativeTypeName("BOOL")] int fByPositon, [NativeTypeName("LPCMENUITEMINFOW")] MENUITEMINFO* lpmii);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMenuDefaultItem", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetMenuDefaultItem([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint fByPos, [NativeTypeName("UINT")] uint gmdiFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetMenuDefaultItem", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuDefaultItem([NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uItem, [NativeTypeName("UINT")] uint fByPos);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMenuItemRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuItemRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("UINT")] uint uItem, [NativeTypeName("LPRECT")] RECT* lprcItem);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MenuItemFromPoint", ExactSpelling = true)]
        public static extern int MenuItemFromPoint([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HMENU")] IntPtr hMenu, POINT ptScreen);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DragObject", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DragObject([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("HWND")] IntPtr hwndFrom, [NativeTypeName("UINT")] uint fmt, [NativeTypeName("ULONG_PTR")] UIntPtr data, [NativeTypeName("HCURSOR")] IntPtr hcur);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DragDetect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DragDetect([NativeTypeName("HWND")] IntPtr hwnd, POINT pt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DrawIcon", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawIcon([NativeTypeName("HDC")] IntPtr hDC, int X, int Y, [NativeTypeName("HICON")] IntPtr hIcon);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DrawTextW", ExactSpelling = true)]
        public static extern int DrawText([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, [NativeTypeName("UINT")] uint format);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DrawTextExW", ExactSpelling = true)]
        public static extern int DrawTextEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPWSTR")] ushort* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, [NativeTypeName("UINT")] uint format, [NativeTypeName("LPDRAWTEXTPARAMS")] DRAWTEXTPARAMS* lpdtp);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GrayStringW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GrayString([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("HBRUSH")] IntPtr hBrush, [NativeTypeName("GRAYSTRINGPROC")] IntPtr lpOutputFunc, [NativeTypeName("LPARAM")] IntPtr lpData, int nCount, int X, int Y, int nWidth, int nHeight);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DrawStateW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawState([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HBRUSH")] IntPtr hbrFore, [NativeTypeName("DRAWSTATEPROC")] IntPtr qfnCallBack, [NativeTypeName("LPARAM")] IntPtr lData, [NativeTypeName("WPARAM")] UIntPtr wData, int x, int y, int cx, int cy, [NativeTypeName("UINT")] uint uFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TabbedTextOutW", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int TabbedTextOut([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPCWSTR")] ushort* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions, int nTabOrigin);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTabbedTextExtentW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTabbedTextExtent([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UpdateWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetActiveWindow", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr SetActiveWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetForegroundWindow", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PaintDesktop", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PaintDesktop([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SwitchToThisWindow", ExactSpelling = true)]
        public static extern void SwitchToThisWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("BOOL")] int fUnknown);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetForegroundWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetForegroundWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AllowSetForegroundWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AllowSetForegroundWindow([NativeTypeName("DWORD")] uint dwProcessId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LockSetForegroundWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockSetForegroundWindow([NativeTypeName("UINT")] uint uLockCode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WindowFromDC", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr WindowFromDC([NativeTypeName("HDC")] IntPtr hDC);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDC", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr GetDC([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDCEx", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr GetDCEx([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hrgnClip, [NativeTypeName("DWORD")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowDC", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr GetWindowDC([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ReleaseDC", ExactSpelling = true)]
        public static extern int ReleaseDC([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HDC")] IntPtr hDC);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "BeginPaint", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr BeginPaint([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPAINTSTRUCT")] PAINTSTRUCT* lpPaint);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EndPaint", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndPaint([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const PAINTSTRUCT *")] PAINTSTRUCT* lpPaint);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetUpdateRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUpdateRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("BOOL")] int bErase);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetUpdateRgn", ExactSpelling = true)]
        public static extern int GetUpdateRgn([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hRgn, [NativeTypeName("BOOL")] int bErase);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowRgn", ExactSpelling = true)]
        public static extern int SetWindowRgn([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hRgn, [NativeTypeName("BOOL")] int bRedraw);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowRgn", ExactSpelling = true)]
        public static extern int GetWindowRgn([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hRgn);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowRgnBox", ExactSpelling = true)]
        public static extern int GetWindowRgnBox([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPRECT")] RECT* lprc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ExcludeUpdateRgn", ExactSpelling = true)]
        public static extern int ExcludeUpdateRgn([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InvalidateRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InvalidateRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const RECT *")] RECT* lpRect, [NativeTypeName("BOOL")] int bErase);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ValidateRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ValidateRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const RECT *")] RECT* lpRect);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InvalidateRgn", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InvalidateRgn([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hRgn, [NativeTypeName("BOOL")] int bErase);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ValidateRgn", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ValidateRgn([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HRGN")] IntPtr hRgn);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RedrawWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RedrawWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const RECT *")] RECT* lprcUpdate, [NativeTypeName("HRGN")] IntPtr hrgnUpdate, [NativeTypeName("UINT")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LockWindowUpdate", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockWindowUpdate([NativeTypeName("HWND")] IntPtr hWndLock);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ScrollWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScrollWindow([NativeTypeName("HWND")] IntPtr hWnd, int XAmount, int YAmount, [NativeTypeName("const RECT *")] RECT* lpRect, [NativeTypeName("const RECT *")] RECT* lpClipRect);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ScrollDC", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScrollDC([NativeTypeName("HDC")] IntPtr hDC, int dx, int dy, [NativeTypeName("const RECT *")] RECT* lprcScroll, [NativeTypeName("const RECT *")] RECT* lprcClip, [NativeTypeName("HRGN")] IntPtr hrgnUpdate, [NativeTypeName("LPRECT")] RECT* lprcUpdate);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ScrollWindowEx", ExactSpelling = true)]
        public static extern int ScrollWindowEx([NativeTypeName("HWND")] IntPtr hWnd, int dx, int dy, [NativeTypeName("const RECT *")] RECT* prcScroll, [NativeTypeName("const RECT *")] RECT* prcClip, [NativeTypeName("HRGN")] IntPtr hrgnUpdate, [NativeTypeName("LPRECT")] RECT* prcUpdate, [NativeTypeName("UINT")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetScrollPos", ExactSpelling = true)]
        public static extern int SetScrollPos([NativeTypeName("HWND")] IntPtr hWnd, int nBar, int nPos, [NativeTypeName("BOOL")] int bRedraw);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetScrollPos", ExactSpelling = true)]
        public static extern int GetScrollPos([NativeTypeName("HWND")] IntPtr hWnd, int nBar);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetScrollRange", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetScrollRange([NativeTypeName("HWND")] IntPtr hWnd, int nBar, int nMinPos, int nMaxPos, [NativeTypeName("BOOL")] int bRedraw);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetScrollRange", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetScrollRange([NativeTypeName("HWND")] IntPtr hWnd, int nBar, [NativeTypeName("LPINT")] int* lpMinPos, [NativeTypeName("LPINT")] int* lpMaxPos);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ShowScrollBar", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowScrollBar([NativeTypeName("HWND")] IntPtr hWnd, int wBar, [NativeTypeName("BOOL")] int bShow);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnableScrollBar", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableScrollBar([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint wSBflags, [NativeTypeName("UINT")] uint wArrows);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetPropW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProp([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("HANDLE")] void* hData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPropW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* GetProp([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RemovePropW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* RemoveProp([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumPropsExW", ExactSpelling = true)]
        public static extern int EnumPropsEx([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("PROPENUMPROCEXW")] IntPtr lpEnumFunc, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumPropsW", ExactSpelling = true)]
        public static extern int EnumProps([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("PROPENUMPROCW")] IntPtr lpEnumFunc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowTextW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowText([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowTextW", ExactSpelling = true)]
        public static extern int GetWindowText([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPWSTR")] ushort* lpString, int nMaxCount);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowTextLengthW", ExactSpelling = true)]
        public static extern int GetWindowTextLength([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClientRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClientRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AdjustWindowRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AdjustWindowRect([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("BOOL")] int bMenu);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AdjustWindowRectEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AdjustWindowRectEx([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("BOOL")] int bMenu, [NativeTypeName("DWORD")] uint dwExStyle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AdjustWindowRectExForDpi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AdjustWindowRectExForDpi([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("BOOL")] int bMenu, [NativeTypeName("DWORD")] uint dwExStyle, [NativeTypeName("UINT")] uint dpi);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowContextHelpId", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowContextHelpId([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("DWORD")] uint param1);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowContextHelpId", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetWindowContextHelpId([NativeTypeName("HWND")] IntPtr param0);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetMenuContextHelpId", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuContextHelpId([NativeTypeName("HMENU")] IntPtr param0, [NativeTypeName("DWORD")] uint param1);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMenuContextHelpId", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetMenuContextHelpId([NativeTypeName("HMENU")] IntPtr param0);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MessageBoxW", ExactSpelling = true)]
        public static extern int MessageBox([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpText, [NativeTypeName("LPCWSTR")] ushort* lpCaption, [NativeTypeName("UINT")] uint uType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MessageBoxExW", ExactSpelling = true)]
        public static extern int MessageBoxEx([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* lpText, [NativeTypeName("LPCWSTR")] ushort* lpCaption, [NativeTypeName("UINT")] uint uType, [NativeTypeName("WORD")] ushort wLanguageId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MessageBoxIndirectW", ExactSpelling = true)]
        public static extern int MessageBoxIndirect([NativeTypeName("const MSGBOXPARAMSW *")] MSGBOXPARAMS* lpmbp);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MessageBeep", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MessageBeep([NativeTypeName("UINT")] uint uType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ShowCursor", ExactSpelling = true)]
        public static extern int ShowCursor([NativeTypeName("BOOL")] int bShow);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetCursorPos", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCursorPos(int X, int Y);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetPhysicalCursorPos", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPhysicalCursorPos(int X, int Y);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetCursor", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr SetCursor([NativeTypeName("HCURSOR")] IntPtr hCursor);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCursorPos", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCursorPos([NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPhysicalCursorPos", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPhysicalCursorPos([NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClipCursor", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClipCursor([NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCursor", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr GetCursor();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateCaret", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateCaret([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HBITMAP")] IntPtr hBitmap, int nWidth, int nHeight);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCaretBlinkTime", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetCaretBlinkTime();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetCaretBlinkTime", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCaretBlinkTime([NativeTypeName("UINT")] uint uMSeconds);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DestroyCaret", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyCaret();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "HideCaret", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HideCaret([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ShowCaret", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowCaret([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetCaretPos", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCaretPos(int X, int Y);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCaretPos", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCaretPos([NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ClientToScreen", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClientToScreen([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ScreenToClient", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScreenToClient([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LogicalToPhysicalPoint", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogicalToPhysicalPoint([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PhysicalToLogicalPoint", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PhysicalToLogicalPoint([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LogicalToPhysicalPointForPerMonitorDPI", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogicalToPhysicalPointForPerMonitorDPI([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PhysicalToLogicalPointForPerMonitorDPI", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PhysicalToLogicalPointForPerMonitorDPI([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MapWindowPoints", ExactSpelling = true)]
        public static extern int MapWindowPoints([NativeTypeName("HWND")] IntPtr hWndFrom, [NativeTypeName("HWND")] IntPtr hWndTo, [NativeTypeName("LPPOINT")] POINT* lpPoints, [NativeTypeName("UINT")] uint cPoints);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WindowFromPoint", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr WindowFromPoint(POINT Point);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WindowFromPhysicalPoint", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr WindowFromPhysicalPoint(POINT Point);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ChildWindowFromPoint", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr ChildWindowFromPoint([NativeTypeName("HWND")] IntPtr hWndParent, POINT Point);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ClipCursor", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClipCursor([NativeTypeName("const RECT *")] RECT* lpRect);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ChildWindowFromPointEx", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr ChildWindowFromPointEx([NativeTypeName("HWND")] IntPtr hwnd, POINT pt, [NativeTypeName("UINT")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSysColor", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetSysColor(int nIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSysColorBrush", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr GetSysColorBrush(int nIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetSysColors", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSysColors(int cElements, [NativeTypeName("const INT *")] int* lpaElements, [NativeTypeName("const COLORREF *")] uint* lpaRgbValues);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DrawFocusRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawFocusRect([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("const RECT *")] RECT* lprc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FillRect", ExactSpelling = true)]
        public static extern int FillRect([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("HBRUSH")] IntPtr hbr);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FrameRect", ExactSpelling = true)]
        public static extern int FrameRect([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("HBRUSH")] IntPtr hbr);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InvertRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InvertRect([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("const RECT *")] RECT* lprc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetRect([NativeTypeName("LPRECT")] RECT* lprc, int xLeft, int yTop, int xRight, int yBottom);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetRectEmpty", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetRectEmpty([NativeTypeName("LPRECT")] RECT* lprc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CopyRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InflateRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InflateRect([NativeTypeName("LPRECT")] RECT* lprc, int dx, int dy);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IntersectRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IntersectRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnionRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnionRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SubtractRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SubtractRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OffsetRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OffsetRect([NativeTypeName("LPRECT")] RECT* lprc, int dx, int dy);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsRectEmpty", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsRectEmpty([NativeTypeName("const RECT *")] RECT* lprc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EqualRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EqualRect([NativeTypeName("const RECT *")] RECT* lprc1, [NativeTypeName("const RECT *")] RECT* lprc2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PtInRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PtInRect([NativeTypeName("const RECT *")] RECT* lprc, POINT pt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowWord", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort GetWindowWord([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowWord", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort SetWindowWord([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("WORD")] ushort wNewWord);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowLongW", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetWindowLong([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowLongW", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetWindowLong([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowLongPtrW", ExactSpelling = true)]
        [return: NativeTypeName("LONG_PTR")]
        public static extern IntPtr GetWindowLongPtr([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowLongPtrW", ExactSpelling = true)]
        [return: NativeTypeName("LONG_PTR")]
        public static extern IntPtr SetWindowLongPtr([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] IntPtr dwNewLong);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClassWord", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort GetClassWord([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetClassWord", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort SetClassWord([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("WORD")] ushort wNewWord);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClassLongW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetClassLong([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetClassLongW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetClassLong([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClassLongPtrW", ExactSpelling = true)]
        [return: NativeTypeName("ULONG_PTR")]
        public static extern UIntPtr GetClassLongPtr([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetClassLongPtrW", ExactSpelling = true)]
        [return: NativeTypeName("ULONG_PTR")]
        public static extern UIntPtr SetClassLongPtr([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] IntPtr dwNewLong);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProcessDefaultLayout", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessDefaultLayout([NativeTypeName("DWORD *")] uint* pdwDefaultLayout);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetProcessDefaultLayout", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDefaultLayout([NativeTypeName("DWORD")] uint dwDefaultLayout);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDesktopWindow", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetDesktopWindow();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetParent", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetParent([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetParent", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr SetParent([NativeTypeName("HWND")] IntPtr hWndChild, [NativeTypeName("HWND")] IntPtr hWndNewParent);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumChildWindows", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumChildWindows([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("WNDENUMPROC")] IntPtr lpEnumFunc, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindWindowW", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr FindWindow([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindWindowExW", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr FindWindowEx([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HWND")] IntPtr hWndChildAfter, [NativeTypeName("LPCWSTR")] ushort* lpszClass, [NativeTypeName("LPCWSTR")] ushort* lpszWindow);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetShellWindow", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetShellWindow();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RegisterShellHookWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterShellHookWindow([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DeregisterShellHookWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeregisterShellHookWindow([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumWindows", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumWindows([NativeTypeName("WNDENUMPROC")] IntPtr lpEnumFunc, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumThreadWindows", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumThreadWindows([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("WNDENUMPROC")] IntPtr lpfn, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClassNameW", ExactSpelling = true)]
        public static extern int GetClassName([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPWSTR")] ushort* lpClassName, int nMaxCount);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTopWindow", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetTopWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowThreadProcessId", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetWindowThreadProcessId([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPDWORD")] uint* lpdwProcessId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsGUIThread", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsGUIThread([NativeTypeName("BOOL")] int bConvert);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetLastActivePopup", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetLastActivePopup([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindow", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint uCmd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowsHookW", ExactSpelling = true)]
        [return: NativeTypeName("HHOOK")]
        public static extern IntPtr SetWindowsHook(int nFilterType, [NativeTypeName("HOOKPROC")] IntPtr pfnFilterProc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnhookWindowsHook", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnhookWindowsHook(int nCode, [NativeTypeName("HOOKPROC")] IntPtr pfnFilterProc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowsHookExW", ExactSpelling = true)]
        [return: NativeTypeName("HHOOK")]
        public static extern IntPtr SetWindowsHookEx(int idHook, [NativeTypeName("HOOKPROC")] IntPtr lpfn, [NativeTypeName("HINSTANCE")] IntPtr hmod, [NativeTypeName("DWORD")] uint dwThreadId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnhookWindowsHookEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnhookWindowsHookEx([NativeTypeName("HHOOK")] IntPtr hhk);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CallNextHookEx", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern IntPtr CallNextHookEx([NativeTypeName("HHOOK")] IntPtr hhk, int nCode, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CheckMenuRadioItem", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckMenuRadioItem([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint first, [NativeTypeName("UINT")] uint last, [NativeTypeName("UINT")] uint check, [NativeTypeName("UINT")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadBitmapW", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr LoadBitmap([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpBitmapName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadCursorW", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr LoadCursor([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpCursorName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadCursorFromFileW", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr LoadCursorFromFile([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateCursor", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr CreateCursor([NativeTypeName("HINSTANCE")] IntPtr hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, [NativeTypeName("const void *")] void* pvANDPlane, [NativeTypeName("const void *")] void* pvXORPlane);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DestroyCursor", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyCursor([NativeTypeName("HCURSOR")] IntPtr hCursor);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetSystemCursor", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSystemCursor([NativeTypeName("HCURSOR")] IntPtr hcur, [NativeTypeName("DWORD")] uint id);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadIconW", ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr LoadIcon([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpIconName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PrivateExtractIconsW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint PrivateExtractIcons([NativeTypeName("LPCWSTR")] ushort* szFileName, int nIconIndex, int cxIcon, int cyIcon, [NativeTypeName("HICON *")] IntPtr* phicon, [NativeTypeName("UINT *")] uint* piconid, [NativeTypeName("UINT")] uint nIcons, [NativeTypeName("UINT")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateIcon", ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr CreateIcon([NativeTypeName("HINSTANCE")] IntPtr hInstance, int nWidth, int nHeight, [NativeTypeName("BYTE")] byte cPlanes, [NativeTypeName("BYTE")] byte cBitsPixel, [NativeTypeName("const BYTE *")] byte* lpbANDbits, [NativeTypeName("const BYTE *")] byte* lpbXORbits);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DestroyIcon", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyIcon([NativeTypeName("HICON")] IntPtr hIcon);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LookupIconIdFromDirectory", ExactSpelling = true)]
        public static extern int LookupIconIdFromDirectory([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("BOOL")] int fIcon);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LookupIconIdFromDirectoryEx", ExactSpelling = true)]
        public static extern int LookupIconIdFromDirectoryEx([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("BOOL")] int fIcon, int cxDesired, int cyDesired, [NativeTypeName("UINT")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateIconFromResource", ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr CreateIconFromResource([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("DWORD")] uint dwResSize, [NativeTypeName("BOOL")] int fIcon, [NativeTypeName("DWORD")] uint dwVer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateIconFromResourceEx", ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr CreateIconFromResourceEx([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("DWORD")] uint dwResSize, [NativeTypeName("BOOL")] int fIcon, [NativeTypeName("DWORD")] uint dwVer, int cxDesired, int cyDesired, [NativeTypeName("UINT")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadImageW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* LoadImage([NativeTypeName("HINSTANCE")] IntPtr hInst, [NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("UINT")] uint type, int cx, int cy, [NativeTypeName("UINT")] uint fuLoad);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CopyImage", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CopyImage([NativeTypeName("HANDLE")] void* h, [NativeTypeName("UINT")] uint type, int cx, int cy, [NativeTypeName("UINT")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DrawIconEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawIconEx([NativeTypeName("HDC")] IntPtr hdc, int xLeft, int yTop, [NativeTypeName("HICON")] IntPtr hIcon, int cxWidth, int cyWidth, [NativeTypeName("UINT")] uint istepIfAniCur, [NativeTypeName("HBRUSH")] IntPtr hbrFlickerFreeDraw, [NativeTypeName("UINT")] uint diFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateIconIndirect", ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr CreateIconIndirect([NativeTypeName("PICONINFO")] ICONINFO* piconinfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CopyIcon", ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr CopyIcon([NativeTypeName("HICON")] IntPtr hIcon);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetIconInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetIconInfo([NativeTypeName("HICON")] IntPtr hIcon, [NativeTypeName("PICONINFO")] ICONINFO* piconinfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetIconInfoExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetIconInfoEx([NativeTypeName("HICON")] IntPtr hicon, [NativeTypeName("PICONINFOEXW")] ICONINFOEX* piconinfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsDialogMessageW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsDialogMessage([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MapDialogRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MapDialogRect([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DlgDirListW", ExactSpelling = true)]
        public static extern int DlgDirList([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPWSTR")] ushort* lpPathSpec, int nIDListBox, int nIDStaticPath, [NativeTypeName("UINT")] uint uFileType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DlgDirSelectExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DlgDirSelectEx([NativeTypeName("HWND")] IntPtr hwndDlg, [NativeTypeName("LPWSTR")] ushort* lpString, int chCount, int idListBox);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DlgDirListComboBoxW", ExactSpelling = true)]
        public static extern int DlgDirListComboBox([NativeTypeName("HWND")] IntPtr hDlg, [NativeTypeName("LPWSTR")] ushort* lpPathSpec, int nIDComboBox, int nIDStaticPath, [NativeTypeName("UINT")] uint uFiletype);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DlgDirSelectComboBoxExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DlgDirSelectComboBoxEx([NativeTypeName("HWND")] IntPtr hwndDlg, [NativeTypeName("LPWSTR")] ushort* lpString, int cchOut, int idComboBox);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetScrollInfo", ExactSpelling = true)]
        public static extern int SetScrollInfo([NativeTypeName("HWND")] IntPtr hwnd, int nBar, [NativeTypeName("LPCSCROLLINFO")] SCROLLINFO* lpsi, [NativeTypeName("BOOL")] int redraw);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetScrollInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetScrollInfo([NativeTypeName("HWND")] IntPtr hwnd, int nBar, [NativeTypeName("LPSCROLLINFO")] SCROLLINFO* lpsi);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DefFrameProcW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern IntPtr DefFrameProc([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HWND")] IntPtr hWndMDIClient, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DefMDIChildProcW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern IntPtr DefMDIChildProc([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TranslateMDISysAccel", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TranslateMDISysAccel([NativeTypeName("HWND")] IntPtr hWndClient, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ArrangeIconicWindows", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint ArrangeIconicWindows([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateMDIWindowW", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateMDIWindow([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TileWindows", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort TileWindows([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("UINT")] uint wHow, [NativeTypeName("const RECT *")] RECT* lpRect, [NativeTypeName("UINT")] uint cKids, [NativeTypeName("const HWND *")] IntPtr* lpKids);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CascadeWindows", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort CascadeWindows([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("UINT")] uint wHow, [NativeTypeName("const RECT *")] RECT* lpRect, [NativeTypeName("UINT")] uint cKids, [NativeTypeName("const HWND *")] IntPtr* lpKids);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WinHelpW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinHelp([NativeTypeName("HWND")] IntPtr hWndMain, [NativeTypeName("LPCWSTR")] ushort* lpszHelp, [NativeTypeName("UINT")] uint uCommand, [NativeTypeName("ULONG_PTR")] UIntPtr dwData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetGuiResources", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGuiResources([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("DWORD")] uint uiFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ChangeDisplaySettingsW", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ChangeDisplaySettings([NativeTypeName("DEVMODEW *")] DEVMODEW* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ChangeDisplaySettingsExW", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ChangeDisplaySettingsEx([NativeTypeName("LPCWSTR")] ushort* lpszDeviceName, [NativeTypeName("DEVMODEW *")] DEVMODEW* lpDevMode, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwflags, [NativeTypeName("LPVOID")] void* lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumDisplaySettingsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplaySettings([NativeTypeName("LPCWSTR")] ushort* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, [NativeTypeName("DEVMODEW *")] DEVMODEW* lpDevMode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumDisplaySettingsExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplaySettingsEx([NativeTypeName("LPCWSTR")] ushort* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, [NativeTypeName("DEVMODEW *")] DEVMODEW* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumDisplayDevicesW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplayDevices([NativeTypeName("LPCWSTR")] ushort* lpDevice, [NativeTypeName("DWORD")] uint iDevNum, [NativeTypeName("PDISPLAY_DEVICEW")] DISPLAY_DEVICEW* lpDisplayDevice, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDisplayConfigBufferSizes", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetDisplayConfigBufferSizes([NativeTypeName("UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* numPathArrayElements, [NativeTypeName("UINT32 *")] uint* numModeInfoArrayElements);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetDisplayConfig", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetDisplayConfig([NativeTypeName("UINT32")] uint numPathArrayElements, [NativeTypeName("DISPLAYCONFIG_PATH_INFO *")] DISPLAYCONFIG_PATH_INFO* pathArray, [NativeTypeName("UINT32")] uint numModeInfoArrayElements, [NativeTypeName("DISPLAYCONFIG_MODE_INFO *")] DISPLAYCONFIG_MODE_INFO* modeInfoArray, [NativeTypeName("UINT32")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "QueryDisplayConfig", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int QueryDisplayConfig([NativeTypeName("UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* numPathArrayElements, [NativeTypeName("DISPLAYCONFIG_PATH_INFO *")] DISPLAYCONFIG_PATH_INFO* pathArray, [NativeTypeName("UINT32 *")] uint* numModeInfoArrayElements, [NativeTypeName("DISPLAYCONFIG_MODE_INFO *")] DISPLAYCONFIG_MODE_INFO* modeInfoArray, [NativeTypeName("DISPLAYCONFIG_TOPOLOGY_ID *")] DISPLAYCONFIG_TOPOLOGY_ID* currentTopologyId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DisplayConfigGetDeviceInfo", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int DisplayConfigGetDeviceInfo([NativeTypeName("DISPLAYCONFIG_DEVICE_INFO_HEADER *")] DISPLAYCONFIG_DEVICE_INFO_HEADER* requestPacket);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DisplayConfigSetDeviceInfo", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int DisplayConfigSetDeviceInfo([NativeTypeName("DISPLAYCONFIG_DEVICE_INFO_HEADER *")] DISPLAYCONFIG_DEVICE_INFO_HEADER* setPacket);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SystemParametersInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SystemParametersInfo([NativeTypeName("UINT")] uint uiAction, [NativeTypeName("UINT")] uint uiParam, [NativeTypeName("PVOID")] void* pvParam, [NativeTypeName("UINT")] uint fWinIni);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SystemParametersInfoForDpi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SystemParametersInfoForDpi([NativeTypeName("UINT")] uint uiAction, [NativeTypeName("UINT")] uint uiParam, [NativeTypeName("PVOID")] void* pvParam, [NativeTypeName("UINT")] uint fWinIni, [NativeTypeName("UINT")] uint dpi);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SoundSentry", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SoundSentry();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetDebugErrorLevel", ExactSpelling = true)]
        public static extern void SetDebugErrorLevel([NativeTypeName("DWORD")] uint dwLevel);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetLastErrorEx", ExactSpelling = true)]
        public static extern void SetLastErrorEx([NativeTypeName("DWORD")] uint dwErrCode, [NativeTypeName("DWORD")] uint dwType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InternalGetWindowText", ExactSpelling = true)]
        public static extern int InternalGetWindowText([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPWSTR")] ushort* pString, int cchMaxCount);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CancelShutdown", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelShutdown();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MonitorFromPoint", ExactSpelling = true)]
        [return: NativeTypeName("HMONITOR")]
        public static extern IntPtr MonitorFromPoint(POINT pt, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MonitorFromRect", ExactSpelling = true)]
        [return: NativeTypeName("HMONITOR")]
        public static extern IntPtr MonitorFromRect([NativeTypeName("LPCRECT")] RECT* lprc, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MonitorFromWindow", ExactSpelling = true)]
        [return: NativeTypeName("HMONITOR")]
        public static extern IntPtr MonitorFromWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMonitorInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMonitorInfo([NativeTypeName("HMONITOR")] IntPtr hMonitor, [NativeTypeName("LPMONITORINFO")] MONITORINFO* lpmi);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumDisplayMonitors", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplayMonitors([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCRECT")] RECT* lprcClip, [NativeTypeName("MONITORENUMPROC")] IntPtr lpfnEnum, [NativeTypeName("LPARAM")] IntPtr dwData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "NotifyWinEvent", ExactSpelling = true)]
        public static extern void NotifyWinEvent([NativeTypeName("DWORD")] uint @event, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("LONG")] int idChild);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWinEventHook", ExactSpelling = true)]
        [return: NativeTypeName("HWINEVENTHOOK")]
        public static extern IntPtr SetWinEventHook([NativeTypeName("DWORD")] uint eventMin, [NativeTypeName("DWORD")] uint eventMax, [NativeTypeName("HMODULE")] IntPtr hmodWinEventProc, [NativeTypeName("WINEVENTPROC")] IntPtr pfnWinEventProc, [NativeTypeName("DWORD")] uint idProcess, [NativeTypeName("DWORD")] uint idThread, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsWinEventHookInstalled", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWinEventHookInstalled([NativeTypeName("DWORD")] uint @event);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnhookWinEvent", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnhookWinEvent([NativeTypeName("HWINEVENTHOOK")] IntPtr hWinEventHook);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetGUIThreadInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGUIThreadInfo([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("PGUITHREADINFO")] GUITHREADINFO* pgui);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "BlockInput", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BlockInput([NativeTypeName("BOOL")] int fBlockIt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetProcessDPIAware", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDPIAware();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsProcessDPIAware", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsProcessDPIAware();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetThreadDpiAwarenessContext", ExactSpelling = true)]
        [return: NativeTypeName("DPI_AWARENESS_CONTEXT")]
        public static extern IntPtr SetThreadDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr dpiContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetThreadDpiAwarenessContext", ExactSpelling = true)]
        [return: NativeTypeName("DPI_AWARENESS_CONTEXT")]
        public static extern IntPtr GetThreadDpiAwarenessContext();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowDpiAwarenessContext", ExactSpelling = true)]
        [return: NativeTypeName("DPI_AWARENESS_CONTEXT")]
        public static extern IntPtr GetWindowDpiAwarenessContext([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetAwarenessFromDpiAwarenessContext", ExactSpelling = true)]
        public static extern DPI_AWARENESS GetAwarenessFromDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr value);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AreDpiAwarenessContextsEqual", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AreDpiAwarenessContextsEqual([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr dpiContextA, [NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr dpiContextB);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsValidDpiAwarenessContext", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsValidDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr value);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDpiForWindow", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDpiForWindow([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDpiForSystem", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDpiForSystem();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnableNonClientDpiScaling", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableNonClientDpiScaling([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InheritWindowMonitor", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InheritWindowMonitor([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HWND")] IntPtr hwndInherit);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetProcessDpiAwarenessContext", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] IntPtr value);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowModuleFileNameW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetWindowModuleFileName([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPWSTR")] ushort* pszFileName, [NativeTypeName("UINT")] uint cchFileNameMax);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCursorInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCursorInfo([NativeTypeName("PCURSORINFO")] CURSORINFO* pci);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowInfo([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("PWINDOWINFO")] WINDOWINFO* pwi);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTitleBarInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTitleBarInfo([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("PTITLEBARINFO")] TITLEBARINFO* pti);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMenuBarInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuBarInfo([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("LONG")] int idItem, [NativeTypeName("PMENUBARINFO")] MENUBARINFO* pmbi);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetScrollBarInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetScrollBarInfo([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("PSCROLLBARINFO")] SCROLLBARINFO* psbi);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetComboBoxInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetComboBoxInfo([NativeTypeName("HWND")] IntPtr hwndCombo, [NativeTypeName("PCOMBOBOXINFO")] COMBOBOXINFO* pcbi);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetAncestor", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetAncestor([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint gaFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RealChildWindowFromPoint", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr RealChildWindowFromPoint([NativeTypeName("HWND")] IntPtr hwndParent, POINT ptParentClientCoords);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RealGetWindowClassW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RealGetWindowClass([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPWSTR")] ushort* ptszClassName, [NativeTypeName("UINT")] uint cchClassNameMax);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetAltTabInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAltTabInfo([NativeTypeName("HWND")] IntPtr hwnd, int iItem, [NativeTypeName("PALTTABINFO")] ALTTABINFO* pati, [NativeTypeName("LPWSTR")] ushort* pszItemText, [NativeTypeName("UINT")] uint cchItemText);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetListBoxInfo", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetListBoxInfo([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LockWorkStation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockWorkStation();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UserHandleGrantAccess", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UserHandleGrantAccess([NativeTypeName("HANDLE")] void* hUserHandle, [NativeTypeName("HANDLE")] void* hJob, [NativeTypeName("BOOL")] int bGrant);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetRawInputData", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRawInputData([NativeTypeName("HRAWINPUT")] IntPtr hRawInput, [NativeTypeName("UINT")] uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize, [NativeTypeName("UINT")] uint cbSizeHeader);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetRawInputDeviceInfoW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRawInputDeviceInfo([NativeTypeName("HANDLE")] void* hDevice, [NativeTypeName("UINT")] uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetRawInputBuffer", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRawInputBuffer([NativeTypeName("PRAWINPUT")] RAWINPUT* pData, [NativeTypeName("PUINT")] uint* pcbSize, [NativeTypeName("UINT")] uint cbSizeHeader);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RegisterRawInputDevices", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterRawInputDevices([NativeTypeName("PCRAWINPUTDEVICE")] RAWINPUTDEVICE* pRawInputDevices, [NativeTypeName("UINT")] uint uiNumDevices, [NativeTypeName("UINT")] uint cbSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetRegisteredRawInputDevices", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRegisteredRawInputDevices([NativeTypeName("PRAWINPUTDEVICE")] RAWINPUTDEVICE* pRawInputDevices, [NativeTypeName("PUINT")] uint* puiNumDevices, [NativeTypeName("UINT")] uint cbSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetRawInputDeviceList", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetRawInputDeviceList([NativeTypeName("PRAWINPUTDEVICELIST")] RAWINPUTDEVICELIST* pRawInputDeviceList, [NativeTypeName("PUINT")] uint* puiNumDevices, [NativeTypeName("UINT")] uint cbSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DefRawInputProc", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern IntPtr DefRawInputProc([NativeTypeName("PRAWINPUT *")] RAWINPUT** paRawInput, [NativeTypeName("INT")] int nInput, [NativeTypeName("UINT")] uint cbSizeHeader);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerDevices", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDevices([NativeTypeName("UINT32 *")] uint* deviceCount, [NativeTypeName("POINTER_DEVICE_INFO *")] POINTER_DEVICE_INFO* pointerDevices);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerDevice", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDevice([NativeTypeName("HANDLE")] void* device, [NativeTypeName("POINTER_DEVICE_INFO *")] POINTER_DEVICE_INFO* pointerDevice);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerDeviceProperties", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDeviceProperties([NativeTypeName("HANDLE")] void* device, [NativeTypeName("UINT32 *")] uint* propertyCount, [NativeTypeName("POINTER_DEVICE_PROPERTY *")] POINTER_DEVICE_PROPERTY* pointerProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RegisterPointerDeviceNotifications", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterPointerDeviceNotifications([NativeTypeName("HWND")] IntPtr window, [NativeTypeName("BOOL")] int notifyRange);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerDeviceRects", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDeviceRects([NativeTypeName("HANDLE")] void* device, [NativeTypeName("RECT *")] RECT* pointerDeviceRect, [NativeTypeName("RECT *")] RECT* displayRect);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPointerDeviceCursors", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDeviceCursors([NativeTypeName("HANDLE")] void* device, [NativeTypeName("UINT32 *")] uint* cursorCount, [NativeTypeName("POINTER_DEVICE_CURSOR_INFO *")] POINTER_DEVICE_CURSOR_INFO* deviceCursors);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetRawPointerDeviceData", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetRawPointerDeviceData([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint historyCount, [NativeTypeName("UINT32")] uint propertiesCount, [NativeTypeName("POINTER_DEVICE_PROPERTY *")] POINTER_DEVICE_PROPERTY* pProperties, [NativeTypeName("LONG *")] int* pValues);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ChangeWindowMessageFilter", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeWindowMessageFilter([NativeTypeName("UINT")] uint message, [NativeTypeName("DWORD")] uint dwFlag);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ChangeWindowMessageFilterEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeWindowMessageFilterEx([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint message, [NativeTypeName("DWORD")] uint action, [NativeTypeName("PCHANGEFILTERSTRUCT")] CHANGEFILTERSTRUCT* pChangeFilterStruct);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetGestureInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGestureInfo([NativeTypeName("HGESTUREINFO")] IntPtr hGestureInfo, [NativeTypeName("PGESTUREINFO")] GESTUREINFO* pGestureInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetGestureExtraArgs", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGestureExtraArgs([NativeTypeName("HGESTUREINFO")] IntPtr hGestureInfo, [NativeTypeName("UINT")] uint cbExtraArgs, [NativeTypeName("PBYTE")] byte* pExtraArgs);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CloseGestureInfoHandle", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseGestureInfoHandle([NativeTypeName("HGESTUREINFO")] IntPtr hGestureInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetGestureConfig", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetGestureConfig([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("UINT")] uint cIDs, [NativeTypeName("PGESTURECONFIG")] GESTURECONFIG* pGestureConfig, [NativeTypeName("UINT")] uint cbSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetGestureConfig", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGestureConfig([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PUINT")] uint* pcIDs, [NativeTypeName("PGESTURECONFIG")] GESTURECONFIG* pGestureConfig, [NativeTypeName("UINT")] uint cbSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ShutdownBlockReasonCreate", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShutdownBlockReasonCreate([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCWSTR")] ushort* pwszReason);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ShutdownBlockReasonQuery", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShutdownBlockReasonQuery([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPWSTR")] ushort* pwszBuff, [NativeTypeName("DWORD *")] uint* pcchBuff);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ShutdownBlockReasonDestroy", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShutdownBlockReasonDestroy([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCurrentInputMessageSource", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentInputMessageSource([NativeTypeName("INPUT_MESSAGE_SOURCE *")] INPUT_MESSAGE_SOURCE* inputMessageSource);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCIMSSM", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCIMSSM([NativeTypeName("INPUT_MESSAGE_SOURCE *")] INPUT_MESSAGE_SOURCE* inputMessageSource);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetAutoRotationState", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAutoRotationState([NativeTypeName("PAR_STATE")] AR_STATE* pState);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDisplayAutoRotationPreferences", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDisplayAutoRotationPreferences([NativeTypeName("ORIENTATION_PREFERENCE *")] ORIENTATION_PREFERENCE* pOrientation);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDisplayAutoRotationPreferencesByProcessId", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDisplayAutoRotationPreferencesByProcessId([NativeTypeName("DWORD")] uint dwProcessId, [NativeTypeName("ORIENTATION_PREFERENCE *")] ORIENTATION_PREFERENCE* pOrientation, [NativeTypeName("BOOL *")] int* fRotateScreen);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetDisplayAutoRotationPreferences", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDisplayAutoRotationPreferences(ORIENTATION_PREFERENCE orientation);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsImmersiveProcess", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsImmersiveProcess([NativeTypeName("HANDLE")] void* hProcess);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetProcessRestrictionExemption", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessRestrictionExemption([NativeTypeName("BOOL")] int fEnableExemption);
    }
}
