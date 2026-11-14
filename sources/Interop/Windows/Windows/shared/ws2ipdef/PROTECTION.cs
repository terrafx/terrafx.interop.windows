// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PROTECTION
{
    /// <include file='PROTECTION.xml' path='doc/member[@name="PROTECTION.PROTECTION_LEVEL_UNRESTRICTED"]/*' />
    [NativeTypeName("#define PROTECTION_LEVEL_UNRESTRICTED 10")]
    public const int PROTECTION_LEVEL_UNRESTRICTED = 10;

    /// <include file='PROTECTION.xml' path='doc/member[@name="PROTECTION.PROTECTION_LEVEL_EDGERESTRICTED"]/*' />
    [NativeTypeName("#define PROTECTION_LEVEL_EDGERESTRICTED 20")]
    public const int PROTECTION_LEVEL_EDGERESTRICTED = 20;

    /// <include file='PROTECTION.xml' path='doc/member[@name="PROTECTION.PROTECTION_LEVEL_RESTRICTED"]/*' />
    [NativeTypeName("#define PROTECTION_LEVEL_RESTRICTED 30")]
    public const int PROTECTION_LEVEL_RESTRICTED = 30;

    /// <include file='PROTECTION.xml' path='doc/member[@name="PROTECTION.PROTECTION_LEVEL_DEFAULT"]/*' />
    [NativeTypeName("#define PROTECTION_LEVEL_DEFAULT ((UINT)-1)")]
    public const uint PROTECTION_LEVEL_DEFAULT = unchecked((uint)(-1));
}
