// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppResourceGroupEnergyQuotaState.xml' path='doc/member[@name="AppResourceGroupEnergyQuotaState"]/*' />
public enum AppResourceGroupEnergyQuotaState
{
    /// <include file='AppResourceGroupEnergyQuotaState.xml' path='doc/member[@name="AppResourceGroupEnergyQuotaState.AppResourceGroupEnergyQuotaState_Unknown"]/*' />
    AppResourceGroupEnergyQuotaState_Unknown = 0,

    /// <include file='AppResourceGroupEnergyQuotaState.xml' path='doc/member[@name="AppResourceGroupEnergyQuotaState.AppResourceGroupEnergyQuotaState_Over"]/*' />
    AppResourceGroupEnergyQuotaState_Over = 1,

    /// <include file='AppResourceGroupEnergyQuotaState.xml' path='doc/member[@name="AppResourceGroupEnergyQuotaState.AppResourceGroupEnergyQuotaState_Under"]/*' />
    AppResourceGroupEnergyQuotaState_Under = 2,
}
