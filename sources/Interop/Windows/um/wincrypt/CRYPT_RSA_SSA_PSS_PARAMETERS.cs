// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CRYPT_RSA_SSA_PSS_PARAMETERS
    {
        public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

        public CRYPT_MASK_GEN_ALGORITHM MaskGenAlgorithm;

        [NativeTypeName("DWORD")]
        public uint dwSaltLength;

        [NativeTypeName("DWORD")]
        public uint dwTrailerField;
    }
}
