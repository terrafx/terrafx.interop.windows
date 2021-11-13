// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct PROV_ENUMALGS_EX
    {
        [NativeTypeName("ALG_ID")]
        public uint aiAlgid;

        [NativeTypeName("DWORD")]
        public uint dwDefaultLen;

        [NativeTypeName("DWORD")]
        public uint dwMinLen;

        [NativeTypeName("DWORD")]
        public uint dwMaxLen;

        [NativeTypeName("DWORD")]
        public uint dwProtocols;

        [NativeTypeName("DWORD")]
        public uint dwNameLen;

        [NativeTypeName("CHAR [20]")]
        public fixed sbyte szName[20];

        [NativeTypeName("DWORD")]
        public uint dwLongNameLen;

        [NativeTypeName("CHAR [40]")]
        public fixed sbyte szLongName[40];
    }
}
