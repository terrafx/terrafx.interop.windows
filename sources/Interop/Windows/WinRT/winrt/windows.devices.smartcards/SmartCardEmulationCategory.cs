// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardEmulationCategory.xml' path='doc/member[@name="SmartCardEmulationCategory"]/*' />
public enum SmartCardEmulationCategory
{
    /// <include file='SmartCardEmulationCategory.xml' path='doc/member[@name="SmartCardEmulationCategory.SmartCardEmulationCategory_Other"]/*' />
    SmartCardEmulationCategory_Other = 0,

    /// <include file='SmartCardEmulationCategory.xml' path='doc/member[@name="SmartCardEmulationCategory.SmartCardEmulationCategory_Payment"]/*' />
    SmartCardEmulationCategory_Payment = 1,
}
