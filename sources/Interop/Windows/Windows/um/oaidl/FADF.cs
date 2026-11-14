// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FADF
{
    /// <include file='FADF.xml' path='doc/member[@name="FADF.FADF_AUTO"]/*' />
    [NativeTypeName("#define FADF_AUTO ( 0x1 )")]
    public const int FADF_AUTO = (0x1);

    /// <include file='FADF.xml' path='doc/member[@name="FADF.FADF_STATIC"]/*' />
    [NativeTypeName("#define FADF_STATIC ( 0x2 )")]
    public const int FADF_STATIC = (0x2);

    /// <include file='FADF.xml' path='doc/member[@name="FADF.FADF_EMBEDDED"]/*' />
    [NativeTypeName("#define FADF_EMBEDDED ( 0x4 )")]
    public const int FADF_EMBEDDED = (0x4);

    /// <include file='FADF.xml' path='doc/member[@name="FADF.FADF_FIXEDSIZE"]/*' />
    [NativeTypeName("#define FADF_FIXEDSIZE ( 0x10 )")]
    public const int FADF_FIXEDSIZE = (0x10);

    /// <include file='FADF.xml' path='doc/member[@name="FADF.FADF_RECORD"]/*' />
    [NativeTypeName("#define FADF_RECORD ( 0x20 )")]
    public const int FADF_RECORD = (0x20);

    /// <include file='FADF.xml' path='doc/member[@name="FADF.FADF_HAVEIID"]/*' />
    [NativeTypeName("#define FADF_HAVEIID ( 0x40 )")]
    public const int FADF_HAVEIID = (0x40);

    /// <include file='FADF.xml' path='doc/member[@name="FADF.FADF_HAVEVARTYPE"]/*' />
    [NativeTypeName("#define FADF_HAVEVARTYPE ( 0x80 )")]
    public const int FADF_HAVEVARTYPE = (0x80);

    /// <include file='FADF.xml' path='doc/member[@name="FADF.FADF_BSTR"]/*' />
    [NativeTypeName("#define FADF_BSTR ( 0x100 )")]
    public const int FADF_BSTR = (0x100);

    /// <include file='FADF.xml' path='doc/member[@name="FADF.FADF_UNKNOWN"]/*' />
    [NativeTypeName("#define FADF_UNKNOWN ( 0x200 )")]
    public const int FADF_UNKNOWN = (0x200);

    /// <include file='FADF.xml' path='doc/member[@name="FADF.FADF_DISPATCH"]/*' />
    [NativeTypeName("#define FADF_DISPATCH ( 0x400 )")]
    public const int FADF_DISPATCH = (0x400);

    /// <include file='FADF.xml' path='doc/member[@name="FADF.FADF_VARIANT"]/*' />
    [NativeTypeName("#define FADF_VARIANT ( 0x800 )")]
    public const int FADF_VARIANT = (0x800);

    /// <include file='FADF.xml' path='doc/member[@name="FADF.FADF_RESERVED"]/*' />
    [NativeTypeName("#define FADF_RESERVED ( 0xf008 )")]
    public const int FADF_RESERVED = (0xf008);
}
