// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS
    {
        D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_NONE = 0,
        D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_BOB = 0x1,
        D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_CUSTOM = unchecked((int)(0x80000000)),
    }
}
