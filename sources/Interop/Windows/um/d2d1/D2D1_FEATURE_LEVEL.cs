// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D3D_FEATURE_LEVEL;

namespace TerraFX.Interop
{
    /// <summary>Describes the minimum DirectX support required for hardware rendering by a render target.</summary>
    public enum D2D1_FEATURE_LEVEL : uint
    {
        /// <summary>The caller does not require a particular underlying D3D device level.</summary>
        D2D1_FEATURE_LEVEL_DEFAULT = 0,

        /// <summary>The D3D device level is DX9 compatible.</summary>
        D2D1_FEATURE_LEVEL_9 = D3D_FEATURE_LEVEL_9_1,

        /// <summary>The D3D device level is DX10 compatible.</summary>
        D2D1_FEATURE_LEVEL_10 = D3D_FEATURE_LEVEL_10_0,

        D2D1_FEATURE_LEVEL_FORCE_DWORD = 0xFFFFFFFF
    }
}
