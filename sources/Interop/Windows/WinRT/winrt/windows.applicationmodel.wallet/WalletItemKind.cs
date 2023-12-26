// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='WalletItemKind.xml' path='doc/member[@name="WalletItemKind"]/*' />
[Obsolete("WalletItemKind is deprecated and might not work on all platforms. For more info, see MSDN.")]
public enum WalletItemKind
{
    /// <include file='WalletItemKind.xml' path='doc/member[@name="WalletItemKind.WalletItemKind_Invalid"]/*' />
    WalletItemKind_Invalid = 0,

    /// <include file='WalletItemKind.xml' path='doc/member[@name="WalletItemKind.WalletItemKind_Deal"]/*' />
    WalletItemKind_Deal = 1,

    /// <include file='WalletItemKind.xml' path='doc/member[@name="WalletItemKind.WalletItemKind_General"]/*' />
    WalletItemKind_General = 2,

    /// <include file='WalletItemKind.xml' path='doc/member[@name="WalletItemKind.WalletItemKind_PaymentInstrument"]/*' />
    WalletItemKind_PaymentInstrument = 3,

    /// <include file='WalletItemKind.xml' path='doc/member[@name="WalletItemKind.WalletItemKind_Ticket"]/*' />
    WalletItemKind_Ticket = 4,

    /// <include file='WalletItemKind.xml' path='doc/member[@name="WalletItemKind.WalletItemKind_BoardingPass"]/*' />
    WalletItemKind_BoardingPass = 5,

    /// <include file='WalletItemKind.xml' path='doc/member[@name="WalletItemKind.WalletItemKind_MembershipCard"]/*' />
    WalletItemKind_MembershipCard = 6,
}
