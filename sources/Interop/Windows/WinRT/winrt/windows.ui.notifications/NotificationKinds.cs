// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='NotificationKinds.xml' path='doc/member[@name="NotificationKinds"]/*' />
[NativeTypeName("unsigned int")]
public enum NotificationKinds : uint
{
    /// <include file='NotificationKinds.xml' path='doc/member[@name="NotificationKinds.NotificationKinds_Unknown"]/*' />
    NotificationKinds_Unknown = 0,

    /// <include file='NotificationKinds.xml' path='doc/member[@name="NotificationKinds.NotificationKinds_Toast"]/*' />
    NotificationKinds_Toast = 0x1,
}
