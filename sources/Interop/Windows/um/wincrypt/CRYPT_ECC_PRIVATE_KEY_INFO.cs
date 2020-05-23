// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_ECC_PRIVATE_KEY_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("CRYPT_DER_BLOB")]
        public CRYPTOAPI_BLOB PrivateKey;

        [NativeTypeName("LPSTR")]
        public sbyte* szCurveOid;

        public CRYPT_BIT_BLOB PublicKey;
    }
}
