// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.619.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_REGISTER_TRIM_NOTIFICATION.xml' path='doc/member[@name="D3D12_REGISTER_TRIM_NOTIFICATION"]/*' />
public unsafe partial struct D3D12_REGISTER_TRIM_NOTIFICATION
{
    /// <include file='D3D12_REGISTER_TRIM_NOTIFICATION.xml' path='doc/member[@name="D3D12_REGISTER_TRIM_NOTIFICATION.pfnCallback"]/*' />
    [NativeTypeName("D3D12_PFN_TRIM_NOTIFICATION_CALLBACK")]
    public delegate* unmanaged<D3D12_TRIM_NOTIFICATION*, void> pfnCallback;

    /// <include file='D3D12_REGISTER_TRIM_NOTIFICATION.xml' path='doc/member[@name="D3D12_REGISTER_TRIM_NOTIFICATION.pContext"]/*' />
    public void* pContext;

    /// <include file='D3D12_REGISTER_TRIM_NOTIFICATION.xml' path='doc/member[@name="D3D12_REGISTER_TRIM_NOTIFICATION.CallbackCookie"]/*' />
    [NativeTypeName("DWORD")]
    public uint CallbackCookie;
}
