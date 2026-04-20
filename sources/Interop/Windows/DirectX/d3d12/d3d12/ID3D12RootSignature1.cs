// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.619.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12RootSignature1.xml' path='doc/member[@name="ID3D12RootSignature1"]/*' />
[Guid("C390BD7D-9142-4A95-B072-6D3439ADE5C4")]
[NativeTypeName("struct ID3D12RootSignature1 : ID3D12RootSignature")]
[NativeInheritance("ID3D12RootSignature")]
public unsafe partial struct ID3D12RootSignature1 : ID3D12RootSignature1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12RootSignature1);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12RootSignature1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12RootSignature1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12RootSignature1*, uint>)(lpVtbl[1]))((ID3D12RootSignature1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12RootSignature1*, uint>)(lpVtbl[2]))((ID3D12RootSignature1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12Object.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12RootSignature1*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12RootSignature1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12RootSignature1*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12RootSignature1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12RootSignature1*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12RootSignature1*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] char* Name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12RootSignature1*, char*, int>)(lpVtbl[6]))((ID3D12RootSignature1*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12RootSignature1*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12RootSignature1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
    }

    /// <include file='ID3D12RootSignature1.xml' path='doc/member[@name="ID3D12RootSignature1.GetSerializedSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetSerializedSize()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12RootSignature1*, nuint>)(lpVtbl[8]))((ID3D12RootSignature1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12RootSignature1.xml' path='doc/member[@name="ID3D12RootSignature1.GetSerializedData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSerializedData(void* pData, [NativeTypeName("SIZE_T")] nuint Size)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12RootSignature1*, void*, nuint, int>)(lpVtbl[9]))((ID3D12RootSignature1*)Unsafe.AsPointer(ref this), pData, Size);
    }

    public interface Interface : ID3D12RootSignature.Interface
    {
        [VtblIndex(8)]
        [return: NativeTypeName("SIZE_T")]
        nuint GetSerializedSize();

        [VtblIndex(9)]
        HRESULT GetSerializedData(void* pData, [NativeTypeName("SIZE_T")] nuint Size);
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

        [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint> GetSerializedSize;

        [NativeTypeName("HRESULT (void *, SIZE_T) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, nuint, int> GetSerializedData;
    }
}
