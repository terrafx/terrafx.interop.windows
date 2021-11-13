// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct CERT_CHAIN
    {
        [NativeTypeName("DWORD")]
        public uint cCerts;

        [NativeTypeName("PCERT_BLOB")]
        public CRYPT_DATA_BLOB* certs;

        public CRYPT_KEY_PROV_INFO keyLocatorInfo;
    }
}
