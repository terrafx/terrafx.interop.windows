// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.DirectX.D3D12;
using static TerraFX.Interop.DirectX.D3D12_FEATURE;
using static TerraFX.Interop.DirectX.D3D12_RESOURCE_DIMENSION;
using static TerraFX.Interop.DirectX.D3D12_RESOURCE_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_TEXTURE_LAYOUT;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    public static ID3D12CommandList** CommandListCast<t_CommandListType>(t_CommandListType** pp)
        where t_CommandListType : unmanaged, ID3D12CommandList.Interface
    {
        return (ID3D12CommandList**)(pp);
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12GetFormatPlaneCount"]/*' />
    [return: NativeTypeName("UINT8")]
    public static byte D3D12GetFormatPlaneCount(ID3D12Device* pDevice, DXGI_FORMAT Format)
    {
        D3D12_FEATURE_DATA_FORMAT_INFO formatInfo = new()
        {
            Format = Format,
            PlaneCount = 0,
        };
        ID3D12Device16* pDevice16 = null;
        Guid device16IID = typeof(ID3D12Device16).GUID;

        if (pDevice->QueryInterface(&device16IID, (void**)(&pDevice16)) >= 0)
        {
            HRESULT hr = pDevice16->CheckFeatureSupport1(D3D12_FEATURE_FORMAT_INFO, &formatInfo, (uint)sizeof(D3D12_FEATURE_DATA_FORMAT_INFO), D3D12_SDK_VERSION);
            _ = pDevice16->Release();

            if (hr < 0)
            {
                return 0;
            }

            return formatInfo.PlaneCount;
        }

        if (pDevice->CheckFeatureSupport(D3D12_FEATURE_FORMAT_INFO, &formatInfo, (uint)sizeof(D3D12_FEATURE_DATA_FORMAT_INFO)) < 0)
        {
            return 0;
        }

        return formatInfo.PlaneCount;
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DX12ConditionallyExpandAPIDesc"]/*' />
    [return: NativeTypeName("const CD3DX12_RESOURCE_DESC1 *")]
    public static ref readonly D3D12_RESOURCE_DESC1 D3DX12ConditionallyExpandAPIDesc([NativeTypeName("CD3DX12_RESOURCE_DESC1 &")] ref D3D12_RESOURCE_DESC1 LclDesc, [NativeTypeName("const CD3DX12_RESOURCE_DESC1 *")] in D3D12_RESOURCE_DESC1 pDesc, [NativeTypeName("const bool")] bool tightAlignmentSupported = false, [NativeTypeName("const bool")] bool alignAsCommitted = false)
    {
        bool recomputeAlignment = (pDesc.Alignment == 0)
            || (tightAlignmentSupported && ((pDesc.Flags & D3D12_RESOURCE_FLAG_USE_TIGHT_ALIGNMENT) != 0));

        if ((pDesc.MipLevels == 0) || recomputeAlignment)
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

            if (recomputeAlignment)
            {
                if ((pDesc.Layout == D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE) || (pDesc.Layout == D3D12_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE))
                {
                    LclDesc.Alignment = (ulong)D3D12_DEFAULT_RESOURCE_PLACEMENT_ALIGNMENT;
                }
                else if (!(tightAlignmentSupported && ((pDesc.Flags & D3D12_RESOURCE_FLAG_USE_TIGHT_ALIGNMENT) != 0)) || ((pDesc.Flags & D3D12_RESOURCE_FLAG_ALLOW_CROSS_ADAPTER) != 0))
                {
                    LclDesc.Alignment = (pDesc.SampleDesc.Count > 1) ? (ulong)(D3D12_DEFAULT_MSAA_RESOURCE_PLACEMENT_ALIGNMENT) : (ulong)(D3D12_DEFAULT_RESOURCE_PLACEMENT_ALIGNMENT);
                }
                else
                {
                    ulong runtimeMin = (ulong)(alignAsCommitted ? D3D12_TIGHT_ALIGNMENT_MIN_COMMITTED_RESOURCE_ALIGNMENT : D3D12_TIGHT_ALIGNMENT_MIN_PLACED_RESOURCE_ALIGNMENT);
                    ulong specMax = (pDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER)
                        ? (alignAsCommitted ? (ulong)D3D12_TIGHT_ALIGNMENT_MAX_COMMITTED_BUFFER_ALIGNMENT : (ulong)D3D12_TIGHT_ALIGNMENT_MAX_PLACED_BUFFER_ALIGNMENT)
                        : (ulong)(pDesc.SampleDesc.Count > 1 ? D3D12_DEFAULT_MSAA_RESOURCE_PLACEMENT_ALIGNMENT : D3D12_DEFAULT_RESOURCE_PLACEMENT_ALIGNMENT);
                    ulong appAlignment = pDesc.Alignment;
                    bool appAlignmentIsValidFloor = appAlignment != 0 && (appAlignment & (appAlignment - 1)) == 0 && appAlignment <= specMax;
                    LclDesc.Alignment = appAlignmentIsValidFloor ? ulong.Max(appAlignment, runtimeMin) : runtimeMin;
                }
            }

            return ref LclDesc;
        }
        else
        {
            return ref pDesc;
        }
    }

    [return: NativeTypeName("const CD3DX12_RESOURCE_DESC2 *")]
    public static ref readonly D3D12_RESOURCE_DESC2 D3DX12ConditionallyExpandAPIDesc([NativeTypeName("CD3DX12_RESOURCE_DESC2 &")] ref D3D12_RESOURCE_DESC2 LclDesc, [NativeTypeName("const CD3DX12_RESOURCE_DESC2 *")] in D3D12_RESOURCE_DESC2 pDesc, [NativeTypeName("const bool")] bool tightAlignmentSupported = false, [NativeTypeName("const bool")] bool alignAsCommitted = false)
    {
        bool recomputeAlignment = (pDesc.Alignment == 0)
            || (tightAlignmentSupported && ((pDesc.Flags & D3D12_RESOURCE_FLAG_USE_TIGHT_ALIGNMENT) != 0));

        if ((pDesc.MipLevels == 0) || recomputeAlignment)
        {
            LclDesc = pDesc;

            if (pDesc.MipLevels == 0)
            {
                ulong maxDimension = ulong.Max((LclDesc.Dimension == D3D12_RESOURCE_DIMENSION_TEXTURE3D) ? LclDesc.DepthOrArraySize : 1UL, ulong.Max(LclDesc.Width, LclDesc.Height));
                ushort mipLevels = 0;

                while (maxDimension > 0)
                {
                    mipLevels++;
                    maxDimension >>= 1;
                }

                LclDesc.MipLevels = mipLevels;
            }

            if (recomputeAlignment)
            {
                if ((pDesc.Layout == D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE) || (pDesc.Layout == D3D12_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE))
                {
                    LclDesc.Alignment = (ulong)D3D12_DEFAULT_RESOURCE_PLACEMENT_ALIGNMENT;
                }
                else if (!(tightAlignmentSupported && ((pDesc.Flags & D3D12_RESOURCE_FLAG_USE_TIGHT_ALIGNMENT) != 0)) || ((pDesc.Flags & D3D12_RESOURCE_FLAG_ALLOW_CROSS_ADAPTER) != 0))
                {
                    LclDesc.Alignment = (ulong)(pDesc.SampleDesc.Count > 1 ? D3D12_DEFAULT_MSAA_RESOURCE_PLACEMENT_ALIGNMENT : D3D12_DEFAULT_RESOURCE_PLACEMENT_ALIGNMENT);
                }
                else
                {
                    ulong runtimeMin = (ulong)(alignAsCommitted ? D3D12_TIGHT_ALIGNMENT_MIN_COMMITTED_RESOURCE_ALIGNMENT : D3D12_TIGHT_ALIGNMENT_MIN_PLACED_RESOURCE_ALIGNMENT);
                    ulong specMax = (pDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER)
                        ? (alignAsCommitted ? (ulong)D3D12_TIGHT_ALIGNMENT_MAX_COMMITTED_BUFFER_ALIGNMENT : (ulong)D3D12_TIGHT_ALIGNMENT_MAX_PLACED_BUFFER_ALIGNMENT)
                        : (ulong)(pDesc.SampleDesc.Count > 1 ? D3D12_DEFAULT_MSAA_RESOURCE_PLACEMENT_ALIGNMENT : D3D12_DEFAULT_RESOURCE_PLACEMENT_ALIGNMENT);
                    ulong appAlignment = pDesc.Alignment;
                    bool appAlignmentIsValidFloor = appAlignment != 0 && (appAlignment & (appAlignment - 1)) == 0 && appAlignment <= specMax;
                    LclDesc.Alignment = appAlignmentIsValidFloor ? ulong.Max(appAlignment, runtimeMin) : runtimeMin;
                }
            }

            return ref LclDesc;
        }

        return ref pDesc;
    }
}
