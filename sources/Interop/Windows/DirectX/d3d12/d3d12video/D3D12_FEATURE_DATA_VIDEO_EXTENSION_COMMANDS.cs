// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMANDS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMANDS"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMANDS
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMANDS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMANDS.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMANDS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMANDS.CommandCount"]/*' />
    public uint CommandCount;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMANDS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMANDS.pCommandInfos"]/*' />
    public D3D12_VIDEO_EXTENSION_COMMAND_INFO* pCommandInfos;
}
