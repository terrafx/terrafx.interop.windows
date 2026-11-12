// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_PRERASTERIZATION_OUTPUT_LINKAGE_ELEMENT_DESC.xml' path='doc/member[@name="D3D12_PRERASTERIZATION_OUTPUT_LINKAGE_ELEMENT_DESC"]/*' />
public unsafe partial struct D3D12_PRERASTERIZATION_OUTPUT_LINKAGE_ELEMENT_DESC
{
    /// <include file='D3D12_PRERASTERIZATION_OUTPUT_LINKAGE_ELEMENT_DESC.xml' path='doc/member[@name="D3D12_PRERASTERIZATION_OUTPUT_LINKAGE_ELEMENT_DESC.SemanticName"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* SemanticName;

    /// <include file='D3D12_PRERASTERIZATION_OUTPUT_LINKAGE_ELEMENT_DESC.xml' path='doc/member[@name="D3D12_PRERASTERIZATION_OUTPUT_LINKAGE_ELEMENT_DESC.SemanticIndex"]/*' />
    public uint SemanticIndex;

    /// <include file='D3D12_PRERASTERIZATION_OUTPUT_LINKAGE_ELEMENT_DESC.xml' path='doc/member[@name="D3D12_PRERASTERIZATION_OUTPUT_LINKAGE_ELEMENT_DESC.StartComponent"]/*' />
    public byte StartComponent;

    /// <include file='D3D12_PRERASTERIZATION_OUTPUT_LINKAGE_ELEMENT_DESC.xml' path='doc/member[@name="D3D12_PRERASTERIZATION_OUTPUT_LINKAGE_ELEMENT_DESC.ComponentCount"]/*' />
    public byte ComponentCount;
}
