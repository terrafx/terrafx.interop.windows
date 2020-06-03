// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F019AC49-F838-4A95-9B17-579437C8F513")]
    public unsafe partial struct ID3D12VideoDevice2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12VideoDevice2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12VideoDevice2*, uint>)(lpVtbl[1]))((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12VideoDevice2*, uint>)(lpVtbl[2]))((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D3D12_FEATURE_VIDEO FeatureVideo, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return ((delegate* stdcall<ID3D12VideoDevice2*, D3D12_FEATURE_VIDEO, void*, uint, int>)(lpVtbl[3]))((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoder([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12_VIDEO_DECODER_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoDecoder)
        {
            return ((delegate* stdcall<ID3D12VideoDevice2*, D3D12_VIDEO_DECODER_DESC*, Guid*, void**, int>)(lpVtbl[4]))((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), pDesc, riid, ppVideoDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoderHeap([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoDecoderHeap)
        {
            return ((delegate* stdcall<ID3D12VideoDevice2*, D3D12_VIDEO_DECODER_HEAP_DESC*, Guid*, void**, int>)(lpVtbl[5]))((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessor([NativeTypeName("UINT")] uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc, [NativeTypeName("UINT")] uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoProcessor)
        {
            return ((delegate* stdcall<ID3D12VideoDevice2*, uint, D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC*, uint, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC*, Guid*, void**, int>)(lpVtbl[6]))((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoMotionEstimator([NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *")] D3D12_VIDEO_MOTION_ESTIMATOR_DESC* pDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoMotionEstimator)
        {
            return ((delegate* stdcall<ID3D12VideoDevice2*, D3D12_VIDEO_MOTION_ESTIMATOR_DESC*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimator);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoMotionVectorHeap([NativeTypeName("const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *")] D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC* pDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoMotionVectorHeap)
        {
            return ((delegate* stdcall<ID3D12VideoDevice2*, D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[8]))((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoder1([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12_VIDEO_DECODER_DESC* pDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoDecoder)
        {
            return ((delegate* stdcall<ID3D12VideoDevice2*, D3D12_VIDEO_DECODER_DESC*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[9]))((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), pDesc, pProtectedResourceSession, riid, ppVideoDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoderHeap1([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoDecoderHeap)
        {
            return ((delegate* stdcall<ID3D12VideoDevice2*, D3D12_VIDEO_DECODER_HEAP_DESC*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[10]))((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), pVideoDecoderHeapDesc, pProtectedResourceSession, riid, ppVideoDecoderHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessor1([NativeTypeName("UINT")] uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc, [NativeTypeName("UINT")] uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoProcessor)
        {
            return ((delegate* stdcall<ID3D12VideoDevice2*, uint, D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC*, uint, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[11]))((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessor);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoExtensionCommand([NativeTypeName("const D3D12_VIDEO_EXTENSION_COMMAND_DESC *")] D3D12_VIDEO_EXTENSION_COMMAND_DESC* pDesc, [NativeTypeName("const void *")] void* pCreationParameters, [NativeTypeName("SIZE_T")] nuint CreationParametersDataSizeInBytes, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoExtensionCommand)
        {
            return ((delegate* stdcall<ID3D12VideoDevice2*, D3D12_VIDEO_EXTENSION_COMMAND_DESC*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[12]))((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
        }

        [return: NativeTypeName("HRESULT")]
        public int ExecuteExtensionCommand([NativeTypeName("ID3D12VideoExtensionCommand *")] ID3D12VideoExtensionCommand* pExtensionCommand, [NativeTypeName("const void *")] void* pExecutionParameters, [NativeTypeName("SIZE_T")] nuint ExecutionParametersSizeInBytes, [NativeTypeName("void *")] void* pOutputData, [NativeTypeName("SIZE_T")] nuint OutputDataSizeInBytes)
        {
            return ((delegate* stdcall<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)(lpVtbl[13]))((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
        }
    }
}
