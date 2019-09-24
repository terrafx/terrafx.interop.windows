// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    /// <summary>Specifies additional features supportable by a compatible render target when it is created. This enumeration allows a bitwise combination of its member values.</summary>
    [Flags]
    public enum D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS : uint
    {
        D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE = 0x00000000,

        /// <summary>The compatible render target will allow a call to GetDC on the ID2D1GdiInteropRenderTarget interface. This can be specified even if the parent render target is not GDI compatible.</summary>
        D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_GDI_COMPATIBLE = 0x00000001,

        D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_FORCE_DWORD = 0xFFFFFFFF
    }
}
