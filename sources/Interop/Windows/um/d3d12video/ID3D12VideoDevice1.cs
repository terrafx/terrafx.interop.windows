// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("981611AD-A144-4C83-9890-F30E26D658AB")]
    public unsafe partial struct ID3D12VideoDevice1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12VideoDevice1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12VideoDevice1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12VideoDevice1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D3D12_FEATURE_VIDEO FeatureVideo, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return lpVtbl->CheckFeatureSupport((ID3D12VideoDevice1*)Unsafe.AsPointer(ref this), FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoder([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12_VIDEO_DECODER_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoDecoder)
        {
            return lpVtbl->CreateVideoDecoder((ID3D12VideoDevice1*)Unsafe.AsPointer(ref this), pDesc, riid, ppVideoDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoderHeap([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoDecoderHeap)
        {
            return lpVtbl->CreateVideoDecoderHeap((ID3D12VideoDevice1*)Unsafe.AsPointer(ref this), pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessor([NativeTypeName("UINT")] uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc, [NativeTypeName("UINT")] uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoProcessor)
        {
            return lpVtbl->CreateVideoProcessor((ID3D12VideoDevice1*)Unsafe.AsPointer(ref this), NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoMotionEstimator([NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *")] D3D12_VIDEO_MOTION_ESTIMATOR_DESC* pDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoMotionEstimator)
        {
            return lpVtbl->CreateVideoMotionEstimator((ID3D12VideoDevice1*)Unsafe.AsPointer(ref this), pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimator);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoMotionVectorHeap([NativeTypeName("const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *")] D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC* pDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoMotionVectorHeap)
        {
            return lpVtbl->CreateVideoMotionVectorHeap((ID3D12VideoDevice1*)Unsafe.AsPointer(ref this), pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoDevice1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoDevice1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoDevice1*, uint> Release;

            [NativeTypeName("HRESULT (D3D12_FEATURE_VIDEO, void *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoDevice1*, D3D12_FEATURE_VIDEO, void*, uint, int> CheckFeatureSupport;

            [NativeTypeName("HRESULT (const D3D12_VIDEO_DECODER_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoDevice1*, D3D12_VIDEO_DECODER_DESC*, Guid*, void**, int> CreateVideoDecoder;

            [NativeTypeName("HRESULT (const D3D12_VIDEO_DECODER_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoDevice1*, D3D12_VIDEO_DECODER_HEAP_DESC*, Guid*, void**, int> CreateVideoDecoderHeap;

            [NativeTypeName("HRESULT (UINT, const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *, UINT, const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoDevice1*, uint, D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC*, uint, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC*, Guid*, void**, int> CreateVideoProcessor;

            [NativeTypeName("HRESULT (const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoDevice1*, D3D12_VIDEO_MOTION_ESTIMATOR_DESC*, ID3D12ProtectedResourceSession*, Guid*, void**, int> CreateVideoMotionEstimator;

            [NativeTypeName("HRESULT (const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoDevice1*, D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC*, ID3D12ProtectedResourceSession*, Guid*, void**, int> CreateVideoMotionVectorHeap;
        }
    }
}
