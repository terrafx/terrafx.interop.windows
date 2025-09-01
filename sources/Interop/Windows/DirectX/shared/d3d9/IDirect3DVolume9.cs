// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9"]/*' />
[Guid("24F416E6-1F67-4AA7-B88E-D33F6F3128A1")]
[NativeTypeName("struct IDirect3DVolume9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DVolume9 : IDirect3DVolume9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDirect3DVolume9);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolume9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolume9*, uint>)(lpVtbl[1]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolume9*, uint>)(lpVtbl[2]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.GetDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDevice(IDirect3DDevice9** ppDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolume9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.SetPrivateData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)(lpVtbl[4]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), refguid, pData, SizeOfData, Flags);
    }

    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.GetPrivateData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolume9*, Guid*, void*, uint*, int>)(lpVtbl[5]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), refguid, pData, pSizeOfData);
    }

    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.FreePrivateData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolume9*, Guid*, int>)(lpVtbl[6]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), refguid);
    }

    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.GetContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetContainer([NativeTypeName("const IID &")] Guid* riid, void** ppContainer)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolume9*, Guid*, void**, int>)(lpVtbl[7]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), riid, ppContainer);
    }

    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.GetDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDesc(D3DVOLUME_DESC* pDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolume9*, D3DVOLUME_DESC*, int>)(lpVtbl[8]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.LockBox"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT LockBox(D3DLOCKED_BOX* pLockedVolume, [NativeTypeName("const D3DBOX *")] D3DBOX* pBox, [NativeTypeName("DWORD")] uint Flags)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolume9*, D3DLOCKED_BOX*, D3DBOX*, uint, int>)(lpVtbl[9]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), pLockedVolume, pBox, Flags);
    }

    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.UnlockBox"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT UnlockBox()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DVolume9*, int>)(lpVtbl[10]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDevice(IDirect3DDevice9** ppDevice);

        [VtblIndex(4)]
        HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags);

        [VtblIndex(5)]
        HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData);

        [VtblIndex(6)]
        HRESULT FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid);

        [VtblIndex(7)]
        HRESULT GetContainer([NativeTypeName("const IID &")] Guid* riid, void** ppContainer);

        [VtblIndex(8)]
        HRESULT GetDesc(D3DVOLUME_DESC* pDesc);

        [VtblIndex(9)]
        HRESULT LockBox(D3DLOCKED_BOX* pLockedVolume, [NativeTypeName("const D3DBOX *")] D3DBOX* pBox, [NativeTypeName("DWORD")] uint Flags);

        [VtblIndex(10)]
        HRESULT UnlockBox();
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

        [NativeTypeName("HRESULT (IDirect3DDevice9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DDevice9**, int> GetDevice;

        [NativeTypeName("HRESULT (const GUID &, const void *, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void*, uint, uint, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, void *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void*, uint*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> FreePrivateData;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetContainer;

        [NativeTypeName("HRESULT (D3DVOLUME_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DVOLUME_DESC*, int> GetDesc;

        [NativeTypeName("HRESULT (D3DLOCKED_BOX *, const D3DBOX *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DLOCKED_BOX*, D3DBOX*, uint, int> LockBox;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> UnlockBox;
    }
}
