// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CM
{
    /// <include file='CM.xml' path='doc/member[@name="CM.CM_OUT_OF_GAMUT"]/*' />
    [NativeTypeName("#define CM_OUT_OF_GAMUT 255")]
    public const int CM_OUT_OF_GAMUT = 255;

    /// <include file='CM.xml' path='doc/member[@name="CM.CM_IN_GAMUT"]/*' />
    [NativeTypeName("#define CM_IN_GAMUT 0")]
    public const int CM_IN_GAMUT = 0;

    /// <include file='CM.xml' path='doc/member[@name="CM.CM_NONE"]/*' />
    [NativeTypeName("#define CM_NONE 0x00000000")]
    public const int CM_NONE = 0x00000000;

    /// <include file='CM.xml' path='doc/member[@name="CM.CM_DEVICE_ICM"]/*' />
    [NativeTypeName("#define CM_DEVICE_ICM 0x00000001")]
    public const int CM_DEVICE_ICM = 0x00000001;

    /// <include file='CM.xml' path='doc/member[@name="CM.CM_GAMMA_RAMP"]/*' />
    [NativeTypeName("#define CM_GAMMA_RAMP 0x00000002")]
    public const int CM_GAMMA_RAMP = 0x00000002;

    /// <include file='CM.xml' path='doc/member[@name="CM.CM_CMYK_COLOR"]/*' />
    [NativeTypeName("#define CM_CMYK_COLOR 0x00000004")]
    public const int CM_CMYK_COLOR = 0x00000004;
}
