// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12VideoProcessor2.xml' path='doc/member[@name="ID3D12VideoProcessor2"]/*' />
[Guid("A24FDD6B-A2E2-41E4-9EA7-F435E4B03751")]
[NativeTypeName("struct ID3D12VideoProcessor2 : ID3D12VideoProcessor1")]
[NativeInheritance("ID3D12VideoProcessor1")]
public unsafe partial struct ID3D12VideoProcessor2 : ID3D12VideoProcessor2.Interface, INativeGuid
{
    /// <include file='ID3D12VideoProcessor2.xml' path='doc/member[@name="ID3D12VideoProcessor2.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12VideoProcessor2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoProcessor2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12VideoProcessor2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoProcessor2*, uint>)(lpVtbl[1]))((ID3D12VideoProcessor2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoProcessor2*, uint>)(lpVtbl[2]))((ID3D12VideoProcessor2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12Object.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoProcessor2*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12VideoProcessor2*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoProcessor2*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12VideoProcessor2*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoProcessor2*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12VideoProcessor2*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] char* Name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoProcessor2*, char*, int>)(lpVtbl[6]))((ID3D12VideoProcessor2*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoProcessor2*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12VideoProcessor2*)Unsafe.AsPointer(ref this), riid, ppvDevice);
    }

    /// <inheritdoc cref="ID3D12VideoProcessor.GetNodeMask" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public uint GetNodeMask()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoProcessor2*, uint>)(lpVtbl[8]))((ID3D12VideoProcessor2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12VideoProcessor.GetNumInputStreamDescs" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public uint GetNumInputStreamDescs()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoProcessor2*, uint>)(lpVtbl[9]))((ID3D12VideoProcessor2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12VideoProcessor.GetInputStreamDescs" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetInputStreamDescs(uint NumInputStreamDescs, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoProcessor2*, uint, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC*, int>)(lpVtbl[10]))((ID3D12VideoProcessor2*)Unsafe.AsPointer(ref this), NumInputStreamDescs, pInputStreamDescs);
    }

    /// <inheritdoc cref="ID3D12VideoProcessor.GetOutputStreamDesc" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC GetOutputStreamDesc()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoProcessor2*, D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC>)(lpVtbl[11]))((ID3D12VideoProcessor2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12VideoProcessor1.GetProtectedResourceSession" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetProtectedResourceSession([NativeTypeName("const IID &")] Guid* riid, void** ppProtectedSession)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoProcessor2*, Guid*, void**, int>)(lpVtbl[12]))((ID3D12VideoProcessor2*)Unsafe.AsPointer(ref this), riid, ppProtectedSession);
    }

    /// <include file='ID3D12VideoProcessor2.xml' path='doc/member[@name="ID3D12VideoProcessor2.GetInputStreamDescs1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetInputStreamDescs1(uint NumInputStreamDescs, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1* pInputStreamDescs)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoProcessor2*, uint, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1*, int>)(lpVtbl[13]))((ID3D12VideoProcessor2*)Unsafe.AsPointer(ref this), NumInputStreamDescs, pInputStreamDescs);
    }

    public interface Interface : ID3D12VideoProcessor1.Interface
    {
        [VtblIndex(13)]
        HRESULT GetInputStreamDescs1(uint NumInputStreamDescs, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1* pInputStreamDescs);
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

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetNodeMask;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetNumInputStreamDescs;

        [NativeTypeName("HRESULT (UINT, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC*, int> GetInputStreamDescs;

        [NativeTypeName("D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC> GetOutputStreamDesc;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetProtectedResourceSession;

        [NativeTypeName("HRESULT (UINT, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1*, int> GetInputStreamDescs1;
    }
}
