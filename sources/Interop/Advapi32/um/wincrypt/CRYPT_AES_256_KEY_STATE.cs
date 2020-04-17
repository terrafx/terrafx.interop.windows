// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_AES_256_KEY_STATE
    {
        [NativeTypeName("unsigned char [32]")]
        public fixed byte Key[32];

        [NativeTypeName("unsigned char [16]")]
        public fixed byte IV[16];

        [NativeTypeName("unsigned char [15][16]")]
        public fixed byte EncryptionState[15 * 16];

        [NativeTypeName("unsigned char [15][16]")]
        public fixed byte DecryptionState[15 * 16];

        [NativeTypeName("unsigned char [16]")]
        public fixed byte Feedback[16];
    }
}
