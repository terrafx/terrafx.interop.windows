// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Windows.Media.Audio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateFX([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("IUnknown **")] IUnknown** pEffect, [NativeTypeName("const void *")] void* pInitDat = null, [NativeTypeName("UINT32")] uint InitDataByteSize = 0);

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

        public static readonly Guid CLSID_FXEQ = new Guid(0xF5E01117, 0xD6C4, 0x485A, 0xA3, 0xF5, 0x69, 0x51, 0x96, 0xF3, 0xDB, 0xFA);

        public static readonly Guid CLSID_FXMasteringLimiter = new Guid(0xC4137916, 0x2BE1, 0x46FD, 0x85, 0x99, 0x44, 0x15, 0x36, 0xF4, 0x98, 0x56);

        public static readonly Guid CLSID_FXReverb = new Guid(0x7D9ACA56, 0xCB68, 0x4807, 0xB6, 0x32, 0xB1, 0x37, 0x35, 0x2E, 0x85, 0x96);

        public static readonly Guid CLSID_FXEcho = new Guid(0x5039D740, 0xF736, 0x449A, 0x84, 0xD3, 0xA5, 0x62, 0x02, 0x55, 0x7B, 0x87);
    }
}
