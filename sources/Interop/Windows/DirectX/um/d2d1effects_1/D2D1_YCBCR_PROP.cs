// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX
{
    public enum D2D1_YCBCR_PROP : uint
    {
        D2D1_YCBCR_PROP_CHROMA_SUBSAMPLING = 0,
        D2D1_YCBCR_PROP_TRANSFORM_MATRIX = 1,
        D2D1_YCBCR_PROP_INTERPOLATION_MODE = 2,
        D2D1_YCBCR_PROP_FORCE_DWORD = 0xffffffff,
    }
}
