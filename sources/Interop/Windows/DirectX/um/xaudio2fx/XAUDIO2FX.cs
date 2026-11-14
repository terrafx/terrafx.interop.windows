// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class XAUDIO2FX
{
    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_FRAMERATE"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_FRAMERATE 20000")]
    public const int XAUDIO2FX_REVERB_MIN_FRAMERATE = 20000;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_FRAMERATE"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_FRAMERATE 48000")]
    public const int XAUDIO2FX_REVERB_MAX_FRAMERATE = 48000;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_WET_DRY_MIX"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_WET_DRY_MIX 0.0f")]
    public const float XAUDIO2FX_REVERB_MIN_WET_DRY_MIX = 0.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_REFLECTIONS_DELAY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_REFLECTIONS_DELAY 0")]
    public const int XAUDIO2FX_REVERB_MIN_REFLECTIONS_DELAY = 0;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_REVERB_DELAY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_REVERB_DELAY 0")]
    public const int XAUDIO2FX_REVERB_MIN_REVERB_DELAY = 0;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_REAR_DELAY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_REAR_DELAY 0")]
    public const int XAUDIO2FX_REVERB_MIN_REAR_DELAY = 0;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_7POINT1_SIDE_DELAY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_7POINT1_SIDE_DELAY 0")]
    public const int XAUDIO2FX_REVERB_MIN_7POINT1_SIDE_DELAY = 0;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_7POINT1_REAR_DELAY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_7POINT1_REAR_DELAY 0")]
    public const int XAUDIO2FX_REVERB_MIN_7POINT1_REAR_DELAY = 0;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_POSITION"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_POSITION 0")]
    public const int XAUDIO2FX_REVERB_MIN_POSITION = 0;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_DIFFUSION"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_DIFFUSION 0")]
    public const int XAUDIO2FX_REVERB_MIN_DIFFUSION = 0;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_LOW_EQ_GAIN"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_LOW_EQ_GAIN 0")]
    public const int XAUDIO2FX_REVERB_MIN_LOW_EQ_GAIN = 0;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_LOW_EQ_CUTOFF"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_LOW_EQ_CUTOFF 0")]
    public const int XAUDIO2FX_REVERB_MIN_LOW_EQ_CUTOFF = 0;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_HIGH_EQ_GAIN"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_HIGH_EQ_GAIN 0")]
    public const int XAUDIO2FX_REVERB_MIN_HIGH_EQ_GAIN = 0;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_HIGH_EQ_CUTOFF"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_HIGH_EQ_CUTOFF 0")]
    public const int XAUDIO2FX_REVERB_MIN_HIGH_EQ_CUTOFF = 0;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_ROOM_FILTER_FREQ"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_ROOM_FILTER_FREQ 20.0f")]
    public const float XAUDIO2FX_REVERB_MIN_ROOM_FILTER_FREQ = 20.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_ROOM_FILTER_MAIN"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_ROOM_FILTER_MAIN -100.0f")]
    public const float XAUDIO2FX_REVERB_MIN_ROOM_FILTER_MAIN = -100.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_ROOM_FILTER_HF"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_ROOM_FILTER_HF -100.0f")]
    public const float XAUDIO2FX_REVERB_MIN_ROOM_FILTER_HF = -100.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_REFLECTIONS_GAIN"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_REFLECTIONS_GAIN -100.0f")]
    public const float XAUDIO2FX_REVERB_MIN_REFLECTIONS_GAIN = -100.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_REVERB_GAIN"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_REVERB_GAIN -100.0f")]
    public const float XAUDIO2FX_REVERB_MIN_REVERB_GAIN = -100.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_DECAY_TIME"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_DECAY_TIME 0.1f")]
    public const float XAUDIO2FX_REVERB_MIN_DECAY_TIME = 0.1f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_DENSITY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_DENSITY 0.0f")]
    public const float XAUDIO2FX_REVERB_MIN_DENSITY = 0.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MIN_ROOM_SIZE"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_ROOM_SIZE 0.0f")]
    public const float XAUDIO2FX_REVERB_MIN_ROOM_SIZE = 0.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_WET_DRY_MIX"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_WET_DRY_MIX 100.0f")]
    public const float XAUDIO2FX_REVERB_MAX_WET_DRY_MIX = 100.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_REFLECTIONS_DELAY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_REFLECTIONS_DELAY 300")]
    public const int XAUDIO2FX_REVERB_MAX_REFLECTIONS_DELAY = 300;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_REVERB_DELAY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_REVERB_DELAY 85")]
    public const int XAUDIO2FX_REVERB_MAX_REVERB_DELAY = 85;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_REAR_DELAY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_REAR_DELAY 5")]
    public const int XAUDIO2FX_REVERB_MAX_REAR_DELAY = 5;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_7POINT1_SIDE_DELAY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_7POINT1_SIDE_DELAY 5")]
    public const int XAUDIO2FX_REVERB_MAX_7POINT1_SIDE_DELAY = 5;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_7POINT1_REAR_DELAY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_7POINT1_REAR_DELAY 20")]
    public const int XAUDIO2FX_REVERB_MAX_7POINT1_REAR_DELAY = 20;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_POSITION"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_POSITION 30")]
    public const int XAUDIO2FX_REVERB_MAX_POSITION = 30;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_DIFFUSION"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_DIFFUSION 15")]
    public const int XAUDIO2FX_REVERB_MAX_DIFFUSION = 15;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_LOW_EQ_GAIN"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_LOW_EQ_GAIN 12")]
    public const int XAUDIO2FX_REVERB_MAX_LOW_EQ_GAIN = 12;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_LOW_EQ_CUTOFF"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_LOW_EQ_CUTOFF 9")]
    public const int XAUDIO2FX_REVERB_MAX_LOW_EQ_CUTOFF = 9;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_HIGH_EQ_GAIN"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_HIGH_EQ_GAIN 8")]
    public const int XAUDIO2FX_REVERB_MAX_HIGH_EQ_GAIN = 8;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_HIGH_EQ_CUTOFF"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_HIGH_EQ_CUTOFF 14")]
    public const int XAUDIO2FX_REVERB_MAX_HIGH_EQ_CUTOFF = 14;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_ROOM_FILTER_FREQ"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_ROOM_FILTER_FREQ 20000.0f")]
    public const float XAUDIO2FX_REVERB_MAX_ROOM_FILTER_FREQ = 20000.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_ROOM_FILTER_MAIN"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_ROOM_FILTER_MAIN 0.0f")]
    public const float XAUDIO2FX_REVERB_MAX_ROOM_FILTER_MAIN = 0.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_ROOM_FILTER_HF"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_ROOM_FILTER_HF 0.0f")]
    public const float XAUDIO2FX_REVERB_MAX_ROOM_FILTER_HF = 0.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_REFLECTIONS_GAIN"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_REFLECTIONS_GAIN 20.0f")]
    public const float XAUDIO2FX_REVERB_MAX_REFLECTIONS_GAIN = 20.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_REVERB_GAIN"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_REVERB_GAIN 20.0f")]
    public const float XAUDIO2FX_REVERB_MAX_REVERB_GAIN = 20.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_DENSITY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_DENSITY 100.0f")]
    public const float XAUDIO2FX_REVERB_MAX_DENSITY = 100.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_MAX_ROOM_SIZE"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_ROOM_SIZE 100.0f")]
    public const float XAUDIO2FX_REVERB_MAX_ROOM_SIZE = 100.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_WET_DRY_MIX"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_WET_DRY_MIX 100.0f")]
    public const float XAUDIO2FX_REVERB_DEFAULT_WET_DRY_MIX = 100.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_REFLECTIONS_DELAY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_REFLECTIONS_DELAY 5")]
    public const int XAUDIO2FX_REVERB_DEFAULT_REFLECTIONS_DELAY = 5;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_REVERB_DELAY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_REVERB_DELAY 5")]
    public const int XAUDIO2FX_REVERB_DEFAULT_REVERB_DELAY = 5;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_REAR_DELAY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_REAR_DELAY 5")]
    public const int XAUDIO2FX_REVERB_DEFAULT_REAR_DELAY = 5;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_7POINT1_SIDE_DELAY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_7POINT1_SIDE_DELAY 5")]
    public const int XAUDIO2FX_REVERB_DEFAULT_7POINT1_SIDE_DELAY = 5;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_7POINT1_REAR_DELAY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_7POINT1_REAR_DELAY 20")]
    public const int XAUDIO2FX_REVERB_DEFAULT_7POINT1_REAR_DELAY = 20;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_POSITION"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_POSITION 6")]
    public const int XAUDIO2FX_REVERB_DEFAULT_POSITION = 6;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_POSITION_MATRIX"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_POSITION_MATRIX 27")]
    public const int XAUDIO2FX_REVERB_DEFAULT_POSITION_MATRIX = 27;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_EARLY_DIFFUSION"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_EARLY_DIFFUSION 8")]
    public const int XAUDIO2FX_REVERB_DEFAULT_EARLY_DIFFUSION = 8;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_LATE_DIFFUSION"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_LATE_DIFFUSION 8")]
    public const int XAUDIO2FX_REVERB_DEFAULT_LATE_DIFFUSION = 8;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_LOW_EQ_GAIN"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_LOW_EQ_GAIN 8")]
    public const int XAUDIO2FX_REVERB_DEFAULT_LOW_EQ_GAIN = 8;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_LOW_EQ_CUTOFF"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_LOW_EQ_CUTOFF 4")]
    public const int XAUDIO2FX_REVERB_DEFAULT_LOW_EQ_CUTOFF = 4;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_HIGH_EQ_GAIN"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_HIGH_EQ_GAIN 8")]
    public const int XAUDIO2FX_REVERB_DEFAULT_HIGH_EQ_GAIN = 8;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_HIGH_EQ_CUTOFF"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_HIGH_EQ_CUTOFF 4")]
    public const int XAUDIO2FX_REVERB_DEFAULT_HIGH_EQ_CUTOFF = 4;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_ROOM_FILTER_FREQ"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_ROOM_FILTER_FREQ 5000.0f")]
    public const float XAUDIO2FX_REVERB_DEFAULT_ROOM_FILTER_FREQ = 5000.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_ROOM_FILTER_MAIN"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_ROOM_FILTER_MAIN 0.0f")]
    public const float XAUDIO2FX_REVERB_DEFAULT_ROOM_FILTER_MAIN = 0.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_ROOM_FILTER_HF"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_ROOM_FILTER_HF 0.0f")]
    public const float XAUDIO2FX_REVERB_DEFAULT_ROOM_FILTER_HF = 0.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_REFLECTIONS_GAIN"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_REFLECTIONS_GAIN 0.0f")]
    public const float XAUDIO2FX_REVERB_DEFAULT_REFLECTIONS_GAIN = 0.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_REVERB_GAIN"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_REVERB_GAIN 0.0f")]
    public const float XAUDIO2FX_REVERB_DEFAULT_REVERB_GAIN = 0.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_DECAY_TIME"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_DECAY_TIME 1.0f")]
    public const float XAUDIO2FX_REVERB_DEFAULT_DECAY_TIME = 1.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_DENSITY"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_DENSITY 100.0f")]
    public const float XAUDIO2FX_REVERB_DEFAULT_DENSITY = 100.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_ROOM_SIZE"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_ROOM_SIZE 100.0f")]
    public const float XAUDIO2FX_REVERB_DEFAULT_ROOM_SIZE = 100.0f;

    /// <include file='XAUDIO2FX.xml' path='doc/member[@name="XAUDIO2FX.XAUDIO2FX_REVERB_DEFAULT_DISABLE_LATE_FIELD"]/*' />
    [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_DISABLE_LATE_FIELD FALSE")]
    public const int XAUDIO2FX_REVERB_DEFAULT_DISABLE_LATE_FIELD = 0;
}
