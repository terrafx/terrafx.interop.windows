// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CERT_DSS_PARAMETERS
    {
        [NativeTypeName("CRYPT_UINT_BLOB")]
        public CRYPT_DATA_BLOB p;

        [NativeTypeName("CRYPT_UINT_BLOB")]
        public CRYPT_DATA_BLOB q;

        [NativeTypeName("CRYPT_UINT_BLOB")]
        public CRYPT_DATA_BLOB g;
    }
}
