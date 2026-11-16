// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static unsafe partial class TIME
{
    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_VALID_OID_GET_OBJECT_FUNC"]/*' />
    [NativeTypeName("#define TIME_VALID_OID_GET_OBJECT_FUNC \"TimeValidDllGetObject\"")]
    public static ReadOnlySpan<byte> TIME_VALID_OID_GET_OBJECT_FUNC => "TimeValidDllGetObject"u8;

    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_VALID_OID_GET_CTL"]/*' />
    [NativeTypeName("#define TIME_VALID_OID_GET_CTL ((LPCSTR)1)")]
    public static sbyte* TIME_VALID_OID_GET_CTL => ((sbyte*)(1));

    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_VALID_OID_GET_CRL"]/*' />
    [NativeTypeName("#define TIME_VALID_OID_GET_CRL ((LPCSTR)2)")]
    public static sbyte* TIME_VALID_OID_GET_CRL => ((sbyte*)(2));

    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_VALID_OID_GET_CRL_FROM_CERT"]/*' />
    [NativeTypeName("#define TIME_VALID_OID_GET_CRL_FROM_CERT ((LPCSTR)3)")]
    public static sbyte* TIME_VALID_OID_GET_CRL_FROM_CERT => ((sbyte*)(3));

    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_VALID_OID_GET_FRESHEST_CRL_FROM_CERT"]/*' />
    [NativeTypeName("#define TIME_VALID_OID_GET_FRESHEST_CRL_FROM_CERT ((LPCSTR)4)")]
    public static sbyte* TIME_VALID_OID_GET_FRESHEST_CRL_FROM_CERT => ((sbyte*)(4));

    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_VALID_OID_GET_FRESHEST_CRL_FROM_CRL"]/*' />
    [NativeTypeName("#define TIME_VALID_OID_GET_FRESHEST_CRL_FROM_CRL ((LPCSTR)5)")]
    public static sbyte* TIME_VALID_OID_GET_FRESHEST_CRL_FROM_CRL => ((sbyte*)(5));

    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_VALID_OID_FLUSH_OBJECT_FUNC"]/*' />
    [NativeTypeName("#define TIME_VALID_OID_FLUSH_OBJECT_FUNC \"TimeValidDllFlushObject\"")]
    public static ReadOnlySpan<byte> TIME_VALID_OID_FLUSH_OBJECT_FUNC => "TimeValidDllFlushObject"u8;

    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_VALID_OID_FLUSH_CTL"]/*' />
    [NativeTypeName("#define TIME_VALID_OID_FLUSH_CTL ((LPCSTR)1)")]
    public static sbyte* TIME_VALID_OID_FLUSH_CTL => ((sbyte*)(1));

    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_VALID_OID_FLUSH_CRL"]/*' />
    [NativeTypeName("#define TIME_VALID_OID_FLUSH_CRL ((LPCSTR)2)")]
    public static sbyte* TIME_VALID_OID_FLUSH_CRL => ((sbyte*)(2));

    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_VALID_OID_FLUSH_CRL_FROM_CERT"]/*' />
    [NativeTypeName("#define TIME_VALID_OID_FLUSH_CRL_FROM_CERT ((LPCSTR)3)")]
    public static sbyte* TIME_VALID_OID_FLUSH_CRL_FROM_CERT => ((sbyte*)(3));

    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_VALID_OID_FLUSH_FRESHEST_CRL_FROM_CERT"]/*' />
    [NativeTypeName("#define TIME_VALID_OID_FLUSH_FRESHEST_CRL_FROM_CERT ((LPCSTR)4)")]
    public static sbyte* TIME_VALID_OID_FLUSH_FRESHEST_CRL_FROM_CERT => ((sbyte*)(4));

    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_VALID_OID_FLUSH_FRESHEST_CRL_FROM_CRL"]/*' />
    [NativeTypeName("#define TIME_VALID_OID_FLUSH_FRESHEST_CRL_FROM_CRL ((LPCSTR)5)")]
    public static sbyte* TIME_VALID_OID_FLUSH_FRESHEST_CRL_FROM_CRL => ((sbyte*)(5));
}
