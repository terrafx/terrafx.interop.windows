// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in the microsoft/DirectX-Graphics-Samples tag v10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using static TerraFX.Interop.D3D12_FEATURE;
using static TerraFX.Interop.D3D12_RESOURCE_DIMENSION;
using static TerraFX.Interop.D3D12_TEXTURE_LAYOUT;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static uint D3D12CalcSubresource(uint MipSlice, uint ArraySlice, uint PlaneSlice, uint MipLevels, uint ArraySize)
        {
            return MipSlice + ArraySlice * MipLevels + PlaneSlice * MipLevels * ArraySize;
        }

        [return: NativeTypeName("UINT8")]
        public static byte D3D12GetFormatPlaneCount(ID3D12Device* pDevice, DXGI_FORMAT Format)
        {
            D3D12_FEATURE_DATA_FORMAT_INFO formatInfo = new D3D12_FEATURE_DATA_FORMAT_INFO
            {
                Format = Format,
                PlaneCount = 0,
            };

            if ((((HRESULT)(pDevice->CheckFeatureSupport(D3D12_FEATURE_FORMAT_INFO, &formatInfo, (uint)(sizeof(D3D12_FEATURE_DATA_FORMAT_INFO))))) < 0))
            {
                return 0;
            }

            return formatInfo.PlaneCount;
        }

        [return: NativeTypeName("UINT64")]
        public static ulong UpdateSubresources(ID3D12GraphicsCommandList* pCmdList, ID3D12Resource* pDestinationResource, ID3D12Resource* pIntermediate, uint FirstSubresource, uint NumSubresources, [NativeTypeName("UINT64")] ulong RequiredSize, [NativeTypeName("const D3D12_PLACED_SUBRESOURCE_FOOTPRINT *")] D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts, [NativeTypeName("const UINT *")] uint* pNumRows, [NativeTypeName("const UINT64 *")] ulong* pRowSizesInBytes, [NativeTypeName("const D3D12_SUBRESOURCE_DATA *")] D3D12_SUBRESOURCE_DATA* pSrcData)
        {
            D3D12_RESOURCE_DESC IntermediateDesc = pIntermediate->GetDesc();
            D3D12_RESOURCE_DESC DestinationDesc = pDestinationResource->GetDesc();

            if (unchecked(IntermediateDesc.Dimension != D3D12_RESOURCE_DIMENSION_BUFFER || IntermediateDesc.Width < RequiredSize + pLayouts[0].Offset || RequiredSize > (nuint)(-1)) || (DestinationDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER && (FirstSubresource != 0 || NumSubresources != 1)))
            {
                return 0;
            }

            byte* pData;
            HRESULT hr = pIntermediate->Map(0, null, (void**)(&pData));

            if ((((HRESULT)(hr)) < 0))
            {
                return 0;
            }

            for (uint i = 0; i < NumSubresources; ++i)
            {
                if (pRowSizesInBytes[i] > unchecked((nuint)(-1)))
                {
                    return 0;
                }

                D3D12_MEMCPY_DEST DestData = new D3D12_MEMCPY_DEST
                {
                    pData = pData + pLayouts[i].Offset,
                    RowPitch = pLayouts[i].Footprint.RowPitch,
                    SlicePitch = unchecked((nuint)(pLayouts[i].Footprint.RowPitch) * (nuint)(pNumRows[i])),
                };

                MemcpySubresource(&DestData, &pSrcData[i], unchecked((nuint)(pRowSizesInBytes[i])), pNumRows[i], pLayouts[i].Footprint.Depth);
            }

            pIntermediate->Unmap(0, null);
            if (DestinationDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER)
            {
                pCmdList->CopyBufferRegion(pDestinationResource, 0, pIntermediate, pLayouts[0].Offset, pLayouts[0].Footprint.Width);
            }
            else
            {
                for (uint i = 0; i < NumSubresources; ++i)
                {
                    D3D12_TEXTURE_COPY_LOCATION Dst = new D3D12_TEXTURE_COPY_LOCATION(pDestinationResource, i + FirstSubresource);
                    D3D12_TEXTURE_COPY_LOCATION Src = new D3D12_TEXTURE_COPY_LOCATION(pIntermediate, pLayouts[i]);

                    pCmdList->CopyTextureRegion(&Dst, 0, 0, 0, &Src, null);
                }
            }

            return RequiredSize;
        }

        public static bool D3D12IsLayoutOpaque(D3D12_TEXTURE_LAYOUT Layout)
        {
            return Layout == D3D12_TEXTURE_LAYOUT_UNKNOWN || Layout == D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE;
        }
    }
}
