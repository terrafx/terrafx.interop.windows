// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ControlChannelTriggerStatus.xml' path='doc/member[@name="ControlChannelTriggerStatus"]/*' />
public enum ControlChannelTriggerStatus
{
    /// <include file='ControlChannelTriggerStatus.xml' path='doc/member[@name="ControlChannelTriggerStatus.ControlChannelTriggerStatus_HardwareSlotRequested"]/*' />
    ControlChannelTriggerStatus_HardwareSlotRequested = 0,

    /// <include file='ControlChannelTriggerStatus.xml' path='doc/member[@name="ControlChannelTriggerStatus.ControlChannelTriggerStatus_SoftwareSlotAllocated"]/*' />
    ControlChannelTriggerStatus_SoftwareSlotAllocated = 1,

    /// <include file='ControlChannelTriggerStatus.xml' path='doc/member[@name="ControlChannelTriggerStatus.ControlChannelTriggerStatus_HardwareSlotAllocated"]/*' />
    ControlChannelTriggerStatus_HardwareSlotAllocated = 2,

    /// <include file='ControlChannelTriggerStatus.xml' path='doc/member[@name="ControlChannelTriggerStatus.ControlChannelTriggerStatus_PolicyError"]/*' />
    ControlChannelTriggerStatus_PolicyError = 3,

    /// <include file='ControlChannelTriggerStatus.xml' path='doc/member[@name="ControlChannelTriggerStatus.ControlChannelTriggerStatus_SystemError"]/*' />
    ControlChannelTriggerStatus_SystemError = 4,

    /// <include file='ControlChannelTriggerStatus.xml' path='doc/member[@name="ControlChannelTriggerStatus.ControlChannelTriggerStatus_TransportDisconnected"]/*' />
    ControlChannelTriggerStatus_TransportDisconnected = 5,

    /// <include file='ControlChannelTriggerStatus.xml' path='doc/member[@name="ControlChannelTriggerStatus.ControlChannelTriggerStatus_ServiceUnavailable"]/*' />
    ControlChannelTriggerStatus_ServiceUnavailable = 6,
}
