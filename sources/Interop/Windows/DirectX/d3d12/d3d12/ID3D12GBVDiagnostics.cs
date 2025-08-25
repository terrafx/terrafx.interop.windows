// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics"]/*' />
[Guid("597985AB-9B75-4DBB-BE23-0761195BEBEE")]
[NativeTypeName("struct ID3D12GBVDiagnostics : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12GBVDiagnostics : ID3D12GBVDiagnostics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12GBVDiagnostics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12GBVDiagnostics*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12GBVDiagnostics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12GBVDiagnostics*, uint>)(lpVtbl[1]))((ID3D12GBVDiagnostics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12GBVDiagnostics*, uint>)(lpVtbl[2]))((ID3D12GBVDiagnostics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GetGBVEntireSubresourceStatesData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetGBVEntireSubresourceStatesData(ID3D12Resource* pResource, int* pData, uint DataSize)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, uint, int>)(lpVtbl[3]))((ID3D12GBVDiagnostics*)Unsafe.AsPointer(ref this), pResource, pData, DataSize);
    }

    /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GetGBVSubresourceState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGBVSubresourceState(ID3D12Resource* pResource, uint Subresource, int* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12GBVDiagnostics*, ID3D12Resource*, uint, int*, int>)(lpVtbl[4]))((ID3D12GBVDiagnostics*)Unsafe.AsPointer(ref this), pResource, Subresource, pData);
    }

    /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GetGBVResourceUniformState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetGBVResourceUniformState(ID3D12Resource* pResource, int* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, int>)(lpVtbl[5]))((ID3D12GBVDiagnostics*)Unsafe.AsPointer(ref this), pResource, pData);
    }

    /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GetGBVResourceInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetGBVResourceInfo(ID3D12Resource* pResource, D3D12_RESOURCE_DESC* pResourceDesc, [NativeTypeName("UINT32 *")] uint* pResourceHash, [NativeTypeName("UINT32 *")] uint* pSubresourceStatesByteOffset)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12GBVDiagnostics*, ID3D12Resource*, D3D12_RESOURCE_DESC*, uint*, uint*, int>)(lpVtbl[6]))((ID3D12GBVDiagnostics*)Unsafe.AsPointer(ref this), pResource, pResourceDesc, pResourceHash, pSubresourceStatesByteOffset);
    }

    /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GBVReserved0"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GBVReserved0()
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12GBVDiagnostics*, void>)(lpVtbl[7]))((ID3D12GBVDiagnostics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GBVReserved1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GBVReserved1()
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12GBVDiagnostics*, void>)(lpVtbl[8]))((ID3D12GBVDiagnostics*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetGBVEntireSubresourceStatesData(ID3D12Resource* pResource, int* pData, uint DataSize);

        [VtblIndex(4)]
        HRESULT GetGBVSubresourceState(ID3D12Resource* pResource, uint Subresource, int* pData);

        [VtblIndex(5)]
        HRESULT GetGBVResourceUniformState(ID3D12Resource* pResource, int* pData);

        [VtblIndex(6)]
        HRESULT GetGBVResourceInfo(ID3D12Resource* pResource, D3D12_RESOURCE_DESC* pResourceDesc, [NativeTypeName("UINT32 *")] uint* pResourceHash, [NativeTypeName("UINT32 *")] uint* pSubresourceStatesByteOffset);

        [VtblIndex(7)]
        void GBVReserved0();

        [VtblIndex(8)]
        void GBVReserved1();
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

        [NativeTypeName("HRESULT (ID3D12Resource *, int *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12Resource*, int*, uint, int> GetGBVEntireSubresourceStatesData;

        [NativeTypeName("HRESULT (ID3D12Resource *, UINT, int *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12Resource*, uint, int*, int> GetGBVSubresourceState;

        [NativeTypeName("HRESULT (ID3D12Resource *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12Resource*, int*, int> GetGBVResourceUniformState;

        [NativeTypeName("HRESULT (ID3D12Resource *, D3D12_RESOURCE_DESC *, UINT32 *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12Resource*, D3D12_RESOURCE_DESC*, uint*, uint*, int> GetGBVResourceInfo;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> GBVReserved0;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> GBVReserved1;
    }
}
