// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12;
using static TerraFX.Interop.DirectX.D3D12_RESOURCE_DIMENSION;
using static TerraFX.Interop.DirectX.D3D12_TEXTURE_LAYOUT;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    public static ID3D12CommandList** CommandListCast<t_CommandListType>(t_CommandListType** pp)
        where t_CommandListType : unmanaged, ID3D12CommandList.Interface
    {
        return (ID3D12CommandList**)(pp);
    }

    [return: NativeTypeName("const CD3DX12_RESOURCE_DESC1 *")]
    public static ref readonly D3D12_RESOURCE_DESC1 D3DX12ConditionallyExpandAPIDesc([NativeTypeName("CD3DX12_RESOURCE_DESC1 &")] ref D3D12_RESOURCE_DESC1 LclDesc, [NativeTypeName("const CD3DX12_RESOURCE_DESC1 *")] in D3D12_RESOURCE_DESC1 pDesc)
    {
        if ((pDesc.MipLevels == 0) || (pDesc.Alignment == 0))
        {
            LclDesc = pDesc;

            if (pDesc.MipLevels == 0)
            {
                ulong uiMaxDimension = ulong.Max((LclDesc.Dimension == D3D12_RESOURCE_DIMENSION_TEXTURE3D) ? LclDesc.DepthOrArraySize : 1UL, ulong.Max(LclDesc.Width, LclDesc.Height));

                ushort uiRet = 0;

                while (uiMaxDimension > 0)
                {
                    uiRet++;
                    uiMaxDimension >>= 1;
                }

                LclDesc.MipLevels = uiRet;
            }

            if (pDesc.Alignment == 0)
            {
                if ((pDesc.Layout == D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE) || (pDesc.Layout == D3D12_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE))
                {
                    LclDesc.Alignment = D3D12_DEFAULT_RESOURCE_PLACEMENT_ALIGNMENT;
                }
                else
                {
                    LclDesc.Alignment = (pDesc.SampleDesc.Count > 1) ? (ulong)(D3D12_DEFAULT_MSAA_RESOURCE_PLACEMENT_ALIGNMENT) : (ulong)(D3D12_DEFAULT_RESOURCE_PLACEMENT_ALIGNMENT);
                }
            }

            return ref LclDesc;
        }
        else
        {
            return ref pDesc;
        }
    }
}
