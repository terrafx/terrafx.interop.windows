// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_FORMATS
    {
        [NativeTypeName("UINT")]
        public uint NodeIndex;

        public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;

        [NativeTypeName("UINT")]
        public uint FormatCount;

        [NativeTypeName("DXGI_FORMAT *")]
        public DXGI_FORMAT* pOutputFormats;
    }
}
