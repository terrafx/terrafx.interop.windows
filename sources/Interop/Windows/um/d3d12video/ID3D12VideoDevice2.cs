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
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12VideoDevice2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12VideoDevice2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12VideoDevice2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckFeatureSupport(ID3D12VideoDevice2* pThis, D3D12_FEATURE_VIDEO FeatureVideo, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVideoDecoder(ID3D12VideoDevice2* pThis, [NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12_VIDEO_DECODER_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoDecoder);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVideoDecoderHeap(ID3D12VideoDevice2* pThis, [NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoDecoderHeap);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVideoProcessor(ID3D12VideoDevice2* pThis, [NativeTypeName("UINT")] uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc, [NativeTypeName("UINT")] uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoProcessor);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVideoMotionEstimator(ID3D12VideoDevice2* pThis, [NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *")] D3D12_VIDEO_MOTION_ESTIMATOR_DESC* pDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoMotionEstimator);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVideoMotionVectorHeap(ID3D12VideoDevice2* pThis, [NativeTypeName("const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *")] D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC* pDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoMotionVectorHeap);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVideoDecoder1(ID3D12VideoDevice2* pThis, [NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12_VIDEO_DECODER_DESC* pDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoDecoder);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVideoDecoderHeap1(ID3D12VideoDevice2* pThis, [NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoDecoderHeap);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVideoProcessor1(ID3D12VideoDevice2* pThis, [NativeTypeName("UINT")] uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc, [NativeTypeName("UINT")] uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoProcessor);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVideoExtensionCommand(ID3D12VideoDevice2* pThis, [NativeTypeName("const D3D12_VIDEO_EXTENSION_COMMAND_DESC *")] D3D12_VIDEO_EXTENSION_COMMAND_DESC* pDesc, [NativeTypeName("const void *")] void* pCreationParameters, [NativeTypeName("SIZE_T")] nuint CreationParametersDataSizeInBytes, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoExtensionCommand);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ExecuteExtensionCommand(ID3D12VideoDevice2* pThis, [NativeTypeName("ID3D12VideoExtensionCommand *")] ID3D12VideoExtensionCommand* pExtensionCommand, [NativeTypeName("const void *")] void* pExecutionParameters, [NativeTypeName("SIZE_T")] nuint ExecutionParametersSizeInBytes, [NativeTypeName("void *")] void* pOutputData, [NativeTypeName("SIZE_T")] nuint OutputDataSizeInBytes);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D3D12_FEATURE_VIDEO FeatureVideo, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckFeatureSupport>(lpVtbl->CheckFeatureSupport)((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoder([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12_VIDEO_DECODER_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoDecoder)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVideoDecoder>(lpVtbl->CreateVideoDecoder)((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), pDesc, riid, ppVideoDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoderHeap([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoDecoderHeap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVideoDecoderHeap>(lpVtbl->CreateVideoDecoderHeap)((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessor([NativeTypeName("UINT")] uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc, [NativeTypeName("UINT")] uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoProcessor)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVideoProcessor>(lpVtbl->CreateVideoProcessor)((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoMotionEstimator([NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *")] D3D12_VIDEO_MOTION_ESTIMATOR_DESC* pDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoMotionEstimator)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVideoMotionEstimator>(lpVtbl->CreateVideoMotionEstimator)((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimator);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoMotionVectorHeap([NativeTypeName("const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *")] D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC* pDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoMotionVectorHeap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVideoMotionVectorHeap>(lpVtbl->CreateVideoMotionVectorHeap)((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoder1([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12_VIDEO_DECODER_DESC* pDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoDecoder)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVideoDecoder1>(lpVtbl->CreateVideoDecoder1)((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), pDesc, pProtectedResourceSession, riid, ppVideoDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoDecoderHeap1([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] D3D12_VIDEO_DECODER_HEAP_DESC* pVideoDecoderHeapDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoDecoderHeap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVideoDecoderHeap1>(lpVtbl->CreateVideoDecoderHeap1)((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), pVideoDecoderHeapDesc, pProtectedResourceSession, riid, ppVideoDecoderHeap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoProcessor1([NativeTypeName("UINT")] uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc, [NativeTypeName("UINT")] uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoProcessor)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVideoProcessor1>(lpVtbl->CreateVideoProcessor1)((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessor);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVideoExtensionCommand([NativeTypeName("const D3D12_VIDEO_EXTENSION_COMMAND_DESC *")] D3D12_VIDEO_EXTENSION_COMMAND_DESC* pDesc, [NativeTypeName("const void *")] void* pCreationParameters, [NativeTypeName("SIZE_T")] nuint CreationParametersDataSizeInBytes, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppVideoExtensionCommand)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVideoExtensionCommand>(lpVtbl->CreateVideoExtensionCommand)((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
        }

        [return: NativeTypeName("HRESULT")]
        public int ExecuteExtensionCommand([NativeTypeName("ID3D12VideoExtensionCommand *")] ID3D12VideoExtensionCommand* pExtensionCommand, [NativeTypeName("const void *")] void* pExecutionParameters, [NativeTypeName("SIZE_T")] nuint ExecutionParametersSizeInBytes, [NativeTypeName("void *")] void* pOutputData, [NativeTypeName("SIZE_T")] nuint OutputDataSizeInBytes)
        {
            return Marshal.GetDelegateForFunctionPointer<_ExecuteExtensionCommand>(lpVtbl->ExecuteExtensionCommand)((ID3D12VideoDevice2*)Unsafe.AsPointer(ref this), pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (D3D12_FEATURE_VIDEO, void *, UINT) __attribute__((stdcall))")]
            public IntPtr CheckFeatureSupport;

            [NativeTypeName("HRESULT (const D3D12_VIDEO_DECODER_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateVideoDecoder;

            [NativeTypeName("HRESULT (const D3D12_VIDEO_DECODER_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateVideoDecoderHeap;

            [NativeTypeName("HRESULT (UINT, const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *, UINT, const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateVideoProcessor;

            [NativeTypeName("HRESULT (const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateVideoMotionEstimator;

            [NativeTypeName("HRESULT (const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateVideoMotionVectorHeap;

            [NativeTypeName("HRESULT (const D3D12_VIDEO_DECODER_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateVideoDecoder1;

            [NativeTypeName("HRESULT (const D3D12_VIDEO_DECODER_HEAP_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateVideoDecoderHeap1;

            [NativeTypeName("HRESULT (UINT, const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *, UINT, const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateVideoProcessor1;

            [NativeTypeName("HRESULT (const D3D12_VIDEO_EXTENSION_COMMAND_DESC *, const void *, SIZE_T, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateVideoExtensionCommand;

            [NativeTypeName("HRESULT (ID3D12VideoExtensionCommand *, const void *, SIZE_T, void *, SIZE_T) __attribute__((stdcall))")]
            public IntPtr ExecuteExtensionCommand;
        }
    }
}
