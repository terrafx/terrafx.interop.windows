// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT
    {
        [NativeTypeName("UINT")]
        public uint NodeIndex;

        [NativeTypeName("BOOL")]
        public int VideoDecodeSupport;

        [NativeTypeName("BOOL")]
        public int VideoProcessSupport;

        [NativeTypeName("BOOL")]
        public int VideoEncodeSupport;
    }
}
