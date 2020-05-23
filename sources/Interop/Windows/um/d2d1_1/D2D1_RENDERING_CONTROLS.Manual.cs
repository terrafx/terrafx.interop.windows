// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public partial struct D2D1_RENDERING_CONTROLS
    {
        public D2D1_RENDERING_CONTROLS(D2D1_BUFFER_PRECISION bufferPrecision, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U tileSize)
        {
            this = RenderingControls(bufferPrecision, tileSize);
        }
    }
}
