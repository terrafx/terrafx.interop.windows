// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluspixelformats.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct ColorPalette
    {
        [NativeTypeName("UINT")]
        public uint Flags;

        [NativeTypeName("UINT")]
        public uint Count;

        [NativeTypeName("Gdiplus::ARGB [1]")]
        public fixed uint Entries[1];
    }
}
