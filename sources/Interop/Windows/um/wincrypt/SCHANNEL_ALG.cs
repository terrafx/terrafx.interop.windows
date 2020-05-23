// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SCHANNEL_ALG
    {
        [NativeTypeName("DWORD")]
        public uint dwUse;

        [NativeTypeName("ALG_ID")]
        public uint Algid;

        [NativeTypeName("DWORD")]
        public uint cBits;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwReserved;
    }
}
