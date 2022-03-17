// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DRED_ALLOCATION_NODE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE"]/*' />
public unsafe partial struct D3D12_DRED_ALLOCATION_NODE
{
    /// <include file='D3D12_DRED_ALLOCATION_NODE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE.ObjectNameA"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* ObjectNameA;

    /// <include file='D3D12_DRED_ALLOCATION_NODE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE.ObjectNameW"]/*' />
    [NativeTypeName("const wchar_t *")]
    public ushort* ObjectNameW;

    /// <include file='D3D12_DRED_ALLOCATION_NODE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE.AllocationType"]/*' />
    public D3D12_DRED_ALLOCATION_TYPE AllocationType;

    /// <include file='D3D12_DRED_ALLOCATION_NODE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE.pNext"]/*' />
    [NativeTypeName("const struct D3D12_DRED_ALLOCATION_NODE *")]
    public D3D12_DRED_ALLOCATION_NODE* pNext;
}
