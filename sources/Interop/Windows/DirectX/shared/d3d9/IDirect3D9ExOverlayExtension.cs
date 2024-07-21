// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirect3D9ExOverlayExtension.xml' path='doc/member[@name="IDirect3D9ExOverlayExtension"]/*' />
[Guid("187AEB13-AAF5-4C59-876D-E059088C0DF8")]
[NativeTypeName("struct IDirect3D9ExOverlayExtension : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3D9ExOverlayExtension : IDirect3D9ExOverlayExtension.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3D9ExOverlayExtension));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9ExOverlayExtension*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3D9ExOverlayExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9ExOverlayExtension*, uint>)(lpVtbl[1]))((IDirect3D9ExOverlayExtension*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9ExOverlayExtension*, uint>)(lpVtbl[2]))((IDirect3D9ExOverlayExtension*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3D9ExOverlayExtension.xml' path='doc/member[@name="IDirect3D9ExOverlayExtension.CheckDeviceOverlayType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CheckDeviceOverlayType(uint Adapter, D3DDEVTYPE DevType, uint OverlayWidth, uint OverlayHeight, D3DFORMAT OverlayFormat, D3DDISPLAYMODEEX* pDisplayMode, D3DDISPLAYROTATION DisplayRotation, D3DOVERLAYCAPS* pOverlayCaps)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9ExOverlayExtension*, uint, D3DDEVTYPE, uint, uint, D3DFORMAT, D3DDISPLAYMODEEX*, D3DDISPLAYROTATION, D3DOVERLAYCAPS*, int>)(lpVtbl[3]))((IDirect3D9ExOverlayExtension*)Unsafe.AsPointer(ref this), Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, pDisplayMode, DisplayRotation, pOverlayCaps);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CheckDeviceOverlayType(uint Adapter, D3DDEVTYPE DevType, uint OverlayWidth, uint OverlayHeight, D3DFORMAT OverlayFormat, D3DDISPLAYMODEEX* pDisplayMode, D3DDISPLAYROTATION DisplayRotation, D3DOVERLAYCAPS* pOverlayCaps);
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

        [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, UINT, UINT, D3DFORMAT, D3DDISPLAYMODEEX *, D3DDISPLAYROTATION, D3DOVERLAYCAPS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DDEVTYPE, uint, uint, D3DFORMAT, D3DDISPLAYMODEEX*, D3DDISPLAYROTATION, D3DOVERLAYCAPS*, int> CheckDeviceOverlayType;
    }
}
