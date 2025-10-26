// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_APPLICATION_SPECIFIC_DRIVER_STATE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_APPLICATION_SPECIFIC_DRIVER_STATE"]/*' />
public partial struct D3D12_FEATURE_DATA_APPLICATION_SPECIFIC_DRIVER_STATE
{
    /// <include file='D3D12_FEATURE_DATA_APPLICATION_SPECIFIC_DRIVER_STATE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_APPLICATION_SPECIFIC_DRIVER_STATE.Supported"]/*' />
    public BOOL Supported;
}
