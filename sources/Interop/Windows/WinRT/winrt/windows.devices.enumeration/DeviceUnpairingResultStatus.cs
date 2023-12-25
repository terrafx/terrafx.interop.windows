// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DeviceUnpairingResultStatus.xml' path='doc/member[@name="DeviceUnpairingResultStatus"]/*' />
public enum DeviceUnpairingResultStatus
{
    /// <include file='DeviceUnpairingResultStatus.xml' path='doc/member[@name="DeviceUnpairingResultStatus.DeviceUnpairingResultStatus_Unpaired"]/*' />
    DeviceUnpairingResultStatus_Unpaired = 0,

    /// <include file='DeviceUnpairingResultStatus.xml' path='doc/member[@name="DeviceUnpairingResultStatus.DeviceUnpairingResultStatus_AlreadyUnpaired"]/*' />
    DeviceUnpairingResultStatus_AlreadyUnpaired = 1,

    /// <include file='DeviceUnpairingResultStatus.xml' path='doc/member[@name="DeviceUnpairingResultStatus.DeviceUnpairingResultStatus_OperationAlreadyInProgress"]/*' />
    DeviceUnpairingResultStatus_OperationAlreadyInProgress = 2,

    /// <include file='DeviceUnpairingResultStatus.xml' path='doc/member[@name="DeviceUnpairingResultStatus.DeviceUnpairingResultStatus_AccessDenied"]/*' />
    DeviceUnpairingResultStatus_AccessDenied = 3,

    /// <include file='DeviceUnpairingResultStatus.xml' path='doc/member[@name="DeviceUnpairingResultStatus.DeviceUnpairingResultStatus_Failed"]/*' />
    DeviceUnpairingResultStatus_Failed = 4,
}
