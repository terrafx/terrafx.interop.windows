// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailStoreAccessType.xml' path='doc/member[@name="EmailStoreAccessType"]/*' />
public enum EmailStoreAccessType
{
    /// <include file='EmailStoreAccessType.xml' path='doc/member[@name="EmailStoreAccessType.EmailStoreAccessType_AppMailboxesReadWrite"]/*' />
    EmailStoreAccessType_AppMailboxesReadWrite = 0,

    /// <include file='EmailStoreAccessType.xml' path='doc/member[@name="EmailStoreAccessType.EmailStoreAccessType_AllMailboxesLimitedReadWrite"]/*' />
    EmailStoreAccessType_AllMailboxesLimitedReadWrite = 1,
}
