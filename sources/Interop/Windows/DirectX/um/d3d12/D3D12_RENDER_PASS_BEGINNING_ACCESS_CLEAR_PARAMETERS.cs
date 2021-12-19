// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS"]/*' />
public partial struct D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS
{
    /// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS.ClearValue"]/*' />
    public D3D12_CLEAR_VALUE ClearValue;
}
