// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_AXIS_SHADING_RATE.xml' path='doc/member[@name="D3D12_AXIS_SHADING_RATE"]/*' />
public enum D3D12_AXIS_SHADING_RATE
{
    /// <include file='D3D12_AXIS_SHADING_RATE.xml' path='doc/member[@name="D3D12_AXIS_SHADING_RATE.D3D12_AXIS_SHADING_RATE_1X"]/*' />
    D3D12_AXIS_SHADING_RATE_1X = 0,

    /// <include file='D3D12_AXIS_SHADING_RATE.xml' path='doc/member[@name="D3D12_AXIS_SHADING_RATE.D3D12_AXIS_SHADING_RATE_2X"]/*' />
    D3D12_AXIS_SHADING_RATE_2X = 0x1,

    /// <include file='D3D12_AXIS_SHADING_RATE.xml' path='doc/member[@name="D3D12_AXIS_SHADING_RATE.D3D12_AXIS_SHADING_RATE_4X"]/*' />
    D3D12_AXIS_SHADING_RATE_4X = 0x2,
}
