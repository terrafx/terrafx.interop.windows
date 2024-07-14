// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DigitalWindowMode.xml' path='doc/member[@name="DigitalWindowMode"]/*' />
public enum DigitalWindowMode
{
    /// <include file='DigitalWindowMode.xml' path='doc/member[@name="DigitalWindowMode.DigitalWindowMode_Off"]/*' />
    DigitalWindowMode_Off = 0,

    /// <include file='DigitalWindowMode.xml' path='doc/member[@name="DigitalWindowMode.DigitalWindowMode_On"]/*' />
    DigitalWindowMode_On = 1,

    /// <include file='DigitalWindowMode.xml' path='doc/member[@name="DigitalWindowMode.DigitalWindowMode_Auto"]/*' />
    DigitalWindowMode_Auto = 2,
}
