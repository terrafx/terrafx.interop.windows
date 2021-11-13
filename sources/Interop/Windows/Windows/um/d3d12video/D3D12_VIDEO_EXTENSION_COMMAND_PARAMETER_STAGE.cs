// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0.19041.0")]
    public enum D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE
    {
        D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CREATION = 0,
        D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_INITIALIZATION = 1,
        D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_EXECUTION = 2,
        D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CAPS_INPUT = 3,
        D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CAPS_OUTPUT = 4,
        D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_DEVICE_EXECUTE_INPUT = 5,
        D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_DEVICE_EXECUTE_OUTPUT = 6,
    }
}
