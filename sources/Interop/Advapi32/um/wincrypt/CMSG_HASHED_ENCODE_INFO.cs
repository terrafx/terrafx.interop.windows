// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_HASHED_ENCODE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HCRYPTPROV_LEGACY")]
        public uint hCryptProv;

        public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

        [NativeTypeName("void *")]
        public void* pvHashAuxInfo;
    }
}
