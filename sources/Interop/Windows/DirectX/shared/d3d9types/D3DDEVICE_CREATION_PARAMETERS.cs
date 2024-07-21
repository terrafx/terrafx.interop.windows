// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3DDEVICE_CREATION_PARAMETERS.xml' path='doc/member[@name="D3DDEVICE_CREATION_PARAMETERS"]/*' />
public partial struct D3DDEVICE_CREATION_PARAMETERS
{
    /// <include file='D3DDEVICE_CREATION_PARAMETERS.xml' path='doc/member[@name="D3DDEVICE_CREATION_PARAMETERS.AdapterOrdinal"]/*' />
    public uint AdapterOrdinal;

    /// <include file='D3DDEVICE_CREATION_PARAMETERS.xml' path='doc/member[@name="D3DDEVICE_CREATION_PARAMETERS.DeviceType"]/*' />
    public D3DDEVTYPE DeviceType;

    /// <include file='D3DDEVICE_CREATION_PARAMETERS.xml' path='doc/member[@name="D3DDEVICE_CREATION_PARAMETERS.hFocusWindow"]/*' />
    public HWND hFocusWindow;

    /// <include file='D3DDEVICE_CREATION_PARAMETERS.xml' path='doc/member[@name="D3DDEVICE_CREATION_PARAMETERS.BehaviorFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint BehaviorFlags;
}
