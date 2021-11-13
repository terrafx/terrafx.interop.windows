// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct D3D12_RENDER_PASS_DEPTH_STENCIL_DESC
    {
        public D3D12_CPU_DESCRIPTOR_HANDLE cpuDescriptor;

        public D3D12_RENDER_PASS_BEGINNING_ACCESS DepthBeginningAccess;

        public D3D12_RENDER_PASS_BEGINNING_ACCESS StencilBeginningAccess;

        public D3D12_RENDER_PASS_ENDING_ACCESS DepthEndingAccess;

        public D3D12_RENDER_PASS_ENDING_ACCESS StencilEndingAccess;
    }
}
