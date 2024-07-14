// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FileUpdateStatus.xml' path='doc/member[@name="FileUpdateStatus"]/*' />
public enum FileUpdateStatus
{
    /// <include file='FileUpdateStatus.xml' path='doc/member[@name="FileUpdateStatus.FileUpdateStatus_Incomplete"]/*' />
    FileUpdateStatus_Incomplete = 0,

    /// <include file='FileUpdateStatus.xml' path='doc/member[@name="FileUpdateStatus.FileUpdateStatus_Complete"]/*' />
    FileUpdateStatus_Complete = 1,

    /// <include file='FileUpdateStatus.xml' path='doc/member[@name="FileUpdateStatus.FileUpdateStatus_UserInputNeeded"]/*' />
    FileUpdateStatus_UserInputNeeded = 2,

    /// <include file='FileUpdateStatus.xml' path='doc/member[@name="FileUpdateStatus.FileUpdateStatus_CurrentlyUnavailable"]/*' />
    FileUpdateStatus_CurrentlyUnavailable = 3,

    /// <include file='FileUpdateStatus.xml' path='doc/member[@name="FileUpdateStatus.FileUpdateStatus_Failed"]/*' />
    FileUpdateStatus_Failed = 4,

    /// <include file='FileUpdateStatus.xml' path='doc/member[@name="FileUpdateStatus.FileUpdateStatus_CompleteAndRenamed"]/*' />
    FileUpdateStatus_CompleteAndRenamed = 5,
}
