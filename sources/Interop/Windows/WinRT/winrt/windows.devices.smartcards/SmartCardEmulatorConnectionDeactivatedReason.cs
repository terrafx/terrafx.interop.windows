// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardEmulatorConnectionDeactivatedReason.xml' path='doc/member[@name="SmartCardEmulatorConnectionDeactivatedReason"]/*' />
public enum SmartCardEmulatorConnectionDeactivatedReason
{
    /// <include file='SmartCardEmulatorConnectionDeactivatedReason.xml' path='doc/member[@name="SmartCardEmulatorConnectionDeactivatedReason.SmartCardEmulatorConnectionDeactivatedReason_ConnectionLost"]/*' />
    SmartCardEmulatorConnectionDeactivatedReason_ConnectionLost = 0,

    /// <include file='SmartCardEmulatorConnectionDeactivatedReason.xml' path='doc/member[@name="SmartCardEmulatorConnectionDeactivatedReason.SmartCardEmulatorConnectionDeactivatedReason_ConnectionRedirected"]/*' />
    SmartCardEmulatorConnectionDeactivatedReason_ConnectionRedirected = 1,
}
