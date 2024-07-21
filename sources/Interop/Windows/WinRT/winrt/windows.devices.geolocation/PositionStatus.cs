// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PositionStatus.xml' path='doc/member[@name="PositionStatus"]/*' />
public enum PositionStatus
{
    /// <include file='PositionStatus.xml' path='doc/member[@name="PositionStatus.PositionStatus_Ready"]/*' />
    PositionStatus_Ready = 0,

    /// <include file='PositionStatus.xml' path='doc/member[@name="PositionStatus.PositionStatus_Initializing"]/*' />
    PositionStatus_Initializing = 1,

    /// <include file='PositionStatus.xml' path='doc/member[@name="PositionStatus.PositionStatus_NoData"]/*' />
    PositionStatus_NoData = 2,

    /// <include file='PositionStatus.xml' path='doc/member[@name="PositionStatus.PositionStatus_Disabled"]/*' />
    PositionStatus_Disabled = 3,

    /// <include file='PositionStatus.xml' path='doc/member[@name="PositionStatus.PositionStatus_NotInitialized"]/*' />
    PositionStatus_NotInitialized = 4,

    /// <include file='PositionStatus.xml' path='doc/member[@name="PositionStatus.PositionStatus_NotAvailable"]/*' />
    PositionStatus_NotAvailable = 5,
}
