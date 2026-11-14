// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PIPE
{
    /// <include file='PIPE.xml' path='doc/member[@name="PIPE.PIPE_ACCESS_INBOUND"]/*' />
    [NativeTypeName("#define PIPE_ACCESS_INBOUND 0x00000001")]
    public const int PIPE_ACCESS_INBOUND = 0x00000001;

    /// <include file='PIPE.xml' path='doc/member[@name="PIPE.PIPE_ACCESS_OUTBOUND"]/*' />
    [NativeTypeName("#define PIPE_ACCESS_OUTBOUND 0x00000002")]
    public const int PIPE_ACCESS_OUTBOUND = 0x00000002;

    /// <include file='PIPE.xml' path='doc/member[@name="PIPE.PIPE_ACCESS_DUPLEX"]/*' />
    [NativeTypeName("#define PIPE_ACCESS_DUPLEX 0x00000003")]
    public const int PIPE_ACCESS_DUPLEX = 0x00000003;

    /// <include file='PIPE.xml' path='doc/member[@name="PIPE.PIPE_CLIENT_END"]/*' />
    [NativeTypeName("#define PIPE_CLIENT_END 0x00000000")]
    public const int PIPE_CLIENT_END = 0x00000000;

    /// <include file='PIPE.xml' path='doc/member[@name="PIPE.PIPE_SERVER_END"]/*' />
    [NativeTypeName("#define PIPE_SERVER_END 0x00000001")]
    public const int PIPE_SERVER_END = 0x00000001;

    /// <include file='PIPE.xml' path='doc/member[@name="PIPE.PIPE_WAIT"]/*' />
    [NativeTypeName("#define PIPE_WAIT 0x00000000")]
    public const int PIPE_WAIT = 0x00000000;

    /// <include file='PIPE.xml' path='doc/member[@name="PIPE.PIPE_NOWAIT"]/*' />
    [NativeTypeName("#define PIPE_NOWAIT 0x00000001")]
    public const int PIPE_NOWAIT = 0x00000001;

    /// <include file='PIPE.xml' path='doc/member[@name="PIPE.PIPE_READMODE_BYTE"]/*' />
    [NativeTypeName("#define PIPE_READMODE_BYTE 0x00000000")]
    public const int PIPE_READMODE_BYTE = 0x00000000;

    /// <include file='PIPE.xml' path='doc/member[@name="PIPE.PIPE_READMODE_MESSAGE"]/*' />
    [NativeTypeName("#define PIPE_READMODE_MESSAGE 0x00000002")]
    public const int PIPE_READMODE_MESSAGE = 0x00000002;

    /// <include file='PIPE.xml' path='doc/member[@name="PIPE.PIPE_TYPE_BYTE"]/*' />
    [NativeTypeName("#define PIPE_TYPE_BYTE 0x00000000")]
    public const int PIPE_TYPE_BYTE = 0x00000000;

    /// <include file='PIPE.xml' path='doc/member[@name="PIPE.PIPE_TYPE_MESSAGE"]/*' />
    [NativeTypeName("#define PIPE_TYPE_MESSAGE 0x00000004")]
    public const int PIPE_TYPE_MESSAGE = 0x00000004;

    /// <include file='PIPE.xml' path='doc/member[@name="PIPE.PIPE_ACCEPT_REMOTE_CLIENTS"]/*' />
    [NativeTypeName("#define PIPE_ACCEPT_REMOTE_CLIENTS 0x00000000")]
    public const int PIPE_ACCEPT_REMOTE_CLIENTS = 0x00000000;

    /// <include file='PIPE.xml' path='doc/member[@name="PIPE.PIPE_REJECT_REMOTE_CLIENTS"]/*' />
    [NativeTypeName("#define PIPE_REJECT_REMOTE_CLIENTS 0x00000008")]
    public const int PIPE_REJECT_REMOTE_CLIENTS = 0x00000008;

    /// <include file='PIPE.xml' path='doc/member[@name="PIPE.PIPE_UNLIMITED_INSTANCES"]/*' />
    [NativeTypeName("#define PIPE_UNLIMITED_INSTANCES 255")]
    public const int PIPE_UNLIMITED_INSTANCES = 255;
}
