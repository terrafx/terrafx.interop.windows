// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailBatchStatus.xml' path='doc/member[@name="EmailBatchStatus"]/*' />
public enum EmailBatchStatus
{
    /// <include file='EmailBatchStatus.xml' path='doc/member[@name="EmailBatchStatus.EmailBatchStatus_Success"]/*' />
    EmailBatchStatus_Success = 0,

    /// <include file='EmailBatchStatus.xml' path='doc/member[@name="EmailBatchStatus.EmailBatchStatus_ServerSearchSyncManagerError"]/*' />
    EmailBatchStatus_ServerSearchSyncManagerError = 1,

    /// <include file='EmailBatchStatus.xml' path='doc/member[@name="EmailBatchStatus.EmailBatchStatus_ServerSearchUnknownError"]/*' />
    EmailBatchStatus_ServerSearchUnknownError = 2,
}
