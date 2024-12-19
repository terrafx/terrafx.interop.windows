// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA"]/*' />
public unsafe partial struct HTTP_LOG_FIELDS_DATA
{
    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.Base"]/*' />
    public HTTP_LOG_DATA Base;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.UserNameLength"]/*' />
    public ushort UserNameLength;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.UriStemLength"]/*' />
    public ushort UriStemLength;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.ClientIpLength"]/*' />
    public ushort ClientIpLength;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.ServerNameLength"]/*' />
    public ushort ServerNameLength;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.ServiceNameLength"]/*' />
    public ushort ServiceNameLength;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.ServerIpLength"]/*' />
    public ushort ServerIpLength;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.MethodLength"]/*' />
    public ushort MethodLength;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.UriQueryLength"]/*' />
    public ushort UriQueryLength;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.HostLength"]/*' />
    public ushort HostLength;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.UserAgentLength"]/*' />
    public ushort UserAgentLength;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.CookieLength"]/*' />
    public ushort CookieLength;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.ReferrerLength"]/*' />
    public ushort ReferrerLength;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.UserName"]/*' />
    [NativeTypeName("PWCHAR")]
    public char* UserName;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.UriStem"]/*' />
    [NativeTypeName("PWCHAR")]
    public char* UriStem;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.ClientIp"]/*' />
    [NativeTypeName("PCHAR")]
    public sbyte* ClientIp;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.ServerName"]/*' />
    [NativeTypeName("PCHAR")]
    public sbyte* ServerName;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.ServiceName"]/*' />
    [NativeTypeName("PCHAR")]
    public sbyte* ServiceName;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.ServerIp"]/*' />
    [NativeTypeName("PCHAR")]
    public sbyte* ServerIp;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.Method"]/*' />
    [NativeTypeName("PCHAR")]
    public sbyte* Method;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.UriQuery"]/*' />
    [NativeTypeName("PCHAR")]
    public sbyte* UriQuery;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.Host"]/*' />
    [NativeTypeName("PCHAR")]
    public sbyte* Host;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.UserAgent"]/*' />
    [NativeTypeName("PCHAR")]
    public sbyte* UserAgent;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.Cookie"]/*' />
    [NativeTypeName("PCHAR")]
    public sbyte* Cookie;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.Referrer"]/*' />
    [NativeTypeName("PCHAR")]
    public sbyte* Referrer;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.ServerPort"]/*' />
    public ushort ServerPort;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.ProtocolStatus"]/*' />
    public ushort ProtocolStatus;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.Win32Status"]/*' />
    [NativeTypeName("ULONG")]
    public uint Win32Status;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.MethodNum"]/*' />
    public HTTP_VERB MethodNum;

    /// <include file='HTTP_LOG_FIELDS_DATA.xml' path='doc/member[@name="HTTP_LOG_FIELDS_DATA.SubStatus"]/*' />
    public ushort SubStatus;
}
