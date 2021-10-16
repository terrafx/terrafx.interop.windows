// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CMSG_SIGNER_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("CERT_NAME_BLOB")]
        public CRYPT_DATA_BLOB Issuer;

        [NativeTypeName("CRYPT_INTEGER_BLOB")]
        public CRYPT_DATA_BLOB SerialNumber;

        public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

        public CRYPT_ALGORITHM_IDENTIFIER HashEncryptionAlgorithm;

        public CRYPT_DATA_BLOB EncryptedHash;

        public CRYPT_ATTRIBUTES AuthAttrs;

        public CRYPT_ATTRIBUTES UnauthAttrs;
    }
}
