// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int SPEAKER_MONO = SPEAKER_FRONT_CENTER;

        public const int SPEAKER_STEREO = (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT);

        public const int SPEAKER_2POINT1 = (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_LOW_FREQUENCY);

        public const int SPEAKER_SURROUND = (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_BACK_CENTER);

        public const int SPEAKER_QUAD = (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT);

        public const int SPEAKER_4POINT1 = (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT);

        public const int SPEAKER_5POINT1 = (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT);

        public const int SPEAKER_7POINT1 = (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT | SPEAKER_FRONT_LEFT_OF_CENTER | SPEAKER_FRONT_RIGHT_OF_CENTER);

        public const int SPEAKER_5POINT1_SURROUND = (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_SIDE_LEFT | SPEAKER_SIDE_RIGHT);

        public const int SPEAKER_7POINT1_SURROUND = (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT | SPEAKER_SIDE_LEFT | SPEAKER_SIDE_RIGHT);

        public const int X3DAUDIO_HANDLE_BYTESIZE = 20;

        public const float X3DAUDIO_PI = 3.141592654f;

        public const float X3DAUDIO_2PI = 6.283185307f;

        public const float X3DAUDIO_SPEED_OF_SOUND = 343.5f;

        public const int X3DAUDIO_CALCULATE_MATRIX = 0x00000001;

        public const int X3DAUDIO_CALCULATE_DELAY = 0x00000002;

        public const int X3DAUDIO_CALCULATE_LPF_DIRECT = 0x00000004;

        public const int X3DAUDIO_CALCULATE_LPF_REVERB = 0x00000008;

        public const int X3DAUDIO_CALCULATE_REVERB = 0x00000010;

        public const int X3DAUDIO_CALCULATE_DOPPLER = 0x00000020;

        public const int X3DAUDIO_CALCULATE_EMITTER_ANGLE = 0x00000040;

        public const int X3DAUDIO_CALCULATE_ZEROCENTER = 0x00010000;

        public const int X3DAUDIO_CALCULATE_REDIRECT_TO_LFE = 0x00020000;

        // public static readonly X3DAUDIO_DISTANCE_CURVE X3DAudioDefault_LinearCurve = new X3DAUDIO_DISTANCE_CURVE {
        //    pPoints = &X3DAudioDefault_LinearCurvePoints[0],
        //    PointsCount = 2,
        // };
    }
}
