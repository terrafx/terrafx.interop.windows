// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmsBroadcastType.xml' path='doc/member[@name="SmsBroadcastType"]/*' />
public enum SmsBroadcastType
{
    /// <include file='SmsBroadcastType.xml' path='doc/member[@name="SmsBroadcastType.SmsBroadcastType_Other"]/*' />
    SmsBroadcastType_Other = 0,

    /// <include file='SmsBroadcastType.xml' path='doc/member[@name="SmsBroadcastType.SmsBroadcastType_CmasPresidential"]/*' />
    SmsBroadcastType_CmasPresidential = 1,

    /// <include file='SmsBroadcastType.xml' path='doc/member[@name="SmsBroadcastType.SmsBroadcastType_CmasExtreme"]/*' />
    SmsBroadcastType_CmasExtreme = 2,

    /// <include file='SmsBroadcastType.xml' path='doc/member[@name="SmsBroadcastType.SmsBroadcastType_CmasSevere"]/*' />
    SmsBroadcastType_CmasSevere = 3,

    /// <include file='SmsBroadcastType.xml' path='doc/member[@name="SmsBroadcastType.SmsBroadcastType_CmasAmber"]/*' />
    SmsBroadcastType_CmasAmber = 4,

    /// <include file='SmsBroadcastType.xml' path='doc/member[@name="SmsBroadcastType.SmsBroadcastType_CmasTest"]/*' />
    SmsBroadcastType_CmasTest = 5,

    /// <include file='SmsBroadcastType.xml' path='doc/member[@name="SmsBroadcastType.SmsBroadcastType_EUAlert1"]/*' />
    SmsBroadcastType_EUAlert1 = 6,

    /// <include file='SmsBroadcastType.xml' path='doc/member[@name="SmsBroadcastType.SmsBroadcastType_EUAlert2"]/*' />
    SmsBroadcastType_EUAlert2 = 7,

    /// <include file='SmsBroadcastType.xml' path='doc/member[@name="SmsBroadcastType.SmsBroadcastType_EUAlert3"]/*' />
    SmsBroadcastType_EUAlert3 = 8,

    /// <include file='SmsBroadcastType.xml' path='doc/member[@name="SmsBroadcastType.SmsBroadcastType_EUAlertAmber"]/*' />
    SmsBroadcastType_EUAlertAmber = 9,

    /// <include file='SmsBroadcastType.xml' path='doc/member[@name="SmsBroadcastType.SmsBroadcastType_EUAlertInfo"]/*' />
    SmsBroadcastType_EUAlertInfo = 10,

    /// <include file='SmsBroadcastType.xml' path='doc/member[@name="SmsBroadcastType.SmsBroadcastType_EtwsEarthquake"]/*' />
    SmsBroadcastType_EtwsEarthquake = 11,

    /// <include file='SmsBroadcastType.xml' path='doc/member[@name="SmsBroadcastType.SmsBroadcastType_EtwsTsunami"]/*' />
    SmsBroadcastType_EtwsTsunami = 12,

    /// <include file='SmsBroadcastType.xml' path='doc/member[@name="SmsBroadcastType.SmsBroadcastType_EtwsTsunamiAndEarthquake"]/*' />
    SmsBroadcastType_EtwsTsunamiAndEarthquake = 13,

    /// <include file='SmsBroadcastType.xml' path='doc/member[@name="SmsBroadcastType.SmsBroadcastType_LatAlertLocal"]/*' />
    SmsBroadcastType_LatAlertLocal = 14,
}
