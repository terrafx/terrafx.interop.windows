// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const X3DAUDIO_DISTANCE_CURVE_POINT [2]")]
        public static X3DAUDIO_DISTANCE_CURVE_POINT[] X3DAudioDefault_LinearCurvePoints = new X3DAUDIO_DISTANCE_CURVE_POINT[2]
        {
            new X3DAUDIO_DISTANCE_CURVE_POINT
            {
                Distance = 0.0f,
                DSPSetting = 1.0f,
            },
            new X3DAUDIO_DISTANCE_CURVE_POINT
            {
                Distance = 1.0f,
                DSPSetting = 0.0f,
            },
        };

        [NativeTypeName("const X3DAUDIO_CONE")]
        public static readonly X3DAUDIO_CONE X3DAudioDefault_DirectionalCone = new X3DAUDIO_CONE
        {
            InnerAngle = 3.141592654f / 2,
            OuterAngle = 3.141592654f,
            InnerVolume = 1.0f,
            OuterVolume = 0.708f,
            InnerLPF = 0.0f,
            OuterLPF = 0.25f,
            InnerReverb = 0.708f,
            OuterReverb = 1.0f,
        };

        [DllImport("X3DAudio1_7", EntryPoint = "X3DAudioInitialize", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int X3DAudioInitialize([NativeTypeName("UINT32")] uint SpeakerChannelMask, [NativeTypeName("FLOAT32")] float SpeedOfSound, [NativeTypeName("X3DAUDIO_HANDLE")] byte* Instance);

        [DllImport("X3DAudio1_7", EntryPoint = "X3DAudioCalculate", ExactSpelling = true)]
        public static extern void X3DAudioCalculate([NativeTypeName("const X3DAUDIO_HANDLE")] byte* Instance, [NativeTypeName("const X3DAUDIO_LISTENER *")] X3DAUDIO_LISTENER* pListener, [NativeTypeName("const X3DAUDIO_EMITTER *")] X3DAUDIO_EMITTER* pEmitter, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("X3DAUDIO_DSP_SETTINGS *")] X3DAUDIO_DSP_SETTINGS* pDSPSettings);
    }
}
