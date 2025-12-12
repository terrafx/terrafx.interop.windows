// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_BUFFER_UAV_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_UAV_DIMENSION;
using static TerraFX.Interop.DirectX.DXGI_FORMAT;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_UNORDERED_ACCESS_VIEW_DESC.xml' path='doc/member[@name="D3D12_UNORDERED_ACCESS_VIEW_DESC"]/*' />
[NativeTypeName("struct CD3DX12_UNORDERED_ACCESS_VIEW_DESC : D3D12_UNORDERED_ACCESS_VIEW_DESC")]
[NativeInheritance("D3D12_UNORDERED_ACCESS_VIEW_DESC")]
public partial struct D3D12_UNORDERED_ACCESS_VIEW_DESC
{

    [return: NativeTypeName("CD3DX12_UNORDERED_ACCESS_VIEW_DESC")]
    public static D3D12_UNORDERED_ACCESS_VIEW_DESC StructuredBuffer(uint NumElements, uint StructureByteStride, [NativeTypeName("UINT64")] ulong FirstElement = 0, [NativeTypeName("UINT64")] ulong CounterOffsetInBytes = 0)
    {
        D3D12_UNORDERED_ACCESS_VIEW_DESC desc = new D3D12_UNORDERED_ACCESS_VIEW_DESC();

        desc.Format = DXGI_FORMAT_UNKNOWN;
        desc.ViewDimension = D3D12_UAV_DIMENSION_BUFFER;
        desc.Anonymous.Buffer.FirstElement = FirstElement;
        desc.Anonymous.Buffer.NumElements = NumElements;
        desc.Anonymous.Buffer.StructureByteStride = StructureByteStride;
        desc.Anonymous.Buffer.Flags = D3D12_BUFFER_UAV_FLAG_NONE;
        desc.Anonymous.Buffer.CounterOffsetInBytes = CounterOffsetInBytes;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_UNORDERED_ACCESS_VIEW_DESC")]
    public static D3D12_UNORDERED_ACCESS_VIEW_DESC RawBuffer(uint NumElements, [NativeTypeName("UINT64")] ulong FirstElement = 0, [NativeTypeName("UINT64")] ulong CounterOffsetInBytes = 0)
    {
        D3D12_UNORDERED_ACCESS_VIEW_DESC desc = new D3D12_UNORDERED_ACCESS_VIEW_DESC();

        desc.Format = DXGI_FORMAT_R32_UINT;
        desc.ViewDimension = D3D12_UAV_DIMENSION_BUFFER;
        desc.Anonymous.Buffer.FirstElement = FirstElement;
        desc.Anonymous.Buffer.NumElements = NumElements;
        desc.Anonymous.Buffer.StructureByteStride = 0;
        desc.Anonymous.Buffer.Flags = D3D12_BUFFER_UAV_FLAG_RAW;
        desc.Anonymous.Buffer.CounterOffsetInBytes = CounterOffsetInBytes;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_UNORDERED_ACCESS_VIEW_DESC")]
    public static D3D12_UNORDERED_ACCESS_VIEW_DESC TypedBuffer(DXGI_FORMAT Format, uint NumElements, [NativeTypeName("UINT64")] ulong FirstElement = 0, [NativeTypeName("UINT64")] ulong CounterOffsetInBytes = 0)
    {
        D3D12_UNORDERED_ACCESS_VIEW_DESC desc = new D3D12_UNORDERED_ACCESS_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_UAV_DIMENSION_BUFFER;
        desc.Anonymous.Buffer.FirstElement = FirstElement;
        desc.Anonymous.Buffer.NumElements = NumElements;
        desc.Anonymous.Buffer.StructureByteStride = 0;
        desc.Anonymous.Buffer.Flags = D3D12_BUFFER_UAV_FLAG_NONE;
        desc.Anonymous.Buffer.CounterOffsetInBytes = CounterOffsetInBytes;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_UNORDERED_ACCESS_VIEW_DESC")]
    public static D3D12_UNORDERED_ACCESS_VIEW_DESC Tex1D(DXGI_FORMAT Format, uint MipSlice = 0)
    {
        D3D12_UNORDERED_ACCESS_VIEW_DESC desc = new D3D12_UNORDERED_ACCESS_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_UAV_DIMENSION_TEXTURE1D;
        desc.Anonymous.Texture1D.MipSlice = MipSlice;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_UNORDERED_ACCESS_VIEW_DESC")]
    public static D3D12_UNORDERED_ACCESS_VIEW_DESC Tex1DArray(DXGI_FORMAT Format, uint ArraySize = unchecked((uint)(-1)), uint FirstArraySlice = 0, uint MipSlice = 0)
    {
        D3D12_UNORDERED_ACCESS_VIEW_DESC desc = new D3D12_UNORDERED_ACCESS_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_UAV_DIMENSION_TEXTURE1DARRAY;
        desc.Anonymous.Texture1DArray.MipSlice = MipSlice;
        desc.Anonymous.Texture1DArray.FirstArraySlice = FirstArraySlice;
        desc.Anonymous.Texture1DArray.ArraySize = unchecked(ArraySize);
        return desc;
    }

    [return: NativeTypeName("CD3DX12_UNORDERED_ACCESS_VIEW_DESC")]
    public static D3D12_UNORDERED_ACCESS_VIEW_DESC Tex2D(DXGI_FORMAT Format, uint MipSlice = 0, uint PlaneSlice = 0)
    {
        D3D12_UNORDERED_ACCESS_VIEW_DESC desc = new D3D12_UNORDERED_ACCESS_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_UAV_DIMENSION_TEXTURE2D;
        desc.Anonymous.Texture2D.MipSlice = MipSlice;
        desc.Anonymous.Texture2D.PlaneSlice = PlaneSlice;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_UNORDERED_ACCESS_VIEW_DESC")]
    public static D3D12_UNORDERED_ACCESS_VIEW_DESC Tex2DArray(DXGI_FORMAT Format, uint ArraySize = unchecked((uint)(-1)), uint FirstArraySlice = 0, uint MipSlice = 0, uint PlaneSlice = 0)
    {
        D3D12_UNORDERED_ACCESS_VIEW_DESC desc = new D3D12_UNORDERED_ACCESS_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_UAV_DIMENSION_TEXTURE2DARRAY;
        desc.Anonymous.Texture2DArray.MipSlice = MipSlice;
        desc.Anonymous.Texture2DArray.FirstArraySlice = FirstArraySlice;
        desc.Anonymous.Texture2DArray.ArraySize = unchecked(ArraySize);
        desc.Anonymous.Texture2DArray.PlaneSlice = PlaneSlice;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_UNORDERED_ACCESS_VIEW_DESC")]
    public static D3D12_UNORDERED_ACCESS_VIEW_DESC Tex2DMS(DXGI_FORMAT Format)
    {
        D3D12_UNORDERED_ACCESS_VIEW_DESC desc = new D3D12_UNORDERED_ACCESS_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_UAV_DIMENSION_TEXTURE2DMS;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_UNORDERED_ACCESS_VIEW_DESC")]
    public static D3D12_UNORDERED_ACCESS_VIEW_DESC Tex2DMSArray(DXGI_FORMAT Format, uint ArraySize = unchecked((uint)(-1)), uint FirstArraySlice = 0)
    {
        D3D12_UNORDERED_ACCESS_VIEW_DESC desc = new D3D12_UNORDERED_ACCESS_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_UAV_DIMENSION_TEXTURE2DMSARRAY;
        desc.Anonymous.Texture2DMSArray.FirstArraySlice = FirstArraySlice;
        desc.Anonymous.Texture2DMSArray.ArraySize = unchecked(ArraySize);
        return desc;
    }

    [return: NativeTypeName("CD3DX12_UNORDERED_ACCESS_VIEW_DESC")]
    public static D3D12_UNORDERED_ACCESS_VIEW_DESC Tex3D(DXGI_FORMAT Format, uint WSize = unchecked((uint)(-1)), uint FirstWSlice = 0, uint MipSlice = 0)
    {
        D3D12_UNORDERED_ACCESS_VIEW_DESC desc = new D3D12_UNORDERED_ACCESS_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_UAV_DIMENSION_TEXTURE3D;
        desc.Anonymous.Texture3D.MipSlice = MipSlice;
        desc.Anonymous.Texture3D.FirstWSlice = FirstWSlice;
        desc.Anonymous.Texture3D.WSize = unchecked(WSize);
        return desc;
    }
}
