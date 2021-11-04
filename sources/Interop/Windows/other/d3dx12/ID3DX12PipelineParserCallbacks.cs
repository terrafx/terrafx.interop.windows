// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in the microsoft/DirectX-Graphics-Samples tag v10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct ID3DX12PipelineParserCallbacks
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public void FlagsCb(D3D12_PIPELINE_STATE_FLAGS param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_PIPELINE_STATE_FLAGS, void>)(lpVtbl[0]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void NodeMaskCb(uint param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, uint, void>)(lpVtbl[1]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public void RootSignatureCb(ID3D12RootSignature* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, ID3D12RootSignature*, void>)(lpVtbl[2]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void InputLayoutCb([NativeTypeName("const D3D12_INPUT_LAYOUT_DESC &")] D3D12_INPUT_LAYOUT_DESC* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_INPUT_LAYOUT_DESC*, void>)(lpVtbl[3]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void IBStripCutValueCb(D3D12_INDEX_BUFFER_STRIP_CUT_VALUE param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_INDEX_BUFFER_STRIP_CUT_VALUE, void>)(lpVtbl[4]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void PrimitiveTopologyTypeCb(D3D12_PRIMITIVE_TOPOLOGY_TYPE param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_PRIMITIVE_TOPOLOGY_TYPE, void>)(lpVtbl[5]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void VSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[6]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void GSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[7]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void StreamOutputCb([NativeTypeName("const D3D12_STREAM_OUTPUT_DESC &")] D3D12_STREAM_OUTPUT_DESC* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_STREAM_OUTPUT_DESC*, void>)(lpVtbl[8]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void HSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[9]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public void DSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[10]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void PSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[11]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void CSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[12]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void ASCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[13]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public void MSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void>)(lpVtbl[14]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public void BlendStateCb([NativeTypeName("const D3D12_BLEND_DESC &")] D3D12_BLEND_DESC* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_BLEND_DESC*, void>)(lpVtbl[15]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public void DepthStencilStateCb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] D3D12_DEPTH_STENCIL_DESC* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_DEPTH_STENCIL_DESC*, void>)(lpVtbl[16]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void DepthStencilState1Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC1 &")] D3D12_DEPTH_STENCIL_DESC1* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_DEPTH_STENCIL_DESC1*, void>)(lpVtbl[17]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void DSVFormatCb(DXGI_FORMAT param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, DXGI_FORMAT, void>)(lpVtbl[18]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void RasterizerStateCb([NativeTypeName("const D3D12_RASTERIZER_DESC &")] D3D12_RASTERIZER_DESC* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_RASTERIZER_DESC*, void>)(lpVtbl[19]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void RTVFormatsCb([NativeTypeName("const D3D12_RT_FORMAT_ARRAY &")] D3D12_RT_FORMAT_ARRAY* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_RT_FORMAT_ARRAY*, void>)(lpVtbl[20]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void SampleDescCb([NativeTypeName("const DXGI_SAMPLE_DESC &")] DXGI_SAMPLE_DESC* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, DXGI_SAMPLE_DESC*, void>)(lpVtbl[21]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void SampleMaskCb(uint param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, uint, void>)(lpVtbl[22]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void ViewInstancingCb([NativeTypeName("const D3D12_VIEW_INSTANCING_DESC &")] D3D12_VIEW_INSTANCING_DESC* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_VIEW_INSTANCING_DESC*, void>)(lpVtbl[23]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public void CachedPSOCb([NativeTypeName("const D3D12_CACHED_PIPELINE_STATE &")] D3D12_CACHED_PIPELINE_STATE* param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_CACHED_PIPELINE_STATE*, void>)(lpVtbl[24]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public void ErrorBadInputParameter(uint param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, uint, void>)(lpVtbl[25]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public void ErrorDuplicateSubobject(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_PIPELINE_STATE_SUBOBJECT_TYPE, void>)(lpVtbl[26]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public void ErrorUnknownSubobject(uint param0)
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, uint, void>)(lpVtbl[27]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public void Dispose()
        {
            ((delegate* unmanaged<ID3DX12PipelineParserCallbacks*, void>)(lpVtbl[28]))((ID3DX12PipelineParserCallbacks*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("void (D3D12_PIPELINE_STATE_FLAGS)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_PIPELINE_STATE_FLAGS, void> FlagsCb;

            [NativeTypeName("void (UINT)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, uint, void> NodeMaskCb;

            [NativeTypeName("void (ID3D12RootSignature *)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, ID3D12RootSignature*, void> RootSignatureCb;

            [NativeTypeName("void (const D3D12_INPUT_LAYOUT_DESC &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_INPUT_LAYOUT_DESC*, void> InputLayoutCb;

            [NativeTypeName("void (D3D12_INDEX_BUFFER_STRIP_CUT_VALUE)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_INDEX_BUFFER_STRIP_CUT_VALUE, void> IBStripCutValueCb;

            [NativeTypeName("void (D3D12_PRIMITIVE_TOPOLOGY_TYPE)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_PRIMITIVE_TOPOLOGY_TYPE, void> PrimitiveTopologyTypeCb;

            [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void> VSCb;

            [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void> GSCb;

            [NativeTypeName("void (const D3D12_STREAM_OUTPUT_DESC &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_STREAM_OUTPUT_DESC*, void> StreamOutputCb;

            [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void> HSCb;

            [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void> DSCb;

            [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void> PSCb;

            [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void> CSCb;

            [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void> ASCb;

            [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_SHADER_BYTECODE*, void> MSCb;

            [NativeTypeName("void (const D3D12_BLEND_DESC &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_BLEND_DESC*, void> BlendStateCb;

            [NativeTypeName("void (const D3D12_DEPTH_STENCIL_DESC &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_DEPTH_STENCIL_DESC*, void> DepthStencilStateCb;

            [NativeTypeName("void (const D3D12_DEPTH_STENCIL_DESC1 &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_DEPTH_STENCIL_DESC1*, void> DepthStencilState1Cb;

            [NativeTypeName("void (DXGI_FORMAT)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, DXGI_FORMAT, void> DSVFormatCb;

            [NativeTypeName("void (const D3D12_RASTERIZER_DESC &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_RASTERIZER_DESC*, void> RasterizerStateCb;

            [NativeTypeName("void (const D3D12_RT_FORMAT_ARRAY &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_RT_FORMAT_ARRAY*, void> RTVFormatsCb;

            [NativeTypeName("void (const DXGI_SAMPLE_DESC &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, DXGI_SAMPLE_DESC*, void> SampleDescCb;

            [NativeTypeName("void (UINT)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, uint, void> SampleMaskCb;

            [NativeTypeName("void (const D3D12_VIEW_INSTANCING_DESC &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_VIEW_INSTANCING_DESC*, void> ViewInstancingCb;

            [NativeTypeName("void (const D3D12_CACHED_PIPELINE_STATE &)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_CACHED_PIPELINE_STATE*, void> CachedPSOCb;

            [NativeTypeName("void (UINT)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, uint, void> ErrorBadInputParameter;

            [NativeTypeName("void (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, D3D12_PIPELINE_STATE_SUBOBJECT_TYPE, void> ErrorDuplicateSubobject;

            [NativeTypeName("void (UINT)")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, uint, void> ErrorUnknownSubobject;

            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged<ID3DX12PipelineParserCallbacks*, void> Dispose;
        }
    }
}
