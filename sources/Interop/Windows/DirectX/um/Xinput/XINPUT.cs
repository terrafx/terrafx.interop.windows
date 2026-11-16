// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

public static partial class XINPUT
{
    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_DLL_A"]/*' />
    [NativeTypeName("#define XINPUT_DLL_A \"xinput1_4.dll\"")]
    public static ReadOnlySpan<byte> XINPUT_DLL_A => "xinput1_4.dll"u8;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_DLL_W"]/*' />
    [NativeTypeName("#define XINPUT_DLL_W L\"xinput1_4.dll\"")]
    public const string XINPUT_DLL_W = "xinput1_4.dll";

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_DLL"]/*' />
    [NativeTypeName("#define XINPUT_DLL XINPUT_DLL_W")]
    public const string XINPUT_DLL = "xinput1_4.dll";

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_DEVTYPE_GAMEPAD"]/*' />
    [NativeTypeName("#define XINPUT_DEVTYPE_GAMEPAD 0x01")]
    public const int XINPUT_DEVTYPE_GAMEPAD = 0x01;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_DEVSUBTYPE_GAMEPAD"]/*' />
    [NativeTypeName("#define XINPUT_DEVSUBTYPE_GAMEPAD 0x01")]
    public const int XINPUT_DEVSUBTYPE_GAMEPAD = 0x01;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_DEVSUBTYPE_UNKNOWN"]/*' />
    [NativeTypeName("#define XINPUT_DEVSUBTYPE_UNKNOWN 0x00")]
    public const int XINPUT_DEVSUBTYPE_UNKNOWN = 0x00;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_DEVSUBTYPE_WHEEL"]/*' />
    [NativeTypeName("#define XINPUT_DEVSUBTYPE_WHEEL 0x02")]
    public const int XINPUT_DEVSUBTYPE_WHEEL = 0x02;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_DEVSUBTYPE_ARCADE_STICK"]/*' />
    [NativeTypeName("#define XINPUT_DEVSUBTYPE_ARCADE_STICK 0x03")]
    public const int XINPUT_DEVSUBTYPE_ARCADE_STICK = 0x03;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_DEVSUBTYPE_FLIGHT_STICK"]/*' />
    [NativeTypeName("#define XINPUT_DEVSUBTYPE_FLIGHT_STICK 0x04")]
    public const int XINPUT_DEVSUBTYPE_FLIGHT_STICK = 0x04;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_DEVSUBTYPE_DANCE_PAD"]/*' />
    [NativeTypeName("#define XINPUT_DEVSUBTYPE_DANCE_PAD 0x05")]
    public const int XINPUT_DEVSUBTYPE_DANCE_PAD = 0x05;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_DEVSUBTYPE_GUITAR"]/*' />
    [NativeTypeName("#define XINPUT_DEVSUBTYPE_GUITAR 0x06")]
    public const int XINPUT_DEVSUBTYPE_GUITAR = 0x06;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_DEVSUBTYPE_GUITAR_ALTERNATE"]/*' />
    [NativeTypeName("#define XINPUT_DEVSUBTYPE_GUITAR_ALTERNATE 0x07")]
    public const int XINPUT_DEVSUBTYPE_GUITAR_ALTERNATE = 0x07;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_DEVSUBTYPE_DRUM_KIT"]/*' />
    [NativeTypeName("#define XINPUT_DEVSUBTYPE_DRUM_KIT 0x08")]
    public const int XINPUT_DEVSUBTYPE_DRUM_KIT = 0x08;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_DEVSUBTYPE_GUITAR_BASS"]/*' />
    [NativeTypeName("#define XINPUT_DEVSUBTYPE_GUITAR_BASS 0x0B")]
    public const int XINPUT_DEVSUBTYPE_GUITAR_BASS = 0x0B;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_DEVSUBTYPE_ARCADE_PAD"]/*' />
    [NativeTypeName("#define XINPUT_DEVSUBTYPE_ARCADE_PAD 0x13")]
    public const int XINPUT_DEVSUBTYPE_ARCADE_PAD = 0x13;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_CAPS_VOICE_SUPPORTED"]/*' />
    [NativeTypeName("#define XINPUT_CAPS_VOICE_SUPPORTED 0x0004")]
    public const int XINPUT_CAPS_VOICE_SUPPORTED = 0x0004;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_CAPS_FFB_SUPPORTED"]/*' />
    [NativeTypeName("#define XINPUT_CAPS_FFB_SUPPORTED 0x0001")]
    public const int XINPUT_CAPS_FFB_SUPPORTED = 0x0001;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_CAPS_WIRELESS"]/*' />
    [NativeTypeName("#define XINPUT_CAPS_WIRELESS 0x0002")]
    public const int XINPUT_CAPS_WIRELESS = 0x0002;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_CAPS_PMD_SUPPORTED"]/*' />
    [NativeTypeName("#define XINPUT_CAPS_PMD_SUPPORTED 0x0008")]
    public const int XINPUT_CAPS_PMD_SUPPORTED = 0x0008;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_CAPS_NO_NAVIGATION"]/*' />
    [NativeTypeName("#define XINPUT_CAPS_NO_NAVIGATION 0x0010")]
    public const int XINPUT_CAPS_NO_NAVIGATION = 0x0010;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_DPAD_UP"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_DPAD_UP 0x0001")]
    public const int XINPUT_GAMEPAD_DPAD_UP = 0x0001;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_DPAD_DOWN"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_DPAD_DOWN 0x0002")]
    public const int XINPUT_GAMEPAD_DPAD_DOWN = 0x0002;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_DPAD_LEFT"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_DPAD_LEFT 0x0004")]
    public const int XINPUT_GAMEPAD_DPAD_LEFT = 0x0004;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_DPAD_RIGHT"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_DPAD_RIGHT 0x0008")]
    public const int XINPUT_GAMEPAD_DPAD_RIGHT = 0x0008;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_START"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_START 0x0010")]
    public const int XINPUT_GAMEPAD_START = 0x0010;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_BACK"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_BACK 0x0020")]
    public const int XINPUT_GAMEPAD_BACK = 0x0020;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_LEFT_THUMB"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_LEFT_THUMB 0x0040")]
    public const int XINPUT_GAMEPAD_LEFT_THUMB = 0x0040;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_RIGHT_THUMB"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_RIGHT_THUMB 0x0080")]
    public const int XINPUT_GAMEPAD_RIGHT_THUMB = 0x0080;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_LEFT_SHOULDER"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_LEFT_SHOULDER 0x0100")]
    public const int XINPUT_GAMEPAD_LEFT_SHOULDER = 0x0100;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_RIGHT_SHOULDER"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_RIGHT_SHOULDER 0x0200")]
    public const int XINPUT_GAMEPAD_RIGHT_SHOULDER = 0x0200;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_A"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_A 0x1000")]
    public const int XINPUT_GAMEPAD_A = 0x1000;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_B"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_B 0x2000")]
    public const int XINPUT_GAMEPAD_B = 0x2000;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_X"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_X 0x4000")]
    public const int XINPUT_GAMEPAD_X = 0x4000;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_Y"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_Y 0x8000")]
    public const int XINPUT_GAMEPAD_Y = 0x8000;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE 7849")]
    public const int XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE = 7849;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE 8689")]
    public const int XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE = 8689;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_GAMEPAD_TRIGGER_THRESHOLD"]/*' />
    [NativeTypeName("#define XINPUT_GAMEPAD_TRIGGER_THRESHOLD 30")]
    public const int XINPUT_GAMEPAD_TRIGGER_THRESHOLD = 30;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_FLAG_GAMEPAD"]/*' />
    [NativeTypeName("#define XINPUT_FLAG_GAMEPAD 0x00000001")]
    public const int XINPUT_FLAG_GAMEPAD = 0x00000001;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_KEYSTROKE_KEYDOWN"]/*' />
    [NativeTypeName("#define XINPUT_KEYSTROKE_KEYDOWN 0x0001")]
    public const int XINPUT_KEYSTROKE_KEYDOWN = 0x0001;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_KEYSTROKE_KEYUP"]/*' />
    [NativeTypeName("#define XINPUT_KEYSTROKE_KEYUP 0x0002")]
    public const int XINPUT_KEYSTROKE_KEYUP = 0x0002;

    /// <include file='XINPUT.xml' path='doc/member[@name="XINPUT.XINPUT_KEYSTROKE_REPEAT"]/*' />
    [NativeTypeName("#define XINPUT_KEYSTROKE_REPEAT 0x0004")]
    public const int XINPUT_KEYSTROKE_REPEAT = 0x0004;
}
