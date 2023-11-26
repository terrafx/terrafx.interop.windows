// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

public static partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DX12GetBaseSubobjectType"]/*' />
    public static D3D12_PIPELINE_STATE_SUBOBJECT_TYPE D3DX12GetBaseSubobjectType(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE SubobjectType)
    {
        switch (SubobjectType)
        {
            case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1:
            {
                return D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL;
            }

            case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL2:
            {
                return D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL;
            }

            case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER1:
            {
                return D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER;
            }

            default:
            {
                return SubobjectType;
            }
        }
    }
}
