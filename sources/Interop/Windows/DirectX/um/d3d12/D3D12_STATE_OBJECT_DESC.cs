// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_STATE_OBJECT_DESC.xml' path='doc/member[@name="D3D12_STATE_OBJECT_DESC"]/*' />
public unsafe partial struct D3D12_STATE_OBJECT_DESC
{
    /// <include file='D3D12_STATE_OBJECT_DESC.xml' path='doc/member[@name="D3D12_STATE_OBJECT_DESC.Type"]/*' />
    public D3D12_STATE_OBJECT_TYPE Type;

    /// <include file='D3D12_STATE_OBJECT_DESC.xml' path='doc/member[@name="D3D12_STATE_OBJECT_DESC.NumSubobjects"]/*' />
    public uint NumSubobjects;

    /// <include file='D3D12_STATE_OBJECT_DESC.xml' path='doc/member[@name="D3D12_STATE_OBJECT_DESC.pSubobjects"]/*' />
    [NativeTypeName("const D3D12_STATE_SUBOBJECT *")]
    public D3D12_STATE_SUBOBJECT* pSubobjects;
}
