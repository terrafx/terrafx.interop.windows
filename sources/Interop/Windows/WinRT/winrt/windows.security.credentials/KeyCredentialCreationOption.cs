// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='KeyCredentialCreationOption.xml' path='doc/member[@name="KeyCredentialCreationOption"]/*' />
public enum KeyCredentialCreationOption
{
    /// <include file='KeyCredentialCreationOption.xml' path='doc/member[@name="KeyCredentialCreationOption.KeyCredentialCreationOption_ReplaceExisting"]/*' />
    KeyCredentialCreationOption_ReplaceExisting = 0,

    /// <include file='KeyCredentialCreationOption.xml' path='doc/member[@name="KeyCredentialCreationOption.KeyCredentialCreationOption_FailIfExists"]/*' />
    KeyCredentialCreationOption_FailIfExists = 1,
}
