// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS
    {
        D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_NONE = 0,
        D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_QUARTER_PEL = 1 << D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_QUARTER_PEL,
    }
}
