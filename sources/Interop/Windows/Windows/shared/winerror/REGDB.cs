// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class REGDB
{
    /// <include file='REGDB.xml' path='doc/member[@name="REGDB.REGDB_E_FIRST"]/*' />
    [NativeTypeName("#define REGDB_E_FIRST 0x80040150L")]
    public const uint REGDB_E_FIRST = 0x80040150;

    /// <include file='REGDB.xml' path='doc/member[@name="REGDB.REGDB_E_LAST"]/*' />
    [NativeTypeName("#define REGDB_E_LAST 0x8004015FL")]
    public const uint REGDB_E_LAST = 0x8004015F;

    /// <include file='REGDB.xml' path='doc/member[@name="REGDB.REGDB_S_FIRST"]/*' />
    [NativeTypeName("#define REGDB_S_FIRST 0x00040150L")]
    public const int REGDB_S_FIRST = 0x00040150;

    /// <include file='REGDB.xml' path='doc/member[@name="REGDB.REGDB_S_LAST"]/*' />
    [NativeTypeName("#define REGDB_S_LAST 0x0004015FL")]
    public const int REGDB_S_LAST = 0x0004015F;

    /// <include file='REGDB.xml' path='doc/member[@name="REGDB.REGDB_E_READREGDB"]/*' />
    [NativeTypeName("#define REGDB_E_READREGDB _HRESULT_TYPEDEF_(0x80040150L)")]
    public const int REGDB_E_READREGDB = unchecked((int)(0x80040150));

    /// <include file='REGDB.xml' path='doc/member[@name="REGDB.REGDB_E_WRITEREGDB"]/*' />
    [NativeTypeName("#define REGDB_E_WRITEREGDB _HRESULT_TYPEDEF_(0x80040151L)")]
    public const int REGDB_E_WRITEREGDB = unchecked((int)(0x80040151));

    /// <include file='REGDB.xml' path='doc/member[@name="REGDB.REGDB_E_KEYMISSING"]/*' />
    [NativeTypeName("#define REGDB_E_KEYMISSING _HRESULT_TYPEDEF_(0x80040152L)")]
    public const int REGDB_E_KEYMISSING = unchecked((int)(0x80040152));

    /// <include file='REGDB.xml' path='doc/member[@name="REGDB.REGDB_E_INVALIDVALUE"]/*' />
    [NativeTypeName("#define REGDB_E_INVALIDVALUE _HRESULT_TYPEDEF_(0x80040153L)")]
    public const int REGDB_E_INVALIDVALUE = unchecked((int)(0x80040153));

    /// <include file='REGDB.xml' path='doc/member[@name="REGDB.REGDB_E_CLASSNOTREG"]/*' />
    [NativeTypeName("#define REGDB_E_CLASSNOTREG _HRESULT_TYPEDEF_(0x80040154L)")]
    public const int REGDB_E_CLASSNOTREG = unchecked((int)(0x80040154));

    /// <include file='REGDB.xml' path='doc/member[@name="REGDB.REGDB_E_IIDNOTREG"]/*' />
    [NativeTypeName("#define REGDB_E_IIDNOTREG _HRESULT_TYPEDEF_(0x80040155L)")]
    public const int REGDB_E_IIDNOTREG = unchecked((int)(0x80040155));

    /// <include file='REGDB.xml' path='doc/member[@name="REGDB.REGDB_E_BADTHREADINGMODEL"]/*' />
    [NativeTypeName("#define REGDB_E_BADTHREADINGMODEL _HRESULT_TYPEDEF_(0x80040156L)")]
    public const int REGDB_E_BADTHREADINGMODEL = unchecked((int)(0x80040156));

    /// <include file='REGDB.xml' path='doc/member[@name="REGDB.REGDB_E_PACKAGEPOLICYVIOLATION"]/*' />
    [NativeTypeName("#define REGDB_E_PACKAGEPOLICYVIOLATION _HRESULT_TYPEDEF_(0x80040157L)")]
    public const int REGDB_E_PACKAGEPOLICYVIOLATION = unchecked((int)(0x80040157));
}
