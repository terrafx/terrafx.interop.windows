// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BackgroundTransferCostPolicy.xml' path='doc/member[@name="BackgroundTransferCostPolicy"]/*' />
public enum BackgroundTransferCostPolicy
{
    /// <include file='BackgroundTransferCostPolicy.xml' path='doc/member[@name="BackgroundTransferCostPolicy.BackgroundTransferCostPolicy_Default"]/*' />
    BackgroundTransferCostPolicy_Default = 0,

    /// <include file='BackgroundTransferCostPolicy.xml' path='doc/member[@name="BackgroundTransferCostPolicy.BackgroundTransferCostPolicy_UnrestrictedOnly"]/*' />
    BackgroundTransferCostPolicy_UnrestrictedOnly = 1,

    /// <include file='BackgroundTransferCostPolicy.xml' path='doc/member[@name="BackgroundTransferCostPolicy.BackgroundTransferCostPolicy_Always"]/*' />
    BackgroundTransferCostPolicy_Always = 2,
}
