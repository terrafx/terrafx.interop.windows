// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='WalletDetailViewPosition.xml' path='doc/member[@name="WalletDetailViewPosition"]/*' />
[Obsolete("WalletDetailViewPosition is deprecated and might not work on all platforms. For more info, see MSDN.")]
public enum WalletDetailViewPosition
{
    /// <include file='WalletDetailViewPosition.xml' path='doc/member[@name="WalletDetailViewPosition.WalletDetailViewPosition_Hidden"]/*' />
    WalletDetailViewPosition_Hidden = 0,

    /// <include file='WalletDetailViewPosition.xml' path='doc/member[@name="WalletDetailViewPosition.WalletDetailViewPosition_HeaderField1"]/*' />
    WalletDetailViewPosition_HeaderField1 = 1,

    /// <include file='WalletDetailViewPosition.xml' path='doc/member[@name="WalletDetailViewPosition.WalletDetailViewPosition_HeaderField2"]/*' />
    WalletDetailViewPosition_HeaderField2 = 2,

    /// <include file='WalletDetailViewPosition.xml' path='doc/member[@name="WalletDetailViewPosition.WalletDetailViewPosition_PrimaryField1"]/*' />
    WalletDetailViewPosition_PrimaryField1 = 3,

    /// <include file='WalletDetailViewPosition.xml' path='doc/member[@name="WalletDetailViewPosition.WalletDetailViewPosition_PrimaryField2"]/*' />
    WalletDetailViewPosition_PrimaryField2 = 4,

    /// <include file='WalletDetailViewPosition.xml' path='doc/member[@name="WalletDetailViewPosition.WalletDetailViewPosition_SecondaryField1"]/*' />
    WalletDetailViewPosition_SecondaryField1 = 5,

    /// <include file='WalletDetailViewPosition.xml' path='doc/member[@name="WalletDetailViewPosition.WalletDetailViewPosition_SecondaryField2"]/*' />
    WalletDetailViewPosition_SecondaryField2 = 6,

    /// <include file='WalletDetailViewPosition.xml' path='doc/member[@name="WalletDetailViewPosition.WalletDetailViewPosition_SecondaryField3"]/*' />
    WalletDetailViewPosition_SecondaryField3 = 7,

    /// <include file='WalletDetailViewPosition.xml' path='doc/member[@name="WalletDetailViewPosition.WalletDetailViewPosition_SecondaryField4"]/*' />
    WalletDetailViewPosition_SecondaryField4 = 8,

    /// <include file='WalletDetailViewPosition.xml' path='doc/member[@name="WalletDetailViewPosition.WalletDetailViewPosition_SecondaryField5"]/*' />
    WalletDetailViewPosition_SecondaryField5 = 9,

    /// <include file='WalletDetailViewPosition.xml' path='doc/member[@name="WalletDetailViewPosition.WalletDetailViewPosition_CenterField1"]/*' />
    WalletDetailViewPosition_CenterField1 = 10,

    /// <include file='WalletDetailViewPosition.xml' path='doc/member[@name="WalletDetailViewPosition.WalletDetailViewPosition_FooterField1"]/*' />
    WalletDetailViewPosition_FooterField1 = 11,

    /// <include file='WalletDetailViewPosition.xml' path='doc/member[@name="WalletDetailViewPosition.WalletDetailViewPosition_FooterField2"]/*' />
    WalletDetailViewPosition_FooterField2 = 12,

    /// <include file='WalletDetailViewPosition.xml' path='doc/member[@name="WalletDetailViewPosition.WalletDetailViewPosition_FooterField3"]/*' />
    WalletDetailViewPosition_FooterField3 = 13,

    /// <include file='WalletDetailViewPosition.xml' path='doc/member[@name="WalletDetailViewPosition.WalletDetailViewPosition_FooterField4"]/*' />
    WalletDetailViewPosition_FooterField4 = 14,
}
