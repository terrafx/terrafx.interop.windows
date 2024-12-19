// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_PROTECTION_LEVEL_TYPE.xml' path='doc/member[@name="HTTP_PROTECTION_LEVEL_TYPE"]/*' />
public enum HTTP_PROTECTION_LEVEL_TYPE
{
    /// <include file='HTTP_PROTECTION_LEVEL_TYPE.xml' path='doc/member[@name="HTTP_PROTECTION_LEVEL_TYPE.HttpProtectionLevelUnrestricted"]/*' />
    HttpProtectionLevelUnrestricted,

    /// <include file='HTTP_PROTECTION_LEVEL_TYPE.xml' path='doc/member[@name="HTTP_PROTECTION_LEVEL_TYPE.HttpProtectionLevelEdgeRestricted"]/*' />
    HttpProtectionLevelEdgeRestricted,

    /// <include file='HTTP_PROTECTION_LEVEL_TYPE.xml' path='doc/member[@name="HTTP_PROTECTION_LEVEL_TYPE.HttpProtectionLevelRestricted"]/*' />
    HttpProtectionLevelRestricted,
}
