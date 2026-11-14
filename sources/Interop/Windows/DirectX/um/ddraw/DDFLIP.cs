// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DDFLIP
{
    /// <include file='DDFLIP.xml' path='doc/member[@name="DDFLIP.DDFLIP_WAIT"]/*' />
    [NativeTypeName("#define DDFLIP_WAIT 0x00000001L")]
    public const int DDFLIP_WAIT = 0x00000001;

    /// <include file='DDFLIP.xml' path='doc/member[@name="DDFLIP.DDFLIP_EVEN"]/*' />
    [NativeTypeName("#define DDFLIP_EVEN 0x00000002L")]
    public const int DDFLIP_EVEN = 0x00000002;

    /// <include file='DDFLIP.xml' path='doc/member[@name="DDFLIP.DDFLIP_ODD"]/*' />
    [NativeTypeName("#define DDFLIP_ODD 0x00000004L")]
    public const int DDFLIP_ODD = 0x00000004;

    /// <include file='DDFLIP.xml' path='doc/member[@name="DDFLIP.DDFLIP_NOVSYNC"]/*' />
    [NativeTypeName("#define DDFLIP_NOVSYNC 0x00000008L")]
    public const int DDFLIP_NOVSYNC = 0x00000008;

    /// <include file='DDFLIP.xml' path='doc/member[@name="DDFLIP.DDFLIP_INTERVAL2"]/*' />
    [NativeTypeName("#define DDFLIP_INTERVAL2 0x02000000L")]
    public const int DDFLIP_INTERVAL2 = 0x02000000;

    /// <include file='DDFLIP.xml' path='doc/member[@name="DDFLIP.DDFLIP_INTERVAL3"]/*' />
    [NativeTypeName("#define DDFLIP_INTERVAL3 0x03000000L")]
    public const int DDFLIP_INTERVAL3 = 0x03000000;

    /// <include file='DDFLIP.xml' path='doc/member[@name="DDFLIP.DDFLIP_INTERVAL4"]/*' />
    [NativeTypeName("#define DDFLIP_INTERVAL4 0x04000000L")]
    public const int DDFLIP_INTERVAL4 = 0x04000000;

    /// <include file='DDFLIP.xml' path='doc/member[@name="DDFLIP.DDFLIP_STEREO"]/*' />
    [NativeTypeName("#define DDFLIP_STEREO 0x00000010L")]
    public const int DDFLIP_STEREO = 0x00000010;

    /// <include file='DDFLIP.xml' path='doc/member[@name="DDFLIP.DDFLIP_DONOTWAIT"]/*' />
    [NativeTypeName("#define DDFLIP_DONOTWAIT 0x00000020L")]
    public const int DDFLIP_DONOTWAIT = 0x00000020;
}
