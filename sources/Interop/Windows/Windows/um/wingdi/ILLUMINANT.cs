// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ILLUMINANT
{
    /// <include file='ILLUMINANT.xml' path='doc/member[@name="ILLUMINANT.ILLUMINANT_DEVICE_DEFAULT"]/*' />
    [NativeTypeName("#define ILLUMINANT_DEVICE_DEFAULT 0")]
    public const int ILLUMINANT_DEVICE_DEFAULT = 0;

    /// <include file='ILLUMINANT.xml' path='doc/member[@name="ILLUMINANT.ILLUMINANT_A"]/*' />
    [NativeTypeName("#define ILLUMINANT_A 1")]
    public const int ILLUMINANT_A = 1;

    /// <include file='ILLUMINANT.xml' path='doc/member[@name="ILLUMINANT.ILLUMINANT_B"]/*' />
    [NativeTypeName("#define ILLUMINANT_B 2")]
    public const int ILLUMINANT_B = 2;

    /// <include file='ILLUMINANT.xml' path='doc/member[@name="ILLUMINANT.ILLUMINANT_C"]/*' />
    [NativeTypeName("#define ILLUMINANT_C 3")]
    public const int ILLUMINANT_C = 3;

    /// <include file='ILLUMINANT.xml' path='doc/member[@name="ILLUMINANT.ILLUMINANT_D50"]/*' />
    [NativeTypeName("#define ILLUMINANT_D50 4")]
    public const int ILLUMINANT_D50 = 4;

    /// <include file='ILLUMINANT.xml' path='doc/member[@name="ILLUMINANT.ILLUMINANT_D55"]/*' />
    [NativeTypeName("#define ILLUMINANT_D55 5")]
    public const int ILLUMINANT_D55 = 5;

    /// <include file='ILLUMINANT.xml' path='doc/member[@name="ILLUMINANT.ILLUMINANT_D65"]/*' />
    [NativeTypeName("#define ILLUMINANT_D65 6")]
    public const int ILLUMINANT_D65 = 6;

    /// <include file='ILLUMINANT.xml' path='doc/member[@name="ILLUMINANT.ILLUMINANT_D75"]/*' />
    [NativeTypeName("#define ILLUMINANT_D75 7")]
    public const int ILLUMINANT_D75 = 7;

    /// <include file='ILLUMINANT.xml' path='doc/member[@name="ILLUMINANT.ILLUMINANT_F2"]/*' />
    [NativeTypeName("#define ILLUMINANT_F2 8")]
    public const int ILLUMINANT_F2 = 8;

    /// <include file='ILLUMINANT.xml' path='doc/member[@name="ILLUMINANT.ILLUMINANT_MAX_INDEX"]/*' />
    [NativeTypeName("#define ILLUMINANT_MAX_INDEX ILLUMINANT_F2")]
    public const int ILLUMINANT_MAX_INDEX = 8;

    /// <include file='ILLUMINANT.xml' path='doc/member[@name="ILLUMINANT.ILLUMINANT_TUNGSTEN"]/*' />
    [NativeTypeName("#define ILLUMINANT_TUNGSTEN ILLUMINANT_A")]
    public const int ILLUMINANT_TUNGSTEN = 1;

    /// <include file='ILLUMINANT.xml' path='doc/member[@name="ILLUMINANT.ILLUMINANT_DAYLIGHT"]/*' />
    [NativeTypeName("#define ILLUMINANT_DAYLIGHT ILLUMINANT_C")]
    public const int ILLUMINANT_DAYLIGHT = 3;

    /// <include file='ILLUMINANT.xml' path='doc/member[@name="ILLUMINANT.ILLUMINANT_FLUORESCENT"]/*' />
    [NativeTypeName("#define ILLUMINANT_FLUORESCENT ILLUMINANT_F2")]
    public const int ILLUMINANT_FLUORESCENT = 8;

    /// <include file='ILLUMINANT.xml' path='doc/member[@name="ILLUMINANT.ILLUMINANT_NTSC"]/*' />
    [NativeTypeName("#define ILLUMINANT_NTSC ILLUMINANT_C")]
    public const int ILLUMINANT_NTSC = 3;
}
