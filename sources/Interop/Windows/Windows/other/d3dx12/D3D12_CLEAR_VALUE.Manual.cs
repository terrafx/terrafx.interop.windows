// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using static TerraFX.Interop.Windows.DXGI_FORMAT;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct D3D12_CLEAR_VALUE : IEquatable<D3D12_CLEAR_VALUE>
    {
        public D3D12_CLEAR_VALUE(DXGI_FORMAT format, [NativeTypeName("const FLOAT [4]")] float* color)
        {
            Unsafe.SkipInit(out this);

            Format = format;
            Anonymous.Color[0] = color[0];
            Anonymous.Color[1] = color[1];
            Anonymous.Color[2] = color[2];
            Anonymous.Color[3] = color[3];
        }

        public D3D12_CLEAR_VALUE(DXGI_FORMAT format, float depth, [NativeTypeName("UINT8")] byte stencil)
        {
            Format = format;
            Anonymous.DepthStencil.Depth = depth;
            Anonymous.DepthStencil.Stencil = stencil;
        }

        public static bool operator ==([NativeTypeName("const D3D12_CLEAR_VALUE &")] in D3D12_CLEAR_VALUE a, [NativeTypeName("const D3D12_CLEAR_VALUE &")] in D3D12_CLEAR_VALUE b)
        {
            if (a.Format != b.Format)
            {
                return false;
            }

            if (a.Format == DXGI_FORMAT_D24_UNORM_S8_UINT || a.Format == DXGI_FORMAT_D16_UNORM || a.Format == DXGI_FORMAT_D32_FLOAT || a.Format == DXGI_FORMAT_D32_FLOAT_S8X24_UINT)
            {
                return (a.Anonymous.DepthStencil.Depth == b.Anonymous.DepthStencil.Depth) && (a.Anonymous.DepthStencil.Stencil == b.Anonymous.DepthStencil.Stencil);
            }
            else
            {
                return (a.Anonymous.Color[0] == b.Anonymous.Color[0]) && (a.Anonymous.Color[1] == b.Anonymous.Color[1]) && (a.Anonymous.Color[2] == b.Anonymous.Color[2]) && (a.Anonymous.Color[3] == b.Anonymous.Color[3]);
            }
        }

        public static bool operator !=([NativeTypeName("const D3D12_CLEAR_VALUE &")] in D3D12_CLEAR_VALUE a, [NativeTypeName("const D3D12_CLEAR_VALUE &")] in D3D12_CLEAR_VALUE b)
            => !(a == b);

        public override bool Equals(object? obj) => (obj is D3D12_CLEAR_VALUE other) && Equals(other);

        public bool Equals(D3D12_CLEAR_VALUE other) => this == other;

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            {
                hashCode.Add(Format);

                if (Format == DXGI_FORMAT_D24_UNORM_S8_UINT || Format == DXGI_FORMAT_D16_UNORM || Format == DXGI_FORMAT_D32_FLOAT || Format == DXGI_FORMAT_D32_FLOAT_S8X24_UINT)
                {
                    hashCode.Add(Anonymous.DepthStencil);
                }
                else
                {
                    hashCode.Add(Anonymous.Color[0]);
                    hashCode.Add(Anonymous.Color[1]);
                    hashCode.Add(Anonymous.Color[2]);
                    hashCode.Add(Anonymous.Color[3]);
                }
            }
            return hashCode.ToHashCode();
        }
    }
}
