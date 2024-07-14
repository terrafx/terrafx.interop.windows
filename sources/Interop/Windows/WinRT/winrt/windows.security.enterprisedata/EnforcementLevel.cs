// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EnforcementLevel.xml' path='doc/member[@name="EnforcementLevel"]/*' />
public enum EnforcementLevel
{
    /// <include file='EnforcementLevel.xml' path='doc/member[@name="EnforcementLevel.EnforcementLevel_NoProtection"]/*' />
    EnforcementLevel_NoProtection = 0,

    /// <include file='EnforcementLevel.xml' path='doc/member[@name="EnforcementLevel.EnforcementLevel_Silent"]/*' />
    EnforcementLevel_Silent = 1,

    /// <include file='EnforcementLevel.xml' path='doc/member[@name="EnforcementLevel.EnforcementLevel_Override"]/*' />
    EnforcementLevel_Override = 2,

    /// <include file='EnforcementLevel.xml' path='doc/member[@name="EnforcementLevel.EnforcementLevel_Block"]/*' />
    EnforcementLevel_Block = 3,
}
