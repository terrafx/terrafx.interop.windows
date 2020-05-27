// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_AES_128_KEY_STATE
    {
        [NativeTypeName("unsigned char [16]")]
        public fixed byte Key[16];

        [NativeTypeName("unsigned char [16]")]
        public fixed byte IV[16];

        [NativeTypeName("unsigned char [11][16]")]
        public fixed byte EncryptionState[11 * 16];

        [NativeTypeName("unsigned char [11][16]")]
        public fixed byte DecryptionState[11 * 16];

        [NativeTypeName("unsigned char [16]")]
        public fixed byte Feedback[16];
    }
}
