// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.CommandId"]/*' />
    public Guid CommandId;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.Stage"]/*' />
    public D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE Stage;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.ParameterCount"]/*' />
    public uint ParameterCount;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.pParameterInfos"]/*' />
    public D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO* pParameterInfos;
}
