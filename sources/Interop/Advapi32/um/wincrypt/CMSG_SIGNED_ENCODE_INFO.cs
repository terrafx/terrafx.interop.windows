// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_SIGNED_ENCODE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint cSigners;

        [NativeTypeName("PCMSG_SIGNER_ENCODE_INFO")]
        public CMSG_SIGNER_ENCODE_INFO* rgSigners;

        [NativeTypeName("DWORD")]
        public uint cCertEncoded;

        [NativeTypeName("PCERT_BLOB")]
        public CRYPTOAPI_BLOB* rgCertEncoded;

        [NativeTypeName("DWORD")]
        public uint cCrlEncoded;

        [NativeTypeName("PCRL_BLOB")]
        public CRYPTOAPI_BLOB* rgCrlEncoded;
    }
}
