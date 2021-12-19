// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DRAW_ARGUMENTS.xml' path='doc/member[@name="D3D12_DRAW_ARGUMENTS"]/*' />
public partial struct D3D12_DRAW_ARGUMENTS
{
    /// <include file='D3D12_DRAW_ARGUMENTS.xml' path='doc/member[@name="D3D12_DRAW_ARGUMENTS.VertexCountPerInstance"]/*' />
    public uint VertexCountPerInstance;

    /// <include file='D3D12_DRAW_ARGUMENTS.xml' path='doc/member[@name="D3D12_DRAW_ARGUMENTS.InstanceCount"]/*' />
    public uint InstanceCount;

    /// <include file='D3D12_DRAW_ARGUMENTS.xml' path='doc/member[@name="D3D12_DRAW_ARGUMENTS.StartVertexLocation"]/*' />
    public uint StartVertexLocation;

    /// <include file='D3D12_DRAW_ARGUMENTS.xml' path='doc/member[@name="D3D12_DRAW_ARGUMENTS.StartInstanceLocation"]/*' />
    public uint StartInstanceLocation;
}
