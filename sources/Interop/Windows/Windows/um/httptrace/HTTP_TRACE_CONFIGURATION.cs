// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httptrace.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_TRACE_CONFIGURATION.xml' path='doc/member[@name="HTTP_TRACE_CONFIGURATION"]/*' />
public unsafe partial struct HTTP_TRACE_CONFIGURATION
{
    /// <include file='HTTP_TRACE_CONFIGURATION.xml' path='doc/member[@name="HTTP_TRACE_CONFIGURATION.pProviderGuid"]/*' />
    [NativeTypeName("LPCGUID")]
    public Guid* pProviderGuid;

    /// <include file='HTTP_TRACE_CONFIGURATION.xml' path='doc/member[@name="HTTP_TRACE_CONFIGURATION.dwAreas"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAreas;

    /// <include file='HTTP_TRACE_CONFIGURATION.xml' path='doc/member[@name="HTTP_TRACE_CONFIGURATION.dwVerbosity"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVerbosity;

    /// <include file='HTTP_TRACE_CONFIGURATION.xml' path='doc/member[@name="HTTP_TRACE_CONFIGURATION.fProviderEnabled"]/*' />
    public BOOL fProviderEnabled;
}
