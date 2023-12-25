// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardCryptogramGeneratorOperationStatus.xml' path='doc/member[@name="SmartCardCryptogramGeneratorOperationStatus"]/*' />
public enum SmartCardCryptogramGeneratorOperationStatus
{
    /// <include file='SmartCardCryptogramGeneratorOperationStatus.xml' path='doc/member[@name="SmartCardCryptogramGeneratorOperationStatus.SmartCardCryptogramGeneratorOperationStatus_Success"]/*' />
    SmartCardCryptogramGeneratorOperationStatus_Success = 0,

    /// <include file='SmartCardCryptogramGeneratorOperationStatus.xml' path='doc/member[@name="SmartCardCryptogramGeneratorOperationStatus.SmartCardCryptogramGeneratorOperationStatus_AuthorizationFailed"]/*' />
    SmartCardCryptogramGeneratorOperationStatus_AuthorizationFailed = 1,

    /// <include file='SmartCardCryptogramGeneratorOperationStatus.xml' path='doc/member[@name="SmartCardCryptogramGeneratorOperationStatus.SmartCardCryptogramGeneratorOperationStatus_AuthorizationCanceled"]/*' />
    SmartCardCryptogramGeneratorOperationStatus_AuthorizationCanceled = 2,

    /// <include file='SmartCardCryptogramGeneratorOperationStatus.xml' path='doc/member[@name="SmartCardCryptogramGeneratorOperationStatus.SmartCardCryptogramGeneratorOperationStatus_AuthorizationRequired"]/*' />
    SmartCardCryptogramGeneratorOperationStatus_AuthorizationRequired = 3,

    /// <include file='SmartCardCryptogramGeneratorOperationStatus.xml' path='doc/member[@name="SmartCardCryptogramGeneratorOperationStatus.SmartCardCryptogramGeneratorOperationStatus_CryptogramMaterialPackageStorageKeyExists"]/*' />
    SmartCardCryptogramGeneratorOperationStatus_CryptogramMaterialPackageStorageKeyExists = 4,

    /// <include file='SmartCardCryptogramGeneratorOperationStatus.xml' path='doc/member[@name="SmartCardCryptogramGeneratorOperationStatus.SmartCardCryptogramGeneratorOperationStatus_NoCryptogramMaterialPackageStorageKey"]/*' />
    SmartCardCryptogramGeneratorOperationStatus_NoCryptogramMaterialPackageStorageKey = 5,

    /// <include file='SmartCardCryptogramGeneratorOperationStatus.xml' path='doc/member[@name="SmartCardCryptogramGeneratorOperationStatus.SmartCardCryptogramGeneratorOperationStatus_NoCryptogramMaterialPackage"]/*' />
    SmartCardCryptogramGeneratorOperationStatus_NoCryptogramMaterialPackage = 6,

    /// <include file='SmartCardCryptogramGeneratorOperationStatus.xml' path='doc/member[@name="SmartCardCryptogramGeneratorOperationStatus.SmartCardCryptogramGeneratorOperationStatus_UnsupportedCryptogramMaterialPackage"]/*' />
    SmartCardCryptogramGeneratorOperationStatus_UnsupportedCryptogramMaterialPackage = 7,

    /// <include file='SmartCardCryptogramGeneratorOperationStatus.xml' path='doc/member[@name="SmartCardCryptogramGeneratorOperationStatus.SmartCardCryptogramGeneratorOperationStatus_UnknownCryptogramMaterialName"]/*' />
    SmartCardCryptogramGeneratorOperationStatus_UnknownCryptogramMaterialName = 8,

    /// <include file='SmartCardCryptogramGeneratorOperationStatus.xml' path='doc/member[@name="SmartCardCryptogramGeneratorOperationStatus.SmartCardCryptogramGeneratorOperationStatus_InvalidCryptogramMaterialUsage"]/*' />
    SmartCardCryptogramGeneratorOperationStatus_InvalidCryptogramMaterialUsage = 9,

    /// <include file='SmartCardCryptogramGeneratorOperationStatus.xml' path='doc/member[@name="SmartCardCryptogramGeneratorOperationStatus.SmartCardCryptogramGeneratorOperationStatus_ApduResponseNotSent"]/*' />
    SmartCardCryptogramGeneratorOperationStatus_ApduResponseNotSent = 10,

    /// <include file='SmartCardCryptogramGeneratorOperationStatus.xml' path='doc/member[@name="SmartCardCryptogramGeneratorOperationStatus.SmartCardCryptogramGeneratorOperationStatus_OtherError"]/*' />
    SmartCardCryptogramGeneratorOperationStatus_OtherError = 11,

    /// <include file='SmartCardCryptogramGeneratorOperationStatus.xml' path='doc/member[@name="SmartCardCryptogramGeneratorOperationStatus.SmartCardCryptogramGeneratorOperationStatus_ValidationFailed"]/*' />
    SmartCardCryptogramGeneratorOperationStatus_ValidationFailed = 12,

    /// <include file='SmartCardCryptogramGeneratorOperationStatus.xml' path='doc/member[@name="SmartCardCryptogramGeneratorOperationStatus.SmartCardCryptogramGeneratorOperationStatus_NotSupported"]/*' />
    SmartCardCryptogramGeneratorOperationStatus_NotSupported = 13,
}
