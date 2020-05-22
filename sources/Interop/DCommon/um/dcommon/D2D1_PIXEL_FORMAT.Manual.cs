// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D2D1_ALPHA_MODE;
using static TerraFX.Interop.DXGI_FORMAT;

namespace TerraFX.Interop
{
    public partial struct D2D1_PIXEL_FORMAT
    {
        public D2D1_PIXEL_FORMAT(DXGI_FORMAT dxgiFormat = DXGI_FORMAT_UNKNOWN, D2D1_ALPHA_MODE alphaMode = D2D1_ALPHA_MODE_UNKNOWN)
        {
            this.format = dxgiFormat;
            this.alphaMode = alphaMode;
        }
    }
}
