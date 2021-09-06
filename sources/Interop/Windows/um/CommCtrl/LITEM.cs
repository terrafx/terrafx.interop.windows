// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct LITEM
    {
        [NativeTypeName("UINT")]
        public uint mask;

        public int iLink;

        [NativeTypeName("UINT")]
        public uint state;

        [NativeTypeName("UINT")]
        public uint stateMask;

        [NativeTypeName("WCHAR [48]")]
        public fixed ushort szID[48];

        [NativeTypeName("WCHAR [2084]")]
        public fixed ushort szUrl[2084];
    }
}
