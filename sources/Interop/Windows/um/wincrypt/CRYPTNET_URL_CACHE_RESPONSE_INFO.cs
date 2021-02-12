// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPTNET_URL_CACHE_RESPONSE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("WORD")]
        public ushort wResponseType;

        [NativeTypeName("WORD")]
        public ushort wResponseFlags;

        public FILETIME LastModifiedTime;

        [NativeTypeName("DWORD")]
        public uint dwMaxAge;

        [NativeTypeName("LPCWSTR")]
        public ushort* pwszETag;

        [NativeTypeName("DWORD")]
        public uint dwProxyId;
    }
}
