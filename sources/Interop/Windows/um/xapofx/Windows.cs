// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.20348.0
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
        public static extern HRESULT CreateFX([NativeTypeName("const IID &")] Guid* clsid, IUnknown** pEffect, [NativeTypeName("const void *")] void* pInitDat = null, [NativeTypeName("UINT32")] uint InitDataByteSize = 0);

        [NativeTypeName("#define FXEQ_MIN_FRAMERATE 22000")]
        public const int FXEQ_MIN_FRAMERATE = 22000;

        [NativeTypeName("#define FXEQ_MAX_FRAMERATE 48000")]
        public const int FXEQ_MAX_FRAMERATE = 48000;

        [NativeTypeName("#define FXEQ_MIN_FREQUENCY_CENTER 20.0f")]
        public const float FXEQ_MIN_FREQUENCY_CENTER = 20.0f;

        [NativeTypeName("#define FXEQ_MAX_FREQUENCY_CENTER 20000.0f")]
        public const float FXEQ_MAX_FREQUENCY_CENTER = 20000.0f;

        [NativeTypeName("#define FXEQ_DEFAULT_FREQUENCY_CENTER_0 100.0f")]
        public const float FXEQ_DEFAULT_FREQUENCY_CENTER_0 = 100.0f;

        [NativeTypeName("#define FXEQ_DEFAULT_FREQUENCY_CENTER_1 800.0f")]
        public const float FXEQ_DEFAULT_FREQUENCY_CENTER_1 = 800.0f;

        [NativeTypeName("#define FXEQ_DEFAULT_FREQUENCY_CENTER_2 2000.0f")]
        public const float FXEQ_DEFAULT_FREQUENCY_CENTER_2 = 2000.0f;

        [NativeTypeName("#define FXEQ_DEFAULT_FREQUENCY_CENTER_3 10000.0f")]
        public const float FXEQ_DEFAULT_FREQUENCY_CENTER_3 = 10000.0f;

        [NativeTypeName("#define FXEQ_MIN_GAIN 0.126f")]
        public const float FXEQ_MIN_GAIN = 0.126f;

        [NativeTypeName("#define FXEQ_MAX_GAIN 7.94f")]
        public const float FXEQ_MAX_GAIN = 7.94f;

        [NativeTypeName("#define FXEQ_DEFAULT_GAIN 1.0f")]
        public const float FXEQ_DEFAULT_GAIN = 1.0f;

        [NativeTypeName("#define FXEQ_MIN_BANDWIDTH 0.1f")]
        public const float FXEQ_MIN_BANDWIDTH = 0.1f;

        [NativeTypeName("#define FXEQ_MAX_BANDWIDTH 2.0f")]
        public const float FXEQ_MAX_BANDWIDTH = 2.0f;

        [NativeTypeName("#define FXEQ_DEFAULT_BANDWIDTH 1.0f")]
        public const float FXEQ_DEFAULT_BANDWIDTH = 1.0f;

        [NativeTypeName("#define FXMASTERINGLIMITER_MIN_RELEASE 1")]
        public const int FXMASTERINGLIMITER_MIN_RELEASE = 1;

        [NativeTypeName("#define FXMASTERINGLIMITER_MAX_RELEASE 20")]
        public const int FXMASTERINGLIMITER_MAX_RELEASE = 20;

        [NativeTypeName("#define FXMASTERINGLIMITER_DEFAULT_RELEASE 6")]
        public const int FXMASTERINGLIMITER_DEFAULT_RELEASE = 6;

        [NativeTypeName("#define FXMASTERINGLIMITER_MIN_LOUDNESS 1")]
        public const int FXMASTERINGLIMITER_MIN_LOUDNESS = 1;

        [NativeTypeName("#define FXMASTERINGLIMITER_MAX_LOUDNESS 1800")]
        public const int FXMASTERINGLIMITER_MAX_LOUDNESS = 1800;

        [NativeTypeName("#define FXMASTERINGLIMITER_DEFAULT_LOUDNESS 1000")]
        public const int FXMASTERINGLIMITER_DEFAULT_LOUDNESS = 1000;

        [NativeTypeName("#define FXREVERB_MIN_DIFFUSION 0.0f")]
        public const float FXREVERB_MIN_DIFFUSION = 0.0f;

        [NativeTypeName("#define FXREVERB_MAX_DIFFUSION 1.0f")]
        public const float FXREVERB_MAX_DIFFUSION = 1.0f;

        [NativeTypeName("#define FXREVERB_DEFAULT_DIFFUSION 0.9f")]
        public const float FXREVERB_DEFAULT_DIFFUSION = 0.9f;

        [NativeTypeName("#define FXREVERB_MIN_ROOMSIZE 0.0001f")]
        public const float FXREVERB_MIN_ROOMSIZE = 0.0001f;

        [NativeTypeName("#define FXREVERB_MAX_ROOMSIZE 1.0f")]
        public const float FXREVERB_MAX_ROOMSIZE = 1.0f;

        [NativeTypeName("#define FXREVERB_DEFAULT_ROOMSIZE 0.6f")]
        public const float FXREVERB_DEFAULT_ROOMSIZE = 0.6f;

        [NativeTypeName("#define FXLOUDNESS_DEFAULT_MOMENTARY_MS 400")]
        public const int FXLOUDNESS_DEFAULT_MOMENTARY_MS = 400;

        [NativeTypeName("#define FXLOUDNESS_DEFAULT_SHORTTERM_MS 3000")]
        public const int FXLOUDNESS_DEFAULT_SHORTTERM_MS = 3000;

        [NativeTypeName("#define FXECHO_MIN_WETDRYMIX 0.0f")]
        public const float FXECHO_MIN_WETDRYMIX = 0.0f;

        [NativeTypeName("#define FXECHO_MAX_WETDRYMIX 1.0f")]
        public const float FXECHO_MAX_WETDRYMIX = 1.0f;

        [NativeTypeName("#define FXECHO_DEFAULT_WETDRYMIX 0.5f")]
        public const float FXECHO_DEFAULT_WETDRYMIX = 0.5f;

        [NativeTypeName("#define FXECHO_MIN_FEEDBACK 0.0f")]
        public const float FXECHO_MIN_FEEDBACK = 0.0f;

        [NativeTypeName("#define FXECHO_MAX_FEEDBACK 1.0f")]
        public const float FXECHO_MAX_FEEDBACK = 1.0f;

        [NativeTypeName("#define FXECHO_DEFAULT_FEEDBACK 0.5f")]
        public const float FXECHO_DEFAULT_FEEDBACK = 0.5f;

        [NativeTypeName("#define FXECHO_MIN_DELAY 1.0f")]
        public const float FXECHO_MIN_DELAY = 1.0f;

        [NativeTypeName("#define FXECHO_MAX_DELAY 2000.0f")]
        public const float FXECHO_MAX_DELAY = 2000.0f;

        [NativeTypeName("#define FXECHO_DEFAULT_DELAY 500.0f")]
        public const float FXECHO_DEFAULT_DELAY = 500.0f;

        public static ref readonly Guid CLSID_FXEQ
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x17, 0x11, 0xE0, 0xF5,
                    0xC4, 0xD6,
                    0x5A, 0x48,
                    0xA3,
                    0xF5,
                    0x69,
                    0x51,
                    0x96,
                    0xF3,
                    0xDB,
                    0xFA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_FXMasteringLimiter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0x79, 0x13, 0xC4,
                    0xE1, 0x2B,
                    0xFD, 0x46,
                    0x85,
                    0x99,
                    0x44,
                    0x15,
                    0x36,
                    0xF4,
                    0x98,
                    0x56
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_FXReverb
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x56, 0xCA, 0x9A, 0x7D,
                    0x68, 0xCB,
                    0x07, 0x48,
                    0xB6,
                    0x32,
                    0xB1,
                    0x37,
                    0x35,
                    0x2E,
                    0x85,
                    0x96
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_FXEcho
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0xD7, 0x39, 0x50,
                    0x36, 0xF7,
                    0x9A, 0x44,
                    0x84,
                    0xD3,
                    0xA5,
                    0x62,
                    0x02,
                    0x55,
                    0x7B,
                    0x87
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
