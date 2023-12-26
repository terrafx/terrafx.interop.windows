// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CoreInputDeviceTypes.xml' path='doc/member[@name="CoreInputDeviceTypes"]/*' />
[NativeTypeName("unsigned int")]
public enum CoreInputDeviceTypes : uint
{
    /// <include file='CoreInputDeviceTypes.xml' path='doc/member[@name="CoreInputDeviceTypes.CoreInputDeviceTypes_None"]/*' />
    CoreInputDeviceTypes_None = 0,

    /// <include file='CoreInputDeviceTypes.xml' path='doc/member[@name="CoreInputDeviceTypes.CoreInputDeviceTypes_Touch"]/*' />
    CoreInputDeviceTypes_Touch = 0x1,

    /// <include file='CoreInputDeviceTypes.xml' path='doc/member[@name="CoreInputDeviceTypes.CoreInputDeviceTypes_Pen"]/*' />
    CoreInputDeviceTypes_Pen = 0x2,

    /// <include file='CoreInputDeviceTypes.xml' path='doc/member[@name="CoreInputDeviceTypes.CoreInputDeviceTypes_Mouse"]/*' />
    CoreInputDeviceTypes_Mouse = 0x4,
}
