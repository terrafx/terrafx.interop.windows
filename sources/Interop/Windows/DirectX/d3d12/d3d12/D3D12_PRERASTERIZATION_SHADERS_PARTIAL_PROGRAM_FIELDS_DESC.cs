// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_PRERASTERIZATION_SHADERS_PARTIAL_PROGRAM_FIELDS_DESC.xml' path='doc/member[@name="D3D12_PRERASTERIZATION_SHADERS_PARTIAL_PROGRAM_FIELDS_DESC"]/*' />
public partial struct D3D12_PRERASTERIZATION_SHADERS_PARTIAL_PROGRAM_FIELDS_DESC
{
    /// <include file='D3D12_PRERASTERIZATION_SHADERS_PARTIAL_PROGRAM_FIELDS_DESC.xml' path='doc/member[@name="D3D12_PRERASTERIZATION_SHADERS_PARTIAL_PROGRAM_FIELDS_DESC.ExcludePS"]/*' />
    public BOOL ExcludePS;

    /// <include file='D3D12_PRERASTERIZATION_SHADERS_PARTIAL_PROGRAM_FIELDS_DESC.xml' path='doc/member[@name="D3D12_PRERASTERIZATION_SHADERS_PARTIAL_PROGRAM_FIELDS_DESC.LateLinkInputLayoutSubobject"]/*' />
    public BOOL LateLinkInputLayoutSubobject;
}
