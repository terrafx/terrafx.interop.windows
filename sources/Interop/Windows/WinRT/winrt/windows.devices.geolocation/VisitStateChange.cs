// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VisitStateChange.xml' path='doc/member[@name="VisitStateChange"]/*' />
public enum VisitStateChange
{
    /// <include file='VisitStateChange.xml' path='doc/member[@name="VisitStateChange.VisitStateChange_TrackingLost"]/*' />
    VisitStateChange_TrackingLost = 0,

    /// <include file='VisitStateChange.xml' path='doc/member[@name="VisitStateChange.VisitStateChange_Arrived"]/*' />
    VisitStateChange_Arrived = 1,

    /// <include file='VisitStateChange.xml' path='doc/member[@name="VisitStateChange.VisitStateChange_Departed"]/*' />
    VisitStateChange_Departed = 2,

    /// <include file='VisitStateChange.xml' path='doc/member[@name="VisitStateChange.VisitStateChange_OtherMovement"]/*' />
    VisitStateChange_OtherMovement = 3,
}
