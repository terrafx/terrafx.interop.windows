// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardCryptogramMaterialPackageConfirmationResponseFormat.xml' path='doc/member[@name="SmartCardCryptogramMaterialPackageConfirmationResponseFormat"]/*' />
public enum SmartCardCryptogramMaterialPackageConfirmationResponseFormat
{
    /// <include file='SmartCardCryptogramMaterialPackageConfirmationResponseFormat.xml' path='doc/member[@name="SmartCardCryptogramMaterialPackageConfirmationResponseFormat.SmartCardCryptogramMaterialPackageConfirmationResponseFormat_None"]/*' />
    SmartCardCryptogramMaterialPackageConfirmationResponseFormat_None = 0,

    /// <include file='SmartCardCryptogramMaterialPackageConfirmationResponseFormat.xml' path='doc/member[@name="SmartCardCryptogramMaterialPackageConfirmationResponseFormat.SmartCardCryptogramMaterialPackageConfirmationResponseFormat_VisaHmac"]/*' />
    SmartCardCryptogramMaterialPackageConfirmationResponseFormat_VisaHmac = 1,
}
