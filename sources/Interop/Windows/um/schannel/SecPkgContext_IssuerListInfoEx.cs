// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SecPkgContext_IssuerListInfoEx
    {
        [NativeTypeName("PCERT_NAME_BLOB")]
        public CRYPT_DATA_BLOB* aIssuers;

        [NativeTypeName("DWORD")]
        public uint cIssuers;
    }
}
