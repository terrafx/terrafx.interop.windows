// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='KeyProtectionLevel.xml' path='doc/member[@name="KeyProtectionLevel"]/*' />
public enum KeyProtectionLevel
{
    /// <include file='KeyProtectionLevel.xml' path='doc/member[@name="KeyProtectionLevel.KeyProtectionLevel_NoConsent"]/*' />
    KeyProtectionLevel_NoConsent = 0,

    /// <include file='KeyProtectionLevel.xml' path='doc/member[@name="KeyProtectionLevel.KeyProtectionLevel_ConsentOnly"]/*' />
    KeyProtectionLevel_ConsentOnly = 1,

    /// <include file='KeyProtectionLevel.xml' path='doc/member[@name="KeyProtectionLevel.KeyProtectionLevel_ConsentWithPassword"]/*' />
    KeyProtectionLevel_ConsentWithPassword = 2,

    /// <include file='KeyProtectionLevel.xml' path='doc/member[@name="KeyProtectionLevel.KeyProtectionLevel_ConsentWithFingerprint"]/*' />
    KeyProtectionLevel_ConsentWithFingerprint = 3,
}
