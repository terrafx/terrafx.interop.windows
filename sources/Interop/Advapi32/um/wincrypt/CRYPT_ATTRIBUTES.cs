// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_ATTRIBUTES
    {
        [NativeTypeName("DWORD")]
        public uint cAttr;

        [NativeTypeName("PCRYPT_ATTRIBUTE")]
        public CRYPT_ATTRIBUTE* rgAttr;
    }
}
