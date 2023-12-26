// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BadgeTemplateType.xml' path='doc/member[@name="BadgeTemplateType"]/*' />
public enum BadgeTemplateType
{
    /// <include file='BadgeTemplateType.xml' path='doc/member[@name="BadgeTemplateType.BadgeTemplateType_BadgeGlyph"]/*' />
    BadgeTemplateType_BadgeGlyph = 0,

    /// <include file='BadgeTemplateType.xml' path='doc/member[@name="BadgeTemplateType.BadgeTemplateType_BadgeNumber"]/*' />
    BadgeTemplateType_BadgeNumber = 1,
}
