// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum AppResourceGroupExecutionState
    {
        AppResourceGroupExecutionState_Unknown = 0,
        AppResourceGroupExecutionState_Running = 1,
        AppResourceGroupExecutionState_Suspending = 2,
        AppResourceGroupExecutionState_Suspended = 3,
        AppResourceGroupExecutionState_NotRunning = 4,
    }
}
