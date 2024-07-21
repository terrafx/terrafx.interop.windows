// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardCryptogramMaterialPackageFormat.xml' path='doc/member[@name="SmartCardCryptogramMaterialPackageFormat"]/*' />
public enum SmartCardCryptogramMaterialPackageFormat
{
    /// <include file='SmartCardCryptogramMaterialPackageFormat.xml' path='doc/member[@name="SmartCardCryptogramMaterialPackageFormat.SmartCardCryptogramMaterialPackageFormat_None"]/*' />
    SmartCardCryptogramMaterialPackageFormat_None = 0,

    /// <include file='SmartCardCryptogramMaterialPackageFormat.xml' path='doc/member[@name="SmartCardCryptogramMaterialPackageFormat.SmartCardCryptogramMaterialPackageFormat_JweRsaPki"]/*' />
    SmartCardCryptogramMaterialPackageFormat_JweRsaPki = 1,
}
