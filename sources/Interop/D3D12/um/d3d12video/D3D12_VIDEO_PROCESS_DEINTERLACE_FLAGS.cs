// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    [NativeTypeName("int")]
    public enum D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS : uint
    {
        D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_NONE = 0,
        D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_BOB = 0x1,
        D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_CUSTOM = 0x80000000,
    }
}
