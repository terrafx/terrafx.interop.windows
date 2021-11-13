// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SP_DRVINFO_DATA64_V1_W
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint DriverType;

        [NativeTypeName("ULONG_PTR")]
        public nuint Reserved;

        [NativeTypeName("WCHAR [256]")]
        public fixed ushort Description[256];

        [NativeTypeName("WCHAR [256]")]
        public fixed ushort MfgName[256];

        [NativeTypeName("WCHAR [256]")]
        public fixed ushort ProviderName[256];
    }
}
