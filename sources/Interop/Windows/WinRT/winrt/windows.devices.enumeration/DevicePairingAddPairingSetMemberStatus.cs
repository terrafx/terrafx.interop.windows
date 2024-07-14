// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DevicePairingAddPairingSetMemberStatus.xml' path='doc/member[@name="DevicePairingAddPairingSetMemberStatus"]/*' />
public enum DevicePairingAddPairingSetMemberStatus
{
    /// <include file='DevicePairingAddPairingSetMemberStatus.xml' path='doc/member[@name="DevicePairingAddPairingSetMemberStatus.DevicePairingAddPairingSetMemberStatus_AddedToSet"]/*' />
    DevicePairingAddPairingSetMemberStatus_AddedToSet = 0,

    /// <include file='DevicePairingAddPairingSetMemberStatus.xml' path='doc/member[@name="DevicePairingAddPairingSetMemberStatus.DevicePairingAddPairingSetMemberStatus_CouldNotBeAddedToSet"]/*' />
    DevicePairingAddPairingSetMemberStatus_CouldNotBeAddedToSet = 1,

    /// <include file='DevicePairingAddPairingSetMemberStatus.xml' path='doc/member[@name="DevicePairingAddPairingSetMemberStatus.DevicePairingAddPairingSetMemberStatus_SetDiscoveryNotAttemptedByProtocol"]/*' />
    DevicePairingAddPairingSetMemberStatus_SetDiscoveryNotAttemptedByProtocol = 2,

    /// <include file='DevicePairingAddPairingSetMemberStatus.xml' path='doc/member[@name="DevicePairingAddPairingSetMemberStatus.DevicePairingAddPairingSetMemberStatus_SetDiscoveryCompletedByProtocol"]/*' />
    DevicePairingAddPairingSetMemberStatus_SetDiscoveryCompletedByProtocol = 3,

    /// <include file='DevicePairingAddPairingSetMemberStatus.xml' path='doc/member[@name="DevicePairingAddPairingSetMemberStatus.DevicePairingAddPairingSetMemberStatus_SetDiscoveryPartiallyCompletedByProtocol"]/*' />
    DevicePairingAddPairingSetMemberStatus_SetDiscoveryPartiallyCompletedByProtocol = 4,

    /// <include file='DevicePairingAddPairingSetMemberStatus.xml' path='doc/member[@name="DevicePairingAddPairingSetMemberStatus.DevicePairingAddPairingSetMemberStatus_Failed"]/*' />
    DevicePairingAddPairingSetMemberStatus_Failed = 5,
}
