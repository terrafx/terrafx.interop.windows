// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreRuntimeFilterFlags.xml' path='doc/member[@name="DXCoreRuntimeFilterFlags"]/*' />
[NativeTypeName("uint32_t")]
public enum DXCoreRuntimeFilterFlags : uint
{
    /// <include file='DXCoreRuntimeFilterFlags.xml' path='doc/member[@name="DXCoreRuntimeFilterFlags.None"]/*' />
    None = 0x0,

    /// <include file='DXCoreRuntimeFilterFlags.xml' path='doc/member[@name="DXCoreRuntimeFilterFlags.D3D11"]/*' />
    D3D11 = 0x1,

    /// <include file='DXCoreRuntimeFilterFlags.xml' path='doc/member[@name="DXCoreRuntimeFilterFlags.D3D12"]/*' />
    D3D12 = 0x2,
}
