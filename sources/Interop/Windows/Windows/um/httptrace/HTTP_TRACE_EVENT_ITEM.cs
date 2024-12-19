// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httptrace.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_TRACE_EVENT_ITEM.xml' path='doc/member[@name="HTTP_TRACE_EVENT_ITEM"]/*' />
public unsafe partial struct HTTP_TRACE_EVENT_ITEM
{
    /// <include file='HTTP_TRACE_EVENT_ITEM.xml' path='doc/member[@name="HTTP_TRACE_EVENT_ITEM.pszName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pszName;

    /// <include file='HTTP_TRACE_EVENT_ITEM.xml' path='doc/member[@name="HTTP_TRACE_EVENT_ITEM.dwDataType"]/*' />
    [NativeTypeName("enum HTTP_TRACE_TYPE")]
    public HTTP_TRACE_TYPE dwDataType;

    /// <include file='HTTP_TRACE_EVENT_ITEM.xml' path='doc/member[@name="HTTP_TRACE_EVENT_ITEM.pbData"]/*' />
    [NativeTypeName("PBYTE")]
    public byte* pbData;

    /// <include file='HTTP_TRACE_EVENT_ITEM.xml' path='doc/member[@name="HTTP_TRACE_EVENT_ITEM.cbData"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbData;

    /// <include file='HTTP_TRACE_EVENT_ITEM.xml' path='doc/member[@name="HTTP_TRACE_EVENT_ITEM.pszDataDescription"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pszDataDescription;
}
