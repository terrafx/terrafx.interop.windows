// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

        public void* pvKeyEncryptionAuxInfo;

        [NativeTypeName("HCRYPTPROV_LEGACY")]
        public nuint hCryptProv;

        public CRYPT_BIT_BLOB RecipientPublicKey;

        public CERT_ID RecipientId;
    }
}
