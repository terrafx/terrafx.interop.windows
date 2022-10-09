// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE"]/*' />
public enum D3D12_COMMAND_LIST_TYPE
{
    /// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE.D3D12_COMMAND_LIST_TYPE_DIRECT"]/*' />
    D3D12_COMMAND_LIST_TYPE_DIRECT = 0,

    /// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE.D3D12_COMMAND_LIST_TYPE_BUNDLE"]/*' />
    D3D12_COMMAND_LIST_TYPE_BUNDLE = 1,

    /// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE.D3D12_COMMAND_LIST_TYPE_COMPUTE"]/*' />
    D3D12_COMMAND_LIST_TYPE_COMPUTE = 2,

    /// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE.D3D12_COMMAND_LIST_TYPE_COPY"]/*' />
    D3D12_COMMAND_LIST_TYPE_COPY = 3,

    /// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE.D3D12_COMMAND_LIST_TYPE_VIDEO_DECODE"]/*' />
    D3D12_COMMAND_LIST_TYPE_VIDEO_DECODE = 4,

    /// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE.D3D12_COMMAND_LIST_TYPE_VIDEO_PROCESS"]/*' />
    D3D12_COMMAND_LIST_TYPE_VIDEO_PROCESS = 5,

    /// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE.D3D12_COMMAND_LIST_TYPE_VIDEO_ENCODE"]/*' />
    D3D12_COMMAND_LIST_TYPE_VIDEO_ENCODE = 6,
}
