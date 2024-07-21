// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SendCommandStatus.xml' path='doc/member[@name="SendCommandStatus"]/*' />
public enum SendCommandStatus
{
    /// <include file='SendCommandStatus.xml' path='doc/member[@name="SendCommandStatus.SendCommandStatus_Success"]/*' />
    SendCommandStatus_Success = 0,

    /// <include file='SendCommandStatus.xml' path='doc/member[@name="SendCommandStatus.SendCommandStatus_DeviceNotAvailable"]/*' />
    SendCommandStatus_DeviceNotAvailable = 1,
}
