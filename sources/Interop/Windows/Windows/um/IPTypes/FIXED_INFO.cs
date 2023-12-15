// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='FIXED_INFO.xml' path='doc/member[@name="FIXED_INFO"]/*' />
public unsafe partial struct FIXED_INFO
{
    /// <include file='FIXED_INFO.xml' path='doc/member[@name="FIXED_INFO.HostName"]/*' />
    [NativeTypeName("char[132]")]
    public _HostName_e__FixedBuffer HostName;

    /// <include file='FIXED_INFO.xml' path='doc/member[@name="FIXED_INFO.DomainName"]/*' />
    [NativeTypeName("char[132]")]
    public _DomainName_e__FixedBuffer DomainName;

    /// <include file='FIXED_INFO.xml' path='doc/member[@name="FIXED_INFO.CurrentDnsServer"]/*' />
    [NativeTypeName("PIP_ADDR_STRING")]
    public IP_ADDR_STRING* CurrentDnsServer;

    /// <include file='FIXED_INFO.xml' path='doc/member[@name="FIXED_INFO.DnsServerList"]/*' />
    public IP_ADDR_STRING DnsServerList;

    /// <include file='FIXED_INFO.xml' path='doc/member[@name="FIXED_INFO.NodeType"]/*' />
    public uint NodeType;

    /// <include file='FIXED_INFO.xml' path='doc/member[@name="FIXED_INFO.ScopeId"]/*' />
    [NativeTypeName("char[260]")]
    public _ScopeId_e__FixedBuffer ScopeId;

    /// <include file='FIXED_INFO.xml' path='doc/member[@name="FIXED_INFO.EnableRouting"]/*' />
    public uint EnableRouting;

    /// <include file='FIXED_INFO.xml' path='doc/member[@name="FIXED_INFO.EnableProxy"]/*' />
    public uint EnableProxy;

    /// <include file='FIXED_INFO.xml' path='doc/member[@name="FIXED_INFO.EnableDns"]/*' />
    public uint EnableDns;

    /// <include file='_HostName_e__FixedBuffer.xml' path='doc/member[@name="_HostName_e__FixedBuffer"]/*' />
    [InlineArray(132)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _HostName_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_DomainName_e__FixedBuffer.xml' path='doc/member[@name="_DomainName_e__FixedBuffer"]/*' />
    [InlineArray(132)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _DomainName_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_ScopeId_e__FixedBuffer.xml' path='doc/member[@name="_ScopeId_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _ScopeId_e__FixedBuffer
    {
        public sbyte e0;
    }
}
