// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CoreInputViewKind.xml' path='doc/member[@name="CoreInputViewKind"]/*' />
public enum CoreInputViewKind
{
    /// <include file='CoreInputViewKind.xml' path='doc/member[@name="CoreInputViewKind.CoreInputViewKind_Default"]/*' />
    CoreInputViewKind_Default = 0,

    /// <include file='CoreInputViewKind.xml' path='doc/member[@name="CoreInputViewKind.CoreInputViewKind_Keyboard"]/*' />
    CoreInputViewKind_Keyboard = 1,

    /// <include file='CoreInputViewKind.xml' path='doc/member[@name="CoreInputViewKind.CoreInputViewKind_Handwriting"]/*' />
    CoreInputViewKind_Handwriting = 2,

    /// <include file='CoreInputViewKind.xml' path='doc/member[@name="CoreInputViewKind.CoreInputViewKind_Emoji"]/*' />
    CoreInputViewKind_Emoji = 3,

    /// <include file='CoreInputViewKind.xml' path='doc/member[@name="CoreInputViewKind.CoreInputViewKind_Symbols"]/*' />
    CoreInputViewKind_Symbols = 4,

    /// <include file='CoreInputViewKind.xml' path='doc/member[@name="CoreInputViewKind.CoreInputViewKind_Clipboard"]/*' />
    CoreInputViewKind_Clipboard = 5,

    /// <include file='CoreInputViewKind.xml' path='doc/member[@name="CoreInputViewKind.CoreInputViewKind_Dictation"]/*' />
    CoreInputViewKind_Dictation = 6,
}
