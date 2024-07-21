// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmsDeviceStatus.xml' path='doc/member[@name="SmsDeviceStatus"]/*' />
public enum SmsDeviceStatus
{
    /// <include file='SmsDeviceStatus.xml' path='doc/member[@name="SmsDeviceStatus.SmsDeviceStatus_Off"]/*' />
    SmsDeviceStatus_Off = 0,

    /// <include file='SmsDeviceStatus.xml' path='doc/member[@name="SmsDeviceStatus.SmsDeviceStatus_Ready"]/*' />
    SmsDeviceStatus_Ready = 1,

    /// <include file='SmsDeviceStatus.xml' path='doc/member[@name="SmsDeviceStatus.SmsDeviceStatus_SimNotInserted"]/*' />
    SmsDeviceStatus_SimNotInserted = 2,

    /// <include file='SmsDeviceStatus.xml' path='doc/member[@name="SmsDeviceStatus.SmsDeviceStatus_BadSim"]/*' />
    SmsDeviceStatus_BadSim = 3,

    /// <include file='SmsDeviceStatus.xml' path='doc/member[@name="SmsDeviceStatus.SmsDeviceStatus_DeviceFailure"]/*' />
    SmsDeviceStatus_DeviceFailure = 4,

    /// <include file='SmsDeviceStatus.xml' path='doc/member[@name="SmsDeviceStatus.SmsDeviceStatus_SubscriptionNotActivated"]/*' />
    SmsDeviceStatus_SubscriptionNotActivated = 5,

    /// <include file='SmsDeviceStatus.xml' path='doc/member[@name="SmsDeviceStatus.SmsDeviceStatus_DeviceLocked"]/*' />
    SmsDeviceStatus_DeviceLocked = 6,

    /// <include file='SmsDeviceStatus.xml' path='doc/member[@name="SmsDeviceStatus.SmsDeviceStatus_DeviceBlocked"]/*' />
    SmsDeviceStatus_DeviceBlocked = 7,
}
