// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MFCameraIntrinsic_CameraModel
    {
        [NativeTypeName("FLOAT")]
        public float FocalLength_x;

        [NativeTypeName("FLOAT")]
        public float FocalLength_y;

        [NativeTypeName("FLOAT")]
        public float PrincipalPoint_x;

        [NativeTypeName("FLOAT")]
        public float PrincipalPoint_y;
    }
}
