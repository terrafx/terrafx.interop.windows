// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS : IEquatable<D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS>
    {
        public static bool operator ==([NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS &")] in D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS a, [NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS &")] in D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS b)
        {
            if (a.pSrcResource != b.pSrcResource)
            {
                return false;
            }

            if (a.pDstResource != b.pDstResource)
            {
                return false;
            }

            if (a.SubresourceCount != b.SubresourceCount)
            {
                return false;
            }

            if (a.Format != b.Format)
            {
                return false;
            }

            if (a.ResolveMode != b.ResolveMode)
            {
                return false;
            }

            if (a.PreserveResolveSource != b.PreserveResolveSource)
            {
                return false;
            }

            return true;
        }

        public static bool operator !=([NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS &")] in D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS a, [NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS &")] in D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS b)
            => !(a == b);

        public override bool Equals(object? obj) => (obj is D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS other) && Equals(other);

        public bool Equals(D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS other) => this == other;

        public override int GetHashCode() => HashCode.Combine((nuint)pSrcResource, (nuint)pDstResource, SubresourceCount, (nuint)pSubresourceParameters, Format, ResolveMode, PreserveResolveSource);
    }
}
