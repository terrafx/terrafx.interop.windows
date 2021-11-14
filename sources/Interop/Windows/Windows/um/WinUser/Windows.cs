// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int wvsprintfA([NativeTypeName("LPSTR")] sbyte* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("va_list")] sbyte* arglist);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int wvsprintfW([NativeTypeName("LPWSTR")] ushort* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("va_list")] sbyte* arglist);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int wsprintfA([NativeTypeName("LPSTR")] sbyte* param0, [NativeTypeName("LPCSTR")] sbyte* param1);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int wsprintfW([NativeTypeName("LPWSTR")] ushort* param0, [NativeTypeName("LPCWSTR")] ushort* param1);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HKL LoadKeyboardLayoutA([NativeTypeName("LPCSTR")] sbyte* pwszKLID, uint Flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HKL LoadKeyboardLayoutW([NativeTypeName("LPCWSTR")] ushort* pwszKLID, uint Flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HKL ActivateKeyboardLayout(HKL hkl, uint Flags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWSTR")] ushort* pwszBuff, int cchBuff, uint wFlags, HKL dwhkl);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL UnloadKeyboardLayout(HKL hkl);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetKeyboardLayoutNameA([NativeTypeName("LPSTR")] sbyte* pwszKLID);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetKeyboardLayoutNameW([NativeTypeName("LPWSTR")] ushort* pwszKLID);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetKeyboardLayoutList(int nBuff, HKL* lpList);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HKL GetKeyboardLayout([NativeTypeName("DWORD")] uint idThread);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetMouseMovePointsEx(uint cbSize, [NativeTypeName("LPMOUSEMOVEPOINT")] MOUSEMOVEPOINT* lppt, [NativeTypeName("LPMOUSEMOVEPOINT")] MOUSEMOVEPOINT* lpptBuf, int nBufPoints, [NativeTypeName("DWORD")] uint resolution);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HDESK CreateDesktopA([NativeTypeName("LPCSTR")] sbyte* lpszDesktop, [NativeTypeName("LPCSTR")] sbyte* lpszDevice, DEVMODEA* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HDESK CreateDesktopW([NativeTypeName("LPCWSTR")] ushort* lpszDesktop, [NativeTypeName("LPCWSTR")] ushort* lpszDevice, DEVMODEW* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HDESK CreateDesktopExA([NativeTypeName("LPCSTR")] sbyte* lpszDesktop, [NativeTypeName("LPCSTR")] sbyte* lpszDevice, DEVMODEA* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa, [NativeTypeName("ULONG")] uint ulHeapSize, [NativeTypeName("PVOID")] void* pvoid);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HDESK CreateDesktopExW([NativeTypeName("LPCWSTR")] ushort* lpszDesktop, [NativeTypeName("LPCWSTR")] ushort* lpszDevice, DEVMODEW* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa, [NativeTypeName("ULONG")] uint ulHeapSize, [NativeTypeName("PVOID")] void* pvoid);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HDESK OpenDesktopA([NativeTypeName("LPCSTR")] sbyte* lpszDesktop, [NativeTypeName("DWORD")] uint dwFlags, BOOL fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HDESK OpenDesktopW([NativeTypeName("LPCWSTR")] ushort* lpszDesktop, [NativeTypeName("DWORD")] uint dwFlags, BOOL fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HDESK OpenInputDesktop([NativeTypeName("DWORD")] uint dwFlags, BOOL fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EnumDesktopsA(HWINSTA hwinsta, [NativeTypeName("DESKTOPENUMPROCA")] delegate* unmanaged<sbyte*, LPARAM, BOOL> lpEnumFunc, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EnumDesktopsW(HWINSTA hwinsta, [NativeTypeName("DESKTOPENUMPROCW")] delegate* unmanaged<ushort*, LPARAM, BOOL> lpEnumFunc, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EnumDesktopWindows(HDESK hDesktop, [NativeTypeName("WNDENUMPROC")] delegate* unmanaged<HWND, LPARAM, BOOL> lpfn, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SwitchDesktop(HDESK hDesktop);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetThreadDesktop(HDESK hDesktop);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CloseDesktop(HDESK hDesktop);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HDESK GetThreadDesktop([NativeTypeName("DWORD")] uint dwThreadId);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWINSTA CreateWindowStationA([NativeTypeName("LPCSTR")] sbyte* lpwinsta, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWINSTA CreateWindowStationW([NativeTypeName("LPCWSTR")] ushort* lpwinsta, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWINSTA OpenWindowStationA([NativeTypeName("LPCSTR")] sbyte* lpszWinSta, BOOL fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWINSTA OpenWindowStationW([NativeTypeName("LPCWSTR")] ushort* lpszWinSta, BOOL fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EnumWindowStationsA([NativeTypeName("WINSTAENUMPROCA")] delegate* unmanaged<sbyte*, LPARAM, BOOL> lpEnumFunc, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EnumWindowStationsW([NativeTypeName("WINSTAENUMPROCW")] delegate* unmanaged<ushort*, LPARAM, BOOL> lpEnumFunc, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CloseWindowStation(HWINSTA hWinSta);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetProcessWindowStation(HWINSTA hWinSta);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWINSTA GetProcessWindowStation();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetUserObjectSecurity(HANDLE hObj, [NativeTypeName("PSECURITY_INFORMATION")] uint* pSIRequested, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSID);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetUserObjectSecurity(HANDLE hObj, [NativeTypeName("PSECURITY_INFORMATION")] uint* pSIRequested, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSID, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetUserObjectInformationA(HANDLE hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetUserObjectInformationW(HANDLE hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetUserObjectInformationA(HANDLE hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetUserObjectInformationW(HANDLE hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsHungAppWindow(HWND hwnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern void DisableProcessWindowsGhosting();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint RegisterWindowMessageA([NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint RegisterWindowMessageW([NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL TrackMouseEvent([NativeTypeName("LPTRACKMOUSEEVENT")] TRACKMOUSEEVENT* lpEventTrack);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL DrawEdge(HDC hdc, [NativeTypeName("LPRECT")] RECT* qrc, uint edge, uint grfFlags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL DrawFrameControl(HDC param0, [NativeTypeName("LPRECT")] RECT* param1, uint param2, uint param3);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL DrawCaption(HWND hwnd, HDC hdc, [NativeTypeName("const RECT *")] RECT* lprect, uint flags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL DrawAnimatedRects(HWND hwnd, int idAni, [NativeTypeName("const RECT *")] RECT* lprcFrom, [NativeTypeName("const RECT *")] RECT* lprcTo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetMessageA([NativeTypeName("LPMSG")] MSG* lpMsg, HWND hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetMessageW([NativeTypeName("LPMSG")] MSG* lpMsg, HWND hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL TranslateMessage([NativeTypeName("const MSG *")] MSG* lpMsg);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT DispatchMessageA([NativeTypeName("const MSG *")] MSG* lpMsg);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT DispatchMessageW([NativeTypeName("const MSG *")] MSG* lpMsg);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL SetMessageQueue(int cMessagesMax);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL PeekMessageA([NativeTypeName("LPMSG")] MSG* lpMsg, HWND hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL PeekMessageW([NativeTypeName("LPMSG")] MSG* lpMsg, HWND hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL RegisterHotKey(HWND hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnregisterHotKey(HWND hWnd, int id);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ExitWindowsEx(uint uFlags, [NativeTypeName("DWORD")] uint dwReason);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL SwapMouseButton(BOOL fSwap);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetMessagePos();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetMessageTime();

        [DllImport("user32", ExactSpelling = true)]
        public static extern LPARAM GetMessageExtraInfo();

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetUnpredictedMessagePos();

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsWow64Message();

        [DllImport("user32", ExactSpelling = true)]
        public static extern LPARAM SetMessageExtraInfo(LPARAM lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT SendMessageA(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT SendMessageW(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern LRESULT SendMessageTimeoutA(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam, uint fuFlags, uint uTimeout, [NativeTypeName("PDWORD_PTR")] nuint* lpdwResult);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern LRESULT SendMessageTimeoutW(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam, uint fuFlags, uint uTimeout, [NativeTypeName("PDWORD_PTR")] nuint* lpdwResult);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SendNotifyMessageA(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SendNotifyMessageW(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SendMessageCallbackA(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam, [NativeTypeName("SENDASYNCPROC")] delegate* unmanaged<HWND, uint, nuint, LRESULT, void> lpResultCallBack, [NativeTypeName("ULONG_PTR")] nuint dwData);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SendMessageCallbackW(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam, [NativeTypeName("SENDASYNCPROC")] delegate* unmanaged<HWND, uint, nuint, LRESULT, void> lpResultCallBack, [NativeTypeName("ULONG_PTR")] nuint dwData);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageExA([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, uint Msg, WPARAM wParam, LPARAM lParam, [NativeTypeName("PBSMINFO")] BSMINFO* pbsmInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageExW([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, uint Msg, WPARAM wParam, LPARAM lParam, [NativeTypeName("PBSMINFO")] BSMINFO* pbsmInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageA([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageW([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HDEVNOTIFY RegisterDeviceNotificationA(HANDLE hRecipient, [NativeTypeName("LPVOID")] void* NotificationFilter, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HDEVNOTIFY RegisterDeviceNotificationW(HANDLE hRecipient, [NativeTypeName("LPVOID")] void* NotificationFilter, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnregisterDeviceNotification(HDEVNOTIFY Handle);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HPOWERNOTIFY RegisterPowerSettingNotification(HANDLE hRecipient, [NativeTypeName("LPCGUID")] Guid* PowerSettingGuid, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnregisterPowerSettingNotification(HPOWERNOTIFY Handle);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HPOWERNOTIFY RegisterSuspendResumeNotification(HANDLE hRecipient, [NativeTypeName("DWORD")] uint Flags);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnregisterSuspendResumeNotification(HPOWERNOTIFY Handle);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL PostMessageA(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL PostMessageW(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL PostThreadMessageA([NativeTypeName("DWORD")] uint idThread, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL PostThreadMessageW([NativeTypeName("DWORD")] uint idThread, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL AttachThreadInput([NativeTypeName("DWORD")] uint idAttach, [NativeTypeName("DWORD")] uint idAttachTo, BOOL fAttach);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL ReplyMessage(LRESULT lResult);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WaitMessage();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WaitForInputIdle(HANDLE hProcess, [NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT DefWindowProcA(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT DefWindowProcW(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern void PostQuitMessage(int nExitCode);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT CallWindowProcA([NativeTypeName("WNDPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, LRESULT> lpPrevWndFunc, HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT CallWindowProcW([NativeTypeName("WNDPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, LRESULT> lpPrevWndFunc, HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL InSendMessage();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint InSendMessageEx([NativeTypeName("LPVOID")] void* lpReserved);

        [DllImport("user32", ExactSpelling = true)]
        public static extern uint GetDoubleClickTime();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetDoubleClickTime(uint param0);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassA([NativeTypeName("const WNDCLASSA *")] WNDCLASSA* lpWndClass);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassW([NativeTypeName("const WNDCLASSW *")] WNDCLASSW* lpWndClass);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnregisterClassA([NativeTypeName("LPCSTR")] sbyte* lpClassName, HINSTANCE hInstance);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnregisterClassW([NativeTypeName("LPCWSTR")] ushort* lpClassName, HINSTANCE hInstance);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetClassInfoA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPWNDCLASSA")] WNDCLASSA* lpWndClass);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetClassInfoW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPWNDCLASSW")] WNDCLASSW* lpWndClass);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassExA([NativeTypeName("const WNDCLASSEXA *")] WNDCLASSEXA* param0);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassExW([NativeTypeName("const WNDCLASSEXW *")] WNDCLASSEXW* param0);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetClassInfoExA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpszClass, [NativeTypeName("LPWNDCLASSEXA")] WNDCLASSEXA* lpwcx);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetClassInfoExW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpszClass, [NativeTypeName("LPWNDCLASSEXW")] WNDCLASSEXW* lpwcx);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND CreateWindowExA([NativeTypeName("DWORD")] uint dwExStyle, [NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, HWND hWndParent, HMENU hMenu, HINSTANCE hInstance, [NativeTypeName("LPVOID")] void* lpParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND CreateWindowExW([NativeTypeName("DWORD")] uint dwExStyle, [NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, HWND hWndParent, HMENU hMenu, HINSTANCE hInstance, [NativeTypeName("LPVOID")] void* lpParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsWindow(HWND hWnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsMenu(HMENU hMenu);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsChild(HWND hWndParent, HWND hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DestroyWindow(HWND hWnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL ShowWindow(HWND hWnd, int nCmdShow);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL AnimateWindow(HWND hWnd, [NativeTypeName("DWORD")] uint dwTime, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UpdateLayeredWindow(HWND hWnd, HDC hdcDst, POINT* pptDst, SIZE* psize, HDC hdcSrc, POINT* pptSrc, COLORREF crKey, BLENDFUNCTION* pblend, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL UpdateLayeredWindowIndirect(HWND hWnd, [NativeTypeName("const UPDATELAYEREDWINDOWINFO *")] UPDATELAYEREDWINDOWINFO* pULWInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetLayeredWindowAttributes(HWND hwnd, COLORREF* pcrKey, byte* pbAlpha, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL PrintWindow(HWND hwnd, HDC hdcBlt, uint nFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetLayeredWindowAttributes(HWND hwnd, COLORREF crKey, byte bAlpha, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL ShowWindowAsync(HWND hWnd, int nCmdShow);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL FlashWindow(HWND hWnd, BOOL bInvert);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL FlashWindowEx([NativeTypeName("PFLASHWINFO")] FLASHWINFO* pfwi);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ShowOwnedPopups(HWND hWnd, BOOL fShow);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL OpenIcon(HWND hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CloseWindow(HWND hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL MoveWindow(HWND hWnd, int X, int Y, int nWidth, int nHeight, BOOL bRepaint);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetWindowPos(HWND hWnd, HWND hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetWindowPlacement(HWND hWnd, WINDOWPLACEMENT* lpwndpl);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetWindowPlacement(HWND hWnd, [NativeTypeName("const WINDOWPLACEMENT *")] WINDOWPLACEMENT* lpwndpl);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetWindowDisplayAffinity(HWND hWnd, [NativeTypeName("DWORD *")] uint* pdwAffinity);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetWindowDisplayAffinity(HWND hWnd, [NativeTypeName("DWORD")] uint dwAffinity);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HDWP BeginDeferWindowPos(int nNumWindows);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HDWP DeferWindowPos(HDWP hWinPosInfo, HWND hWnd, HWND hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EndDeferWindowPos(HDWP hWinPosInfo);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsWindowVisible(HWND hWnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsIconic(HWND hWnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL AnyPopup();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL BringWindowToTop(HWND hWnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsZoomed(HWND hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND CreateDialogParamA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTemplateName, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc, LPARAM dwInitParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND CreateDialogParamW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTemplateName, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc, LPARAM dwInitParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND CreateDialogIndirectParamA(HINSTANCE hInstance, [NativeTypeName("LPCDLGTEMPLATEA")] DLGTEMPLATE* lpTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc, LPARAM dwInitParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND CreateDialogIndirectParamW(HINSTANCE hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc, LPARAM dwInitParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint DialogBoxParamA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTemplateName, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc, LPARAM dwInitParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint DialogBoxParamW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTemplateName, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc, LPARAM dwInitParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint DialogBoxIndirectParamA(HINSTANCE hInstance, [NativeTypeName("LPCDLGTEMPLATEA")] DLGTEMPLATE* hDialogTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc, LPARAM dwInitParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint DialogBoxIndirectParamW(HINSTANCE hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* hDialogTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc, LPARAM dwInitParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EndDialog(HWND hDlg, [NativeTypeName("INT_PTR")] nint nResult);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND GetDlgItem(HWND hDlg, int nIDDlgItem);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetDlgItemInt(HWND hDlg, int nIDDlgItem, uint uValue, BOOL bSigned);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint GetDlgItemInt(HWND hDlg, int nIDDlgItem, BOOL* lpTranslated, BOOL bSigned);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetDlgItemTextA(HWND hDlg, int nIDDlgItem, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetDlgItemTextW(HWND hDlg, int nIDDlgItem, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint GetDlgItemTextA(HWND hDlg, int nIDDlgItem, [NativeTypeName("LPSTR")] sbyte* lpString, int cchMax);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint GetDlgItemTextW(HWND hDlg, int nIDDlgItem, [NativeTypeName("LPWSTR")] ushort* lpString, int cchMax);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CheckDlgButton(HWND hDlg, int nIDButton, uint uCheck);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CheckRadioButton(HWND hDlg, int nIDFirstButton, int nIDLastButton, int nIDCheckButton);

        [DllImport("user32", ExactSpelling = true)]
        public static extern uint IsDlgButtonChecked(HWND hDlg, int nIDButton);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT SendDlgItemMessageA(HWND hDlg, int nIDDlgItem, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT SendDlgItemMessageW(HWND hDlg, int nIDDlgItem, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND GetNextDlgGroupItem(HWND hDlg, HWND hCtl, BOOL bPrevious);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND GetNextDlgTabItem(HWND hDlg, HWND hCtl, BOOL bPrevious);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetDlgCtrlID(HWND hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int GetDialogBaseUnits();

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT DefDlgProcA(HWND hDlg, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT DefDlgProcW(HWND hDlg, uint Msg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL SetDialogControlDpiChangeBehavior(HWND hWnd, DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS mask, DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS values);

        [SupportedOSPlatform("windows10.0.15063.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS GetDialogControlDpiChangeBehavior(HWND hWnd);

        [SupportedOSPlatform("windows10.0.15063.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetDialogDpiChangeBehavior(HWND hDlg, DIALOG_DPI_CHANGE_BEHAVIORS mask, DIALOG_DPI_CHANGE_BEHAVIORS values);

        [SupportedOSPlatform("windows10.0.15063.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern DIALOG_DPI_CHANGE_BEHAVIORS GetDialogDpiChangeBehavior(HWND hDlg);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL CallMsgFilterA([NativeTypeName("LPMSG")] MSG* lpMsg, int nCode);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL CallMsgFilterW([NativeTypeName("LPMSG")] MSG* lpMsg, int nCode);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL OpenClipboard(HWND hWndNewOwner);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CloseClipboard();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetClipboardSequenceNumber();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND GetClipboardOwner();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND SetClipboardViewer(HWND hWndNewViewer);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND GetClipboardViewer();

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL ChangeClipboardChain(HWND hWndRemove, HWND hWndNewNext);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HANDLE SetClipboardData(uint uFormat, HANDLE hMem);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HANDLE GetClipboardData(uint uFormat);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint RegisterClipboardFormatA([NativeTypeName("LPCSTR")] sbyte* lpszFormat);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint RegisterClipboardFormatW([NativeTypeName("LPCWSTR")] ushort* lpszFormat);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int CountClipboardFormats();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint EnumClipboardFormats(uint format);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetClipboardFormatNameA(uint format, [NativeTypeName("LPSTR")] sbyte* lpszFormatName, int cchMaxCount);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetClipboardFormatNameW(uint format, [NativeTypeName("LPWSTR")] ushort* lpszFormatName, int cchMaxCount);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EmptyClipboard();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL IsClipboardFormatAvailable(uint format);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetPriorityClipboardFormat(uint* paFormatPriorityList, int cFormats);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND GetOpenClipboardWindow();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL AddClipboardFormatListener(HWND hwnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL RemoveClipboardFormatListener(HWND hwnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetUpdatedClipboardFormats([NativeTypeName("PUINT")] uint* lpuiFormats, uint cFormats, [NativeTypeName("PUINT")] uint* pcFormatsOut);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CharToOemA([NativeTypeName("LPCSTR")] sbyte* pSrc, [NativeTypeName("LPSTR")] sbyte* pDst);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CharToOemW([NativeTypeName("LPCWSTR")] ushort* pSrc, [NativeTypeName("LPSTR")] sbyte* pDst);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL OemToCharA([NativeTypeName("LPCSTR")] sbyte* pSrc, [NativeTypeName("LPSTR")] sbyte* pDst);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL OemToCharW([NativeTypeName("LPCSTR")] sbyte* pSrc, [NativeTypeName("LPWSTR")] ushort* pDst);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CharToOemBuffA([NativeTypeName("LPCSTR")] sbyte* lpszSrc, [NativeTypeName("LPSTR")] sbyte* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CharToOemBuffW([NativeTypeName("LPCWSTR")] ushort* lpszSrc, [NativeTypeName("LPSTR")] sbyte* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL OemToCharBuffA([NativeTypeName("LPCSTR")] sbyte* lpszSrc, [NativeTypeName("LPSTR")] sbyte* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL OemToCharBuffW([NativeTypeName("LPCSTR")] sbyte* lpszSrc, [NativeTypeName("LPWSTR")] ushort* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharUpperA([NativeTypeName("LPSTR")] sbyte* lpsz);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* CharUpperW([NativeTypeName("LPWSTR")] ushort* lpsz);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CharUpperBuffA([NativeTypeName("LPSTR")] sbyte* lpsz, [NativeTypeName("DWORD")] uint cchLength);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CharUpperBuffW([NativeTypeName("LPWSTR")] ushort* lpsz, [NativeTypeName("DWORD")] uint cchLength);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharLowerA([NativeTypeName("LPSTR")] sbyte* lpsz);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
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

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL IsCharAlphaA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL IsCharAlphaW([NativeTypeName("WCHAR")] ushort ch);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL IsCharAlphaNumericA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL IsCharAlphaNumericW([NativeTypeName("WCHAR")] ushort ch);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL IsCharUpperA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL IsCharUpperW([NativeTypeName("WCHAR")] ushort ch);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL IsCharLowerA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL IsCharLowerW([NativeTypeName("WCHAR")] ushort ch);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWND SetFocus(HWND hWnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWND GetActiveWindow();

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWND GetFocus();

        [DllImport("user32", ExactSpelling = true)]
        public static extern uint GetKBCodePage();

        [DllImport("user32", ExactSpelling = true)]
        public static extern short GetKeyState(int nVirtKey);

        [DllImport("user32", ExactSpelling = true)]
        public static extern short GetAsyncKeyState(int vKey);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetKeyboardState([NativeTypeName("PBYTE")] byte* lpKeyState);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetKeyboardState([NativeTypeName("LPBYTE")] byte* lpKeyState);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetKeyNameTextA([NativeTypeName("LONG")] int lParam, [NativeTypeName("LPSTR")] sbyte* lpString, int cchSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetKeyNameTextW([NativeTypeName("LONG")] int lParam, [NativeTypeName("LPWSTR")] ushort* lpString, int cchSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetKeyboardType(int nTypeFlag);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int ToAscii(uint uVirtKey, uint uScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWORD")] ushort* lpChar, uint uFlags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int ToAsciiEx(uint uVirtKey, uint uScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWORD")] ushort* lpChar, uint uFlags, HKL dwhkl);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int ToUnicode(uint wVirtKey, uint wScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWSTR")] ushort* pwszBuff, int cchBuff, uint wFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint OemKeyScan([NativeTypeName("WORD")] ushort wOemChar);

        [DllImport("user32", ExactSpelling = true)]
        public static extern short VkKeyScanA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32", ExactSpelling = true)]
        public static extern short VkKeyScanW([NativeTypeName("WCHAR")] ushort ch);

        [DllImport("user32", ExactSpelling = true)]
        public static extern short VkKeyScanExA([NativeTypeName("CHAR")] sbyte ch, HKL dwhkl);

        [DllImport("user32", ExactSpelling = true)]
        public static extern short VkKeyScanExW([NativeTypeName("WCHAR")] ushort ch, HKL dwhkl);

        [DllImport("user32", ExactSpelling = true)]
        public static extern void keybd_event(byte bVk, byte bScan, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG_PTR")] nuint dwExtraInfo);

        [DllImport("user32", ExactSpelling = true)]
        public static extern void mouse_event([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dx, [NativeTypeName("DWORD")] uint dy, [NativeTypeName("DWORD")] uint dwData, [NativeTypeName("ULONG_PTR")] nuint dwExtraInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint SendInput(uint cInputs, [NativeTypeName("LPINPUT")] INPUT* pInputs, int cbSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetTouchInputInfo(HTOUCHINPUT hTouchInput, uint cInputs, [NativeTypeName("PTOUCHINPUT")] TOUCHINPUT* pInputs, int cbSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CloseTouchInputHandle(HTOUCHINPUT hTouchInput);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL RegisterTouchWindow(HWND hwnd, [NativeTypeName("ULONG")] uint ulFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnregisterTouchWindow(HWND hwnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsTouchWindow(HWND hwnd, [NativeTypeName("PULONG")] uint* pulFlags);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL InitializeTouchInjection([NativeTypeName("UINT32")] uint maxCount, [NativeTypeName("DWORD")] uint dwMode);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL InjectTouchInput([NativeTypeName("UINT32")] uint count, [NativeTypeName("const POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* contacts);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerType([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_INPUT_TYPE *")] uint* pointerType);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerCursorId([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* cursorId);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerInfo([NativeTypeName("UINT32")] uint pointerId, POINTER_INFO* pointerInfo);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, POINTER_INFO* pointerInfo);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerFrameInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, POINTER_INFO* pointerInfo);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerFrameInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, POINTER_INFO* pointerInfo);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerTouchInfo([NativeTypeName("UINT32")] uint pointerId, POINTER_TOUCH_INFO* touchInfo);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerTouchInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, POINTER_TOUCH_INFO* touchInfo);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerFrameTouchInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, POINTER_TOUCH_INFO* touchInfo);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerFrameTouchInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, POINTER_TOUCH_INFO* touchInfo);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerPenInfo([NativeTypeName("UINT32")] uint pointerId, POINTER_PEN_INFO* penInfo);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerPenInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, POINTER_PEN_INFO* penInfo);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerFramePenInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, POINTER_PEN_INFO* penInfo);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerFramePenInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, POINTER_PEN_INFO* penInfo);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SkipPointerFrameMessages([NativeTypeName("UINT32")] uint pointerId);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL RegisterPointerInputTarget(HWND hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnregisterPointerInputTarget(HWND hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);

        [SupportedOSPlatform("windows10.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL RegisterPointerInputTargetEx(HWND hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType, BOOL fObserve);

        [SupportedOSPlatform("windows10.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL UnregisterPointerInputTargetEx(HWND hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);

        [SupportedOSPlatform("windows10.0.17763.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HSYNTHETICPOINTERDEVICE CreateSyntheticPointerDevice([NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType, [NativeTypeName("ULONG")] uint maxCount, POINTER_FEEDBACK_MODE mode);

        [SupportedOSPlatform("windows10.0.17763.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL InjectSyntheticPointerInput(HSYNTHETICPOINTERDEVICE device, [NativeTypeName("const POINTER_TYPE_INFO *")] POINTER_TYPE_INFO* pointerInfo, [NativeTypeName("UINT32")] uint count);

        [SupportedOSPlatform("windows10.0.17763.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern void DestroySyntheticPointerDevice(HSYNTHETICPOINTERDEVICE device);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EnableMouseInPointer(BOOL fEnable);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsMouseInPointerEnabled();

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL RegisterTouchHitTestingWindow(HWND hwnd, [NativeTypeName("ULONG")] uint value);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EvaluateProximityToRect([NativeTypeName("const RECT *")] RECT* controlBoundingBox, [NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] TOUCH_HIT_TESTING_INPUT* pHitTestingInput, TOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EvaluateProximityToPolygon([NativeTypeName("UINT32")] uint numVertices, [NativeTypeName("const POINT *")] POINT* controlPolygon, [NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] TOUCH_HIT_TESTING_INPUT* pHitTestingInput, TOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern LRESULT PackTouchHitTestingProximityEvaluation([NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] TOUCH_HIT_TESTING_INPUT* pHitTestingInput, [NativeTypeName("const TOUCH_HIT_TESTING_PROXIMITY_EVALUATION *")] TOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL GetWindowFeedbackSetting(HWND hwnd, FEEDBACK_TYPE feedback, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("UINT32 *")] uint* pSize, void* config);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL SetWindowFeedbackSetting(HWND hwnd, FEEDBACK_TYPE feedback, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("UINT32")] uint size, [NativeTypeName("const void *")] void* configuration);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerInputTransform([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint historyCount, INPUT_TRANSFORM* inputTransform);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL GetLastInputInfo([NativeTypeName("PLASTINPUTINFO")] LASTINPUTINFO* plii);

        [DllImport("user32", ExactSpelling = true)]
        public static extern uint MapVirtualKeyA(uint uCode, uint uMapType);

        [DllImport("user32", ExactSpelling = true)]
        public static extern uint MapVirtualKeyW(uint uCode, uint uMapType);

        [DllImport("user32", ExactSpelling = true)]
        public static extern uint MapVirtualKeyExA(uint uCode, uint uMapType, HKL dwhkl);

        [DllImport("user32", ExactSpelling = true)]
        public static extern uint MapVirtualKeyExW(uint uCode, uint uMapType, HKL dwhkl);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL GetInputState();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetQueueStatus(uint flags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWND GetCapture();

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWND SetCapture(HWND hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ReleaseCapture();

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MsgWaitForMultipleObjects([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] HANDLE* pHandles, BOOL fWaitAll, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("DWORD")] uint dwWakeMask);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MsgWaitForMultipleObjectsEx([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] HANDLE* pHandles, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("DWORD")] uint dwWakeMask, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT_PTR")]
        public static extern nuint SetTimer(HWND hWnd, [NativeTypeName("UINT_PTR")] nuint nIDEvent, uint uElapse, [NativeTypeName("TIMERPROC")] delegate* unmanaged<HWND, uint, nuint, uint, void> lpTimerFunc);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT_PTR")]
        public static extern nuint SetCoalescableTimer(HWND hWnd, [NativeTypeName("UINT_PTR")] nuint nIDEvent, uint uElapse, [NativeTypeName("TIMERPROC")] delegate* unmanaged<HWND, uint, nuint, uint, void> lpTimerFunc, [NativeTypeName("ULONG")] uint uToleranceDelay);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL KillTimer(HWND hWnd, [NativeTypeName("UINT_PTR")] nuint uIDEvent);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsWindowUnicode(HWND hWnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL EnableWindow(HWND hWnd, BOOL bEnable);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsWindowEnabled(HWND hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HACCEL LoadAcceleratorsA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTableName);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HACCEL LoadAcceleratorsW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTableName);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HACCEL CreateAcceleratorTableA([NativeTypeName("LPACCEL")] ACCEL* paccel, int cAccel);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HACCEL CreateAcceleratorTableW([NativeTypeName("LPACCEL")] ACCEL* paccel, int cAccel);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL DestroyAcceleratorTable(HACCEL hAccel);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int CopyAcceleratorTableA(HACCEL hAccelSrc, [NativeTypeName("LPACCEL")] ACCEL* lpAccelDst, int cAccelEntries);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int CopyAcceleratorTableW(HACCEL hAccelSrc, [NativeTypeName("LPACCEL")] ACCEL* lpAccelDst, int cAccelEntries);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int TranslateAcceleratorA(HWND hWnd, HACCEL hAccTable, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int TranslateAcceleratorW(HWND hWnd, HACCEL hAccTable, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetSystemMetrics(int nIndex);

        [SupportedOSPlatform("windows10.0.14393.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetSystemMetricsForDpi(int nIndex, uint dpi);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HMENU LoadMenuA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpMenuName);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HMENU LoadMenuW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpMenuName);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HMENU LoadMenuIndirectA([NativeTypeName("const MENUTEMPLATEA *")] void* lpMenuTemplate);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HMENU LoadMenuIndirectW([NativeTypeName("const MENUTEMPLATEW *")] void* lpMenuTemplate);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HMENU GetMenu(HWND hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetMenu(HWND hWnd, HMENU hMenu);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL ChangeMenuA(HMENU hMenu, uint cmd, [NativeTypeName("LPCSTR")] sbyte* lpszNewItem, uint cmdInsert, uint flags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL ChangeMenuW(HMENU hMenu, uint cmd, [NativeTypeName("LPCWSTR")] ushort* lpszNewItem, uint cmdInsert, uint flags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL HiliteMenuItem(HWND hWnd, HMENU hMenu, uint uIDHiliteItem, uint uHilite);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetMenuStringA(HMENU hMenu, uint uIDItem, [NativeTypeName("LPSTR")] sbyte* lpString, int cchMax, uint flags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetMenuStringW(HMENU hMenu, uint uIDItem, [NativeTypeName("LPWSTR")] ushort* lpString, int cchMax, uint flags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern uint GetMenuState(HMENU hMenu, uint uId, uint uFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DrawMenuBar(HWND hWnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HMENU GetSystemMenu(HWND hWnd, BOOL bRevert);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HMENU CreateMenu();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HMENU CreatePopupMenu();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DestroyMenu(HMENU hMenu);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CheckMenuItem(HMENU hMenu, uint uIDCheckItem, uint uCheck);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL EnableMenuItem(HMENU hMenu, uint uIDEnableItem, uint uEnable);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HMENU GetSubMenu(HMENU hMenu, int nPos);

        [DllImport("user32", ExactSpelling = true)]
        public static extern uint GetMenuItemID(HMENU hMenu, int nPos);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetMenuItemCount(HMENU hMenu);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL InsertMenuA(HMENU hMenu, uint uPosition, uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCSTR")] sbyte* lpNewItem);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL InsertMenuW(HMENU hMenu, uint uPosition, uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCWSTR")] ushort* lpNewItem);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL AppendMenuA(HMENU hMenu, uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCSTR")] sbyte* lpNewItem);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL AppendMenuW(HMENU hMenu, uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCWSTR")] ushort* lpNewItem);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ModifyMenuA(HMENU hMnu, uint uPosition, uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCSTR")] sbyte* lpNewItem);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ModifyMenuW(HMENU hMnu, uint uPosition, uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCWSTR")] ushort* lpNewItem);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL RemoveMenu(HMENU hMenu, uint uPosition, uint uFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DeleteMenu(HMENU hMenu, uint uPosition, uint uFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetMenuItemBitmaps(HMENU hMenu, uint uPosition, uint uFlags, HBITMAP hBitmapUnchecked, HBITMAP hBitmapChecked);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetMenuCheckMarkDimensions();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL TrackPopupMenu(HMENU hMenu, uint uFlags, int x, int y, int nReserved, HWND hWnd, [NativeTypeName("const RECT *")] RECT* prcRect);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL TrackPopupMenuEx(HMENU hMenu, uint uFlags, int x, int y, HWND hwnd, [NativeTypeName("LPTPMPARAMS")] TPMPARAMS* lptpm);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CalculatePopupWindowPosition([NativeTypeName("const POINT *")] POINT* anchorPoint, [NativeTypeName("const SIZE *")] SIZE* windowSize, uint flags, RECT* excludeRect, RECT* popupWindowPosition);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetMenuInfo(HMENU param0, [NativeTypeName("LPMENUINFO")] MENUINFO* param1);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetMenuInfo(HMENU param0, [NativeTypeName("LPCMENUINFO")] MENUINFO* param1);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EndMenu();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL InsertMenuItemA(HMENU hmenu, uint item, BOOL fByPosition, [NativeTypeName("LPCMENUITEMINFOA")] MENUITEMINFOA* lpmi);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL InsertMenuItemW(HMENU hmenu, uint item, BOOL fByPosition, [NativeTypeName("LPCMENUITEMINFOW")] MENUITEMINFOW* lpmi);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetMenuItemInfoA(HMENU hmenu, uint item, BOOL fByPosition, [NativeTypeName("LPMENUITEMINFOA")] MENUITEMINFOA* lpmii);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetMenuItemInfoW(HMENU hmenu, uint item, BOOL fByPosition, [NativeTypeName("LPMENUITEMINFOW")] MENUITEMINFOW* lpmii);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetMenuItemInfoA(HMENU hmenu, uint item, BOOL fByPositon, [NativeTypeName("LPCMENUITEMINFOA")] MENUITEMINFOA* lpmii);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetMenuItemInfoW(HMENU hmenu, uint item, BOOL fByPositon, [NativeTypeName("LPCMENUITEMINFOW")] MENUITEMINFOW* lpmii);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint GetMenuDefaultItem(HMENU hMenu, uint fByPos, uint gmdiFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetMenuDefaultItem(HMENU hMenu, uint uItem, uint fByPos);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetMenuItemRect(HWND hWnd, HMENU hMenu, uint uItem, [NativeTypeName("LPRECT")] RECT* lprcItem);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int MenuItemFromPoint(HWND hWnd, HMENU hMenu, POINT ptScreen);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DragObject(HWND hwndParent, HWND hwndFrom, uint fmt, [NativeTypeName("ULONG_PTR")] nuint data, HCURSOR hcur);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL DragDetect(HWND hwnd, POINT pt);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DrawIcon(HDC hDC, int X, int Y, HICON hIcon);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int DrawTextA(HDC hdc, [NativeTypeName("LPCSTR")] sbyte* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, uint format);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int DrawTextW(HDC hdc, [NativeTypeName("LPCWSTR")] ushort* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, uint format);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int DrawTextExA(HDC hdc, [NativeTypeName("LPSTR")] sbyte* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, uint format, [NativeTypeName("LPDRAWTEXTPARAMS")] DRAWTEXTPARAMS* lpdtp);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int DrawTextExW(HDC hdc, [NativeTypeName("LPWSTR")] ushort* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, uint format, [NativeTypeName("LPDRAWTEXTPARAMS")] DRAWTEXTPARAMS* lpdtp);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL GrayStringA(HDC hDC, HBRUSH hBrush, [NativeTypeName("GRAYSTRINGPROC")] delegate* unmanaged<HDC, LPARAM, int, BOOL> lpOutputFunc, LPARAM lpData, int nCount, int X, int Y, int nWidth, int nHeight);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL GrayStringW(HDC hDC, HBRUSH hBrush, [NativeTypeName("GRAYSTRINGPROC")] delegate* unmanaged<HDC, LPARAM, int, BOOL> lpOutputFunc, LPARAM lpData, int nCount, int X, int Y, int nWidth, int nHeight);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL DrawStateA(HDC hdc, HBRUSH hbrFore, [NativeTypeName("DRAWSTATEPROC")] delegate* unmanaged<HDC, LPARAM, WPARAM, int, int, BOOL> qfnCallBack, LPARAM lData, WPARAM wData, int x, int y, int cx, int cy, uint uFlags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL DrawStateW(HDC hdc, HBRUSH hbrFore, [NativeTypeName("DRAWSTATEPROC")] delegate* unmanaged<HDC, LPARAM, WPARAM, int, int, BOOL> qfnCallBack, LPARAM lData, WPARAM wData, int x, int y, int cx, int cy, uint uFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int TabbedTextOutA(HDC hdc, int x, int y, [NativeTypeName("LPCSTR")] sbyte* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions, int nTabOrigin);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int TabbedTextOutW(HDC hdc, int x, int y, [NativeTypeName("LPCWSTR")] ushort* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions, int nTabOrigin);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTabbedTextExtentA(HDC hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTabbedTextExtentW(HDC hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL UpdateWindow(HWND hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND SetActiveWindow(HWND hWnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWND GetForegroundWindow();

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL PaintDesktop(HDC hdc);

        [DllImport("user32", ExactSpelling = true)]
        public static extern void SwitchToThisWindow(HWND hwnd, BOOL fUnknown);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL SetForegroundWindow(HWND hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL AllowSetForegroundWindow([NativeTypeName("DWORD")] uint dwProcessId);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL LockSetForegroundWindow(uint uLockCode);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWND WindowFromDC(HDC hDC);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HDC GetDC(HWND hWnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HDC GetDCEx(HWND hWnd, HRGN hrgnClip, [NativeTypeName("DWORD")] uint flags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HDC GetWindowDC(HWND hWnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int ReleaseDC(HWND hWnd, HDC hDC);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HDC BeginPaint(HWND hWnd, [NativeTypeName("LPPAINTSTRUCT")] PAINTSTRUCT* lpPaint);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL EndPaint(HWND hWnd, [NativeTypeName("const PAINTSTRUCT *")] PAINTSTRUCT* lpPaint);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL GetUpdateRect(HWND hWnd, [NativeTypeName("LPRECT")] RECT* lpRect, BOOL bErase);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetUpdateRgn(HWND hWnd, HRGN hRgn, BOOL bErase);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int SetWindowRgn(HWND hWnd, HRGN hRgn, BOOL bRedraw);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetWindowRgn(HWND hWnd, HRGN hRgn);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int GetWindowRgnBox(HWND hWnd, [NativeTypeName("LPRECT")] RECT* lprc);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int ExcludeUpdateRgn(HDC hDC, HWND hWnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL InvalidateRect(HWND hWnd, [NativeTypeName("const RECT *")] RECT* lpRect, BOOL bErase);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL ValidateRect(HWND hWnd, [NativeTypeName("const RECT *")] RECT* lpRect);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL InvalidateRgn(HWND hWnd, HRGN hRgn, BOOL bErase);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL ValidateRgn(HWND hWnd, HRGN hRgn);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL RedrawWindow(HWND hWnd, [NativeTypeName("const RECT *")] RECT* lprcUpdate, HRGN hrgnUpdate, uint flags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL LockWindowUpdate(HWND hWndLock);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ScrollWindow(HWND hWnd, int XAmount, int YAmount, [NativeTypeName("const RECT *")] RECT* lpRect, [NativeTypeName("const RECT *")] RECT* lpClipRect);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ScrollDC(HDC hDC, int dx, int dy, [NativeTypeName("const RECT *")] RECT* lprcScroll, [NativeTypeName("const RECT *")] RECT* lprcClip, HRGN hrgnUpdate, [NativeTypeName("LPRECT")] RECT* lprcUpdate);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int ScrollWindowEx(HWND hWnd, int dx, int dy, [NativeTypeName("const RECT *")] RECT* prcScroll, [NativeTypeName("const RECT *")] RECT* prcClip, HRGN hrgnUpdate, [NativeTypeName("LPRECT")] RECT* prcUpdate, uint flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int SetScrollPos(HWND hWnd, int nBar, int nPos, BOOL bRedraw);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetScrollPos(HWND hWnd, int nBar);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetScrollRange(HWND hWnd, int nBar, int nMinPos, int nMaxPos, BOOL bRedraw);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetScrollRange(HWND hWnd, int nBar, [NativeTypeName("LPINT")] int* lpMinPos, [NativeTypeName("LPINT")] int* lpMaxPos);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ShowScrollBar(HWND hWnd, int wBar, BOOL bShow);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EnableScrollBar(HWND hWnd, uint wSBflags, uint wArrows);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetPropA(HWND hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString, HANDLE hData);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetPropW(HWND hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString, HANDLE hData);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HANDLE GetPropA(HWND hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HANDLE GetPropW(HWND hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HANDLE RemovePropA(HWND hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HANDLE RemovePropW(HWND hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int EnumPropsExA(HWND hWnd, [NativeTypeName("PROPENUMPROCEXA")] delegate* unmanaged<HWND, sbyte*, HANDLE, nuint, BOOL> lpEnumFunc, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int EnumPropsExW(HWND hWnd, [NativeTypeName("PROPENUMPROCEXW")] delegate* unmanaged<HWND, ushort*, HANDLE, nuint, BOOL> lpEnumFunc, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int EnumPropsA(HWND hWnd, [NativeTypeName("PROPENUMPROCA")] delegate* unmanaged<HWND, sbyte*, HANDLE, BOOL> lpEnumFunc);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int EnumPropsW(HWND hWnd, [NativeTypeName("PROPENUMPROCW")] delegate* unmanaged<HWND, ushort*, HANDLE, BOOL> lpEnumFunc);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetWindowTextA(HWND hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetWindowTextW(HWND hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetWindowTextA(HWND hWnd, [NativeTypeName("LPSTR")] sbyte* lpString, int nMaxCount);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetWindowTextW(HWND hWnd, [NativeTypeName("LPWSTR")] ushort* lpString, int nMaxCount);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetWindowTextLengthA(HWND hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetWindowTextLengthW(HWND hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetClientRect(HWND hWnd, [NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetWindowRect(HWND hWnd, [NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL AdjustWindowRect([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, BOOL bMenu);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL AdjustWindowRectEx([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, BOOL bMenu, [NativeTypeName("DWORD")] uint dwExStyle);

        [SupportedOSPlatform("windows10.0.14393.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL AdjustWindowRectExForDpi([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, BOOL bMenu, [NativeTypeName("DWORD")] uint dwExStyle, uint dpi);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetWindowContextHelpId(HWND param0, [NativeTypeName("DWORD")] uint param1);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetWindowContextHelpId(HWND param0);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetMenuContextHelpId(HMENU param0, [NativeTypeName("DWORD")] uint param1);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetMenuContextHelpId(HMENU param0);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int MessageBoxA(HWND hWnd, [NativeTypeName("LPCSTR")] sbyte* lpText, [NativeTypeName("LPCSTR")] sbyte* lpCaption, uint uType);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int MessageBoxW(HWND hWnd, [NativeTypeName("LPCWSTR")] ushort* lpText, [NativeTypeName("LPCWSTR")] ushort* lpCaption, uint uType);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int MessageBoxExA(HWND hWnd, [NativeTypeName("LPCSTR")] sbyte* lpText, [NativeTypeName("LPCSTR")] sbyte* lpCaption, uint uType, [NativeTypeName("WORD")] ushort wLanguageId);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int MessageBoxExW(HWND hWnd, [NativeTypeName("LPCWSTR")] ushort* lpText, [NativeTypeName("LPCWSTR")] ushort* lpCaption, uint uType, [NativeTypeName("WORD")] ushort wLanguageId);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int MessageBoxIndirectA([NativeTypeName("const MSGBOXPARAMSA *")] MSGBOXPARAMSA* lpmbp);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int MessageBoxIndirectW([NativeTypeName("const MSGBOXPARAMSW *")] MSGBOXPARAMSW* lpmbp);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL MessageBeep(uint uType);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int ShowCursor(BOOL bShow);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetCursorPos(int X, int Y);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL SetPhysicalCursorPos(int X, int Y);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HCURSOR SetCursor(HCURSOR hCursor);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetCursorPos([NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPhysicalCursorPos([NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetClipCursor([NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HCURSOR GetCursor();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CreateCaret(HWND hWnd, HBITMAP hBitmap, int nWidth, int nHeight);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint GetCaretBlinkTime();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetCaretBlinkTime(uint uMSeconds);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DestroyCaret();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL HideCaret(HWND hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ShowCaret(HWND hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetCaretPos(int X, int Y);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetCaretPos([NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL ClientToScreen(HWND hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL ScreenToClient(HWND hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL LogicalToPhysicalPoint(HWND hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL PhysicalToLogicalPoint(HWND hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL LogicalToPhysicalPointForPerMonitorDPI(HWND hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL PhysicalToLogicalPointForPerMonitorDPI(HWND hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int MapWindowPoints(HWND hWndFrom, HWND hWndTo, [NativeTypeName("LPPOINT")] POINT* lpPoints, uint cPoints);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWND WindowFromPoint(POINT Point);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWND WindowFromPhysicalPoint(POINT Point);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWND ChildWindowFromPoint(HWND hWndParent, POINT Point);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ClipCursor([NativeTypeName("const RECT *")] RECT* lpRect);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWND ChildWindowFromPointEx(HWND hwnd, POINT pt, uint flags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetSysColor(int nIndex);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HBRUSH GetSysColorBrush(int nIndex);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetSysColors(int cElements, [NativeTypeName("const INT *")] int* lpaElements, [NativeTypeName("const COLORREF *")] COLORREF* lpaRgbValues);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL DrawFocusRect(HDC hDC, [NativeTypeName("const RECT *")] RECT* lprc);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int FillRect(HDC hDC, [NativeTypeName("const RECT *")] RECT* lprc, HBRUSH hbr);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int FrameRect(HDC hDC, [NativeTypeName("const RECT *")] RECT* lprc, HBRUSH hbr);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL InvertRect(HDC hDC, [NativeTypeName("const RECT *")] RECT* lprc);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL SetRect([NativeTypeName("LPRECT")] RECT* lprc, int xLeft, int yTop, int xRight, int yBottom);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL SetRectEmpty([NativeTypeName("LPRECT")] RECT* lprc);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL CopyRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL InflateRect([NativeTypeName("LPRECT")] RECT* lprc, int dx, int dy);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IntersectRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL UnionRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL SubtractRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL OffsetRect([NativeTypeName("LPRECT")] RECT* lprc, int dx, int dy);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsRectEmpty([NativeTypeName("const RECT *")] RECT* lprc);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL EqualRect([NativeTypeName("const RECT *")] RECT* lprc1, [NativeTypeName("const RECT *")] RECT* lprc2);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL PtInRect([NativeTypeName("const RECT *")] RECT* lprc, POINT pt);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort GetWindowWord(HWND hWnd, int nIndex);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort SetWindowWord(HWND hWnd, int nIndex, [NativeTypeName("WORD")] ushort wNewWord);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetWindowLongA(HWND hWnd, int nIndex);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetWindowLongW(HWND hWnd, int nIndex);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetWindowLongA(HWND hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetWindowLongW(HWND hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort GetClassWord(HWND hWnd, int nIndex);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort SetClassWord(HWND hWnd, int nIndex, [NativeTypeName("WORD")] ushort wNewWord);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetClassLongA(HWND hWnd, int nIndex);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetClassLongW(HWND hWnd, int nIndex);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetClassLongA(HWND hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetClassLongW(HWND hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetProcessDefaultLayout([NativeTypeName("DWORD *")] uint* pdwDefaultLayout);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetProcessDefaultLayout([NativeTypeName("DWORD")] uint dwDefaultLayout);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWND GetDesktopWindow();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND GetParent(HWND hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND SetParent(HWND hWndChild, HWND hWndNewParent);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL EnumChildWindows(HWND hWndParent, [NativeTypeName("WNDENUMPROC")] delegate* unmanaged<HWND, LPARAM, BOOL> lpEnumFunc, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND FindWindowA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND FindWindowW([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND FindWindowExA(HWND hWndParent, HWND hWndChildAfter, [NativeTypeName("LPCSTR")] sbyte* lpszClass, [NativeTypeName("LPCSTR")] sbyte* lpszWindow);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND FindWindowExW(HWND hWndParent, HWND hWndChildAfter, [NativeTypeName("LPCWSTR")] ushort* lpszClass, [NativeTypeName("LPCWSTR")] ushort* lpszWindow);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWND GetShellWindow();

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL RegisterShellHookWindow(HWND hwnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL DeregisterShellHookWindow(HWND hwnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EnumWindows([NativeTypeName("WNDENUMPROC")] delegate* unmanaged<HWND, LPARAM, BOOL> lpEnumFunc, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL EnumThreadWindows([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("WNDENUMPROC")] delegate* unmanaged<HWND, LPARAM, BOOL> lpfn, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetClassNameA(HWND hWnd, [NativeTypeName("LPSTR")] sbyte* lpClassName, int nMaxCount);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetClassNameW(HWND hWnd, [NativeTypeName("LPWSTR")] ushort* lpClassName, int nMaxCount);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND GetTopWindow(HWND hWnd);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetWindowThreadProcessId(HWND hWnd, [NativeTypeName("LPDWORD")] uint* lpdwProcessId);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsGUIThread(BOOL bConvert);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWND GetLastActivePopup(HWND hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND GetWindow(HWND hWnd, uint uCmd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HHOOK SetWindowsHookA(int nFilterType, [NativeTypeName("HOOKPROC")] delegate* unmanaged<int, WPARAM, LPARAM, LRESULT> pfnFilterProc);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HHOOK SetWindowsHookW(int nFilterType, [NativeTypeName("HOOKPROC")] delegate* unmanaged<int, WPARAM, LPARAM, LRESULT> pfnFilterProc);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL UnhookWindowsHook(int nCode, [NativeTypeName("HOOKPROC")] delegate* unmanaged<int, WPARAM, LPARAM, LRESULT> pfnFilterProc);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HHOOK SetWindowsHookExA(int idHook, [NativeTypeName("HOOKPROC")] delegate* unmanaged<int, WPARAM, LPARAM, LRESULT> lpfn, HINSTANCE hmod, [NativeTypeName("DWORD")] uint dwThreadId);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HHOOK SetWindowsHookExW(int idHook, [NativeTypeName("HOOKPROC")] delegate* unmanaged<int, WPARAM, LPARAM, LRESULT> lpfn, HINSTANCE hmod, [NativeTypeName("DWORD")] uint dwThreadId);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnhookWindowsHookEx(HHOOK hhk);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT CallNextHookEx(HHOOK hhk, int nCode, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CheckMenuRadioItem(HMENU hmenu, uint first, uint last, uint check, uint flags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HBITMAP LoadBitmapA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpBitmapName);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HBITMAP LoadBitmapW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpBitmapName);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HCURSOR LoadCursorA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpCursorName);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HCURSOR LoadCursorW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpCursorName);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HCURSOR LoadCursorFromFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HCURSOR LoadCursorFromFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HCURSOR CreateCursor(HINSTANCE hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, [NativeTypeName("const void *")] void* pvANDPlane, [NativeTypeName("const void *")] void* pvXORPlane);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DestroyCursor(HCURSOR hCursor);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetSystemCursor(HCURSOR hcur, [NativeTypeName("DWORD")] uint id);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HICON LoadIconA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpIconName);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HICON LoadIconW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpIconName);

        [DllImport("user32", ExactSpelling = true)]
        public static extern uint PrivateExtractIconsA([NativeTypeName("LPCSTR")] sbyte* szFileName, int nIconIndex, int cxIcon, int cyIcon, HICON* phicon, uint* piconid, uint nIcons, uint flags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern uint PrivateExtractIconsW([NativeTypeName("LPCWSTR")] ushort* szFileName, int nIconIndex, int cxIcon, int cyIcon, HICON* phicon, uint* piconid, uint nIcons, uint flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HICON CreateIcon(HINSTANCE hInstance, int nWidth, int nHeight, byte cPlanes, byte cBitsPixel, [NativeTypeName("const BYTE *")] byte* lpbANDbits, [NativeTypeName("const BYTE *")] byte* lpbXORbits);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DestroyIcon(HICON hIcon);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int LookupIconIdFromDirectory([NativeTypeName("PBYTE")] byte* presbits, BOOL fIcon);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int LookupIconIdFromDirectoryEx([NativeTypeName("PBYTE")] byte* presbits, BOOL fIcon, int cxDesired, int cyDesired, uint Flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HICON CreateIconFromResource([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("DWORD")] uint dwResSize, BOOL fIcon, [NativeTypeName("DWORD")] uint dwVer);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HICON CreateIconFromResourceEx([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("DWORD")] uint dwResSize, BOOL fIcon, [NativeTypeName("DWORD")] uint dwVer, int cxDesired, int cyDesired, uint Flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HANDLE LoadImageA(HINSTANCE hInst, [NativeTypeName("LPCSTR")] sbyte* name, uint type, int cx, int cy, uint fuLoad);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HANDLE LoadImageW(HINSTANCE hInst, [NativeTypeName("LPCWSTR")] ushort* name, uint type, int cx, int cy, uint fuLoad);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HANDLE CopyImage(HANDLE h, uint type, int cx, int cy, uint flags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DrawIconEx(HDC hdc, int xLeft, int yTop, HICON hIcon, int cxWidth, int cyWidth, uint istepIfAniCur, HBRUSH hbrFlickerFreeDraw, uint diFlags);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HICON CreateIconIndirect([NativeTypeName("PICONINFO")] ICONINFO* piconinfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HICON CopyIcon(HICON hIcon);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetIconInfo(HICON hIcon, [NativeTypeName("PICONINFO")] ICONINFO* piconinfo);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL GetIconInfoExA(HICON hicon, [NativeTypeName("PICONINFOEXA")] ICONINFOEXA* piconinfo);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL GetIconInfoExW(HICON hicon, [NativeTypeName("PICONINFOEXW")] ICONINFOEXW* piconinfo);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsDialogMessageA(HWND hDlg, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsDialogMessageW(HWND hDlg, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL MapDialogRect(HWND hDlg, [NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int DlgDirListA(HWND hDlg, [NativeTypeName("LPSTR")] sbyte* lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int DlgDirListW(HWND hDlg, [NativeTypeName("LPWSTR")] ushort* lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DlgDirSelectExA(HWND hwndDlg, [NativeTypeName("LPSTR")] sbyte* lpString, int chCount, int idListBox);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DlgDirSelectExW(HWND hwndDlg, [NativeTypeName("LPWSTR")] ushort* lpString, int chCount, int idListBox);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int DlgDirListComboBoxA(HWND hDlg, [NativeTypeName("LPSTR")] sbyte* lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int DlgDirListComboBoxW(HWND hDlg, [NativeTypeName("LPWSTR")] ushort* lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DlgDirSelectComboBoxExA(HWND hwndDlg, [NativeTypeName("LPSTR")] sbyte* lpString, int cchOut, int idComboBox);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DlgDirSelectComboBoxExW(HWND hwndDlg, [NativeTypeName("LPWSTR")] ushort* lpString, int cchOut, int idComboBox);

        [DllImport("user32", ExactSpelling = true)]
        public static extern int SetScrollInfo(HWND hwnd, int nBar, [NativeTypeName("LPCSCROLLINFO")] SCROLLINFO* lpsi, BOOL redraw);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetScrollInfo(HWND hwnd, int nBar, [NativeTypeName("LPSCROLLINFO")] SCROLLINFO* lpsi);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT DefFrameProcA(HWND hWnd, HWND hWndMDIClient, uint uMsg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT DefFrameProcW(HWND hWnd, HWND hWndMDIClient, uint uMsg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT DefMDIChildProcA(HWND hWnd, uint uMsg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT DefMDIChildProcW(HWND hWnd, uint uMsg, WPARAM wParam, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL TranslateMDISysAccel(HWND hWndClient, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint ArrangeIconicWindows(HWND hWnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND CreateMDIWindowA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, HWND hWndParent, HINSTANCE hInstance, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern HWND CreateMDIWindowW([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, HWND hWndParent, HINSTANCE hInstance, LPARAM lParam);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort TileWindows(HWND hwndParent, uint wHow, [NativeTypeName("const RECT *")] RECT* lpRect, uint cKids, [NativeTypeName("const HWND *")] HWND* lpKids);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort CascadeWindows(HWND hwndParent, uint wHow, [NativeTypeName("const RECT *")] RECT* lpRect, uint cKids, [NativeTypeName("const HWND *")] HWND* lpKids);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHelpA(HWND hWndMain, [NativeTypeName("LPCSTR")] sbyte* lpszHelp, uint uCommand, [NativeTypeName("ULONG_PTR")] nuint dwData);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WinHelpW(HWND hWndMain, [NativeTypeName("LPCWSTR")] ushort* lpszHelp, uint uCommand, [NativeTypeName("ULONG_PTR")] nuint dwData);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGuiResources(HANDLE hProcess, [NativeTypeName("DWORD")] uint uiFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ChangeDisplaySettingsA(DEVMODEA* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ChangeDisplaySettingsW(DEVMODEW* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ChangeDisplaySettingsExA([NativeTypeName("LPCSTR")] sbyte* lpszDeviceName, DEVMODEA* lpDevMode, HWND hwnd, [NativeTypeName("DWORD")] uint dwflags, [NativeTypeName("LPVOID")] void* lParam);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ChangeDisplaySettingsExW([NativeTypeName("LPCWSTR")] ushort* lpszDeviceName, DEVMODEW* lpDevMode, HWND hwnd, [NativeTypeName("DWORD")] uint dwflags, [NativeTypeName("LPVOID")] void* lParam);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL EnumDisplaySettingsA([NativeTypeName("LPCSTR")] sbyte* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, DEVMODEA* lpDevMode);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL EnumDisplaySettingsW([NativeTypeName("LPCWSTR")] ushort* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, DEVMODEW* lpDevMode);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL EnumDisplaySettingsExA([NativeTypeName("LPCSTR")] sbyte* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, DEVMODEA* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL EnumDisplaySettingsExW([NativeTypeName("LPCWSTR")] ushort* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, DEVMODEW* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL EnumDisplayDevicesA([NativeTypeName("LPCSTR")] sbyte* lpDevice, [NativeTypeName("DWORD")] uint iDevNum, [NativeTypeName("PDISPLAY_DEVICEA")] DISPLAY_DEVICEA* lpDisplayDevice, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL EnumDisplayDevicesW([NativeTypeName("LPCWSTR")] ushort* lpDevice, [NativeTypeName("DWORD")] uint iDevNum, [NativeTypeName("PDISPLAY_DEVICEW")] DISPLAY_DEVICEW* lpDisplayDevice, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetDisplayConfigBufferSizes([NativeTypeName("UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* numPathArrayElements, [NativeTypeName("UINT32 *")] uint* numModeInfoArrayElements);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetDisplayConfig([NativeTypeName("UINT32")] uint numPathArrayElements, DISPLAYCONFIG_PATH_INFO* pathArray, [NativeTypeName("UINT32")] uint numModeInfoArrayElements, DISPLAYCONFIG_MODE_INFO* modeInfoArray, [NativeTypeName("UINT32")] uint flags);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int QueryDisplayConfig([NativeTypeName("UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* numPathArrayElements, DISPLAYCONFIG_PATH_INFO* pathArray, [NativeTypeName("UINT32 *")] uint* numModeInfoArrayElements, DISPLAYCONFIG_MODE_INFO* modeInfoArray, DISPLAYCONFIG_TOPOLOGY_ID* currentTopologyId);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int DisplayConfigGetDeviceInfo(DISPLAYCONFIG_DEVICE_INFO_HEADER* requestPacket);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int DisplayConfigSetDeviceInfo(DISPLAYCONFIG_DEVICE_INFO_HEADER* setPacket);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SystemParametersInfoA(uint uiAction, uint uiParam, [NativeTypeName("PVOID")] void* pvParam, uint fWinIni);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SystemParametersInfoW(uint uiAction, uint uiParam, [NativeTypeName("PVOID")] void* pvParam, uint fWinIni);

        [SupportedOSPlatform("windows10.0.14393.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SystemParametersInfoForDpi(uint uiAction, uint uiParam, [NativeTypeName("PVOID")] void* pvParam, uint fWinIni, uint dpi);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL SoundSentry();

        [DllImport("user32", ExactSpelling = true)]
        public static extern void SetDebugErrorLevel([NativeTypeName("DWORD")] uint dwLevel);

        [DllImport("user32", ExactSpelling = true)]
        public static extern void SetLastErrorEx([NativeTypeName("DWORD")] uint dwErrCode, [NativeTypeName("DWORD")] uint dwType);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern int InternalGetWindowText(HWND hWnd, [NativeTypeName("LPWSTR")] ushort* pString, int cchMaxCount);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL CancelShutdown();

        [DllImport("user32", ExactSpelling = true)]
        public static extern HMONITOR MonitorFromPoint(POINT pt, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HMONITOR MonitorFromRect([NativeTypeName("LPCRECT")] RECT* lprc, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HMONITOR MonitorFromWindow(HWND hwnd, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL GetMonitorInfoA(HMONITOR hMonitor, [NativeTypeName("LPMONITORINFO")] MONITORINFO* lpmi);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL GetMonitorInfoW(HMONITOR hMonitor, [NativeTypeName("LPMONITORINFO")] MONITORINFO* lpmi);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL EnumDisplayMonitors(HDC hdc, [NativeTypeName("LPCRECT")] RECT* lprcClip, [NativeTypeName("MONITORENUMPROC")] delegate* unmanaged<HMONITOR, HDC, RECT*, LPARAM, BOOL> lpfnEnum, LPARAM dwData);

        [DllImport("user32", ExactSpelling = true)]
        public static extern void NotifyWinEvent([NativeTypeName("DWORD")] uint @event, HWND hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("LONG")] int idChild);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWINEVENTHOOK SetWinEventHook([NativeTypeName("DWORD")] uint eventMin, [NativeTypeName("DWORD")] uint eventMax, HMODULE hmodWinEventProc, [NativeTypeName("WINEVENTPROC")] delegate* unmanaged<HWINEVENTHOOK, uint, HWND, int, int, uint, uint, void> pfnWinEventProc, [NativeTypeName("DWORD")] uint idProcess, [NativeTypeName("DWORD")] uint idThread, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsWinEventHookInstalled([NativeTypeName("DWORD")] uint @event);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL UnhookWinEvent(HWINEVENTHOOK hWinEventHook);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetGUIThreadInfo([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("PGUITHREADINFO")] GUITHREADINFO* pgui);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL BlockInput(BOOL fBlockIt);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL SetProcessDPIAware();

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsProcessDPIAware();

        [SupportedOSPlatform("windows10.0.14393.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern DPI_AWARENESS_CONTEXT SetThreadDpiAwarenessContext(DPI_AWARENESS_CONTEXT dpiContext);

        [SupportedOSPlatform("windows10.0.14393.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern DPI_AWARENESS_CONTEXT GetThreadDpiAwarenessContext();

        [SupportedOSPlatform("windows10.0.14393.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern DPI_AWARENESS_CONTEXT GetWindowDpiAwarenessContext(HWND hwnd);

        [SupportedOSPlatform("windows10.0.14393.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern DPI_AWARENESS GetAwarenessFromDpiAwarenessContext(DPI_AWARENESS_CONTEXT value);

        [SupportedOSPlatform("windows10.0.17134.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern uint GetDpiFromDpiAwarenessContext(DPI_AWARENESS_CONTEXT value);

        [SupportedOSPlatform("windows10.0.14393.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL AreDpiAwarenessContextsEqual(DPI_AWARENESS_CONTEXT dpiContextA, DPI_AWARENESS_CONTEXT dpiContextB);

        [SupportedOSPlatform("windows10.0.14393.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL IsValidDpiAwarenessContext(DPI_AWARENESS_CONTEXT value);

        [SupportedOSPlatform("windows10.0.14393.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern uint GetDpiForWindow(HWND hwnd);

        [SupportedOSPlatform("windows10.0.14393.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern uint GetDpiForSystem();

        [SupportedOSPlatform("windows10.0.17134.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern uint GetSystemDpiForProcess(HANDLE hProcess);

        [SupportedOSPlatform("windows10.0.14393.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EnableNonClientDpiScaling(HWND hwnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL InheritWindowMonitor(HWND hwnd, HWND hwndInherit);

        [SupportedOSPlatform("windows10.0.15063.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetProcessDpiAwarenessContext(DPI_AWARENESS_CONTEXT value);

        [DllImport("user32", ExactSpelling = true)]
        public static extern DPI_AWARENESS_CONTEXT GetDpiAwarenessContextForProcess(HANDLE hProcess);

        [SupportedOSPlatform("windows10.0.17134.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern DPI_HOSTING_BEHAVIOR SetThreadDpiHostingBehavior(DPI_HOSTING_BEHAVIOR value);

        [SupportedOSPlatform("windows10.0.17134.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern DPI_HOSTING_BEHAVIOR GetThreadDpiHostingBehavior();

        [SupportedOSPlatform("windows10.0.17134.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern DPI_HOSTING_BEHAVIOR GetWindowDpiHostingBehavior(HWND hwnd);

        [DllImport("user32", ExactSpelling = true)]
        public static extern uint GetWindowModuleFileNameA(HWND hwnd, [NativeTypeName("LPSTR")] sbyte* pszFileName, uint cchFileNameMax);

        [DllImport("user32", ExactSpelling = true)]
        public static extern uint GetWindowModuleFileNameW(HWND hwnd, [NativeTypeName("LPWSTR")] ushort* pszFileName, uint cchFileNameMax);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetCursorInfo([NativeTypeName("PCURSORINFO")] CURSORINFO* pci);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetWindowInfo(HWND hwnd, [NativeTypeName("PWINDOWINFO")] WINDOWINFO* pwi);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetTitleBarInfo(HWND hwnd, [NativeTypeName("PTITLEBARINFO")] TITLEBARINFO* pti);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetMenuBarInfo(HWND hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("LONG")] int idItem, [NativeTypeName("PMENUBARINFO")] MENUBARINFO* pmbi);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetScrollBarInfo(HWND hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("PSCROLLBARINFO")] SCROLLBARINFO* psbi);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetComboBoxInfo(HWND hwndCombo, [NativeTypeName("PCOMBOBOXINFO")] COMBOBOXINFO* pcbi);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWND GetAncestor(HWND hwnd, uint gaFlags);

        [DllImport("user32", ExactSpelling = true)]
        public static extern HWND RealChildWindowFromPoint(HWND hwndParent, POINT ptParentClientCoords);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint RealGetWindowClassA(HWND hwnd, [NativeTypeName("LPSTR")] sbyte* ptszClassName, uint cchClassNameMax);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint RealGetWindowClassW(HWND hwnd, [NativeTypeName("LPWSTR")] ushort* ptszClassName, uint cchClassNameMax);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetAltTabInfoA(HWND hwnd, int iItem, [NativeTypeName("PALTTABINFO")] ALTTABINFO* pati, [NativeTypeName("LPSTR")] sbyte* pszItemText, uint cchItemText);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetAltTabInfoW(HWND hwnd, int iItem, [NativeTypeName("PALTTABINFO")] ALTTABINFO* pati, [NativeTypeName("LPWSTR")] ushort* pszItemText, uint cchItemText);

        [DllImport("user32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetListBoxInfo(HWND hwnd);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL LockWorkStation();

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UserHandleGrantAccess(HANDLE hUserHandle, HANDLE hJob, BOOL bGrant);

        [DllImport("user32", ExactSpelling = true)]
        public static extern uint GetRawInputData(HRAWINPUT hRawInput, uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize, uint cbSizeHeader);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint GetRawInputDeviceInfoA(HANDLE hDevice, uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint GetRawInputDeviceInfoW(HANDLE hDevice, uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize);

        [DllImport("user32", ExactSpelling = true)]
        public static extern uint GetRawInputBuffer([NativeTypeName("PRAWINPUT")] RAWINPUT* pData, [NativeTypeName("PUINT")] uint* pcbSize, uint cbSizeHeader);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL RegisterRawInputDevices([NativeTypeName("PCRAWINPUTDEVICE")] RAWINPUTDEVICE* pRawInputDevices, uint uiNumDevices, uint cbSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint GetRegisteredRawInputDevices([NativeTypeName("PRAWINPUTDEVICE")] RAWINPUTDEVICE* pRawInputDevices, [NativeTypeName("PUINT")] uint* puiNumDevices, uint cbSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern uint GetRawInputDeviceList([NativeTypeName("PRAWINPUTDEVICELIST")] RAWINPUTDEVICELIST* pRawInputDeviceList, [NativeTypeName("PUINT")] uint* puiNumDevices, uint cbSize);

        [DllImport("user32", ExactSpelling = true)]
        public static extern LRESULT DefRawInputProc([NativeTypeName("PRAWINPUT *")] RAWINPUT** paRawInput, int nInput, uint cbSizeHeader);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerDevices([NativeTypeName("UINT32 *")] uint* deviceCount, POINTER_DEVICE_INFO* pointerDevices);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerDevice(HANDLE device, POINTER_DEVICE_INFO* pointerDevice);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerDeviceProperties(HANDLE device, [NativeTypeName("UINT32 *")] uint* propertyCount, POINTER_DEVICE_PROPERTY* pointerProperties);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL RegisterPointerDeviceNotifications(HWND window, BOOL notifyRange);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerDeviceRects(HANDLE device, RECT* pointerDeviceRect, RECT* displayRect);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetPointerDeviceCursors(HANDLE device, [NativeTypeName("UINT32 *")] uint* cursorCount, POINTER_DEVICE_CURSOR_INFO* deviceCursors);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetRawPointerDeviceData([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint historyCount, [NativeTypeName("UINT32")] uint propertiesCount, POINTER_DEVICE_PROPERTY* pProperties, [NativeTypeName("LONG *")] int* pValues);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ChangeWindowMessageFilter(uint message, [NativeTypeName("DWORD")] uint dwFlag);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ChangeWindowMessageFilterEx(HWND hwnd, uint message, [NativeTypeName("DWORD")] uint action, [NativeTypeName("PCHANGEFILTERSTRUCT")] CHANGEFILTERSTRUCT* pChangeFilterStruct);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetGestureInfo(HGESTUREINFO hGestureInfo, [NativeTypeName("PGESTUREINFO")] GESTUREINFO* pGestureInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetGestureExtraArgs(HGESTUREINFO hGestureInfo, uint cbExtraArgs, [NativeTypeName("PBYTE")] byte* pExtraArgs);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CloseGestureInfoHandle(HGESTUREINFO hGestureInfo);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetGestureConfig(HWND hwnd, [NativeTypeName("DWORD")] uint dwReserved, uint cIDs, [NativeTypeName("PGESTURECONFIG")] GESTURECONFIG* pGestureConfig, uint cbSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetGestureConfig(HWND hwnd, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PUINT")] uint* pcIDs, [NativeTypeName("PGESTURECONFIG")] GESTURECONFIG* pGestureConfig, uint cbSize);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ShutdownBlockReasonCreate(HWND hWnd, [NativeTypeName("LPCWSTR")] ushort* pwszReason);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ShutdownBlockReasonQuery(HWND hWnd, [NativeTypeName("LPWSTR")] ushort* pwszBuff, [NativeTypeName("DWORD *")] uint* pcchBuff);

        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ShutdownBlockReasonDestroy(HWND hWnd);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetCurrentInputMessageSource(INPUT_MESSAGE_SOURCE* inputMessageSource);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL GetCIMSSM(INPUT_MESSAGE_SOURCE* inputMessageSource);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL GetAutoRotationState([NativeTypeName("PAR_STATE")] AR_STATE* pState);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL GetDisplayAutoRotationPreferences(ORIENTATION_PREFERENCE* pOrientation);

        [DllImport("user32", ExactSpelling = true)]
        public static extern BOOL SetDisplayAutoRotationPreferences(ORIENTATION_PREFERENCE orientation);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL IsImmersiveProcess(HANDLE hProcess);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetProcessRestrictionExemption(BOOL fEnableExemption);

        [NativeTypeName("#define RT_CURSOR MAKEINTRESOURCE(1)")]
        public static ushort* RT_CURSOR => ((ushort*)((nuint)((ushort)(1))));

        [NativeTypeName("#define RT_BITMAP MAKEINTRESOURCE(2)")]
        public static ushort* RT_BITMAP => ((ushort*)((nuint)((ushort)(2))));

        [NativeTypeName("#define RT_ICON MAKEINTRESOURCE(3)")]
        public static ushort* RT_ICON => ((ushort*)((nuint)((ushort)(3))));

        [NativeTypeName("#define RT_MENU MAKEINTRESOURCE(4)")]
        public static ushort* RT_MENU => ((ushort*)((nuint)((ushort)(4))));

        [NativeTypeName("#define RT_DIALOG MAKEINTRESOURCE(5)")]
        public static ushort* RT_DIALOG => ((ushort*)((nuint)((ushort)(5))));

        [NativeTypeName("#define RT_STRING MAKEINTRESOURCE(6)")]
        public static ushort* RT_STRING => ((ushort*)((nuint)((ushort)(6))));

        [NativeTypeName("#define RT_FONTDIR MAKEINTRESOURCE(7)")]
        public static ushort* RT_FONTDIR => ((ushort*)((nuint)((ushort)(7))));

        [NativeTypeName("#define RT_FONT MAKEINTRESOURCE(8)")]
        public static ushort* RT_FONT => ((ushort*)((nuint)((ushort)(8))));

        [NativeTypeName("#define RT_ACCELERATOR MAKEINTRESOURCE(9)")]
        public static ushort* RT_ACCELERATOR => ((ushort*)((nuint)((ushort)(9))));

        [NativeTypeName("#define RT_RCDATA MAKEINTRESOURCE(10)")]
        public static ushort* RT_RCDATA => ((ushort*)((nuint)((ushort)(10))));

        [NativeTypeName("#define RT_MESSAGETABLE MAKEINTRESOURCE(11)")]
        public static ushort* RT_MESSAGETABLE => ((ushort*)((nuint)((ushort)(11))));

        [NativeTypeName("#define DIFFERENCE 11")]
        public const int DIFFERENCE = 11;

        [NativeTypeName("#define RT_GROUP_CURSOR MAKEINTRESOURCE((ULONG_PTR)(RT_CURSOR) + DIFFERENCE)")]
        public static ushort* RT_GROUP_CURSOR => ((ushort*)((nuint)((ushort)((nuint)(((ushort*)((nuint)((ushort)(1))))) + 11))));

        [NativeTypeName("#define RT_GROUP_ICON MAKEINTRESOURCE((ULONG_PTR)(RT_ICON) + DIFFERENCE)")]
        public static ushort* RT_GROUP_ICON => ((ushort*)((nuint)((ushort)((nuint)(((ushort*)((nuint)((ushort)(3))))) + 11))));

        [NativeTypeName("#define RT_VERSION MAKEINTRESOURCE(16)")]
        public static ushort* RT_VERSION => ((ushort*)((nuint)((ushort)(16))));

        [NativeTypeName("#define RT_DLGINCLUDE MAKEINTRESOURCE(17)")]
        public static ushort* RT_DLGINCLUDE => ((ushort*)((nuint)((ushort)(17))));

        [NativeTypeName("#define RT_PLUGPLAY MAKEINTRESOURCE(19)")]
        public static ushort* RT_PLUGPLAY => ((ushort*)((nuint)((ushort)(19))));

        [NativeTypeName("#define RT_VXD MAKEINTRESOURCE(20)")]
        public static ushort* RT_VXD => ((ushort*)((nuint)((ushort)(20))));

        [NativeTypeName("#define RT_ANICURSOR MAKEINTRESOURCE(21)")]
        public static ushort* RT_ANICURSOR => ((ushort*)((nuint)((ushort)(21))));

        [NativeTypeName("#define RT_ANIICON MAKEINTRESOURCE(22)")]
        public static ushort* RT_ANIICON => ((ushort*)((nuint)((ushort)(22))));

        [NativeTypeName("#define RT_HTML MAKEINTRESOURCE(23)")]
        public static ushort* RT_HTML => ((ushort*)((nuint)((ushort)(23))));

        [NativeTypeName("#define RT_MANIFEST MAKEINTRESOURCE(24)")]
        public static ushort* RT_MANIFEST => ((ushort*)((nuint)((ushort)(24))));

        [NativeTypeName("#define CREATEPROCESS_MANIFEST_RESOURCE_ID MAKEINTRESOURCE( 1)")]
        public static ushort* CREATEPROCESS_MANIFEST_RESOURCE_ID => ((ushort*)((nuint)((ushort)(1))));

        [NativeTypeName("#define ISOLATIONAWARE_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(2)")]
        public static ushort* ISOLATIONAWARE_MANIFEST_RESOURCE_ID => ((ushort*)((nuint)((ushort)(2))));

        [NativeTypeName("#define ISOLATIONAWARE_NOSTATICIMPORT_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(3)")]
        public static ushort* ISOLATIONAWARE_NOSTATICIMPORT_MANIFEST_RESOURCE_ID => ((ushort*)((nuint)((ushort)(3))));

        [NativeTypeName("#define ISOLATIONPOLICY_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(4)")]
        public static ushort* ISOLATIONPOLICY_MANIFEST_RESOURCE_ID => ((ushort*)((nuint)((ushort)(4))));

        [NativeTypeName("#define ISOLATIONPOLICY_BROWSER_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(5)")]
        public static ushort* ISOLATIONPOLICY_BROWSER_MANIFEST_RESOURCE_ID => ((ushort*)((nuint)((ushort)(5))));

        [NativeTypeName("#define MINIMUM_RESERVED_MANIFEST_RESOURCE_ID MAKEINTRESOURCE( 1 /*inclusive*/)")]
        public static ushort* MINIMUM_RESERVED_MANIFEST_RESOURCE_ID => ((ushort*)((nuint)((ushort)(1))));

        [NativeTypeName("#define MAXIMUM_RESERVED_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(16 /*inclusive*/)")]
        public static ushort* MAXIMUM_RESERVED_MANIFEST_RESOURCE_ID => ((ushort*)((nuint)((ushort)(16))));

        [NativeTypeName("#define wvsprintf wvsprintfW")]
        public static delegate*<ushort*, ushort*, sbyte*, int> wvsprintf => &wvsprintfW;

        [NativeTypeName("#define wsprintf wsprintfW")]
        public static delegate*<ushort*, ushort*, int> wsprintf => &wsprintfW;

        [NativeTypeName("#define SETWALLPAPER_DEFAULT ((LPWSTR)-1)")]
        public static ushort* SETWALLPAPER_DEFAULT => unchecked((ushort*)(-1));

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
        public static delegate*<ushort*, uint, HKL> LoadKeyboardLayout => &LoadKeyboardLayoutW;

        [NativeTypeName("#define GetKeyboardLayoutName GetKeyboardLayoutNameW")]
        public static delegate*<ushort*, BOOL> GetKeyboardLayoutName => &GetKeyboardLayoutNameW;

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
        public static delegate*<ushort*, ushort*, DEVMODEW*, uint, uint, SECURITY_ATTRIBUTES*, HDESK> CreateDesktop => &CreateDesktopW;

        [NativeTypeName("#define CreateDesktopEx CreateDesktopExW")]
        public static delegate*<ushort*, ushort*, DEVMODEW*, uint, uint, SECURITY_ATTRIBUTES*, uint, void*, HDESK> CreateDesktopEx => &CreateDesktopExW;

        [NativeTypeName("#define OpenDesktop OpenDesktopW")]
        public static delegate*<ushort*, uint, BOOL, uint, HDESK> OpenDesktop => &OpenDesktopW;

        [NativeTypeName("#define EnumDesktops EnumDesktopsW")]
        public static delegate*<HWINSTA, delegate* unmanaged<ushort*, LPARAM, BOOL>, LPARAM, BOOL> EnumDesktops => &EnumDesktopsW;

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
        public static delegate*<ushort*, uint, uint, SECURITY_ATTRIBUTES*, HWINSTA> CreateWindowStation => &CreateWindowStationW;

        [NativeTypeName("#define OpenWindowStation OpenWindowStationW")]
        public static delegate*<ushort*, BOOL, uint, HWINSTA> OpenWindowStation => &OpenWindowStationW;

        [NativeTypeName("#define EnumWindowStations EnumWindowStationsW")]
        public static delegate*<delegate* unmanaged<ushort*, LPARAM, BOOL>, LPARAM, BOOL> EnumWindowStations => &EnumWindowStationsW;

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
        public static delegate*<HANDLE, int, void*, uint, uint*, BOOL> GetUserObjectInformation => &GetUserObjectInformationW;

        [NativeTypeName("#define SetUserObjectInformation SetUserObjectInformationW")]
        public static delegate*<HANDLE, int, void*, uint, BOOL> SetUserObjectInformation => &SetUserObjectInformationW;

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

        [NativeTypeName("#define WA_INACTIVE 0")]
        public const int WA_INACTIVE = 0;

        [NativeTypeName("#define WA_ACTIVE 1")]
        public const int WA_ACTIVE = 1;

        [NativeTypeName("#define WA_CLICKACTIVE 2")]
        public const int WA_CLICKACTIVE = 2;

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

        [NativeTypeName("#define NFR_ANSI 1")]
        public const int NFR_ANSI = 1;

        [NativeTypeName("#define NFR_UNICODE 2")]
        public const int NFR_UNICODE = 2;

        [NativeTypeName("#define NF_QUERY 3")]
        public const int NF_QUERY = 3;

        [NativeTypeName("#define NF_REQUERY 4")]
        public const int NF_REQUERY = 4;

        [NativeTypeName("#define UNICODE_NOCHAR 0xFFFF")]
        public const int UNICODE_NOCHAR = 0xFFFF;

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

        [NativeTypeName("#define MN_GETHMENU 0x01E1")]
        public const int MN_GETHMENU = 0x01E1;

        [NativeTypeName("#define WHEEL_DELTA 120")]
        public const int WHEEL_DELTA = 120;

        [NativeTypeName("#define WHEEL_PAGESCROLL (UINT_MAX)")]
        public const uint WHEEL_PAGESCROLL = (0xffffffff);

        [NativeTypeName("#define XBUTTON1 0x0001")]
        public const int XBUTTON1 = 0x0001;

        [NativeTypeName("#define XBUTTON2 0x0002")]
        public const int XBUTTON2 = 0x0002;

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

        [NativeTypeName("#define DM_POINTERHITTEST 0x0250")]
        public const int DM_POINTERHITTEST = 0x0250;

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
        public static delegate*<ushort*, uint> RegisterWindowMessage => &RegisterWindowMessageW;

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
        public static delegate*<MSG*, HWND, uint, uint, BOOL> GetMessage => &GetMessageW;

        [NativeTypeName("#define DispatchMessage DispatchMessageW")]
        public static delegate*<MSG*, LRESULT> DispatchMessage => &DispatchMessageW;

        [NativeTypeName("#define PeekMessage PeekMessageW")]
        public static delegate*<MSG*, HWND, uint, uint, uint, BOOL> PeekMessage => &PeekMessageW;

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

        [NativeTypeName("#define EWX_CHECK_SAFE_FOR_SERVER 0x08000000")]
        public const int EWX_CHECK_SAFE_FOR_SERVER = 0x08000000;

        [NativeTypeName("#define SendMessage SendMessageW")]
        public static delegate*<HWND, uint, WPARAM, LPARAM, LRESULT> SendMessage => &SendMessageW;

        [NativeTypeName("#define SendMessageTimeout SendMessageTimeoutW")]
        public static delegate*<HWND, uint, WPARAM, LPARAM, uint, uint, nuint*, LRESULT> SendMessageTimeout => &SendMessageTimeoutW;

        [NativeTypeName("#define SendNotifyMessage SendNotifyMessageW")]
        public static delegate*<HWND, uint, WPARAM, LPARAM, BOOL> SendNotifyMessage => &SendNotifyMessageW;

        [NativeTypeName("#define SendMessageCallback SendMessageCallbackW")]
        public static delegate*<HWND, uint, WPARAM, LPARAM, delegate* unmanaged<HWND, uint, nuint, LRESULT, void>, nuint, BOOL> SendMessageCallback => &SendMessageCallbackW;

        [NativeTypeName("#define BroadcastSystemMessageEx BroadcastSystemMessageExW")]
        public static delegate*<uint, uint*, uint, WPARAM, LPARAM, BSMINFO*, int> BroadcastSystemMessageEx => &BroadcastSystemMessageExW;

        [NativeTypeName("#define BroadcastSystemMessage BroadcastSystemMessageW")]
        public static delegate*<uint, uint*, uint, WPARAM, LPARAM, int> BroadcastSystemMessage => &BroadcastSystemMessageW;

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
        public static delegate*<HANDLE, void*, uint, HDEVNOTIFY> RegisterDeviceNotification => &RegisterDeviceNotificationW;

        [NativeTypeName("#define PostMessage PostMessageW")]
        public static delegate*<HWND, uint, WPARAM, LPARAM, BOOL> PostMessage => &PostMessageW;

        [NativeTypeName("#define PostThreadMessage PostThreadMessageW")]
        public static delegate*<uint, uint, WPARAM, LPARAM, BOOL> PostThreadMessage => &PostThreadMessageW;

        [NativeTypeName("#define DefWindowProc DefWindowProcW")]
        public static delegate*<HWND, uint, WPARAM, LPARAM, LRESULT> DefWindowProc => &DefWindowProcW;

        [NativeTypeName("#define CallWindowProc CallWindowProcW")]
        public static delegate*<delegate* unmanaged<HWND, uint, WPARAM, LPARAM, LRESULT>, HWND, uint, WPARAM, LPARAM, LRESULT> CallWindowProc => &CallWindowProcW;

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
        public static delegate*<WNDCLASSW*, ushort> RegisterClass => &RegisterClassW;

        [NativeTypeName("#define UnregisterClass UnregisterClassW")]
        public static delegate*<ushort*, HINSTANCE, BOOL> UnregisterClass => &UnregisterClassW;

        [NativeTypeName("#define GetClassInfo GetClassInfoW")]
        public static delegate*<HINSTANCE, ushort*, WNDCLASSW*, BOOL> GetClassInfo => &GetClassInfoW;

        [NativeTypeName("#define RegisterClassEx RegisterClassExW")]
        public static delegate*<WNDCLASSEXW*, ushort> RegisterClassEx => &RegisterClassExW;

        [NativeTypeName("#define GetClassInfoEx GetClassInfoExW")]
        public static delegate*<HINSTANCE, ushort*, WNDCLASSEXW*, BOOL> GetClassInfoEx => &GetClassInfoExW;

        [NativeTypeName("#define CW_USEDEFAULT ((int)0x80000000)")]
        public const int CW_USEDEFAULT = unchecked((int)(0x80000000));

        [NativeTypeName("#define CreateWindowEx CreateWindowExW")]
        public static delegate*<uint, ushort*, ushort*, uint, int, int, int, int, HWND, HMENU, HINSTANCE, void*, HWND> CreateWindowEx => &CreateWindowExW;

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

        [NativeTypeName("#define CreateDialogParam CreateDialogParamW")]
        public static delegate*<HINSTANCE, ushort*, HWND, delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint>, LPARAM, HWND> CreateDialogParam => &CreateDialogParamW;

        [NativeTypeName("#define CreateDialogIndirectParam CreateDialogIndirectParamW")]
        public static delegate*<HINSTANCE, DLGTEMPLATE*, HWND, delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint>, LPARAM, HWND> CreateDialogIndirectParam => &CreateDialogIndirectParamW;

        [NativeTypeName("#define DialogBoxParam DialogBoxParamW")]
        public static delegate*<HINSTANCE, ushort*, HWND, delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint>, LPARAM, nint> DialogBoxParam => &DialogBoxParamW;

        [NativeTypeName("#define DialogBoxIndirectParam DialogBoxIndirectParamW")]
        public static delegate*<HINSTANCE, DLGTEMPLATE*, HWND, delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint>, LPARAM, nint> DialogBoxIndirectParam => &DialogBoxIndirectParamW;

        [NativeTypeName("#define SetDlgItemText SetDlgItemTextW")]
        public static delegate*<HWND, int, ushort*, BOOL> SetDlgItemText => &SetDlgItemTextW;

        [NativeTypeName("#define GetDlgItemText GetDlgItemTextW")]
        public static delegate*<HWND, int, ushort*, int, uint> GetDlgItemText => &GetDlgItemTextW;

        [NativeTypeName("#define SendDlgItemMessage SendDlgItemMessageW")]
        public static delegate*<HWND, int, uint, WPARAM, LPARAM, LRESULT> SendDlgItemMessage => &SendDlgItemMessageW;

        [NativeTypeName("#define DefDlgProc DefDlgProcW")]
        public static delegate*<HWND, uint, WPARAM, LPARAM, LRESULT> DefDlgProc => &DefDlgProcW;

        [NativeTypeName("#define DLGWINDOWEXTRA 30")]
        public const int DLGWINDOWEXTRA = 30;

        [NativeTypeName("#define CallMsgFilter CallMsgFilterW")]
        public static delegate*<MSG*, int, BOOL> CallMsgFilter => &CallMsgFilterW;

        [NativeTypeName("#define RegisterClipboardFormat RegisterClipboardFormatW")]
        public static delegate*<ushort*, uint> RegisterClipboardFormat => &RegisterClipboardFormatW;

        [NativeTypeName("#define GetClipboardFormatName GetClipboardFormatNameW")]
        public static delegate*<uint, ushort*, int, int> GetClipboardFormatName => &GetClipboardFormatNameW;

        [NativeTypeName("#define CharToOem CharToOemW")]
        public static delegate*<ushort*, sbyte*, BOOL> CharToOem => &CharToOemW;

        [NativeTypeName("#define OemToChar OemToCharW")]
        public static delegate*<sbyte*, ushort*, BOOL> OemToChar => &OemToCharW;

        [NativeTypeName("#define CharToOemBuff CharToOemBuffW")]
        public static delegate*<ushort*, sbyte*, uint, BOOL> CharToOemBuff => &CharToOemBuffW;

        [NativeTypeName("#define OemToCharBuff OemToCharBuffW")]
        public static delegate*<sbyte*, ushort*, uint, BOOL> OemToCharBuff => &OemToCharBuffW;

        [NativeTypeName("#define CharUpper CharUpperW")]
        public static delegate*<ushort*, ushort*> CharUpper => &CharUpperW;

        [NativeTypeName("#define CharUpperBuff CharUpperBuffW")]
        public static delegate*<ushort*, uint, uint> CharUpperBuff => &CharUpperBuffW;

        [NativeTypeName("#define CharLower CharLowerW")]
        public static delegate*<ushort*, ushort*> CharLower => &CharLowerW;

        [NativeTypeName("#define CharLowerBuff CharLowerBuffW")]
        public static delegate*<ushort*, uint, uint> CharLowerBuff => &CharLowerBuffW;

        [NativeTypeName("#define CharNext CharNextW")]
        public static delegate*<ushort*, ushort*> CharNext => &CharNextW;

        [NativeTypeName("#define CharPrev CharPrevW")]
        public static delegate*<ushort*, ushort*, ushort*> CharPrev => &CharPrevW;

        [NativeTypeName("#define AnsiToOem CharToOemA")]
        public static delegate*<sbyte*, sbyte*, BOOL> AnsiToOem => &CharToOemA;

        [NativeTypeName("#define OemToAnsi OemToCharA")]
        public static delegate*<sbyte*, sbyte*, BOOL> OemToAnsi => &OemToCharA;

        [NativeTypeName("#define AnsiToOemBuff CharToOemBuffA")]
        public static delegate*<sbyte*, sbyte*, uint, BOOL> AnsiToOemBuff => &CharToOemBuffA;

        [NativeTypeName("#define OemToAnsiBuff OemToCharBuffA")]
        public static delegate*<sbyte*, sbyte*, uint, BOOL> OemToAnsiBuff => &OemToCharBuffA;

        [NativeTypeName("#define AnsiUpper CharUpperA")]
        public static delegate*<sbyte*, sbyte*> AnsiUpper => &CharUpperA;

        [NativeTypeName("#define AnsiUpperBuff CharUpperBuffA")]
        public static delegate*<sbyte*, uint, uint> AnsiUpperBuff => &CharUpperBuffA;

        [NativeTypeName("#define AnsiLower CharLowerA")]
        public static delegate*<sbyte*, sbyte*> AnsiLower => &CharLowerA;

        [NativeTypeName("#define AnsiLowerBuff CharLowerBuffA")]
        public static delegate*<sbyte*, uint, uint> AnsiLowerBuff => &CharLowerBuffA;

        [NativeTypeName("#define AnsiNext CharNextA")]
        public static delegate*<sbyte*, sbyte*> AnsiNext => &CharNextA;

        [NativeTypeName("#define AnsiPrev CharPrevA")]
        public static delegate*<sbyte*, sbyte*, sbyte*> AnsiPrev => &CharPrevA;

        [NativeTypeName("#define IsCharAlpha IsCharAlphaW")]
        public static delegate*<ushort, BOOL> IsCharAlpha => &IsCharAlphaW;

        [NativeTypeName("#define IsCharAlphaNumeric IsCharAlphaNumericW")]
        public static delegate*<ushort, BOOL> IsCharAlphaNumeric => &IsCharAlphaNumericW;

        [NativeTypeName("#define IsCharUpper IsCharUpperW")]
        public static delegate*<ushort, BOOL> IsCharUpper => &IsCharUpperW;

        [NativeTypeName("#define IsCharLower IsCharLowerW")]
        public static delegate*<ushort, BOOL> IsCharLower => &IsCharLowerW;

        [NativeTypeName("#define GetKeyNameText GetKeyNameTextW")]
        public static delegate*<int, ushort*, int, int> GetKeyNameText => &GetKeyNameTextW;

        [NativeTypeName("#define VkKeyScan VkKeyScanW")]
        public static delegate*<ushort, short> VkKeyScan => &VkKeyScanW;

        [NativeTypeName("#define VkKeyScanEx VkKeyScanExW")]
        public static delegate*<ushort, HKL, short> VkKeyScanEx => &VkKeyScanExW;

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
        public static delegate*<uint, uint, uint> MapVirtualKey => &MapVirtualKeyW;

        [NativeTypeName("#define MapVirtualKeyEx MapVirtualKeyExW")]
        public static delegate*<uint, uint, HKL, uint> MapVirtualKeyEx => &MapVirtualKeyExW;

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
        public static delegate*<HINSTANCE, ushort*, HACCEL> LoadAccelerators => &LoadAcceleratorsW;

        [NativeTypeName("#define CreateAcceleratorTable CreateAcceleratorTableW")]
        public static delegate*<ACCEL*, int, HACCEL> CreateAcceleratorTable => &CreateAcceleratorTableW;

        [NativeTypeName("#define CopyAcceleratorTable CopyAcceleratorTableW")]
        public static delegate*<HACCEL, ACCEL*, int, int> CopyAcceleratorTable => &CopyAcceleratorTableW;

        [NativeTypeName("#define TranslateAccelerator TranslateAcceleratorW")]
        public static delegate*<HWND, HACCEL, MSG*, int> TranslateAccelerator => &TranslateAcceleratorW;

        [NativeTypeName("#define LoadMenu LoadMenuW")]
        public static delegate*<HINSTANCE, ushort*, HMENU> LoadMenu => &LoadMenuW;

        [NativeTypeName("#define LoadMenuIndirect LoadMenuIndirectW")]
        public static delegate*<void*, HMENU> LoadMenuIndirect => &LoadMenuIndirectW;

        [NativeTypeName("#define ChangeMenu ChangeMenuW")]
        public static delegate*<HMENU, uint, ushort*, uint, uint, BOOL> ChangeMenu => &ChangeMenuW;

        [NativeTypeName("#define GetMenuString GetMenuStringW")]
        public static delegate*<HMENU, uint, ushort*, int, uint, int> GetMenuString => &GetMenuStringW;

        [NativeTypeName("#define PMB_ACTIVE 0x00000001")]
        public const int PMB_ACTIVE = 0x00000001;

        [NativeTypeName("#define InsertMenu InsertMenuW")]
        public static delegate*<HMENU, uint, uint, nuint, ushort*, BOOL> InsertMenu => &InsertMenuW;

        [NativeTypeName("#define AppendMenu AppendMenuW")]
        public static delegate*<HMENU, uint, nuint, ushort*, BOOL> AppendMenu => &AppendMenuW;

        [NativeTypeName("#define ModifyMenu ModifyMenuW")]
        public static delegate*<HMENU, uint, uint, nuint, ushort*, BOOL> ModifyMenu => &ModifyMenuW;

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

        [NativeTypeName("#define InsertMenuItem InsertMenuItemW")]
        public static delegate*<HMENU, uint, BOOL, MENUITEMINFOW*, BOOL> InsertMenuItem => &InsertMenuItemW;

        [NativeTypeName("#define GetMenuItemInfo GetMenuItemInfoW")]
        public static delegate*<HMENU, uint, BOOL, MENUITEMINFOW*, BOOL> GetMenuItemInfo => &GetMenuItemInfoW;

        [NativeTypeName("#define SetMenuItemInfo SetMenuItemInfoW")]
        public static delegate*<HMENU, uint, BOOL, MENUITEMINFOW*, BOOL> SetMenuItemInfo => &SetMenuItemInfoW;

        [NativeTypeName("#define GMDI_USEDISABLED 0x0001L")]
        public const int GMDI_USEDISABLED = 0x0001;

        [NativeTypeName("#define GMDI_GOINTOPOPUPS 0x0002L")]
        public const int GMDI_GOINTOPOPUPS = 0x0002;

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
        public static delegate*<HDC, ushort*, int, RECT*, uint, int> DrawText => &DrawTextW;

        [NativeTypeName("#define DrawTextEx DrawTextExW")]
        public static delegate*<HDC, ushort*, int, RECT*, uint, DRAWTEXTPARAMS*, int> DrawTextEx => &DrawTextExW;

        [NativeTypeName("#define GrayString GrayStringW")]
        public static delegate*<HDC, HBRUSH, delegate* unmanaged<HDC, LPARAM, int, BOOL>, LPARAM, int, int, int, int, int, BOOL> GrayString => &GrayStringW;

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
        public static delegate*<HDC, HBRUSH, delegate* unmanaged<HDC, LPARAM, WPARAM, int, int, BOOL>, LPARAM, WPARAM, int, int, int, int, uint, BOOL> DrawState => &DrawStateW;

        [NativeTypeName("#define TabbedTextOut TabbedTextOutW")]
        public static delegate*<HDC, int, int, ushort*, int, int, int*, int, int> TabbedTextOut => &TabbedTextOutW;

        [NativeTypeName("#define GetTabbedTextExtent GetTabbedTextExtentW")]
        public static delegate*<HDC, ushort*, int, int, int*, uint> GetTabbedTextExtent => &GetTabbedTextExtentW;

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
        public static delegate*<HWND, ushort*, HANDLE, BOOL> SetProp => &SetPropW;

        [NativeTypeName("#define GetProp GetPropW")]
        public static delegate*<HWND, ushort*, HANDLE> GetProp => &GetPropW;

        [NativeTypeName("#define RemoveProp RemovePropW")]
        public static delegate*<HWND, ushort*, HANDLE> RemoveProp => &RemovePropW;

        [NativeTypeName("#define EnumPropsEx EnumPropsExW")]
        public static delegate*<HWND, delegate* unmanaged<HWND, ushort*, HANDLE, nuint, BOOL>, LPARAM, int> EnumPropsEx => &EnumPropsExW;

        [NativeTypeName("#define EnumProps EnumPropsW")]
        public static delegate*<HWND, delegate* unmanaged<HWND, ushort*, HANDLE, BOOL>, int> EnumProps => &EnumPropsW;

        [NativeTypeName("#define SetWindowText SetWindowTextW")]
        public static delegate*<HWND, ushort*, BOOL> SetWindowText => &SetWindowTextW;

        [NativeTypeName("#define GetWindowText GetWindowTextW")]
        public static delegate*<HWND, ushort*, int, int> GetWindowText => &GetWindowTextW;

        [NativeTypeName("#define GetWindowTextLength GetWindowTextLengthW")]
        public static delegate*<HWND, int> GetWindowTextLength => &GetWindowTextLengthW;

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
        public static delegate*<HWND, ushort*, ushort*, uint, int> MessageBox => &MessageBoxW;

        [NativeTypeName("#define MessageBoxEx MessageBoxExW")]
        public static delegate*<HWND, ushort*, ushort*, uint, ushort, int> MessageBoxEx => &MessageBoxExW;

        [NativeTypeName("#define MessageBoxIndirect MessageBoxIndirectW")]
        public static delegate*<MSGBOXPARAMSW*, int> MessageBoxIndirect => &MessageBoxIndirectW;

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
        public static delegate*<HWND, int, int> GetWindowLong => &GetWindowLongW;

        [NativeTypeName("#define SetWindowLong SetWindowLongW")]
        public static delegate*<HWND, int, int, int> SetWindowLong => &SetWindowLongW;

        [NativeTypeName("#define GetClassLong GetClassLongW")]
        public static delegate*<HWND, int, uint> GetClassLong => &GetClassLongW;

        [NativeTypeName("#define SetClassLong SetClassLongW")]
        public static delegate*<HWND, int, int, uint> SetClassLong => &SetClassLongW;

        [NativeTypeName("#define FindWindow FindWindowW")]
        public static delegate*<ushort*, ushort*, HWND> FindWindow => &FindWindowW;

        [NativeTypeName("#define FindWindowEx FindWindowExW")]
        public static delegate*<HWND, HWND, ushort*, ushort*, HWND> FindWindowEx => &FindWindowExW;

        [NativeTypeName("#define GetClassName GetClassNameW")]
        public static delegate*<HWND, ushort*, int, int> GetClassName => &GetClassNameW;

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
        public static delegate*<int, delegate* unmanaged<int, WPARAM, LPARAM, LRESULT>, HHOOK> SetWindowsHook => &SetWindowsHookW;

        [NativeTypeName("#define SetWindowsHookEx SetWindowsHookExW")]
        public static delegate*<int, delegate* unmanaged<int, WPARAM, LPARAM, LRESULT>, HINSTANCE, uint, HHOOK> SetWindowsHookEx => &SetWindowsHookExW;

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
        public static delegate*<HINSTANCE, ushort*, HBITMAP> LoadBitmap => &LoadBitmapW;

        [NativeTypeName("#define LoadCursor LoadCursorW")]
        public static delegate*<HINSTANCE, ushort*, HCURSOR> LoadCursor => &LoadCursorW;

        [NativeTypeName("#define LoadCursorFromFile LoadCursorFromFileW")]
        public static delegate*<ushort*, HCURSOR> LoadCursorFromFile => &LoadCursorFromFileW;

        [NativeTypeName("#define IDC_ARROW MAKEINTRESOURCE(32512)")]
        public static ushort* IDC_ARROW => ((ushort*)((nuint)((ushort)(32512))));

        [NativeTypeName("#define IDC_IBEAM MAKEINTRESOURCE(32513)")]
        public static ushort* IDC_IBEAM => ((ushort*)((nuint)((ushort)(32513))));

        [NativeTypeName("#define IDC_WAIT MAKEINTRESOURCE(32514)")]
        public static ushort* IDC_WAIT => ((ushort*)((nuint)((ushort)(32514))));

        [NativeTypeName("#define IDC_CROSS MAKEINTRESOURCE(32515)")]
        public static ushort* IDC_CROSS => ((ushort*)((nuint)((ushort)(32515))));

        [NativeTypeName("#define IDC_UPARROW MAKEINTRESOURCE(32516)")]
        public static ushort* IDC_UPARROW => ((ushort*)((nuint)((ushort)(32516))));

        [NativeTypeName("#define IDC_SIZE MAKEINTRESOURCE(32640)")]
        public static ushort* IDC_SIZE => ((ushort*)((nuint)((ushort)(32640))));

        [NativeTypeName("#define IDC_ICON MAKEINTRESOURCE(32641)")]
        public static ushort* IDC_ICON => ((ushort*)((nuint)((ushort)(32641))));

        [NativeTypeName("#define IDC_SIZENWSE MAKEINTRESOURCE(32642)")]
        public static ushort* IDC_SIZENWSE => ((ushort*)((nuint)((ushort)(32642))));

        [NativeTypeName("#define IDC_SIZENESW MAKEINTRESOURCE(32643)")]
        public static ushort* IDC_SIZENESW => ((ushort*)((nuint)((ushort)(32643))));

        [NativeTypeName("#define IDC_SIZEWE MAKEINTRESOURCE(32644)")]
        public static ushort* IDC_SIZEWE => ((ushort*)((nuint)((ushort)(32644))));

        [NativeTypeName("#define IDC_SIZENS MAKEINTRESOURCE(32645)")]
        public static ushort* IDC_SIZENS => ((ushort*)((nuint)((ushort)(32645))));

        [NativeTypeName("#define IDC_SIZEALL MAKEINTRESOURCE(32646)")]
        public static ushort* IDC_SIZEALL => ((ushort*)((nuint)((ushort)(32646))));

        [NativeTypeName("#define IDC_NO MAKEINTRESOURCE(32648)")]
        public static ushort* IDC_NO => ((ushort*)((nuint)((ushort)(32648))));

        [NativeTypeName("#define IDC_HAND MAKEINTRESOURCE(32649)")]
        public static ushort* IDC_HAND => ((ushort*)((nuint)((ushort)(32649))));

        [NativeTypeName("#define IDC_APPSTARTING MAKEINTRESOURCE(32650)")]
        public static ushort* IDC_APPSTARTING => ((ushort*)((nuint)((ushort)(32650))));

        [NativeTypeName("#define IDC_HELP MAKEINTRESOURCE(32651)")]
        public static ushort* IDC_HELP => ((ushort*)((nuint)((ushort)(32651))));

        [NativeTypeName("#define IDC_PIN MAKEINTRESOURCE(32671)")]
        public static ushort* IDC_PIN => ((ushort*)((nuint)((ushort)(32671))));

        [NativeTypeName("#define IDC_PERSON MAKEINTRESOURCE(32672)")]
        public static ushort* IDC_PERSON => ((ushort*)((nuint)((ushort)(32672))));

        [NativeTypeName("#define LoadIcon LoadIconW")]
        public static delegate*<HINSTANCE, ushort*, HICON> LoadIcon => &LoadIconW;

        [NativeTypeName("#define PrivateExtractIcons PrivateExtractIconsW")]
        public static delegate*<ushort*, int, int, int, HICON*, uint*, uint, uint, uint> PrivateExtractIcons => &PrivateExtractIconsW;

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
        public static delegate*<HINSTANCE, ushort*, uint, int, int, uint, HANDLE> LoadImage => &LoadImageW;

        [NativeTypeName("#define GetIconInfoEx GetIconInfoExW")]
        public static delegate*<HICON, ICONINFOEXW*, BOOL> GetIconInfoEx => &GetIconInfoExW;

        [NativeTypeName("#define RES_ICON 1")]
        public const int RES_ICON = 1;

        [NativeTypeName("#define RES_CURSOR 2")]
        public const int RES_CURSOR = 2;

        [NativeTypeName("#define ORD_LANGDRIVER 1")]
        public const int ORD_LANGDRIVER = 1;

        [NativeTypeName("#define IDI_APPLICATION MAKEINTRESOURCE(32512)")]
        public static ushort* IDI_APPLICATION => ((ushort*)((nuint)((ushort)(32512))));

        [NativeTypeName("#define IDI_HAND MAKEINTRESOURCE(32513)")]
        public static ushort* IDI_HAND => ((ushort*)((nuint)((ushort)(32513))));

        [NativeTypeName("#define IDI_QUESTION MAKEINTRESOURCE(32514)")]
        public static ushort* IDI_QUESTION => ((ushort*)((nuint)((ushort)(32514))));

        [NativeTypeName("#define IDI_EXCLAMATION MAKEINTRESOURCE(32515)")]
        public static ushort* IDI_EXCLAMATION => ((ushort*)((nuint)((ushort)(32515))));

        [NativeTypeName("#define IDI_ASTERISK MAKEINTRESOURCE(32516)")]
        public static ushort* IDI_ASTERISK => ((ushort*)((nuint)((ushort)(32516))));

        [NativeTypeName("#define IDI_WINLOGO MAKEINTRESOURCE(32517)")]
        public static ushort* IDI_WINLOGO => ((ushort*)((nuint)((ushort)(32517))));

        [NativeTypeName("#define IDI_SHIELD MAKEINTRESOURCE(32518)")]
        public static ushort* IDI_SHIELD => ((ushort*)((nuint)((ushort)(32518))));

        [NativeTypeName("#define IDI_WARNING IDI_EXCLAMATION")]
        public static ushort* IDI_WARNING => ((ushort*)((nuint)((ushort)(32515))));

        [NativeTypeName("#define IDI_ERROR IDI_HAND")]
        public static ushort* IDI_ERROR => ((ushort*)((nuint)((ushort)(32513))));

        [NativeTypeName("#define IDI_INFORMATION IDI_ASTERISK")]
        public static ushort* IDI_INFORMATION => ((ushort*)((nuint)((ushort)(32516))));

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
        public static ushort* WC_DIALOG => ((ushort*)((nuint)((ushort)(0x8002))));

        [NativeTypeName("#define DWL_MSGRESULT 0")]
        public const int DWL_MSGRESULT = 0;

        [NativeTypeName("#define DWL_DLGPROC 4")]
        public const int DWL_DLGPROC = 4;

        [NativeTypeName("#define DWL_USER 8")]
        public const int DWL_USER = 8;

        [NativeTypeName("#define DWLP_MSGRESULT 0")]
        public const int DWLP_MSGRESULT = 0;

        [NativeTypeName("#define DWLP_DLGPROC DWLP_MSGRESULT + sizeof(LRESULT)")]
        public static uint DWLP_DLGPROC => unchecked(0 + (uint)(sizeof(LRESULT)));

        [NativeTypeName("#define DWLP_USER DWLP_DLGPROC + sizeof(DLGPROC)")]
        public static uint DWLP_USER => unchecked(0 + (uint)(sizeof(LRESULT)) + (uint)(sizeof(delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint>)));

        [NativeTypeName("#define IsDialogMessage IsDialogMessageW")]
        public static delegate*<HWND, MSG*, BOOL> IsDialogMessage => &IsDialogMessageW;

        [NativeTypeName("#define DlgDirList DlgDirListW")]
        public static delegate*<HWND, ushort*, int, int, uint, int> DlgDirList => &DlgDirListW;

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
        public static delegate*<HWND, ushort*, int, int, BOOL> DlgDirSelectEx => &DlgDirSelectExW;

        [NativeTypeName("#define DlgDirListComboBox DlgDirListComboBoxW")]
        public static delegate*<HWND, ushort*, int, int, uint, int> DlgDirListComboBox => &DlgDirListComboBoxW;

        [NativeTypeName("#define DlgDirSelectComboBoxEx DlgDirSelectComboBoxExW")]
        public static delegate*<HWND, ushort*, int, int, BOOL> DlgDirSelectComboBoxEx => &DlgDirSelectComboBoxExW;

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
        public static delegate*<HWND, HWND, uint, WPARAM, LPARAM, LRESULT> DefFrameProc => &DefFrameProcW;

        [NativeTypeName("#define DefMDIChildProc DefMDIChildProcW")]
        public static delegate*<HWND, uint, WPARAM, LPARAM, LRESULT> DefMDIChildProc => &DefMDIChildProcW;

        [NativeTypeName("#define CreateMDIWindow CreateMDIWindowW")]
        public static delegate*<ushort*, ushort*, uint, int, int, int, int, HWND, HINSTANCE, LPARAM, HWND> CreateMDIWindow => &CreateMDIWindowW;

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
        public static delegate*<HWND, ushort*, uint, nuint, BOOL> WinHelp => &WinHelpW;

        [NativeTypeName("#define GR_GDIOBJECTS 0")]
        public const int GR_GDIOBJECTS = 0;

        [NativeTypeName("#define GR_USEROBJECTS 1")]
        public const int GR_USEROBJECTS = 1;

        [NativeTypeName("#define GR_GDIOBJECTS_PEAK 2")]
        public const int GR_GDIOBJECTS_PEAK = 2;

        [NativeTypeName("#define GR_USEROBJECTS_PEAK 4")]
        public const int GR_USEROBJECTS_PEAK = 4;

        [NativeTypeName("#define TOUCHPREDICTIONPARAMETERS_DEFAULT_LATENCY 8")]
        public const int TOUCHPREDICTIONPARAMETERS_DEFAULT_LATENCY = 8;

        [NativeTypeName("#define TOUCHPREDICTIONPARAMETERS_DEFAULT_SAMPLETIME 8")]
        public const int TOUCHPREDICTIONPARAMETERS_DEFAULT_SAMPLETIME = 8;

        [NativeTypeName("#define TOUCHPREDICTIONPARAMETERS_DEFAULT_USE_HW_TIMESTAMP 1")]
        public const int TOUCHPREDICTIONPARAMETERS_DEFAULT_USE_HW_TIMESTAMP = 1;

        [NativeTypeName("#define TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_DELTA 0.001f")]
        public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_DELTA = 0.001f;

        [NativeTypeName("#define TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_MIN 0.9f")]
        public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_MIN = 0.9f;

        [NativeTypeName("#define TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_MAX 0.999f")]
        public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_MAX = 0.999f;

        [NativeTypeName("#define TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_LEARNING_RATE 0.001f")]
        public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_LEARNING_RATE = 0.001f;

        [NativeTypeName("#define TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_EXPO_SMOOTH_ALPHA 0.99f")]
        public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_EXPO_SMOOTH_ALPHA = 0.99f;

        [NativeTypeName("#define MIN_LOGICALDPIOVERRIDE -2")]
        public const int MIN_LOGICALDPIOVERRIDE = -2;

        [NativeTypeName("#define FE_FONTSMOOTHINGSTANDARD 0x0001")]
        public const int FE_FONTSMOOTHINGSTANDARD = 0x0001;

        [NativeTypeName("#define FE_FONTSMOOTHINGCLEARTYPE 0x0002")]
        public const int FE_FONTSMOOTHINGCLEARTYPE = 0x0002;

        [NativeTypeName("#define FE_FONTSMOOTHINGORIENTATIONBGR 0x0000")]
        public const int FE_FONTSMOOTHINGORIENTATIONBGR = 0x0000;

        [NativeTypeName("#define FE_FONTSMOOTHINGORIENTATIONRGB 0x0001")]
        public const int FE_FONTSMOOTHINGORIENTATIONRGB = 0x0001;

        [NativeTypeName("#define CONTACTVISUALIZATION_OFF 0x0000")]
        public const int CONTACTVISUALIZATION_OFF = 0x0000;

        [NativeTypeName("#define CONTACTVISUALIZATION_ON 0x0001")]
        public const int CONTACTVISUALIZATION_ON = 0x0001;

        [NativeTypeName("#define CONTACTVISUALIZATION_PRESENTATIONMODE 0x0002")]
        public const int CONTACTVISUALIZATION_PRESENTATIONMODE = 0x0002;

        [NativeTypeName("#define GESTUREVISUALIZATION_OFF 0x0000")]
        public const int GESTUREVISUALIZATION_OFF = 0x0000;

        [NativeTypeName("#define GESTUREVISUALIZATION_ON 0x001F")]
        public const int GESTUREVISUALIZATION_ON = 0x001F;

        [NativeTypeName("#define GESTUREVISUALIZATION_TAP 0x0001")]
        public const int GESTUREVISUALIZATION_TAP = 0x0001;

        [NativeTypeName("#define GESTUREVISUALIZATION_DOUBLETAP 0x0002")]
        public const int GESTUREVISUALIZATION_DOUBLETAP = 0x0002;

        [NativeTypeName("#define GESTUREVISUALIZATION_PRESSANDTAP 0x0004")]
        public const int GESTUREVISUALIZATION_PRESSANDTAP = 0x0004;

        [NativeTypeName("#define GESTUREVISUALIZATION_PRESSANDHOLD 0x0008")]
        public const int GESTUREVISUALIZATION_PRESSANDHOLD = 0x0008;

        [NativeTypeName("#define GESTUREVISUALIZATION_RIGHTTAP 0x0010")]
        public const int GESTUREVISUALIZATION_RIGHTTAP = 0x0010;

        [NativeTypeName("#define MOUSEWHEEL_ROUTING_FOCUS 0")]
        public const int MOUSEWHEEL_ROUTING_FOCUS = 0;

        [NativeTypeName("#define MOUSEWHEEL_ROUTING_HYBRID 1")]
        public const int MOUSEWHEEL_ROUTING_HYBRID = 1;

        [NativeTypeName("#define MOUSEWHEEL_ROUTING_MOUSE_POS 2")]
        public const int MOUSEWHEEL_ROUTING_MOUSE_POS = 2;

        [NativeTypeName("#define PENVISUALIZATION_ON 0x0023")]
        public const int PENVISUALIZATION_ON = 0x0023;

        [NativeTypeName("#define PENVISUALIZATION_OFF 0x0000")]
        public const int PENVISUALIZATION_OFF = 0x0000;

        [NativeTypeName("#define PENVISUALIZATION_TAP 0x0001")]
        public const int PENVISUALIZATION_TAP = 0x0001;

        [NativeTypeName("#define PENVISUALIZATION_DOUBLETAP 0x0002")]
        public const int PENVISUALIZATION_DOUBLETAP = 0x0002;

        [NativeTypeName("#define PENVISUALIZATION_CURSOR 0x0020")]
        public const int PENVISUALIZATION_CURSOR = 0x0020;

        [NativeTypeName("#define PENARBITRATIONTYPE_NONE 0x0000")]
        public const int PENARBITRATIONTYPE_NONE = 0x0000;

        [NativeTypeName("#define PENARBITRATIONTYPE_WIN8 0x0001")]
        public const int PENARBITRATIONTYPE_WIN8 = 0x0001;

        [NativeTypeName("#define PENARBITRATIONTYPE_FIS 0x0002")]
        public const int PENARBITRATIONTYPE_FIS = 0x0002;

        [NativeTypeName("#define PENARBITRATIONTYPE_SPT 0x0003")]
        public const int PENARBITRATIONTYPE_SPT = 0x0003;

        [NativeTypeName("#define PENARBITRATIONTYPE_MAX 0x0004")]
        public const int PENARBITRATIONTYPE_MAX = 0x0004;

        [NativeTypeName("#define SPIF_UPDATEINIFILE 0x0001")]
        public const int SPIF_UPDATEINIFILE = 0x0001;

        [NativeTypeName("#define SPIF_SENDWININICHANGE 0x0002")]
        public const int SPIF_SENDWININICHANGE = 0x0002;

        [NativeTypeName("#define SPIF_SENDCHANGE SPIF_SENDWININICHANGE")]
        public const int SPIF_SENDCHANGE = 0x0002;

        [NativeTypeName("#define METRICS_USEDEFAULT -1")]
        public const int METRICS_USEDEFAULT = -1;

        [NativeTypeName("#define ARW_BOTTOMLEFT 0x0000L")]
        public const int ARW_BOTTOMLEFT = 0x0000;

        [NativeTypeName("#define ARW_BOTTOMRIGHT 0x0001L")]
        public const int ARW_BOTTOMRIGHT = 0x0001;

        [NativeTypeName("#define ARW_TOPLEFT 0x0002L")]
        public const int ARW_TOPLEFT = 0x0002;

        [NativeTypeName("#define ARW_TOPRIGHT 0x0003L")]
        public const int ARW_TOPRIGHT = 0x0003;

        [NativeTypeName("#define ARW_STARTMASK 0x0003L")]
        public const int ARW_STARTMASK = 0x0003;

        [NativeTypeName("#define ARW_STARTRIGHT 0x0001L")]
        public const int ARW_STARTRIGHT = 0x0001;

        [NativeTypeName("#define ARW_STARTTOP 0x0002L")]
        public const int ARW_STARTTOP = 0x0002;

        [NativeTypeName("#define ARW_LEFT 0x0000L")]
        public const int ARW_LEFT = 0x0000;

        [NativeTypeName("#define ARW_RIGHT 0x0000L")]
        public const int ARW_RIGHT = 0x0000;

        [NativeTypeName("#define ARW_UP 0x0004L")]
        public const int ARW_UP = 0x0004;

        [NativeTypeName("#define ARW_DOWN 0x0004L")]
        public const int ARW_DOWN = 0x0004;

        [NativeTypeName("#define ARW_HIDE 0x0008L")]
        public const int ARW_HIDE = 0x0008;

        [NativeTypeName("#define SERKF_SERIALKEYSON 0x00000001")]
        public const int SERKF_SERIALKEYSON = 0x00000001;

        [NativeTypeName("#define SERKF_AVAILABLE 0x00000002")]
        public const int SERKF_AVAILABLE = 0x00000002;

        [NativeTypeName("#define SERKF_INDICATOR 0x00000004")]
        public const int SERKF_INDICATOR = 0x00000004;

        [NativeTypeName("#define HCF_HIGHCONTRASTON 0x00000001")]
        public const int HCF_HIGHCONTRASTON = 0x00000001;

        [NativeTypeName("#define HCF_AVAILABLE 0x00000002")]
        public const int HCF_AVAILABLE = 0x00000002;

        [NativeTypeName("#define HCF_HOTKEYACTIVE 0x00000004")]
        public const int HCF_HOTKEYACTIVE = 0x00000004;

        [NativeTypeName("#define HCF_CONFIRMHOTKEY 0x00000008")]
        public const int HCF_CONFIRMHOTKEY = 0x00000008;

        [NativeTypeName("#define HCF_HOTKEYSOUND 0x00000010")]
        public const int HCF_HOTKEYSOUND = 0x00000010;

        [NativeTypeName("#define HCF_INDICATOR 0x00000020")]
        public const int HCF_INDICATOR = 0x00000020;

        [NativeTypeName("#define HCF_HOTKEYAVAILABLE 0x00000040")]
        public const int HCF_HOTKEYAVAILABLE = 0x00000040;

        [NativeTypeName("#define HCF_LOGONDESKTOP 0x00000100")]
        public const int HCF_LOGONDESKTOP = 0x00000100;

        [NativeTypeName("#define HCF_DEFAULTDESKTOP 0x00000200")]
        public const int HCF_DEFAULTDESKTOP = 0x00000200;

        [NativeTypeName("#define HCF_OPTION_NOTHEMECHANGE 0x00001000")]
        public const int HCF_OPTION_NOTHEMECHANGE = 0x00001000;

        [NativeTypeName("#define CDS_UPDATEREGISTRY 0x00000001")]
        public const int CDS_UPDATEREGISTRY = 0x00000001;

        [NativeTypeName("#define CDS_TEST 0x00000002")]
        public const int CDS_TEST = 0x00000002;

        [NativeTypeName("#define CDS_FULLSCREEN 0x00000004")]
        public const int CDS_FULLSCREEN = 0x00000004;

        [NativeTypeName("#define CDS_GLOBAL 0x00000008")]
        public const int CDS_GLOBAL = 0x00000008;

        [NativeTypeName("#define CDS_SET_PRIMARY 0x00000010")]
        public const int CDS_SET_PRIMARY = 0x00000010;

        [NativeTypeName("#define CDS_VIDEOPARAMETERS 0x00000020")]
        public const int CDS_VIDEOPARAMETERS = 0x00000020;

        [NativeTypeName("#define CDS_ENABLE_UNSAFE_MODES 0x00000100")]
        public const int CDS_ENABLE_UNSAFE_MODES = 0x00000100;

        [NativeTypeName("#define CDS_DISABLE_UNSAFE_MODES 0x00000200")]
        public const int CDS_DISABLE_UNSAFE_MODES = 0x00000200;

        [NativeTypeName("#define CDS_RESET 0x40000000")]
        public const int CDS_RESET = 0x40000000;

        [NativeTypeName("#define CDS_RESET_EX 0x20000000")]
        public const int CDS_RESET_EX = 0x20000000;

        [NativeTypeName("#define CDS_NORESET 0x10000000")]
        public const int CDS_NORESET = 0x10000000;

        [NativeTypeName("#define DISP_CHANGE_SUCCESSFUL 0")]
        public const int DISP_CHANGE_SUCCESSFUL = 0;

        [NativeTypeName("#define DISP_CHANGE_RESTART 1")]
        public const int DISP_CHANGE_RESTART = 1;

        [NativeTypeName("#define DISP_CHANGE_FAILED -1")]
        public const int DISP_CHANGE_FAILED = -1;

        [NativeTypeName("#define DISP_CHANGE_BADMODE -2")]
        public const int DISP_CHANGE_BADMODE = -2;

        [NativeTypeName("#define DISP_CHANGE_NOTUPDATED -3")]
        public const int DISP_CHANGE_NOTUPDATED = -3;

        [NativeTypeName("#define DISP_CHANGE_BADFLAGS -4")]
        public const int DISP_CHANGE_BADFLAGS = -4;

        [NativeTypeName("#define DISP_CHANGE_BADPARAM -5")]
        public const int DISP_CHANGE_BADPARAM = -5;

        [NativeTypeName("#define DISP_CHANGE_BADDUALVIEW -6")]
        public const int DISP_CHANGE_BADDUALVIEW = -6;

        [NativeTypeName("#define ChangeDisplaySettings ChangeDisplaySettingsW")]
        public static delegate*<DEVMODEW*, uint, int> ChangeDisplaySettings => &ChangeDisplaySettingsW;

        [NativeTypeName("#define ChangeDisplaySettingsEx ChangeDisplaySettingsExW")]
        public static delegate*<ushort*, DEVMODEW*, HWND, uint, void*, int> ChangeDisplaySettingsEx => &ChangeDisplaySettingsExW;

        [NativeTypeName("#define ENUM_CURRENT_SETTINGS ((DWORD)-1)")]
        public const uint ENUM_CURRENT_SETTINGS = unchecked((uint)(-1));

        [NativeTypeName("#define ENUM_REGISTRY_SETTINGS ((DWORD)-2)")]
        public const uint ENUM_REGISTRY_SETTINGS = unchecked((uint)(-2));

        [NativeTypeName("#define EnumDisplaySettings EnumDisplaySettingsW")]
        public static delegate*<ushort*, uint, DEVMODEW*, BOOL> EnumDisplaySettings => &EnumDisplaySettingsW;

        [NativeTypeName("#define EnumDisplaySettingsEx EnumDisplaySettingsExW")]
        public static delegate*<ushort*, uint, DEVMODEW*, uint, BOOL> EnumDisplaySettingsEx => &EnumDisplaySettingsExW;

        [NativeTypeName("#define EDS_RAWMODE 0x00000002")]
        public const int EDS_RAWMODE = 0x00000002;

        [NativeTypeName("#define EDS_ROTATEDMODE 0x00000004")]
        public const int EDS_ROTATEDMODE = 0x00000004;

        [NativeTypeName("#define EnumDisplayDevices EnumDisplayDevicesW")]
        public static delegate*<ushort*, uint, DISPLAY_DEVICEW*, uint, BOOL> EnumDisplayDevices => &EnumDisplayDevicesW;

        [NativeTypeName("#define EDD_GET_DEVICE_INTERFACE_NAME 0x00000001")]
        public const int EDD_GET_DEVICE_INTERFACE_NAME = 0x00000001;

        [NativeTypeName("#define SystemParametersInfo SystemParametersInfoW")]
        public static delegate*<uint, uint, void*, uint, BOOL> SystemParametersInfo => &SystemParametersInfoW;

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
        public static delegate*<HMONITOR, MONITORINFO*, BOOL> GetMonitorInfo => &GetMonitorInfoW;

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

        [NativeTypeName("#define CONSOLE_CARET_SELECTION 0x0001")]
        public const int CONSOLE_CARET_SELECTION = 0x0001;

        [NativeTypeName("#define CONSOLE_CARET_VISIBLE 0x0002")]
        public const int CONSOLE_CARET_VISIBLE = 0x0002;

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

        [NativeTypeName("#define USER_DEFAULT_SCREEN_DPI 96")]
        public const int USER_DEFAULT_SCREEN_DPI = 96;

        [NativeTypeName("#define GetWindowModuleFileName GetWindowModuleFileNameW")]
        public static delegate*<HWND, ushort*, uint, uint> GetWindowModuleFileName => &GetWindowModuleFileNameW;

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

        [NativeTypeName("#define GA_PARENT 1")]
        public const int GA_PARENT = 1;

        [NativeTypeName("#define GA_ROOT 2")]
        public const int GA_ROOT = 2;

        [NativeTypeName("#define GA_ROOTOWNER 3")]
        public const int GA_ROOTOWNER = 3;

        [NativeTypeName("#define RealGetWindowClass RealGetWindowClassW")]
        public static delegate*<HWND, ushort*, uint, uint> RealGetWindowClass => &RealGetWindowClassW;

        [NativeTypeName("#define GetAltTabInfo GetAltTabInfoW")]
        public static delegate*<HWND, int, ALTTABINFO*, ushort*, uint, BOOL> GetAltTabInfo => &GetAltTabInfoW;

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
        public static delegate*<HANDLE, uint, void*, uint*, uint> GetRawInputDeviceInfo => &GetRawInputDeviceInfoW;

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
    }
}
