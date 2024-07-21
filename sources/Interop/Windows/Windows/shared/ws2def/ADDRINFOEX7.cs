// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7"]/*' />
public unsafe partial struct ADDRINFOEX7
{
    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_flags"]/*' />
    public int ai_flags;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_family"]/*' />
    public int ai_family;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_socktype"]/*' />
    public int ai_socktype;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_protocol"]/*' />
    public int ai_protocol;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_addrlen"]/*' />
    [NativeTypeName("size_t")]
    public nuint ai_addrlen;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_canonname"]/*' />
    [NativeTypeName("PWSTR")]
    public char* ai_canonname;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_addr"]/*' />
    [NativeTypeName("struct sockaddr *")]
    public SOCKADDR* ai_addr;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_blob"]/*' />
    public void* ai_blob;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_bloblen"]/*' />
    [NativeTypeName("size_t")]
    public nuint ai_bloblen;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_provider"]/*' />
    public Guid* ai_provider;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_next"]/*' />
    [NativeTypeName("struct addrinfoex7 *")]
    public ADDRINFOEX7* ai_next;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_version"]/*' />
    public int ai_version;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_fqdn"]/*' />
    [NativeTypeName("PWSTR")]
    public char* ai_fqdn;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_interfaceindex"]/*' />
    public int ai_interfaceindex;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_resolutionhandle"]/*' />
    public HANDLE ai_resolutionhandle;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_ttl"]/*' />
    [NativeTypeName("unsigned int")]
    public uint ai_ttl;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_numservers"]/*' />
    [NativeTypeName("unsigned int")]
    public uint ai_numservers;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_servers"]/*' />
    public ADDRINFO_DNS_SERVER* ai_servers;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_responseflags"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ai_responseflags;

    /// <include file='ADDRINFOEX7.xml' path='doc/member[@name="ADDRINFOEX7.ai_extraflags"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ai_extraflags;
}
