// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ToastNotificationMode.xml' path='doc/member[@name="ToastNotificationMode"]/*' />
public enum ToastNotificationMode
{
    /// <include file='ToastNotificationMode.xml' path='doc/member[@name="ToastNotificationMode.ToastNotificationMode_Unrestricted"]/*' />
    ToastNotificationMode_Unrestricted = 0,

    /// <include file='ToastNotificationMode.xml' path='doc/member[@name="ToastNotificationMode.ToastNotificationMode_PriorityOnly"]/*' />
    ToastNotificationMode_PriorityOnly = 1,

    /// <include file='ToastNotificationMode.xml' path='doc/member[@name="ToastNotificationMode.ToastNotificationMode_AlarmsOnly"]/*' />
    ToastNotificationMode_AlarmsOnly = 2,
}
