// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DWRITE_FONT_AXIS_TAG : uint
    {
        DWRITE_FONT_AXIS_TAG_WEIGHT = 0x74686777,
        DWRITE_FONT_AXIS_TAG_WIDTH = 0x68746477,
        DWRITE_FONT_AXIS_TAG_SLANT = 0x746E6C73,
        DWRITE_FONT_AXIS_TAG_OPTICAL_SIZE = 0x7A73706F,
        DWRITE_FONT_AXIS_TAG_ITALIC = 0x6C617469,
    }
}
