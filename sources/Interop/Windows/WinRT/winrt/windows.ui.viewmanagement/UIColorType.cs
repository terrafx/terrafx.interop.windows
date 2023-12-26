// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UIColorType.xml' path='doc/member[@name="UIColorType"]/*' />
public enum UIColorType
{
    /// <include file='UIColorType.xml' path='doc/member[@name="UIColorType.UIColorType_Background"]/*' />
    UIColorType_Background = 0,

    /// <include file='UIColorType.xml' path='doc/member[@name="UIColorType.UIColorType_Foreground"]/*' />
    UIColorType_Foreground = 1,

    /// <include file='UIColorType.xml' path='doc/member[@name="UIColorType.UIColorType_AccentDark3"]/*' />
    UIColorType_AccentDark3 = 2,

    /// <include file='UIColorType.xml' path='doc/member[@name="UIColorType.UIColorType_AccentDark2"]/*' />
    UIColorType_AccentDark2 = 3,

    /// <include file='UIColorType.xml' path='doc/member[@name="UIColorType.UIColorType_AccentDark1"]/*' />
    UIColorType_AccentDark1 = 4,

    /// <include file='UIColorType.xml' path='doc/member[@name="UIColorType.UIColorType_Accent"]/*' />
    UIColorType_Accent = 5,

    /// <include file='UIColorType.xml' path='doc/member[@name="UIColorType.UIColorType_AccentLight1"]/*' />
    UIColorType_AccentLight1 = 6,

    /// <include file='UIColorType.xml' path='doc/member[@name="UIColorType.UIColorType_AccentLight2"]/*' />
    UIColorType_AccentLight2 = 7,

    /// <include file='UIColorType.xml' path='doc/member[@name="UIColorType.UIColorType_AccentLight3"]/*' />
    UIColorType_AccentLight3 = 8,

    /// <include file='UIColorType.xml' path='doc/member[@name="UIColorType.UIColorType_Complement"]/*' />
    UIColorType_Complement = 9,
}
