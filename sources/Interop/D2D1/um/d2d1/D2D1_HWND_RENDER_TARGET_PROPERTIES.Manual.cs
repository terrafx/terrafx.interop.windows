// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct D2D1_HWND_RENDER_TARGET_PROPERTIES
    {
        public D2D1_HWND_RENDER_TARGET_PROPERTIES(IntPtr hwnd, D2D_SIZE_U pixelSize, D2D1_PRESENT_OPTIONS presentOptions = D2D1_PRESENT_OPTIONS.D2D1_PRESENT_OPTIONS_NONE)
        {
            this.hwnd = hwnd;
            this.pixelSize = pixelSize;
            this.presentOptions = presentOptions;
        }

        public D2D1_HWND_RENDER_TARGET_PROPERTIES(IntPtr hwnd, D2D1_PRESENT_OPTIONS presentOptions = D2D1_PRESENT_OPTIONS.D2D1_PRESENT_OPTIONS_NONE) : this(hwnd, new D2D_SIZE_U(0, 0), presentOptions)
        {
        }
    }
}
