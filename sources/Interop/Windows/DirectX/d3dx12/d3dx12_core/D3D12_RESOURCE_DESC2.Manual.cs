// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Diagnostics.CodeAnalysis;
using static TerraFX.Interop.DirectX.D3D12_RESOURCE_DIMENSION;
using static TerraFX.Interop.DirectX.D3D12_RESOURCE_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_TEXTURE_LAYOUT;
using static TerraFX.Interop.DirectX.DXGI_FORMAT;
using static TerraFX.Interop.DirectX.DirectX;

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D12_RESOURCE_DESC2 : IEquatable<D3D12_RESOURCE_DESC2>
{
    public D3D12_RESOURCE_DESC2(in D3D12_RESOURCE_DESC1 other)
    {
        Dimension = other.Dimension;
        Alignment = other.Alignment;
        Width = other.Width;
        Height = other.Height;
        DepthOrArraySize = other.DepthOrArraySize;
        MipLevels = other.MipLevels;
        Format = other.Format;
        SampleDesc = other.SampleDesc;
        Layout = other.Layout;
        Flags = other.Flags;
        SamplerFeedbackMipRegion = other.SamplerFeedbackMipRegion;
        LayoutGuid = default;
    }

    public D3D12_RESOURCE_DESC2(in D3D12_RESOURCE_DESC other)
    {
        Dimension = other.Dimension;
        Alignment = other.Alignment;
        Width = other.Width;
        Height = other.Height;
        DepthOrArraySize = other.DepthOrArraySize;
        MipLevels = other.MipLevels;
        Format = other.Format;
        SampleDesc = other.SampleDesc;
        Layout = other.Layout;
        Flags = other.Flags;
        SamplerFeedbackMipRegion = default;
        LayoutGuid = default;
    }

    public D3D12_RESOURCE_DESC2(
        D3D12_RESOURCE_DIMENSION dimension,
        ulong alignment,
        ulong width,
        uint height,
        ushort depthOrArraySize,
        ushort mipLevels,
        DXGI_FORMAT format,
        uint sampleCount,
        uint sampleQuality,
        D3D12_TEXTURE_LAYOUT layout,
        D3D12_RESOURCE_FLAGS flags,
        uint samplerFeedbackMipRegionWidth = 0,
        uint samplerFeedbackMipRegionHeight = 0,
        uint samplerFeedbackMipRegionDepth = 0,
        Guid layoutGuid = default)
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
        SamplerFeedbackMipRegion.Width = samplerFeedbackMipRegionWidth;
        SamplerFeedbackMipRegion.Height = samplerFeedbackMipRegionHeight;
        SamplerFeedbackMipRegion.Depth = samplerFeedbackMipRegionDepth;
        LayoutGuid = layoutGuid;
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_DESC2")]
    public static D3D12_RESOURCE_DESC2 Buffer(in D3D12_RESOURCE_ALLOCATION_INFO resAllocInfo, D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE)
    {
        return new D3D12_RESOURCE_DESC2(D3D12_RESOURCE_DIMENSION_BUFFER, resAllocInfo.Alignment, resAllocInfo.SizeInBytes, 1, 1, 1, DXGI_FORMAT_UNKNOWN, 1, 0, D3D12_TEXTURE_LAYOUT_ROW_MAJOR, flags);
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_DESC2")]
    public static D3D12_RESOURCE_DESC2 Buffer(ulong width, D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE, ulong alignment = 0)
    {
        return new D3D12_RESOURCE_DESC2(D3D12_RESOURCE_DIMENSION_BUFFER, alignment, width, 1, 1, 1, DXGI_FORMAT_UNKNOWN, 1, 0, D3D12_TEXTURE_LAYOUT_ROW_MAJOR, flags);
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_DESC2")]
    public static D3D12_RESOURCE_DESC2 Tex1D(DXGI_FORMAT format, ulong width, ushort arraySize = 1, ushort mipLevels = 0, D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE, D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN, ulong alignment = 0)
    {
        return new D3D12_RESOURCE_DESC2(D3D12_RESOURCE_DIMENSION_TEXTURE1D, alignment, width, 1, arraySize, mipLevels, format, 1, 0, layout, flags);
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_DESC2")]
    public static D3D12_RESOURCE_DESC2 Tex2D(
        DXGI_FORMAT format,
        ulong width,
        uint height,
        ushort arraySize = 1,
        ushort mipLevels = 0,
        uint sampleCount = 1,
        uint sampleQuality = 0,
        D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE,
        D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN,
        ulong alignment = 0,
        uint samplerFeedbackMipRegionWidth = 0,
        uint samplerFeedbackMipRegionHeight = 0,
        uint samplerFeedbackMipRegionDepth = 0,
        Guid layoutGuid = default)
    {
        return new D3D12_RESOURCE_DESC2(D3D12_RESOURCE_DIMENSION_TEXTURE2D, alignment, width, height, arraySize, mipLevels, format, sampleCount, sampleQuality, layout, flags, samplerFeedbackMipRegionWidth, samplerFeedbackMipRegionHeight, samplerFeedbackMipRegionDepth, layoutGuid);
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_DESC2")]
    public static D3D12_RESOURCE_DESC2 Tex3D(DXGI_FORMAT format, ulong width, uint height, ushort depth, ushort mipLevels = 0, D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE, D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN, ulong alignment = 0)
    {
        return new D3D12_RESOURCE_DESC2(D3D12_RESOURCE_DIMENSION_TEXTURE3D, alignment, width, height, depth, mipLevels, format, 1, 0, layout, flags);
    }

    [return: NativeTypeName("UINT16")]
    public readonly ushort Depth() => Dimension == D3D12_RESOURCE_DIMENSION_TEXTURE3D ? DepthOrArraySize : (ushort)1;

    [return: NativeTypeName("UINT16")]
    public readonly ushort ArraySize() => Dimension != D3D12_RESOURCE_DIMENSION_TEXTURE3D ? DepthOrArraySize : (ushort)1;

    [return: NativeTypeName("UINT8")]
    public readonly byte PlaneCount(ID3D12Device* pDevice) => D3D12GetFormatPlaneCount(pDevice, Format);

    public readonly uint Subresources(ID3D12Device* pDevice) => (uint)MipLevels * ArraySize() * PlaneCount(pDevice);

    public readonly uint CalcSubresource(uint MipSlice, uint ArraySlice, uint PlaneSlice) => D3D12CalcSubresource(MipSlice, ArraySlice, PlaneSlice, MipLevels, ArraySize());

    public static bool operator ==(in D3D12_RESOURCE_DESC2 left, in D3D12_RESOURCE_DESC2 right)
    {
        return left.Dimension == right.Dimension
            && left.Alignment == right.Alignment
            && left.Width == right.Width
            && left.Height == right.Height
            && left.DepthOrArraySize == right.DepthOrArraySize
            && left.MipLevels == right.MipLevels
            && left.Format == right.Format
            && left.SampleDesc.Count == right.SampleDesc.Count
            && left.SampleDesc.Quality == right.SampleDesc.Quality
            && left.Layout == right.Layout
            && left.Flags == right.Flags
            && left.SamplerFeedbackMipRegion.Width == right.SamplerFeedbackMipRegion.Width
            && left.SamplerFeedbackMipRegion.Height == right.SamplerFeedbackMipRegion.Height
            && left.SamplerFeedbackMipRegion.Depth == right.SamplerFeedbackMipRegion.Depth
            && left.LayoutGuid == right.LayoutGuid;
    }

    public static bool operator !=(in D3D12_RESOURCE_DESC2 left, in D3D12_RESOURCE_DESC2 right) => !(left == right);

    public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is D3D12_RESOURCE_DESC2 other && Equals(other);

    public readonly bool Equals(D3D12_RESOURCE_DESC2 other) => this == other;

    public override readonly int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(Dimension);
        hashCode.Add(Alignment);
        hashCode.Add(Width);
        hashCode.Add(Height);
        hashCode.Add(DepthOrArraySize);
        hashCode.Add(MipLevels);
        hashCode.Add(Format);
        hashCode.Add(SampleDesc.Count);
        hashCode.Add(SampleDesc.Quality);
        hashCode.Add(Layout);
        hashCode.Add(Flags);
        hashCode.Add(SamplerFeedbackMipRegion.Width);
        hashCode.Add(SamplerFeedbackMipRegion.Height);
        hashCode.Add(SamplerFeedbackMipRegion.Depth);
        hashCode.Add(LayoutGuid);
        return hashCode.ToHashCode();
    }
}
