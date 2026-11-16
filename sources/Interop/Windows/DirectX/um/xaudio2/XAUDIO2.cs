// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.DirectX.XAUDIO2_FILTER_TYPE;

namespace TerraFX.Interop.DirectX;

public static partial class XAUDIO2
{
    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_DLL_A"]/*' />
    [NativeTypeName("#define XAUDIO2_DLL_A \"xaudio2_9.dll\"")]
    public static ReadOnlySpan<byte> XAUDIO2_DLL_A => "xaudio2_9.dll"u8;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_DLL_W"]/*' />
    [NativeTypeName("#define XAUDIO2_DLL_W L\"xaudio2_9.dll\"")]
    public const string XAUDIO2_DLL_W = "xaudio2_9.dll";

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_DLL"]/*' />
    [NativeTypeName("#define XAUDIO2_DLL XAUDIO2_DLL_W")]
    public const string XAUDIO2_DLL = "xaudio2_9.dll";

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_MAX_BUFFER_BYTES"]/*' />
    [NativeTypeName("#define XAUDIO2_MAX_BUFFER_BYTES 0x80000000")]
    public const uint XAUDIO2_MAX_BUFFER_BYTES = 0x80000000;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_MAX_QUEUED_BUFFERS"]/*' />
    [NativeTypeName("#define XAUDIO2_MAX_QUEUED_BUFFERS 64")]
    public const int XAUDIO2_MAX_QUEUED_BUFFERS = 64;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_MAX_BUFFERS_SYSTEM"]/*' />
    [NativeTypeName("#define XAUDIO2_MAX_BUFFERS_SYSTEM 2")]
    public const int XAUDIO2_MAX_BUFFERS_SYSTEM = 2;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_MAX_AUDIO_CHANNELS"]/*' />
    [NativeTypeName("#define XAUDIO2_MAX_AUDIO_CHANNELS 64")]
    public const int XAUDIO2_MAX_AUDIO_CHANNELS = 64;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_MIN_SAMPLE_RATE"]/*' />
    [NativeTypeName("#define XAUDIO2_MIN_SAMPLE_RATE 1000")]
    public const int XAUDIO2_MIN_SAMPLE_RATE = 1000;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_MAX_SAMPLE_RATE"]/*' />
    [NativeTypeName("#define XAUDIO2_MAX_SAMPLE_RATE 384000")]
    public const int XAUDIO2_MAX_SAMPLE_RATE = 384000;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_MAX_VOLUME_LEVEL"]/*' />
    [NativeTypeName("#define XAUDIO2_MAX_VOLUME_LEVEL 16777216.0f")]
    public const float XAUDIO2_MAX_VOLUME_LEVEL = 16777216.0f;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_MIN_FREQ_RATIO"]/*' />
    [NativeTypeName("#define XAUDIO2_MIN_FREQ_RATIO (1/1024.0f)")]
    public const float XAUDIO2_MIN_FREQ_RATIO = (1 / 1024.0f);

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_MAX_FREQ_RATIO"]/*' />
    [NativeTypeName("#define XAUDIO2_MAX_FREQ_RATIO 1024.0f")]
    public const float XAUDIO2_MAX_FREQ_RATIO = 1024.0f;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_DEFAULT_FREQ_RATIO"]/*' />
    [NativeTypeName("#define XAUDIO2_DEFAULT_FREQ_RATIO 2.0f")]
    public const float XAUDIO2_DEFAULT_FREQ_RATIO = 2.0f;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_MAX_FILTER_ONEOVERQ"]/*' />
    [NativeTypeName("#define XAUDIO2_MAX_FILTER_ONEOVERQ 1.5f")]
    public const float XAUDIO2_MAX_FILTER_ONEOVERQ = 1.5f;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_MAX_FILTER_FREQUENCY"]/*' />
    [NativeTypeName("#define XAUDIO2_MAX_FILTER_FREQUENCY 1.0f")]
    public const float XAUDIO2_MAX_FILTER_FREQUENCY = 1.0f;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_MAX_LOOP_COUNT"]/*' />
    [NativeTypeName("#define XAUDIO2_MAX_LOOP_COUNT 254")]
    public const int XAUDIO2_MAX_LOOP_COUNT = 254;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_MAX_INSTANCES"]/*' />
    [NativeTypeName("#define XAUDIO2_MAX_INSTANCES 8")]
    public const int XAUDIO2_MAX_INSTANCES = 8;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MONO"]/*' />
    [NativeTypeName("#define XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MONO 600000")]
    public const int XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MONO = 600000;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MULTICHANNEL"]/*' />
    [NativeTypeName("#define XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MULTICHANNEL 300000")]
    public const int XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MULTICHANNEL = 300000;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_COMMIT_NOW"]/*' />
    [NativeTypeName("#define XAUDIO2_COMMIT_NOW 0")]
    public const int XAUDIO2_COMMIT_NOW = 0;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_COMMIT_ALL"]/*' />
    [NativeTypeName("#define XAUDIO2_COMMIT_ALL 0")]
    public const int XAUDIO2_COMMIT_ALL = 0;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_INVALID_OPSET"]/*' />
    [NativeTypeName("#define XAUDIO2_INVALID_OPSET (UINT32)(-1)")]
    public const uint XAUDIO2_INVALID_OPSET = unchecked((uint)(-1));

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_NO_LOOP_REGION"]/*' />
    [NativeTypeName("#define XAUDIO2_NO_LOOP_REGION 0")]
    public const int XAUDIO2_NO_LOOP_REGION = 0;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_LOOP_INFINITE"]/*' />
    [NativeTypeName("#define XAUDIO2_LOOP_INFINITE 255")]
    public const int XAUDIO2_LOOP_INFINITE = 255;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_DEFAULT_CHANNELS"]/*' />
    [NativeTypeName("#define XAUDIO2_DEFAULT_CHANNELS 0")]
    public const int XAUDIO2_DEFAULT_CHANNELS = 0;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_DEFAULT_SAMPLERATE"]/*' />
    [NativeTypeName("#define XAUDIO2_DEFAULT_SAMPLERATE 0")]
    public const int XAUDIO2_DEFAULT_SAMPLERATE = 0;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_DEBUG_ENGINE"]/*' />
    [NativeTypeName("#define XAUDIO2_DEBUG_ENGINE 0x0001")]
    public const int XAUDIO2_DEBUG_ENGINE = 0x0001;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_VOICE_NOPITCH"]/*' />
    [NativeTypeName("#define XAUDIO2_VOICE_NOPITCH 0x0002")]
    public const int XAUDIO2_VOICE_NOPITCH = 0x0002;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_VOICE_NOSRC"]/*' />
    [NativeTypeName("#define XAUDIO2_VOICE_NOSRC 0x0004")]
    public const int XAUDIO2_VOICE_NOSRC = 0x0004;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_VOICE_USEFILTER"]/*' />
    [NativeTypeName("#define XAUDIO2_VOICE_USEFILTER 0x0008")]
    public const int XAUDIO2_VOICE_USEFILTER = 0x0008;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_PLAY_TAILS"]/*' />
    [NativeTypeName("#define XAUDIO2_PLAY_TAILS 0x0020")]
    public const int XAUDIO2_PLAY_TAILS = 0x0020;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_END_OF_STREAM"]/*' />
    [NativeTypeName("#define XAUDIO2_END_OF_STREAM 0x0040")]
    public const int XAUDIO2_END_OF_STREAM = 0x0040;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_SEND_USEFILTER"]/*' />
    [NativeTypeName("#define XAUDIO2_SEND_USEFILTER 0x0080")]
    public const int XAUDIO2_SEND_USEFILTER = 0x0080;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_VOICE_NOSAMPLESPLAYED"]/*' />
    [NativeTypeName("#define XAUDIO2_VOICE_NOSAMPLESPLAYED 0x0100")]
    public const int XAUDIO2_VOICE_NOSAMPLESPLAYED = 0x0100;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_STOP_ENGINE_WHEN_IDLE"]/*' />
    [NativeTypeName("#define XAUDIO2_STOP_ENGINE_WHEN_IDLE 0x2000")]
    public const int XAUDIO2_STOP_ENGINE_WHEN_IDLE = 0x2000;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_1024_QUANTUM"]/*' />
    [NativeTypeName("#define XAUDIO2_1024_QUANTUM 0x8000")]
    public const int XAUDIO2_1024_QUANTUM = 0x8000;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_NO_VIRTUAL_AUDIO_CLIENT"]/*' />
    [NativeTypeName("#define XAUDIO2_NO_VIRTUAL_AUDIO_CLIENT 0x10000")]
    public const int XAUDIO2_NO_VIRTUAL_AUDIO_CLIENT = 0x10000;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_DEFAULT_FILTER_TYPE"]/*' />
    [NativeTypeName("#define XAUDIO2_DEFAULT_FILTER_TYPE LowPassFilter")]
    public const XAUDIO2_FILTER_TYPE XAUDIO2_DEFAULT_FILTER_TYPE = LowPassFilter;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_DEFAULT_FILTER_FREQUENCY"]/*' />
    [NativeTypeName("#define XAUDIO2_DEFAULT_FILTER_FREQUENCY XAUDIO2_MAX_FILTER_FREQUENCY")]
    public const float XAUDIO2_DEFAULT_FILTER_FREQUENCY = 1.0f;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_DEFAULT_FILTER_ONEOVERQ"]/*' />
    [NativeTypeName("#define XAUDIO2_DEFAULT_FILTER_ONEOVERQ 1.0f")]
    public const float XAUDIO2_DEFAULT_FILTER_ONEOVERQ = 1.0f;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_QUANTUM_NUMERATOR"]/*' />
    [NativeTypeName("#define XAUDIO2_QUANTUM_NUMERATOR 1")]
    public const int XAUDIO2_QUANTUM_NUMERATOR = 1;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_QUANTUM_DENOMINATOR"]/*' />
    [NativeTypeName("#define XAUDIO2_QUANTUM_DENOMINATOR 100")]
    public const int XAUDIO2_QUANTUM_DENOMINATOR = 100;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_QUANTUM_MS"]/*' />
    [NativeTypeName("#define XAUDIO2_QUANTUM_MS (1000.0f * XAUDIO2_QUANTUM_NUMERATOR / XAUDIO2_QUANTUM_DENOMINATOR)")]
    public const float XAUDIO2_QUANTUM_MS = (1000.0f * 1 / 100);

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_E_INVALID_CALL"]/*' />
    [NativeTypeName("#define XAUDIO2_E_INVALID_CALL ((HRESULT)0x88960001)")]
    public const int XAUDIO2_E_INVALID_CALL = unchecked((int)(0x88960001));

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_E_XMA_DECODER_ERROR"]/*' />
    [NativeTypeName("#define XAUDIO2_E_XMA_DECODER_ERROR ((HRESULT)0x88960002)")]
    public const int XAUDIO2_E_XMA_DECODER_ERROR = unchecked((int)(0x88960002));

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_E_XAPO_CREATION_FAILED"]/*' />
    [NativeTypeName("#define XAUDIO2_E_XAPO_CREATION_FAILED ((HRESULT)0x88960003)")]
    public const int XAUDIO2_E_XAPO_CREATION_FAILED = unchecked((int)(0x88960003));

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_E_DEVICE_INVALIDATED"]/*' />
    [NativeTypeName("#define XAUDIO2_E_DEVICE_INVALIDATED ((HRESULT)0x88960004)")]
    public const int XAUDIO2_E_DEVICE_INVALIDATED = unchecked((int)(0x88960004));

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_ANY_PROCESSOR"]/*' />
    [NativeTypeName("#define XAUDIO2_ANY_PROCESSOR 0xffffffff")]
    public const uint XAUDIO2_ANY_PROCESSOR = 0xffffffff;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_USE_DEFAULT_PROCESSOR"]/*' />
    [NativeTypeName("#define XAUDIO2_USE_DEFAULT_PROCESSOR 0x00000000")]
    public const int XAUDIO2_USE_DEFAULT_PROCESSOR = 0x00000000;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_DEFAULT_PROCESSOR"]/*' />
    [NativeTypeName("#define XAUDIO2_DEFAULT_PROCESSOR Processor1")]
    public const int XAUDIO2_DEFAULT_PROCESSOR = 0x00000001;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_LOG_ERRORS"]/*' />
    [NativeTypeName("#define XAUDIO2_LOG_ERRORS 0x0001")]
    public const int XAUDIO2_LOG_ERRORS = 0x0001;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_LOG_WARNINGS"]/*' />
    [NativeTypeName("#define XAUDIO2_LOG_WARNINGS 0x0002")]
    public const int XAUDIO2_LOG_WARNINGS = 0x0002;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_LOG_INFO"]/*' />
    [NativeTypeName("#define XAUDIO2_LOG_INFO 0x0004")]
    public const int XAUDIO2_LOG_INFO = 0x0004;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_LOG_DETAIL"]/*' />
    [NativeTypeName("#define XAUDIO2_LOG_DETAIL 0x0008")]
    public const int XAUDIO2_LOG_DETAIL = 0x0008;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_LOG_API_CALLS"]/*' />
    [NativeTypeName("#define XAUDIO2_LOG_API_CALLS 0x0010")]
    public const int XAUDIO2_LOG_API_CALLS = 0x0010;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_LOG_FUNC_CALLS"]/*' />
    [NativeTypeName("#define XAUDIO2_LOG_FUNC_CALLS 0x0020")]
    public const int XAUDIO2_LOG_FUNC_CALLS = 0x0020;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_LOG_TIMING"]/*' />
    [NativeTypeName("#define XAUDIO2_LOG_TIMING 0x0040")]
    public const int XAUDIO2_LOG_TIMING = 0x0040;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_LOG_LOCKS"]/*' />
    [NativeTypeName("#define XAUDIO2_LOG_LOCKS 0x0080")]
    public const int XAUDIO2_LOG_LOCKS = 0x0080;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_LOG_MEMORY"]/*' />
    [NativeTypeName("#define XAUDIO2_LOG_MEMORY 0x0100")]
    public const int XAUDIO2_LOG_MEMORY = 0x0100;

    /// <include file='XAUDIO2.xml' path='doc/member[@name="XAUDIO2.XAUDIO2_LOG_STREAMING"]/*' />
    [NativeTypeName("#define XAUDIO2_LOG_STREAMING 0x1000")]
    public const int XAUDIO2_LOG_STREAMING = 0x1000;
}
