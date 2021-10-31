// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DRAGINFO64A
    {
        [NativeTypeName("UINT")]
        public uint uSize;

        public POINT pt;

        public BOOL fNC;

        [NativeTypeName("PZZSTR")]
        public sbyte* lpFileList;

        [NativeTypeName("DWORD")]
        public uint grfKeyState;
    }
}
