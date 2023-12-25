// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardEmulationType.xml' path='doc/member[@name="SmartCardEmulationType"]/*' />
public enum SmartCardEmulationType
{
    /// <include file='SmartCardEmulationType.xml' path='doc/member[@name="SmartCardEmulationType.SmartCardEmulationType_Host"]/*' />
    SmartCardEmulationType_Host = 0,

    /// <include file='SmartCardEmulationType.xml' path='doc/member[@name="SmartCardEmulationType.SmartCardEmulationType_Uicc"]/*' />
    SmartCardEmulationType_Uicc = 1,

    /// <include file='SmartCardEmulationType.xml' path='doc/member[@name="SmartCardEmulationType.SmartCardEmulationType_EmbeddedSE"]/*' />
    SmartCardEmulationType_EmbeddedSE = 2,
}
