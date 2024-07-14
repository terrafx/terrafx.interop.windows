// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MF_DXGI_DEVICE_MANAGER_MODE.xml' path='doc/member[@name="MF_DXGI_DEVICE_MANAGER_MODE"]/*' />
public enum MF_DXGI_DEVICE_MANAGER_MODE
{
    /// <include file='MF_DXGI_DEVICE_MANAGER_MODE.xml' path='doc/member[@name="MF_DXGI_DEVICE_MANAGER_MODE.MF_DXGI_DEVICE_MANAGER_MODE_INVALID"]/*' />
    MF_DXGI_DEVICE_MANAGER_MODE_INVALID = 0,

    /// <include file='MF_DXGI_DEVICE_MANAGER_MODE.xml' path='doc/member[@name="MF_DXGI_DEVICE_MANAGER_MODE.MF_DXGI_DEVICE_MANAGER_MODE_D3D11"]/*' />
    MF_DXGI_DEVICE_MANAGER_MODE_D3D11 = (MF_DXGI_DEVICE_MANAGER_MODE_INVALID + 1),

    /// <include file='MF_DXGI_DEVICE_MANAGER_MODE.xml' path='doc/member[@name="MF_DXGI_DEVICE_MANAGER_MODE.MF_DXGI_DEVICE_MANAGER_MODE_D3D12"]/*' />
    MF_DXGI_DEVICE_MANAGER_MODE_D3D12 = (MF_DXGI_DEVICE_MANAGER_MODE_D3D11 + 1),
}
