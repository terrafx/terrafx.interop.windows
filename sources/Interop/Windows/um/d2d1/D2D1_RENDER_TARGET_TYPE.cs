// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Describes whether a render target uses hardware or software rendering, or if Direct2D should select the rendering mode.</summary>
    public enum D2D1_RENDER_TARGET_TYPE : uint
    {
        /// <summary>D2D is free to choose the render target type for the caller.</summary>
        D2D1_RENDER_TARGET_TYPE_DEFAULT = 0,

        /// <summary>The render target will render using the CPU.</summary>
        D2D1_RENDER_TARGET_TYPE_SOFTWARE = 1,

        /// <summary>The render target will render using the GPU.</summary>
        D2D1_RENDER_TARGET_TYPE_HARDWARE = 2,

        D2D1_RENDER_TARGET_TYPE_FORCE_DWORD = 0xFFFFFFFF
    }
}
