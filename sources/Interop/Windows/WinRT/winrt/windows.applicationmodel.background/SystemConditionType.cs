// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SystemConditionType.xml' path='doc/member[@name="SystemConditionType"]/*' />
public enum SystemConditionType
{
    /// <include file='SystemConditionType.xml' path='doc/member[@name="SystemConditionType.SystemConditionType_Invalid"]/*' />
    SystemConditionType_Invalid = 0,

    /// <include file='SystemConditionType.xml' path='doc/member[@name="SystemConditionType.SystemConditionType_UserPresent"]/*' />
    SystemConditionType_UserPresent = 1,

    /// <include file='SystemConditionType.xml' path='doc/member[@name="SystemConditionType.SystemConditionType_UserNotPresent"]/*' />
    SystemConditionType_UserNotPresent = 2,

    /// <include file='SystemConditionType.xml' path='doc/member[@name="SystemConditionType.SystemConditionType_InternetAvailable"]/*' />
    SystemConditionType_InternetAvailable = 3,

    /// <include file='SystemConditionType.xml' path='doc/member[@name="SystemConditionType.SystemConditionType_InternetNotAvailable"]/*' />
    SystemConditionType_InternetNotAvailable = 4,

    /// <include file='SystemConditionType.xml' path='doc/member[@name="SystemConditionType.SystemConditionType_SessionConnected"]/*' />
    SystemConditionType_SessionConnected = 5,

    /// <include file='SystemConditionType.xml' path='doc/member[@name="SystemConditionType.SystemConditionType_SessionDisconnected"]/*' />
    SystemConditionType_SessionDisconnected = 6,

    /// <include file='SystemConditionType.xml' path='doc/member[@name="SystemConditionType.SystemConditionType_FreeNetworkAvailable"]/*' />
    SystemConditionType_FreeNetworkAvailable = 7,

    /// <include file='SystemConditionType.xml' path='doc/member[@name="SystemConditionType.SystemConditionType_BackgroundWorkCostNotHigh"]/*' />
    SystemConditionType_BackgroundWorkCostNotHigh = 8,
}
