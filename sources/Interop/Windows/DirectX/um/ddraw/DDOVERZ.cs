// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DDOVERZ
{
    /// <include file='DDOVERZ.xml' path='doc/member[@name="DDOVERZ.DDOVERZ_SENDTOFRONT"]/*' />
    [NativeTypeName("#define DDOVERZ_SENDTOFRONT 0x00000000l")]
    public const int DDOVERZ_SENDTOFRONT = 0x00000000;

    /// <include file='DDOVERZ.xml' path='doc/member[@name="DDOVERZ.DDOVERZ_SENDTOBACK"]/*' />
    [NativeTypeName("#define DDOVERZ_SENDTOBACK 0x00000001l")]
    public const int DDOVERZ_SENDTOBACK = 0x00000001;

    /// <include file='DDOVERZ.xml' path='doc/member[@name="DDOVERZ.DDOVERZ_MOVEFORWARD"]/*' />
    [NativeTypeName("#define DDOVERZ_MOVEFORWARD 0x00000002l")]
    public const int DDOVERZ_MOVEFORWARD = 0x00000002;

    /// <include file='DDOVERZ.xml' path='doc/member[@name="DDOVERZ.DDOVERZ_MOVEBACKWARD"]/*' />
    [NativeTypeName("#define DDOVERZ_MOVEBACKWARD 0x00000003l")]
    public const int DDOVERZ_MOVEBACKWARD = 0x00000003;

    /// <include file='DDOVERZ.xml' path='doc/member[@name="DDOVERZ.DDOVERZ_INSERTINFRONTOF"]/*' />
    [NativeTypeName("#define DDOVERZ_INSERTINFRONTOF 0x00000004l")]
    public const int DDOVERZ_INSERTINFRONTOF = 0x00000004;

    /// <include file='DDOVERZ.xml' path='doc/member[@name="DDOVERZ.DDOVERZ_INSERTINBACKOF"]/*' />
    [NativeTypeName("#define DDOVERZ_INSERTINBACKOF 0x00000005l")]
    public const int DDOVERZ_INSERTINBACKOF = 0x00000005;
}
