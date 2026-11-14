// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SO
{
    /// <include file='SO.xml' path='doc/member[@name="SO.SO_DEBUG"]/*' />
    [NativeTypeName("#define SO_DEBUG 0x0001")]
    public const int SO_DEBUG = 0x0001;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_ACCEPTCONN"]/*' />
    [NativeTypeName("#define SO_ACCEPTCONN 0x0002")]
    public const int SO_ACCEPTCONN = 0x0002;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_REUSEADDR"]/*' />
    [NativeTypeName("#define SO_REUSEADDR 0x0004")]
    public const int SO_REUSEADDR = 0x0004;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_KEEPALIVE"]/*' />
    [NativeTypeName("#define SO_KEEPALIVE 0x0008")]
    public const int SO_KEEPALIVE = 0x0008;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_DONTROUTE"]/*' />
    [NativeTypeName("#define SO_DONTROUTE 0x0010")]
    public const int SO_DONTROUTE = 0x0010;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_BROADCAST"]/*' />
    [NativeTypeName("#define SO_BROADCAST 0x0020")]
    public const int SO_BROADCAST = 0x0020;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_USELOOPBACK"]/*' />
    [NativeTypeName("#define SO_USELOOPBACK 0x0040")]
    public const int SO_USELOOPBACK = 0x0040;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_LINGER"]/*' />
    [NativeTypeName("#define SO_LINGER 0x0080")]
    public const int SO_LINGER = 0x0080;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_OOBINLINE"]/*' />
    [NativeTypeName("#define SO_OOBINLINE 0x0100")]
    public const int SO_OOBINLINE = 0x0100;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_DONTLINGER"]/*' />
    [NativeTypeName("#define SO_DONTLINGER (int)(~SO_LINGER)")]
    public const int SO_DONTLINGER = (int)(~0x0080);

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_EXCLUSIVEADDRUSE"]/*' />
    [NativeTypeName("#define SO_EXCLUSIVEADDRUSE ((int)(~SO_REUSEADDR))")]
    public const int SO_EXCLUSIVEADDRUSE = ((int)(~0x0004));

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_SNDBUF"]/*' />
    [NativeTypeName("#define SO_SNDBUF 0x1001")]
    public const int SO_SNDBUF = 0x1001;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_RCVBUF"]/*' />
    [NativeTypeName("#define SO_RCVBUF 0x1002")]
    public const int SO_RCVBUF = 0x1002;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_SNDLOWAT"]/*' />
    [NativeTypeName("#define SO_SNDLOWAT 0x1003")]
    public const int SO_SNDLOWAT = 0x1003;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_RCVLOWAT"]/*' />
    [NativeTypeName("#define SO_RCVLOWAT 0x1004")]
    public const int SO_RCVLOWAT = 0x1004;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_SNDTIMEO"]/*' />
    [NativeTypeName("#define SO_SNDTIMEO 0x1005")]
    public const int SO_SNDTIMEO = 0x1005;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_RCVTIMEO"]/*' />
    [NativeTypeName("#define SO_RCVTIMEO 0x1006")]
    public const int SO_RCVTIMEO = 0x1006;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_ERROR"]/*' />
    [NativeTypeName("#define SO_ERROR 0x1007")]
    public const int SO_ERROR = 0x1007;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_TYPE"]/*' />
    [NativeTypeName("#define SO_TYPE 0x1008")]
    public const int SO_TYPE = 0x1008;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_BSP_STATE"]/*' />
    [NativeTypeName("#define SO_BSP_STATE 0x1009")]
    public const int SO_BSP_STATE = 0x1009;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_GROUP_ID"]/*' />
    [NativeTypeName("#define SO_GROUP_ID 0x2001")]
    public const int SO_GROUP_ID = 0x2001;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_GROUP_PRIORITY"]/*' />
    [NativeTypeName("#define SO_GROUP_PRIORITY 0x2002")]
    public const int SO_GROUP_PRIORITY = 0x2002;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_MAX_MSG_SIZE"]/*' />
    [NativeTypeName("#define SO_MAX_MSG_SIZE 0x2003")]
    public const int SO_MAX_MSG_SIZE = 0x2003;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_CONDITIONAL_ACCEPT"]/*' />
    [NativeTypeName("#define SO_CONDITIONAL_ACCEPT 0x3002")]
    public const int SO_CONDITIONAL_ACCEPT = 0x3002;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_PAUSE_ACCEPT"]/*' />
    [NativeTypeName("#define SO_PAUSE_ACCEPT 0x3003")]
    public const int SO_PAUSE_ACCEPT = 0x3003;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_COMPARTMENT_ID"]/*' />
    [NativeTypeName("#define SO_COMPARTMENT_ID 0x3004")]
    public const int SO_COMPARTMENT_ID = 0x3004;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_RANDOMIZE_PORT"]/*' />
    [NativeTypeName("#define SO_RANDOMIZE_PORT 0x3005")]
    public const int SO_RANDOMIZE_PORT = 0x3005;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_PORT_SCALABILITY"]/*' />
    [NativeTypeName("#define SO_PORT_SCALABILITY 0x3006")]
    public const int SO_PORT_SCALABILITY = 0x3006;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_REUSE_UNICASTPORT"]/*' />
    [NativeTypeName("#define SO_REUSE_UNICASTPORT 0x3007")]
    public const int SO_REUSE_UNICASTPORT = 0x3007;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_REUSE_MULTICASTPORT"]/*' />
    [NativeTypeName("#define SO_REUSE_MULTICASTPORT 0x3008")]
    public const int SO_REUSE_MULTICASTPORT = 0x3008;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_ORIGINAL_DST"]/*' />
    [NativeTypeName("#define SO_ORIGINAL_DST 0x300F")]
    public const int SO_ORIGINAL_DST = 0x300F;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_RECEIVED_HOPLIMIT"]/*' />
    [NativeTypeName("#define SO_RECEIVED_HOPLIMIT 0x3010")]
    public const int SO_RECEIVED_HOPLIMIT = 0x3010;

    /// <include file='SO.xml' path='doc/member[@name="SO.SO_RECEIVED_PROCESSOR"]/*' />
    [NativeTypeName("#define SO_RECEIVED_PROCESSOR 0x3011")]
    public const int SO_RECEIVED_PROCESSOR = 0x3011;
}
