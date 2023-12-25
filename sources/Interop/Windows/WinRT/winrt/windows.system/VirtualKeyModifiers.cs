// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VirtualKeyModifiers.xml' path='doc/member[@name="VirtualKeyModifiers"]/*' />
[NativeTypeName("unsigned int")]
public enum VirtualKeyModifiers : uint
{
    /// <include file='VirtualKeyModifiers.xml' path='doc/member[@name="VirtualKeyModifiers.VirtualKeyModifiers_None"]/*' />
    VirtualKeyModifiers_None = 0,

    /// <include file='VirtualKeyModifiers.xml' path='doc/member[@name="VirtualKeyModifiers.VirtualKeyModifiers_Control"]/*' />
    VirtualKeyModifiers_Control = 0x1,

    /// <include file='VirtualKeyModifiers.xml' path='doc/member[@name="VirtualKeyModifiers.VirtualKeyModifiers_Menu"]/*' />
    VirtualKeyModifiers_Menu = 0x2,

    /// <include file='VirtualKeyModifiers.xml' path='doc/member[@name="VirtualKeyModifiers.VirtualKeyModifiers_Shift"]/*' />
    VirtualKeyModifiers_Shift = 0x4,

    /// <include file='VirtualKeyModifiers.xml' path='doc/member[@name="VirtualKeyModifiers.VirtualKeyModifiers_Windows"]/*' />
    VirtualKeyModifiers_Windows = 0x8,
}
