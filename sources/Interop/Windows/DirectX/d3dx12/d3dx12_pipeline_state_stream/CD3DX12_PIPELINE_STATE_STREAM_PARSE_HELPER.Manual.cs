// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.DirectX.D3D12_PRIMITIVE_TOPOLOGY_TYPE;
using static TerraFX.Interop.DirectX.DXGI_FORMAT;

namespace TerraFX.Interop.DirectX;

public unsafe struct CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER : ID3DX12PipelineParserCallbacks.Interface
{
    internal static readonly void** VtblInstance = InitVtblInstance();

    public void** lpVtbl;

    public CD3DX12_PIPELINE_STATE_STREAM1 PipelineStream;

    private bool SeenDSS;

    private static void** InitVtblInstance()
    {
        void** lpVtbl = (void**)(RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER), 32 * sizeof(void*)));

        lpVtbl[0] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_PIPELINE_STATE_FLAGS, void>)(&FlagsCb);
        lpVtbl[1] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, uint, void>)(&NodeMaskCb);
        lpVtbl[2] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, ID3D12RootSignature*, void>)(&RootSignatureCb);
        lpVtbl[3] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_INPUT_LAYOUT_DESC*, void>)(&InputLayoutCb);
        lpVtbl[4] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_INDEX_BUFFER_STRIP_CUT_VALUE, void>)(&IBStripCutValueCb);
        lpVtbl[5] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_PRIMITIVE_TOPOLOGY_TYPE, void>)(&PrimitiveTopologyTypeCb);
        lpVtbl[6] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_SHADER_BYTECODE*, void>)(&VSCb);
        lpVtbl[7] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_SHADER_BYTECODE*, void>)(&GSCb);
        lpVtbl[8] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_STREAM_OUTPUT_DESC*, void>)(&StreamOutputCb);
        lpVtbl[9] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_SHADER_BYTECODE*, void>)(&HSCb);
        lpVtbl[10] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_SHADER_BYTECODE*, void>)(&DSCb);
        lpVtbl[11] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_SHADER_BYTECODE*, void>)(&PSCb);
        lpVtbl[12] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_SHADER_BYTECODE*, void>)(&CSCb);
        lpVtbl[13] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_SHADER_BYTECODE*, void>)(&ASCb);
        lpVtbl[14] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_SHADER_BYTECODE*, void>)(&MSCb);
        lpVtbl[15] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_BLEND_DESC*, void>)(&BlendStateCb);
        lpVtbl[16] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_DEPTH_STENCIL_DESC*, void>)(&DepthStencilStateCb);
        lpVtbl[17] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_DEPTH_STENCIL_DESC1*, void>)(&DepthStencilState1Cb);
        lpVtbl[18] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_DEPTH_STENCIL_DESC2*, void>)(&DepthStencilState2Cb);
        lpVtbl[19] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, DXGI_FORMAT, void>)(&DSVFormatCb);
        lpVtbl[20] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_RASTERIZER_DESC*, void>)(&RasterizerStateCb);
        lpVtbl[21] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_RASTERIZER_DESC1*, void>)(&RasterizerState1Cb);
        lpVtbl[22] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_RASTERIZER_DESC2*, void>)(&RasterizerState2Cb);
        lpVtbl[23] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_RT_FORMAT_ARRAY*, void>)(&RTVFormatsCb);
        lpVtbl[24] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, DXGI_SAMPLE_DESC*, void>)(&SampleDescCb);
        lpVtbl[25] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, uint, void>)(&SampleMaskCb);
        lpVtbl[26] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_VIEW_INSTANCING_DESC*, void>)(&ViewInstancingCb);
        lpVtbl[27] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_CACHED_PIPELINE_STATE*, void>)(&CachedPSOCb);
        lpVtbl[28] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, uint, void>)(&ErrorBadInputParameter);
        lpVtbl[29] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_PIPELINE_STATE_SUBOBJECT_TYPE, void>)(&ErrorDuplicateSubobject);
        lpVtbl[30] = (delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, uint, void>)(&ErrorUnknownSubobject);
        lpVtbl[31] = (delegate* unmanaged[MemberFunction]< CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER *, void>)(&Dispose);

        return lpVtbl;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER()
    {
        lpVtbl = VtblInstance;

        // Adjust defaults to account for absent members.
        PipelineStream.PrimitiveTopologyType = D3D12_PRIMITIVE_TOPOLOGY_TYPE_TRIANGLE;

        // Depth disabled if no DSV format specified.
        PipelineStream.DepthStencilState.pssInner.DepthEnable = false;
    }

    [VtblIndex(0)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void FlagsCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, D3D12_PIPELINE_STATE_FLAGS Flags)
    {
        pThis->PipelineStream.Flags = Flags;
    }

    [VtblIndex(1)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void NodeMaskCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, uint NodeMask)
    {
        pThis->PipelineStream.NodeMask = NodeMask;
    }

    [VtblIndex(2)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void RootSignatureCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, ID3D12RootSignature* pRootSignature)
    {
        pThis->PipelineStream.pRootSignature = pRootSignature;
    }

    [VtblIndex(3)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void InputLayoutCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_INPUT_LAYOUT_DESC &")] D3D12_INPUT_LAYOUT_DESC* InputLayout)
    {
        pThis->PipelineStream.InputLayout = *InputLayout;
    }

    [VtblIndex(4)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void IBStripCutValueCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IBStripCutValue)
    {
        pThis->PipelineStream.IBStripCutValue = IBStripCutValue;
    }

    [VtblIndex(5)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void PrimitiveTopologyTypeCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, D3D12_PRIMITIVE_TOPOLOGY_TYPE PrimitiveTopologyType)
    {
        pThis->PipelineStream.PrimitiveTopologyType = PrimitiveTopologyType;
    }

    [VtblIndex(6)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void VSCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* VS)
    {
        pThis->PipelineStream.VS = *VS;
    }

    [VtblIndex(7)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void GSCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* GS)
    {
        pThis->PipelineStream.GS = *GS;
    }

    [VtblIndex(8)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void StreamOutputCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_STREAM_OUTPUT_DESC &")] D3D12_STREAM_OUTPUT_DESC* StreamOutput)
    {
        pThis->PipelineStream.StreamOutput = *StreamOutput;
    }

    [VtblIndex(9)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void HSCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* HS)
    {
        pThis->PipelineStream.HS = *HS;
    }

    [VtblIndex(10)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void DSCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* DS)
    {
        pThis->PipelineStream.DS = *DS;
    }

    [VtblIndex(11)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void PSCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* PS)
    {
        pThis->PipelineStream.PS = *PS;
    }

    [VtblIndex(12)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void CSCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* CS)
    {
        pThis->PipelineStream.CS = *CS;
    }

    [VtblIndex(13)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void ASCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* AS)
    {
    }

    [VtblIndex(14)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void MSCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* MS)
    {
    }

    [VtblIndex(15)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void BlendStateCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_BLEND_DESC &")] D3D12_BLEND_DESC* BlendState)
    {
        pThis->PipelineStream.BlendState = *BlendState;
    }

    [VtblIndex(16)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void DepthStencilStateCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] D3D12_DEPTH_STENCIL_DESC* DepthStencilState)
    {
        pThis->PipelineStream.DepthStencilState = new D3D12_DEPTH_STENCIL_DESC1(DepthStencilState);
        pThis->SeenDSS = true;
    }

    [VtblIndex(17)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void DepthStencilState1Cb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_DEPTH_STENCIL_DESC1 &")] D3D12_DEPTH_STENCIL_DESC1* DepthStencilState)
    {
        pThis->PipelineStream.DepthStencilState = *DepthStencilState;
        pThis->SeenDSS = true;
    }

    [VtblIndex(18)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void DepthStencilState2Cb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_DEPTH_STENCIL_DESC2 &")] D3D12_DEPTH_STENCIL_DESC2* DepthStencilState)
    {
    }

    [VtblIndex(19)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void DSVFormatCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, DXGI_FORMAT DSVFormat)
    {
        pThis->PipelineStream.DSVFormat = DSVFormat;
        if (!pThis->SeenDSS && (DSVFormat != DXGI_FORMAT_UNKNOWN))
        {
            // Re-enable depth for the default state.
            pThis->PipelineStream.DepthStencilState.pssInner.DepthEnable = true;
        }
    }

    [VtblIndex(20)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void RasterizerStateCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_RASTERIZER_DESC &")] D3D12_RASTERIZER_DESC* RasterizerState)
    {
        pThis->PipelineStream.RasterizerState = *RasterizerState;
    }

    [VtblIndex(21)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void RasterizerState1Cb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_RASTERIZER_DESC1 &")] D3D12_RASTERIZER_DESC1* RasterizerState)
    {
    }

    [VtblIndex(22)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void RasterizerState2Cb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_RASTERIZER_DESC2 &")] D3D12_RASTERIZER_DESC2* RasterizerState)
    {
    }

    [VtblIndex(23)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void RTVFormatsCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_RT_FORMAT_ARRAY &")] D3D12_RT_FORMAT_ARRAY* RTVFormats)
    {
        pThis->PipelineStream.RTVFormats = *RTVFormats;
    }

    [VtblIndex(24)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void SampleDescCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const DXGI_SAMPLE_DESC &")] DXGI_SAMPLE_DESC* SampleDesc)
    {
        pThis->PipelineStream.SampleDesc = *SampleDesc;
    }

    [VtblIndex(25)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void SampleMaskCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, uint SampleMask)
    {
        pThis->PipelineStream.SampleMask = SampleMask;
    }

    [VtblIndex(26)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void ViewInstancingCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_VIEW_INSTANCING_DESC &")] D3D12_VIEW_INSTANCING_DESC* ViewInstancingDesc)
    {
        pThis->PipelineStream.ViewInstancingDesc = *ViewInstancingDesc;
    }

    [VtblIndex(27)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void CachedPSOCb(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, [NativeTypeName("const D3D12_CACHED_PIPELINE_STATE &")] D3D12_CACHED_PIPELINE_STATE* CachedPSO)
    {
        pThis->PipelineStream.CachedPSO = *CachedPSO;
    }

    [VtblIndex(28)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void ErrorBadInputParameter(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, uint ParameterIndex)
    {
    }

    [VtblIndex(29)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void ErrorDuplicateSubobject(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, D3D12_PIPELINE_STATE_SUBOBJECT_TYPE DuplicateType)
    {
    }

    [VtblIndex(30)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void ErrorUnknownSubobject(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis, uint UnknownTypeValue)
    {
    }

    [VtblIndex(31)]
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvMemberFunction)])]
    public static void Dispose(CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER* pThis)
    {
    }

    // ID3DX12PipelineParserCallbacks
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void FlagsCb(D3D12_PIPELINE_STATE_FLAGS Flags)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_PIPELINE_STATE_FLAGS, void>)(lpVtbl[0]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), Flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void NodeMaskCb(uint NodeMask)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, uint, void>)(lpVtbl[1]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), NodeMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void RootSignatureCb(ID3D12RootSignature* pRootSignature)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, ID3D12RootSignature*, void>)(lpVtbl[2]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), pRootSignature);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void InputLayoutCb([NativeTypeName("const D3D12_INPUT_LAYOUT_DESC &")] D3D12_INPUT_LAYOUT_DESC* InputLayout)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_INPUT_LAYOUT_DESC*, void>)(lpVtbl[3]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), InputLayout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void IBStripCutValueCb(D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IBStripCutValue)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_INDEX_BUFFER_STRIP_CUT_VALUE, void>)(lpVtbl[4]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), IBStripCutValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void PrimitiveTopologyTypeCb(D3D12_PRIMITIVE_TOPOLOGY_TYPE PrimitiveTopologyType)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_PRIMITIVE_TOPOLOGY_TYPE, void>)(lpVtbl[5]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), PrimitiveTopologyType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void VSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* VS)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[6]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), VS);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* GS)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[7]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), GS);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void StreamOutputCb([NativeTypeName("const D3D12_STREAM_OUTPUT_DESC &")] D3D12_STREAM_OUTPUT_DESC* StreamOutput)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_STREAM_OUTPUT_DESC*, void>)(lpVtbl[8]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), StreamOutput);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void HSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* HS)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[9]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), HS);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void DSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* DS)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[10]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), DS);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void PSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* PS)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[11]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), PS);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void CSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* CS)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[12]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), CS);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    void ID3DX12PipelineParserCallbacks.Interface.ASCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* AS)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[13]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), AS);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    void ID3DX12PipelineParserCallbacks.Interface.MSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* MS)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[14]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), MS);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void BlendStateCb([NativeTypeName("const D3D12_BLEND_DESC &")] D3D12_BLEND_DESC* BlendState)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_BLEND_DESC*, void>)(lpVtbl[15]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), BlendState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void DepthStencilStateCb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] D3D12_DEPTH_STENCIL_DESC* DepthStencilState)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_DEPTH_STENCIL_DESC*, void>)(lpVtbl[16]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), DepthStencilState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void DepthStencilState1Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC1 &")] D3D12_DEPTH_STENCIL_DESC1* DepthStencilState)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_DEPTH_STENCIL_DESC1*, void>)(lpVtbl[17]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), DepthStencilState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    void ID3DX12PipelineParserCallbacks.Interface.DepthStencilState2Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC2 &")] D3D12_DEPTH_STENCIL_DESC2* DepthStencilState)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_DEPTH_STENCIL_DESC2*, void>)(lpVtbl[18]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), DepthStencilState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void DSVFormatCb(DXGI_FORMAT DSVFormat)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, DXGI_FORMAT, void>)(lpVtbl[19]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), DSVFormat);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void RasterizerStateCb([NativeTypeName("const D3D12_RASTERIZER_DESC &")] D3D12_RASTERIZER_DESC* RasterizerState)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_RASTERIZER_DESC*, void>)(lpVtbl[20]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), RasterizerState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    void ID3DX12PipelineParserCallbacks.Interface.RasterizerState1Cb([NativeTypeName("const D3D12_RASTERIZER_DESC1 &")] D3D12_RASTERIZER_DESC1* RasterizerState)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_RASTERIZER_DESC1*, void>)(lpVtbl[21]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), RasterizerState);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.RasterizerState2Cb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    void ID3DX12PipelineParserCallbacks.Interface.RasterizerState2Cb([NativeTypeName("const D3D12_RASTERIZER_DESC2 &")] D3D12_RASTERIZER_DESC2* RasterizerState)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_RASTERIZER_DESC2*, void>)(lpVtbl[22]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), RasterizerState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void RTVFormatsCb([NativeTypeName("const D3D12_RT_FORMAT_ARRAY &")] D3D12_RT_FORMAT_ARRAY* RTVFormats)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_RT_FORMAT_ARRAY*, void>)(lpVtbl[23]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), RTVFormats);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void SampleDescCb([NativeTypeName("const DXGI_SAMPLE_DESC &")] DXGI_SAMPLE_DESC* SampleDesc)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, DXGI_SAMPLE_DESC*, void>)(lpVtbl[24]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), SampleDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public void SampleMaskCb(uint SampleMask)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, uint, void>)(lpVtbl[25]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), SampleMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public void ViewInstancingCb([NativeTypeName("const D3D12_VIEW_INSTANCING_DESC &")] D3D12_VIEW_INSTANCING_DESC* ViewInstancingDesc)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_VIEW_INSTANCING_DESC*, void>)(lpVtbl[26]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), ViewInstancingDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public void CachedPSOCb([NativeTypeName("const D3D12_CACHED_PIPELINE_STATE &")] D3D12_CACHED_PIPELINE_STATE* CachedPSO)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_CACHED_PIPELINE_STATE*, void>)(lpVtbl[27]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), CachedPSO);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    void ID3DX12PipelineParserCallbacks.Interface.ErrorBadInputParameter(uint ParameterIndex)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, uint, void>)(lpVtbl[28]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), ParameterIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    void ID3DX12PipelineParserCallbacks.Interface.ErrorDuplicateSubobject(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE DuplicateType)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, D3D12_PIPELINE_STATE_SUBOBJECT_TYPE, void>)(lpVtbl[29]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), DuplicateType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    void ID3DX12PipelineParserCallbacks.Interface.ErrorUnknownSubobject(uint UnknownTypeValue)
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, uint, void>)(lpVtbl[30]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)), UnknownTypeValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    void ID3DX12PipelineParserCallbacks.Interface.Dispose()
    {
        ((delegate* unmanaged[MemberFunction]<CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*, void>)(lpVtbl[31]))((CD3DX12_PIPELINE_STATE_STREAM_PARSE_HELPER*)(Unsafe.AsPointer(ref this)));
    }
}
