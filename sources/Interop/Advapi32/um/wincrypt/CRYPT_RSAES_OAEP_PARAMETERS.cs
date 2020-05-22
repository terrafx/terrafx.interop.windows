// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CRYPT_RSAES_OAEP_PARAMETERS
    {
        public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

        public CRYPT_MASK_GEN_ALGORITHM MaskGenAlgorithm;

        public CRYPT_PSOURCE_ALGORITHM PSourceAlgorithm;
    }
}
