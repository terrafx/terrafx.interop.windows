// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct X3DAUDIO_CONE
    {
        [NativeTypeName("FLOAT32")]
        public float InnerAngle;

        [NativeTypeName("FLOAT32")]
        public float OuterAngle;

        [NativeTypeName("FLOAT32")]
        public float InnerVolume;

        [NativeTypeName("FLOAT32")]
        public float OuterVolume;

        [NativeTypeName("FLOAT32")]
        public float InnerLPF;

        [NativeTypeName("FLOAT32")]
        public float OuterLPF;

        [NativeTypeName("FLOAT32")]
        public float InnerReverb;

        [NativeTypeName("FLOAT32")]
        public float OuterReverb;
    }
}
