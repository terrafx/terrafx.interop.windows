// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct LVFINDINFOA
    {
        [NativeTypeName("UINT")]
        public uint flags;

        [NativeTypeName("LPCSTR")]
        public sbyte* psz;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        public POINT pt;

        [NativeTypeName("UINT")]
        public uint vkDirection;
    }
}
