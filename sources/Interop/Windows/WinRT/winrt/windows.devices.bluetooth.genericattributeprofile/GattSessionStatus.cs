// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GattSessionStatus.xml' path='doc/member[@name="GattSessionStatus"]/*' />
public enum GattSessionStatus
{
    /// <include file='GattSessionStatus.xml' path='doc/member[@name="GattSessionStatus.GattSessionStatus_Closed"]/*' />
    GattSessionStatus_Closed = 0,

    /// <include file='GattSessionStatus.xml' path='doc/member[@name="GattSessionStatus.GattSessionStatus_Active"]/*' />
    GattSessionStatus_Active = 1,
}
