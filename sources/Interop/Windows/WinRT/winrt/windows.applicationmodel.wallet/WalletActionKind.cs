// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='WalletActionKind.xml' path='doc/member[@name="WalletActionKind"]/*' />
[Obsolete("WalletActionKind is deprecated and might not work on all platforms. For more info, see MSDN.")]
public enum WalletActionKind
{
    /// <include file='WalletActionKind.xml' path='doc/member[@name="WalletActionKind.WalletActionKind_OpenItem"]/*' />
    WalletActionKind_OpenItem = 0,

    /// <include file='WalletActionKind.xml' path='doc/member[@name="WalletActionKind.WalletActionKind_Transaction"]/*' />
    WalletActionKind_Transaction = 1,

    /// <include file='WalletActionKind.xml' path='doc/member[@name="WalletActionKind.WalletActionKind_MoreTransactions"]/*' />
    WalletActionKind_MoreTransactions = 2,

    /// <include file='WalletActionKind.xml' path='doc/member[@name="WalletActionKind.WalletActionKind_Message"]/*' />
    WalletActionKind_Message = 3,

    /// <include file='WalletActionKind.xml' path='doc/member[@name="WalletActionKind.WalletActionKind_Verb"]/*' />
    WalletActionKind_Verb = 4,
}
