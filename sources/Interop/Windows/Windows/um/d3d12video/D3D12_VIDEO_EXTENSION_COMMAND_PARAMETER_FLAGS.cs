// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [Flags]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public enum D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS
    {
        D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_NONE = 0,
        D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_READ = 0x1,
        D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_WRITE = 0x2,
    }
}
