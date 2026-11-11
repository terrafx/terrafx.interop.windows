// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BROADCAST_NODETYPE"]/*' />
    [NativeTypeName("#define BROADCAST_NODETYPE 1")]
    public const int BROADCAST_NODETYPE = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MIXED_NODETYPE"]/*' />
    [NativeTypeName("#define MIXED_NODETYPE 4")]
    public const int MIXED_NODETYPE = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HYBRID_NODETYPE"]/*' />
    [NativeTypeName("#define HYBRID_NODETYPE 8")]
    public const int HYBRID_NODETYPE = 8;
}
