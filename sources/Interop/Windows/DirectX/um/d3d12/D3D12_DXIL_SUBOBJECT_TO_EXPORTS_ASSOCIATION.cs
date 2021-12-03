// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION.xml' path='doc/member[@name="D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION"]/*' />
public unsafe partial struct D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION
{
    /// <include file='D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION.xml' path='doc/member[@name="D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION.SubobjectToAssociate"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* SubobjectToAssociate;

    /// <include file='D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION.xml' path='doc/member[@name="D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION.NumExports"]/*' />
    public uint NumExports;

    /// <include file='D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION.xml' path='doc/member[@name="D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION.pExports"]/*' />
    [NativeTypeName("LPCWSTR *")]
    public ushort** pExports;
}
