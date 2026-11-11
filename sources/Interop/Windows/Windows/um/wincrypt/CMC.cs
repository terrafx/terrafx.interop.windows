// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class CMC
{
    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_DATA"]/*' />
    [NativeTypeName("#define CMC_DATA ((LPCSTR) 59)")]
    public static sbyte* CMC_DATA => ((sbyte*)(59));

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_RESPONSE"]/*' />
    [NativeTypeName("#define CMC_RESPONSE ((LPCSTR) 60)")]
    public static sbyte* CMC_RESPONSE => ((sbyte*)(60));

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_STATUS"]/*' />
    [NativeTypeName("#define CMC_STATUS ((LPCSTR) 61)")]
    public static sbyte* CMC_STATUS => ((sbyte*)(61));

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_ADD_EXTENSIONS"]/*' />
    [NativeTypeName("#define CMC_ADD_EXTENSIONS ((LPCSTR) 62)")]
    public static sbyte* CMC_ADD_EXTENSIONS => ((sbyte*)(62));

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_ADD_ATTRIBUTES"]/*' />
    [NativeTypeName("#define CMC_ADD_ATTRIBUTES ((LPCSTR) 63)")]
    public static sbyte* CMC_ADD_ATTRIBUTES => ((sbyte*)(63));

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_TAGGED_CERT_REQUEST_CHOICE"]/*' />
    [NativeTypeName("#define CMC_TAGGED_CERT_REQUEST_CHOICE 1")]
    public const int CMC_TAGGED_CERT_REQUEST_CHOICE = 1;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_OTHER_INFO_NO_CHOICE"]/*' />
    [NativeTypeName("#define CMC_OTHER_INFO_NO_CHOICE 0")]
    public const int CMC_OTHER_INFO_NO_CHOICE = 0;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_OTHER_INFO_FAIL_CHOICE"]/*' />
    [NativeTypeName("#define CMC_OTHER_INFO_FAIL_CHOICE 1")]
    public const int CMC_OTHER_INFO_FAIL_CHOICE = 1;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_OTHER_INFO_PEND_CHOICE"]/*' />
    [NativeTypeName("#define CMC_OTHER_INFO_PEND_CHOICE 2")]
    public const int CMC_OTHER_INFO_PEND_CHOICE = 2;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_STATUS_SUCCESS"]/*' />
    [NativeTypeName("#define CMC_STATUS_SUCCESS 0")]
    public const int CMC_STATUS_SUCCESS = 0;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_STATUS_FAILED"]/*' />
    [NativeTypeName("#define CMC_STATUS_FAILED 2")]
    public const int CMC_STATUS_FAILED = 2;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_STATUS_PENDING"]/*' />
    [NativeTypeName("#define CMC_STATUS_PENDING 3")]
    public const int CMC_STATUS_PENDING = 3;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_STATUS_NO_SUPPORT"]/*' />
    [NativeTypeName("#define CMC_STATUS_NO_SUPPORT 4")]
    public const int CMC_STATUS_NO_SUPPORT = 4;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_STATUS_CONFIRM_REQUIRED"]/*' />
    [NativeTypeName("#define CMC_STATUS_CONFIRM_REQUIRED 5")]
    public const int CMC_STATUS_CONFIRM_REQUIRED = 5;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_FAIL_BAD_ALG"]/*' />
    [NativeTypeName("#define CMC_FAIL_BAD_ALG 0")]
    public const int CMC_FAIL_BAD_ALG = 0;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_FAIL_BAD_MESSAGE_CHECK"]/*' />
    [NativeTypeName("#define CMC_FAIL_BAD_MESSAGE_CHECK 1")]
    public const int CMC_FAIL_BAD_MESSAGE_CHECK = 1;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_FAIL_BAD_REQUEST"]/*' />
    [NativeTypeName("#define CMC_FAIL_BAD_REQUEST 2")]
    public const int CMC_FAIL_BAD_REQUEST = 2;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_FAIL_BAD_TIME"]/*' />
    [NativeTypeName("#define CMC_FAIL_BAD_TIME 3")]
    public const int CMC_FAIL_BAD_TIME = 3;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_FAIL_BAD_CERT_ID"]/*' />
    [NativeTypeName("#define CMC_FAIL_BAD_CERT_ID 4")]
    public const int CMC_FAIL_BAD_CERT_ID = 4;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_FAIL_UNSUPORTED_EXT"]/*' />
    [NativeTypeName("#define CMC_FAIL_UNSUPORTED_EXT 5")]
    public const int CMC_FAIL_UNSUPORTED_EXT = 5;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_FAIL_MUST_ARCHIVE_KEYS"]/*' />
    [NativeTypeName("#define CMC_FAIL_MUST_ARCHIVE_KEYS 6")]
    public const int CMC_FAIL_MUST_ARCHIVE_KEYS = 6;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_FAIL_BAD_IDENTITY"]/*' />
    [NativeTypeName("#define CMC_FAIL_BAD_IDENTITY 7")]
    public const int CMC_FAIL_BAD_IDENTITY = 7;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_FAIL_POP_REQUIRED"]/*' />
    [NativeTypeName("#define CMC_FAIL_POP_REQUIRED 8")]
    public const int CMC_FAIL_POP_REQUIRED = 8;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_FAIL_POP_FAILED"]/*' />
    [NativeTypeName("#define CMC_FAIL_POP_FAILED 9")]
    public const int CMC_FAIL_POP_FAILED = 9;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_FAIL_NO_KEY_REUSE"]/*' />
    [NativeTypeName("#define CMC_FAIL_NO_KEY_REUSE 10")]
    public const int CMC_FAIL_NO_KEY_REUSE = 10;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_FAIL_INTERNAL_CA_ERROR"]/*' />
    [NativeTypeName("#define CMC_FAIL_INTERNAL_CA_ERROR 11")]
    public const int CMC_FAIL_INTERNAL_CA_ERROR = 11;

    /// <include file='CMC.xml' path='doc/member[@name="CMC.CMC_FAIL_TRY_LATER"]/*' />
    [NativeTypeName("#define CMC_FAIL_TRY_LATER 12")]
    public const int CMC_FAIL_TRY_LATER = 12;
}
