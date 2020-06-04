// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using static TerraFX.Interop.D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE;

namespace TerraFX.Interop
{
    public partial struct D3D12_RENDER_PASS_BEGINNING_ACCESS : IEquatable<D3D12_RENDER_PASS_BEGINNING_ACCESS>
    {
        public static bool operator ==([NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS &")] in D3D12_RENDER_PASS_BEGINNING_ACCESS a, [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS &")] in D3D12_RENDER_PASS_BEGINNING_ACCESS b)
        {
            if (a.Type != b.Type)
                return false;

            if (a.Type == D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR && !(a.Anonymous.Clear == b.Anonymous.Clear))
                return false;

            return true;
        }

        public static bool operator !=([NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS &")] in D3D12_RENDER_PASS_BEGINNING_ACCESS a, [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS &")] in D3D12_RENDER_PASS_BEGINNING_ACCESS b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj) => (obj is D3D12_RENDER_PASS_BEGINNING_ACCESS other) && Equals(other);

        public bool Equals(D3D12_RENDER_PASS_BEGINNING_ACCESS other) => this == other;

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            {
                hashCode.Add(Type);

                if (Type == D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR)
                {
                    hashCode.Add(Anonymous.Clear);
                }
            }
            return hashCode.ToHashCode();
        }
    }
}
