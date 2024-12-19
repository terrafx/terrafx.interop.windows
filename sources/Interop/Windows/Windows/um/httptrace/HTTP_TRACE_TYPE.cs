// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httptrace.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_TRACE_TYPE.xml' path='doc/member[@name="HTTP_TRACE_TYPE"]/*' />
public enum HTTP_TRACE_TYPE
{
    /// <include file='HTTP_TRACE_TYPE.xml' path='doc/member[@name="HTTP_TRACE_TYPE.HTTP_TRACE_TYPE_BYTE"]/*' />
    HTTP_TRACE_TYPE_BYTE = 17,

    /// <include file='HTTP_TRACE_TYPE.xml' path='doc/member[@name="HTTP_TRACE_TYPE.HTTP_TRACE_TYPE_USHORT"]/*' />
    HTTP_TRACE_TYPE_USHORT = 18,

    /// <include file='HTTP_TRACE_TYPE.xml' path='doc/member[@name="HTTP_TRACE_TYPE.HTTP_TRACE_TYPE_ULONG"]/*' />
    HTTP_TRACE_TYPE_ULONG = 19,

    /// <include file='HTTP_TRACE_TYPE.xml' path='doc/member[@name="HTTP_TRACE_TYPE.HTTP_TRACE_TYPE_ULONGLONG"]/*' />
    HTTP_TRACE_TYPE_ULONGLONG = 21,

    /// <include file='HTTP_TRACE_TYPE.xml' path='doc/member[@name="HTTP_TRACE_TYPE.HTTP_TRACE_TYPE_CHAR"]/*' />
    HTTP_TRACE_TYPE_CHAR = 16,

    /// <include file='HTTP_TRACE_TYPE.xml' path='doc/member[@name="HTTP_TRACE_TYPE.HTTP_TRACE_TYPE_SHORT"]/*' />
    HTTP_TRACE_TYPE_SHORT = 2,

    /// <include file='HTTP_TRACE_TYPE.xml' path='doc/member[@name="HTTP_TRACE_TYPE.HTTP_TRACE_TYPE_LONG"]/*' />
    HTTP_TRACE_TYPE_LONG = 3,

    /// <include file='HTTP_TRACE_TYPE.xml' path='doc/member[@name="HTTP_TRACE_TYPE.HTTP_TRACE_TYPE_LONGLONG"]/*' />
    HTTP_TRACE_TYPE_LONGLONG = 20,

    /// <include file='HTTP_TRACE_TYPE.xml' path='doc/member[@name="HTTP_TRACE_TYPE.HTTP_TRACE_TYPE_LPCWSTR"]/*' />
    HTTP_TRACE_TYPE_LPCWSTR = 31,

    /// <include file='HTTP_TRACE_TYPE.xml' path='doc/member[@name="HTTP_TRACE_TYPE.HTTP_TRACE_TYPE_LPCSTR"]/*' />
    HTTP_TRACE_TYPE_LPCSTR = 30,

    /// <include file='HTTP_TRACE_TYPE.xml' path='doc/member[@name="HTTP_TRACE_TYPE.HTTP_TRACE_TYPE_LPCGUID"]/*' />
    HTTP_TRACE_TYPE_LPCGUID = 72,

    /// <include file='HTTP_TRACE_TYPE.xml' path='doc/member[@name="HTTP_TRACE_TYPE.HTTP_TRACE_TYPE_BOOL"]/*' />
    HTTP_TRACE_TYPE_BOOL = 11,
}
