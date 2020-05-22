// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_ENVELOPED_ENCODE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HCRYPTPROV_LEGACY")]
        public nuint hCryptProv;

        public CRYPT_ALGORITHM_IDENTIFIER ContentEncryptionAlgorithm;

        [NativeTypeName("void *")]
        public void* pvEncryptionAuxInfo;

        [NativeTypeName("DWORD")]
        public uint cRecipients;

        [NativeTypeName("PCERT_INFO *")]
        public CERT_INFO** rgpRecipients;
    }
}
