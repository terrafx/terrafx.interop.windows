// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB525AE4-6AD6-473C-BAA7-59B2E37082E4")]
    public unsafe partial struct ID3D12VideoProcessCommandList2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12VideoProcessCommandList2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12VideoProcessCommandList2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("LPCWSTR")] ushort* Name);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D3D12_COMMAND_LIST_TYPE _GetType(ID3D12VideoProcessCommandList2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Close(ID3D12VideoProcessCommandList2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Reset(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("ID3D12CommandAllocator *")] ID3D12CommandAllocator* pAllocator);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ClearState(ID3D12VideoProcessCommandList2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ResourceBarrier(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("UINT")] uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12_RESOURCE_BARRIER* pBarriers);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _DiscardResource(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12_DISCARD_REGION* pRegion);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _BeginQuery(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _EndQuery(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ResolveQueryData(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint StartIndex, [NativeTypeName("UINT")] uint NumQueries, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetPredication(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetMarker(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _BeginEvent(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _EndEvent(ID3D12VideoProcessCommandList2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ProcessFrames(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("ID3D12VideoProcessor *")] ID3D12VideoProcessor* pVideoProcessor, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS *")] D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS* pOutputArguments, [NativeTypeName("UINT")] uint NumInputStreams, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS *")] D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS* pInputArguments);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _WriteBufferImmediate(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("UINT")] uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER* pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] D3D12_WRITEBUFFERIMMEDIATE_MODE* pModes);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ProcessFrames1(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("ID3D12VideoProcessor *")] ID3D12VideoProcessor* pVideoProcessor, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS *")] D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS* pOutputArguments, [NativeTypeName("UINT")] uint NumInputStreams, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1 *")] D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1* pInputArguments);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetProtectedResourceSession(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _InitializeExtensionCommand(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("ID3D12VideoExtensionCommand *")] ID3D12VideoExtensionCommand* pExtensionCommand, [NativeTypeName("const void *")] void* pInitializationParameters, [NativeTypeName("SIZE_T")] nuint InitializationParametersSizeInBytes);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ExecuteExtensionCommand(ID3D12VideoProcessCommandList2* pThis, [NativeTypeName("ID3D12VideoExtensionCommand *")] ID3D12VideoExtensionCommand* pExtensionCommand, [NativeTypeName("const void *")] void* pExecutionParameters, [NativeTypeName("SIZE_T")] nuint ExecutionParametersSizeInBytes);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        public new D3D12_COMMAND_LIST_TYPE GetType()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetType>(lpVtbl->GetType)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return Marshal.GetDelegateForFunctionPointer<_Close>(lpVtbl->Close)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset([NativeTypeName("ID3D12CommandAllocator *")] ID3D12CommandAllocator* pAllocator)
        {
            return Marshal.GetDelegateForFunctionPointer<_Reset>(lpVtbl->Reset)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), pAllocator);
        }

        public void ClearState()
        {
            Marshal.GetDelegateForFunctionPointer<_ClearState>(lpVtbl->ClearState)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this));
        }

        public void ResourceBarrier([NativeTypeName("UINT")] uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12_RESOURCE_BARRIER* pBarriers)
        {
            Marshal.GetDelegateForFunctionPointer<_ResourceBarrier>(lpVtbl->ResourceBarrier)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), NumBarriers, pBarriers);
        }

        public void DiscardResource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12_DISCARD_REGION* pRegion)
        {
            Marshal.GetDelegateForFunctionPointer<_DiscardResource>(lpVtbl->DiscardResource)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), pResource, pRegion);
        }

        public void BeginQuery([NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index)
        {
            Marshal.GetDelegateForFunctionPointer<_BeginQuery>(lpVtbl->BeginQuery)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
        }

        public void EndQuery([NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index)
        {
            Marshal.GetDelegateForFunctionPointer<_EndQuery>(lpVtbl->EndQuery)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
        }

        public void ResolveQueryData([NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint StartIndex, [NativeTypeName("UINT")] uint NumQueries, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset)
        {
            Marshal.GetDelegateForFunctionPointer<_ResolveQueryData>(lpVtbl->ResolveQueryData)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }

        public void SetPredication([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation)
        {
            Marshal.GetDelegateForFunctionPointer<_SetPredication>(lpVtbl->SetPredication)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), pBuffer, AlignedBufferOffset, Operation);
        }

        public void SetMarker([NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            Marshal.GetDelegateForFunctionPointer<_SetMarker>(lpVtbl->SetMarker)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        public void BeginEvent([NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            Marshal.GetDelegateForFunctionPointer<_BeginEvent>(lpVtbl->BeginEvent)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        public void EndEvent()
        {
            Marshal.GetDelegateForFunctionPointer<_EndEvent>(lpVtbl->EndEvent)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this));
        }

        public void ProcessFrames([NativeTypeName("ID3D12VideoProcessor *")] ID3D12VideoProcessor* pVideoProcessor, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS *")] D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS* pOutputArguments, [NativeTypeName("UINT")] uint NumInputStreams, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS *")] D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS* pInputArguments)
        {
            Marshal.GetDelegateForFunctionPointer<_ProcessFrames>(lpVtbl->ProcessFrames)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), pVideoProcessor, pOutputArguments, NumInputStreams, pInputArguments);
        }

        public void WriteBufferImmediate([NativeTypeName("UINT")] uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER* pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] D3D12_WRITEBUFFERIMMEDIATE_MODE* pModes)
        {
            Marshal.GetDelegateForFunctionPointer<_WriteBufferImmediate>(lpVtbl->WriteBufferImmediate)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), Count, pParams, pModes);
        }

        public void ProcessFrames1([NativeTypeName("ID3D12VideoProcessor *")] ID3D12VideoProcessor* pVideoProcessor, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS *")] D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS* pOutputArguments, [NativeTypeName("UINT")] uint NumInputStreams, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1 *")] D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1* pInputArguments)
        {
            Marshal.GetDelegateForFunctionPointer<_ProcessFrames1>(lpVtbl->ProcessFrames1)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), pVideoProcessor, pOutputArguments, NumInputStreams, pInputArguments);
        }

        public void SetProtectedResourceSession([NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession)
        {
            Marshal.GetDelegateForFunctionPointer<_SetProtectedResourceSession>(lpVtbl->SetProtectedResourceSession)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), pProtectedResourceSession);
        }

        public void InitializeExtensionCommand([NativeTypeName("ID3D12VideoExtensionCommand *")] ID3D12VideoExtensionCommand* pExtensionCommand, [NativeTypeName("const void *")] void* pInitializationParameters, [NativeTypeName("SIZE_T")] nuint InitializationParametersSizeInBytes)
        {
            Marshal.GetDelegateForFunctionPointer<_InitializeExtensionCommand>(lpVtbl->InitializeExtensionCommand)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), pExtensionCommand, pInitializationParameters, InitializationParametersSizeInBytes);
        }

        public void ExecuteExtensionCommand([NativeTypeName("ID3D12VideoExtensionCommand *")] ID3D12VideoExtensionCommand* pExtensionCommand, [NativeTypeName("const void *")] void* pExecutionParameters, [NativeTypeName("SIZE_T")] nuint ExecutionParametersSizeInBytes)
        {
            Marshal.GetDelegateForFunctionPointer<_ExecuteExtensionCommand>(lpVtbl->ExecuteExtensionCommand)((ID3D12VideoProcessCommandList2*)Unsafe.AsPointer(ref this), pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public IntPtr SetName;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetDevice;

            [NativeTypeName("D3D12_COMMAND_LIST_TYPE () __attribute__((stdcall))")]
            public new IntPtr GetType;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Close;

            [NativeTypeName("HRESULT (ID3D12CommandAllocator *) __attribute__((stdcall))")]
            public IntPtr Reset;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr ClearState;

            [NativeTypeName("void (UINT, const D3D12_RESOURCE_BARRIER *) __attribute__((stdcall))")]
            public IntPtr ResourceBarrier;

            [NativeTypeName("void (ID3D12Resource *, const D3D12_DISCARD_REGION *) __attribute__((stdcall))")]
            public IntPtr DiscardResource;

            [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))")]
            public IntPtr BeginQuery;

            [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))")]
            public IntPtr EndQuery;

            [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT, UINT, ID3D12Resource *, UINT64) __attribute__((stdcall))")]
            public IntPtr ResolveQueryData;

            [NativeTypeName("void (ID3D12Resource *, UINT64, D3D12_PREDICATION_OP) __attribute__((stdcall))")]
            public IntPtr SetPredication;

            [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
            public IntPtr SetMarker;

            [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
            public IntPtr BeginEvent;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr EndEvent;

            [NativeTypeName("void (ID3D12VideoProcessor *, const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS *, UINT, const D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS *) __attribute__((stdcall))")]
            public IntPtr ProcessFrames;

            [NativeTypeName("void (UINT, const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *, const D3D12_WRITEBUFFERIMMEDIATE_MODE *) __attribute__((stdcall))")]
            public IntPtr WriteBufferImmediate;

            [NativeTypeName("void (ID3D12VideoProcessor *, const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS *, UINT, const D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1 *) __attribute__((stdcall))")]
            public IntPtr ProcessFrames1;

            [NativeTypeName("void (ID3D12ProtectedResourceSession *) __attribute__((stdcall))")]
            public IntPtr SetProtectedResourceSession;

            [NativeTypeName("void (ID3D12VideoExtensionCommand *, const void *, SIZE_T) __attribute__((stdcall))")]
            public IntPtr InitializeExtensionCommand;

            [NativeTypeName("void (ID3D12VideoExtensionCommand *, const void *, SIZE_T) __attribute__((stdcall))")]
            public IntPtr ExecuteExtensionCommand;
        }
    }
}
