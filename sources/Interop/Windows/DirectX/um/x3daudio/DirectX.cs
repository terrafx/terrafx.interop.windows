// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    public static unsafe partial class DirectX
    {
        [NativeTypeName("const X3DAUDIO_DISTANCE_CURVE_POINT [2]")]
        public static ReadOnlySpan<X3DAUDIO_DISTANCE_CURVE_POINT> X3DAudioDefault_LinearCurvePoints
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x80, 0x3F,
                    0x00, 0x00, 0x80, 0x3F,
                    0x00, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == (Unsafe.SizeOf<X3DAUDIO_DISTANCE_CURVE_POINT>() * 2));
                return MemoryMarshal.CreateReadOnlySpan<X3DAUDIO_DISTANCE_CURVE_POINT>(ref Unsafe.As<byte, X3DAUDIO_DISTANCE_CURVE_POINT>(ref MemoryMarshal.GetReference(data)), 2);
            }
        }

        [NativeTypeName("const X3DAUDIO_CONE")]
        public static ref readonly X3DAUDIO_CONE X3DAudioDefault_DirectionalCone
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDB, 0x0F, 0xC9, 0x3F,
                    0xDB, 0x0F, 0x49, 0x40,
                    0x00, 0x00, 0x80, 0x3F,
                    0x7D, 0x3F, 0x35, 0x3F,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x80, 0x3E,
                    0x7D, 0x3F, 0x35, 0x3F,
                    0x00, 0x00, 0x80, 0x3F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<X3DAUDIO_CONE>());
                return ref Unsafe.As<byte, X3DAUDIO_CONE>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("X3DAudio1_7", ExactSpelling = true)]
        public static extern HRESULT X3DAudioInitialize([NativeTypeName("UINT32")] uint SpeakerChannelMask, [NativeTypeName("FLOAT32")] float SpeedOfSound, [NativeTypeName("X3DAUDIO_HANDLE")] byte* Instance);

        [DllImport("X3DAudio1_7", ExactSpelling = true)]
        public static extern void X3DAudioCalculate([NativeTypeName("const X3DAUDIO_HANDLE")] byte* Instance, [NativeTypeName("const X3DAUDIO_LISTENER *")] X3DAUDIO_LISTENER* pListener, [NativeTypeName("const X3DAUDIO_EMITTER *")] X3DAUDIO_EMITTER* pEmitter, [NativeTypeName("UINT32")] uint Flags, X3DAUDIO_DSP_SETTINGS* pDSPSettings);

        [NativeTypeName("#define SPEAKER_MONO SPEAKER_FRONT_CENTER")]
        public const int SPEAKER_MONO = 0x00000004;

        [NativeTypeName("#define SPEAKER_STEREO (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT)")]
        public const int SPEAKER_STEREO = (0x00000001 | 0x00000002);

        [NativeTypeName("#define SPEAKER_2POINT1 (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_LOW_FREQUENCY)")]
        public const int SPEAKER_2POINT1 = (0x00000001 | 0x00000002 | 0x00000008);

        [NativeTypeName("#define SPEAKER_SURROUND (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_BACK_CENTER)")]
        public const int SPEAKER_SURROUND = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000100);

        [NativeTypeName("#define SPEAKER_QUAD (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT)")]
        public const int SPEAKER_QUAD = (0x00000001 | 0x00000002 | 0x00000010 | 0x00000020);

        [NativeTypeName("#define SPEAKER_4POINT1 (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT)")]
        public const int SPEAKER_4POINT1 = (0x00000001 | 0x00000002 | 0x00000008 | 0x00000010 | 0x00000020);

        [NativeTypeName("#define SPEAKER_5POINT1 (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT)")]
        public const int SPEAKER_5POINT1 = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020);

        [NativeTypeName("#define SPEAKER_7POINT1 (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT | SPEAKER_FRONT_LEFT_OF_CENTER | SPEAKER_FRONT_RIGHT_OF_CENTER)")]
        public const int SPEAKER_7POINT1 = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020 | 0x00000040 | 0x00000080);

        [NativeTypeName("#define SPEAKER_5POINT1_SURROUND (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_SIDE_LEFT  | SPEAKER_SIDE_RIGHT)")]
        public const int SPEAKER_5POINT1_SURROUND = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000200 | 0x00000400);

        [NativeTypeName("#define SPEAKER_7POINT1_SURROUND (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT | SPEAKER_SIDE_LEFT  | SPEAKER_SIDE_RIGHT)")]
        public const int SPEAKER_7POINT1_SURROUND = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020 | 0x00000200 | 0x00000400);

        [NativeTypeName("#define X3DAUDIO_HANDLE_BYTESIZE 20")]
        public const int X3DAUDIO_HANDLE_BYTESIZE = 20;

        [NativeTypeName("#define X3DAUDIO_PI 3.141592654f")]
        public const float X3DAUDIO_PI = 3.141592654f;

        [NativeTypeName("#define X3DAUDIO_2PI 6.283185307f")]
        public const float X3DAUDIO_2PI = 6.283185307f;

        [NativeTypeName("#define X3DAUDIO_SPEED_OF_SOUND 343.5f")]
        public const float X3DAUDIO_SPEED_OF_SOUND = 343.5f;

        [NativeTypeName("#define X3DAUDIO_CALCULATE_MATRIX 0x00000001")]
        public const int X3DAUDIO_CALCULATE_MATRIX = 0x00000001;

        [NativeTypeName("#define X3DAUDIO_CALCULATE_DELAY 0x00000002")]
        public const int X3DAUDIO_CALCULATE_DELAY = 0x00000002;

        [NativeTypeName("#define X3DAUDIO_CALCULATE_LPF_DIRECT 0x00000004")]
        public const int X3DAUDIO_CALCULATE_LPF_DIRECT = 0x00000004;

        [NativeTypeName("#define X3DAUDIO_CALCULATE_LPF_REVERB 0x00000008")]
        public const int X3DAUDIO_CALCULATE_LPF_REVERB = 0x00000008;

        [NativeTypeName("#define X3DAUDIO_CALCULATE_REVERB 0x00000010")]
        public const int X3DAUDIO_CALCULATE_REVERB = 0x00000010;

        [NativeTypeName("#define X3DAUDIO_CALCULATE_DOPPLER 0x00000020")]
        public const int X3DAUDIO_CALCULATE_DOPPLER = 0x00000020;

        [NativeTypeName("#define X3DAUDIO_CALCULATE_EMITTER_ANGLE 0x00000040")]
        public const int X3DAUDIO_CALCULATE_EMITTER_ANGLE = 0x00000040;

        [NativeTypeName("#define X3DAUDIO_CALCULATE_ZEROCENTER 0x00010000")]
        public const int X3DAUDIO_CALCULATE_ZEROCENTER = 0x00010000;

        [NativeTypeName("#define X3DAUDIO_CALCULATE_REDIRECT_TO_LFE 0x00020000")]
        public const int X3DAUDIO_CALCULATE_REDIRECT_TO_LFE = 0x00020000;
    }
}
