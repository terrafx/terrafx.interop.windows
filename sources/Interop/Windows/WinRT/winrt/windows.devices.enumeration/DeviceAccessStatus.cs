// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DeviceAccessStatus.xml' path='doc/member[@name="DeviceAccessStatus"]/*' />
public enum DeviceAccessStatus
{
    /// <include file='DeviceAccessStatus.xml' path='doc/member[@name="DeviceAccessStatus.DeviceAccessStatus_Unspecified"]/*' />
    DeviceAccessStatus_Unspecified = 0,

    /// <include file='DeviceAccessStatus.xml' path='doc/member[@name="DeviceAccessStatus.DeviceAccessStatus_Allowed"]/*' />
    DeviceAccessStatus_Allowed = 1,

    /// <include file='DeviceAccessStatus.xml' path='doc/member[@name="DeviceAccessStatus.DeviceAccessStatus_DeniedByUser"]/*' />
    DeviceAccessStatus_DeniedByUser = 2,

    /// <include file='DeviceAccessStatus.xml' path='doc/member[@name="DeviceAccessStatus.DeviceAccessStatus_DeniedBySystem"]/*' />
    DeviceAccessStatus_DeniedBySystem = 3,
}
