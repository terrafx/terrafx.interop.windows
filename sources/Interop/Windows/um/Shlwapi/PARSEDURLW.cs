// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PARSEDURLW
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("LPCWSTR")]
        public ushort* pszProtocol;

        [NativeTypeName("UINT")]
        public uint cchProtocol;

        [NativeTypeName("LPCWSTR")]
        public ushort* pszSuffix;

        [NativeTypeName("UINT")]
        public uint cchSuffix;

        [NativeTypeName("UINT")]
        public uint nScheme;
    }
}
