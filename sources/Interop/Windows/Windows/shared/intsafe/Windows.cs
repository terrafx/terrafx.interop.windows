// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/intsafe.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows._ARM64_MULT_INTRINS_SUPPORTED"]/*' />
    [NativeTypeName("#define _ARM64_MULT_INTRINS_SUPPORTED 0")]
    public const int _ARM64_MULT_INTRINS_SUPPORTED = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INTSAFE_E_ARITHMETIC_OVERFLOW"]/*' />
    [NativeTypeName("#define INTSAFE_E_ARITHMETIC_OVERFLOW ((HRESULT)0x80070216L)")]
    public const int INTSAFE_E_ARITHMETIC_OVERFLOW = unchecked((int)(0x80070216));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT8_MIN"]/*' />
    [NativeTypeName("#define INT8_MIN (-127i8 - 1)")]
    public const int INT8_MIN = (-127 - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHORT_MIN"]/*' />
    [NativeTypeName("#define SHORT_MIN (-32768)")]
    public const int SHORT_MIN = (-32768);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT16_MIN"]/*' />
    [NativeTypeName("#define INT16_MIN (-32767i16 - 1)")]
    public const int INT16_MIN = (-32767 - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT32_MIN"]/*' />
    [NativeTypeName("#define INT32_MIN (-2147483647i32 - 1)")]
    public const int INT32_MIN = (-2147483647 - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LONGLONG_MIN"]/*' />
    [NativeTypeName("#define LONGLONG_MIN (-9223372036854775807i64 - 1)")]
    public const long LONGLONG_MIN = (-9223372036854775807L - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LONG64_MIN"]/*' />
    [NativeTypeName("#define LONG64_MIN (-9223372036854775807i64 - 1)")]
    public const long LONG64_MIN = (-9223372036854775807L - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT64_MIN"]/*' />
    [NativeTypeName("#define INT64_MIN (-9223372036854775807i64 - 1)")]
    public const long INT64_MIN = (-9223372036854775807L - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT8_MAX"]/*' />
    [NativeTypeName("#define INT8_MAX 127i8")]
    public const sbyte INT8_MAX = 127;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT8_MAX"]/*' />
    [NativeTypeName("#define UINT8_MAX 0xffui8")]
    public const byte UINT8_MAX = unchecked(0xff);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BYTE_MAX"]/*' />
    [NativeTypeName("#define BYTE_MAX 0xff")]
    public const int BYTE_MAX = 0xff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHORT_MAX"]/*' />
    [NativeTypeName("#define SHORT_MAX 32767")]
    public const int SHORT_MAX = 32767;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT16_MAX"]/*' />
    [NativeTypeName("#define INT16_MAX 32767i16")]
    public const short INT16_MAX = 32767;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.USHORT_MAX"]/*' />
    [NativeTypeName("#define USHORT_MAX 0xffff")]
    public const int USHORT_MAX = 0xffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT16_MAX"]/*' />
    [NativeTypeName("#define UINT16_MAX 0xffffui16")]
    public const ushort UINT16_MAX = unchecked(0xffff);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WORD_MAX"]/*' />
    [NativeTypeName("#define WORD_MAX 0xffff")]
    public const int WORD_MAX = 0xffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT32_MAX"]/*' />
    [NativeTypeName("#define INT32_MAX 2147483647i32")]
    public const int INT32_MAX = 2147483647;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT32_MAX"]/*' />
    [NativeTypeName("#define UINT32_MAX 0xffffffffui32")]
    public const uint UINT32_MAX = 0xffffffffU;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWORD_MAX"]/*' />
    [NativeTypeName("#define DWORD_MAX 0xffffffffUL")]
    public const uint DWORD_MAX = 0xffffffffU;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LONGLONG_MAX"]/*' />
    [NativeTypeName("#define LONGLONG_MAX 9223372036854775807i64")]
    public const long LONGLONG_MAX = 9223372036854775807L;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LONG64_MAX"]/*' />
    [NativeTypeName("#define LONG64_MAX 9223372036854775807i64")]
    public const long LONG64_MAX = 9223372036854775807L;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT64_MAX"]/*' />
    [NativeTypeName("#define INT64_MAX 9223372036854775807i64")]
    public const long INT64_MAX = 9223372036854775807L;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULONGLONG_MAX"]/*' />
    [NativeTypeName("#define ULONGLONG_MAX 0xffffffffffffffffui64")]
    public const ulong ULONGLONG_MAX = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWORDLONG_MAX"]/*' />
    [NativeTypeName("#define DWORDLONG_MAX 0xffffffffffffffffui64")]
    public const ulong DWORDLONG_MAX = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULONG64_MAX"]/*' />
    [NativeTypeName("#define ULONG64_MAX 0xffffffffffffffffui64")]
    public const ulong ULONG64_MAX = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWORD64_MAX"]/*' />
    [NativeTypeName("#define DWORD64_MAX 0xffffffffffffffffui64")]
    public const ulong DWORD64_MAX = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT64_MAX"]/*' />
    [NativeTypeName("#define UINT64_MAX 0xffffffffffffffffui64")]
    public const ulong UINT64_MAX = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT8_ERROR"]/*' />
    [NativeTypeName("#define INT8_ERROR (-1i8)")]
    public const int INT8_ERROR = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT8_ERROR"]/*' />
    [NativeTypeName("#define UINT8_ERROR 0xffui8")]
    public const byte UINT8_ERROR = unchecked(0xff);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BYTE_ERROR"]/*' />
    [NativeTypeName("#define BYTE_ERROR 0xff")]
    public const int BYTE_ERROR = 0xff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHORT_ERROR"]/*' />
    [NativeTypeName("#define SHORT_ERROR (-1)")]
    public const int SHORT_ERROR = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT16_ERROR"]/*' />
    [NativeTypeName("#define INT16_ERROR (-1i16)")]
    public const int INT16_ERROR = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.USHORT_ERROR"]/*' />
    [NativeTypeName("#define USHORT_ERROR 0xffff")]
    public const int USHORT_ERROR = 0xffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT16_ERROR"]/*' />
    [NativeTypeName("#define UINT16_ERROR 0xffffui16")]
    public const ushort UINT16_ERROR = unchecked(0xffff);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WORD_ERROR"]/*' />
    [NativeTypeName("#define WORD_ERROR 0xffff")]
    public const int WORD_ERROR = 0xffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT_ERROR"]/*' />
    [NativeTypeName("#define INT_ERROR (-1)")]
    public const int INT_ERROR = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT32_ERROR"]/*' />
    [NativeTypeName("#define INT32_ERROR (-1i32)")]
    public const int INT32_ERROR = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT_ERROR"]/*' />
    [NativeTypeName("#define UINT_ERROR 0xffffffff")]
    public const uint UINT_ERROR = 0xffffffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT32_ERROR"]/*' />
    [NativeTypeName("#define UINT32_ERROR 0xffffffffui32")]
    public const uint UINT32_ERROR = 0xffffffffU;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LONG_ERROR"]/*' />
    [NativeTypeName("#define LONG_ERROR (-1L)")]
    public const int LONG_ERROR = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULONG_ERROR"]/*' />
    [NativeTypeName("#define ULONG_ERROR 0xffffffffUL")]
    public const uint ULONG_ERROR = 0xffffffffU;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWORD_ERROR"]/*' />
    [NativeTypeName("#define DWORD_ERROR 0xffffffffUL")]
    public const uint DWORD_ERROR = 0xffffffffU;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LONGLONG_ERROR"]/*' />
    [NativeTypeName("#define LONGLONG_ERROR (-1i64)")]
    public const long LONGLONG_ERROR = (-1L);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LONG64_ERROR"]/*' />
    [NativeTypeName("#define LONG64_ERROR (-1i64)")]
    public const long LONG64_ERROR = (-1L);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT64_ERROR"]/*' />
    [NativeTypeName("#define INT64_ERROR (-1i64)")]
    public const long INT64_ERROR = (-1L);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULONGLONG_ERROR"]/*' />
    [NativeTypeName("#define ULONGLONG_ERROR 0xffffffffffffffffui64")]
    public const ulong ULONGLONG_ERROR = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWORDLONG_ERROR"]/*' />
    [NativeTypeName("#define DWORDLONG_ERROR 0xffffffffffffffffui64")]
    public const ulong DWORDLONG_ERROR = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULONG64_ERROR"]/*' />
    [NativeTypeName("#define ULONG64_ERROR 0xffffffffffffffffui64")]
    public const ulong ULONG64_ERROR = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT64_ERROR"]/*' />
    [NativeTypeName("#define UINT64_ERROR 0xffffffffffffffffui64")]
    public const ulong UINT64_ERROR = 0xffffffffffffffffUL;
}
