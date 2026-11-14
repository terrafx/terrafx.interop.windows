// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TYPE
{
    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_BUFFERTOOSMALL"]/*' />
    [NativeTypeName("#define TYPE_E_BUFFERTOOSMALL _HRESULT_TYPEDEF_(0x80028016L)")]
    public const int TYPE_E_BUFFERTOOSMALL = unchecked((int)(0x80028016));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_FIELDNOTFOUND"]/*' />
    [NativeTypeName("#define TYPE_E_FIELDNOTFOUND _HRESULT_TYPEDEF_(0x80028017L)")]
    public const int TYPE_E_FIELDNOTFOUND = unchecked((int)(0x80028017));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_INVDATAREAD"]/*' />
    [NativeTypeName("#define TYPE_E_INVDATAREAD _HRESULT_TYPEDEF_(0x80028018L)")]
    public const int TYPE_E_INVDATAREAD = unchecked((int)(0x80028018));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_UNSUPFORMAT"]/*' />
    [NativeTypeName("#define TYPE_E_UNSUPFORMAT _HRESULT_TYPEDEF_(0x80028019L)")]
    public const int TYPE_E_UNSUPFORMAT = unchecked((int)(0x80028019));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_REGISTRYACCESS"]/*' />
    [NativeTypeName("#define TYPE_E_REGISTRYACCESS _HRESULT_TYPEDEF_(0x8002801CL)")]
    public const int TYPE_E_REGISTRYACCESS = unchecked((int)(0x8002801C));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_LIBNOTREGISTERED"]/*' />
    [NativeTypeName("#define TYPE_E_LIBNOTREGISTERED _HRESULT_TYPEDEF_(0x8002801DL)")]
    public const int TYPE_E_LIBNOTREGISTERED = unchecked((int)(0x8002801D));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_UNDEFINEDTYPE"]/*' />
    [NativeTypeName("#define TYPE_E_UNDEFINEDTYPE _HRESULT_TYPEDEF_(0x80028027L)")]
    public const int TYPE_E_UNDEFINEDTYPE = unchecked((int)(0x80028027));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_QUALIFIEDNAMEDISALLOWED"]/*' />
    [NativeTypeName("#define TYPE_E_QUALIFIEDNAMEDISALLOWED _HRESULT_TYPEDEF_(0x80028028L)")]
    public const int TYPE_E_QUALIFIEDNAMEDISALLOWED = unchecked((int)(0x80028028));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_INVALIDSTATE"]/*' />
    [NativeTypeName("#define TYPE_E_INVALIDSTATE _HRESULT_TYPEDEF_(0x80028029L)")]
    public const int TYPE_E_INVALIDSTATE = unchecked((int)(0x80028029));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_WRONGTYPEKIND"]/*' />
    [NativeTypeName("#define TYPE_E_WRONGTYPEKIND _HRESULT_TYPEDEF_(0x8002802AL)")]
    public const int TYPE_E_WRONGTYPEKIND = unchecked((int)(0x8002802A));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_ELEMENTNOTFOUND"]/*' />
    [NativeTypeName("#define TYPE_E_ELEMENTNOTFOUND _HRESULT_TYPEDEF_(0x8002802BL)")]
    public const int TYPE_E_ELEMENTNOTFOUND = unchecked((int)(0x8002802B));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_AMBIGUOUSNAME"]/*' />
    [NativeTypeName("#define TYPE_E_AMBIGUOUSNAME _HRESULT_TYPEDEF_(0x8002802CL)")]
    public const int TYPE_E_AMBIGUOUSNAME = unchecked((int)(0x8002802C));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_NAMECONFLICT"]/*' />
    [NativeTypeName("#define TYPE_E_NAMECONFLICT _HRESULT_TYPEDEF_(0x8002802DL)")]
    public const int TYPE_E_NAMECONFLICT = unchecked((int)(0x8002802D));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_UNKNOWNLCID"]/*' />
    [NativeTypeName("#define TYPE_E_UNKNOWNLCID _HRESULT_TYPEDEF_(0x8002802EL)")]
    public const int TYPE_E_UNKNOWNLCID = unchecked((int)(0x8002802E));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_DLLFUNCTIONNOTFOUND"]/*' />
    [NativeTypeName("#define TYPE_E_DLLFUNCTIONNOTFOUND _HRESULT_TYPEDEF_(0x8002802FL)")]
    public const int TYPE_E_DLLFUNCTIONNOTFOUND = unchecked((int)(0x8002802F));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_BADMODULEKIND"]/*' />
    [NativeTypeName("#define TYPE_E_BADMODULEKIND _HRESULT_TYPEDEF_(0x800288BDL)")]
    public const int TYPE_E_BADMODULEKIND = unchecked((int)(0x800288BD));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_SIZETOOBIG"]/*' />
    [NativeTypeName("#define TYPE_E_SIZETOOBIG _HRESULT_TYPEDEF_(0x800288C5L)")]
    public const int TYPE_E_SIZETOOBIG = unchecked((int)(0x800288C5));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_DUPLICATEID"]/*' />
    [NativeTypeName("#define TYPE_E_DUPLICATEID _HRESULT_TYPEDEF_(0x800288C6L)")]
    public const int TYPE_E_DUPLICATEID = unchecked((int)(0x800288C6));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_INVALIDID"]/*' />
    [NativeTypeName("#define TYPE_E_INVALIDID _HRESULT_TYPEDEF_(0x800288CFL)")]
    public const int TYPE_E_INVALIDID = unchecked((int)(0x800288CF));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_TYPEMISMATCH"]/*' />
    [NativeTypeName("#define TYPE_E_TYPEMISMATCH _HRESULT_TYPEDEF_(0x80028CA0L)")]
    public const int TYPE_E_TYPEMISMATCH = unchecked((int)(0x80028CA0));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_OUTOFBOUNDS"]/*' />
    [NativeTypeName("#define TYPE_E_OUTOFBOUNDS _HRESULT_TYPEDEF_(0x80028CA1L)")]
    public const int TYPE_E_OUTOFBOUNDS = unchecked((int)(0x80028CA1));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_IOERROR"]/*' />
    [NativeTypeName("#define TYPE_E_IOERROR _HRESULT_TYPEDEF_(0x80028CA2L)")]
    public const int TYPE_E_IOERROR = unchecked((int)(0x80028CA2));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_CANTCREATETMPFILE"]/*' />
    [NativeTypeName("#define TYPE_E_CANTCREATETMPFILE _HRESULT_TYPEDEF_(0x80028CA3L)")]
    public const int TYPE_E_CANTCREATETMPFILE = unchecked((int)(0x80028CA3));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_CANTLOADLIBRARY"]/*' />
    [NativeTypeName("#define TYPE_E_CANTLOADLIBRARY _HRESULT_TYPEDEF_(0x80029C4AL)")]
    public const int TYPE_E_CANTLOADLIBRARY = unchecked((int)(0x80029C4A));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_INCONSISTENTPROPFUNCS"]/*' />
    [NativeTypeName("#define TYPE_E_INCONSISTENTPROPFUNCS _HRESULT_TYPEDEF_(0x80029C83L)")]
    public const int TYPE_E_INCONSISTENTPROPFUNCS = unchecked((int)(0x80029C83));

    /// <include file='TYPE.xml' path='doc/member[@name="TYPE.TYPE_E_CIRCULARTYPE"]/*' />
    [NativeTypeName("#define TYPE_E_CIRCULARTYPE _HRESULT_TYPEDEF_(0x80029C84L)")]
    public const int TYPE_E_CIRCULARTYPE = unchecked((int)(0x80029C84));
}
