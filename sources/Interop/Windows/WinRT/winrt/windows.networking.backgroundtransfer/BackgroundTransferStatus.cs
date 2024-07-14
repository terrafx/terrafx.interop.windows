// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BackgroundTransferStatus.xml' path='doc/member[@name="BackgroundTransferStatus"]/*' />
public enum BackgroundTransferStatus
{
    /// <include file='BackgroundTransferStatus.xml' path='doc/member[@name="BackgroundTransferStatus.BackgroundTransferStatus_Idle"]/*' />
    BackgroundTransferStatus_Idle = 0,

    /// <include file='BackgroundTransferStatus.xml' path='doc/member[@name="BackgroundTransferStatus.BackgroundTransferStatus_Running"]/*' />
    BackgroundTransferStatus_Running = 1,

    /// <include file='BackgroundTransferStatus.xml' path='doc/member[@name="BackgroundTransferStatus.BackgroundTransferStatus_PausedByApplication"]/*' />
    BackgroundTransferStatus_PausedByApplication = 2,

    /// <include file='BackgroundTransferStatus.xml' path='doc/member[@name="BackgroundTransferStatus.BackgroundTransferStatus_PausedCostedNetwork"]/*' />
    BackgroundTransferStatus_PausedCostedNetwork = 3,

    /// <include file='BackgroundTransferStatus.xml' path='doc/member[@name="BackgroundTransferStatus.BackgroundTransferStatus_PausedNoNetwork"]/*' />
    BackgroundTransferStatus_PausedNoNetwork = 4,

    /// <include file='BackgroundTransferStatus.xml' path='doc/member[@name="BackgroundTransferStatus.BackgroundTransferStatus_Completed"]/*' />
    BackgroundTransferStatus_Completed = 5,

    /// <include file='BackgroundTransferStatus.xml' path='doc/member[@name="BackgroundTransferStatus.BackgroundTransferStatus_Canceled"]/*' />
    BackgroundTransferStatus_Canceled = 6,

    /// <include file='BackgroundTransferStatus.xml' path='doc/member[@name="BackgroundTransferStatus.BackgroundTransferStatus_Error"]/*' />
    BackgroundTransferStatus_Error = 7,

    /// <include file='BackgroundTransferStatus.xml' path='doc/member[@name="BackgroundTransferStatus.BackgroundTransferStatus_PausedRecoverableWebErrorStatus"]/*' />
    BackgroundTransferStatus_PausedRecoverableWebErrorStatus = 8,

    /// <include file='BackgroundTransferStatus.xml' path='doc/member[@name="BackgroundTransferStatus.BackgroundTransferStatus_PausedSystemPolicy"]/*' />
    BackgroundTransferStatus_PausedSystemPolicy = 32,
}
