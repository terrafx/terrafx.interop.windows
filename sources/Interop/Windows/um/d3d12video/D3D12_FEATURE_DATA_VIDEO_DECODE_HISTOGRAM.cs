// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM
    {
        [NativeTypeName("UINT")]
        public uint NodeIndex;

        [NativeTypeName("GUID")]
        public Guid DecodeProfile;

        [NativeTypeName("UINT")]
        public uint Width;

        [NativeTypeName("UINT")]
        public uint Height;

        public DXGI_FORMAT DecodeFormat;

        public D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS Components;

        [NativeTypeName("UINT")]
        public uint BinCount;

        [NativeTypeName("UINT")]
        public uint CounterBitDepth;
    }
}
