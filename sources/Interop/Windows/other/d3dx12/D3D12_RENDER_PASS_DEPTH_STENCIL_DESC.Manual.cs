// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;

namespace TerraFX.Interop
{
    public partial struct D3D12_RENDER_PASS_DEPTH_STENCIL_DESC : IEquatable<D3D12_RENDER_PASS_DEPTH_STENCIL_DESC>
    {
        public static bool operator ==([NativeTypeName("const D3D12_RENDER_PASS_DEPTH_STENCIL_DESC &")] in D3D12_RENDER_PASS_DEPTH_STENCIL_DESC a, [NativeTypeName("const D3D12_RENDER_PASS_DEPTH_STENCIL_DESC &")] in D3D12_RENDER_PASS_DEPTH_STENCIL_DESC b)
        {
            if (a.cpuDescriptor.ptr != b.cpuDescriptor.ptr)
                return false;

            if (!(a.DepthBeginningAccess == b.DepthBeginningAccess))
                return false;

            if (!(a.StencilBeginningAccess == b.StencilBeginningAccess))
                return false;

            if (!(a.DepthEndingAccess == b.DepthEndingAccess))
                return false;

            if (!(a.StencilEndingAccess == b.StencilEndingAccess))
                return false;

            return true;
        }

        public static bool operator !=([NativeTypeName("const D3D12_RENDER_PASS_DEPTH_STENCIL_DESC &")] in D3D12_RENDER_PASS_DEPTH_STENCIL_DESC a, [NativeTypeName("const D3D12_RENDER_PASS_DEPTH_STENCIL_DESC &")] in D3D12_RENDER_PASS_DEPTH_STENCIL_DESC b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj) => (obj is D3D12_RENDER_PASS_DEPTH_STENCIL_DESC other) && Equals(other);

        public bool Equals(D3D12_RENDER_PASS_DEPTH_STENCIL_DESC other) => this == other;

        public override int GetHashCode() => HashCode.Combine(cpuDescriptor, DepthBeginningAccess, StencilBeginningAccess, DepthEndingAccess, StencilEndingAccess);
    }
}
