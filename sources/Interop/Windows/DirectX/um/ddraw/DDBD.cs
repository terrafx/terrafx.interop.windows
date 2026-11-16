// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DDBD
{
    /// <include file='DDBD.xml' path='doc/member[@name="DDBD.DDBD_1"]/*' />
    [NativeTypeName("#define DDBD_1 0x00004000l")]
    public const int DDBD_1 = 0x00004000;

    /// <include file='DDBD.xml' path='doc/member[@name="DDBD.DDBD_2"]/*' />
    [NativeTypeName("#define DDBD_2 0x00002000l")]
    public const int DDBD_2 = 0x00002000;

    /// <include file='DDBD.xml' path='doc/member[@name="DDBD.DDBD_4"]/*' />
    [NativeTypeName("#define DDBD_4 0x00001000l")]
    public const int DDBD_4 = 0x00001000;

    /// <include file='DDBD.xml' path='doc/member[@name="DDBD.DDBD_8"]/*' />
    [NativeTypeName("#define DDBD_8 0x00000800l")]
    public const int DDBD_8 = 0x00000800;

    /// <include file='DDBD.xml' path='doc/member[@name="DDBD.DDBD_16"]/*' />
    [NativeTypeName("#define DDBD_16 0x00000400l")]
    public const int DDBD_16 = 0x00000400;

    /// <include file='DDBD.xml' path='doc/member[@name="DDBD.DDBD_24"]/*' />
    [NativeTypeName("#define DDBD_24 0X00000200l")]
    public const int DDBD_24 = 0X00000200;

    /// <include file='DDBD.xml' path='doc/member[@name="DDBD.DDBD_32"]/*' />
    [NativeTypeName("#define DDBD_32 0x00000100l")]
    public const int DDBD_32 = 0x00000100;
}
