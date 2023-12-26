// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HumanPresence.xml' path='doc/member[@name="HumanPresence"]/*' />
public enum HumanPresence
{
    /// <include file='HumanPresence.xml' path='doc/member[@name="HumanPresence.HumanPresence_Unknown"]/*' />
    HumanPresence_Unknown = 0,

    /// <include file='HumanPresence.xml' path='doc/member[@name="HumanPresence.HumanPresence_Present"]/*' />
    HumanPresence_Present = 1,

    /// <include file='HumanPresence.xml' path='doc/member[@name="HumanPresence.HumanPresence_NotPresent"]/*' />
    HumanPresence_NotPresent = 2,
}
