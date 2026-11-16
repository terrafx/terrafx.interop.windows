// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINHTTP_CONNECTION_POLICY_ENTRY.xml' path='doc/member[@name="WINHTTP_CONNECTION_POLICY_ENTRY"]/*' />
public unsafe partial struct WINHTTP_CONNECTION_POLICY_ENTRY
{
    /// <include file='WINHTTP_CONNECTION_POLICY_ENTRY.xml' path='doc/member[@name="WINHTTP_CONNECTION_POLICY_ENTRY.pwszHost"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pwszHost;

    /// <include file='WINHTTP_CONNECTION_POLICY_ENTRY.xml' path='doc/member[@name="WINHTTP_CONNECTION_POLICY_ENTRY.pwszAppId"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pwszAppId;

    /// <include file='WINHTTP_CONNECTION_POLICY_ENTRY.xml' path='doc/member[@name="WINHTTP_CONNECTION_POLICY_ENTRY.cbAppSid"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbAppSid;

    /// <include file='WINHTTP_CONNECTION_POLICY_ENTRY.xml' path='doc/member[@name="WINHTTP_CONNECTION_POLICY_ENTRY.pbAppSid"]/*' />
    [NativeTypeName("PBYTE")]
    public byte* pbAppSid;

    /// <include file='WINHTTP_CONNECTION_POLICY_ENTRY.xml' path='doc/member[@name="WINHTTP_CONNECTION_POLICY_ENTRY.nConnections"]/*' />
    [NativeTypeName("DWORD")]
    public uint nConnections;

    /// <include file='WINHTTP_CONNECTION_POLICY_ENTRY.xml' path='doc/member[@name="WINHTTP_CONNECTION_POLICY_ENTRY.ppwszConnections"]/*' />
    [NativeTypeName("PCWSTR *")]
    public char** ppwszConnections;

    /// <include file='WINHTTP_CONNECTION_POLICY_ENTRY.xml' path='doc/member[@name="WINHTTP_CONNECTION_POLICY_ENTRY.dwPolicyEntryFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPolicyEntryFlags;
}
