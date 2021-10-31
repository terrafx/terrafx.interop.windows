// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SCHANNEL_CERT_HASH_STORE
    {
        [NativeTypeName("DWORD")]
        public uint dwLength;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public HCRYPTPROV hProv;

        [NativeTypeName("BYTE [20]")]
        public fixed byte ShaHash[20];

        [NativeTypeName("WCHAR [128]")]
        public fixed ushort pwszStoreName[128];
    }
}
