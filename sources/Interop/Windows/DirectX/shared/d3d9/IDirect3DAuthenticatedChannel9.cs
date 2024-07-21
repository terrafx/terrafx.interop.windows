// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9"]/*' />
[Guid("FF24BEEE-DA21-4BEB-98B5-D2F899F98AF9")]
[NativeTypeName("struct IDirect3DAuthenticatedChannel9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DAuthenticatedChannel9 : IDirect3DAuthenticatedChannel9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DAuthenticatedChannel9));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DAuthenticatedChannel9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DAuthenticatedChannel9*, uint>)(lpVtbl[1]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DAuthenticatedChannel9*, uint>)(lpVtbl[2]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.GetCertificateSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCertificateSize(uint* pCertificateSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DAuthenticatedChannel9*, uint*, int>)(lpVtbl[3]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), pCertificateSize);
    }

    /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.GetCertificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCertificate(uint CertifacteSize, byte* ppCertificate)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DAuthenticatedChannel9*, uint, byte*, int>)(lpVtbl[4]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), CertifacteSize, ppCertificate);
    }

    /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.NegotiateKeyExchange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT NegotiateKeyExchange(uint DataSize, void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DAuthenticatedChannel9*, uint, void*, int>)(lpVtbl[5]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), DataSize, pData);
    }

    /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.Query"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Query(uint InputSize, [NativeTypeName("const void *")] void* pInput, uint OutputSize, void* pOutput)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DAuthenticatedChannel9*, uint, void*, uint, void*, int>)(lpVtbl[6]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), InputSize, pInput, OutputSize, pOutput);
    }

    /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.Configure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Configure(uint InputSize, [NativeTypeName("const void *")] void* pInput, D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT* pOutput)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DAuthenticatedChannel9*, uint, void*, D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT*, int>)(lpVtbl[7]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), InputSize, pInput, pOutput);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCertificateSize(uint* pCertificateSize);

        [VtblIndex(4)]
        HRESULT GetCertificate(uint CertifacteSize, byte* ppCertificate);

        [VtblIndex(5)]
        HRESULT NegotiateKeyExchange(uint DataSize, void* pData);

        [VtblIndex(6)]
        HRESULT Query(uint InputSize, [NativeTypeName("const void *")] void* pInput, uint OutputSize, void* pOutput);

        [VtblIndex(7)]
        HRESULT Configure(uint InputSize, [NativeTypeName("const void *")] void* pInput, D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT* pOutput);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetCertificateSize;

        [NativeTypeName("HRESULT (UINT, BYTE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> GetCertificate;

        [NativeTypeName("HRESULT (UINT, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, int> NegotiateKeyExchange;

        [NativeTypeName("HRESULT (UINT, const void *, UINT, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, uint, void*, int> Query;

        [NativeTypeName("HRESULT (UINT, const void *, D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT*, int> Configure;
    }
}
