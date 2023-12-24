// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9"]/*' />
[Guid("D9771460-A695-4F26-BBD3-27B840B541CC")]
[NativeTypeName("struct IDirect3DQuery9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DQuery9 : IDirect3DQuery9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DQuery9));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DQuery9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DQuery9*, uint>)(lpVtbl[1]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DQuery9*, uint>)(lpVtbl[2]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.GetDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDevice(IDirect3DDevice9** ppDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DQuery9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.GetType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public new D3DQUERYTYPE GetType()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DQuery9*, D3DQUERYTYPE>)(lpVtbl[4]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.GetDataSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("DWORD")]
    public uint GetDataSize()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DQuery9*, uint>)(lpVtbl[5]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.Issue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Issue([NativeTypeName("DWORD")] uint dwIssueFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DQuery9*, uint, int>)(lpVtbl[6]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this), dwIssueFlags);
    }

    /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.GetData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetData(void* pData, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD")] uint dwGetDataFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DQuery9*, void*, uint, uint, int>)(lpVtbl[7]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this), pData, dwSize, dwGetDataFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDevice(IDirect3DDevice9** ppDevice);

        [VtblIndex(4)]
        D3DQUERYTYPE GetType();

        [VtblIndex(5)]
        [return: NativeTypeName("DWORD")]
        uint GetDataSize();

        [VtblIndex(6)]
        HRESULT Issue([NativeTypeName("DWORD")] uint dwIssueFlags);

        [VtblIndex(7)]
        HRESULT GetData(void* pData, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD")] uint dwGetDataFlags);
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

        [NativeTypeName("D3DQUERYTYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public new delegate* unmanaged[MemberFunction]<TSelf*, D3DQUERYTYPE> GetType;

        [NativeTypeName("DWORD () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetDataSize;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Issue;

        [NativeTypeName("HRESULT (void *, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, uint, int> GetData;
    }
}
