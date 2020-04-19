// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_X942_OTHER_INFO
    {
        [NativeTypeName("LPSTR")]
        public sbyte* pszContentEncryptionObjId;

        [NativeTypeName("BYTE [4]")]
        public fixed byte rgbCounter[4];

        [NativeTypeName("BYTE [4]")]
        public fixed byte rgbKeyLength[4];

        [NativeTypeName("CRYPT_DATA_BLOB")]
        public CRYPTOAPI_BLOB PubInfo;
    }
}
