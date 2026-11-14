// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class RBN
{
    /// <include file='RBN.xml' path='doc/member[@name="RBN.RBN_FIRST"]/*' />
    [NativeTypeName("#define RBN_FIRST (0U-831U)")]
    public const uint RBN_FIRST = unchecked(0U - 831U);

    /// <include file='RBN.xml' path='doc/member[@name="RBN.RBN_LAST"]/*' />
    [NativeTypeName("#define RBN_LAST (0U-859U)")]
    public const uint RBN_LAST = unchecked(0U - 859U);

    /// <include file='RBN.xml' path='doc/member[@name="RBN.RBN_HEIGHTCHANGE"]/*' />
    [NativeTypeName("#define RBN_HEIGHTCHANGE (RBN_FIRST - 0)")]
    public const uint RBN_HEIGHTCHANGE = unchecked((0U - 831U) - 0);

    /// <include file='RBN.xml' path='doc/member[@name="RBN.RBN_GETOBJECT"]/*' />
    [NativeTypeName("#define RBN_GETOBJECT (RBN_FIRST - 1)")]
    public const uint RBN_GETOBJECT = unchecked((0U - 831U) - 1);

    /// <include file='RBN.xml' path='doc/member[@name="RBN.RBN_LAYOUTCHANGED"]/*' />
    [NativeTypeName("#define RBN_LAYOUTCHANGED (RBN_FIRST - 2)")]
    public const uint RBN_LAYOUTCHANGED = unchecked((0U - 831U) - 2);

    /// <include file='RBN.xml' path='doc/member[@name="RBN.RBN_AUTOSIZE"]/*' />
    [NativeTypeName("#define RBN_AUTOSIZE (RBN_FIRST - 3)")]
    public const uint RBN_AUTOSIZE = unchecked((0U - 831U) - 3);

    /// <include file='RBN.xml' path='doc/member[@name="RBN.RBN_BEGINDRAG"]/*' />
    [NativeTypeName("#define RBN_BEGINDRAG (RBN_FIRST - 4)")]
    public const uint RBN_BEGINDRAG = unchecked((0U - 831U) - 4);

    /// <include file='RBN.xml' path='doc/member[@name="RBN.RBN_ENDDRAG"]/*' />
    [NativeTypeName("#define RBN_ENDDRAG (RBN_FIRST - 5)")]
    public const uint RBN_ENDDRAG = unchecked((0U - 831U) - 5);

    /// <include file='RBN.xml' path='doc/member[@name="RBN.RBN_DELETINGBAND"]/*' />
    [NativeTypeName("#define RBN_DELETINGBAND (RBN_FIRST - 6)")]
    public const uint RBN_DELETINGBAND = unchecked((0U - 831U) - 6);

    /// <include file='RBN.xml' path='doc/member[@name="RBN.RBN_DELETEDBAND"]/*' />
    [NativeTypeName("#define RBN_DELETEDBAND (RBN_FIRST - 7)")]
    public const uint RBN_DELETEDBAND = unchecked((0U - 831U) - 7);

    /// <include file='RBN.xml' path='doc/member[@name="RBN.RBN_CHILDSIZE"]/*' />
    [NativeTypeName("#define RBN_CHILDSIZE (RBN_FIRST - 8)")]
    public const uint RBN_CHILDSIZE = unchecked((0U - 831U) - 8);

    /// <include file='RBN.xml' path='doc/member[@name="RBN.RBN_CHEVRONPUSHED"]/*' />
    [NativeTypeName("#define RBN_CHEVRONPUSHED (RBN_FIRST - 10)")]
    public const uint RBN_CHEVRONPUSHED = unchecked((0U - 831U) - 10);

    /// <include file='RBN.xml' path='doc/member[@name="RBN.RBN_SPLITTERDRAG"]/*' />
    [NativeTypeName("#define RBN_SPLITTERDRAG (RBN_FIRST - 11)")]
    public const uint RBN_SPLITTERDRAG = unchecked((0U - 831U) - 11);

    /// <include file='RBN.xml' path='doc/member[@name="RBN.RBN_MINMAX"]/*' />
    [NativeTypeName("#define RBN_MINMAX (RBN_FIRST - 21)")]
    public const uint RBN_MINMAX = unchecked((0U - 831U) - 21);

    /// <include file='RBN.xml' path='doc/member[@name="RBN.RBN_AUTOBREAK"]/*' />
    [NativeTypeName("#define RBN_AUTOBREAK (RBN_FIRST - 22)")]
    public const uint RBN_AUTOBREAK = unchecked((0U - 831U) - 22);
}
