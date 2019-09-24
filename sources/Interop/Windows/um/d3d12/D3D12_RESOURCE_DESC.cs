// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.D3D12;
using static TerraFX.Interop.D3D12_RESOURCE_DIMENSION;
using static TerraFX.Interop.D3D12_RESOURCE_FLAGS;
using static TerraFX.Interop.D3D12_TEXTURE_LAYOUT;
using static TerraFX.Interop.DXGI_FORMAT;

namespace TerraFX.Interop
{
    public unsafe struct D3D12_RESOURCE_DESC
    {
        public D3D12_RESOURCE_DIMENSION Dimension;

        [NativeTypeName("UINT64")]
        public ulong Alignment;

        [NativeTypeName("UINT64")]
        public ulong Width;

        [NativeTypeName("UINT")]
        public uint Height;

        [NativeTypeName("UINT16")]
        public ushort DepthOrArraySize;

        [NativeTypeName("UINT16")]
        public ushort MipLevels;

        public DXGI_FORMAT Format;

        public DXGI_SAMPLE_DESC SampleDesc;

        public D3D12_TEXTURE_LAYOUT Layout;

        public D3D12_RESOURCE_FLAGS Flags;

        public D3D12_RESOURCE_DESC(D3D12_RESOURCE_DIMENSION dimension, ulong alignment, ulong width, uint height, ushort depthOrArraySize, ushort mipLevels, DXGI_FORMAT format, uint sampleCount, uint sampleQuality, D3D12_TEXTURE_LAYOUT layout, D3D12_RESOURCE_FLAGS flags)
        {
            Dimension = dimension;
            Alignment = alignment;
            Width = width;
            Height = height;
            DepthOrArraySize = depthOrArraySize;
            MipLevels = mipLevels;
            Format = format;
            SampleDesc.Count = sampleCount;
            SampleDesc.Quality = sampleQuality;
            Layout = layout;
            Flags = flags;
        }

        public ushort Depth
        {
            get
            {
                return Dimension == D3D12_RESOURCE_DIMENSION_TEXTURE3D ? DepthOrArraySize : (ushort)1;
            }
        }

        public ushort ArraySize
        {
            get
            {
                return Dimension != D3D12_RESOURCE_DIMENSION_TEXTURE3D ? DepthOrArraySize : (ushort)1;
            }
        }

        public static bool operator ==(D3D12_RESOURCE_DESC l, D3D12_RESOURCE_DESC r)
        {
             return (l.Dimension == r.Dimension)
                && (l.Alignment == r.Alignment)
                && (l.Width == r.Width)
                && (l.Height == r.Height)
                && (l.DepthOrArraySize == r.DepthOrArraySize)
                && (l.MipLevels == r.MipLevels)
                && (l.Format == r.Format)
                && (l.SampleDesc.Count == r.SampleDesc.Count)
                && (l.SampleDesc.Quality == r.SampleDesc.Quality)
                && (l.Layout == r.Layout)
                && (l.Flags == r.Flags);
        }

        public static bool operator !=(D3D12_RESOURCE_DESC l, D3D12_RESOURCE_DESC r)
        {
            return !(l == r);
        }

        public static D3D12_RESOURCE_DESC Buffer(D3D12_RESOURCE_ALLOCATION_INFO* resAllocInfo, D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE)
        {
            return new D3D12_RESOURCE_DESC(D3D12_RESOURCE_DIMENSION_BUFFER, resAllocInfo->Alignment, resAllocInfo->SizeInBytes, 1, 1, 1, DXGI_FORMAT_UNKNOWN, 1, 0, D3D12_TEXTURE_LAYOUT_ROW_MAJOR, flags);
        }
        public static D3D12_RESOURCE_DESC Buffer(ulong width, D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE, ulong alignment = 0)
        {
            return new D3D12_RESOURCE_DESC( D3D12_RESOURCE_DIMENSION_BUFFER, alignment, width, 1, 1, 1, DXGI_FORMAT_UNKNOWN, 1, 0, D3D12_TEXTURE_LAYOUT_ROW_MAJOR, flags);
        }

        public static D3D12_RESOURCE_DESC Tex1D(DXGI_FORMAT format, ulong width, ushort arraySize = 1, ushort mipLevels = 0, D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE, D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN, ulong alignment = 0)
        {
            return new D3D12_RESOURCE_DESC(D3D12_RESOURCE_DIMENSION_TEXTURE1D, alignment, width, 1, arraySize, mipLevels, format, 1, 0, layout, flags);
        }

        public static D3D12_RESOURCE_DESC Tex2D(DXGI_FORMAT format, ulong width, uint height, ushort arraySize = 1, ushort mipLevels = 0, uint sampleCount = 1, uint sampleQuality = 0, D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE, D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN, ulong alignment = 0)
        {
            return new D3D12_RESOURCE_DESC(D3D12_RESOURCE_DIMENSION_TEXTURE2D, alignment, width, height, arraySize, mipLevels, format, sampleCount, sampleQuality, layout, flags);
        }

        public static D3D12_RESOURCE_DESC Tex3D(DXGI_FORMAT format, ulong width, uint height, ushort depth, ushort mipLevels = 0, D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE, D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN, ulong alignment = 0)
        {
            return new D3D12_RESOURCE_DESC(D3D12_RESOURCE_DIMENSION_TEXTURE3D, alignment, width, height, depth, mipLevels, format, 1, 0, layout, flags);
        }

        public byte GetPlaneCount(ID3D12Device* pDevice)
        {
            return D3D12GetFormatPlaneCount(pDevice, Format);
        }

        public uint GetSubresources(ID3D12Device* pDevice)
        {
            return MipLevels * (uint)ArraySize * (uint)GetPlaneCount(pDevice);
        }

        public uint CalcSubresource(uint MipSlice, uint ArraySlice, uint PlaneSlice)
        {
            return D3D12CalcSubresource(MipSlice, ArraySlice, PlaneSlice, MipLevels, ArraySize);
        }

        public override bool Equals(object? obj)
        {
            return (obj is D3D12_RESOURCE_DESC other) && (this == other);
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            {
                hashCode.Add(Dimension);
                hashCode.Add(Alignment);
                hashCode.Add(Width);
                hashCode.Add(Height);
                hashCode.Add(DepthOrArraySize);
                hashCode.Add(MipLevels);
                hashCode.Add(Format);
                hashCode.Add(SampleDesc);
                hashCode.Add(Layout);
                hashCode.Add(Flags);
            }
            return hashCode.ToHashCode();
        }
    }
}
