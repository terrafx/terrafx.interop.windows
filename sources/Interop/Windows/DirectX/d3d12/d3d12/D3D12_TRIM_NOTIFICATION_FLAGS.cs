// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.619.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TRIM_NOTIFICATION_FLAGS.xml' path='doc/member[@name="D3D12_TRIM_NOTIFICATION_FLAGS"]/*' />
public enum D3D12_TRIM_NOTIFICATION_FLAGS
{
    /// <include file='D3D12_TRIM_NOTIFICATION_FLAGS.xml' path='doc/member[@name="D3D12_TRIM_NOTIFICATION_FLAGS.D3D12_TRIM_NOTIFICATION_FLAG_NONE"]/*' />
    D3D12_TRIM_NOTIFICATION_FLAG_NONE = 0,

    /// <include file='D3D12_TRIM_NOTIFICATION_FLAGS.xml' path='doc/member[@name="D3D12_TRIM_NOTIFICATION_FLAGS.D3D12_TRIM_NOTIFICATION_FLAG_PERIODIC_TRIM"]/*' />
    D3D12_TRIM_NOTIFICATION_FLAG_PERIODIC_TRIM = 0x1,

    /// <include file='D3D12_TRIM_NOTIFICATION_FLAGS.xml' path='doc/member[@name="D3D12_TRIM_NOTIFICATION_FLAGS.D3D12_TRIM_NOTIFICATION_FLAG_RESTART_PERIODIC_TRIM"]/*' />
    D3D12_TRIM_NOTIFICATION_FLAG_RESTART_PERIODIC_TRIM = 0x2,

    /// <include file='D3D12_TRIM_NOTIFICATION_FLAGS.xml' path='doc/member[@name="D3D12_TRIM_NOTIFICATION_FLAGS.D3D12_TRIM_NOTIFICATION_FLAG_TRIM_TO_BUDGET"]/*' />
    D3D12_TRIM_NOTIFICATION_FLAG_TRIM_TO_BUDGET = 0x4,
}
