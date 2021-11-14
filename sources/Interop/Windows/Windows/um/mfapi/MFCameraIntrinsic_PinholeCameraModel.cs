// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0")]
    public partial struct MFCameraIntrinsic_PinholeCameraModel
    {
        public MF_FLOAT2 FocalLength;

        public MF_FLOAT2 PrincipalPoint;
    }
}
