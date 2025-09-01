// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9"]/*' />
[Guid("FA0AB799-7A9C-48CA-8C5B-237E71A54434")]
[NativeTypeName("struct IDirect3DCryptoSession9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DCryptoSession9 : IDirect3DCryptoSession9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDirect3DCryptoSession9);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DCryptoSession9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DCryptoSession9*, uint>)(lpVtbl[1]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DCryptoSession9*, uint>)(lpVtbl[2]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.GetCertificateSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCertificateSize(uint* pCertificateSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DCryptoSession9*, uint*, int>)(lpVtbl[3]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pCertificateSize);
    }

    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.GetCertificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCertificate(uint CertifacteSize, byte* ppCertificate)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DCryptoSession9*, uint, byte*, int>)(lpVtbl[4]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), CertifacteSize, ppCertificate);
    }

    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.NegotiateKeyExchange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT NegotiateKeyExchange(uint DataSize, void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DCryptoSession9*, uint, void*, int>)(lpVtbl[5]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), DataSize, pData);
    }

    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.EncryptionBlt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EncryptionBlt(IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, void* pIV)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)(lpVtbl[6]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pSrcSurface, pDstSurface, DstSurfaceSize, pIV);
    }

    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.DecryptionBlt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DecryptionBlt(IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, D3DENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo, void* pContentKey, void* pIV)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, D3DENCRYPTED_BLOCK_INFO*, void*, void*, int>)(lpVtbl[7]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
    }

    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.GetSurfacePitch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSurfacePitch(IDirect3DSurface9* pSrcSurface, uint* pSurfacePitch)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)(lpVtbl[8]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pSrcSurface, pSurfacePitch);
    }

    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.StartSessionKeyRefresh"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StartSessionKeyRefresh(void* pRandomNumber, uint RandomNumberSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DCryptoSession9*, void*, uint, int>)(lpVtbl[9]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pRandomNumber, RandomNumberSize);
    }

    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.FinishSessionKeyRefresh"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FinishSessionKeyRefresh()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DCryptoSession9*, int>)(lpVtbl[10]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.GetEncryptionBltKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetEncryptionBltKey(void* pReadbackKey, uint KeySize)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DCryptoSession9*, void*, uint, int>)(lpVtbl[11]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pReadbackKey, KeySize);
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
        HRESULT EncryptionBlt(IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, void* pIV);

        [VtblIndex(7)]
        HRESULT DecryptionBlt(IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, D3DENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo, void* pContentKey, void* pIV);

        [VtblIndex(8)]
        HRESULT GetSurfacePitch(IDirect3DSurface9* pSrcSurface, uint* pSurfacePitch);

        [VtblIndex(9)]
        HRESULT StartSessionKeyRefresh(void* pRandomNumber, uint RandomNumberSize);

        [VtblIndex(10)]
        HRESULT FinishSessionKeyRefresh();

        [VtblIndex(11)]
        HRESULT GetEncryptionBltKey(void* pReadbackKey, uint KeySize);
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

        [NativeTypeName("HRESULT (IDirect3DSurface9 *, IDirect3DSurface9 *, UINT, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int> EncryptionBlt;

        [NativeTypeName("HRESULT (IDirect3DSurface9 *, IDirect3DSurface9 *, UINT, D3DENCRYPTED_BLOCK_INFO *, void *, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface9*, IDirect3DSurface9*, uint, D3DENCRYPTED_BLOCK_INFO*, void*, void*, int> DecryptionBlt;

        [NativeTypeName("HRESULT (IDirect3DSurface9 *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface9*, uint*, int> GetSurfacePitch;

        [NativeTypeName("HRESULT (void *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, int> StartSessionKeyRefresh;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> FinishSessionKeyRefresh;

        [NativeTypeName("HRESULT (void *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, int> GetEncryptionBltKey;
    }
}
