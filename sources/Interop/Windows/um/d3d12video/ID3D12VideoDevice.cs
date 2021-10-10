// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1F052807-0B46-4ACC-8A89-364F793718A4")]
    [NativeTypeName("struct ID3D12VideoDevice : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D12VideoDevice
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12VideoDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12VideoDevice*, uint>)(lpVtbl[1]))((ID3D12VideoDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12VideoDevice*, uint>)(lpVtbl[2]))((ID3D12VideoDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D3D12_FEATURE_VIDEO FeatureVideo, void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice*, D3D12_FEATURE_VIDEO, void*, uint, int>)(lpVtbl[3]))((ID3D12VideoDevice*)Unsafe.AsPointer(ref this), FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoder([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12_VIDEO_DECODER_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoder)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice*, D3D12_VIDEO_DECODER_DESC*, Guid*, void**, int>)(lpVtbl[4]))((ID3D12VideoDevice*)Unsafe.AsPointer(ref this), pDesc, riid, ppVideoDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoderHeap([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoderHeap)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice*, D3D12_VIDEO_DECODER_HEAP_DESC*, Guid*, void**, int>)(lpVtbl[5]))((ID3D12VideoDevice*)Unsafe.AsPointer(ref this), pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessor([NativeTypeName("UINT")] uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc, [NativeTypeName("UINT")] uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoProcessor)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice*, uint, D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC*, uint, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC*, Guid*, void**, int>)(lpVtbl[6]))((ID3D12VideoDevice*)Unsafe.AsPointer(ref this), NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
        }
    }
}
