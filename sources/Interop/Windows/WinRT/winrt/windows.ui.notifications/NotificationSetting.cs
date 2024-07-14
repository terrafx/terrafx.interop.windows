// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='NotificationSetting.xml' path='doc/member[@name="NotificationSetting"]/*' />
public enum NotificationSetting
{
    /// <include file='NotificationSetting.xml' path='doc/member[@name="NotificationSetting.NotificationSetting_Enabled"]/*' />
    NotificationSetting_Enabled = 0,

    /// <include file='NotificationSetting.xml' path='doc/member[@name="NotificationSetting.NotificationSetting_DisabledForApplication"]/*' />
    NotificationSetting_DisabledForApplication = 1,

    /// <include file='NotificationSetting.xml' path='doc/member[@name="NotificationSetting.NotificationSetting_DisabledForUser"]/*' />
    NotificationSetting_DisabledForUser = 2,

    /// <include file='NotificationSetting.xml' path='doc/member[@name="NotificationSetting.NotificationSetting_DisabledByGroupPolicy"]/*' />
    NotificationSetting_DisabledByGroupPolicy = 3,

    /// <include file='NotificationSetting.xml' path='doc/member[@name="NotificationSetting.NotificationSetting_DisabledByManifest"]/*' />
    NotificationSetting_DisabledByManifest = 4,
}
