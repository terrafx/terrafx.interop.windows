// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleauto.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class VARCMP
{
    /// <include file='VARCMP.xml' path='doc/member[@name="VARCMP.VARCMP_LT"]/*' />
    [NativeTypeName("#define VARCMP_LT 0")]
    public const int VARCMP_LT = 0;

    /// <include file='VARCMP.xml' path='doc/member[@name="VARCMP.VARCMP_EQ"]/*' />
    [NativeTypeName("#define VARCMP_EQ 1")]
    public const int VARCMP_EQ = 1;

    /// <include file='VARCMP.xml' path='doc/member[@name="VARCMP.VARCMP_GT"]/*' />
    [NativeTypeName("#define VARCMP_GT 2")]
    public const int VARCMP_GT = 2;

    /// <include file='VARCMP.xml' path='doc/member[@name="VARCMP.VARCMP_NULL"]/*' />
    [NativeTypeName("#define VARCMP_NULL 3")]
    public const int VARCMP_NULL = 3;
}
