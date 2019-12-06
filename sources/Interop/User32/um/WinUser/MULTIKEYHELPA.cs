// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MULTIKEYHELPA
    {
        [NativeTypeName("DWORD")]
        public uint mkSize;

        [NativeTypeName("CHAR")]
        public sbyte mkKeylist;

        [NativeTypeName("CHAR [1]")]
        public fixed sbyte szKeyphrase[1];
    }
}
