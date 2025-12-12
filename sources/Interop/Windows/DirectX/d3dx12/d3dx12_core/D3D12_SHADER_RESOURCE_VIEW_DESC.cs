// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_BUFFER_SRV_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_SRV_DIMENSION;
using static TerraFX.Interop.DirectX.DXGI_FORMAT;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SHADER_RESOURCE_VIEW_DESC.xml' path='doc/member[@name="D3D12_SHADER_RESOURCE_VIEW_DESC"]/*' />
[NativeTypeName("struct CD3DX12_SHADER_RESOURCE_VIEW_DESC : D3D12_SHADER_RESOURCE_VIEW_DESC")]
[NativeInheritance("D3D12_SHADER_RESOURCE_VIEW_DESC")]
public partial struct D3D12_SHADER_RESOURCE_VIEW_DESC
{

    [return: NativeTypeName("CD3DX12_SHADER_RESOURCE_VIEW_DESC")]
    public static D3D12_SHADER_RESOURCE_VIEW_DESC StructuredBuffer(uint NumElements, uint StructureByteStride, [NativeTypeName("UINT64")] ulong FirstElement = 0)
    {
        D3D12_SHADER_RESOURCE_VIEW_DESC desc = new D3D12_SHADER_RESOURCE_VIEW_DESC();

        desc.Format = DXGI_FORMAT_UNKNOWN;
        desc.ViewDimension = D3D12_SRV_DIMENSION_BUFFER;
        desc.Shader4ComponentMapping = ((((0) & 0x7) | (((1) & 0x7) << 3) | (((2) & 0x7) << (3 * 2)) | (((3) & 0x7) << (3 * 3)) | (1 << (3 * 4))));
        desc.Anonymous.Buffer.FirstElement = FirstElement;
        desc.Anonymous.Buffer.NumElements = NumElements;
        desc.Anonymous.Buffer.StructureByteStride = StructureByteStride;
        desc.Anonymous.Buffer.Flags = D3D12_BUFFER_SRV_FLAG_NONE;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_SHADER_RESOURCE_VIEW_DESC")]
    public static D3D12_SHADER_RESOURCE_VIEW_DESC RawBuffer(uint NumElements, [NativeTypeName("UINT64")] ulong FirstElement = 0)
    {
        D3D12_SHADER_RESOURCE_VIEW_DESC desc = new D3D12_SHADER_RESOURCE_VIEW_DESC();

        desc.Format = DXGI_FORMAT_R32_UINT;
        desc.ViewDimension = D3D12_SRV_DIMENSION_BUFFER;
        desc.Shader4ComponentMapping = ((((0) & 0x7) | (((1) & 0x7) << 3) | (((2) & 0x7) << (3 * 2)) | (((3) & 0x7) << (3 * 3)) | (1 << (3 * 4))));
        desc.Anonymous.Buffer.FirstElement = FirstElement;
        desc.Anonymous.Buffer.NumElements = NumElements;
        desc.Anonymous.Buffer.StructureByteStride = 0;
        desc.Anonymous.Buffer.Flags = D3D12_BUFFER_SRV_FLAG_RAW;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_SHADER_RESOURCE_VIEW_DESC")]
    public static D3D12_SHADER_RESOURCE_VIEW_DESC TypedBuffer(DXGI_FORMAT Format, uint NumElements, [NativeTypeName("UINT64")] ulong FirstElement = 0, uint Shader4ComponentMapping = ((((0) & 0x7) | (((1) & 0x7) << 3) | (((2) & 0x7) << (3 * 2)) | (((3) & 0x7) << (3 * 3)) | (1 << (3 * 4)))))
    {
        D3D12_SHADER_RESOURCE_VIEW_DESC desc = new D3D12_SHADER_RESOURCE_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_SRV_DIMENSION_BUFFER;
        desc.Shader4ComponentMapping = Shader4ComponentMapping;
        desc.Anonymous.Buffer.FirstElement = FirstElement;
        desc.Anonymous.Buffer.NumElements = NumElements;
        desc.Anonymous.Buffer.StructureByteStride = 0;
        desc.Anonymous.Buffer.Flags = D3D12_BUFFER_SRV_FLAG_NONE;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_SHADER_RESOURCE_VIEW_DESC")]
    public static D3D12_SHADER_RESOURCE_VIEW_DESC Tex1D(DXGI_FORMAT Format, uint MipLevels = unchecked((uint)(-1)), uint MostDetailedMip = 0, float ResourceMinLODClamp = 0.0f, uint Shader4ComponentMapping = ((((0) & 0x7) | (((1) & 0x7) << 3) | (((2) & 0x7) << (3 * 2)) | (((3) & 0x7) << (3 * 3)) | (1 << (3 * 4)))))
    {
        D3D12_SHADER_RESOURCE_VIEW_DESC desc = new D3D12_SHADER_RESOURCE_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_SRV_DIMENSION_TEXTURE1D;
        desc.Shader4ComponentMapping = Shader4ComponentMapping;
        desc.Anonymous.Texture1D.MostDetailedMip = MostDetailedMip;
        desc.Anonymous.Texture1D.MipLevels = unchecked(MipLevels);
        desc.Anonymous.Texture1D.ResourceMinLODClamp = ResourceMinLODClamp;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_SHADER_RESOURCE_VIEW_DESC")]
    public static D3D12_SHADER_RESOURCE_VIEW_DESC Tex1DArray(DXGI_FORMAT Format, uint ArraySize = unchecked((uint)(-1)), uint MipLevels = unchecked((uint)(-1)), uint FirstArraySlice = 0, uint MostDetailedMip = 0, float ResourceMinLODClamp = 0.0f, uint Shader4ComponentMapping = ((((0) & 0x7) | (((1) & 0x7) << 3) | (((2) & 0x7) << (3 * 2)) | (((3) & 0x7) << (3 * 3)) | (1 << (3 * 4)))))
    {
        D3D12_SHADER_RESOURCE_VIEW_DESC desc = new D3D12_SHADER_RESOURCE_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_SRV_DIMENSION_TEXTURE1DARRAY;
        desc.Shader4ComponentMapping = Shader4ComponentMapping;
        desc.Anonymous.Texture1DArray.MostDetailedMip = MostDetailedMip;
        desc.Anonymous.Texture1DArray.MipLevels = unchecked(MipLevels);
        desc.Anonymous.Texture1DArray.FirstArraySlice = FirstArraySlice;
        desc.Anonymous.Texture1DArray.ArraySize = unchecked(ArraySize);
        desc.Anonymous.Texture1DArray.ResourceMinLODClamp = ResourceMinLODClamp;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_SHADER_RESOURCE_VIEW_DESC")]
    public static D3D12_SHADER_RESOURCE_VIEW_DESC Tex2D(DXGI_FORMAT Format, uint MipLevels = unchecked((uint)(-1)), uint MostDetailedMip = 0, uint PlaneSlice = 0, float ResourceMinLODClamp = 0.0f, uint Shader4ComponentMapping = ((((0) & 0x7) | (((1) & 0x7) << 3) | (((2) & 0x7) << (3 * 2)) | (((3) & 0x7) << (3 * 3)) | (1 << (3 * 4)))))
    {
        D3D12_SHADER_RESOURCE_VIEW_DESC desc = new D3D12_SHADER_RESOURCE_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_SRV_DIMENSION_TEXTURE2D;
        desc.Shader4ComponentMapping = Shader4ComponentMapping;
        desc.Anonymous.Texture2D.MostDetailedMip = MostDetailedMip;
        desc.Anonymous.Texture2D.MipLevels = unchecked(MipLevels);
        desc.Anonymous.Texture2D.PlaneSlice = PlaneSlice;
        desc.Anonymous.Texture2D.ResourceMinLODClamp = ResourceMinLODClamp;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_SHADER_RESOURCE_VIEW_DESC")]
    public static D3D12_SHADER_RESOURCE_VIEW_DESC Tex2DArray(DXGI_FORMAT Format, uint ArraySize = unchecked((uint)(-1)), uint MipLevels = unchecked((uint)(-1)), uint FirstArraySlice = 0, uint MostDetailedMip = 0, uint PlaneSlice = 0, float ResourceMinLODClamp = 0.0f, uint Shader4ComponentMapping = ((((0) & 0x7) | (((1) & 0x7) << 3) | (((2) & 0x7) << (3 * 2)) | (((3) & 0x7) << (3 * 3)) | (1 << (3 * 4)))))
    {
        D3D12_SHADER_RESOURCE_VIEW_DESC desc = new D3D12_SHADER_RESOURCE_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_SRV_DIMENSION_TEXTURE2DARRAY;
        desc.Shader4ComponentMapping = Shader4ComponentMapping;
        desc.Anonymous.Texture2DArray.MostDetailedMip = MostDetailedMip;
        desc.Anonymous.Texture2DArray.MipLevels = unchecked(MipLevels);
        desc.Anonymous.Texture2DArray.FirstArraySlice = FirstArraySlice;
        desc.Anonymous.Texture2DArray.ArraySize = unchecked(ArraySize);
        desc.Anonymous.Texture2DArray.PlaneSlice = PlaneSlice;
        desc.Anonymous.Texture2DArray.ResourceMinLODClamp = ResourceMinLODClamp;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_SHADER_RESOURCE_VIEW_DESC")]
    public static D3D12_SHADER_RESOURCE_VIEW_DESC Tex2DMS(DXGI_FORMAT Format, uint Shader4ComponentMapping = ((((0) & 0x7) | (((1) & 0x7) << 3) | (((2) & 0x7) << (3 * 2)) | (((3) & 0x7) << (3 * 3)) | (1 << (3 * 4)))))
    {
        D3D12_SHADER_RESOURCE_VIEW_DESC desc = new D3D12_SHADER_RESOURCE_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_SRV_DIMENSION_TEXTURE2DMS;
        desc.Shader4ComponentMapping = Shader4ComponentMapping;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_SHADER_RESOURCE_VIEW_DESC")]
    public static D3D12_SHADER_RESOURCE_VIEW_DESC Tex2DMSArray(DXGI_FORMAT Format, uint ArraySize, uint FirstArraySlice = 0, uint Shader4ComponentMapping = ((((0) & 0x7) | (((1) & 0x7) << 3) | (((2) & 0x7) << (3 * 2)) | (((3) & 0x7) << (3 * 3)) | (1 << (3 * 4)))))
    {
        D3D12_SHADER_RESOURCE_VIEW_DESC desc = new D3D12_SHADER_RESOURCE_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_SRV_DIMENSION_TEXTURE2DMSARRAY;
        desc.Shader4ComponentMapping = Shader4ComponentMapping;
        desc.Anonymous.Texture2DMSArray.ArraySize = ArraySize;
        desc.Anonymous.Texture2DMSArray.FirstArraySlice = FirstArraySlice;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_SHADER_RESOURCE_VIEW_DESC")]
    public static D3D12_SHADER_RESOURCE_VIEW_DESC Tex3D(DXGI_FORMAT Format, uint MipLevels = unchecked((uint)(-1)), uint MostDetailedMip = 0, float ResourceMinLODClamp = 0.0f, uint Shader4ComponentMapping = ((((0) & 0x7) | (((1) & 0x7) << 3) | (((2) & 0x7) << (3 * 2)) | (((3) & 0x7) << (3 * 3)) | (1 << (3 * 4)))))
    {
        D3D12_SHADER_RESOURCE_VIEW_DESC desc = new D3D12_SHADER_RESOURCE_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_SRV_DIMENSION_TEXTURE3D;
        desc.Shader4ComponentMapping = Shader4ComponentMapping;
        desc.Anonymous.Texture3D.MostDetailedMip = MostDetailedMip;
        desc.Anonymous.Texture3D.MipLevels = unchecked(MipLevels);
        desc.Anonymous.Texture3D.ResourceMinLODClamp = ResourceMinLODClamp;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_SHADER_RESOURCE_VIEW_DESC")]
    public static D3D12_SHADER_RESOURCE_VIEW_DESC TexCube(DXGI_FORMAT Format, uint MipLevels = unchecked((uint)(-1)), uint MostDetailedMip = 0, float ResourceMinLODClamp = 0.0f, uint Shader4ComponentMapping = ((((0) & 0x7) | (((1) & 0x7) << 3) | (((2) & 0x7) << (3 * 2)) | (((3) & 0x7) << (3 * 3)) | (1 << (3 * 4)))))
    {
        D3D12_SHADER_RESOURCE_VIEW_DESC desc = new D3D12_SHADER_RESOURCE_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_SRV_DIMENSION_TEXTURECUBE;
        desc.Shader4ComponentMapping = Shader4ComponentMapping;
        desc.Anonymous.TextureCube.MostDetailedMip = MostDetailedMip;
        desc.Anonymous.TextureCube.MipLevels = unchecked(MipLevels);
        desc.Anonymous.TextureCube.ResourceMinLODClamp = ResourceMinLODClamp;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_SHADER_RESOURCE_VIEW_DESC")]
    public static D3D12_SHADER_RESOURCE_VIEW_DESC TexCubeArray(DXGI_FORMAT Format, uint NumCubes, uint MipLevels = unchecked((uint)(-1)), uint First2DArrayFace = 0, uint MostDetailedMip = 0, float ResourceMinLODClamp = 0.0f, uint Shader4ComponentMapping = ((((0) & 0x7) | (((1) & 0x7) << 3) | (((2) & 0x7) << (3 * 2)) | (((3) & 0x7) << (3 * 3)) | (1 << (3 * 4)))))
    {
        D3D12_SHADER_RESOURCE_VIEW_DESC desc = new D3D12_SHADER_RESOURCE_VIEW_DESC();

        desc.Format = Format;
        desc.ViewDimension = D3D12_SRV_DIMENSION_TEXTURECUBEARRAY;
        desc.Shader4ComponentMapping = Shader4ComponentMapping;
        desc.Anonymous.TextureCubeArray.NumCubes = NumCubes;
        desc.Anonymous.TextureCubeArray.MostDetailedMip = MostDetailedMip;
        desc.Anonymous.TextureCubeArray.MipLevels = unchecked(MipLevels);
        desc.Anonymous.TextureCubeArray.First2DArrayFace = First2DArrayFace;
        desc.Anonymous.TextureCubeArray.ResourceMinLODClamp = ResourceMinLODClamp;
        return desc;
    }

    [return: NativeTypeName("CD3DX12_SHADER_RESOURCE_VIEW_DESC")]
    public static D3D12_SHADER_RESOURCE_VIEW_DESC RaytracingAccelStruct([NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong Location)
    {
        D3D12_SHADER_RESOURCE_VIEW_DESC desc = new D3D12_SHADER_RESOURCE_VIEW_DESC();

        desc.Format = DXGI_FORMAT_UNKNOWN;
        desc.ViewDimension = D3D12_SRV_DIMENSION_RAYTRACING_ACCELERATION_STRUCTURE;
        desc.Shader4ComponentMapping = ((((0) & 0x7) | (((1) & 0x7) << 3) | (((2) & 0x7) << (3 * 2)) | (((3) & 0x7) << (3 * 3)) | (1 << (3 * 4))));
        desc.Anonymous.RaytracingAccelerationStructure.Location = Location;
        return desc;
    }
}
