// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ToastDismissalReason.xml' path='doc/member[@name="ToastDismissalReason"]/*' />
public enum ToastDismissalReason
{
    /// <include file='ToastDismissalReason.xml' path='doc/member[@name="ToastDismissalReason.ToastDismissalReason_UserCanceled"]/*' />
    ToastDismissalReason_UserCanceled = 0,

    /// <include file='ToastDismissalReason.xml' path='doc/member[@name="ToastDismissalReason.ToastDismissalReason_ApplicationHidden"]/*' />
    ToastDismissalReason_ApplicationHidden = 1,

    /// <include file='ToastDismissalReason.xml' path='doc/member[@name="ToastDismissalReason.ToastDismissalReason_TimedOut"]/*' />
    ToastDismissalReason_TimedOut = 2,
}
