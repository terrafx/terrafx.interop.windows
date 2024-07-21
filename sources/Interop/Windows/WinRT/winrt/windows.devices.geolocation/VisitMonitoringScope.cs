// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VisitMonitoringScope.xml' path='doc/member[@name="VisitMonitoringScope"]/*' />
public enum VisitMonitoringScope
{
    /// <include file='VisitMonitoringScope.xml' path='doc/member[@name="VisitMonitoringScope.VisitMonitoringScope_Venue"]/*' />
    VisitMonitoringScope_Venue = 0,

    /// <include file='VisitMonitoringScope.xml' path='doc/member[@name="VisitMonitoringScope.VisitMonitoringScope_City"]/*' />
    VisitMonitoringScope_City = 1,
}
