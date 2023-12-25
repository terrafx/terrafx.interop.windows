// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TabAlignment.xml' path='doc/member[@name="TabAlignment"]/*' />
public enum TabAlignment
{
    /// <include file='TabAlignment.xml' path='doc/member[@name="TabAlignment.TabAlignment_Left"]/*' />
    TabAlignment_Left = 0,

    /// <include file='TabAlignment.xml' path='doc/member[@name="TabAlignment.TabAlignment_Center"]/*' />
    TabAlignment_Center = 1,

    /// <include file='TabAlignment.xml' path='doc/member[@name="TabAlignment.TabAlignment_Right"]/*' />
    TabAlignment_Right = 2,

    /// <include file='TabAlignment.xml' path='doc/member[@name="TabAlignment.TabAlignment_Decimal"]/*' />
    TabAlignment_Decimal = 3,

    /// <include file='TabAlignment.xml' path='doc/member[@name="TabAlignment.TabAlignment_Bar"]/*' />
    TabAlignment_Bar = 4,
}
