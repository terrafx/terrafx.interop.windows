// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SecPkgContext_KeyingMaterialInfo
    {
        [NativeTypeName("WORD")]
        public ushort cbLabel;

        [NativeTypeName("LPSTR")]
        public sbyte* pszLabel;

        [NativeTypeName("WORD")]
        public ushort cbContextValue;

        [NativeTypeName("PBYTE")]
        public byte* pbContextValue;

        [NativeTypeName("DWORD")]
        public uint cbKeyingMaterial;
    }
}
