// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_EXPORT_DESC.xml' path='doc/member[@name="D3D12_EXPORT_DESC"]/*' />
public unsafe partial struct D3D12_EXPORT_DESC
{
    /// <include file='D3D12_EXPORT_DESC.xml' path='doc/member[@name="D3D12_EXPORT_DESC.Name"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* Name;

    /// <include file='D3D12_EXPORT_DESC.xml' path='doc/member[@name="D3D12_EXPORT_DESC.ExportToRename"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* ExportToRename;

    /// <include file='D3D12_EXPORT_DESC.xml' path='doc/member[@name="D3D12_EXPORT_DESC.Flags"]/*' />
    public D3D12_EXPORT_FLAGS Flags;
}
