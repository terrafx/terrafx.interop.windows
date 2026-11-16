// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TCP
{
    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_OFFLOAD_NO_PREFERENCE"]/*' />
    [NativeTypeName("#define TCP_OFFLOAD_NO_PREFERENCE 0")]
    public const int TCP_OFFLOAD_NO_PREFERENCE = 0;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_OFFLOAD_NOT_PREFERRED"]/*' />
    [NativeTypeName("#define TCP_OFFLOAD_NOT_PREFERRED 1")]
    public const int TCP_OFFLOAD_NOT_PREFERRED = 1;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_OFFLOAD_PREFERRED"]/*' />
    [NativeTypeName("#define TCP_OFFLOAD_PREFERRED 2")]
    public const int TCP_OFFLOAD_PREFERRED = 2;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_EXPEDITED_1122"]/*' />
    [NativeTypeName("#define TCP_EXPEDITED_1122 0x0002")]
    public const int TCP_EXPEDITED_1122 = 0x0002;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_KEEPALIVE"]/*' />
    [NativeTypeName("#define TCP_KEEPALIVE 3")]
    public const int TCP_KEEPALIVE = 3;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_MAXSEG"]/*' />
    [NativeTypeName("#define TCP_MAXSEG 4")]
    public const int TCP_MAXSEG = 4;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_MAXRT"]/*' />
    [NativeTypeName("#define TCP_MAXRT 5")]
    public const int TCP_MAXRT = 5;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_STDURG"]/*' />
    [NativeTypeName("#define TCP_STDURG 6")]
    public const int TCP_STDURG = 6;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_NOURG"]/*' />
    [NativeTypeName("#define TCP_NOURG 7")]
    public const int TCP_NOURG = 7;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_ATMARK"]/*' />
    [NativeTypeName("#define TCP_ATMARK 8")]
    public const int TCP_ATMARK = 8;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_NOSYNRETRIES"]/*' />
    [NativeTypeName("#define TCP_NOSYNRETRIES 9")]
    public const int TCP_NOSYNRETRIES = 9;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_TIMESTAMPS"]/*' />
    [NativeTypeName("#define TCP_TIMESTAMPS 10")]
    public const int TCP_TIMESTAMPS = 10;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_OFFLOAD_PREFERENCE"]/*' />
    [NativeTypeName("#define TCP_OFFLOAD_PREFERENCE 11")]
    public const int TCP_OFFLOAD_PREFERENCE = 11;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_CONGESTION_ALGORITHM"]/*' />
    [NativeTypeName("#define TCP_CONGESTION_ALGORITHM 12")]
    public const int TCP_CONGESTION_ALGORITHM = 12;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_DELAY_FIN_ACK"]/*' />
    [NativeTypeName("#define TCP_DELAY_FIN_ACK 13")]
    public const int TCP_DELAY_FIN_ACK = 13;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_MAXRTMS"]/*' />
    [NativeTypeName("#define TCP_MAXRTMS 14")]
    public const int TCP_MAXRTMS = 14;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_FASTOPEN"]/*' />
    [NativeTypeName("#define TCP_FASTOPEN 15")]
    public const int TCP_FASTOPEN = 15;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_KEEPCNT"]/*' />
    [NativeTypeName("#define TCP_KEEPCNT 16")]
    public const int TCP_KEEPCNT = 16;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_KEEPIDLE"]/*' />
    [NativeTypeName("#define TCP_KEEPIDLE TCP_KEEPALIVE")]
    public const int TCP_KEEPIDLE = 3;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_KEEPINTVL"]/*' />
    [NativeTypeName("#define TCP_KEEPINTVL 17")]
    public const int TCP_KEEPINTVL = 17;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_FAIL_CONNECT_ON_ICMP_ERROR"]/*' />
    [NativeTypeName("#define TCP_FAIL_CONNECT_ON_ICMP_ERROR 18")]
    public const int TCP_FAIL_CONNECT_ON_ICMP_ERROR = 18;

    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_ICMP_ERROR_INFO"]/*' />
    [NativeTypeName("#define TCP_ICMP_ERROR_INFO 19")]
    public const int TCP_ICMP_ERROR_INFO = 19;
}
