// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SPEAKER
{
    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_FRONT_LEFT"]/*' />
    [NativeTypeName("#define SPEAKER_FRONT_LEFT 0x1")]
    public const int SPEAKER_FRONT_LEFT = 0x1;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_FRONT_RIGHT"]/*' />
    [NativeTypeName("#define SPEAKER_FRONT_RIGHT 0x2")]
    public const int SPEAKER_FRONT_RIGHT = 0x2;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_FRONT_CENTER"]/*' />
    [NativeTypeName("#define SPEAKER_FRONT_CENTER 0x4")]
    public const int SPEAKER_FRONT_CENTER = 0x4;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_LOW_FREQUENCY"]/*' />
    [NativeTypeName("#define SPEAKER_LOW_FREQUENCY 0x8")]
    public const int SPEAKER_LOW_FREQUENCY = 0x8;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_BACK_LEFT"]/*' />
    [NativeTypeName("#define SPEAKER_BACK_LEFT 0x10")]
    public const int SPEAKER_BACK_LEFT = 0x10;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_BACK_RIGHT"]/*' />
    [NativeTypeName("#define SPEAKER_BACK_RIGHT 0x20")]
    public const int SPEAKER_BACK_RIGHT = 0x20;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_FRONT_LEFT_OF_CENTER"]/*' />
    [NativeTypeName("#define SPEAKER_FRONT_LEFT_OF_CENTER 0x40")]
    public const int SPEAKER_FRONT_LEFT_OF_CENTER = 0x40;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_FRONT_RIGHT_OF_CENTER"]/*' />
    [NativeTypeName("#define SPEAKER_FRONT_RIGHT_OF_CENTER 0x80")]
    public const int SPEAKER_FRONT_RIGHT_OF_CENTER = 0x80;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_BACK_CENTER"]/*' />
    [NativeTypeName("#define SPEAKER_BACK_CENTER 0x100")]
    public const int SPEAKER_BACK_CENTER = 0x100;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_SIDE_LEFT"]/*' />
    [NativeTypeName("#define SPEAKER_SIDE_LEFT 0x200")]
    public const int SPEAKER_SIDE_LEFT = 0x200;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_SIDE_RIGHT"]/*' />
    [NativeTypeName("#define SPEAKER_SIDE_RIGHT 0x400")]
    public const int SPEAKER_SIDE_RIGHT = 0x400;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_TOP_CENTER"]/*' />
    [NativeTypeName("#define SPEAKER_TOP_CENTER 0x800")]
    public const int SPEAKER_TOP_CENTER = 0x800;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_TOP_FRONT_LEFT"]/*' />
    [NativeTypeName("#define SPEAKER_TOP_FRONT_LEFT 0x1000")]
    public const int SPEAKER_TOP_FRONT_LEFT = 0x1000;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_TOP_FRONT_CENTER"]/*' />
    [NativeTypeName("#define SPEAKER_TOP_FRONT_CENTER 0x2000")]
    public const int SPEAKER_TOP_FRONT_CENTER = 0x2000;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_TOP_FRONT_RIGHT"]/*' />
    [NativeTypeName("#define SPEAKER_TOP_FRONT_RIGHT 0x4000")]
    public const int SPEAKER_TOP_FRONT_RIGHT = 0x4000;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_TOP_BACK_LEFT"]/*' />
    [NativeTypeName("#define SPEAKER_TOP_BACK_LEFT 0x8000")]
    public const int SPEAKER_TOP_BACK_LEFT = 0x8000;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_TOP_BACK_CENTER"]/*' />
    [NativeTypeName("#define SPEAKER_TOP_BACK_CENTER 0x10000")]
    public const int SPEAKER_TOP_BACK_CENTER = 0x10000;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_TOP_BACK_RIGHT"]/*' />
    [NativeTypeName("#define SPEAKER_TOP_BACK_RIGHT 0x20000")]
    public const int SPEAKER_TOP_BACK_RIGHT = 0x20000;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_RESERVED"]/*' />
    [NativeTypeName("#define SPEAKER_RESERVED 0x7FFC0000")]
    public const int SPEAKER_RESERVED = 0x7FFC0000;

    /// <include file='SPEAKER.xml' path='doc/member[@name="SPEAKER.SPEAKER_ALL"]/*' />
    [NativeTypeName("#define SPEAKER_ALL 0x80000000")]
    public const uint SPEAKER_ALL = 0x80000000;
}
