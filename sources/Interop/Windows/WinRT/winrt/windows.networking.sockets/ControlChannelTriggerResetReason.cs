// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ControlChannelTriggerResetReason.xml' path='doc/member[@name="ControlChannelTriggerResetReason"]/*' />
public enum ControlChannelTriggerResetReason
{
    /// <include file='ControlChannelTriggerResetReason.xml' path='doc/member[@name="ControlChannelTriggerResetReason.ControlChannelTriggerResetReason_FastUserSwitched"]/*' />
    ControlChannelTriggerResetReason_FastUserSwitched = 0,

    /// <include file='ControlChannelTriggerResetReason.xml' path='doc/member[@name="ControlChannelTriggerResetReason.ControlChannelTriggerResetReason_LowPowerExit"]/*' />
    ControlChannelTriggerResetReason_LowPowerExit = 1,

    /// <include file='ControlChannelTriggerResetReason.xml' path='doc/member[@name="ControlChannelTriggerResetReason.ControlChannelTriggerResetReason_QuietHoursExit"]/*' />
    ControlChannelTriggerResetReason_QuietHoursExit = 2,

    /// <include file='ControlChannelTriggerResetReason.xml' path='doc/member[@name="ControlChannelTriggerResetReason.ControlChannelTriggerResetReason_ApplicationRestart"]/*' />
    ControlChannelTriggerResetReason_ApplicationRestart = 3,
}
