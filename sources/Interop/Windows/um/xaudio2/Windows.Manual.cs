// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.XAUDIO2_FILTER_TYPE;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static float XAudio2DecibelsToAmplitudeRatio(float Decibels)
        {
            return MathF.Pow(10.0f, Decibels / 20.0f);
        }

        public static float XAudio2AmplitudeRatioToDecibels(float Volume)
        {
            if (Volume == 0)
            {
                return -3.402823466e+38f;
            }

            return 20.0f * MathF.Log10(Volume);
        }

        public static float XAudio2SemitonesToFrequencyRatio(float Semitones)
        {
            return MathF.Pow(2.0f, Semitones / 12.0f);
        }

        public static float XAudio2FrequencyRatioToSemitones(float FrequencyRatio)
        {
            return 39.86313713864835f * MathF.Log10(FrequencyRatio);
        }

        public static float XAudio2CutoffFrequencyToRadians(float CutoffFrequency, [NativeTypeName("UINT32")] uint SampleRate)
        {
            if ((uint)(CutoffFrequency * 6.0f) >= SampleRate)
            {
                return 1.0f;
            }

            return 2.0f * MathF.Sin((float)3.14159265358979323846 * CutoffFrequency / SampleRate);
        }

        public static float XAudio2RadiansToCutoffFrequency(float Radians, float SampleRate)
        {
            return SampleRate * MathF.Asin(Radians / 2.0f) / (float)3.14159265358979323846;
        }

        public static float XAudio2CutoffFrequencyToOnePoleCoefficient(float CutoffFrequency, [NativeTypeName("UINT32")] uint SampleRate)
        {
            if ((uint)CutoffFrequency >= SampleRate)
            {
                return 1.0f;
            }

            return (1.0f - MathF.Pow(1.0f - 2.0f * CutoffFrequency / SampleRate, 2.0f));
        }

        [DllImport("XAudio2_9", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int XAudio2Create([NativeTypeName("IXAudio2 **")] IXAudio2** ppXAudio2, [NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("XAUDIO2_PROCESSOR")] uint XAudio2Processor = XAUDIO2_DEFAULT_PROCESSOR);
    }
}
