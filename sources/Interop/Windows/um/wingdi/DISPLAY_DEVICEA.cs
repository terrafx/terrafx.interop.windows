// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DISPLAY_DEVICEA
    {
        [NativeTypeName("DWORD")]
        public uint cb;

        [NativeTypeName("CHAR [32]")]
        public fixed sbyte DeviceName[32];

        [NativeTypeName("CHAR [128]")]
        public fixed sbyte DeviceString[128];

        [NativeTypeName("DWORD")]
        public uint StateFlags;

        [NativeTypeName("CHAR [128]")]
        public fixed sbyte DeviceID[128];

        [NativeTypeName("CHAR [128]")]
        public fixed sbyte DeviceKey[128];
    }
}
