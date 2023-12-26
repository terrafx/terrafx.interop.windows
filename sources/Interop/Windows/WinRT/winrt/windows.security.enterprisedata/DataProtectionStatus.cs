// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DataProtectionStatus.xml' path='doc/member[@name="DataProtectionStatus"]/*' />
public enum DataProtectionStatus
{
    /// <include file='DataProtectionStatus.xml' path='doc/member[@name="DataProtectionStatus.DataProtectionStatus_ProtectedToOtherIdentity"]/*' />
    DataProtectionStatus_ProtectedToOtherIdentity = 0,

    /// <include file='DataProtectionStatus.xml' path='doc/member[@name="DataProtectionStatus.DataProtectionStatus_Protected"]/*' />
    DataProtectionStatus_Protected = 1,

    /// <include file='DataProtectionStatus.xml' path='doc/member[@name="DataProtectionStatus.DataProtectionStatus_Revoked"]/*' />
    DataProtectionStatus_Revoked = 2,

    /// <include file='DataProtectionStatus.xml' path='doc/member[@name="DataProtectionStatus.DataProtectionStatus_Unprotected"]/*' />
    DataProtectionStatus_Unprotected = 3,

    /// <include file='DataProtectionStatus.xml' path='doc/member[@name="DataProtectionStatus.DataProtectionStatus_LicenseExpired"]/*' />
    DataProtectionStatus_LicenseExpired = 4,

    /// <include file='DataProtectionStatus.xml' path='doc/member[@name="DataProtectionStatus.DataProtectionStatus_AccessSuspended"]/*' />
    DataProtectionStatus_AccessSuspended = 5,
}
