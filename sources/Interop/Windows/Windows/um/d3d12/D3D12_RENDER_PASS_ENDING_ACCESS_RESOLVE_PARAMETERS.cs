// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS
    {
        public ID3D12Resource* pSrcResource;

        public ID3D12Resource* pDstResource;

        public uint SubresourceCount;

        [NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_SUBRESOURCE_PARAMETERS *")]
        public D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_SUBRESOURCE_PARAMETERS* pSubresourceParameters;

        public DXGI_FORMAT Format;

        public D3D12_RESOLVE_MODE ResolveMode;

        public BOOL PreserveResolveSource;
    }
}
