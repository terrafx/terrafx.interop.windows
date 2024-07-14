// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TextDecorations.xml' path='doc/member[@name="TextDecorations"]/*' />
[NativeTypeName("unsigned int")]
public enum TextDecorations : uint
{
    /// <include file='TextDecorations.xml' path='doc/member[@name="TextDecorations.TextDecorations_None"]/*' />
    TextDecorations_None = 0,

    /// <include file='TextDecorations.xml' path='doc/member[@name="TextDecorations.TextDecorations_Underline"]/*' />
    TextDecorations_Underline = 0x1,

    /// <include file='TextDecorations.xml' path='doc/member[@name="TextDecorations.TextDecorations_Strikethrough"]/*' />
    TextDecorations_Strikethrough = 0x2,
}
