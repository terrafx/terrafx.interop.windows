// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specifies how a device context is initialized for GDI rendering when it is retrieved from the render target.</summary>
    public enum D2D1_DC_INITIALIZE_MODE : uint
    {
        /// <summary>The contents of the D2D render target will be copied to the DC.</summary>
        D2D1_DC_INITIALIZE_MODE_COPY = 0,

        /// <summary>The contents of the DC will be cleared.</summary>
        D2D1_DC_INITIALIZE_MODE_CLEAR = 1,

        D2D1_DC_INITIALIZE_MODE_FORCE_DWORD = 0xFFFFFFFF
    }
}
