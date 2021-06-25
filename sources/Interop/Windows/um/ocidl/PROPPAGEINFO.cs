// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PROPPAGEINFO
    {
        [NativeTypeName("ULONG")]
        public uint cb;

        [NativeTypeName("LPOLESTR")]
        public ushort* pszTitle;

        public SIZE size;

        [NativeTypeName("LPOLESTR")]
        public ushort* pszDocString;

        [NativeTypeName("LPOLESTR")]
        public ushort* pszHelpFile;

        [NativeTypeName("DWORD")]
        public uint dwHelpContext;
    }
}
