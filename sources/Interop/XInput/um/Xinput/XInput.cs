// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class XInput
    {
        private const string LibraryPath = "xinput1_4";

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "XInputGetState", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint XInputGetState([NativeTypeName("DWORD")] uint dwUserIndex, [NativeTypeName("XINPUT_STATE *")] XINPUT_STATE* pState);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "XInputSetState", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint XInputSetState([NativeTypeName("DWORD")] uint dwUserIndex, [NativeTypeName("XINPUT_VIBRATION *")] XINPUT_VIBRATION* pVibration);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "XInputGetCapabilities", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint XInputGetCapabilities([NativeTypeName("DWORD")] uint dwUserIndex, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("XINPUT_CAPABILITIES *")] XINPUT_CAPABILITIES* pCapabilities);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "XInputEnable", ExactSpelling = true)]
        public static extern void XInputEnable([NativeTypeName("BOOL")] int enable);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "XInputGetAudioDeviceIds", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint XInputGetAudioDeviceIds([NativeTypeName("DWORD")] uint dwUserIndex, [NativeTypeName("LPWSTR")] ushort* pRenderDeviceId, [NativeTypeName("UINT *")] uint* pRenderCount, [NativeTypeName("LPWSTR")] ushort* pCaptureDeviceId, [NativeTypeName("UINT *")] uint* pCaptureCount);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "XInputGetBatteryInformation", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint XInputGetBatteryInformation([NativeTypeName("DWORD")] uint dwUserIndex, [NativeTypeName("BYTE")] byte devType, [NativeTypeName("XINPUT_BATTERY_INFORMATION *")] XINPUT_BATTERY_INFORMATION* pBatteryInformation);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "XInputGetKeystroke", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint XInputGetKeystroke([NativeTypeName("DWORD")] uint dwUserIndex, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("PXINPUT_KEYSTROKE")] XINPUT_KEYSTROKE* pKeystroke);
    }
}
