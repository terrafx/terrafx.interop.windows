// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='NotificationUpdateResult.xml' path='doc/member[@name="NotificationUpdateResult"]/*' />
public enum NotificationUpdateResult
{
    /// <include file='NotificationUpdateResult.xml' path='doc/member[@name="NotificationUpdateResult.NotificationUpdateResult_Succeeded"]/*' />
    NotificationUpdateResult_Succeeded = 0,

    /// <include file='NotificationUpdateResult.xml' path='doc/member[@name="NotificationUpdateResult.NotificationUpdateResult_Failed"]/*' />
    NotificationUpdateResult_Failed = 1,

    /// <include file='NotificationUpdateResult.xml' path='doc/member[@name="NotificationUpdateResult.NotificationUpdateResult_NotificationNotFound"]/*' />
    NotificationUpdateResult_NotificationNotFound = 2,
}
