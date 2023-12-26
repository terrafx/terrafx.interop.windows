// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FontStretch.xml' path='doc/member[@name="FontStretch"]/*' />
public enum FontStretch
{
    /// <include file='FontStretch.xml' path='doc/member[@name="FontStretch.FontStretch_Undefined"]/*' />
    FontStretch_Undefined = 0,

    /// <include file='FontStretch.xml' path='doc/member[@name="FontStretch.FontStretch_UltraCondensed"]/*' />
    FontStretch_UltraCondensed = 1,

    /// <include file='FontStretch.xml' path='doc/member[@name="FontStretch.FontStretch_ExtraCondensed"]/*' />
    FontStretch_ExtraCondensed = 2,

    /// <include file='FontStretch.xml' path='doc/member[@name="FontStretch.FontStretch_Condensed"]/*' />
    FontStretch_Condensed = 3,

    /// <include file='FontStretch.xml' path='doc/member[@name="FontStretch.FontStretch_SemiCondensed"]/*' />
    FontStretch_SemiCondensed = 4,

    /// <include file='FontStretch.xml' path='doc/member[@name="FontStretch.FontStretch_Normal"]/*' />
    FontStretch_Normal = 5,

    /// <include file='FontStretch.xml' path='doc/member[@name="FontStretch.FontStretch_SemiExpanded"]/*' />
    FontStretch_SemiExpanded = 6,

    /// <include file='FontStretch.xml' path='doc/member[@name="FontStretch.FontStretch_Expanded"]/*' />
    FontStretch_Expanded = 7,

    /// <include file='FontStretch.xml' path='doc/member[@name="FontStretch.FontStretch_ExtraExpanded"]/*' />
    FontStretch_ExtraExpanded = 8,

    /// <include file='FontStretch.xml' path='doc/member[@name="FontStretch.FontStretch_UltraExpanded"]/*' />
    FontStretch_UltraExpanded = 9,
}
