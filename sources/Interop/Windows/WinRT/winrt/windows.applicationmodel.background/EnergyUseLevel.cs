// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EnergyUseLevel.xml' path='doc/member[@name="EnergyUseLevel"]/*' />
public enum EnergyUseLevel
{
    /// <include file='EnergyUseLevel.xml' path='doc/member[@name="EnergyUseLevel.EnergyUseLevel_Unknown"]/*' />
    EnergyUseLevel_Unknown = 0,

    /// <include file='EnergyUseLevel.xml' path='doc/member[@name="EnergyUseLevel.EnergyUseLevel_UnderHalfOfBudget"]/*' />
    EnergyUseLevel_UnderHalfOfBudget = 1,

    /// <include file='EnergyUseLevel.xml' path='doc/member[@name="EnergyUseLevel.EnergyUseLevel_OverHalfOfBudget"]/*' />
    EnergyUseLevel_OverHalfOfBudget = 2,

    /// <include file='EnergyUseLevel.xml' path='doc/member[@name="EnergyUseLevel.EnergyUseLevel_OverBudget"]/*' />
    EnergyUseLevel_OverBudget = 3,
}
