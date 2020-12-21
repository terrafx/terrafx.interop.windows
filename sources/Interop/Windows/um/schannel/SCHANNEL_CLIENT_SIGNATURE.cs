// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SCHANNEL_CLIENT_SIGNATURE
    {
        [NativeTypeName("DWORD")]
        public uint cbLength;

        [NativeTypeName("ALG_ID")]
        public uint aiHash;

        [NativeTypeName("DWORD")]
        public uint cbHash;

        [NativeTypeName("BYTE [36]")]
        public fixed byte HashValue[36];

        [NativeTypeName("BYTE [20]")]
        public fixed byte CertThumbprint[20];
    }
}
