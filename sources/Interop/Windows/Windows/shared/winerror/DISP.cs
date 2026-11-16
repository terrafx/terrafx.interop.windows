// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DISP
{
    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_UNKNOWNINTERFACE"]/*' />
    [NativeTypeName("#define DISP_E_UNKNOWNINTERFACE _HRESULT_TYPEDEF_(0x80020001L)")]
    public const int DISP_E_UNKNOWNINTERFACE = unchecked((int)(0x80020001));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_MEMBERNOTFOUND"]/*' />
    [NativeTypeName("#define DISP_E_MEMBERNOTFOUND _HRESULT_TYPEDEF_(0x80020003L)")]
    public const int DISP_E_MEMBERNOTFOUND = unchecked((int)(0x80020003));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_PARAMNOTFOUND"]/*' />
    [NativeTypeName("#define DISP_E_PARAMNOTFOUND _HRESULT_TYPEDEF_(0x80020004L)")]
    public const int DISP_E_PARAMNOTFOUND = unchecked((int)(0x80020004));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_TYPEMISMATCH"]/*' />
    [NativeTypeName("#define DISP_E_TYPEMISMATCH _HRESULT_TYPEDEF_(0x80020005L)")]
    public const int DISP_E_TYPEMISMATCH = unchecked((int)(0x80020005));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_UNKNOWNNAME"]/*' />
    [NativeTypeName("#define DISP_E_UNKNOWNNAME _HRESULT_TYPEDEF_(0x80020006L)")]
    public const int DISP_E_UNKNOWNNAME = unchecked((int)(0x80020006));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_NONAMEDARGS"]/*' />
    [NativeTypeName("#define DISP_E_NONAMEDARGS _HRESULT_TYPEDEF_(0x80020007L)")]
    public const int DISP_E_NONAMEDARGS = unchecked((int)(0x80020007));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_BADVARTYPE"]/*' />
    [NativeTypeName("#define DISP_E_BADVARTYPE _HRESULT_TYPEDEF_(0x80020008L)")]
    public const int DISP_E_BADVARTYPE = unchecked((int)(0x80020008));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_EXCEPTION"]/*' />
    [NativeTypeName("#define DISP_E_EXCEPTION _HRESULT_TYPEDEF_(0x80020009L)")]
    public const int DISP_E_EXCEPTION = unchecked((int)(0x80020009));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_OVERFLOW"]/*' />
    [NativeTypeName("#define DISP_E_OVERFLOW _HRESULT_TYPEDEF_(0x8002000AL)")]
    public const int DISP_E_OVERFLOW = unchecked((int)(0x8002000A));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_BADINDEX"]/*' />
    [NativeTypeName("#define DISP_E_BADINDEX _HRESULT_TYPEDEF_(0x8002000BL)")]
    public const int DISP_E_BADINDEX = unchecked((int)(0x8002000B));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_UNKNOWNLCID"]/*' />
    [NativeTypeName("#define DISP_E_UNKNOWNLCID _HRESULT_TYPEDEF_(0x8002000CL)")]
    public const int DISP_E_UNKNOWNLCID = unchecked((int)(0x8002000C));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_ARRAYISLOCKED"]/*' />
    [NativeTypeName("#define DISP_E_ARRAYISLOCKED _HRESULT_TYPEDEF_(0x8002000DL)")]
    public const int DISP_E_ARRAYISLOCKED = unchecked((int)(0x8002000D));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_BADPARAMCOUNT"]/*' />
    [NativeTypeName("#define DISP_E_BADPARAMCOUNT _HRESULT_TYPEDEF_(0x8002000EL)")]
    public const int DISP_E_BADPARAMCOUNT = unchecked((int)(0x8002000E));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_PARAMNOTOPTIONAL"]/*' />
    [NativeTypeName("#define DISP_E_PARAMNOTOPTIONAL _HRESULT_TYPEDEF_(0x8002000FL)")]
    public const int DISP_E_PARAMNOTOPTIONAL = unchecked((int)(0x8002000F));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_BADCALLEE"]/*' />
    [NativeTypeName("#define DISP_E_BADCALLEE _HRESULT_TYPEDEF_(0x80020010L)")]
    public const int DISP_E_BADCALLEE = unchecked((int)(0x80020010));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_NOTACOLLECTION"]/*' />
    [NativeTypeName("#define DISP_E_NOTACOLLECTION _HRESULT_TYPEDEF_(0x80020011L)")]
    public const int DISP_E_NOTACOLLECTION = unchecked((int)(0x80020011));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_DIVBYZERO"]/*' />
    [NativeTypeName("#define DISP_E_DIVBYZERO _HRESULT_TYPEDEF_(0x80020012L)")]
    public const int DISP_E_DIVBYZERO = unchecked((int)(0x80020012));

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_E_BUFFERTOOSMALL"]/*' />
    [NativeTypeName("#define DISP_E_BUFFERTOOSMALL _HRESULT_TYPEDEF_(0x80020013L)")]
    public const int DISP_E_BUFFERTOOSMALL = unchecked((int)(0x80020013));
}
