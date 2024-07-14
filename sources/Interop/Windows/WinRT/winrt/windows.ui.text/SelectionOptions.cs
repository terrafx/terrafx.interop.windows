// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SelectionOptions.xml' path='doc/member[@name="SelectionOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum SelectionOptions : uint
{
    /// <include file='SelectionOptions.xml' path='doc/member[@name="SelectionOptions.SelectionOptions_StartActive"]/*' />
    SelectionOptions_StartActive = 0x1,

    /// <include file='SelectionOptions.xml' path='doc/member[@name="SelectionOptions.SelectionOptions_AtEndOfLine"]/*' />
    SelectionOptions_AtEndOfLine = 0x2,

    /// <include file='SelectionOptions.xml' path='doc/member[@name="SelectionOptions.SelectionOptions_Overtype"]/*' />
    SelectionOptions_Overtype = 0x4,

    /// <include file='SelectionOptions.xml' path='doc/member[@name="SelectionOptions.SelectionOptions_Active"]/*' />
    SelectionOptions_Active = 0x8,

    /// <include file='SelectionOptions.xml' path='doc/member[@name="SelectionOptions.SelectionOptions_Replace"]/*' />
    SelectionOptions_Replace = 0x10,
}
