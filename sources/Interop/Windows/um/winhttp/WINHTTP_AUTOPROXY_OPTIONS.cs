// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WINHTTP_AUTOPROXY_OPTIONS
    {
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwAutoDetectFlags;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpszAutoConfigUrl;

        [NativeTypeName("LPVOID")]
        public void* lpvReserved;

        [NativeTypeName("DWORD")]
        public uint dwReserved;

        [NativeTypeName("BOOL")]
        public int fAutoLogonIfChallenged;
    }
}
