// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_PIXEL_FORMAT
    {
        public static readonly D2D1_PIXEL_FORMAT DEFAULT = new D2D1_PIXEL_FORMAT(DXGI_FORMAT.DXGI_FORMAT_UNKNOWN, D2D1_ALPHA_MODE.D2D1_ALPHA_MODE_UNKNOWN);

        public D2D1_PIXEL_FORMAT(in DXGI_FORMAT dxgiFormat, in D2D1_ALPHA_MODE alphaMode)
        {
            format = dxgiFormat;
            this.alphaMode = alphaMode;
        }
    }
}
