// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMMAND_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_COMMAND_SIGNATURE_DESC"]/*' />
public unsafe partial struct D3D12_COMMAND_SIGNATURE_DESC
{
    /// <include file='D3D12_COMMAND_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_COMMAND_SIGNATURE_DESC.ByteStride"]/*' />
    public uint ByteStride;

    /// <include file='D3D12_COMMAND_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_COMMAND_SIGNATURE_DESC.NumArgumentDescs"]/*' />
    public uint NumArgumentDescs;

    /// <include file='D3D12_COMMAND_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_COMMAND_SIGNATURE_DESC.pArgumentDescs"]/*' />
    [NativeTypeName("const D3D12_INDIRECT_ARGUMENT_DESC *")]
    public D3D12_INDIRECT_ARGUMENT_DESC* pArgumentDescs;

    /// <include file='D3D12_COMMAND_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_COMMAND_SIGNATURE_DESC.NodeMask"]/*' />
    public uint NodeMask;
}
