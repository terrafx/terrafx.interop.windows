// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserAgeConsentResult.xml' path='doc/member[@name="UserAgeConsentResult"]/*' />
public enum UserAgeConsentResult
{
    /// <include file='UserAgeConsentResult.xml' path='doc/member[@name="UserAgeConsentResult.UserAgeConsentResult_NotEnforced"]/*' />
    UserAgeConsentResult_NotEnforced = 0,

    /// <include file='UserAgeConsentResult.xml' path='doc/member[@name="UserAgeConsentResult.UserAgeConsentResult_Included"]/*' />
    UserAgeConsentResult_Included = 1,

    /// <include file='UserAgeConsentResult.xml' path='doc/member[@name="UserAgeConsentResult.UserAgeConsentResult_NotIncluded"]/*' />
    UserAgeConsentResult_NotIncluded = 2,

    /// <include file='UserAgeConsentResult.xml' path='doc/member[@name="UserAgeConsentResult.UserAgeConsentResult_Unknown"]/*' />
    UserAgeConsentResult_Unknown = 3,

    /// <include file='UserAgeConsentResult.xml' path='doc/member[@name="UserAgeConsentResult.UserAgeConsentResult_Ambiguous"]/*' />
    UserAgeConsentResult_Ambiguous = 4,
}
