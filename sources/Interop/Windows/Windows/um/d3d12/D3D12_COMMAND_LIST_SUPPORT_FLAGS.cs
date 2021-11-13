// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.Windows.D3D12_COMMAND_LIST_TYPE;

namespace TerraFX.Interop.Windows
{
    [Flags]
    public enum D3D12_COMMAND_LIST_SUPPORT_FLAGS
    {
        D3D12_COMMAND_LIST_SUPPORT_FLAG_NONE = 0,
        D3D12_COMMAND_LIST_SUPPORT_FLAG_DIRECT = (1 << D3D12_COMMAND_LIST_TYPE_DIRECT),
        D3D12_COMMAND_LIST_SUPPORT_FLAG_BUNDLE = (1 << D3D12_COMMAND_LIST_TYPE_BUNDLE),
        D3D12_COMMAND_LIST_SUPPORT_FLAG_COMPUTE = (1 << D3D12_COMMAND_LIST_TYPE_COMPUTE),
        D3D12_COMMAND_LIST_SUPPORT_FLAG_COPY = (1 << D3D12_COMMAND_LIST_TYPE_COPY),
        D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_DECODE = (1 << D3D12_COMMAND_LIST_TYPE_VIDEO_DECODE),
        D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_PROCESS = (1 << D3D12_COMMAND_LIST_TYPE_VIDEO_PROCESS),
        D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_ENCODE = (1 << D3D12_COMMAND_LIST_TYPE_VIDEO_ENCODE),
    }
}
