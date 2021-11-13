// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0.19041.0")]
    public partial struct D3D12_VIDEO_MOTION_ESTIMATOR_DESC
    {
        public uint NodeMask;

        public DXGI_FORMAT InputFormat;

        public D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE BlockSize;

        public D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION Precision;

        public D3D12_VIDEO_SIZE_RANGE SizeRange;
    }
}
