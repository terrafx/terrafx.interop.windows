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
