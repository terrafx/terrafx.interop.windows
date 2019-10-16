// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DISPLAY_DEVICEW
    {
        [NativeTypeName("DWORD")]
        public uint cb;

        [NativeTypeName("WCHAR [32]")]
        public fixed ushort DeviceName[32];

        [NativeTypeName("WCHAR [128]")]
        public fixed ushort DeviceString[128];

        [NativeTypeName("DWORD")]
        public uint StateFlags;

        [NativeTypeName("WCHAR [128]")]
        public fixed ushort DeviceID[128];

        [NativeTypeName("WCHAR [128]")]
        public fixed ushort DeviceKey[128];
    }
}
