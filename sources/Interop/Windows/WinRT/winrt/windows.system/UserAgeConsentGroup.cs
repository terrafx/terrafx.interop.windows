// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserAgeConsentGroup.xml' path='doc/member[@name="UserAgeConsentGroup"]/*' />
public enum UserAgeConsentGroup
{
    /// <include file='UserAgeConsentGroup.xml' path='doc/member[@name="UserAgeConsentGroup.UserAgeConsentGroup_Child"]/*' />
    UserAgeConsentGroup_Child = 0,

    /// <include file='UserAgeConsentGroup.xml' path='doc/member[@name="UserAgeConsentGroup.UserAgeConsentGroup_Minor"]/*' />
    UserAgeConsentGroup_Minor = 1,

    /// <include file='UserAgeConsentGroup.xml' path='doc/member[@name="UserAgeConsentGroup.UserAgeConsentGroup_Adult"]/*' />
    UserAgeConsentGroup_Adult = 2,
}
