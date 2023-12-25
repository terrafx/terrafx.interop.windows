// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='FileProtectionStatus.xml' path='doc/member[@name="FileProtectionStatus"]/*' />
public enum FileProtectionStatus
{
    /// <include file='FileProtectionStatus.xml' path='doc/member[@name="FileProtectionStatus.FileProtectionStatus_Undetermined"]/*' />
    [Obsolete("Undetermined might be unavailable after Windows 10. Instead, use Unknown.")]
    FileProtectionStatus_Undetermined = 0,

    /// <include file='FileProtectionStatus.xml' path='doc/member[@name="FileProtectionStatus.FileProtectionStatus_Unknown"]/*' />
    FileProtectionStatus_Unknown = 0,

    /// <include file='FileProtectionStatus.xml' path='doc/member[@name="FileProtectionStatus.FileProtectionStatus_Unprotected"]/*' />
    FileProtectionStatus_Unprotected = 1,

    /// <include file='FileProtectionStatus.xml' path='doc/member[@name="FileProtectionStatus.FileProtectionStatus_Revoked"]/*' />
    FileProtectionStatus_Revoked = 2,

    /// <include file='FileProtectionStatus.xml' path='doc/member[@name="FileProtectionStatus.FileProtectionStatus_Protected"]/*' />
    FileProtectionStatus_Protected = 3,

    /// <include file='FileProtectionStatus.xml' path='doc/member[@name="FileProtectionStatus.FileProtectionStatus_ProtectedByOtherUser"]/*' />
    [Obsolete("ProtectedByOtherUser might be unavailable after Windows 10. Instead, use ProtectedToOtherIdentity.")]
    FileProtectionStatus_ProtectedByOtherUser = 4,

    /// <include file='FileProtectionStatus.xml' path='doc/member[@name="FileProtectionStatus.FileProtectionStatus_ProtectedToOtherEnterprise"]/*' />
    [Obsolete("ProtectedToOtherEnterprise might be unavailable after Windows 10. Instead, use ProtectedToOtherIdentity.")]
    FileProtectionStatus_ProtectedToOtherEnterprise = 5,

    /// <include file='FileProtectionStatus.xml' path='doc/member[@name="FileProtectionStatus.FileProtectionStatus_NotProtectable"]/*' />
    FileProtectionStatus_NotProtectable = 6,

    /// <include file='FileProtectionStatus.xml' path='doc/member[@name="FileProtectionStatus.FileProtectionStatus_ProtectedToOtherIdentity"]/*' />
    FileProtectionStatus_ProtectedToOtherIdentity = 7,

    /// <include file='FileProtectionStatus.xml' path='doc/member[@name="FileProtectionStatus.FileProtectionStatus_LicenseExpired"]/*' />
    FileProtectionStatus_LicenseExpired = 8,

    /// <include file='FileProtectionStatus.xml' path='doc/member[@name="FileProtectionStatus.FileProtectionStatus_AccessSuspended"]/*' />
    FileProtectionStatus_AccessSuspended = 9,

    /// <include file='FileProtectionStatus.xml' path='doc/member[@name="FileProtectionStatus.FileProtectionStatus_FileInUse"]/*' />
    FileProtectionStatus_FileInUse = 10,
}
