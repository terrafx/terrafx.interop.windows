// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_VIDEO_SIZE_RANGE
    {
        [NativeTypeName("UINT")]
        public uint MaxWidth;

        [NativeTypeName("UINT")]
        public uint MaxHeight;

        [NativeTypeName("UINT")]
        public uint MinWidth;

        [NativeTypeName("UINT")]
        public uint MinHeight;
    }
}
