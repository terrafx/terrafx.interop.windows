// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum eTlsHashAlgorithm
    {
        TlsHashAlgorithm_None = 0,
        TlsHashAlgorithm_Md5 = 1,
        TlsHashAlgorithm_Sha1 = 2,
        TlsHashAlgorithm_Sha224 = 3,
        TlsHashAlgorithm_Sha256 = 4,
        TlsHashAlgorithm_Sha384 = 5,
        TlsHashAlgorithm_Sha512 = 6,
    }
}
