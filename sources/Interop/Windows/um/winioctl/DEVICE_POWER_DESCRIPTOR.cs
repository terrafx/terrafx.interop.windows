// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DEVICE_POWER_DESCRIPTOR
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("BOOLEAN")]
        public byte DeviceAttentionSupported;

        [NativeTypeName("BOOLEAN")]
        public byte AsynchronousNotificationSupported;

        [NativeTypeName("BOOLEAN")]
        public byte IdlePowerManagementEnabled;

        [NativeTypeName("BOOLEAN")]
        public byte D3ColdEnabled;

        [NativeTypeName("BOOLEAN")]
        public byte D3ColdSupported;

        [NativeTypeName("BOOLEAN")]
        public byte NoVerifyDuringIdlePower;

        [NativeTypeName("BYTE [2]")]
        public fixed byte Reserved[2];

        [NativeTypeName("DWORD")]
        public uint IdleTimeoutInMS;
    }
}
