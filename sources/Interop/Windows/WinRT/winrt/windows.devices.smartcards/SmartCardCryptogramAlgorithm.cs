// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardCryptogramAlgorithm.xml' path='doc/member[@name="SmartCardCryptogramAlgorithm"]/*' />
public enum SmartCardCryptogramAlgorithm
{
    /// <include file='SmartCardCryptogramAlgorithm.xml' path='doc/member[@name="SmartCardCryptogramAlgorithm.SmartCardCryptogramAlgorithm_None"]/*' />
    SmartCardCryptogramAlgorithm_None = 0,

    /// <include file='SmartCardCryptogramAlgorithm.xml' path='doc/member[@name="SmartCardCryptogramAlgorithm.SmartCardCryptogramAlgorithm_CbcMac"]/*' />
    SmartCardCryptogramAlgorithm_CbcMac = 1,

    /// <include file='SmartCardCryptogramAlgorithm.xml' path='doc/member[@name="SmartCardCryptogramAlgorithm.SmartCardCryptogramAlgorithm_Cvc3Umd"]/*' />
    SmartCardCryptogramAlgorithm_Cvc3Umd = 2,

    /// <include file='SmartCardCryptogramAlgorithm.xml' path='doc/member[@name="SmartCardCryptogramAlgorithm.SmartCardCryptogramAlgorithm_DecimalizedMsd"]/*' />
    SmartCardCryptogramAlgorithm_DecimalizedMsd = 3,

    /// <include file='SmartCardCryptogramAlgorithm.xml' path='doc/member[@name="SmartCardCryptogramAlgorithm.SmartCardCryptogramAlgorithm_Cvc3MD"]/*' />
    SmartCardCryptogramAlgorithm_Cvc3MD = 4,

    /// <include file='SmartCardCryptogramAlgorithm.xml' path='doc/member[@name="SmartCardCryptogramAlgorithm.SmartCardCryptogramAlgorithm_Sha1"]/*' />
    SmartCardCryptogramAlgorithm_Sha1 = 5,

    /// <include file='SmartCardCryptogramAlgorithm.xml' path='doc/member[@name="SmartCardCryptogramAlgorithm.SmartCardCryptogramAlgorithm_SignedDynamicApplicationData"]/*' />
    SmartCardCryptogramAlgorithm_SignedDynamicApplicationData = 6,

    /// <include file='SmartCardCryptogramAlgorithm.xml' path='doc/member[@name="SmartCardCryptogramAlgorithm.SmartCardCryptogramAlgorithm_RsaPkcs1"]/*' />
    SmartCardCryptogramAlgorithm_RsaPkcs1 = 7,

    /// <include file='SmartCardCryptogramAlgorithm.xml' path='doc/member[@name="SmartCardCryptogramAlgorithm.SmartCardCryptogramAlgorithm_Sha256Hmac"]/*' />
    SmartCardCryptogramAlgorithm_Sha256Hmac = 8,
}
