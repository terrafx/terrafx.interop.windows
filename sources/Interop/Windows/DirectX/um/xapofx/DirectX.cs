// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    public static unsafe partial class DirectX
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
    }
}
