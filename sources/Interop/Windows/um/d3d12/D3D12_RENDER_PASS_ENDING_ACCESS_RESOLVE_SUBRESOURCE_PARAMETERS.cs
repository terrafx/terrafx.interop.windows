// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_SUBRESOURCE_PARAMETERS
    {
        [NativeTypeName("UINT")]
        public uint SrcSubresource;

        [NativeTypeName("UINT")]
        public uint DstSubresource;

        [NativeTypeName("UINT")]
        public uint DstX;

        [NativeTypeName("UINT")]
        public uint DstY;

        [NativeTypeName("D3D12_RECT")]
        public RECT SrcRect;
    }
}
