// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardCryptographicKeyAttestationStatus.xml' path='doc/member[@name="SmartCardCryptographicKeyAttestationStatus"]/*' />
public enum SmartCardCryptographicKeyAttestationStatus
{
    /// <include file='SmartCardCryptographicKeyAttestationStatus.xml' path='doc/member[@name="SmartCardCryptographicKeyAttestationStatus.SmartCardCryptographicKeyAttestationStatus_NoAttestation"]/*' />
    SmartCardCryptographicKeyAttestationStatus_NoAttestation = 0,

    /// <include file='SmartCardCryptographicKeyAttestationStatus.xml' path='doc/member[@name="SmartCardCryptographicKeyAttestationStatus.SmartCardCryptographicKeyAttestationStatus_SoftwareKeyWithoutTpm"]/*' />
    SmartCardCryptographicKeyAttestationStatus_SoftwareKeyWithoutTpm = 1,

    /// <include file='SmartCardCryptographicKeyAttestationStatus.xml' path='doc/member[@name="SmartCardCryptographicKeyAttestationStatus.SmartCardCryptographicKeyAttestationStatus_SoftwareKeyWithTpm"]/*' />
    SmartCardCryptographicKeyAttestationStatus_SoftwareKeyWithTpm = 2,

    /// <include file='SmartCardCryptographicKeyAttestationStatus.xml' path='doc/member[@name="SmartCardCryptographicKeyAttestationStatus.SmartCardCryptographicKeyAttestationStatus_TpmKeyUnknownAttestationStatus"]/*' />
    SmartCardCryptographicKeyAttestationStatus_TpmKeyUnknownAttestationStatus = 3,

    /// <include file='SmartCardCryptographicKeyAttestationStatus.xml' path='doc/member[@name="SmartCardCryptographicKeyAttestationStatus.SmartCardCryptographicKeyAttestationStatus_TpmKeyWithoutAttestationCapability"]/*' />
    SmartCardCryptographicKeyAttestationStatus_TpmKeyWithoutAttestationCapability = 4,

    /// <include file='SmartCardCryptographicKeyAttestationStatus.xml' path='doc/member[@name="SmartCardCryptographicKeyAttestationStatus.SmartCardCryptographicKeyAttestationStatus_TpmKeyWithTemporaryAttestationFailure"]/*' />
    SmartCardCryptographicKeyAttestationStatus_TpmKeyWithTemporaryAttestationFailure = 5,

    /// <include file='SmartCardCryptographicKeyAttestationStatus.xml' path='doc/member[@name="SmartCardCryptographicKeyAttestationStatus.SmartCardCryptographicKeyAttestationStatus_TpmKeyWithLongTermAttestationFailure"]/*' />
    SmartCardCryptographicKeyAttestationStatus_TpmKeyWithLongTermAttestationFailure = 6,

    /// <include file='SmartCardCryptographicKeyAttestationStatus.xml' path='doc/member[@name="SmartCardCryptographicKeyAttestationStatus.SmartCardCryptographicKeyAttestationStatus_TpmKeyWithAttestation"]/*' />
    SmartCardCryptographicKeyAttestationStatus_TpmKeyWithAttestation = 7,
}
