// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.XAUDIO2_FILTER_TYPE;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("xaudio2_9", ExactSpelling = true)]
        public static extern HRESULT XAudio2CreateWithVersionInfo(IXAudio2** ppXAudio2, [NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("XAUDIO2_PROCESSOR")] uint XAudio2Processor = 0x00000001, [NativeTypeName("DWORD")] uint ntddiVersion = 0x0A00000A);

        [NativeTypeName("#define XAUDIO2_DLL_A \"xaudio2_9.dll\"")]
        public static ReadOnlySpan<byte> XAUDIO2_DLL_A => new byte[] { 0x78, 0x61, 0x75, 0x64, 0x69, 0x6F, 0x32, 0x5F, 0x39, 0x2E, 0x64, 0x6C, 0x6C, 0x00 };

        [NativeTypeName("#define XAUDIO2_DLL_W L\"xaudio2_9.dll\"")]
        public const string XAUDIO2_DLL_W = "xaudio2_9.dll";

        [NativeTypeName("#define XAUDIO2D_DLL_A \"xaudio2_9d.dll\"")]
        public static ReadOnlySpan<byte> XAUDIO2D_DLL_A => new byte[] { 0x78, 0x61, 0x75, 0x64, 0x69, 0x6F, 0x32, 0x5F, 0x39, 0x64, 0x2E, 0x64, 0x6C, 0x6C, 0x00 };

        [NativeTypeName("#define XAUDIO2D_DLL_W L\"xaudio2_9d.dll\"")]
        public const string XAUDIO2D_DLL_W = "xaudio2_9d.dll";

        [NativeTypeName("#define XAUDIO2_DLL XAUDIO2_DLL_W")]
        public const string XAUDIO2_DLL = "xaudio2_9.dll";

        [NativeTypeName("#define XAUDIO2D_DLL XAUDIO2D_DLL_W")]
        public const string XAUDIO2D_DLL = "xaudio2_9d.dll";

        [NativeTypeName("#define XAUDIO2_MAX_BUFFER_BYTES 0x80000000")]
        public const uint XAUDIO2_MAX_BUFFER_BYTES = 0x80000000;

        [NativeTypeName("#define XAUDIO2_MAX_QUEUED_BUFFERS 64")]
        public const int XAUDIO2_MAX_QUEUED_BUFFERS = 64;

        [NativeTypeName("#define XAUDIO2_MAX_BUFFERS_SYSTEM 2")]
        public const int XAUDIO2_MAX_BUFFERS_SYSTEM = 2;

        [NativeTypeName("#define XAUDIO2_MAX_AUDIO_CHANNELS 64")]
        public const int XAUDIO2_MAX_AUDIO_CHANNELS = 64;

        [NativeTypeName("#define XAUDIO2_MIN_SAMPLE_RATE 1000")]
        public const int XAUDIO2_MIN_SAMPLE_RATE = 1000;

        [NativeTypeName("#define XAUDIO2_MAX_SAMPLE_RATE 200000")]
        public const int XAUDIO2_MAX_SAMPLE_RATE = 200000;

        [NativeTypeName("#define XAUDIO2_MAX_VOLUME_LEVEL 16777216.0f")]
        public const float XAUDIO2_MAX_VOLUME_LEVEL = 16777216.0f;

        [NativeTypeName("#define XAUDIO2_MIN_FREQ_RATIO (1/1024.0f)")]
        public const float XAUDIO2_MIN_FREQ_RATIO = (1 / 1024.0f);

        [NativeTypeName("#define XAUDIO2_MAX_FREQ_RATIO 1024.0f")]
        public const float XAUDIO2_MAX_FREQ_RATIO = 1024.0f;

        [NativeTypeName("#define XAUDIO2_DEFAULT_FREQ_RATIO 2.0f")]
        public const float XAUDIO2_DEFAULT_FREQ_RATIO = 2.0f;

        [NativeTypeName("#define XAUDIO2_MAX_FILTER_ONEOVERQ 1.5f")]
        public const float XAUDIO2_MAX_FILTER_ONEOVERQ = 1.5f;

        [NativeTypeName("#define XAUDIO2_MAX_FILTER_FREQUENCY 1.0f")]
        public const float XAUDIO2_MAX_FILTER_FREQUENCY = 1.0f;

        [NativeTypeName("#define XAUDIO2_MAX_LOOP_COUNT 254")]
        public const int XAUDIO2_MAX_LOOP_COUNT = 254;

        [NativeTypeName("#define XAUDIO2_MAX_INSTANCES 8")]
        public const int XAUDIO2_MAX_INSTANCES = 8;

        [NativeTypeName("#define XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MONO 600000")]
        public const int XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MONO = 600000;

        [NativeTypeName("#define XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MULTICHANNEL 300000")]
        public const int XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MULTICHANNEL = 300000;

        [NativeTypeName("#define XAUDIO2_COMMIT_NOW 0")]
        public const int XAUDIO2_COMMIT_NOW = 0;

        [NativeTypeName("#define XAUDIO2_COMMIT_ALL 0")]
        public const int XAUDIO2_COMMIT_ALL = 0;

        [NativeTypeName("#define XAUDIO2_INVALID_OPSET (UINT32)(-1)")]
        public const uint XAUDIO2_INVALID_OPSET = unchecked((uint)(-1));

        [NativeTypeName("#define XAUDIO2_NO_LOOP_REGION 0")]
        public const int XAUDIO2_NO_LOOP_REGION = 0;

        [NativeTypeName("#define XAUDIO2_LOOP_INFINITE 255")]
        public const int XAUDIO2_LOOP_INFINITE = 255;

        [NativeTypeName("#define XAUDIO2_DEFAULT_CHANNELS 0")]
        public const int XAUDIO2_DEFAULT_CHANNELS = 0;

        [NativeTypeName("#define XAUDIO2_DEFAULT_SAMPLERATE 0")]
        public const int XAUDIO2_DEFAULT_SAMPLERATE = 0;

        [NativeTypeName("#define XAUDIO2_DEBUG_ENGINE 0x0001")]
        public const int XAUDIO2_DEBUG_ENGINE = 0x0001;

        [NativeTypeName("#define XAUDIO2_VOICE_NOPITCH 0x0002")]
        public const int XAUDIO2_VOICE_NOPITCH = 0x0002;

        [NativeTypeName("#define XAUDIO2_VOICE_NOSRC 0x0004")]
        public const int XAUDIO2_VOICE_NOSRC = 0x0004;

        [NativeTypeName("#define XAUDIO2_VOICE_USEFILTER 0x0008")]
        public const int XAUDIO2_VOICE_USEFILTER = 0x0008;

        [NativeTypeName("#define XAUDIO2_PLAY_TAILS 0x0020")]
        public const int XAUDIO2_PLAY_TAILS = 0x0020;

        [NativeTypeName("#define XAUDIO2_END_OF_STREAM 0x0040")]
        public const int XAUDIO2_END_OF_STREAM = 0x0040;

        [NativeTypeName("#define XAUDIO2_SEND_USEFILTER 0x0080")]
        public const int XAUDIO2_SEND_USEFILTER = 0x0080;

        [NativeTypeName("#define XAUDIO2_VOICE_NOSAMPLESPLAYED 0x0100")]
        public const int XAUDIO2_VOICE_NOSAMPLESPLAYED = 0x0100;

        [NativeTypeName("#define XAUDIO2_STOP_ENGINE_WHEN_IDLE 0x2000")]
        public const int XAUDIO2_STOP_ENGINE_WHEN_IDLE = 0x2000;

        [NativeTypeName("#define XAUDIO2_1024_QUANTUM 0x8000")]
        public const int XAUDIO2_1024_QUANTUM = 0x8000;

        [NativeTypeName("#define XAUDIO2_NO_VIRTUAL_AUDIO_CLIENT 0x10000")]
        public const int XAUDIO2_NO_VIRTUAL_AUDIO_CLIENT = 0x10000;

        [NativeTypeName("#define XAUDIO2_DEFAULT_FILTER_TYPE LowPassFilter")]
        public const XAUDIO2_FILTER_TYPE XAUDIO2_DEFAULT_FILTER_TYPE = LowPassFilter;

        [NativeTypeName("#define XAUDIO2_DEFAULT_FILTER_FREQUENCY XAUDIO2_MAX_FILTER_FREQUENCY")]
        public const float XAUDIO2_DEFAULT_FILTER_FREQUENCY = 1.0f;

        [NativeTypeName("#define XAUDIO2_DEFAULT_FILTER_ONEOVERQ 1.0f")]
        public const float XAUDIO2_DEFAULT_FILTER_ONEOVERQ = 1.0f;

        [NativeTypeName("#define XAUDIO2_QUANTUM_NUMERATOR 1")]
        public const int XAUDIO2_QUANTUM_NUMERATOR = 1;

        [NativeTypeName("#define XAUDIO2_QUANTUM_DENOMINATOR 100")]
        public const int XAUDIO2_QUANTUM_DENOMINATOR = 100;

        [NativeTypeName("#define XAUDIO2_QUANTUM_MS (1000.0f * XAUDIO2_QUANTUM_NUMERATOR / XAUDIO2_QUANTUM_DENOMINATOR)")]
        public const float XAUDIO2_QUANTUM_MS = (1000.0f * 1 / 100);

        [NativeTypeName("#define FACILITY_XAUDIO2 0x896")]
        public const int FACILITY_XAUDIO2 = 0x896;

        [NativeTypeName("#define XAUDIO2_E_INVALID_CALL ((HRESULT)0x88960001)")]
        public const int XAUDIO2_E_INVALID_CALL = unchecked((int)(0x88960001));

        [NativeTypeName("#define XAUDIO2_E_XMA_DECODER_ERROR ((HRESULT)0x88960002)")]
        public const int XAUDIO2_E_XMA_DECODER_ERROR = unchecked((int)(0x88960002));

        [NativeTypeName("#define XAUDIO2_E_XAPO_CREATION_FAILED ((HRESULT)0x88960003)")]
        public const int XAUDIO2_E_XAPO_CREATION_FAILED = unchecked((int)(0x88960003));

        [NativeTypeName("#define XAUDIO2_E_DEVICE_INVALIDATED ((HRESULT)0x88960004)")]
        public const int XAUDIO2_E_DEVICE_INVALIDATED = unchecked((int)(0x88960004));

        [NativeTypeName("#define Processor1 0x00000001")]
        public const int Processor1 = 0x00000001;

        [NativeTypeName("#define Processor2 0x00000002")]
        public const int Processor2 = 0x00000002;

        [NativeTypeName("#define Processor3 0x00000004")]
        public const int Processor3 = 0x00000004;

        [NativeTypeName("#define Processor4 0x00000008")]
        public const int Processor4 = 0x00000008;

        [NativeTypeName("#define Processor5 0x00000010")]
        public const int Processor5 = 0x00000010;

        [NativeTypeName("#define Processor6 0x00000020")]
        public const int Processor6 = 0x00000020;

        [NativeTypeName("#define Processor7 0x00000040")]
        public const int Processor7 = 0x00000040;

        [NativeTypeName("#define Processor8 0x00000080")]
        public const int Processor8 = 0x00000080;

        [NativeTypeName("#define Processor9 0x00000100")]
        public const int Processor9 = 0x00000100;

        [NativeTypeName("#define Processor10 0x00000200")]
        public const int Processor10 = 0x00000200;

        [NativeTypeName("#define Processor11 0x00000400")]
        public const int Processor11 = 0x00000400;

        [NativeTypeName("#define Processor12 0x00000800")]
        public const int Processor12 = 0x00000800;

        [NativeTypeName("#define Processor13 0x00001000")]
        public const int Processor13 = 0x00001000;

        [NativeTypeName("#define Processor14 0x00002000")]
        public const int Processor14 = 0x00002000;

        [NativeTypeName("#define Processor15 0x00004000")]
        public const int Processor15 = 0x00004000;

        [NativeTypeName("#define Processor16 0x00008000")]
        public const int Processor16 = 0x00008000;

        [NativeTypeName("#define Processor17 0x00010000")]
        public const int Processor17 = 0x00010000;

        [NativeTypeName("#define Processor18 0x00020000")]
        public const int Processor18 = 0x00020000;

        [NativeTypeName("#define Processor19 0x00040000")]
        public const int Processor19 = 0x00040000;

        [NativeTypeName("#define Processor20 0x00080000")]
        public const int Processor20 = 0x00080000;

        [NativeTypeName("#define Processor21 0x00100000")]
        public const int Processor21 = 0x00100000;

        [NativeTypeName("#define Processor22 0x00200000")]
        public const int Processor22 = 0x00200000;

        [NativeTypeName("#define Processor23 0x00400000")]
        public const int Processor23 = 0x00400000;

        [NativeTypeName("#define Processor24 0x00800000")]
        public const int Processor24 = 0x00800000;

        [NativeTypeName("#define Processor25 0x01000000")]
        public const int Processor25 = 0x01000000;

        [NativeTypeName("#define Processor26 0x02000000")]
        public const int Processor26 = 0x02000000;

        [NativeTypeName("#define Processor27 0x04000000")]
        public const int Processor27 = 0x04000000;

        [NativeTypeName("#define Processor28 0x08000000")]
        public const int Processor28 = 0x08000000;

        [NativeTypeName("#define Processor29 0x10000000")]
        public const int Processor29 = 0x10000000;

        [NativeTypeName("#define Processor30 0x20000000")]
        public const int Processor30 = 0x20000000;

        [NativeTypeName("#define Processor31 0x40000000")]
        public const int Processor31 = 0x40000000;

        [NativeTypeName("#define Processor32 0x80000000")]
        public const uint Processor32 = 0x80000000;

        [NativeTypeName("#define XAUDIO2_ANY_PROCESSOR 0xffffffff")]
        public const uint XAUDIO2_ANY_PROCESSOR = 0xffffffff;

        [NativeTypeName("#define XAUDIO2_USE_DEFAULT_PROCESSOR 0x00000000")]
        public const int XAUDIO2_USE_DEFAULT_PROCESSOR = 0x00000000;

        [NativeTypeName("#define XAUDIO2_DEFAULT_PROCESSOR Processor1")]
        public const int XAUDIO2_DEFAULT_PROCESSOR = 0x00000001;

        [NativeTypeName("#define XAUDIO2_LOG_ERRORS 0x0001")]
        public const int XAUDIO2_LOG_ERRORS = 0x0001;

        [NativeTypeName("#define XAUDIO2_LOG_WARNINGS 0x0002")]
        public const int XAUDIO2_LOG_WARNINGS = 0x0002;

        [NativeTypeName("#define XAUDIO2_LOG_INFO 0x0004")]
        public const int XAUDIO2_LOG_INFO = 0x0004;

        [NativeTypeName("#define XAUDIO2_LOG_DETAIL 0x0008")]
        public const int XAUDIO2_LOG_DETAIL = 0x0008;

        [NativeTypeName("#define XAUDIO2_LOG_API_CALLS 0x0010")]
        public const int XAUDIO2_LOG_API_CALLS = 0x0010;

        [NativeTypeName("#define XAUDIO2_LOG_FUNC_CALLS 0x0020")]
        public const int XAUDIO2_LOG_FUNC_CALLS = 0x0020;

        [NativeTypeName("#define XAUDIO2_LOG_TIMING 0x0040")]
        public const int XAUDIO2_LOG_TIMING = 0x0040;

        [NativeTypeName("#define XAUDIO2_LOG_LOCKS 0x0080")]
        public const int XAUDIO2_LOG_LOCKS = 0x0080;

        [NativeTypeName("#define XAUDIO2_LOG_MEMORY 0x0100")]
        public const int XAUDIO2_LOG_MEMORY = 0x0100;

        [NativeTypeName("#define XAUDIO2_LOG_STREAMING 0x1000")]
        public const int XAUDIO2_LOG_STREAMING = 0x1000;

        public static ref readonly Guid IID_IXAudio2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCF, 0xE3, 0x02, 0x2B,
                    0x0B, 0x2E,
                    0xC3, 0x4E,
                    0xBE,
                    0x45,
                    0x1B,
                    0x2A,
                    0x3F,
                    0xE7,
                    0x21,
                    0x0D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXAudio2Extension
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBB, 0x29, 0xAC, 0x84,
                    0x19, 0xD6,
                    0xD2, 0x44,
                    0xB1,
                    0x97,
                    0xE4,
                    0xAC,
                    0xF7,
                    0xDF,
                    0x3E,
                    0xD6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
