// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppResourceGroupExecutionState.xml' path='doc/member[@name="AppResourceGroupExecutionState"]/*' />
public enum AppResourceGroupExecutionState
{
    /// <include file='AppResourceGroupExecutionState.xml' path='doc/member[@name="AppResourceGroupExecutionState.AppResourceGroupExecutionState_Unknown"]/*' />
    AppResourceGroupExecutionState_Unknown = 0,

    /// <include file='AppResourceGroupExecutionState.xml' path='doc/member[@name="AppResourceGroupExecutionState.AppResourceGroupExecutionState_Running"]/*' />
    AppResourceGroupExecutionState_Running = 1,

    /// <include file='AppResourceGroupExecutionState.xml' path='doc/member[@name="AppResourceGroupExecutionState.AppResourceGroupExecutionState_Suspending"]/*' />
    AppResourceGroupExecutionState_Suspending = 2,

    /// <include file='AppResourceGroupExecutionState.xml' path='doc/member[@name="AppResourceGroupExecutionState.AppResourceGroupExecutionState_Suspended"]/*' />
    AppResourceGroupExecutionState_Suspended = 3,

    /// <include file='AppResourceGroupExecutionState.xml' path='doc/member[@name="AppResourceGroupExecutionState.AppResourceGroupExecutionState_NotRunning"]/*' />
    AppResourceGroupExecutionState_NotRunning = 4,
}
