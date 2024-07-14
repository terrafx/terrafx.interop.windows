// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='WalletBarcodeSymbology.xml' path='doc/member[@name="WalletBarcodeSymbology"]/*' />
[Obsolete("WalletBarcodeSymbology is deprecated and might not work on all platforms. For more info, see MSDN.")]
public enum WalletBarcodeSymbology
{
    /// <include file='WalletBarcodeSymbology.xml' path='doc/member[@name="WalletBarcodeSymbology.WalletBarcodeSymbology_Invalid"]/*' />
    WalletBarcodeSymbology_Invalid = 0,

    /// <include file='WalletBarcodeSymbology.xml' path='doc/member[@name="WalletBarcodeSymbology.WalletBarcodeSymbology_Upca"]/*' />
    WalletBarcodeSymbology_Upca = 1,

    /// <include file='WalletBarcodeSymbology.xml' path='doc/member[@name="WalletBarcodeSymbology.WalletBarcodeSymbology_Upce"]/*' />
    WalletBarcodeSymbology_Upce = 2,

    /// <include file='WalletBarcodeSymbology.xml' path='doc/member[@name="WalletBarcodeSymbology.WalletBarcodeSymbology_Ean13"]/*' />
    WalletBarcodeSymbology_Ean13 = 3,

    /// <include file='WalletBarcodeSymbology.xml' path='doc/member[@name="WalletBarcodeSymbology.WalletBarcodeSymbology_Ean8"]/*' />
    WalletBarcodeSymbology_Ean8 = 4,

    /// <include file='WalletBarcodeSymbology.xml' path='doc/member[@name="WalletBarcodeSymbology.WalletBarcodeSymbology_Itf"]/*' />
    WalletBarcodeSymbology_Itf = 5,

    /// <include file='WalletBarcodeSymbology.xml' path='doc/member[@name="WalletBarcodeSymbology.WalletBarcodeSymbology_Code39"]/*' />
    WalletBarcodeSymbology_Code39 = 6,

    /// <include file='WalletBarcodeSymbology.xml' path='doc/member[@name="WalletBarcodeSymbology.WalletBarcodeSymbology_Code128"]/*' />
    WalletBarcodeSymbology_Code128 = 7,

    /// <include file='WalletBarcodeSymbology.xml' path='doc/member[@name="WalletBarcodeSymbology.WalletBarcodeSymbology_Qr"]/*' />
    WalletBarcodeSymbology_Qr = 8,

    /// <include file='WalletBarcodeSymbology.xml' path='doc/member[@name="WalletBarcodeSymbology.WalletBarcodeSymbology_Pdf417"]/*' />
    WalletBarcodeSymbology_Pdf417 = 9,

    /// <include file='WalletBarcodeSymbology.xml' path='doc/member[@name="WalletBarcodeSymbology.WalletBarcodeSymbology_Aztec"]/*' />
    WalletBarcodeSymbology_Aztec = 10,

    /// <include file='WalletBarcodeSymbology.xml' path='doc/member[@name="WalletBarcodeSymbology.WalletBarcodeSymbology_Custom"]/*' />
    WalletBarcodeSymbology_Custom = 100000,
}
