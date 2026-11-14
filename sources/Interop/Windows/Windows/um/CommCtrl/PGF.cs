// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PGF
{
    /// <include file='PGF.xml' path='doc/member[@name="PGF.PGF_INVISIBLE"]/*' />
    [NativeTypeName("#define PGF_INVISIBLE 0")]
    public const int PGF_INVISIBLE = 0;

    /// <include file='PGF.xml' path='doc/member[@name="PGF.PGF_NORMAL"]/*' />
    [NativeTypeName("#define PGF_NORMAL 1")]
    public const int PGF_NORMAL = 1;

    /// <include file='PGF.xml' path='doc/member[@name="PGF.PGF_GRAYED"]/*' />
    [NativeTypeName("#define PGF_GRAYED 2")]
    public const int PGF_GRAYED = 2;

    /// <include file='PGF.xml' path='doc/member[@name="PGF.PGF_DEPRESSED"]/*' />
    [NativeTypeName("#define PGF_DEPRESSED 4")]
    public const int PGF_DEPRESSED = 4;

    /// <include file='PGF.xml' path='doc/member[@name="PGF.PGF_HOT"]/*' />
    [NativeTypeName("#define PGF_HOT 8")]
    public const int PGF_HOT = 8;

    /// <include file='PGF.xml' path='doc/member[@name="PGF.PGF_SCROLLUP"]/*' />
    [NativeTypeName("#define PGF_SCROLLUP 1")]
    public const int PGF_SCROLLUP = 1;

    /// <include file='PGF.xml' path='doc/member[@name="PGF.PGF_SCROLLDOWN"]/*' />
    [NativeTypeName("#define PGF_SCROLLDOWN 2")]
    public const int PGF_SCROLLDOWN = 2;

    /// <include file='PGF.xml' path='doc/member[@name="PGF.PGF_SCROLLLEFT"]/*' />
    [NativeTypeName("#define PGF_SCROLLLEFT 4")]
    public const int PGF_SCROLLLEFT = 4;

    /// <include file='PGF.xml' path='doc/member[@name="PGF.PGF_SCROLLRIGHT"]/*' />
    [NativeTypeName("#define PGF_SCROLLRIGHT 8")]
    public const int PGF_SCROLLRIGHT = 8;

    /// <include file='PGF.xml' path='doc/member[@name="PGF.PGF_CALCWIDTH"]/*' />
    [NativeTypeName("#define PGF_CALCWIDTH 1")]
    public const int PGF_CALCWIDTH = 1;

    /// <include file='PGF.xml' path='doc/member[@name="PGF.PGF_CALCHEIGHT"]/*' />
    [NativeTypeName("#define PGF_CALCHEIGHT 2")]
    public const int PGF_CALCHEIGHT = 2;
}
