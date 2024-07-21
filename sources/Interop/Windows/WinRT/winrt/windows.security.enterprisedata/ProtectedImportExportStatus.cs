// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ProtectedImportExportStatus.xml' path='doc/member[@name="ProtectedImportExportStatus"]/*' />
public enum ProtectedImportExportStatus
{
    /// <include file='ProtectedImportExportStatus.xml' path='doc/member[@name="ProtectedImportExportStatus.ProtectedImportExportStatus_Ok"]/*' />
    ProtectedImportExportStatus_Ok = 0,

    /// <include file='ProtectedImportExportStatus.xml' path='doc/member[@name="ProtectedImportExportStatus.ProtectedImportExportStatus_Undetermined"]/*' />
    ProtectedImportExportStatus_Undetermined = 1,

    /// <include file='ProtectedImportExportStatus.xml' path='doc/member[@name="ProtectedImportExportStatus.ProtectedImportExportStatus_Unprotected"]/*' />
    ProtectedImportExportStatus_Unprotected = 2,

    /// <include file='ProtectedImportExportStatus.xml' path='doc/member[@name="ProtectedImportExportStatus.ProtectedImportExportStatus_Revoked"]/*' />
    ProtectedImportExportStatus_Revoked = 3,

    /// <include file='ProtectedImportExportStatus.xml' path='doc/member[@name="ProtectedImportExportStatus.ProtectedImportExportStatus_NotRoamable"]/*' />
    ProtectedImportExportStatus_NotRoamable = 4,

    /// <include file='ProtectedImportExportStatus.xml' path='doc/member[@name="ProtectedImportExportStatus.ProtectedImportExportStatus_ProtectedToOtherIdentity"]/*' />
    ProtectedImportExportStatus_ProtectedToOtherIdentity = 5,

    /// <include file='ProtectedImportExportStatus.xml' path='doc/member[@name="ProtectedImportExportStatus.ProtectedImportExportStatus_LicenseExpired"]/*' />
    ProtectedImportExportStatus_LicenseExpired = 6,

    /// <include file='ProtectedImportExportStatus.xml' path='doc/member[@name="ProtectedImportExportStatus.ProtectedImportExportStatus_AccessSuspended"]/*' />
    ProtectedImportExportStatus_AccessSuspended = 7,
}
