// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum RM_APP_STATUS
    {
        RmStatusUnknown = 0x0,
        RmStatusRunning = 0x1,
        RmStatusStopped = 0x2,
        RmStatusStoppedOther = 0x4,
        RmStatusRestarted = 0x8,
        RmStatusErrorOnStop = 0x10,
        RmStatusErrorOnRestart = 0x20,
        RmStatusShutdownMasked = 0x40,
        RmStatusRestartMasked = 0x80,
    }
}
