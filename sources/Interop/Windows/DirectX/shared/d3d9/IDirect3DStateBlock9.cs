// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirect3DStateBlock9.xml' path='doc/member[@name="IDirect3DStateBlock9"]/*' />
[Guid("B07C4FE5-310D-4BA8-A23C-4F0F206F218B")]
[NativeTypeName("struct IDirect3DStateBlock9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DStateBlock9 : IDirect3DStateBlock9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DStateBlock9));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DStateBlock9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DStateBlock9*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DStateBlock9*, uint>)(lpVtbl[1]))((IDirect3DStateBlock9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DStateBlock9*, uint>)(lpVtbl[2]))((IDirect3DStateBlock9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DStateBlock9.xml' path='doc/member[@name="IDirect3DStateBlock9.GetDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDevice(IDirect3DDevice9** ppDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DStateBlock9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DStateBlock9*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <include file='IDirect3DStateBlock9.xml' path='doc/member[@name="IDirect3DStateBlock9.Capture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Capture()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DStateBlock9*, int>)(lpVtbl[4]))((IDirect3DStateBlock9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DStateBlock9.xml' path='doc/member[@name="IDirect3DStateBlock9.Apply"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Apply()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DStateBlock9*, int>)(lpVtbl[5]))((IDirect3DStateBlock9*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDevice(IDirect3DDevice9** ppDevice);

        [VtblIndex(4)]
        HRESULT Capture();

        [VtblIndex(5)]
        HRESULT Apply();
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

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Capture;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Apply;
    }
}
