// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.power.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PowerSupplyStatus.xml' path='doc/member[@name="PowerSupplyStatus"]/*' />
public enum PowerSupplyStatus
{
    /// <include file='PowerSupplyStatus.xml' path='doc/member[@name="PowerSupplyStatus.PowerSupplyStatus_NotPresent"]/*' />
    PowerSupplyStatus_NotPresent = 0,

    /// <include file='PowerSupplyStatus.xml' path='doc/member[@name="PowerSupplyStatus.PowerSupplyStatus_Inadequate"]/*' />
    PowerSupplyStatus_Inadequate = 1,

    /// <include file='PowerSupplyStatus.xml' path='doc/member[@name="PowerSupplyStatus.PowerSupplyStatus_Adequate"]/*' />
    PowerSupplyStatus_Adequate = 2,
}
