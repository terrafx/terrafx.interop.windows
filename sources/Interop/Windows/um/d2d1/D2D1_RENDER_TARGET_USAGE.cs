// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    /// <summary>Describes how a render target is remoted and whether it should be GDI-compatible. This enumeration allows a bitwise combination of its member values.</summary>
    [Flags]
    public enum D2D1_RENDER_TARGET_USAGE : uint
    {
        D2D1_RENDER_TARGET_USAGE_NONE = 0x00000000,

        /// <summary>Rendering will occur locally, if a terminal-services session is established, the bitmap updates will be sent to the terminal services client.</summary>
        D2D1_RENDER_TARGET_USAGE_FORCE_BITMAP_REMOTING = 0x00000001,

        /// <summary>The render target will allow a call to GetDC on the ID2D1GdiInteropRenderTarget interface. Rendering will also occur locally.</summary>
        D2D1_RENDER_TARGET_USAGE_GDI_COMPATIBLE = 0x00000002,

        D2D1_RENDER_TARGET_USAGE_FORCE_DWORD = 0xFFFFFFFF
    }
}
