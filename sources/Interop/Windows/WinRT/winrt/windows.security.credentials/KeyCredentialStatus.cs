// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='KeyCredentialStatus.xml' path='doc/member[@name="KeyCredentialStatus"]/*' />
public enum KeyCredentialStatus
{
    /// <include file='KeyCredentialStatus.xml' path='doc/member[@name="KeyCredentialStatus.KeyCredentialStatus_Success"]/*' />
    KeyCredentialStatus_Success = 0,

    /// <include file='KeyCredentialStatus.xml' path='doc/member[@name="KeyCredentialStatus.KeyCredentialStatus_UnknownError"]/*' />
    KeyCredentialStatus_UnknownError = 1,

    /// <include file='KeyCredentialStatus.xml' path='doc/member[@name="KeyCredentialStatus.KeyCredentialStatus_NotFound"]/*' />
    KeyCredentialStatus_NotFound = 2,

    /// <include file='KeyCredentialStatus.xml' path='doc/member[@name="KeyCredentialStatus.KeyCredentialStatus_UserCanceled"]/*' />
    KeyCredentialStatus_UserCanceled = 3,

    /// <include file='KeyCredentialStatus.xml' path='doc/member[@name="KeyCredentialStatus.KeyCredentialStatus_UserPrefersPassword"]/*' />
    KeyCredentialStatus_UserPrefersPassword = 4,

    /// <include file='KeyCredentialStatus.xml' path='doc/member[@name="KeyCredentialStatus.KeyCredentialStatus_CredentialAlreadyExists"]/*' />
    KeyCredentialStatus_CredentialAlreadyExists = 5,

    /// <include file='KeyCredentialStatus.xml' path='doc/member[@name="KeyCredentialStatus.KeyCredentialStatus_SecurityDeviceLocked"]/*' />
    KeyCredentialStatus_SecurityDeviceLocked = 6,
}
