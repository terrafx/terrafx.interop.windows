// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using static TerraFX.Interop.Windows;
using static TerraFX.Interop.D3D12_RESOURCE_DIMENSION;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_VIEWPORT : IEquatable<D3D12_VIEWPORT>
    {
        public static bool operator ==([NativeTypeName("const D3D12_VIEWPORT &")] in D3D12_VIEWPORT l, [NativeTypeName("const D3D12_VIEWPORT &")] in D3D12_VIEWPORT r)
        {
            return l.TopLeftX == r.TopLeftX && l.TopLeftY == r.TopLeftY && l.Width == r.Width && l.Height == r.Height && l.MinDepth == r.MinDepth && l.MaxDepth == r.MaxDepth;
        }

        public static bool operator !=([NativeTypeName("const D3D12_VIEWPORT &")] in D3D12_VIEWPORT l, [NativeTypeName("const D3D12_VIEWPORT &")] in D3D12_VIEWPORT r)
        {
            return !(l == r);
        }

        public D3D12_VIEWPORT(float topLeftX, float topLeftY, float width, float height, float minDepth = D3D12_MIN_DEPTH, float maxDepth = D3D12_MAX_DEPTH)
        {
            TopLeftX = topLeftX;
            TopLeftY = topLeftY;
            Width = width;
            Height = height;
            MinDepth = minDepth;
            MaxDepth = maxDepth;
        }

        public D3D12_VIEWPORT(ID3D12Resource* pResource, uint mipSlice = 0, float topLeftX = 0.0f, float topLeftY = 0.0f, float minDepth = D3D12_MIN_DEPTH, float maxDepth = D3D12_MAX_DEPTH)
        {
            var Desc = pResource->GetDesc();

            ulong SubresourceWidth = Desc.Width >> unchecked((int)mipSlice);
            ulong SubresourceHeight = Desc.Height >> unchecked((int)mipSlice);

            switch (Desc.Dimension)
            {
                case D3D12_RESOURCE_DIMENSION_BUFFER:
                    TopLeftX = topLeftX;
                    TopLeftY = 0.0f;
                    Width = Desc.Width - topLeftX;
                    Height = 1.0f;
                    break;

                case D3D12_RESOURCE_DIMENSION_TEXTURE1D:
                    TopLeftX = topLeftX;
                    TopLeftY = 0.0f;
                    Width = ((SubresourceWidth != 0) ? SubresourceWidth : 1.0f) - topLeftX;
                    Height = 1.0f;
                    break;

                case D3D12_RESOURCE_DIMENSION_TEXTURE2D:
                case D3D12_RESOURCE_DIMENSION_TEXTURE3D:
                    TopLeftX = topLeftX;
                    TopLeftY = topLeftY;
                    Width = ((SubresourceWidth != 0) ? SubresourceWidth : 1.0f) - topLeftX;
                    Height = ((SubresourceHeight != 0) ? SubresourceHeight : 1.0f) - topLeftY;
                    break;

                default:
                    TopLeftX = 0;
                    TopLeftY = 0;
                    Width = 0;
                    Height = 0;
                    break;
            }

            MinDepth = minDepth;
            MaxDepth = maxDepth;
        }

        public override bool Equals(object? obj) => (obj is D3D12_VIEWPORT other) && Equals(other);

        public bool Equals(D3D12_VIEWPORT other) => this == other;

        public override int GetHashCode() => HashCode.Combine(TopLeftX, TopLeftY, Width, Height, MinDepth, MaxDepth);
    }
}
