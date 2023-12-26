// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ControlChannelTriggerResourceType.xml' path='doc/member[@name="ControlChannelTriggerResourceType"]/*' />
public enum ControlChannelTriggerResourceType
{
    /// <include file='ControlChannelTriggerResourceType.xml' path='doc/member[@name="ControlChannelTriggerResourceType.ControlChannelTriggerResourceType_RequestSoftwareSlot"]/*' />
    ControlChannelTriggerResourceType_RequestSoftwareSlot = 0,

    /// <include file='ControlChannelTriggerResourceType.xml' path='doc/member[@name="ControlChannelTriggerResourceType.ControlChannelTriggerResourceType_RequestHardwareSlot"]/*' />
    ControlChannelTriggerResourceType_RequestHardwareSlot = 1,
}
