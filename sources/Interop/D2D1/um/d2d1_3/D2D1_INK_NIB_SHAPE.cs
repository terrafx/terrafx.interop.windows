// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specifies the appearance of the ink nib (pen tip) as part of an D2D1_INK_STYLE_PROPERTIES structure.</summary>
    public enum D2D1_INK_NIB_SHAPE : uint
    {
        D2D1_INK_NIB_SHAPE_ROUND = 0,

        D2D1_INK_NIB_SHAPE_SQUARE = 1,

        D2D1_INK_NIB_SHAPE_FORCE_DWORD = 0xFFFFFFFF
    }
}
