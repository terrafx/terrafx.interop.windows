// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE.CommandId"]/*' />
    public Guid CommandId;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE.pCreationParameters"]/*' />
    [NativeTypeName("const void *")]
    public void* pCreationParameters;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE.CreationParametersSizeInBytes"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint CreationParametersSizeInBytes;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE.MemoryPoolL0Size"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MemoryPoolL0Size;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE.MemoryPoolL1Size"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MemoryPoolL1Size;
}
