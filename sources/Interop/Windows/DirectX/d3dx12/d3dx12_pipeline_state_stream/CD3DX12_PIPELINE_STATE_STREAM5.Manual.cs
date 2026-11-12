// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

// Use CD3DX12_PIPELINE_STATE_STREAM5 for D3D12_RASTERIZER_DESC2 when CheckFeatureSupport returns true for Options19::RasterizerDesc2Supported is true
public unsafe struct CD3DX12_PIPELINE_STATE_STREAM5
{
    public CD3DX12_PIPELINE_STATE_STREAM5()
    {
    }

    public CD3DX12_PIPELINE_STATE_STREAM_FLAGS Flags = new CD3DX12_PIPELINE_STATE_STREAM_FLAGS();

    public CD3DX12_PIPELINE_STATE_STREAM_NODE_MASK NodeMask = new CD3DX12_PIPELINE_STATE_STREAM_NODE_MASK();

    public CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE pRootSignature = new CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE();

    public CD3DX12_PIPELINE_STATE_STREAM_INPUT_LAYOUT InputLayout = new CD3DX12_PIPELINE_STATE_STREAM_INPUT_LAYOUT();

    public CD3DX12_PIPELINE_STATE_STREAM_IB_STRIP_CUT_VALUE IBStripCutValue = new CD3DX12_PIPELINE_STATE_STREAM_IB_STRIP_CUT_VALUE();

    public CD3DX12_PIPELINE_STATE_STREAM_PRIMITIVE_TOPOLOGY PrimitiveTopologyType = new CD3DX12_PIPELINE_STATE_STREAM_PRIMITIVE_TOPOLOGY();

    public CD3DX12_PIPELINE_STATE_STREAM_VS VS = new CD3DX12_PIPELINE_STATE_STREAM_VS();

    public CD3DX12_PIPELINE_STATE_STREAM_GS GS = new CD3DX12_PIPELINE_STATE_STREAM_GS();

    public CD3DX12_PIPELINE_STATE_STREAM_STREAM_OUTPUT StreamOutput = new CD3DX12_PIPELINE_STATE_STREAM_STREAM_OUTPUT();

    public CD3DX12_PIPELINE_STATE_STREAM_HS HS = new CD3DX12_PIPELINE_STATE_STREAM_HS();

    public CD3DX12_PIPELINE_STATE_STREAM_DS DS = new CD3DX12_PIPELINE_STATE_STREAM_DS();

    public CD3DX12_PIPELINE_STATE_STREAM_PS PS = new CD3DX12_PIPELINE_STATE_STREAM_PS();

    public CD3DX12_PIPELINE_STATE_STREAM_AS AS = new CD3DX12_PIPELINE_STATE_STREAM_AS();

    public CD3DX12_PIPELINE_STATE_STREAM_MS MS = new CD3DX12_PIPELINE_STATE_STREAM_MS();

    public CD3DX12_PIPELINE_STATE_STREAM_CS CS = new CD3DX12_PIPELINE_STATE_STREAM_CS();

    public CD3DX12_PIPELINE_STATE_STREAM_BLEND_DESC BlendState = new CD3DX12_PIPELINE_STATE_STREAM_BLEND_DESC();

    public CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL2 DepthStencilState = new CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL2();

    public CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL_FORMAT DSVFormat = new CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL_FORMAT();

    public CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER2 RasterizerState = new CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER2();

    public CD3DX12_PIPELINE_STATE_STREAM_RENDER_TARGET_FORMATS RTVFormats = new CD3DX12_PIPELINE_STATE_STREAM_RENDER_TARGET_FORMATS();

    public CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC SampleDesc = new CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC();

    public CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_MASK SampleMask = new CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_MASK();

    public CD3DX12_PIPELINE_STATE_STREAM_CACHED_PSO CachedPSO = new CD3DX12_PIPELINE_STATE_STREAM_CACHED_PSO();

    public CD3DX12_PIPELINE_STATE_STREAM_VIEW_INSTANCING ViewInstancingDesc = new CD3DX12_PIPELINE_STATE_STREAM_VIEW_INSTANCING();

