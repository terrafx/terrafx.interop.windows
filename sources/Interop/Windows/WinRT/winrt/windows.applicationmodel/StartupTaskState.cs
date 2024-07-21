// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StartupTaskState.xml' path='doc/member[@name="StartupTaskState"]/*' />
public enum StartupTaskState
{
    /// <include file='StartupTaskState.xml' path='doc/member[@name="StartupTaskState.StartupTaskState_Disabled"]/*' />
    StartupTaskState_Disabled = 0,

    /// <include file='StartupTaskState.xml' path='doc/member[@name="StartupTaskState.StartupTaskState_DisabledByUser"]/*' />
    StartupTaskState_DisabledByUser = 1,

    /// <include file='StartupTaskState.xml' path='doc/member[@name="StartupTaskState.StartupTaskState_Enabled"]/*' />
    StartupTaskState_Enabled = 2,

    /// <include file='StartupTaskState.xml' path='doc/member[@name="StartupTaskState.StartupTaskState_DisabledByPolicy"]/*' />
    StartupTaskState_DisabledByPolicy = 3,

    /// <include file='StartupTaskState.xml' path='doc/member[@name="StartupTaskState.StartupTaskState_EnabledByPolicy"]/*' />
    StartupTaskState_EnabledByPolicy = 4,
}
