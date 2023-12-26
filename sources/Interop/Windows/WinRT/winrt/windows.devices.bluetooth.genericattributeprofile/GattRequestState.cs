// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GattRequestState.xml' path='doc/member[@name="GattRequestState"]/*' />
public enum GattRequestState
{
    /// <include file='GattRequestState.xml' path='doc/member[@name="GattRequestState.GattRequestState_Pending"]/*' />
    GattRequestState_Pending = 0,

    /// <include file='GattRequestState.xml' path='doc/member[@name="GattRequestState.GattRequestState_Completed"]/*' />
    GattRequestState_Completed = 1,

    /// <include file='GattRequestState.xml' path='doc/member[@name="GattRequestState.GattRequestState_Canceled"]/*' />
    GattRequestState_Canceled = 2,
}
