// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserAgeVerificationStatus.xml' path='doc/member[@name="UserAgeVerificationStatus"]/*' />
public enum UserAgeVerificationStatus
{
    /// <include file='UserAgeVerificationStatus.xml' path='doc/member[@name="UserAgeVerificationStatus.UserAgeVerificationStatus_NotApplicable"]/*' />
    UserAgeVerificationStatus_NotApplicable = 0,

    /// <include file='UserAgeVerificationStatus.xml' path='doc/member[@name="UserAgeVerificationStatus.UserAgeVerificationStatus_TemporarilyUnavailable"]/*' />
    UserAgeVerificationStatus_TemporarilyUnavailable = 1,

    /// <include file='UserAgeVerificationStatus.xml' path='doc/member[@name="UserAgeVerificationStatus.UserAgeVerificationStatus_Unverified"]/*' />
    UserAgeVerificationStatus_Unverified = 2,

    /// <include file='UserAgeVerificationStatus.xml' path='doc/member[@name="UserAgeVerificationStatus.UserAgeVerificationStatus_OptedOut"]/*' />
    UserAgeVerificationStatus_OptedOut = 3,

    /// <include file='UserAgeVerificationStatus.xml' path='doc/member[@name="UserAgeVerificationStatus.UserAgeVerificationStatus_Verified"]/*' />
    UserAgeVerificationStatus_Verified = 4,
}
