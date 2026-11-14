// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifmib.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ANY_SIZE"]/*' />
    [NativeTypeName("#define ANY_SIZE 1")]
    public const int ANY_SIZE = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MAXLEN_PHYSADDR"]/*' />
    [NativeTypeName("#define MAXLEN_PHYSADDR 8")]
    public const int MAXLEN_PHYSADDR = 8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MAXLEN_IFDESCR"]/*' />
    [NativeTypeName("#define MAXLEN_IFDESCR 256")]
    public const int MAXLEN_IFDESCR = 256;
}
