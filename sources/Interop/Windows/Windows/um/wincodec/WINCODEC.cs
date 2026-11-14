// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WINCODEC
{
    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_SDK_VERSION1"]/*' />
    [NativeTypeName("#define WINCODEC_SDK_VERSION1 0x0236")]
    public const int WINCODEC_SDK_VERSION1 = 0x0236;

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_SDK_VERSION2"]/*' />
    [NativeTypeName("#define WINCODEC_SDK_VERSION2 0x0237")]
    public const int WINCODEC_SDK_VERSION2 = 0x0237;

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_SDK_VERSION"]/*' />
    [NativeTypeName("#define WINCODEC_SDK_VERSION WINCODEC_SDK_VERSION2")]
    public const int WINCODEC_SDK_VERSION = 0x0237;

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_BASE"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_BASE 0x2000")]
    public const int WINCODEC_ERR_BASE = 0x2000;

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_GENERIC_ERROR"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_GENERIC_ERROR E_FAIL")]
    public const int WINCODEC_ERR_GENERIC_ERROR = unchecked((int)(0x80004005));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_INVALIDPARAMETER"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_INVALIDPARAMETER E_INVALIDARG")]
    public const int WINCODEC_ERR_INVALIDPARAMETER = unchecked((int)(0x80070057));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_OUTOFMEMORY"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_OUTOFMEMORY E_OUTOFMEMORY")]
    public const int WINCODEC_ERR_OUTOFMEMORY = unchecked((int)(0x8007000E));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_NOTIMPLEMENTED"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_NOTIMPLEMENTED E_NOTIMPL")]
    public const int WINCODEC_ERR_NOTIMPLEMENTED = unchecked((int)(0x80004001));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_ABORTED"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_ABORTED E_ABORT")]
    public const int WINCODEC_ERR_ABORTED = unchecked((int)(0x80004004));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_ACCESSDENIED"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_ACCESSDENIED E_ACCESSDENIED")]
    public const int WINCODEC_ERR_ACCESSDENIED = unchecked((int)(0x80070005));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_VALUEOVERFLOW"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_VALUEOVERFLOW INTSAFE_E_ARITHMETIC_OVERFLOW")]
    public const int WINCODEC_ERR_VALUEOVERFLOW = unchecked((int)(0x80070216));
}
