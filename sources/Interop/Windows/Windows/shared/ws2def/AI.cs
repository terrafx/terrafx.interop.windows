// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class AI
{
    /// <include file='AI.xml' path='doc/member[@name="AI.AI_PASSIVE"]/*' />
    [NativeTypeName("#define AI_PASSIVE 0x00000001")]
    public const int AI_PASSIVE = 0x00000001;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_CANONNAME"]/*' />
    [NativeTypeName("#define AI_CANONNAME 0x00000002")]
    public const int AI_CANONNAME = 0x00000002;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_NUMERICHOST"]/*' />
    [NativeTypeName("#define AI_NUMERICHOST 0x00000004")]
    public const int AI_NUMERICHOST = 0x00000004;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_NUMERICSERV"]/*' />
    [NativeTypeName("#define AI_NUMERICSERV 0x00000008")]
    public const int AI_NUMERICSERV = 0x00000008;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_DNS_ONLY"]/*' />
    [NativeTypeName("#define AI_DNS_ONLY 0x00000010")]
    public const int AI_DNS_ONLY = 0x00000010;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_FORCE_CLEAR_TEXT"]/*' />
    [NativeTypeName("#define AI_FORCE_CLEAR_TEXT 0x00000020")]
    public const int AI_FORCE_CLEAR_TEXT = 0x00000020;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_BYPASS_DNS_CACHE"]/*' />
    [NativeTypeName("#define AI_BYPASS_DNS_CACHE 0x00000040")]
    public const int AI_BYPASS_DNS_CACHE = 0x00000040;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_RETURN_TTL"]/*' />
    [NativeTypeName("#define AI_RETURN_TTL 0x00000080")]
    public const int AI_RETURN_TTL = 0x00000080;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_ALL"]/*' />
    [NativeTypeName("#define AI_ALL 0x00000100")]
    public const int AI_ALL = 0x00000100;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_ADDRCONFIG"]/*' />
    [NativeTypeName("#define AI_ADDRCONFIG 0x00000400")]
    public const int AI_ADDRCONFIG = 0x00000400;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_V4MAPPED"]/*' />
    [NativeTypeName("#define AI_V4MAPPED 0x00000800")]
    public const int AI_V4MAPPED = 0x00000800;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_NON_AUTHORITATIVE"]/*' />
    [NativeTypeName("#define AI_NON_AUTHORITATIVE 0x00004000")]
    public const int AI_NON_AUTHORITATIVE = 0x00004000;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_SECURE"]/*' />
    [NativeTypeName("#define AI_SECURE 0x00008000")]
    public const int AI_SECURE = 0x00008000;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_RETURN_PREFERRED_NAMES"]/*' />
    [NativeTypeName("#define AI_RETURN_PREFERRED_NAMES 0x00010000")]
    public const int AI_RETURN_PREFERRED_NAMES = 0x00010000;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_FQDN"]/*' />
    [NativeTypeName("#define AI_FQDN 0x00020000")]
    public const int AI_FQDN = 0x00020000;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_FILESERVER"]/*' />
    [NativeTypeName("#define AI_FILESERVER 0x00040000")]
    public const int AI_FILESERVER = 0x00040000;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_DISABLE_IDN_ENCODING"]/*' />
    [NativeTypeName("#define AI_DISABLE_IDN_ENCODING 0x00080000")]
    public const int AI_DISABLE_IDN_ENCODING = 0x00080000;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_SECURE_WITH_FALLBACK"]/*' />
    [NativeTypeName("#define AI_SECURE_WITH_FALLBACK 0x00100000")]
    public const int AI_SECURE_WITH_FALLBACK = 0x00100000;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_EXCLUSIVE_CUSTOM_SERVERS"]/*' />
    [NativeTypeName("#define AI_EXCLUSIVE_CUSTOM_SERVERS 0x00200000")]
    public const int AI_EXCLUSIVE_CUSTOM_SERVERS = 0x00200000;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_RETURN_RESPONSE_FLAGS"]/*' />
    [NativeTypeName("#define AI_RETURN_RESPONSE_FLAGS 0x10000000")]
    public const int AI_RETURN_RESPONSE_FLAGS = 0x10000000;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_REQUIRE_SECURE"]/*' />
    [NativeTypeName("#define AI_REQUIRE_SECURE 0x20000000")]
    public const int AI_REQUIRE_SECURE = 0x20000000;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_RESOLUTION_HANDLE"]/*' />
    [NativeTypeName("#define AI_RESOLUTION_HANDLE 0x40000000")]
    public const int AI_RESOLUTION_HANDLE = 0x40000000;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_EXTENDED"]/*' />
    [NativeTypeName("#define AI_EXTENDED 0x80000000")]
    public const uint AI_EXTENDED = 0x80000000;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_DNS_SERVER_TYPE_UDP"]/*' />
    [NativeTypeName("#define AI_DNS_SERVER_TYPE_UDP 0x1")]
    public const int AI_DNS_SERVER_TYPE_UDP = 0x1;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_DNS_SERVER_TYPE_DOH"]/*' />
    [NativeTypeName("#define AI_DNS_SERVER_TYPE_DOH 0x2")]
    public const int AI_DNS_SERVER_TYPE_DOH = 0x2;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_DNS_SERVER_TYPE_DOT"]/*' />
    [NativeTypeName("#define AI_DNS_SERVER_TYPE_DOT 0x3")]
    public const int AI_DNS_SERVER_TYPE_DOT = 0x3;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_DNS_SERVER_UDP_FALLBACK"]/*' />
    [NativeTypeName("#define AI_DNS_SERVER_UDP_FALLBACK 0x1")]
    public const int AI_DNS_SERVER_UDP_FALLBACK = 0x1;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_DNS_RESPONSE_SECURE"]/*' />
    [NativeTypeName("#define AI_DNS_RESPONSE_SECURE 0x1")]
    public const int AI_DNS_RESPONSE_SECURE = 0x1;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_DNS_RESPONSE_HOSTFILE"]/*' />
    [NativeTypeName("#define AI_DNS_RESPONSE_HOSTFILE 0x2")]
    public const int AI_DNS_RESPONSE_HOSTFILE = 0x2;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_EXTRA_DNSSEC_REQUIRED"]/*' />
    [NativeTypeName("#define AI_EXTRA_DNSSEC_REQUIRED 0x0000000000000001")]
    public const int AI_EXTRA_DNSSEC_REQUIRED = 0x0000000000000001;

    /// <include file='AI.xml' path='doc/member[@name="AI.AI_EXTRA_UNTRUSTED_QUERY"]/*' />
    [NativeTypeName("#define AI_EXTRA_UNTRUSTED_QUERY 0x0000000000000002")]
    public const int AI_EXTRA_UNTRUSTED_QUERY = 0x0000000000000002;
}
