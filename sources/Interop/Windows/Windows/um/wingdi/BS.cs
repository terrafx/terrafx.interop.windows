// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class BS
{
    /// <include file='BS.xml' path='doc/member[@name="BS.BS_SOLID"]/*' />
    [NativeTypeName("#define BS_SOLID 0")]
    public const int BS_SOLID = 0;

    /// <include file='BS.xml' path='doc/member[@name="BS.BS_NULL"]/*' />
    [NativeTypeName("#define BS_NULL 1")]
    public const int BS_NULL = 1;

    /// <include file='BS.xml' path='doc/member[@name="BS.BS_HOLLOW"]/*' />
    [NativeTypeName("#define BS_HOLLOW BS_NULL")]
    public const int BS_HOLLOW = 1;

    /// <include file='BS.xml' path='doc/member[@name="BS.BS_HATCHED"]/*' />
    [NativeTypeName("#define BS_HATCHED 2")]
    public const int BS_HATCHED = 2;

    /// <include file='BS.xml' path='doc/member[@name="BS.BS_PATTERN"]/*' />
    [NativeTypeName("#define BS_PATTERN 3")]
    public const int BS_PATTERN = 3;

    /// <include file='BS.xml' path='doc/member[@name="BS.BS_INDEXED"]/*' />
    [NativeTypeName("#define BS_INDEXED 4")]
    public const int BS_INDEXED = 4;

    /// <include file='BS.xml' path='doc/member[@name="BS.BS_DIBPATTERN"]/*' />
    [NativeTypeName("#define BS_DIBPATTERN 5")]
    public const int BS_DIBPATTERN = 5;

    /// <include file='BS.xml' path='doc/member[@name="BS.BS_DIBPATTERNPT"]/*' />
    [NativeTypeName("#define BS_DIBPATTERNPT 6")]
    public const int BS_DIBPATTERNPT = 6;

    /// <include file='BS.xml' path='doc/member[@name="BS.BS_PATTERN8X8"]/*' />
    [NativeTypeName("#define BS_PATTERN8X8 7")]
    public const int BS_PATTERN8X8 = 7;

    /// <include file='BS.xml' path='doc/member[@name="BS.BS_DIBPATTERN8X8"]/*' />
    [NativeTypeName("#define BS_DIBPATTERN8X8 8")]
    public const int BS_DIBPATTERN8X8 = 8;

    /// <include file='BS.xml' path='doc/member[@name="BS.BS_MONOPATTERN"]/*' />
    [NativeTypeName("#define BS_MONOPATTERN 9")]
    public const int BS_MONOPATTERN = 9;
}
