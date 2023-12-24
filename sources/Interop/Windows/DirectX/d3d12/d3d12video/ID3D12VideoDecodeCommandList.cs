// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList"]/*' />
[Guid("3B60536E-AD29-4E64-A269-F853837E5E53")]
[NativeTypeName("struct ID3D12VideoDecodeCommandList : ID3D12CommandList")]
[NativeInheritance("ID3D12CommandList")]
public unsafe partial struct ID3D12VideoDecodeCommandList : ID3D12VideoDecodeCommandList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12VideoDecodeCommandList));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, uint>)(lpVtbl[1]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, uint>)(lpVtbl[2]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12Object.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] char* Name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, char*, int>)(lpVtbl[6]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), riid, ppvDevice);
    }

    /// <inheritdoc cref="ID3D12CommandList.GetType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public new D3D12_COMMAND_LIST_TYPE GetType()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, D3D12_COMMAND_LIST_TYPE>)(lpVtbl[8]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.Close"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, int>)(lpVtbl[9]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Reset(ID3D12CommandAllocator* pAllocator)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, ID3D12CommandAllocator*, int>)(lpVtbl[10]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), pAllocator);
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.ClearState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void ClearState()
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, void>)(lpVtbl[11]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.ResourceBarrier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12_RESOURCE_BARRIER* pBarriers)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, uint, D3D12_RESOURCE_BARRIER*, void>)(lpVtbl[12]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), NumBarriers, pBarriers);
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.DiscardResource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void DiscardResource(ID3D12Resource* pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12_DISCARD_REGION* pRegion)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, ID3D12Resource*, D3D12_DISCARD_REGION*, void>)(lpVtbl[13]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), pResource, pRegion);
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.BeginQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void BeginQuery(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, uint Index)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void>)(lpVtbl[14]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.EndQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void EndQuery(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, uint Index)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void>)(lpVtbl[15]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.ResolveQueryData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, uint, ID3D12Resource*, ulong, void>)(lpVtbl[16]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.SetPredication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void SetPredication(ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, ID3D12Resource*, ulong, D3D12_PREDICATION_OP, void>)(lpVtbl[17]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), pBuffer, AlignedBufferOffset, Operation);
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.SetMarker"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, uint, void*, uint, void>)(lpVtbl[18]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.BeginEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, uint, void*, uint, void>)(lpVtbl[19]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.EndEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void EndEvent()
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, void>)(lpVtbl[20]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.DecodeFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void DecodeFrame(ID3D12VideoDecoder* pDecoder, [NativeTypeName("const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS *")] D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS* pOutputArguments, [NativeTypeName("const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *")] D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS* pInputArguments)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, ID3D12VideoDecoder*, D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS*, D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS*, void>)(lpVtbl[21]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), pDecoder, pOutputArguments, pInputArguments);
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.WriteBufferImmediate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void WriteBufferImmediate(uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER* pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] D3D12_WRITEBUFFERIMMEDIATE_MODE* pModes)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12VideoDecodeCommandList*, uint, D3D12_WRITEBUFFERIMMEDIATE_PARAMETER*, D3D12_WRITEBUFFERIMMEDIATE_MODE*, void>)(lpVtbl[22]))((ID3D12VideoDecodeCommandList*)Unsafe.AsPointer(ref this), Count, pParams, pModes);
    }

    public interface Interface : ID3D12CommandList.Interface
    {
        [VtblIndex(9)]
        HRESULT Close();

        [VtblIndex(10)]
        HRESULT Reset(ID3D12CommandAllocator* pAllocator);

        [VtblIndex(11)]
        void ClearState();

        [VtblIndex(12)]
        void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12_RESOURCE_BARRIER* pBarriers);

        [VtblIndex(13)]
        void DiscardResource(ID3D12Resource* pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12_DISCARD_REGION* pRegion);

        [VtblIndex(14)]
        void BeginQuery(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, uint Index);

        [VtblIndex(15)]
        void EndQuery(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, uint Index);

        [VtblIndex(16)]
        void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset);

        [VtblIndex(17)]
        void SetPredication(ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation);

        [VtblIndex(18)]
        void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size);

        [VtblIndex(19)]
        void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size);

        [VtblIndex(20)]
        void EndEvent();

        [VtblIndex(21)]
        void DecodeFrame(ID3D12VideoDecoder* pDecoder, [NativeTypeName("const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS *")] D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS* pOutputArguments, [NativeTypeName("const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *")] D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS* pInputArguments);

        [VtblIndex(22)]
        void WriteBufferImmediate(uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER* pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] D3D12_WRITEBUFFERIMMEDIATE_MODE* pModes);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetName;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetDevice;

        [NativeTypeName("D3D12_COMMAND_LIST_TYPE () __attribute__((stdcall))")]
        public new delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMMAND_LIST_TYPE> GetType;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Close;

        [NativeTypeName("HRESULT (ID3D12CommandAllocator *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12CommandAllocator*, int> Reset;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> ClearState;

        [NativeTypeName("void (UINT, const D3D12_RESOURCE_BARRIER *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3D12_RESOURCE_BARRIER*, void> ResourceBarrier;

        [NativeTypeName("void (ID3D12Resource *, const D3D12_DISCARD_REGION *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12Resource*, D3D12_DISCARD_REGION*, void> DiscardResource;

        [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void> BeginQuery;

        [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void> EndQuery;

        [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT, UINT, ID3D12Resource *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, uint, ID3D12Resource*, ulong, void> ResolveQueryData;

        [NativeTypeName("void (ID3D12Resource *, UINT64, D3D12_PREDICATION_OP) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12Resource*, ulong, D3D12_PREDICATION_OP, void> SetPredication;

        [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, uint, void> SetMarker;

        [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, uint, void> BeginEvent;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> EndEvent;

        [NativeTypeName("void (ID3D12VideoDecoder *, const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS *, const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12VideoDecoder*, D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS*, D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS*, void> DecodeFrame;

        [NativeTypeName("void (UINT, const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *, const D3D12_WRITEBUFFERIMMEDIATE_MODE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3D12_WRITEBUFFERIMMEDIATE_PARAMETER*, D3D12_WRITEBUFFERIMMEDIATE_MODE*, void> WriteBufferImmediate;
    }
}
