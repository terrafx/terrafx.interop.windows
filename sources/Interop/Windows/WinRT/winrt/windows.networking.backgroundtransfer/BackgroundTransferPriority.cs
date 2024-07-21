// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BackgroundTransferPriority.xml' path='doc/member[@name="BackgroundTransferPriority"]/*' />
public enum BackgroundTransferPriority
{
    /// <include file='BackgroundTransferPriority.xml' path='doc/member[@name="BackgroundTransferPriority.BackgroundTransferPriority_Default"]/*' />
    BackgroundTransferPriority_Default = 0,

    /// <include file='BackgroundTransferPriority.xml' path='doc/member[@name="BackgroundTransferPriority.BackgroundTransferPriority_High"]/*' />
    BackgroundTransferPriority_High = 1,

    /// <include file='BackgroundTransferPriority.xml' path='doc/member[@name="BackgroundTransferPriority.BackgroundTransferPriority_Low"]/*' />
    BackgroundTransferPriority_Low = 2,
}
