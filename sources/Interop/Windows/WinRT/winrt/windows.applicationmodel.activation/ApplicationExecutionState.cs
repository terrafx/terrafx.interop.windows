// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ApplicationExecutionState.xml' path='doc/member[@name="ApplicationExecutionState"]/*' />
public enum ApplicationExecutionState
{
    /// <include file='ApplicationExecutionState.xml' path='doc/member[@name="ApplicationExecutionState.ApplicationExecutionState_NotRunning"]/*' />
    ApplicationExecutionState_NotRunning = 0,

    /// <include file='ApplicationExecutionState.xml' path='doc/member[@name="ApplicationExecutionState.ApplicationExecutionState_Running"]/*' />
    ApplicationExecutionState_Running = 1,

    /// <include file='ApplicationExecutionState.xml' path='doc/member[@name="ApplicationExecutionState.ApplicationExecutionState_Suspended"]/*' />
    ApplicationExecutionState_Suspended = 2,

    /// <include file='ApplicationExecutionState.xml' path='doc/member[@name="ApplicationExecutionState.ApplicationExecutionState_Terminated"]/*' />
    ApplicationExecutionState_Terminated = 3,

    /// <include file='ApplicationExecutionState.xml' path='doc/member[@name="ApplicationExecutionState.ApplicationExecutionState_ClosedByUser"]/*' />
    ApplicationExecutionState_ClosedByUser = 4,
}
