// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GattSharingMode.xml' path='doc/member[@name="GattSharingMode"]/*' />
public enum GattSharingMode
{
    /// <include file='GattSharingMode.xml' path='doc/member[@name="GattSharingMode.GattSharingMode_Unspecified"]/*' />
    GattSharingMode_Unspecified = 0,

    /// <include file='GattSharingMode.xml' path='doc/member[@name="GattSharingMode.GattSharingMode_Exclusive"]/*' />
    GattSharingMode_Exclusive = 1,

    /// <include file='GattSharingMode.xml' path='doc/member[@name="GattSharingMode.GattSharingMode_SharedReadOnly"]/*' />
    GattSharingMode_SharedReadOnly = 2,

    /// <include file='GattSharingMode.xml' path='doc/member[@name="GattSharingMode.GattSharingMode_SharedReadAndWrite"]/*' />
    GattSharingMode_SharedReadAndWrite = 3,
}
