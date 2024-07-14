// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='NotificationMirroring.xml' path='doc/member[@name="NotificationMirroring"]/*' />
public enum NotificationMirroring
{
    /// <include file='NotificationMirroring.xml' path='doc/member[@name="NotificationMirroring.NotificationMirroring_Allowed"]/*' />
    NotificationMirroring_Allowed = 0,

    /// <include file='NotificationMirroring.xml' path='doc/member[@name="NotificationMirroring.NotificationMirroring_Disabled"]/*' />
    NotificationMirroring_Disabled = 1,
}
