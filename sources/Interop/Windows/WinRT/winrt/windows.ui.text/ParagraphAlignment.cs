// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ParagraphAlignment.xml' path='doc/member[@name="ParagraphAlignment"]/*' />
public enum ParagraphAlignment
{
    /// <include file='ParagraphAlignment.xml' path='doc/member[@name="ParagraphAlignment.ParagraphAlignment_Undefined"]/*' />
    ParagraphAlignment_Undefined = 0,

    /// <include file='ParagraphAlignment.xml' path='doc/member[@name="ParagraphAlignment.ParagraphAlignment_Left"]/*' />
    ParagraphAlignment_Left = 1,

    /// <include file='ParagraphAlignment.xml' path='doc/member[@name="ParagraphAlignment.ParagraphAlignment_Center"]/*' />
    ParagraphAlignment_Center = 2,

    /// <include file='ParagraphAlignment.xml' path='doc/member[@name="ParagraphAlignment.ParagraphAlignment_Right"]/*' />
    ParagraphAlignment_Right = 3,

    /// <include file='ParagraphAlignment.xml' path='doc/member[@name="ParagraphAlignment.ParagraphAlignment_Justify"]/*' />
    ParagraphAlignment_Justify = 4,
}
