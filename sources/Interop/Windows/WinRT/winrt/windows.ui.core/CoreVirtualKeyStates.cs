// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CoreVirtualKeyStates.xml' path='doc/member[@name="CoreVirtualKeyStates"]/*' />
[NativeTypeName("unsigned int")]
public enum CoreVirtualKeyStates : uint
{
    /// <include file='CoreVirtualKeyStates.xml' path='doc/member[@name="CoreVirtualKeyStates.CoreVirtualKeyStates_None"]/*' />
    CoreVirtualKeyStates_None = 0,

    /// <include file='CoreVirtualKeyStates.xml' path='doc/member[@name="CoreVirtualKeyStates.CoreVirtualKeyStates_Down"]/*' />
    CoreVirtualKeyStates_Down = 0x1,

    /// <include file='CoreVirtualKeyStates.xml' path='doc/member[@name="CoreVirtualKeyStates.CoreVirtualKeyStates_Locked"]/*' />
    CoreVirtualKeyStates_Locked = 0x2,
}
