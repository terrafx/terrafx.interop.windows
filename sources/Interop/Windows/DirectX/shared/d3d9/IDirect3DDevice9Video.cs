// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirect3DDevice9Video.xml' path='doc/member[@name="IDirect3DDevice9Video"]/*' />
[Guid("26DC4561-A1EE-4AE7-96DA-118A36C0EC95")]
[NativeTypeName("struct IDirect3DDevice9Video : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DDevice9Video : IDirect3DDevice9Video.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DDevice9Video));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9Video*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9Video*, uint>)(lpVtbl[1]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9Video*, uint>)(lpVtbl[2]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DDevice9Video.xml' path='doc/member[@name="IDirect3DDevice9Video.GetContentProtectionCaps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetContentProtectionCaps([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecodeProfile, D3DCONTENTPROTECTIONCAPS* pCaps)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9Video*, Guid*, Guid*, D3DCONTENTPROTECTIONCAPS*, int>)(lpVtbl[3]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this), pCryptoType, pDecodeProfile, pCaps);
    }

    /// <include file='IDirect3DDevice9Video.xml' path='doc/member[@name="IDirect3DDevice9Video.CreateAuthenticatedChannel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateAuthenticatedChannel(D3DAUTHENTICATEDCHANNELTYPE ChannelType, IDirect3DAuthenticatedChannel9** ppAuthenticatedChannel, HANDLE* pChannelHandle)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9Video*, D3DAUTHENTICATEDCHANNELTYPE, IDirect3DAuthenticatedChannel9**, HANDLE*, int>)(lpVtbl[4]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this), ChannelType, ppAuthenticatedChannel, pChannelHandle);
    }

    /// <include file='IDirect3DDevice9Video.xml' path='doc/member[@name="IDirect3DDevice9Video.CreateCryptoSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateCryptoSession([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, HANDLE* pCryptoHandle)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, HANDLE*, int>)(lpVtbl[5]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this), pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandle);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetContentProtectionCaps([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecodeProfile, D3DCONTENTPROTECTIONCAPS* pCaps);

        [VtblIndex(4)]
        HRESULT CreateAuthenticatedChannel(D3DAUTHENTICATEDCHANNELTYPE ChannelType, IDirect3DAuthenticatedChannel9** ppAuthenticatedChannel, HANDLE* pChannelHandle);

        [VtblIndex(5)]
        HRESULT CreateCryptoSession([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, HANDLE* pCryptoHandle);
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

        [NativeTypeName("HRESULT (const GUID *, const GUID *, D3DCONTENTPROTECTIONCAPS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, D3DCONTENTPROTECTIONCAPS*, int> GetContentProtectionCaps;

        [NativeTypeName("HRESULT (D3DAUTHENTICATEDCHANNELTYPE, IDirect3DAuthenticatedChannel9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DAUTHENTICATEDCHANNELTYPE, IDirect3DAuthenticatedChannel9**, HANDLE*, int> CreateAuthenticatedChannel;

        [NativeTypeName("HRESULT (const GUID *, const GUID *, IDirect3DCryptoSession9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, IDirect3DCryptoSession9**, HANDLE*, int> CreateCryptoSession;
    }
}
