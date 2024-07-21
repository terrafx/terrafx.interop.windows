// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactBatchStatus.xml' path='doc/member[@name="ContactBatchStatus"]/*' />
public enum ContactBatchStatus
{
    /// <include file='ContactBatchStatus.xml' path='doc/member[@name="ContactBatchStatus.ContactBatchStatus_Success"]/*' />
    ContactBatchStatus_Success = 0,

    /// <include file='ContactBatchStatus.xml' path='doc/member[@name="ContactBatchStatus.ContactBatchStatus_ServerSearchSyncManagerError"]/*' />
    ContactBatchStatus_ServerSearchSyncManagerError = 1,

    /// <include file='ContactBatchStatus.xml' path='doc/member[@name="ContactBatchStatus.ContactBatchStatus_ServerSearchUnknownError"]/*' />
    ContactBatchStatus_ServerSearchUnknownError = 2,
}
