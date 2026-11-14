// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PIDVSI
{
    /// <include file='PIDVSI.xml' path='doc/member[@name="PIDVSI.PIDVSI_STREAM_NAME"]/*' />
    [NativeTypeName("#define PIDVSI_STREAM_NAME 0x00000002")]
    public const int PIDVSI_STREAM_NAME = 0x00000002;

    /// <include file='PIDVSI.xml' path='doc/member[@name="PIDVSI.PIDVSI_FRAME_WIDTH"]/*' />
    [NativeTypeName("#define PIDVSI_FRAME_WIDTH 0x00000003")]
    public const int PIDVSI_FRAME_WIDTH = 0x00000003;

    /// <include file='PIDVSI.xml' path='doc/member[@name="PIDVSI.PIDVSI_FRAME_HEIGHT"]/*' />
    [NativeTypeName("#define PIDVSI_FRAME_HEIGHT 0x00000004")]
    public const int PIDVSI_FRAME_HEIGHT = 0x00000004;

    /// <include file='PIDVSI.xml' path='doc/member[@name="PIDVSI.PIDVSI_TIMELENGTH"]/*' />
    [NativeTypeName("#define PIDVSI_TIMELENGTH 0x00000007")]
    public const int PIDVSI_TIMELENGTH = 0x00000007;

    /// <include file='PIDVSI.xml' path='doc/member[@name="PIDVSI.PIDVSI_FRAME_COUNT"]/*' />
    [NativeTypeName("#define PIDVSI_FRAME_COUNT 0x00000005")]
    public const int PIDVSI_FRAME_COUNT = 0x00000005;

    /// <include file='PIDVSI.xml' path='doc/member[@name="PIDVSI.PIDVSI_FRAME_RATE"]/*' />
    [NativeTypeName("#define PIDVSI_FRAME_RATE 0x00000006")]
    public const int PIDVSI_FRAME_RATE = 0x00000006;

    /// <include file='PIDVSI.xml' path='doc/member[@name="PIDVSI.PIDVSI_DATA_RATE"]/*' />
    [NativeTypeName("#define PIDVSI_DATA_RATE 0x00000008")]
    public const int PIDVSI_DATA_RATE = 0x00000008;

    /// <include file='PIDVSI.xml' path='doc/member[@name="PIDVSI.PIDVSI_SAMPLE_SIZE"]/*' />
    [NativeTypeName("#define PIDVSI_SAMPLE_SIZE 0x00000009")]
    public const int PIDVSI_SAMPLE_SIZE = 0x00000009;

    /// <include file='PIDVSI.xml' path='doc/member[@name="PIDVSI.PIDVSI_COMPRESSION"]/*' />
    [NativeTypeName("#define PIDVSI_COMPRESSION 0x0000000A")]
    public const int PIDVSI_COMPRESSION = 0x0000000A;

    /// <include file='PIDVSI.xml' path='doc/member[@name="PIDVSI.PIDVSI_STREAM_NUMBER"]/*' />
    [NativeTypeName("#define PIDVSI_STREAM_NUMBER 0x0000000B")]
    public const int PIDVSI_STREAM_NUMBER = 0x0000000B;
}
