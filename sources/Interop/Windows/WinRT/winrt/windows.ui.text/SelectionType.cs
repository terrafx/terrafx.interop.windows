// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SelectionType.xml' path='doc/member[@name="SelectionType"]/*' />
public enum SelectionType
{
    /// <include file='SelectionType.xml' path='doc/member[@name="SelectionType.SelectionType_None"]/*' />
    SelectionType_None = 0,

    /// <include file='SelectionType.xml' path='doc/member[@name="SelectionType.SelectionType_InsertionPoint"]/*' />
    SelectionType_InsertionPoint = 1,

    /// <include file='SelectionType.xml' path='doc/member[@name="SelectionType.SelectionType_Normal"]/*' />
    SelectionType_Normal = 2,

    /// <include file='SelectionType.xml' path='doc/member[@name="SelectionType.SelectionType_InlineShape"]/*' />
    SelectionType_InlineShape = 7,

    /// <include file='SelectionType.xml' path='doc/member[@name="SelectionType.SelectionType_Shape"]/*' />
    SelectionType_Shape = 8,
}
