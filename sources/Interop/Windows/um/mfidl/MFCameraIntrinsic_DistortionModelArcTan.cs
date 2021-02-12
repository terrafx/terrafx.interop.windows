// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MFCameraIntrinsic_DistortionModelArcTan
    {
        [NativeTypeName("FLOAT")]
        public float Radial_k0;

        [NativeTypeName("FLOAT")]
        public float DistortionCenter_x;

        [NativeTypeName("FLOAT")]
        public float DistortionCenter_y;

        [NativeTypeName("FLOAT")]
        public float Tangential_x;

        [NativeTypeName("FLOAT")]
        public float Tangential_y;
    }
}
