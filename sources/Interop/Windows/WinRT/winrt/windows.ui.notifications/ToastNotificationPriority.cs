// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ToastNotificationPriority.xml' path='doc/member[@name="ToastNotificationPriority"]/*' />
public enum ToastNotificationPriority
{
    /// <include file='ToastNotificationPriority.xml' path='doc/member[@name="ToastNotificationPriority.ToastNotificationPriority_Default"]/*' />
    ToastNotificationPriority_Default = 0,

    /// <include file='ToastNotificationPriority.xml' path='doc/member[@name="ToastNotificationPriority.ToastNotificationPriority_High"]/*' />
    ToastNotificationPriority_High = 1,
}
