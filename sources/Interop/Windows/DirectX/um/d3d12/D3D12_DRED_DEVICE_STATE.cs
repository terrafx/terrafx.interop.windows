// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DRED_DEVICE_STATE.xml' path='doc/member[@name="D3D12_DRED_DEVICE_STATE"]/*' />
public enum D3D12_DRED_DEVICE_STATE
{
    /// <include file='D3D12_DRED_DEVICE_STATE.xml' path='doc/member[@name="D3D12_DRED_DEVICE_STATE.D3D12_DRED_DEVICE_STATE_UNKNOWN"]/*' />
    D3D12_DRED_DEVICE_STATE_UNKNOWN = 0,

    /// <include file='D3D12_DRED_DEVICE_STATE.xml' path='doc/member[@name="D3D12_DRED_DEVICE_STATE.D3D12_DRED_DEVICE_STATE_HUNG"]/*' />
    D3D12_DRED_DEVICE_STATE_HUNG = 3,

    /// <include file='D3D12_DRED_DEVICE_STATE.xml' path='doc/member[@name="D3D12_DRED_DEVICE_STATE.D3D12_DRED_DEVICE_STATE_FAULT"]/*' />
    D3D12_DRED_DEVICE_STATE_FAULT = 6,

    /// <include file='D3D12_DRED_DEVICE_STATE.xml' path='doc/member[@name="D3D12_DRED_DEVICE_STATE.D3D12_DRED_DEVICE_STATE_PAGEFAULT"]/*' />
    D3D12_DRED_DEVICE_STATE_PAGEFAULT = 7,
}
