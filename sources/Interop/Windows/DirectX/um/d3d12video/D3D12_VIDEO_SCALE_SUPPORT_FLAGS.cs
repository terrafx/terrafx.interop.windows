// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

[Flags]
public enum D3D12_VIDEO_SCALE_SUPPORT_FLAGS
{
    D3D12_VIDEO_SCALE_SUPPORT_FLAG_NONE = 0,
    D3D12_VIDEO_SCALE_SUPPORT_FLAG_POW2_ONLY = 0x1,
    D3D12_VIDEO_SCALE_SUPPORT_FLAG_EVEN_DIMENSIONS_ONLY = 0x2,
}
