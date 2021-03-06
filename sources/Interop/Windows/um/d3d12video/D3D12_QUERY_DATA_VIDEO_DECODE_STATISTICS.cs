// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_QUERY_DATA_VIDEO_DECODE_STATISTICS
    {
        [NativeTypeName("UINT64")]
        public ulong Status;

        [NativeTypeName("UINT64")]
        public ulong NumMacroblocksAffected;

        public DXGI_RATIONAL FrameRate;

        [NativeTypeName("UINT")]
        public uint BitRate;
    }
}
