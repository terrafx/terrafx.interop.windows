// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TRUST_ATTRIBUTE
{
    /// <include file='TRUST_ATTRIBUTE.xml' path='doc/member[@name="TRUST_ATTRIBUTE.TRUST_ATTRIBUTES_VALID"]/*' />
    [NativeTypeName("#define TRUST_ATTRIBUTES_VALID 0xFF03FFFF")]
    public const uint TRUST_ATTRIBUTES_VALID = 0xFF03FFFF;

    /// <include file='TRUST_ATTRIBUTE.xml' path='doc/member[@name="TRUST_ATTRIBUTE.TRUST_ATTRIBUTES_USER"]/*' />
    [NativeTypeName("#define TRUST_ATTRIBUTES_USER 0xFF000000")]
    public const uint TRUST_ATTRIBUTES_USER = 0xFF000000;
}
