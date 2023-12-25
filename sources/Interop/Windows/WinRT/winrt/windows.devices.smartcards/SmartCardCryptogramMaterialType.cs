// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardCryptogramMaterialType.xml' path='doc/member[@name="SmartCardCryptogramMaterialType"]/*' />
public enum SmartCardCryptogramMaterialType
{
    /// <include file='SmartCardCryptogramMaterialType.xml' path='doc/member[@name="SmartCardCryptogramMaterialType.SmartCardCryptogramMaterialType_None"]/*' />
    SmartCardCryptogramMaterialType_None = 0,

    /// <include file='SmartCardCryptogramMaterialType.xml' path='doc/member[@name="SmartCardCryptogramMaterialType.SmartCardCryptogramMaterialType_StaticDataAuthentication"]/*' />
    SmartCardCryptogramMaterialType_StaticDataAuthentication = 1,

    /// <include file='SmartCardCryptogramMaterialType.xml' path='doc/member[@name="SmartCardCryptogramMaterialType.SmartCardCryptogramMaterialType_TripleDes112"]/*' />
    SmartCardCryptogramMaterialType_TripleDes112 = 2,

    /// <include file='SmartCardCryptogramMaterialType.xml' path='doc/member[@name="SmartCardCryptogramMaterialType.SmartCardCryptogramMaterialType_Aes"]/*' />
    SmartCardCryptogramMaterialType_Aes = 3,

    /// <include file='SmartCardCryptogramMaterialType.xml' path='doc/member[@name="SmartCardCryptogramMaterialType.SmartCardCryptogramMaterialType_RsaPkcs1"]/*' />
    SmartCardCryptogramMaterialType_RsaPkcs1 = 4,
}
