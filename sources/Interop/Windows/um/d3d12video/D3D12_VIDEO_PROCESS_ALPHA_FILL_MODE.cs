// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE
    {
        D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_OPAQUE = 0,
        D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_BACKGROUND = 1,
        D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_DESTINATION = 2,
        D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_SOURCE_STREAM = 3,
    }
}