    // Mesh and amplification shaders must be set manually, since they do not have representation in D3D12_GRAPHICS_PIPELINE_STATE_DESC
    public CD3DX12_PIPELINE_STATE_STREAM5([NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC &")] in D3D12_GRAPHICS_PIPELINE_STATE_DESC Desc)
    {
        Flags = Desc.Flags;
        NodeMask = Desc.NodeMask;
        pRootSignature = Desc.pRootSignature;
        InputLayout = Desc.InputLayout;
        IBStripCutValue = Desc.IBStripCutValue;
        PrimitiveTopologyType = Desc.PrimitiveTopologyType;
        VS = Desc.VS;
        GS = Desc.GS;
        StreamOutput = Desc.StreamOutput;
        HS = Desc.HS;
        DS = Desc.DS;
        PS = Desc.PS;
        BlendState = Desc.BlendState;
        DepthStencilState = new D3D12_DEPTH_STENCIL_DESC2(in Desc.DepthStencilState);
        DSVFormat = Desc.DSVFormat;
        RasterizerState = new D3D12_RASTERIZER_DESC2(in Desc.RasterizerState);

        fixed (DXGI_FORMAT* pFormats = &Desc.RTVFormats[0])
        {
            RTVFormats = new D3D12_RT_FORMAT_ARRAY(pFormats, Desc.NumRenderTargets);
        }

        SampleDesc = Desc.SampleDesc;
        SampleMask = Desc.SampleMask;
        CachedPSO = Desc.CachedPSO;
        ViewInstancingDesc = D3D12_VIEW_INSTANCING_DESC.DEFAULT;
    }

    public CD3DX12_PIPELINE_STATE_STREAM5([NativeTypeName("const D3DX12_MESH_SHADER_PIPELINE_STATE_DESC &")] in D3DX12_MESH_SHADER_PIPELINE_STATE_DESC Desc)
    {
        Flags = Desc.Flags;
        NodeMask = Desc.NodeMask;
        pRootSignature = Desc.pRootSignature;
        PrimitiveTopologyType = Desc.PrimitiveTopologyType;
        PS = Desc.PS;
        AS = Desc.AS;
        MS = Desc.MS;
        BlendState = Desc.BlendState;
        DepthStencilState = new D3D12_DEPTH_STENCIL_DESC2(in Desc.DepthStencilState);
        DSVFormat = Desc.DSVFormat;
        RasterizerState = new D3D12_RASTERIZER_DESC2(Desc.RasterizerState);

        fixed (DXGI_FORMAT* pFormats = &Desc.RTVFormats[0])
        {
            RTVFormats = new D3D12_RT_FORMAT_ARRAY(pFormats, Desc.NumRenderTargets);
        }

        SampleDesc = Desc.SampleDesc;
        SampleMask = Desc.SampleMask;
        CachedPSO = Desc.CachedPSO;
        ViewInstancingDesc = D3D12_VIEW_INSTANCING_DESC.DEFAULT;
    }

    public CD3DX12_PIPELINE_STATE_STREAM5([NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC &")] in D3D12_COMPUTE_PIPELINE_STATE_DESC Desc)
    {
        Flags = Desc.Flags;
        NodeMask = Desc.NodeMask;
        pRootSignature = Desc.pRootSignature;
        CS = Desc.CS;
        CachedPSO = Desc.CachedPSO;
        DepthStencilState.pssInner.DepthEnable = false;
    }

    public readonly D3D12_GRAPHICS_PIPELINE_STATE_DESC GraphicsDescV0()
    {
        D3D12_GRAPHICS_PIPELINE_STATE_DESC D = new D3D12_GRAPHICS_PIPELINE_STATE_DESC {
            Flags = Flags,
            NodeMask = NodeMask,
            pRootSignature = pRootSignature,
            InputLayout = InputLayout,
            IBStripCutValue = IBStripCutValue,
            PrimitiveTopologyType = PrimitiveTopologyType,
            VS = VS,
            GS = GS,
            StreamOutput = StreamOutput,
            HS = HS,
            DS = DS,
            PS = PS,
            BlendState = BlendState,
            DepthStencilState = (D3D12_DEPTH_STENCIL_DESC)(DepthStencilState.pssInner),
            DSVFormat = DSVFormat,
            RasterizerState = (D3D12_RASTERIZER_DESC)(RasterizerState.pssInner),
            NumRenderTargets = RTVFormats.pssInner.NumRenderTargets,
            SampleDesc = SampleDesc,
            SampleMask = SampleMask,
            CachedPSO = CachedPSO,
        };

        fixed (DXGI_FORMAT* pFormat = &RTVFormats.pssInner.RTFormats[0])
        {
            NativeMemory.Copy(pFormat, &D.RTVFormats[0], 8 * sizeof(DXGI_FORMAT));
        }

        return D;
    }

    public readonly D3D12_COMPUTE_PIPELINE_STATE_DESC ComputeDescV0() => new D3D12_COMPUTE_PIPELINE_STATE_DESC {
        Flags = Flags,
        NodeMask = NodeMask,
        pRootSignature = pRootSignature,
        CS = CS,
        CachedPSO = CachedPSO,
    };
}
