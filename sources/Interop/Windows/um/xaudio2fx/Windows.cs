// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("xaudio2_9", ExactSpelling = true)]
        public static extern HRESULT CreateAudioVolumeMeter(IUnknown** ppApo);

        [DllImport("xaudio2_9", ExactSpelling = true)]
        public static extern HRESULT CreateAudioReverb(IUnknown** ppApo);

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_FRAMERATE 20000")]
        public const int XAUDIO2FX_REVERB_MIN_FRAMERATE = 20000;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_FRAMERATE 48000")]
        public const int XAUDIO2FX_REVERB_MAX_FRAMERATE = 48000;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_WET_DRY_MIX 0.0f")]
        public const float XAUDIO2FX_REVERB_MIN_WET_DRY_MIX = 0.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_REFLECTIONS_DELAY 0")]
        public const int XAUDIO2FX_REVERB_MIN_REFLECTIONS_DELAY = 0;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_REVERB_DELAY 0")]
        public const int XAUDIO2FX_REVERB_MIN_REVERB_DELAY = 0;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_REAR_DELAY 0")]
        public const int XAUDIO2FX_REVERB_MIN_REAR_DELAY = 0;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_7POINT1_SIDE_DELAY 0")]
        public const int XAUDIO2FX_REVERB_MIN_7POINT1_SIDE_DELAY = 0;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_7POINT1_REAR_DELAY 0")]
        public const int XAUDIO2FX_REVERB_MIN_7POINT1_REAR_DELAY = 0;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_POSITION 0")]
        public const int XAUDIO2FX_REVERB_MIN_POSITION = 0;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_DIFFUSION 0")]
        public const int XAUDIO2FX_REVERB_MIN_DIFFUSION = 0;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_LOW_EQ_GAIN 0")]
        public const int XAUDIO2FX_REVERB_MIN_LOW_EQ_GAIN = 0;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_LOW_EQ_CUTOFF 0")]
        public const int XAUDIO2FX_REVERB_MIN_LOW_EQ_CUTOFF = 0;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_HIGH_EQ_GAIN 0")]
        public const int XAUDIO2FX_REVERB_MIN_HIGH_EQ_GAIN = 0;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_HIGH_EQ_CUTOFF 0")]
        public const int XAUDIO2FX_REVERB_MIN_HIGH_EQ_CUTOFF = 0;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_ROOM_FILTER_FREQ 20.0f")]
        public const float XAUDIO2FX_REVERB_MIN_ROOM_FILTER_FREQ = 20.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_ROOM_FILTER_MAIN -100.0f")]
        public const float XAUDIO2FX_REVERB_MIN_ROOM_FILTER_MAIN = -100.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_ROOM_FILTER_HF -100.0f")]
        public const float XAUDIO2FX_REVERB_MIN_ROOM_FILTER_HF = -100.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_REFLECTIONS_GAIN -100.0f")]
        public const float XAUDIO2FX_REVERB_MIN_REFLECTIONS_GAIN = -100.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_REVERB_GAIN -100.0f")]
        public const float XAUDIO2FX_REVERB_MIN_REVERB_GAIN = -100.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_DECAY_TIME 0.1f")]
        public const float XAUDIO2FX_REVERB_MIN_DECAY_TIME = 0.1f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_DENSITY 0.0f")]
        public const float XAUDIO2FX_REVERB_MIN_DENSITY = 0.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MIN_ROOM_SIZE 0.0f")]
        public const float XAUDIO2FX_REVERB_MIN_ROOM_SIZE = 0.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_WET_DRY_MIX 100.0f")]
        public const float XAUDIO2FX_REVERB_MAX_WET_DRY_MIX = 100.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_REFLECTIONS_DELAY 300")]
        public const int XAUDIO2FX_REVERB_MAX_REFLECTIONS_DELAY = 300;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_REVERB_DELAY 85")]
        public const int XAUDIO2FX_REVERB_MAX_REVERB_DELAY = 85;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_REAR_DELAY 5")]
        public const int XAUDIO2FX_REVERB_MAX_REAR_DELAY = 5;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_7POINT1_SIDE_DELAY 5")]
        public const int XAUDIO2FX_REVERB_MAX_7POINT1_SIDE_DELAY = 5;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_7POINT1_REAR_DELAY 20")]
        public const int XAUDIO2FX_REVERB_MAX_7POINT1_REAR_DELAY = 20;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_POSITION 30")]
        public const int XAUDIO2FX_REVERB_MAX_POSITION = 30;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_DIFFUSION 15")]
        public const int XAUDIO2FX_REVERB_MAX_DIFFUSION = 15;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_LOW_EQ_GAIN 12")]
        public const int XAUDIO2FX_REVERB_MAX_LOW_EQ_GAIN = 12;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_LOW_EQ_CUTOFF 9")]
        public const int XAUDIO2FX_REVERB_MAX_LOW_EQ_CUTOFF = 9;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_HIGH_EQ_GAIN 8")]
        public const int XAUDIO2FX_REVERB_MAX_HIGH_EQ_GAIN = 8;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_HIGH_EQ_CUTOFF 14")]
        public const int XAUDIO2FX_REVERB_MAX_HIGH_EQ_CUTOFF = 14;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_ROOM_FILTER_FREQ 20000.0f")]
        public const float XAUDIO2FX_REVERB_MAX_ROOM_FILTER_FREQ = 20000.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_ROOM_FILTER_MAIN 0.0f")]
        public const float XAUDIO2FX_REVERB_MAX_ROOM_FILTER_MAIN = 0.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_ROOM_FILTER_HF 0.0f")]
        public const float XAUDIO2FX_REVERB_MAX_ROOM_FILTER_HF = 0.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_REFLECTIONS_GAIN 20.0f")]
        public const float XAUDIO2FX_REVERB_MAX_REFLECTIONS_GAIN = 20.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_REVERB_GAIN 20.0f")]
        public const float XAUDIO2FX_REVERB_MAX_REVERB_GAIN = 20.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_DENSITY 100.0f")]
        public const float XAUDIO2FX_REVERB_MAX_DENSITY = 100.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_MAX_ROOM_SIZE 100.0f")]
        public const float XAUDIO2FX_REVERB_MAX_ROOM_SIZE = 100.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_WET_DRY_MIX 100.0f")]
        public const float XAUDIO2FX_REVERB_DEFAULT_WET_DRY_MIX = 100.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_REFLECTIONS_DELAY 5")]
        public const int XAUDIO2FX_REVERB_DEFAULT_REFLECTIONS_DELAY = 5;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_REVERB_DELAY 5")]
        public const int XAUDIO2FX_REVERB_DEFAULT_REVERB_DELAY = 5;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_REAR_DELAY 5")]
        public const int XAUDIO2FX_REVERB_DEFAULT_REAR_DELAY = 5;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_7POINT1_SIDE_DELAY 5")]
        public const int XAUDIO2FX_REVERB_DEFAULT_7POINT1_SIDE_DELAY = 5;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_7POINT1_REAR_DELAY 20")]
        public const int XAUDIO2FX_REVERB_DEFAULT_7POINT1_REAR_DELAY = 20;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_POSITION 6")]
        public const int XAUDIO2FX_REVERB_DEFAULT_POSITION = 6;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_POSITION_MATRIX 27")]
        public const int XAUDIO2FX_REVERB_DEFAULT_POSITION_MATRIX = 27;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_EARLY_DIFFUSION 8")]
        public const int XAUDIO2FX_REVERB_DEFAULT_EARLY_DIFFUSION = 8;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_LATE_DIFFUSION 8")]
        public const int XAUDIO2FX_REVERB_DEFAULT_LATE_DIFFUSION = 8;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_LOW_EQ_GAIN 8")]
        public const int XAUDIO2FX_REVERB_DEFAULT_LOW_EQ_GAIN = 8;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_LOW_EQ_CUTOFF 4")]
        public const int XAUDIO2FX_REVERB_DEFAULT_LOW_EQ_CUTOFF = 4;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_HIGH_EQ_GAIN 8")]
        public const int XAUDIO2FX_REVERB_DEFAULT_HIGH_EQ_GAIN = 8;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_HIGH_EQ_CUTOFF 4")]
        public const int XAUDIO2FX_REVERB_DEFAULT_HIGH_EQ_CUTOFF = 4;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_ROOM_FILTER_FREQ 5000.0f")]
        public const float XAUDIO2FX_REVERB_DEFAULT_ROOM_FILTER_FREQ = 5000.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_ROOM_FILTER_MAIN 0.0f")]
        public const float XAUDIO2FX_REVERB_DEFAULT_ROOM_FILTER_MAIN = 0.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_ROOM_FILTER_HF 0.0f")]
        public const float XAUDIO2FX_REVERB_DEFAULT_ROOM_FILTER_HF = 0.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_REFLECTIONS_GAIN 0.0f")]
        public const float XAUDIO2FX_REVERB_DEFAULT_REFLECTIONS_GAIN = 0.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_REVERB_GAIN 0.0f")]
        public const float XAUDIO2FX_REVERB_DEFAULT_REVERB_GAIN = 0.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_DECAY_TIME 1.0f")]
        public const float XAUDIO2FX_REVERB_DEFAULT_DECAY_TIME = 1.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_DENSITY 100.0f")]
        public const float XAUDIO2FX_REVERB_DEFAULT_DENSITY = 100.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_ROOM_SIZE 100.0f")]
        public const float XAUDIO2FX_REVERB_DEFAULT_ROOM_SIZE = 100.0f;

        [NativeTypeName("#define XAUDIO2FX_REVERB_DEFAULT_DISABLE_LATE_FIELD FALSE")]
        public const int XAUDIO2FX_REVERB_DEFAULT_DISABLE_LATE_FIELD = 0;

        public static ref readonly Guid CLSID_AudioVolumeMeter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x66, 0xB1, 0xC3, 0x4F,
                    0x2A, 0x97,
                    0xCF, 0x40,
                    0xBC,
                    0x37,
                    0x7D,
                    0xB0,
                    0x3D,
                    0xB2,
                    0xFB,
                    0xA3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_AudioReverb
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0x3B, 0x63, 0xC2,
                    0x1B, 0x47,
                    0x98, 0x44,
                    0xB8,
                    0xC5,
                    0x4F,
                    0x09,
                    0x59,
                    0xE2,
                    0xEC,
                    0x09
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
