// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='Panel.xml' path='doc/member[@name="Panel"]/*' />
public enum Panel
{
    /// <include file='Panel.xml' path='doc/member[@name="Panel.Panel_Unknown"]/*' />
    Panel_Unknown = 0,

    /// <include file='Panel.xml' path='doc/member[@name="Panel.Panel_Front"]/*' />
    Panel_Front = 1,

    /// <include file='Panel.xml' path='doc/member[@name="Panel.Panel_Back"]/*' />
    Panel_Back = 2,

    /// <include file='Panel.xml' path='doc/member[@name="Panel.Panel_Top"]/*' />
    Panel_Top = 3,

    /// <include file='Panel.xml' path='doc/member[@name="Panel.Panel_Bottom"]/*' />
    Panel_Bottom = 4,

    /// <include file='Panel.xml' path='doc/member[@name="Panel.Panel_Left"]/*' />
    Panel_Left = 5,

    /// <include file='Panel.xml' path='doc/member[@name="Panel.Panel_Right"]/*' />
    Panel_Right = 6,
}
