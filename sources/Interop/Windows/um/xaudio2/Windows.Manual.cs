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
        public const string XAUDIO2_DLL_W = "xaudio2_9.dll";

        public const string XAUDIO2D_DLL_W = "xaudio2_9d.dll";

        public static readonly Guid IID_IXAudio2 = new Guid(0x2B02E3CF, 0x2E0B, 0x4EC3, 0xBE, 0x45, 0x1B, 0x2A, 0x3F, 0xE7, 0x21, 0x0D);

        public static readonly Guid IID_IXAudio2Extension = new Guid(0x84AC29BB, 0xD619, 0x44D2, 0xB1, 0x97, 0xE4, 0xAC, 0xF7, 0xDF, 0x3E, 0xD6);

        public const int XAUDIO2_MAX_BUFFER_BYTES = unchecked((int)0x80000000);

        public const int XAUDIO2_MAX_QUEUED_BUFFERS = 64;

        public const int XAUDIO2_MAX_BUFFERS_SYSTEM = 2;

        public const int XAUDIO2_MAX_AUDIO_CHANNELS = 64;

        public const int XAUDIO2_MIN_SAMPLE_RATE = 1000;

        public const int XAUDIO2_MAX_SAMPLE_RATE = 200000;

        public const float XAUDIO2_MAX_VOLUME_LEVEL = 16777216.0f;

        public const float XAUDIO2_MIN_FREQ_RATIO = (1 / 1024.0f);

        public const float XAUDIO2_MAX_FREQ_RATIO = 1024.0f;

        public const float XAUDIO2_DEFAULT_FREQ_RATIO = 2.0f;

        public const float XAUDIO2_MAX_FILTER_ONEOVERQ = 1.5f;

        public const float XAUDIO2_MAX_FILTER_FREQUENCY = 1.0f;

        public const int XAUDIO2_MAX_LOOP_COUNT = 254;

        public const int XAUDIO2_MAX_INSTANCES = 8;

        public const int XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MONO = 600000;

        public const int XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MULTICHANNEL = 300000;

        public const int XAUDIO2_COMMIT_NOW = 0;

        public const int XAUDIO2_COMMIT_ALL = 0;

        public const uint XAUDIO2_INVALID_OPSET = unchecked((uint)(-1));

        public const int XAUDIO2_NO_LOOP_REGION = 0;

        public const int XAUDIO2_LOOP_INFINITE = 255;

        public const int XAUDIO2_DEFAULT_CHANNELS = 0;

        public const int XAUDIO2_DEFAULT_SAMPLERATE = 0;

        public const int XAUDIO2_DEBUG_ENGINE = 0x0001;

        public const int XAUDIO2_VOICE_NOPITCH = 0x0002;

        public const int XAUDIO2_VOICE_NOSRC = 0x0004;

        public const int XAUDIO2_VOICE_USEFILTER = 0x0008;

        public const int XAUDIO2_PLAY_TAILS = 0x0020;

        public const int XAUDIO2_END_OF_STREAM = 0x0040;

        public const int XAUDIO2_SEND_USEFILTER = 0x0080;

        public const int XAUDIO2_VOICE_NOSAMPLESPLAYED = 0x0100;

        public const int XAUDIO2_STOP_ENGINE_WHEN_IDLE = 0x2000;

        public const int XAUDIO2_1024_QUANTUM = 0x8000;

        public const int XAUDIO2_NO_VIRTUAL_AUDIO_CLIENT = 0x10000;

        public const XAUDIO2_FILTER_TYPE XAUDIO2_DEFAULT_FILTER_TYPE = LowPassFilter;

        public const float XAUDIO2_DEFAULT_FILTER_FREQUENCY = XAUDIO2_MAX_FILTER_FREQUENCY;

        public const float XAUDIO2_DEFAULT_FILTER_ONEOVERQ = 1.0f;

        public const int XAUDIO2_QUANTUM_NUMERATOR = 1;

        public const int XAUDIO2_QUANTUM_DENOMINATOR = 100;

        public const float XAUDIO2_QUANTUM_MS = (1000.0f * XAUDIO2_QUANTUM_NUMERATOR / XAUDIO2_QUANTUM_DENOMINATOR);

        public const int FACILITY_XAUDIO2 = 0x896;

        public const int XAUDIO2_E_INVALID_CALL = unchecked((int)0x88960001);

        public const int XAUDIO2_E_XMA_DECODER_ERROR = unchecked((int)0x88960002);

        public const int XAUDIO2_E_XAPO_CREATION_FAILED = unchecked((int)0x88960003);

        public const int XAUDIO2_E_DEVICE_INVALIDATED = unchecked((int)0x88960004);

        public const uint Processor1 = 0x00000001;

        public const uint Processor2 = 0x00000002;

        public const uint Processor3 = 0x00000004;

        public const uint Processor4 = 0x00000008;

        public const uint Processor5 = 0x00000010;

        public const uint Processor6 = 0x00000020;

        public const uint Processor7 = 0x00000040;

        public const uint Processor8 = 0x00000080;

        public const uint Processor9 = 0x00000100;

        public const uint Processor10 = 0x00000200;

        public const uint Processor11 = 0x00000400;

        public const uint Processor12 = 0x00000800;

        public const uint Processor13 = 0x00001000;

        public const uint Processor14 = 0x00002000;

        public const uint Processor15 = 0x00004000;

        public const uint Processor16 = 0x00008000;

        public const uint Processor17 = 0x00010000;

        public const uint Processor18 = 0x00020000;

        public const uint Processor19 = 0x00040000;

        public const uint Processor20 = 0x00080000;

        public const uint Processor21 = 0x00100000;

        public const uint Processor22 = 0x00200000;

        public const uint Processor23 = 0x00400000;

        public const uint Processor24 = 0x00800000;

        public const uint Processor25 = 0x01000000;

        public const uint Processor26 = 0x02000000;

        public const uint Processor27 = 0x04000000;

        public const uint Processor28 = 0x08000000;

        public const uint Processor29 = 0x10000000;

        public const uint Processor30 = 0x20000000;

        public const uint Processor31 = 0x40000000;

        public const uint Processor32 = 0x80000000;

        public const uint XAUDIO2_ANY_PROCESSOR = 0xffffffff;

        public const uint XAUDIO2_USE_DEFAULT_PROCESSOR = 0x00000000;

        public const uint XAUDIO2_DEFAULT_PROCESSOR = Processor1;

        public const int XAUDIO2_LOG_ERRORS = 0x0001;

        public const int XAUDIO2_LOG_WARNINGS = 0x0002;

        public const int XAUDIO2_LOG_INFO = 0x0004;

        public const int XAUDIO2_LOG_DETAIL = 0x0008;

        public const int XAUDIO2_LOG_API_CALLS = 0x0010;

        public const int XAUDIO2_LOG_FUNC_CALLS = 0x0020;

        public const int XAUDIO2_LOG_TIMING = 0x0040;

        public const int XAUDIO2_LOG_LOCKS = 0x0080;

        public const int XAUDIO2_LOG_MEMORY = 0x0100;

        public const int XAUDIO2_LOG_STREAMING = 0x1000;

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

        [DllImport("XAudio2_9", EntryPoint = "XAudio2Create", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int XAudio2Create([NativeTypeName("IXAudio2 **")] IXAudio2** ppXAudio2, [NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("XAUDIO2_PROCESSOR")] uint XAudio2Processor = XAUDIO2_DEFAULT_PROCESSOR);
    }
}
