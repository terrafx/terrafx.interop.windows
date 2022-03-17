// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DRED_ENABLEMENT.xml' path='doc/member[@name="D3D12_DRED_ENABLEMENT"]/*' />
public enum D3D12_DRED_ENABLEMENT
{
    /// <include file='D3D12_DRED_ENABLEMENT.xml' path='doc/member[@name="D3D12_DRED_ENABLEMENT.D3D12_DRED_ENABLEMENT_SYSTEM_CONTROLLED"]/*' />
    D3D12_DRED_ENABLEMENT_SYSTEM_CONTROLLED = 0,

    /// <include file='D3D12_DRED_ENABLEMENT.xml' path='doc/member[@name="D3D12_DRED_ENABLEMENT.D3D12_DRED_ENABLEMENT_FORCED_OFF"]/*' />
    D3D12_DRED_ENABLEMENT_FORCED_OFF = 1,

    /// <include file='D3D12_DRED_ENABLEMENT.xml' path='doc/member[@name="D3D12_DRED_ENABLEMENT.D3D12_DRED_ENABLEMENT_FORCED_ON"]/*' />
    D3D12_DRED_ENABLEMENT_FORCED_ON = 2,
}
