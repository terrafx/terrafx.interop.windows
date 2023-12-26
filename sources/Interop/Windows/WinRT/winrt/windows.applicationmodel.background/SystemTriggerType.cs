// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType"]/*' />
public enum SystemTriggerType
{
    /// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType.SystemTriggerType_Invalid"]/*' />
    SystemTriggerType_Invalid = 0,

    /// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType.SystemTriggerType_SmsReceived"]/*' />
    SystemTriggerType_SmsReceived = 1,

    /// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType.SystemTriggerType_UserPresent"]/*' />
    SystemTriggerType_UserPresent = 2,

    /// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType.SystemTriggerType_UserAway"]/*' />
    SystemTriggerType_UserAway = 3,

    /// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType.SystemTriggerType_NetworkStateChange"]/*' />
    SystemTriggerType_NetworkStateChange = 4,

    /// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType.SystemTriggerType_ControlChannelReset"]/*' />
    SystemTriggerType_ControlChannelReset = 5,

    /// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType.SystemTriggerType_InternetAvailable"]/*' />
    SystemTriggerType_InternetAvailable = 6,

    /// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType.SystemTriggerType_SessionConnected"]/*' />
    SystemTriggerType_SessionConnected = 7,

    /// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType.SystemTriggerType_ServicingComplete"]/*' />
    SystemTriggerType_ServicingComplete = 8,

    /// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType.SystemTriggerType_LockScreenApplicationAdded"]/*' />
    SystemTriggerType_LockScreenApplicationAdded = 9,

    /// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType.SystemTriggerType_LockScreenApplicationRemoved"]/*' />
    SystemTriggerType_LockScreenApplicationRemoved = 10,

    /// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType.SystemTriggerType_TimeZoneChange"]/*' />
    SystemTriggerType_TimeZoneChange = 11,

    /// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType.SystemTriggerType_OnlineIdConnectedStateChange"]/*' />
    SystemTriggerType_OnlineIdConnectedStateChange = 12,

    /// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType.SystemTriggerType_BackgroundWorkCostChange"]/*' />
    SystemTriggerType_BackgroundWorkCostChange = 13,

    /// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType.SystemTriggerType_PowerStateChange"]/*' />
    SystemTriggerType_PowerStateChange = 14,

    /// <include file='SystemTriggerType.xml' path='doc/member[@name="SystemTriggerType.SystemTriggerType_DefaultSignInAccountChange"]/*' />
    SystemTriggerType_DefaultSignInAccountChange = 15,
}
