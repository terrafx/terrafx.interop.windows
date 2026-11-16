// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CS
{
    /// <include file='CS.xml' path='doc/member[@name="CS.CS_E_FIRST"]/*' />
    [NativeTypeName("#define CS_E_FIRST 0x80040164L")]
    public const uint CS_E_FIRST = 0x80040164;

    /// <include file='CS.xml' path='doc/member[@name="CS.CS_E_LAST"]/*' />
    [NativeTypeName("#define CS_E_LAST 0x8004016FL")]
    public const uint CS_E_LAST = 0x8004016F;

    /// <include file='CS.xml' path='doc/member[@name="CS.CS_E_PACKAGE_NOTFOUND"]/*' />
    [NativeTypeName("#define CS_E_PACKAGE_NOTFOUND _HRESULT_TYPEDEF_(0x80040164L)")]
    public const int CS_E_PACKAGE_NOTFOUND = unchecked((int)(0x80040164));

    /// <include file='CS.xml' path='doc/member[@name="CS.CS_E_NOT_DELETABLE"]/*' />
    [NativeTypeName("#define CS_E_NOT_DELETABLE _HRESULT_TYPEDEF_(0x80040165L)")]
    public const int CS_E_NOT_DELETABLE = unchecked((int)(0x80040165));

    /// <include file='CS.xml' path='doc/member[@name="CS.CS_E_CLASS_NOTFOUND"]/*' />
    [NativeTypeName("#define CS_E_CLASS_NOTFOUND _HRESULT_TYPEDEF_(0x80040166L)")]
    public const int CS_E_CLASS_NOTFOUND = unchecked((int)(0x80040166));

    /// <include file='CS.xml' path='doc/member[@name="CS.CS_E_INVALID_VERSION"]/*' />
    [NativeTypeName("#define CS_E_INVALID_VERSION _HRESULT_TYPEDEF_(0x80040167L)")]
    public const int CS_E_INVALID_VERSION = unchecked((int)(0x80040167));

    /// <include file='CS.xml' path='doc/member[@name="CS.CS_E_NO_CLASSSTORE"]/*' />
    [NativeTypeName("#define CS_E_NO_CLASSSTORE _HRESULT_TYPEDEF_(0x80040168L)")]
    public const int CS_E_NO_CLASSSTORE = unchecked((int)(0x80040168));

    /// <include file='CS.xml' path='doc/member[@name="CS.CS_E_OBJECT_NOTFOUND"]/*' />
    [NativeTypeName("#define CS_E_OBJECT_NOTFOUND _HRESULT_TYPEDEF_(0x80040169L)")]
    public const int CS_E_OBJECT_NOTFOUND = unchecked((int)(0x80040169));

    /// <include file='CS.xml' path='doc/member[@name="CS.CS_E_OBJECT_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define CS_E_OBJECT_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x8004016AL)")]
    public const int CS_E_OBJECT_ALREADY_EXISTS = unchecked((int)(0x8004016A));

    /// <include file='CS.xml' path='doc/member[@name="CS.CS_E_INVALID_PATH"]/*' />
    [NativeTypeName("#define CS_E_INVALID_PATH _HRESULT_TYPEDEF_(0x8004016BL)")]
    public const int CS_E_INVALID_PATH = unchecked((int)(0x8004016B));

    /// <include file='CS.xml' path='doc/member[@name="CS.CS_E_NETWORK_ERROR"]/*' />
    [NativeTypeName("#define CS_E_NETWORK_ERROR _HRESULT_TYPEDEF_(0x8004016CL)")]
    public const int CS_E_NETWORK_ERROR = unchecked((int)(0x8004016C));

    /// <include file='CS.xml' path='doc/member[@name="CS.CS_E_ADMIN_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define CS_E_ADMIN_LIMIT_EXCEEDED _HRESULT_TYPEDEF_(0x8004016DL)")]
    public const int CS_E_ADMIN_LIMIT_EXCEEDED = unchecked((int)(0x8004016D));

    /// <include file='CS.xml' path='doc/member[@name="CS.CS_E_SCHEMA_MISMATCH"]/*' />
    [NativeTypeName("#define CS_E_SCHEMA_MISMATCH _HRESULT_TYPEDEF_(0x8004016EL)")]
    public const int CS_E_SCHEMA_MISMATCH = unchecked((int)(0x8004016E));

    /// <include file='CS.xml' path='doc/member[@name="CS.CS_E_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define CS_E_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x8004016FL)")]
    public const int CS_E_INTERNAL_ERROR = unchecked((int)(0x8004016F));
}
