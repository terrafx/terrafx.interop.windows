// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM
    {
        [NativeTypeName("UINT64")]
        public ulong Offset;

        public ID3D12Resource* pBuffer;
    }
}
