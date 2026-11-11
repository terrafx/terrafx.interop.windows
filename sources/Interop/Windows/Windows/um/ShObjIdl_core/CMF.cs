// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CMF
{
    /// <include file='CMF.xml' path='doc/member[@name="CMF.CMF_NORMAL"]/*' />
    [NativeTypeName("#define CMF_NORMAL 0x00000000")]
    public const int CMF_NORMAL = 0x00000000;

    /// <include file='CMF.xml' path='doc/member[@name="CMF.CMF_DEFAULTONLY"]/*' />
    [NativeTypeName("#define CMF_DEFAULTONLY 0x00000001")]
    public const int CMF_DEFAULTONLY = 0x00000001;

    /// <include file='CMF.xml' path='doc/member[@name="CMF.CMF_VERBSONLY"]/*' />
    [NativeTypeName("#define CMF_VERBSONLY 0x00000002")]
    public const int CMF_VERBSONLY = 0x00000002;

    /// <include file='CMF.xml' path='doc/member[@name="CMF.CMF_EXPLORE"]/*' />
    [NativeTypeName("#define CMF_EXPLORE 0x00000004")]
    public const int CMF_EXPLORE = 0x00000004;

    /// <include file='CMF.xml' path='doc/member[@name="CMF.CMF_NOVERBS"]/*' />
    [NativeTypeName("#define CMF_NOVERBS 0x00000008")]
    public const int CMF_NOVERBS = 0x00000008;

    /// <include file='CMF.xml' path='doc/member[@name="CMF.CMF_CANRENAME"]/*' />
    [NativeTypeName("#define CMF_CANRENAME 0x00000010")]
    public const int CMF_CANRENAME = 0x00000010;

    /// <include file='CMF.xml' path='doc/member[@name="CMF.CMF_NODEFAULT"]/*' />
    [NativeTypeName("#define CMF_NODEFAULT 0x00000020")]
    public const int CMF_NODEFAULT = 0x00000020;

    /// <include file='CMF.xml' path='doc/member[@name="CMF.CMF_ITEMMENU"]/*' />
    [NativeTypeName("#define CMF_ITEMMENU 0x00000080")]
    public const int CMF_ITEMMENU = 0x00000080;

    /// <include file='CMF.xml' path='doc/member[@name="CMF.CMF_EXTENDEDVERBS"]/*' />
    [NativeTypeName("#define CMF_EXTENDEDVERBS 0x00000100")]
    public const int CMF_EXTENDEDVERBS = 0x00000100;

    /// <include file='CMF.xml' path='doc/member[@name="CMF.CMF_DISABLEDVERBS"]/*' />
    [NativeTypeName("#define CMF_DISABLEDVERBS 0x00000200")]
    public const int CMF_DISABLEDVERBS = 0x00000200;

    /// <include file='CMF.xml' path='doc/member[@name="CMF.CMF_ASYNCVERBSTATE"]/*' />
    [NativeTypeName("#define CMF_ASYNCVERBSTATE 0x00000400")]
    public const int CMF_ASYNCVERBSTATE = 0x00000400;

    /// <include file='CMF.xml' path='doc/member[@name="CMF.CMF_OPTIMIZEFORINVOKE"]/*' />
    [NativeTypeName("#define CMF_OPTIMIZEFORINVOKE 0x00000800")]
    public const int CMF_OPTIMIZEFORINVOKE = 0x00000800;

    /// <include file='CMF.xml' path='doc/member[@name="CMF.CMF_SYNCCASCADEMENU"]/*' />
    [NativeTypeName("#define CMF_SYNCCASCADEMENU 0x00001000")]
    public const int CMF_SYNCCASCADEMENU = 0x00001000;

    /// <include file='CMF.xml' path='doc/member[@name="CMF.CMF_DONOTPICKDEFAULT"]/*' />
    [NativeTypeName("#define CMF_DONOTPICKDEFAULT 0x00002000")]
    public const int CMF_DONOTPICKDEFAULT = 0x00002000;

    /// <include file='CMF.xml' path='doc/member[@name="CMF.CMF_RESERVED"]/*' />
    [NativeTypeName("#define CMF_RESERVED 0xffff0000")]
    public const uint CMF_RESERVED = 0xffff0000;
}
