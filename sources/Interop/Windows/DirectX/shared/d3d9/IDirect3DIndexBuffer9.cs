// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirect3DIndexBuffer9.xml' path='doc/member[@name="IDirect3DIndexBuffer9"]/*' />
[Guid("7C9DD65E-D3F7-4529-ACEE-785830ACDE35")]
[NativeTypeName("struct IDirect3DIndexBuffer9 : IDirect3DResource9")]
[NativeInheritance("IDirect3DResource9")]
public unsafe partial struct IDirect3DIndexBuffer9 : IDirect3DIndexBuffer9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DIndexBuffer9));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DIndexBuffer9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DIndexBuffer9*, uint>)(lpVtbl[1]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DIndexBuffer9*, uint>)(lpVtbl[2]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirect3DResource9.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDevice(IDirect3DDevice9** ppDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DIndexBuffer9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <inheritdoc cref="IDirect3DResource9.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DIndexBuffer9*, Guid*, void*, uint, uint, int>)(lpVtbl[4]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), refguid, pData, SizeOfData, Flags);
    }

    /// <inheritdoc cref="IDirect3DResource9.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DIndexBuffer9*, Guid*, void*, uint*, int>)(lpVtbl[5]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), refguid, pData, pSizeOfData);
    }

    /// <inheritdoc cref="IDirect3DResource9.FreePrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DIndexBuffer9*, Guid*, int>)(lpVtbl[6]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), refguid);
    }

    /// <inheritdoc cref="IDirect3DResource9.SetPriority" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("DWORD")]
    public uint SetPriority([NativeTypeName("DWORD")] uint PriorityNew)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DIndexBuffer9*, uint, uint>)(lpVtbl[7]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), PriorityNew);
    }

    /// <inheritdoc cref="IDirect3DResource9.GetPriority" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("DWORD")]
    public uint GetPriority()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DIndexBuffer9*, uint>)(lpVtbl[8]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirect3DResource9.PreLoad" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void PreLoad()
    {
        ((delegate* unmanaged[MemberFunction]<IDirect3DIndexBuffer9*, void>)(lpVtbl[9]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirect3DResource9.GetType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public new D3DRESOURCETYPE GetType()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DIndexBuffer9*, D3DRESOURCETYPE>)(lpVtbl[10]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DIndexBuffer9.xml' path='doc/member[@name="IDirect3DIndexBuffer9.Lock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Lock(uint OffsetToLock, uint SizeToLock, void** ppbData, [NativeTypeName("DWORD")] uint Flags)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DIndexBuffer9*, uint, uint, void**, uint, int>)(lpVtbl[11]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), OffsetToLock, SizeToLock, ppbData, Flags);
    }

    /// <include file='IDirect3DIndexBuffer9.xml' path='doc/member[@name="IDirect3DIndexBuffer9.Unlock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Unlock()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DIndexBuffer9*, int>)(lpVtbl[12]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DIndexBuffer9.xml' path='doc/member[@name="IDirect3DIndexBuffer9.GetDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDesc(D3DINDEXBUFFER_DESC* pDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DIndexBuffer9*, D3DINDEXBUFFER_DESC*, int>)(lpVtbl[13]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), pDesc);
    }

    public interface Interface : IDirect3DResource9.Interface
    {
        [VtblIndex(11)]
        HRESULT Lock(uint OffsetToLock, uint SizeToLock, void** ppbData, [NativeTypeName("DWORD")] uint Flags);

        [VtblIndex(12)]
        HRESULT Unlock();

        [VtblIndex(13)]
        HRESULT GetDesc(D3DINDEXBUFFER_DESC* pDesc);
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

        [NativeTypeName("DWORD (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint> SetPriority;

        [NativeTypeName("DWORD () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetPriority;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> PreLoad;

        [NativeTypeName("D3DRESOURCETYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public new delegate* unmanaged[MemberFunction]<TSelf*, D3DRESOURCETYPE> GetType;

        [NativeTypeName("HRESULT (UINT, UINT, void **, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, void**, uint, int> Lock;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Unlock;

        [NativeTypeName("HRESULT (D3DINDEXBUFFER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DINDEXBUFFER_DESC*, int> GetDesc;
    }
}
