// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_RC4_KEY_STATE
    {
        [NativeTypeName("unsigned char [16]")]
        public fixed byte Key[16];

        [NativeTypeName("unsigned char [256]")]
        public fixed byte SBox[256];

        [NativeTypeName("unsigned char")]
        public byte i;

        [NativeTypeName("unsigned char")]
        public byte j;
    }
}
