// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirect3DPixelShader9.xml' path='doc/member[@name="IDirect3DPixelShader9"]/*' />
[Guid("6D3BDBDC-5B02-4415-B852-CE5E8BCCB289")]
[NativeTypeName("struct IDirect3DPixelShader9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DPixelShader9 : IDirect3DPixelShader9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDirect3DPixelShader9);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DPixelShader9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DPixelShader9*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DPixelShader9*, uint>)(lpVtbl[1]))((IDirect3DPixelShader9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DPixelShader9*, uint>)(lpVtbl[2]))((IDirect3DPixelShader9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DPixelShader9.xml' path='doc/member[@name="IDirect3DPixelShader9.GetDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDevice(IDirect3DDevice9** ppDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DPixelShader9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DPixelShader9*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <include file='IDirect3DPixelShader9.xml' path='doc/member[@name="IDirect3DPixelShader9.GetFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFunction(void* param0, uint* pSizeOfData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DPixelShader9*, void*, uint*, int>)(lpVtbl[4]))((IDirect3DPixelShader9*)Unsafe.AsPointer(ref this), param0, pSizeOfData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDevice(IDirect3DDevice9** ppDevice);

        [VtblIndex(4)]
        HRESULT GetFunction(void* param0, uint* pSizeOfData);
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

        [NativeTypeName("HRESULT (void *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint*, int> GetFunction;
    }
}
