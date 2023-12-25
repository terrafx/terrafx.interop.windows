// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='KnownFoldersAccessStatus.xml' path='doc/member[@name="KnownFoldersAccessStatus"]/*' />
public enum KnownFoldersAccessStatus
{
    /// <include file='KnownFoldersAccessStatus.xml' path='doc/member[@name="KnownFoldersAccessStatus.KnownFoldersAccessStatus_DeniedBySystem"]/*' />
    KnownFoldersAccessStatus_DeniedBySystem = 0,

    /// <include file='KnownFoldersAccessStatus.xml' path='doc/member[@name="KnownFoldersAccessStatus.KnownFoldersAccessStatus_NotDeclaredByApp"]/*' />
    KnownFoldersAccessStatus_NotDeclaredByApp = 1,

    /// <include file='KnownFoldersAccessStatus.xml' path='doc/member[@name="KnownFoldersAccessStatus.KnownFoldersAccessStatus_DeniedByUser"]/*' />
    KnownFoldersAccessStatus_DeniedByUser = 2,

    /// <include file='KnownFoldersAccessStatus.xml' path='doc/member[@name="KnownFoldersAccessStatus.KnownFoldersAccessStatus_UserPromptRequired"]/*' />
    KnownFoldersAccessStatus_UserPromptRequired = 3,

    /// <include file='KnownFoldersAccessStatus.xml' path='doc/member[@name="KnownFoldersAccessStatus.KnownFoldersAccessStatus_Allowed"]/*' />
    KnownFoldersAccessStatus_Allowed = 4,

    /// <include file='KnownFoldersAccessStatus.xml' path='doc/member[@name="KnownFoldersAccessStatus.KnownFoldersAccessStatus_AllowedPerAppFolder"]/*' />
    KnownFoldersAccessStatus_AllowedPerAppFolder = 5,
}
