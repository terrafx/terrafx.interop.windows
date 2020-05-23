// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D12_VIDEO_PROCESS_FEATURE_FLAGS
    {
        D3D12_VIDEO_PROCESS_FEATURE_FLAG_NONE = 0,
        D3D12_VIDEO_PROCESS_FEATURE_FLAG_ALPHA_FILL = 0x1,
        D3D12_VIDEO_PROCESS_FEATURE_FLAG_LUMA_KEY = 0x2,
        D3D12_VIDEO_PROCESS_FEATURE_FLAG_STEREO = 0x4,
        D3D12_VIDEO_PROCESS_FEATURE_FLAG_ROTATION = 0x8,
        D3D12_VIDEO_PROCESS_FEATURE_FLAG_FLIP = 0x10,
        D3D12_VIDEO_PROCESS_FEATURE_FLAG_ALPHA_BLENDING = 0x20,
        D3D12_VIDEO_PROCESS_FEATURE_FLAG_PIXEL_ASPECT_RATIO = 0x40,
    }
}
