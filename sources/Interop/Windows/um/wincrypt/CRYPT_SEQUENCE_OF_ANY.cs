// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_SEQUENCE_OF_ANY
    {
        [NativeTypeName("DWORD")]
        public uint cValue;

        [NativeTypeName("PCRYPT_DER_BLOB")]
        public CRYPTOAPI_BLOB* rgValue;
    }
}
