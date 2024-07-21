// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='WalletSummaryViewPosition.xml' path='doc/member[@name="WalletSummaryViewPosition"]/*' />
[Obsolete("WalletSummaryViewPosition is deprecated and might not work on all platforms. For more info, see MSDN.")]
public enum WalletSummaryViewPosition
{
    /// <include file='WalletSummaryViewPosition.xml' path='doc/member[@name="WalletSummaryViewPosition.WalletSummaryViewPosition_Hidden"]/*' />
    WalletSummaryViewPosition_Hidden = 0,

    /// <include file='WalletSummaryViewPosition.xml' path='doc/member[@name="WalletSummaryViewPosition.WalletSummaryViewPosition_Field1"]/*' />
    WalletSummaryViewPosition_Field1 = 1,

    /// <include file='WalletSummaryViewPosition.xml' path='doc/member[@name="WalletSummaryViewPosition.WalletSummaryViewPosition_Field2"]/*' />
    WalletSummaryViewPosition_Field2 = 2,
}
