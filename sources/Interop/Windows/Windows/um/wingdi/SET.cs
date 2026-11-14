// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SET
{
    /// <include file='SET.xml' path='doc/member[@name="SET.SET_ARC_DIRECTION"]/*' />
    [NativeTypeName("#define SET_ARC_DIRECTION 4102")]
    public const int SET_ARC_DIRECTION = 4102;

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_BACKGROUND_COLOR"]/*' />
    [NativeTypeName("#define SET_BACKGROUND_COLOR 4103")]
    public const int SET_BACKGROUND_COLOR = 4103;

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_POLY_MODE"]/*' />
    [NativeTypeName("#define SET_POLY_MODE 4104")]
    public const int SET_POLY_MODE = 4104;

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_SCREEN_ANGLE"]/*' />
    [NativeTypeName("#define SET_SCREEN_ANGLE 4105")]
    public const int SET_SCREEN_ANGLE = 4105;

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_SPREAD"]/*' />
    [NativeTypeName("#define SET_SPREAD 4106")]
    public const int SET_SPREAD = 4106;

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_CLIP_BOX"]/*' />
    [NativeTypeName("#define SET_CLIP_BOX 4108")]
    public const int SET_CLIP_BOX = 4108;

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_BOUNDS"]/*' />
    [NativeTypeName("#define SET_BOUNDS 4109")]
    public const int SET_BOUNDS = 4109;

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_MIRROR_MODE"]/*' />
    [NativeTypeName("#define SET_MIRROR_MODE 4110")]
    public const int SET_MIRROR_MODE = 4110;
}
