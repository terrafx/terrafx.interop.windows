// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SP_DRVINFO_DATA_V2_A
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint DriverType;

        [NativeTypeName("ULONG_PTR")]
        public nuint Reserved;

        [NativeTypeName("CHAR [256]")]
        public fixed sbyte Description[256];

        [NativeTypeName("CHAR [256]")]
        public fixed sbyte MfgName[256];

        [NativeTypeName("CHAR [256]")]
        public fixed sbyte ProviderName[256];

        public FILETIME DriverDate;

        [NativeTypeName("DWORDLONG")]
        public ulong DriverVersion;
    }
}
