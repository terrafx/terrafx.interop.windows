// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CoreTextRange.xml' path='doc/member[@name="CoreTextRange"]/*' />
public partial struct CoreTextRange
{
    /// <include file='CoreTextRange.xml' path='doc/member[@name="CoreTextRange.StartCaretPosition"]/*' />
    [NativeTypeName("INT32")]
    public int StartCaretPosition;

    /// <include file='CoreTextRange.xml' path='doc/member[@name="CoreTextRange.EndCaretPosition"]/*' />
    [NativeTypeName("INT32")]
    public int EndCaretPosition;
}
