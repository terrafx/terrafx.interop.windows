// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    public partial struct D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_SUBRESOURCE_PARAMETERS
    {
        public uint SrcSubresource;

        public uint DstSubresource;

        public uint DstX;

        public uint DstY;

        [NativeTypeName("D3D12_RECT")]
        public RECT SrcRect;
    }
}
