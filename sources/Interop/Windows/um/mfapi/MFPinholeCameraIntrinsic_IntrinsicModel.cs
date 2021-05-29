// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MFPinholeCameraIntrinsic_IntrinsicModel
    {
        [NativeTypeName("UINT32")]
        public uint Width;

        [NativeTypeName("UINT32")]
        public uint Height;

        public MFCameraIntrinsic_PinholeCameraModel CameraModel;

        public MFCameraIntrinsic_DistortionModel DistortionModel;
    }
}
