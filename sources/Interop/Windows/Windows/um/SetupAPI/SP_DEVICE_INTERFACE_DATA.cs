// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='SP_DEVICE_INTERFACE_DATA.xml' path='doc/member[@name="SP_DEVICE_INTERFACE_DATA"]/*' />
public partial struct SP_DEVICE_INTERFACE_DATA
{
    /// <include file='SP_DEVICE_INTERFACE_DATA.xml' path='doc/member[@name="SP_DEVICE_INTERFACE_DATA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_DEVICE_INTERFACE_DATA.xml' path='doc/member[@name="SP_DEVICE_INTERFACE_DATA.InterfaceClassGuid"]/*' />
    public Guid InterfaceClassGuid;

    /// <include file='SP_DEVICE_INTERFACE_DATA.xml' path='doc/member[@name="SP_DEVICE_INTERFACE_DATA.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='SP_DEVICE_INTERFACE_DATA.xml' path='doc/member[@name="SP_DEVICE_INTERFACE_DATA.Reserved"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint Reserved;
}
