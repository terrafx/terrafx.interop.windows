// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MFCameraIntrinsic_DistortionModel6KT
    {
        [NativeTypeName("FLOAT")]
        public float Radial_k1;

        [NativeTypeName("FLOAT")]
        public float Radial_k2;

        [NativeTypeName("FLOAT")]
        public float Radial_k3;

        [NativeTypeName("FLOAT")]
        public float Radial_k4;

        [NativeTypeName("FLOAT")]
        public float Radial_k5;

        [NativeTypeName("FLOAT")]
        public float Radial_k6;

        [NativeTypeName("FLOAT")]
        public float Tangential_p1;

        [NativeTypeName("FLOAT")]
        public float Tangential_p2;
    }
}
