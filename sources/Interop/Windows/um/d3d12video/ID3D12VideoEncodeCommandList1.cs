// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("94971ECA-2BDB-4769-88CF-3675EA757EBC")]
    public unsafe partial struct ID3D12VideoEncodeCommandList1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return lpVtbl->SetPrivateDataInterface((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return lpVtbl->SetName((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return lpVtbl->GetDevice((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        public new D3D12_COMMAND_LIST_TYPE GetType()
        {
            return lpVtbl->GetType((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return lpVtbl->Close((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset([NativeTypeName("ID3D12CommandAllocator *")] ID3D12CommandAllocator* pAllocator)
        {
            return lpVtbl->Reset((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), pAllocator);
        }

        public void ClearState()
        {
            lpVtbl->ClearState((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this));
        }

        public void ResourceBarrier([NativeTypeName("UINT")] uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12_RESOURCE_BARRIER* pBarriers)
        {
            lpVtbl->ResourceBarrier((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), NumBarriers, pBarriers);
        }

        public void DiscardResource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12_DISCARD_REGION* pRegion)
        {
            lpVtbl->DiscardResource((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), pResource, pRegion);
        }

        public void BeginQuery([NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index)
        {
            lpVtbl->BeginQuery((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
        }

        public void EndQuery([NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index)
        {
            lpVtbl->EndQuery((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
        }

        public void ResolveQueryData([NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint StartIndex, [NativeTypeName("UINT")] uint NumQueries, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset)
        {
            lpVtbl->ResolveQueryData((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }

        public void SetPredication([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation)
        {
            lpVtbl->SetPredication((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), pBuffer, AlignedBufferOffset, Operation);
        }

        public void SetMarker([NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            lpVtbl->SetMarker((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        public void BeginEvent([NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            lpVtbl->BeginEvent((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        public void EndEvent()
        {
            lpVtbl->EndEvent((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this));
        }

        public void EstimateMotion([NativeTypeName("ID3D12VideoMotionEstimator *")] ID3D12VideoMotionEstimator* pMotionEstimator, [NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_OUTPUT *")] D3D12_VIDEO_MOTION_ESTIMATOR_OUTPUT* pOutputArguments, [NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_INPUT *")] D3D12_VIDEO_MOTION_ESTIMATOR_INPUT* pInputArguments)
        {
            lpVtbl->EstimateMotion((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), pMotionEstimator, pOutputArguments, pInputArguments);
        }

        public void ResolveMotionVectorHeap([NativeTypeName("const D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT *")] D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT* pOutputArguments, [NativeTypeName("const D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT *")] D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT* pInputArguments)
        {
            lpVtbl->ResolveMotionVectorHeap((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), pOutputArguments, pInputArguments);
        }

        public void WriteBufferImmediate([NativeTypeName("UINT")] uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER* pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] D3D12_WRITEBUFFERIMMEDIATE_MODE* pModes)
        {
            lpVtbl->WriteBufferImmediate((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), Count, pParams, pModes);
        }

        public void SetProtectedResourceSession([NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession)
        {
            lpVtbl->SetProtectedResourceSession((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), pProtectedResourceSession);
        }

        public void InitializeExtensionCommand([NativeTypeName("ID3D12VideoExtensionCommand *")] ID3D12VideoExtensionCommand* pExtensionCommand, [NativeTypeName("const void *")] void* pInitializationParameters, [NativeTypeName("SIZE_T")] nuint InitializationParametersSizeInBytes)
        {
            lpVtbl->InitializeExtensionCommand((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), pExtensionCommand, pInitializationParameters, InitializationParametersSizeInBytes);
        }

        public void ExecuteExtensionCommand([NativeTypeName("ID3D12VideoExtensionCommand *")] ID3D12VideoExtensionCommand* pExtensionCommand, [NativeTypeName("const void *")] void* pExecutionParameters, [NativeTypeName("SIZE_T")] nuint ExecutionParametersSizeInBytes)
        {
            lpVtbl->ExecuteExtensionCommand((ID3D12VideoEncodeCommandList1*)Unsafe.AsPointer(ref this), pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, ushort*, int> SetName;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, Guid*, void**, int> GetDevice;

            [NativeTypeName("D3D12_COMMAND_LIST_TYPE () __attribute__((stdcall))")]
            public new delegate* stdcall<ID3D12VideoEncodeCommandList1*, D3D12_COMMAND_LIST_TYPE> GetType;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, int> Close;

            [NativeTypeName("HRESULT (ID3D12CommandAllocator *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, ID3D12CommandAllocator*, int> Reset;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, void> ClearState;

            [NativeTypeName("void (UINT, const D3D12_RESOURCE_BARRIER *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, uint, D3D12_RESOURCE_BARRIER*, void> ResourceBarrier;

            [NativeTypeName("void (ID3D12Resource *, const D3D12_DISCARD_REGION *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, ID3D12Resource*, D3D12_DISCARD_REGION*, void> DiscardResource;

            [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void> BeginQuery;

            [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void> EndQuery;

            [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT, UINT, ID3D12Resource *, UINT64) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, uint, ID3D12Resource*, ulong, void> ResolveQueryData;

            [NativeTypeName("void (ID3D12Resource *, UINT64, D3D12_PREDICATION_OP) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, ID3D12Resource*, ulong, D3D12_PREDICATION_OP, void> SetPredication;

            [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, uint, void*, uint, void> SetMarker;

            [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, uint, void*, uint, void> BeginEvent;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, void> EndEvent;

            [NativeTypeName("void (ID3D12VideoMotionEstimator *, const D3D12_VIDEO_MOTION_ESTIMATOR_OUTPUT *, const D3D12_VIDEO_MOTION_ESTIMATOR_INPUT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, ID3D12VideoMotionEstimator*, D3D12_VIDEO_MOTION_ESTIMATOR_OUTPUT*, D3D12_VIDEO_MOTION_ESTIMATOR_INPUT*, void> EstimateMotion;

            [NativeTypeName("void (const D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT *, const D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT*, D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT*, void> ResolveMotionVectorHeap;

            [NativeTypeName("void (UINT, const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *, const D3D12_WRITEBUFFERIMMEDIATE_MODE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, uint, D3D12_WRITEBUFFERIMMEDIATE_PARAMETER*, D3D12_WRITEBUFFERIMMEDIATE_MODE*, void> WriteBufferImmediate;

            [NativeTypeName("void (ID3D12ProtectedResourceSession *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, ID3D12ProtectedResourceSession*, void> SetProtectedResourceSession;

            [NativeTypeName("void (ID3D12VideoExtensionCommand *, const void *, SIZE_T) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, ID3D12VideoExtensionCommand*, void*, nuint, void> InitializeExtensionCommand;

            [NativeTypeName("void (ID3D12VideoExtensionCommand *, const void *, SIZE_T) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12VideoEncodeCommandList1*, ID3D12VideoExtensionCommand*, void*, nuint, void> ExecuteExtensionCommand;
        }
    }
}
