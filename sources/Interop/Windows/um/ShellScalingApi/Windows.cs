// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShellScalingApi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("shcore", ExactSpelling = true)]
        public static extern DEVICE_SCALE_FACTOR GetScaleFactorForDevice(DISPLAY_DEVICE_TYPE deviceType);

        [DllImport("shcore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RegisterScaleChangeNotifications(DISPLAY_DEVICE_TYPE displayDevice, [NativeTypeName("HWND")] IntPtr hwndNotify, [NativeTypeName("UINT")] uint uMsgNotify, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [DllImport("shcore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RevokeScaleChangeNotifications(DISPLAY_DEVICE_TYPE displayDevice, [NativeTypeName("DWORD")] uint dwCookie);

        [DllImport("shcore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetScaleFactorForMonitor([NativeTypeName("HMONITOR")] IntPtr hMon, DEVICE_SCALE_FACTOR* pScale);

        [DllImport("shcore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RegisterScaleChangeEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD_PTR *")] nuint* pdwCookie);

        [DllImport("shcore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UnregisterScaleChangeEvent([NativeTypeName("DWORD_PTR")] nuint dwCookie);

        [DllImport("shcore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SetProcessDpiAwareness(PROCESS_DPI_AWARENESS value);

        [DllImport("shcore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetProcessDpiAwareness([NativeTypeName("HANDLE")] IntPtr hprocess, PROCESS_DPI_AWARENESS* value);

        [DllImport("shcore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetDpiForMonitor([NativeTypeName("HMONITOR")] IntPtr hmonitor, MONITOR_DPI_TYPE dpiType, [NativeTypeName("UINT *")] uint* dpiX, [NativeTypeName("UINT *")] uint* dpiY);

        [DllImport("shcore", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDpiForShellUIComponent(SHELL_UI_COMPONENT param0);
    }
}
