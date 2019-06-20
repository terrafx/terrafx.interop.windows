// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    /// <summary>Specifies how the bitmap can be used.</summary>
    [Flags]
    public enum D2D1_BITMAP_OPTIONS : uint
    {
        /// <summary>The bitmap is created with default properties.</summary>
        D2D1_BITMAP_OPTIONS_NONE = 0x00000000,

        /// <summary>The bitmap can be specified as a target in ID2D1DeviceContext::SetTarget</summary>
        D2D1_BITMAP_OPTIONS_TARGET = 0x00000001,

        /// <summary>The bitmap cannot be used as an input to DrawBitmap, DrawImage, in a bitmap brush or as an input to an effect.</summary>
        D2D1_BITMAP_OPTIONS_CANNOT_DRAW = 0x00000002,

        /// <summary>The bitmap can be read from the CPU.</summary>
        D2D1_BITMAP_OPTIONS_CPU_READ = 0x00000004,

        /// <summary>The bitmap works with the ID2D1GdiInteropRenderTarget::GetDC API.</summary>
        D2D1_BITMAP_OPTIONS_GDI_COMPATIBLE = 0x00000008,

        D2D1_BITMAP_OPTIONS_FORCE_DWORD = 0xFFFFFFFF
    }
}
