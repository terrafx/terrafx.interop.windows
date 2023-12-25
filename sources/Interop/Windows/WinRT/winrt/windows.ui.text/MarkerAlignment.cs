// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MarkerAlignment.xml' path='doc/member[@name="MarkerAlignment"]/*' />
public enum MarkerAlignment
{
    /// <include file='MarkerAlignment.xml' path='doc/member[@name="MarkerAlignment.MarkerAlignment_Undefined"]/*' />
    MarkerAlignment_Undefined = 0,

    /// <include file='MarkerAlignment.xml' path='doc/member[@name="MarkerAlignment.MarkerAlignment_Left"]/*' />
    MarkerAlignment_Left = 1,

    /// <include file='MarkerAlignment.xml' path='doc/member[@name="MarkerAlignment.MarkerAlignment_Center"]/*' />
    MarkerAlignment_Center = 2,

    /// <include file='MarkerAlignment.xml' path='doc/member[@name="MarkerAlignment.MarkerAlignment_Right"]/*' />
    MarkerAlignment_Right = 3,
}
