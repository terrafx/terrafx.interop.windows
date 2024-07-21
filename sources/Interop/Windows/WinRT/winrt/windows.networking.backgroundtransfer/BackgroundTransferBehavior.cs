// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BackgroundTransferBehavior.xml' path='doc/member[@name="BackgroundTransferBehavior"]/*' />
public enum BackgroundTransferBehavior
{
    /// <include file='BackgroundTransferBehavior.xml' path='doc/member[@name="BackgroundTransferBehavior.BackgroundTransferBehavior_Parallel"]/*' />
    BackgroundTransferBehavior_Parallel = 0,

    /// <include file='BackgroundTransferBehavior.xml' path='doc/member[@name="BackgroundTransferBehavior.BackgroundTransferBehavior_Serialized"]/*' />
    BackgroundTransferBehavior_Serialized = 1,
}
