// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httptrace.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_TRACE_EVENT.xml' path='doc/member[@name="HTTP_TRACE_EVENT"]/*' />
public unsafe partial struct HTTP_TRACE_EVENT
{
    /// <include file='HTTP_TRACE_EVENT.xml' path='doc/member[@name="HTTP_TRACE_EVENT.pProviderGuid"]/*' />
    [NativeTypeName("LPCGUID")]
    public Guid* pProviderGuid;

    /// <include file='HTTP_TRACE_EVENT.xml' path='doc/member[@name="HTTP_TRACE_EVENT.dwArea"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwArea;

    /// <include file='HTTP_TRACE_EVENT.xml' path='doc/member[@name="HTTP_TRACE_EVENT.pAreaGuid"]/*' />
    [NativeTypeName("LPCGUID")]
    public Guid* pAreaGuid;

    /// <include file='HTTP_TRACE_EVENT.xml' path='doc/member[@name="HTTP_TRACE_EVENT.dwEvent"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwEvent;

    /// <include file='HTTP_TRACE_EVENT.xml' path='doc/member[@name="HTTP_TRACE_EVENT.pszEventName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pszEventName;

    /// <include file='HTTP_TRACE_EVENT.xml' path='doc/member[@name="HTTP_TRACE_EVENT.dwEventVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwEventVersion;

    /// <include file='HTTP_TRACE_EVENT.xml' path='doc/member[@name="HTTP_TRACE_EVENT.dwVerbosity"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVerbosity;

    /// <include file='HTTP_TRACE_EVENT.xml' path='doc/member[@name="HTTP_TRACE_EVENT.pActivityGuid"]/*' />
    [NativeTypeName("LPCGUID")]
    public Guid* pActivityGuid;

    /// <include file='HTTP_TRACE_EVENT.xml' path='doc/member[@name="HTTP_TRACE_EVENT.pRelatedActivityGuid"]/*' />
    [NativeTypeName("LPCGUID")]
    public Guid* pRelatedActivityGuid;

    /// <include file='HTTP_TRACE_EVENT.xml' path='doc/member[@name="HTTP_TRACE_EVENT.dwTimeStamp"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTimeStamp;

    /// <include file='HTTP_TRACE_EVENT.xml' path='doc/member[@name="HTTP_TRACE_EVENT.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='HTTP_TRACE_EVENT.xml' path='doc/member[@name="HTTP_TRACE_EVENT.cEventItems"]/*' />
    [NativeTypeName("DWORD")]
    public uint cEventItems;

    /// <include file='HTTP_TRACE_EVENT.xml' path='doc/member[@name="HTTP_TRACE_EVENT.pEventItems"]/*' />
    [NativeTypeName("struct HTTP_TRACE_EVENT_ITEM *")]
    public HTTP_TRACE_EVENT_ITEM* pEventItems;
}
