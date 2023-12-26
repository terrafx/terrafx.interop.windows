// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus"]/*' />
public enum DevicePairingResultStatus
{
    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_Paired"]/*' />
    DevicePairingResultStatus_Paired = 0,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_NotReadyToPair"]/*' />
    DevicePairingResultStatus_NotReadyToPair = 1,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_NotPaired"]/*' />
    DevicePairingResultStatus_NotPaired = 2,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_AlreadyPaired"]/*' />
    DevicePairingResultStatus_AlreadyPaired = 3,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_ConnectionRejected"]/*' />
    DevicePairingResultStatus_ConnectionRejected = 4,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_TooManyConnections"]/*' />
    DevicePairingResultStatus_TooManyConnections = 5,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_HardwareFailure"]/*' />
    DevicePairingResultStatus_HardwareFailure = 6,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_AuthenticationTimeout"]/*' />
    DevicePairingResultStatus_AuthenticationTimeout = 7,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_AuthenticationNotAllowed"]/*' />
    DevicePairingResultStatus_AuthenticationNotAllowed = 8,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_AuthenticationFailure"]/*' />
    DevicePairingResultStatus_AuthenticationFailure = 9,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_NoSupportedProfiles"]/*' />
    DevicePairingResultStatus_NoSupportedProfiles = 10,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_ProtectionLevelCouldNotBeMet"]/*' />
    DevicePairingResultStatus_ProtectionLevelCouldNotBeMet = 11,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_AccessDenied"]/*' />
    DevicePairingResultStatus_AccessDenied = 12,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_InvalidCeremonyData"]/*' />
    DevicePairingResultStatus_InvalidCeremonyData = 13,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_PairingCanceled"]/*' />
    DevicePairingResultStatus_PairingCanceled = 14,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_OperationAlreadyInProgress"]/*' />
    DevicePairingResultStatus_OperationAlreadyInProgress = 15,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_RequiredHandlerNotRegistered"]/*' />
    DevicePairingResultStatus_RequiredHandlerNotRegistered = 16,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_RejectedByHandler"]/*' />
    DevicePairingResultStatus_RejectedByHandler = 17,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_RemoteDeviceHasAssociation"]/*' />
    DevicePairingResultStatus_RemoteDeviceHasAssociation = 18,

    /// <include file='DevicePairingResultStatus.xml' path='doc/member[@name="DevicePairingResultStatus.DevicePairingResultStatus_Failed"]/*' />
    DevicePairingResultStatus_Failed = 19,
}
