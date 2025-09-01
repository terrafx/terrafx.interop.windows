// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks"]/*' />
public unsafe partial struct ID3DX12PipelineParserCallbacks : ID3DX12PipelineParserCallbacks.Interface
{
    public void** lpVtbl;

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.FlagsCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void FlagsCb(D3D12_PIPELINE_STATE_FLAGS Flags)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_PIPELINE_STATE_FLAGS, void>)(lpVtbl[0]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), Flags);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.NodeMaskCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void NodeMaskCb(uint NodeMask)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, uint, void>)(lpVtbl[1]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), NodeMask);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.RootSignatureCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void RootSignatureCb(ID3D12RootSignature* pRootSignature)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, ID3D12RootSignature*, void>)(lpVtbl[2]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), pRootSignature);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.InputLayoutCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void InputLayoutCb([NativeTypeName("const D3D12_INPUT_LAYOUT_DESC &")] D3D12_INPUT_LAYOUT_DESC* InputLayout)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_INPUT_LAYOUT_DESC*, void>)(lpVtbl[3]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), InputLayout);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.IBStripCutValueCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void IBStripCutValueCb(D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IBStripCutValue)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_INDEX_BUFFER_STRIP_CUT_VALUE, void>)(lpVtbl[4]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), IBStripCutValue);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.PrimitiveTopologyTypeCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void PrimitiveTopologyTypeCb(D3D12_PRIMITIVE_TOPOLOGY_TYPE PrimitiveTopologyType)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_PRIMITIVE_TOPOLOGY_TYPE, void>)(lpVtbl[5]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), PrimitiveTopologyType);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.VSCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void VSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* VS)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[6]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), VS);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.GSCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* GS)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[7]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), GS);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.StreamOutputCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void StreamOutputCb([NativeTypeName("const D3D12_STREAM_OUTPUT_DESC &")] D3D12_STREAM_OUTPUT_DESC* StreamOutput)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_STREAM_OUTPUT_DESC*, void>)(lpVtbl[8]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), StreamOutput);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.HSCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void HSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* HS)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[9]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), HS);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.DSCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void DSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* DS)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[10]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), DS);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.PSCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void PSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* PS)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[11]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), PS);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.CSCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void CSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* CS)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[12]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), CS);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.ASCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void ASCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* AS)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[13]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), AS);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.MSCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void MSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* MS)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[14]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), MS);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.BlendStateCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void BlendStateCb([NativeTypeName("const D3D12_BLEND_DESC &")] D3D12_BLEND_DESC* BlendState)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_BLEND_DESC*, void>)(lpVtbl[15]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), BlendState);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.DepthStencilStateCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void DepthStencilStateCb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] D3D12_DEPTH_STENCIL_DESC* DepthStencilState)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_DEPTH_STENCIL_DESC*, void>)(lpVtbl[16]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), DepthStencilState);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.DepthStencilState1Cb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void DepthStencilState1Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC1 &")] D3D12_DEPTH_STENCIL_DESC1* DepthStencilState)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_DEPTH_STENCIL_DESC1*, void>)(lpVtbl[17]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), DepthStencilState);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.DepthStencilState2Cb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void DepthStencilState2Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC2 &")] D3D12_DEPTH_STENCIL_DESC2* DepthStencilState)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_DEPTH_STENCIL_DESC2*, void>)(lpVtbl[18]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), DepthStencilState);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.DSVFormatCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void DSVFormatCb(DXGI_FORMAT DSVFormat)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, DXGI_FORMAT, void>)(lpVtbl[19]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), DSVFormat);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.RasterizerStateCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void RasterizerStateCb([NativeTypeName("const D3D12_RASTERIZER_DESC &")] D3D12_RASTERIZER_DESC* RasterizerState)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_RASTERIZER_DESC*, void>)(lpVtbl[20]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), RasterizerState);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.RasterizerState1Cb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void RasterizerState1Cb([NativeTypeName("const D3D12_RASTERIZER_DESC1 &")] D3D12_RASTERIZER_DESC1* RasterizerState)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_RASTERIZER_DESC1*, void>)(lpVtbl[21]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), RasterizerState);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.RasterizerState2Cb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void RasterizerState2Cb([NativeTypeName("const D3D12_RASTERIZER_DESC2 &")] D3D12_RASTERIZER_DESC2* RasterizerState)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_RASTERIZER_DESC2*, void>)(lpVtbl[22]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), RasterizerState);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.RTVFormatsCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void RTVFormatsCb([NativeTypeName("const D3D12_RT_FORMAT_ARRAY &")] D3D12_RT_FORMAT_ARRAY* RTVFormats)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_RT_FORMAT_ARRAY*, void>)(lpVtbl[23]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), RTVFormats);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.SampleDescCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void SampleDescCb([NativeTypeName("const DXGI_SAMPLE_DESC &")] DXGI_SAMPLE_DESC* SampleDesc)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, DXGI_SAMPLE_DESC*, void>)(lpVtbl[24]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), SampleDesc);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.SampleMaskCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public void SampleMaskCb(uint SampleMask)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, uint, void>)(lpVtbl[25]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), SampleMask);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.ViewInstancingCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public void ViewInstancingCb([NativeTypeName("const D3D12_VIEW_INSTANCING_DESC &")] D3D12_VIEW_INSTANCING_DESC* ViewInstancingDesc)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_VIEW_INSTANCING_DESC*, void>)(lpVtbl[26]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), ViewInstancingDesc);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.CachedPSOCb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public void CachedPSOCb([NativeTypeName("const D3D12_CACHED_PIPELINE_STATE &")] D3D12_CACHED_PIPELINE_STATE* CachedPSO)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_CACHED_PIPELINE_STATE*, void>)(lpVtbl[27]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), CachedPSO);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.ErrorBadInputParameter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public void ErrorBadInputParameter(uint ParameterIndex)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, uint, void>)(lpVtbl[28]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), ParameterIndex);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.ErrorDuplicateSubobject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public void ErrorDuplicateSubobject(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE DuplicateType)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, D3D12_PIPELINE_STATE_SUBOBJECT_TYPE, void>)(lpVtbl[29]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), DuplicateType);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.ErrorUnknownSubobject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public void ErrorUnknownSubobject(uint UnknownTypeValue)
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, uint, void>)(lpVtbl[30]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), UnknownTypeValue);
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.Dispose"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public void Dispose()
    {
        ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks*, void>)(lpVtbl[31]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        void FlagsCb(D3D12_PIPELINE_STATE_FLAGS Flags);

        [VtblIndex(1)]
        void NodeMaskCb(uint NodeMask);

        [VtblIndex(2)]
        void RootSignatureCb(ID3D12RootSignature* pRootSignature);

        [VtblIndex(3)]
        void InputLayoutCb([NativeTypeName("const D3D12_INPUT_LAYOUT_DESC &")] D3D12_INPUT_LAYOUT_DESC* InputLayout);

        [VtblIndex(4)]
        void IBStripCutValueCb(D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IBStripCutValue);

        [VtblIndex(5)]
        void PrimitiveTopologyTypeCb(D3D12_PRIMITIVE_TOPOLOGY_TYPE PrimitiveTopologyType);

        [VtblIndex(6)]
        void VSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* VS);

        [VtblIndex(7)]
        void GSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* GS);

        [VtblIndex(8)]
        void StreamOutputCb([NativeTypeName("const D3D12_STREAM_OUTPUT_DESC &")] D3D12_STREAM_OUTPUT_DESC* StreamOutput);

        [VtblIndex(9)]
        void HSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* HS);

        [VtblIndex(10)]
        void DSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* DS);

        [VtblIndex(11)]
        void PSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* PS);

        [VtblIndex(12)]
        void CSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* CS);

        [VtblIndex(13)]
        void ASCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* AS);

        [VtblIndex(14)]
        void MSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* MS);

        [VtblIndex(15)]
        void BlendStateCb([NativeTypeName("const D3D12_BLEND_DESC &")] D3D12_BLEND_DESC* BlendState);

        [VtblIndex(16)]
        void DepthStencilStateCb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] D3D12_DEPTH_STENCIL_DESC* DepthStencilState);

        [VtblIndex(17)]
        void DepthStencilState1Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC1 &")] D3D12_DEPTH_STENCIL_DESC1* DepthStencilState);

        [VtblIndex(18)]
        void DepthStencilState2Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC2 &")] D3D12_DEPTH_STENCIL_DESC2* DepthStencilState);

        [VtblIndex(19)]
        void DSVFormatCb(DXGI_FORMAT DSVFormat);

        [VtblIndex(20)]
        void RasterizerStateCb([NativeTypeName("const D3D12_RASTERIZER_DESC &")] D3D12_RASTERIZER_DESC* RasterizerState);

        [VtblIndex(21)]
        void RasterizerState1Cb([NativeTypeName("const D3D12_RASTERIZER_DESC1 &")] D3D12_RASTERIZER_DESC1* RasterizerState);

        [VtblIndex(22)]
        void RasterizerState2Cb([NativeTypeName("const D3D12_RASTERIZER_DESC2 &")] D3D12_RASTERIZER_DESC2* RasterizerState);

        [VtblIndex(23)]
        void RTVFormatsCb([NativeTypeName("const D3D12_RT_FORMAT_ARRAY &")] D3D12_RT_FORMAT_ARRAY* RTVFormats);

        [VtblIndex(24)]
        void SampleDescCb([NativeTypeName("const DXGI_SAMPLE_DESC &")] DXGI_SAMPLE_DESC* SampleDesc);

        [VtblIndex(25)]
        void SampleMaskCb(uint SampleMask);

        [VtblIndex(26)]
        void ViewInstancingCb([NativeTypeName("const D3D12_VIEW_INSTANCING_DESC &")] D3D12_VIEW_INSTANCING_DESC* ViewInstancingDesc);

        [VtblIndex(27)]
        void CachedPSOCb([NativeTypeName("const D3D12_CACHED_PIPELINE_STATE &")] D3D12_CACHED_PIPELINE_STATE* CachedPSO);

        [VtblIndex(28)]
        void ErrorBadInputParameter(uint ParameterIndex);

        [VtblIndex(29)]
        void ErrorDuplicateSubobject(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE DuplicateType);

        [VtblIndex(30)]
        void ErrorUnknownSubobject(uint UnknownTypeValue);

        [VtblIndex(31)]
        void Dispose();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (D3D12_PIPELINE_STATE_FLAGS)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_PIPELINE_STATE_FLAGS, void> FlagsCb;

        [NativeTypeName("void (UINT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void> NodeMaskCb;

        [NativeTypeName("void (ID3D12RootSignature *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12RootSignature*, void> RootSignatureCb;

        [NativeTypeName("void (const D3D12_INPUT_LAYOUT_DESC &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_INPUT_LAYOUT_DESC*, void> InputLayoutCb;

        [NativeTypeName("void (D3D12_INDEX_BUFFER_STRIP_CUT_VALUE)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_INDEX_BUFFER_STRIP_CUT_VALUE, void> IBStripCutValueCb;

        [NativeTypeName("void (D3D12_PRIMITIVE_TOPOLOGY_TYPE)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_PRIMITIVE_TOPOLOGY_TYPE, void> PrimitiveTopologyTypeCb;

        [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_BYTECODE*, void> VSCb;

        [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_BYTECODE*, void> GSCb;

        [NativeTypeName("void (const D3D12_STREAM_OUTPUT_DESC &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_STREAM_OUTPUT_DESC*, void> StreamOutputCb;

        [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_BYTECODE*, void> HSCb;

        [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_BYTECODE*, void> DSCb;

        [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_BYTECODE*, void> PSCb;

        [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_BYTECODE*, void> CSCb;

        [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_BYTECODE*, void> ASCb;

        [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_BYTECODE*, void> MSCb;

        [NativeTypeName("void (const D3D12_BLEND_DESC &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_BLEND_DESC*, void> BlendStateCb;

        [NativeTypeName("void (const D3D12_DEPTH_STENCIL_DESC &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_DEPTH_STENCIL_DESC*, void> DepthStencilStateCb;

        [NativeTypeName("void (const D3D12_DEPTH_STENCIL_DESC1 &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_DEPTH_STENCIL_DESC1*, void> DepthStencilState1Cb;

        [NativeTypeName("void (const D3D12_DEPTH_STENCIL_DESC2 &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_DEPTH_STENCIL_DESC2*, void> DepthStencilState2Cb;

        [NativeTypeName("void (DXGI_FORMAT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXGI_FORMAT, void> DSVFormatCb;

        [NativeTypeName("void (const D3D12_RASTERIZER_DESC &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_RASTERIZER_DESC*, void> RasterizerStateCb;

        [NativeTypeName("void (const D3D12_RASTERIZER_DESC1 &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_RASTERIZER_DESC1*, void> RasterizerState1Cb;

        [NativeTypeName("void (const D3D12_RASTERIZER_DESC2 &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_RASTERIZER_DESC2*, void> RasterizerState2Cb;

        [NativeTypeName("void (const D3D12_RT_FORMAT_ARRAY &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_RT_FORMAT_ARRAY*, void> RTVFormatsCb;

        [NativeTypeName("void (const DXGI_SAMPLE_DESC &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXGI_SAMPLE_DESC*, void> SampleDescCb;

        [NativeTypeName("void (UINT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void> SampleMaskCb;

        [NativeTypeName("void (const D3D12_VIEW_INSTANCING_DESC &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_VIEW_INSTANCING_DESC*, void> ViewInstancingCb;

        [NativeTypeName("void (const D3D12_CACHED_PIPELINE_STATE &)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_CACHED_PIPELINE_STATE*, void> CachedPSOCb;

        [NativeTypeName("void (UINT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void> ErrorBadInputParameter;

        [NativeTypeName("void (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_PIPELINE_STATE_SUBOBJECT_TYPE, void> ErrorDuplicateSubobject;

        [NativeTypeName("void (UINT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void> ErrorUnknownSubobject;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> Dispose;
    }
}
