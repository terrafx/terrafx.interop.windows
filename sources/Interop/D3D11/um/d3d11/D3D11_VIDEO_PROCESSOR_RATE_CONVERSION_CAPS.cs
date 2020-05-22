// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS
    {
        [NativeTypeName("UINT")]
        public uint PastFrames;

        [NativeTypeName("UINT")]
        public uint FutureFrames;

        [NativeTypeName("UINT")]
        public uint ProcessorCaps;

        [NativeTypeName("UINT")]
        public uint ITelecineCaps;

        [NativeTypeName("UINT")]
        public uint CustomRateCount;
    }
}
