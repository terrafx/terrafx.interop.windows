// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tvout.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class VP
{
    /// <include file='VP.xml' path='doc/member[@name="VP.VP_COMMAND_GET"]/*' />
    [NativeTypeName("#define VP_COMMAND_GET 0x0001")]
    public const int VP_COMMAND_GET = 0x0001;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_COMMAND_SET"]/*' />
    [NativeTypeName("#define VP_COMMAND_SET 0x0002")]
    public const int VP_COMMAND_SET = 0x0002;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_FLAGS_TV_MODE"]/*' />
    [NativeTypeName("#define VP_FLAGS_TV_MODE 0x0001")]
    public const int VP_FLAGS_TV_MODE = 0x0001;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_FLAGS_TV_STANDARD"]/*' />
    [NativeTypeName("#define VP_FLAGS_TV_STANDARD 0x0002")]
    public const int VP_FLAGS_TV_STANDARD = 0x0002;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_FLAGS_FLICKER"]/*' />
    [NativeTypeName("#define VP_FLAGS_FLICKER 0x0004")]
    public const int VP_FLAGS_FLICKER = 0x0004;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_FLAGS_OVERSCAN"]/*' />
    [NativeTypeName("#define VP_FLAGS_OVERSCAN 0x0008")]
    public const int VP_FLAGS_OVERSCAN = 0x0008;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_FLAGS_MAX_UNSCALED"]/*' />
    [NativeTypeName("#define VP_FLAGS_MAX_UNSCALED 0x0010")]
    public const int VP_FLAGS_MAX_UNSCALED = 0x0010;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_FLAGS_POSITION"]/*' />
    [NativeTypeName("#define VP_FLAGS_POSITION 0x0020")]
    public const int VP_FLAGS_POSITION = 0x0020;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_FLAGS_BRIGHTNESS"]/*' />
    [NativeTypeName("#define VP_FLAGS_BRIGHTNESS 0x0040")]
    public const int VP_FLAGS_BRIGHTNESS = 0x0040;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_FLAGS_CONTRAST"]/*' />
    [NativeTypeName("#define VP_FLAGS_CONTRAST 0x0080")]
    public const int VP_FLAGS_CONTRAST = 0x0080;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_FLAGS_COPYPROTECT"]/*' />
    [NativeTypeName("#define VP_FLAGS_COPYPROTECT 0x0100")]
    public const int VP_FLAGS_COPYPROTECT = 0x0100;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_MODE_WIN_GRAPHICS"]/*' />
    [NativeTypeName("#define VP_MODE_WIN_GRAPHICS 0x0001")]
    public const int VP_MODE_WIN_GRAPHICS = 0x0001;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_MODE_TV_PLAYBACK"]/*' />
    [NativeTypeName("#define VP_MODE_TV_PLAYBACK 0x0002")]
    public const int VP_MODE_TV_PLAYBACK = 0x0002;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_NTSC_M"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_NTSC_M 0x0001")]
    public const int VP_TV_STANDARD_NTSC_M = 0x0001;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_NTSC_M_J"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_NTSC_M_J 0x0002")]
    public const int VP_TV_STANDARD_NTSC_M_J = 0x0002;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_PAL_B"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_PAL_B 0x0004")]
    public const int VP_TV_STANDARD_PAL_B = 0x0004;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_PAL_D"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_PAL_D 0x0008")]
    public const int VP_TV_STANDARD_PAL_D = 0x0008;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_PAL_H"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_PAL_H 0x0010")]
    public const int VP_TV_STANDARD_PAL_H = 0x0010;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_PAL_I"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_PAL_I 0x0020")]
    public const int VP_TV_STANDARD_PAL_I = 0x0020;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_PAL_M"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_PAL_M 0x0040")]
    public const int VP_TV_STANDARD_PAL_M = 0x0040;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_PAL_N"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_PAL_N 0x0080")]
    public const int VP_TV_STANDARD_PAL_N = 0x0080;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_SECAM_B"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_SECAM_B 0x0100")]
    public const int VP_TV_STANDARD_SECAM_B = 0x0100;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_SECAM_D"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_SECAM_D 0x0200")]
    public const int VP_TV_STANDARD_SECAM_D = 0x0200;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_SECAM_G"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_SECAM_G 0x0400")]
    public const int VP_TV_STANDARD_SECAM_G = 0x0400;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_SECAM_H"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_SECAM_H 0x0800")]
    public const int VP_TV_STANDARD_SECAM_H = 0x0800;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_SECAM_K"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_SECAM_K 0x1000")]
    public const int VP_TV_STANDARD_SECAM_K = 0x1000;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_SECAM_K1"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_SECAM_K1 0x2000")]
    public const int VP_TV_STANDARD_SECAM_K1 = 0x2000;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_SECAM_L"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_SECAM_L 0x4000")]
    public const int VP_TV_STANDARD_SECAM_L = 0x4000;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_WIN_VGA"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_WIN_VGA 0x8000")]
    public const int VP_TV_STANDARD_WIN_VGA = 0x8000;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_NTSC_433"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_NTSC_433 0x00010000")]
    public const int VP_TV_STANDARD_NTSC_433 = 0x00010000;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_PAL_G"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_PAL_G 0x00020000")]
    public const int VP_TV_STANDARD_PAL_G = 0x00020000;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_PAL_60"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_PAL_60 0x00040000")]
    public const int VP_TV_STANDARD_PAL_60 = 0x00040000;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_TV_STANDARD_SECAM_L1"]/*' />
    [NativeTypeName("#define VP_TV_STANDARD_SECAM_L1 0x00080000")]
    public const int VP_TV_STANDARD_SECAM_L1 = 0x00080000;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_CP_TYPE_APS_TRIGGER"]/*' />
    [NativeTypeName("#define VP_CP_TYPE_APS_TRIGGER 0x0001")]
    public const int VP_CP_TYPE_APS_TRIGGER = 0x0001;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_CP_TYPE_MACROVISION"]/*' />
    [NativeTypeName("#define VP_CP_TYPE_MACROVISION 0x0002")]
    public const int VP_CP_TYPE_MACROVISION = 0x0002;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_CP_CMD_ACTIVATE"]/*' />
    [NativeTypeName("#define VP_CP_CMD_ACTIVATE 0x0001")]
    public const int VP_CP_CMD_ACTIVATE = 0x0001;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_CP_CMD_DEACTIVATE"]/*' />
    [NativeTypeName("#define VP_CP_CMD_DEACTIVATE 0x0002")]
    public const int VP_CP_CMD_DEACTIVATE = 0x0002;

    /// <include file='VP.xml' path='doc/member[@name="VP.VP_CP_CMD_CHANGE"]/*' />
    [NativeTypeName("#define VP_CP_CMD_CHANGE 0x0004")]
    public const int VP_CP_CMD_CHANGE = 0x0004;
}
