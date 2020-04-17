// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SPC_IMAGE
    {
        [NativeTypeName("struct SPC_LINK_ *")]
        public SPC_LINK* pImageLink;

        [NativeTypeName("CRYPT_DATA_BLOB")]
        public CRYPTOAPI_BLOB Bitmap;

        [NativeTypeName("CRYPT_DATA_BLOB")]
        public CRYPTOAPI_BLOB Metafile;

        [NativeTypeName("CRYPT_DATA_BLOB")]
        public CRYPTOAPI_BLOB EnhancedMetafile;

        [NativeTypeName("CRYPT_DATA_BLOB")]
        public CRYPTOAPI_BLOB GifFile;
    }
}
