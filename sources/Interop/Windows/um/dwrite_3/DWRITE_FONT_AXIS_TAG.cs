// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("UINT32")]
    public enum DWRITE_FONT_AXIS_TAG : uint
    {
        DWRITE_FONT_AXIS_TAG_WEIGHT = (((uint)((byte)((byte)('t'))) << 24) | ((uint)((byte)((byte)('h'))) << 16) | ((uint)((byte)((byte)('g'))) << 8) | (uint)((byte)((byte)('w')))),
        DWRITE_FONT_AXIS_TAG_WIDTH = (((uint)((byte)((byte)('h'))) << 24) | ((uint)((byte)((byte)('t'))) << 16) | ((uint)((byte)((byte)('d'))) << 8) | (uint)((byte)((byte)('w')))),
        DWRITE_FONT_AXIS_TAG_SLANT = (((uint)((byte)((byte)('t'))) << 24) | ((uint)((byte)((byte)('n'))) << 16) | ((uint)((byte)((byte)('l'))) << 8) | (uint)((byte)((byte)('s')))),
        DWRITE_FONT_AXIS_TAG_OPTICAL_SIZE = (((uint)((byte)((byte)('z'))) << 24) | ((uint)((byte)((byte)('s'))) << 16) | ((uint)((byte)((byte)('p'))) << 8) | (uint)((byte)((byte)('o')))),
        DWRITE_FONT_AXIS_TAG_ITALIC = (((uint)((byte)((byte)('l'))) << 24) | ((uint)((byte)((byte)('a'))) << 16) | ((uint)((byte)((byte)('t'))) << 8) | (uint)((byte)((byte)('i')))),
    }
}
