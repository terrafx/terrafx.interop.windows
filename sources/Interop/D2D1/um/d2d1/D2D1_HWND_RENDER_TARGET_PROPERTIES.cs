// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    /// <summary>Contains the HWND, pixel size, and presentation options for an ID2D1HwndRenderTarget.</summary>
    public unsafe struct D2D1_HWND_RENDER_TARGET_PROPERTIES
    {
        [NativeTypeName("HWND")]
        public IntPtr hwnd;

        [NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U pixelSize;

        public D2D1_PRESENT_OPTIONS presentOptions;
    }
}
