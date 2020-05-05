// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SP_DRVINFO_DETAIL_DATA_A
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public FILETIME InfDate;

        [NativeTypeName("DWORD")]
        public uint CompatIDsOffset;

        [NativeTypeName("DWORD")]
        public uint CompatIDsLength;

        [NativeTypeName("ULONG_PTR")]
        public UIntPtr Reserved;

        [NativeTypeName("CHAR [256]")]
        public fixed sbyte SectionName[256];

        [NativeTypeName("CHAR [260]")]
        public fixed sbyte InfFileName[260];

        [NativeTypeName("CHAR [256]")]
        public fixed sbyte DrvDescription[256];

        [NativeTypeName("CHAR [1]")]
        public fixed sbyte HardwareID[1];
    }
}
