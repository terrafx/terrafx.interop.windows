// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PROV_ENUMALGS
    {
        [NativeTypeName("ALG_ID")]
        public uint aiAlgid;

        [NativeTypeName("DWORD")]
        public uint dwBitLen;

        [NativeTypeName("DWORD")]
        public uint dwNameLen;

        [NativeTypeName("CHAR [20]")]
        public fixed sbyte szName[20];
    }
}
